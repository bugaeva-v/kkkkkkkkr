using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение возникает при обнаружении недопустимого универсального кода ресурса (URI).</summary>
	// Token: 0x02000154 RID: 340
	[Serializable]
	public class UriFormatException : FormatException, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.UriFormatException" />.</summary>
		// Token: 0x06000979 RID: 2425 RVA: 0x00029735 File Offset: 0x00027935
		public UriFormatException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.UriFormatException" /> указанным сообщением.</summary>
		/// <param name="textString">Строка сообщения об ошибке.</param>
		// Token: 0x0600097A RID: 2426 RVA: 0x0002973D File Offset: 0x0002793D
		public UriFormatException(string textString) : base(textString)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.UriFormatException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="textString">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="e">Исключение, которое является причиной текущего исключения. Если значение параметра <c>innerException</c> не равно <see langword="null" />, текущее исключение возникает в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600097B RID: 2427 RVA: 0x00029746 File Offset: 0x00027946
		public UriFormatException(string textString, Exception e) : base(textString, e)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.UriFormatException" /> из указанных экземпляров <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, в котором содержатся сведения, требуемые для сериализации нового объекта <see cref="T:System.UriFormatException" />.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, который содержит источник сериализованного потока, связанного с новым объектом <see cref="T:System.UriFormatException" />.</param>
		// Token: 0x0600097C RID: 2428 RVA: 0x00029750 File Offset: 0x00027950
		protected UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Заполняет экземпляр <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации объекта <see cref="T:System.UriFormatException" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который будет содержать сериализованные данные для <see cref="T:System.UriFormatException" />.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий назначение сериализованного потока, связанного с классом <see cref="T:System.UriFormatException" />.</param>
		// Token: 0x0600097D RID: 2429 RVA: 0x0002975A File Offset: 0x0002795A
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}
	}
}
