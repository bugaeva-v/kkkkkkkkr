using System;
using System.Xml.Schema;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Представляет атрибут, указывающий, производные типы, которые <see cref="T:System.Xml.Serialization.XmlSerializer" /> можно поместить в сериализованном массиве.
	///       </summary>
	// Token: 0x020002C7 RID: 711
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	public class XmlArrayItemAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" />.
		///       </summary>
		// Token: 0x06001AFE RID: 6910 RVA: 0x000021EA File Offset: 0x000003EA
		public XmlArrayItemAttribute()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> класса и задает имя элемента XML, создаваемого в документе XML.
		///       </summary>
		/// <param name="elementName">
		///           Имя элемента XML.
		///         </param>
		// Token: 0x06001AFF RID: 6911 RVA: 0x0009B621 File Offset: 0x00099821
		public XmlArrayItemAttribute(string elementName)
		{
			this.elementName = elementName;
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> и определяет <see cref="T:System.Type" /> могут быть вставлены в сериализованном массиве.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Объекта для сериализации.
		///         </param>
		// Token: 0x06001B00 RID: 6912 RVA: 0x0009B630 File Offset: 0x00099830
		public XmlArrayItemAttribute(Type type)
		{
			this.type = type;
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> класса и задает имя элемента XML, создаваемого в документе XML и <see cref="T:System.Type" /> могут быть вставлены в создаваемый документ XML.
		///       </summary>
		/// <param name="elementName">
		///           Имя элемента XML.
		///         </param>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Объекта для сериализации.
		///         </param>
		// Token: 0x06001B01 RID: 6913 RVA: 0x0009B63F File Offset: 0x0009983F
		public XmlArrayItemAttribute(string elementName, Type type)
		{
			this.elementName = elementName;
			this.type = type;
		}

		/// <summary>
		///         Возвращает или задает тип, допустимый в массиве.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Type" /> допустимое в массиве.
		///       </returns>
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x0009B655 File Offset: 0x00099855
		// (set) Token: 0x06001B03 RID: 6915 RVA: 0x0009B65D File Offset: 0x0009985D
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
		///         Возвращает или задает имя создаваемого элемента XML.
		///       </summary>
		/// <returns>
		///         Имя создаваемого элемента XML.
		///          По умолчанию используется идентификатор члена.
		///       </returns>
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x0009B666 File Offset: 0x00099866
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x0009B67C File Offset: 0x0009987C
		public string ElementName
		{
			get
			{
				if (this.elementName != null)
				{
					return this.elementName;
				}
				return string.Empty;
			}
			set
			{
				this.elementName = value;
			}
		}

		/// <summary>
		///         Возвращает или задает пространство имен создаваемого элемента XML.
		///       </summary>
		/// <returns>
		///         Пространство имен создаваемого элемента XML.
		///       </returns>
		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0009B685 File Offset: 0x00099885
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x0009B68D File Offset: 0x0009988D
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
		///         Возвращает или задает уровень в иерархии элементов XML, <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> влияет.
		///       </summary>
		/// <returns>
		///         Отсчитываемый от нуля индекс набора индексов в массиве массивов.
		///       </returns>
		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0009B696 File Offset: 0x00099896
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x0009B69E File Offset: 0x0009989E
		public int NestingLevel
		{
			get
			{
				return this.nestingLevel;
			}
			set
			{
				this.nestingLevel = value;
			}
		}

		/// <summary>
		///         Возвращает или задает тип данных XML сгенерированного элемента XML.
		///       </summary>
		/// <returns>
		///         Тип схемы XML (XSD) определения данных, как определено документом консорциума World Wide Web (www.w3.org) «XML схема часть 2: типы данных».
		///       </returns>
		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x0009B6A7 File Offset: 0x000998A7
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x0009B6BD File Offset: 0x000998BD
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
		///         Возвращает или задает значение, указывающее, является ли <see cref="T:System.Xml.Serialization.XmlSerializer" /> должен сериализовать член как пустой тег XML с <see langword="xsi:nil" /> атрибут <see langword="true" />.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если <see cref="T:System.Xml.Serialization.XmlSerializer" /> создает <see langword="xsi:nil" /> атрибут; в противном случае — <see langword="false" />, и ни один экземпляр не создаются.
		///          Значение по умолчанию — <see langword="true" />.
		///       </returns>
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0009B6C6 File Offset: 0x000998C6
		// (set) Token: 0x06001B0D RID: 6925 RVA: 0x0009B6CE File Offset: 0x000998CE
		public bool IsNullable
		{
			get
			{
				return this.nullable;
			}
			set
			{
				this.nullable = value;
				this.nullableSpecified = true;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x0009B6DE File Offset: 0x000998DE
		internal bool IsNullableSpecified
		{
			get
			{
				return this.nullableSpecified;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, является ли имя созданного элемента XML полным.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.Schema.XmlSchemaForm" />.
		///          Значение по умолчанию — <see langword="XmlSchemaForm.None" />.
		///       </returns>
		/// <exception cref="T:System.Exception">
		///             <see cref="P:System.Xml.Serialization.XmlArrayItemAttribute.Form" /> Свойству <see langword="XmlSchemaForm.Unqualified" /> и <see cref="P:System.Xml.Serialization.XmlArrayItemAttribute.Namespace" /> указано значение.
		///           </exception>
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x0009B6E6 File Offset: 0x000998E6
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x0009B6EE File Offset: 0x000998EE
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

		// Token: 0x040019BD RID: 6589
		private string elementName;

		// Token: 0x040019BE RID: 6590
		private Type type;

		// Token: 0x040019BF RID: 6591
		private string ns;

		// Token: 0x040019C0 RID: 6592
		private string dataType;

		// Token: 0x040019C1 RID: 6593
		private bool nullable;

		// Token: 0x040019C2 RID: 6594
		private bool nullableSpecified;

		// Token: 0x040019C3 RID: 6595
		private XmlSchemaForm form;

		// Token: 0x040019C4 RID: 6596
		private int nestingLevel;
	}
}
