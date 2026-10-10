using System;
using System.Xml.Linq;

namespace System.Xml.Schema
{
	/// <summary>Этот класс содержит методы расширения LINQ to XML для проверки XSD.</summary>
	// Token: 0x0200000E RID: 14
	public static class Extensions
	{
		/// <summary>Получает набор сведений после проверки схемы (PSVI) для проверенного элемента.</summary>
		/// <param name="source">Ранее проверенный <see cref="T:System.Xml.Linq.XElement" />.</param>
		/// <returns>
		///   <see cref="T:System.Xml.Schema.IXmlSchemaInfo" />, содержащий набор сведений после проверки схемы для <see cref="T:System.Xml.Linq.XElement" />.</returns>
		// Token: 0x0600006B RID: 107 RVA: 0x00003E3E File Offset: 0x0000203E
		public static IXmlSchemaInfo GetSchemaInfo(this XElement source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return source.Annotation<IXmlSchemaInfo>();
		}

		/// <summary>Получает набор сведений после проверки схемы (PSVI) для проверенного атрибута.</summary>
		/// <param name="source">Ранее проверенный <see cref="T:System.Xml.Linq.XAttribute" />.</param>
		/// <returns>
		///   <see cref="T:System.Xml.Schema.IXmlSchemaInfo" />, содержащий набор сведений после проверки схемы для <see cref="T:System.Xml.Linq.XAttribute" />.</returns>
		// Token: 0x0600006C RID: 108 RVA: 0x00003E3E File Offset: 0x0000203E
		public static IXmlSchemaInfo GetSchemaInfo(this XAttribute source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return source.Annotation<IXmlSchemaInfo>();
		}

		/// <summary>Этот метод проверяет соответствие <see cref="T:System.Xml.Linq.XDocument" /> спецификации XSD в <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="source">Объект <see cref="T:System.Xml.Linq.XDocument" /> для проверки.</param>
		/// <param name="schemas">
		///   <see cref="T:System.Xml.Schema.XmlSchemaSet" /> для проверки на соответствие.</param>
		/// <param name="validationEventHandler">
		///   <see cref="T:System.Xml.Schema.ValidationEventHandler" /> для события, которое происходит, когда читатель встречает ошибки проверки. При значении <see langword="null" /> генерируется исключение возникновения ошибок проверки.</param>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">Генерируется для ошибок проверки XSD.</exception>
		// Token: 0x0600006D RID: 109 RVA: 0x00003E54 File Offset: 0x00002054
		public static void Validate(this XDocument source, XmlSchemaSet schemas, ValidationEventHandler validationEventHandler)
		{
			source.Validate(schemas, validationEventHandler, false);
		}

		/// <summary>Проверяет <see cref="T:System.Xml.Linq.XDocument" /> на соответствие XSD в <see cref="T:System.Xml.Schema.XmlSchemaSet" /> с возможностью заполнения дерева XML набором сведений после проверки схемы (PSVI).</summary>
		/// <param name="source">Объект <see cref="T:System.Xml.Linq.XDocument" /> для проверки.</param>
		/// <param name="schemas">
		///   <see cref="T:System.Xml.Schema.XmlSchemaSet" /> для проверки на соответствие.</param>
		/// <param name="validationEventHandler">
		///   <see cref="T:System.Xml.Schema.ValidationEventHandler" /> для события, которое происходит, когда читатель встречает ошибки проверки. При значении <see langword="null" /> генерируется исключение возникновения ошибок проверки.</param>
		/// <param name="addSchemaInfo">
		///   <see cref="T:System.Boolean" />, указывающий, требуется ли заполнение набором сведений после проверки схемы (PSVI).</param>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">Генерируется для ошибок проверки XSD.</exception>
		// Token: 0x0600006E RID: 110 RVA: 0x00003E5F File Offset: 0x0000205F
		public static void Validate(this XDocument source, XmlSchemaSet schemas, ValidationEventHandler validationEventHandler, bool addSchemaInfo)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (schemas == null)
			{
				throw new ArgumentNullException("schemas");
			}
			new XNodeValidator(schemas, validationEventHandler).Validate(source, null, addSchemaInfo);
		}

		/// <summary>Этот метод проверяет поддерево <see cref="T:System.Xml.Linq.XElement" /> на соответствие указанным <see cref="T:System.Xml.Schema.XmlSchemaObject" /> и <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="source">Объект <see cref="T:System.Xml.Linq.XElement" /> для проверки.</param>
		/// <param name="partialValidationType">
		///   <see cref="T:System.Xml.Schema.XmlSchemaObject" />, задающий проверяемое поддерево.</param>
		/// <param name="schemas">
		///   <see cref="T:System.Xml.Schema.XmlSchemaSet" /> для проверки на соответствие.</param>
		/// <param name="validationEventHandler">
		///   <see cref="T:System.Xml.Schema.ValidationEventHandler" /> для события, которое происходит, когда читатель встречает ошибки проверки. При значении <see langword="null" /> генерируется исключение возникновения ошибок проверки.</param>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">Генерируется для ошибок проверки XSD.</exception>
		// Token: 0x0600006F RID: 111 RVA: 0x00003E8C File Offset: 0x0000208C
		public static void Validate(this XElement source, XmlSchemaObject partialValidationType, XmlSchemaSet schemas, ValidationEventHandler validationEventHandler)
		{
			source.Validate(partialValidationType, schemas, validationEventHandler, false);
		}

