using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Internal;

namespace System.ComponentModel.Composition
{
	/// <summary>Исключение, указывающее, была ли часть отклонена в процессе композиции.</summary>
	// Token: 0x02000023 RID: 35
	[Serializable]
	public class ChangeRejectedException : CompositionException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ChangeRejectedException" /> с системным сообщением, содержащим описание ошибки.</summary>
		// Token: 0x0600012C RID: 300 RVA: 0x00004380 File Offset: 0x00002580
		public ChangeRejectedException() : this(null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ChangeRejectedException" /> с использованием заданного сообщения, содержащего описание ошибки.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x0600012D RID: 301 RVA: 0x0000438A File Offset: 0x0000258A
		public ChangeRejectedException(string message) : this(message, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ChangeRejectedException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600012E RID: 302 RVA: 0x00004394 File Offset: 0x00002594
		public ChangeRejectedException(string message, Exception innerException) : base(message, innerException, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ChangeRejectedException" /> списком ошибок композиции.</summary>
		/// <param name="errors">Коллекция ошибок, возникших при композиции.</param>
		// Token: 0x0600012F RID: 303 RVA: 0x0000439F File Offset: 0x0000259F
		public ChangeRejectedException(IEnumerable<CompositionError> errors) : base(null, null, errors)
		{
		}

		/// <summary>Получает или задает сведение, связанное с отклонением компонента.</summary>
		/// <returns>Сведение, связанное с отклонением компонента.</returns>
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000043AA File Offset: 0x000025AA
		public override string Message
		{
			get
			{
				return string.Format(CultureInfo.CurrentCulture, Strings.CompositionException_ChangesRejected, base.Message);
			}
		}
	}
}
