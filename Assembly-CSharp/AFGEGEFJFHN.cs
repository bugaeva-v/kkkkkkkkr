using System;
using System.Security.Cryptography;

// Token: 0x0200047F RID: 1151
public static class AFGEGEFJFHN
{
	// Token: 0x06008BDE RID: 35806 RVA: 0x003DF6B8 File Offset: 0x003DD8B8
	public static byte[] DOLEHNFNOMB(byte[] HOGMBJDIJGA, byte[] GGDCLLDAPFJ)
	{
		if (GGDCLLDAPFJ == null)
		{
			throw new ArgumentNullException("ikm");
		}
		byte[] result;
		using (HMACSHA256 hmacsha = new HMACSHA256((HOGMBJDIJGA == null || HOGMBJDIJGA.Length == 0) ? new byte[32] : HOGMBJDIJGA))
		{
			result = hmacsha.ComputeHash(GGDCLLDAPFJ);
		}
		return result;
	}

	// Token: 0x06008BDF RID: 35807 RVA: 0x003DF710 File Offset: 0x003DD910
	public static byte[] BEAGDCGCPJA(byte[] GGDCLLDAPFJ, byte[] HOGMBJDIJGA, byte[] OHCDFPLACOP, int CHCPAAHFGCA)
	{
		return AFGEGEFJFHN.FDKBPLBFHEK(AFGEGEFJFHN.DOLEHNFNOMB(HOGMBJDIJGA, GGDCLLDAPFJ), OHCDFPLACOP, CHCPAAHFGCA);
	}

	// Token: 0x06008BE0 RID: 35808 RVA: 0x003DF720 File Offset: 0x003DD920
	public static bool LPDFBIONAJK(byte[] JHNGHPENDEA, byte[] BHGHOHCMHPJ)
	{
		if (JHNGHPENDEA == null || BHGHOHCMHPJ == null || JHNGHPENDEA.Length != BHGHOHCMHPJ.Length)
		{
			return false;
		}
		int num = 0;
		for (int i = 0; i < JHNGHPENDEA.Length; i++)
		{
			num |= (int)(JHNGHPENDEA[i] ^ BHGHOHCMHPJ[i]);
		}
		return num == 0;
	}

	// Token: 0x06008BE1 RID: 35809 RVA: 0x003DF75C File Offset: 0x003DD95C
	public static byte[] FDKBPLBFHEK(byte[] NADCCDNBBOG, byte[] OHCDFPLACOP, int CHCPAAHFGCA)
	{
		if (NADCCDNBBOG == null)
		{
			throw new ArgumentNullException("prk");
		}
		if (CHCPAAHFGCA <= 0)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		if (CHCPAAHFGCA > 8160)
		{
			throw new ArgumentOutOfRangeException("length", "HKDF output capped at 255 * HashLen bytes.");
		}
		if (OHCDFPLACOP == null)
		{
			OHCDFPLACOP = Array.Empty<byte>();
		}
		byte[] array = new byte[CHCPAAHFGCA];
		byte[] array2 = Array.Empty<byte>();
		int i = 0;
		byte b = 1;
		using (HMACSHA256 hmacsha = new HMACSHA256(NADCCDNBBOG))
		{
			while (i < CHCPAAHFGCA)
			{
				byte[] array3 = new byte[array2.Length + OHCDFPLACOP.Length + 1];
				Buffer.BlockCopy(array2, 0, array3, 0, array2.Length);
				Buffer.BlockCopy(OHCDFPLACOP, 0, array3, array2.Length, OHCDFPLACOP.Length);
				array3[array3.Length - 1] = b;
				array2 = hmacsha.ComputeHash(array3);
				int num = Math.Min(array2.Length, CHCPAAHFGCA - i);
				Buffer.BlockCopy(array2, 0, array, i, num);
				i += num;
				b += 1;
			}
		}
		return array;
	}

	// Token: 0x0400272C RID: 10028
	private const int GHFFCDMLPJG = 32;
}
