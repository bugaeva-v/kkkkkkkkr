using System;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	/// <summary>Исключение, которое выдается, когда ключ, указанный для доступа к элементу в коллекции, не совпадает ни с одним ключом в коллекции.</summary>
	// Token: 0x02000AA0 RID: 2720
	[Serializable]
	public class KeyNotFoundException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Generic.KeyNotFoundException" />, используя значения свойства по умолчанию.</summary>
		// Token: 0x06006137 RID: 24887 RVA: 0x001451E4 File Offset: 0x001433E4
		public KeyNotFoundException() : base("The given key was not present in the dictionary.")
		{
			base.HResult = -2146232969;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Generic.KeyNotFoundException" /> указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06006138 RID: 24888 RVA: 0x001451FC File Offset: 0x001433FC
		public KeyNotFoundException(string message) : base(message)
		{
			base.HResult = -2146232969;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Generic.KeyNotFoundException" /> с указанным сообщением об ошибке и ссылкой на внутреннее исключение, которое стало причиной данного исключения.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06006139 RID: 24889 RVA: 0x00145210 File Offset: 0x00143410
		public KeyNotFoundException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232969;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Generic.KeyNotFoundException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x0600613A RID: 24890 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected KeyNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
