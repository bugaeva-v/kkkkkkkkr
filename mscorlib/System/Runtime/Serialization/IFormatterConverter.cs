using System;

namespace System.Runtime.Serialization
{
	/// <summary>Осуществляет связь между экземпляром <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и предоставленным форматером классом, наиболее подходящим для анализа данных внутри <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
	// Token: 0x02000648 RID: 1608
	[CLSCompliant(false)]
	public interface IFormatterConverter
	{
		/// <summary>Преобразует значение в заданный <see cref="T:System.Type" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <param name="type">Объект <see cref="T:System.Type" />, в который необходимо преобразовать параметр <paramref name="value" />.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C3C RID: 15420
		object Convert(object value, Type type);

		/// <summary>Преобразует значение в заданный <see cref="T:System.TypeCode" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <param name="typeCode">Объект <see cref="T:System.TypeCode" />, в который необходимо преобразовать параметр <paramref name="value" />.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C3D RID: 15421
		object Convert(object value, TypeCode typeCode);

		/// <summary>Преобразует значение в <see cref="T:System.Boolean" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C3E RID: 15422
		bool ToBoolean(object value);

		/// <summary>Преобразует значение в знак Юникода.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C3F RID: 15423
		char ToChar(object value);

		/// <summary>Преобразует значение в <see cref="T:System.SByte" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C40 RID: 15424
		sbyte ToSByte(object value);

		/// <summary>Преобразует значение в 8-битовое целое число без знака.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C41 RID: 15425
		byte ToByte(object value);

		/// <summary>Преобразует значение в 16-битовое знаковое целое число.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C42 RID: 15426
		short ToInt16(object value);

		/// <summary>Преобразует значение в 16-битовое целое число без знака.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C43 RID: 15427
		ushort ToUInt16(object value);

		/// <summary>Преобразует значение в 32-битовое целое число со знаком.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C44 RID: 15428
		int ToInt32(object value);

		/// <summary>Преобразует значение в 32-битовое целое число без знака.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C45 RID: 15429
		uint ToUInt32(object value);

		/// <summary>Преобразует значение в 64-битовое целое число со знаком.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C46 RID: 15430
		long ToInt64(object value);

		/// <summary>Преобразует значение в 64-битовое целое число без знака.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C47 RID: 15431
		ulong ToUInt64(object value);

		/// <summary>Преобразует значение в число обычной точности с плавающей запятой.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C48 RID: 15432
		float ToSingle(object value);

		/// <summary>Преобразует значение в число удвоенной точности с плавающей запятой.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C49 RID: 15433
		double ToDouble(object value);

		/// <summary>Преобразует значение в <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C4A RID: 15434
		decimal ToDecimal(object value);

		/// <summary>Преобразует значение в <see cref="T:System.DateTime" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C4B RID: 15435
		DateTime ToDateTime(object value);

		/// <summary>Преобразует значение в <see cref="T:System.String" />.</summary>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразуемый <paramref name="value" />.</returns>
		// Token: 0x06003C4C RID: 15436
		string ToString(object value);
	}
}
