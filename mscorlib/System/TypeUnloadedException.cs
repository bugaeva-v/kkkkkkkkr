using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, возникающее при попытке обращения к выгруженному классу.</summary>
	// Token: 0x020001A5 RID: 421
	[Serializable]
	public class TypeUnloadedException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TypeUnloadedException" />.</summary>
		// Token: 0x060011F0 RID: 4592 RVA: 0x00047D33 File Offset: 0x00045F33
		public TypeUnloadedException() : base("Type had been unloaded.")
		{
			base.HResult = -2146234349;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TypeUnloadedException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x060011F1 RID: 4593 RVA: 0x00047D4B File Offset: 0x00045F4B
		public TypeUnloadedException(string message) : base(message)
		{
			base.HResult = -2146234349;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TypeUnloadedException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060011F2 RID: 4594 RVA: 0x00047D5F File Offset: 0x00045F5F
		public TypeUnloadedException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146234349;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TypeUnloadedException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x060011F3 RID: 4595 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected TypeUnloadedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
