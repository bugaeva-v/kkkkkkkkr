using System;
using System.Runtime.InteropServices;
using System.Transactions;

namespace System.EnterpriseServices
{
	/// <summary>Указывает и настраивает службы, которые должны быть активированы в домене, который вводится при вызове <see cref="M:System.EnterpriseServices.ServiceDomain.Enter(System.EnterpriseServices.ServiceConfig)" /> или создание <see cref="T:System.EnterpriseServices.Activity" />. Этот класс не наследуется.</summary>
	// Token: 0x02000046 RID: 70
	[MonoTODO]
	[ComVisible(false)]
	public sealed class ServiceConfig
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ServiceConfig" /> и задает свойства для настройки требуемых служб.</summary>
		/// <exception cref="T:System.PlatformNotSupportedException">Объект <see cref="T:System.EnterpriseServices.ServiceConfig" /> не поддерживается текущей платформой.</exception>
		// Token: 0x06000101 RID: 257 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public ServiceConfig()
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает или задает параметр привязки, показывающий, должна ли вся работа, представленная операцией, быть связана только с одним однопотоковым подразделением.</summary>
		/// <returns>Одно из значений <see cref="T:System.EnterpriseServices.BindingOption" />. Значение по умолчанию — <see cref="F:System.EnterpriseServices.BindingOption.NoBinding" />.</returns>
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public BindingOption Binding
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает объект <see cref="T:System.Transactions.Transaction" />, представляющий существующую транзакцию, которая предоставляет параметры для выполнения транзакции, определенной с помощью объекта <see cref="T:System.EnterpriseServices.ServiceConfig" />.</summary>
		/// <returns>Объект <see cref="T:System.Transactions.Transaction" />. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public Transaction BringYourOwnSystemTransaction
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает объект <see cref="T:System.EnterpriseServices.ITransaction" />, представляющий существующую транзакцию, которая предоставляет параметры для выполнения транзакции, определенной с помощью объекта <see cref="T:System.EnterpriseServices.ServiceConfig" />.</summary>
		/// <returns>Объект <see cref="T:System.EnterpriseServices.ITransaction" />. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public ITransaction BringYourOwnTransaction
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает значение, показывающее, включены ли встроенные функции COM Transaction Integrator (COMTI).</summary>
		/// <returns>Значение <see langword="true" />, если встроенные функции COMTI включены; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public bool COMTIIntrinsicsEnabled
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает значение, показывающее, включены ли встроенные функции IIS Transaction Integrator (COMTI).</summary>
		/// <returns>Значение <see langword="true" />, если встроенные функции IIS включены; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public bool IISIntrinsicsEnabled
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает значение, показывающее, следует ли формировать новый контекст на основе текущего контекста или исключительно на основе информации в объекте <see cref="T:System.EnterpriseServices.ServiceConfig" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.EnterpriseServices.InheritanceOption" />. Значение по умолчанию — <see cref="F:System.EnterpriseServices.InheritanceOption.Inherit" />.</returns>
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public InheritanceOption Inheritance
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает уровень изоляции для транзакции.</summary>
		/// <returns>Одно из значений <see cref="T:System.EnterpriseServices.TransactionIsolationLevel" />. Значение по умолчанию — <see cref="F:System.EnterpriseServices.TransactionIsolationLevel.Any" />.</returns>
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public TransactionIsolationLevel IsolationLevel
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает GUID для раздела COM+, который должен использоваться.</summary>
		/// <returns>Идентификатор GUID для раздела, который должен использоваться. По умолчанию используется нулевое значение GUID.</returns>
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public Guid PartitionId
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает значение, показывающее, как разделы используются для закрытой работы.</summary>
		/// <returns>Одно из значений <see cref="T:System.EnterpriseServices.PartitionOption" />. Значение по умолчанию — <see cref="F:System.EnterpriseServices.PartitionOption.Ignore" />.</returns>
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public PartitionOption PartitionOption
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает каталог параллельной сборки для закрытой работы.</summary>
		/// <returns>Имя каталога, который необходимо использовать для параллельной сборки. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string SxsDirectory
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает имя файла параллельной сборки для выполнения закрытой работы.</summary>
		/// <returns>Имя файла параллельной сборки. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string SxsName
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает значение, показывающее способ настройки параллельной сборки.</summary>
		/// <returns>Одно из значений <see cref="T:System.EnterpriseServices.SxsOption" />. Значение по умолчанию — <see cref="F:System.EnterpriseServices.SxsOption.Ignore" />.</returns>
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public SxsOption SxsOption
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает значение, показывающее тип автоматической синхронизации, запрашиваемой компонентом.</summary>
		/// <returns>Одно из значений <see cref="T:System.EnterpriseServices.SynchronizationOption" />. Значение по умолчанию — <see cref="F:System.EnterpriseServices.SynchronizationOption.Disabled" />.</returns>
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public SynchronizationOption Synchronization
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает значение, показывающее пул потоков, который выполняет работу, представленную действием.</summary>
		/// <returns>Одно из значений <see cref="T:System.EnterpriseServices.ThreadPoolOption" />. Значение по умолчанию — <see cref="F:System.EnterpriseServices.ThreadPoolOption.None" />.</returns>
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public ThreadPoolOption ThreadPool
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает URL-адрес протокола TIP (Transaction Internet Protocol), позволяющего выполнять в существующей транзакции вложенный код.</summary>
		/// <returns>URL-адрес протокола TIP. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string TipUrl
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает текстовую строку, соответствующую идентификатору приложения, по которому предоставляется отчет о сведениях средства отслеживания.</summary>
		/// <returns>Идентификатор приложения, по которому предоставляется отчет о сведениях средства отслеживания. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string TrackingAppName
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает текстовую строку, соответствующую имени контекста, по которому предоставляется отчет о сведениях средства отслеживания.</summary>
		/// <returns>Имя контекста, по которому предоставляется отчет о сведениях средства отслеживания. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string TrackingComponentName
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает значение, указывающее, активировано ли отслеживание.</summary>
		/// <returns>Значение <see langword="true" />, если отслеживание включено; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public bool TrackingEnabled
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает значение, показывающее, как транзакции используются для закрытой работы.</summary>
		/// <returns>Одно из значений <see cref="T:System.EnterpriseServices.TransactionOption" />. Значение по умолчанию — <see cref="F:System.EnterpriseServices.TransactionOption.Disabled" />.</returns>
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public TransactionOption Transaction
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает имя, используемое при отображении статистики транзакции.</summary>
		/// <returns>Имя, используемое при отображении статистики транзакции. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public string TransactionDescription
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает или задает время ожидания транзакции для новых транзакций.</summary>
		/// <returns>Время ожидания для транзакции в секундах.</returns>
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public int TransactionTimeout
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
