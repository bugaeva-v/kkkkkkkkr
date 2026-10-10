using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет простую реализацию по умолчанию для интерфейса <see cref="T:System.ComponentModel.ICustomTypeDescriptor" />.</summary>
	// Token: 0x02000393 RID: 915
	public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.CustomTypeDescriptor" />.</summary>
		// Token: 0x06001DFF RID: 7679 RVA: 0x0000219B File Offset: 0x0000039B
		protected CustomTypeDescriptor()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.CustomTypeDescriptor" />, используя дескриптор родительского настраиваемого типа.</summary>
		/// <param name="parent">Дескриптор родительского настраиваемого типа.</param>
		// Token: 0x06001E00 RID: 7680 RVA: 0x0006B3B7 File Offset: 0x000695B7
		protected CustomTypeDescriptor(ICustomTypeDescriptor parent)
		{
			this._parent = parent;
		}

		/// <summary>Возвращает коллекцию настраиваемых атрибутов для типа, представленного этим дескриптором типа.</summary>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.AttributeCollection" />, содержащая атрибуты для этого типа. Значение по умолчанию: <see cref="F:System.ComponentModel.AttributeCollection.Empty" />.</returns>
		// Token: 0x06001E01 RID: 7681 RVA: 0x0006B3C6 File Offset: 0x000695C6
		public virtual AttributeCollection GetAttributes()
		{
			if (this._parent != null)
			{
				return this._parent.GetAttributes();
			}
			return AttributeCollection.Empty;
		}

		/// <summary>Возвращает полное имя класса, представленного этим дескриптором типа.</summary>
		/// <returns>Свойство <see cref="T:System.String" />, содержащее полное имя класса типа, описываемого этим дескриптором типа. Значение по умолчанию: <see langword="null" />.</returns>
		// Token: 0x06001E02 RID: 7682 RVA: 0x0006B3E1 File Offset: 0x000695E1
		public virtual string GetClassName()
		{
			ICustomTypeDescriptor parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetClassName();
		}

		/// <summary>Возвращает имя класса, представленное этим дескриптором типа.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая имя экземпляра компонента, описываемого этим дескриптором типа. Значение по умолчанию: <see langword="null" />.</returns>
		// Token: 0x06001E03 RID: 7683 RVA: 0x0006B3F4 File Offset: 0x000695F4
		public virtual string GetComponentName()
		{
			ICustomTypeDescriptor parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetComponentName();
		}

		/// <summary>Возвращает преобразователь типов для типа, представленного этим дескриптором типа.</summary>
		/// <returns>Преобразователь <see cref="T:System.ComponentModel.TypeConverter" /> для типа, представленного этим дескриптором типа. Значением по умолчанию является только что созданный преобразователь <see cref="T:System.ComponentModel.TypeConverter" />.</returns>
		// Token: 0x06001E04 RID: 7684 RVA: 0x0006B407 File Offset: 0x00069607
		public virtual TypeConverter GetConverter()
		{
			if (this._parent != null)
			{
				return this._parent.GetConverter();
			}
			return new TypeConverter();
		}

		/// <summary>Возвращает дескриптор события по умолчанию для объекта, представленного этим дескриптором типа.</summary>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.EventDescriptor" /> события по умолчанию для объекта, представленного этим дескриптором типа. Значение по умолчанию: <see langword="null" />.</returns>
		// Token: 0x06001E05 RID: 7685 RVA: 0x0006B422 File Offset: 0x00069622
		public virtual EventDescriptor GetDefaultEvent()
		{
			ICustomTypeDescriptor parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetDefaultEvent();
		}

		/// <summary>Возвращает дескриптор свойства по умолчанию для объекта, представленного этим дескриптором типа.</summary>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> свойства по умолчанию для объекта, представленного этим дескриптором типа. Значение по умолчанию: <see langword="null" />.</returns>
		// Token: 0x06001E06 RID: 7686 RVA: 0x0006B435 File Offset: 0x00069635
		public virtual PropertyDescriptor GetDefaultProperty()
		{
			ICustomTypeDescriptor parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetDefaultProperty();
		}

		/// <summary>Возвращает редактор для заданного типа, который должен быть связан с классом, представленным этим дескриптором типа.</summary>
		/// <param name="editorBaseType">Базовый тип возвращаемого редактора.</param>
		/// <returns>Редактор для данного типа, который должен быть связан с классом, представленным этим дескриптором типа. Значение по умолчанию: <see langword="null" />.</returns>
		// Token: 0x06001E07 RID: 7687 RVA: 0x0006B448 File Offset: 0x00069648
		public virtual object GetEditor(Type editorBaseType)
		{
			ICustomTypeDescriptor parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetEditor(editorBaseType);
		}

		/// <summary>Возвращает коллекцию дескрипторов событий по умолчанию для объекта, представленного этим дескриптором типа.</summary>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.EventDescriptorCollection" />, содержащая дескрипторы событий для объекта, представленного этим дескриптором типа. Значение по умолчанию: <see cref="F:System.ComponentModel.EventDescriptorCollection.Empty" />.</returns>
		// Token: 0x06001E08 RID: 7688 RVA: 0x0006B45C File Offset: 0x0006965C
		public virtual EventDescriptorCollection GetEvents()
		{
			if (this._parent != null)
			{
				return this._parent.GetEvents();
			}
			return EventDescriptorCollection.Empty;
		}

		/// <summary>Возвращает фильтрованную коллекцию дескрипторов событий по умолчанию для объекта, представленного этим дескриптором типа.</summary>
		/// <param name="attributes">Массив атрибутов, используемый в качестве фильтра. Это может быть <see langword="null" />.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.EventDescriptorCollection" />, содержащая описания событий для объекта, представленного этим дескриптором типа. Значение по умолчанию: <see cref="F:System.ComponentModel.EventDescriptorCollection.Empty" />.</returns>
		// Token: 0x06001E09 RID: 7689 RVA: 0x0006B477 File Offset: 0x00069677
		public virtual EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			if (this._parent != null)
			{
				return this._parent.GetEvents(attributes);
			}
			return EventDescriptorCollection.Empty;
		}

		/// <summary>Возвращает коллекцию дескрипторов свойств для объекта, представленного этим дескриптором типа.</summary>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, содержащая описания свойств для объекта, представленного этим дескриптором типа. Значение по умолчанию: <see cref="F:System.ComponentModel.PropertyDescriptorCollection.Empty" />.</returns>
		// Token: 0x06001E0A RID: 7690 RVA: 0x0006B493 File Offset: 0x00069693
		public virtual PropertyDescriptorCollection GetProperties()
		{
			if (this._parent != null)
			{
				return this._parent.GetProperties();
			}
			return PropertyDescriptorCollection.Empty;
		}

		/// <summary>Возвращает фильтрованную коллекцию дескрипторов свойств для объекта, представленного этим дескриптором типа.</summary>
		/// <param name="attributes">Массив атрибутов, используемый в качестве фильтра. Это может быть <see langword="null" />.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, содержащая описания свойств для объекта, представленного этим дескриптором типа. Значение по умолчанию: <see cref="F:System.ComponentModel.PropertyDescriptorCollection.Empty" />.</returns>
		// Token: 0x06001E0B RID: 7691 RVA: 0x0006B4AE File Offset: 0x000696AE
		public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			if (this._parent != null)
			{
				return this._parent.GetProperties(attributes);
			}
			return PropertyDescriptorCollection.Empty;
		}

		/// <summary>Возвращает объект, содержащий свойство, описанное указанным дескриптором свойства.</summary>
		/// <param name="pd">Дескриптор свойства, для которого возвращается объект-владелец.</param>
		/// <returns>Объект <see cref="T:System.Object" />, являющийся владельцем данного свойства, заданного дескриптором типа. Значение по умолчанию: <see langword="null" />.</returns>
		// Token: 0x06001E0C RID: 7692 RVA: 0x0006B4CA File Offset: 0x000696CA
		public virtual object GetPropertyOwner(PropertyDescriptor pd)
		{
			ICustomTypeDescriptor parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetPropertyOwner(pd);
		}

		// Token: 0x04000F05 RID: 3845
		private readonly ICustomTypeDescriptor _parent;
	}
}
