using System;

namespace System
{
	/// <summary>Предоставляет механизм для извлечения объекта с целью управления форматированием.</summary>
	// Token: 0x0200013F RID: 319
	public interface IFormatProvider
	{
		/// <summary>Возвращает объекты, предоставляющие службы форматирования для заданного типа.</summary>
		/// <param name="formatType">Объект, определяющий тип возвращаемого объекта форматирования.</param>
		/// <returns>Экземпляр объекта, заданного в параметре <paramref name="formatType" />, если реализация <see cref="T:System.IFormatProvider" /> может предоставить объект такого типа; в противном случае — <see langword="null" />.</returns>
		// Token: 0x06000BFF RID: 3071
		object GetFormat(Type formatType);
	}
}
