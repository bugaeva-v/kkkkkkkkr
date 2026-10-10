using System;
using System.Configuration;
using Unity;

namespace System.Net.Configuration
{
	/// <summary>Представляет элемент WebUtility в файле конфигурации.</summary>
	// Token: 0x02000877 RID: 2167
	public sealed class WebUtilityElement : ConfigurationElement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Configuration.WebUtilityElement" />.</summary>
		// Token: 0x060044B2 RID: 17586 RVA: 0x00013BCA File Offset: 0x00011DCA
		public WebUtilityElement()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает значение по умолчанию для поведения соответствия декодирования юникода, используемое для объекта <see cref="T:System.Net.WebUtility" />.</summary>
		/// <returns>Возвращает <see cref="T:System.Net.Configuration.UnicodeDecodingConformance" />.  
		/// поведение декодирования юникода по умолчанию.</returns>
		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x060044B3 RID: 17587 RVA: 0x000ED180 File Offset: 0x000EB380
		// (set) Token: 0x060044B4 RID: 17588 RVA: 0x00013BCA File Offset: 0x00011DCA
		public UnicodeDecodingConformance UnicodeDecodingConformance
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return UnicodeDecodingConformance.Auto;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		/// <summary>Получает значение по умолчанию для поведения соответствия кодирования юникода, используемое для объекта <see cref="T:System.Net.WebUtility" />.</summary>
		/// <returns>Возвращает <see cref="T:System.Net.Configuration.UnicodeEncodingConformance" />.  
		/// Поведение кодирования юникода по умолчанию.</returns>
		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x060044B5 RID: 17589 RVA: 0x000ED19C File Offset: 0x000EB39C
		// (set) Token: 0x060044B6 RID: 17590 RVA: 0x00013BCA File Offset: 0x00011DCA
		public UnicodeEncodingConformance UnicodeEncodingConformance
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return UnicodeEncodingConformance.Auto;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}
	}
}
