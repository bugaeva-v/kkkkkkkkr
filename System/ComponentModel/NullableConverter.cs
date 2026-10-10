using System;
using System.Collections;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Обеспечивает автоматическое преобразование между типом, допускающим значение null, и его базовым типом-примитивом.</summary>
	// Token: 0x020003DD RID: 989
	public class NullableConverter : TypeConverter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.NullableConverter" />.</summary>
		/// <param name="type">Заданный обнуляемый тип.</param>
		/// <exception cref="T:System.ArgumentException">Элемент <paramref name="type" /> не является обнуляемым типом.</exception>
		// Token: 0x06002035 RID: 8245 RVA: 0x0006F960 File Offset: 0x0006DB60
		public NullableConverter(Type type)
		{
			this.NullableType = type;
			this.UnderlyingType = Nullable.GetUnderlyingType(type);
			if (this.UnderlyingType == null)
			{
				throw new ArgumentException("The specified type is not a nullable type.", "type");
			}
			this.UnderlyingTypeConverter = TypeDescriptor.GetConverter(this.UnderlyingType);
		}

		/// <summary>Возвращает значение, указывающее, может ли этот преобразователь выполнить преобразование объекта заданного типа в тип этого преобразователя, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Объект <see cref="T:System.Type" />, представляющий тип, из которого нужно выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002036 RID: 8246 RVA: 0x0006F9B5 File Offset: 0x0006DBB5
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType == this.UnderlyingType)
			{
				return true;
			}
			if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.CanConvertFrom(context, sourceType);
			}
			return base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Преобразует заданный объект в тип этого преобразователя, используя указанные сведения о контексте и языке и региональных параметрах.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в качестве текущего языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06002037 RID: 8247 RVA: 0x0006F9E8 File Offset: 0x0006DBE8
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value == null || value.GetType() == this.UnderlyingType)
			{
				return value;
			}
			if (value is string && string.IsNullOrEmpty(value as string))
			{
				return null;
			}
			if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.ConvertFrom(context, culture, value);
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Возвращает значение, показывающее, может ли этот преобразователь преобразовать объект в заданный тип с помощью указанного контекста.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">Класс <see cref="T:System.Type" />, представляющий тип, в который нужно выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002038 RID: 8248 RVA: 0x0006FA44 File Offset: 0x0006DC44
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (destinationType == this.UnderlyingType)
			{
				return true;
			}
			if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.CanConvertTo(context, destinationType);
			}
			return base.CanConvertTo(context, destinationType);
		}

		/// <summary>Преобразует данный объект значения в указанный тип, используя заданные сведения о контексте, а также о языке и региональных параметрах.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в качестве текущего языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <param name="destinationType">Тип <see cref="T:System.Type" />, в который преобразуется параметр значения.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06002039 RID: 8249 RVA: 0x0006FA74 File Offset: 0x0006DC74
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == this.UnderlyingType && value != null && this.NullableType.IsInstanceOfType(value))
			{
				return value;
			}
			if (value == null)
			{
				if (destinationType == typeof(string))
				{
					return string.Empty;
				}
			}
			else if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.ConvertTo(context, culture, value, destinationType);
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Создает экземпляр типа, с которым связан этот <see cref="T:System.ComponentModel.TypeConverter" />, используя заданный контекст с учетом набора значений свойств для объекта.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="propertyValues">
		///   <see cref="T:System.Collections.IDictionary" /> новых значений свойств.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий данный <see cref="T:System.Collections.IDictionary" />, или <see langword="null" />, если объект не может быть создан. Этот метод всегда возвращает значение <see langword="null" />.</returns>
		// Token: 0x0600203A RID: 8250 RVA: 0x0006FAF8 File Offset: 0x0006DCF8
		public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.CreateInstance(context, propertyValues);
			}
			return base.CreateInstance(context, propertyValues);
		}

		/// <summary>Возвращает значение, показывающее, требуется ли при изменении значения этого объекта вызывать метод <see cref="M:System.ComponentModel.TypeConverter.CreateInstance(System.Collections.IDictionary)" />, чтобы создать новое значение, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="true" />, если при изменении значения этого объекта требуется вызывать метод <see cref="M:System.ComponentModel.TypeConverter.CreateInstance(System.Collections.IDictionary)" /> для создания нового значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600203B RID: 8251 RVA: 0x0006FB18 File Offset: 0x0006DD18
		public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.GetCreateInstanceSupported(context);
			}
			return base.GetCreateInstanceSupported(context);
		}

		/// <summary>Возвращает коллекцию свойств для типа массива, заданного параметром value, используя заданные контекст и атрибуты.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Объект класса <see cref="T:System.Object" />, задающий тип массива, для которого нужно получить свойства.</param>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, используемый в качестве фильтра.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> со свойствами, доступными для этого типа данных, или <see langword="null" />, если свойства отсутствуют.</returns>
		// Token: 0x0600203C RID: 8252 RVA: 0x0006FB38 File Offset: 0x0006DD38
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.GetProperties(context, value, attributes);
			}
			return base.GetProperties(context, value, attributes);
		}

		/// <summary>Возвращает значение, показывающее, поддерживает ли данный объект свойства, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Имеет значение <see langword="true" />, если для поиска свойств этого объекта следует вызвать метод <see cref="M:System.ComponentModel.TypeConverter.GetProperties(System.Object)" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600203D RID: 8253 RVA: 0x0006FB67 File Offset: 0x0006DD67
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.GetPropertiesSupported(context);
			}
			return base.GetPropertiesSupported(context);
		}

		/// <summary>Возвращает коллекцию стандартных значений для типа данных, для которого предназначен этот преобразователь типов при предоставлении с контекстом формата.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, содержащий контекст формата, который может быть использован для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Этот параметр или свойства этого параметра могут иметь значение <see langword="null" />.</param>
		/// <returns>
		///   <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, содержащий стандартный набор допустимых значений, или <see langword="null" />, если этот тип данных не поддерживает стандартный набор значений.</returns>
		// Token: 0x0600203E RID: 8254 RVA: 0x0006FB88 File Offset: 0x0006DD88
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			if (this.UnderlyingTypeConverter != null)
			{
				TypeConverter.StandardValuesCollection standardValues = this.UnderlyingTypeConverter.GetStandardValues(context);
				if (this.GetStandardValuesSupported(context) && standardValues != null)
				{
					object[] array = new object[standardValues.Count + 1];
					int num = 0;
					array[num++] = null;
					foreach (object obj in standardValues)
					{
						array[num++] = obj;
					}
					return new TypeConverter.StandardValuesCollection(array);
				}
			}
			return base.GetStandardValues(context);
		}

		/// <summary>Используя заданный контекст, возвращает значение, показывающее, является ли исчерпывающим списком возможных значений коллекция стандартных значений, возвращаемая методом <see cref="Overload:System.ComponentModel.TypeConverter.GetStandardValues" />.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Имеет значение <see langword="true" />, если объект класса <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, возвращенный методом <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" />, является исчерпывающим списком возможных значений, значение <see langword="false" />, если возможны другие значения.</returns>
		// Token: 0x0600203F RID: 8255 RVA: 0x0006FC24 File Offset: 0x0006DE24
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.GetStandardValuesExclusive(context);
			}
			return base.GetStandardValuesExclusive(context);
		}

		/// <summary>Получает значение, показывающее, поддерживает ли этот объект стандартный набор значений, которые можно выбрать из списка, используя заданную контекстную информацию.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="true" />, если метод <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" /> должен быть вызван для поиска общего набора значений, поддерживаемых объектом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002040 RID: 8256 RVA: 0x0006FC42 File Offset: 0x0006DE42
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			if (this.UnderlyingTypeConverter != null)
			{
				return this.UnderlyingTypeConverter.GetStandardValuesSupported(context);
			}
			return base.GetStandardValuesSupported(context);
		}

		/// <summary>Возвращает значение, показывающее, допустим ли для этого типа и указанного контекста данный объект значения.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, допустимость которого требуется проверить.</param>
		/// <returns>Значение <see langword="true" />, если заданное значение допустимо для этого объекта; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002041 RID: 8257 RVA: 0x0006FC60 File Offset: 0x0006DE60
		public override bool IsValid(ITypeDescriptorContext context, object value)
		{
			if (this.UnderlyingTypeConverter != null)
			{
				return value == null || this.UnderlyingTypeConverter.IsValid(context, value);
			}
			return base.IsValid(context, value);
		}

		/// <summary>Возвращает обнуляемый тип.</summary>
		/// <returns>Тип <see cref="T:System.Type" />, представляющий обнуляемый тип.</returns>
		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x0006FC92 File Offset: 0x0006DE92
		public Type NullableType { get; }

		/// <summary>Возвращает базовый тип.</summary>
		/// <returns>Тип <see cref="T:System.Type" />, представляющий базовый тип.</returns>
		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x0006FC9A File Offset: 0x0006DE9A
		public Type UnderlyingType { get; }

		/// <summary>Возвращает преобразователь базового типа.</summary>
		/// <returns>Преобразователь <see cref="T:System.ComponentModel.TypeConverter" />, представляющий преобразователь базового типа.</returns>
		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06002044 RID: 8260 RVA: 0x0006FCA2 File Offset: 0x0006DEA2
		public TypeConverter UnderlyingTypeConverter { get; }
	}
}
