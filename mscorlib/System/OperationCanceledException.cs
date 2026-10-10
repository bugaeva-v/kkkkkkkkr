using System;
using System.Runtime.Serialization;
using System.Threading;

namespace System
{
	/// <summary>Исключение, которое выдается в потоке при отмене операции, выполняемой этим потоком.</summary>
	// Token: 0x0200016A RID: 362
	[Serializable]
	public class OperationCanceledException : SystemException
	{
		/// <summary>Получает токен, связанный с отмененной операцией.</summary>
		/// <returns>Токен, связанный с отмененной операцией, или токен по умолчанию.</returns>
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x0003AD8B File Offset: 0x00038F8B
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x0003AD93 File Offset: 0x00038F93
		public CancellationToken CancellationToken
		{
			get
			{
				return this._cancellationToken;
			}
			private set
			{
				this._cancellationToken = value;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OperationCanceledException" /> с системным сообщением об ошибке.</summary>
		// Token: 0x06000E67 RID: 3687 RVA: 0x0003AD9C File Offset: 0x00038F9C
		public OperationCanceledException() : base("The operation was canceled.")
		{
			base.HResult = -2146233029;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OperationCanceledException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку.</param>
		// Token: 0x06000E68 RID: 3688 RVA: 0x0003ADB4 File Offset: 0x00038FB4
		public OperationCanceledException(string message) : base(message)
		{
			base.HResult = -2146233029;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OperationCanceledException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000E69 RID: 3689 RVA: 0x0003ADC8 File Offset: 0x00038FC8
		public OperationCanceledException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233029;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OperationCanceledException" /> с токеном отмены.</summary>
		/// <param name="token">Токен отмены, связанный с отмененной операцией.</param>
		// Token: 0x06000E6A RID: 3690 RVA: 0x0003ADDD File Offset: 0x00038FDD
		public OperationCanceledException(CancellationToken token) : this()
		{
			this.CancellationToken = token;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OperationCanceledException" /> с заданным сообщением об ошибке и токеном отмены.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="token">Токен отмены, связанный с отмененной операцией.</param>
		// Token: 0x06000E6B RID: 3691 RVA: 0x0003ADEC File Offset: 0x00038FEC
		public OperationCanceledException(string message, CancellationToken token) : this(message)
		{
			this.CancellationToken = token;
		}

		/// <summary>Инициализирует экземпляр класса <see cref="T:System.OperationCanceledException" /> указанным сообщением об ошибке, ссылкой на внутреннее исключение, вызвавшее данное исключение, и токеном отмены.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		/// <param name="token">Токен отмены, связанный с отмененной операцией.</param>
		// Token: 0x06000E6C RID: 3692 RVA: 0x0003ADFC File Offset: 0x00038FFC
		public OperationCanceledException(string message, Exception innerException, CancellationToken token) : this(message, innerException)
		{
			this.CancellationToken = token;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OperationCanceledException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000E6D RID: 3693 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected OperationCanceledException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x040012A7 RID: 4775
		[NonSerialized]
		private CancellationToken _cancellationToken;
	}
}
