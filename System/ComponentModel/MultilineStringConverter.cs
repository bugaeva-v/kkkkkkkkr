using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типов для преобразования многострочных строк в простую строку.</summary>
	// Token: 0x020003DA RID: 986
	public class MultilineStringConverter : TypeConverter
	{
		/// <summary>Преобразует данный объект значения в указанный тип, используя заданные сведения о контексте, а также о языке и региональных параметрах.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />. Если передано значение <see langword="null" />, используются текущие настройки языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <param name="destinationType">Тип <see cref="T:System.Type" />, в который преобразуется параметр значения.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06002022 RID: 8226 RVA: 0x0006F708 File Offset: 0x0006D908
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(string) && value is string)
			{
				return "(Text)";
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Возвращает коллекцию свойств для типа массива, заданного параметром <paramref name="value" />, используя заданные контекст и атрибуты.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Объект класса <see cref="T:System.Object" />, задающий тип массива, для которого нужно получить свойства.</param>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, используемый в качестве фильтра.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> со свойствами, доступными для этого типа данных, или <see langword="null" />, если свойства отсутствуют.</returns>
		// Token: 0x06002023 RID: 8227 RVA: 0x00002F6A File Offset: 0x0000116A
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return null;
		}

		/// <summary>Возвращает значение, показывающее, поддерживает ли данный объект свойства, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Имеет значение <see langword="true" />, если для поиска свойств этого объекта следует вызвать метод <see cref="Overload:System.ComponentModel.MultilineStringConverter.GetProperties" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002024 RID: 8228 RVA: 0x00003062 File Offset: 0x00001262
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return false;
		}
	}
}
