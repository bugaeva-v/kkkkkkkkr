using System;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Runtime.InteropServices.WindowsRuntime
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMetadata.ReflectionOnlyNamespaceResolve" />.</summary>
	// Token: 0x02000798 RID: 1944
	[ComVisible(false)]
	public class NamespaceResolveEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.WindowsRuntime.NamespaceResolveEventArgs" />, указывающий пространство имен для разрешения и сборку, зависимость которой необходимо разрешить.</summary>
		/// <param name="namespaceName">Разрешаемое пространство имен.</param>
		/// <param name="requestingAssembly">Сборка, зависимость которой необходимо разрешить.</param>
		// Token: 0x060044DD RID: 17629 RVA: 0x000E4F3C File Offset: 0x000E313C
		public NamespaceResolveEventArgs(string namespaceName, Assembly requestingAssembly)
		{
			this.NamespaceName = namespaceName;
			this.RequestingAssembly = requestingAssembly;
			this.ResolvedAssemblies = new Collection<Assembly>();
		}

		/// <summary>Получает имя разрешаемого пространства имен.</summary>
		/// <returns>Имя разрешаемого пространства имен.</returns>
		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x000E4F5D File Offset: 0x000E315D
		// (set) Token: 0x060044DF RID: 17631 RVA: 0x000E4F65 File Offset: 0x000E3165
		public string NamespaceName { get; private set; }

		/// <summary>Получает имя сборки, зависимость которой необходимо разрешить.</summary>
		/// <returns>Имя сборки, зависимость которой необходимо разрешить.</returns>
		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x000E4F6E File Offset: 0x000E316E
		// (set) Token: 0x060044E1 RID: 17633 RVA: 0x000E4F76 File Offset: 0x000E3176
		public Assembly RequestingAssembly { get; private set; }

		/// <summary>Получает коллекцию сборок; при вызове обработчика событий для события <see cref="E:System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMetadata.ReflectionOnlyNamespaceResolve" /> коллекция пуста и обработчик событий отвечает за добавление необходимых сборок.</summary>
		/// <returns>Коллекция сборок, определяющих запрашиваемое пространство имен.</returns>
		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x060044E2 RID: 17634 RVA: 0x000E4F7F File Offset: 0x000E317F
		// (set) Token: 0x060044E3 RID: 17635 RVA: 0x000E4F87 File Offset: 0x000E3187
		public Collection<Assembly> ResolvedAssemblies { get; private set; }
	}
}
