using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Исключение, которое создается, когда путь или полное имя файла длиннее, чем максимальная длина, определенная системой.</summary>
	// Token: 0x02000B0E RID: 2830
	[Serializable]
	public class PathTooLongException : IOException
	{
		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.PathTooLongException" /> с параметром HRESULT, для которого задано значение COR_E_PATHTOOLONG.</summary>
		// Token: 0x0600652D RID: 25901 RVA: 0x001584DF File Offset: 0x001566DF
		public PathTooLongException() : base("The specified file name or path is too long, or a component of the specified path is too long.")
		{
			base.HResult = -2147024690;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.PathTooLongException" /> со строкой сообщения, для которой задан параметр <paramref name="message" />, и параметром HRESULT, для которого задано значение COR_E_PATHTOOLONG.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x0600652E RID: 25902 RVA: 0x001584F7 File Offset: 0x001566F7
		public PathTooLongException(string message) : base(message)
		{
			base.HResult = -2147024690;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.PathTooLongException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600652F RID: 25903 RVA: 0x0015850B File Offset: 0x0015670B
		public PathTooLongException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024690;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.PathTooLongException" /> с указанными сведениями о сериализации и контексте.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06006530 RID: 25904 RVA: 0x00156728 File Offset: 0x00154928
		protected PathTooLongException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
