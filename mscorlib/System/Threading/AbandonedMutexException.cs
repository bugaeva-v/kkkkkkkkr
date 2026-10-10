using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>Исключение вызывается, когда некоторый поток получает объект <see cref="T:System.Threading.Mutex" />, брошенный другим потоком путем выхода без высвобождения.</summary>
	// Token: 0x0200027F RID: 639
	[Serializable]
	public class AbandonedMutexException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.AbandonedMutexException" /> значениями по умолчанию.</summary>
		// Token: 0x06001D50 RID: 7504 RVA: 0x0006D99B File Offset: 0x0006BB9B
		public AbandonedMutexException() : base("The wait completed due to an abandoned mutex.")
		{
			base.HResult = -2146233043;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.AbandonedMutexException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке с объяснением причины исключения.</param>
		// Token: 0x06001D51 RID: 7505 RVA: 0x0006D9BA File Offset: 0x0006BBBA
		public AbandonedMutexException(string message) : base(message)
		{
			base.HResult = -2146233043;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Threading.AbandonedMutexException" /> с указанным сообщением об ошибке и внутренним исключением.</summary>
		/// <param name="message">Сообщение об ошибке с объяснением причины исключения.</param>
		/// <param name="inner">Исключение, которое вызвало текущее исключение. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06001D52 RID: 7506 RVA: 0x0006D9D5 File Offset: 0x0006BBD5
		public AbandonedMutexException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233043;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.AbandonedMutexException" />, используя конкретиый индекс брошенного мьютекса, (если применимо), а также объект <see cref="T:System.Threading.Mutex" />, представляющий мьютекс.</summary>
		/// <param name="location">Индекс брошенного мьютекса в массиве дескрипторов ожидания, если выдается исключение для метода <see cref="Overload:System.Threading.WaitHandle.WaitAny" />, или –1, если исключение выдается для методов <see cref="Overload:System.Threading.WaitHandle.WaitOne" /> или <see cref="Overload:System.Threading.WaitHandle.WaitAll" />.</param>
		/// <param name="handle">Объект <see cref="T:System.Threading.Mutex" />, представляющий брошенный мьютекс.</param>
		// Token: 0x06001D53 RID: 7507 RVA: 0x0006D9F1 File Offset: 0x0006BBF1
		public AbandonedMutexException(int location, WaitHandle handle) : base("The wait completed due to an abandoned mutex.")
		{
			base.HResult = -2146233043;
			this.SetupException(location, handle);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.AbandonedMutexException" /> указанным сообщением об ошибке, индексом брошенного мьютекса (если применимо), а также брошенным мьютексом.</summary>
		/// <param name="message">Сообщение об ошибке с объяснением причины исключения.</param>
		/// <param name="location">Индекс брошенного мьютекса в массиве дескрипторов ожидания, если выдается исключение для метода <see cref="Overload:System.Threading.WaitHandle.WaitAny" />, или –1, если исключение выдается для методов <see cref="Overload:System.Threading.WaitHandle.WaitOne" /> или <see cref="Overload:System.Threading.WaitHandle.WaitAll" />.</param>
		/// <param name="handle">Объект <see cref="T:System.Threading.Mutex" />, представляющий брошенный мьютекс.</param>
		// Token: 0x06001D54 RID: 7508 RVA: 0x0006DA18 File Offset: 0x0006BC18
		public AbandonedMutexException(string message, int location, WaitHandle handle) : base(message)
		{
			base.HResult = -2146233043;
			this.SetupException(location, handle);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.AbandonedMutexException" />, используя указанное сообщения об ошибке, внутреннее исключение, индекс брошенного мьютекса (если применимо), а также объект <see cref="T:System.Threading.Mutex" />, представляющего мьютекс.</summary>
		/// <param name="message">Сообщение об ошибке с объяснением причины исключения.</param>
		/// <param name="inner">Исключение, которое вызвало текущее исключение. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		/// <param name="location">Индекс брошенного мьютекса в массиве дескрипторов ожидания, если выдается исключение для метода <see cref="Overload:System.Threading.WaitHandle.WaitAny" />, или –1, если исключение выдается для методов <see cref="Overload:System.Threading.WaitHandle.WaitOne" /> или <see cref="Overload:System.Threading.WaitHandle.WaitAll" />.</param>
		/// <param name="handle">Объект <see cref="T:System.Threading.Mutex" />, представляющий брошенный мьютекс.</param>
		// Token: 0x06001D55 RID: 7509 RVA: 0x0006DA3B File Offset: 0x0006BC3B
		public AbandonedMutexException(string message, Exception inner, int location, WaitHandle handle) : base(message, inner)
		{
			base.HResult = -2146233043;
			this.SetupException(location, handle);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.AbandonedMutexException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к генерируемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06001D56 RID: 7510 RVA: 0x0006DA60 File Offset: 0x0006BC60
		protected AbandonedMutexException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x0006DA71 File Offset: 0x0006BC71
		private void SetupException(int location, WaitHandle handle)
		{
			this._mutexIndex = location;
			if (handle != null)
			{
				this._mutex = (handle as Mutex);
			}
		}

		/// <summary>Получает брошенный мьютекс, вызвавший исключение (если он известен).</summary>
		/// <returns>Объект <see cref="T:System.Threading.Mutex" />, представляющий брошенный мьютекс, или <see langword="null" />, если брошенный мьютекс не может быть идентифицирован.</returns>
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x0006DA89 File Offset: 0x0006BC89
		public Mutex Mutex
		{
			get
			{
				return this._mutex;
			}
		}

		/// <summary>Получает индекс брошенного мьютекса, вызвавшего исключение (если он известен).</summary>
		/// <returns>Индекс в массиве дескрипторов ожидания, передаваемый <see cref="Overload:System.Threading.WaitHandle.WaitAny" /> метод, из <see cref="T:System.Threading.Mutex" /> , представляющий Брошенный мьютекс, или значение -1, если не удалось определить индекс брошенного мьютекса.</returns>
		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x0006DA91 File Offset: 0x0006BC91
		public int MutexIndex
		{
			get
			{
				return this._mutexIndex;
			}
		}

		// Token: 0x04001A1E RID: 6686
		private int _mutexIndex = -1;

		// Token: 0x04001A1F RID: 6687
		private Mutex _mutex;
	}
}
