using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	/// <summary>Настраивает генерирование и обработку SOAP для поля. Этот класс не наследуется.</summary>
	// Token: 0x020005D9 RID: 1497
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class SoapFieldAttribute : SoapAttribute
	{
		/// <summary>Получает или задает порядковый номер текущего атрибута поля.</summary>
		/// <returns>Порядковый номер текущего атрибута поля.</returns>
		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060038FD RID: 14589 RVA: 0x000CAFD2 File Offset: 0x000C91D2
		// (set) Token: 0x060038FE RID: 14590 RVA: 0x000CAFDA File Offset: 0x000C91DA
		public int Order
		{
			get
			{
				return this._order;
			}
			set
			{
				this._order = value;
			}
		}

		/// <summary>Возвращает или задает имя элемента XML для поля, содержащегося в атрибуте <see cref="T:System.Runtime.Remoting.Metadata.SoapFieldAttribute" />.</summary>
		/// <returns>Имя элемента XML для поля, содержащегося в этом атрибуте.</returns>
		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x000CAFE3 File Offset: 0x000C91E3
		// (set) Token: 0x06003900 RID: 14592 RVA: 0x000CAFEB File Offset: 0x000C91EB
		public string XmlElementName
		{
			get
			{
				return this._elementName;
			}
			set
			{
				this._isElement = (value != null);
				this._elementName = value;
			}
		}

		/// <summary>Возвращает значение, указывающее, содержит ли текущий атрибут взаимодействующие значения элементов XML.</summary>
		/// <returns>
		///   <see langword="true" />, если текущий атрибут содержит взаимодействующие значения элементов XML; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003901 RID: 14593 RVA: 0x000CAFFE File Offset: 0x000C91FE
		public bool IsInteropXmlElement()
		{
			return this._isElement;
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x000CB008 File Offset: 0x000C9208
		internal override void SetReflectionObject(object reflectionObject)
		{
			FieldInfo fieldInfo = (FieldInfo)reflectionObject;
			if (this._elementName == null)
			{
				this._elementName = fieldInfo.Name;
			}
		}

		// Token: 0x04002602 RID: 9730
		private int _order;

		// Token: 0x04002603 RID: 9731
		private string _elementName;

		// Token: 0x04002604 RID: 9732
		private bool _isElement;
	}
}
