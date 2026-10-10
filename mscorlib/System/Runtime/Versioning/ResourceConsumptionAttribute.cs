using System;
using System.Diagnostics;

namespace System.Runtime.Versioning
{
	/// <summary>Указывает ресурс, потребляемый членом класса. Этот класс не наследуется.</summary>
	// Token: 0x0200063F RID: 1599
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
	[Conditional("RESOURCE_ANNOTATION_WORK")]
	public sealed class ResourceConsumptionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Versioning.ResourceConsumptionAttribute" />, задающего область потребляемого ресурса.</summary>
		/// <param name="resourceScope">Возвращает область видимости <see cref="T:System.Runtime.Versioning.ResourceScope" /> потребляемого ресурса.</param>
		// Token: 0x06003C2B RID: 15403 RVA: 0x000D117E File Offset: 0x000CF37E
		public ResourceConsumptionAttribute(ResourceScope resourceScope)
		{
			this._resourceScope = resourceScope;
			this._consumptionScope = this._resourceScope;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Versioning.ResourceConsumptionAttribute" />, задающего область видимости потребляемого ресурса и область его потребления.</summary>
		/// <param name="resourceScope">Возвращает область видимости <see cref="T:System.Runtime.Versioning.ResourceScope" /> потребляемого ресурса.</param>
		/// <param name="consumptionScope">Область видимости ресурса <see cref="T:System.Runtime.Versioning.ResourceScope" />, используемая этим членом.</param>
		// Token: 0x06003C2C RID: 15404 RVA: 0x000D1199 File Offset: 0x000CF399
		public ResourceConsumptionAttribute(ResourceScope resourceScope, ResourceScope consumptionScope)
		{
			this._resourceScope = resourceScope;
			this._consumptionScope = consumptionScope;
		}

		/// <summary>Возвращает область видимости потребляемого ресурса.</summary>
		/// <returns>Объект <see cref="T:System.Runtime.Versioning.ResourceScope" />, задающий область видимости ресурса потребляемого члена.</returns>
		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06003C2D RID: 15405 RVA: 0x000D11AF File Offset: 0x000CF3AF
		public ResourceScope ResourceScope
		{
			get
			{
				return this._resourceScope;
			}
		}

		/// <summary>Возвращает область потребления для данного члена.</summary>
		/// <returns>Объект <see cref="T:System.Runtime.Versioning.ResourceScope" />, задающий область видимости ресурса, используемую данным членом.</returns>
		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06003C2E RID: 15406 RVA: 0x000D11B7 File Offset: 0x000CF3B7
		public ResourceScope ConsumptionScope
		{
			get
			{
				return this._consumptionScope;
			}
		}

		// Token: 0x040026F6 RID: 9974
		private ResourceScope _consumptionScope;

		// Token: 0x040026F7 RID: 9975
		private ResourceScope _resourceScope;
	}
}
