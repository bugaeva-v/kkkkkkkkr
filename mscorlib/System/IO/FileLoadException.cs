using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.IO
{
	/// <summary>Исключение, которое создается в случае, когда управляемая сборка найдена, но не может быть загружена.</summary>
	// Token: 0x02000B06 RID: 2822
	[Serializable]
	public class FileLoadException : IOException
	{
		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.FileLoadException" /> и устанавливает свойство <see cref="P:System.Exception.Message" /> нового экземпляра на получение системного сообщения, описывающего ошибку, такого как "Заданный файл не найден". Это сообщение учитывает текущую культуру системы.</summary>
		// Token: 0x060064C6 RID: 25798 RVA: 0x001567BD File Offset: 0x001549BD
		public FileLoadException() : base("Could not load the specified file.")
		{
			base.HResult = -2146232799;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileLoadException" /> указанным сообщением об ошибке.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x060064C7 RID: 25799 RVA: 0x001567D5 File Offset: 0x001549D5
		public FileLoadException(string message) : base(message)
		{
			base.HResult = -2146232799;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileLoadException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060064C8 RID: 25800 RVA: 0x001567E9 File Offset: 0x001549E9
		public FileLoadException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232799;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.FileLoadException" /> с заданным сообщением об ошибке и именем файла, который не может быть загружен.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="fileName">Объект <see cref="T:System.String" /> содержит имя файла, который не был загружен.</param>
		// Token: 0x060064C9 RID: 25801 RVA: 0x001567FE File Offset: 0x001549FE
		public FileLoadException(string message, string fileName) : base(message)
		{
			base.HResult = -2146232799;
			this.FileName = fileName;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.IO.FileLoadException" /> с заданным сообщением об ошибке, именем файла, который не может быть загружен, и ссылкой на внутреннее исключение, являющееся причиной данного исключения.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку. Содержимое <paramref name="message" /> должно быть понятно пользователю. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="fileName">Объект <see cref="T:System.String" /> содержит имя файла, который не был загружен.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060064CA RID: 25802 RVA: 0x00156819 File Offset: 0x00154A19
		public FileLoadException(string message, string fileName, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232799;
			this.FileName = fileName;
		}

		/// <summary>Получает сообщение об ошибке и имя файла, вызвавшего данное исключение.</summary>
		/// <returns>Строка, содержащая сообщение об ошибке и имя файла, вызвавшего данное исключение.</returns>
		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x060064CB RID: 25803 RVA: 0x00156835 File Offset: 0x00154A35
		public override string Message
		{
			get
			{
				if (this._message == null)
				{
					this._message = FileLoadException.FormatFileLoadExceptionMessage(this.FileName, base.HResult);
				}
				return this._message;
			}
		}

		/// <summary>Возвращает имя файла, вызвавшего данное исключение.</summary>
		/// <returns>Объект <see cref="T:System.String" /> содержит имя файла с недействительным изображением или пустую ссылку, если для этого экземпляра имя файла не было передано в конструктор.</returns>
		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x060064CC RID: 25804 RVA: 0x0015685C File Offset: 0x00154A5C
		public string FileName { get; }

		/// <summary>Возвращает имя журнала, в котором описано, почему загрузка сборки не выполнена.</summary>
		/// <returns>Строка, содержащая ошибки, сообщенные кэшем сборки.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x060064CD RID: 25805 RVA: 0x00156864 File Offset: 0x00154A64
		public string FusionLog { get; }

		/// <summary>Возвращает полное имя текущего исключения и, возможно, сообщение об ошибке, имя внутреннего исключения и трассировку стека.</summary>
		/// <returns>Строка содержит полное имя данного исключения и, возможно, сообщение об ошибке, имя внутреннего исключения и трассировку стека, в зависимости от использованного конструктора <see cref="T:System.IO.FileLoadException" />.</returns>
		// Token: 0x060064CE RID: 25806 RVA: 0x0015686C File Offset: 0x00154A6C
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

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.FileLoadException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x060064CF RID: 25807 RVA: 0x00156936 File Offset: 0x00154B36
		protected FileLoadException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.FileName = info.GetString("FileLoad_FileName");
			this.FusionLog = info.GetString("FileLoad_FusionLog");
		}

		/// <summary>Устанавливает <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с именем файла и дополнительными сведениями об исключении.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x060064D0 RID: 25808 RVA: 0x00156962 File Offset: 0x00154B62
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("FileLoad_FileName", this.FileName, typeof(string));
			info.AddValue("FileLoad_FusionLog", this.FusionLog, typeof(string));
		}

		// Token: 0x060064D1 RID: 25809 RVA: 0x001569A2 File Offset: 0x00154BA2
		internal static string FormatFileLoadExceptionMessage(string fileName, int hResult)
		{
			if (fileName != null)
			{
				return SR.Format("Could not load the file '{0}'.", fileName);
			}
			return "Could not load the specified file.";
		}
	}
}
