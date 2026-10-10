using System;
using System.Xml.Schema;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Указывает, что <see cref="T:System.Xml.Serialization.XmlSerializer" /> должен сериализовать определенный член класса как массив XML-элементов.
	///       </summary>
	// Token: 0x020002C6 RID: 710
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false)]
	public class XmlArrayAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlArrayAttribute" />.
		///       </summary>
		// Token: 0x06001AF2 RID: 6898 RVA: 0x0009B580 File Offset: 0x00099780
		public XmlArrayAttribute()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlArrayAttribute" /> и задает имя элемента XML, создаваемого в экземпляре документа XML.
		///       </summary>
		/// <param name="elementName">
		///           Имя элемента XML, <see cref="T:System.Xml.Serialization.XmlSerializer" /> приводит к возникновению ошибки.
		///         </param>
		// Token: 0x06001AF3 RID: 6899 RVA: 0x0009B58F File Offset: 0x0009978F
		public XmlArrayAttribute(string elementName)
		{
			this.elementName = elementName;
		}

		/// <summary>
		///         Возвращает или задает имя элемента XML, заданного в сериализованном массиве.
		///       </summary>
		/// <returns>
		///         Имя элемента XML в сериализованном массиве.
		///          Значение по умолчанию — имя члена, к которому <see cref="T:System.Xml.Serialization.XmlArrayAttribute" /> назначается.
		///       </returns>
		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x0009B5A5 File Offset: 0x000997A5
		// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x0009B5BB File Offset: 0x000997BB
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
		///         Возвращает или задает пространство имен элемента XML.
		///       </summary>
		/// <returns>
		///         Пространство имен элемента XML.
		///       </returns>
		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x0009B5C4 File Offset: 0x000997C4
		// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x0009B5CC File Offset: 0x000997CC
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
		///         Возвращает или задает значение, указывающее, является ли <see cref="T:System.Xml.Serialization.XmlSerializer" /> должен сериализовать член как пустой тег XML с <see langword="xsi:nil" /> атрибут <see langword="true" />.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если <see cref="T:System.Xml.Serialization.XmlSerializer" /> создает <see langword="xsi:nil" /> атрибут; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x0009B5D5 File Offset: 0x000997D5
		// (set) Token: 0x06001AF9 RID: 6905 RVA: 0x0009B5DD File Offset: 0x000997DD
		public bool IsNullable
		{
			get
			{
				return this.nullable;
			}
			set
			{
				this.nullable = value;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, является ли имя элемента XML, созданные <see cref="T:System.Xml.Serialization.XmlSerializer" /> является полным или неполным.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.Schema.XmlSchemaForm" />.
		///          Значение по умолчанию — <see langword="XmlSchemaForm.None" />.
		///       </returns>
		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x0009B5E6 File Offset: 0x000997E6
		// (set) Token: 0x06001AFB RID: 6907 RVA: 0x0009B5EE File Offset: 0x000997EE
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
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x0009B5F7 File Offset: 0x000997F7
		// (set) Token: 0x06001AFD RID: 6909 RVA: 0x0009B5FF File Offset: 0x000997FF
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

		// Token: 0x040019B8 RID: 6584
		private string elementName;

		// Token: 0x040019B9 RID: 6585
		private string ns;

		// Token: 0x040019BA RID: 6586
		private bool nullable;

		// Token: 0x040019BB RID: 6587
		private XmlSchemaForm form;

		// Token: 0x040019BC RID: 6588
		private int order = -1;
	}
}
