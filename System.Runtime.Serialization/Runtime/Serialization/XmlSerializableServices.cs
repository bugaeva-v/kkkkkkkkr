using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;

namespace System.Runtime.Serialization
{
	/// <summary>Содержит методы для чтения и записи XML.</summary>
	// Token: 0x02000150 RID: 336
	public static class XmlSerializableServices
	{
		/// <summary>Считывает набор узлов XML из указанного средства чтения и возвращает результат.</summary>
		/// <param name="xmlReader">Объект <see cref="T:System.Xml.XmlReader" />, используемый для чтения.</param>
		/// <returns>Массив типа <see cref="T:System.Xml.XmlNode" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="xmlReader" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">При считывании был обнаружен узел со значением <see langword="null" />.</exception>
		// Token: 0x0600118B RID: 4491 RVA: 0x00044DD0 File Offset: 0x00042FD0
		public static XmlNode[] ReadNodes(XmlReader xmlReader)
		{
			if (xmlReader == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("xmlReader");
			}
			XmlDocument xmlDocument = new XmlDocument();
			List<XmlNode> list = new List<XmlNode>();
			if (xmlReader.MoveToFirstAttribute())
			{
				for (;;)
				{
					if (XmlSerializableServices.IsValidAttribute(xmlReader))
					{
						XmlNode xmlNode = xmlDocument.ReadNode(xmlReader);
						if (xmlNode == null)
						{
							break;
						}
						list.Add(xmlNode);
					}
					if (!xmlReader.MoveToNextAttribute())
					{
						goto IL_59;
					}
				}
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(XmlObjectSerializer.CreateSerializationException(SR.GetString("Unexpected end of file.")));
			}
			IL_59:
			xmlReader.MoveToElement();
			if (!xmlReader.IsEmptyElement)
			{
				int depth = xmlReader.Depth;
				xmlReader.Read();
				while (xmlReader.Depth > depth && xmlReader.NodeType != XmlNodeType.EndElement)
				{
					XmlNode xmlNode2 = xmlDocument.ReadNode(xmlReader);
					if (xmlNode2 == null)
					{
						throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(XmlObjectSerializer.CreateSerializationException(SR.GetString("Unexpected end of file.")));
					}
					list.Add(xmlNode2);
				}
			}
			return list.ToArray();
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00044E98 File Offset: 0x00043098
		private static bool IsValidAttribute(XmlReader xmlReader)
		{
			return xmlReader.NamespaceURI != "http://schemas.microsoft.com/2003/10/Serialization/" && xmlReader.NamespaceURI != "http://www.w3.org/2001/XMLSchema-instance" && xmlReader.Prefix != "xmlns" && xmlReader.LocalName != "xmlns";
		}

		/// <summary>Выполняет запись предоставленных узлов с помощью указанного средства записи.</summary>
		/// <param name="xmlWriter">Объект <see cref="T:System.Xml.XmlWriter" />, используемый для записи.</param>
		/// <param name="nodes">Массив типа <see cref="T:System.Xml.XmlNode" />, который требуется записать.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="xmlWriter" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600118D RID: 4493 RVA: 0x00044EF0 File Offset: 0x000430F0
		public static void WriteNodes(XmlWriter xmlWriter, XmlNode[] nodes)
		{
			if (xmlWriter == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("xmlWriter");
			}
			if (nodes != null)
			{
				for (int i = 0; i < nodes.Length; i++)
				{
					if (nodes[i] != null)
					{
						nodes[i].WriteTo(xmlWriter);
					}
				}
			}
		}

		/// <summary>Создает тип схемы по умолчанию с заданным именем типа и добавляет ее в указанный набор схем.</summary>
		/// <param name="schemas">Объект <see cref="T:System.Xml.Schema.XmlSchemaSet" />, в который добавляется созданный тип схемы.</param>
		/// <param name="typeQName">Объект <see cref="T:System.Xml.XmlQualifiedName" />, указывающий имя типа, которому присваивается схема.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="schemas" /> или аргумент <paramref name="typeQName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600118E RID: 4494 RVA: 0x00044F2A File Offset: 0x0004312A
		public static void AddDefaultSchema(XmlSchemaSet schemas, XmlQualifiedName typeQName)
		{
			if (schemas == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("schemas");
			}
			if (typeQName == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("typeQName");
			}
			SchemaExporter.AddDefaultXmlType(schemas, typeQName.Name, typeQName.Namespace);
		}

		// Token: 0x0400072C RID: 1836
		internal static readonly string ReadNodesMethodName = "ReadNodes";

		// Token: 0x0400072D RID: 1837
		internal static string WriteNodesMethodName = "WriteNodes";

		// Token: 0x0400072E RID: 1838
		internal static string AddDefaultSchemaMethodName = "AddDefaultSchema";
	}
}
