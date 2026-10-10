using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Структура <see langword="ParameterToken" /> является закрытым представлением возвращаемого метаданными маркера, используемого для представления параметра.</summary>
	// Token: 0x0200093F RID: 2367
	[ComVisible(true)]
	[Serializable]
	public readonly struct ParameterToken : IEquatable<ParameterToken>
	{
		// Token: 0x0600520F RID: 21007 RVA: 0x001023FA File Offset: 0x001005FA
		internal ParameterToken(int val)
		{
			this.tokValue = val;
		}

		/// <summary>Проверяет, является ли данный объект экземпляром <see langword="ParameterToken" /> и равен ли он этому экземпляру.</summary>
		/// <param name="obj">Объект, который требуется сравнить с данным объектом.</param>
		/// <returns>Возвращается <see langword="true" />, если <paramref name="obj" /> является экземпляром <see langword="ParameterToken" /> и совпадает с текущим экземпляром; в противном случае возвращается <see langword="false" />.</returns>
		// Token: 0x06005210 RID: 21008 RVA: 0x00102404 File Offset: 0x00100604
		public override bool Equals(object obj)
		{
			bool flag = obj is ParameterToken;
			if (flag)
			{
				ParameterToken parameterToken = (ParameterToken)obj;
				flag = (this.tokValue == parameterToken.tokValue);
			}
			return flag;
		}

		/// <summary>Определяет равенство текущего экземпляра и указанного объекта <see cref="T:System.Reflection.Emit.ParameterToken" />.</summary>
		/// <param name="obj">
		///   <see cref="T:System.Reflection.Emit.ParameterToken" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005211 RID: 21009 RVA: 0x00102435 File Offset: 0x00100635
		public bool Equals(ParameterToken obj)
		{
			return this.tokValue == obj.tokValue;
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Reflection.Emit.ParameterToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.ParameterToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.ParameterToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005212 RID: 21010 RVA: 0x00102445 File Offset: 0x00100645
		public static bool operator ==(ParameterToken a, ParameterToken b)
		{
			return object.Equals(a, b);
		}

		/// <summary>Указывает, действительно ли не равны две структуры <see cref="T:System.Reflection.Emit.ParameterToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.ParameterToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.ParameterToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="a" /> и <paramref name="b" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005213 RID: 21011 RVA: 0x00102458 File Offset: 0x00100658
		public static bool operator !=(ParameterToken a, ParameterToken b)
		{
			return !object.Equals(a, b);
		}

		/// <summary>Создает хэш-код для данного параметра.</summary>
		/// <returns>Хэш-код для этого параметра.</returns>
		// Token: 0x06005214 RID: 21012 RVA: 0x0010246E File Offset: 0x0010066E
		public override int GetHashCode()
		{
			return this.tokValue;
		}

		/// <summary>Извлекает маркер метаданных для данного параметра.</summary>
		/// <returns>Только для чтения. Извлекает маркер метаданных для данного параметра.</returns>
		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06005215 RID: 21013 RVA: 0x0010246E File Offset: 0x0010066E
		public int Token
		{
			get
			{
				return this.tokValue;
			}
		}

		// Token: 0x040032F6 RID: 13046
		internal readonly int tokValue;

		/// <summary>По умолчанию <see langword="ParameterToken" /> с <see cref="P:System.Reflection.Emit.ParameterToken.Token" /> используется значение 0.</summary>
		// Token: 0x040032F7 RID: 13047
		public static readonly ParameterToken Empty;
	}
}
