using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting
{
	/// <summary>Исключение, создаваемое при какой-либо неполадке во время удаленного доступа.</summary>
	// Token: 0x0200056A RID: 1386
	[ComVisible(true)]
	[Serializable]
	public class RemotingException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.RemotingException" /> стандартными свойствами.</summary>
		// Token: 0x06003666 RID: 13926 RVA: 0x00092A49 File Offset: 0x00090C49
		public RemotingException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.RemotingException" /> с заданным сообщением.</summary>
		/// <param name="message">Сообщение об ошибке с объяснением причин исключения.</param>
		// Token: 0x06003667 RID: 13927 RVA: 0x0006E6A5 File Offset: 0x0006C8A5
		public RemotingException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.RemotingException" /> из сериализованных данных.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении исключения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003668 RID: 13928 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected RemotingException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.RemotingException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке с объяснением причин исключения.</param>
		/// <param name="InnerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="InnerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06003669 RID: 13929 RVA: 0x0006E6AE File Offset: 0x0006C8AE
		public RemotingException(string message, Exception InnerException) : base(message, InnerException)
		{
		}
	}
}
