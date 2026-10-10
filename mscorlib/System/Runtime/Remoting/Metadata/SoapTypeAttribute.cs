using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	/// <summary>Настраивает генерирование и обработку SOAP для типов целевых объектов. Этот класс не наследуется.</summary>
	// Token: 0x020005DD RID: 1501
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	[ComVisible(true)]
	public sealed class SoapTypeAttribute : SoapAttribute
	{
		/// <summary>Возвращает или задает значение конфигурации <see cref="T:System.Runtime.Remoting.Metadata.SoapOption" />.</summary>
		/// <returns>Значение конфигурации <see cref="T:System.Runtime.Remoting.Metadata.SoapOption" />.</returns>
		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06003913 RID: 14611 RVA: 0x000CB129 File Offset: 0x000C9329
		// (set) Token: 0x06003914 RID: 14612 RVA: 0x000CB131 File Offset: 0x000C9331
		public SoapOption SoapOptions
		{
			get
			{
				return this._soapOption;
			}
			set
			{
				this._soapOption = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, будет ли сериализован целевой объект текущего атрибута как атрибут XML вместо поля XML.</summary>
		/// <returns>Текущая реализация всегда возвращает <see langword="false" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Была предпринята попытка задать текущее свойство.</exception>
		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06003915 RID: 14613 RVA: 0x000CB13A File Offset: 0x000C933A
		// (set) Token: 0x06003916 RID: 14614 RVA: 0x000CB142 File Offset: 0x000C9342
		public override bool UseAttribute
		{
			get
			{
				return this._useAttribute;
			}
			set
			{
				this._useAttribute = value;
			}
		}

		/// <summary>Возвращает или задает имя XML-элемента.</summary>
		/// <returns>Имя элемента XML.</returns>
		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06003917 RID: 14615 RVA: 0x000CB14B File Offset: 0x000C934B
		// (set) Token: 0x06003918 RID: 14616 RVA: 0x000CB153 File Offset: 0x000C9353
		public string XmlElementName
		{
			get
			{
				return this._xmlElementName;
			}
			set
			{
				this._isElement = (value != null);
				this._xmlElementName = value;
			}
		}

		/// <summary>Получает или задает порядок полей XML для типа целевого объекта.</summary>
		/// <returns>Порядок полей XML для типа целевого объекта.</returns>
		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06003919 RID: 14617 RVA: 0x000CB166 File Offset: 0x000C9366
		// (set) Token: 0x0600391A RID: 14618 RVA: 0x000CB16E File Offset: 0x000C936E
		public XmlFieldOrderOption XmlFieldOrder
		{
			get
			{
				return this._xmlFieldOrder;
			}
			set
			{
				this._xmlFieldOrder = value;
			}
		}

		/// <summary>Возвращает или задает пространство имен XML, которое используется во время сериализации типа целевого объекта.</summary>
		/// <returns>Пространство имен XML, которое используется во время сериализации типа целевого объекта.</returns>
		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x0600391B RID: 14619 RVA: 0x000CB177 File Offset: 0x000C9377
		// (set) Token: 0x0600391C RID: 14620 RVA: 0x000CB17F File Offset: 0x000C937F
		public override string XmlNamespace
		{
			get
			{
				return this._xmlNamespace;
			}
			set
			{
				this._isElement = (value != null);
				this._xmlNamespace = value;
			}
		}

		/// <summary>Возвращает или задает имя типа XML для типа целевого объекта.</summary>
		/// <returns>Имя типа XML для типа целевого объекта.</returns>
		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x0600391D RID: 14621 RVA: 0x000CB192 File Offset: 0x000C9392
		// (set) Token: 0x0600391E RID: 14622 RVA: 0x000CB19A File Offset: 0x000C939A
		public string XmlTypeName
		{
			get
			{
				return this._xmlTypeName;
			}
			set
			{
				this._isType = (value != null);
				this._xmlTypeName = value;
			}
		}

		/// <summary>Возвращает или задает пространство имен типов XML для текущего типа объекта.</summary>
		/// <returns>Пространство имен типов XML для текущего типа объектов.</returns>
		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x0600391F RID: 14623 RVA: 0x000CB1AD File Offset: 0x000C93AD
		// (set) Token: 0x06003920 RID: 14624 RVA: 0x000CB1B5 File Offset: 0x000C93B5
		public string XmlTypeNamespace
		{
			get
			{
				return this._xmlTypeNamespace;
			}
			set
			{
				this._isType = (value != null);
				this._xmlTypeNamespace = value;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06003921 RID: 14625 RVA: 0x000CB1C8 File Offset: 0x000C93C8
		internal bool IsInteropXmlElement
		{
			get
			{
				return this._isElement;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x000CB1D0 File Offset: 0x000C93D0
		internal bool IsInteropXmlType
		{
			get
			{
				return this._isType;
			}
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x000CB1D8 File Offset: 0x000C93D8
		internal override void SetReflectionObject(object reflectionObject)
		{
			Type type = (Type)reflectionObject;
			if (this._xmlElementName == null)
			{
				this._xmlElementName = type.Name;
			}
			if (this._xmlTypeName == null)
			{
				this._xmlTypeName = type.Name;
			}
			if (this._xmlTypeNamespace == null)
			{
				string assemblyName;
				if (type.Assembly == typeof(object).Assembly)
				{
					assemblyName = string.Empty;
				}
				else
				{
					assemblyName = type.Assembly.GetName().Name;
				}
				this._xmlTypeNamespace = SoapServices.CodeXmlNamespaceForClrTypeNamespace(type.Namespace, assemblyName);
			}
			if (this._xmlNamespace == null)
			{
				this._xmlNamespace = this._xmlTypeNamespace;
			}
		}

		// Token: 0x04002612 RID: 9746
		private SoapOption _soapOption;

		// Token: 0x04002613 RID: 9747
		private bool _useAttribute;

		// Token: 0x04002614 RID: 9748
		private string _xmlElementName;

		// Token: 0x04002615 RID: 9749
		private XmlFieldOrderOption _xmlFieldOrder;

		// Token: 0x04002616 RID: 9750
		private string _xmlNamespace;

		// Token: 0x04002617 RID: 9751
		private string _xmlTypeName;

		// Token: 0x04002618 RID: 9752
		private string _xmlTypeNamespace;

		// Token: 0x04002619 RID: 9753
		private bool _isType;

		// Token: 0x0400261A RID: 9754
		private bool _isElement;
	}
}
