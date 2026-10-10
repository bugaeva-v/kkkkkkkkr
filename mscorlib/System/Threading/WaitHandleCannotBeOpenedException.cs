using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>Исключение, которое возникает при попытке открыть несуществующий системный семафор или дескриптор ожидания события.</summary>
	// Token: 0x0200029C RID: 668
	[Serializable]
	public class WaitHandleCannotBeOpenedException : ApplicationException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.WaitHandleCannotBeOpenedException" /> со значениями по умолчанию.</summary>
		// Token: 0x06001DA7 RID: 7591 RVA: 0x0006E77C File Offset: 0x0006C97C
		public WaitHandleCannotBeOpenedException() : base("No handle of the given name exists.")
		{
			base.HResult = -2146233044;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.WaitHandleCannotBeOpenedException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06001DA8 RID: 7592 RVA: 0x0006E794 File Offset: 0x0006C994
		public WaitHandleCannotBeOpenedException(string message) : base(message)
		{
			base.HResult = -2146233044;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.WaitHandleCannotBeOpenedException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06001DA9 RID: 7593 RVA: 0x0006E7A8 File Offset: 0x0006C9A8
		public WaitHandleCannotBeOpenedException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233044;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.WaitHandleCannotBeOpenedException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта по возникающему исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06001DAA RID: 7594 RVA: 0x0006E7BD File Offset: 0x0006C9BD
		protected WaitHandleCannotBeOpenedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
