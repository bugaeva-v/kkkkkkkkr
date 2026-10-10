using System;

namespace System.ComponentModel
{
	/// <summary>Обеспечивает функциональные возможности для вложенных контейнеров, логически содержащих ноль или более компонентов и принадлежащих родительскому компоненту.</summary>
	// Token: 0x020003B8 RID: 952
	public interface INestedContainer : IContainer, IDisposable
	{
		/// <summary>Возвращает компонент-владелец для вложенного контейнера.</summary>
		/// <returns>Компонент <see cref="T:System.ComponentModel.IComponent" />, являющийся владельцем вложенного контейнера.</returns>
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001F17 RID: 7959
		IComponent Owner { get; }
	}
}
