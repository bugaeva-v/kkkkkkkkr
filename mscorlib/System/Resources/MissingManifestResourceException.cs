using System;
using System.Runtime.Serialization;

namespace System.Resources
{
	/// <summary>Исключение, которое создается, если основная сборка не содержит ресурсы для нейтрального языка и региональных параметров и соответствующая вспомогательная сборка отсутствует.</summary>
	// Token: 0x0200085A RID: 2138
	[Serializable]
	public class MissingManifestResourceException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.MissingManifestResourceException" /> стандартными свойствами.</summary>
		// Token: 0x06004736 RID: 18230 RVA: 0x000E805F File Offset: 0x000E625F
		public MissingManifestResourceException() : base("Unable to find manifest resource.")
		{
			base.HResult = -2146233038;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.MissingManifestResourceException" /> указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06004737 RID: 18231 RVA: 0x000E8077 File Offset: 0x000E6277
		public MissingManifestResourceException(string message) : base(message)
		{
			base.HResult = -2146233038;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.MissingManifestResourceException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06004738 RID: 18232 RVA: 0x000E808B File Offset: 0x000E628B
		public MissingManifestResourceException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233038;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.MissingManifestResourceException" /> из сериализованных данных.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении исключения.</param>
		// Token: 0x06004739 RID: 18233 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected MissingManifestResourceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
