using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing.Text;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace System.Drawing
{
	/// <summary>Преобразует объекты <see cref="T:System.Drawing.Font" /> из одного типа данных в другой.</summary>
	// Token: 0x0200006D RID: 109
	public class FontConverter : TypeConverter
	{
		/// <summary>Позволяет объекту <see cref="T:System.Drawing.FontConverter" /> попытаться освободить ресурсы и выполнить другие завершающие операции, перед тем как объект <see cref="T:System.Drawing.FontConverter" /> будет уничтожен в процессе сборки мусора.</summary>
		// Token: 0x0600047B RID: 1147 RVA: 0x0000BB70 File Offset: 0x00009D70
		~FontConverter()
		{
		}

		/// <summary>Определяет, может ли этот преобразователь преобразовывать объект заданного исходного типа в собственный тип преобразователя.</summary>
		/// <param name="context">Контекст модуля форматирования. Данный объект может использоваться для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="sourceType">Тип, из которого нужно выполнить преобразование.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если объект может выполнить преобразование.</returns>
		// Token: 0x0600047C RID: 1148 RVA: 0x00003338 File Offset: 0x00001538
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Возвращает значение, указывающее, может ли данный преобразователь преобразовать объект с помощью контекста в заданный конечный тип.</summary>
		/// <param name="context">Объект <see langword="ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">Объект <see cref="T:System.Type" />, представляющий тип, в который происходит преобразование.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если объект может выполнить преобразование; в противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x0600047D RID: 1149 RVA: 0x0000BB98 File Offset: 0x00009D98
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Преобразует указанный объект в другой тип.</summary>
		/// <param name="context">Контекст модуля форматирования. Данный объект может использоваться для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, задающий язык и региональные параметры, используемые для представления объекта.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <param name="destinationType">Тип данных, в который требуется преобразовать объект.</param>
		/// <returns>Преобразованный объект.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не удалось.</exception>
		// Token: 0x0600047E RID: 1150 RVA: 0x0000BBCC File Offset: 0x00009DCC
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string) && value is Font)
			{
				Font font = (Font)value;
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(font.Name).Append(culture.TextInfo.ListSeparator[0].ToString() + " ");
				stringBuilder.Append(font.Size);
				switch (font.Unit)
				{
				case GraphicsUnit.World:
					stringBuilder.Append("world");
					break;
				case GraphicsUnit.Display:
					stringBuilder.Append("display");
					break;
				case GraphicsUnit.Pixel:
					stringBuilder.Append("px");
					break;
				case GraphicsUnit.Point:
					stringBuilder.Append("pt");
					break;
				case GraphicsUnit.Inch:
					stringBuilder.Append("in");
					break;
				case GraphicsUnit.Document:
					stringBuilder.Append("doc");
					break;
				case GraphicsUnit.Millimeter:
					stringBuilder.Append("mm");
					break;
				}
				if (font.Style != FontStyle.Regular)
				{
					stringBuilder.Append(culture.TextInfo.ListSeparator[0].ToString() + " style=").Append(font.Style);
				}
				return stringBuilder.ToString();
			}
			if (destinationType == typeof(InstanceDescriptor) && value is Font)
			{
				Font font2 = (Font)value;
				return new InstanceDescriptor(typeof(Font).GetTypeInfo().GetConstructor(new Type[]
				{
					typeof(string),
					typeof(float),
					typeof(FontStyle),
					typeof(GraphicsUnit)
				}), new object[]
				{
					font2.Name,
					font2.Size,
					font2.Style,
					font2.Unit
				});
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Преобразует указанный объект в собственный тип преобразователя.</summary>
		/// <param name="context">Контекст модуля форматирования. Данный объект может использоваться для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="culture">Объект <see langword="CultureInfo" />, задающий язык и региональные параметры, используемые для представления шрифта.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованный объект.</returns>
		/// <exception cref="T:System.NotSupportedException">Не удалось выполнить преобразование.</exception>
		// Token: 0x0600047F RID: 1151 RVA: 0x0000BDEC File Offset: 0x00009FEC
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (!(value is string))
			{
				return base.ConvertFrom(context, culture, value);
			}
			string text = (string)value;
			text = text.Trim();
			if (text.Length == 0)
			{
				return null;
			}
			if (culture == null)
			{
				culture = CultureInfo.CurrentCulture;
			}
			string[] array = text.Split(new char[]
			{
				culture.TextInfo.ListSeparator[0]
			});
			if (array.Length < 1)
			{
				throw new ArgumentException("Failed to parse font format");
			}
			text = array[0];
			float emSize = 8f;
			string a = "px";
			GraphicsUnit unit = GraphicsUnit.Pixel;
			if (array.Length > 1)
			{
				for (int i = 0; i < array[1].Length; i++)
				{
					if (char.IsLetter(array[1][i]))
					{
						emSize = (float)TypeDescriptor.GetConverter(typeof(float)).ConvertFromString(context, culture, array[1].Substring(0, i));
						a = array[1].Substring(i);
						break;
					}
				}
				if (a == "display")
				{
					unit = GraphicsUnit.Display;
				}
				else if (a == "doc")
				{
					unit = GraphicsUnit.Document;
				}
				else if (a == "pt")
				{
					unit = GraphicsUnit.Point;
				}
				else if (a == "in")
				{
					unit = GraphicsUnit.Inch;
				}
				else if (a == "mm")
				{
					unit = GraphicsUnit.Millimeter;
				}
				else if (a == "px")
				{
					unit = GraphicsUnit.Pixel;
				}
				else if (a == "world")
				{
					unit = GraphicsUnit.World;
				}
			}
			FontStyle fontStyle = FontStyle.Regular;
			if (array.Length > 2)
			{
				for (int j = 2; j < array.Length; j++)
				{
					string text2 = array[j];
					if (text2.IndexOf("Regular") != -1)
					{
						fontStyle |= FontStyle.Regular;
					}
					if (text2.IndexOf("Bold") != -1)
					{
						fontStyle |= FontStyle.Bold;
					}
					if (text2.IndexOf("Italic") != -1)
					{
						fontStyle |= FontStyle.Italic;
					}
					if (text2.IndexOf("Strikeout") != -1)
					{
						fontStyle |= FontStyle.Strikeout;
					}
					if (text2.IndexOf("Underline") != -1)
					{
						fontStyle |= FontStyle.Underline;
					}
				}
			}
			return new Font(text, emSize, fontStyle, unit);
		}

		/// <summary>Создает объект данного типа, используя указанный набор значений свойств для объекта.</summary>
		/// <param name="context">Дескриптор типа, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <param name="propertyValues">Словарь новых значений свойств. Словарь содержит ряд пар имя-значение, по одной для каждого свойства, возвращенного из метода <see cref="Overload:System.Drawing.FontConverter.GetProperties" />.</param>
		/// <returns>Вновь созданный объект или <see langword="null" />, если объект не был создан. Реализация по умолчанию возвращает значение <see langword="null" />.  
		///  Метод <see cref="M:System.Drawing.FontConverter.CreateInstance(System.ComponentModel.ITypeDescriptorContext,System.Collections.IDictionary)" /> полезен при создании неизменяемых объектов с изменяемыми свойствами.</returns>
		// Token: 0x06000480 RID: 1152 RVA: 0x0000BFE0 File Offset: 0x0000A1E0
		public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			byte gdiCharSet = 1;
			float emSize = 8f;
			string text = null;
			bool gdiVerticalFont = false;
			FontStyle fontStyle = FontStyle.Regular;
			FontFamily fontFamily = null;
			GraphicsUnit unit = GraphicsUnit.Point;
			object obj;
			if ((obj = propertyValues["GdiCharSet"]) != null)
			{
				gdiCharSet = (byte)obj;
			}
			if ((obj = propertyValues["Size"]) != null)
			{
				emSize = (float)obj;
			}
			if ((obj = propertyValues["Unit"]) != null)
			{
				unit = (GraphicsUnit)obj;
			}
			if ((obj = propertyValues["Name"]) != null)
			{
				text = (string)obj;
			}
			if ((obj = propertyValues["GdiVerticalFont"]) != null)
			{
				gdiVerticalFont = (bool)obj;
			}
			if ((obj = propertyValues["Bold"]) != null && (bool)obj)
			{
				fontStyle |= FontStyle.Bold;
			}
			if ((obj = propertyValues["Italic"]) != null && (bool)obj)
			{
				fontStyle |= FontStyle.Italic;
			}
			if ((obj = propertyValues["Strikeout"]) != null && (bool)obj)
			{
				fontStyle |= FontStyle.Strikeout;
			}
			if ((obj = propertyValues["Underline"]) != null && (bool)obj)
			{
				fontStyle |= FontStyle.Underline;
			}
			if (text == null)
			{
				fontFamily = new FontFamily("Tahoma");
			}
			else
			{
				text = text.ToLower();
				foreach (FontFamily fontFamily2 in new InstalledFontCollection().Families)
				{
					if (text == fontFamily2.Name.ToLower())
					{
						fontFamily = fontFamily2;
						break;
					}
				}
				if (fontFamily == null)
				{
					foreach (FontFamily fontFamily3 in new PrivateFontCollection().Families)
					{
						if (text == fontFamily3.Name.ToLower())
						{
							fontFamily = fontFamily3;
							break;
						}
					}
				}
				if (fontFamily == null)
				{
					fontFamily = FontFamily.GenericSansSerif;
				}
			}
			return new Font(fontFamily, emSize, fontStyle, unit, gdiCharSet, gdiVerticalFont);
		}

		/// <summary>Определяет, необходимо ли при изменении значения данного объекта вызывать метод <see cref="Overload:System.Drawing.FontConverter.CreateInstance" />, чтобы создать новое значение.</summary>
		/// <param name="context">Дескриптор типа, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если объект <see langword="CreateInstance" /> необходимо вызвать при изменении одного или нескольких свойств данного объекта. В противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000481 RID: 1153 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>Извлекает набор свойств для данного типа. По умолчанию тип не обладает свойствами, которые необходимо возвращать.</summary>
		/// <param name="context">Дескриптор типа, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <param name="value">Значение объекта, для которого извлекаются свойства.</param>
		/// <param name="attributes">Массив объектов <see cref="T:System.Attribute" />, описывающих свойства.</param>
		/// <returns>Набор свойств, который должен быть представлен для этого типа данных. Если представление свойств не требуется, может возвращаться значение <see langword="null" />. Реализация по умолчанию всегда возвращает значение <see langword="null" />.  
		/// Простая реализация данного метода может вызывать метод <see cref="Overload:System.ComponentModel.TypeConverter.GetProperties" /> для правильного типа данных.</returns>
		// Token: 0x06000482 RID: 1154 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			if (value is Font)
			{
				return TypeDescriptor.GetProperties(value, attributes);
			}
			return base.GetProperties(context, value, attributes);
		}

		/// <summary>Определяет, поддерживаются ли свойства этим объектом. Значение по умолчанию — <see langword="false" />.</summary>
		/// <param name="context">Дескриптор типа, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если для поиска свойств объекта следует вызывать метод <see cref="M:System.Drawing.FontConverter.GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext)" />, в противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000483 RID: 1155 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>
		///   <see cref="T:System.Drawing.FontConverter.FontNameConverter" /> — преобразователь типа, который используется для преобразования имени шрифта в другие различные представления и обратно.</summary>
		// Token: 0x0200006E RID: 110
		public sealed class FontNameConverter : TypeConverter, IDisposable
		{
			/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.FontConverter.FontNameConverter" />.</summary>
			// Token: 0x06000484 RID: 1156 RVA: 0x0000C1BB File Offset: 0x0000A3BB
			public FontNameConverter()
			{
				this.fonts = FontFamily.Families;
			}

			/// <summary>Выполняет определяемые приложением задачи, связанные с удалением, высвобождением или сбросом неуправляемых ресурсов.</summary>
			// Token: 0x06000485 RID: 1157 RVA: 0x000049FE File Offset: 0x00002BFE
			void IDisposable.Dispose()
			{
			}

			/// <summary>Определяет, может ли данный преобразователь преобразовывать объект заданного типа источника в собственный тип преобразователя.</summary>
			/// <param name="context">Параметр <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> может использоваться для получения дополнительных сведений о среде, из которой вызывается преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста могут также возвращать значение <see langword="null" />.</param>
			/// <param name="sourceType">Преобразуемый тип.</param>
			/// <returns>Значение <see langword="true" />, если преобразователь может выполнить преобразование; в противном случае — значение <see langword="false" />.</returns>
			// Token: 0x06000486 RID: 1158 RVA: 0x00003338 File Offset: 0x00001538
			public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
			{
				return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
			}

			/// <summary>Преобразует указанный объект в тип, используемый преобразователем.</summary>
			/// <param name="context">Параметр <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> может использоваться для получения дополнительных сведений о среде, из которой вызывается преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста могут также возвращать значение <see langword="null" />.</param>
			/// <param name="culture">Сведения <see cref="T:System.Globalization.CultureInfo" />, используемые для выполнения преобразования</param>
			/// <param name="value">Преобразуемый объект.</param>
			/// <returns>Преобразованный объект.</returns>
			/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
			// Token: 0x06000487 RID: 1159 RVA: 0x0000C1CE File Offset: 0x0000A3CE
			public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
			{
				if (value is string)
				{
					return value;
				}
				return base.ConvertFrom(context, culture, value);
			}

			/// <summary>Извлекает коллекцию, содержащую набор стандартных значений типов данных, для которых предназначен данный преобразователь.</summary>
			/// <param name="context">Параметр <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> может использоваться для получения дополнительных сведений о среде, из которой вызывается преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста могут также возвращать значение <see langword="null" />.</param>
			/// <returns>Коллекция, содержащая стандартный набор значений, или <see langword="null" />. Значение по умолчанию — <see langword="null" />.</returns>
			// Token: 0x06000488 RID: 1160 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
			public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
			{
				string[] array = new string[this.fonts.Length];
				int i = this.fonts.Length;
				while (i > 0)
				{
					i--;
					array[i] = this.fonts[i].Name;
				}
				return new TypeConverter.StandardValuesCollection(array);
			}

			/// <summary>Определяет, является ли список стандартных значений, возвращаемых из метода <see cref="Overload:System.Drawing.FontConverter.FontNameConverter.GetStandardValues" />, всеобъемлющим списком.</summary>
			/// <param name="context">Параметр <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> может использоваться для получения дополнительных сведений о среде, из которой вызывается преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста могут также возвращать значение <see langword="null" />.</param>
			/// <returns>Значение <see langword="true" />, если коллекция, возвращаемая из метода <see cref="Overload:System.Drawing.FontConverter.FontNameConverter.GetStandardValues" />, является всеобъемлющим списком возможных значений; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
			// Token: 0x06000489 RID: 1161 RVA: 0x0000C228 File Offset: 0x0000A428
			public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
			{
				return false;
			}

			/// <summary>Определяет, поддерживает ли объект стандартный набор значений, которые можно выбрать из списка.</summary>
			/// <param name="context">Параметр <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> может использоваться для получения дополнительных сведений о среде, из которой вызывается преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста могут также возвращать значение <see langword="null" />.</param>
			/// <returns>Имеет значение <see langword="true" />, если метод <see cref="Overload:System.Drawing.FontConverter.FontNameConverter.GetStandardValues" /> должен быть вызван для поиска общего набора значений, поддерживаемых объектом, в противном случае — значение <see langword="false" />.</returns>
			// Token: 0x0600048A RID: 1162 RVA: 0x00003610 File Offset: 0x00001810
			public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
			{
				return true;
			}

			// Token: 0x04000491 RID: 1169
			private FontFamily[] fonts;
		}

		/// <summary>Преобразует единицы шрифта в другие типы единиц и обратно.</summary>
		// Token: 0x0200006F RID: 111
		public class FontUnitConverter : EnumConverter
		{
			/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.FontConverter.FontUnitConverter" />.</summary>
			// Token: 0x0600048B RID: 1163 RVA: 0x0000C22B File Offset: 0x0000A42B
			public FontUnitConverter() : base(typeof(GraphicsUnit))
			{
			}

			/// <summary>Возвращает коллекцию стандартных значений, действительных для типа данных <see cref="T:System.Drawing.Font" />.</summary>
			/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
			// Token: 0x0600048C RID: 1164 RVA: 0x0000C23D File Offset: 0x0000A43D
			public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
			{
				return base.GetStandardValues(context);
			}
		}
	}
}
