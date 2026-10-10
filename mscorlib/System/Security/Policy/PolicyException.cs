using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security.Policy
{
	/// <summary>Исключение, создаваемое, если политика запрещает запуск кода.</summary>
	// Token: 0x0200041B RID: 1051
	[ComVisible(true)]
	[Serializable]
	public class PolicyException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.PolicyException" /> стандартными свойствами.</summary>
		// Token: 0x06002AE4 RID: 10980 RVA: 0x0009AEE4 File Offset: 0x000990E4
		public PolicyException() : base(Locale.GetText("Cannot run because of policy."))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.PolicyException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06002AE5 RID: 10981 RVA: 0x0006E6A5 File Offset: 0x0006C8A5
		public PolicyException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.PolicyException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06002AE6 RID: 10982 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected PolicyException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.PolicyException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="exception">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="exception" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06002AE7 RID: 10983 RVA: 0x0006E6AE File Offset: 0x0006C8AE
		public PolicyException(string message, Exception exception) : base(message, exception)
		{
		}
	}
}
