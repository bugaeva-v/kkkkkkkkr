using System;

namespace System.ComponentModel.Design
{
	/// <summary>Поставщик описания типа для указанного типа.</summary>
	// Token: 0x0200047A RID: 1146
	public abstract class TypeDescriptionProviderService
	{
		/// <summary>Получает поставщик описания типа для указанного объекта.</summary>
		/// <param name="instance">Объект, для которого необходимо получить поставщик описания типа.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.TypeDescriptionProvider" />, соответствующий значению параметра <paramref name="instance" />.</returns>
		// Token: 0x060024B7 RID: 9399
		public abstract TypeDescriptionProvider GetProvider(object instance);

		/// <summary>Получает поставщик описания типа для указанного типа.</summary>
		/// <param name="type">Тип, для которого необходимо получить поставщик описания типа.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.TypeDescriptionProvider" />, соответствующий значению параметра <paramref name="type" />.</returns>
		// Token: 0x060024B8 RID: 9400
		public abstract TypeDescriptionProvider GetProvider(Type type);
	}
}
