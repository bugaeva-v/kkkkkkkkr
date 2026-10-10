using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Исключение, которое создается, когда не удается найти часть файла или каталога.</summary>
	// Token: 0x02000B02 RID: 2818
	[Serializable]
	public class DirectoryNotFoundException : IOException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.DirectoryNotFoundException" /> со строкой сообщения, соответствующей строке системного сообщения и значением HRESULT, равным COR_E_DIRECTORYNOTFOUND.</summary>
		// Token: 0x060064B8 RID: 25784 RVA: 0x001566E7 File Offset: 0x001548E7
		public DirectoryNotFoundException() : base("Attempted to access a path that is not on the disk.")
		{
			base.HResult = -2147024893;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.DirectoryNotFoundException" /> со строкой сообщения, установленной в <paramref name="message" /> и значением HRESULT, равным COR_E_DIRECTORYNOTFOUND.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x060064B9 RID: 25785 RVA: 0x001566FF File Offset: 0x001548FF
		public DirectoryNotFoundException(string message) : base(message)
		{
			base.HResult = -2147024893;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.DirectoryNotFoundException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060064BA RID: 25786 RVA: 0x00156713 File Offset: 0x00154913
		public DirectoryNotFoundException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024893;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.DirectoryNotFoundException" /> с указанными сведениями о сериализации и контексте.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x060064BB RID: 25787 RVA: 0x00156728 File Offset: 0x00154928
		protected DirectoryNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
