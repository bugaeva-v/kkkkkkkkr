using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System.Drawing
{
	/// <summary>Преобразует цвета одного типа данных в другой. Доступ к данному классу осуществляется с помощью объекта <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
	// Token: 0x0200001C RID: 28
	public class ColorConverter : TypeConverter
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00003E14 File Offset: 0x00002014
		private static Hashtable Colors
		{
			get
			{
				if (ColorConverter.colorConstants == null)
				{
					string colorConstantsLock = ColorConverter.ColorConstantsLock;
					lock (colorConstantsLock)
					{
						if (ColorConverter.colorConstants == null)
						{
							Hashtable hash = new Hashtable(StringComparer.OrdinalIgnoreCase);
							ColorConverter.FillConstants(hash, typeof(Color));
							ColorConverter.colorConstants = hash;
						}
					}
				}
				return ColorConverter.colorConstants;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003E80 File Offset: 0x00002080
		private static Hashtable SystemColors
		{
			get
			{
				if (ColorConverter.systemColorConstants == null)
				{
					string systemColorConstantsLock = ColorConverter.SystemColorConstantsLock;
					lock (systemColorConstantsLock)
					{
						if (ColorConverter.systemColorConstants == null)
						{
							Hashtable hash = new Hashtable(StringComparer.OrdinalIgnoreCase);
							ColorConverter.FillConstants(hash, typeof(SystemColors));
							ColorConverter.systemColorConstants = hash;
						}
					}
				}
				return ColorConverter.systemColorConstants;
			}
		}

		/// <summary>Определяет, может ли данный преобразователь преобразовывать объект заданного типа источника в собственный тип преобразователя.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата. Этот объект можно использовать для получения дополнительных сведений о среде, из которой вызывается данный преобразователь.</param>
		/// <param name="sourceType">Тип, из которого нужно выполнить преобразование.</param>
		/// <returns>
		///   <see langword="true" />, если этот объект может выполнить преобразование; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000074 RID: 116 RVA: 0x00003338 File Offset: 0x00001538
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Возвращает значение, показывающее, может ли данный преобразователь преобразовать объект с помощью контекста в конечный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">
		///   <see cref="T:System.Type" /> представляет нужный результат конвертирования.</param>
		/// <returns>Значение <see langword="true" />, если данный преобразователь может выполнить операцию, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000075 RID: 117 RVA: 0x00003356 File Offset: 0x00001556
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003EEC File Offset: 0x000020EC
		internal static object GetNamedColor(string name)
		{
			object obj = ColorConverter.Colors[name];
			if (obj != null)
			{
				return obj;
			}
			return ColorConverter.SystemColors[name];
		}

		/// <summary>Преобразует указанный объект в тип, используемый преобразователем.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.TypeDescriptor" />, предоставляющий контекст формата. Этот объект можно использовать для получения дополнительных сведений о среде, из которой вызывается данный преобразователь.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, определяющий язык и региональные параметры для представления цвета.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий конвертируемое значение.</returns>
		/// <exception cref="T:System.ArgumentException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06000077 RID: 119 RVA: 0x00003F1C File Offset: 0x0000211C
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (text != null)
			{
				object obj = null;
				string text2 = text.Trim();
				if (text2.Length == 0)
				{
					obj = Color.Empty;
				}
				else
				{
					obj = ColorConverter.GetNamedColor(text2);
					if (obj == null)
					{
						if (culture == null)
						{
							culture = CultureInfo.CurrentCulture;
						}
						char c = culture.TextInfo.ListSeparator[0];
						bool flag = true;
						TypeConverter converter = TypeDescriptor.GetConverter(typeof(int));
						if (text2.IndexOf(c) == -1)
						{
							if (text2.Length >= 2 && (text2[0] == '\'' || text2[0] == '"') && text2[0] == text2[text2.Length - 1])
							{
								obj = Color.FromName(text2.Substring(1, text2.Length - 2));
								flag = false;
							}
							else if ((text2.Length == 7 && text2[0] == '#') || (text2.Length == 8 && (text2.StartsWith("0x") || text2.StartsWith("0X"))) || (text2.Length == 8 && (text2.StartsWith("&h") || text2.StartsWith("&H"))))
							{
								obj = Color.FromArgb(-16777216 | (int)converter.ConvertFromString(context, culture, text2));
							}
						}
						if (obj == null)
						{
							string[] array = text2.Split(new char[]
							{
								c
							});
							int[] array2 = new int[array.Length];
							for (int i = 0; i < array2.Length; i++)
							{
								array2[i] = (int)converter.ConvertFromString(context, culture, array[i]);
							}
							switch (array2.Length)
							{
							case 1:
								obj = Color.FromArgb(array2[0]);
								break;
							case 3:
								obj = Color.FromArgb(array2[0], array2[1], array2[2]);
								break;
							case 4:
								obj = Color.FromArgb(array2[0], array2[1], array2[2], array2[3]);
								break;
							}
							flag = true;
						}
						if (obj != null && flag)
						{
							int num = ((Color)obj).ToArgb();
							foreach (object obj2 in ColorConverter.Colors.Values)
							{
								Color color = (Color)obj2;
								if (color.ToArgb() == num)
								{
									obj = color;
									break;
								}
							}
						}
					}
					if (obj == null)
					{
						throw new ArgumentException(SR.Format("Color '{0}' is not valid.", new object[]
						{
							text2
						}));
					}
				}
				return obj;
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Преобразует указанный объект в другой тип.</summary>
		/// <param name="context">Контекст модуля форматирования. Используйте этот объект для получения дополнительных сведений о среде, из которой вызывается данный преобразователь. Всегда проверяйте, не равно ли данное значение значению <see langword="null" />. Свойства объекта контекста могут также возвращать значение <see langword="null" />.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, определяющий язык и региональные параметры для представления цвета.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <param name="destinationType">Тип, в который требуется преобразовать объект.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий конвертируемое значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationtype" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06000078 RID: 120 RVA: 0x000041D0 File Offset: 0x000023D0
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (value is Color)
			{
				if (destinationType == typeof(string))
				{
					Color left = (Color)value;
					if (left == Color.Empty)
					{
						return string.Empty;
					}
					if (left.IsKnownColor)
					{
						return left.Name;
					}
					if (left.IsNamedColor)
					{
						return "'" + left.Name + "'";
					}
					if (culture == null)
					{
						culture = CultureInfo.CurrentCulture;
					}
					string separator = culture.TextInfo.ListSeparator + " ";
					TypeConverter converter = TypeDescriptor.GetConverter(typeof(int));
					int num = 0;
					string[] array;
					if (left.A < 255)
					{
						array = new string[4];
						array[num++] = converter.ConvertToString(context, culture, left.A);
					}
					else
					{
						array = new string[3];
					}
					array[num++] = converter.ConvertToString(context, culture, left.R);
					array[num++] = converter.ConvertToString(context, culture, left.G);
					array[num++] = converter.ConvertToString(context, culture, left.B);
					return string.Join(separator, array);
				}
				else if (destinationType == typeof(InstanceDescriptor))
				{
					object[] arguments = null;
					Color color = (Color)value;
					MemberInfo memberInfo;
					if (color.IsEmpty)
					{
						memberInfo = typeof(Color).GetField("Empty");
					}
					else if (color.IsSystemColor)
					{
						memberInfo = typeof(SystemColors).GetProperty(color.Name);
					}
					else if (color.IsKnownColor)
					{
						memberInfo = typeof(Color).GetProperty(color.Name);
					}
					else if (color.A != 255)
					{
						memberInfo = typeof(Color).GetMethod("FromArgb", new Type[]
						{
							typeof(int),
							typeof(int),
							typeof(int),
							typeof(int)
						});
						arguments = new object[]
						{
							color.A,
							color.R,
							color.G,
							color.B
						};
					}
					else if (color.IsNamedColor)
					{
						memberInfo = typeof(Color).GetMethod("FromName", new Type[]
						{
							typeof(string)
						});
						arguments = new object[]
						{
							color.Name
						};
					}
					else
					{
						memberInfo = typeof(Color).GetMethod("FromArgb", new Type[]
						{
							typeof(int),
							typeof(int),
							typeof(int)
						});
						arguments = new object[]
						{
							color.R,
							color.G,
							color.B
						};
					}
					if (memberInfo != null)
					{
						return new InstanceDescriptor(memberInfo, arguments);
					}
					return null;
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004540 File Offset: 0x00002740
		private static void FillConstants(Hashtable hash, Type enumType)
		{
			MethodAttributes methodAttributes = MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static;
			foreach (PropertyInfo propertyInfo in enumType.GetProperties())
			{
				if (propertyInfo.PropertyType == typeof(Color))
				{
					MethodInfo getMethod = propertyInfo.GetGetMethod();
					if (getMethod != null && (getMethod.Attributes & methodAttributes) == methodAttributes)
					{
						object[] index = null;
						hash[propertyInfo.Name] = propertyInfo.GetValue(null, index);
					}
				}
			}
		}

		/// <summary>Извлекает коллекцию, содержащую набор стандартных значений типов данных, для которых предназначен данный проверяющий элемент управления. Если тип данных не поддерживает стандартный набор значений, будет возвращено значение <see langword="null" />,.</summary>
		/// <param name="context">Контекст модуля форматирования. Используйте этот объект для получения дополнительных сведений о среде, из которой вызывается данный преобразователь. Всегда проверяйте, не равно ли данное значение значению <see langword="null" />. Свойства объекта контекста могут также возвращать значение <see langword="null" />.</param>
		/// <returns>Коллекция, содержащая значение <see langword="null" /> или стандартный набор допустимых значений. Реализация по умолчанию всегда возвращает значение <see langword="null" />.</returns>
		// Token: 0x0600007A RID: 122 RVA: 0x000045B8 File Offset: 0x000027B8
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			if (ColorConverter.values == null)
			{
				string valuesLock = ColorConverter.ValuesLock;
				lock (valuesLock)
				{
					if (ColorConverter.values == null)
					{
						ArrayList arrayList = new ArrayList();
						arrayList.AddRange(ColorConverter.Colors.Values);
						arrayList.AddRange(ColorConverter.SystemColors.Values);
						int num = arrayList.Count;
						for (int i = 0; i < num - 1; i++)
						{
							for (int j = i + 1; j < num; j++)
							{
								if (arrayList[i].Equals(arrayList[j]))
								{
									arrayList.RemoveAt(j);
									num--;
									j--;
								}
							}
						}
						arrayList.Sort(0, arrayList.Count, new ColorConverter.ColorComparer());
						ColorConverter.values = new TypeConverter.StandardValuesCollection(arrayList.ToArray());
					}
				}
			}
			return ColorConverter.values;
		}

		/// <summary>Определяет, поддерживает ли объект стандартный набор значений, которые можно выбрать в списке.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.TypeDescriptor" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <returns>Значение <see langword="true" />, если метод <see cref="Overload:System.Drawing.ColorConverter.GetStandardValues" /> должен быть вызван для поиска набора значений, поддерживаемых объектом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600007B RID: 123 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x04000155 RID: 341
		private static string ColorConstantsLock = "colorConstants";

		// Token: 0x04000156 RID: 342
		private static Hashtable colorConstants;

		// Token: 0x04000157 RID: 343
		private static string SystemColorConstantsLock = "systemColorConstants";

		// Token: 0x04000158 RID: 344
		private static Hashtable systemColorConstants;

		// Token: 0x04000159 RID: 345
		private static string ValuesLock = "values";

		// Token: 0x0400015A RID: 346
		private static TypeConverter.StandardValuesCollection values;

		// Token: 0x0200001D RID: 29
		private class ColorComparer : IComparer
		{
			// Token: 0x0600007D RID: 125 RVA: 0x000046C8 File Offset: 0x000028C8
			public int Compare(object left, object right)
			{
				Color color = (Color)left;
				Color color2 = (Color)right;
				return string.Compare(color.Name, color2.Name, false, CultureInfo.InvariantCulture);
			}
		}
	}
}
