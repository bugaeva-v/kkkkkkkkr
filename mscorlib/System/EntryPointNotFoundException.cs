using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, выбрасываемое, когда попытка загрузки класса завершается неудачей из-за отсутствия метода входа.</summary>
	// Token: 0x02000114 RID: 276
	[Serializable]
	public class EntryPointNotFoundException : TypeLoadException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EntryPointNotFoundException" />.</summary>
		// Token: 0x06000ACB RID: 2763 RVA: 0x000287CC File Offset: 0x000269CC
		public EntryPointNotFoundException() : base("Entry point was not found.")
		{
			base.HResult = -2146233053;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EntryPointNotFoundException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06000ACC RID: 2764 RVA: 0x000287E4 File Offset: 0x000269E4
		public EntryPointNotFoundException(string message) : base(message)
		{
			base.HResult = -2146233053;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EntryPointNotFoundException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="inner" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000ACD RID: 2765 RVA: 0x000287F8 File Offset: 0x000269F8
		public EntryPointNotFoundException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233053;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EntryPointNotFoundException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000ACE RID: 2766 RVA: 0x0002824E File Offset: 0x0002644E
		protected EntryPointNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
