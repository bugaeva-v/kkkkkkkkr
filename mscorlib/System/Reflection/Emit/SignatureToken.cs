using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Предоставляет <see langword="Token" />, возвращенный метаданными для представления сигнатуры.</summary>
	// Token: 0x02000945 RID: 2373
	[ComVisible(true)]
	public readonly struct SignatureToken : IEquatable<SignatureToken>
	{
		// Token: 0x06005275 RID: 21109 RVA: 0x00102DCF File Offset: 0x00100FCF
		internal SignatureToken(int val)
		{
			this.tokValue = val;
		}

		/// <summary>Проверяет, является ли данный объект экземпляром <see langword="SignatureToken" /> и равен ли он этому экземпляру.</summary>
		/// <param name="obj">Объект, который требуется сравнить с данным объектом <see langword="SignatureToken" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> является экземпляром <see langword="SignatureToken" /> и равен этому объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005276 RID: 21110 RVA: 0x00102DD8 File Offset: 0x00100FD8
		public override bool Equals(object obj)
		{
			bool flag = obj is SignatureToken;
			if (flag)
			{
				SignatureToken signatureToken = (SignatureToken)obj;
				flag = (this.tokValue == signatureToken.tokValue);
			}
			return flag;
		}

		/// <summary>Определяет равенство текущего экземпляра и указанного объекта <see cref="T:System.Reflection.Emit.SignatureToken" />.</summary>
		/// <param name="obj">
		///   <see cref="T:System.Reflection.Emit.SignatureToken" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005277 RID: 21111 RVA: 0x00102E09 File Offset: 0x00101009
		public bool Equals(SignatureToken obj)
		{
			return this.tokValue == obj.tokValue;
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Reflection.Emit.SignatureToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.SignatureToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.SignatureToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005278 RID: 21112 RVA: 0x00102E19 File Offset: 0x00101019
		public static bool operator ==(SignatureToken a, SignatureToken b)
		{
			return object.Equals(a, b);
		}

		/// <summary>Указывает, действительно ли не равны две структуры <see cref="T:System.Reflection.Emit.SignatureToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.SignatureToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.SignatureToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="a" /> и <paramref name="b" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005279 RID: 21113 RVA: 0x00102E2C File Offset: 0x0010102C
		public static bool operator !=(SignatureToken a, SignatureToken b)
		{
			return !object.Equals(a, b);
		}

		/// <summary>Создает хэш-код для этой сигнатуры.</summary>
		/// <returns>Хэш-код для этой сигнатуры.</returns>
		// Token: 0x0600527A RID: 21114 RVA: 0x00102E42 File Offset: 0x00101042
		public override int GetHashCode()
		{
			return this.tokValue;
		}

		/// <summary>Извлекает маркер метаданных для сигнатуры локальной переменной для этого метода.</summary>
		/// <returns>Только для чтения. Извлекает маркер метаданных этой сигнатуры.</returns>
		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x0600527B RID: 21115 RVA: 0x00102E42 File Offset: 0x00101042
		public int Token
		{
			get
			{
				return this.tokValue;
			}
		}

		// Token: 0x04003318 RID: 13080
		internal readonly int tokValue;

		/// <summary>По умолчанию <see langword="SignatureToken" /> с <see cref="P:System.Reflection.Emit.SignatureToken.Token" /> используется значение 0.</summary>
		// Token: 0x04003319 RID: 13081
		public static readonly SignatureToken Empty;
	}
}
