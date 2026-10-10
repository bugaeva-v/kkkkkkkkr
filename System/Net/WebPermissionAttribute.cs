using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net
{
	/// <summary>Задает разрешение для доступа к интернет-ресурсам. Этот класс не наследуется.</summary>
	// Token: 0x0200060F RID: 1551
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class WebPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.WebPermissionAttribute" /> со значением, описывающим операции безопасности, которые можно выполнять в этом классе.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="action" /> не является допустимым значением <see cref="T:System.Security.Permissions.SecurityAction" />.</exception>
		// Token: 0x0600311A RID: 12570 RVA: 0x000A97B6 File Offset: 0x000A79B6
		public WebPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Возвращает или задает строку подключения URI, управляемую текущим <see cref="T:System.Net.WebPermissionAttribute" />.</summary>
		/// <returns>Строка, содержащая подключение URI, управляемая текущим <see cref="T:System.Net.WebPermissionAttribute" />.</returns>
		/// <exception cref="T:System.ArgumentException">При попытке установить значение свойство <see cref="P:System.Net.WebPermissionAttribute.Connect" /> не равно <see langword="null" />. Если нужно указать более одного URI для подключения, используйте дополнительный оператор объявления атрибута.</exception>
		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x000A97BF File Offset: 0x000A79BF
		// (set) Token: 0x0600311C RID: 12572 RVA: 0x000A97CC File Offset: 0x000A79CC
		public string Connect
		{
			get
			{
				return this.m_connect as string;
			}
			set
			{
				if (this.m_connect != null)
				{
					throw new ArgumentException(SR.GetString("The permission '{0}={1}' cannot be added. Add a separate Attribute statement.", new object[]
					{
						"Connect",
						value
					}), "value");
				}
				this.m_connect = value;
			}
		}

		/// <summary>Возвращает или задает строку URI, принятую текущим <see cref="T:System.Net.WebPermissionAttribute" />.</summary>
		/// <returns>Строка, содержащая URI, принятый текущим <see cref="T:System.Net.WebPermissionAttribute" />.</returns>
		/// <exception cref="T:System.ArgumentException">При попытке установить значение свойство <see cref="P:System.Net.WebPermissionAttribute.Accept" /> не равно <see langword="null" />. Если нужно указать более одного URI для приема подключения, используйте дополнительный оператор объявления атрибута.</exception>
		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x0600311D RID: 12573 RVA: 0x000A9804 File Offset: 0x000A7A04
		// (set) Token: 0x0600311E RID: 12574 RVA: 0x000A9811 File Offset: 0x000A7A11
		public string Accept
		{
			get
			{
				return this.m_accept as string;
			}
			set
			{
				if (this.m_accept != null)
				{
					throw new ArgumentException(SR.GetString("The permission '{0}={1}' cannot be added. Add a separate Attribute statement.", new object[]
					{
						"Accept",
						value
					}), "value");
				}
				this.m_accept = value;
			}
		}

		/// <summary>Возвращает или задает шаблон регулярного выражения для описания строки подключения URI, управляемой текущим <see cref="T:System.Net.WebPermissionAttribute" />.</summary>
		/// <returns>Строка, содержащая шаблон регулярного выражения для описания строки подключения URI, управляемой этим <see cref="T:System.Net.WebPermissionAttribute" />.</returns>
		/// <exception cref="T:System.ArgumentException">При попытке установить значение свойство <see cref="P:System.Net.WebPermissionAttribute.ConnectPattern" /> не равно <see langword="null" />. Если нужно указать более одного URI для подключения, используйте дополнительный оператор объявления атрибута.</exception>
		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x0600311F RID: 12575 RVA: 0x000A9849 File Offset: 0x000A7A49
		// (set) Token: 0x06003120 RID: 12576 RVA: 0x000A9888 File Offset: 0x000A7A88
		public string ConnectPattern
		{
			get
			{
				if (this.m_connect is DelayedRegex)
				{
					return this.m_connect.ToString();
				}
				if (!(this.m_connect is bool) || !(bool)this.m_connect)
				{
					return null;
				}
				return ".*";
			}
			set
			{
				if (this.m_connect != null)
				{
					throw new ArgumentException(SR.GetString("The permission '{0}={1}' cannot be added. Add a separate Attribute statement.", new object[]
					{
						"ConnectPatern",
						value
					}), "value");
				}
				if (value == ".*")
				{
					this.m_connect = true;
					return;
				}
				this.m_connect = new DelayedRegex(value);
			}
		}

		/// <summary>Возвращает или задает шаблон регулярного выражения для описания строки URI, принятой текущим <see cref="T:System.Net.WebPermissionAttribute" />.</summary>
		/// <returns>Строка, содержащая шаблон регулярного выражения для описания строки URI, принятой текущим <see cref="T:System.Net.WebPermissionAttribute" />. Эта строка должна содержать знаки переключения в соответствии с правилами кодирования строки конструктора <see cref="T:System.Text.RegularExpressions.Regex" />.</returns>
		/// <exception cref="T:System.ArgumentException">При попытке установить значение свойство <see cref="P:System.Net.WebPermissionAttribute.AcceptPattern" /> не равно <see langword="null" />. Если нужно указать более одного URI для приема подключения, используйте дополнительный оператор объявления атрибута.</exception>
		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x000A98EA File Offset: 0x000A7AEA
		// (set) Token: 0x06003122 RID: 12578 RVA: 0x000A9928 File Offset: 0x000A7B28
		public string AcceptPattern
		{
			get
			{
				if (this.m_accept is DelayedRegex)
				{
					return this.m_accept.ToString();
				}
				if (!(this.m_accept is bool) || !(bool)this.m_accept)
				{
					return null;
				}
				return ".*";
			}
			set
			{
				if (this.m_accept != null)
				{
					throw new ArgumentException(SR.GetString("The permission '{0}={1}' cannot be added. Add a separate Attribute statement.", new object[]
					{
						"AcceptPattern",
						value
					}), "value");
				}
				if (value == ".*")
				{
					this.m_accept = true;
					return;
				}
				this.m_accept = new DelayedRegex(value);
			}
		}

		/// <summary>Создает и возвращает новый экземпляр класса <see cref="T:System.Net.WebPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Net.WebPermission" />, соответствующий объявлению безопасности.</returns>
		// Token: 0x06003123 RID: 12579 RVA: 0x000A998C File Offset: 0x000A7B8C
		public override IPermission CreatePermission()
		{
			WebPermission webPermission;
			if (base.Unrestricted)
			{
				webPermission = new WebPermission(PermissionState.Unrestricted);
			}
			else
			{
				NetworkAccess networkAccess = (NetworkAccess)0;
				if (this.m_connect is bool)
				{
					if ((bool)this.m_connect)
					{
						networkAccess |= NetworkAccess.Connect;
					}
					this.m_connect = null;
				}
				if (this.m_accept is bool)
				{
					if ((bool)this.m_accept)
					{
						networkAccess |= NetworkAccess.Accept;
					}
					this.m_accept = null;
				}
				webPermission = new WebPermission(networkAccess);
				if (this.m_accept != null)
				{
					if (this.m_accept is DelayedRegex)
					{
						webPermission.AddAsPattern(NetworkAccess.Accept, (DelayedRegex)this.m_accept);
					}
					else
					{
						webPermission.AddPermission(NetworkAccess.Accept, (string)this.m_accept);
					}
				}
				if (this.m_connect != null)
				{
					if (this.m_connect is DelayedRegex)
					{
						webPermission.AddAsPattern(NetworkAccess.Connect, (DelayedRegex)this.m_connect);
					}
					else
					{
						webPermission.AddPermission(NetworkAccess.Connect, (string)this.m_connect);
					}
				}
			}
			return webPermission;
		}

		// Token: 0x04001C96 RID: 7318
		private object m_accept;

		// Token: 0x04001C97 RID: 7319
		private object m_connect;
	}
}
