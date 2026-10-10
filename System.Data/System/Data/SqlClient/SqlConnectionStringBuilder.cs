using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using Unity;

namespace System.Data.SqlClient
{
	/// <summary>Удобное средство, с помощью которого можно создавать используемые классом <see cref="T:System.Data.SqlClient.SqlConnection" /> строки соединений и управлять их содержимым.</summary>
	// Token: 0x020001DD RID: 477
	public sealed class SqlConnectionStringBuilder : DbConnectionStringBuilder
	{
		// Token: 0x0600170D RID: 5901 RVA: 0x0006904C File Offset: 0x0006724C
		private static string[] CreateValidKeywords()
		{
			string[] array = new string[29];
			array[25] = "ApplicationIntent";
			array[20] = "Application Name";
			array[2] = "AttachDbFilename";
			array[14] = "Connect Timeout";
			array[21] = "Current Language";
			array[0] = "Data Source";
			array[15] = "Encrypt";
			array[8] = "Enlist";
			array[1] = "Failover Partner";
			array[3] = "Initial Catalog";
			array[4] = "Integrated Security";
			array[17] = "Load Balance Timeout";
			array[11] = "Max Pool Size";
			array[10] = "Min Pool Size";
			array[12] = "MultipleActiveResultSets";
			array[26] = "MultiSubnetFailover";
			array[18] = "Packet Size";
			array[7] = "Password";
			array[5] = "Persist Security Info";
			array[9] = "Pooling";
			array[13] = "Replication";
			array[24] = "Transaction Binding";
			array[16] = "TrustServerCertificate";
			array[19] = "Type System Version";
			array[6] = "User ID";
			array[23] = "User Instance";
			array[22] = "Workstation ID";
			array[27] = "ConnectRetryCount";
			array[28] = "ConnectRetryInterval";
			return array;
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x0006915C File Offset: 0x0006735C
		private static Dictionary<string, SqlConnectionStringBuilder.Keywords> CreateKeywordsDictionary()
		{
			return new Dictionary<string, SqlConnectionStringBuilder.Keywords>(47, StringComparer.OrdinalIgnoreCase)
			{
				{
					"ApplicationIntent",
					SqlConnectionStringBuilder.Keywords.ApplicationIntent
				},
				{
					"Application Name",
					SqlConnectionStringBuilder.Keywords.ApplicationName
				},
				{
					"AttachDbFilename",
					SqlConnectionStringBuilder.Keywords.AttachDBFilename
				},
				{
					"Connect Timeout",
					SqlConnectionStringBuilder.Keywords.ConnectTimeout
				},
				{
					"Current Language",
					SqlConnectionStringBuilder.Keywords.CurrentLanguage
				},
				{
					"Data Source",
					SqlConnectionStringBuilder.Keywords.DataSource
				},
				{
					"Encrypt",
					SqlConnectionStringBuilder.Keywords.Encrypt
				},
				{
					"Enlist",
					SqlConnectionStringBuilder.Keywords.Enlist
				},
				{
					"Failover Partner",
					SqlConnectionStringBuilder.Keywords.FailoverPartner
				},
				{
					"Initial Catalog",
					SqlConnectionStringBuilder.Keywords.InitialCatalog
				},
				{
					"Integrated Security",
					SqlConnectionStringBuilder.Keywords.IntegratedSecurity
				},
				{
					"Load Balance Timeout",
					SqlConnectionStringBuilder.Keywords.LoadBalanceTimeout
				},
				{
					"MultipleActiveResultSets",
					SqlConnectionStringBuilder.Keywords.MultipleActiveResultSets
				},
				{
					"Max Pool Size",
					SqlConnectionStringBuilder.Keywords.MaxPoolSize
				},
				{
					"Min Pool Size",
					SqlConnectionStringBuilder.Keywords.MinPoolSize
				},
				{
					"MultiSubnetFailover",
					SqlConnectionStringBuilder.Keywords.MultiSubnetFailover
				},
				{
					"Packet Size",
					SqlConnectionStringBuilder.Keywords.PacketSize
				},
				{
					"Password",
					SqlConnectionStringBuilder.Keywords.Password
				},
				{
					"Persist Security Info",
					SqlConnectionStringBuilder.Keywords.PersistSecurityInfo
				},
				{
					"Pooling",
					SqlConnectionStringBuilder.Keywords.Pooling
				},
				{
					"Replication",
					SqlConnectionStringBuilder.Keywords.Replication
				},
				{
					"Transaction Binding",
					SqlConnectionStringBuilder.Keywords.TransactionBinding
				},
				{
					"TrustServerCertificate",
					SqlConnectionStringBuilder.Keywords.TrustServerCertificate
				},
				{
					"Type System Version",
					SqlConnectionStringBuilder.Keywords.TypeSystemVersion
				},
				{
					"User ID",
					SqlConnectionStringBuilder.Keywords.UserID
				},
				{
					"User Instance",
					SqlConnectionStringBuilder.Keywords.UserInstance
				},
				{
					"Workstation ID",
					SqlConnectionStringBuilder.Keywords.WorkstationID
				},
				{
					"ConnectRetryCount",
					SqlConnectionStringBuilder.Keywords.ConnectRetryCount
				},
				{
					"ConnectRetryInterval",
					SqlConnectionStringBuilder.Keywords.ConnectRetryInterval
				},
				{
					"app",
					SqlConnectionStringBuilder.Keywords.ApplicationName
				},
				{
					"extended properties",
					SqlConnectionStringBuilder.Keywords.AttachDBFilename
				},
				{
					"initial file name",
					SqlConnectionStringBuilder.Keywords.AttachDBFilename
				},
				{
					"connection timeout",
					SqlConnectionStringBuilder.Keywords.ConnectTimeout
				},
				{
					"timeout",
					SqlConnectionStringBuilder.Keywords.ConnectTimeout
				},
				{
					"language",
					SqlConnectionStringBuilder.Keywords.CurrentLanguage
				},
				{
					"addr",
					SqlConnectionStringBuilder.Keywords.DataSource
				},
				{
					"address",
					SqlConnectionStringBuilder.Keywords.DataSource
				},
				{
					"network address",
					SqlConnectionStringBuilder.Keywords.DataSource
				},
				{
					"server",
					SqlConnectionStringBuilder.Keywords.DataSource
				},
				{
					"database",
					SqlConnectionStringBuilder.Keywords.InitialCatalog
				},
				{
					"trusted_connection",
					SqlConnectionStringBuilder.Keywords.IntegratedSecurity
				},
				{
					"connection lifetime",
					SqlConnectionStringBuilder.Keywords.LoadBalanceTimeout
				},
				{
					"pwd",
					SqlConnectionStringBuilder.Keywords.Password
				},
				{
					"persistsecurityinfo",
					SqlConnectionStringBuilder.Keywords.PersistSecurityInfo
				},
				{
					"uid",
					SqlConnectionStringBuilder.Keywords.UserID
				},
				{
					"user",
					SqlConnectionStringBuilder.Keywords.UserID
				},
				{
					"wsid",
					SqlConnectionStringBuilder.Keywords.WorkstationID
				}
			};
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" />.</summary>
		// Token: 0x0600170F RID: 5903 RVA: 0x000693C3 File Offset: 0x000675C3
		public SqlConnectionStringBuilder() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" />. Предоставленная строка подключения содержит данные для сведений о внутреннем подключении экземпляра.</summary>
		/// <param name="connectionString">Основа для сведений о внутреннем подключении объекта. Разбито на пары имя-значение. Недопустимое имя ключа вызывает исключение <see cref="T:System.Collections.Generic.KeyNotFoundException" />.</param>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">Недопустимое имя ключа в строке подключения.</exception>
		/// <exception cref="T:System.FormatException">Недопустимое значение в строке подключения (в данном случае ожидаемое логическое или числовое значение не было передано).</exception>
		/// <exception cref="T:System.ArgumentException">Поставлено недопустимое значение <paramref name="connectionString" />.</exception>
		// Token: 0x06001710 RID: 5904 RVA: 0x000693CC File Offset: 0x000675CC
		public SqlConnectionStringBuilder(string connectionString)
		{
			if (!string.IsNullOrEmpty(connectionString))
			{
				base.ConnectionString = connectionString;
			}
		}

		/// <summary>Возвращает или задает значение, связанное с указанным ключом. В языке C# это свойство является индексатором.</summary>
		/// <param name="keyword">Ключ возвращаемого или задаваемого элемента.</param>
		/// <returns>Значение, связанное с указанным ключом.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="keyword" /> является неопределенной ссылкой (<see langword="Nothing" /> в Visual Basic).</exception>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">Попытка добавить ключ, не существующий в списке доступных ключей.</exception>
		/// <exception cref="T:System.FormatException">Недопустимое значение в строке подключения (в данном случае ожидаемое логическое или числовое значение не было передано).</exception>
		// Token: 0x17000412 RID: 1042
		public override object this[string keyword]
		{
			get
			{
				SqlConnectionStringBuilder.Keywords index = this.GetIndex(keyword);
				return this.GetAt(index);
			}
			set
			{
				if (value == null)
				{
					this.Remove(keyword);
					return;
				}
				switch (this.GetIndex(keyword))
				{
				case SqlConnectionStringBuilder.Keywords.DataSource:
					this.DataSource = SqlConnectionStringBuilder.ConvertToString(value);
					return;
				case SqlConnectionStringBuilder.Keywords.FailoverPartner:
					this.FailoverPartner = SqlConnectionStringBuilder.ConvertToString(value);
					return;
				case SqlConnectionStringBuilder.Keywords.AttachDBFilename:
					this.AttachDBFilename = SqlConnectionStringBuilder.ConvertToString(value);
					return;
				case SqlConnectionStringBuilder.Keywords.InitialCatalog:
					this.InitialCatalog = SqlConnectionStringBuilder.ConvertToString(value);
					return;
				case SqlConnectionStringBuilder.Keywords.IntegratedSecurity:
					this.IntegratedSecurity = SqlConnectionStringBuilder.ConvertToIntegratedSecurity(value);
					return;
				case SqlConnectionStringBuilder.Keywords.PersistSecurityInfo:
					this.PersistSecurityInfo = SqlConnectionStringBuilder.ConvertToBoolean(value);
					return;
				case SqlConnectionStringBuilder.Keywords.UserID:
					this.UserID = SqlConnectionStringBuilder.ConvertToString(value);
					return;
				case SqlConnectionStringBuilder.Keywords.Password:
					this.Password = SqlConnectionStringBuilder.ConvertToString(value);
					return;
				case SqlConnectionStringBuilder.Keywords.Enlist:
					this.Enlist = SqlConnectionStringBuilder.ConvertToBoolean(value);
					return;
				case SqlConnectionStringBuilder.Keywords.Pooling:
					this.Pooling = SqlConnectionStringBuilder.ConvertToBoolean(value);
					return;
				case SqlConnectionStringBuilder.Keywords.MinPoolSize:
					this.MinPoolSize = SqlConnectionStringBuilder.ConvertToInt32(value);
					return;
				case SqlConnectionStringBuilder.Keywords.MaxPoolSize:
					this.MaxPoolSize = SqlConnectionStringBuilder.ConvertToInt32(value);
					return;
				case SqlConnectionStringBuilder.Keywords.MultipleActiveResultSets:
					this.MultipleActiveResultSets = SqlConnectionStringBuilder.ConvertToBoolean(value);
					return;
				case SqlConnectionStringBuilder.Keywords.Replication:
					this.Replication = SqlConnectionStringBuilder.ConvertToBoolean(value);
					return;
				case SqlConnectionStringBuilder.Keywords.ConnectTimeout:
					this.ConnectTimeout = SqlConnectionStringBuilder.ConvertToInt32(value);
					return;
				case SqlConnectionStringBuilder.Keywords.Encrypt:
					this.Encrypt = SqlConnectionStringBuilder.ConvertToBoolean(value);
					return;
				case SqlConnectionStringBuilder.Keywords.TrustServerCertificate:
					this.TrustServerCertificate = SqlConnectionStringBuilder.ConvertToBoolean(value);
					return;
				case SqlConnectionStringBuilder.Keywords.LoadBalanceTimeout:
					this.LoadBalanceTimeout = SqlConnectionStringBuilder.ConvertToInt32(value);
					return;
				case SqlConnectionStringBuilder.Keywords.PacketSize:
					this.PacketSize = SqlConnectionStringBuilder.ConvertToInt32(value);
					return;
				case SqlConnectionStringBuilder.Keywords.TypeSystemVersion:
					this.TypeSystemVersion = SqlConnectionStringBuilder.ConvertToString(value);
					return;
				case SqlConnectionStringBuilder.Keywords.ApplicationName:
					this.ApplicationName = SqlConnectionStringBuilder.ConvertToString(value);
					return;
				case SqlConnectionStringBuilder.Keywords.CurrentLanguage:
					this.CurrentLanguage = SqlConnectionStringBuilder.ConvertToString(value);
					return;
				case SqlConnectionStringBuilder.Keywords.WorkstationID:
					this.WorkstationID = SqlConnectionStringBuilder.ConvertToString(value);
					return;
				case SqlConnectionStringBuilder.Keywords.UserInstance:
					this.UserInstance = SqlConnectionStringBuilder.ConvertToBoolean(value);
					return;
				case SqlConnectionStringBuilder.Keywords.TransactionBinding:
					this.TransactionBinding = SqlConnectionStringBuilder.ConvertToString(value);
					return;
				case SqlConnectionStringBuilder.Keywords.ApplicationIntent:
					this.ApplicationIntent = SqlConnectionStringBuilder.ConvertToApplicationIntent(keyword, value);
					return;
				case SqlConnectionStringBuilder.Keywords.MultiSubnetFailover:
					this.MultiSubnetFailover = SqlConnectionStringBuilder.ConvertToBoolean(value);
					return;
				case SqlConnectionStringBuilder.Keywords.ConnectRetryCount:
					this.ConnectRetryCount = SqlConnectionStringBuilder.ConvertToInt32(value);
					return;
				case SqlConnectionStringBuilder.Keywords.ConnectRetryInterval:
					this.ConnectRetryInterval = SqlConnectionStringBuilder.ConvertToInt32(value);
					return;
				default:
					throw this.UnsupportedKeyword(keyword);
				}
			}
		}

		/// <summary>Объявляет тип рабочей нагрузки приложения при подключении к базе данных в группе доступности SQL Server. Значение этого свойства можно задать при помощи <see cref="T:System.Data.SqlClient.ApplicationIntent" />. Дополнительные сведения о поддержке SqlClient для групп доступности Always On см. в разделе Поддержка SqlClient для высокого уровня доступности и аварийного восстановления.</summary>
		/// <returns>Возвращает текущее значение свойства (значение типа <see cref="T:System.Data.SqlClient.ApplicationIntent" />).</returns>
		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x000696E0 File Offset: 0x000678E0
		// (set) Token: 0x06001714 RID: 5908 RVA: 0x000696E8 File Offset: 0x000678E8
		public ApplicationIntent ApplicationIntent
		{
			get
			{
				return this._applicationIntent;
			}
			set
			{
				if (!DbConnectionStringBuilderUtil.IsValidApplicationIntentValue(value))
				{
					throw ADP.InvalidEnumerationValue(typeof(ApplicationIntent), (int)value);
				}
				this.SetApplicationIntentValue(value);
				this._applicationIntent = value;
			}
		}

		/// <summary>Возвращает или задает имя приложения, связанного со строкой подключения.</summary>
		/// <returns>Имя приложения или «.NET SqlClient Data Provider», если имя не указано.</returns>
		/// <exception cref="T:System.ArgumentNullException">Чтобы задать значение NULL, используйте <see cref="F:System.DBNull.Value" />.</exception>
		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x00069711 File Offset: 0x00067911
		// (set) Token: 0x06001716 RID: 5910 RVA: 0x00069719 File Offset: 0x00067919
		public string ApplicationName
		{
			get
			{
				return this._applicationName;
			}
			set
			{
				this.SetValue("Application Name", value);
				this._applicationName = value;
			}
		}

		/// <summary>Возвращает или задает строку, содержащую имя первичного файла данных. Оно включает полный путь к подключаемой базе данных.</summary>
		/// <returns>Значение свойства <see langword="AttachDBFilename" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		/// <exception cref="T:System.ArgumentNullException">Чтобы задать значение NULL, используйте <see cref="F:System.DBNull.Value" />.</exception>
		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x0006972E File Offset: 0x0006792E
		// (set) Token: 0x06001718 RID: 5912 RVA: 0x00069736 File Offset: 0x00067936
		public string AttachDBFilename
		{
			get
			{
				return this._attachDBFilename;
			}
			set
			{
				this.SetValue("AttachDbFilename", value);
				this._attachDBFilename = value;
			}
		}

		/// <summary>Получает или задает продолжительность времени ожидания подключения к серверу (в секундах) перед прекращением попытки подключения и созданием ошибки.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.ConnectTimeout" /> или 15 секунд, если значение не указано.</returns>
		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x0006974B File Offset: 0x0006794B
		// (set) Token: 0x0600171A RID: 5914 RVA: 0x00069753 File Offset: 0x00067953
		public int ConnectTimeout
		{
			get
			{
				return this._connectTimeout;
			}
			set
			{
				if (value < 0)
				{
					throw ADP.InvalidConnectionOptionValue("Connect Timeout");
				}
				this.SetValue("Connect Timeout", value);
				this._connectTimeout = value;
			}
		}

		/// <summary>Возвращает или задает имя записи языка SQL Server.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.CurrentLanguage" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		/// <exception cref="T:System.ArgumentNullException">Чтобы задать значение NULL, используйте <see cref="F:System.DBNull.Value" />.</exception>
		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x00069777 File Offset: 0x00067977
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x0006977F File Offset: 0x0006797F
		public string CurrentLanguage
		{
			get
			{
				return this._currentLanguage;
			}
			set
			{
				this.SetValue("Current Language", value);
				this._currentLanguage = value;
			}
		}

		/// <summary>Возвращает или задает имя или сетевой адрес экземпляра SQL Server, с которым устанавливается соединение.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.DataSource" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		/// <exception cref="T:System.ArgumentNullException">Чтобы задать значение NULL, используйте <see cref="F:System.DBNull.Value" />.</exception>
		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x00069794 File Offset: 0x00067994
		// (set) Token: 0x0600171E RID: 5918 RVA: 0x0006979C File Offset: 0x0006799C
		public string DataSource
		{
			get
			{
				return this._dataSource;
			}
			set
			{
				this.SetValue("Data Source", value);
				this._dataSource = value;
			}
		}

		/// <summary>Возвращает или задает логическое значение, указывающее, использует ли SQL Server шифрование SSL для всех данных, передаваемых между клиентом и сервером, если на сервере установлен сертификат.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.Encrypt" /> или <see langword="false" />, если значение не указано.</returns>
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x000697B1 File Offset: 0x000679B1
		// (set) Token: 0x06001720 RID: 5920 RVA: 0x000697B9 File Offset: 0x000679B9
		public bool Encrypt
		{
			get
			{
				return this._encrypt;
			}
			set
			{
				this.SetValue("Encrypt", value);
				this._encrypt = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, будет ли шифроваться канал, если обход цепочки сертификатов для проверки доверия не выполняется.</summary>
		/// <returns>Объект <see langword="Boolean" />. Допустимые значения: <see langword="true" />, <see langword="false" />, <see langword="yes" /> и <see langword="no" />.</returns>
		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x000697CE File Offset: 0x000679CE
		// (set) Token: 0x06001722 RID: 5922 RVA: 0x000697D6 File Offset: 0x000679D6
		public bool TrustServerCertificate
		{
			get
			{
				return this._trustServerCertificate;
			}
			set
			{
				this.SetValue("TrustServerCertificate", value);
				this._trustServerCertificate = value;
			}
		}

		/// <summary>Возвращает или задает логическое значение, которое определяет, добавляет ли автоматически процесс SQL Server, обслуживающий пул, соединение в контекст текущей транзакции создающего ее потока.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.Enlist" /> или <see langword="true" />, если значение не указано.</returns>
		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x000697EB File Offset: 0x000679EB
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x000697F3 File Offset: 0x000679F3
		public bool Enlist
		{
			get
			{
				return this._enlist;
			}
			set
			{
				this.SetValue("Enlist", value);
				this._enlist = value;
			}
		}

		/// <summary>Возвращает или задает имя или адрес сервера-участника, к которому осуществляется подключение, если сервер-источник недоступен.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.FailoverPartner" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		/// <exception cref="T:System.ArgumentNullException">Чтобы задать значение NULL, используйте <see cref="F:System.DBNull.Value" />.</exception>
		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x00069808 File Offset: 0x00067A08
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x00069810 File Offset: 0x00067A10
		public string FailoverPartner
		{
			get
			{
				return this._failoverPartner;
			}
			set
			{
				this.SetValue("Failover Partner", value);
				this._failoverPartner = value;
			}
		}

		/// <summary>Возвращает или задает имя базы данных, связанной с подключением.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.InitialCatalog" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		/// <exception cref="T:System.ArgumentNullException">Чтобы задать значение NULL, используйте <see cref="F:System.DBNull.Value" />.</exception>
		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x00069825 File Offset: 0x00067A25
		// (set) Token: 0x06001728 RID: 5928 RVA: 0x0006982D File Offset: 0x00067A2D
		[TypeConverter(typeof(SqlConnectionStringBuilder.SqlInitialCatalogConverter))]
		public string InitialCatalog
		{
			get
			{
				return this._initialCatalog;
			}
			set
			{
				this.SetValue("Initial Catalog", value);
				this._initialCatalog = value;
			}
		}

		/// <summary>Возвращает или задает логическое значение, определяющее способ проверки подлинности: либо при подключении указаны идентификатор пользователя и пароль (значение <see langword="false" />), либо использованы учетные данные текущей учетной записи Windows (значение <see langword="true" />).</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.IntegratedSecurity" /> или <see langword="false" />, если значение не указано.</returns>
		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x00069842 File Offset: 0x00067A42
		// (set) Token: 0x0600172A RID: 5930 RVA: 0x0006984A File Offset: 0x00067A4A
		public bool IntegratedSecurity
		{
			get
			{
				return this._integratedSecurity;
			}
			set
			{
				this.SetValue("Integrated Security", value);
				this._integratedSecurity = value;
			}
		}

		/// <summary>Возвращает или задает минимальное время ожидания в секундах перед уничтожением соединения, находящегося в пуле.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.LoadBalanceTimeout" /> или 0, если значение не указано.</returns>
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x0006985F File Offset: 0x00067A5F
		// (set) Token: 0x0600172C RID: 5932 RVA: 0x00069867 File Offset: 0x00067A67
		public int LoadBalanceTimeout
		{
			get
			{
				return this._loadBalanceTimeout;
			}
			set
			{
				if (value < 0)
				{
					throw ADP.InvalidConnectionOptionValue("Load Balance Timeout");
				}
				this.SetValue("Load Balance Timeout", value);
				this._loadBalanceTimeout = value;
			}
		}

		/// <summary>Возвращает или задает максимальное количество соединений в пуле для данной строки подключения.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.MaxPoolSize" /> или 100, если значение не указано.</returns>
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x0006988B File Offset: 0x00067A8B
		// (set) Token: 0x0600172E RID: 5934 RVA: 0x00069893 File Offset: 0x00067A93
		public int MaxPoolSize
		{
			get
			{
				return this._maxPoolSize;
			}
			set
			{
				if (value < 1)
				{
					throw ADP.InvalidConnectionOptionValue("Max Pool Size");
				}
				this.SetValue("Max Pool Size", value);
				this._maxPoolSize = value;
			}
		}

		/// <summary>Количество повторных попыток подключения после обнаружения простоя при сбое подключения. Это должно быть целое число в диапазоне от 0 до 255. Значение по умолчанию — 1. Задайте значение 0, чтобы запретить повторное подключение при сбое подключения. Будет создано <see cref="T:System.ArgumentException" />, если заданное значение окажется вне допустимого диапазона.</summary>
		/// <returns>Количество повторных попыток подключения после обнаружения простоя при сбое подключения.</returns>
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x000698B7 File Offset: 0x00067AB7
		// (set) Token: 0x06001730 RID: 5936 RVA: 0x000698BF File Offset: 0x00067ABF
		public int ConnectRetryCount
		{
			get
			{
				return this._connectRetryCount;
			}
			set
			{
				if (value < 0 || value > 255)
				{
					throw ADP.InvalidConnectionOptionValue("ConnectRetryCount");
				}
				this.SetValue("ConnectRetryCount", value);
				this._connectRetryCount = value;
			}
		}

		/// <summary>Количество времени (в секундах) между попытками повторного подключения после идентификации сбоя неактивного подключения. Это должно быть целое число в диапазоне от 1 до 60. По умолчанию используется значение 10 секунд. Будет вызван <see cref="T:System.ArgumentException" />, если будет задано значение вне допустимого диапазона.</summary>
		/// <returns>Количество времени (в секундах) между попытками повторного подключения после идентификации сбоя неактивного подключения.</returns>
		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x000698EB File Offset: 0x00067AEB
		// (set) Token: 0x06001732 RID: 5938 RVA: 0x000698F3 File Offset: 0x00067AF3
		public int ConnectRetryInterval
		{
			get
			{
				return this._connectRetryInterval;
			}
			set
			{
				if (value < 1 || value > 60)
				{
					throw ADP.InvalidConnectionOptionValue("ConnectRetryInterval");
				}
				this.SetValue("ConnectRetryInterval", value);
				this._connectRetryInterval = value;
			}
		}

		/// <summary>Возвращает или задает минимальное количество подключений в пуле для данной строки подключения.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.MinPoolSize" /> или 0, если значение не указано.</returns>
		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x0006991C File Offset: 0x00067B1C
		// (set) Token: 0x06001734 RID: 5940 RVA: 0x00069924 File Offset: 0x00067B24
		public int MinPoolSize
		{
			get
			{
				return this._minPoolSize;
			}
			set
			{
				if (value < 0)
				{
					throw ADP.InvalidConnectionOptionValue("Min Pool Size");
				}
				this.SetValue("Min Pool Size", value);
				this._minPoolSize = value;
			}
		}

		/// <summary>Если указано значение true, приложение может поддерживать несколько активных наборов результатов (режим MARS). Если указано значение false, приложение должно обработать или отменить все наборы результатов из одного пакета, прежде чем выполнять любой другой пакет для данного подключения.  
		/// Дополнительные сведения см. в разделе Несколько активных результирующих наборов (MARS).</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.MultipleActiveResultSets" /> или <see langword="false" />, если значение не указано.</returns>
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x00069948 File Offset: 0x00067B48
		// (set) Token: 0x06001736 RID: 5942 RVA: 0x00069950 File Offset: 0x00067B50
		public bool MultipleActiveResultSets
		{
			get
			{
				return this._multipleActiveResultSets;
			}
			set
			{
				this.SetValue("MultipleActiveResultSets", value);
				this._multipleActiveResultSets = value;
			}
		}

		/// <summary>Если приложение подключается к группе доступности AlwaysOn в другой подсети, при задании MultiSubnetFailover=true обеспечивается более быстрое обнаружение и подключение к доступному (в данный момент) серверу. Дополнительные сведения о поддержке SqlClient для групп доступности Always On см. в разделе Поддержка SqlClient для высокого уровня доступности и аварийного восстановления.</summary>
		/// <returns>Возвращает <see cref="T:System.Boolean" />, указывающее текущее значение свойства.</returns>
		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00069965 File Offset: 0x00067B65
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x0006996D File Offset: 0x00067B6D
		public bool MultiSubnetFailover
		{
			get
			{
				return this._multiSubnetFailover;
			}
			set
			{
				this.SetValue("MultiSubnetFailover", value);
				this._multiSubnetFailover = value;
			}
		}

		/// <summary>Возвращает или задает размер сетевых пакетов (в байтах), используемых при взаимодействии с экземпляром SQL Server.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.PacketSize" /> или 8000, если значение не указано.</returns>
		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x00069982 File Offset: 0x00067B82
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x0006998A File Offset: 0x00067B8A
		public int PacketSize
		{
			get
			{
				return this._packetSize;
			}
			set
			{
				if (value < 512 || 32768 < value)
				{
					throw SQL.InvalidPacketSizeValue();
				}
				this.SetValue("Packet Size", value);
				this._packetSize = value;
			}
		}

		/// <summary>Возвращает или задает пароль для учетной записи SQL Server.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.Password" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для пароля было задано значение NULL, что неверно.  Образец исходного кода см. далее.</exception>
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x000699B5 File Offset: 0x00067BB5
		// (set) Token: 0x0600173C RID: 5948 RVA: 0x000699BD File Offset: 0x00067BBD
		public string Password
		{
			get
			{
				return this._password;
			}
			set
			{
				this.SetValue("Password", value);
				this._password = value;
			}
		}

		/// <summary>Возвращает или задает логическое значение, которое определяет, возвращаются ли сведения, связанные с безопасностью (такие как пароль), как часть подключения, если оно открыто или когда-либо находилось в открытом состоянии.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.PersistSecurityInfo" /> или <see langword="false" />, если значение не указано.</returns>
		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x000699D2 File Offset: 0x00067BD2
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x000699DA File Offset: 0x00067BDA
		public bool PersistSecurityInfo
		{
			get
			{
				return this._persistSecurityInfo;
			}
			set
			{
				this.SetValue("Persist Security Info", value);
				this._persistSecurityInfo = value;
			}
		}

		/// <summary>Возвращает или задает логическое значение, которое определяет, будет ли соединение добавлено в пул или каждое соединение будет явно открываться каждый раз, когда поступает запрос на соединение.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.Pooling" /> или <see langword="true" />, если значение не указано.</returns>
		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x000699EF File Offset: 0x00067BEF
		// (set) Token: 0x06001740 RID: 5952 RVA: 0x000699F7 File Offset: 0x00067BF7
		public bool Pooling
		{
			get
			{
				return this._pooling;
			}
			set
			{
				this.SetValue("Pooling", value);
				this._pooling = value;
			}
		}

		/// <summary>Возвращает или задает логическое значение, указывающее, можно ли с помощью этого соединения выполнять репликацию.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.Replication" /> или false, если значение не указано.</returns>
		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x00069A0C File Offset: 0x00067C0C
		// (set) Token: 0x06001742 RID: 5954 RVA: 0x00069A14 File Offset: 0x00067C14
		public bool Replication
		{
			get
			{
				return this._replication;
			}
			set
			{
				this.SetValue("Replication", value);
				this._replication = value;
			}
		}

		/// <summary>Возвращает или задает строковое значение, указывающее, как соединение поддерживает связь с прикрепленной транзакцией <see langword="System.Transactions" />.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.TransactionBinding" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00069A29 File Offset: 0x00067C29
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x00069A31 File Offset: 0x00067C31
		public string TransactionBinding
		{
			get
			{
				return this._transactionBinding;
			}
			set
			{
				this.SetValue("Transaction Binding", value);
				this._transactionBinding = value;
			}
		}

		/// <summary>Возвращает или задает строковое значение, определяющее систему типов, ожидаемую приложением.</summary>
		/// <returns>В следующей таблице описаны возможные значения свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.TypeSystemVersion" />. 
		///   Значение 
		///   Описание 
		///   SQL Server 2005 
		///   Используется система типов SQL Server 2005. Для текущей версии ADO.NET никакое преобразование не выполняется.  
		///   SQL Server 2008 
		///   Используется система типов SQL Server 2008.  
		///   Последняя версия 
		///   Используется последняя версия, с которой может работать эта пара клиент-сервер. При обновлении клиентского и серверного компонентов она автоматически обновляется.</returns>
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x00069A46 File Offset: 0x00067C46
		// (set) Token: 0x06001746 RID: 5958 RVA: 0x00069A4E File Offset: 0x00067C4E
		public string TypeSystemVersion
		{
			get
			{
				return this._typeSystemVersion;
			}
			set
			{
				this.SetValue("Type System Version", value);
				this._typeSystemVersion = value;
			}
		}

		/// <summary>Возвращает или задает идентификатор пользователя, который должен использоваться при подключении к SQL Server.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.UserID" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		/// <exception cref="T:System.ArgumentNullException">Чтобы задать значение NULL, используйте <see cref="F:System.DBNull.Value" />.</exception>
		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x00069A63 File Offset: 0x00067C63
		// (set) Token: 0x06001748 RID: 5960 RVA: 0x00069A6B File Offset: 0x00067C6B
		public string UserID
		{
			get
			{
				return this._userID;
			}
			set
			{
				this.SetValue("User ID", value);
				this._userID = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, следует ли перенаправлять подключение от используемого по умолчанию экземпляра SQL Server Express к запущенному исполняющей средой экземпляру, который выполняется с учетной записью вызывающего кода.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.UserInstance" /> или <see langword="False" />, если значение не указано.</returns>
		/// <exception cref="T:System.ArgumentNullException">Чтобы задать значение NULL, используйте <see cref="F:System.DBNull.Value" />.</exception>
		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x00069A80 File Offset: 0x00067C80
		// (set) Token: 0x0600174A RID: 5962 RVA: 0x00069A88 File Offset: 0x00067C88
		public bool UserInstance
		{
			get
			{
				return this._userInstance;
			}
			set
			{
				this.SetValue("User Instance", value);
				this._userInstance = value;
			}
		}

		/// <summary>Возвращает или задает имя рабочей станции, подключающейся к SQL Server.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.WorkstationID" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		/// <exception cref="T:System.ArgumentNullException">Чтобы задать значение NULL, используйте <see cref="F:System.DBNull.Value" />.</exception>
		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x00069A9D File Offset: 0x00067C9D
		// (set) Token: 0x0600174C RID: 5964 RVA: 0x00069AA5 File Offset: 0x00067CA5
		public string WorkstationID
		{
			get
			{
				return this._workstationID;
			}
			set
			{
				this.SetValue("Workstation ID", value);
				this._workstationID = value;
			}
		}

		/// <summary>Возвращает коллекцию <see cref="T:System.Collections.ICollection" />, которая содержит ключи из <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, которая содержит ключи из <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" />.</returns>
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x00069ABA File Offset: 0x00067CBA
		public override ICollection Keys
		{
			get
			{
				return new ReadOnlyCollection<string>(SqlConnectionStringBuilder.s_validKeywords);
			}
		}

		/// <summary>Возвращает коллекцию <see cref="T:System.Collections.ICollection" />, которая содержит значения в <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, которая содержит значения из <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" />.</returns>
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x00069AC8 File Offset: 0x00067CC8
		public override ICollection Values
		{
			get
			{
				object[] array = new object[SqlConnectionStringBuilder.s_validKeywords.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = this.GetAt((SqlConnectionStringBuilder.Keywords)i);
				}
				return new ReadOnlyCollection<object>(array);
			}
		}

		/// <summary>Удаляет содержимое экземпляра <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" />.</summary>
		// Token: 0x0600174F RID: 5967 RVA: 0x00069B00 File Offset: 0x00067D00
		public override void Clear()
		{
			base.Clear();
			for (int i = 0; i < SqlConnectionStringBuilder.s_validKeywords.Length; i++)
			{
				this.Reset((SqlConnectionStringBuilder.Keywords)i);
			}
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" /> указанный ключ.</summary>
		/// <param name="keyword">Ключ, который требуется найти в <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" />.</param>
		/// <returns>Значение true, если объект <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" /> содержит элемент, который имеет заданный ключ. В противном случае — значение false.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keyword" /> имеет значение NULL (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x06001750 RID: 5968 RVA: 0x00069B2C File Offset: 0x00067D2C
		public override bool ContainsKey(string keyword)
		{
			ADP.CheckArgumentNull(keyword, "keyword");
			return SqlConnectionStringBuilder.s_keywords.ContainsKey(keyword);
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00069B44 File Offset: 0x00067D44
		private static bool ConvertToBoolean(object value)
		{
			return DbConnectionStringBuilderUtil.ConvertToBoolean(value);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00069B4C File Offset: 0x00067D4C
		private static int ConvertToInt32(object value)
		{
			return DbConnectionStringBuilderUtil.ConvertToInt32(value);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00069B54 File Offset: 0x00067D54
		private static bool ConvertToIntegratedSecurity(object value)
		{
			return DbConnectionStringBuilderUtil.ConvertToIntegratedSecurity(value);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00069B5C File Offset: 0x00067D5C
		private static string ConvertToString(object value)
		{
			return DbConnectionStringBuilderUtil.ConvertToString(value);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00069B64 File Offset: 0x00067D64
		private static ApplicationIntent ConvertToApplicationIntent(string keyword, object value)
		{
			return DbConnectionStringBuilderUtil.ConvertToApplicationIntent(keyword, value);
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00069B70 File Offset: 0x00067D70
		private object GetAt(SqlConnectionStringBuilder.Keywords index)
		{
			switch (index)
			{
			case SqlConnectionStringBuilder.Keywords.DataSource:
				return this.DataSource;
			case SqlConnectionStringBuilder.Keywords.FailoverPartner:
				return this.FailoverPartner;
			case SqlConnectionStringBuilder.Keywords.AttachDBFilename:
				return this.AttachDBFilename;
			case SqlConnectionStringBuilder.Keywords.InitialCatalog:
				return this.InitialCatalog;
			case SqlConnectionStringBuilder.Keywords.IntegratedSecurity:
				return this.IntegratedSecurity;
			case SqlConnectionStringBuilder.Keywords.PersistSecurityInfo:
				return this.PersistSecurityInfo;
			case SqlConnectionStringBuilder.Keywords.UserID:
				return this.UserID;
			case SqlConnectionStringBuilder.Keywords.Password:
				return this.Password;
			case SqlConnectionStringBuilder.Keywords.Enlist:
				return this.Enlist;
			case SqlConnectionStringBuilder.Keywords.Pooling:
				return this.Pooling;
			case SqlConnectionStringBuilder.Keywords.MinPoolSize:
				return this.MinPoolSize;
			case SqlConnectionStringBuilder.Keywords.MaxPoolSize:
				return this.MaxPoolSize;
			case SqlConnectionStringBuilder.Keywords.MultipleActiveResultSets:
				return this.MultipleActiveResultSets;
			case SqlConnectionStringBuilder.Keywords.Replication:
				return this.Replication;
			case SqlConnectionStringBuilder.Keywords.ConnectTimeout:
				return this.ConnectTimeout;
			case SqlConnectionStringBuilder.Keywords.Encrypt:
				return this.Encrypt;
			case SqlConnectionStringBuilder.Keywords.TrustServerCertificate:
				return this.TrustServerCertificate;
			case SqlConnectionStringBuilder.Keywords.LoadBalanceTimeout:
				return this.LoadBalanceTimeout;
			case SqlConnectionStringBuilder.Keywords.PacketSize:
				return this.PacketSize;
			case SqlConnectionStringBuilder.Keywords.TypeSystemVersion:
				return this.TypeSystemVersion;
			case SqlConnectionStringBuilder.Keywords.ApplicationName:
				return this.ApplicationName;
			case SqlConnectionStringBuilder.Keywords.CurrentLanguage:
				return this.CurrentLanguage;
			case SqlConnectionStringBuilder.Keywords.WorkstationID:
				return this.WorkstationID;
			case SqlConnectionStringBuilder.Keywords.UserInstance:
				return this.UserInstance;
			case SqlConnectionStringBuilder.Keywords.TransactionBinding:
				return this.TransactionBinding;
			case SqlConnectionStringBuilder.Keywords.ApplicationIntent:
				return this.ApplicationIntent;
			case SqlConnectionStringBuilder.Keywords.MultiSubnetFailover:
				return this.MultiSubnetFailover;
			case SqlConnectionStringBuilder.Keywords.ConnectRetryCount:
				return this.ConnectRetryCount;
			case SqlConnectionStringBuilder.Keywords.ConnectRetryInterval:
				return this.ConnectRetryInterval;
			default:
				throw this.UnsupportedKeyword(SqlConnectionStringBuilder.s_validKeywords[(int)index]);
			}
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00069D30 File Offset: 0x00067F30
		private SqlConnectionStringBuilder.Keywords GetIndex(string keyword)
		{
			ADP.CheckArgumentNull(keyword, "keyword");
			SqlConnectionStringBuilder.Keywords result;
			if (SqlConnectionStringBuilder.s_keywords.TryGetValue(keyword, out result))
			{
				return result;
			}
			throw this.UnsupportedKeyword(keyword);
		}

		/// <summary>Удаляет из экземпляра <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" /> запись с указанным ключом.</summary>
		/// <param name="keyword">Ключ пары «ключ-значение», удаляемой из строки подключения в этом объекте <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" />.</param>
		/// <returns>Значение <see langword="true" />, если ключ был указан в строке подключения и был удален. Значение <see langword="false" />, если такого ключа не было.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keyword" /> имеет значение NULL (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x06001758 RID: 5976 RVA: 0x00069D60 File Offset: 0x00067F60
		public override bool Remove(string keyword)
		{
			ADP.CheckArgumentNull(keyword, "keyword");
			SqlConnectionStringBuilder.Keywords keywords;
			if (SqlConnectionStringBuilder.s_keywords.TryGetValue(keyword, out keywords) && base.Remove(SqlConnectionStringBuilder.s_validKeywords[(int)keywords]))
			{
				this.Reset(keywords);
				return true;
			}
			return false;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00069DA0 File Offset: 0x00067FA0
		private void Reset(SqlConnectionStringBuilder.Keywords index)
		{
			switch (index)
			{
			case SqlConnectionStringBuilder.Keywords.DataSource:
				this._dataSource = "";
				return;
			case SqlConnectionStringBuilder.Keywords.FailoverPartner:
				this._failoverPartner = "";
				return;
			case SqlConnectionStringBuilder.Keywords.AttachDBFilename:
				this._attachDBFilename = "";
				return;
			case SqlConnectionStringBuilder.Keywords.InitialCatalog:
				this._initialCatalog = "";
				return;
			case SqlConnectionStringBuilder.Keywords.IntegratedSecurity:
				this._integratedSecurity = false;
				return;
			case SqlConnectionStringBuilder.Keywords.PersistSecurityInfo:
				this._persistSecurityInfo = false;
				return;
			case SqlConnectionStringBuilder.Keywords.UserID:
				this._userID = "";
				return;
			case SqlConnectionStringBuilder.Keywords.Password:
				this._password = "";
				return;
			case SqlConnectionStringBuilder.Keywords.Enlist:
				this._enlist = true;
				return;
			case SqlConnectionStringBuilder.Keywords.Pooling:
				this._pooling = true;
				return;
			case SqlConnectionStringBuilder.Keywords.MinPoolSize:
				this._minPoolSize = 0;
				return;
			case SqlConnectionStringBuilder.Keywords.MaxPoolSize:
				this._maxPoolSize = 100;
				return;
			case SqlConnectionStringBuilder.Keywords.MultipleActiveResultSets:
				this._multipleActiveResultSets = false;
				return;
			case SqlConnectionStringBuilder.Keywords.Replication:
				this._replication = false;
				return;
			case SqlConnectionStringBuilder.Keywords.ConnectTimeout:
				this._connectTimeout = 15;
				return;
			case SqlConnectionStringBuilder.Keywords.Encrypt:
				this._encrypt = false;
				return;
			case SqlConnectionStringBuilder.Keywords.TrustServerCertificate:
				this._trustServerCertificate = false;
				return;
			case SqlConnectionStringBuilder.Keywords.LoadBalanceTimeout:
				this._loadBalanceTimeout = 0;
				return;
			case SqlConnectionStringBuilder.Keywords.PacketSize:
				this._packetSize = 8000;
				return;
			case SqlConnectionStringBuilder.Keywords.TypeSystemVersion:
				this._typeSystemVersion = "Latest";
				return;
			case SqlConnectionStringBuilder.Keywords.ApplicationName:
				this._applicationName = "Core .Net SqlClient Data Provider";
				return;
			case SqlConnectionStringBuilder.Keywords.CurrentLanguage:
				this._currentLanguage = "";
				return;
			case SqlConnectionStringBuilder.Keywords.WorkstationID:
				this._workstationID = "";
				return;
			case SqlConnectionStringBuilder.Keywords.UserInstance:
				this._userInstance = false;
				return;
			case SqlConnectionStringBuilder.Keywords.TransactionBinding:
				this._transactionBinding = "Implicit Unbind";
				return;
			case SqlConnectionStringBuilder.Keywords.ApplicationIntent:
				this._applicationIntent = ApplicationIntent.ReadWrite;
				return;
			case SqlConnectionStringBuilder.Keywords.MultiSubnetFailover:
				this._multiSubnetFailover = false;
				return;
			case SqlConnectionStringBuilder.Keywords.ConnectRetryCount:
				this._connectRetryCount = 1;
				return;
			case SqlConnectionStringBuilder.Keywords.ConnectRetryInterval:
				this._connectRetryInterval = 10;
				return;
			default:
				throw this.UnsupportedKeyword(SqlConnectionStringBuilder.s_validKeywords[(int)index]);
			}
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00069F54 File Offset: 0x00068154
		private void SetValue(string keyword, bool value)
		{
			base[keyword] = value.ToString();
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00069F64 File Offset: 0x00068164
		private void SetValue(string keyword, int value)
		{
			base[keyword] = value.ToString(null);
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00069F75 File Offset: 0x00068175
		private void SetValue(string keyword, string value)
		{
			ADP.CheckArgumentNull(value, keyword);
			base[keyword] = value;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00069F86 File Offset: 0x00068186
		private void SetApplicationIntentValue(ApplicationIntent value)
		{
			base["ApplicationIntent"] = DbConnectionStringBuilderUtil.ApplicationIntentToString(value);
		}

		/// <summary>Указывает, существует ли заданный ключ в этом экземпляре <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" />.</summary>
		/// <param name="keyword">Ключ, который требуется найти в <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" />.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" /> содержит запись с указанным ключом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600175E RID: 5982 RVA: 0x00069F9C File Offset: 0x0006819C
		public override bool ShouldSerialize(string keyword)
		{
			ADP.CheckArgumentNull(keyword, "keyword");
			SqlConnectionStringBuilder.Keywords keywords;
			return SqlConnectionStringBuilder.s_keywords.TryGetValue(keyword, out keywords) && base.ShouldSerialize(SqlConnectionStringBuilder.s_validKeywords[(int)keywords]);
		}

		/// <summary>Получает значение, соответствующее заданному ключу, из данного объекта <see cref="T:System.Data.SqlClient.SqlConnectionStringBuilder" />.</summary>
		/// <param name="keyword">Ключ искомого элемента.</param>
		/// <param name="value">Значение, соответствующее <paramref name="keyword" />.</param>
		/// <returns>Значение <see langword="true" />, если значение <paramref name="keyword" /> найдено в строке подключения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keyword" /> содержит значение NULL (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x0600175F RID: 5983 RVA: 0x00069FD4 File Offset: 0x000681D4
		public override bool TryGetValue(string keyword, out object value)
		{
			SqlConnectionStringBuilder.Keywords index;
			if (SqlConnectionStringBuilder.s_keywords.TryGetValue(keyword, out index))
			{
				value = this.GetAt(index);
				return true;
			}
			value = null;
			return false;
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00069FFF File Offset: 0x000681FF
		private Exception UnsupportedKeyword(string keyword)
		{
			if (SqlConnectionStringBuilder.s_notSupportedKeywords.Contains(keyword, StringComparer.OrdinalIgnoreCase))
			{
				return SQL.UnsupportedKeyword(keyword);
			}
			if (SqlConnectionStringBuilder.s_notSupportedNetworkLibraryKeywords.Contains(keyword, StringComparer.OrdinalIgnoreCase))
			{
				return SQL.NetworkLibraryKeywordNotSupported();
			}
			return ADP.KeywordNotSupported(keyword);
		}

		/// <summary>Возвращает или задает логическое значение, указывающее, допускается ли асинхронная обработка соединением, созданным с использованием данной строки подключения.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.AsynchronousProcessing" /> или <see langword="false" />, если значение не указано.</returns>
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x0006A038 File Offset: 0x00068238
		// (set) Token: 0x06001762 RID: 5986 RVA: 0x0006A040 File Offset: 0x00068240
		[Obsolete("This property is ignored beginning in .NET Framework 4.5.For more information about SqlClient support for asynchronous programming, seehttps://docs.microsoft.com/en-us/dotnet/framework/data/adonet/asynchronous-programming")]
		public bool AsynchronousProcessing { get; set; }

		/// <summary>Является устаревшей. Возвращает или задает логическое значение, указывающее, следует ли сбрасывать соединение при извлечении его из пула.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.ConnectionReset" /> или true, если значение не указано.</returns>
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x0006A049 File Offset: 0x00068249
		// (set) Token: 0x06001764 RID: 5988 RVA: 0x0006A051 File Offset: 0x00068251
		[Obsolete("ConnectionReset has been deprecated.  SqlConnection will ignore the 'connection reset'keyword and always reset the connection")]
		public bool ConnectionReset { get; set; }

		/// <summary>Возвращает способ проверки подлинности строки подключения.</summary>
		/// <returns>Способ проверки подлинности строки подключения.</returns>
		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x00010C60 File Offset: 0x0000EE60
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x00010C60 File Offset: 0x0000EE60
		[MonoTODO("Not implemented in corefx: https://github.com/dotnet/corefx/issues/22474")]
		public SqlAuthenticationMethod Authentication
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

		/// <summary>Возвращает или задает значение, указывающее, какое следует установить соединение с SQL Server: клиент-серверное или внутрипроцессное.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.ContextConnection" /> или <see langword="False" />, если значение не указано.</returns>
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x00010C60 File Offset: 0x0000EE60
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x00010C60 File Offset: 0x0000EE60
		[MonoTODO("Not implemented in corefx: https://github.com/dotnet/corefx/issues/22474")]
		public bool ContextConnection
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

		/// <summary>Возвращает или задает строку, которая содержит имя сетевой библиотеки, используемой для установления подключения с SQL Server.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.SqlClient.SqlConnectionStringBuilder.NetworkLibrary" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		/// <exception cref="T:System.ArgumentNullException">Чтобы задать значение NULL, используйте <see cref="F:System.DBNull.Value" />.</exception>
		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00010C60 File Offset: 0x0000EE60
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x00010C60 File Offset: 0x0000EE60
		[MonoTODO("Not implemented in corefx: https://github.com/dotnet/corefx/issues/22474")]
		public string NetworkLibrary
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

		/// <summary>Поведение периода блокировки для пула подключений.</summary>
		/// <returns>Доступные параметры периода блокировки.</returns>
		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x00010C60 File Offset: 0x0000EE60
		// (set) Token: 0x0600176C RID: 5996 RVA: 0x00010C60 File Offset: 0x0000EE60
		[MonoTODO("Not implemented in corefx: https://github.com/dotnet/corefx/issues/22474")]
		public PoolBlockingPeriod PoolBlockingPeriod
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

		/// <summary>Если этому ключу присвоено значение <see langword="true" />, приложение должно получить все IP-адреса для определенной записи DNS, а затем попытаться подключиться по первому адресу в списке. Если подключение не устанавливается в течение 0,5 секунды, приложение попытается параллельно подключиться по другим адресам. При получении первого ответа приложение устанавливает подключение по соответствующему IP-адресу.</summary>
		/// <returns>Логическое значение.</returns>
		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x00010C60 File Offset: 0x0000EE60
		// (set) Token: 0x0600176E RID: 5998 RVA: 0x00010C60 File Offset: 0x0000EE60
		[MonoTODO("Not implemented in corefx: https://github.com/dotnet/corefx/issues/22474")]
		public bool TransparentNetworkIPResolution
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

		/// <summary>Получает или задает параметры шифрования столбца для построителя строк подключения.</summary>
		/// <returns>Параметры шифрования столбца для построителя строки подключения.</returns>
		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600176F RID: 5999 RVA: 0x00010C60 File Offset: 0x0000EE60
		// (set) Token: 0x06001770 RID: 6000 RVA: 0x00010C60 File Offset: 0x0000EE60
		[MonoTODO("Not implemented in corefx: https://github.com/dotnet/corefx/issues/22474")]
		public SqlConnectionColumnEncryptionSetting ColumnEncryptionSetting
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

		/// <summary>Получает или устанавливает URL-адрес для аттестации анклава, который используется с постоянным шифрованием на основе анклава.</summary>
		/// <returns>URL-адрес для аттестации анклава.</returns>
		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x00060C51 File Offset: 0x0005EE51
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x000108A6 File Offset: 0x0000EAA6
		public string EnclaveAttestationUrl
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		// Token: 0x04000ED3 RID: 3795
		internal const int KeywordsCount = 29;

		// Token: 0x04000ED4 RID: 3796
		internal const int DeprecatedKeywordsCount = 4;

		// Token: 0x04000ED5 RID: 3797
		private static readonly string[] s_validKeywords = SqlConnectionStringBuilder.CreateValidKeywords();

		// Token: 0x04000ED6 RID: 3798
		private static readonly Dictionary<string, SqlConnectionStringBuilder.Keywords> s_keywords = SqlConnectionStringBuilder.CreateKeywordsDictionary();

		// Token: 0x04000ED7 RID: 3799
		private ApplicationIntent _applicationIntent;

		// Token: 0x04000ED8 RID: 3800
		private string _applicationName = "Core .Net SqlClient Data Provider";

		// Token: 0x04000ED9 RID: 3801
		private string _attachDBFilename = "";

		// Token: 0x04000EDA RID: 3802
		private string _currentLanguage = "";

		// Token: 0x04000EDB RID: 3803
		private string _dataSource = "";

		// Token: 0x04000EDC RID: 3804
		private string _failoverPartner = "";

		// Token: 0x04000EDD RID: 3805
		private string _initialCatalog = "";

		// Token: 0x04000EDE RID: 3806
		private string _password = "";

		// Token: 0x04000EDF RID: 3807
		private string _transactionBinding = "Implicit Unbind";

		// Token: 0x04000EE0 RID: 3808
		private string _typeSystemVersion = "Latest";

		// Token: 0x04000EE1 RID: 3809
		private string _userID = "";

		// Token: 0x04000EE2 RID: 3810
		private string _workstationID = "";

		// Token: 0x04000EE3 RID: 3811
		private int _connectTimeout = 15;

		// Token: 0x04000EE4 RID: 3812
		private int _loadBalanceTimeout;

		// Token: 0x04000EE5 RID: 3813
		private int _maxPoolSize = 100;

		// Token: 0x04000EE6 RID: 3814
		private int _minPoolSize;

		// Token: 0x04000EE7 RID: 3815
		private int _packetSize = 8000;

		// Token: 0x04000EE8 RID: 3816
		private int _connectRetryCount = 1;

		// Token: 0x04000EE9 RID: 3817
		private int _connectRetryInterval = 10;

		// Token: 0x04000EEA RID: 3818
		private bool _encrypt;

		// Token: 0x04000EEB RID: 3819
		private bool _trustServerCertificate;

		// Token: 0x04000EEC RID: 3820
		private bool _enlist = true;

		// Token: 0x04000EED RID: 3821
		private bool _integratedSecurity;

		// Token: 0x04000EEE RID: 3822
		private bool _multipleActiveResultSets;

		// Token: 0x04000EEF RID: 3823
		private bool _multiSubnetFailover;

		// Token: 0x04000EF0 RID: 3824
		private bool _persistSecurityInfo;

		// Token: 0x04000EF1 RID: 3825
		private bool _pooling = true;

		// Token: 0x04000EF2 RID: 3826
		private bool _replication;

		// Token: 0x04000EF3 RID: 3827
		private bool _userInstance;

		// Token: 0x04000EF4 RID: 3828
		private static readonly string[] s_notSupportedKeywords = new string[]
		{
			"Asynchronous Processing",
			"Connection Reset",
			"Context Connection",
			"Transaction Binding",
			"async"
		};

		// Token: 0x04000EF5 RID: 3829
		private static readonly string[] s_notSupportedNetworkLibraryKeywords = new string[]
		{
			"Network Library",
			"net",
			"network"
		};

		// Token: 0x020001DE RID: 478
		private enum Keywords
		{
			// Token: 0x04000EF9 RID: 3833
			DataSource,
			// Token: 0x04000EFA RID: 3834
			FailoverPartner,
			// Token: 0x04000EFB RID: 3835
			AttachDBFilename,
			// Token: 0x04000EFC RID: 3836
			InitialCatalog,
			// Token: 0x04000EFD RID: 3837
			IntegratedSecurity,
			// Token: 0x04000EFE RID: 3838
			PersistSecurityInfo,
			// Token: 0x04000EFF RID: 3839
			UserID,
			// Token: 0x04000F00 RID: 3840
			Password,
			// Token: 0x04000F01 RID: 3841
			Enlist,
			// Token: 0x04000F02 RID: 3842
			Pooling,
			// Token: 0x04000F03 RID: 3843
			MinPoolSize,
			// Token: 0x04000F04 RID: 3844
			MaxPoolSize,
			// Token: 0x04000F05 RID: 3845
			MultipleActiveResultSets,
			// Token: 0x04000F06 RID: 3846
			Replication,
			// Token: 0x04000F07 RID: 3847
			ConnectTimeout,
			// Token: 0x04000F08 RID: 3848
			Encrypt,
			// Token: 0x04000F09 RID: 3849
			TrustServerCertificate,
			// Token: 0x04000F0A RID: 3850
			LoadBalanceTimeout,
			// Token: 0x04000F0B RID: 3851
			PacketSize,
			// Token: 0x04000F0C RID: 3852
			TypeSystemVersion,
			// Token: 0x04000F0D RID: 3853
			ApplicationName,
			// Token: 0x04000F0E RID: 3854
			CurrentLanguage,
			// Token: 0x04000F0F RID: 3855
			WorkstationID,
			// Token: 0x04000F10 RID: 3856
			UserInstance,
			// Token: 0x04000F11 RID: 3857
			TransactionBinding,
			// Token: 0x04000F12 RID: 3858
			ApplicationIntent,
			// Token: 0x04000F13 RID: 3859
			MultiSubnetFailover,
			// Token: 0x04000F14 RID: 3860
			ConnectRetryCount,
			// Token: 0x04000F15 RID: 3861
			ConnectRetryInterval,
			// Token: 0x04000F16 RID: 3862
			KeywordsCount
		}

		// Token: 0x020001DF RID: 479
		private sealed class SqlInitialCatalogConverter : StringConverter
		{
			// Token: 0x06001775 RID: 6005 RVA: 0x0006A0D3 File Offset: 0x000682D3
			public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
			{
				return this.GetStandardValuesSupportedInternal(context);
			}

			// Token: 0x06001776 RID: 6006 RVA: 0x0006A0DC File Offset: 0x000682DC
			private bool GetStandardValuesSupportedInternal(ITypeDescriptorContext context)
			{
				bool result = false;
				if (context != null)
				{
					SqlConnectionStringBuilder sqlConnectionStringBuilder = context.Instance as SqlConnectionStringBuilder;
					if (sqlConnectionStringBuilder != null && 0 < sqlConnectionStringBuilder.DataSource.Length && (sqlConnectionStringBuilder.IntegratedSecurity || 0 < sqlConnectionStringBuilder.UserID.Length))
					{
						result = true;
					}
				}
				return result;
			}

			// Token: 0x06001777 RID: 6007 RVA: 0x00006D64 File Offset: 0x00004F64
			public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
			{
				return false;
			}

			// Token: 0x06001778 RID: 6008 RVA: 0x0006A124 File Offset: 0x00068324
			public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
			{
				if (this.GetStandardValuesSupportedInternal(context))
				{
					List<string> list = new List<string>();
					try
					{
						SqlConnectionStringBuilder sqlConnectionStringBuilder = (SqlConnectionStringBuilder)context.Instance;
						using (SqlConnection sqlConnection = new SqlConnection())
						{
							sqlConnection.ConnectionString = sqlConnectionStringBuilder.ConnectionString;
							sqlConnection.Open();
							foreach (object obj in sqlConnection.GetSchema("DATABASES").Rows)
							{
								string item = (string)((DataRow)obj)["database_name"];
								list.Add(item);
							}
						}
					}
					catch (SqlException e)
					{
						ADP.TraceExceptionWithoutRethrow(e);
					}
					return new TypeConverter.StandardValuesCollection(list);
				}
				return null;
			}
		}
	}
}
