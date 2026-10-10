using System;
using System.Security.Principal;

namespace System.Net
{
	/// <summary>Хранит имя пользователя и пароль для запроса обычной проверки подлинности.</summary>
	// Token: 0x0200068A RID: 1674
	public class HttpListenerBasicIdentity : GenericIdentity
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.HttpListenerBasicIdentity" />, используя указанные имя пользователя и пароль.</summary>
		/// <param name="username">Имя пользователя.</param>
		/// <param name="password">Пароль.</param>
		// Token: 0x060034DC RID: 13532 RVA: 0x000B8F4D File Offset: 0x000B714D
		public HttpListenerBasicIdentity(string username, string password) : base(username, "Basic")
		{
			this.password = password;
		}

		/// <summary>Указывает пароль при попытке обычной проверки подлинности.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит пароль.</returns>
		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x060034DD RID: 13533 RVA: 0x000B8F62 File Offset: 0x000B7162
		public virtual string Password
		{
			get
			{
				return this.password;
			}
		}

		// Token: 0x04001EDF RID: 7903
		private string password;
	}
}
