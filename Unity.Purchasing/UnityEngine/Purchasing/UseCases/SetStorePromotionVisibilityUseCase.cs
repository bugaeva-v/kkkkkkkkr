using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x02000137 RID: 311
	[NullableContext(1)]
	[Nullable(0)]
	internal class SetStorePromotionVisibilityUseCase : ISetStorePromotionVisibilityUseCase
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
		[Preserve]
		internal SetStorePromotionVisibilityUseCase(INativeAppleStore nativeStore, ITelemetryDiagnostics telemetryDiagnostics)
		{
			this.m_NativeAppleStore = nativeStore;
			this.m_TelemetryDiagnostics = telemetryDiagnostics;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		public void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visibility)
		{
			if (product == null)
			{
				ArgumentNullException ex = new ArgumentNullException("product");
				this.m_TelemetryDiagnostics.SendDiagnostic("invalid_product_error", ex);
				throw ex;
			}
			this.m_NativeAppleStore.SetStorePromotionVisibility(product.definition.storeSpecificId, visibility.ToString());
		}

		// Token: 0x0400028C RID: 652
		private readonly INativeAppleStore m_NativeAppleStore;

		// Token: 0x0400028D RID: 653
		private readonly ITelemetryDiagnostics m_TelemetryDiagnostics;
	}
}
