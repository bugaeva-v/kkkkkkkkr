using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, что поле должно считаться содержащим фиксированное число элементов указанного типа-примитива. Этот класс не наследуется.</summary>
	// Token: 0x020007F2 RID: 2034
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class FixedBufferAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.FixedBufferAttribute" />.</summary>
		/// <param name="elementType">Тип элементов, содержащихся в буфере.</param>
		/// <param name="length">Количество элементов в буфере.</param>
		// Token: 0x060045FC RID: 17916 RVA: 0x000E57AD File Offset: 0x000E39AD
		public FixedBufferAttribute(Type elementType, int length)
		{
			this.ElementType = elementType;
			this.Length = length;
		}

		/// <summary>Возвращает тип элементов, содержащихся в фиксированном буфере.</summary>
		/// <returns>Тип элементов.</returns>
		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x060045FD RID: 17917 RVA: 0x000E57C3 File Offset: 0x000E39C3
		public Type ElementType { get; }

		/// <summary>Возвращает число элементов в фиксированном буфере.</summary>
		/// <returns>Число элементов в фиксированном буфере.</returns>
		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x060045FE RID: 17918 RVA: 0x000E57CB File Offset: 0x000E39CB
		public int Length { get; }
	}
}
