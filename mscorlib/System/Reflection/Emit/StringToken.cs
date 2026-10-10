using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Представляет маркер, представляющий строку.</summary>
	// Token: 0x02000946 RID: 2374
	[ComVisible(true)]
	[Serializable]
	public readonly struct StringToken : IEquatable<StringToken>
	{
		// Token: 0x0600527D RID: 21117 RVA: 0x00102E4A File Offset: 0x0010104A
		internal StringToken(int val)
		{
			this.tokValue = val;
		}

		/// <summary>Проверяет, является ли данный объект экземпляром <see langword="StringToken" /> и равен ли он этому экземпляру.</summary>
		/// <param name="obj">Объект, который требуется сравнить с данным объектом <see langword="StringToken" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> является экземпляром <see langword="StringToken" /> и равен этому объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600527E RID: 21118 RVA: 0x00102E54 File Offset: 0x00101054
		public override bool Equals(object obj)
		{
			bool flag = obj is StringToken;
			if (flag)
			{
				StringToken stringToken = (StringToken)obj;
				flag = (this.tokValue == stringToken.tokValue);
			}
			return flag;
		}

		/// <summary>Определяет равенство текущего экземпляра и указанного объекта <see cref="T:System.Reflection.Emit.StringToken" />.</summary>
		/// <param name="obj">
		///   <see cref="T:System.Reflection.Emit.StringToken" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600527F RID: 21119 RVA: 0x00102E85 File Offset: 0x00101085
		public bool Equals(StringToken obj)
		{
			return this.tokValue == obj.tokValue;
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Reflection.Emit.StringToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.StringToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.StringToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005280 RID: 21120 RVA: 0x00102E95 File Offset: 0x00101095
		public static bool operator ==(StringToken a, StringToken b)
		{
			return object.Equals(a, b);
		}

		/// <summary>Указывает, действительно ли не равны две структуры <see cref="T:System.Reflection.Emit.StringToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.StringToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.StringToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="a" /> и <paramref name="b" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005281 RID: 21121 RVA: 0x00102EA8 File Offset: 0x001010A8
		public static bool operator !=(StringToken a, StringToken b)
		{
			return !object.Equals(a, b);
		}

		/// <summary>Возвращает хэш-код для этой строки.</summary>
		/// <returns>Токен базовой строки.</returns>
		// Token: 0x06005282 RID: 21122 RVA: 0x00102EBE File Offset: 0x001010BE
		public override int GetHashCode()
		{
			return this.tokValue;
		}

		/// <summary>Получает маркер метаданных для данной строки.</summary>
		/// <returns>Только для чтения. Получает маркер метаданных для данной строки.</returns>
		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06005283 RID: 21123 RVA: 0x00102EBE File Offset: 0x001010BE
		public int Token
		{
			get
			{
				return this.tokValue;
			}
		}

		// Token: 0x0400331A RID: 13082
		internal readonly int tokValue;
	}
}
