using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типов для преобразования объектов <see cref="T:System.Array" /> в прочие представления и обратно.</summary>
	// Token: 0x0200037B RID: 891
	public class ArrayConverter : CollectionConverter
	{
		/// <summary>Преобразовывает указанное значение объекта в указанный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Язык и региональные параметры, в которые будет выполнено преобразование <paramref name="value" />.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <param name="destinationType">Тип <see cref="T:System.Type" />, к которому следует привести значение.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06001D55 RID: 7509 RVA: 0x000688C8 File Offset: 0x00066AC8
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(string) && value is Array)
			{
				return SR.Format("{0} Array", value.GetType().Name);
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Возвращает коллекцию свойств для типа массива, заданного параметром.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, задающий тип массива, для которого нужно получить свойства.</param>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, который будет использоваться как фильтр.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> со свойствами, предоставляемыми для массива, или <see langword="null" /> в случае отсутствия свойств.</returns>
		// Token: 0x06001D56 RID: 7510 RVA: 0x00068928 File Offset: 0x00066B28
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			if (value == null)
			{
				return null;
			}
			PropertyDescriptor[] array = null;
			if (value.GetType().IsArray)
			{
				int length = ((Array)value).GetLength(0);
				array = new PropertyDescriptor[length];
				Type type = value.GetType();
				Type elementType = type.GetElementType();
				for (int i = 0; i < length; i++)
				{
					array[i] = new ArrayConverter.ArrayPropertyDescriptor(type, elementType, i);
				}
			}
			return new PropertyDescriptorCollection(array);
		}

		/// <summary>Возвращает значение, показывающее, поддерживает ли свойства этот объект.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="true" />, так как для поиска свойств данного объекта следует вызывать метод <see cref="M:System.ComponentModel.ArrayConverter.GetProperties(System.ComponentModel.ITypeDescriptorContext,System.Object,System.Attribute[])" />.  Этот метод никогда не возвращает значение <see langword="false" />.</returns>
		// Token: 0x06001D57 RID: 7511 RVA: 0x0000390E File Offset: 0x00001B0E
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0200037C RID: 892
		private class ArrayPropertyDescriptor : TypeConverter.SimplePropertyDescriptor
		{
			// Token: 0x06001D59 RID: 7513 RVA: 0x00068996 File Offset: 0x00066B96
			public ArrayPropertyDescriptor(Type arrayType, Type elementType, int index) : base(arrayType, "[" + index.ToString() + "]", elementType, null)
			{
				this._index = index;
			}

			// Token: 0x06001D5A RID: 7514 RVA: 0x000689C0 File Offset: 0x00066BC0
			public override object GetValue(object instance)
			{
				Array array = instance as Array;
				if (array != null && array.GetLength(0) > this._index)
				{
					return array.GetValue(this._index);
				}
				return null;
			}

			// Token: 0x06001D5B RID: 7515 RVA: 0x000689F4 File Offset: 0x00066BF4
			public override void SetValue(object instance, object value)
			{
				if (instance is Array)
				{
					Array array = (Array)instance;
					if (array.GetLength(0) > this._index)
					{
						array.SetValue(value, this._index);
					}
					this.OnValueChanged(instance, EventArgs.Empty);
				}
			}

			// Token: 0x04000ED0 RID: 3792
			private readonly int _index;
		}
	}
}
