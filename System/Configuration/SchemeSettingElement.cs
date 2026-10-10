using System;
using Unity;

namespace System.Configuration
{
	/// <summary>Представляет элемент в классе <see cref="T:System.Configuration.SchemeSettingElementCollection" />.</summary>
	// Token: 0x0200087A RID: 2170
	public sealed class SchemeSettingElement : ConfigurationElement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SchemeSettingElement" />.</summary>
		// Token: 0x060044BF RID: 17599 RVA: 0x00013BCA File Offset: 0x00011DCA
		public SchemeSettingElement()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает значение записи из GenericUriParserOptions экземпляра класса <see cref="T:System.Configuration.SchemeSettingElement" />.</summary>
		/// <returns>Значение записи GenericUriParserOptions.</returns>
		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x060044C0 RID: 17600 RVA: 0x000ED1F0 File Offset: 0x000EB3F0
		public GenericUriParserOptions GenericUriParserOptions
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return GenericUriParserOptions.Default;
			}
		}

		/// <summary>Получает значение записи Name из экземпляра класса <see cref="T:System.Configuration.SchemeSettingElement" />.</summary>
		/// <returns>Протокол, используемый данным параметром схемы.</returns>
		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x060044C1 RID: 17601 RVA: 0x00032884 File Offset: 0x00030A84
		public string Name
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}
	}
}
