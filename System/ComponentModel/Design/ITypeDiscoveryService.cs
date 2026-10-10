using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	/// <summary>Выявляет доступные типы времени разработки.</summary>
	// Token: 0x0200046D RID: 1133
	public interface ITypeDiscoveryService
	{
		/// <summary>Извлекает список доступных типов.</summary>
		/// <param name="baseType">Базовый тип для выполнения сравнения. Может принимать значение <see langword="null" />.</param>
		/// <param name="excludeGlobalTypes">Указывает, должны проверяться типы из всех базовых сборок.</param>
		/// <returns>Коллекция типов, которые соответствует критериям, определенным параметрами <paramref name="baseType" /> и <paramref name="excludeGlobalTypes" />.</returns>
		// Token: 0x0600247F RID: 9343
		ICollection GetTypes(Type baseType, bool excludeGlobalTypes);
	}
}
