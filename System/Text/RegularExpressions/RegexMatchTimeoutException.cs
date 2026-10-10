using System;
using System.Runtime.Serialization;

namespace System.Text.RegularExpressions
{
	/// <summary>Исключение, которое выдается, если время выполнения метода сопоставления шаблонов регулярных выражений превышает интервал времени ожидания.</summary>
	// Token: 0x02000206 RID: 518
	[Serializable]
	public class RegexMatchTimeoutException : TimeoutException, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException" /> сведениями о шаблоне регулярного выражения, входном тексте и интервалом времени ожидания.</summary>
		/// <param name="regexInput">Входной текст, обработанный обработчиком регулярных выражений, если истекло время ожидания.</param>
		/// <param name="regexPattern">Шаблон, используемый обработчиком регулярных выражений, если истекло время ожидания.</param>
		/// <param name="matchTimeout">Интервал времени ожидания.</param>
		// Token: 0x06000E9B RID: 3739 RVA: 0x0003FF4C File Offset: 0x0003E14C
		public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout) : base("The RegEx engine has timed out while trying to match a pattern to an input string. This can occur for many reasons, including very large inputs or excessive backtracking caused by nested quantifiers, back-references and other factors.")
		{
			this.Input = regexInput;
			this.Pattern = regexPattern;
			this.MatchTimeout = matchTimeout;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException" />, используя системное сообщение.</summary>
		// Token: 0x06000E9C RID: 3740 RVA: 0x0003FF9C File Offset: 0x0003E19C
		public RegexMatchTimeoutException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException" /> с указанной строкой сообщения.</summary>
		/// <param name="message">Строка с описанием исключения.</param>
		// Token: 0x06000E9D RID: 3741 RVA: 0x0003FFC7 File Offset: 0x0003E1C7
		public RegexMatchTimeoutException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Строка с описанием исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения.</param>
		// Token: 0x06000E9E RID: 3742 RVA: 0x0003FFF3 File Offset: 0x0003E1F3
		public RegexMatchTimeoutException(string message, Exception inner) : base(message, inner)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные.</param>
		/// <param name="context">Поток, содержащий сериализованные данные.</param>
		// Token: 0x06000E9F RID: 3743 RVA: 0x00040020 File Offset: 0x0003E220
		protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.Input = info.GetString("regexInput");
			this.Pattern = info.GetString("regexPattern");
			this.MatchTimeout = new TimeSpan(info.GetInt64("timeoutTicks"));
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации объекта <see cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException" />.</summary>
		/// <param name="si">Объект, который требуется заполнить данными.</param>
		/// <param name="context">Целевой объект этой сериализации.</param>
		// Token: 0x06000EA0 RID: 3744 RVA: 0x00040090 File Offset: 0x0003E290
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("regexInput", this.Input);
			info.AddValue("regexPattern", this.Pattern);
			info.AddValue("timeoutTicks", this.MatchTimeout.Ticks);
		}

		/// <summary>Получает входной текст, который обрабатывался обработчиком регулярных выражений, когда истекло время ожидания.</summary>
		/// <returns>Входной текст регулярного выражения.</returns>
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x000400E0 File Offset: 0x0003E2E0
		public string Input { get; } = string.Empty;

		/// <summary>Получает шаблон регулярного выражения, который использовался в операции сравнения, когда истекло время ожидания.</summary>
		/// <returns>Шаблон регулярного выражения.</returns>
		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x000400E8 File Offset: 0x0003E2E8
		public string Pattern { get; } = string.Empty;

		/// <summary>Получает интервал времени для сравнения регулярного выражения.</summary>
		/// <returns>Интервал времени ожидания.</returns>
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x000400F0 File Offset: 0x0003E2F0
		public TimeSpan MatchTimeout { get; } = TimeSpan.FromTicks(-1L);
	}
}
