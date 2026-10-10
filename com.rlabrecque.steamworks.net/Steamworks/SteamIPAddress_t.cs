using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace Steamworks
{
	// Token: 0x020001EC RID: 492
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SteamIPAddress_t
	{
		// Token: 0x0600246A RID: 9322 RVA: 0x00019158 File Offset: 0x00017358
		public IPAddress BIFJGFEPLGB()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[8];
				array[1] = bytes[6];
				array[0] = bytes[3];
				array[7] = bytes[0];
				array[5] = bytes[1];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[40];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 4);
			return new IPAddress(array2);
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x000191D0 File Offset: 0x000173D0
		public IPAddress GEIKNALPALI()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[0];
				array[1] = bytes[2];
				array[0] = bytes[0];
				array[0] = bytes[1];
				array[7] = bytes[0];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[75];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 2);
			return new IPAddress(array2);
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF KHMDLNFKEBE()
		{
			return this.m_eType;
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF KNGBODGCBII()
		{
			return this.m_eType;
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x0001924F File Offset: 0x0001744F
		public bool EDMIPJCJCBM()
		{
			return this.m_ip0 == 0L && this.m_ip1 != 0L;
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF CBILPPCFONK()
		{
			return this.m_eType;
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x00019265 File Offset: 0x00017465
		public bool DGKJMIBGHGI()
		{
			return this.m_ip0 == 0L && this.m_ip1 > 1L;
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x0001927B File Offset: 0x0001747B
		public bool EAIECKOFNAO()
		{
			return this.m_ip0 != 0L || this.m_ip1 != 0L;
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF AEALDFEDCKG()
		{
			return this.m_eType;
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF LNBHEBMJBJN()
		{
			return this.m_eType;
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x00019294 File Offset: 0x00017494
		public IPAddress OKANJDEBBBE()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[4];
				array[0] = bytes[8];
				array[0] = bytes[8];
				array[5] = bytes[0];
				array[7] = bytes[0];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[-83];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 1);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 4);
			return new IPAddress(array2);
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x0001930C File Offset: 0x0001750C
		public IPAddress OFKEKJEEOHO()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				return new IPAddress(new byte[]
				{
					bytes[3],
					bytes[2],
					bytes[1],
					bytes[0]
				});
			}
			byte[] array = new byte[16];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array, 8);
			return new IPAddress(array);
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF GNPGADDKNJD()
		{
			return this.m_eType;
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF MHLCKPLDHIM()
		{
			return this.m_eType;
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF ELHFFBINIOG()
		{
			return this.m_eType;
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00019384 File Offset: 0x00017584
		public IPAddress BBMMMEFMHBK()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[8];
				array[0] = bytes[6];
				array[1] = bytes[2];
				array[8] = bytes[1];
				array[5] = bytes[1];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[-59];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 1);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 0);
			return new IPAddress(array2);
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF HADNDBFKJPD()
		{
			return this.m_eType;
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x000193FB File Offset: 0x000175FB
		public bool BAIJAMHFHLA()
		{
			return this.m_ip0 != 0L || this.m_ip1 > 1L;
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x00019414 File Offset: 0x00017614
		public IPAddress BOLIJBMCOIO()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[2];
				array[0] = bytes[2];
				array[0] = bytes[5];
				array[7] = bytes[0];
				array[2] = bytes[1];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[-65];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 1);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 7);
			return new IPAddress(array2);
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x0001948C File Offset: 0x0001768C
		public SteamIPAddress_t(IPAddress IJGODDGDGGL)
		{
			byte[] addressBytes = IJGODDGDGGL.GetAddressBytes();
			AddressFamily addressFamily = IJGODDGDGGL.AddressFamily;
			if (addressFamily != AddressFamily.InterNetwork)
			{
				if (addressFamily != AddressFamily.InterNetworkV6)
				{
					throw new TypeInitializationException("SteamIPAddress_t: Unexpected address family " + IJGODDGDGGL.AddressFamily.ToString(), null);
				}
				if (addressBytes.Length != 16)
				{
					throw new TypeInitializationException("SteamIPAddress_t: Unexpected byte length for Ipv6: " + addressBytes.Length.ToString(), null);
				}
				this.m_ip0 = (long)((int)addressBytes[1] << 24 | (int)addressBytes[0] << 16 | (int)addressBytes[3] << 8 | (int)addressBytes[2] | (int)addressBytes[5] << 24 | (int)addressBytes[4] << 16 | (int)addressBytes[7] << 8 | (int)addressBytes[6]);
				this.m_ip1 = (long)((int)addressBytes[9] << 24 | (int)addressBytes[8] << 16 | (int)addressBytes[11] << 8 | (int)addressBytes[10] | (int)addressBytes[13] << 24 | (int)addressBytes[12] << 16 | (int)addressBytes[15] << 8 | (int)addressBytes[14]);
				this.m_eType = DMFCADALDJF.k_ESteamIPTypeIPv6;
				return;
			}
			else
			{
				if (addressBytes.Length != 4)
				{
					throw new TypeInitializationException("SteamIPAddress_t: Unexpected byte length for Ipv4." + addressBytes.Length.ToString(), null);
				}
				this.m_ip0 = (long)((int)addressBytes[0] << 24 | (int)addressBytes[1] << 16 | (int)addressBytes[2] << 8 | (int)addressBytes[3]);
				this.m_ip1 = 0L;
				this.m_eType = DMFCADALDJF.k_ESteamIPTypeIPv4;
				return;
			}
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x000193FB File Offset: 0x000175FB
		public bool AEEPGJKJLGN()
		{
			return this.m_ip0 != 0L || this.m_ip1 > 1L;
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x0001927B File Offset: 0x0001747B
		public bool MFDDNAJPIDH()
		{
			return this.m_ip0 != 0L || this.m_ip1 != 0L;
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x000195C8 File Offset: 0x000177C8
		public IPAddress HKACLGPKHEL()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[0];
				array[0] = bytes[8];
				array[0] = bytes[1];
				array[2] = bytes[0];
				array[2] = bytes[0];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[-20];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 1);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 0);
			return new IPAddress(array2);
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00019640 File Offset: 0x00017840
		public IPAddress KJCEPJOGCHE()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[6];
				array[0] = bytes[7];
				array[0] = bytes[1];
				array[8] = bytes[1];
				array[1] = bytes[1];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[6];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 8);
			return new IPAddress(array2);
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF PCOMDPGLMMP()
		{
			return this.m_eType;
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF CMLDCNLEBAC()
		{
			return this.m_eType;
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF NOFCNBFFLPC()
		{
			return this.m_eType;
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF DBNIJFIMFLE()
		{
			return this.m_eType;
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x000196B8 File Offset: 0x000178B8
		public IPAddress ADILBOFGLBJ()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[]
				{
					0,
					bytes[4]
				};
				array[1] = bytes[0];
				array[2] = bytes[1];
				array[1] = bytes[1];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[107];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 7);
			return new IPAddress(array2);
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF HEAKNDNFAGB()
		{
			return this.m_eType;
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x00019730 File Offset: 0x00017930
		public IPAddress EIKBNOJDGEH()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[8];
				array[0] = bytes[8];
				array[0] = bytes[0];
				array[1] = bytes[0];
				array[2] = bytes[0];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[-90];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 0);
			return new IPAddress(array2);
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x000197A8 File Offset: 0x000179A8
		public IPAddress NBLFKAOEINK()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[3];
				array[1] = bytes[7];
				array[1] = bytes[8];
				array[7] = bytes[0];
				array[6] = bytes[0];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[52];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 3);
			return new IPAddress(array2);
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x0001927B File Offset: 0x0001747B
		public bool LNEHHGCEIIN()
		{
			return this.m_ip0 != 0L || this.m_ip1 != 0L;
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF JHPLPMBIBML()
		{
			return this.m_eType;
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00019820 File Offset: 0x00017A20
		public IPAddress LCPHGGKEAKL()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[5];
				array[0] = bytes[5];
				array[0] = bytes[5];
				array[7] = bytes[1];
				array[6] = bytes[1];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[-65];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 5);
			return new IPAddress(array2);
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF ECINODNCMCN()
		{
			return this.m_eType;
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x00019265 File Offset: 0x00017465
		public bool LABDLJPJIPH()
		{
			return this.m_ip0 == 0L && this.m_ip1 > 1L;
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x0001924F File Offset: 0x0001744F
		public bool LPNKBNIGFDJ()
		{
			return this.m_ip0 == 0L && this.m_ip1 != 0L;
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00019898 File Offset: 0x00017A98
		public IPAddress GNBBAGFHEIC()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[]
				{
					bytes[3]
				};
				array[0] = bytes[7];
				array[8] = bytes[1];
				array[4] = bytes[0];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[108];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 1);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 4);
			return new IPAddress(array2);
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x0001990F File Offset: 0x00017B0F
		public override string ToString()
		{
			return this.OFKEKJEEOHO().ToString();
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF CDOAJAIELIC()
		{
			return this.m_eType;
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x0001991C File Offset: 0x00017B1C
		public IPAddress DGEPAIMNIKB()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[3];
				array[1] = bytes[8];
				array[1] = bytes[5];
				array[3] = bytes[0];
				array[7] = bytes[1];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[76];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 4);
			return new IPAddress(array2);
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00019994 File Offset: 0x00017B94
		public IPAddress HFAMFNHOHCA()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				return new IPAddress(new byte[]
				{
					bytes[7],
					bytes[2],
					0,
					bytes[1],
					0,
					0,
					0,
					bytes[0]
				});
			}
			byte[] array = new byte[120];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array, 1);
			return new IPAddress(array);
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00019A0C File Offset: 0x00017C0C
		public IPAddress CELCIOJIICK()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[0];
				array[1] = bytes[7];
				array[0] = bytes[1];
				array[8] = bytes[1];
				array[0] = bytes[0];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[-62];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 1);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 2);
			return new IPAddress(array2);
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x00019A84 File Offset: 0x00017C84
		public IPAddress HJFOPJNCKLH()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[1];
				array[1] = bytes[2];
				array[1] = bytes[5];
				array[2] = bytes[1];
				array[6] = bytes[1];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[127];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 8);
			return new IPAddress(array2);
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF KPCHCLMAOKD()
		{
			return this.m_eType;
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF MAKBMOOPJML()
		{
			return this.m_eType;
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x0001927B File Offset: 0x0001747B
		public bool DNNODMABGNK()
		{
			return this.m_ip0 != 0L || this.m_ip1 != 0L;
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF CCGCGAOPPAM()
		{
			return this.m_eType;
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x000193FB File Offset: 0x000175FB
		public bool LBDALPKCDDP()
		{
			return this.m_ip0 != 0L || this.m_ip1 > 1L;
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00019AFC File Offset: 0x00017CFC
		public IPAddress FJBJBMBICON()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[7];
				array[0] = bytes[4];
				array[1] = bytes[1];
				array[4] = bytes[0];
				array[4] = bytes[1];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[-30];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 1);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 1);
			return new IPAddress(array2);
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x00019265 File Offset: 0x00017465
		public bool EGOFJDGBGMM()
		{
			return this.m_ip0 == 0L && this.m_ip1 > 1L;
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF IJOKAAOEGGI()
		{
			return this.m_eType;
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x00019265 File Offset: 0x00017465
		public bool ADKDPDACOCE()
		{
			return this.m_ip0 == 0L && this.m_ip1 > 1L;
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x000193FB File Offset: 0x000175FB
		public bool DGKHBJMKILG()
		{
			return this.m_ip0 != 0L || this.m_ip1 > 1L;
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF FJEFCFMIMNJ()
		{
			return this.m_eType;
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x0001924F File Offset: 0x0001744F
		public bool HJNNKMNJOPO()
		{
			return this.m_ip0 == 0L && this.m_ip1 != 0L;
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF DHNOHJLLAJB()
		{
			return this.m_eType;
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0001927B File Offset: 0x0001747B
		public bool OOKHOMBLNJH()
		{
			return this.m_ip0 != 0L || this.m_ip1 != 0L;
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF BOIHAPABIPA()
		{
			return this.m_eType;
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x00019B74 File Offset: 0x00017D74
		public IPAddress GJCNNHABKHB()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[8];
				array[0] = bytes[8];
				array[0] = bytes[1];
				array[7] = bytes[0];
				array[3] = bytes[1];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[96];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 5);
			return new IPAddress(array2);
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF BLDKHOJJECC()
		{
			return this.m_eType;
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x000193FB File Offset: 0x000175FB
		public bool DMBMAKNJAFP()
		{
			return this.m_ip0 != 0L || this.m_ip1 > 1L;
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x00019BEC File Offset: 0x00017DEC
		public IPAddress DOFIFKMKJNG()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[4];
				array[1] = bytes[4];
				array[0] = bytes[3];
				array[8] = bytes[1];
				array[1] = bytes[1];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[83];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 4);
			return new IPAddress(array2);
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF OPCPGBEFCBO()
		{
			return this.m_eType;
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x000193FB File Offset: 0x000175FB
		public bool FGCNFAMICDN()
		{
			return this.m_ip0 != 0L || this.m_ip1 > 1L;
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0001924F File Offset: 0x0001744F
		public bool IHCGLNKGMMH()
		{
			return this.m_ip0 == 0L && this.m_ip1 != 0L;
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00019C64 File Offset: 0x00017E64
		public IPAddress MKEENEHHMPL()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[5];
				array[0] = bytes[2];
				array[0] = bytes[0];
				array[0] = bytes[0];
				array[3] = bytes[1];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[-77];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 0);
			return new IPAddress(array2);
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00019CDC File Offset: 0x00017EDC
		public IPAddress MFDHADKBEKC()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[7];
				array[0] = bytes[2];
				array[0] = bytes[2];
				array[4] = bytes[1];
				array[5] = bytes[1];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[-99];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 0);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 6);
			return new IPAddress(array2);
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x00019D54 File Offset: 0x00017F54
		public IPAddress PHMGFJPOFHJ()
		{
			if (this.m_eType == DMFCADALDJF.k_ESteamIPTypeIPv4)
			{
				byte[] bytes = BitConverter.GetBytes(this.m_ip0);
				byte[] array = new byte[3];
				array[0] = bytes[8];
				array[0] = bytes[6];
				array[7] = bytes[1];
				array[2] = bytes[0];
				return new IPAddress(array);
			}
			byte[] array2 = new byte[-34];
			BitConverter.GetBytes(this.m_ip0).CopyTo(array2, 1);
			BitConverter.GetBytes(this.m_ip1).CopyTo(array2, 5);
			return new IPAddress(array2);
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x0001927B File Offset: 0x0001747B
		public bool CJKLNMOCGKB()
		{
			return this.m_ip0 != 0L || this.m_ip1 != 0L;
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF DEIPIEJALJF()
		{
			return this.m_eType;
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF HMGPNPHFCKO()
		{
			return this.m_eType;
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x00019247 File Offset: 0x00017447
		public DMFCADALDJF LEFKBHNPGBE()
		{
			return this.m_eType;
		}

		// Token: 0x04000AE9 RID: 2793
		private long m_ip0;

		// Token: 0x04000AEA RID: 2794
		private long m_ip1;

		// Token: 0x04000AEB RID: 2795
		private DMFCADALDJF m_eType;
	}
}
