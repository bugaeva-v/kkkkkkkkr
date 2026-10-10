using System;

namespace System.Reflection
{
	/// <summary>Указывает, какой язык и региональные параметры поддерживает сборка.</summary>
	// Token: 0x02000882 RID: 2178
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyCultureAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyCultureAttribute" /> с языком и региональными параметрами, поддерживаемыми сборкой с данным атрибутом.</summary>
		/// <param name="culture">Язык и региональные параметры, поддерживаемые сборкой с данным атрибутом.</param>
		// Token: 0x06004857 RID: 18519 RVA: 0x000EE049 File Offset: 0x000EC249
		public AssemblyCultureAttribute(string culture)
		{
			this.Culture = culture;
		}

		/// <summary>Возвращает поддерживаемые язык и региональные параметры сборки с данным атрибутом.</summary>
		/// <returns>Строка, содержащая имя поддерживаемых языка и региональных параметров.</returns>
		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06004858 RID: 18520 RVA: 0x000EE058 File Offset: 0x000EC258
		public string Culture { get; }
	}
}