		/// <summary>Проверяет поддерево <see cref="T:System.Xml.Linq.XElement" /> на соответствие указанным <see cref="T:System.Xml.Schema.XmlSchemaObject" /> и <see cref="T:System.Xml.Schema.XmlSchemaSet" />, с возможностью заполнения дерева XML набором сведений после проверки схемы (PSVI).</summary>
		/// <param name="source">Объект <see cref="T:System.Xml.Linq.XElement" /> для проверки.</param>
		/// <param name="partialValidationType">
		///   <see cref="T:System.Xml.Schema.XmlSchemaObject" />, задающий проверяемое поддерево.</param>
		/// <param name="schemas">
		///   <see cref="T:System.Xml.Schema.XmlSchemaSet" /> для проверки на соответствие.</param>
		/// <param name="validationEventHandler">
		///   <see cref="T:System.Xml.Schema.ValidationEventHandler" /> для события, которое происходит, когда читатель встречает ошибки проверки. При значении <see langword="null" /> генерируется исключение возникновения ошибок проверки.</param>
		/// <param name="addSchemaInfo">
		///   <see cref="T:System.Boolean" />, указывающий, требуется ли заполнение набором сведений после проверки схемы (PSVI).</param>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">Генерируется для ошибок проверки XSD.</exception>
		// Token: 0x06000070 RID: 112 RVA: 0x00003E98 File Offset: 0x00002098
		public static void Validate(this XElement source, XmlSchemaObject partialValidationType, XmlSchemaSet schemas, ValidationEventHandler validationEventHandler, bool addSchemaInfo)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (partialValidationType == null)
			{
				throw new ArgumentNullException("partialValidationType");
			}
			if (schemas == null)
			{
				throw new ArgumentNullException("schemas");
			}
			new XNodeValidator(schemas, validationEventHandler).Validate(source, partialValidationType, addSchemaInfo);
		}

		/// <summary>Этот метод проверяет <see cref="T:System.Xml.Linq.XAttribute" /> на соответствие указанным <see cref="T:System.Xml.Schema.XmlSchemaObject" /> и <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="source">Объект <see cref="T:System.Xml.Linq.XAttribute" /> для проверки.</param>
		/// <param name="partialValidationType">
		///   <see cref="T:System.Xml.Schema.XmlSchemaObject" />, задающий проверяемое поддерево.</param>
		/// <param name="schemas">
		///   <see cref="T:System.Xml.Schema.XmlSchemaSet" /> для проверки на соответствие.</param>
		/// <param name="validationEventHandler">
		///   <see cref="T:System.Xml.Schema.ValidationEventHandler" /> для события, которое происходит, когда читатель встречает ошибки проверки. При значении <see langword="null" /> генерируется исключение возникновения ошибок проверки.</param>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">Генерируется для ошибок проверки XSD.</exception>
		// Token: 0x06000071 RID: 113 RVA: 0x00003ED4 File Offset: 0x000020D4
		public static void Validate(this XAttribute source, XmlSchemaObject partialValidationType, XmlSchemaSet schemas, ValidationEventHandler validationEventHandler)
		{
			source.Validate(partialValidationType, schemas, validationEventHandler, false);
		}

		/// <summary>Проверяет <see cref="T:System.Xml.Linq.XAttribute" /> на соответствие указанным <see cref="T:System.Xml.Schema.XmlSchemaObject" /> и <see cref="T:System.Xml.Schema.XmlSchemaSet" />, с возможностью заполнения дерева XML набором сведений после проверки схемы (PSVI).</summary>
		/// <param name="source">Объект <see cref="T:System.Xml.Linq.XAttribute" /> для проверки.</param>
		/// <param name="partialValidationType">
		///   <see cref="T:System.Xml.Schema.XmlSchemaObject" />, задающий проверяемое поддерево.</param>
		/// <param name="schemas">
		///   <see cref="T:System.Xml.Schema.XmlSchemaSet" /> для проверки на соответствие.</param>
		/// <param name="validationEventHandler">
		///   <see cref="T:System.Xml.Schema.ValidationEventHandler" /> для события, которое происходит, когда читатель встречает ошибки проверки. При значении <see langword="null" /> генерируется исключение возникновения ошибок проверки.</param>
		/// <param name="addSchemaInfo">
		///   <see cref="T:System.Boolean" />, указывающий, требуется ли заполнение набором сведений после проверки схемы (PSVI).</param>
		/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">Генерируется для ошибок проверки XSD.</exception>
		// Token: 0x06000072 RID: 114 RVA: 0x00003E98 File Offset: 0x00002098
		public static void Validate(this XAttribute source, XmlSchemaObject partialValidationType, XmlSchemaSet schemas, ValidationEventHandler validationEventHandler, bool addSchemaInfo)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (partialValidationType == null)
			{
				throw new ArgumentNullException("partialValidationType");
			}
			if (schemas == null)
			{
				throw new ArgumentNullException("schemas");
			}
			new XNodeValidator(schemas, validationEventHandler).Validate(source, partialValidationType, addSchemaInfo);
		}
	}
}
