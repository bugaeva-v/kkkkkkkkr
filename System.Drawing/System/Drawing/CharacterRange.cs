using System;

namespace System.Drawing
{
	/// <summary>Определяет диапазон позиций символа в пределах строки.</summary>
	// Token: 0x02000052 RID: 82
	public struct CharacterRange
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Drawing.CharacterRange" />, определяющей диапазон позиций символа в пределах строки.</summary>
		/// <param name="First">Позиция первого символа в диапазоне. Например, если параметр <paramref name="First" /> установлен равным 0, то первая позиция в диапазоне является нулевой позицией в строке.</param>
		/// <param name="Length">Число позиций в диапазоне.</param>
		// Token: 0x060003B4 RID: 948 RVA: 0x00009C00 File Offset: 0x00007E00
		public CharacterRange(int First, int Length)
		{
			this.first = First;
			this.length = Length;
		}

		/// <summary>Получает или устанавливает позицию первого символа диапазона <see cref="T:System.Drawing.CharacterRange" /> в строке.</summary>
		/// <returns>Первая позиция этого диапазона <see cref="T:System.Drawing.CharacterRange" />.</returns>
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00009C10 File Offset: 0x00007E10
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00009C18 File Offset: 0x00007E18
		public int First
		{
			get
			{
				return this.first;
			}
			set
			{
				this.first = value;
			}
		}

		/// <summary>Получает или задает число позиций в этом диапазоне <see cref="T:System.Drawing.CharacterRange" />.</summary>
		/// <returns>Число позиций в этом диапазоне <see cref="T:System.Drawing.CharacterRange" />.</returns>
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00009C21 File Offset: 0x00007E21
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00009C29 File Offset: 0x00007E29
		public int Length
		{
			get
			{
				return this.length;
			}
			set
			{
				this.length = value;
			}
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный объект заданному объекту.</summary>
		/// <param name="obj">Объект для сравнения на равенство.</param>
		/// <returns>
		///   <see langword="true" />, показывающее, что заданный объект — экземпляр с теми же значениями <see cref="P:System.Drawing.CharacterRange.First" /> и <see cref="P:System.Drawing.CharacterRange.Length" />, что и данный экземпляр, в противном случае <see langword="false" />.</returns>
		// Token: 0x060003B9 RID: 953 RVA: 0x00009C34 File Offset: 0x00007E34
		public override bool Equals(object obj)
		{
			if (!(obj is CharacterRange))
			{
				return false;
			}
			CharacterRange cr = (CharacterRange)obj;
			return this == cr;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>32-разрядное целое число со знаком, являющееся хэш-кодом для данного экземпляра.</returns>
		// Token: 0x060003BA RID: 954 RVA: 0x00009C5E File Offset: 0x00007E5E
		public override int GetHashCode()
		{
			return this.first ^ this.length;
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.Drawing.CharacterRange" />. Возвращает значение, показывающее, равны  ли значения<see cref="P:System.Drawing.CharacterRange.First" /> и <see cref="P:System.Drawing.CharacterRange.Length" /> двух объектов <see cref="T:System.Drawing.CharacterRange" />.</summary>
		/// <param name="cr1">Диапазон <see cref="T:System.Drawing.CharacterRange" />, предназначенный для сравнения равенства.</param>
		/// <param name="cr2">Диапазон <see cref="T:System.Drawing.CharacterRange" />, предназначенный для сравнения равенства.</param>
		/// <returns>
		///   <see langword="true" />, показывающее, что у двух объектов <see cref="T:System.Drawing.CharacterRange" /> значения <see cref="P:System.Drawing.CharacterRange.First" /> и <see cref="P:System.Drawing.CharacterRange.Length" /> одинаковы, в противном случае <see langword="false" />.</returns>
		// Token: 0x060003BB RID: 955 RVA: 0x00009C6D File Offset: 0x00007E6D
		public static bool operator ==(CharacterRange cr1, CharacterRange cr2)
		{
			return cr1.first == cr2.first && cr1.length == cr2.length;
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.Drawing.CharacterRange" />. Возвращает значение, показывающее, являются ли неравными значения<see cref="P:System.Drawing.CharacterRange.First" /> или <see cref="P:System.Drawing.CharacterRange.Length" /> двух объектов <see cref="T:System.Drawing.CharacterRange" />.</summary>
		/// <param name="cr1">Диапазон <see cref="T:System.Drawing.CharacterRange" />, предназначенный для сравнения неравенства.</param>
		/// <param name="cr2">Диапазон <see cref="T:System.Drawing.CharacterRange" />, предназначенный для сравнения неравенства.</param>
		/// <returns>
		///   <see langword="true" />, показывающее отличие значений либо <see cref="P:System.Drawing.CharacterRange.First" />, либо <see cref="P:System.Drawing.CharacterRange.Length" /> двух объектов <see cref="T:System.Drawing.CharacterRange" />, в противном случае <see langword="false" />.</returns>
		// Token: 0x060003BC RID: 956 RVA: 0x00009C8D File Offset: 0x00007E8D
		public static bool operator !=(CharacterRange cr1, CharacterRange cr2)
		{
			return cr1.first != cr2.first || cr1.length != cr2.length;
		}

		// Token: 0x04000434 RID: 1076
		private int first;

		// Token: 0x04000435 RID: 1077
		private int length;
	}
}
