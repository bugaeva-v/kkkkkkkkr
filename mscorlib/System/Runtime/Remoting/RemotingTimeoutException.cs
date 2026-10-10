using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting
{
	/// <summary>Исключение возникает, когда доступ к серверу или клиенту оказывается невозможен в течение периода времени, указанного ранее.</summary>
	// Token: 0x0200056D RID: 1389
	[ComVisible(true)]
	[Serializable]
	public class RemotingTimeoutException : RemotingException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.RemotingTimeoutException" /> стандартными свойствами.</summary>
		// Token: 0x060036A8 RID: 13992 RVA: 0x000C595D File Offset: 0x000C3B5D
		public RemotingTimeoutException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.RemotingTimeoutException" /> с указанным сообщением.</summary>
		/// <param name="message">Сообщение, в котором указывается причина исключения.</param>
		// Token: 0x060036A9 RID: 13993 RVA: 0x000C5965 File Offset: 0x000C3B65
		public RemotingTimeoutException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.RemotingTimeoutException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="InnerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="InnerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060036AA RID: 13994 RVA: 0x000C596E File Offset: 0x000C3B6E
		public RemotingTimeoutException(string message, Exception InnerException) : base(message, InnerException)
		{
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x000C5978 File Offset: 0x000C3B78
		internal RemotingTimeoutException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
