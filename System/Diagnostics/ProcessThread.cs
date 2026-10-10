using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Представляет поток процесса операционной системы.</summary>
	// Token: 0x0200027E RID: 638
	[Designer("System.Diagnostics.Design.ProcessThreadDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public class ProcessThread : Component
	{
		// Token: 0x06001448 RID: 5192 RVA: 0x000507D0 File Offset: 0x0004E9D0
		[MonoTODO("Parse parameters")]
		internal ProcessThread()
		{
		}

		/// <summary>Возвращает базовый приоритет потока.</summary>
		/// <returns>Базовый приоритет потока, вычисляемый операционной системой путем совмещения класса приоритета процесса с уровнем приоритета соответствующего потока.</returns>
		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x00003062 File Offset: 0x00001262
		[MonitoringDescription("The base priority of this thread.")]
		[MonoTODO]
		public int BasePriority
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Возвращает текущий приоритет потока.</summary>
		/// <returns>Текущий приоритет потока, который может отклоняться от базового, в зависимости от способа планирования потока в операционной системе. Для активного потока приоритет может быть временно увеличен.</returns>
		// Token: 0x170003CE RID: 974
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x00003062 File Offset: 0x00001262
		[MonoTODO]
		[MonitoringDescription("The current priority of this thread.")]
		public int CurrentPriority
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Возвращает уникальный идентификатор потока.</summary>
		/// <returns>Уникальный идентификатор связан с конкретным потоком.</returns>
		// Token: 0x170003CF RID: 975
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x00003062 File Offset: 0x00001262
		[MonitoringDescription("The ID of this thread.")]
		[MonoTODO]
		public int Id
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Устанавливает предпочтительный процессор для выполнения этого потока.</summary>
		/// <returns>Предпочтительный процессор для потока, используемый при планировании потока системой для определения процессора, на котором будет выполняться поток.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Системе не удалось задать поток для запуска на указанном процессоре.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.NotSupportedException">Данный процесс выполняется на удаленном компьютере.</exception>
		// Token: 0x170003D0 RID: 976
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x00003917 File Offset: 0x00001B17
		[Browsable(false)]
		[MonoTODO]
		public int IdealProcessor
		{
			set
			{
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, должна ли операционная система временно увеличивать приоритет соответствующего потока всякий раз, когда основное окно процесса, которому принадлежит данный поток, получает фокус.</summary>
		/// <returns>Значение <see langword="true" /> для увеличения приоритета потока при взаимодействии пользователя с интерфейсом процесса или значение <see langword="false" /> в противном случае. Значение по умолчанию: <see langword="false" />.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удается извлечь информацию о повышении приоритета.  
		///
		/// или - 
		/// Не удается задать информацию о повышении приоритета.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.NotSupportedException">Данный процесс выполняется на удаленном компьютере.</exception>
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x00003062 File Offset: 0x00001262
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x00003917 File Offset: 0x00001B17
		[MonitoringDescription("Thread gets a priority boot when interactively used by a user.")]
		[MonoTODO]
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

		/// <summary>Возвращает или задает уровень приоритета потока.</summary>
		/// <returns>Одно из значений <see cref="T:System.Diagnostics.ThreadPriorityLevel" />, задающих диапазон, который ограничивает приоритет потока.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удается извлечь информацию об уровне приоритета потока.  
		///
		/// или - 
		/// Не удается задать информацию об уровне приоритета потока.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.NotSupportedException">Данный процесс выполняется на удаленном компьютере.</exception>
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x00053124 File Offset: 0x00051324
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO]
		[MonitoringDescription("The priority level of this thread.")]
		public ThreadPriorityLevel PriorityLevel
		{
			get
			{
				return ThreadPriorityLevel.Idle;
			}
			set
			{
			}
		}

		/// <summary>Возвращает количество времени, затрачиваемое потоком на выполнение кода внутри ядра операционной системы.</summary>
		/// <returns>Объект <see cref="T:System.TimeSpan" />, указывающий количество времени, которое поток потратил на выполнение кода внутри ядра операционной системы.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удалось извлечь затраченное потоком время.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.NotSupportedException">Данный процесс выполняется на удаленном компьютере.</exception>
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x00053128 File Offset: 0x00051328
		[MonitoringDescription("The amount of CPU time used in privileged mode.")]
		[MonoTODO]
		public TimeSpan PrivilegedProcessorTime
		{
			get
			{
				return new TimeSpan(0L);
			}
		}

		/// <summary>Задает процессоры, на которых может выполняться соответствующий поток.</summary>
		/// <returns>Объект <see cref="T:System.IntPtr" />, указывающий на набор битов, каждый из которых представляет процессор, где может выполняться поток.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удается задать сходство процессоров.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.NotSupportedException">Данный процесс выполняется на удаленном компьютере.</exception>
		// Token: 0x170003D4 RID: 980
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x00003917 File Offset: 0x00001B17
		[Browsable(false)]
		[MonoTODO]
		public IntPtr ProcessorAffinity
		{
			set
			{
			}
		}

		/// <summary>Возвращает адрес функции в памяти, которая была вызвана операционной системой и запустила этот поток.</summary>
		/// <returns>Начальный адрес потока, указывающий на определенную приложением функцию, которую выполняет данный поток.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.NotSupportedException">Данный процесс выполняется на удаленном компьютере.</exception>
		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0004D218 File Offset: 0x0004B418
		[MonitoringDescription("The start address in memory of this thread.")]
		[MonoTODO]
		public IntPtr StartAddress
		{
			get
			{
				return (IntPtr)0;
			}
		}

		/// <summary>Возвращает время запуска потока операционной системой.</summary>
		/// <returns>Класс <see cref="T:System.DateTime" />, представляющий системное время запуска потока операционной системой.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удалось извлечь затраченное потоком время.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.NotSupportedException">Данный процесс выполняется на удаленном компьютере.</exception>
		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x00053131 File Offset: 0x00051331
		[MonoTODO]
		[MonitoringDescription("The time this thread was started.")]
		public DateTime StartTime
		{
			get
			{
				return new DateTime(0L);
			}
		}

		/// <summary>Возвращает текущее состояние данного потока.</summary>
		/// <returns>Объект <see cref="T:System.Diagnostics.ThreadState" />, указывающий на состояние выполнения потока, например, выполняется, ожидает или прекращен.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.NotSupportedException">Данный процесс выполняется на удаленном компьютере.</exception>
		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x00003062 File Offset: 0x00001262
		[MonitoringDescription("The current state of this thread.")]
		[MonoTODO]
		public ThreadState ThreadState
		{
			get
			{
				return ThreadState.Initialized;
			}
		}

		/// <summary>Возвращает общее количество времени, которое потратил поток на обработку процессором.</summary>
		/// <returns>Объект <see cref="T:System.TimeSpan" />, указывающий количество времени, на протяжении которого поток контролировал процессор.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удалось извлечь затраченное потоком время.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.NotSupportedException">Данный процесс выполняется на удаленном компьютере.</exception>
		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x00053128 File Offset: 0x00051328
		[MonitoringDescription("The total amount of CPU time used.")]
		[MonoTODO]
		public TimeSpan TotalProcessorTime
		{
			get
			{
				return new TimeSpan(0L);
			}
		}

		/// <summary>Возвращает количество времени, которое поток потратил на выполнение кода внутри приложения.</summary>
		/// <returns>Объект <see cref="T:System.TimeSpan" />, указывающий количество времени, которое поток потратил на выполнение кода внутри приложения, в отличие от выполнения в ядре операционной системы.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удалось извлечь затраченное потоком время.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.NotSupportedException">Данный процесс выполняется на удаленном компьютере.</exception>
		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x00053128 File Offset: 0x00051328
		[MonoTODO]
		[MonitoringDescription("The amount of CPU time used in user mode.")]
		public TimeSpan UserProcessorTime
		{
			get
			{
				return new TimeSpan(0L);
			}
		}

		/// <summary>Возвращает причину, по которой поток находится в состоянии ожидания.</summary>
		/// <returns>Объект <see cref="T:System.Diagnostics.ThreadWaitReason" />, представляющий причину нахождения потока в состоянии ожидания.</returns>
		/// <exception cref="T:System.InvalidOperationException">Поток не находится в состоянии ожидания.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.NotSupportedException">Данный процесс выполняется на удаленном компьютере.</exception>
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x00003062 File Offset: 0x00001262
		[MonoTODO]
		[MonitoringDescription("The reason why this thread is waiting.")]
		public ThreadWaitReason WaitReason
		{
			get
			{
				return ThreadWaitReason.Executive;
			}
		}

		/// <summary>Отменяет идеальный процессор для данного потока, указывая тем самым на отсутствие единственного идеального процессора. Другими словами, для потока идеален любой процессор.</summary>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Не удается сбросить идеальный процессор.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используется платформа Windows 98 или Windows Millennium Edition.</exception>
		/// <exception cref="T:System.NotSupportedException">Данный процесс выполняется на удаленном компьютере.</exception>
		// Token: 0x06001459 RID: 5209 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO]
		public void ResetIdealProcessor()
		{
		}
	}
}
