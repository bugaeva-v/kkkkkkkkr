using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типов для преобразования объектов <see cref="T:System.Enum" /> в прочие представления и обратно.</summary>
	// Token: 0x02000415 RID: 1045
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public class EnumConverter : TypeConverter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.EnumConverter" /> для данного типа.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" />, представляющий тип перечисления, связываемый с этим преобразователем перечисления.</param>
		// Token: 0x060021BC RID: 8636 RVA: 0x000734DC File Offset: 0x000716DC
		public EnumConverter(Type type)
		{
			this.type = type;
		}

		/// <summary>Определяет тип перечислителя, с которым связан этот преобразователь.</summary>
		/// <returns>Определяет тип перечислителя, с которым связан этот преобразователь.</returns>
		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x000734EB File Offset: 0x000716EB
		protected Type EnumType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Получает или задает коллекцию <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, определяющую возможные значения для перечисления.</summary>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, определяющая возможные значения для перечисления.</returns>
		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x000734F3 File Offset: 0x000716F3
		// (set) Token: 0x060021BF RID: 8639 RVA: 0x000734FB File Offset: 0x000716FB
		protected TypeConverter.StandardValuesCollection Values
		{
			get
			{
				return this.values;
			}
			set
			{
				this.values = value;
			}
		}

		/// <summary>Возвращает значение, показывающее, может ли этот преобразователь выполнить преобразование объекта заданного исходного типа в объект перечисления, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Тип <see cref="T:System.Type" />, представляющий тип, из которого нужно выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060021C0 RID: 8640 RVA: 0x00073504 File Offset: 0x00071704
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || sourceType == typeof(Enum[]) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Возвращает значение, указывающее, может ли данный преобразователь преобразовать объект с помощью контекста в заданный конечный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">Объект <see cref="T:System.Type" />, представляющий тип, в который необходимо выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060021C1 RID: 8641 RVA: 0x00073534 File Offset: 0x00071734
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || destinationType == typeof(Enum[]) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Возвращает интерфейс сравнения <see cref="T:System.Collections.IComparer" />, который может использоваться для выполнения сортировки значений перечисления.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IComparer" /> для сортировки значений перечисления.</returns>
		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x00073564 File Offset: 0x00071764
		protected virtual IComparer Comparer
		{
			get
			{
				return InvariantComparer.Default;
			}
		}

		/// <summary>Преобразует заданный объект значения в объект перечисления.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Необязательный класс <see cref="T:System.Globalization.CultureInfo" />. Если не предоставляются, предполагается использование текущего языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий преобразованное значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.FormatException">Значение <paramref name="value" /> не является допустимым значением для конечного типа.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x060021C3 RID: 8643 RVA: 0x0007356C File Offset: 0x0007176C
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string)
			{
				try
				{
					string text = (string)value;
					if (text.IndexOf(',') != -1)
					{
						long num = 0L;
						foreach (string value2 in text.Split(new char[]
						{
							','
						}))
						{
							num |= Convert.ToInt64((Enum)Enum.Parse(this.type, value2, true), culture);
						}
						return Enum.ToObject(this.type, num);
					}
					return Enum.Parse(this.type, text, true);
				}
				catch (Exception innerException)
				{
					throw new FormatException(SR.GetString("{0} is not a valid value for {1}.", new object[]
					{
						(string)value,
						this.type.Name
					}), innerException);
				}
			}
			if (value is Enum[])
			{
				long num2 = 0L;
				foreach (Enum value3 in (Enum[])value)
				{
					num2 |= Convert.ToInt64(value3, culture);
				}
				return Enum.ToObject(this.type, num2);
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Преобразовывает указанное значение объекта в указанный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Необязательный класс <see cref="T:System.Globalization.CultureInfo" />. Если не предоставляются, предполагается использование текущего языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <param name="destinationType">Тип <see cref="T:System.Type" />, к которому следует привести значение.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий преобразованное значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="value" /> не является допустимым значением перечисления.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x060021C4 RID: 8644 RVA: 0x00073690 File Offset: 0x00071890
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(string) && value != null)
			{
				Type underlyingType = Enum.GetUnderlyingType(this.type);
				if (value is IConvertible && value.GetType() != underlyingType)
				{
					value = ((IConvertible)value).ToType(underlyingType, culture);
				}
				if (!this.type.IsDefined(typeof(FlagsAttribute), false) && !Enum.IsDefined(this.type, value))
				{
					throw new ArgumentException(SR.GetString("The value '{0}' is not a valid value for the enum '{1}'.", new object[]
					{
						value.ToString(),
						this.type.Name
					}));
				}
				return Enum.Format(this.type, value, "G");
			}
			else
			{
				if (destinationType == typeof(InstanceDescriptor) && value != null)
				{
					string text = base.ConvertToInvariantString(context, value);
					if (this.type.IsDefined(typeof(FlagsAttribute), false) && text.IndexOf(',') != -1)
					{
						Type underlyingType2 = Enum.GetUnderlyingType(this.type);
						if (value is IConvertible)
						{
							object obj = ((IConvertible)value).ToType(underlyingType2, culture);
							MethodInfo method = typeof(Enum).GetMethod("ToObject", new Type[]
							{
								typeof(Type),
								underlyingType2
							});
							if (method != null)
							{
								return new InstanceDescriptor(method, new object[]
								{
									this.type,
									obj
								});
							}
						}
					}
					else
					{
						FieldInfo field = this.type.GetField(text);
						if (field != null)
						{
							return new InstanceDescriptor(field, null);
						}
					}
				}
				if (!(destinationType == typeof(Enum[])) || value == null)
				{
					return base.ConvertTo(context, culture, value, destinationType);
				}
				if (this.type.IsDefined(typeof(FlagsAttribute), false))
				{
					List<Enum> list = new List<Enum>();
					Array array = Enum.GetValues(this.type);
					long[] array2 = new long[array.Length];
					for (int i = 0; i < array.Length; i++)
					{
						array2[i] = Convert.ToInt64((Enum)array.GetValue(i), culture);
					}
					long num = Convert.ToInt64((Enum)value, culture);
					bool flag = true;
					while (flag)
					{
						flag = false;
						foreach (long num2 in array2)
						{
							if ((num2 != 0L && (num2 & num) == num2) || num2 == num)
							{
								list.Add((Enum)Enum.ToObject(this.type, num2));
								flag = true;
								num &= ~num2;
								break;
							}
						}
						if (num == 0L)
						{
							break;
						}
					}
					if (!flag && num != 0L)
					{
						list.Add((Enum)Enum.ToObject(this.type, num));
					}
					return list.ToArray();
				}
				return new Enum[]
				{
					(Enum)Enum.ToObject(this.type, value)
				};
			}
		}

		/// <summary>Получает коллекцию стандартных значений для того типа данных, для которого предназначен данный проверяющий элемент управления.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>
		///   <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, содержащий стандартный набор допустимых значений, или <see langword="null" />, если этот тип данных не поддерживает стандартный набор значений.</returns>
		// Token: 0x060021C5 RID: 8645 RVA: 0x00073994 File Offset: 0x00071B94
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			if (this.values == null)
			{
				Type reflectionType = TypeDescriptor.GetReflectionType(this.type);
				if (reflectionType == null)
				{
					reflectionType = this.type;
				}
				FieldInfo[] fields = reflectionType.GetFields(BindingFlags.Static | BindingFlags.Public);
				ArrayList arrayList = null;
				if (fields != null && fields.Length != 0)
				{
					arrayList = new ArrayList(fields.Length);
				}
				if (arrayList != null)
				{
					foreach (FieldInfo fieldInfo in fields)
					{
						BrowsableAttribute browsableAttribute = null;
						object[] customAttributes = fieldInfo.GetCustomAttributes(typeof(BrowsableAttribute), false);
						for (int j = 0; j < customAttributes.Length; j++)
						{
							browsableAttribute = (((Attribute)customAttributes[j]) as BrowsableAttribute);
						}
						if (browsableAttribute == null || browsableAttribute.Browsable)
						{
							object obj = null;
							try
							{
								if (fieldInfo.Name != null)
								{
									obj = Enum.Parse(this.type, fieldInfo.Name);
								}
							}
							catch (ArgumentException)
							{
							}
							if (obj != null)
							{
								arrayList.Add(obj);
							}
						}
					}
					IComparer comparer = this.Comparer;
					if (comparer != null)
					{
						arrayList.Sort(comparer);
					}
				}
				Array array2 = (arrayList != null) ? arrayList.ToArray() : null;
				this.values = new TypeConverter.StandardValuesCollection(array2);
			}
			return this.values;
		}

		/// <summary>Возвращает значение, показывающее, является ли список стандартных значений, возвращаемых методом <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" />, исчерпывающим списком в заданном контексте.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Имеет значение <see langword="true" />, если объект класса <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, возвращенный методом <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" />, является исчерпывающим списком возможных значений, значение <see langword="false" />, если возможны другие значения.</returns>
		// Token: 0x060021C6 RID: 8646 RVA: 0x00073ACC File Offset: 0x00071CCC
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return !this.type.IsDefined(typeof(FlagsAttribute), false);
		}

		/// <summary>Возвращает значение, показывающее, поддерживает ли этот объект стандартный набор значений, которые можно выбрать из списка, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="true" />, поскольку для поиска набора значений, поддерживаемых объектом, необходимо вызвать метод <see cref="M:System.ComponentModel.TypeConverter.GetStandardValues" />. Этот метод никогда не возвращает значение <see langword="false" />.</returns>
		// Token: 0x060021C7 RID: 8647 RVA: 0x0000390E File Offset: 0x00001B0E
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>Возвращает значение, показывающее, допустимо ли данное значение объекта для этого типа.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Объект <see cref="T:System.Object" /> для проверки.</param>
		/// <returns>Значение <see langword="true" />, если заданное значение допустимо для этого объекта; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060021C8 RID: 8648 RVA: 0x00073AE7 File Offset: 0x00071CE7
		public override bool IsValid(ITypeDescriptorContext context, object value)
		{
			return Enum.IsDefined(this.type, value);
		}

		// Token: 0x04001027 RID: 4135
		private TypeConverter.StandardValuesCollection values;

		// Token: 0x04001028 RID: 4136
		private Type type;
	}
}
