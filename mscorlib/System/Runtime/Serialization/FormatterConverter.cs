using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
	/// <summary>Представляет базовую реализацию интерфейса <see cref="T:System.Runtime.Serialization.IFormatterConverter" />, использующую класс <see cref="T:System.Convert" /> и интерфейс <see cref="T:System.IConvertible" />.</summary>
	// Token: 0x02000651 RID: 1617
	public class FormatterConverter : IFormatterConverter
	{
		/// <summary>Преобразует значение в заданный <see cref="T:System.Type" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <param name="type">
		///   <see cref="T:System.Type" />, в который преобразуется <paramref name="value" />.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C87 RID: 15495 RVA: 0x000D1929 File Offset: 0x000CFB29
		public object Convert(object value, Type type)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ChangeType(value, type, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в заданный <see cref="T:System.TypeCode" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <param name="typeCode">
		///   <see cref="T:System.TypeCode" />, в который преобразуется <paramref name="value" />.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C88 RID: 15496 RVA: 0x000D193F File Offset: 0x000CFB3F
		public object Convert(object value, TypeCode typeCode)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ChangeType(value, typeCode, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в <see cref="T:System.Boolean" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C89 RID: 15497 RVA: 0x000D1955 File Offset: 0x000CFB55
		public bool ToBoolean(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToBoolean(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в знак Юникода.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C8A RID: 15498 RVA: 0x000D196A File Offset: 0x000CFB6A
		public char ToChar(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToChar(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в <see cref="T:System.SByte" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C8B RID: 15499 RVA: 0x000D197F File Offset: 0x000CFB7F
		[CLSCompliant(false)]
		public sbyte ToSByte(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToSByte(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в 8-битовое целое число без знака.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C8C RID: 15500 RVA: 0x000D1994 File Offset: 0x000CFB94
		public byte ToByte(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToByte(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в 16-битовое знаковое целое число.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C8D RID: 15501 RVA: 0x000D19A9 File Offset: 0x000CFBA9
		public short ToInt16(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToInt16(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в 16-битовое целое число без знака.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C8E RID: 15502 RVA: 0x000D19BE File Offset: 0x000CFBBE
		[CLSCompliant(false)]
		public ushort ToUInt16(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToUInt16(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в 32-битовое целое число со знаком.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C8F RID: 15503 RVA: 0x000D19D3 File Offset: 0x000CFBD3
		public int ToInt32(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToInt32(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в 32-битовое целое число без знака.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C90 RID: 15504 RVA: 0x000D19E8 File Offset: 0x000CFBE8
		[CLSCompliant(false)]
		public uint ToUInt32(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToUInt32(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в 64-битовое целое число со знаком.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C91 RID: 15505 RVA: 0x000D19FD File Offset: 0x000CFBFD
		public long ToInt64(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToInt64(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в 64-битовое целое число без знака.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C92 RID: 15506 RVA: 0x000D1A12 File Offset: 0x000CFC12
		[CLSCompliant(false)]
		public ulong ToUInt64(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToUInt64(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в число обычной точности с плавающей запятой.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C93 RID: 15507 RVA: 0x000D1A27 File Offset: 0x000CFC27
		public float ToSingle(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToSingle(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в число удвоенной точности с плавающей запятой.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C94 RID: 15508 RVA: 0x000D1A3C File Offset: 0x000CFC3C
		public double ToDouble(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToDouble(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C95 RID: 15509 RVA: 0x000D1A51 File Offset: 0x000CFC51
		public decimal ToDecimal(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToDecimal(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует значение в <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C96 RID: 15510 RVA: 0x000D1A66 File Offset: 0x000CFC66
		public DateTime ToDateTime(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToDateTime(value, CultureInfo.InvariantCulture);
		}

		/// <summary>Преобразует указанный объект в <see cref="T:System.String" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованное значение параметра <paramref name="value" /> или значение <see langword="null" />, если параметр <paramref name="type" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C97 RID: 15511 RVA: 0x000D1A7B File Offset: 0x000CFC7B
		public string ToString(object value)
		{
			if (value == null)
			{
				FormatterConverter.ThrowValueNullException();
			}
			return System.Convert.ToString(value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x000D1A90 File Offset: 0x000CFC90
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowValueNullException()
		{
			throw new ArgumentNullException("value");
		}
	}
}
