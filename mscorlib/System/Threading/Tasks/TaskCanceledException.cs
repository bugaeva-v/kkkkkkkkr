using System;
using System.Runtime.Serialization;

namespace System.Threading.Tasks
{
	/// <summary>Представляет исключение, используемое для передачи отмены задачи.</summary>
	// Token: 0x02000309 RID: 777
	[Serializable]
	public class TaskCanceledException : OperationCanceledException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Tasks.TaskCanceledException" /> системным сообщением, содержащим описание ошибки.</summary>
		// Token: 0x06002167 RID: 8551 RVA: 0x00078479 File Offset: 0x00076679
		public TaskCanceledException() : base("A task was canceled.")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Tasks.TaskCanceledException" /> с использованием заданного сообщения, содержащего описание ошибки.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x06002168 RID: 8552 RVA: 0x00078486 File Offset: 0x00076686
		public TaskCanceledException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Tasks.TaskCanceledException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06002169 RID: 8553 RVA: 0x0007848F File Offset: 0x0007668F
		public TaskCanceledException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00078499 File Offset: 0x00076699
		public TaskCanceledException(string message, Exception innerException, CancellationToken token) : base(message, innerException, token)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Tasks.TaskCanceledException" /> со ссылкой на отмененную задачу <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="task">Отмененная задача.</param>
		// Token: 0x0600216B RID: 8555 RVA: 0x000784A4 File Offset: 0x000766A4
		public TaskCanceledException(Task task) : base("A task was canceled.", (task != null) ? task.CancellationToken : default(CancellationToken))
		{
			this._canceledTask = task;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Tasks.TaskCanceledException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x0600216C RID: 8556 RVA: 0x000784D7 File Offset: 0x000766D7
		protected TaskCanceledException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Получает задачу, связанную с данным исключением.</summary>
		/// <returns>Ссылка на задачу <see cref="T:System.Threading.Tasks.Task" />, связанную с этим исключением.</returns>
		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x000784E1 File Offset: 0x000766E1
		public Task Task
		{
			get
			{
				return this._canceledTask;
			}
		}

		// Token: 0x04001BC7 RID: 7111
		[NonSerialized]
		private readonly Task _canceledTask;
	}
}
