using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics
{
	/// <summary>Предоставляет доступ к локальным и удаленным процессам и позволяет запускать и останавливать локальные системные процессы.</summary>
	// Token: 0x0200023C RID: 572
	[DefaultEvent("Exited")]
	[Designer("System.Diagnostics.Design.ProcessDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
	[DefaultProperty("StartInfo")]
	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	[HostProtection(SecurityAction.LinkDemand, SharedState = true, Synchronization = true, ExternalProcessMgmt = true, SelfAffectingProcessMgmt = true)]
	[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
	public class Process : Component
	{
		/// <summary>Происходит, когда приложение записывает строку в свой перенаправленный поток <see cref="P:System.Diagnostics.Process.StandardOutput" />.</summary>
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x0600113D RID: 4413 RVA: 0x0004BC10 File Offset: 0x00049E10
		// (remove) Token: 0x0600113E RID: 4414 RVA: 0x0004BC48 File Offset: 0x00049E48
		[Browsable(true)]
		[MonitoringDescription("Indicates if the process component is associated with a real process.")]
		public event DataReceivedEventHandler OutputDataReceived;

		/// <summary>Происходит, когда приложение выполняет запись в свой перенаправленный поток <see cref="P:System.Diagnostics.Process.StandardError" />.</summary>
		// Token: 0x1400001A RID: 26
		// (add) Token: 0x0600113F RID: 4415 RVA: 0x0004BC80 File Offset: 0x00049E80
		// (remove) Token: 0x06001140 RID: 4416 RVA: 0x0004BCB8 File Offset: 0x00049EB8
		[MonitoringDescription("Indicates if the process component is associated with a real process.")]
		[Browsable(true)]
		public event DataReceivedEventHandler ErrorDataReceived;

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Process" />.</summary>
		// Token: 0x06001141 RID: 4417 RVA: 0x0004BCED File Offset: 0x00049EED
		public Process()
		{
			this.machineName = ".";
			this.outputStreamReadMode = Process.StreamReadMode.undefined;
			this.errorStreamReadMode = Process.StreamReadMode.undefined;
			this.m_processAccess = 2035711;
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x0004BD19 File Offset: 0x00049F19
		private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo)
		{
			this.machineName = machineName;
			this.isRemoteMachine = isRemoteMachine;
			this.processId = processId;
			this.haveProcessId = true;
			this.outputStreamReadMode = Process.StreamReadMode.undefined;
			this.errorStreamReadMode = Process.StreamReadMode.undefined;
			this.m_processAccess = 2035711;
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x0004BD56 File Offset: 0x00049F56
		[MonitoringDescription("Indicates if the process component is associated with a real process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		private bool Associated
		{
			get
			{
				return this.haveProcessId || this.haveProcessHandle;
			}
		}

		/// <summary>Получает значение, заданное связанным процессом при завершении.</summary>
		/// <returns>Код, который задал связанный процесс при завершении.</returns>
		/// <exception cref="T:System.InvalidOperationException">Процесс не был завершен.  
		/// -или- 
		/// Процесс <see cref="P:System.Diagnostics.Process.Handle" /> не является допустимым.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.ExitCode" /> процесса, выполняющегося на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x0004BD68 File Offset: 0x00049F68
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The value returned from the associated process when it terminated.")]
		public int ExitCode
		{
			get
			{
				this.EnsureState(Process.State.Exited);
				if (this.exitCode == -1 && !RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
				{
					throw new InvalidOperationException("Cannot get the exit code from a non-child process on Unix");
				}
				return this.exitCode;
			}
		}

		/// <summary>Получает значение, определяющее завершение связанного процесса.</summary>
		/// <returns>Значение <see langword="true" />, если процесс операционной системы, на который ссылается компонент <see cref="T:System.Diagnostics.Process" />, был завершен; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">С объектом не связаны никакие процессы.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удалось получить код выхода для процесса.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.HasExited" /> процесса, запущенного на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0004BD98 File Offset: 0x00049F98
		[MonitoringDescription("Indicates if the associated process has been terminated.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public bool HasExited
		{
			get
			{
				if (!this.exited)
				{
					this.EnsureState(Process.State.Associated);
					SafeProcessHandle safeProcessHandle = null;
					try
					{
						safeProcessHandle = this.GetProcessHandle(1049600, false);
						int num;
						if (safeProcessHandle.IsInvalid)
						{
							this.exited = true;
						}
						else if (NativeMethods.GetExitCodeProcess(safeProcessHandle, out num) && num != 259)
						{
							this.exited = true;
							this.exitCode = num;
						}
						else
						{
							if (!this.signaled)
							{
								ProcessWaitHandle processWaitHandle = null;
								try
								{
									processWaitHandle = new ProcessWaitHandle(safeProcessHandle);
									this.signaled = processWaitHandle.WaitOne(0, false);
								}
								finally
								{
									if (processWaitHandle != null)
									{
										processWaitHandle.Close();
									}
								}
							}
							if (this.signaled)
							{
								if (!NativeMethods.GetExitCodeProcess(safeProcessHandle, out num))
								{
									throw new Win32Exception();
								}
								this.exited = true;
								this.exitCode = num;
							}
						}
					}
					finally
					{
						this.ReleaseProcessHandle(safeProcessHandle);
					}
					if (this.exited)
					{
						this.RaiseOnExited();
					}
				}
				return this.exited;
			}
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0004BE88 File Offset: 0x0004A088
		private ProcessThreadTimes GetProcessTimes()
		{
			ProcessThreadTimes processThreadTimes = new ProcessThreadTimes();
			SafeProcessHandle safeProcessHandle = null;
			try
			{
				int access = 1024;
				if (EnvironmentHelpers.IsWindowsVistaOrAbove())
				{
					access = 4096;
				}
				safeProcessHandle = this.GetProcessHandle(access, false);
				if (safeProcessHandle.IsInvalid)
				{
					throw new InvalidOperationException(SR.GetString("Cannot process request because the process ({0}) has exited.", new object[]
					{
						this.processId.ToString(CultureInfo.CurrentCulture)
					}));
				}
				if (!NativeMethods.GetProcessTimes(safeProcessHandle, out processThreadTimes.create, out processThreadTimes.exit, out processThreadTimes.kernel, out processThreadTimes.user))
				{
					throw new Win32Exception();
				}
			}
			finally
			{
				this.ReleaseProcessHandle(safeProcessHandle);
			}
			return processThreadTimes;
		}

		/// <summary>Получает время завершения связанного процесса.</summary>
		/// <returns>Класс <see cref="T:System.DateTime" />, показывающий время завершения связанного процесса.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.ExitTime" /> процесса, запущенного на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x0004BF2C File Offset: 0x0004A12C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The time that the associated process exited.")]
		public DateTime ExitTime
		{
			get
			{
				if (!this.haveExitTime)
				{
					this.EnsureState((Process.State)20);
					this.exitTime = this.GetProcessTimes().ExitTime;
					this.haveExitTime = true;
				}
				return this.exitTime;
			}
		}

		/// <summary>Получает собственный дескриптор связанного процесса.</summary>
		/// <returns>Дескриптор, присвоенный процессу операционной системой при запуске. Система использует этот дескриптор для хранения атрибутов процесса.</returns>
		/// <exception cref="T:System.InvalidOperationException">Процесс не был запущен или был завершен. Невозможно прочитать свойство <see cref="P:System.Diagnostics.Process.Handle" />, поскольку ни один процесс не связан с этим экземпляром <see cref="T:System.Diagnostics.Process" />.  
		/// -или- 
		/// Экземпляр <see cref="T:System.Diagnostics.Process" /> был присоединен к запущенному процессу, но у вас нет необходимых разрешений для получения маркера с полными правами доступа.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.Handle" /> процесса, запущенного на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x0004BF5C File Offset: 0x0004A15C
		[MonitoringDescription("Returns the native handle for this process.   The handle is only available if the process was started using this component.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public IntPtr Handle
		{
			get
			{
				this.EnsureState(Process.State.Associated);
				return this.OpenProcessHandle(this.m_processAccess).DangerousGetHandle();
			}
		}

		/// <summary>Получает собственный дескриптор процесса.</summary>
		/// <returns>Собственный дескриптор процесса.</returns>
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x0004BF77 File Offset: 0x0004A177
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public SafeProcessHandle SafeHandle
		{
			get
			{
				this.EnsureState(Process.State.Associated);
				return this.OpenProcessHandle(this.m_processAccess);
			}
		}

		/// <summary>Получает уникальный идентификатор связанного процесса.</summary>
		/// <returns>Созданный системой уникальный идентификатор, на который ссылается этот экземпляр <see cref="T:System.Diagnostics.Process" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Свойство <see cref="P:System.Diagnostics.Process.Id" /> процесса не задано.  
		/// -или- 
		/// С этим объектом <see cref="T:System.Diagnostics.Process" /> никакие процессы не связаны.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me). Задайте для свойства <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> значение <see langword="false" />, чтобы получить доступ к этому свойству в Windows 98 и Windows Me.</exception>
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x0004BF8D File Offset: 0x0004A18D
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The unique identifier for the process.")]
		public int Id
		{
			get
			{
				this.EnsureState(Process.State.HaveId);
				return this.processId;
			}
		}

		/// <summary>Получает имя компьютера, на котором выполняется связанный процесс.</summary>
		/// <returns>Имя компьютера, на котором выполняется связанный процесс.</returns>
		/// <exception cref="T:System.InvalidOperationException">С этим объектом <see cref="T:System.Diagnostics.Process" /> никакие процессы не связаны.</exception>
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0004BF9C File Offset: 0x0004A19C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The name of the machine the running the process.")]
		public string MachineName
		{
			get
			{
				this.EnsureState(Process.State.Associated);
				return this.machineName;
			}
		}

		/// <summary>Получает или задает максимальный допустимый размер рабочего множества (в байтах) для связанного процесса.</summary>
		/// <returns>Максимальный размер рабочего множества в байтах, доступного в памяти для процесса.</returns>
		/// <exception cref="T:System.ArgumentException">Максимальный размер рабочего множества является недопустимым. Это значение должно быть больше минимального размера рабочего множества или равно ему.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удается получить сведения о рабочем множестве из ресурса связанного процесса.  
		/// -или- 
		/// Идентификатор или дескриптор процесса равен нулю, так как процесс не запущен.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.MaxWorkingSet" /> процесса, запущенного на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс <see cref="P:System.Diagnostics.Process.Id" /> недоступен.  
		/// -или- 
		/// Процесс завершен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x0004BFAC File Offset: 0x0004A1AC
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x0004BFBA File Offset: 0x0004A1BA
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The maximum amount of physical memory the process has required since it was started.")]
		public IntPtr MaxWorkingSet
		{
			get
			{
				this.EnsureWorkingSetLimits();
				return this.maxWorkingSet;
			}
			set
			{
				this.SetWorkingSetLimits(null, value);
			}
		}

		/// <summary>Возвращает или задает минимальный допустимый размер рабочего множества (в байтах) для связанного процесса.</summary>
		/// <returns>Минимальный размер рабочего множества в байтах, требуемый в памяти для процесса.</returns>
		/// <exception cref="T:System.ArgumentException">Минимальный размер рабочего множества является недопустимым. Это значение должно быть не больше максимального размера рабочего множества.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удается получить сведения о рабочем множестве из ресурса связанного процесса.  
		/// -или- 
		/// Идентификатор или дескриптор процесса равен нулю, так как процесс не запущен.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.MinWorkingSet" /> процесса, запущенного на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс <see cref="P:System.Diagnostics.Process.Id" /> недоступен.  
		/// -или- 
		/// Процесс завершен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x0004BFC9 File Offset: 0x0004A1C9
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x0004BFD7 File Offset: 0x0004A1D7
		[MonitoringDescription("The minimum amount of physical memory the process has required since it was started.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IntPtr MinWorkingSet
		{
			get
			{
				this.EnsureWorkingSetLimits();
				return this.minWorkingSet;
			}
			set
			{
				this.SetWorkingSetLimits(value, null);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x0004BFE6 File Offset: 0x0004A1E6
		private OperatingSystem OperatingSystem
		{
			get
			{
				if (this.operatingSystem == null)
				{
					this.operatingSystem = Environment.OSVersion;
				}
				return this.operatingSystem;
			}
		}

		/// <summary>Возвращает или задает общую категорию приоритета для процесса.</summary>
		/// <returns>Категория приоритета для связанного процесса, из которой вычисляется свойство <see cref="P:System.Diagnostics.Process.BasePriority" />.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удается задать или получить сведения о приоритете процесса от связанного ресурса процесса.  
		/// -или- 
		/// Идентификатор процесса или дескриптор процесса равен нулю. (Процесс не был запущен.)</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.PriorityClass" /> для процесса, запущенного на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс <see cref="P:System.Diagnostics.Process.Id" /> недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Вы задали для класса <see cref="P:System.Diagnostics.Process.PriorityClass" /> значение <see langword="AboveNormal" /> или <see langword="BelowNormal" /> при использовании Windows 98 или Windows Millennium Edition (Windows Me). Эти платформы не поддерживают такие значения для класса приоритета.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Невозможно задать класс приоритета, поскольку он не использует допустимое значение, как определено в перечислении <see cref="T:System.Diagnostics.ProcessPriorityClass" />.</exception>
		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x0004C004 File Offset: 0x0004A204
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x0004C068 File Offset: 0x0004A268
		[MonitoringDescription("The priority that the threads in the process run relative to.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ProcessPriorityClass PriorityClass
		{
			get
			{
				if (!this.havePriorityClass)
				{
					SafeProcessHandle handle = null;
					try
					{
						handle = this.GetProcessHandle(1024);
						int num = NativeMethods.GetPriorityClass(handle);
						if (num == 0)
						{
							throw new Win32Exception();
						}
						this.priorityClass = (ProcessPriorityClass)num;
						this.havePriorityClass = true;
					}
					finally
					{
						this.ReleaseProcessHandle(handle);
					}
				}
				return this.priorityClass;
			}
			set
			{
				if (!Enum.IsDefined(typeof(ProcessPriorityClass), value))
				{
					throw new InvalidEnumArgumentException("value", (int)value, typeof(ProcessPriorityClass));
				}
				SafeProcessHandle handle = null;
				try
				{
					handle = this.GetProcessHandle(512);
					if (!NativeMethods.SetPriorityClass(handle, (int)value))
					{
						throw new Win32Exception();
					}
					this.priorityClass = value;
					this.havePriorityClass = true;
				}
				finally
				{
					this.ReleaseProcessHandle(handle);
				}
			}
		}

		/// <summary>Получает права доступа на время процессора для этого процесса.</summary>
		/// <returns>Класс <see cref="T:System.TimeSpan" />, показывающий количество времени, которое процесс потратил на выполнение кода внутри ядра операционной системы.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.PrivilegedProcessorTime" /> для процесса, выполняемого на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x0004C0E8 File Offset: 0x0004A2E8
		[MonitoringDescription("The amount of CPU time the process spent inside the operating system core.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public TimeSpan PrivilegedProcessorTime
		{
			get
			{
				this.EnsureState(Process.State.IsNt);
				return this.GetProcessTimes().PrivilegedProcessorTime;
			}
		}

		/// <summary>Получает или задает свойства для передачи их методу <see cref="M:System.Diagnostics.Process.Start" /> объекта <see cref="T:System.Diagnostics.Process" />.</summary>
		/// <returns>Класс <see cref="T:System.Diagnostics.ProcessStartInfo" />, который представляет данные для запуска процесса. Эти аргументы включают имя исполняемого файла или документа, использованного для запуска процесса.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение, указывающее <see cref="P:System.Diagnostics.Process.StartInfo" />, равняется <see langword="null" />.</exception>
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x0004C0FC File Offset: 0x0004A2FC
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x0004C118 File Offset: 0x0004A318
		[MonitoringDescription("Specifies information used to start a process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		public ProcessStartInfo StartInfo
		{
			get
			{
				if (this.startInfo == null)
				{
					this.startInfo = new ProcessStartInfo(this);
				}
				return this.startInfo;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.startInfo = value;
			}
		}

		/// <summary>Получает время запуска связанного процесса.</summary>
		/// <returns>Объект, показывающий время запуска процесса. Если процесс не выполняется, возникает исключение.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.StartTime" /> для процесса, выполняемого на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс завершен.  
		/// -или- 
		/// Процесс не был запущен.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">В вызове функции Windows произошла ошибка.</exception>
		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0004C12F File Offset: 0x0004A32F
		[MonitoringDescription("The time at which the process was started.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DateTime StartTime
		{
			get
			{
				this.EnsureState(Process.State.IsNt);
				return this.GetProcessTimes().StartTime;
			}
		}

		/// <summary>Получает или задает объект, используемый для маршалинга вызовов обработчика событий, происходящих в результате события завершения процесса.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.ISynchronizeInvoke" />, используемый для маршалинга вызовов обработчика событий, возникающих в результате события <see cref="E:System.Diagnostics.Process.Exited" /> в процессе.</returns>
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0004C144 File Offset: 0x0004A344
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x0004C19E File Offset: 0x0004A39E
		[DefaultValue(null)]
		[Browsable(false)]
		[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
		public ISynchronizeInvoke SynchronizingObject
		{
			get
			{
				if (this.synchronizingObject == null && base.DesignMode)
				{
					IDesignerHost designerHost = (IDesignerHost)this.GetService(typeof(IDesignerHost));
					if (designerHost != null)
					{
						object rootComponent = designerHost.RootComponent;
						if (rootComponent != null && rootComponent is ISynchronizeInvoke)
						{
							this.synchronizingObject = (ISynchronizeInvoke)rootComponent;
						}
					}
				}
				return this.synchronizingObject;
			}
			set
			{
				this.synchronizingObject = value;
			}
		}

		/// <summary>Получает полное время процессора для этого процесса.</summary>
		/// <returns>Объект <see cref="T:System.TimeSpan" />, указывающий количество времени, потраченного процессом на загрузку ЦП. Это значение является суммой значений свойств <see cref="P:System.Diagnostics.Process.UserProcessorTime" /> и <see cref="P:System.Diagnostics.Process.PrivilegedProcessorTime" />.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.TotalProcessorTime" /> для процесса, выполняемого на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x0004C1A7 File Offset: 0x0004A3A7
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The amount of CPU time the process has used.")]
		public TimeSpan TotalProcessorTime
		{
			get
			{
				this.EnsureState(Process.State.IsNt);
				return this.GetProcessTimes().TotalProcessorTime;
			}
		}

		/// <summary>Получает пользовательское время процессора для этого процесса.</summary>
		/// <returns>Класс <see cref="T:System.TimeSpan" />, показывающий количество времени, которое связанный процесс потратил на выполнение кода внутри приложения (не внутри ядра операционной системы).</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.UserProcessorTime" /> для процесса, выполняемого на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x0004C1BB File Offset: 0x0004A3BB
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The amount of CPU time the process spent outside the operating system core.")]
		public TimeSpan UserProcessorTime
		{
			get
			{
				this.EnsureState(Process.State.IsNt);
				return this.GetProcessTimes().UserProcessorTime;
			}
		}

		/// <summary>Получает или задает значение, указывающее, следует ли вызывать событие <see cref="E:System.Diagnostics.Process.Exited" /> при прекращении процесса.</summary>
		/// <returns>Значение <see langword="true" />, если событие <see cref="E:System.Diagnostics.Process.Exited" /> должно быть вызвано при завершении связанного процесса (выход или вызов метода <see cref="M:System.Diagnostics.Process.Kill" />); в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />. Обратите внимание, что <see cref="E:System.Diagnostics.Process.Exited" /> события даже в том случае, если значение <see cref="P:System.Diagnostics.Process.EnableRaisingEvents" /> — <see langword="false" /> при завершении процесса во время или до выполнения пользователем <see cref="P:System.Diagnostics.Process.HasExited" /> проверки.</returns>
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x0004C1CF File Offset: 0x0004A3CF
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x0004C1D7 File Offset: 0x0004A3D7
		[MonitoringDescription("Whether the process component should watch for the associated process to exit, and raise the Exited event.")]
		[Browsable(false)]
		[DefaultValue(false)]
		public bool EnableRaisingEvents
		{
			get
			{
				return this.watchForExit;
			}
			set
			{
				if (value != this.watchForExit)
				{
					if (this.Associated)
					{
						if (value)
						{
							this.OpenProcessHandle();
							this.EnsureWatchingForExit();
						}
						else
						{
							this.StopWatchingForExit();
						}
					}
					this.watchForExit = value;
				}
			}
		}

		/// <summary>Получает поток, используемый для записи ввода приложения.</summary>
		/// <returns>Объект <see cref="T:System.IO.StreamWriter" />, используемый для записи стандартного входного потока приложения.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="P:System.Diagnostics.Process.StandardInput" /> Поток не был определен, так как для <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardInput" /> установлено значение <see langword="false" />.</exception>
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x0004C209 File Offset: 0x0004A409
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[MonitoringDescription("Standard input stream of the process.")]
		public StreamWriter StandardInput
		{
			get
			{
				if (this.standardInput == null)
				{
					throw new InvalidOperationException(SR.GetString("StandardIn has not been redirected."));
				}
				this.inputStreamReadMode = Process.StreamReadMode.syncMode;
				return this.standardInput;
			}
		}

		/// <summary>Получает поток, используемый для чтения текстовых выходных данных приложения.</summary>
		/// <returns>Объект <see cref="T:System.IO.StreamReader" />, используемый для чтения стандартного потока вывода приложения.</returns>
		/// <exception cref="T:System.InvalidOperationException">Поток <see cref="P:System.Diagnostics.Process.StandardOutput" /> не был определен для переадресации. Убедитесь, что для <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput" /> задано <see langword="true" />, а для <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> — <see langword="false" />.  
		/// -или- 
		/// Поток <see cref="P:System.Diagnostics.Process.StandardOutput" /> был открыт для асинхронных операций чтения с <see cref="M:System.Diagnostics.Process.BeginOutputReadLine" />.</exception>
		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x0004C230 File Offset: 0x0004A430
		[MonitoringDescription("Standard output stream of the process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public StreamReader StandardOutput
		{
			get
			{
				if (this.standardOutput == null)
				{
					throw new InvalidOperationException(SR.GetString("StandardOut has not been redirected or the process hasn't started yet."));
				}
				if (this.outputStreamReadMode == Process.StreamReadMode.undefined)
				{
					this.outputStreamReadMode = Process.StreamReadMode.syncMode;
				}
				else if (this.outputStreamReadMode != Process.StreamReadMode.syncMode)
				{
					throw new InvalidOperationException(SR.GetString("Cannot mix synchronous and asynchronous operation on process stream."));
				}
				return this.standardOutput;
			}
		}

		/// <summary>Получает поток, используемый для чтения вывода ошибок приложения.</summary>
		/// <returns>Объект <see cref="T:System.IO.StreamReader" />, используемый для чтения стандартного потока ошибок приложения.</returns>
		/// <exception cref="T:System.InvalidOperationException">Поток <see cref="P:System.Diagnostics.Process.StandardError" /> не был определен для переадресации. Убедитесь, что для <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError" /> задано <see langword="true" />, а для <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> — <see langword="false" />.  
		/// -или- 
		/// Поток <see cref="P:System.Diagnostics.Process.StandardError" /> был открыт для асинхронных операций чтения с <see cref="M:System.Diagnostics.Process.BeginErrorReadLine" />.</exception>
		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x0004C288 File Offset: 0x0004A488
		[MonitoringDescription("Standard error stream of the process.")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public StreamReader StandardError
		{
			get
			{
				if (this.standardError == null)
				{
					throw new InvalidOperationException(SR.GetString("StandardError has not been redirected."));
				}
				if (this.errorStreamReadMode == Process.StreamReadMode.undefined)
				{
					this.errorStreamReadMode = Process.StreamReadMode.syncMode;
				}
				else if (this.errorStreamReadMode != Process.StreamReadMode.syncMode)
				{
					throw new InvalidOperationException(SR.GetString("Cannot mix synchronous and asynchronous operation on process stream."));
				}
				return this.standardError;
			}
		}

		/// <summary>Происходит при завершении процесса.</summary>
		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06001160 RID: 4448 RVA: 0x0004C2DD File Offset: 0x0004A4DD
		// (remove) Token: 0x06001161 RID: 4449 RVA: 0x0004C2F6 File Offset: 0x0004A4F6
		[MonitoringDescription("If the WatchForExit property is set to true, then this event is raised when the associated process exits.")]
		[Category("Behavior")]
		public event EventHandler Exited
		{
			add
			{
				this.onExited = (EventHandler)Delegate.Combine(this.onExited, value);
			}
			remove
			{
				this.onExited = (EventHandler)Delegate.Remove(this.onExited, value);
			}
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0004C30F File Offset: 0x0004A50F
		private void ReleaseProcessHandle(SafeProcessHandle handle)
		{
			if (handle == null)
			{
				return;
			}
			if (this.haveProcessHandle && handle == this.m_processHandle)
			{
				return;
			}
			handle.Close();
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0004C32D File Offset: 0x0004A52D
		private void CompletionCallback(object context, bool wasSignaled)
		{
			this.StopWatchingForExit();
			this.RaiseOnExited();
		}

		/// <summary>Освобождает все ресурсы, используемые этим процессом.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить управляемые и неуправляемые ресурсы; значение <see langword="false" /> позволяет освободить только неуправляемые ресурсы.</param>
		// Token: 0x06001164 RID: 4452 RVA: 0x0004C33B File Offset: 0x0004A53B
		protected override void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					this.Close();
				}
				this.disposed = true;
				base.Dispose(disposing);
			}
		}

		/// <summary>Освобождает все ресурсы, связанные с этим компонентом.</summary>
		// Token: 0x06001165 RID: 4453 RVA: 0x0004C35C File Offset: 0x0004A55C
		public void Close()
		{
			if (this.Associated)
			{
				if (this.haveProcessHandle)
				{
					this.StopWatchingForExit();
					this.m_processHandle.Close();
					this.m_processHandle = null;
					this.haveProcessHandle = false;
				}
				this.haveProcessId = false;
				this.isRemoteMachine = false;
				this.machineName = ".";
				this.raisedOnExited = false;
				StreamWriter streamWriter = this.standardInput;
				this.standardInput = null;
				if (this.inputStreamReadMode == Process.StreamReadMode.undefined && streamWriter != null)
				{
					streamWriter.Close();
				}
				StreamReader streamReader = this.standardOutput;
				this.standardOutput = null;
				if (this.outputStreamReadMode == Process.StreamReadMode.undefined && streamReader != null)
				{
					streamReader.Close();
				}
				streamReader = this.standardError;
				this.standardError = null;
				if (this.errorStreamReadMode == Process.StreamReadMode.undefined && streamReader != null)
				{
					streamReader.Close();
				}
				AsyncStreamReader asyncStreamReader = this.output;
				this.output = null;
				if (this.outputStreamReadMode == Process.StreamReadMode.asyncMode && asyncStreamReader != null)
				{
					asyncStreamReader.CancelOperation();
					asyncStreamReader.Close();
				}
				asyncStreamReader = this.error;
				this.error = null;
				if (this.errorStreamReadMode == Process.StreamReadMode.asyncMode && asyncStreamReader != null)
				{
					asyncStreamReader.CancelOperation();
					asyncStreamReader.Close();
				}
				this.Refresh();
			}
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0004C46C File Offset: 0x0004A66C
		private void EnsureState(Process.State state)
		{
			if ((state & Process.State.Associated) != (Process.State)0 && !this.Associated)
			{
				throw new InvalidOperationException(SR.GetString("No process is associated with this object."));
			}
			if ((state & Process.State.HaveId) != (Process.State)0 && !this.haveProcessId)
			{
				this.EnsureState(Process.State.Associated);
				throw new InvalidOperationException(SR.GetString("Feature requires a process identifier."));
			}
			if ((state & Process.State.IsLocal) != (Process.State)0 && this.isRemoteMachine)
			{
				throw new NotSupportedException(SR.GetString("Feature is not supported for remote machines."));
			}
			if ((state & Process.State.HaveProcessInfo) != (Process.State)0)
			{
				throw new InvalidOperationException(SR.GetString("Process has exited, so the requested information is not available."));
			}
			if ((state & Process.State.Exited) != (Process.State)0)
			{
				if (!this.HasExited)
				{
					throw new InvalidOperationException(SR.GetString("Process must exit before requested information can be determined."));
				}
				if (!this.haveProcessHandle)
				{
					throw new InvalidOperationException(SR.GetString("Process was not started by this object, so requested information cannot be determined."));
				}
			}
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0004C524 File Offset: 0x0004A724
		private void EnsureWatchingForExit()
		{
			if (!this.watchingForExit)
			{
				lock (this)
				{
					if (!this.watchingForExit)
					{
						this.watchingForExit = true;
						try
						{
							this.waitHandle = new ProcessWaitHandle(this.m_processHandle);
							this.registeredWaitHandle = ThreadPool.RegisterWaitForSingleObject(this.waitHandle, new WaitOrTimerCallback(this.CompletionCallback), null, -1, true);
						}
						catch
						{
							this.watchingForExit = false;
							throw;
						}
					}
				}
			}
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0004C5BC File Offset: 0x0004A7BC
		private void EnsureWorkingSetLimits()
		{
			this.EnsureState(Process.State.IsNt);
			if (!this.haveWorkingSetLimits)
			{
				SafeProcessHandle handle = null;
				try
				{
					handle = this.GetProcessHandle(1024);
					IntPtr intPtr;
					IntPtr intPtr2;
					if (!NativeMethods.GetProcessWorkingSetSize(handle, out intPtr, out intPtr2))
					{
						throw new Win32Exception();
					}
					this.minWorkingSet = intPtr;
					this.maxWorkingSet = intPtr2;
					this.haveWorkingSetLimits = true;
				}
				finally
				{
					this.ReleaseProcessHandle(handle);
				}
			}
		}

		/// <summary>Помещает компонент <see cref="T:System.Diagnostics.Process" /> в состояние взаимодействия с работающим системным процессом, выполняющимся в специальном режиме путем включения встроенного свойства <see langword="SeDebugPrivilege" /> в данном потоке.</summary>
		// Token: 0x06001169 RID: 4457 RVA: 0x00003917 File Offset: 0x00001B17
		public static void EnterDebugMode()
		{
		}

		/// <summary>Выбирает компонент <see cref="T:System.Diagnostics.Process" /> из состояния, позволяющего ему взаимодействовать с процессами операционной системы, запущенными в специальном режиме.</summary>
		// Token: 0x0600116A RID: 4458 RVA: 0x00003917 File Offset: 0x00001B17
		public static void LeaveDebugMode()
		{
		}

		/// <summary>Возвращает новый компонент <see cref="T:System.Diagnostics.Process" />, по заданному идентификатору процесса на локальном компьютере.</summary>
		/// <param name="processId">Уникальный в системе идентификатор ресурса процесса.</param>
		/// <returns>Компонент <see cref="T:System.Diagnostics.Process" />, связанный с локальным ресурсом процесса, определенного параметром <paramref name="processId" />.</returns>
		/// <exception cref="T:System.ArgumentException">Процесс, указанный параметром <paramref name="processId" />, не выполняется. Возможно, истек срок действия идентификатора.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс не был запущен этим объектом.</exception>
		// Token: 0x0600116B RID: 4459 RVA: 0x0004C628 File Offset: 0x0004A828
		public static Process GetProcessById(int processId)
		{
			return Process.GetProcessById(processId, ".");
		}

		/// <summary>Создает массив из новых компонентов <see cref="T:System.Diagnostics.Process" /> и связывает их со всеми ресурсами процесса на локальном компьютере, для которых заданное имя процесса является общедоступным.</summary>
		/// <param name="processName">Понятное имя процесса.</param>
		/// <returns>Массив типа <see cref="T:System.Diagnostics.Process" />, представляющий ресурсы процесса, выполняющего указанное приложение или файл.</returns>
		/// <exception cref="T:System.InvalidOperationException">Существуют проблемы при доступе к API счетчиков производительности, которые используются для получения сведений о процессе. Это исключение характерно для Windows NT, Windows 2000 и Windows XP.</exception>
		// Token: 0x0600116C RID: 4460 RVA: 0x0004C635 File Offset: 0x0004A835
		public static Process[] GetProcessesByName(string processName)
		{
			return Process.GetProcessesByName(processName, ".");
		}

		/// <summary>Создает новый компонент <see cref="T:System.Diagnostics.Process" /> для каждого ресурса процесса на локальном компьютере.</summary>
		/// <returns>Массив типа <see cref="T:System.Diagnostics.Process" />, представляющий все ресурсы процесса, выполняющегося на локальном компьютере.</returns>
		// Token: 0x0600116D RID: 4461 RVA: 0x0004C642 File Offset: 0x0004A842
		public static Process[] GetProcesses()
		{
			return Process.GetProcesses(".");
		}

		/// <summary>Получает новый компонент <see cref="T:System.Diagnostics.Process" /> и связывает его с активным в данный момент процессом.</summary>
		/// <returns>Новый компонент <see cref="T:System.Diagnostics.Process" />, связанный с ресурсом выполняющегося процесса в вызывающем приложении.</returns>
		// Token: 0x0600116E RID: 4462 RVA: 0x0004C64E File Offset: 0x0004A84E
		public static Process GetCurrentProcess()
		{
			return new Process(".", false, NativeMethods.GetCurrentProcessId(), null);
		}

		/// <summary>Создает событие <see cref="E:System.Diagnostics.Process.Exited" />.</summary>
		// Token: 0x0600116F RID: 4463 RVA: 0x0004C664 File Offset: 0x0004A864
		protected void OnExited()
		{
			EventHandler eventHandler = this.onExited;
			if (eventHandler != null)
			{
				if (this.SynchronizingObject != null && this.SynchronizingObject.InvokeRequired)
				{
					this.SynchronizingObject.BeginInvoke(eventHandler, new object[]
					{
						this,
						EventArgs.Empty
					});
					return;
				}
				eventHandler(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0004C6BC File Offset: 0x0004A8BC
		private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited)
		{
			if (this.haveProcessHandle)
			{
				if (throwIfExited)
				{
					ProcessWaitHandle processWaitHandle = null;
					try
					{
						processWaitHandle = new ProcessWaitHandle(this.m_processHandle);
						if (processWaitHandle.WaitOne(0, false))
						{
							if (this.haveProcessId)
							{
								throw new InvalidOperationException(SR.GetString("Cannot process request because the process ({0}) has exited.", new object[]
								{
									this.processId.ToString(CultureInfo.CurrentCulture)
								}));
							}
							throw new InvalidOperationException(SR.GetString("Cannot process request because the process has exited."));
						}
					}
					finally
					{
						if (processWaitHandle != null)
						{
							processWaitHandle.Close();
						}
					}
				}
				return this.m_processHandle;
			}
			this.EnsureState((Process.State)3);
			SafeProcessHandle invalidHandle = SafeProcessHandle.InvalidHandle;
			IntPtr currentProcess = NativeMethods.GetCurrentProcess();
			if (!NativeMethods.DuplicateHandle(new HandleRef(this, currentProcess), new HandleRef(this, currentProcess), new HandleRef(this, currentProcess), out invalidHandle, 0, false, 3))
			{
				throw new Win32Exception();
			}
			if (throwIfExited && (access & 1024) != 0 && NativeMethods.GetExitCodeProcess(invalidHandle, out this.exitCode) && this.exitCode != 259)
			{
				throw new InvalidOperationException(SR.GetString("Cannot process request because the process ({0}) has exited.", new object[]
				{
					this.processId.ToString(CultureInfo.CurrentCulture)
				}));
			}
			return invalidHandle;
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0004C7DC File Offset: 0x0004A9DC
		private SafeProcessHandle GetProcessHandle(int access)
		{
			return this.GetProcessHandle(access, true);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0004C7E6 File Offset: 0x0004A9E6
		private SafeProcessHandle OpenProcessHandle()
		{
			return this.OpenProcessHandle(2035711);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0004C7F3 File Offset: 0x0004A9F3
		private SafeProcessHandle OpenProcessHandle(int access)
		{
			if (!this.haveProcessHandle)
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException(base.GetType().Name);
				}
				this.SetProcessHandle(this.GetProcessHandle(access));
			}
			return this.m_processHandle;
		}

		/// <summary>Удаляет любые кэшированные внутри компонента процесса сведения о связанном процессе.</summary>
		// Token: 0x06001174 RID: 4468 RVA: 0x0004C829 File Offset: 0x0004AA29
		public void Refresh()
		{
			this.threads = null;
			this.modules = null;
			this.exited = false;
			this.signaled = false;
			this.haveWorkingSetLimits = false;
			this.havePriorityClass = false;
			this.haveExitTime = false;
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0004C85C File Offset: 0x0004AA5C
		private void SetProcessHandle(SafeProcessHandle processHandle)
		{
			this.m_processHandle = processHandle;
			this.haveProcessHandle = true;
			if (this.watchForExit)
			{
				this.EnsureWatchingForExit();
			}
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0004C87A File Offset: 0x0004AA7A
		private void SetProcessId(int processId)
		{
			this.processId = processId;
			this.haveProcessId = true;
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0004C88C File Offset: 0x0004AA8C
		private void SetWorkingSetLimits(object newMin, object newMax)
		{
			this.EnsureState(Process.State.IsNt);
			SafeProcessHandle handle = null;
			try
			{
				handle = this.GetProcessHandle(1280);
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!NativeMethods.GetProcessWorkingSetSize(handle, out intPtr, out intPtr2))
				{
					throw new Win32Exception();
				}
				if (newMin != null)
				{
					intPtr = (IntPtr)newMin;
				}
				if (newMax != null)
				{
					intPtr2 = (IntPtr)newMax;
				}
				if ((long)intPtr > (long)intPtr2)
				{
					if (newMin != null)
					{
						throw new ArgumentException(SR.GetString("Minimum working set size is invalid. It must be less than or equal to the maximum working set size."));
					}
					throw new ArgumentException(SR.GetString("Maximum working set size is invalid. It must be greater than or equal to the minimum working set size."));
				}
				else
				{
					if (!NativeMethods.SetProcessWorkingSetSize(handle, intPtr, intPtr2))
					{
						throw new Win32Exception();
					}
					if (!NativeMethods.GetProcessWorkingSetSize(handle, out intPtr, out intPtr2))
					{
						throw new Win32Exception();
					}
					this.minWorkingSet = intPtr;
					this.maxWorkingSet = intPtr2;
					this.haveWorkingSetLimits = true;
				}
			}
			finally
			{
				this.ReleaseProcessHandle(handle);
			}
		}

		/// <summary>Запускает (или повторно использует) ресурс процесса, определенный свойством <see cref="P:System.Diagnostics.Process.StartInfo" /> этого компонента <see cref="T:System.Diagnostics.Process" />, и связывает его с компонентом.</summary>
		/// <returns>Значение <see langword="true" />, если ресурс процесса запущен; значение <see langword="false" />, если новый ресурс процесса не был запущен (например, при повторном использовании существующего процесса).</returns>
		/// <exception cref="T:System.InvalidOperationException">Имя файла не было указано в свойстве <see cref="P:System.Diagnostics.Process.StartInfo" /> компонента <see cref="T:System.Diagnostics.Process" />.
		///
		/// или- Член <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> свойства <see cref="P:System.Diagnostics.Process.StartInfo" /> имеет значение <see langword="true" />, тогда как <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardInput" />, <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput" /> или <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError" /> имеет значение <see langword="true" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при открытии связанного файла.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект процесса уже удален.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Метод не поддерживается в операционных системах без поддержки оболочки, таких как Nano Server (только в .NET Core).</exception>
		// Token: 0x06001178 RID: 4472 RVA: 0x0004C958 File Offset: 0x0004AB58
		public bool Start()
		{
			this.Close();
			ProcessStartInfo processStartInfo = this.StartInfo;
			if (processStartInfo.FileName.Length == 0)
			{
				throw new InvalidOperationException(SR.GetString("Cannot start process because a file name has not been provided."));
			}
			if (processStartInfo.UseShellExecute)
			{
				return this.StartWithShellExecuteEx(processStartInfo);
			}
			return this.StartWithCreateProcess(processStartInfo);
		}

		/// <summary>Запускает ресурс процесса путем указания имени приложения, имени пользователя, пароля и домена и связывает ресурс с новым компонентом <see cref="T:System.Diagnostics.Process" />.</summary>
		/// <param name="fileName">Имя файла приложения для запуска в процессе.</param>
		/// <param name="userName">Имя пользователя, используемое при запуске процесса.</param>
		/// <param name="password">Объект <see cref="T:System.Security.SecureString" />, содержащий пароль для использования при запуске процесса.</param>
		/// <param name="domain">Домен, используемый при запуске процесса.</param>
		/// <returns>Новый процесс <see cref="T:System.Diagnostics.Process" />, связанный с ресурсом процесса, или <see langword="null" />, если ресурс процесса не запущен. Обратите внимание, что новый процесс, запущенный наряду с уже выполняющимися экземплярами того же процесса, будет независимым от других. Кроме того, метод Start может вернуть ненулевой тип Process, свойство <see cref="P:System.Diagnostics.Process.HasExited" /> которого равно <see langword="true" />. В этом случае запущенный процесс может активировать существующий экземпляр самого себя, а затем завершить работу.</returns>
		/// <exception cref="T:System.InvalidOperationException">Не указано имя файла.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при открытии связанного файла.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект процесса уже удален.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Метод не поддерживается в Linux или macOS (только в .NET Core).</exception>
		// Token: 0x06001179 RID: 4473 RVA: 0x0004C9A6 File Offset: 0x0004ABA6
		public static Process Start(string fileName, string userName, SecureString password, string domain)
		{
			return Process.Start(new ProcessStartInfo(fileName)
			{
				UserName = userName,
				Password = password,
				Domain = domain,
				UseShellExecute = false
			});
		}

		/// <summary>Запускает ресурс процесса путем указания имени приложения, набора аргументов командной строки, имени пользователя, пароля и домена и связывает ресурс с новым компонентом <see cref="T:System.Diagnostics.Process" />.</summary>
		/// <param name="fileName">Имя файла приложения для запуска в процессе.</param>
		/// <param name="arguments">Аргументы командной строки для передачи при запуске процесса.</param>
		/// <param name="userName">Имя пользователя, используемое при запуске процесса.</param>
		/// <param name="password">Объект <see cref="T:System.Security.SecureString" />, содержащий пароль для использования при запуске процесса.</param>
		/// <param name="domain">Домен, используемый при запуске процесса.</param>
		/// <returns>Новый процесс <see cref="T:System.Diagnostics.Process" />, связанный с ресурсом процесса, или <see langword="null" />, если ресурс процесса не запущен. Обратите внимание, что новый процесс, запущенный наряду с уже выполняющимися экземплярами того же процесса, будет независимым от других. Кроме того, метод Start может вернуть ненулевой тип Process, свойство <see cref="P:System.Diagnostics.Process.HasExited" /> которого равно <see langword="true" />. В этом случае запущенный процесс может активировать существующий экземпляр самого себя, а затем завершить работу.</returns>
		/// <exception cref="T:System.InvalidOperationException">Не указано имя файла.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Возникла ошибка при открытии связанного файла.  
		/// -или- 
		/// Сумма длины аргументов и длины полного пути к соответствующему файлу превышает 2080. Сообщение об ошибке, связанной с этим исключением, может иметь следующую формулировку: "Область данных, переданная системному вызову, слишком мала". или "Отказано в доступе".</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект процесса уже удален.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Метод не поддерживается в Linux или macOS (только в .NET Core).</exception>
		// Token: 0x0600117A RID: 4474 RVA: 0x0004C9CF File Offset: 0x0004ABCF
		public static Process Start(string fileName, string arguments, string userName, SecureString password, string domain)
		{
			return Process.Start(new ProcessStartInfo(fileName, arguments)
			{
				UserName = userName,
				Password = password,
				Domain = domain,
				UseShellExecute = false
			});
		}

		/// <summary>Запускает ресурс процесса путем указания имени документа или файла приложения и связывает ресурс с новым компонентом <see cref="T:System.Diagnostics.Process" />.</summary>
		/// <param name="fileName">Имя документа или файла приложения для запуска в процессе.</param>
		/// <returns>Новый процесс <see cref="T:System.Diagnostics.Process" />, связанный с ресурсом процесса, или <see langword="null" />, если ресурс процесса не запущен. Обратите внимание, что новый процесс, запущенный наряду с уже выполняющимися экземплярами того же процесса, будет независимым от других. Кроме того, метод Start может вернуть ненулевой тип Process, свойство <see cref="P:System.Diagnostics.Process.HasExited" /> которого равно <see langword="true" />. В этом случае запущенный процесс может активировать существующий экземпляр самого себя, а затем завершить работу.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Возникла ошибка при открытии связанного файла.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект процесса уже удален.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Переменная среды PATH содержит строку с кавычками.</exception>
		// Token: 0x0600117B RID: 4475 RVA: 0x0004C9FA File Offset: 0x0004ABFA
		public static Process Start(string fileName)
		{
			return Process.Start(new ProcessStartInfo(fileName));
		}

		/// <summary>Запускает ресурс процесса путем указания имени приложения и набора аргументов командной строки и связывает ресурс с новым компонентом <see cref="T:System.Diagnostics.Process" />.</summary>
		/// <param name="fileName">Имя файла приложения для запуска в процессе.</param>
		/// <param name="arguments">Аргументы командной строки для передачи при запуске процесса.</param>
		/// <returns>Новый процесс <see cref="T:System.Diagnostics.Process" />, связанный с ресурсом процесса, или <see langword="null" />, если ресурс процесса не запущен. Обратите внимание, что новый процесс, запущенный наряду с уже выполняющимися экземплярами того же процесса, будет независимым от других. Кроме того, метод Start может вернуть ненулевой тип Process, свойство <see cref="P:System.Diagnostics.Process.HasExited" /> которого равно <see langword="true" />. В этом случае запущенный процесс может активировать существующий экземпляр самого себя, а затем завершить работу.</returns>
		/// <exception cref="T:System.InvalidOperationException">Значение параметра <paramref name="fileName" /> или параметра <paramref name="arguments" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Возникла ошибка при открытии связанного файла.  
		/// -или- 
		/// Сумма длины аргументов и длины полного пути к процессу превышает 2080. Сообщение об ошибке, связанной с этим исключением, может иметь следующую формулировку: "Область данных, переданная системному вызову, слишком мала". или "Отказано в доступе".</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект процесса уже удален.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Переменная среды PATH содержит строку с кавычками.</exception>
		// Token: 0x0600117C RID: 4476 RVA: 0x0004CA07 File Offset: 0x0004AC07
		public static Process Start(string fileName, string arguments)
		{
			return Process.Start(new ProcessStartInfo(fileName, arguments));
		}

		/// <summary>Запускает ресурс процесса, определенный параметром, содержащим стартовую информацию процесса (например, имя файла запускаемого процесса), и связывает ресурс с новым компонентом <see cref="T:System.Diagnostics.Process" />.</summary>
		/// <param name="startInfo">Объект <see cref="T:System.Diagnostics.ProcessStartInfo" />, который содержит информацию, использующуюся для запуска процесса, включая имя файла и все аргументы командной строки.</param>
		/// <returns>Новый процесс <see cref="T:System.Diagnostics.Process" />, связанный с ресурсом процесса, или <see langword="null" />, если ресурс процесса не запущен. Обратите внимание, что новый процесс, запущенный наряду с уже выполняющимися экземплярами того же процесса, будет независимым от других. Кроме того, метод Start может вернуть ненулевой тип Process, свойство <see cref="P:System.Diagnostics.Process.HasExited" /> которого равно <see langword="true" />. В этом случае запущенный процесс может активировать существующий экземпляр самого себя, а затем завершить работу.</returns>
		/// <exception cref="T:System.InvalidOperationException">Имя файла не было указано в свойстве <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" /> параметра <paramref name="startInfo" />.  
		/// -или- 
		/// Свойство <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> параметра<paramref name="startInfo" /> имеет значение <see langword="true" /> и <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardInput" />, <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput" /> или свойство <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError" /> также имеет значение <see langword="true" />.  
		/// -или- 
		/// Свойство <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> параметра <paramref name="startInfo" /> имеет значение <see langword="true" />, и свойство <see cref="P:System.Diagnostics.ProcessStartInfo.UserName" /> не равно <see langword="null" /> или не является пустым или свойство <see cref="P:System.Diagnostics.ProcessStartInfo.Password" /> не равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="startInfo" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект процесса уже удален.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Файл, указанный в свойстве <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" /> параметра <paramref name="startInfo" />, не найден.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Возникла ошибка при открытии связанного файла.  
		/// -или- 
		/// Сумма длины аргументов и длины полного пути к процессу превышает 2080. Сообщение об ошибке, связанной с этим исключением, может иметь следующую формулировку: "Область данных, переданная системному вызову, слишком мала". или "Отказано в доступе".</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Метод не поддерживается в операционных системах без поддержки оболочки, таких как Nano Server (только в .NET Core).</exception>
		// Token: 0x0600117D RID: 4477 RVA: 0x0004CA18 File Offset: 0x0004AC18
		public static Process Start(ProcessStartInfo startInfo)
		{
			Process process = new Process();
			if (startInfo == null)
			{
				throw new ArgumentNullException("startInfo");
			}
			process.StartInfo = startInfo;
			if (process.Start())
			{
				return process;
			}
			return null;
		}

		/// <summary>Немедленно останавливает связанный процесс.</summary>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Связанный процесс не может быть завершен.  
		/// -или- 
		/// Выполняется завершение процесса.  
		/// -или- 
		/// Связанный процесс является исполняемым файлом Win16.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь вызвать метод <see cref="M:System.Diagnostics.Process.Kill" /> для процесса, выполняющегося на удаленном компьютере. Этот метод доступен только для процессов, запущенных на локальном компьютере.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот процесс уже завершился.  
		/// -или- 
		/// С этим объектом <see cref="T:System.Diagnostics.Process" /> никакие процессы не связаны.</exception>
		// Token: 0x0600117E RID: 4478 RVA: 0x0004CA4C File Offset: 0x0004AC4C
		public void Kill()
		{
			SafeProcessHandle safeProcessHandle = null;
			try
			{
				safeProcessHandle = this.GetProcessHandle(1);
				if (!NativeMethods.TerminateProcess(safeProcessHandle, -1))
				{
					throw new Win32Exception();
				}
			}
			finally
			{
				this.ReleaseProcessHandle(safeProcessHandle);
			}
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0004CA8C File Offset: 0x0004AC8C
		private void StopWatchingForExit()
		{
			if (this.watchingForExit)
			{
				lock (this)
				{
					if (this.watchingForExit)
					{
						this.watchingForExit = false;
						this.registeredWaitHandle.Unregister(null);
						this.waitHandle.Close();
						this.waitHandle = null;
						this.registeredWaitHandle = null;
					}
				}
			}
		}

		/// <summary>Преобразует имя процесса в строку, объединенную с родительским типом компонента, если это применимо.</summary>
		/// <returns>Свойство <see cref="P:System.Diagnostics.Process.ProcessName" />, объединенное с возвращаемым значением метода <see cref="M:System.Object.ToString" /> базового компонента.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///   <see cref="M:System.Diagnostics.Process.ToString" /> не поддерживается в Windows 98.</exception>
		// Token: 0x06001180 RID: 4480 RVA: 0x0004CB00 File Offset: 0x0004AD00
		public override string ToString()
		{
			if (!this.Associated)
			{
				return base.ToString();
			}
			string text = string.Empty;
			try
			{
				text = this.ProcessName;
			}
			catch (PlatformNotSupportedException)
			{
			}
			if (text.Length != 0)
			{
				return string.Format(CultureInfo.CurrentCulture, "{0} ({1})", base.ToString(), text);
			}
			return base.ToString();
		}

		/// <summary>Дает компоненту <see cref="T:System.Diagnostics.Process" /> команду ожидать завершения связанного процесса в течение указанного времени в миллисекундах.</summary>
		/// <param name="milliseconds">Количество времени в миллисекундах для ожидания завершения связанного процесса. Максимальным является наибольшее возможное 32-битное целое число, которое представляет для операционной системы бесконечность.</param>
		/// <returns>Значение <see langword="true" />, если связанный процесс завершился; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Нет доступа к параметру ожидания.</exception>
		/// <exception cref="T:System.SystemException">Не задан <see cref="P:System.Diagnostics.Process.Id" /> процесса, и <see cref="P:System.Diagnostics.Process.Handle" />, из которого можно определить свойство <see cref="P:System.Diagnostics.Process.Id" />, не существует.  
		/// -или- 
		/// С этим объектом <see cref="T:System.Diagnostics.Process" /> никакие процессы не связаны.  
		/// -или- 
		/// Вы пытаетесь вызвать метод <see cref="M:System.Diagnostics.Process.WaitForExit(System.Int32)" /> для процесса, выполняющегося на удаленном компьютере. Этот метод доступен только для процессов, запущенных на локальном компьютере.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="milliseconds" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		// Token: 0x06001181 RID: 4481 RVA: 0x0004CB64 File Offset: 0x0004AD64
		public bool WaitForExit(int milliseconds)
		{
			SafeProcessHandle safeProcessHandle = null;
			ProcessWaitHandle processWaitHandle = null;
			bool flag;
			try
			{
				safeProcessHandle = this.GetProcessHandle(1048576, false);
				if (safeProcessHandle.IsInvalid)
				{
					flag = true;
				}
				else
				{
					processWaitHandle = new ProcessWaitHandle(safeProcessHandle);
					if (processWaitHandle.WaitOne(milliseconds, false))
					{
						flag = true;
						this.signaled = true;
					}
					else
					{
						flag = false;
						this.signaled = false;
					}
				}
				if (this.output != null && milliseconds == -1)
				{
					this.output.WaitUtilEOF();
				}
				if (this.error != null && milliseconds == -1)
				{
					this.error.WaitUtilEOF();
				}
			}
			finally
			{
				if (processWaitHandle != null)
				{
					processWaitHandle.Close();
				}
				this.ReleaseProcessHandle(safeProcessHandle);
			}
			if (flag && this.watchForExit)
			{
				this.RaiseOnExited();
			}
			return flag;
		}

		/// <summary>Дает компоненту <see cref="T:System.Diagnostics.Process" /> команду ожидать завершения связанного процесса в течение неограниченного времени.</summary>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Нет доступа к параметру ожидания.</exception>
		/// <exception cref="T:System.SystemException">Не задан <see cref="P:System.Diagnostics.Process.Id" /> процесса, и <see cref="P:System.Diagnostics.Process.Handle" />, из которого можно определить свойство <see cref="P:System.Diagnostics.Process.Id" />, не существует.  
		/// -или- 
		/// С этим объектом <see cref="T:System.Diagnostics.Process" /> никакие процессы не связаны.  
		/// -или- 
		/// Вы пытаетесь вызвать метод <see cref="M:System.Diagnostics.Process.WaitForExit" /> для процесса, выполняющегося на удаленном компьютере. Этот метод доступен только для процессов, запущенных на локальном компьютере.</exception>
		// Token: 0x06001182 RID: 4482 RVA: 0x0004CC18 File Offset: 0x0004AE18
		public void WaitForExit()
		{
			this.WaitForExit(-1);
		}

		/// <summary>Дает компоненту <see cref="T:System.Diagnostics.Process" /> команду ожидать входа связанного процесса в состояние простоя в течение указанного времени в миллисекундах. Эта перегрузка применяется только к процессам с пользовательским интерфейсом и, следовательно, с циклом сообщений.</summary>
		/// <param name="milliseconds">Значение от 1 до <see cref="F:System.Int32.MaxValue" />, определяющее количество времени в миллисекундах, в течение которого ожидается переход связанного процесса в состояние простоя. Значение "0" указывает немедленный возврат, а значение "-1" указывает неопределенно долгое ожидание.</param>
		/// <returns>Значение <see langword="true" />, если связанный процесс достиг состояния простоя; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Процесс не имеет графического интерфейса.  
		/// -или- 
		/// Произошла неизвестная ошибка. Процессу не удалось перейти в состояние бездействия.  
		/// -или- 
		/// Этот процесс уже завершился.  
		/// -или- 
		/// Нет процессов, связанных с этим объектом <see cref="T:System.Diagnostics.Process" />.</exception>
		// Token: 0x06001183 RID: 4483 RVA: 0x0004CC24 File Offset: 0x0004AE24
		public bool WaitForInputIdle(int milliseconds)
		{
			SafeProcessHandle handle = null;
			try
			{
				handle = this.GetProcessHandle(1049600);
				int num = NativeMethods.WaitForInputIdle(handle, milliseconds);
				if (num != -1)
				{
					if (num == 0)
					{
						return true;
					}
					if (num == 258)
					{
						return false;
					}
				}
				throw new InvalidOperationException(SR.GetString("WaitForInputIdle failed.  This could be because the process does not have a graphical interface."));
			}
			finally
			{
				this.ReleaseProcessHandle(handle);
			}
			bool result;
			return result;
		}

		/// <summary>Дает компоненту <see cref="T:System.Diagnostics.Process" /> команду ожидать перехода связанного процесса в состояние простоя в течение неограниченного времени. Эта перегрузка применяется только к процессам с пользовательским интерфейсом и, следовательно, с циклом сообщений.</summary>
		/// <returns>Значение <see langword="true" />, если связанный процесс достиг состояния простоя.</returns>
		/// <exception cref="T:System.InvalidOperationException">Процесс не имеет графического интерфейса.  
		/// -или- 
		/// Произошла неизвестная ошибка. Процессу не удалось перейти в состояние бездействия.  
		/// -или- 
		/// Этот процесс уже завершился.  
		/// -или- 
		/// Нет процессов, связанных с этим объектом <see cref="T:System.Diagnostics.Process" />.</exception>
		// Token: 0x06001184 RID: 4484 RVA: 0x0004CC8C File Offset: 0x0004AE8C
		public bool WaitForInputIdle()
		{
			return this.WaitForInputIdle(int.MaxValue);
		}

		/// <summary>Начинает операции асинхронного чтения с перенаправленного потока <see cref="P:System.Diagnostics.Process.StandardOutput" /> приложения.</summary>
		/// <exception cref="T:System.InvalidOperationException">Значение свойства <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput" /> — <see langword="false" />.  
		/// -или- 
		/// Асинхронная операция чтения уже выполняется в потоке <see cref="P:System.Diagnostics.Process.StandardOutput" />.  
		/// -или- 
		/// Поток <see cref="P:System.Diagnostics.Process.StandardOutput" /> используется синхронной операцией чтения.</exception>
		// Token: 0x06001185 RID: 4485 RVA: 0x0004CC9C File Offset: 0x0004AE9C
		[ComVisible(false)]
		public void BeginOutputReadLine()
		{
			if (this.outputStreamReadMode == Process.StreamReadMode.undefined)
			{
				this.outputStreamReadMode = Process.StreamReadMode.asyncMode;
			}
			else if (this.outputStreamReadMode != Process.StreamReadMode.asyncMode)
			{
				throw new InvalidOperationException(SR.GetString("Cannot mix synchronous and asynchronous operation on process stream."));
			}
			if (this.pendingOutputRead)
			{
				throw new InvalidOperationException(SR.GetString("An async read operation has already been started on the stream."));
			}
			this.pendingOutputRead = true;
			if (this.output == null)
			{
				if (this.standardOutput == null)
				{
					throw new InvalidOperationException(SR.GetString("StandardOut has not been redirected or the process hasn't started yet."));
				}
				Stream baseStream = this.standardOutput.BaseStream;
				this.output = new AsyncStreamReader(this, baseStream, new UserCallBack(this.OutputReadNotifyUser), this.standardOutput.CurrentEncoding);
			}
			this.output.BeginReadLine();
		}

		/// <summary>Начинает операции асинхронного чтения с перенаправленного потока <see cref="P:System.Diagnostics.Process.StandardError" /> приложения.</summary>
		/// <exception cref="T:System.InvalidOperationException">Значение свойства <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError" /> — <see langword="false" />.  
		/// -или- 
		/// Асинхронная операция чтения уже выполняется в потоке <see cref="P:System.Diagnostics.Process.StandardError" />.  
		/// -или- 
		/// Поток <see cref="P:System.Diagnostics.Process.StandardError" /> используется синхронной операцией чтения.</exception>
		// Token: 0x06001186 RID: 4486 RVA: 0x0004CD50 File Offset: 0x0004AF50
		[ComVisible(false)]
		public void BeginErrorReadLine()
		{
			if (this.errorStreamReadMode == Process.StreamReadMode.undefined)
			{
				this.errorStreamReadMode = Process.StreamReadMode.asyncMode;
			}
			else if (this.errorStreamReadMode != Process.StreamReadMode.asyncMode)
			{
				throw new InvalidOperationException(SR.GetString("Cannot mix synchronous and asynchronous operation on process stream."));
			}
			if (this.pendingErrorRead)
			{
				throw new InvalidOperationException(SR.GetString("An async read operation has already been started on the stream."));
			}
			this.pendingErrorRead = true;
			if (this.error == null)
			{
				if (this.standardError == null)
				{
					throw new InvalidOperationException(SR.GetString("StandardError has not been redirected."));
				}
				Stream baseStream = this.standardError.BaseStream;
				this.error = new AsyncStreamReader(this, baseStream, new UserCallBack(this.ErrorReadNotifyUser), this.standardError.CurrentEncoding);
			}
			this.error.BeginReadLine();
		}

		/// <summary>Отменяет операцию асинхронного чтения в перенаправленном потоке <see cref="P:System.Diagnostics.Process.StandardOutput" /> приложения.</summary>
		/// <exception cref="T:System.InvalidOperationException">Поток <see cref="P:System.Diagnostics.Process.StandardOutput" /> не включен для асинхронных операций чтения.</exception>
		// Token: 0x06001187 RID: 4487 RVA: 0x0004CE01 File Offset: 0x0004B001
		[ComVisible(false)]
		public void CancelOutputRead()
		{
			if (this.output != null)
			{
				this.output.CancelOperation();
				this.pendingOutputRead = false;
				return;
			}
			throw new InvalidOperationException(SR.GetString("No async read operation is in progress on the stream."));
		}

		/// <summary>Отменяет операцию асинхронного чтения в перенаправленном потоке <see cref="P:System.Diagnostics.Process.StandardError" /> приложения.</summary>
		/// <exception cref="T:System.InvalidOperationException">Поток <see cref="P:System.Diagnostics.Process.StandardError" /> не включен для асинхронных операций чтения.</exception>
		// Token: 0x06001188 RID: 4488 RVA: 0x0004CE2F File Offset: 0x0004B02F
		[ComVisible(false)]
		public void CancelErrorRead()
		{
			if (this.error != null)
			{
				this.error.CancelOperation();
				this.pendingErrorRead = false;
				return;
			}
			throw new InvalidOperationException(SR.GetString("No async read operation is in progress on the stream."));
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0004CE60 File Offset: 0x0004B060
		internal void OutputReadNotifyUser(string data)
		{
			DataReceivedEventHandler outputDataReceived = this.OutputDataReceived;
			if (outputDataReceived != null)
			{
				DataReceivedEventArgs dataReceivedEventArgs = new DataReceivedEventArgs(data);
				if (this.SynchronizingObject != null && this.SynchronizingObject.InvokeRequired)
				{
					this.SynchronizingObject.Invoke(outputDataReceived, new object[]
					{
						this,
						dataReceivedEventArgs
					});
					return;
				}
				outputDataReceived(this, dataReceivedEventArgs);
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0004CEB8 File Offset: 0x0004B0B8
		internal void ErrorReadNotifyUser(string data)
		{
			DataReceivedEventHandler errorDataReceived = this.ErrorDataReceived;
			if (errorDataReceived != null)
			{
				DataReceivedEventArgs dataReceivedEventArgs = new DataReceivedEventArgs(data);
				if (this.SynchronizingObject != null && this.SynchronizingObject.InvokeRequired)
				{
					this.SynchronizingObject.Invoke(errorDataReceived, new object[]
					{
						this,
						dataReceivedEventArgs
					});
					return;
				}
				errorDataReceived(this, dataReceivedEventArgs);
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0004CF0F File Offset: 0x0004B10F
		private Process(SafeProcessHandle handle, int id)
		{
			this.SetProcessHandle(handle);
			this.SetProcessId(id);
		}

		/// <summary>Получает базовый приоритет связанного процесса.</summary>
		/// <returns>Базовый приоритет, который вычисляется свойством <see cref="P:System.Diagnostics.Process.PriorityClass" /> связанного процесса.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me). Задайте для свойства <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> значение <see langword="false" />, чтобы получить доступ к этому свойству в Windows 98 и Windows Me.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс завершен.  
		/// -или- 
		/// Процесс не запущен, поэтому нет идентификатора процесса.</exception>
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x00003062 File Offset: 0x00001262
		[MonitoringDescription("Base process priority.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonoTODO]
		public int BasePriority
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Получает число дескрипторов, открытых процессом.</summary>
		/// <returns>Число дескрипторов операционной системы, открытых процессом.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me). Задайте для свойства <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> значение <see langword="false" />, чтобы получить доступ к этому свойству в Windows 98 и Windows Me.</exception>
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x00003062 File Offset: 0x00001262
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Handles for this process.")]
		[MonoTODO]
		public int HandleCount
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Получает главный модуль связанного процесса.</summary>
		/// <returns>Модуль <see cref="T:System.Diagnostics.ProcessModule" />, который был использован для запуска процесса.</returns>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.MainModule" /> процесса, выполняющегося на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">32-разрядный процесс пытается получить доступ к модулям 64-разрядного процесса.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me). Задайте для <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> значение <see langword="false" />, чтобы получить доступ к этому свойству в Windows 98 и Windows Me.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс <see cref="P:System.Diagnostics.Process.Id" /> недоступен.  
		/// -или- 
		/// Процесс завершен.</exception>
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x0004CF25 File Offset: 0x0004B125
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The main module of the process.")]
		[Browsable(false)]
		public ProcessModule MainModule
		{
			get
			{
				if (this.processId == NativeMethods.GetCurrentProcessId())
				{
					if (Process.current_main_module == null)
					{
						Process.current_main_module = this.Modules[0];
					}
					return Process.current_main_module;
				}
				return this.Modules[0];
			}
		}

		// Token: 0x0600118F RID: 4495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr MainWindowHandle_icall(int pid);

		/// <summary>Получает дескриптор главного окна связанного процесса.</summary>
		/// <returns>Созданный системой дескриптор главного окна связанного процесса.</returns>
		/// <exception cref="T:System.InvalidOperationException">Свойство <see cref="P:System.Diagnostics.Process.MainWindowHandle" /> не определено, так как процесс завершился.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.MainWindowHandle" /> процесса, выполняющегося на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me). Задайте для <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> значение <see langword="false" />, чтобы получить доступ к этому свойству в Windows 98 и Windows Me.</exception>
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x0004CF5E File Offset: 0x0004B15E
		[MonitoringDescription("The handle of the main window of the process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IntPtr MainWindowHandle
		{
			get
			{
				return Process.MainWindowHandle_icall(this.processId);
			}
		}

		/// <summary>Получает заголовок главного окна процесса.</summary>
		/// <returns>Заголовок главного окна процесса.</returns>
		/// <exception cref="T:System.InvalidOperationException">Свойство <see cref="P:System.Diagnostics.Process.MainWindowTitle" /> не определено, так как процесс завершился.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.MainWindowTitle" /> процесса, выполняющегося на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me). Задайте для <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> значение <see langword="false" />, чтобы получить доступ к этому свойству в Windows 98 и Windows Me.</exception>
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x000186CD File Offset: 0x000168CD
		[MonitoringDescription("The title of the main window of the process.")]
		[MonoTODO]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string MainWindowTitle
		{
			get
			{
				return "null";
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0004CF6C File Offset: 0x0004B16C
		private static void AppendArguments(StringBuilder stringBuilder, Collection<string> argumentList)
		{
			if (argumentList.Count > 0)
			{
				foreach (string argument in argumentList)
				{
					PasteArguments.AppendArgument(stringBuilder, argument);
				}
			}
		}

		// Token: 0x06001193 RID: 4499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern ProcessModule[] GetModules_icall(IntPtr handle);

		// Token: 0x06001194 RID: 4500 RVA: 0x0004CFC0 File Offset: 0x0004B1C0
		private ProcessModule[] GetModules_internal(SafeProcessHandle handle)
		{
			bool flag = false;
			ProcessModule[] modules_icall;
			try
			{
				handle.DangerousAddRef(ref flag);
				modules_icall = this.GetModules_icall(handle.DangerousGetHandle());
			}
			finally
			{
				if (flag)
				{
					handle.DangerousRelease();
				}
			}
			return modules_icall;
		}

		/// <summary>Получает модули, которые были загружены связанным процессом.</summary>
		/// <returns>Массив объектов типа <see cref="T:System.Diagnostics.ProcessModule" />, который предоставляет модули, загруженные связанным процессом.</returns>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.Modules" /> для процесса, выполняемого на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс <see cref="P:System.Diagnostics.Process.Id" /> недоступен.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me). Задайте для <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> значение <see langword="false" />, чтобы получить доступ к этому свойству в Windows 98 и Windows Me.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.Modules" /> системного или бездействующего процесса. Эти процессы не имеют модулей.</exception>
		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x0004D004 File Offset: 0x0004B204
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The modules that are loaded as part of this process.")]
		public ProcessModuleCollection Modules
		{
			get
			{
				if (this.modules == null)
				{
					SafeProcessHandle handle = null;
					try
					{
						handle = this.GetProcessHandle(1024);
						this.modules = new ProcessModuleCollection(this.GetModules_internal(handle));
					}
					finally
					{
						this.ReleaseProcessHandle(handle);
					}
				}
				return this.modules;
			}
		}

		// Token: 0x06001196 RID: 4502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long GetProcessData(int pid, int data_type, out int error);

		/// <summary>Возвращает объем невыгружаемой системной памяти в байтах, выделенной для связанного процесса.</summary>
		/// <returns>Объем памяти в байтах, выделенной системой для связанного процесса, который нельзя записать в файл подкачки виртуальной памяти.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x00003062 File Offset: 0x00001262
		[MonitoringDescription("The number of bytes that are not pageable.")]
		[Obsolete("Use NonpagedSystemMemorySize64")]
		[MonoTODO]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int NonpagedSystemMemorySize
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Возвращает объем выгружаемой системной памяти в байтах, выделенной для связанного процесса.</summary>
		/// <returns>Объем памяти в байтах, выделенной связанным процессом, который можно записать в файл подкачки виртуальной памяти.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x0004D05C File Offset: 0x0004B25C
		[Obsolete("Use PagedMemorySize64")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The number of bytes that are paged.")]
		public int PagedMemorySize
		{
			get
			{
				return (int)this.PagedMemorySize64;
			}
		}

		/// <summary>Получает объем выгружаемой системной памяти (в байтах), выделенной для связанного процесса.</summary>
		/// <returns>Объем памяти в байтах, выделенной системой для связанного процесса, который можно записать в файл подкачки виртуальной памяти.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x0004D05C File Offset: 0x0004B25C
		[Obsolete("Use PagedSystemMemorySize64")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The amount of paged system memory in bytes.")]
		public int PagedSystemMemorySize
		{
			get
			{
				return (int)this.PagedMemorySize64;
			}
		}

		/// <summary>Возвращает максимальный объем памяти в байтах в файле подкачки виртуальной памяти, используемой связанным процессом.</summary>
		/// <returns>Максимальный объем памяти в байтах, выделенной связанным процессом, который можно записать в файл подкачки виртуальной памяти.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x00003062 File Offset: 0x00001262
		[MonoTODO]
		[Obsolete("Use PeakPagedMemorySize64")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The maximum amount of paged memory used by this process.")]
		public int PeakPagedMemorySize
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Получает максимальный объем виртуальной памяти (в байтах), используемой связанным процессом.</summary>
		/// <returns>Максимальный объем виртуальной памяти в байтах, запрошенной связанным процессом.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x0004D068 File Offset: 0x0004B268
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The maximum amount of virtual memory used by this process.")]
		[Obsolete("Use PeakVirtualMemorySize64")]
		public int PeakVirtualMemorySize
		{
			get
			{
				int num;
				return (int)Process.GetProcessData(this.processId, 8, out num);
			}
		}

		/// <summary>Возвращает максимальный размер рабочего множества для связанного процесса (в байтах).</summary>
		/// <returns>Максимальный объем физической памяти, запрошенной связанным процессом одновременно (в байтах).</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x0004D084 File Offset: 0x0004B284
		[Obsolete("Use PeakWorkingSet64")]
		[MonitoringDescription("The maximum amount of system memory used by this process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int PeakWorkingSet
		{
			get
			{
				int num;
				return (int)Process.GetProcessData(this.processId, 5, out num);
			}
		}

		/// <summary>Возвращает объем невыгружаемой системной памяти в байтах, выделенной для связанного процесса.</summary>
		/// <returns>Объем системной памяти в байтах, выделенной для связанного процесса, которую нельзя записать в файл подкачки виртуальной памяти.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x0004D0A0 File Offset: 0x0004B2A0
		[ComVisible(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The number of bytes that are not pageable.")]
		[MonoTODO]
		public long NonpagedSystemMemorySize64
		{
			get
			{
				return 0L;
			}
		}

		/// <summary>Возвращает объем выгружаемой системной памяти в байтах, выделенной для связанного процесса.</summary>
		/// <returns>Объем памяти в байтах, выделенной в файле подкачки виртуальной памяти для связанного процесса.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x0004D0A4 File Offset: 0x0004B2A4
		[ComVisible(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The number of bytes that are paged.")]
		public long PagedMemorySize64
		{
			get
			{
				int num;
				return Process.GetProcessData(this.processId, 12, out num);
			}
		}

		/// <summary>Получает объем выгружаемой системной памяти (в байтах), выделенной для связанного процесса.</summary>
		/// <returns>Объем системной памяти в байтах, выделенной для связанного процесса, которую можно записать в файл подкачки виртуальной памяти.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x0004D0C0 File Offset: 0x0004B2C0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The amount of paged system memory in bytes.")]
		[ComVisible(false)]
		public long PagedSystemMemorySize64
		{
			get
			{
				return this.PagedMemorySize64;
			}
		}

		/// <summary>Возвращает максимальный объем памяти в байтах в файле подкачки виртуальной памяти, используемой связанным процессом.</summary>
		/// <returns>Максимальный объем памяти в байтах, выделенной в файле подкачки виртуальной памяти для связанного процесса с момента его запуска.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x0004D0A0 File Offset: 0x0004B2A0
		[MonitoringDescription("The maximum amount of paged memory used by this process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[ComVisible(false)]
		[MonoTODO]
		public long PeakPagedMemorySize64
		{
			get
			{
				return 0L;
			}
		}

		/// <summary>Получает максимальный объем виртуальной памяти (в байтах), используемой связанным процессом.</summary>
		/// <returns>Максимальный объем виртуальной памяти в байтах, выделенной для связанного процесса с момента его запуска.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x0004D0C8 File Offset: 0x0004B2C8
		[MonitoringDescription("The maximum amount of virtual memory used by this process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[ComVisible(false)]
		public long PeakVirtualMemorySize64
		{
			get
			{
				int num;
				return Process.GetProcessData(this.processId, 8, out num);
			}
		}

		/// <summary>Получает максимальный объем физической памяти (в байтах), используемой связанным процессом.</summary>
		/// <returns>Максимальный объем физической памяти в байтах, выделенной для связанного процесса с момента его запуска.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x0004D0E4 File Offset: 0x0004B2E4
		[ComVisible(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The maximum amount of system memory used by this process.")]
		public long PeakWorkingSet64
		{
			get
			{
				int num;
				return Process.GetProcessData(this.processId, 5, out num);
			}
		}

		/// <summary>Получает или задает значение, указывающее, должна ли операционная система временно увеличить приоритет связанного процесса, когда основное окно процесса получит фокус.</summary>
		/// <returns>Значение <see langword="true" />, если требуется динамическое увеличение приоритета процесса, когда процесс выходит из состояния ожидания; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удается получить информацию о повышении приоритета от связанного ресурса процесса.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.  
		/// -или- 
		/// Идентификатор процесса или дескриптор процесса равен нулю. (Процесс не был запущен.)</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.PriorityBoostEnabled" /> для процесса, запущенного на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс <see cref="P:System.Diagnostics.Process.Id" /> недоступен.</exception>
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00003062 File Offset: 0x00001262
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x00003917 File Offset: 0x00001B17
		[MonitoringDescription("Process will be of higher priority while it is actively used.")]
		[MonoTODO]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool PriorityBoostEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Получает объем закрытой системной памяти в байтах, выделенной для связанного процесса.</summary>
		/// <returns>Число байтов, выделенных связанным процессом, которые не могут быть доступны другим процессам.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x0004D100 File Offset: 0x0004B300
		[Obsolete("Use PrivateMemorySize64")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The amount of memory exclusively used by this process.")]
		public int PrivateMemorySize
		{
			get
			{
				int num;
				return (int)Process.GetProcessData(this.processId, 6, out num);
			}
		}

		/// <summary>Получает идентификатор сеанса служб терминалов для связанного процесса.</summary>
		/// <returns>Идентификатор сеанса служба терминалов для связанного процесса.</returns>
		/// <exception cref="T:System.NullReferenceException">С этим процессом никакие сеансы не связаны.</exception>
		/// <exception cref="T:System.InvalidOperationException">С этим идентификатором сеанса не связаны никакие процессы.  
		/// -или- 
		/// На этом компьютере нет связанного процесса.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">В Windows 98 свойство <see cref="P:System.Diagnostics.Process.SessionId" /> не поддерживается.</exception>
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00003062 File Offset: 0x00001262
		[MonoNotSupported("")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The session ID for this process.")]
		public int SessionId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060011A7 RID: 4519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string ProcessName_icall(IntPtr handle);

		// Token: 0x060011A8 RID: 4520 RVA: 0x0004D11C File Offset: 0x0004B31C
		private static string ProcessName_internal(SafeProcessHandle handle)
		{
			bool flag = false;
			string result;
			try
			{
				handle.DangerousAddRef(ref flag);
				result = Process.ProcessName_icall(handle.DangerousGetHandle());
			}
			finally
			{
				if (flag)
				{
					handle.DangerousRelease();
				}
			}
			return result;
		}

		/// <summary>Получает имя процесса.</summary>
		/// <returns>Имя, которое использует система для идентификации процесса для пользователя.</returns>
		/// <exception cref="T:System.InvalidOperationException">Процесс не имеет идентификатора, или нет процесса, связанного с <see cref="T:System.Diagnostics.Process" />.  
		/// -или- 
		/// Связанный процесс завершился.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me). Задайте для <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> значение <see langword="false" />, чтобы получить доступ к этому свойству в Windows 98 и Windows Me.</exception>
		/// <exception cref="T:System.NotSupportedException">Процесс отсутствует на этом компьютере.</exception>
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x0004D15C File Offset: 0x0004B35C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The name of this process.")]
		public string ProcessName
		{
			get
			{
				if (this.process_name == null)
				{
					SafeProcessHandle handle = null;
					try
					{
						handle = this.GetProcessHandle(1024);
						this.process_name = Process.ProcessName_internal(handle);
						if (this.process_name == null)
						{
							throw new InvalidOperationException("Process has exited or is inaccessible, so the requested information is not available.");
						}
						if (this.process_name.EndsWith(".exe") || this.process_name.EndsWith(".bat") || this.process_name.EndsWith(".com"))
						{
							this.process_name = this.process_name.Substring(0, this.process_name.Length - 4);
						}
					}
					finally
					{
						this.ReleaseProcessHandle(handle);
					}
				}
				return this.process_name;
			}
		}

		/// <summary>Получает или задает процессоры, на которых может быть запланировано выполнение потоков данного процесса.</summary>
		/// <returns>Битовая маска, представляющая процессоры, на которых могут выполняться потоки связанного процесса. По умолчанию маска зависит от числа процессоров в компьютере. Значение по умолчанию — 2 n -1, где n — число процессоров.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удается задать или получить сведения о <see cref="P:System.Diagnostics.Process.ProcessorAffinity" /> от связанного ресурса процесса.  
		/// -или- 
		/// Идентификатор процесса или дескриптор процесса равен нулю. (Процесс не был запущен.)</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.ProcessorAffinity" /> для процесса, запущенного на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс <see cref="P:System.Diagnostics.Process.Id" /> недоступен.  
		/// -или- 
		/// Процесс завершен.</exception>
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x0004D218 File Offset: 0x0004B418
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Allowed processor that can be used by this process.")]
		public IntPtr ProcessorAffinity
		{
			get
			{
				return (IntPtr)0;
			}
			set
			{
			}
		}

		/// <summary>Получает значение, указывающее, отвечает или нет пользовательский интерфейс.</summary>
		/// <returns>Значение <see langword="true" />, если пользовательский интерфейс связанного процесса отвечает системе; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me). Задайте для <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> значение <see langword="false" />, чтобы получить доступ к этому свойству в Windows 98 и Windows Me.</exception>
		/// <exception cref="T:System.InvalidOperationException">С этим объектом <see cref="T:System.Diagnostics.Process" /> никакие процессы не связаны.</exception>
		/// <exception cref="T:System.NotSupportedException">Вы пытаетесь получить доступ к свойству <see cref="P:System.Diagnostics.Process.Responding" /> для процесса, запущенного на удаленном компьютере. Это свойство доступно только для процессов, запущенных на локальном компьютере.</exception>
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00003062 File Offset: 0x00001262
		[MonitoringDescription("Is this process responsive.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonoTODO]
		public bool Responding
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает множество потоков, выполняющихся в связанном процессе.</summary>
		/// <returns>Массив объектов типа <see cref="T:System.Diagnostics.ProcessThread" />, представляющий потоки операционной системы, которые в настоящий момент выполняются в связанном процессе.</returns>
		/// <exception cref="T:System.SystemException">Процесс не имеет <see cref="P:System.Diagnostics.Process.Id" />, или нет процесса, связанного с экземпляром <see cref="T:System.Diagnostics.Process" />.  
		/// -или- 
		/// Связанный процесс завершился.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me). Задайте для <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> значение <see langword="false" />, чтобы получить доступ к этому свойству в Windows 98 и Windows Me.</exception>
		// Token: 0x17000314 RID: 788
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x0004D220 File Offset: 0x0004B420
		[MonoTODO]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The number of threads of this process.")]
		public ProcessThreadCollection Threads
		{
			get
			{
				if (this.threads == null)
				{
					int num;
					this.threads = new ProcessThreadCollection(new ProcessThread[Process.GetProcessData(this.processId, 0, out num)]);
				}
				return this.threads;
			}
		}

		/// <summary>Получает размер виртуальной памяти процесса (в байтах).</summary>
		/// <returns>Объем виртуальной памяти в байтах, запрошенной связанным процессом.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x0004D25C File Offset: 0x0004B45C
		[MonitoringDescription("The amount of virtual memory currently used for this process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Obsolete("Use VirtualMemorySize64")]
		public int VirtualMemorySize
		{
			get
			{
				int num;
				return (int)Process.GetProcessData(this.processId, 7, out num);
			}
		}

		/// <summary>Возвращает использование физической памяти связанного процесса (в байтах).</summary>
		/// <returns>Общий объем физической памяти в байтах, используемой связанный процесс.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x0004D278 File Offset: 0x0004B478
		[MonitoringDescription("The amount of physical memory currently used for this process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Obsolete("Use WorkingSet64")]
		public int WorkingSet
		{
			get
			{
				int num;
				return (int)Process.GetProcessData(this.processId, 4, out num);
			}
		}

		/// <summary>Получает объем закрытой системной памяти в байтах, выделенной для связанного процесса.</summary>
		/// <returns>Объем памяти в байтах, выделенное для связанного процесса, которое не может быть доступно другим процессам.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x0004D294 File Offset: 0x0004B494
		[ComVisible(false)]
		[MonitoringDescription("The amount of memory exclusively used by this process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public long PrivateMemorySize64
		{
			get
			{
				int num;
				return Process.GetProcessData(this.processId, 6, out num);
			}
		}

		/// <summary>Возвращает объем виртуальной памяти в байтах, выделенной для связанного процесса.</summary>
		/// <returns>Объем виртуальной памяти в байтах, выделенной для связанного процесса.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0004D2B0 File Offset: 0x0004B4B0
		[MonitoringDescription("The amount of virtual memory currently used for this process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[ComVisible(false)]
		public long VirtualMemorySize64
		{
			get
			{
				int num;
				return Process.GetProcessData(this.processId, 7, out num);
			}
		}

		/// <summary>Получает объем физической памяти в байтах, выделенной для связанного процесса.</summary>
		/// <returns>Объем физической памяти в байтах, выделенной для связанного процесса.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me), которая не поддерживает это свойство.</exception>
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x0004D2CC File Offset: 0x0004B4CC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[ComVisible(false)]
		[MonitoringDescription("The amount of physical memory currently used for this process.")]
		public long WorkingSet64
		{
			get
			{
				int num;
				return Process.GetProcessData(this.processId, 4, out num);
			}
		}

		/// <summary>Закрывает процесс, имеющий пользовательский интерфейс, посылая сообщение о закрытии главному окну процесса.</summary>
		/// <returns>Значение <see langword="true" />, если сообщение о закрытии было успешно отправлено; <see langword="false" />, если связанный процесс не имеет главного окна или если главное окно отключено (например, если отображается модальное диалоговое окно).</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition (Windows Me). Задайте для свойства <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> значение <see langword="false" />, чтобы получить доступ к этому свойству в Windows 98 и Windows Me.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот процесс уже завершился.  
		/// -или- 
		/// Нет процессов, связанных с этим объектом <see cref="T:System.Diagnostics.Process" />.</exception>
		// Token: 0x060011B3 RID: 4531 RVA: 0x0004D2E8 File Offset: 0x0004B4E8
		public bool CloseMainWindow()
		{
			SafeProcessHandle safeProcessHandle = null;
			bool result;
			try
			{
				safeProcessHandle = this.GetProcessHandle(1);
				result = NativeMethods.TerminateProcess(safeProcessHandle, -2);
			}
			finally
			{
				this.ReleaseProcessHandle(safeProcessHandle);
			}
			return result;
		}

		// Token: 0x060011B4 RID: 4532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetProcess_internal(int pid);

		/// <summary>Возвращает новый компонент <see cref="T:System.Diagnostics.Process" /> по заданному идентификатору процесса и имени компьютера в сети.</summary>
		/// <param name="processId">Уникальный в системе идентификатор ресурса процесса.</param>
		/// <param name="machineName">Имя компьютера в сети.</param>
		/// <returns>Компонент <see cref="T:System.Diagnostics.Process" />, связанный с удаленным ресурсом процесса, определенного параметром <paramref name="processId" />.</returns>
		/// <exception cref="T:System.ArgumentException">Процесс, указанный параметром <paramref name="processId" />, не выполняется. Возможно, истек срок действия идентификатора.  
		/// -или- 
		/// Недопустимый синтаксис параметра <paramref name="machineName" />. Возможно, имя имеет нулевую длину (0).</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="machineName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс не был запущен этим объектом.</exception>
		// Token: 0x060011B5 RID: 4533 RVA: 0x0004D324 File Offset: 0x0004B524
		[MonoTODO("There is no support for retrieving process information from a remote machine")]
		public static Process GetProcessById(int processId, string machineName)
		{
			if (machineName == null)
			{
				throw new ArgumentNullException("machineName");
			}
			if (!Process.IsLocalMachine(machineName))
			{
				throw new NotImplementedException();
			}
			IntPtr process_internal = Process.GetProcess_internal(processId);
			if (process_internal == IntPtr.Zero)
			{
				throw new ArgumentException("Can't find process with ID " + processId.ToString());
			}
			return new Process(new SafeProcessHandle(process_internal, true), processId);
		}

		/// <summary>Создает массив из новых компонентов <see cref="T:System.Diagnostics.Process" /> и связывает их со всеми ресурсами процесса на удаленном компьютере, для которых заданное имя процесса является общедоступным.</summary>
		/// <param name="processName">Понятное имя процесса.</param>
		/// <param name="machineName">Имя компьютера в сети.</param>
		/// <returns>Массив типа <see cref="T:System.Diagnostics.Process" />, представляющий ресурсы процесса, выполняющего указанное приложение или файл.</returns>
		/// <exception cref="T:System.ArgumentException">Недопустимый синтаксис параметра <paramref name="machineName" />. Он может иметь нулевую длину (0).</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="machineName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Платформа операционной системы не поддерживает эту операцию на удаленных компьютерах.</exception>
		/// <exception cref="T:System.InvalidOperationException">Попытка подключиться к <paramref name="machineName" /> завершилась ошибкой.
		/// -или- 
		/// Существуют проблемы при доступе к API счетчиков производительности, которые используются для получения сведений о процессе. Это исключение характерно для Windows NT, Windows 2000 и Windows XP.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Возникла проблема при доступе к базовому системному API.</exception>
		// Token: 0x060011B6 RID: 4534 RVA: 0x0004D384 File Offset: 0x0004B584
		public static Process[] GetProcessesByName(string processName, string machineName)
		{
			if (machineName == null)
			{
				throw new ArgumentNullException("machineName");
			}
			if (!Process.IsLocalMachine(machineName))
			{
				throw new NotImplementedException();
			}
			Process[] processes = Process.GetProcesses();
			if (processes.Length == 0)
			{
				return processes;
			}
			int newSize = 0;
			foreach (Process process in processes)
			{
				try
				{
					if (string.Compare(processName, process.ProcessName, true) == 0)
					{
						processes[newSize++] = process;
					}
					else
					{
						process.Dispose();
					}
				}
				catch (SystemException)
				{
				}
			}
			Array.Resize<Process>(ref processes, newSize);
			return processes;
		}

		// Token: 0x060011B7 RID: 4535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int[] GetProcesses_internal();

		/// <summary>Создает новый компонент <see cref="T:System.Diagnostics.Process" /> для каждого ресурса процесса на указанном компьютере.</summary>
		/// <param name="machineName">Компьютер, из которого читается список процессов.</param>
		/// <returns>Массив типа <see cref="T:System.Diagnostics.Process" />, представляющий все ресурсы процесса, выполняющегося на указанном компьютере.</returns>
		/// <exception cref="T:System.ArgumentException">Недопустимый синтаксис параметра <paramref name="machineName" />. Он может иметь нулевую длину (0).</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="machineName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Платформа операционной системы не поддерживает эту операцию на удаленных компьютерах.</exception>
		/// <exception cref="T:System.InvalidOperationException">Существуют проблемы при доступе к API счетчиков производительности, которые используются для получения сведений о процессе. Это исключение характерно для Windows NT, Windows 2000 и Windows XP.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Возникла проблема при доступе к базовому системному API.</exception>
		// Token: 0x060011B8 RID: 4536 RVA: 0x0004D40C File Offset: 0x0004B60C
		[MonoTODO("There is no support for retrieving process information from a remote machine")]
		public static Process[] GetProcesses(string machineName)
		{
			if (machineName == null)
			{
				throw new ArgumentNullException("machineName");
			}
			if (!Process.IsLocalMachine(machineName))
			{
				throw new NotImplementedException();
			}
			int[] processes_internal = Process.GetProcesses_internal();
			if (processes_internal == null)
			{
				return new Process[0];
			}
			List<Process> list = new List<Process>(processes_internal.Length);
			for (int i = 0; i < processes_internal.Length; i++)
			{
				try
				{
					list.Add(Process.GetProcessById(processes_internal[i]));
				}
				catch (SystemException)
				{
				}
			}
			return list.ToArray();
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0004D488 File Offset: 0x0004B688
		private static bool IsLocalMachine(string machineName)
		{
			return machineName == "." || machineName.Length == 0 || string.Compare(machineName, Environment.MachineName, true) == 0;
		}

		// Token: 0x060011BA RID: 4538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo);

		// Token: 0x060011BB RID: 4539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, ref Process.ProcInfo procInfo);

		// Token: 0x060011BC RID: 4540 RVA: 0x0004D4B0 File Offset: 0x0004B6B0
		private bool StartWithShellExecuteEx(ProcessStartInfo startInfo)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().Name);
			}
			if (!string.IsNullOrEmpty(startInfo.UserName) || startInfo.Password != null)
			{
				throw new InvalidOperationException(SR.GetString("The Process object must have the UseShellExecute property set to false in order to start a process as a user."));
			}
			if (startInfo.RedirectStandardInput || startInfo.RedirectStandardOutput || startInfo.RedirectStandardError)
			{
				throw new InvalidOperationException(SR.GetString("The Process object must have the UseShellExecute property set to false in order to redirect IO streams."));
			}
			if (startInfo.StandardErrorEncoding != null)
			{
				throw new InvalidOperationException(SR.GetString("StandardErrorEncoding is only supported when standard error is redirected."));
			}
			if (startInfo.StandardOutputEncoding != null)
			{
				throw new InvalidOperationException(SR.GetString("StandardOutputEncoding is only supported when standard output is redirected."));
			}
			if (startInfo.environmentVariables != null)
			{
				throw new InvalidOperationException(SR.GetString("The Process object must have the UseShellExecute property set to false in order to use environment variables."));
			}
			Process.ProcInfo procInfo = default(Process.ProcInfo);
			Process.FillUserInfo(startInfo, ref procInfo);
			bool flag;
			try
			{
				flag = Process.ShellExecuteEx_internal(startInfo, ref procInfo);
			}
			finally
			{
				if (procInfo.Password != IntPtr.Zero)
				{
					Marshal.ZeroFreeBSTR(procInfo.Password);
				}
				procInfo.Password = IntPtr.Zero;
			}
			if (!flag)
			{
				throw new Win32Exception(-procInfo.pid);
			}
			this.SetProcessHandle(new SafeProcessHandle(procInfo.process_handle, true));
			this.SetProcessId(procInfo.pid);
			return flag;
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0004D5F0 File Offset: 0x0004B7F0
		private static void CreatePipe(out IntPtr read, out IntPtr write, bool writeDirection)
		{
			MonoIOError monoIOError;
			if (!MonoIO.CreatePipe(out read, out write, out monoIOError))
			{
				throw MonoIO.GetException(monoIOError);
			}
			if (Process.IsWindows)
			{
				IntPtr intPtr = writeDirection ? write : read;
				if (!MonoIO.DuplicateHandle(Process.GetCurrentProcess().Handle, intPtr, Process.GetCurrentProcess().Handle, out intPtr, 0, 0, 2, out monoIOError))
				{
					throw MonoIO.GetException(monoIOError);
				}
				if (writeDirection)
				{
					if (!MonoIO.Close(write, out monoIOError))
					{
						throw MonoIO.GetException(monoIOError);
					}
					write = intPtr;
					return;
				}
				else
				{
					if (!MonoIO.Close(read, out monoIOError))
					{
						throw MonoIO.GetException(monoIOError);
					}
					read = intPtr;
				}
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x0004D678 File Offset: 0x0004B878
		private static bool IsWindows
		{
			get
			{
				PlatformID platform = Environment.OSVersion.Platform;
				return platform == PlatformID.Win32S || platform == PlatformID.Win32Windows || platform == PlatformID.Win32NT || platform == PlatformID.WinCE;
			}
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0004D6A4 File Offset: 0x0004B8A4
		private bool StartWithCreateProcess(ProcessStartInfo startInfo)
		{
			if (startInfo.StandardOutputEncoding != null && !startInfo.RedirectStandardOutput)
			{
				throw new InvalidOperationException(SR.GetString("StandardOutputEncoding is only supported when standard output is redirected."));
			}
			if (startInfo.StandardErrorEncoding != null && !startInfo.RedirectStandardError)
			{
				throw new InvalidOperationException(SR.GetString("StandardErrorEncoding is only supported when standard error is redirected."));
			}
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().Name);
			}
			Process.ProcInfo procInfo = default(Process.ProcInfo);
			if (startInfo.HaveEnvVars)
			{
				List<string> list = new List<string>();
				foreach (object obj in startInfo.EnvironmentVariables)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					if (dictionaryEntry.Value != null)
					{
						list.Add((string)dictionaryEntry.Key + "=" + (string)dictionaryEntry.Value);
					}
				}
				procInfo.envVariables = list.ToArray();
			}
			if (startInfo.ArgumentList.Count > 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (string argument in startInfo.ArgumentList)
				{
					PasteArguments.AppendArgument(stringBuilder, argument);
				}
				startInfo.Arguments = stringBuilder.ToString();
			}
			IntPtr intPtr = IntPtr.Zero;
			IntPtr zero = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			IntPtr intPtr2 = IntPtr.Zero;
			IntPtr zero3 = IntPtr.Zero;
			IntPtr intPtr3 = IntPtr.Zero;
			try
			{
				if (startInfo.RedirectStandardInput)
				{
					Process.CreatePipe(out intPtr, out zero, true);
				}
				else
				{
					intPtr = MonoIO.ConsoleInput;
					zero = IntPtr.Zero;
				}
				if (startInfo.RedirectStandardOutput)
				{
					Process.CreatePipe(out zero2, out intPtr2, false);
				}
				else
				{
					zero2 = IntPtr.Zero;
					intPtr2 = MonoIO.ConsoleOutput;
				}
				if (startInfo.RedirectStandardError)
				{
					Process.CreatePipe(out zero3, out intPtr3, false);
				}
				else
				{
					zero3 = IntPtr.Zero;
					intPtr3 = MonoIO.ConsoleError;
				}
				Process.FillUserInfo(startInfo, ref procInfo);
				if (!Process.CreateProcess_internal(startInfo, intPtr, intPtr2, intPtr3, ref procInfo))
				{
					throw new Win32Exception(-procInfo.pid, string.Concat(new string[]
					{
						"ApplicationName='",
						startInfo.FileName,
						"', CommandLine='",
						startInfo.Arguments,
						"', CurrentDirectory='",
						startInfo.WorkingDirectory,
						"', Native error= ",
						Win32Exception.GetErrorMessage(-procInfo.pid)
					}));
				}
			}
			catch
			{
				if (startInfo.RedirectStandardInput)
				{
					if (intPtr != IntPtr.Zero)
					{
						MonoIOError monoIOError;
						MonoIO.Close(intPtr, out monoIOError);
					}
					if (zero != IntPtr.Zero)
					{
						MonoIOError monoIOError;
						MonoIO.Close(zero, out monoIOError);
					}
				}
				if (startInfo.RedirectStandardOutput)
				{
					if (zero2 != IntPtr.Zero)
					{
						MonoIOError monoIOError;
						MonoIO.Close(zero2, out monoIOError);
					}
					if (intPtr2 != IntPtr.Zero)
					{
						MonoIOError monoIOError;
						MonoIO.Close(intPtr2, out monoIOError);
					}
				}
				if (startInfo.RedirectStandardError)
				{
					if (zero3 != IntPtr.Zero)
					{
						MonoIOError monoIOError;
						MonoIO.Close(zero3, out monoIOError);
					}
					if (intPtr3 != IntPtr.Zero)
					{
						MonoIOError monoIOError;
						MonoIO.Close(intPtr3, out monoIOError);
					}
				}
				throw;
			}
			finally
			{
				if (procInfo.Password != IntPtr.Zero)
				{
					Marshal.ZeroFreeBSTR(procInfo.Password);
					procInfo.Password = IntPtr.Zero;
				}
			}
			this.SetProcessHandle(new SafeProcessHandle(procInfo.process_handle, true));
			this.SetProcessId(procInfo.pid);
			if (startInfo.RedirectStandardInput)
			{
				MonoIOError monoIOError;
				MonoIO.Close(intPtr, out monoIOError);
				Encoding encoding = startInfo.StandardInputEncoding ?? Console.InputEncoding;
				this.standardInput = new StreamWriter(new FileStream(zero, FileAccess.Write, true, 8192), encoding)
				{
					AutoFlush = true
				};
			}
			if (startInfo.RedirectStandardOutput)
			{
				MonoIOError monoIOError;
				MonoIO.Close(intPtr2, out monoIOError);
				Encoding encoding2 = startInfo.StandardOutputEncoding ?? Console.OutputEncoding;
				this.standardOutput = new StreamReader(new FileStream(zero2, FileAccess.Read, true, 8192), encoding2, true);
			}
			if (startInfo.RedirectStandardError)
			{
				MonoIOError monoIOError;
				MonoIO.Close(intPtr3, out monoIOError);
				Encoding encoding3 = startInfo.StandardErrorEncoding ?? Console.OutputEncoding;
				this.standardError = new StreamReader(new FileStream(zero3, FileAccess.Read, true, 8192), encoding3, true);
			}
			return true;
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0004DB1C File Offset: 0x0004BD1C
		private static void FillUserInfo(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo)
		{
			if (startInfo.UserName.Length != 0)
			{
				procInfo.UserName = startInfo.UserName;
				procInfo.Domain = startInfo.Domain;
				if (startInfo.Password != null)
				{
					procInfo.Password = Marshal.SecureStringToBSTR(startInfo.Password);
				}
				else
				{
					procInfo.Password = IntPtr.Zero;
				}
				procInfo.LoadUserProfile = startInfo.LoadUserProfile;
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0004DB80 File Offset: 0x0004BD80
		private void RaiseOnExited()
		{
			if (!this.watchForExit)
			{
				return;
			}
			if (!this.raisedOnExited)
			{
				lock (this)
				{
					if (!this.raisedOnExited)
					{
						this.raisedOnExited = true;
						this.OnExited();
					}
				}
			}
		}

		// Token: 0x04000A2D RID: 2605
		private bool haveProcessId;

		// Token: 0x04000A2E RID: 2606
		private int processId;

		// Token: 0x04000A2F RID: 2607
		private bool haveProcessHandle;

		// Token: 0x04000A30 RID: 2608
		private SafeProcessHandle m_processHandle;

		// Token: 0x04000A31 RID: 2609
		private bool isRemoteMachine;

		// Token: 0x04000A32 RID: 2610
		private string machineName;

		// Token: 0x04000A33 RID: 2611
		private int m_processAccess;

		// Token: 0x04000A34 RID: 2612
		private ProcessThreadCollection threads;

		// Token: 0x04000A35 RID: 2613
		private ProcessModuleCollection modules;

		// Token: 0x04000A36 RID: 2614
		private bool haveWorkingSetLimits;

		// Token: 0x04000A37 RID: 2615
		private IntPtr minWorkingSet;

		// Token: 0x04000A38 RID: 2616
		private IntPtr maxWorkingSet;

		// Token: 0x04000A39 RID: 2617
		private bool havePriorityClass;

		// Token: 0x04000A3A RID: 2618
		private ProcessPriorityClass priorityClass;

		// Token: 0x04000A3B RID: 2619
		private ProcessStartInfo startInfo;

		// Token: 0x04000A3C RID: 2620
		private bool watchForExit;

		// Token: 0x04000A3D RID: 2621
		private bool watchingForExit;

		// Token: 0x04000A3E RID: 2622
		private EventHandler onExited;

		// Token: 0x04000A3F RID: 2623
		private bool exited;

		// Token: 0x04000A40 RID: 2624
		private int exitCode;

		// Token: 0x04000A41 RID: 2625
		private bool signaled;

		// Token: 0x04000A42 RID: 2626
		private DateTime exitTime;

		// Token: 0x04000A43 RID: 2627
		private bool haveExitTime;

		// Token: 0x04000A44 RID: 2628
		private bool raisedOnExited;

		// Token: 0x04000A45 RID: 2629
		private RegisteredWaitHandle registeredWaitHandle;

		// Token: 0x04000A46 RID: 2630
		private WaitHandle waitHandle;

		// Token: 0x04000A47 RID: 2631
		private ISynchronizeInvoke synchronizingObject;

		// Token: 0x04000A48 RID: 2632
		private StreamReader standardOutput;

		// Token: 0x04000A49 RID: 2633
		private StreamWriter standardInput;

		// Token: 0x04000A4A RID: 2634
		private StreamReader standardError;

		// Token: 0x04000A4B RID: 2635
		private OperatingSystem operatingSystem;

		// Token: 0x04000A4C RID: 2636
		private bool disposed;

		// Token: 0x04000A4D RID: 2637
		private Process.StreamReadMode outputStreamReadMode;

		// Token: 0x04000A4E RID: 2638
		private Process.StreamReadMode errorStreamReadMode;

		// Token: 0x04000A4F RID: 2639
		private Process.StreamReadMode inputStreamReadMode;

		// Token: 0x04000A52 RID: 2642
		internal AsyncStreamReader output;

		// Token: 0x04000A53 RID: 2643
		internal AsyncStreamReader error;

		// Token: 0x04000A54 RID: 2644
		internal bool pendingOutputRead;

		// Token: 0x04000A55 RID: 2645
		internal bool pendingErrorRead;

		// Token: 0x04000A56 RID: 2646
		internal static TraceSwitch processTracing;

		// Token: 0x04000A57 RID: 2647
		private string process_name;

		// Token: 0x04000A58 RID: 2648
		private static ProcessModule current_main_module;

		// Token: 0x0200023D RID: 573
		private enum StreamReadMode
		{
			// Token: 0x04000A5A RID: 2650
			undefined,
			// Token: 0x04000A5B RID: 2651
			syncMode,
			// Token: 0x04000A5C RID: 2652
			asyncMode
		}

		// Token: 0x0200023E RID: 574
		private enum State
		{
			// Token: 0x04000A5E RID: 2654
			HaveId = 1,
			// Token: 0x04000A5F RID: 2655
			IsLocal,
			// Token: 0x04000A60 RID: 2656
			IsNt = 4,
			// Token: 0x04000A61 RID: 2657
			HaveProcessInfo = 8,
			// Token: 0x04000A62 RID: 2658
			Exited = 16,
			// Token: 0x04000A63 RID: 2659
			Associated = 32,
			// Token: 0x04000A64 RID: 2660
			IsWin2k = 64,
			// Token: 0x04000A65 RID: 2661
			HaveNtProcessInfo = 12
		}

		// Token: 0x0200023F RID: 575
		private struct ProcInfo
		{
			// Token: 0x04000A66 RID: 2662
			public IntPtr process_handle;

			// Token: 0x04000A67 RID: 2663
			public int pid;

			// Token: 0x04000A68 RID: 2664
			public string[] envVariables;

			// Token: 0x04000A69 RID: 2665
			public string UserName;

			// Token: 0x04000A6A RID: 2666
			public string Domain;

			// Token: 0x04000A6B RID: 2667
			public IntPtr Password;

			// Token: 0x04000A6C RID: 2668
			public bool LoadUserProfile;
		}
	}
}
