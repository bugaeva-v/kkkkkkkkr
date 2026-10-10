using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Предоставляет исключение, возникающее при попытке возврата версии объекта <see cref="T:System.Data.DataRow" />, который был удален.</summary>
	// Token: 0x02000092 RID: 146
	[Serializable]
	public class VersionNotFoundException : DataException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.VersionNotFoundException" /> со сведениями о сериализации.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Описание источника и назначения заданного сериализованного потока.</param>
		// Token: 0x060006FC RID: 1788 RVA: 0x0001A5BF File Offset: 0x000187BF
		protected VersionNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.VersionNotFoundException" />.</summary>
		// Token: 0x060006FD RID: 1789 RVA: 0x0001A812 File Offset: 0x00018A12
		public VersionNotFoundException() : base("Version not found.")
		{
			base.HResult = -2146232023;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.VersionNotFoundException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x060006FE RID: 1790 RVA: 0x0001A82A File Offset: 0x00018A2A
		public VersionNotFoundException(string s) : base(s)
		{
			base.HResult = -2146232023;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.VersionNotFoundException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x060006FF RID: 1791 RVA: 0x0001A83E File Offset: 0x00018A3E
		public VersionNotFoundException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232023;
		}
	}
}
