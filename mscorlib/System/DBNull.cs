using System;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Представляет несуществующее значение. Этот класс не наследуется.</summary>
	// Token: 0x0200010A RID: 266
	[Serializable]
	public sealed class DBNull : ISerializable, IConvertible
	{
		// Token: 0x0600098D RID: 2445 RVA: 0x0000259F File Offset: 0x0000079F
		private DBNull()
		{
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000258C0 File Offset: 0x00023AC0
		private DBNull(SerializationInfo info, StreamingContext context)
		{
			throw new NotSupportedException("Only one DBNull instance may exist, and calls to DBNull deserialization methods are not allowed.");
		}

		/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и возвращает данные, необходимые для сериализации объекта <see cref="T:System.DBNull" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сведения, которые требуются для сериализации объекта <see cref="T:System.DBNull" />.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий исходный объект и объект назначения для сериализованного потока, связанного с объектом <see cref="T:System.DBNull" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600098F RID: 2447 RVA: 0x000258D2 File Offset: 0x00023AD2
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			UnitySerializationHolder.GetUnitySerializationInfo(info, 2);
		}

		/// <summary>Возвращает пустую строку (<see cref="F:System.String.Empty" />).</summary>
		/// <returns>Пустая строка (<see cref="F:System.String.Empty" />).</returns>
		// Token: 0x06000990 RID: 2448 RVA: 0x000258DB File Offset: 0x00023ADB
		public override string ToString()
		{
			return string.Empty;
		}

		/// <summary>Возвращает пустую строку, используя заданный объект <see cref="T:System.IFormatProvider" />.</summary>
		/// <param name="provider">Объект <see cref="T:System.IFormatProvider" />, используемый для форматирования возвращаемого значения.  
		///
		/// или - 
		/// Значение <see langword="null" />, чтобы получить сведения о форматировании на основе текущего значения параметра языкового стандарта операционной системы.</param>
		/// <returns>Пустая строка (<see cref="F:System.String.Empty" />).</returns>
		// Token: 0x06000991 RID: 2449 RVA: 0x000258DB File Offset: 0x00023ADB
		public string ToString(IFormatProvider provider)
		{
			return string.Empty;
		}

		/// <summary>Возвращает значение <see cref="T:System.TypeCode" /> для объекта <see cref="T:System.DBNull" />.</summary>
		/// <returns>Значение <see cref="T:System.TypeCode" /> для объекта <see cref="T:System.DBNull" />, который является полем <see cref="F:System.TypeCode.DBNull" />.</returns>
		// Token: 0x06000992 RID: 2450 RVA: 0x00015831 File Offset: 0x00013A31
		public TypeCode GetTypeCode()
		{
			return TypeCode.DBNull;
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x06000993 RID: 2451 RVA: 0x000258E2 File Offset: 0x00023AE2
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x06000994 RID: 2452 RVA: 0x000258E2 File Offset: 0x00023AE2
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x06000995 RID: 2453 RVA: 0x000258E2 File Offset: 0x00023AE2
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x06000996 RID: 2454 RVA: 0x000258E2 File Offset: 0x00023AE2
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x06000997 RID: 2455 RVA: 0x000258E2 File Offset: 0x00023AE2
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x06000998 RID: 2456 RVA: 0x000258E2 File Offset: 0x00023AE2
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x06000999 RID: 2457 RVA: 0x000258E2 File Offset: 0x00023AE2
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x0600099A RID: 2458 RVA: 0x000258E2 File Offset: 0x00023AE2
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x0600099B RID: 2459 RVA: 0x000258E2 File Offset: 0x00023AE2
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x0600099C RID: 2460 RVA: 0x000258E2 File Offset: 0x00023AE2
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x0600099D RID: 2461 RVA: 0x000258E2 File Offset: 0x00023AE2
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x0600099E RID: 2462 RVA: 0x000258E2 File Offset: 0x00023AE2
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x0600099F RID: 2463 RVA: 0x000258E2 File Offset: 0x00023AE2
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Данное преобразование не поддерживается. Попытка выполнить такое преобразование приведет к возникновению исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" />. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <returns>Отсутствует. Возвращаемое значение для этого члена не используется.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		// Token: 0x060009A0 RID: 2464 RVA: 0x000258E2 File Offset: 0x00023AE2
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException("Object cannot be cast from DBNull to other types.");
		}

		/// <summary>Преобразует текущий объект <see cref="T:System.DBNull" /> в объект заданного типа.</summary>
		/// <param name="type">Тип данных, к которому необходимо привести текущий объект <see cref="T:System.DBNull" />.</param>
		/// <param name="provider">Объект, реализующий интерфейс <see cref="T:System.IFormatProvider" /> и используемый для расширения преобразования. Если задано значение <see langword="null" />, сведения о формате извлекаются из данных о текущем языке и региональных параметрах.</param>
		/// <returns>Упакованный эквивалент текущего объекта <see cref="T:System.DBNull" />, если такое преобразование поддерживается. Если оно не поддерживается, создается исключение и значение не возвращается.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается для типа <see cref="T:System.DBNull" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060009A1 RID: 2465 RVA: 0x0001931A File Offset: 0x0001751A
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		/// <summary>Представляет единственный экземпляр класса <see cref="T:System.DBNull" />.</summary>
		// Token: 0x04001092 RID: 4242
		public static readonly DBNull Value = new DBNull();
	}
}
