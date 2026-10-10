using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет базовый класс для службы фильтра контейнера.</summary>
	// Token: 0x0200038F RID: 911
	public abstract class ContainerFilterService
	{
		/// <summary>Выполняет фильтрацию коллекции компонентов.</summary>
		/// <param name="components">Фильтруемая коллекция компонентов.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.ComponentCollection" />, представляющий измененную коллекцию.</returns>
		// Token: 0x06001DEF RID: 7663 RVA: 0x00003914 File Offset: 0x00001B14
		public virtual ComponentCollection FilterComponents(ComponentCollection components)
		{
			return components;
		}
	}
}
