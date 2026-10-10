using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting
{
	/// <summary>Исключение вызывается, чтобы сообщать клиенту об ошибках, когда клиент подключается к приложениям, работающим не под платформой .NET Framework, которые не способны вызывать исключения.</summary>
	// Token: 0x0200056E RID: 1390
	[ComVisible(true)]
	[Serializable]
	public class ServerException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.ServerException" /> стандартными свойствами.</summary>
		// Token: 0x060036AC RID: 13996 RVA: 0x00092A49 File Offset: 0x00090C49
		public ServerException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.ServerException" /> с заданным сообщением.</summary>
		/// <param name="message">Сообщение с описанием исключения</param>
		// Token: 0x060036AD RID: 13997 RVA: 0x0006E6A5 File Offset: 0x0006C8A5
		public ServerException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.ServerException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="InnerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="InnerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060036AE RID: 13998 RVA: 0x0006E6AE File Offset: 0x0006C8AE
		public ServerException(string message, Exception InnerException) : base(message, InnerException)
		{
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x00020A65 File Offset: 0x0001EC65
		internal ServerException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
