using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>Исключение, которое возникает в методе <see cref="M:System.Type.FindMembers(System.Reflection.MemberTypes,System.Reflection.BindingFlags,System.Reflection.MemberFilter,System.Object)" />, если для данного типа фильтра используются недопустимые критерии.</summary>
	// Token: 0x020008A7 RID: 2215
	[Serializable]
	public class InvalidFilterCriteriaException : ApplicationException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.InvalidFilterCriteriaException" /> со стандартными свойствами.</summary>
		// Token: 0x06004904 RID: 18692 RVA: 0x000EE904 File Offset: 0x000ECB04
		public InvalidFilterCriteriaException() : this("Specified filter criteria was invalid.")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.InvalidFilterCriteriaException" /> с помощью заданного параметра HRESULT и строки сообщения.</summary>
		/// <param name="message">Текст сообщения исключения.</param>
		// Token: 0x06004905 RID: 18693 RVA: 0x000EE911 File Offset: 0x000ECB11
		public InvalidFilterCriteriaException(string message) : this(message, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.InvalidFilterCriteriaException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06004906 RID: 18694 RVA: 0x000EE91B File Offset: 0x000ECB1B
		public InvalidFilterCriteriaException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232831;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Reflection.InvalidFilterCriteriaException" /> с указанными сведениями о сериализации и контексте.</summary>
		/// <param name="info">Объект <see langword="SerializationInfo" />, который содержит сведения, требуемые для сериализации этого экземпляра.</param>
		/// <param name="context">Объект <see langword="StreamingContext" />, который содержит исходный и конечный объекты сериализованного потока, сопоставленного данному экземпляру.</param>
		// Token: 0x06004907 RID: 18695 RVA: 0x0006E7BD File Offset: 0x0006C9BD
		protected InvalidFilterCriteriaException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
