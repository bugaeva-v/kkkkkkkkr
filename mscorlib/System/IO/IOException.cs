using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Исключение, которое выдается при возникновении ошибки ввода-вывода.</summary>
	// Token: 0x02000B0B RID: 2827
	[Serializable]
	public class IOException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.IOException" /> пустой строкой сообщения (""), значением COR_E_IO для HRESULT и пустой ссылкой для внутреннего исключения.</summary>
		// Token: 0x060064DE RID: 25822 RVA: 0x00156BDE File Offset: 0x00154DDE
		public IOException() : base("I/O error occurred.")
		{
			base.HResult = -2146232800;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.IOException" /> с заданным для строки сообщения значением <paramref name="message" />, HRESULT имеет значение COR_E_IO, а внутреннее исключение — <see langword="null" />.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x060064DF RID: 25823 RVA: 0x00156BF6 File Offset: 0x00154DF6
		public IOException(string message) : base(message)
		{
			base.HResult = -2146232800;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.IOException" />, причем для его строки сообщения задается значение <paramref name="message" />, а свойство HRESULT задается пользователем.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="hresult">Целое число, определяющее возникшую ошибку.</param>
		// Token: 0x060064E0 RID: 25824 RVA: 0x00032810 File Offset: 0x00030A10
		public IOException(string message, int hresult) : base(message)
		{
			base.HResult = hresult;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.IOException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060064E1 RID: 25825 RVA: 0x00156C0A File Offset: 0x00154E0A
		public IOException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232800;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.IOException" /> с указанными сведениями о сериализации и контексте.</summary>
		/// <param name="info">Данные для выполнения сериализации или десериализации объекта.</param>
		/// <param name="context">Источник и назначение для объекта.</param>
		// Token: 0x060064E2 RID: 25826 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected IOException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
