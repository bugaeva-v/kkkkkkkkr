using System;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

// Token: 0x020001DF RID: 479
public static class JGPMLOAKFGC
{
	// Token: 0x06003B94 RID: 15252 RVA: 0x0018B0C0 File Offset: 0x001892C0
	private static void JCPGGIEIIHH()
	{
		if (JGPMLOAKFGC.MOJLPPPFOAL)
		{
			return;
		}
		object flioamdiebf = JGPMLOAKFGC.FLIOAMDIEBF;
		lock (flioamdiebf)
		{
			if (!JGPMLOAKFGC.MOJLPPPFOAL)
			{
				byte[] hash;
				using (SHA256 sha = SHA256.Create())
				{
					sha.Initialize();
					for (int i = 0; i < JGPMLOAKFGC.PNIHDJGJMBI.Length; i++)
					{
						sha.TransformBlock(JGPMLOAKFGC.PNIHDJGJMBI[i], 0, JGPMLOAKFGC.PNIHDJGJMBI[i].Length, null, 0);
					}
					sha.TransformFinalBlock(new byte[0], 0, 0);
					hash = sha.Hash;
				}
				if (!AFGEGEFJFHN.LPDFBIONAJK(hash, JGPMLOAKFGC.LEHBFMNLJKO))
				{
					throw new JGPMLOAKFGC.DCICLCDPPIF("hkfx-91");
				}
				JGPMLOAKFGC.MOJLPPPFOAL = true;
			}
		}
	}

