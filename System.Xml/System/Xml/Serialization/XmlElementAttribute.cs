using System;
using System.Xml.Schema;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Указывает, что открытое поле или свойство представляет элемент XML при <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует или десериализует содержащий его объект.
	///       </summary>
	// Token: 0x020002D0 RID: 720
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	public class XmlElementAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlElementAttribute" />.
		///       </summary>
		// Token: 0x06001BDC RID: 7132 RVA: 0x0009E5D8 File Offset: 0x0009C7D8
		public XmlElementAttribute()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> класса и задает имя элемента XML.
		///       </summary>
		/// <param name="elementName">
		///           Имя элемента XML сериализованного члена.
		///         </param>
		// Token: 0x06001BDD RID: 7133 RVA: 0x0009E5E7 File Offset: 0x0009C7E7
		public XmlElementAttribute(string elementName)
		{
			this.elementName = elementName;
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> класса и указывает тип члена, к которому <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> применяется.
		///          Этот тип используется <see cref="T:System.Xml.Serialization.XmlSerializer" /> при сериализации или десериализации объекта, который его содержит.
		///       </summary>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Объекта, производного от типа элемента.
		///         </param>
		// Token: 0x06001BDE RID: 7134 RVA: 0x0009E5FD File Offset: 0x0009C7FD
		public XmlElementAttribute(Type type)
		{
			this.type = type;
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> и указывает имя элемента XML и производного типа для члена, к которому <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> применяется.
		///          Этот тип члена используется при <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует объект, который его содержит.
		///       </summary>
		/// <param name="elementName">
		///           Имя элемента XML сериализованного члена.
		///         </param>
		/// <param name="type">
		///           <see cref="T:System.Type" /> Объекта, производного от типа элемента.
		///         </param>
		// Token: 0x06001BDF RID: 7135 RVA: 0x0009E613 File Offset: 0x0009C813
		public XmlElementAttribute(string elementName, Type type)
		{
			this.elementName = elementName;
			this.type = type;
		}

		/// <summary>
		///         Возвращает или задает тип объекта, используемый для представления элемента XML.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Type" /> Элемента.
		///       </returns>
		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x0009E630 File Offset: 0x0009C830
		// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x0009E638 File Offset: 0x0009C838
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
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x0009E641 File Offset: 0x0009C841
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x0009E657 File Offset: 0x0009C857
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
		///         Возвращает или задает пространство имен, назначенный элементу XML, полученный при сериализации класса.
		///       </summary>
		/// <returns>
		///         Пространство имен элемента XML.
		///       </returns>
		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x0009E660 File Offset: 0x0009C860
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x0009E668 File Offset: 0x0009C868
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
		///         Возвращает или задает типа данных схемы XML (XSD) определения элемента XML, созданные <see cref="T:System.Xml.Serialization.XmlSerializer" />.
		///       </summary>
		/// <returns>
		///         Тип данных схемы XML, как определено документом консорциума World Wide Web (www.w3.org) с именем «XML схема часть 2: типы данных».
		///       </returns>
		/// <exception cref="T:System.Exception">
		///             Указанный тип данных схемы XML не может быть сопоставлен типа данных платформы.NET.
		///           </exception>
		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x0009E671 File Offset: 0x0009C871
		// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x0009E687 File Offset: 0x0009C887
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
		///         Возвращает или задает значение, указывающее, является ли <see cref="T:System.Xml.Serialization.XmlSerializer" /> должен сериализовать член, который имеет значение <see langword="null" /> как пустой тег с <see langword="xsi:nil" /> атрибуту присвоено значение <see langword="true" />.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если <see cref="T:System.Xml.Serialization.XmlSerializer" /> создает <see langword="xsi:nil" /> атрибут; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x0009E690 File Offset: 0x0009C890
		// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x0009E698 File Offset: 0x0009C898
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

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x0009E6A8 File Offset: 0x0009C8A8
		internal bool IsNullableSpecified
		{
			get
			{
				return this.nullableSpecified;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, является ли элемент полным.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.Schema.XmlSchemaForm" />.
		///          Значение по умолчанию — <see cref="F:System.Xml.Schema.XmlSchemaForm.None" />.
		///       </returns>
		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0009E6B0 File Offset: 0x0009C8B0
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x0009E6B8 File Offset: 0x0009C8B8
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

		/// <summary>
		///         Возвращает или задает явный порядок сериализации или десериализации элементов.
		///       </summary>
		/// <returns>
		///         Порядок создания кода.
		///       </returns>
		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x0009E6C1 File Offset: 0x0009C8C1
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x0009E6C9 File Offset: 0x0009C8C9
		public int Order
		{
			get
			{
				return this.order;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException(Res.GetString("Negative values are prohibited."), "Order");
				}
				this.order = value;
			}
		}

		// Token: 0x040019EB RID: 6635
		private string elementName;

		// Token: 0x040019EC RID: 6636
		private Type type;

		// Token: 0x040019ED RID: 6637
		private string ns;

		// Token: 0x040019EE RID: 6638
		private string dataType;

		// Token: 0x040019EF RID: 6639
		private bool nullable;

		// Token: 0x040019F0 RID: 6640
		private bool nullableSpecified;

		// Token: 0x040019F1 RID: 6641
		private XmlSchemaForm form;

		// Token: 0x040019F2 RID: 6642
		private int order = -1;
	}
}
