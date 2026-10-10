using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	/// <summary>Включает перечисление компонентов во время разработки.</summary>
	// Token: 0x02000457 RID: 1111
	public interface IComponentDiscoveryService
	{
		/// <summary>Возвращает список доступных типов компонентов.</summary>
		/// <param name="designerHost">Хост конструктора, обеспечивающий службы времени разработки. Может принимать значение <see langword="null" />.</param>
		/// <param name="baseType">Базовый тип, указывающий компоненты для извлечения. Может принимать значение <see langword="null" />.</param>
		/// <returns>Список доступных типов компонентов.</returns>
		// Token: 0x0600240C RID: 9228
		ICollection GetComponentTypes(IDesignerHost designerHost, Type baseType);
	}
}
