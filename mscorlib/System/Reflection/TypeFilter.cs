using System;

namespace System.Reflection
{
	/// <summary>Отфильтровывает классы, представленные в массиве объектов <see cref="T:System.Type" />.</summary>
	/// <param name="m">Объект <see langword="Type" />, к которому применяется фильтр.</param>
	/// <param name="filterCriteria">Произвольный объект, используемый для фильтрации списка.</param>
	/// <returns>Значение <see langword="true" /> для включения объекта <see cref="T:System.Type" /> в отфильтрованный список. В противном случае — значение <see langword="false" />.</returns>
	// Token: 0x020008CF RID: 2255
	// (Invoke) Token: 0x06004B25 RID: 19237
	public delegate bool TypeFilter(Type m, object filterCriteria);
}
