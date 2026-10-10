using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Структура <see langword="FieldToken" /> является объектным представлением маркера, представляющего поле.</summary>
	// Token: 0x02000926 RID: 2342
	[ComVisible(true)]
	[Serializable]
	public readonly struct FieldToken : IEquatable<FieldToken>
	{
		// Token: 0x0600503D RID: 20541 RVA: 0x000FAEB6 File Offset: 0x000F90B6
		internal FieldToken(int val)
		{
			this.tokValue = val;
		}

		/// <summary>Определяет, является ли указанный объект экземпляром <see langword="FieldToken" /> и совпадает ли он с данным экземпляром.</summary>
		/// <param name="obj">Объект, который требуется сравнить с данным объектом <see langword="FieldToken" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> является экземпляром <see langword="FieldToken" /> и равен этому объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600503E RID: 20542 RVA: 0x000FAEC0 File Offset: 0x000F90C0
		public override bool Equals(object obj)
		{
			bool flag = obj is FieldToken;
			if (flag)
			{
				FieldToken fieldToken = (FieldToken)obj;
				flag = (this.tokValue == fieldToken.tokValue);
			}
			return flag;
		}

		/// <summary>Определяет равенство текущего экземпляра и указанного объекта <see cref="T:System.Reflection.Emit.FieldToken" />.</summary>
		/// <param name="obj">
		///   <see cref="T:System.Reflection.Emit.FieldToken" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600503F RID: 20543 RVA: 0x000FAEF1 File Offset: 0x000F90F1
		public bool Equals(FieldToken obj)
		{
			return this.tokValue == obj.tokValue;
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Reflection.Emit.FieldToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.FieldToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.FieldToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005040 RID: 20544 RVA: 0x000FAF01 File Offset: 0x000F9101
		public static bool operator ==(FieldToken a, FieldToken b)
		{
			return object.Equals(a, b);
		}

		/// <summary>Указывает, действительно ли не равны две структуры <see cref="T:System.Reflection.Emit.FieldToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.FieldToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.FieldToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="a" /> и <paramref name="b" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005041 RID: 20545 RVA: 0x000FAF14 File Offset: 0x000F9114
		public static bool operator !=(FieldToken a, FieldToken b)
		{
			return !object.Equals(a, b);
		}

		/// <summary>Создает хэш-код для данного поля.</summary>
		/// <returns>Хэш-код данного экземпляра.</returns>
		// Token: 0x06005042 RID: 20546 RVA: 0x000FAF2A File Offset: 0x000F912A
		public override int GetHashCode()
		{
			return this.tokValue;
		}

		/// <summary>Извлекает маркер метаданных для данного поля.</summary>
		/// <returns>Только для чтения. Извлекает маркер метаданных данного поля.</returns>
		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06005043 RID: 20547 RVA: 0x000FAF2A File Offset: 0x000F912A
		public int Token
		{
			get
			{
				return this.tokValue;
			}
		}

		// Token: 0x0400316B RID: 12651
		internal readonly int tokValue;

		/// <summary>Используемая по умолчанию FieldToken, значение свойства <see cref="P:System.Reflection.Emit.FieldToken.Token" /> которого равно 0.</summary>
		// Token: 0x0400316C RID: 12652
		public static readonly FieldToken Empty;
	}
}
