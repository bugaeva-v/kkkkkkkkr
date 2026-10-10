using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Содержит значения для типа объектов, зарегистрированного на стороне клиента в качестве типа, активированного сервером (единственного вызова или одноэлементного множества).</summary>
	// Token: 0x02000578 RID: 1400
	[ComVisible(true)]
	public class WellKnownClientTypeEntry : TypeEntry
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> с заданным типом и URL-адресом.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> активированного сервером типа.</param>
		/// <param name="objectUrl">Адрес URL активированного сервером типа.</param>
		// Token: 0x060036F8 RID: 14072 RVA: 0x000C6885 File Offset: 0x000C4A85
		public WellKnownClientTypeEntry(Type type, string objectUrl)
		{
			base.AssemblyName = type.Assembly.FullName;
			base.TypeName = type.FullName;
			this.obj_type = type;
			this.obj_url = objectUrl;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> с заданным типом, именем сборки и URL-адресом.</summary>
		/// <param name="typeName">Имя типа, активированного сервером.</param>
		/// <param name="assemblyName">Имя сборки типа активированного сервером.</param>
		/// <param name="objectUrl">Адрес URL активированного сервером типа.</param>
		// Token: 0x060036F9 RID: 14073 RVA: 0x000C68B8 File Offset: 0x000C4AB8
		public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl)
		{
			this.obj_url = objectUrl;
			base.AssemblyName = assemblyName;
			base.TypeName = typeName;
			Assembly assembly = Assembly.Load(assemblyName);
			this.obj_type = assembly.GetType(typeName);
			if (this.obj_type == null)
			{
				throw new RemotingException("Type not found: " + typeName + ", " + assemblyName);
			}
		}

		/// <summary>Возвращает или задает URL-адрес приложения, в котором активируется тип.</summary>
		/// <returns>URL-адрес приложения, в котором активируется тип.</returns>
		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x000C6919 File Offset: 0x000C4B19
		// (set) Token: 0x060036FB RID: 14075 RVA: 0x000C6921 File Offset: 0x000C4B21
		public string ApplicationUrl
		{
			get
			{
				return this.app_url;
			}
			set
			{
				this.app_url = value;
			}
		}

		/// <summary>Возвращает <see cref="T:System.Type" /> тип клиента, активированный сервером.</summary>
		/// <returns>Возвращает <see cref="T:System.Type" /> тип клиента, активированный сервером.</returns>
		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060036FC RID: 14076 RVA: 0x000C692A File Offset: 0x000C4B2A
		public Type ObjectType
		{
			get
			{
				return this.obj_type;
			}
		}

		/// <summary>Возвращает адрес URL объекта клиента, активированного сервером.</summary>
		/// <returns>Адрес URL объекта клиента, активированного сервером.</returns>
		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060036FD RID: 14077 RVA: 0x000C6932 File Offset: 0x000C4B32
		public string ObjectUrl
		{
			get
			{
				return this.obj_url;
			}
		}

		/// <summary>Возвращает полное имя типа, сборки и адрес URL объекта типа клиента, активированного сервером, в качестве <see cref="T:System.String" />.</summary>
		/// <returns>Полное имя типа, имя сборки и URL-адрес объекта, типа клиента, активированного сервером, в качестве <see cref="T:System.String" />.</returns>
		// Token: 0x060036FE RID: 14078 RVA: 0x000C693A File Offset: 0x000C4B3A
		public override string ToString()
		{
			if (this.ApplicationUrl != null)
			{
				return base.TypeName + base.AssemblyName + this.ObjectUrl + this.ApplicationUrl;
			}
			return base.TypeName + base.AssemblyName + this.ObjectUrl;
		}

		// Token: 0x0400256D RID: 9581
		private Type obj_type;

		// Token: 0x0400256E RID: 9582
		private string obj_url;

		// Token: 0x0400256F RID: 9583
		private string app_url;
	}
}
