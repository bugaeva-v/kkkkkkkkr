using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Определяемый платформой тип, который используется для представления указателя или дескриптора.</summary>
	// Token: 0x02000239 RID: 569
	[ComVisible(true)]
	[Serializable]
	public readonly struct IntPtr : ISerializable, IEquatable<IntPtr>
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.IntPtr" /> с помощью заданного 32-битового указателя или дескриптора.</summary>
		/// <param name="value">Указатель или дескриптор состоит из 32-разрядного целого числа со знаком.</param>
		// Token: 0x060019F8 RID: 6648 RVA: 0x0005FCE8 File Offset: 0x0005DEE8
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public IntPtr(int value)
		{
			this.m_value = value;
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.IntPtr" /> с использованием заданного 64-разрядного указателя.</summary>
		/// <param name="value">Указатель или дескриптор состоит из 64-разрядного целого числа со знаком.</param>
		/// <exception cref="T:System.OverflowException">На 32-разрядной платформе значение <paramref name="value" /> слишком велико, или слишком мало для представления структуры <see cref="T:System.IntPtr" />.</exception>
		// Token: 0x060019F9 RID: 6649 RVA: 0x0005FCF2 File Offset: 0x0005DEF2
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public IntPtr(long value)
		{
			this.m_value = value;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.IntPtr" /> с использованием заданного указателя на незаданный тип.</summary>
		/// <param name="value">Указатель незаданного типа.</param>
		// Token: 0x060019FA RID: 6650 RVA: 0x0005FCFC File Offset: 0x0005DEFC
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		[CLSCompliant(false)]
		public unsafe IntPtr(void* value)
		{
			this.m_value = value;
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0005FD08 File Offset: 0x0005DF08
		private IntPtr(SerializationInfo info, StreamingContext context)
		{
			long @int = info.GetInt64("value");
			this.m_value = @int;
		}

		/// <summary>Получает размер этого экземпляра.</summary>
		/// <returns>Размер указателя или дескриптора в данном процессе в байтах. Значение этого свойства равно 4 в 32-разрядном процессе и 8 в 64-разрядном процессе. Можно указать тип процесса, задав параметр <see langword="/platform" /> при компилировании кода с помощью компиляторов C# и Visual Basic.</returns>
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x0005FD29 File Offset: 0x0005DF29
		public unsafe static int Size
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return sizeof(void*);
			}
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации текущего объекта <see cref="T:System.IntPtr" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который требуется заполнить данными.</param>
		/// <param name="context">Целевой объект этой сериализации. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> — <see langword="null" />.</exception>
		// Token: 0x060019FD RID: 6653 RVA: 0x0005FD31 File Offset: 0x0005DF31
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("value", this.ToInt64());
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром или <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является экземпляром типа <see cref="T:System.IntPtr" /> и равен значению данного экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060019FE RID: 6654 RVA: 0x0005FD52 File Offset: 0x0005DF52
		public override bool Equals(object obj)
		{
			return obj is IntPtr && ((IntPtr)obj).m_value == this.m_value;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060019FF RID: 6655 RVA: 0x0005FD71 File Offset: 0x0005DF71
		public override int GetHashCode()
		{
			return this.m_value;
		}

		/// <summary>Преобразует значение этого экземпляра в формат 32-разрядного целого числа со знаком.</summary>
		/// <returns>32-разрядное целое число со знаком, равное значению данного экземпляра.</returns>
		/// <exception cref="T:System.OverflowException">На 64-разрядной платформе значение этого экземпляра слишком велико, или слишком мало для представления его в качестве 32-разрядного целого числа со знаком.</exception>
		// Token: 0x06001A00 RID: 6656 RVA: 0x0005FD71 File Offset: 0x0005DF71
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public int ToInt32()
		{
			return this.m_value;
		}

		/// <summary>Преобразует значение этого экземпляра в формат 64-разрядного целого числа со знаком.</summary>
		/// <returns>64-и разрядное целое число со знаком равно значению данного экземпляра.</returns>
		// Token: 0x06001A01 RID: 6657 RVA: 0x0005FD7A File Offset: 0x0005DF7A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public long ToInt64()
		{
			if (IntPtr.Size == 4)
			{
				return (long)this.m_value;
			}
			return this.m_value;
		}

		/// <summary>Преобразует значение этого экземпляра в указатель незаданного типа.</summary>
		/// <returns>Указатель на <see cref="T:System.Void" /> (указатель на ячейку памяти, содержащую данные незаданного типа).</returns>
		// Token: 0x06001A02 RID: 6658 RVA: 0x0005FD94 File Offset: 0x0005DF94
		[CLSCompliant(false)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public unsafe void* ToPointer()
		{
			return this.m_value;
		}

		/// <summary>Преобразует числовое значение текущего объекта <see cref="T:System.IntPtr" /> в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения этого экземпляра.</returns>
		// Token: 0x06001A03 RID: 6659 RVA: 0x0005FD9C File Offset: 0x0005DF9C
		public override string ToString()
		{
			return this.ToString(null);
		}

		/// <summary>Преобразует числовое значение текущего объекта <see cref="T:System.IntPtr" /> в эквивалентное ему строковое представление.</summary>
		/// <param name="format">Спецификация формата, в которой определен порядок преобразования текущего объекта <see cref="T:System.IntPtr" />.</param>
		/// <returns>Строковое представление значения текущего объекта <see cref="T:System.IntPtr" />.</returns>
		// Token: 0x06001A04 RID: 6660 RVA: 0x0005FDA8 File Offset: 0x0005DFA8
		public string ToString(string format)
		{
			if (IntPtr.Size == 4)
			{
				return this.m_value.ToString(format, null);
			}
			return this.m_value.ToString(format, null);
		}

		/// <summary>Определяет, равны ли два заданных экземпляра класса <see cref="T:System.IntPtr" />.</summary>
		/// <param name="value1">Первый из сравниваемых указателей или дескрипторов.</param>
		/// <param name="value2">Второй из сравниваемых указателей или дескрипторов.</param>
		/// <returns>Если значение <paramref name="value1" /> равно <paramref name="value2" />, значение <see langword="true" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001A05 RID: 6661 RVA: 0x0005FDE0 File Offset: 0x0005DFE0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static bool operator ==(IntPtr value1, IntPtr value2)
		{
			return value1.m_value == value2.m_value;
		}

		/// <summary>Определяет, являются ли два заданных экземпляра класса <see cref="T:System.IntPtr" /> неравными.</summary>
		/// <param name="value1">Первый из сравниваемых указателей или дескрипторов.</param>
		/// <param name="value2">Второй из сравниваемых указателей или дескрипторов.</param>
		/// <returns>Значение <see langword="true" />, если значения параметров <paramref name="value1" /> и <paramref name="value2" /> не равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001A06 RID: 6662 RVA: 0x0005FDF2 File Offset: 0x0005DFF2
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static bool operator !=(IntPtr value1, IntPtr value2)
		{
			return value1.m_value != value2.m_value;
		}

		/// <summary>Преобразует 32-разрядное целочисленное значение со знаком в <see cref="T:System.IntPtr" />.</summary>
		/// <param name="value">32-разрядное знаковое целое число.</param>
		/// <returns>Новый экземпляр <see cref="T:System.IntPtr" />, инициализированный значением <paramref name="value" />.</returns>
		// Token: 0x06001A07 RID: 6663 RVA: 0x0005FE07 File Offset: 0x0005E007
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static explicit operator IntPtr(int value)
		{
			return new IntPtr(value);
		}

		/// <summary>Преобразует 64-разрядное целочисленное значение со знаком в <see cref="T:System.IntPtr" />.</summary>
		/// <param name="value">64-разрядное целое число со знаком.</param>
		/// <returns>Новый экземпляр <see cref="T:System.IntPtr" />, инициализированный значением <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">На 32-разрядной платформе значение параметра <paramref name="value" /> слишком велико для представления параметра <see cref="T:System.IntPtr" />.</exception>
		// Token: 0x06001A08 RID: 6664 RVA: 0x0005FE0F File Offset: 0x0005E00F
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static explicit operator IntPtr(long value)
		{
			return new IntPtr(value);
		}

		/// <summary>Преобразует заданный указатель на незаданный тип в <see cref="T:System.IntPtr" />.  
		/// Этот интерфейс API CLS-несовместим.</summary>
		/// <param name="value">Указатель незаданного типа.</param>
		/// <returns>Новый экземпляр <see cref="T:System.IntPtr" />, инициализированный значением <paramref name="value" />.</returns>
		// Token: 0x06001A09 RID: 6665 RVA: 0x0005FE17 File Offset: 0x0005E017
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		[CLSCompliant(false)]
		public unsafe static explicit operator IntPtr(void* value)
		{
			return new IntPtr(value);
		}

		/// <summary>Преобразует значение заданной структуры <see cref="T:System.IntPtr" /> в формат 32-разрядного целого числа со знаком.</summary>
		/// <param name="value">Указатель или дескриптор, подлежащий преобразованию.</param>
		/// <returns>Содержимое <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">На 64-разрядной платформе значение <paramref name="value" /> слишком велико для представления в качестве 32-разрядного целого числа со знаком.</exception>
		// Token: 0x06001A0A RID: 6666 RVA: 0x0005FE1F File Offset: 0x0005E01F
		public static explicit operator int(IntPtr value)
		{
			return value.m_value;
		}

		/// <summary>Преобразует значение заданной структуры <see cref="T:System.IntPtr" /> в формат 64-разрядного целого числа со знаком.</summary>
		/// <param name="value">Указатель или дескриптор, подлежащий преобразованию.</param>
		/// <returns>Содержимое <paramref name="value" />.</returns>
		// Token: 0x06001A0B RID: 6667 RVA: 0x0005FE29 File Offset: 0x0005E029
		public static explicit operator long(IntPtr value)
		{
			return value.ToInt64();
		}

		/// <summary>Преобразует значение заданной структуры <see cref="T:System.IntPtr" /> в указатель на незаданный тип.  
		/// Этот интерфейс API CLS-несовместим.</summary>
		/// <param name="value">Указатель или дескриптор, подлежащий преобразованию.</param>
		/// <returns>Содержимое <paramref name="value" />.</returns>
		// Token: 0x06001A0C RID: 6668 RVA: 0x0005FE32 File Offset: 0x0005E032
		[CLSCompliant(false)]
		public unsafe static explicit operator void*(IntPtr value)
		{
			return value.m_value;
		}

		/// <summary>Добавляет смещение к значению указателя.</summary>
		/// <param name="pointer">Указатель, к которому требуется добавить смещение.</param>
		/// <param name="offset">Добавляемое смещение.</param>
		/// <returns>Новый указатель, получающийся при добавлении смещения <paramref name="offset" /> к указателю <paramref name="pointer" />.</returns>
		// Token: 0x06001A0D RID: 6669 RVA: 0x0005FE3B File Offset: 0x0005E03B
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public unsafe static IntPtr Add(IntPtr pointer, int offset)
		{
			return (IntPtr)((void*)((byte*)((void*)pointer) + offset));
		}

		/// <summary>Вычитает смещение из значения указателя.</summary>
		/// <param name="pointer">Указатель, из которого требуется вычесть смещение.</param>
		/// <param name="offset">Вычитаемое смещение.</param>
		/// <returns>Новый указатель, получающийся при вычитании смещения <paramref name="offset" /> из указателя <paramref name="pointer" />.</returns>
		// Token: 0x06001A0E RID: 6670 RVA: 0x0005FE4A File Offset: 0x0005E04A
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public unsafe static IntPtr Subtract(IntPtr pointer, int offset)
		{
			return (IntPtr)((void*)((byte*)((void*)pointer) - offset));
		}

		/// <summary>Добавляет смещение к значению указателя.</summary>
		/// <param name="pointer">Указатель, к которому требуется добавить смещение.</param>
		/// <param name="offset">Добавляемое смещение.</param>
		/// <returns>Новый указатель, получающийся при добавлении смещения <paramref name="offset" /> к указателю <paramref name="pointer" />.</returns>
		// Token: 0x06001A0F RID: 6671 RVA: 0x0005FE3B File Offset: 0x0005E03B
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public unsafe static IntPtr operator +(IntPtr pointer, int offset)
		{
			return (IntPtr)((void*)((byte*)((void*)pointer) + offset));
		}

		/// <summary>Вычитает смещение из значения указателя.</summary>
		/// <param name="pointer">Указатель, из которого требуется вычесть смещение.</param>
		/// <param name="offset">Вычитаемое смещение.</param>
		/// <returns>Новый указатель, получающийся при вычитании смещения <paramref name="offset" /> из указателя <paramref name="pointer" />.</returns>
		// Token: 0x06001A10 RID: 6672 RVA: 0x0005FE4A File Offset: 0x0005E04A
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public unsafe static IntPtr operator -(IntPtr pointer, int offset)
		{
			return (IntPtr)((void*)((byte*)((void*)pointer) - offset));
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0005FE59 File Offset: 0x0005E059
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal bool IsNull()
		{
			return this.m_value == null;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0005FE65 File Offset: 0x0005E065
		bool IEquatable<IntPtr>.Equals(IntPtr other)
		{
			return this.m_value == other.m_value;
		}

		// Token: 0x0400171C RID: 5916
		private unsafe readonly void* m_value;

		/// <summary>Доступное только для чтения поле, которое предоставляет указатель или дескриптор, инициализированный с нулевым значением.</summary>
		// Token: 0x0400171D RID: 5917
		public static readonly IntPtr Zero;
	}
}
