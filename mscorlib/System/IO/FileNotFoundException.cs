using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.IO
{
	/// <summary>Исключение, которое выдается при попытке получить доступ к файлу или каталогу, которого нет на диске.</summary>
	// Token: 0x02000B08 RID: 2824
	[Serializable]
	public class FileNotFoundException : IOException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileNotFoundException" /> строкой сообщений, настроенной на отображение предоставляемого системой сообщения.</summary>
		// Token: 0x060064D2 RID: 25810 RVA: 0x001569B8 File Offset: 0x00154BB8
		public FileNotFoundException() : base("Unable to find the specified file.")
		{
			base.HResult = -2147024894;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileNotFoundException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Описание ошибки. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x060064D3 RID: 25811 RVA: 0x001569D0 File Offset: 0x00154BD0
		public FileNotFoundException(string message) : base(message)
		{
			base.HResult = -2147024894;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileNotFoundException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Описание ошибки. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060064D4 RID: 25812 RVA: 0x001569E4 File Offset: 0x00154BE4
		public FileNotFoundException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024894;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileNotFoundException" /> с заданным сообщением об ошибке и именем файла, который не удается найти.</summary>
		/// <param name="message">Описание ошибки. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="fileName">Полное имя файла с недопустимым изображением.</param>
		// Token: 0x060064D5 RID: 25813 RVA: 0x001569F9 File Offset: 0x00154BF9
		public FileNotFoundException(string message, string fileName) : base(message)
		{
			base.HResult = -2147024894;
			this.FileName = fileName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileNotFoundException" /> с заданным сообщением об ошибке, именем файла, который не удается найти, и ссылкой на внутреннее исключение, являющееся причиной данного исключения.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="fileName">Полное имя файла с недопустимым изображением.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060064D6 RID: 25814 RVA: 0x00156A14 File Offset: 0x00154C14
		public FileNotFoundException(string message, string fileName, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024894;
			this.FileName = fileName;
		}

		/// <summary>Возвращает сообщение об ошибке с объяснением причин исключения.</summary>
		/// <returns>Сообщение об ошибке.</returns>
		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x060064D7 RID: 25815 RVA: 0x00156A30 File Offset: 0x00154C30
		public override string Message
		{
			get
			{
				this.SetMessageField();
				return this._message;
			}
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x00156A40 File Offset: 0x00154C40
		private void SetMessageField()
		{
			if (this._message == null)
			{
				if (this.FileName == null && base.HResult == -2146233088)
				{
					this._message = "Unable to find the specified file.";
					return;
				}
				if (this.FileName != null)
				{
					this._message = FileLoadException.FormatFileLoadExceptionMessage(this.FileName, base.HResult);
				}
			}
		}

		/// <summary>Получает имя файла, который не удается найти.</summary>
		/// <returns>Имя файла или <see langword="null" />, если имя файла не было передано в конструктор для данного экземпляра.</returns>
		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x060064D9 RID: 25817 RVA: 0x00156A95 File Offset: 0x00154C95
		public string FileName { get; }

		/// <summary>Возвращает имя журнала, в котором описано, почему закончилась неудачей загрузка сборки.</summary>
		/// <returns>Ошибки, о которых сообщил кэш сборок.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x060064DA RID: 25818 RVA: 0x00156A9D File Offset: 0x00154C9D
		public string FusionLog { get; }

		/// <summary>Возвращает полное имя данного исключения и, возможно, сообщение об ошибке, имя внутреннего исключения и трассировку стека.</summary>
		/// <returns>Полное имя данного исключения и, возможно, сообщение об ошибке, имя внутреннего исключения и трассировка стека.</returns>
		// Token: 0x060064DB RID: 25819 RVA: 0x00156AA8 File Offset: 0x00154CA8
		public override string ToString()
		{
			string text = base.GetType().ToString() + ": " + this.Message;
			if (this.FileName != null && this.FileName.Length != 0)
			{
				text = text + Environment.NewLine + SR.Format("File name: '{0}'", this.FileName);
			}
			if (base.InnerException != null)
			{
				text = text + " ---> " + base.InnerException.ToString();
			}
			if (this.StackTrace != null)
			{
				text = text + Environment.NewLine + this.StackTrace;
			}
			if (this.FusionLog != null)
			{
				if (text == null)
				{
					text = " ";
				}
				text += Environment.NewLine;
				text += Environment.NewLine;
				text += this.FusionLog;
			}
			return text;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.FileNotFoundException" /> с указанными сведениями о сериализации и контексте.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта о возникающем исключении.</param>
		/// <param name="context">Объект, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x060064DC RID: 25820 RVA: 0x00156B72 File Offset: 0x00154D72
		protected FileNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.FileName = info.GetString("FileNotFound_FileName");
			this.FusionLog = info.GetString("FileNotFound_FusionLog");
		}

		/// <summary>Устанавливает объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с именем файла и дополнительными сведениями об исключении.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта о возникающем исключении.</param>
		/// <param name="context">Объект, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x060064DD RID: 25821 RVA: 0x00156B9E File Offset: 0x00154D9E
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("FileNotFound_FileName", this.FileName, typeof(string));
			info.AddValue("FileNotFound_FusionLog", this.FusionLog, typeof(string));
		}
	}
}
