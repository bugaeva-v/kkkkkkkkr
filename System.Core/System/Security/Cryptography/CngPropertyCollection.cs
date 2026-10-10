using System;
using System.Collections.ObjectModel;
using System.Security.Permissions;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Предоставляет строго типизированную коллекцию свойств криптографии следующего поколения (CNG).
	///       </summary>
	// Token: 0x02000045 RID: 69
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class CngPropertyCollection : Collection<CngProperty>
	{
	}
}
