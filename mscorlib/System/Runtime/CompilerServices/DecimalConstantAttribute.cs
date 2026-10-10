using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Сохраняет значение константы типа <see cref="T:System.Decimal" /> в метаданных. Этот класс не наследуется.</summary>
	// Token: 0x020007ED RID: 2029
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	[Serializable]
	public sealed class DecimalConstantAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.DecimalConstantAttribute" /> указанными целочисленными значениями без знака.</summary>
		/// <param name="scale">Показатель степени множителя 10, определяющий число знаков справа от десятичной запятой. Допустимые значения — от 0 до 28 включительно.</param>
		/// <param name="sign">Значение 0 указывает на положительное значение, а 1 — на отрицательное.</param>
		/// <param name="hi">Старшие 32 бита 96-битного <see cref="P:System.Runtime.CompilerServices.DecimalConstantAttribute.Value" />.</param>
		/// <param name="mid">Средние 32 бита 96-битного <see cref="P:System.Runtime.CompilerServices.DecimalConstantAttribute.Value" />.</param>
		/// <param name="low">Младшие 32 бита 96-битного <see cref="P:System.Runtime.CompilerServices.DecimalConstantAttribute.Value" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="scale" /> &gt; 28.</exception>
		// Token: 0x060045F5 RID: 17909 RVA: 0x000E5788 File Offset: 0x000E3988
		[CLSCompliant(false)]
		public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low)
		{
			this._dec = new decimal((int)low, (int)mid, (int)hi, sign > 0, scale);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.DecimalConstantAttribute" /> указанными целочисленными значениями со знаком.</summary>
		/// <param name="scale">Показатель степени множителя 10, определяющий число знаков справа от десятичной запятой. Допустимые значения — от 0 до 28 включительно.</param>
		/// <param name="sign">Значение 0 указывает на положительное значение, а 1 — на отрицательное.</param>
		/// <param name="hi">Старшие 32 бита 96-битного <see cref="P:System.Runtime.CompilerServices.DecimalConstantAttribute.Value" />.</param>
		/// <param name="mid">Средние 32 бита 96-битного <see cref="P:System.Runtime.CompilerServices.DecimalConstantAttribute.Value" />.</param>
		/// <param name="low">Младшие 32 бита 96-битного <see cref="P:System.Runtime.CompilerServices.DecimalConstantAttribute.Value" />.</param>
		// Token: 0x060045F6 RID: 17910 RVA: 0x000E5788 File Offset: 0x000E3988
		public DecimalConstantAttribute(byte scale, byte sign, int hi, int mid, int low)
		{
			this._dec = new decimal(low, mid, hi, sign > 0, scale);
		}

		/// <summary>Возвращает десятичную константу, хранящуюся в данном атрибуте.</summary>
		/// <returns>Десятичная константа, хранящаяся в данном атрибуте.</returns>
		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x060045F7 RID: 17911 RVA: 0x000E57A5 File Offset: 0x000E39A5
		public decimal Value
		{
			get
			{
				return this._dec;
			}
		}

		// Token: 0x04002D37 RID: 11575
		private decimal _dec;
	}
}
