using System;
using System.Data.Common;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Представляет XML-данные, сохраняемые на сервере или извлекаемые с него.</summary>
	// Token: 0x02000320 RID: 800
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public sealed class SqlXml : INullable, IXmlSerializable
	{
		/// <summary>Создает новый экземпляр <see cref="T:System.Data.SqlTypes.SqlXml" />.</summary>
		// Token: 0x060025FB RID: 9723 RVA: 0x000A96A7 File Offset: 0x000A78A7
		public SqlXml()
		{
			this.SetNull();
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x000A96A7 File Offset: 0x000A78A7
		private SqlXml(bool fNull)
		{
			this.SetNull();
		}

		/// <summary>Создает новый экземпляр <see cref="T:System.Data.SqlTypes.SqlXml" /> и связывает его с содержимым предоставленного <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <param name="value">Экземпляр производного класса, полученного из <see cref="T:System.Xml.XmlReader" />, который требуется использовать в качестве значения нового экземпляра <see cref="T:System.Data.SqlTypes.SqlXml" />.</param>
		// Token: 0x060025FD RID: 9725 RVA: 0x000A96B5 File Offset: 0x000A78B5
		public SqlXml(XmlReader value)
		{
			if (value == null)
			{
				this.SetNull();
				return;
			}
			this._fNotNull = true;
			this._firstCreateReader = true;
			this._stream = this.CreateMemoryStreamFromXmlReader(value);
		}

		/// <summary>Создает новый экземпляр <see cref="T:System.Data.SqlTypes.SqlXml" />, получая XML-значение из полученного производного экземпляра <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="value">Производный экземпляр <see cref="T:System.IO.Stream" /> (например, <see cref="T:System.IO.FileStream" />), из которого следует загрузить XML-содержимое экземпляра <see cref="T:System.Data.SqlTypes.SqlXml" />.</param>
		// Token: 0x060025FE RID: 9726 RVA: 0x000A96E2 File Offset: 0x000A78E2
		public SqlXml(Stream value)
		{
			if (value == null)
			{
				this.SetNull();
				return;
			}
			this._firstCreateReader = true;
			this._fNotNull = true;
			this._stream = value;
		}

		/// <summary>Получает значение XML-содержимого данного экземпляра <see cref="T:System.Data.SqlTypes.SqlXml" /> в формате <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <returns>Производный экземпляр, полученный из <see cref="T:System.Xml.XmlReader" /> и содержащий XML-данные. Фактический тип может меняться (например, возвращаемое значение может быть в формате <see cref="T:System.Xml.XmlTextReader" />) в зависимости от внутреннего способа представления данных на сервере.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">Предпринята попытка получить доступ к этому свойству в неопределенном экземпляре <see cref="T:System.Data.SqlTypes.SqlXml" />.</exception>
		// Token: 0x060025FF RID: 9727 RVA: 0x000A970C File Offset: 0x000A790C
		public XmlReader CreateReader()
		{
			if (this.IsNull)
			{
				throw new SqlNullValueException();
			}
			SqlXmlStreamWrapper sqlXmlStreamWrapper = new SqlXmlStreamWrapper(this._stream);
			if ((!this._firstCreateReader || sqlXmlStreamWrapper.CanSeek) && sqlXmlStreamWrapper.Position != 0L)
			{
				sqlXmlStreamWrapper.Seek(0L, SeekOrigin.Begin);
			}
			if (this._createSqlReaderMethodInfo == null)
			{
				this._createSqlReaderMethodInfo = SqlXml.CreateSqlReaderMethodInfo;
			}
			XmlReader result = SqlXml.CreateSqlXmlReader(sqlXmlStreamWrapper, false, false);
			this._firstCreateReader = false;
			return result;
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x000A9780 File Offset: 0x000A7980
		internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = false, bool throwTargetInvocationExceptions = false)
		{
			XmlReaderSettings arg = closeInput ? SqlXml.s_defaultXmlReaderSettingsCloseInput : SqlXml.s_defaultXmlReaderSettings;
			XmlReader result;
			try
			{
				result = SqlXml.s_sqlReaderDelegate(stream, arg, null);
			}
			catch (Exception ex)
			{
				if (!throwTargetInvocationExceptions || !ADP.IsCatchableExceptionType(ex))
				{
					throw;
				}
				throw new TargetInvocationException(ex);
			}
			return result;
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x000A97D4 File Offset: 0x000A79D4
		private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate()
		{
			return (Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader>)SqlXml.CreateSqlReaderMethodInfo.CreateDelegate(typeof(Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader>));
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x000A97EF File Offset: 0x000A79EF
		private static MethodInfo CreateSqlReaderMethodInfo
		{
			get
			{
				if (SqlXml.s_createSqlReaderMethodInfo == null)
				{
					SqlXml.s_createSqlReaderMethodInfo = typeof(XmlReader).GetMethod("CreateSqlReader", BindingFlags.Static | BindingFlags.NonPublic);
				}
				return SqlXml.s_createSqlReaderMethodInfo;
			}
		}

		/// <summary>Показывает, представляет ли данный экземпляр неопределенное значение <see cref="T:System.Data.SqlTypes.SqlXml" />.</summary>
		/// <returns>
		///   <see langword="true" />, если <see langword="Value" /> равно NULL. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x000A981E File Offset: 0x000A7A1E
		public bool IsNull
		{
			get
			{
				return !this._fNotNull;
			}
		}

		/// <summary>Получает строковое представление XML-содержимого данного экземпляра <see cref="T:System.Data.SqlTypes.SqlXml" />.</summary>
		/// <returns>Строковое представление XML-содержимого.</returns>
		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x000A982C File Offset: 0x000A7A2C
		public string Value
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				StringWriter stringWriter = new StringWriter(null);
				XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings
				{
					CloseOutput = false,
					ConformanceLevel = ConformanceLevel.Fragment
				});
				XmlReader xmlReader = this.CreateReader();
				if (xmlReader.ReadState == ReadState.Initial)
				{
					xmlReader.Read();
				}
				while (!xmlReader.EOF)
				{
					xmlWriter.WriteNode(xmlReader, true);
				}
				xmlWriter.Flush();
				return stringWriter.ToString();
			}
		}

		/// <summary>Представляет неопределенный экземпляр типа <see cref="T:System.Data.SqlTypes.SqlXml" />.</summary>
		/// <returns>Неопределенный экземпляр типа <see cref="T:System.Data.SqlTypes.SqlXml" />.</returns>
		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06002605 RID: 9733 RVA: 0x000A989E File Offset: 0x000A7A9E
		public static SqlXml Null
		{
			get
			{
				return new SqlXml(true);
			}
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x000A98A6 File Offset: 0x000A7AA6
		private void SetNull()
		{
			this._fNotNull = false;
			this._stream = null;
			this._firstCreateReader = true;
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x000A98C0 File Offset: 0x000A7AC0
		private Stream CreateMemoryStreamFromXmlReader(XmlReader reader)
		{
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.CloseOutput = false;
			xmlWriterSettings.ConformanceLevel = ConformanceLevel.Fragment;
			xmlWriterSettings.Encoding = Encoding.GetEncoding("utf-16");
			xmlWriterSettings.OmitXmlDeclaration = true;
			MemoryStream memoryStream = new MemoryStream();
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
			if (reader.ReadState == ReadState.Closed)
			{
				throw new InvalidOperationException(SQLResource.ClosedXmlReaderMessage);
			}
			if (reader.ReadState == ReadState.Initial)
			{
				reader.Read();
			}
			while (!reader.EOF)
			{
				xmlWriter.WriteNode(reader, true);
			}
			xmlWriter.Flush();
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return memoryStream;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.Xml.Serialization.IXmlSerializable.GetSchema" />.</summary>
		/// <returns>Схема <see cref="T:System.Xml.Schema.XmlSchema" />, описывающая представление XML объекта, полученного методом <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" /> и используемого методом <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" />.</returns>
		// Token: 0x06002608 RID: 9736 RVA: 0x00003E32 File Offset: 0x00002032
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" />.</summary>
		/// <param name="r">XmlReader.</param>
		// Token: 0x06002609 RID: 9737 RVA: 0x000A994C File Offset: 0x000A7B4C
		void IXmlSerializable.ReadXml(XmlReader r)
		{
			string attribute = r.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				r.ReadInnerXml();
				this.SetNull();
				return;
			}
			this._fNotNull = true;
			this._firstCreateReader = true;
			this._stream = new MemoryStream();
			StreamWriter streamWriter = new StreamWriter(this._stream);
			streamWriter.Write(r.ReadInnerXml());
			streamWriter.Flush();
			if (this._stream.CanSeek)
			{
				this._stream.Seek(0L, SeekOrigin.Begin);
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" />.</summary>
		/// <param name="writer">XmlWriter.</param>
		// Token: 0x0600260A RID: 9738 RVA: 0x000A99D4 File Offset: 0x000A7BD4
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
			}
			else
			{
				XmlReader xmlReader = this.CreateReader();
				if (xmlReader.ReadState == ReadState.Initial)
				{
					xmlReader.Read();
				}
				while (!xmlReader.EOF)
				{
					writer.WriteNode(xmlReader, true);
				}
			}
			writer.Flush();
		}

		/// <summary>Возвращает XSD (XML-схему) заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>Строка, указывающая определение XML-схемы заданного объекта <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x0600260B RID: 9739 RVA: 0x000A9A33 File Offset: 0x000A7C33
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("anyType", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x040018FF RID: 6399
		private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate = SqlXml.CreateSqlReaderDelegate();

		// Token: 0x04001900 RID: 6400
		private static readonly XmlReaderSettings s_defaultXmlReaderSettings = new XmlReaderSettings
		{
			ConformanceLevel = ConformanceLevel.Fragment
		};

		// Token: 0x04001901 RID: 6401
		private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput = new XmlReaderSettings
		{
			ConformanceLevel = ConformanceLevel.Fragment,
			CloseInput = true
		};

		// Token: 0x04001902 RID: 6402
		private static MethodInfo s_createSqlReaderMethodInfo;

		// Token: 0x04001903 RID: 6403
		private MethodInfo _createSqlReaderMethodInfo;

		// Token: 0x04001904 RID: 6404
		private bool _fNotNull;

		// Token: 0x04001905 RID: 6405
		private Stream _stream;

		// Token: 0x04001906 RID: 6406
		private bool _firstCreateReader;
	}
}