	// Token: 0x06003B95 RID: 15253 RVA: 0x0018B1A0 File Offset: 0x001893A0
	public static bool GOAGKJPMCOJ(string HPIGJNFGNDM)
	{
		JGPMLOAKFGC.JCPGGIEIIHH();
		if (string.IsNullOrEmpty(HPIGJNFGNDM))
		{
			return false;
		}
		string host;
		try
		{
			host = new Uri(HPIGJNFGNDM).Host;
		}
		catch
		{
			return false;
		}
		if (string.IsNullOrEmpty(host))
		{
			return false;
		}
		byte[] jhnghpendea;
		using (SHA256 sha = SHA256.Create())
		{
			jhnghpendea = sha.ComputeHash(Encoding.ASCII.GetBytes(host.ToLowerInvariant()));
		}
		for (int i = 0; i < JGPMLOAKFGC.PNIHDJGJMBI.Length; i++)
		{
			if (AFGEGEFJFHN.LPDFBIONAJK(jhnghpendea, JGPMLOAKFGC.PNIHDJGJMBI[i]))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003B97 RID: 15255 RVA: 0x0018B430 File Offset: 0x00189630
	public static void PAHPCJOCAPA(string HPIGJNFGNDM)
	{
		if (JGPMLOAKFGC.CGBMMIPMMAG)
		{
			JGPMLOAKFGC.LJPOBNOPFDJ();
		}
		try
		{
			if (!JGPMLOAKFGC.GOAGKJPMCOJ(HPIGJNFGNDM))
			{
				JGPMLOAKFGC.CGBMMIPMMAG = true;
				JGPMLOAKFGC.LJPOBNOPFDJ();
			}
		}
		catch (JGPMLOAKFGC.DCICLCDPPIF)
		{
			JGPMLOAKFGC.CGBMMIPMMAG = true;
			JGPMLOAKFGC.LJPOBNOPFDJ();
		}
		catch (Exception)
		{
			JGPMLOAKFGC.CGBMMIPMMAG = true;
			JGPMLOAKFGC.LJPOBNOPFDJ();
		}
	}

	// Token: 0x06003B98 RID: 15256 RVA: 0x0018B4A0 File Offset: 0x001896A0
	private static void LJPOBNOPFDJ()
	{
		try
		{
			DPGJIJGOCIC.LEFOKDBKJGF(new Exception("hkfx-91"));
		}
		catch
		{
		}
		try
		{
			Application.Quit();
		}
		catch
		{
		}
		int length = null[0].Length;
	}

	// Token: 0x04001140 RID: 4416
	private static readonly byte[][] PNIHDJGJMBI = new byte[][]
	{
		new byte[]
		{
			185,
			123,
			112,
			86,
			119,
			236,
			32,
			23,
			107,
			244,
			60,
			135,
			237,
			110,
			175,
			112,
			125,
			223,
			15,
			79,
			227,
			189,
			204,
			8,
			94,
			204,
			214,
			128,
			27,
			105,
			184,
			59
		},
		new byte[]
		{
			137,
			123,
			126,
			112,
			218,
			95,
			50,
			103,
			241,
			98,
			94,
			127,
			66,
			141,
			37,
			166,
			229,
			65,
			154,
			10,
			248,
			85,
			227,
			77,
			241,
			230,
			7,
			95,
			171,
			183,
			202,
			164
		},
		new byte[]
		{
			181,
			86,
			201,
			25,
			15,
			86,
			114,
			246,
			14,
			63,
			163,
			247,
			1,
			150,
			195,
			93,
			139,
			4,
			219,
			128,
			100,
			26,
			80,
			80,
			153,
			182,
			103,
			109,
			0,
			byte.MaxValue,
			124,
			72
		},
		new byte[]
		{
			169,
			216,
			157,
			152,
			200,
			222,
			36,
			179,
			162,
			2,
			104,
			77,
			134,
			96,
			70,
			214,
			26,
			179,
			238,
			73,
			120,
			234,
			180,
			43,
			37,
			85,
			105,
			168,
			246,
			139,
			240,
			143
		},
		new byte[]
		{
			120,
			123,
			66,
			170,
			8,
			53,
			115,
			185,
			157,
			73,
			2,
			126,
			90,
			3,
			150,
			230,
			39,
			71,
			86,
			232,
			12,
			133,
			5,
			36,
			22,
			165,
			180,
			26,
			156,
			137,
			78,
			188
		},
		new byte[]
		{
			204,
			191,
			162,
			164,
			43,
			171,
			7,
			169,
			30,
			135,
			215,
			71,
			177,
			248,
			142,
			139,
			44,
			163,
			44,
			194,
			16,
			75,
			215,
			105,
			222,
			191,
			106,
			79,
			206,
			252,
			32,
			83
		},
		new byte[]
		{
			205,
			150,
			63,
			14,
			213,
			120,
			162,
			237,
			12,
			56,
			248,
			159,
			206,
			96,
			208,
			32,
			231,
			59,
			148,
			169,
			240,
			168,
			211,
			126,
			218,
			135,
			88,
			114,
			93,
			208,
			164,
			222
		},
		new byte[]
		{
			64,
			89,
			224,
			16,
			40,
			193,
			126,
			20,
			216,
			207,
			59,
			167,
			93,
			167,
			42,
			62,
			240,
			202,
			29,
			153,
			246,
			139,
			225,
			88,
			84,
			28,
			116,
			219,
			19,
			22,
			22,
			232
		},
		new byte[]
		{
			156,
			174,
			210,
			91,
			26,
			10,
			35,
			78,
			245,
			11,
			6,
			243,
			229,
			180,
			120,
			31,
			94,
			54,
			117,
			187,
			103,
			188,
			57,
			175,
			139,
			147,
			55,
			17,
			186,
			159,
			139,
			175
		},
		new byte[]
		{
			157,
			204,
			188,
			57,
			69,
			54,
			23,
			157,
			106,
			243,
			185,
			236,
			31,
			148,
			238,
			176,
			25,
			161,
			90,
			28,
			245,
			74,
			120,
			115,
			96,
			222,
			209,
			99,
			4,
			227,
			173,
			118
		},
		new byte[]
		{
			145,
			38,
			123,
			208,
			22,
			107,
			168,
			239,
			187,
			9,
			113,
			70,
			118,
			215,
			162,
			59,
			184,
			158,
			59,
			76,
			246,
			181,
			32,
			209,
			87,
			178,
			251,
			192,
			61,
			60,
			187,
			197
		},
		new byte[]
		{
			119,
			118,
			24,
			54,
			84,
			175,
			146,
			135,
			35,
			79,
			26,
			155,
			11,
			232,
			123,
			4,
			132,
			158,
			47,
			33,
			40,
			115,
			104,
			204,
			37,
			54,
			46,
			161,
			177,
			13,
			107,
			183
		},
		new byte[]
		{
			185,
			184,
			83,
			108,
			87,
			154,
			180,
			114,
			58,
			152,
			174,
			95,
			133,
			149,
			10,
			151,
			3,
			66,
			176,
			100,
			129,
			157,
			45,
			107,
			34,
			246,
			218,
			236,
			94,
			19,
			103,
			228
		},
		new byte[]
		{
			170,
			17,
			214,
			8,
			96,
			142,
			121,
			183,
			247,
			106,
			64,
			125,
			60,
			244,
			108,
			55,
			152,
			240,
			199,
			47,
			181,
			127,
			195,
			147,
			222,
			252,
			117,
			214,
			56,
			17,
			96,
			241
		},
		new byte[]
		{
			25,
			65,
			131,
			182,
			78,
			217,
			247,
			149,
			82,
			78,
			6,
			21,
			31,
			114,
			148,
			174,
			238,
			230,
			227,
			164,
			76,
			6,
			195,
			20,
			238,
			146,
			253,
			107,
			71,
			23,
			28,
			37
		},
		new byte[]
		{
			195,
			252,
			146,
			158,
			101,
			75,
			2,
			246,
			173,
			159,
			16,
			129,
			137,
			88,
			239,
			85,
			93,
			37,
			90,
			32,
			252,
			19,
			118,
			233,
			0,
			156,
			231,
			118,
			80,
			46,
			133,
			179
		},
		new byte[]
		{
			248,
			215,
			54,
			159,
			22,
			49,
			203,
			131,
			152,
			158,
			240,
			96,
			133,
			156,
			104,
			24,
			104,
			209,
			184,
			89,
			107,
			109,
			222,
			180,
			138,
			190,
			186,
			226,
			85,
			212,
			189,
			28
		},
		new byte[]
		{
			62,
			43,
			21,
			50,
			234,
			85,
			181,
			150,
			16,
			236,
			186,
			113,
			135,
			218,
			248,
			176,
			101,
			190,
			167,
			139,
			128,
			119,
			211,
			13,
			220,
			23,
			157,
			144,
			117,
			51,
			191,
			196
		},
		new byte[]
		{
			99,
			90,
			86,
			147,
			239,
			98,
			0,
			82,
			96,
			90,
			105,
			29,
			234,
			73,
			5,
			248,
			89,
			248,
			5,
			5,
			39,
			56,
			100,
			230,
			214,
			33,
			155,
			97,
			192,
			52,
			78,
			252
		}
	};

	// Token: 0x04001141 RID: 4417
	private static readonly byte[] LEHBFMNLJKO = new byte[]
	{
		16,
		137,
		120,
		93,
		112,
		47,
		180,
		208,
		245,
		18,
		43,
		95,
		224,
		108,
		118,
		219,
		102,
		137,
		89,
		238,
		118,
		118,
		151,
		205,
		134,
		11,
		35,
		55,
		50,
		64,
		199,
		204
	};

	// Token: 0x04001142 RID: 4418
	private static volatile bool MOJLPPPFOAL = false;

	// Token: 0x04001143 RID: 4419
	private static volatile bool CGBMMIPMMAG = false;

	// Token: 0x04001144 RID: 4420
	private static readonly object FLIOAMDIEBF = new object();

	// Token: 0x020001E0 RID: 480
	private class DCICLCDPPIF : Exception
	{
		// Token: 0x06003B99 RID: 15257 RVA: 0x0018B4F4 File Offset: 0x001896F4
		public DCICLCDPPIF(string PNBDFMLMCLJ) : base(PNBDFMLMCLJ)
		{
		}
	}
}
