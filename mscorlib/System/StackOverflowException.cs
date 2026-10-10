using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выбрасывается при переполнении стека выполнения из-за чрезмерного количества вложенных вызовов метода. Этот класс не наследуется.</summary>
	// Token: 0x02000186 RID: 390
	[Serializable]
	public sealed class StackOverflowException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.StackOverflowException" />, устанавливая в качестве значения свойства нового экземпляра <see cref="P:System.Exception.Message" /> системное сообщение с описанием ошибки, например: "Запрашиваемая операция вызывает переполнение стека". Это сообщение учитывает текущую культуру системы.</summary>
		// Token: 0x06000F9A RID: 3994 RVA: 0x000414BA File Offset: 0x0003F6BA
		public StackOverflowException() : base("Operation caused a stack overflow.")
		{
			base.HResult = -2147023895;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.StackOverflowException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку. Содержимое параметра message должно быть понятным пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x06000F9B RID: 3995 RVA: 0x000414D2 File Offset: 0x0003F6D2
		public StackOverflowException(string message) : base(message)
		{
			base.HResult = -2147023895;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.StackOverflowException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000F9C RID: 3996 RVA: 0x000414E6 File Offset: 0x0003F6E6
		public StackOverflowException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147023895;
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00020A65 File Offset: 0x0001EC65
		internal StackOverflowException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
