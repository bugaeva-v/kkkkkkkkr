using System;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Исключение, возникающее при попытке динамического доступа к члену класса, который не существует или не объявлен как открытый. При удалении члена из библиотеки класса необходимо перекомпилировать все сборки, ссылающиеся на эту библиотеку.</summary>
	// Token: 0x020001CF RID: 463
	[Serializable]
	public class MissingMemberException : MemberAccessException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingMemberException" />.</summary>
		// Token: 0x060013CF RID: 5071 RVA: 0x0004EAD0 File Offset: 0x0004CCD0
		public MissingMemberException() : base("Attempted to access a missing member.")
		{
			base.HResult = -2146233070;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingMemberException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x060013D0 RID: 5072 RVA: 0x0004EAE8 File Offset: 0x0004CCE8
		public MissingMemberException(string message) : base(message)
		{
			base.HResult = -2146233070;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingMemberException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, которое стало первопричиной данного исключения.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Экземпляр <see cref="T:System.Exception" />, являющийся причиной текущего исключения <see langword="Exception" />. Если <paramref name="inner" /> не является пустой ссылкой (<see langword="Nothing" /> в Visual Basic), текущее исключение <see langword="Exception" /> вызывается в блоке catch, обрабатывающем исключение <paramref name="inner" />.</param>
		// Token: 0x060013D1 RID: 5073 RVA: 0x0004EAFC File Offset: 0x0004CCFC
		public MissingMemberException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233070;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingMemberException" /> заданным именем класса и именем члена.</summary>
		/// <param name="className">Имя класса, в котором была произведена попытка доступа к несуществующему члену.</param>
		/// <param name="memberName">Имя члена, доступ к которому невозможен.</param>
		// Token: 0x060013D2 RID: 5074 RVA: 0x0004EB11 File Offset: 0x0004CD11
		public MissingMemberException(string className, string memberName)
		{
			this.ClassName = className;
			this.MemberName = memberName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MissingMemberException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x060013D3 RID: 5075 RVA: 0x0004EB28 File Offset: 0x0004CD28
		protected MissingMemberException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.ClassName = info.GetString("MMClassName");
			this.MemberName = info.GetString("MMMemberName");
			this.Signature = (byte[])info.GetValue("MMSignature", typeof(byte[]));
		}

		/// <summary>Задает объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сигнатуру отсутствующего члена, имя класса, имя члена и дополнительную информацию исключения.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Объект <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060013D4 RID: 5076 RVA: 0x0004EB80 File Offset: 0x0004CD80
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("MMClassName", this.ClassName, typeof(string));
			info.AddValue("MMMemberName", this.MemberName, typeof(string));
			info.AddValue("MMSignature", this.Signature, typeof(byte[]));
		}

		/// <summary>Получает текстовую строку с именем класса, именем элемента и подписью отсутствующего элемента.</summary>
		/// <returns>Строка сообщения об ошибке.</returns>
		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x0004EBE8 File Offset: 0x0004CDE8
		public override string Message
		{
			[SecuritySafeCritical]
			get
			{
				if (this.ClassName == null)
				{
					return base.Message;
				}
				return SR.Format("Member '{0}' not found.", this.ClassName + "." + this.MemberName + ((this.Signature != null) ? (" " + MissingMemberException.FormatSignature(this.Signature)) : string.Empty));
			}
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x000258DB File Offset: 0x00023ADB
		internal static string FormatSignature(byte[] signature)
		{
			return string.Empty;
		}

		/// <summary>Содержит имя класса отсутствующего члена.</summary>
		// Token: 0x04001459 RID: 5209
		protected string ClassName;

		/// <summary>Содержит имя отсутствующего члена.</summary>
		// Token: 0x0400145A RID: 5210
		protected string MemberName;

		/// <summary>Содержит сигнатуру отсутствующего члена.</summary>
		// Token: 0x0400145B RID: 5211
		protected byte[] Signature;
	}
}
