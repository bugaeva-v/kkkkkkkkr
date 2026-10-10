using System;
using System.IO;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Исключение, которое выдается при недопустимом образе файла библиотеки динамической компоновки (DLL) или выполняемой программы.</summary>
	// Token: 0x020000FF RID: 255
	[Serializable]
	public class BadImageFormatException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.BadImageFormatException" />.</summary>
		// Token: 0x06000759 RID: 1881 RVA: 0x000217B6 File Offset: 0x0001F9B6
		public BadImageFormatException() : base("Format of the executable (.exe) or library (.dll) is invalid.")
		{
			base.HResult = -2147024885;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.BadImageFormatException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x0600075A RID: 1882 RVA: 0x000217CE File Offset: 0x0001F9CE
		public BadImageFormatException(string message) : base(message)
		{
			base.HResult = -2147024885;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.BadImageFormatException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="inner" /> не является указателем NULL, текущее исключение возникло в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600075B RID: 1883 RVA: 0x000217E2 File Offset: 0x0001F9E2
		public BadImageFormatException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2147024885;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.BadImageFormatException" /> указанным сообщением об ошибке и именем файла.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		/// <param name="fileName">Полное имя файла с недопустимым изображением.</param>
		// Token: 0x0600075C RID: 1884 RVA: 0x000217F7 File Offset: 0x0001F9F7
		public BadImageFormatException(string message, string fileName) : base(message)
		{
			base.HResult = -2147024885;
			this._fileName = fileName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.BadImageFormatException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="fileName">Полное имя файла с недопустимым изображением.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600075D RID: 1885 RVA: 0x00021812 File Offset: 0x0001FA12
		public BadImageFormatException(string message, string fileName, Exception inner) : base(message, inner)
		{
			base.HResult = -2147024885;
			this._fileName = fileName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.BadImageFormatException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x0600075E RID: 1886 RVA: 0x0002182E File Offset: 0x0001FA2E
		protected BadImageFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._fileName = info.GetString("BadImageFormat_FileName");
			this._fusionLog = info.GetString("BadImageFormat_FusionLog");
		}

		/// <summary>Задает для объекта <see cref="T:System.Runtime.Serialization.SerializationInfo" /> имя файла, журнал кэша сборок и дополнительные сведения об исключении.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600075F RID: 1887 RVA: 0x0002185A File Offset: 0x0001FA5A
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("BadImageFormat_FileName", this._fileName, typeof(string));
			info.AddValue("BadImageFormat_FusionLog", this._fusionLog, typeof(string));
		}

		/// <summary>Получает сообщение об ошибке и имя файла, вызвавшего данное исключение.</summary>
		/// <returns>Строка, содержащая сообщение об ошибке и имя файла, вызвавшего данное исключение.</returns>
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x0002189A File Offset: 0x0001FA9A
		public override string Message
		{
			get
			{
				this.SetMessageField();
				return this._message;
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000218A8 File Offset: 0x0001FAA8
		private void SetMessageField()
		{
			if (this._message == null)
			{
				if (this._fileName == null && base.HResult == -2146233088)
				{
					this._message = "Format of the executable (.exe) or library (.dll) is invalid.";
					return;
				}
				this._message = FileLoadException.FormatFileLoadExceptionMessage(this._fileName, base.HResult);
			}
		}

		/// <summary>Возвращает имя файла, вызвавшего данное исключение.</summary>
		/// <returns>Имя файла с недопустимым образом или пустая ссылка, если имя файла не было передано конструктору для текущего экземпляра.</returns>
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x000218F5 File Offset: 0x0001FAF5
		public string FileName
		{
			get
			{
				return this._fileName;
			}
		}

		/// <summary>Возвращает полное имя данного исключения и, возможно, сообщение об ошибке, имя внутреннего исключения и трассировку стека.</summary>
		/// <returns>Строка, содержащая полное имя данного исключения и, возможно, сообщение об ошибке, имя внутреннего исключения и трассировку стека.</returns>
		// Token: 0x06000763 RID: 1891 RVA: 0x00021900 File Offset: 0x0001FB00
		public override string ToString()
		{
			string text = base.GetType().ToString() + ": " + this.Message;
			if (this._fileName != null && this._fileName.Length != 0)
			{
				text = text + Environment.NewLine + SR.Format("File name: '{0}'", this._fileName);
			}
			if (base.InnerException != null)
			{
				text = text + " ---> " + base.InnerException.ToString();
			}
			if (this.StackTrace != null)
			{
				text = text + Environment.NewLine + this.StackTrace;
			}
			if (this._fusionLog != null)
			{
				if (text == null)
				{
					text = " ";
				}
				text += Environment.NewLine;
				text += Environment.NewLine;
				text += this._fusionLog;
			}
			return text;
		}

		/// <summary>Возвращает имя журнала, в котором описано, почему загрузка сборки не выполнена.</summary>
		/// <returns>Строка <see langword="String" />, содержащая ошибки, сообщенные кэшем сборок.</returns>
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x000219CA File Offset: 0x0001FBCA
		public string FusionLog
		{
			get
			{
				return this._fusionLog;
			}
		}

		// Token: 0x04001068 RID: 4200
		private string _fileName;

		// Token: 0x04001069 RID: 4201
		private string _fusionLog;
	}
}
