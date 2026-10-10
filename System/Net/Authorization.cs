using System;

namespace System.Net
{
	/// <summary>Содержит сообщение проверки подлинности для веб-сервера.</summary>
	// Token: 0x020005C4 RID: 1476
	public class Authorization
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Authorization" /> с указанным сообщением авторизации.</summary>
		/// <param name="token">Зашифрованное сообщение авторизации, ожидаемое сервером.</param>
		// Token: 0x06002FD6 RID: 12246 RVA: 0x000A51F9 File Offset: 0x000A33F9
		public Authorization(string token)
		{
			this.m_Message = ValidationHelper.MakeStringNull(token);
			this.m_Complete = true;
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Authorization" /> с указанным сообщением авторизации и состоянием завершения.</summary>
		/// <param name="token">Зашифрованное сообщение авторизации, ожидаемое сервером.</param>
		/// <param name="finished">Состояние завершения попытки авторизации. Значение <see langword="true" />, если попытка авторизации завершена; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06002FD7 RID: 12247 RVA: 0x000A5214 File Offset: 0x000A3414
		public Authorization(string token, bool finished)
		{
			this.m_Message = ValidationHelper.MakeStringNull(token);
			this.m_Complete = finished;
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Authorization" /> с указанным сообщением авторизации, состоянием завершения и идентификатором группы подключения.</summary>
		/// <param name="token">Зашифрованное сообщение авторизации, ожидаемое сервером.</param>
		/// <param name="finished">Состояние завершения попытки авторизации. Значение <see langword="true" />, если попытка авторизации завершена; в противном случае — значение <see langword="false" />.</param>
		/// <param name="connectionGroupId">Уникальный идентификатор, который может использоваться для создания закрытых клиент-серверных подключений, связанных только с этой схемой проверки подлинности.</param>
		// Token: 0x06002FD8 RID: 12248 RVA: 0x000A522F File Offset: 0x000A342F
		public Authorization(string token, bool finished, string connectionGroupId) : this(token, finished, connectionGroupId, false)
		{
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x000A523B File Offset: 0x000A343B
		internal Authorization(string token, bool finished, string connectionGroupId, bool mutualAuth)
		{
			this.m_Message = ValidationHelper.MakeStringNull(token);
			this.m_ConnectionGroupId = ValidationHelper.MakeStringNull(connectionGroupId);
			this.m_Complete = finished;
			this.m_MutualAuth = mutualAuth;
		}

		/// <summary>Получает сообщение, возвращенное на сервер в ответ на запрос проверки подлинности.</summary>
		/// <returns>Сообщение, которое возвращается на сервер в ответ на запрос проверки подлинности.</returns>
		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06002FDA RID: 12250 RVA: 0x000A526A File Offset: 0x000A346A
		public string Message
		{
			get
			{
				return this.m_Message;
			}
		}

		/// <summary>Возвращает уникальный идентификатор для подключений пользователя.</summary>
		/// <returns>Уникальная строка, связывающая подключение с объектом, выполняющим проверку подлинности.</returns>
		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06002FDB RID: 12251 RVA: 0x000A5272 File Offset: 0x000A3472
		public string ConnectionGroupId
		{
			get
			{
				return this.m_ConnectionGroupId;
			}
		}

		/// <summary>Получает состояние завершения авторизации.</summary>
		/// <returns>Значение <see langword="true" />, если проверка подлинности завершена; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06002FDC RID: 12252 RVA: 0x000A527A File Offset: 0x000A347A
		public bool Complete
		{
			get
			{
				return this.m_Complete;
			}
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x000A5282 File Offset: 0x000A3482
		internal void SetComplete(bool complete)
		{
			this.m_Complete = complete;
		}

		/// <summary>Возвращает или задает префикс идентификаторов URI, которые могут проходить проверку подлинности с помощью свойства <see cref="P:System.Net.Authorization.Message" />.</summary>
		/// <returns>Массив строк, содержащий префиксы URI.</returns>
		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06002FDE RID: 12254 RVA: 0x000A528B File Offset: 0x000A348B
		// (set) Token: 0x06002FDF RID: 12255 RVA: 0x000A5294 File Offset: 0x000A3494
		public string[] ProtectionRealm
		{
			get
			{
				return this.m_ProtectionRealm;
			}
			set
			{
				string[] protectionRealm = ValidationHelper.MakeEmptyArrayNull(value);
				this.m_ProtectionRealm = protectionRealm;
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, указывающее, происходит ли взаимная проверка подлинности.</summary>
		/// <returns>Значение <see langword="true" />, если и клиент, и сервер прошли проверку подлинности; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06002FE0 RID: 12256 RVA: 0x000A52AF File Offset: 0x000A34AF
		// (set) Token: 0x06002FE1 RID: 12257 RVA: 0x000A52C1 File Offset: 0x000A34C1
		public bool MutuallyAuthenticated
		{
			get
			{
				return this.Complete && this.m_MutualAuth;
			}
			set
			{
				this.m_MutualAuth = value;
			}
		}

		// Token: 0x04001A5B RID: 6747
		private string m_Message;

		// Token: 0x04001A5C RID: 6748
		private bool m_Complete;

		// Token: 0x04001A5D RID: 6749
		private string[] m_ProtectionRealm;

		// Token: 0x04001A5E RID: 6750
		private string m_ConnectionGroupId;

		// Token: 0x04001A5F RID: 6751
		private bool m_MutualAuth;

		// Token: 0x04001A60 RID: 6752
		internal string ModuleAuthenticationType;
	}
}
