using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Задает длину цепочки сертификата X.509, которая должна быть включена в данные X.509.</summary>
	// Token: 0x020002C4 RID: 708
	public enum X509IncludeOption
	{
		/// <summary>Отсутствуют сведения о цепочке X.509.</summary>
		// Token: 0x04000CA3 RID: 3235
		None,
		/// <summary>В сведения включается вся цепочка X.509 за исключением корневого сертификата.</summary>
		// Token: 0x04000CA4 RID: 3236
		ExcludeRoot,
		/// <summary>В сведения о цепочке X.509 включается только конечный сертификат.</summary>
		// Token: 0x04000CA5 RID: 3237
		EndCertOnly,
		/// <summary>Включена вся цепочка X.509.</summary>
		// Token: 0x04000CA6 RID: 3238
		WholeChain
	}
}
