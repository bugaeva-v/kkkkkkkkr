using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml.Linq
{
	/// <summary>Представляет XML-документ. Информацию о компонентах и использовании объекта <see cref="T:System.Xml.Linq.XDocument" /> см. в статье Общие сведения о классах XDocument.</summary>
	// Token: 0x02000027 RID: 39
	public class XDocument : XContainer
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Xml.Linq.XDocument" />.</summary>
		// Token: 0x0600016E RID: 366 RVA: 0x00007A9D File Offset: 0x00005C9D
		public XDocument()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Xml.Linq.XDocument" /> с указанным содержимым.</summary>
		/// <param name="content">Список параметров объектов содержимого для добавления в этот документ.</param>
		// Token: 0x0600016F RID: 367 RVA: 0x00007AA5 File Offset: 0x00005CA5
		public XDocument(params object[] content) : this()
		{
			base.AddContentSkipNotify(content);
		}

		/// <summary>Инициализация нового экземпляра  класса <see cref="T:System.Xml.Linq.XDocument" /> с указанным <see cref="T:System.Xml.Linq.XDeclaration" /> и содержимым.</summary>
		/// <param name="declaration">
		///   <see cref="T:System.Xml.Linq.XDeclaration" /> для документа.</param>
		/// <param name="content">Содержимое документа.</param>
		// Token: 0x06000170 RID: 368 RVA: 0x00007AB4 File Offset: 0x00005CB4
		public XDocument(XDeclaration declaration, params object[] content) : this(content)
		{
			this._declaration = declaration;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Xml.Linq.XDocument" /> из существующего объекта <see cref="T:System.Xml.Linq.XDocument" />.</summary>
		/// <param name="other">Объект <see cref="T:System.Xml.Linq.XDocument" />, который будет копироваться.</param>
		// Token: 0x06000171 RID: 369 RVA: 0x00007AC4 File Offset: 0x00005CC4
		public XDocument(XDocument other) : base(other)
		{
			if (other._declaration != null)
			{
				this._declaration = new XDeclaration(other._declaration);
			}
		}

		/// <summary>Возвращает или задает объявление XML для этого документа.</summary>
		/// <returns>Объект <see cref="T:System.Xml.Linq.XDeclaration" />, который содержит объявление XML для этого документа.</returns>
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00007AE6 File Offset: 0x00005CE6
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00007AEE File Offset: 0x00005CEE
		public XDeclaration Declaration
		{
			get
			{
				return this._declaration;
			}
			set
			{
				this._declaration = value;
			}
		}

		/// <summary>Возвращает определение типа документа (DTD) для этого документа.</summary>
		/// <returns>
		///   <see cref="T:System.Xml.Linq.XDocumentType" />, который содержит DTD для этого документа.</returns>
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00007AF7 File Offset: 0x00005CF7
		public XDocumentType DocumentType
		{
			get
			{
				return this.GetFirstNode<XDocumentType>();
			}
		}

		/// <summary>Возвращает тип узла для этого узла.</summary>
		/// <returns>Тип узла. Для объектов <see cref="T:System.Xml.Linq.XDocument" /> это значение равно <see cref="F:System.Xml.XmlNodeType.Document" />.</returns>
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00007AFF File Offset: 0x00005CFF
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Document;
			}
		}

		/// <summary>Возвращает корневой элемент дерева XML для этого документа.</summary>
		/// <returns>Корень <see cref="T:System.Xml.Linq.XElement" /> дерева XML.</returns>
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00007B03 File Offset: 0x00005D03
		public XElement Root
		{
			get
			{
				return this.GetFirstNode<XElement>();
			}
		}

		/// <summary>Создает новый <see cref="T:System.Xml.Linq.XDocument" /> из файла.</summary>
		/// <param name="uri">Строка URI, ссылающаяся на файл для загрузки в новый <see cref="T:System.Xml.Linq.XDocument" />.</param>
		/// <returns>Элемент <see cref="T:System.Xml.Linq.XDocument" /> с содержимым указанного файла.</returns>
		// Token: 0x06000177 RID: 375 RVA: 0x00007B0B File Offset: 0x00005D0B
		public static XDocument Load(string uri)
		{
			return XDocument.Load(uri, LoadOptions.None);
		}

		/// <summary>Создает новый <see cref="T:System.Xml.Linq.XDocument" /> из файла, при необходимости оставляя пустое пространство, задавая базовый URI и сохраняя сведения о строках.</summary>
		/// <param name="uri">Строка URI, ссылающаяся на файл для загрузки в новый <see cref="T:System.Xml.Linq.XDocument" />.</param>
		/// <param name="options">
		///   <see cref="T:System.Xml.Linq.LoadOptions" />, указывающий поведение пустого пространства и необходимость загрузки базового URI и сведений о строке.</param>
		/// <returns>Элемент <see cref="T:System.Xml.Linq.XDocument" /> с содержимым указанного файла.</returns>
		// Token: 0x06000178 RID: 376 RVA: 0x00007B14 File Offset: 0x00005D14
		public static XDocument Load(string uri, LoadOptions options)
		{
			XmlReaderSettings xmlReaderSettings = XNode.GetXmlReaderSettings(options);
			XDocument result;
			using (XmlReader xmlReader = XmlReader.Create(uri, xmlReaderSettings))
			{
				result = XDocument.Load(xmlReader, options);
			}
			return result;
		}

		/// <summary>Создает новый экземпляр <see cref="T:System.Xml.Linq.XDocument" /> с помощью указанного потока.</summary>
		/// <param name="stream">Поток, содержащий XML-данные.</param>
		/// <returns>Объект <see cref="T:System.Xml.Linq.XDocument" />, который считывает содержащиеся в потоке данные.</returns>
		// Token: 0x06000179 RID: 377 RVA: 0x00007B58 File Offset: 0x00005D58
		public static XDocument Load(Stream stream)
		{
			return XDocument.Load(stream, LoadOptions.None);
		}

		/// <summary>Создает новый экземпляр<see cref="T:System.Xml.Linq.XDocument" />, используя указанный поток и при необходимости оставляя пустое пространство, задавая базовый URI и сохраняя сведения о строках.</summary>
		/// <param name="stream">Поток, содержащий данные XML.</param>
		/// <param name="options">Объект <see cref="T:System.Xml.Linq.LoadOptions" />, указывающий, следует ли загружать базовый URI и сведения о строках.</param>
		/// <returns>Объект <see cref="T:System.Xml.Linq.XDocument" />, который считывает содержащиеся в потоке данные.</returns>
		// Token: 0x0600017A RID: 378 RVA: 0x00007B64 File Offset: 0x00005D64
		public static XDocument Load(Stream stream, LoadOptions options)
		{
			XmlReaderSettings xmlReaderSettings = XNode.GetXmlReaderSettings(options);
			XDocument result;
			using (XmlReader xmlReader = XmlReader.Create(stream, xmlReaderSettings))
			{
				result = XDocument.Load(xmlReader, options);
			}
			return result;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00007BA8 File Offset: 0x00005DA8
		public static Task<XDocument> LoadAsync(Stream stream, LoadOptions options, CancellationToken cancellationToken)
		{
			XDocument.<LoadAsync>d__18 <LoadAsync>d__;
			<LoadAsync>d__.stream = stream;
			<LoadAsync>d__.options = options;
			<LoadAsync>d__.cancellationToken = cancellationToken;
			<LoadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<XDocument>.Create();
			<LoadAsync>d__.<>1__state = -1;
			<LoadAsync>d__.<>t__builder.Start<XDocument.<LoadAsync>d__18>(ref <LoadAsync>d__);
			return <LoadAsync>d__.<>t__builder.Task;
		}

		/// <summary>Создает новый <see cref="T:System.Xml.Linq.XDocument" /> из <see cref="T:System.IO.TextReader" />.</summary>
		/// <param name="textReader">Объект <see cref="T:System.IO.TextReader" />, включающий содержимое для документа <see cref="T:System.Xml.Linq.XDocument" />.</param>
		/// <returns>Документ <see cref="T:System.Xml.Linq.XDocument" />, включающий содержимое указанного объекта <see cref="T:System.IO.TextReader" />.</returns>
		// Token: 0x0600017C RID: 380 RVA: 0x00007BFB File Offset: 0x00005DFB
		public static XDocument Load(TextReader textReader)
		{
			return XDocument.Load(textReader, LoadOptions.None);
		}

		/// <summary>Создает новый документ <see cref="T:System.Xml.Linq.XDocument" /> из объекта <see cref="T:System.IO.TextReader" />, при необходимости оставляя пустое пространство, задавая базовый URI и сохраняя сведения о строках.</summary>
		/// <param name="textReader">Объект <see cref="T:System.IO.TextReader" />, включающий содержимое для документа <see cref="T:System.Xml.Linq.XDocument" />.</param>
		/// <param name="options">
		///   <see cref="T:System.Xml.Linq.LoadOptions" />, указывающий поведение пустого пространства и необходимость загрузки базового URI и сведений о строке.</param>
		/// <returns>
		///   <see cref="T:System.Xml.Linq.XDocument" />, содержащий XML, считанный из указанного <see cref="T:System.IO.TextReader" />.</returns>
		// Token: 0x0600017D RID: 381 RVA: 0x00007C04 File Offset: 0x00005E04
		public static XDocument Load(TextReader textReader, LoadOptions options)
		{
			XmlReaderSettings xmlReaderSettings = XNode.GetXmlReaderSettings(options);
			XDocument result;
			using (XmlReader xmlReader = XmlReader.Create(textReader, xmlReaderSettings))
			{
				result = XDocument.Load(xmlReader, options);
			}
			return result;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00007C48 File Offset: 0x00005E48
		public static Task<XDocument> LoadAsync(TextReader textReader, LoadOptions options, CancellationToken cancellationToken)
		{
			XDocument.<LoadAsync>d__21 <LoadAsync>d__;
			<LoadAsync>d__.textReader = textReader;
			<LoadAsync>d__.options = options;
			<LoadAsync>d__.cancellationToken = cancellationToken;
			<LoadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<XDocument>.Create();
			<LoadAsync>d__.<>1__state = -1;
			<LoadAsync>d__.<>t__builder.Start<XDocument.<LoadAsync>d__21>(ref <LoadAsync>d__);
			return <LoadAsync>d__.<>t__builder.Task;
		}

		/// <summary>Создает новый документ <see cref="T:System.Xml.Linq.XDocument" /> из объекта <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <param name="reader">Объект <see cref="T:System.Xml.XmlReader" />, включающий содержимое для документа <see cref="T:System.Xml.Linq.XDocument" />.</param>
		/// <returns>Документ <see cref="T:System.Xml.Linq.XDocument" />, включающий содержимое указанного объекта <see cref="T:System.Xml.XmlReader" />.</returns>
		// Token: 0x0600017F RID: 383 RVA: 0x00007C9B File Offset: 0x00005E9B
		public static XDocument Load(XmlReader reader)
		{
			return XDocument.Load(reader, LoadOptions.None);
		}

		/// <summary>Загружает <see cref="T:System.Xml.Linq.XDocument" /> из <see cref="T:System.Xml.XmlReader" />, при необходимости задавая базовый URI и сохраняя сведения о строках.</summary>
		/// <param name="reader">
		///   <see cref="T:System.Xml.XmlReader" /> будет прочтен для содержимого <see cref="T:System.Xml.Linq.XDocument" />.</param>
		/// <param name="options">Объект <see cref="T:System.Xml.Linq.LoadOptions" />, указывающий, следует ли загружать базовый URI и сведения о строках.</param>
		/// <returns>
		///   <see cref="T:System.Xml.Linq.XDocument" />, содержащий XML, считанный из указанного <see cref="T:System.Xml.XmlReader" />.</returns>
		// Token: 0x06000180 RID: 384 RVA: 0x00007CA4 File Offset: 0x00005EA4
		public static XDocument Load(XmlReader reader, LoadOptions options)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (reader.ReadState == ReadState.Initial)
			{
				reader.Read();
			}
			XDocument xdocument = XDocument.InitLoad(reader, options);
			xdocument.ReadContentFrom(reader, options);
			if (!reader.EOF)
			{
				throw new InvalidOperationException("The XmlReader state should be EndOfFile after this operation.");
			}
			if (xdocument.Root == null)
			{
				throw new InvalidOperationException("The root element is missing.");
			}
			return xdocument;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00007D03 File Offset: 0x00005F03
		public static Task<XDocument> LoadAsync(XmlReader reader, LoadOptions options, CancellationToken cancellationToken)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<XDocument>(cancellationToken);
			}
			return XDocument.LoadAsyncInternal(reader, options, cancellationToken);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00007D2C File Offset: 0x00005F2C
		private static Task<XDocument> LoadAsyncInternal(XmlReader reader, LoadOptions options, CancellationToken cancellationToken)
		{
			XDocument.<LoadAsyncInternal>d__25 <LoadAsyncInternal>d__;
			<LoadAsyncInternal>d__.reader = reader;
			<LoadAsyncInternal>d__.options = options;
			<LoadAsyncInternal>d__.cancellationToken = cancellationToken;
			<LoadAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder<XDocument>.Create();
			<LoadAsyncInternal>d__.<>1__state = -1;
			<LoadAsyncInternal>d__.<>t__builder.Start<XDocument.<LoadAsyncInternal>d__25>(ref <LoadAsyncInternal>d__);
			return <LoadAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00007D80 File Offset: 0x00005F80
		private static XDocument InitLoad(XmlReader reader, LoadOptions options)
		{
			XDocument xdocument = new XDocument();
			if ((options & LoadOptions.SetBaseUri) != LoadOptions.None)
			{
				string baseURI = reader.BaseURI;
				if (!string.IsNullOrEmpty(baseURI))
				{
					xdocument.SetBaseUri(baseURI);
				}
			}
			if ((options & LoadOptions.SetLineInfo) != LoadOptions.None)
			{
				IXmlLineInfo xmlLineInfo = reader as IXmlLineInfo;
				if (xmlLineInfo != null && xmlLineInfo.HasLineInfo())
				{
					xdocument.SetLineInfo(xmlLineInfo.LineNumber, xmlLineInfo.LinePosition);
				}
			}
			if (reader.NodeType == XmlNodeType.XmlDeclaration)
			{
				xdocument.Declaration = new XDeclaration(reader);
			}
			return xdocument;
		}

		/// <summary>Создает новый документ <see cref="T:System.Xml.Linq.XDocument" /> из строки.</summary>
		/// <param name="text">Строка, содержащая XML.</param>
		/// <returns>
		///   <see cref="T:System.Xml.Linq.XDocument" /> заполнен из строки, содержащей XML.</returns>
		// Token: 0x06000184 RID: 388 RVA: 0x00007DEE File Offset: 0x00005FEE
		public static XDocument Parse(string text)
		{
			return XDocument.Parse(text, LoadOptions.None);
		}

		/// <summary>Создает новый документ <see cref="T:System.Xml.Linq.XDocument" /> из строки, при необходимости оставляя пустое пространство, задавая базовый URI и сохраняя сведения о строках.</summary>
		/// <param name="text">Строка, содержащая XML.</param>
		/// <param name="options">
		///   <see cref="T:System.Xml.Linq.LoadOptions" />, указывающий поведение пустого пространства и необходимость загрузки базового URI и сведений о строке.</param>
		/// <returns>
		///   <see cref="T:System.Xml.Linq.XDocument" /> заполнен из строки, содержащей XML.</returns>
		// Token: 0x06000185 RID: 389 RVA: 0x00007DF8 File Offset: 0x00005FF8
		public static XDocument Parse(string text, LoadOptions options)
		{
			XDocument result;
			using (StringReader stringReader = new StringReader(text))
			{
				XmlReaderSettings xmlReaderSettings = XNode.GetXmlReaderSettings(options);
				using (XmlReader xmlReader = XmlReader.Create(stringReader, xmlReaderSettings))
				{
					result = XDocument.Load(xmlReader, options);
				}
			}
			return result;
		}

		/// <summary>Выводит этот документ <see cref="T:System.Xml.Linq.XDocument" /> в указанный поток <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="stream">Поток для вывода данного элемента <see cref="T:System.Xml.Linq.XDocument" />.</param>
		// Token: 0x06000186 RID: 390 RVA: 0x00007E58 File Offset: 0x00006058
		public void Save(Stream stream)
		{
			this.Save(stream, base.GetSaveOptionsFromAnnotations());
		}

		/// <summary>Выводит данный элемент <see cref="T:System.Xml.Linq.XDocument" /> в указанный поток <see cref="T:System.IO.Stream" />, при необходимости задавая поведение форматирования.</summary>
		/// <param name="stream">Поток для вывода данного элемента <see cref="T:System.Xml.Linq.XDocument" />.</param>
		/// <param name="options">Объект <see cref="T:System.Xml.Linq.SaveOptions" />, указывающий поведение форматирования.</param>
		// Token: 0x06000187 RID: 391 RVA: 0x00007E68 File Offset: 0x00006068
		public void Save(Stream stream, SaveOptions options)
		{
			XmlWriterSettings xmlWriterSettings = XNode.GetXmlWriterSettings(options);
			if (this._declaration != null && !string.IsNullOrEmpty(this._declaration.Encoding))
			{
				try
				{
					xmlWriterSettings.Encoding = Encoding.GetEncoding(this._declaration.Encoding);
				}
				catch (ArgumentException)
				{
				}
			}
			using (XmlWriter xmlWriter = XmlWriter.Create(stream, xmlWriterSettings))
			{
				this.Save(xmlWriter);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00007EE8 File Offset: 0x000060E8
		public Task SaveAsync(Stream stream, SaveOptions options, CancellationToken cancellationToken)
		{
			XDocument.<SaveAsync>d__31 <SaveAsync>d__;
			<SaveAsync>d__.<>4__this = this;
			<SaveAsync>d__.stream = stream;
			<SaveAsync>d__.options = options;
			<SaveAsync>d__.cancellationToken = cancellationToken;
			<SaveAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SaveAsync>d__.<>1__state = -1;
			<SaveAsync>d__.<>t__builder.Start<XDocument.<SaveAsync>d__31>(ref <SaveAsync>d__);
			return <SaveAsync>d__.<>t__builder.Task;
		}

		/// <summary>Сериализует данный документ <see cref="T:System.Xml.Linq.XDocument" /> в <see cref="T:System.IO.TextWriter" />.</summary>
		/// <param name="textWriter">Объект <see cref="T:System.IO.TextWriter" />, в который будет записан элемент <see cref="T:System.Xml.Linq.XDocument" />.</param>
		// Token: 0x06000189 RID: 393 RVA: 0x00007F43 File Offset: 0x00006143
		public void Save(TextWriter textWriter)
		{
			this.Save(textWriter, base.GetSaveOptionsFromAnnotations());
		}

		/// <summary>Сериализует данный документ <see cref="T:System.Xml.Linq.XDocument" /> в <see cref="T:System.IO.TextWriter" />, при необходимости выключая форматирование.</summary>
		/// <param name="textWriter">
		///   <see cref="T:System.IO.TextWriter" />, в который выводится XML.</param>
		/// <param name="options">Объект <see cref="T:System.Xml.Linq.SaveOptions" />, указывающий поведение форматирования.</param>
		// Token: 0x0600018A RID: 394 RVA: 0x00007F54 File Offset: 0x00006154
		public void Save(TextWriter textWriter, SaveOptions options)
		{
			XmlWriterSettings xmlWriterSettings = XNode.GetXmlWriterSettings(options);
			using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, xmlWriterSettings))
			{
				this.Save(xmlWriter);
			}
		}

		/// <summary>Сериализует данный документ <see cref="T:System.Xml.Linq.XDocument" /> в <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />, в который будет записан элемент <see cref="T:System.Xml.Linq.XDocument" />.</param>
		// Token: 0x0600018B RID: 395 RVA: 0x00007F94 File Offset: 0x00006194
		public void Save(XmlWriter writer)
		{
			this.WriteTo(writer);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007FA0 File Offset: 0x000061A0
		public Task SaveAsync(TextWriter textWriter, SaveOptions options, CancellationToken cancellationToken)
		{
			XDocument.<SaveAsync>d__35 <SaveAsync>d__;
			<SaveAsync>d__.<>4__this = this;
			<SaveAsync>d__.textWriter = textWriter;
			<SaveAsync>d__.options = options;
			<SaveAsync>d__.cancellationToken = cancellationToken;
			<SaveAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SaveAsync>d__.<>1__state = -1;
			<SaveAsync>d__.<>t__builder.Start<XDocument.<SaveAsync>d__35>(ref <SaveAsync>d__);
			return <SaveAsync>d__.<>t__builder.Task;
		}

		/// <summary>Необходимо сериализовать этот объект <see cref="T:System.Xml.Linq.XDocument" /> в файл, перезаписывая существующий файл, если имеется.</summary>
		/// <param name="fileName">Строка, которая содержит имя файла.</param>
		// Token: 0x0600018D RID: 397 RVA: 0x00007FFB File Offset: 0x000061FB
		public void Save(string fileName)
		{
			this.Save(fileName, base.GetSaveOptionsFromAnnotations());
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000800A File Offset: 0x0000620A
		public Task SaveAsync(XmlWriter writer, CancellationToken cancellationToken)
		{
			return this.WriteToAsync(writer, cancellationToken);
		}

		/// <summary>Сериализует данный <see cref="T:System.Xml.Linq.XDocument" /> в файл, при необходимости выключая форматирование.</summary>
		/// <param name="fileName">Строка, которая содержит имя файла.</param>
		/// <param name="options">Объект <see cref="T:System.Xml.Linq.SaveOptions" />, указывающий поведение форматирования.</param>
		// Token: 0x0600018F RID: 399 RVA: 0x00008014 File Offset: 0x00006214
		public void Save(string fileName, SaveOptions options)
		{
			XmlWriterSettings xmlWriterSettings = XNode.GetXmlWriterSettings(options);
			if (this._declaration != null && !string.IsNullOrEmpty(this._declaration.Encoding))
			{
				try
				{
					xmlWriterSettings.Encoding = Encoding.GetEncoding(this._declaration.Encoding);
				}
				catch (ArgumentException)
				{
				}
			}
			using (XmlWriter xmlWriter = XmlWriter.Create(fileName, xmlWriterSettings))
			{
				this.Save(xmlWriter);
			}
		}

		/// <summary>Записывает данный документ в <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />, в который данный метод будет выполнять запись.</param>
		// Token: 0x06000190 RID: 400 RVA: 0x00008094 File Offset: 0x00006294
		public override void WriteTo(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (this._declaration != null && this._declaration.Standalone == "yes")
			{
				writer.WriteStartDocument(true);
			}
			else if (this._declaration != null && this._declaration.Standalone == "no")
			{
				writer.WriteStartDocument(false);
			}
			else
			{
				writer.WriteStartDocument();
			}
			base.WriteContentTo(writer);
			writer.WriteEndDocument();
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00008112 File Offset: 0x00006312
		public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			return this.WriteToAsyncInternal(writer, cancellationToken);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000813C File Offset: 0x0000633C
		private Task WriteToAsyncInternal(XmlWriter writer, CancellationToken cancellationToken)
		{
			XDocument.<WriteToAsyncInternal>d__41 <WriteToAsyncInternal>d__;
			<WriteToAsyncInternal>d__.<>4__this = this;
			<WriteToAsyncInternal>d__.writer = writer;
			<WriteToAsyncInternal>d__.cancellationToken = cancellationToken;
			<WriteToAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteToAsyncInternal>d__.<>1__state = -1;
			<WriteToAsyncInternal>d__.<>t__builder.Start<XDocument.<WriteToAsyncInternal>d__41>(ref <WriteToAsyncInternal>d__);
			return <WriteToAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000818F File Offset: 0x0000638F
		internal override void AddAttribute(XAttribute a)
		{
			throw new ArgumentException("An attribute cannot be added to content.");
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000818F File Offset: 0x0000638F
		internal override void AddAttributeSkipNotify(XAttribute a)
		{
			throw new ArgumentException("An attribute cannot be added to content.");
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000819B File Offset: 0x0000639B
		internal override XNode CloneNode()
		{
			return new XDocument(this);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000081A4 File Offset: 0x000063A4
		internal override bool DeepEquals(XNode node)
		{
			XDocument xdocument = node as XDocument;
			return xdocument != null && base.ContentsEqual(xdocument);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000081C4 File Offset: 0x000063C4
		internal override int GetDeepHashCode()
		{
			return base.ContentsHashCode();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000081CC File Offset: 0x000063CC
		private T GetFirstNode<T>() where T : XNode
		{
			XNode xnode = this.content as XNode;
			if (xnode != null)
			{
				T t;
				for (;;)
				{
					xnode = xnode.next;
					t = (xnode as T);
					if (t != null)
					{
						break;
					}
					if (xnode == this.content)
					{
						goto IL_35;
					}
				}
				return t;
			}
			IL_35:
			return default(T);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00008218 File Offset: 0x00006418
		internal static bool IsWhitespace(string s)
		{
			foreach (char c in s)
			{
				if (c != ' ' && c != '\t' && c != '\r' && c != '\n')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00008258 File Offset: 0x00006458
		internal override void ValidateNode(XNode node, XNode previous)
		{
			XmlNodeType nodeType = node.NodeType;
			switch (nodeType)
			{
			case XmlNodeType.Element:
				this.ValidateDocument(previous, XmlNodeType.DocumentType, XmlNodeType.None);
				return;
			case XmlNodeType.Attribute:
				return;
			case XmlNodeType.Text:
				this.ValidateString(((XText)node).Value);
				return;
			case XmlNodeType.CDATA:
				throw new ArgumentException(SR.Format("A node of type {0} cannot be added to content.", XmlNodeType.CDATA));
			default:
				if (nodeType == XmlNodeType.Document)
				{
					throw new ArgumentException(SR.Format("A node of type {0} cannot be added to content.", XmlNodeType.Document));
				}
				if (nodeType != XmlNodeType.DocumentType)
				{
					return;
				}
				this.ValidateDocument(previous, XmlNodeType.None, XmlNodeType.Element);
				return;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000082E4 File Offset: 0x000064E4
		private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter)
		{
			XNode xnode = this.content as XNode;
			if (xnode != null)
			{
				if (previous == null)
				{
					allowBefore = allowAfter;
				}
				for (;;)
				{
					xnode = xnode.next;
					XmlNodeType nodeType = xnode.NodeType;
					if (nodeType == XmlNodeType.Element || nodeType == XmlNodeType.DocumentType)
					{
						if (nodeType != allowBefore)
						{
							break;
						}
						allowBefore = XmlNodeType.None;
					}
					if (xnode == previous)
					{
						allowBefore = allowAfter;
					}
					if (xnode == this.content)
					{
						return;
					}
				}
				throw new InvalidOperationException("This operation would create an incorrectly structured document.");
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000833F File Offset: 0x0000653F
		internal override void ValidateString(string s)
		{
			if (!XDocument.IsWhitespace(s))
			{
				throw new ArgumentException("Non-whitespace characters cannot be added to content.");
			}
		}

		// Token: 0x040000C8 RID: 200
		private XDeclaration _declaration;
	}
}
