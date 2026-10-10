using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>Представляет исключение, которое возникает при попытке вызвать недопустимый адресат.</summary>
	// Token: 0x020008CA RID: 2250
	[Serializable]
	public class TargetException : ApplicationException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.TargetException" /> с помощью пустого сообщения и исключения, представляющего первопричину.</summary>
		// Token: 0x06004AE5 RID: 19173 RVA: 0x000EFD78 File Offset: 0x000EDF78
		public TargetException() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.TargetException" /> с помощью заданного сообщения и исключения, представляющего первопричину.</summary>
		/// <param name="message">Значение типа <see langword="String" />, описывающее причину возникновения исключения.</param>
		// Token: 0x06004AE6 RID: 19174 RVA: 0x000EFD81 File Offset: 0x000EDF81
		public TargetException(string message) : this(message, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.TargetException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06004AE7 RID: 19175 RVA: 0x000EFD8B File Offset: 0x000EDF8B
		public TargetException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232829;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Reflection.TargetException" /> с указанными сведениями о сериализации и контексте.</summary>
		/// <param name="info">Данные для выполнения сериализации или десериализации объекта.</param>
		/// <param name="context">Источник и назначение объекта.</param>
		// Token: 0x06004AE8 RID: 19176 RVA: 0x0006E7BD File Offset: 0x0006C9BD
		protected TargetException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
