using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting
{
	/// <summary>Содержит значения для типа объектов, зарегистрированного службой как тип, который может быть активирован по запросу клиента.</summary>
	// Token: 0x02000559 RID: 1369
	[ComVisible(true)]
	public class ActivatedServiceTypeEntry : TypeEntry
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.ActivatedServiceTypeEntry" /> с заданным объектом <see cref="T:System.Type" />.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" /> активируемого клиентом типа службы.</param>
		// Token: 0x060035D7 RID: 13783 RVA: 0x000C2302 File Offset: 0x000C0502
		public ActivatedServiceTypeEntry(Type type)
		{
			base.AssemblyName = type.Assembly.FullName;
			base.TypeName = type.FullName;
			this.obj_type = type;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.ActivatedServiceTypeEntry" /> с заданным именем типа и именем сборки.</summary>
		/// <param name="typeName">Имя активируемого клиентом типа службы.</param>
		/// <param name="assemblyName">Имя сборки активируемого клиентом типа службы.</param>
		// Token: 0x060035D8 RID: 13784 RVA: 0x000C2330 File Offset: 0x000C0530
		public ActivatedServiceTypeEntry(string typeName, string assemblyName)
		{
			base.AssemblyName = assemblyName;
			base.TypeName = typeName;
			Assembly assembly = Assembly.Load(assemblyName);
			this.obj_type = assembly.GetType(typeName);
			if (this.obj_type == null)
			{
				throw new RemotingException("Type not found: " + typeName + ", " + assemblyName);
			}
		}

		/// <summary>Возвращает или устанавливает атрибуты контекста для активируемого клиентом типа службы.</summary>
		/// <returns>Атрибуты контекста для активируемого клиентом типа службы.</returns>
		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x0000AF5E File Offset: 0x0000915E
		// (set) Token: 0x060035DA RID: 13786 RVA: 0x00004BF9 File Offset: 0x00002DF9
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

		/// <summary>Получает <see cref="T:System.Type" /> типа службы, активируемой клиентом.</summary>
		/// <returns>
		///   <see cref="T:System.Type" /> активируемого клиентом типа службы.</returns>
		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060035DB RID: 13787 RVA: 0x000C238A File Offset: 0x000C058A
		public Type ObjectType
		{
			get
			{
				return this.obj_type;
			}
		}

		/// <summary>Возвращает тип и имя сборки активируемого клиентом типа службы в виде <see cref="T:System.String" />.</summary>
		/// <returns>Тип и имя сборки активируемого клиентом типа службы в виде <see cref="T:System.String" />.</returns>
		// Token: 0x060035DC RID: 13788 RVA: 0x000C2392 File Offset: 0x000C0592
		public override string ToString()
		{
			return base.AssemblyName + base.TypeName;
		}

		// Token: 0x04002515 RID: 9493
		private Type obj_type;
	}
}
