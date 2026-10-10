using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Определяемый платформой тип, который используется для представления указателя или дескриптора.</summary>
	// Token: 0x02000265 RID: 613
	[ComVisible(true)]
	[CLSCompliant(false)]
	[Serializable]
	public readonly struct UIntPtr : ISerializable, IEquatable<UIntPtr>
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.UIntPtr" /> с помощью заданного 64-битового указателя или дескриптора.</summary>
		/// <param name="value">Указатель или дескриптор, содержащийся в 64-битовом целом числе без знака.</param>
		/// <exception cref="T:System.OverflowException">На 32-разрядной платформе значение параметра <paramref name="value" /> слишком велико для представления параметра <see cref="T:System.UIntPtr" />.</exception>
		// Token: 0x06001BF4 RID: 7156 RVA: 0x0006894E File Offset: 0x00066B4E
		public UIntPtr(ulong value)
		{
			if (value > (ulong)-1 && UIntPtr.Size < 8)
			{
				throw new OverflowException(Locale.GetText("This isn't a 64bits machine."));
			}
			this._pointer = value;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.UIntPtr" /> с использованием указанного 32-битового указателя или дескриптора.</summary>
		/// <param name="value">Указатель или дескриптор, содержащийся в 32-битовом целом числе без знака.</param>
		// Token: 0x06001BF5 RID: 7157 RVA: 0x00068975 File Offset: 0x00066B75
		public UIntPtr(uint value)
		{
			this._pointer = value;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.UIntPtr" /> с использованием заданного указателя на незаданный тип.</summary>
		/// <param name="value">Указатель незаданного типа.</param>
		// Token: 0x06001BF6 RID: 7158 RVA: 0x0006897F File Offset: 0x00066B7F
		[CLSCompliant(false)]
		public unsafe UIntPtr(void* value)
		{
			this._pointer = value;
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром или <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является экземпляром типа <see cref="T:System.UIntPtr" /> и равен значению данного экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001BF7 RID: 7159 RVA: 0x00068988 File Offset: 0x00066B88
		public override bool Equals(object obj)
		{
			if (obj is UIntPtr)
			{
				UIntPtr uintPtr = (UIntPtr)obj;
				return this._pointer == uintPtr._pointer;
			}
			return false;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001BF8 RID: 7160 RVA: 0x000689B5 File Offset: 0x00066BB5
		public override int GetHashCode()
		{
			return this._pointer;
		}

		/// <summary>Преобразует значение данного экземпляра в 32-битовое целое число без знака.</summary>
		/// <returns>32-битовое целое число без знака, эквивалентное значению данного экземпляра.</returns>
		/// <exception cref="T:System.OverflowException">На 64-разрядной платформе значение указателя слишком велико, чтобы быть представленным 32-битовым целым числом без знака.</exception>
		// Token: 0x06001BF9 RID: 7161 RVA: 0x000689BE File Offset: 0x00066BBE
		public uint ToUInt32()
		{
			return this._pointer;
		}

		/// <summary>Преобразует значение данного экземпляра в 64-битовое целое число без знака.</summary>
		/// <returns>64-битовое целое число без знака, эквивалентное значению данного экземпляра.</returns>
		// Token: 0x06001BFA RID: 7162 RVA: 0x000689C7 File Offset: 0x00066BC7
		public ulong ToUInt64()
		{
			return this._pointer;
		}

		/// <summary>Преобразует значение этого экземпляра в указатель незаданного типа.</summary>
		/// <returns>Указатель на <see cref="T:System.Void" /> (указатель на ячейку памяти, содержащую данные незаданного типа).</returns>
		// Token: 0x06001BFB RID: 7163 RVA: 0x000689D0 File Offset: 0x00066BD0
		[CLSCompliant(false)]
		public unsafe void* ToPointer()
		{
			return this._pointer;
		}

		/// <summary>Преобразовывает числовое значение данного экземпляра в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения этого экземпляра.</returns>
		// Token: 0x06001BFC RID: 7164 RVA: 0x000689D8 File Offset: 0x00066BD8
		public override string ToString()
		{
			if (UIntPtr.Size >= 8)
			{
				return this._pointer.ToString();
			}
			return this._pointer.ToString();
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации текущего объекта <see cref="T:System.UIntPtr" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который требуется заполнить данными.</param>
		/// <param name="context">Целевой объект этой сериализации. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> — <see langword="null" />.</exception>
		// Token: 0x06001BFD RID: 7165 RVA: 0x00068A0C File Offset: 0x00066C0C
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("pointer", this._pointer);
		}

		/// <summary>Определяет, равны ли два заданных экземпляра класса <see cref="T:System.UIntPtr" />.</summary>
		/// <param name="value1">Первый из сравниваемых указателей или дескрипторов.</param>
		/// <param name="value2">Второй из сравниваемых указателей или дескрипторов.</param>
		/// <returns>Если значение <paramref name="value1" /> равно <paramref name="value2" />, значение <see langword="true" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001BFE RID: 7166 RVA: 0x00068A2E File Offset: 0x00066C2E
		public static bool operator ==(UIntPtr value1, UIntPtr value2)
		{
			return value1._pointer == value2._pointer;
		}

		/// <summary>Определяет, являются ли два заданных экземпляра класса <see cref="T:System.UIntPtr" /> неравными.</summary>
		/// <param name="value1">Первый из сравниваемых указателей или дескрипторов.</param>
		/// <param name="value2">Второй из сравниваемых указателей или дескрипторов.</param>
		/// <returns>Значение <see langword="true" />, если значения параметров <paramref name="value1" /> и <paramref name="value2" /> не равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001BFF RID: 7167 RVA: 0x00068A40 File Offset: 0x00066C40
		public static bool operator !=(UIntPtr value1, UIntPtr value2)
		{
			return value1._pointer != value2._pointer;
		}

		/// <summary>Преобразует значение заданного указателя <see cref="T:System.UIntPtr" /> в 64-битовое целое число без знака.</summary>
		/// <param name="value">Указатель или дескриптор, подлежащий преобразованию.</param>
		/// <returns>Содержимое <paramref name="value" />.</returns>
		// Token: 0x06001C00 RID: 7168 RVA: 0x00068A55 File Offset: 0x00066C55
		public static explicit operator ulong(UIntPtr value)
		{
			return value._pointer;
		}

		/// <summary>Преобразует значение заданного указателя <see cref="T:System.UIntPtr" /> в 32-битовое целое число без знака.</summary>
		/// <param name="value">Указатель или дескриптор, подлежащий преобразованию.</param>
		/// <returns>Содержимое <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">На 64-разрядной платформе значение указателя <paramref name="value" /> слишком велико, чтобы быть представленным 32-битовым целым числом без знака.</exception>
		// Token: 0x06001C01 RID: 7169 RVA: 0x00068A5F File Offset: 0x00066C5F
		public static explicit operator uint(UIntPtr value)
		{
			return value._pointer;
		}

		/// <summary>Преобразует значение 64-битового целого числа без знака в значение типа <see cref="T:System.UIntPtr" />.</summary>
		/// <param name="value">64-разрядное целое число без знака.</param>
		/// <returns>Новый экземпляр <see cref="T:System.UIntPtr" />, инициализированный значением <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">На 32-разрядной платформе значение параметра <paramref name="value" /> слишком велико для представления параметра <see cref="T:System.UIntPtr" />.</exception>
		// Token: 0x06001C02 RID: 7170 RVA: 0x00068A69 File Offset: 0x00066C69
		public static explicit operator UIntPtr(ulong value)
		{
			return new UIntPtr(value);
		}

		/// <summary>Преобразует заданный указатель на незаданный тип в <see cref="T:System.UIntPtr" />.  
		/// Этот интерфейс API CLS-несовместим.</summary>
		/// <param name="value">Указатель незаданного типа.</param>
		/// <returns>Новый экземпляр <see cref="T:System.UIntPtr" />, инициализированный значением <paramref name="value" />.</returns>
		// Token: 0x06001C03 RID: 7171 RVA: 0x00068A71 File Offset: 0x00066C71
		[CLSCompliant(false)]
		public unsafe static explicit operator UIntPtr(void* value)
		{
			return new UIntPtr(value);
		}

		/// <summary>Преобразует значение заданной структуры <see cref="T:System.UIntPtr" /> в указатель на незаданный тип.  
		/// Этот интерфейс API CLS-несовместим.</summary>
		/// <param name="value">Указатель или дескриптор, подлежащий преобразованию.</param>
		/// <returns>Содержимое <paramref name="value" />.</returns>
		// Token: 0x06001C04 RID: 7172 RVA: 0x00068A79 File Offset: 0x00066C79
		[CLSCompliant(false)]
		public unsafe static explicit operator void*(UIntPtr value)
		{
			return value.ToPointer();
		}

		/// <summary>Преобразует значение 32-битового целого числа без знака в значение типа <see cref="T:System.UIntPtr" />.</summary>
		/// <param name="value">32-разрядное целое число без знака.</param>
		/// <returns>Новый экземпляр <see cref="T:System.UIntPtr" />, инициализированный значением <paramref name="value" />.</returns>
		// Token: 0x06001C05 RID: 7173 RVA: 0x00068A82 File Offset: 0x00066C82
		public static explicit operator UIntPtr(uint value)
		{
			return new UIntPtr(value);
		}

		/// <summary>Получает размер этого экземпляра.</summary>
		/// <returns>Размер указателя или дескриптора на данной платформе в байтах. Значение этого свойства равно 4 на 32-разрядной платформе, и 8 на 64-разрядной платформе.</returns>
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x0005FD29 File Offset: 0x0005DF29
		public unsafe static int Size
		{
			get
			{
				return sizeof(void*);
			}
		}

		/// <summary>Добавляет смещение к значению указателя без знака.</summary>
		/// <param name="pointer">Указатель без знака, к которому требуется добавить смещение.</param>
		/// <param name="offset">Добавляемое смещение.</param>
		/// <returns>Новый указатель без знака, получающийся при добавлении смещения <paramref name="offset" /> к указателю <paramref name="pointer" />.</returns>
		// Token: 0x06001C07 RID: 7175 RVA: 0x00068A8A File Offset: 0x00066C8A
		public unsafe static UIntPtr Add(UIntPtr pointer, int offset)
		{
			return (UIntPtr)((void*)((byte*)((void*)pointer) + offset));
		}

		/// <summary>Вычитает смещение из значения указателя без знака.</summary>
		/// <param name="pointer">Указатель без знака, из которого требуется вычесть смещение.</param>
		/// <param name="offset">Вычитаемое смещение.</param>
		/// <returns>Новый указатель без знака, получающийся при вычитании смещения <paramref name="offset" /> из указателя <paramref name="pointer" />.</returns>
		// Token: 0x06001C08 RID: 7176 RVA: 0x00068A99 File Offset: 0x00066C99
		public unsafe static UIntPtr Subtract(UIntPtr pointer, int offset)
		{
			return (UIntPtr)((void*)((byte*)((void*)pointer) - offset));
		}

		/// <summary>Добавляет смещение к значению указателя без знака.</summary>
		/// <param name="pointer">Указатель без знака, к которому требуется добавить смещение.</param>
		/// <param name="offset">Добавляемое смещение.</param>
		/// <returns>Новый указатель без знака, получающийся при добавлении смещения <paramref name="offset" /> к указателю <paramref name="pointer" />.</returns>
		// Token: 0x06001C09 RID: 7177 RVA: 0x00068A8A File Offset: 0x00066C8A
		public unsafe static UIntPtr operator +(UIntPtr pointer, int offset)
		{
			return (UIntPtr)((void*)((byte*)((void*)pointer) + offset));
		}

		/// <summary>Вычитает смещение из значения указателя без знака.</summary>
		/// <param name="pointer">Указатель без знака, из которого требуется вычесть смещение.</param>
		/// <param name="offset">Вычитаемое смещение.</param>
		/// <returns>Новый указатель без знака, получающийся при вычитании смещения <paramref name="offset" /> из указателя <paramref name="pointer" />.</returns>
		// Token: 0x06001C0A RID: 7178 RVA: 0x00068A99 File Offset: 0x00066C99
		public unsafe static UIntPtr operator -(UIntPtr pointer, int offset)
		{
			return (UIntPtr)((void*)((byte*)((void*)pointer) - offset));
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00068AA8 File Offset: 0x00066CA8
		bool IEquatable<UIntPtr>.Equals(UIntPtr other)
		{
			return this._pointer == other._pointer;
		}

		/// <summary>Доступное только для чтения поле, которое предоставляет указатель или дескриптор, инициализированный с нулевым значением.</summary>
		// Token: 0x040019A3 RID: 6563
		public static readonly UIntPtr Zero = new UIntPtr(0U);

		// Token: 0x040019A4 RID: 6564
		private unsafe readonly void* _pointer;
	}
}
