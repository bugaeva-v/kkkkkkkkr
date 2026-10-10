using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Структура <see langword="PropertyToken" /> является закрытым представлением возвращаемого метаданными маркера <see langword="Token" />, используемого для представления свойства.</summary>
	// Token: 0x02000942 RID: 2370
	[ComVisible(true)]
	[Serializable]
	public readonly struct PropertyToken : IEquatable<PropertyToken>
	{
		// Token: 0x0600524A RID: 21066 RVA: 0x001027CA File Offset: 0x001009CA
		internal PropertyToken(int val)
		{
			this.tokValue = val;
		}

		/// <summary>Проверяет, является ли данный объект экземпляром <see langword="PropertyToken" /> и равен ли он этому экземпляру.</summary>
		/// <param name="obj">Объект, подлежащий сравнению.</param>
		/// <returns>Возвращается <see langword="true" />, если <paramref name="obj" /> является экземпляром <see langword="PropertyToken" /> и совпадает с текущим экземпляром; в противном случае возвращается <see langword="false" />.</returns>
		// Token: 0x0600524B RID: 21067 RVA: 0x001027D4 File Offset: 0x001009D4
		public override bool Equals(object obj)
		{
			bool flag = obj is PropertyToken;
			if (flag)
			{
				PropertyToken propertyToken = (PropertyToken)obj;
				flag = (this.tokValue == propertyToken.tokValue);
			}
			return flag;
		}

		/// <summary>Определяет равенство текущего экземпляра и указанного объекта <see cref="T:System.Reflection.Emit.PropertyToken" />.</summary>
		/// <param name="obj">
		///   <see cref="T:System.Reflection.Emit.PropertyToken" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600524C RID: 21068 RVA: 0x00102805 File Offset: 0x00100A05
		public bool Equals(PropertyToken obj)
		{
			return this.tokValue == obj.tokValue;
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Reflection.Emit.PropertyToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.PropertyToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.PropertyToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600524D RID: 21069 RVA: 0x00102815 File Offset: 0x00100A15
		public static bool operator ==(PropertyToken a, PropertyToken b)
		{
			return object.Equals(a, b);
		}

		/// <summary>Указывает, действительно ли не равны две структуры <see cref="T:System.Reflection.Emit.PropertyToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.PropertyToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.PropertyToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="a" /> и <paramref name="b" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600524E RID: 21070 RVA: 0x00102828 File Offset: 0x00100A28
		public static bool operator !=(PropertyToken a, PropertyToken b)
		{
			return !object.Equals(a, b);
		}

		/// <summary>Создает хэш-код для данного свойства.</summary>
		/// <returns>Хэш-код для этого свойства.</returns>
		// Token: 0x0600524F RID: 21071 RVA: 0x0010283E File Offset: 0x00100A3E
		public override int GetHashCode()
		{
			return this.tokValue;
		}

		/// <summary>Извлекает маркер метаданных для данного свойства.</summary>
		/// <returns>Только для чтения. Извлекает маркер метаданных для данного экземпляра.</returns>
		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06005250 RID: 21072 RVA: 0x0010283E File Offset: 0x00100A3E
		public int Token
		{
			get
			{
				return this.tokValue;
			}
		}

		// Token: 0x04003309 RID: 13065
		internal readonly int tokValue;

		/// <summary>По умолчанию <see langword="PropertyToken" /> с <see cref="P:System.Reflection.Emit.PropertyToken.Token" /> используется значение 0.</summary>
		// Token: 0x0400330A RID: 13066
		public static readonly PropertyToken Empty;
	}
}
