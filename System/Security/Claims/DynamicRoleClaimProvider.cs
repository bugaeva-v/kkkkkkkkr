using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace System.Security.Claims
{
	/// <summary>Единственный предоставляемый этим классом метод <see cref="M:System.Security.Claims.DynamicRoleClaimProvider.AddDynamicRoleClaims(System.Security.Claims.ClaimsIdentity,System.Collections.Generic.IEnumerable{System.Security.Claims.Claim})" /> является устаревшим. Можно использовать объект <see cref="T:System.Security.Claims.ClaimsAuthenticationManager" /> для добавления требований в объект <see cref="T:System.Security.Claims.ClaimsIdentity" />.</summary>
	// Token: 0x02000292 RID: 658
	public static class DynamicRoleClaimProvider
	{
		/// <summary>Можно использовать объект <see cref="T:System.Security.Claims.ClaimsAuthenticationManager" /> для добавления требований в объект <see cref="T:System.Security.Claims.ClaimsIdentity" />.</summary>
		/// <param name="claimsIdentity">Удостоверение требований, в которое добавляются требования.</param>
		/// <param name="claims">Добавляемые требования.</param>
		// Token: 0x060014C7 RID: 5319 RVA: 0x0005452C File Offset: 0x0005272C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use ClaimsAuthenticationManager to add claims to a ClaimsIdentity", true)]
		public static void AddDynamicRoleClaims(ClaimsIdentity claimsIdentity, IEnumerable<Claim> claims)
		{
			claimsIdentity.ExternalClaims.Add(claims);
		}
	}
}
