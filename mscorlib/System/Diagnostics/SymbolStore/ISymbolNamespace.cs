using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Представляет пространство имен в хранилище символов.</summary>
	// Token: 0x020009DA RID: 2522
	[ComVisible(true)]
	public interface ISymbolNamespace
	{
		/// <summary>Получает текущее пространство имен.</summary>
		/// <returns>Текущее пространство имен.</returns>
		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06005A5B RID: 23131
		string Name { get; }

		/// <summary>Получает дочерние члены текущего пространства имен.</summary>
		/// <returns>Дочерние члены текущего пространства имен.</returns>
		// Token: 0x06005A5C RID: 23132
		ISymbolNamespace[] GetNamespaces();

		/// <summary>Получает все переменные, определенные в глобальной области в текущем пространстве имен.</summary>
		/// <returns>Переменные, определенные в глобальной области в текущем пространстве имен.</returns>
		// Token: 0x06005A5D RID: 23133
		ISymbolVariable[] GetVariables();
	}
}
