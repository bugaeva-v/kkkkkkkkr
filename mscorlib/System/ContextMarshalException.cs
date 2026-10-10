using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, возникающее при неудачной попытке маршалинга объекта через границы контекста.</summary>
	// Token: 0x020001EE RID: 494
	[ComVisible(true)]
	[Serializable]
	public class ContextMarshalException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ContextMarshalException" /> стандартными свойствами.</summary>
		// Token: 0x0600154E RID: 5454 RVA: 0x00053951 File Offset: 0x00051B51
		public ContextMarshalException() : base(Environment.GetResourceString("Attempted to marshal an object across a context boundary."))
		{
			base.SetErrorCode(-2146233084);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ContextMarshalException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x0600154F RID: 5455 RVA: 0x0005396E File Offset: 0x00051B6E
		public ContextMarshalException(string message) : base(message)
		{
			base.SetErrorCode(-2146233084);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ContextMarshalException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06001550 RID: 5456 RVA: 0x00053982 File Offset: 0x00051B82
		public ContextMarshalException(string message, Exception inner) : base(message, inner)
		{
			base.SetErrorCode(-2146233084);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ContextMarshalException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06001551 RID: 5457 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected ContextMarshalException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
