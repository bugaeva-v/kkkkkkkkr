using System;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Исключение, которое выдается при попытке динамического доступа к несуществующему методу.</summary>
	// Token: 0x0200015C RID: 348
	[Serializable]
	public class MissingMethodException : MissingMemberException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingMethodException" />.</summary>
		// Token: 0x06000DC8 RID: 3528 RVA: 0x00035D7A File Offset: 0x00033F7A
		public MissingMethodException() : base("Attempted to access a missing method.")
		{
			base.HResult = -2146233069;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingMethodException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку.</param>
		// Token: 0x06000DC9 RID: 3529 RVA: 0x00035D92 File Offset: 0x00033F92
		public MissingMethodException(string message) : base(message)
		{
			base.HResult = -2146233069;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingMethodException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="inner" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000DCA RID: 3530 RVA: 0x00035DA6 File Offset: 0x00033FA6
		public MissingMethodException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233069;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingMethodException" /> заданным именем класса и именем метода.</summary>
		/// <param name="className">Имя класса, в который была предпринята попытка доступа к несуществующему методу.</param>
		/// <param name="methodName">Имя метода, доступ к которому невозможен.</param>
		// Token: 0x06000DCB RID: 3531 RVA: 0x00035DBB File Offset: 0x00033FBB
		public MissingMethodException(string className, string methodName)
		{
			this.ClassName = className;
			this.MemberName = methodName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingMethodException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000DCC RID: 3532 RVA: 0x00035DD1 File Offset: 0x00033FD1
		protected MissingMethodException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Возвращает текстовую строку, содержащую имя класса, имя метода и сигнатуру отсутствующего метода. Это свойство доступно только для чтения.</summary>
		/// <returns>Строка сообщения об ошибке.</returns>
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00035DDC File Offset: 0x00033FDC
		public override string Message
		{
			[SecuritySafeCritical]
			get
			{
				if (this.ClassName != null)
				{
					return SR.Format("Method '{0}' not found.", this.ClassName + "." + this.MemberName + ((this.Signature != null) ? (" " + MissingMemberException.FormatSignature(this.Signature)) : string.Empty));
				}
				return base.Message;
			}
		}
	}
}
