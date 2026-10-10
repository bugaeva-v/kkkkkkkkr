using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, возникающее, когда объект присутствует в массиве объектов синхронизации более одного раза.</summary>
	// Token: 0x02000113 RID: 275
	[Serializable]
	public class DuplicateWaitObjectException : ArgumentException
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00028753 File Offset: 0x00026953
		private static string DuplicateWaitObjectMessage
		{
			get
			{
				if (DuplicateWaitObjectException.s_duplicateWaitObjectMessage == null)
				{
					DuplicateWaitObjectException.s_duplicateWaitObjectMessage = "Duplicate objects in argument.";
				}
				return DuplicateWaitObjectException.s_duplicateWaitObjectMessage;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DuplicateWaitObjectException" />.</summary>
		// Token: 0x06000AC6 RID: 2758 RVA: 0x00028771 File Offset: 0x00026971
		public DuplicateWaitObjectException() : base(DuplicateWaitObjectException.DuplicateWaitObjectMessage)
		{
			base.HResult = -2146233047;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DuplicateWaitObjectException" /> именем параметра, вызвавшего исключение.</summary>
		/// <param name="parameterName">Имя параметра, вызвавшего данное исключение.</param>
		// Token: 0x06000AC7 RID: 2759 RVA: 0x00028789 File Offset: 0x00026989
		public DuplicateWaitObjectException(string parameterName) : base(DuplicateWaitObjectException.DuplicateWaitObjectMessage, parameterName)
		{
			base.HResult = -2146233047;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DuplicateWaitObjectException" /> с указанным сообщением об ошибке и именем параметра, ставшего причиной этого исключения.</summary>
		/// <param name="parameterName">Имя параметра, вызвавшего данное исключение.</param>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06000AC8 RID: 2760 RVA: 0x000287A2 File Offset: 0x000269A2
		public DuplicateWaitObjectException(string parameterName, string message) : base(message, parameterName)
		{
			base.HResult = -2146233047;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DuplicateWaitObjectException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000AC9 RID: 2761 RVA: 0x000287B7 File Offset: 0x000269B7
		public DuplicateWaitObjectException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233047;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DuplicateWaitObjectException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000ACA RID: 2762 RVA: 0x0002110F File Offset: 0x0001F30F
		protected DuplicateWaitObjectException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x040010E1 RID: 4321
		private static volatile string s_duplicateWaitObjectMessage;
	}
}
