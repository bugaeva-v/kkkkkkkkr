using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Структура <see langword="MethodToken" /> является объектным представлением маркера, представляющего метод.</summary>
	// Token: 0x02000937 RID: 2359
	[ComVisible(true)]
	[Serializable]
	public readonly struct MethodToken : IEquatable<MethodToken>
	{
		// Token: 0x06005170 RID: 20848 RVA: 0x000FE985 File Offset: 0x000FCB85
		internal MethodToken(int val)
		{
			this.tokValue = val;
		}

		/// <summary>Проверяет, идентичен ли указанный объект данному объекту <see langword="MethodToken" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с данным объектом.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> является экземпляром <see langword="MethodToken" /> и равен этому объекту; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005171 RID: 20849 RVA: 0x000FE990 File Offset: 0x000FCB90
		public override bool Equals(object obj)
		{
			bool flag = obj is MethodToken;
			if (flag)
			{
				MethodToken methodToken = (MethodToken)obj;
				flag = (this.tokValue == methodToken.tokValue);
			}
			return flag;
		}

		/// <summary>Определяет равенство текущего экземпляра и указанного объекта <see cref="T:System.Reflection.Emit.MethodToken" />.</summary>
		/// <param name="obj">
		///   <see cref="T:System.Reflection.Emit.MethodToken" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005172 RID: 20850 RVA: 0x000FE9C1 File Offset: 0x000FCBC1
		public bool Equals(MethodToken obj)
		{
			return this.tokValue == obj.tokValue;
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Reflection.Emit.MethodToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.MethodToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.MethodToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005173 RID: 20851 RVA: 0x000FE9D1 File Offset: 0x000FCBD1
		public static bool operator ==(MethodToken a, MethodToken b)
		{
			return object.Equals(a, b);
		}

		/// <summary>Указывает, действительно ли не равны две структуры <see cref="T:System.Reflection.Emit.MethodToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.MethodToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.MethodToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="a" /> и <paramref name="b" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005174 RID: 20852 RVA: 0x000FE9E4 File Offset: 0x000FCBE4
		public static bool operator !=(MethodToken a, MethodToken b)
		{
			return !object.Equals(a, b);
		}

		/// <summary>Возвращает созданный для данного метода хэш-код.</summary>
		/// <returns>Хэш-код данного экземпляра.</returns>
		// Token: 0x06005175 RID: 20853 RVA: 0x000FE9FA File Offset: 0x000FCBFA
		public override int GetHashCode()
		{
			return this.tokValue;
		}

		/// <summary>Возвращает маркер метаданных для данного метода.</summary>
		/// <returns>Только для чтения. Возвращает маркер метаданных для данного метода.</returns>
		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06005176 RID: 20854 RVA: 0x000FE9FA File Offset: 0x000FCBFA
		public int Token
		{
			get
			{
				return this.tokValue;
			}
		}

		// Token: 0x040031D8 RID: 12760
		internal readonly int tokValue;

		/// <summary>По умолчанию <see langword="MethodToken" /> с <see cref="P:System.Reflection.Emit.MethodToken.Token" /> используется значение 0.</summary>
		// Token: 0x040031D9 RID: 12761
		public static readonly MethodToken Empty;
	}
}
