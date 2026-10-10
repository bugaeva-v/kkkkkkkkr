using System;

namespace System.Configuration
{
	/// <summary>Определяет поставщика параметров, используемого для хранения текущего класса параметров приложения или свойства. Этот класс не наследуется.</summary>
	// Token: 0x020001D4 RID: 468
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class SettingsProviderAttribute : Attribute
	{
		/// <summary>Инициализирует экземпляр класса <see cref="T:System.Configuration.SettingsProviderAttribute" />.</summary>
		/// <param name="providerTypeName">
		///   <see cref="T:System.String" />, содержащая имя поставщика параметров.</param>
		// Token: 0x06000C4C RID: 3148 RVA: 0x000326BF File Offset: 0x000308BF
		public SettingsProviderAttribute(string providerTypeName)
		{
			if (providerTypeName == null)
			{
				throw new ArgumentNullException("providerTypeName");
			}
			this.providerTypeName = providerTypeName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsProviderAttribute" />.</summary>
		/// <param name="providerType">
		///   <see cref="T:System.Type" />, содержащая тип поставщика параметров.</param>
		// Token: 0x06000C4D RID: 3149 RVA: 0x000326DC File Offset: 0x000308DC
		public SettingsProviderAttribute(Type providerType)
		{
			if (providerType == null)
			{
				throw new ArgumentNullException("providerType");
			}
			this.providerTypeName = providerType.AssemblyQualifiedName;
		}

		/// <summary>Возвращает имя типа поставщика параметров.</summary>
		/// <returns>
		///   <see cref="T:System.String" />, содержащая имя поставщика параметров.</returns>
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x00032704 File Offset: 0x00030904
		public string ProviderTypeName
		{
			get
			{
				return this.providerTypeName;
			}
		}

		// Token: 0x040007B2 RID: 1970
		private string providerTypeName;
	}
}
