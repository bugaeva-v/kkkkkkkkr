using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;

namespace System.Diagnostics
{
	/// <summary>Задает набор значений, используемых при запуске процесса.</summary>
	// Token: 0x02000245 RID: 581
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	[HostProtection(SecurityAction.LinkDemand, SharedState = true, SelfAffectingProcessMgmt = true)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class ProcessStartInfo
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.ProcessStartInfo" />, не указывая имени файла, вместе с которым должен запускаться процесс.</summary>
		// Token: 0x060011D3 RID: 4563 RVA: 0x0004DDAC File Offset: 0x0004BFAC
		public ProcessStartInfo()
		{
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0004DDBB File Offset: 0x0004BFBB
		internal ProcessStartInfo(Process parent)
		{
			this.weakParentProcess = new WeakReference(parent);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.ProcessStartInfo" /> и задает имя файла, например приложение или документ, вместе с которым должен запускаться процесс.</summary>
		/// <param name="fileName">Приложение или документ, вместе с которыми должен запускаться процесс.</param>
		// Token: 0x060011D5 RID: 4565 RVA: 0x0004DDD6 File Offset: 0x0004BFD6
		public ProcessStartInfo(string fileName)
		{
			this.fileName = fileName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.ProcessStartInfo" />, задает имя файла приложения, вместе с которым должен запускаться процесс, и указывает передаваемые в приложение аргументы командной строки.</summary>
		/// <param name="fileName">Приложение, с которым должен запускаться процесс.</param>
		/// <param name="arguments">Аргументы командной строки, передаваемые в приложение при запуске процесса.</param>
		// Token: 0x060011D6 RID: 4566 RVA: 0x0004DDEC File Offset: 0x0004BFEC
		public ProcessStartInfo(string fileName, string arguments)
		{
			this.fileName = fileName;
			this.arguments = arguments;
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0004DE09 File Offset: 0x0004C009
		public Collection<string> ArgumentList
		{
			get
			{
				if (this._argumentList == null)
				{
					this._argumentList = new Collection<string>();
				}
				return this._argumentList;
			}
		}

		/// <summary>Получает или задает команду, которую необходимо использовать при открытии приложения или документа, указанного в свойстве <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" />.</summary>
		/// <returns>Действие, которое необходимо выполнить с файлом, который открывается данным процессом. Значение по умолчанию — пустая строка (""), что означает "никаких действий".</returns>
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x0004DE24 File Offset: 0x0004C024
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x0004DE3A File Offset: 0x0004C03A
		[NotifyParentProperty(true)]
		[TypeConverter("System.Diagnostics.Design.VerbConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[DefaultValue("")]
		[MonitoringDescription("The verb to apply to the document specified by the FileName property.")]
		public string Verb
		{
			get
			{
				if (this.verb == null)
				{
					return string.Empty;
				}
				return this.verb;
			}
			set
			{
				this.verb = value;
			}
		}

		/// <summary>Получает или задает набор аргументов командной строки, используемых при запуске приложения.</summary>
		/// <returns>Одна строка, содержащая аргументы для передачи в целевое приложение, указанное в свойстве <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" />. Значение по умолчанию — пустая строка (""). В Windows Vista и более ранних версиях операционной системы Windows длина аргументов, добавляемых к длине полного пути к процессу, должна быть меньше 2080. В Windows 7 и более поздних версиях длина должна быть меньше 32699.  
		/// Аргументы анализируются и интерпретируются целевым приложением, поэтому они должны соответствовать ожидаемым аргументам приложения. Как показано в примерах ниже, для приложений .NET пробелы считаются разделителями между несколькими аргументами. Одиночный аргумент, включающий пробелы, должен быть заключен в кавычки, но кавычки не указываются в целевом приложении. В финальном проанализированном аргументе при включении кавычек к каждому знаку следует добавить escape-символ.</returns>
		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x0004DE43 File Offset: 0x0004C043
		// (set) Token: 0x060011DB RID: 4571 RVA: 0x0004DE59 File Offset: 0x0004C059
		[SettingsBindable(true)]
		[MonitoringDescription("Command line arguments that will be passed to the application specified by the FileName property.")]
		[DefaultValue("")]
		[NotifyParentProperty(true)]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public string Arguments
		{
			get
			{
				if (this.arguments == null)
				{
					return string.Empty;
				}
				return this.arguments;
			}
			set
			{
				this.arguments = value;
			}
		}

		/// <summary>Получает или задает значение, позволяющее определить, нужно ли запускать процесс в новом окне.</summary>
		/// <returns>Значение <see langword="true" /> для процесс должен быть запущен без создания для него нового окна; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x0004DE62 File Offset: 0x0004C062
		// (set) Token: 0x060011DD RID: 4573 RVA: 0x0004DE6A File Offset: 0x0004C06A
		[DefaultValue(false)]
		[MonitoringDescription("Whether to start the process without creating a new window to contain it.")]
		[NotifyParentProperty(true)]
		public bool CreateNoWindow
		{
			get
			{
				return this.createNoWindow;
			}
			set
			{
				this.createNoWindow = value;
			}
		}

		/// <summary>Получает пути поиска файлов, каталоги временных файлов, параметры данного приложения и другие аналогичные сведения.</summary>
		/// <returns>Словарь строк, предоставляющий переменные среды, применимые к этому процессу и дочерним процессам. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x0004DE74 File Offset: 0x0004C074
		[MonitoringDescription("Set of environment variables that apply to this process and child processes.")]
		[NotifyParentProperty(true)]
		[DefaultValue(null)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Editor("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public StringDictionary EnvironmentVariables
		{
			get
			{
				if (this.environmentVariables == null)
				{
					this.environmentVariables = new CaseSensitiveStringDictionary();
					if (this.weakParentProcess == null || !this.weakParentProcess.IsAlive || ((Component)this.weakParentProcess.Target).Site == null || !((Component)this.weakParentProcess.Target).Site.DesignMode)
					{
						foreach (object obj in System.Environment.GetEnvironmentVariables())
						{
							DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
							this.environmentVariables.Add((string)dictionaryEntry.Key, (string)dictionaryEntry.Value);
						}
					}
				}
				return this.environmentVariables;
			}
		}

		/// <summary>Возвращает переменные среды, относящиеся к этому процессу и его дочерним процессам.</summary>
		/// <returns>Универсальный словарь, содержащий переменные среды, относящиеся к этому процессу и его дочерним процессам. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x0004DF4C File Offset: 0x0004C14C
		[NotifyParentProperty(true)]
		[DefaultValue(null)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IDictionary<string, string> Environment
		{
			get
			{
				if (this.environment == null)
				{
					this.environment = this.EnvironmentVariables.AsGenericDictionary();
				}
				return this.environment;
			}
		}

		/// <summary>Получает или задает значение, позволяющее определить, будут ли считываться входные данные приложения из потока <see cref="P:System.Diagnostics.Process.StandardInput" />.</summary>
		/// <returns>Значение <see langword="true" />, если входные данные должны считываться из <see cref="P:System.Diagnostics.Process.StandardInput" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x0004DF6D File Offset: 0x0004C16D
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x0004DF75 File Offset: 0x0004C175
		[MonitoringDescription("Whether the process command input is read from the Process instance's StandardInput member.")]
		[DefaultValue(false)]
		[NotifyParentProperty(true)]
		public bool RedirectStandardInput
		{
			get
			{
				return this.redirectStandardInput;
			}
			set
			{
				this.redirectStandardInput = value;
			}
		}

		/// <summary>Получает или задает значение, позволяющее определить, записываются ли текстовые выходные данные приложения в поток <see cref="P:System.Diagnostics.Process.StandardOutput" />.</summary>
		/// <returns>Значение <see langword="true" />, если выходные данные должны записываться в <see cref="P:System.Diagnostics.Process.StandardOutput" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x0004DF7E File Offset: 0x0004C17E
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x0004DF86 File Offset: 0x0004C186
		[DefaultValue(false)]
		[NotifyParentProperty(true)]
		[MonitoringDescription("Whether the process output is written to the Process instance's StandardOutput member.")]
		public bool RedirectStandardOutput
		{
			get
			{
				return this.redirectStandardOutput;
			}
			set
			{
				this.redirectStandardOutput = value;
			}
		}

		/// <summary>Получает или задает значение, позволяющее определить, записываются ли выходные данные об ошибках приложения в поток <see cref="P:System.Diagnostics.Process.StandardError" />.</summary>
		/// <returns>Значение <see langword="true" />, если выходные сообщения об ошибках должны записываться в <see cref="P:System.Diagnostics.Process.StandardError" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x0004DF8F File Offset: 0x0004C18F
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x0004DF97 File Offset: 0x0004C197
		[DefaultValue(false)]
		[MonitoringDescription("Whether the process's error output is written to the Process instance's StandardError member.")]
		[NotifyParentProperty(true)]
		public bool RedirectStandardError
		{
			get
			{
				return this.redirectStandardError;
			}
			set
			{
				this.redirectStandardError = value;
			}
		}

		/// <summary>Получает или задает предпочтительную кодировку для вывода ошибок.</summary>
		/// <returns>Объект, представляющий предпочтительную кодировку для вывода ошибок. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0004DFA0 File Offset: 0x0004C1A0
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x0004DFA8 File Offset: 0x0004C1A8
		public Encoding StandardErrorEncoding
		{
			get
			{
				return this.standardErrorEncoding;
			}
			set
			{
				this.standardErrorEncoding = value;
			}
		}

		/// <summary>Получает или задает предпочтительную кодировку для стандартного вывода.</summary>
		/// <returns>Объект, представляющий предпочтительную кодировку для стандартного вывода. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0004DFB1 File Offset: 0x0004C1B1
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x0004DFB9 File Offset: 0x0004C1B9
		public Encoding StandardOutputEncoding
		{
			get
			{
				return this.standardOutputEncoding;
			}
			set
			{
				this.standardOutputEncoding = value;
			}
		}

		/// <summary>Получает или задает значение, позволяющее определить, нужно ли использовать оболочку операционной системы для запуска процесса.</summary>
		/// <returns>Значение <see langword="true" />, если оболочка должна использоваться при запуске процесса; значение <see langword="false" />, если процесс должен создаваться непосредственно из исполняемого файла. По умолчанию используется <see langword="true" /> в приложениях .NET Framework и <see langword="false" /> в приложениях .NET Core.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Выполняется попытка задать значение для <see langword="true" /> в приложениях универсальной платформы Windows (UWP).</exception>
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x0004DFC2 File Offset: 0x0004C1C2
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x0004DFCA File Offset: 0x0004C1CA
		[NotifyParentProperty(true)]
		[MonitoringDescription("Whether to use the operating system shell to start the process.")]
		[DefaultValue(true)]
		public bool UseShellExecute
		{
			get
			{
				return this.useShellExecute;
			}
			set
			{
				this.useShellExecute = value;
			}
		}

		/// <summary>Получает или задает имя пользователя, которое следует использовать при запуске процесса. Если используется формат имени субъекта-пользователя, <paramref name="user" /> @ <paramref name="DNS_domain_name" />, свойство <see cref="P:System.Diagnostics.ProcessStartInfo.Domain" /> должно иметь значение <see langword="null" />.</summary>
		/// <returns>Имя пользователя, используемое при запуске процесса. Если используется формат имени субъекта-пользователя, <paramref name="user" /> @ <paramref name="DNS_domain_name" />, свойство <see cref="P:System.Diagnostics.ProcessStartInfo.Domain" /> должно иметь значение <see langword="null" />.</returns>
		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x0004DFD3 File Offset: 0x0004C1D3
		// (set) Token: 0x060011ED RID: 4589 RVA: 0x0004DFE9 File Offset: 0x0004C1E9
		[NotifyParentProperty(true)]
		public string UserName
		{
			get
			{
				if (this.userName == null)
				{
					return string.Empty;
				}
				return this.userName;
			}
			set
			{
				this.userName = value;
			}
		}

		/// <summary>Получает или задает параметр безопасности, в котором содержится пароль пользователя, используемый при запуске процесса.</summary>
		/// <returns>Пароль пользователя, используемый при запуске процесса.</returns>
		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x0004DFF2 File Offset: 0x0004C1F2
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x0004DFFA File Offset: 0x0004C1FA
		public SecureString Password
		{
			get
			{
				return this.password;
			}
			set
			{
				this.password = value;
			}
		}

		/// <summary>Возвращает или задает пароль пользователя в виде открытого текста, который будет использоваться при запуске процесса.</summary>
		/// <returns>Пароль пользователя в виде открытого текста.</returns>
		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x0004E003 File Offset: 0x0004C203
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x0004E00B File Offset: 0x0004C20B
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string PasswordInClearText
		{
			get
			{
				return this.passwordInClearText;
			}
			set
			{
				this.passwordInClearText = value;
			}
		}

		/// <summary>Получает или задает значение, позволяющее идентифицировать домен, используемый при запуске процесса. Если это значение равно <see langword="null" />, свойство <see cref="P:System.Diagnostics.ProcessStartInfo.UserName" /> должно быть указано в формате имени субъекта-пользователя.</summary>
		/// <returns>Домен Active Directory, используемый при запуске процесса. Если это значение равно <see langword="null" />, свойство <see cref="P:System.Diagnostics.ProcessStartInfo.UserName" /> должно быть указано в формате имени субъекта-пользователя.</returns>
		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0004E014 File Offset: 0x0004C214
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x0004E02A File Offset: 0x0004C22A
		[NotifyParentProperty(true)]
		public string Domain
		{
			get
			{
				if (this.domain == null)
				{
					return string.Empty;
				}
				return this.domain;
			}
			set
			{
				this.domain = value;
			}
		}

		/// <summary>Получает или задает значение, позволяющее определить, следует ли загружать профиль пользователя Windows из реестра.</summary>
		/// <returns>Значение <see langword="true" />, если должен быть загружен профиль пользователя Windows; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0004E033 File Offset: 0x0004C233
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0004E03B File Offset: 0x0004C23B
		[NotifyParentProperty(true)]
		public bool LoadUserProfile
		{
			get
			{
				return this.loadUserProfile;
			}
			set
			{
				this.loadUserProfile = value;
			}
		}

		/// <summary>Получает или задает приложение или документ для запуска.</summary>
		/// <returns>Имя запускаемого приложения или имя документа, тип файла которого связан с приложением и для которого доступно действие открытия по умолчанию. Значение по умолчанию — пустая строка ("").</returns>
		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x0004E044 File Offset: 0x0004C244
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x0004E05A File Offset: 0x0004C25A
		[SettingsBindable(true)]
		[NotifyParentProperty(true)]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[MonitoringDescription("The name of the application, document or URL to start.")]
		[Editor("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[DefaultValue("")]
		public string FileName
		{
			get
			{
				if (this.fileName == null)
				{
					return string.Empty;
				}
				return this.fileName;
			}
			set
			{
				this.fileName = value;
			}
		}

		/// <summary>Если свойство <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> имеет значение <see langword="false" />, возвращает или задает рабочую папку для запускаемого процесса. Если параметру <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> присвоено значение <see langword="true" />, возвращает или задает каталог, содержащий процесс, который требуется запустить.</summary>
		/// <returns>Если <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> имеет значение <see langword="true" />, полное имя каталога, в котором содержится запускаемый процесс. Если свойство <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> имеет значение <see langword="false" />, рабочая папка для запускаемого процесса. Значение по умолчанию — пустая строка ("").</returns>
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x0004E063 File Offset: 0x0004C263
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x0004E079 File Offset: 0x0004C279
		[SettingsBindable(true)]
		[MonitoringDescription("The initial working directory for the process.")]
		[DefaultValue("")]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[NotifyParentProperty(true)]
		[Editor("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public string WorkingDirectory
		{
			get
			{
				if (this.directory == null)
				{
					return string.Empty;
				}
				return this.directory;
			}
			set
			{
				this.directory = value;
			}
		}

		/// <summary>Получает или задает значение, позволяющее определить, будет ли отображаться диалоговое окно сообщения об ошибке в случае невозможности запуска процесса.</summary>
		/// <returns>Значение <see langword="true" />, если диалоговое окно сообщения об ошибке должно отображаться на экране при невозможности запуска процесса; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x0004E082 File Offset: 0x0004C282
		// (set) Token: 0x060011FB RID: 4603 RVA: 0x0004E08A File Offset: 0x0004C28A
		[MonitoringDescription("Whether to show an error dialog to the user if there is an error.")]
		[NotifyParentProperty(true)]
		[DefaultValue(false)]
		public bool ErrorDialog
		{
			get
			{
				return this.errorDialog;
			}
			set
			{
				this.errorDialog = value;
			}
		}

		/// <summary>Получает или задает дескриптор окна, используемый при отображении диалогового окна сообщения об ошибке в случае невозможности запустить процесс.</summary>
		/// <returns>Указатель на дескриптор диалогового окна сообщения об ошибке, возникшего в результате сбоя при запуске процесса.</returns>
		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x0004E093 File Offset: 0x0004C293
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x0004E09B File Offset: 0x0004C29B
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public IntPtr ErrorDialogParentHandle
		{
			get
			{
				return this.errorDialogParentHandle;
			}
			set
			{
				this.errorDialogParentHandle = value;
			}
		}

		/// <summary>Получает или задает состояние окна, используемое при запуске процесса.</summary>
		/// <returns>Одно из значений перечисления, позволяющее определить состояние окна, в котором был запущен процесс: во весь экран, свернутое, обычное (ни полноэкранное ни свернутое) или невидимое. Значение по умолчанию — <see langword="Normal" />.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Стиль окна не является одним из членов перечисления <see cref="T:System.Diagnostics.ProcessWindowStyle" />.</exception>
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x0004E0A4 File Offset: 0x0004C2A4
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x0004E0AC File Offset: 0x0004C2AC
		[DefaultValue(ProcessWindowStyle.Normal)]
		[MonitoringDescription("How the main window should be created when the process starts.")]
		[NotifyParentProperty(true)]
		public ProcessWindowStyle WindowStyle
		{
			get
			{
				return this.windowStyle;
			}
			set
			{
				if (!Enum.IsDefined(typeof(ProcessWindowStyle), value))
				{
					throw new InvalidEnumArgumentException("value", (int)value, typeof(ProcessWindowStyle));
				}
				this.windowStyle = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x0004E0E2 File Offset: 0x0004C2E2
		internal bool HaveEnvVars
		{
			get
			{
				return this.environmentVariables != null;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x0004E0ED File Offset: 0x0004C2ED
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x0004E0F5 File Offset: 0x0004C2F5
		public Encoding StandardInputEncoding { get; set; }

		/// <summary>Получает набор команд, которые связаны с типом файла, заданным в свойстве <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" />.</summary>
		/// <returns>Действия, которые система может применить к файлу, заданному в свойстве <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" />.</returns>
		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x0004E100 File Offset: 0x0004C300
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string[] Verbs
		{
			get
			{
				PlatformID platform = System.Environment.OSVersion.Platform;
				if (platform == PlatformID.Unix || platform == PlatformID.MacOSX || platform == (PlatformID)128)
				{
					return ProcessStartInfo.empty;
				}
				string text = string.IsNullOrEmpty(this.fileName) ? null : Path.GetExtension(this.fileName);
				if (text == null)
				{
					return ProcessStartInfo.empty;
				}
				RegistryKey registryKey = null;
				RegistryKey registryKey2 = null;
				RegistryKey registryKey3 = null;
				string[] result;
				try
				{
					registryKey = Registry.ClassesRoot.OpenSubKey(text);
					string text2 = (registryKey != null) ? (registryKey.GetValue(null) as string) : null;
					registryKey2 = ((text2 != null) ? Registry.ClassesRoot.OpenSubKey(text2) : null);
					registryKey3 = ((registryKey2 != null) ? registryKey2.OpenSubKey("shell") : null);
					result = ((registryKey3 != null) ? registryKey3.GetSubKeyNames() : null);
				}
				finally
				{
					if (registryKey3 != null)
					{
						registryKey3.Close();
					}
					if (registryKey2 != null)
					{
						registryKey2.Close();
					}
					if (registryKey != null)
					{
						registryKey.Close();
					}
				}
				return result;
			}
		}

		// Token: 0x04000A72 RID: 2674
		private string fileName;

		// Token: 0x04000A73 RID: 2675
		private string arguments;

		// Token: 0x04000A74 RID: 2676
		private string directory;

		// Token: 0x04000A75 RID: 2677
		private string verb;

		// Token: 0x04000A76 RID: 2678
		private ProcessWindowStyle windowStyle;

		// Token: 0x04000A77 RID: 2679
		private bool errorDialog;

		// Token: 0x04000A78 RID: 2680
		private IntPtr errorDialogParentHandle;

		// Token: 0x04000A79 RID: 2681
		private bool useShellExecute = true;

		// Token: 0x04000A7A RID: 2682
		private string userName;

		// Token: 0x04000A7B RID: 2683
		private string domain;

		// Token: 0x04000A7C RID: 2684
		private SecureString password;

		// Token: 0x04000A7D RID: 2685
		private string passwordInClearText;

		// Token: 0x04000A7E RID: 2686
		private bool loadUserProfile;

		// Token: 0x04000A7F RID: 2687
		private bool redirectStandardInput;

		// Token: 0x04000A80 RID: 2688
		private bool redirectStandardOutput;

		// Token: 0x04000A81 RID: 2689
		private bool redirectStandardError;

		// Token: 0x04000A82 RID: 2690
		private Encoding standardOutputEncoding;

		// Token: 0x04000A83 RID: 2691
		private Encoding standardErrorEncoding;

		// Token: 0x04000A84 RID: 2692
		private bool createNoWindow;

		// Token: 0x04000A85 RID: 2693
		private WeakReference weakParentProcess;

		// Token: 0x04000A86 RID: 2694
		internal StringDictionary environmentVariables;

		// Token: 0x04000A87 RID: 2695
		private static readonly string[] empty = new string[0];

		// Token: 0x04000A88 RID: 2696
		private Collection<string> _argumentList;

		// Token: 0x04000A89 RID: 2697
		private IDictionary<string, string> environment;
	}
}
