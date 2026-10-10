using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>Это исключение выдается при неправильном двоичном формате настраиваемого атрибута.</summary>
	// Token: 0x02000896 RID: 2198
	[Serializable]
	public class CustomAttributeFormatException : FormatException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.CustomAttributeFormatException" /> со стандартными свойствами.</summary>
		// Token: 0x06004894 RID: 18580 RVA: 0x000EE219 File Offset: 0x000EC419
		public CustomAttributeFormatException() : this("Binary format of the specified custom attribute was invalid.")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.CustomAttributeFormatException" /> указанным сообщением.</summary>
		/// <param name="message">Сообщение, показывающее причину создания этого исключения.</param>
		// Token: 0x06004895 RID: 18581 RVA: 0x000EE226 File Offset: 0x000EC426
		public CustomAttributeFormatException(string message) : this(message, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.CustomAttributeFormatException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06004896 RID: 18582 RVA: 0x000EE230 File Offset: 0x000EC430
		public CustomAttributeFormatException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232827;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Reflection.CustomAttributeFormatException" /> с указанными сведениями о сериализации и контексте.</summary>
		/// <param name="info">Данные для сериализации или десериализации пользовательского атрибута.</param>
		/// <param name="context">Источник и назначение пользовательского атрибута.</param>
		// Token: 0x06004897 RID: 18583 RVA: 0x000EE245 File Offset: 0x000EC445
		protected CustomAttributeFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
