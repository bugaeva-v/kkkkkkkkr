using System;

namespace System
{
	/// <summary>Представляет метод, преобразующий объект от одного типа к другому.</summary>
	/// <param name="input">Преобразуемый объект.</param>
	/// <typeparam name="TInput">Тип преобразуемого объекта.</typeparam>
	/// <typeparam name="TOutput">Тип, к которому выполняется преобразование объекта.</typeparam>
	/// <returns>
	///   <typeparamref name="TOutput" />, представляющий преобразованный <typeparamref name="TInput" />.</returns>
	// Token: 0x020000EF RID: 239
	// (Invoke) Token: 0x060006DF RID: 1759
	public delegate TOutput Converter<in TInput, out TOutput>(TInput input);
}
