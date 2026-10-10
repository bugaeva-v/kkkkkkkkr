using System;
using System.Data.Common;

namespace System.Data.Sql
{
	/// <summary>Представляет запрос уведомления для заданной команды.</summary>
	// Token: 0x02000176 RID: 374
	public sealed class SqlNotificationRequest
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Data.Sql.SqlNotificationRequest" /> со значениями по умолчанию.</summary>
		// Token: 0x060013DF RID: 5087 RVA: 0x0005AE4C File Offset: 0x0005904C
		public SqlNotificationRequest() : this(null, null, 0)
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Data.Sql.SqlNotificationRequest" /> с определенной пользователем строкой, идентифицирующей конкретный запрос уведомления, имя предопределенной службы сервис-брокера SQL Server 2005 и период таймаута в секундах.</summary>
		/// <param name="userData">Строка, содержащая специфический для приложения идентификатор данного уведомления. Она не используется инфраструктурой уведомлений, но позволяет связывать уведомления с состоянием приложения. Указанное в этом параметре значение включается в сообщение в очереди сервис-брокера.</param>
		/// <param name="options">Строка, содержащая имя службы сервис-брокера при передаче уведомляющих сообщений; должна включать имя базы данных или GUID экземпляра сервис-брокера, ограничивающего область поиска имени службы определенной базой данных.  
		/// Дополнительные сведения о формате параметра <paramref name="options" /> см. в разделе <see cref="P:System.Data.Sql.SqlNotificationRequest.Options" />.</param>
		/// <param name="timeout">Время ожидания уведомляющего сообщения в секундах.</param>
		/// <exception cref="T:System.ArgumentNullException">Значением параметра <paramref name="options" /> является NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина параметра <paramref name="options" /> or <paramref name="userData" /> превышает длину <see langword="uint16.MaxValue" />, или значение параметра <paramref name="timeout" /> меньше нуля.</exception>
		// Token: 0x060013E0 RID: 5088 RVA: 0x0005AE57 File Offset: 0x00059057
		public SqlNotificationRequest(string userData, string options, int timeout)
		{
			this.UserData = userData;
			this.Timeout = timeout;
			this.Options = options;
		}

		/// <summary>Возвращает или задает имя службы сервис-брокера SQL Server, куда помещаются уведомления.</summary>
		/// <returns>Значение типа <see langword="string" />, содержащее имя службы сервис-брокера SQL Server 2005, куда помещаются уведомления, а также идентификатор GUID базы данных или экземпляра сервис-брокера, ограничивающий область поиска имени сервера.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение равно NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Значение длиннее, чем <see langword="uint16.MaxValue" />.</exception>
		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0005AE74 File Offset: 0x00059074
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x0005AE7C File Offset: 0x0005907C
		public string Options
		{
			get
			{
				return this._options;
			}
			set
			{
				if (value != null && 65535 < value.Length)
				{
					throw ADP.ArgumentOutOfRange(string.Empty, "Options");
				}
				this._options = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, как долго SQL Server должен ожидать изменения, прежде чем произойдет таймаут операции.</summary>
		/// <returns>Целочисленное значение со знаком, указывающее, в секундах, как долго SQL Server должен ожидать изменения, прежде чем произойдет таймаут операции.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение меньше нуля.</exception>
		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0005AEA5 File Offset: 0x000590A5
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x0005AEAD File Offset: 0x000590AD
		public int Timeout
		{
			get
			{
				return this._timeout;
			}
			set
			{
				if (0 > value)
				{
					throw ADP.ArgumentOutOfRange(string.Empty, "Timeout");
				}
				this._timeout = value;
			}
		}

		/// <summary>Возвращает или задает специфический для приложения идентификатор данного уведомления.</summary>
		/// <returns>Значение типа <see langword="string" />, представляющее специфический для приложения идентификатор данного уведомления.</returns>
		/// <exception cref="T:System.ArgumentException">Значение длиннее, чем <see langword="uint16.MaxValue" />.</exception>
		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x0005AECA File Offset: 0x000590CA
		// (set) Token: 0x060013E6 RID: 5094 RVA: 0x0005AED2 File Offset: 0x000590D2
		public string UserData
		{
			get
			{
				return this._userData;
			}
			set
			{
				if (value != null && 65535 < value.Length)
				{
					throw ADP.ArgumentOutOfRange(string.Empty, "UserData");
				}
				this._userData = value;
			}
		}

		// Token: 0x04000C27 RID: 3111
		private string _userData;

		// Token: 0x04000C28 RID: 3112
		private string _options;

		// Token: 0x04000C29 RID: 3113
		private int _timeout;
	}
}
