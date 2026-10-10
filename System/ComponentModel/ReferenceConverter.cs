using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типа для преобразования ссылок объектов в прочие представления и обратно.</summary>
	// Token: 0x020003E4 RID: 996
	public class ReferenceConverter : TypeConverter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ReferenceConverter" />.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" />, представляющий тип для связи с этим преобразователем ссылок.</param>
		// Token: 0x060020B2 RID: 8370 RVA: 0x00070D52 File Offset: 0x0006EF52
		public ReferenceConverter(Type type)
		{
			this._type = type;
		}

		/// <summary>Возвращает значение, показывающее, может ли этот преобразователь выполнить преобразование объекта заданного исходного типа в объект ссылки, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Тип <see cref="T:System.Type" />, представляющий тип, из которого нужно выполнить преобразование.</param>
		/// <returns>
		///   <see langword="true" />, если этот объект может выполнить преобразование; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060020B3 RID: 8371 RVA: 0x00070D61 File Offset: 0x0006EF61
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return (sourceType == typeof(string) && context != null) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Приводит заданный объект к ссылочному типу.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, задающий язык и региональные параметры, используемые для представления шрифта.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий преобразованное значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x060020B4 RID: 8372 RVA: 0x00070D84 File Offset: 0x0006EF84
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string)
			{
				string text = ((string)value).Trim();
				if (!string.Equals(text, ReferenceConverter.s_none) && context != null)
				{
					IReferenceService referenceService = (IReferenceService)context.GetService(typeof(IReferenceService));
					if (referenceService != null)
					{
						object reference = referenceService.GetReference(text);
						if (reference != null)
						{
							return reference;
						}
					}
					IContainer container = context.Container;
					if (container != null)
					{
						object obj = container.Components[text];
						if (obj != null)
						{
							return obj;
						}
					}
				}
				return null;
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Преобразует указанное значение объекта с помощью указанного контекста и аргументов в ссылочный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, задающий язык и региональные параметры, используемые для представления шрифта.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <param name="destinationType">Тип, в который требуется преобразовать объект.</param>
		/// <returns>Преобразованный объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x060020B5 RID: 8373 RVA: 0x00070E08 File Offset: 0x0006F008
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (!(destinationType == typeof(string)))
			{
				return base.ConvertTo(context, culture, value, destinationType);
			}
			if (value != null)
			{
				IReferenceService referenceService = (IReferenceService)((context != null) ? context.GetService(typeof(IReferenceService)) : null);
				if (referenceService != null)
				{
					string name = referenceService.GetName(value);
					if (name != null)
					{
						return name;
					}
				}
				if (!Marshal.IsComObject(value) && value is IComponent)
				{
					ISite site = ((IComponent)value).Site;
					string text = (site != null) ? site.Name : null;
					if (text != null)
					{
						return text;
					}
				}
				return string.Empty;
			}
			return ReferenceConverter.s_none;
		}

		/// <summary>Возвращает коллекцию стандартных значений для ссылочного типа данных.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>
		///   <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, содержащий стандартный набор допустимых значений, или <see langword="null" />, если этот тип данных не поддерживает стандартный набор значений.</returns>
		// Token: 0x060020B6 RID: 8374 RVA: 0x00070EB0 File Offset: 0x0006F0B0
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			object[] array = null;
			if (context != null)
			{
				List<object> list = new List<object>();
				list.Add(null);
				IReferenceService referenceService = (IReferenceService)context.GetService(typeof(IReferenceService));
				if (referenceService != null)
				{
					object[] references = referenceService.GetReferences(this._type);
					int num = references.Length;
					for (int i = 0; i < num; i++)
					{
						if (this.IsValueAllowed(context, references[i]))
						{
							list.Add(references[i]);
						}
					}
				}
				else
				{
					IContainer container = context.Container;
					if (container != null)
					{
						foreach (object obj in container.Components)
						{
							IComponent component = (IComponent)obj;
							if (component != null && this._type.IsInstanceOfType(component) && this.IsValueAllowed(context, component))
							{
								list.Add(component);
							}
						}
					}
				}
				array = list.ToArray();
				Array.Sort(array, 0, array.Length, new ReferenceConverter.ReferenceComparer(this));
			}
			return new TypeConverter.StandardValuesCollection(array);
		}

		/// <summary>Возвращает значение, показывающее, является ли список стандартных значений, возвращенных из <see cref="M:System.ComponentModel.ReferenceConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" />, исчерпывающим.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="true" />, так как коллекция <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, возвращенная методом <see cref="M:System.ComponentModel.ReferenceConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" />, является исчерпывающим списком возможных значений. Этот метод никогда не возвращает значение <see langword="false" />.</returns>
		// Token: 0x060020B7 RID: 8375 RVA: 0x0000390E File Offset: 0x00001B0E
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>Получает значение, показывающее, поддерживает ли этот объект стандартный набор значений, которые можно выбрать из списка.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="true" />, так как для поиска общего набора значений, поддерживаемых объектом, можно вызвать метод <see cref="M:System.ComponentModel.ReferenceConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" />. Этот метод никогда не возвращает значение <see langword="false" />.</returns>
		// Token: 0x060020B8 RID: 8376 RVA: 0x0000390E File Offset: 0x00001B0E
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>Возвращает значение, показывающее, может ли конкретное значение быть добавлено в коллекцию стандартных значений.</summary>
		/// <param name="context">Контекст <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, содержащий дополнительную контекстную информацию.</param>
		/// <param name="value">Проверяемое значение.</param>
		/// <returns>Значение <see langword="true" />, если значение допустимо и может быть добавлено в коллекцию стандартных значений, значение <see langword="false" />, если значение не может быть добавлено в коллекцию стандартных значений.</returns>
		// Token: 0x060020B9 RID: 8377 RVA: 0x0000390E File Offset: 0x00001B0E
		protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value)
		{
			return true;
		}

		// Token: 0x04000FD7 RID: 4055
		private static readonly string s_none = "(none)";

		// Token: 0x04000FD8 RID: 4056
		private Type _type;

		// Token: 0x020003E5 RID: 997
		private class ReferenceComparer : IComparer
		{
			// Token: 0x060020BB RID: 8379 RVA: 0x00070FD0 File Offset: 0x0006F1D0
			public ReferenceComparer(ReferenceConverter converter)
			{
				this._converter = converter;
			}

			// Token: 0x060020BC RID: 8380 RVA: 0x00070FE0 File Offset: 0x0006F1E0
			public int Compare(object item1, object item2)
			{
				string strA = this._converter.ConvertToString(item1);
				string strB = this._converter.ConvertToString(item2);
				return string.Compare(strA, strB, false, CultureInfo.InvariantCulture);
			}

			// Token: 0x04000FD9 RID: 4057
			private ReferenceConverter _converter;
		}
	}
}
