using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выдается при недопустимой попытке доступа к методу, например при попытке доступа к закрытому методу из частично доверенного кода.</summary>
	// Token: 0x0200015A RID: 346
	[Serializable]
	public class MethodAccessException : MemberAccessException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MethodAccessException" />, присваивая его свойству <see cref="P:System.Exception.Message" /> нового системное сообщение с описанием ошибки, например: "Ошибка доступа к методу". Это сообщение учитывает текущую культуру системы.</summary>
		// Token: 0x06000DC4 RID: 3524 RVA: 0x00035D39 File Offset: 0x00033F39
		public MethodAccessException() : base("Attempt to access the method failed.")
		{
			base.HResult = -2146233072;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MethodAccessException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку.</param>
		// Token: 0x06000DC5 RID: 3525 RVA: 0x00035D51 File Offset: 0x00033F51
		public MethodAccessException(string message) : base(message)
		{
			base.HResult = -2146233072;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MethodAccessException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="inner" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000DC6 RID: 3526 RVA: 0x00035D65 File Offset: 0x00033F65
		public MethodAccessException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233072;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MethodAccessException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000DC7 RID: 3527 RVA: 0x0002889B File Offset: 0x00026A9B
		protected MethodAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
