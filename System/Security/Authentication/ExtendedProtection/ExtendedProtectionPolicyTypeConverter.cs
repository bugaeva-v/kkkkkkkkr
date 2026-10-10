using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Security.Authentication.ExtendedProtection
{
	/// <summary>Класс <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicyTypeConverter" /> представляет преобразователь типов для расширенной политики защиты, используемой сервером для проверки входящих соединений от клиентов.</summary>
	// Token: 0x020002A7 RID: 679
	[MonoTODO]
	public class ExtendedProtectionPolicyTypeConverter : TypeConverter
	{
		/// <summary>Возвращает значение, указывающее, может ли этот преобразователь выполнить преобразование данного объекта к заданному типу.</summary>
		/// <param name="context">Преобразуемый объект.</param>
		/// <param name="destinationType">Класс <see cref="T:System.Type" />, представляющий тип, в который нужно выполнить преобразование.</param>
		/// <returns>Значение <see langword="true" />, если данный преобразователь может выполнить преобразование; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600153C RID: 5436 RVA: 0x0000829A File Offset: 0x0000649A
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			throw new NotImplementedException();
		}

		/// <summary>Преобразуйте объект в указанный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />. Если передано значение <see langword="null" />, используются текущие настройки языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />. Должно быть объектом <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />.</param>
		/// <param name="destinationType">Тип <see cref="T:System.Type" />, в который преобразуется параметр значения.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий преобразуемый параметр <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Не удалось выполнить преобразование.</exception>
		// Token: 0x0600153D RID: 5437 RVA: 0x0000829A File Offset: 0x0000649A
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			throw new NotImplementedException();
		}
	}
}
