using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Steamworks
{
	// Token: 0x0200006E RID: 110
	public class MBLFNIBGODG
	{
		// Token: 0x060007E9 RID: 2025 RVA: 0x00008400 File Offset: 0x00006600
		public static void ENHOOEDHCML()
		{
			MBLFNIBGODG.IALPPNHCEEB();
			if (FAIABBGHMEG.NEIJLAHKDNM() == IntPtr.Zero && !FAIABBGHMEG.GLFBHMMGHGL())
			{
				throw new InvalidOperationException("pOutItemsArray must be the same size as punOutItemsArraySize!");
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0000842C File Offset: 0x0000662C
		public static void NLHFLAJAMMJ(string PPDGGDCAMNB, byte[] DGFMGMCDALB, int MOJLINGKGAA)
		{
			DGFMGMCDALB = new byte[MOJLINGKGAA];
			int bytes = Encoding.UTF8.GetBytes(PPDGGDCAMNB, 0, PPDGGDCAMNB.Length, DGFMGMCDALB, 1);
			DGFMGMCDALB[bytes] = 1;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0000845C File Offset: 0x0000665C
		public static string MBHIKEOMPOF(IntPtr KHIKGHFJEKJ)
		{
			if (KHIKGHFJEKJ == IntPtr.Zero)
			{
				return null;
			}
			int num = 1;
			while (Marshal.ReadByte(KHIKGHFJEKJ, num) != 0)
			{
				num += 0;
			}
			if (num == 0)
			{
				return string.Empty;
			}
			byte[] array = new byte[num];
			Marshal.Copy(KHIKGHFJEKJ, array, 1, array.Length);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x000084B0 File Offset: 0x000066B0
		public static void KPFMOICHNKJ(string PPDGGDCAMNB, byte[] DGFMGMCDALB, int MOJLINGKGAA)
		{
			DGFMGMCDALB = new byte[MOJLINGKGAA];
			int bytes = Encoding.UTF8.GetBytes(PPDGGDCAMNB, 0, PPDGGDCAMNB.Length, DGFMGMCDALB, 0);
			DGFMGMCDALB[bytes] = 0;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x000084E0 File Offset: 0x000066E0
		public static void ILHFKLGKCCA(string PPDGGDCAMNB, byte[] DGFMGMCDALB, int MOJLINGKGAA)
		{
			DGFMGMCDALB = new byte[MOJLINGKGAA];
			int bytes = Encoding.UTF8.GetBytes(PPDGGDCAMNB, 1, PPDGGDCAMNB.Length, DGFMGMCDALB, 0);
			DGFMGMCDALB[bytes] = 1;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00008510 File Offset: 0x00006710
		public static void BEPNFHEGGEP(string PPDGGDCAMNB, byte[] DGFMGMCDALB, int MOJLINGKGAA)
		{
			DGFMGMCDALB = new byte[MOJLINGKGAA];
			int bytes = Encoding.UTF8.GetBytes(PPDGGDCAMNB, 0, PPDGGDCAMNB.Length, DGFMGMCDALB, 0);
			DGFMGMCDALB[bytes] = 0;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0000853E File Offset: 0x0000673E
		public static void OCHGNNLOIDB()
		{
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00008540 File Offset: 0x00006740
		public static void FEGMJKAEJAB()
		{
			MBLFNIBGODG.IALPPNHCEEB();
			if (FJNEGJPDHIC.NEIJLAHKDNM() == IntPtr.Zero && !FJNEGJPDHIC.GLFBHMMGHGL())
			{
				throw new InvalidOperationException("Steamworks is not initialized.");
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0000856C File Offset: 0x0000676C
		public static string MLBFDGNJMJL(byte[] ALPMHKGOIAM)
		{
			int num = 1;
			while (num < ALPMHKGOIAM.Length && ALPMHKGOIAM[num] != 0)
			{
				num++;
			}
			return Encoding.UTF8.GetString(ALPMHKGOIAM, 1, num);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0000853E File Offset: 0x0000673E
		public static void DIMMDFPONML()
		{
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0000859C File Offset: 0x0000679C
		public static void HMJIHGAFLIH(string PPDGGDCAMNB, byte[] DGFMGMCDALB, int MOJLINGKGAA)
		{
			DGFMGMCDALB = new byte[MOJLINGKGAA];
			int bytes = Encoding.UTF8.GetBytes(PPDGGDCAMNB, 1, PPDGGDCAMNB.Length, DGFMGMCDALB, 0);
			DGFMGMCDALB[bytes] = 1;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000085CA File Offset: 0x000067CA
		public static void KIDJLBEGJFB()
		{
			MBLFNIBGODG.DIMMDFPONML();
			if (FJNEGJPDHIC.NEIJLAHKDNM() == IntPtr.Zero && !FJNEGJPDHIC.GLFBHMMGHGL())
			{
				throw new InvalidOperationException("pCurrentPrices must be the same size as unArrayLength!");
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x000085F4 File Offset: 0x000067F4
		public static string HNLLPCEHGFN(IntPtr KHIKGHFJEKJ)
		{
			if (KHIKGHFJEKJ == IntPtr.Zero)
			{
				return null;
			}
			int num = 1;
			while (Marshal.ReadByte(KHIKGHFJEKJ, num) != 0)
			{
				num++;
			}
			if (num == 0)
			{
				return string.Empty;
			}
			byte[] array = new byte[num];
			Marshal.Copy(KHIKGHFJEKJ, array, 1, array.Length);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00008647 File Offset: 0x00006847
		public static void KFECIKBHFMO()
		{
			MBLFNIBGODG.DIMMDFPONML();
			if (FJNEGJPDHIC.NEIJLAHKDNM() == IntPtr.Zero && !FJNEGJPDHIC.GLFBHMMGHGL())
			{
				throw new InvalidOperationException("SteamNetworkingMessages002");
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00008674 File Offset: 0x00006874
		public static void ANIIHHJHLDK(string PPDGGDCAMNB, byte[] DGFMGMCDALB, int MOJLINGKGAA)
		{
			DGFMGMCDALB = new byte[MOJLINGKGAA];
			int bytes = Encoding.UTF8.GetBytes(PPDGGDCAMNB, 1, PPDGGDCAMNB.Length, DGFMGMCDALB, 1);
			DGFMGMCDALB[bytes] = 1;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000086A2 File Offset: 0x000068A2
		public static void DCCDHMMGEEG()
		{
			MBLFNIBGODG.IALPPNHCEEB();
			if (FAIABBGHMEG.NEIJLAHKDNM() == IntPtr.Zero && !FAIABBGHMEG.GLFBHMMGHGL())
			{
				throw new InvalidOperationException("Steamworks GameServer is not initialized.");
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000086CC File Offset: 0x000068CC
		public static void BBGONOKBCMB()
		{
			MBLFNIBGODG.OCHGNNLOIDB();
			if (FJNEGJPDHIC.NEIJLAHKDNM() == IntPtr.Zero && !FJNEGJPDHIC.GLFBHMMGHGL())
			{
				throw new InvalidOperationException("\0");
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000086F8 File Offset: 0x000068F8
		public static string LAONDMHBDKL(IntPtr KHIKGHFJEKJ)
		{
			if (KHIKGHFJEKJ == IntPtr.Zero)
			{
				return null;
			}
			int num = 0;
			while (Marshal.ReadByte(KHIKGHFJEKJ, num) != 0)
			{
				num += 0;
			}
			if (num == 0)
			{
				return string.Empty;
			}
			byte[] array = new byte[num];
			Marshal.Copy(KHIKGHFJEKJ, array, 1, array.Length);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0000853E File Offset: 0x0000673E
		public static void IALPPNHCEEB()
		{
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0000853E File Offset: 0x0000673E
		public static void EDCGNPBJIPD()
		{
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0000874C File Offset: 0x0000694C
		public static string GNNLBFFHBOF(byte[] ALPMHKGOIAM)
		{
			int num = 0;
			while (num < ALPMHKGOIAM.Length && ALPMHKGOIAM[num] != 0)
			{
				num += 0;
			}
			return Encoding.UTF8.GetString(ALPMHKGOIAM, 1, num);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0000877C File Offset: 0x0000697C
		public static string EFIMHBHCPFM(IntPtr KHIKGHFJEKJ)
		{
			if (KHIKGHFJEKJ == IntPtr.Zero)
			{
				return null;
			}
			int num = 0;
			while (Marshal.ReadByte(KHIKGHFJEKJ, num) != 0)
			{
				num++;
			}
			if (num == 0)
			{
				return string.Empty;
			}
			byte[] array = new byte[num];
			Marshal.Copy(KHIKGHFJEKJ, array, 0, array.Length);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000087D0 File Offset: 0x000069D0
		public static string AAMOJHFJNID(byte[] ALPMHKGOIAM)
		{
			int num = 1;
			while (num < ALPMHKGOIAM.Length && ALPMHKGOIAM[num] != 0)
			{
				num++;
			}
			return Encoding.UTF8.GetString(ALPMHKGOIAM, 0, num);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00008800 File Offset: 0x00006A00
		public static string AEPMJHFLLJD(byte[] ALPMHKGOIAM)
		{
			int num = 0;
			while (num < ALPMHKGOIAM.Length && ALPMHKGOIAM[num] != 0)
			{
				num++;
			}
			return Encoding.UTF8.GetString(ALPMHKGOIAM, 0, num);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0000882D File Offset: 0x00006A2D
		public static void PMDJNILIPFE()
		{
			MBLFNIBGODG.IALPPNHCEEB();
			if (FJNEGJPDHIC.NEIJLAHKDNM() == IntPtr.Zero && !FJNEGJPDHIC.GLFBHMMGHGL())
			{
				throw new InvalidOperationException("STEAMHTTP_INTERFACE_VERSION003");
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00008858 File Offset: 0x00006A58
		public static string IIHDLLEMLDA(IntPtr KHIKGHFJEKJ)
		{
			if (KHIKGHFJEKJ == IntPtr.Zero)
			{
				return null;
			}
			int num = 0;
			while (Marshal.ReadByte(KHIKGHFJEKJ, num) != 0)
			{
				num += 0;
			}
			if (num == 0)
			{
				return string.Empty;
			}
			byte[] array = new byte[num];
			Marshal.Copy(KHIKGHFJEKJ, array, 0, array.Length);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0000853E File Offset: 0x0000673E
		public static void CEHFHJHAEME()
		{
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000088AB File Offset: 0x00006AAB
		public static void FNDCNIOLOOC()
		{
			MBLFNIBGODG.EDCGNPBJIPD();
			if (FJNEGJPDHIC.NEIJLAHKDNM() == IntPtr.Zero && !FJNEGJPDHIC.GLFBHMMGHGL())
			{
				throw new InvalidOperationException("STEAMUGC_INTERFACE_VERSION016");
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000088D8 File Offset: 0x00006AD8
		public static void NHNKNABCLDI(string PPDGGDCAMNB, byte[] DGFMGMCDALB, int MOJLINGKGAA)
		{
			DGFMGMCDALB = new byte[MOJLINGKGAA];
			int bytes = Encoding.UTF8.GetBytes(PPDGGDCAMNB, 0, PPDGGDCAMNB.Length, DGFMGMCDALB, 1);
			DGFMGMCDALB[bytes] = 1;
		}

		// Token: 0x0200006F RID: 111
		public class LJANJDBDBJI : SafeHandleZeroOrMinusOneIsInvalid
		{
			// Token: 0x06000807 RID: 2055 RVA: 0x00008908 File Offset: 0x00006B08
			public LJANJDBDBJI(string PPDGGDCAMNB) : base(true)
			{
				if (PPDGGDCAMNB == null)
				{
					base.SetHandle(IntPtr.Zero);
					return;
				}
				byte[] array = new byte[Encoding.UTF8.GetByteCount(PPDGGDCAMNB) + 1];
				Encoding.UTF8.GetBytes(PPDGGDCAMNB, 0, PPDGGDCAMNB.Length, array, 0);
				IntPtr intPtr = Marshal.AllocHGlobal(array.Length);
				Marshal.Copy(array, 0, intPtr, array.Length);
				base.SetHandle(intPtr);
			}

			// Token: 0x06000808 RID: 2056 RVA: 0x0000896E File Offset: 0x00006B6E
			protected override bool ReleaseHandle()
			{
				if (!this.IsInvalid)
				{
					Marshal.FreeHGlobal(this.handle);
				}
				return true;
			}
		}

		// Token: 0x02000070 RID: 112
		public class LLPDMOBLMJG
		{
			// Token: 0x06000809 RID: 2057 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr PAJPEPCPJDP(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600080A RID: 2058 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr JFEMOMBFEAB(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600080B RID: 2059 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr BOGPFFPKFGH(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600080C RID: 2060 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr KLDBCIBANEF(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600080D RID: 2061 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr GLJLCCILMCD(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600080E RID: 2062 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr GKJCLPDBCHG(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600080F RID: 2063 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr MJAOAJNDANO(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000810 RID: 2064 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr CHMKLEOGPKN(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000811 RID: 2065 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr GIJBCCLKIAC(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000812 RID: 2066 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr OJAAPLBAMDB(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000813 RID: 2067 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr IBGNLNIDFPO(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000814 RID: 2068 RVA: 0x0000898C File Offset: 0x00006B8C
			protected override void Finalize()
			{
				try
				{
					if (this.DFBHMKKKMJK != null)
					{
						IntPtr[] dfbhmkkkmjk = this.DFBHMKKKMJK;
						for (int i = 0; i < dfbhmkkkmjk.Length; i++)
						{
							Marshal.FreeHGlobal(dfbhmkkkmjk[i]);
						}
					}
					if (this.GGBJFPGGBIO != IntPtr.Zero)
					{
						Marshal.FreeHGlobal(this.GGBJFPGGBIO);
					}
					if (this.KNNOFLDJDFC != IntPtr.Zero)
					{
						Marshal.FreeHGlobal(this.KNNOFLDJDFC);
					}
				}
				finally
				{
					base.Finalize();
				}
			}

			// Token: 0x06000815 RID: 2069 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr KOJHBOLDPHN(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000816 RID: 2070 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr MNMCFLOCMEL(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000817 RID: 2071 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr MLLDEEJPIHJ(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000818 RID: 2072 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr DMLKCGNOMHM(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000819 RID: 2073 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr NAEGHICDNGG(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600081A RID: 2074 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr KIBNBAONAFH(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600081B RID: 2075 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr OIBNALDEHDE(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600081C RID: 2076 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr GGLPKLGEBOL(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600081D RID: 2077 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr BMHKLAIGBOE(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600081E RID: 2078 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr DDIJNCPCPPD(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600081F RID: 2079 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr PEICEFDGOGJ(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000820 RID: 2080 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr GDNGPACFLMB(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000821 RID: 2081 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr ANIPDOHFBNO(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000822 RID: 2082 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr PMAMIEGLKGI(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000823 RID: 2083 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr HIEGGJJJJIM(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000824 RID: 2084 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr OOBEBEOPGLO(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000825 RID: 2085 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr AAALCMKIBIP(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000826 RID: 2086 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr BABPLFLNEGL(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000827 RID: 2087 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr MIGCEKOFIOJ(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000828 RID: 2088 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr NKBCJAFHMMJ(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000829 RID: 2089 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr IABDJGNANAB(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600082A RID: 2090 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr NNBKNIOBAHC(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600082B RID: 2091 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr FKPGACFDNFJ(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600082C RID: 2092 RVA: 0x00008A14 File Offset: 0x00006C14
			public LLPDMOBLMJG(IList<string> OEHCNNJJECI)
			{
				if (OEHCNNJJECI == null)
				{
					this.KNNOFLDJDFC = IntPtr.Zero;
					return;
				}
				this.DFBHMKKKMJK = new IntPtr[OEHCNNJJECI.Count];
				for (int i = 0; i < OEHCNNJJECI.Count; i++)
				{
					byte[] array = new byte[Encoding.UTF8.GetByteCount(OEHCNNJJECI[i]) + 1];
					Encoding.UTF8.GetBytes(OEHCNNJJECI[i], 0, OEHCNNJJECI[i].Length, array, 0);
					this.DFBHMKKKMJK[i] = Marshal.AllocHGlobal(array.Length);
					Marshal.Copy(array, 0, this.DFBHMKKKMJK[i], array.Length);
				}
				this.GGBJFPGGBIO = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * this.DFBHMKKKMJK.Length);
				BOLLDGJJLLM bolldgjjllm = new BOLLDGJJLLM
				{
					ECHAFABCHPN = this.GGBJFPGGBIO,
					PFPGEEMIELB = this.DFBHMKKKMJK.Length
				};
				Marshal.Copy(this.DFBHMKKKMJK, 0, bolldgjjllm.ECHAFABCHPN, this.DFBHMKKKMJK.Length);
				this.KNNOFLDJDFC = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(BOLLDGJJLLM)));
				Marshal.StructureToPtr<BOLLDGJJLLM>(bolldgjjllm, this.KNNOFLDJDFC, false);
			}

			// Token: 0x0600082D RID: 2093 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr NHMHFNOHOJH(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600082E RID: 2094 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr BIBNEOGMCEH(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x0600082F RID: 2095 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr BHCGOJKLLLO(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000830 RID: 2096 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr BJBPNDHAHFC(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x06000831 RID: 2097 RVA: 0x00008984 File Offset: 0x00006B84
			public static IntPtr LEMPLPBOLAD(MBLFNIBGODG.LLPDMOBLMJG MECNHBOFHJB)
			{
				return MECNHBOFHJB.KNNOFLDJDFC;
			}

			// Token: 0x04000311 RID: 785
			private IntPtr[] DFBHMKKKMJK;

			// Token: 0x04000312 RID: 786
			private IntPtr GGBJFPGGBIO;

			// Token: 0x04000313 RID: 787
			private IntPtr KNNOFLDJDFC;
		}
	}
}
