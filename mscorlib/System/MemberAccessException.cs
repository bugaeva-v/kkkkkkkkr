using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение возникает при неудачной попытке доступа к члену класса.</summary>
	// Token: 0x02000156 RID: 342
	[Serializable]
	public class MemberAccessException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MemberAccessException" />.</summary>
		// Token: 0x06000D49 RID: 3401 RVA: 0x00033813 File Offset: 0x00031A13
		public MemberAccessException() : base("Cannot access member.")
		{
			base.HResult = -2146233062;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MemberAccessException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06000D4A RID: 3402 RVA: 0x0003382B File Offset: 0x00031A2B
		public MemberAccessException(string message) : base(message)
		{
			base.HResult = -2146233062;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MemberAccessException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="inner" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000D4B RID: 3403 RVA: 0x0003383F File Offset: 0x00031A3F
		public MemberAccessException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233062;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MemberAccessException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000D4C RID: 3404 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected MemberAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
