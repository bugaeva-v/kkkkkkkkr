using System;
using System.Runtime.Serialization;

namespace System.Threading.Tasks
{
	/// <summary>Представляет исключение, используемое для передачи недопустимой операции планировщиком <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
	// Token: 0x0200030B RID: 779
	[Serializable]
	public class TaskSchedulerException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Tasks.TaskSchedulerException" /> с системным сообщением, содержащим описание ошибки.</summary>
		// Token: 0x0600217D RID: 8573 RVA: 0x000786CD File Offset: 0x000768CD
		public TaskSchedulerException() : base("An exception was thrown by a TaskScheduler.")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Tasks.TaskSchedulerException" /> с использованием заданного сообщения, содержащего описание ошибки.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x0600217E RID: 8574 RVA: 0x000328A2 File Offset: 0x00030AA2
		public TaskSchedulerException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Threading.Tasks.TaskSchedulerException" /> с сообщением об ошибке по умолчанию и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения.</param>
		// Token: 0x0600217F RID: 8575 RVA: 0x000786DA File Offset: 0x000768DA
		public TaskSchedulerException(Exception innerException) : base("An exception was thrown by a TaskScheduler.", innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Tasks.TaskSchedulerException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06002180 RID: 8576 RVA: 0x000328AB File Offset: 0x00030AAB
		public TaskSchedulerException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Tasks.TaskSchedulerException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06002181 RID: 8577 RVA: 0x00020FA7 File Offset: 0x0001F1A7
		protected TaskSchedulerException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
