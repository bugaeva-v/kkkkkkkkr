using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>Представляет ошибки структурной обработки исключений (SEH).</summary>
	// Token: 0x020006DC RID: 1756
	[Serializable]
	public class SEHException : ExternalException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.SEHException" />.</summary>
		// Token: 0x06004041 RID: 16449 RVA: 0x000E0D5A File Offset: 0x000DEF5A
		public SEHException()
		{
			base.HResult = -2147467259;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.SEHException" /> с заданным сообщением.</summary>
		/// <param name="message">Сообщение, указывающее причину возникновения исключения.</param>
		// Token: 0x06004042 RID: 16450 RVA: 0x000E0D6D File Offset: 0x000DEF6D
		public SEHException(string message) : base(message)
		{
			base.HResult = -2147467259;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.SEHException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06004043 RID: 16451 RVA: 0x000E0D81 File Offset: 0x000DEF81
		public SEHException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2147467259;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.SEHException" />, используя данные сериализации.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004044 RID: 16452 RVA: 0x000E0B6F File Offset: 0x000DED6F
		protected SEHException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Показывает, возможно ли восстановление после исключения и возможно ли продолжить выполнение кода с точки возникновения этого исключения.</summary>
		/// <returns>Всегда имеет значение <see langword="false" />, поскольку исключения с возможностью восстановления не реализованы.</returns>
		// Token: 0x06004045 RID: 16453 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool CanResume()
		{
			return false;
		}
	}
}
