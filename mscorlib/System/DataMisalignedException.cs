using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выбрасывается, когда единица данных считывается или записывается по адресу, не кратному размеру данных. Этот класс не наследуется.</summary>
	// Token: 0x0200010B RID: 267
	[Serializable]
	public sealed class DataMisalignedException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DataMisalignedException" />.</summary>
		// Token: 0x060009A3 RID: 2467 RVA: 0x000258FA File Offset: 0x00023AFA
		public DataMisalignedException() : base("A datatype misalignment was detected in a load or store instruction.")
		{
			base.HResult = -2146233023;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DataMisalignedException" />, используя указанное сообщение об ошибке.</summary>
		/// <param name="message">Объект <see cref="T:System.String" />, описывающий ошибку. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x060009A4 RID: 2468 RVA: 0x00025912 File Offset: 0x00023B12
		public DataMisalignedException(string message) : base(message)
		{
			base.HResult = -2146233023;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DataMisalignedException" />, используя указанные сообщение об ошибке и исходное исключение.</summary>
		/// <param name="message">Объект <see cref="T:System.String" />, описывающий ошибку. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="innerException">Исключение, являющееся причиной текущего исключения <see cref="T:System.DataMisalignedException" />,. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060009A5 RID: 2469 RVA: 0x00025926 File Offset: 0x00023B26
		public DataMisalignedException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233023;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00020A65 File Offset: 0x0001EC65
		internal DataMisalignedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
