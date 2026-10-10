using System;
using System.Reflection;

namespace System
{
	/// <summary>Предоставляет данные для события <see cref="E:System.AppDomain.AssemblyLoad" />.</summary>
	// Token: 0x020000FA RID: 250
	public class AssemblyLoadEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AssemblyLoadEventArgs" /> с использованием указанного объекта <see cref="T:System.Reflection.Assembly" />.</summary>
		/// <param name="loadedAssembly">Экземпляр, представляющий текущую загруженную сборку.</param>
		// Token: 0x06000747 RID: 1863 RVA: 0x00021714 File Offset: 0x0001F914
		public AssemblyLoadEventArgs(Assembly loadedAssembly)
		{
			this.LoadedAssembly = loadedAssembly;
		}

		/// <summary>Возвращает объект <see cref="T:System.Reflection.Assembly" />, представляющий текущую загруженную сборку.</summary>
		/// <returns>Экземпляр объекта <see cref="T:System.Reflection.Assembly" />, представляющий текущую загруженную сборку.</returns>
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00021723 File Offset: 0x0001F923
		public Assembly LoadedAssembly { get; }
	}
}
