using System;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Исключение, которое выдается при попытке динамического доступа к несуществующему полю. Если поле в библиотеке классов было удалено или переименовано, перекомпилируйте все сборки, ссылающиеся на эту библиотеку.</summary>
	// Token: 0x020001CE RID: 462
	[Serializable]
	public class MissingFieldException : MissingMemberException, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingFieldException" />.</summary>
		// Token: 0x060013C9 RID: 5065 RVA: 0x0004EA2E File Offset: 0x0004CC2E
		public MissingFieldException() : base("Attempted to access a non-existing field.")
		{
			base.HResult = -2146233071;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingFieldException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку.</param>
		// Token: 0x060013CA RID: 5066 RVA: 0x0004EA46 File Offset: 0x0004CC46
		public MissingFieldException(string message) : base(message)
		{
			base.HResult = -2146233071;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingFieldException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="inner" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060013CB RID: 5067 RVA: 0x0004EA5A File Offset: 0x0004CC5A
		public MissingFieldException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233071;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingFieldException" /> заданным именем класса и именем поля.</summary>
		/// <param name="className">Имя класса, в котором была произведена попытка доступа к несуществующему полю.</param>
		/// <param name="fieldName">Имя поля, доступ к которому невозможен.</param>
		// Token: 0x060013CC RID: 5068 RVA: 0x00035DBB File Offset: 0x00033FBB
		public MissingFieldException(string className, string fieldName)
		{
			this.ClassName = className;
			this.MemberName = fieldName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingFieldException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x060013CD RID: 5069 RVA: 0x00035DD1 File Offset: 0x00033FD1
		protected MissingFieldException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Возвращает текстовую строку, содержащую сигнатуру отсутствующего поля, имя класса и имя поля. Это свойство доступно только для чтения.</summary>
		/// <returns>Строка сообщения об ошибке.</returns>
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x0004EA70 File Offset: 0x0004CC70
		public override string Message
		{
			[SecuritySafeCritical]
			get
			{
				if (this.ClassName == null)
				{
					return base.Message;
				}
				return SR.Format("Field '{0}' not found.", ((this.Signature != null) ? (MissingMemberException.FormatSignature(this.Signature) + " ") : "") + this.ClassName + "." + this.MemberName);
			}
		}
	}
}
