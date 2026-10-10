using System;

namespace System.Reflection
{
	/// <summary>Представляет делегат, используемый для фильтрации списка элементов, представленных в массиве объектов <see cref="T:System.Reflection.MemberInfo" />.</summary>
	/// <param name="m">Объект <see cref="T:System.Reflection.MemberInfo" />, к которому применяется фильтр.</param>
	/// <param name="filterCriteria">Произвольный объект, используемый для фильтрации списка.</param>
	/// <returns>Значение <see langword="true" /> для включения элемента в отфильтрованный список. В противном случае — значение <see langword="false" />.</returns>
	// Token: 0x020008A9 RID: 2217
	// (Invoke) Token: 0x0600490D RID: 18701
	public delegate bool MemberFilter(MemberInfo m, object filterCriteria);
}
