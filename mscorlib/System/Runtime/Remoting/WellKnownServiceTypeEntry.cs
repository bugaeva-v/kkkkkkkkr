using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting
{
	/// <summary>Содержит значения для типа объектов, зарегистрированного на стороне сервера в качестве типа объекта, активированного сервером (единственного вызова или одноэлементного множества).</summary>
	// Token: 0x0200057A RID: 1402
	[ComVisible(true)]
	public class WellKnownServiceTypeEntry : TypeEntry
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.WellKnownServiceTypeEntry" />с заданным <see cref="T:System.Type" />, объектом URI, и <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" />.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> типа службы, активированной клиентом.</param>
		/// <param name="objectUri">URI активированного сервером типа службы.</param>
		/// <param name="mode">
		///   <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> типа, определяющего метод активации объекта.</param>
		// Token: 0x060036FF RID: 14079 RVA: 0x000C6979 File Offset: 0x000C4B79
		public WellKnownServiceTypeEntry(Type type, string objectUri, WellKnownObjectMode mode)
		{
			base.AssemblyName = type.Assembly.FullName;
			base.TypeName = type.FullName;
			this.obj_type = type;
			this.obj_uri = objectUri;
			this.obj_mode = mode;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.WellKnownServiceTypeEntry" /> с заданным именем типа, именем сборки, объекта URI и <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" />.</summary>
		/// <param name="typeName">Полное имя типа службы, активированной сервером.</param>
		/// <param name="assemblyName">Имя сборки типа службы, активированной сервером.</param>
		/// <param name="objectUri">URI объекта, активированного сервером.</param>
		/// <param name="mode">
		///   <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> типа, определяющего метод активации объекта.</param>
		// Token: 0x06003700 RID: 14080 RVA: 0x000C69B4 File Offset: 0x000C4BB4
		public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode)
		{
			base.AssemblyName = assemblyName;
			base.TypeName = typeName;
			Assembly assembly = Assembly.Load(assemblyName);
			this.obj_type = assembly.GetType(typeName);
			this.obj_uri = objectUri;
			this.obj_mode = mode;
			if (this.obj_type == null)
			{
				throw new RemotingException("Type not found: " + typeName + ", " + assemblyName);
			}
		}

		/// <summary>Возвращает или устанавливает атрибуты контекста для типа службы, активированной сервером.</summary>
		/// <returns>Атрибуты контекста для активируемого сервером типа.</returns>
		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06003701 RID: 14081 RVA: 0x0000AF5E File Offset: 0x0000915E
		// (set) Token: 0x06003702 RID: 14082 RVA: 0x00004BF9 File Offset: 0x00002DF9
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

		/// <summary>Возвращает <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> тип службы, активированной сервером.</summary>
		/// <returns>
		///   <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> активированного сервером типа.</returns>
		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06003703 RID: 14083 RVA: 0x000C6A1D File Offset: 0x000C4C1D
		public WellKnownObjectMode Mode
		{
			get
			{
				return this.obj_mode;
			}
		}

		/// <summary>Возвращает <see cref="T:System.Type" /> тип службы, активированной сервером.</summary>
		/// <returns>
		///   <see cref="T:System.Type" /> активированного сервером типа.</returns>
		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06003704 RID: 14084 RVA: 0x000C6A25 File Offset: 0x000C4C25
		public Type ObjectType
		{
			get
			{
				return this.obj_type;
			}
		}

		/// <summary>Возвращает URI хорошо известного типа службы.</summary>
		/// <returns>URI типа службы, активированной сервером.</returns>
		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x000C6A2D File Offset: 0x000C4C2D
		public string ObjectUri
		{
			get
			{
				return this.obj_uri;
			}
		}

		/// <summary>Возвращает имя типа, имя сборки, объект URI и <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> типа, активированного сервером <see cref="T:System.String" />.</summary>
		/// <returns>Имя типа, имя сборки, объект URI и <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> типа, активированного сервером <see cref="T:System.String" />.</returns>
		// Token: 0x06003706 RID: 14086 RVA: 0x000C6A35 File Offset: 0x000C4C35
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				base.TypeName,
				", ",
				base.AssemblyName,
				" ",
				this.ObjectUri
			});
		}

		// Token: 0x04002573 RID: 9587
		private Type obj_type;

		// Token: 0x04002574 RID: 9588
		private string obj_uri;

		// Token: 0x04002575 RID: 9589
		private WellKnownObjectMode obj_mode;
	}
}
