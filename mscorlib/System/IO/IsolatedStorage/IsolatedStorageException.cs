using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO.IsolatedStorage
{
	/// <summary>Исключение вызывается при сбое операции в изолированном хранилище.</summary>
	// Token: 0x02000B72 RID: 2930
	[ComVisible(true)]
	[Serializable]
	public class IsolatedStorageException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.IsolatedStorage.IsolatedStorageException" /> стандартными свойствами.</summary>
		// Token: 0x06006A89 RID: 27273 RVA: 0x0016C994 File Offset: 0x0016AB94
		public IsolatedStorageException() : base(Locale.GetText("An Isolated storage operation failed."))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.IsolatedStorage.IsolatedStorageException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06006A8A RID: 27274 RVA: 0x000328A2 File Offset: 0x00030AA2
		public IsolatedStorageException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.IsolatedStorage.IsolatedStorageException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06006A8B RID: 27275 RVA: 0x000328AB File Offset: 0x00030AAB
		public IsolatedStorageException(string message, Exception inner) : base(message, inner)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.IsolatedStorage.IsolatedStorageException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06006A8C RID: 27276 RVA: 0x00020FA7 File Offset: 0x0001F1A7
		protected IsolatedStorageException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
