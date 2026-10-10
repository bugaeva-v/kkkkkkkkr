using System;
using System.ComponentModel;
using System.Reflection;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Представляет коллекцию объектов атрибутов, которые управляют как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует и десериализует методы SOAP.
	///       </summary>
	// Token: 0x020002AD RID: 685
	public class SoapAttributes
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.SoapAttributes" />.
		///       </summary>
		// Token: 0x060019C5 RID: 6597 RVA: 0x0000216B File Offset: 0x0000036B
		public SoapAttributes()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.SoapAttributes" /> с использованием указанного настраиваемого типа.
		///       </summary>
		/// <param name="provider">
		///           Любой объект, реализующий <see cref="T:System.Reflection.ICustomAttributeProvider" /> интерфейса, такие как <see cref="T:System.Type" /> класса.
		///         </param>
		// Token: 0x060019C6 RID: 6598 RVA: 0x0009435C File Offset: 0x0009255C
		public SoapAttributes(ICustomAttributeProvider provider)
		{
			object[] customAttributes = provider.GetCustomAttributes(false);
			for (int i = 0; i < customAttributes.Length; i++)
			{
				if (customAttributes[i] is SoapIgnoreAttribute || customAttributes[i] is ObsoleteAttribute)
				{
					this.soapIgnore = true;
					break;
				}
				if (customAttributes[i] is SoapElementAttribute)
				{
					this.soapElement = (SoapElementAttribute)customAttributes[i];
				}
				else if (customAttributes[i] is SoapAttributeAttribute)
				{
					this.soapAttribute = (SoapAttributeAttribute)customAttributes[i];
				}
				else if (customAttributes[i] is SoapTypeAttribute)
				{
					this.soapType = (SoapTypeAttribute)customAttributes[i];
				}
				else if (customAttributes[i] is SoapEnumAttribute)
				{
					this.soapEnum = (SoapEnumAttribute)customAttributes[i];
				}
				else if (customAttributes[i] is DefaultValueAttribute)
				{
					this.soapDefaultValue = ((DefaultValueAttribute)customAttributes[i]).Value;
				}
			}
			if (this.soapIgnore)
			{
				this.soapElement = null;
				this.soapAttribute = null;
				this.soapType = null;
				this.soapEnum = null;
				this.soapDefaultValue = null;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x0009445C File Offset: 0x0009265C
		internal SoapAttributeFlags SoapFlags
		{
			get
			{
				SoapAttributeFlags soapAttributeFlags = (SoapAttributeFlags)0;
				if (this.soapElement != null)
				{
					soapAttributeFlags |= SoapAttributeFlags.Element;
				}
				if (this.soapAttribute != null)
				{
					soapAttributeFlags |= SoapAttributeFlags.Attribute;
				}
				if (this.soapEnum != null)
				{
					soapAttributeFlags |= SoapAttributeFlags.Enum;
				}
				if (this.soapType != null)
				{
					soapAttributeFlags |= SoapAttributeFlags.Type;
				}
				return soapAttributeFlags;
			}
		}

		/// <summary>
		///         Возвращает или задает объект, который указывает, что <see cref="T:System.Xml.Serialization.XmlSerializer" /> способ сериализации типа объекта в закодированный SOAP XML.
		///       </summary>
		/// <returns>
		///         A <see cref="T:System.Xml.Serialization.SoapTypeAttribute" /> который или переопределяет <see cref="T:System.Xml.Serialization.SoapTypeAttribute" /> применяются к объявлению класса, или применяется к объявлению класса.
		///       </returns>
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x0009449C File Offset: 0x0009269C
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x000944A4 File Offset: 0x000926A4
		public SoapTypeAttribute SoapType
		{
			get
			{
				return this.soapType;
			}
			set
			{
				this.soapType = value;
			}
		}

		/// <summary>
		///         Возвращает или задает объект, указывающий как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует перечисление SOAP.
		///       </summary>
		/// <returns>
		///         Объект, задающий как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует член перечисления.
		///       </returns>
		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x000944AD File Offset: 0x000926AD
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x000944B5 File Offset: 0x000926B5
		public SoapEnumAttribute SoapEnum
		{
			get
			{
				return this.soapEnum;
			}
			set
			{
				this.soapEnum = value;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, является ли <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует открытое поле или свойство как закодированный SOAP XML.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если <see cref="T:System.Xml.Serialization.XmlSerializer" /> не должен сериализовать поле или свойство; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x000944BE File Offset: 0x000926BE
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x000944C6 File Offset: 0x000926C6
		public bool SoapIgnore
		{
			get
			{
				return this.soapIgnore;
			}
			set
			{
				this.soapIgnore = value;
			}
		}

		/// <summary>
		///         Возвращает или задает <see cref="T:System.Xml.Serialization.SoapElementAttribute" /> для переопределения.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.SoapElementAttribute" /> Для переопределения.
		///       </returns>
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x000944CF File Offset: 0x000926CF
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x000944D7 File Offset: 0x000926D7
		public SoapElementAttribute SoapElement
		{
			get
			{
				return this.soapElement;
			}
			set
			{
				this.soapElement = value;
			}
		}

		/// <summary>
		///         Возвращает или задает <see cref="T:System.Xml.Serialization.SoapAttributeAttribute" /> для переопределения.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Xml.Serialization.SoapAttributeAttribute" /> переопределяющий <see cref="T:System.Xml.Serialization.XmlSerializer" /> при сериализации элемента.
		///       </returns>
		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x000944E0 File Offset: 0x000926E0
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x000944E8 File Offset: 0x000926E8
		public SoapAttributeAttribute SoapAttribute
		{
			get
			{
				return this.soapAttribute;
			}
			set
			{
				this.soapAttribute = value;
			}
		}

		/// <summary>
		///         Возвращает или задает значение по умолчанию XML-элемента или атрибута.
		///       </summary>
		/// <returns>
		///         Объект, представляющий значение по умолчанию XML-элемента или атрибута.
		///       </returns>
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x000944F1 File Offset: 0x000926F1
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x000944F9 File Offset: 0x000926F9
		public object SoapDefaultValue
		{
			get
			{
				return this.soapDefaultValue;
			}
			set
			{
				this.soapDefaultValue = value;
			}
		}

		// Token: 0x04001947 RID: 6471
		private bool soapIgnore;

		// Token: 0x04001948 RID: 6472
		private SoapTypeAttribute soapType;

		// Token: 0x04001949 RID: 6473
		private SoapElementAttribute soapElement;

		// Token: 0x0400194A RID: 6474
		private SoapAttributeAttribute soapAttribute;

		// Token: 0x0400194B RID: 6475
		private SoapEnumAttribute soapEnum;

		// Token: 0x0400194C RID: 6476
		private object soapDefaultValue;
	}
}
