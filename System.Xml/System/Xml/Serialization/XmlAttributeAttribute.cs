using System;
using System.Xml.Schema;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Указывает, что <see cref="T:System.Xml.Serialization.XmlSerializer" /> должен сериализовать член класса как атрибут XML.
	///       </summary>
	// Token: 0x020002C9 RID: 713
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class XmlAttributeAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlAttributeAttribute" />.
		///       </summary>
		// Token: 0x06001B1A RID: 6938 RVA: 0x000021EA File Offset: 0x000003EA
		public XmlAttributeAttribute()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlAttributeAttribute" /> и задает имя создаваемого атрибута XML.
		///       </summary>
		/// <param name="attributeName">
		///           Имя XML-атрибута, <see cref="T:System.Xml.Serialization.XmlSerializer" /> приводит к возникновению ошибки.
		///         </param>
		// Token: 0x06001B1B RID: 6939 RVA: 0x0009B70A File Offset: 0x0009990A
		public XmlAttributeAttribute(string attributeName)
		{
			this.attributeName = attributeName;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlAttributeAttribute" />.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Используется для хранения атрибутов.
		///         </param>
		// Token: 0x06001B1C RID: 6940 RVA: 0x0009B719 File Offset: 0x00099919
		public XmlAttributeAttribute(Type type)
		{
			this.type = type;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlAttributeAttribute" />.
		///       </summary>
		/// <param name="attributeName">
		///           Имя создаваемого атрибута XML.
		///         </param>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Используется для хранения атрибутов.
		///         </param>
		// Token: 0x06001B1D RID: 6941 RVA: 0x0009B728 File Offset: 0x00099928
		public XmlAttributeAttribute(string attributeName, Type type)
		{
			this.attributeName = attributeName;
			this.type = type;
		}

		/// <summary>
		///         Возвращает или задает сложный тип XML-атрибута.
		///       </summary>
		/// <returns>
		///         Тип XML-атрибута.
		///       </returns>
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x0009B73E File Offset: 0x0009993E
		// (set) Token: 0x06001B1F RID: 6943 RVA: 0x0009B746 File Offset: 0x00099946
		public Type Type
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}

		/// <summary>
		///         Возвращает или задает имя атрибута XML.
		///       </summary>
		/// <returns>
		///         Имя XML-атрибута.
		///          По умолчанию используется имя члена.
		///       </returns>
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x0009B74F File Offset: 0x0009994F
		// (set) Token: 0x06001B21 RID: 6945 RVA: 0x0009B765 File Offset: 0x00099965
		public string AttributeName
		{
			get
			{
				if (this.attributeName != null)
				{
					return this.attributeName;
				}
				return string.Empty;
			}
			set
			{
				this.attributeName = value;
			}
		}

		/// <summary>
		///         Возвращает или задает пространство имен XML атрибута XML.
		///       </summary>
		/// <returns>
		///         Пространство имен XML атрибута XML.
		///       </returns>
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x0009B76E File Offset: 0x0009996E
		// (set) Token: 0x06001B23 RID: 6947 RVA: 0x0009B776 File Offset: 0x00099976
		public string Namespace
		{
			get
			{
				return this.ns;
			}
			set
			{
				this.ns = value;
			}
		}

		/// <summary>
		///         Возвращает или задает тип данных XSD атрибута XML, созданного объектом <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </summary>
		/// <returns>
		///         Тип данных XSD (документ схемы XML), как определено документом консорциума World Wide Web (www.w3.org) с именем «XML Schema: DataTypes».
		///       </returns>
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0009B77F File Offset: 0x0009997F
		// (set) Token: 0x06001B25 RID: 6949 RVA: 0x0009B795 File Offset: 0x00099995
		public string DataType
		{
			get
			{
				if (this.dataType != null)
				{
					return this.dataType;
				}
				return string.Empty;
			}
			set
			{
				this.dataType = value;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, является ли имя атрибута XML, созданные <see cref="T:System.Xml.Serialization.XmlSerializer" /> полным.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.Schema.XmlSchemaForm" />.
		///          Значение по умолчанию — <see langword="XmlForm.None" />.
		///       </returns>
		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x0009B79E File Offset: 0x0009999E
		// (set) Token: 0x06001B27 RID: 6951 RVA: 0x0009B7A6 File Offset: 0x000999A6
		public XmlSchemaForm Form
		{
			get
			{
				return this.form;
			}
			set
			{
				this.form = value;
			}
		}

		// Token: 0x040019C5 RID: 6597
		private string attributeName;

		// Token: 0x040019C6 RID: 6598
		private Type type;

		// Token: 0x040019C7 RID: 6599
		private string ns;

		// Token: 0x040019C8 RID: 6600
		private string dataType;

		// Token: 0x040019C9 RID: 6601
		private XmlSchemaForm form;
	}
}
