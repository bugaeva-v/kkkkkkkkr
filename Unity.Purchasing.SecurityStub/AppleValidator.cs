using System;

namespace UnityEngine.Purchasing.Security
{
	// Token: 0x02000002 RID: 2
	[Obsolete("AppleValidator is a stub and does not perform any validation. Do not use this class. Use UnityEngine.Purchasing.Security.CrossPlatformValidator with a valid Apple certificate for receipt validation.", false)]
	public class AppleValidator
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public AppleValidator(byte[] appleRootCertificate)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205D File Offset: 0x0000025D
		public AppleReceipt Validate(byte[] receiptData)
		{
			throw new NotImplementedException();
		}
	}
}
