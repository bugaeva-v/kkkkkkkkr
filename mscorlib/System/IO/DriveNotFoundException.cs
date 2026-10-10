using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Исключение вызывается при попытке доступа к недоступному диску или данным совместного использования.</summary>
	// Token: 0x02000B2C RID: 2860
	[Serializable]
	public class DriveNotFoundException : IOException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.DriveNotFoundException" /> со строкой сообщения, соответствующей строке системного сообщения и значением HRESULT, равным COR_E_DIRECTORYNOTFOUND.</summary>
		// Token: 0x060066DB RID: 26331 RVA: 0x0015F454 File Offset: 0x0015D654
		public DriveNotFoundException() : base("Could not find the drive. The drive might not be ready or might not be mapped.")
		{
			base.HResult = -2147024893;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.DriveNotFoundException" /> с заданной строкой сообщения и значением COR_E_DIRECTORYNOTFOUND, заданным для HRESULT.</summary>
		/// <param name="message">Объект <see cref="T:System.String" />, описывающий ошибку. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x060066DC RID: 26332 RVA: 0x001566FF File Offset: 0x001548FF
		public DriveNotFoundException(string message) : base(message)
		{
			base.HResult = -2147024893;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.DriveNotFoundException" /> с указанным сообщением об ошибке и ссылкой на внутреннее исключение, которое стало причиной данного исключения.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060066DD RID: 26333 RVA: 0x00156713 File Offset: 0x00154913
		public DriveNotFoundException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024893;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.DriveNotFoundException" /> с указанными сведениями о сериализации и контексте.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сериализованные данные объекта, относящиеся к генерируемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении вызываемого исключения.</param>
		// Token: 0x060066DE RID: 26334 RVA: 0x00156728 File Offset: 0x00154928
		protected DriveNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
