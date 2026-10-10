using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Представляет <see langword="Token" />, возвращенный метаданными для представления подписи.</summary>
	// Token: 0x02000949 RID: 2377
	[ComVisible(true)]
	[Serializable]
	public readonly struct TypeToken : IEquatable<TypeToken>
	{
		// Token: 0x06005353 RID: 21331 RVA: 0x00105C1C File Offset: 0x00103E1C
		internal TypeToken(int val)
		{
			this.tokValue = val;
		}

		/// <summary>Проверяет, является ли данный объект экземпляром <see langword="TypeToken" /> и равен ли он этому экземпляру.</summary>
		/// <param name="obj">Объект, который требуется сравнить с TypeToken.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> является экземпляром <see langword="TypeToken" /> и равен этому объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005354 RID: 21332 RVA: 0x00105C28 File Offset: 0x00103E28
		public override bool Equals(object obj)
		{
			bool flag = obj is TypeToken;
			if (flag)
			{
				TypeToken typeToken = (TypeToken)obj;
				flag = (this.tokValue == typeToken.tokValue);
			}
			return flag;
		}

		/// <summary>Определяет равенство текущего экземпляра и указанного объекта <see cref="T:System.Reflection.Emit.TypeToken" />.</summary>
		/// <param name="obj">
		///   <see cref="T:System.Reflection.Emit.TypeToken" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005355 RID: 21333 RVA: 0x00105C59 File Offset: 0x00103E59
		public bool Equals(TypeToken obj)
		{
			return this.tokValue == obj.tokValue;
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Reflection.Emit.TypeToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.TypeToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.TypeToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005356 RID: 21334 RVA: 0x00105C69 File Offset: 0x00103E69
		public static bool operator ==(TypeToken a, TypeToken b)
		{
			return object.Equals(a, b);
		}

		/// <summary>Указывает, действительно ли не равны две структуры <see cref="T:System.Reflection.Emit.TypeToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.TypeToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.TypeToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="a" /> и <paramref name="b" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005357 RID: 21335 RVA: 0x00105C7C File Offset: 0x00103E7C
		public static bool operator !=(TypeToken a, TypeToken b)
		{
			return !object.Equals(a, b);
		}

		/// <summary>Создает хэш-код для этого типа.</summary>
		/// <returns>Хэш-код для этого типа.</returns>
		// Token: 0x06005358 RID: 21336 RVA: 0x00105C92 File Offset: 0x00103E92
		public override int GetHashCode()
		{
			return this.tokValue;
		}

		/// <summary>Получает маркер метаданных для данного класса.</summary>
		/// <returns>Только для чтения. Получает маркер метаданных для данного типа.</returns>
		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06005359 RID: 21337 RVA: 0x00105C92 File Offset: 0x00103E92
		public int Token
		{
			get
			{
				return this.tokValue;
			}
		}

		// Token: 0x0400333D RID: 13117
		internal readonly int tokValue;

		/// <summary>По умолчанию <see langword="TypeToken" /> с <see cref="P:System.Reflection.Emit.TypeToken.Token" /> используется значение 0.</summary>
		// Token: 0x0400333E RID: 13118
		public static readonly TypeToken Empty;
	}
}
