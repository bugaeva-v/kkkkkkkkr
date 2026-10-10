using System;
using System.Collections;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Предоставляет унифицированный способ преобразования типов значений в другие типы, а также позволяет осуществить доступ к стандартным значениям и вложенным свойствам.</summary>
	// Token: 0x02000421 RID: 1057
	[ComVisible(true)]
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public class TypeConverter
	{
		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x000778CA File Offset: 0x00075ACA
		private static bool UseCompatibleTypeConversion
		{
			get
			{
				return TypeConverter.useCompatibleTypeConversion;
			}
		}

		/// <summary>Возвращает значение, указывающее, может ли этот преобразователь преобразовать объект заданного типа к типу этого преобразователя.</summary>
		/// <param name="sourceType">Объект <see cref="T:System.Type" />, представляющий тип, из которого нужно выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600225D RID: 8797 RVA: 0x000778D3 File Offset: 0x00075AD3
		public bool CanConvertFrom(Type sourceType)
		{
			return this.CanConvertFrom(null, sourceType);
		}

		/// <summary>Возвращает значение, указывающее, может ли этот преобразователь выполнить преобразование объекта заданного типа в тип этого преобразователя, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Объект <see cref="T:System.Type" />, представляющий тип, из которого нужно выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600225E RID: 8798 RVA: 0x000778DD File Offset: 0x00075ADD
		public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(InstanceDescriptor);
		}

		/// <summary>Возвращает значение, указывающее, может ли этот преобразователь выполнить преобразование данного объекта к заданному типу.</summary>
		/// <param name="destinationType">Класс <see cref="T:System.Type" />, представляющий тип, в который нужно выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600225F RID: 8799 RVA: 0x000778F4 File Offset: 0x00075AF4
		public bool CanConvertTo(Type destinationType)
		{
			return this.CanConvertTo(null, destinationType);
		}

		/// <summary>Возвращает значение, показывающее, может ли этот преобразователь преобразовать объект в заданный тип с помощью указанного контекста.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">Класс <see cref="T:System.Type" />, представляющий тип, в который нужно выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002260 RID: 8800 RVA: 0x000778FE File Offset: 0x00075AFE
		public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		/// <summary>Приводит заданное значение к типу этого преобразователя.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06002261 RID: 8801 RVA: 0x00077910 File Offset: 0x00075B10
		public object ConvertFrom(object value)
		{
			return this.ConvertFrom(null, CultureInfo.CurrentCulture, value);
		}

		/// <summary>Преобразует заданный объект в тип этого преобразователя, используя указанные сведения о контексте и языке и региональных параметрах.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в качестве текущего языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06002262 RID: 8802 RVA: 0x00077920 File Offset: 0x00075B20
		public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			InstanceDescriptor instanceDescriptor = value as InstanceDescriptor;
			if (instanceDescriptor != null)
			{
				return instanceDescriptor.Invoke();
			}
			throw this.GetConvertFromException(value);
		}

		/// <summary>Преобразует заданную строку к типу этого преобразователя, используя нейтральные язык и региональные параметры.</summary>
		/// <param name="text">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий преобразованный текст.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06002263 RID: 8803 RVA: 0x00077945 File Offset: 0x00075B45
		public object ConvertFromInvariantString(string text)
		{
			return this.ConvertFromString(null, CultureInfo.InvariantCulture, text);
		}

		/// <summary>Преобразует заданную строку к типу этого преобразователя, используя нейтральные язык и региональные параметры вместе с заданным контекстом.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="text">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий преобразованный текст.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06002264 RID: 8804 RVA: 0x00077954 File Offset: 0x00075B54
		public object ConvertFromInvariantString(ITypeDescriptorContext context, string text)
		{
			return this.ConvertFromString(context, CultureInfo.InvariantCulture, text);
		}

		/// <summary>Преобразует заданный текст в объект.</summary>
		/// <param name="text">Текстовое представление преобразуемого объекта.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий преобразованный текст.</returns>
		/// <exception cref="T:System.NotSupportedException">Данная строка не может быть преобразована в соответствующий объект.</exception>
		// Token: 0x06002265 RID: 8805 RVA: 0x00077963 File Offset: 0x00075B63
		public object ConvertFromString(string text)
		{
			return this.ConvertFrom(null, null, text);
		}

		/// <summary>Преобразует заданный текст в объект, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="text">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий преобразованный текст.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06002266 RID: 8806 RVA: 0x0007796E File Offset: 0x00075B6E
		public object ConvertFromString(ITypeDescriptorContext context, string text)
		{
			return this.ConvertFrom(context, CultureInfo.CurrentCulture, text);
		}

		/// <summary>Преобразует заданный текст в объект, используя заданный контекст и сведения о языке и региональных параметрах.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />. Если передано значение <see langword="null" />, используются текущие настройки языка и региональных параметров.</param>
		/// <param name="text">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий преобразованный текст.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06002267 RID: 8807 RVA: 0x0007797D File Offset: 0x00075B7D
		public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text)
		{
			return this.ConvertFrom(context, culture, text);
		}

		/// <summary>Преобразует данное значение в указанный тип, используя заданные аргументы.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <param name="destinationType">
		///   <see cref="T:System.Type" />, к которому преобразуется параметр <paramref name="value" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06002268 RID: 8808 RVA: 0x00077988 File Offset: 0x00075B88
		public object ConvertTo(object value, Type destinationType)
		{
			return this.ConvertTo(null, null, value, destinationType);
		}

		/// <summary>Преобразует данный объект значения в указанный тип, используя заданные сведения о контексте, а также о языке и региональных параметрах.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />. Если передано значение <see langword="null" />, используются текущие настройки языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <param name="destinationType">
		///   <see cref="T:System.Type" />, к которому преобразуется параметр <paramref name="value" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06002269 RID: 8809 RVA: 0x00077994 File Offset: 0x00075B94
		public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (!(destinationType == typeof(string)))
			{
				throw this.GetConvertToException(value, destinationType);
			}
			if (value == null)
			{
				return string.Empty;
			}
			if (culture != null && culture != CultureInfo.CurrentCulture)
			{
				IFormattable formattable = value as IFormattable;
				if (formattable != null)
				{
					return formattable.ToString(null, culture);
				}
			}
			return value.ToString();
		}

		/// <summary>Преобразует указанное значение в строковое представление для нейтральных языка и региональных параметров.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>Объект <see cref="T:System.String" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x0600226A RID: 8810 RVA: 0x00077A00 File Offset: 0x00075C00
		public string ConvertToInvariantString(object value)
		{
			return this.ConvertToString(null, CultureInfo.InvariantCulture, value);
		}

		/// <summary>Преобразует указанное значение в строковое представление для нейтральных языка и региональных параметров.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>Объект <see cref="T:System.String" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x0600226B RID: 8811 RVA: 0x00077A0F File Offset: 0x00075C0F
		public string ConvertToInvariantString(ITypeDescriptorContext context, object value)
		{
			return this.ConvertToString(context, CultureInfo.InvariantCulture, value);
		}

		/// <summary>Преобразует указанное значение в строковое представление.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x0600226C RID: 8812 RVA: 0x00077A1E File Offset: 0x00075C1E
		public string ConvertToString(object value)
		{
			return (string)this.ConvertTo(null, CultureInfo.CurrentCulture, value, typeof(string));
		}

		/// <summary>Преобразует данное значение в строку, используя данный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x0600226D RID: 8813 RVA: 0x00077A3C File Offset: 0x00075C3C
		public string ConvertToString(ITypeDescriptorContext context, object value)
		{
			return (string)this.ConvertTo(context, CultureInfo.CurrentCulture, value, typeof(string));
		}

		/// <summary>Преобразует данное значение в заданный тип, используя заданный контекст и сведения о языке и региональных параметрах.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />. Если передано значение <see langword="null" />, используются текущие настройки языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x0600226E RID: 8814 RVA: 0x00077A5A File Offset: 0x00075C5A
		public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return (string)this.ConvertTo(context, culture, value, typeof(string));
		}

		/// <summary>Повторно создает объект <see cref="T:System.Object" />, задающий набор значений свойств для объекта.</summary>
		/// <param name="propertyValues">Интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий словарь новых значений свойства.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий данный <see cref="T:System.Collections.IDictionary" />, или <see langword="null" />, если объект не может быть создан. Этот метод всегда возвращает значение <see langword="null" />.</returns>
		// Token: 0x0600226F RID: 8815 RVA: 0x00077A74 File Offset: 0x00075C74
		public object CreateInstance(IDictionary propertyValues)
		{
			return this.CreateInstance(null, propertyValues);
		}

		/// <summary>Создает экземпляр типа, с которым связан этот <see cref="T:System.ComponentModel.TypeConverter" />, используя заданный контекст с учетом набора значений свойств для объекта.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="propertyValues">
		///   <see cref="T:System.Collections.IDictionary" /> новых значений свойств.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий данный <see cref="T:System.Collections.IDictionary" />, или <see langword="null" />, если объект не может быть создан. Этот метод всегда возвращает значение <see langword="null" />.</returns>
		// Token: 0x06002270 RID: 8816 RVA: 0x00002F6A File Offset: 0x0000116A
		public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			return null;
		}

		/// <summary>Возвращает исключение, возникающее в случае, если невозможно выполнить преобразование.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" /> для преобразования или <see langword="null" />, если объект отсутствует.</param>
		/// <returns>Объект <see cref="T:System.Exception" />, представляющий исключение, возникающее, если преобразование не может быть выполнено.</returns>
		/// <exception cref="T:System.NotSupportedException">Автоматически вызывается этим методом.</exception>
		// Token: 0x06002271 RID: 8817 RVA: 0x00077A80 File Offset: 0x00075C80
		protected Exception GetConvertFromException(object value)
		{
			string text;
			if (value == null)
			{
				text = SR.GetString("(null)");
			}
			else
			{
				text = value.GetType().FullName;
			}
			throw new NotSupportedException(SR.GetString("{0} cannot convert from {1}.", new object[]
			{
				base.GetType().Name,
				text
			}));
		}

		/// <summary>Возвращает исключение, возникающее в случае, если невозможно выполнить преобразование.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" /> для преобразования или <see langword="null" />, если объект отсутствует.</param>
		/// <param name="destinationType">Объект <see cref="T:System.Type" />, представляющий тип, в который осуществлялось преобразование.</param>
		/// <returns>Объект <see cref="T:System.Exception" />, представляющий исключение, возникающее, если преобразование не может быть выполнено.</returns>
		/// <exception cref="T:System.NotSupportedException">Автоматически вызывается этим методом.</exception>
		// Token: 0x06002272 RID: 8818 RVA: 0x00077AD0 File Offset: 0x00075CD0
		protected Exception GetConvertToException(object value, Type destinationType)
		{
			string text;
			if (value == null)
			{
				text = SR.GetString("(null)");
			}
			else
			{
				text = value.GetType().FullName;
			}
			throw new NotSupportedException(SR.GetString("'{0}' is unable to convert '{1}' to '{2}'.", new object[]
			{
				base.GetType().Name,
				text,
				destinationType.FullName
			}));
		}

		/// <summary>Возвращает значение, показывающее, требуется ли при изменении значения этого объекта вызывать метод <see cref="M:System.ComponentModel.TypeConverter.CreateInstance(System.Collections.IDictionary)" />, чтобы создать новое значение.</summary>
		/// <returns>Значение <see langword="true" />, если для изменения свойства в этом объекте требуется вызов <see cref="M:System.ComponentModel.TypeConverter.CreateInstance(System.Collections.IDictionary)" />, чтобы создать новое значение; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002273 RID: 8819 RVA: 0x00077B29 File Offset: 0x00075D29
		public bool GetCreateInstanceSupported()
		{
			return this.GetCreateInstanceSupported(null);
		}

		/// <summary>Возвращает значение, указывающее, требуется ли для изменения значения в этом объекте вызов <see cref="M:System.ComponentModel.TypeConverter.CreateInstance(System.Collections.IDictionary)" />, чтобы создать новое значение с помощью указанного контекста.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="true" />, если для изменения свойства в этом объекте требуется вызов <see cref="M:System.ComponentModel.TypeConverter.CreateInstance(System.Collections.IDictionary)" />, чтобы создать новое значение; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002274 RID: 8820 RVA: 0x00003062 File Offset: 0x00001262
		public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		/// <summary>Возвращает коллекцию свойств для типа массива, заданного параметром значения.</summary>
		/// <param name="value">Объект класса <see cref="T:System.Object" />, задающий тип массива, для которого нужно получить свойства.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> со свойствами, доступными для этого типа данных, или значение <see langword="null" />, если свойства отсутствуют.</returns>
		// Token: 0x06002275 RID: 8821 RVA: 0x00077B32 File Offset: 0x00075D32
		public PropertyDescriptorCollection GetProperties(object value)
		{
			return this.GetProperties(null, value);
		}

		/// <summary>Возвращает коллекцию свойств для типа массива, заданного параметром, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Объект класса <see cref="T:System.Object" />, задающий тип массива, для которого нужно получить свойства.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> со свойствами, доступными для этого типа данных, или значение <see langword="null" />, если свойства отсутствуют.</returns>
		// Token: 0x06002276 RID: 8822 RVA: 0x00077B3C File Offset: 0x00075D3C
		public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value)
		{
			return this.GetProperties(context, value, new Attribute[]
			{
				BrowsableAttribute.Yes
			});
		}

		/// <summary>Возвращает коллекцию свойств для типа массива, заданного параметром value, используя заданные контекст и атрибуты.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Объект класса <see cref="T:System.Object" />, задающий тип массива, для которого нужно получить свойства.</param>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, используемый в качестве фильтра.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> со свойствами, доступными для этого типа данных, или значение <see langword="null" />, если свойства отсутствуют.</returns>
		// Token: 0x06002277 RID: 8823 RVA: 0x00002F6A File Offset: 0x0000116A
		public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return null;
		}

		/// <summary>Возвращает значение, показывающее, поддерживаются ли свойства этим объектом.</summary>
		/// <returns>Имеет значение <see langword="true" />, если для поиска свойств этого объекта следует вызвать метод <see cref="M:System.ComponentModel.TypeConverter.GetProperties(System.Object)" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002278 RID: 8824 RVA: 0x00077B54 File Offset: 0x00075D54
		public bool GetPropertiesSupported()
		{
			return this.GetPropertiesSupported(null);
		}

		/// <summary>Возвращает значение, показывающее, поддерживает ли данный объект свойства, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Имеет значение <see langword="true" />, если для поиска свойств этого объекта следует вызвать метод <see cref="M:System.ComponentModel.TypeConverter.GetProperties(System.Object)" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002279 RID: 8825 RVA: 0x00003062 File Offset: 0x00001262
		public virtual bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		/// <summary>Возвращает коллекцию стандартных значений из контекста по умолчанию для типа данных, для которого предназначен этот преобразователь типов.</summary>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, содержащая стандартный набор допустимых значений, или <see langword="null" />, если этот тип данных не поддерживает стандартный набор значений.</returns>
		// Token: 0x0600227A RID: 8826 RVA: 0x00077B5D File Offset: 0x00075D5D
		public ICollection GetStandardValues()
		{
			return this.GetStandardValues(null);
		}

		/// <summary>Возвращает коллекцию стандартных значений для типа данных, для которого предназначен этот преобразователь типов при предоставлении с контекстом формата.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата, который можно использовать для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Этот параметр или его свойства могут иметь значение <see langword="null" />.</param>
		/// <returns>Класс <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, содержащий стандартный набор допустимых значений или значение <see langword="null" />, если этот тип данных не поддерживает стандартный набор значений.</returns>
		// Token: 0x0600227B RID: 8827 RVA: 0x00002F6A File Offset: 0x0000116A
		public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}

		/// <summary>Возвращает значение, показывающее, является ли исчерпывающим списком коллекция стандартных значений, возвращаемая методом <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" />.</summary>
		/// <returns>Имеет значение <see langword="true" />, если объект класса <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, возвращенный методом <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" />, является исчерпывающим списком возможных значений, значение <see langword="false" />, если возможны другие значения.</returns>
		// Token: 0x0600227C RID: 8828 RVA: 0x00077B66 File Offset: 0x00075D66
		public bool GetStandardValuesExclusive()
		{
			return this.GetStandardValuesExclusive(null);
		}

		/// <summary>Используя заданный контекст, возвращает значение, показывающее, является ли исчерпывающим списком возможных значений коллекция стандартных значений, возвращаемая методом <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" />.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Имеет значение <see langword="true" />, если объект класса <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, возвращенный методом <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" />, является исчерпывающим списком возможных значений, значение <see langword="false" />, если возможны другие значения.</returns>
		// Token: 0x0600227D RID: 8829 RVA: 0x00003062 File Offset: 0x00001262
		public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return false;
		}

		/// <summary>Возвращает значение, показывающее, поддерживает ли объект стандартный набор значений, которые можно выбрать из списка.</summary>
		/// <returns>Имеет значение <see langword="true" />, если метод <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> должен быть вызван для поиска общего набора значений, поддерживаемых объектом, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600227E RID: 8830 RVA: 0x00077B6F File Offset: 0x00075D6F
		public bool GetStandardValuesSupported()
		{
			return this.GetStandardValuesSupported(null);
		}

		/// <summary>Получает значение, показывающее, поддерживает ли этот объект стандартный набор значений, которые можно выбрать из списка, используя заданную контекстную информацию.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Имеет значение <see langword="true" />, если метод <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> должен быть вызван для поиска общего набора значений, поддерживаемых объектом, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600227F RID: 8831 RVA: 0x00003062 File Offset: 0x00001262
		public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		/// <summary>Возвращает значение, показывающее, допустим ли для этого типа данный объект значения.</summary>
		/// <param name="value">Объект, допустимость которого требуется проверить.</param>
		/// <returns>Значение <see langword="true" />, если указанное значение является допустимым для данного объекта; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002280 RID: 8832 RVA: 0x00077B78 File Offset: 0x00075D78
		public bool IsValid(object value)
		{
			return this.IsValid(null, value);
		}

		/// <summary>Возвращает значение, показывающее, допустим ли для этого типа и указанного контекста данный объект значения.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Объект <see cref="T:System.Object" /> для проверки на допустимость.</param>
		/// <returns>Значение <see langword="true" />, если указанное значение является допустимым для данного объекта; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002281 RID: 8833 RVA: 0x00077B84 File Offset: 0x00075D84
		public virtual bool IsValid(ITypeDescriptorContext context, object value)
		{
			if (TypeConverter.UseCompatibleTypeConversion)
			{
				return true;
			}
			bool result = true;
			try
			{
				if (value == null || this.CanConvertFrom(context, value.GetType()))
				{
					this.ConvertFrom(context, CultureInfo.InvariantCulture, value);
				}
				else
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		/// <summary>Сортирует коллекцию свойств.</summary>
		/// <param name="props">Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, содержащая свойства для сортировки.</param>
		/// <param name="names">Массив имен в том порядке, в котором нужно представить свойства в коллекции.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, содержащая отсортированные свойства.</returns>
		// Token: 0x06002282 RID: 8834 RVA: 0x00077BD8 File Offset: 0x00075DD8
		protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names)
		{
			props.Sort(names);
			return props;
		}

		// Token: 0x0400106D RID: 4205
		private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";

		// Token: 0x0400106E RID: 4206
		private static volatile bool useCompatibleTypeConversion;

		/// <summary>Представляет класс <see langword="abstract" />, предоставляющий свойства для объектов, у которых нет свойств.</summary>
		// Token: 0x02000422 RID: 1058
		protected abstract class SimplePropertyDescriptor : PropertyDescriptor
		{
			/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.TypeConverter.SimplePropertyDescriptor" />.</summary>
			/// <param name="componentType">Тип <see cref="T:System.Type" />, представляющий тип компонента, с которым связывается дескриптор этого свойства.</param>
			/// <param name="name">Имя свойства.</param>
			/// <param name="propertyType">Тип <see cref="T:System.Type" />, представляющий тип данных для этого свойства.</param>
			// Token: 0x06002284 RID: 8836 RVA: 0x00077BE3 File Offset: 0x00075DE3
			protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType) : this(componentType, name, propertyType, new Attribute[0])
			{
			}

			/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.TypeConverter.SimplePropertyDescriptor" />.</summary>
			/// <param name="componentType">Тип <see cref="T:System.Type" />, представляющий тип компонента, с которым связывается дескриптор этого свойства.</param>
			/// <param name="name">Имя свойства.</param>
			/// <param name="propertyType">Тип <see cref="T:System.Type" />, представляющий тип данных для этого свойства.</param>
			/// <param name="attributes">Массив <see cref="T:System.Attribute" />, содержащий атрибуты, связываемые со свойством.</param>
			// Token: 0x06002285 RID: 8837 RVA: 0x00077BF4 File Offset: 0x00075DF4
			protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType, Attribute[] attributes) : base(name, attributes)
			{
				this.componentType = componentType;
				this.propertyType = propertyType;
			}

			/// <summary>Возвращает тип компонента, к которому привязывается дескриптор этого свойства.</summary>
			/// <returns>Тип <see cref="T:System.Type" />, представляющий тип компонента, с которым связывается это свойство.</returns>
			// Token: 0x1700071B RID: 1819
			// (get) Token: 0x06002286 RID: 8838 RVA: 0x00077C0D File Offset: 0x00075E0D
			public override Type ComponentType
			{
				get
				{
					return this.componentType;
				}
			}

			/// <summary>Возвращает значение, показывающее, является ли это свойство доступным только для чтения.</summary>
			/// <returns>Значение <see langword="true" />, если это свойство доступно только для чтения; значение <see langword="false" />, если это свойство доступно и для чтения, и для записи.</returns>
			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x06002287 RID: 8839 RVA: 0x00077C15 File Offset: 0x00075E15
			public override bool IsReadOnly
			{
				get
				{
					return this.Attributes.Contains(ReadOnlyAttribute.Yes);
				}
			}

			/// <summary>Возвращает тип свойства.</summary>
			/// <returns>Тип <see cref="T:System.Type" />, представляющий тип свойства.</returns>
			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x06002288 RID: 8840 RVA: 0x00077C27 File Offset: 0x00075E27
			public override Type PropertyType
			{
				get
				{
					return this.propertyType;
				}
			}

			/// <summary>Возвращает значение, показывающее, изменяет ли сброс компонента значение компонента.</summary>
			/// <param name="component">Компонент для проверки на возможность сброса.</param>
			/// <returns>Значение <see langword="true" />, если сброс компонента изменяет значение компонента; в противном случае — значение <see langword="false" />.</returns>
			// Token: 0x06002289 RID: 8841 RVA: 0x00077C30 File Offset: 0x00075E30
			public override bool CanResetValue(object component)
			{
				DefaultValueAttribute defaultValueAttribute = (DefaultValueAttribute)this.Attributes[typeof(DefaultValueAttribute)];
				return defaultValueAttribute != null && defaultValueAttribute.Value.Equals(this.GetValue(component));
			}

			/// <summary>Сбрасывает данное значение этого свойства компонента.</summary>
			/// <param name="component">Компонент со значением свойства, которое нужно сбросить.</param>
			// Token: 0x0600228A RID: 8842 RVA: 0x00077C70 File Offset: 0x00075E70
			public override void ResetValue(object component)
			{
				DefaultValueAttribute defaultValueAttribute = (DefaultValueAttribute)this.Attributes[typeof(DefaultValueAttribute)];
				if (defaultValueAttribute != null)
				{
					this.SetValue(component, defaultValueAttribute.Value);
				}
			}

			/// <summary>Возвращает значение, показывающее, может ли значение этого свойства быть сохранено.</summary>
			/// <param name="component">Компонент со свойством, для которого нужно проверить сохраняемость.</param>
			/// <returns>Значение <see langword="true" />, если значение свойства может быть сохранено; в противном случае — значение <see langword="false" />.</returns>
			// Token: 0x0600228B RID: 8843 RVA: 0x00003062 File Offset: 0x00001262
			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}

			// Token: 0x0400106F RID: 4207
			private Type componentType;

			// Token: 0x04001070 RID: 4208
			private Type propertyType;
		}

		/// <summary>Представляет коллекцию значений.</summary>
		// Token: 0x02000423 RID: 1059
		public class StandardValuesCollection : ICollection, IEnumerable
		{
			/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />.</summary>
			/// <param name="values">Объект <see cref="T:System.Collections.ICollection" />, представляющий объекты, которые должны войти в коллекцию.</param>
			// Token: 0x0600228C RID: 8844 RVA: 0x00077CA8 File Offset: 0x00075EA8
			public StandardValuesCollection(ICollection values)
			{
				if (values == null)
				{
					values = new object[0];
				}
				Array array = values as Array;
				if (array != null)
				{
					this.valueArray = array;
				}
				this.values = values;
			}

			/// <summary>Получает количество объектов в коллекции.</summary>
			/// <returns>Количество объектов в коллекции.</returns>
			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x0600228D RID: 8845 RVA: 0x00077CDE File Offset: 0x00075EDE
			public int Count
			{
				get
				{
					if (this.valueArray != null)
					{
						return this.valueArray.Length;
					}
					return this.values.Count;
				}
			}

			/// <summary>Возвращает объект с заданным индексом.</summary>
			/// <param name="index">Индекс объекта (отсчитываемый с нуля) <see cref="T:System.Object" />, возвращаемого из коллекции.</param>
			/// <returns>Объект <see cref="T:System.Object" /> с заданным индексом.</returns>
			// Token: 0x1700071F RID: 1823
			public object this[int index]
			{
				get
				{
					if (this.valueArray != null)
					{
						return this.valueArray.GetValue(index);
					}
					IList list = this.values as IList;
					if (list != null)
					{
						return list[index];
					}
					this.valueArray = new object[this.values.Count];
					this.values.CopyTo(this.valueArray, 0);
					return this.valueArray.GetValue(index);
				}
			}

			/// <summary>Копирует содержимое коллекции в массив.</summary>
			/// <param name="array">Объект <see cref="T:System.Array" />, представляющий массив, в который будет производиться копирование.</param>
			/// <param name="index">Начальный индекс.</param>
			// Token: 0x0600228F RID: 8847 RVA: 0x00077D6D File Offset: 0x00075F6D
			public void CopyTo(Array array, int index)
			{
				this.values.CopyTo(array, index);
			}

			/// <summary>Возвращает перечислитель для этой коллекции.</summary>
			/// <returns>Перечислитель типа <see cref="T:System.Collections.IEnumerator" />.</returns>
			// Token: 0x06002290 RID: 8848 RVA: 0x00077D7C File Offset: 0x00075F7C
			public IEnumerator GetEnumerator()
			{
				return this.values.GetEnumerator();
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.Count" />.</summary>
			/// <returns>Число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.ICollection" />.</returns>
			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x06002291 RID: 8849 RVA: 0x00077D89 File Offset: 0x00075F89
			int ICollection.Count
			{
				get
				{
					return this.Count;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
			/// <returns>Значение <see langword="false" /> во всех случаях.</returns>
			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x06002292 RID: 8850 RVA: 0x00003062 File Offset: 0x00001262
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
			/// <returns>Значение <see langword="null" /> во всех случаях.</returns>
			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x06002293 RID: 8851 RVA: 0x00002F6A File Offset: 0x0000116A
			object ICollection.SyncRoot
			{
				get
				{
					return null;
				}
			}

			/// <summary>Копирует содержимое коллекции в массив.</summary>
			/// <param name="array">Массив для копирования данных.</param>
			/// <param name="index">Индекс в массиве, начиная с которого должно начаться копирование.</param>
			// Token: 0x06002294 RID: 8852 RVA: 0x00077D91 File Offset: 0x00075F91
			void ICollection.CopyTo(Array array, int index)
			{
				this.CopyTo(array, index);
			}

			/// <summary>Описание этого члена см. в разделе <see cref="M:System.Collections.IEnumerable.GetEnumerator" />.</summary>
			/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
			// Token: 0x06002295 RID: 8853 RVA: 0x00077D9B File Offset: 0x00075F9B
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04001071 RID: 4209
			private ICollection values;

			// Token: 0x04001072 RID: 4210
			private Array valueArray;
		}
	}
}
