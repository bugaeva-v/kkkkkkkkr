using System;

namespace UnityEngine.Purchasing.Security
{
	// Token: 0x02000004 RID: 4
	public class CrossPlatformValidator
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002073 File Offset: 0x00000273
		public CrossPlatformValidator(byte[] googlePublicKey, string googleBundleId)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002080 File Offset: 0x00000280
		public CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, string appBundleId)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000208D File Offset: 0x0000028D
		public CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, string googleBundleId, string appleBundleId)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000209A File Offset: 0x0000029A
		public IPurchaseReceipt[] Validate(string unityIAPReceipt)
		{
			throw new NotImplementedException();
		}
	}
}
