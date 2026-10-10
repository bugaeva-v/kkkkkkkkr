using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;

namespace System
{
	/// <summary>Представляет одну или несколько ошибок, возникающих во время выполнения приложения.</summary>
	// Token: 0x020000F1 RID: 241
	[DebuggerDisplay("Count = {InnerExceptionCount}")]
	[Serializable]
	public class AggregateException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AggregateException" /> с системным сообщением, содержащим описание ошибки.</summary>
		// Token: 0x060006E6 RID: 1766 RVA: 0x00020A6F File Offset: 0x0001EC6F
		public AggregateException() : base("One or more errors occurred.")
		{
			this.m_innerExceptions = new ReadOnlyCollection<Exception>(Array.Empty<Exception>());
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AggregateException" /> с использованием заданного сообщения, содержащего описание ошибки.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x060006E7 RID: 1767 RVA: 0x00020A8C File Offset: 0x0001EC8C
		public AggregateException(string message) : base(message)
		{
			this.m_innerExceptions = new ReadOnlyCollection<Exception>(Array.Empty<Exception>());
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AggregateException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="innerException" /> имеет значение NULL.</exception>
		// Token: 0x060006E8 RID: 1768 RVA: 0x00020AA5 File Offset: 0x0001ECA5
		public AggregateException(string message, Exception innerException) : base(message, innerException)
		{
			if (innerException == null)
			{
				throw new ArgumentNullException("innerException");
			}
			this.m_innerExceptions = new ReadOnlyCollection<Exception>(new Exception[]
			{
				innerException
			});
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AggregateException" /> со ссылками на внутренние исключения, вызвавшие данное исключение.</summary>
		/// <param name="innerExceptions">Исключения, являющиеся причиной текущего исключения.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="innerExceptions" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Элемент <paramref name="innerExceptions" /> равен null.</exception>
		// Token: 0x060006E9 RID: 1769 RVA: 0x00020AD2 File Offset: 0x0001ECD2
		public AggregateException(IEnumerable<Exception> innerExceptions) : this("One or more errors occurred.", innerExceptions)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AggregateException" /> со ссылками на внутренние исключения, вызвавшие данное исключение.</summary>
		/// <param name="innerExceptions">Исключения, являющиеся причиной текущего исключения.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="innerExceptions" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Элемент <paramref name="innerExceptions" /> равен null.</exception>
		// Token: 0x060006EA RID: 1770 RVA: 0x00020AE0 File Offset: 0x0001ECE0
		public AggregateException(params Exception[] innerExceptions) : this("One or more errors occurred.", innerExceptions)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AggregateException" /> с заданным сообщением об ошибке и ссылками на внутренние исключения, вызвавшие данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerExceptions">Исключения, являющиеся причиной текущего исключения.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="innerExceptions" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Элемент <paramref name="innerExceptions" /> равен null.</exception>
		// Token: 0x060006EB RID: 1771 RVA: 0x00020AEE File Offset: 0x0001ECEE
		public AggregateException(string message, IEnumerable<Exception> innerExceptions) : this(message, (innerExceptions as IList<Exception>) ?? ((innerExceptions == null) ? null : new List<Exception>(innerExceptions)))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AggregateException" /> с заданным сообщением об ошибке и ссылками на внутренние исключения, вызвавшие данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerExceptions">Исключения, являющиеся причиной текущего исключения.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="innerExceptions" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Элемент <paramref name="innerExceptions" /> равен null.</exception>
		// Token: 0x060006EC RID: 1772 RVA: 0x00020B0D File Offset: 0x0001ED0D
		public AggregateException(string message, params Exception[] innerExceptions) : this(message, innerExceptions)
		{
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00020B18 File Offset: 0x0001ED18
		private AggregateException(string message, IList<Exception> innerExceptions) : base(message, (innerExceptions != null && innerExceptions.Count > 0) ? innerExceptions[0] : null)
		{
			if (innerExceptions == null)
			{
				throw new ArgumentNullException("innerExceptions");
			}
			Exception[] array = new Exception[innerExceptions.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = innerExceptions[i];
				if (array[i] == null)
				{
					throw new ArgumentException("An element of innerExceptions was null.");
				}
			}
			this.m_innerExceptions = new ReadOnlyCollection<Exception>(array);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00020B90 File Offset: 0x0001ED90
		internal AggregateException(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) : this("One or more errors occurred.", innerExceptionInfos)
		{
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00020B9E File Offset: 0x0001ED9E
		internal AggregateException(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) : this(message, (innerExceptionInfos as IList<ExceptionDispatchInfo>) ?? ((innerExceptionInfos == null) ? null : new List<ExceptionDispatchInfo>(innerExceptionInfos)))
		{
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00020BC0 File Offset: 0x0001EDC0
		private AggregateException(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) : base(message, (innerExceptionInfos != null && innerExceptionInfos.Count > 0 && innerExceptionInfos[0] != null) ? innerExceptionInfos[0].SourceException : null)
		{
			if (innerExceptionInfos == null)
			{
				throw new ArgumentNullException("innerExceptionInfos");
			}
			Exception[] array = new Exception[innerExceptionInfos.Count];
			for (int i = 0; i < array.Length; i++)
			{
				ExceptionDispatchInfo exceptionDispatchInfo = innerExceptionInfos[i];
				if (exceptionDispatchInfo != null)
				{
					array[i] = exceptionDispatchInfo.SourceException;
				}
				if (array[i] == null)
				{
					throw new ArgumentException("An element of innerExceptions was null.");
				}
			}
			this.m_innerExceptions = new ReadOnlyCollection<Exception>(array);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AggregateException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="info" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Не удалось правильно выполнить десериализацию исключения.</exception>
		// Token: 0x060006F1 RID: 1777 RVA: 0x00020C50 File Offset: 0x0001EE50
		protected AggregateException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			Exception[] array = info.GetValue("InnerExceptions", typeof(Exception[])) as Exception[];
			if (array == null)
			{
				throw new SerializationException("The serialization stream contains no inner exceptions.");
			}
			this.m_innerExceptions = new ReadOnlyCollection<Exception>(array);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AggregateException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="info" /> имеет значение NULL.</exception>
		// Token: 0x060006F2 RID: 1778 RVA: 0x00020CA8 File Offset: 0x0001EEA8
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			Exception[] array = new Exception[this.m_innerExceptions.Count];
			this.m_innerExceptions.CopyTo(array, 0);
			info.AddValue("InnerExceptions", array, typeof(Exception[]));
		}

		/// <summary>Возвращает объект <see cref="T:System.AggregateException" />, являющийся первопричиной данного исключения.</summary>
		/// <returns>Объект <see cref="T:System.AggregateException" />, являющийся первопричиной данного исключения.</returns>
		// Token: 0x060006F3 RID: 1779 RVA: 0x00020CF4 File Offset: 0x0001EEF4
		public override Exception GetBaseException()
		{
			Exception ex = this;
			AggregateException ex2 = this;
			while (ex2 != null && ex2.InnerExceptions.Count == 1)
			{
				ex = ex.InnerException;
				ex2 = (ex as AggregateException);
			}
			return ex;
		}

		/// <summary>Получает доступную только для чтения коллекцию экземпляров <see cref="T:System.Exception" />, вызывавших текущее исключение.</summary>
		/// <returns>Только для чтения коллекция <see cref="T:System.Exception" /> экземпляры, вызвавшее текущее исключение.</returns>
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00020D27 File Offset: 0x0001EF27
		public ReadOnlyCollection<Exception> InnerExceptions
		{
			get
			{
				return this.m_innerExceptions;
			}
		}

		/// <summary>Вызывает обработчик в каждом <see cref="T:System.Exception" />, содержащемся в этом объекте <see cref="T:System.AggregateException" />.</summary>
		/// <param name="predicate">Предикат, который необходимо выполнить для каждого исключения. Предикат принимает в качестве аргумента <see cref="T:System.Exception" /> для обработки и возвращает логическое значение для указания, было ли это исключение обработано.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="predicate" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.AggregateException">Исключение, содержащихся в этом объекте <see cref="T:System.AggregateException" />, не было обработано.</exception>
		// Token: 0x060006F5 RID: 1781 RVA: 0x00020D30 File Offset: 0x0001EF30
		public void Handle(Func<Exception, bool> predicate)
		{
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			List<Exception> list = null;
			for (int i = 0; i < this.m_innerExceptions.Count; i++)
			{
				if (!predicate(this.m_innerExceptions[i]))
				{
					if (list == null)
					{
						list = new List<Exception>();
					}
					list.Add(this.m_innerExceptions[i]);
				}
			}
			if (list != null)
			{
				throw new AggregateException(this.Message, list);
			}
		}

		/// <summary>Выполняет сведение экземпляров <see cref="T:System.AggregateException" /> в один новый экземпляр.</summary>
		/// <returns>Новый сведенный экземпляр <see cref="T:System.AggregateException" />.</returns>
		// Token: 0x060006F6 RID: 1782 RVA: 0x00020DA4 File Offset: 0x0001EFA4
		public AggregateException Flatten()
		{
			List<Exception> list = new List<Exception>();
			List<AggregateException> list2 = new List<AggregateException>();
			list2.Add(this);
			int num = 0;
			while (list2.Count > num)
			{
				IList<Exception> innerExceptions = list2[num++].InnerExceptions;
				for (int i = 0; i < innerExceptions.Count; i++)
				{
					Exception ex = innerExceptions[i];
					if (ex != null)
					{
						AggregateException ex2 = ex as AggregateException;
						if (ex2 != null)
						{
							list2.Add(ex2);
						}
						else
						{
							list.Add(ex);
						}
					}
				}
			}
			return new AggregateException(this.Message, list);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00020E30 File Offset: 0x0001F030
		public override string Message
		{
			get
			{
				if (this.m_innerExceptions.Count == 0)
				{
					return base.Message;
				}
				StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
				stringBuilder.Append(base.Message);
				stringBuilder.Append(' ');
				for (int i = 0; i < this.m_innerExceptions.Count; i++)
				{
					stringBuilder.Append('(');
					stringBuilder.Append(this.m_innerExceptions[i].Message);
					stringBuilder.Append(") ");
				}
				stringBuilder.Length--;
				return StringBuilderCache.GetStringAndRelease(stringBuilder);
			}
		}

		/// <summary>Создает и возвращает строковое представление текущего <see cref="T:System.AggregateException" />.</summary>
		/// <returns>Строковое представление текущего исключения.</returns>
		// Token: 0x060006F8 RID: 1784 RVA: 0x00020EC8 File Offset: 0x0001F0C8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(base.ToString());
			for (int i = 0; i < this.m_innerExceptions.Count; i++)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("---> ");
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "(Inner Exception #{0}) ", i);
				stringBuilder.Append(this.m_innerExceptions[i].ToString());
				stringBuilder.Append("<---");
				stringBuilder.AppendLine();
			}
			return stringBuilder.ToString();
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00020F59 File Offset: 0x0001F159
		private int InnerExceptionCount
		{
			get
			{
				return this.InnerExceptions.Count;
			}
		}

		// Token: 0x04001047 RID: 4167
		private ReadOnlyCollection<Exception> m_innerExceptions;
	}
}
