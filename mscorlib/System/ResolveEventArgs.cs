using System;
using System.Reflection;

namespace System
{
	/// <summary>Предоставляет данные для событий разрешения загрузчика, например<see cref="E:System.AppDomain.TypeResolve" />, <see cref="E:System.AppDomain.ResourceResolve" />, <see cref="E:System.AppDomain.ReflectionOnlyAssemblyResolve" /> и <see cref="E:System.AppDomain.AssemblyResolve" />.</summary>
	// Token: 0x02000178 RID: 376
	public class ResolveEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ResolveEventArgs" />, используя имя элемента для разрешения.</summary>
		/// <param name="name">Имя разрешаемого элемента.</param>
		// Token: 0x06000EE1 RID: 3809 RVA: 0x0003CA6D File Offset: 0x0003AC6D
		public ResolveEventArgs(string name)
		{
			this.Name = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ResolveEventArgs" />, используя имя элемента для разрешения и сборку, зависимость которой необходимо разрешить.</summary>
		/// <param name="name">Имя разрешаемого элемента.</param>
		/// <param name="requestingAssembly">Сборка, зависимость которой необходимо разрешить.</param>
		// Token: 0x06000EE2 RID: 3810 RVA: 0x0003CA7C File Offset: 0x0003AC7C
		public ResolveEventArgs(string name, Assembly requestingAssembly)
		{
			this.Name = name;
			this.RequestingAssembly = requestingAssembly;
		}

		/// <summary>Возвращает имя разрешаемого элемента.</summary>
		/// <returns>Имя разрешаемого элемента.</returns>
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x0003CA92 File Offset: 0x0003AC92
		public string Name { get; }

		/// <summary>Получает сборку, зависимость которой необходимо разрешить.</summary>
		/// <returns>Сборка, запросившая элемент, задается свойством <see cref="P:System.ResolveEventArgs.Name" />.</returns>
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0003CA9A File Offset: 0x0003AC9A
		public Assembly RequestingAssembly { get; }
	}
}
