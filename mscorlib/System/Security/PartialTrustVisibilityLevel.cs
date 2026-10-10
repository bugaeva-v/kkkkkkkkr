using System;

namespace System.Security
{
	/// <summary>Задает видимость по умолчанию с частичным доверием для кода, помеченного атрибутом <see cref="T:System.Security.AllowPartiallyTrustedCallersAttribute" /> (APTCA).</summary>
	// Token: 0x020003D1 RID: 977
	public enum PartialTrustVisibilityLevel
	{
		/// <summary>Сборку всегда может вызывать частично доверенный код.</summary>
		// Token: 0x04001E9C RID: 7836
		VisibleToAllHosts,
		/// <summary>Сборка прошла проверку для получения частичного доверия, но не видима для частично доверенного кода на всех узлах. Чтобы сделать сборку видимой для частично доверенного кода, добавьте ее в свойство <see cref="P:System.AppDomainSetup.PartialTrustVisibleAssemblies" />.</summary>
		// Token: 0x04001E9D RID: 7837
		NotVisibleByDefault
	}
}
