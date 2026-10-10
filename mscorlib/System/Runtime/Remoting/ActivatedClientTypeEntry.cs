using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting
{
	/// <summary>Содержит значения для типа объекта, зарегистрированного со стороны клиента в качестве типа, который может активироваться сервером.</summary>
	// Token: 0x02000558 RID: 1368
	[ComVisible(true)]
	public class ActivatedClientTypeEntry : TypeEntry
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> с заданным типом <see cref="T:System.Type" /> и URL-адресом.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> типа сервера, активированного клиентом.</param>
		/// <param name="appUrl">URL-адрес приложения, в котором активируется тип.</param>
		// Token: 0x060035D0 RID: 13776 RVA: 0x000C2245 File Offset: 0x000C0445
		public ActivatedClientTypeEntry(Type type, string appUrl)
		{
			base.AssemblyName = type.Assembly.FullName;
			base.TypeName = type.FullName;
			this.applicationUrl = appUrl;
			this.obj_type = type;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> с заданным именем и URL-адресом приложения.</summary>
		/// <param name="typeName">Имя активируемого клиентом типа.</param>
		/// <param name="assemblyName">Имя активируемого клиентом типа сборки.</param>
		/// <param name="appUrl">URL-адрес приложения, в котором активируется тип.</param>
		// Token: 0x060035D1 RID: 13777 RVA: 0x000C2278 File Offset: 0x000C0478
		public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl)
		{
			base.AssemblyName = assemblyName;
			base.TypeName = typeName;
			this.applicationUrl = appUrl;
			Assembly assembly = Assembly.Load(assemblyName);
			this.obj_type = assembly.GetType(typeName);
			if (this.obj_type == null)
			{
				throw new RemotingException("Type not found: " + typeName + ", " + assemblyName);
			}
		}

		/// <summary>Получает URL-адрес приложения, в котором активируется тип.</summary>
		/// <returns>URL-адрес приложения, в котором активируется тип.</returns>
		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060035D2 RID: 13778 RVA: 0x000C22D9 File Offset: 0x000C04D9
		public string ApplicationUrl
		{
			get
			{
				return this.applicationUrl;
			}
		}

		/// <summary>Возвращает или устанавливает атрибуты контекста для активируемого клиентом типа.</summary>
		/// <returns>Атрибуты контекста для активируемого клиентом типа.</returns>
		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x0000AF5E File Offset: 0x0000915E
		// (set) Token: 0x060035D4 RID: 13780 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public IContextAttribute[] ContextAttributes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Получает <see cref="T:System.Type" /> тип службы, активируемой клиентом.</summary>
		/// <returns>Получает <see cref="T:System.Type" /> тип службы, активируемой клиентом.</returns>
		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x000C22E1 File Offset: 0x000C04E1
		public Type ObjectType
		{
			get
			{
				return this.obj_type;
			}
		}

		/// <summary>Возвращает имя типа, имя сборки, приложение URL типа, активированного клиентом в качестве <see cref="T:System.String" />.</summary>
		/// <returns>Имя типа, имя сборки, приложение URL типа, активированного клиентом в качестве <see cref="T:System.String" />.</returns>
		// Token: 0x060035D6 RID: 13782 RVA: 0x000C22E9 File Offset: 0x000C04E9
		public override string ToString()
		{
			return base.TypeName + base.AssemblyName + this.ApplicationUrl;
		}

		// Token: 0x04002513 RID: 9491
		private string applicationUrl;

		// Token: 0x04002514 RID: 9492
		private Type obj_type;
	}
}
