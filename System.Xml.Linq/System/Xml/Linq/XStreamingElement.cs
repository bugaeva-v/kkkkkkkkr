using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace System.Xml.Linq
{
	/// <summary>Представляет элементы в дереве XML, поддерживающем отложенный потоковый выход.</summary>
	// Token: 0x02000060 RID: 96
	public class XStreamingElement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Xml.Linq.XElement" /> из указанного потока <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <param name="name">
		///   <see cref="T:System.Xml.Linq.XName" />, содержащий имя элемента.</param>
		// Token: 0x0600039A RID: 922 RVA: 0x0001036E File Offset: 0x0000E56E
		public XStreamingElement(XName name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			this.name = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Xml.Linq.XStreamingElement" /> с указанными именем и содержимым.</summary>
		/// <param name="name">
		///   <see cref="T:System.Xml.Linq.XName" />, содержащий имя элемента.</param>
		/// <param name="content">Содержимое элемента.</param>
		// Token: 0x0600039B RID: 923 RVA: 0x00010391 File Offset: 0x0000E591
		public XStreamingElement(XName name, object content) : this(name)
		{
			object obj;
			if (!(content is List<object>))
			{
				obj = content;
			}
			else
			{
				(obj = new object[1])[0] = content;
			}
			this.content = obj;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Xml.Linq.XStreamingElement" /> с указанными именем и содержимым.</summary>
		/// <param name="name">
		///   <see cref="T:System.Xml.Linq.XName" />, содержащий имя элемента.</param>
		/// <param name="content">Содержимое элемента.</param>
		// Token: 0x0600039C RID: 924 RVA: 0x000103B5 File Offset: 0x0000E5B5
		public XStreamingElement(XName name, params object[] content) : this(name)
		{
			this.content = content;
		}

		/// <summary>Получает или задает имя данного потокового элемента.</summary>
		/// <returns>Объект <see cref="T:System.Xml.Linq.XName" />, содержащий имя данного потокового элемента.</returns>
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600039D RID: 925 RVA: 0x000103C5 File Offset: 0x0000E5C5
		// (set) Token: 0x0600039E RID: 926 RVA: 0x000103CD File Offset: 0x0000E5CD
		public XName Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.name = value;
			}
		}

		/// <summary>Добавляет указанное содержимое в качестве дочерних элементов в данный объект <see cref="T:System.Xml.Linq.XStreamingElement" />.</summary>
		/// <param name="content">Содержимое для добавления к потоковому элементу.</param>
		// Token: 0x0600039F RID: 927 RVA: 0x000103EC File Offset: 0x0000E5EC
		public void Add(object content)
		{
			if (content != null)
			{
				List<object> list = this.content as List<object>;
				if (list == null)
				{
					list = new List<object>();
					if (this.content != null)
					{
						list.Add(this.content);
					}
					this.content = list;
				}
				list.Add(content);
			}
		}

		/// <summary>Добавляет указанное содержимое в качестве дочерних элементов в данный объект <see cref="T:System.Xml.Linq.XStreamingElement" />.</summary>
		/// <param name="content">Содержимое для добавления к потоковому элементу.</param>
		// Token: 0x060003A0 RID: 928 RVA: 0x00010433 File Offset: 0x0000E633
		public void Add(params object[] content)
		{
			this.Add(content);
		}

		/// <summary>Выводит этот документ <see cref="T:System.Xml.Linq.XStreamingElement" /> в указанный поток <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="stream">Поток для вывода данного элемента <see cref="T:System.Xml.Linq.XDocument" />.</param>
		// Token: 0x060003A1 RID: 929 RVA: 0x0001043C File Offset: 0x0000E63C
		public void Save(Stream stream)
		{
			this.Save(stream, SaveOptions.None);
		}

		/// <summary>Выводит данный элемент <see cref="T:System.Xml.Linq.XStreamingElement" /> в указанный поток <see cref="T:System.IO.Stream" />, при необходимости задавая поведение форматирования.</summary>
		/// <param name="stream">Поток для вывода данного элемента <see cref="T:System.Xml.Linq.XDocument" />.</param>
		/// <param name="options">Объект <see cref="T:System.Xml.Linq.SaveOptions" />, определяющий форматирование.</param>
		// Token: 0x060003A2 RID: 930 RVA: 0x00010448 File Offset: 0x0000E648
		public void Save(Stream stream, SaveOptions options)
		{
			XmlWriterSettings xmlWriterSettings = XNode.GetXmlWriterSettings(options);
			using (XmlWriter xmlWriter = XmlWriter.Create(stream, xmlWriterSettings))
			{
				this.Save(xmlWriter);
			}
		}

		/// <summary>Сериализует данный потоковый элемент в <see cref="T:System.IO.TextWriter" />.</summary>
		/// <param name="textWriter">Объект <see cref="T:System.IO.TextWriter" />, в который будет записан элемент <see cref="T:System.Xml.Linq.XStreamingElement" />.</param>
		// Token: 0x060003A3 RID: 931 RVA: 0x00010488 File Offset: 0x0000E688
		public void Save(TextWriter textWriter)
		{
			this.Save(textWriter, SaveOptions.None);
		}

		/// <summary>Сериализует данный потоковый элемент в объект <see cref="T:System.IO.TextWriter" />, дополнительно отключая форматирование.</summary>
		/// <param name="textWriter">
		///   <see cref="T:System.IO.TextWriter" />, в который выводится XML.</param>
		/// <param name="options">Объект <see cref="T:System.Xml.Linq.SaveOptions" />, указывающий поведение форматирования.</param>
		// Token: 0x060003A4 RID: 932 RVA: 0x00010494 File Offset: 0x0000E694
		public void Save(TextWriter textWriter, SaveOptions options)
		{
			XmlWriterSettings xmlWriterSettings = XNode.GetXmlWriterSettings(options);
			using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, xmlWriterSettings))
			{
				this.Save(xmlWriter);
			}
		}

		/// <summary>Сериализует данный потоковый элемент в объект <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />, в который будет записан элемент <see cref="T:System.Xml.Linq.XElement" />.</param>
		// Token: 0x060003A5 RID: 933 RVA: 0x000104D4 File Offset: 0x0000E6D4
		public void Save(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			writer.WriteStartDocument();
			this.WriteTo(writer);
			writer.WriteEndDocument();
		}

		/// <summary>Сериализует данный потоковый элемент в файл.</summary>
		/// <param name="fileName">Объект <see cref="T:System.String" />, содержащий имя файла.</param>
		// Token: 0x060003A6 RID: 934 RVA: 0x000104F7 File Offset: 0x0000E6F7
		public void Save(string fileName)
		{
			this.Save(fileName, SaveOptions.None);
		}

		/// <summary>Сериализует данный потоковый элемент в файл, дополнительно отключая форматирование.</summary>
		/// <param name="fileName">Объект <see cref="T:System.String" />, содержащий имя файла.</param>
		/// <param name="options">Объект <see cref="T:System.Xml.Linq.SaveOptions" />, определяющий форматирование.</param>
		// Token: 0x060003A7 RID: 935 RVA: 0x00010504 File Offset: 0x0000E704
		public void Save(string fileName, SaveOptions options)
		{
			XmlWriterSettings xmlWriterSettings = XNode.GetXmlWriterSettings(options);
			using (XmlWriter xmlWriter = XmlWriter.Create(fileName, xmlWriterSettings))
			{
				this.Save(xmlWriter);
			}
		}

		/// <summary>Возвращает форматированный (с отступом) XML для данного потокового элемента.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий XML с отступами.</returns>
		// Token: 0x060003A8 RID: 936 RVA: 0x00010544 File Offset: 0x0000E744
		public override string ToString()
		{
			return this.GetXmlString(SaveOptions.None);
		}

		/// <summary>Возвращает XML для данного потокового элемента, дополнительно отключая форматирование.</summary>
		/// <param name="options">Объект <see cref="T:System.Xml.Linq.SaveOptions" />, указывающий поведение форматирования.</param>
		/// <returns>Объект <see cref="T:System.String" />, содержащий XML.</returns>
		// Token: 0x060003A9 RID: 937 RVA: 0x0001054D File Offset: 0x0000E74D
		public string ToString(SaveOptions options)
		{
			return this.GetXmlString(options);
		}

		/// <summary>Записывает данный потоковый элемент в объект <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">Объект <see cref="T:System.Xml.XmlWriter" />, в который данный метод будет выполнять запись.</param>
		// Token: 0x060003AA RID: 938 RVA: 0x00010558 File Offset: 0x0000E758
		public void WriteTo(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			new StreamingElementWriter(writer).WriteStreamingElement(this);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00010584 File Offset: 0x0000E784
		private string GetXmlString(SaveOptions o)
		{
			string result;
			using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
			{
				XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
				xmlWriterSettings.OmitXmlDeclaration = true;
				if ((o & SaveOptions.DisableFormatting) == SaveOptions.None)
				{
					xmlWriterSettings.Indent = true;
				}
				if ((o & SaveOptions.OmitDuplicateNamespaces) != SaveOptions.None)
				{
					xmlWriterSettings.NamespaceHandling |= NamespaceHandling.OmitDuplicates;
				}
				using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings))
				{
					this.WriteTo(xmlWriter);
				}
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x040001E0 RID: 480
		internal XName name;

		// Token: 0x040001E1 RID: 481
		internal object content;
	}
}
