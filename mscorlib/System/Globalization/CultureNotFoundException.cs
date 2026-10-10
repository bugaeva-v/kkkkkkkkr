using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.Globalization
{
	/// <summary>Исключение, возникающее при вызове метода, который осуществляет попытку создать недоступные язык и региональные параметры.</summary>
	// Token: 0x02000957 RID: 2391
	[Serializable]
	public class CultureNotFoundException : ArgumentException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.CultureNotFoundException" /> строкой сообщений, настроенной на отображение предоставляемого системой сообщения.</summary>
		// Token: 0x06005499 RID: 21657 RVA: 0x0011AB56 File Offset: 0x00118D56
		public CultureNotFoundException() : base(CultureNotFoundException.DefaultMessage)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.CultureNotFoundException" /> указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, отображаемое с этим исключением.</param>
		// Token: 0x0600549A RID: 21658 RVA: 0x0011AB63 File Offset: 0x00118D63
		public CultureNotFoundException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.CultureNotFoundException" /> заданным сообщением об ошибке и именем параметра, ставшего причиной этого исключения.</summary>
		/// <param name="paramName">Имя параметра, вызвавшего текущее исключение.</param>
		/// <param name="message">Сообщение об ошибке, отображаемое с этим исключением.</param>
		// Token: 0x0600549B RID: 21659 RVA: 0x0011AB6C File Offset: 0x00118D6C
		public CultureNotFoundException(string paramName, string message) : base(message, paramName)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.CultureNotFoundException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, отображаемое с этим исключением.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем NULL, текущее исключение возникло в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600549C RID: 21660 RVA: 0x0011AB76 File Offset: 0x00118D76
		public CultureNotFoundException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.CultureNotFoundException" /> заданным сообщением об ошибке, недействительным именем языка и региональных параметров и именем параметра, ставшего причиной этого исключения.</summary>
		/// <param name="paramName">Имя параметра, вызвавшего текущее исключение.</param>
		/// <param name="invalidCultureName">Имя языка и региональных параметров, которое не удается найти.</param>
		/// <param name="message">Сообщение об ошибке, отображаемое с этим исключением.</param>
		// Token: 0x0600549D RID: 21661 RVA: 0x0011AB80 File Offset: 0x00118D80
		public CultureNotFoundException(string paramName, string invalidCultureName, string message) : base(message, paramName)
		{
			this._invalidCultureName = invalidCultureName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.CultureNotFoundException" /> заданным сообщением об ошибке, недопустимым именем языка и региональных параметров и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, отображаемое с этим исключением.</param>
		/// <param name="invalidCultureName">Имя языка и региональных параметров, которое не удается найти.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем NULL, текущее исключение возникло в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600549E RID: 21662 RVA: 0x0011AB91 File Offset: 0x00118D91
		public CultureNotFoundException(string message, string invalidCultureName, Exception innerException) : base(message, innerException)
		{
			this._invalidCultureName = invalidCultureName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.CultureNotFoundException" /> заданным сообщением об ошибке, недопустимым идентификатором языка и региональных параметров и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, отображаемое с этим исключением.</param>
		/// <param name="invalidCultureId">Идентификатор языка и региональных параметров, который не удается найти.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем NULL, текущее исключение возникло в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600549F RID: 21663 RVA: 0x0011ABA2 File Offset: 0x00118DA2
		public CultureNotFoundException(string message, int invalidCultureId, Exception innerException) : base(message, innerException)
		{
			this._invalidCultureId = new int?(invalidCultureId);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.CultureNotFoundException" /> заданным сообщением об ошибке, недействительным идентификатором языка и региональных параметров и именем параметра, ставшего причиной этого исключения.</summary>
		/// <param name="paramName">Имя параметра, вызвавшего текущее исключение.</param>
		/// <param name="invalidCultureId">Идентификатор языка и региональных параметров, который не удается найти.</param>
		/// <param name="message">Сообщение об ошибке, отображаемое с этим исключением.</param>
		// Token: 0x060054A0 RID: 21664 RVA: 0x0011ABB8 File Offset: 0x00118DB8
		public CultureNotFoundException(string paramName, int invalidCultureId, string message) : base(message, paramName)
		{
			this._invalidCultureId = new int?(invalidCultureId);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Globalization.CultureNotFoundException" />, используя указанные данные сериализации и контекст.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x060054A1 RID: 21665 RVA: 0x0011ABD0 File Offset: 0x00118DD0
		protected CultureNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._invalidCultureId = (int?)info.GetValue("InvalidCultureId", typeof(int?));
			this._invalidCultureName = (string)info.GetValue("InvalidCultureName", typeof(string));
		}

		/// <summary>Задает объекту <see cref="T:System.Runtime.Serialization.SerializationInfo" /> имя параметра и дополнительную информацию об исключении.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060054A2 RID: 21666 RVA: 0x0011AC28 File Offset: 0x00118E28
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("InvalidCultureId", this._invalidCultureId, typeof(int?));
			info.AddValue("InvalidCultureName", this._invalidCultureName, typeof(string));
		}

		/// <summary>Возвращает идентификатор языка и региональных параметров, который не удается найти.</summary>
		/// <returns>Недействительный идентификатор языка и региональных параметров.</returns>
		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x060054A3 RID: 21667 RVA: 0x0011AC78 File Offset: 0x00118E78
		public virtual int? InvalidCultureId
		{
			get
			{
				return this._invalidCultureId;
			}
		}

		/// <summary>Возвращает имя языка и региональных параметров, которое не удается найти.</summary>
		/// <returns>Недействительное имя языка и региональных параметров.</returns>
		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x060054A4 RID: 21668 RVA: 0x0011AC80 File Offset: 0x00118E80
		public virtual string InvalidCultureName
		{
			get
			{
				return this._invalidCultureName;
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060054A5 RID: 21669 RVA: 0x0011AC88 File Offset: 0x00118E88
		private static string DefaultMessage
		{
			get
			{
				return "Culture is not supported.";
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x0011AC90 File Offset: 0x00118E90
		private string FormatedInvalidCultureId
		{
			get
			{
				if (this.InvalidCultureId == null)
				{
					return this.InvalidCultureName;
				}
				return string.Format(CultureInfo.InvariantCulture, "{0} (0x{0:x4})", this.InvalidCultureId.Value);
			}
		}

		/// <summary>Возвращает сообщение об ошибке с объяснением причин исключения.</summary>
		/// <returns>Текстовая строка с подробным описанием исключения.</returns>
		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x060054A7 RID: 21671 RVA: 0x0011ACD8 File Offset: 0x00118ED8
		public override string Message
		{
			get
			{
				string message = base.Message;
				if (this._invalidCultureId == null && this._invalidCultureName == null)
				{
					return message;
				}
				string text = SR.Format("{0} is an invalid culture identifier.", this.FormatedInvalidCultureId);
				if (message == null)
				{
					return text;
				}
				return message + Environment.NewLine + text;
			}
		}

		// Token: 0x040033D2 RID: 13266
		private string _invalidCultureName;

		// Token: 0x040033D3 RID: 13267
		private int? _invalidCultureId;
	}
}
