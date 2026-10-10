using System;
using System.Security.Cryptography;
using System.Text;

// Token: 0x020003FC RID: 1020
public static class HNIBKBPOCJG
{
	// Token: 0x060078B0 RID: 30896 RVA: 0x0036029C File Offset: 0x0035E49C
	public static bool DDKPGMBIHOP(string JHNGHPENDEA, string BHGHOHCMHPJ)
	{
		if (JHNGHPENDEA == null || BHGHOHCMHPJ == null)
		{
			return false;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(JHNGHPENDEA);
		byte[] bytes2 = Encoding.UTF8.GetBytes(BHGHOHCMHPJ);
		return AFGEGEFJFHN.LPDFBIONAJK(bytes, bytes2);
	}

	// Token: 0x060078B1 RID: 30897 RVA: 0x003602CE File Offset: 0x0035E4CE
	public static byte[] JGMBGBKFHMA(string CKHFGKCNLED)
	{
		if (CKHFGKCNLED == null)
		{
			throw new ArgumentNullException("s");
		}
		return HNIBKBPOCJG.EODJEBCDBBF(Encoding.UTF8.GetBytes(CKHFGKCNLED));
	}

	// Token: 0x060078B2 RID: 30898 RVA: 0x003602F0 File Offset: 0x0035E4F0
	public static byte[] EODJEBCDBBF(byte[] GDAFFANBJED)
	{
		if (GDAFFANBJED == null)
		{
			throw new ArgumentNullException("data");
		}
		byte[] result;
		using (SHA256 sha = SHA256.Create())
		{
			result = sha.ComputeHash(GDAFFANBJED);
		}
		return result;
	}
}
