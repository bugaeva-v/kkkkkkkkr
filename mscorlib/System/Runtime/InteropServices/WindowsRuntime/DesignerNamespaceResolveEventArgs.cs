using System;
using System.Collections.ObjectModel;

namespace System.Runtime.InteropServices.WindowsRuntime
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMetadata.DesignerNamespaceResolve" />.</summary>
	// Token: 0x02000797 RID: 1943
	[ComVisible(false)]
	public class DesignerNamespaceResolveEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.WindowsRuntime.DesignerNamespaceResolveEventArgs" />.</summary>
		/// <param name="namespaceName">Имя разрешаемого пространства имен.</param>
		// Token: 0x060044D8 RID: 17624 RVA: 0x000E4F00 File Offset: 0x000E3100
		public DesignerNamespaceResolveEventArgs(string namespaceName)
		{
			this.NamespaceName = namespaceName;
			this.ResolvedAssemblyFiles = new Collection<string>();
		}

		/// <summary>Получает имя разрешаемого пространства имен.</summary>
		/// <returns>Имя разрешаемого пространства имен.</returns>
		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060044D9 RID: 17625 RVA: 0x000E4F1A File Offset: 0x000E311A
		// (set) Token: 0x060044DA RID: 17626 RVA: 0x000E4F22 File Offset: 0x000E3122
		public string NamespaceName { get; private set; }

		/// <summary>Получает коллекцию путей к файлам сборки; при вызове обработчика событий для события <see cref="E:System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMetadata.DesignerNamespaceResolve" /> коллекция пуста и обработчик событий отвечает за добавление необходимых файлов сборки.</summary>
		/// <returns>Коллекция файлов сборок, определяющих запрашиваемое пространство имен.</returns>
		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060044DB RID: 17627 RVA: 0x000E4F2B File Offset: 0x000E312B
		// (set) Token: 0x060044DC RID: 17628 RVA: 0x000E4F33 File Offset: 0x000E3133
		public Collection<string> ResolvedAssemblyFiles { get; private set; }
	}
}
