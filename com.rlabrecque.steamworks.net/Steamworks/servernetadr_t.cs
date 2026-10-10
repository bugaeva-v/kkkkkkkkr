using System;

namespace Steamworks
{
	// Token: 0x020001C7 RID: 455
	[Serializable]
	public struct servernetadr_t
	{
		// Token: 0x06002349 RID: 9033 RVA: 0x00018518 File Offset: 0x00016718
		public string EFAHPACJKED()
		{
			return servernetadr_t.IFHHKFIEDFP(this.m_unIP, this.m_usConnectionPort);
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x0001852B File Offset: 0x0001672B
		public int JHNOPELLICH(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP.CompareTo(LNBMEILJKDH.m_unIP) + this.m_usQueryPort.CompareTo(LNBMEILJKDH.m_usQueryPort) + this.m_usConnectionPort.CompareTo(LNBMEILJKDH.m_usConnectionPort);
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00018562 File Offset: 0x00016762
		public string JCOHONGHMNM()
		{
			return servernetadr_t.FFPLEFPLADA(this.m_unIP, this.m_usConnectionPort);
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00018575 File Offset: 0x00016775
		public static bool GGKPHDIAJBH(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return !servernetadr_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0001852B File Offset: 0x0001672B
		public int FEAMPHPBLDN(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP.CompareTo(LNBMEILJKDH.m_unIP) + this.m_usQueryPort.CompareTo(LNBMEILJKDH.m_usQueryPort) + this.m_usConnectionPort.CompareTo(LNBMEILJKDH.m_usConnectionPort);
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x00018584 File Offset: 0x00016784
		public static string NHDHDBEMJCC(uint FLGFECHPNIF, ushort KLBOAFDGBGD)
		{
			string format = "pItemDefIDs must be the same size as punItemDefIDsArraySize!";
			object[] array = new object[0];
			array[1] = ((ulong)(FLGFECHPNIF >> -124) & 18446744073709551456UL);
			array[1] = ((ulong)(FLGFECHPNIF >> -27) & 18446744073709551492UL);
			array[0] = ((ulong)(FLGFECHPNIF >> 3) & 18446744073709551484UL);
			array[7] = ((ulong)FLGFECHPNIF & 18446744073709551524UL);
			array[2] = KLBOAFDGBGD;
			return string.Format(format, array);
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x000185F6 File Offset: 0x000167F6
		public bool MBFMHOMAONI(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP == LNBMEILJKDH.m_unIP && this.m_usQueryPort == LNBMEILJKDH.m_usQueryPort && this.m_usConnectionPort == LNBMEILJKDH.m_usConnectionPort;
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x00018624 File Offset: 0x00016824
		public static bool JFCLBKPJNLL(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP <= DEJFBNMNMOK.m_unIP && (OBNBCGOIMKE.m_unIP != DEJFBNMNMOK.m_unIP || OBNBCGOIMKE.m_usQueryPort > DEJFBNMNMOK.m_usQueryPort);
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x0001852B File Offset: 0x0001672B
		public int IKDJDCLHBGI(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP.CompareTo(LNBMEILJKDH.m_unIP) + this.m_usQueryPort.CompareTo(LNBMEILJKDH.m_usQueryPort) + this.m_usConnectionPort.CompareTo(LNBMEILJKDH.m_usConnectionPort);
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x00018654 File Offset: 0x00016854
		public static bool LPHKOLIFFNO(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return servernetadr_t.ILILDKIKFHN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x00018660 File Offset: 0x00016860
		public static bool EIPBBOHNKFK(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return servernetadr_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x0001866C File Offset: 0x0001686C
		public void FPFFIDGPFNO(uint FLGFECHPNIF)
		{
			this.m_unIP = FLGFECHPNIF;
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x00018675 File Offset: 0x00016875
		public string KGPDALKEFAI()
		{
			return servernetadr_t.HNLIALGFMJH(this.m_unIP, this.m_usQueryPort);
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x0001866C File Offset: 0x0001686C
		public void BBALOGAJPFE(uint FLGFECHPNIF)
		{
			this.m_unIP = FLGFECHPNIF;
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x00018688 File Offset: 0x00016888
		public ushort EDCOJKCNCNM()
		{
			return this.m_usQueryPort;
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00018690 File Offset: 0x00016890
		public string CKLGFFPLKIE()
		{
			return servernetadr_t.OKMIBIHFEHH(this.m_unIP, this.m_usConnectionPort);
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x000186A3 File Offset: 0x000168A3
		public uint LGCNCKNHDCN()
		{
			return this.m_unIP;
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x000186AB File Offset: 0x000168AB
		public string COPBNJHAAEN()
		{
			return servernetadr_t.FFPLEFPLADA(this.m_unIP, this.m_usQueryPort);
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x000186BE File Offset: 0x000168BE
		public static bool OGEBIEPJENL(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP >= DEJFBNMNMOK.m_unIP && (OBNBCGOIMKE.m_unIP != DEJFBNMNMOK.m_unIP || OBNBCGOIMKE.m_usQueryPort < DEJFBNMNMOK.m_usQueryPort);
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x000186AB File Offset: 0x000168AB
		public string NMELCKFBMBO()
		{
			return servernetadr_t.FFPLEFPLADA(this.m_unIP, this.m_usQueryPort);
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x000186EE File Offset: 0x000168EE
		public static bool KIBKANNBCNB(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP > DEJFBNMNMOK.m_unIP || (OBNBCGOIMKE.m_unIP == DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_usQueryPort > DEJFBNMNMOK.m_usQueryPort);
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x0001871E File Offset: 0x0001691E
		public void CIPNOEEFPEO(ushort KLBOAFDGBGD)
		{
			this.m_usConnectionPort = KLBOAFDGBGD;
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00018727 File Offset: 0x00016927
		public void LNIMGCALLIL(uint PMMAHNECNIN, ushort KMLJPOGEMNO, ushort IGFEDDIMDAF)
		{
			this.m_unIP = PMMAHNECNIN;
			this.m_usQueryPort = KMLJPOGEMNO;
			this.m_usConnectionPort = IGFEDDIMDAF;
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x000186A3 File Offset: 0x000168A3
		public uint ONKIMPNFJNO()
		{
			return this.m_unIP;
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x0001873E File Offset: 0x0001693E
		public ushort JACMFHOGLME()
		{
			return this.m_usConnectionPort;
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x000186A3 File Offset: 0x000168A3
		public uint NJCNKADHIEN()
		{
			return this.m_unIP;
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x00018746 File Offset: 0x00016946
		public static bool HJLDBHMLPMI(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP < DEJFBNMNMOK.m_unIP || OBNBCGOIMKE.m_unIP != DEJFBNMNMOK.m_unIP || OBNBCGOIMKE.m_usQueryPort < DEJFBNMNMOK.m_usQueryPort;
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x000185F6 File Offset: 0x000167F6
		public bool HOOEDAAGDGJ(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP == LNBMEILJKDH.m_unIP && this.m_usQueryPort == LNBMEILJKDH.m_usQueryPort && this.m_usConnectionPort == LNBMEILJKDH.m_usConnectionPort;
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00018688 File Offset: 0x00016888
		public ushort GMJGBLHBFJO()
		{
			return this.m_usQueryPort;
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x0001873E File Offset: 0x0001693E
		public ushort AHPHHNDKGPO()
		{
			return this.m_usConnectionPort;
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x00018660 File Offset: 0x00016860
		public static bool DOELMPHIGAG(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return servernetadr_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x000186A3 File Offset: 0x000168A3
		public uint HOFALJHCGLK()
		{
			return this.m_unIP;
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x000185F6 File Offset: 0x000167F6
		public static bool MKGNKAMFMPG(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP == DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_usQueryPort == DEJFBNMNMOK.m_usQueryPort && OBNBCGOIMKE.m_usConnectionPort == DEJFBNMNMOK.m_usConnectionPort;
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x00018776 File Offset: 0x00016976
		public void CIAEPKFAMPM(ushort KLBOAFDGBGD)
		{
			this.m_usQueryPort = KLBOAFDGBGD;
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00018776 File Offset: 0x00016976
		public void JKLBGMLACOB(ushort KLBOAFDGBGD)
		{
			this.m_usQueryPort = KLBOAFDGBGD;
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x0001877F File Offset: 0x0001697F
		public bool LOFCAANOECF(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP != LNBMEILJKDH.m_unIP || this.m_usQueryPort != LNBMEILJKDH.m_usQueryPort || this.m_usConnectionPort == LNBMEILJKDH.m_usConnectionPort;
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x000187AD File Offset: 0x000169AD
		public static bool OPELMELIJFM(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP < DEJFBNMNMOK.m_unIP || (OBNBCGOIMKE.m_unIP == DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_usQueryPort < DEJFBNMNMOK.m_usQueryPort);
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x000186EE File Offset: 0x000168EE
		public static bool NOFKEMKIMHI(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP > DEJFBNMNMOK.m_unIP || (OBNBCGOIMKE.m_unIP == DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_usQueryPort > DEJFBNMNMOK.m_usQueryPort);
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x000187E0 File Offset: 0x000169E0
		public static string AGHINCDCDCP(uint FLGFECHPNIF, ushort KLBOAFDGBGD)
		{
			string format = "STEAMREMOTEPLAY_INTERFACE_VERSION001";
			object[] array = new object[5];
			array[0] = ((ulong)(FLGFECHPNIF >> -102) & 18446744073709551564UL);
			array[0] = ((ulong)(FLGFECHPNIF >> 61) & 94UL);
			array[6] = ((ulong)(FLGFECHPNIF >> 1) & 62UL);
			array[1] = ((ulong)FLGFECHPNIF & 18446744073709551536UL);
			array[1] = KLBOAFDGBGD;
			return string.Format(format, array);
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x0001871E File Offset: 0x0001691E
		public void FEAHDKDNCPJ(ushort KLBOAFDGBGD)
		{
			this.m_usConnectionPort = KLBOAFDGBGD;
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x0001873E File Offset: 0x0001693E
		public ushort KMHMGOGCBDL()
		{
			return this.m_usConnectionPort;
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x0001871E File Offset: 0x0001691E
		public void BJHEHLNGCIJ(ushort KLBOAFDGBGD)
		{
			this.m_usConnectionPort = KLBOAFDGBGD;
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x00018852 File Offset: 0x00016A52
		public static bool MAMNJIDPNME(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return !servernetadr_t.ECBCJIBHMHH(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x00018860 File Offset: 0x00016A60
		public static string OKMIBIHFEHH(uint FLGFECHPNIF, ushort KLBOAFDGBGD)
		{
			string format = "\0";
			object[] array = new object[]
			{
				null,
				(ulong)(FLGFECHPNIF >> -1) & 18446744073709551475UL
			};
			array[1] = ((ulong)(FLGFECHPNIF >> 105) & 142UL);
			array[7] = ((ulong)(FLGFECHPNIF >> 8) & 171UL);
			array[3] = ((ulong)FLGFECHPNIF & 159UL);
			array[3] = KLBOAFDGBGD;
			return string.Format(format, array);
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x000188D2 File Offset: 0x00016AD2
		public override int GetHashCode()
		{
			return this.m_unIP.GetHashCode() + this.m_usQueryPort.GetHashCode() + this.m_usConnectionPort.GetHashCode();
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x000188F7 File Offset: 0x00016AF7
		public string EJBJCIFONGN()
		{
			return servernetadr_t.EEBEDKOFCOB(this.m_unIP, this.m_usQueryPort);
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x0001866C File Offset: 0x0001686C
		public void NNJPAELEEKI(uint FLGFECHPNIF)
		{
			this.m_unIP = FLGFECHPNIF;
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x000186A3 File Offset: 0x000168A3
		public uint GNPCKHIJFGD()
		{
			return this.m_unIP;
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x0001852B File Offset: 0x0001672B
		public int FIIHLFOLBBH(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP.CompareTo(LNBMEILJKDH.m_unIP) + this.m_usQueryPort.CompareTo(LNBMEILJKDH.m_usQueryPort) + this.m_usConnectionPort.CompareTo(LNBMEILJKDH.m_usConnectionPort);
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x000186EE File Offset: 0x000168EE
		public static bool KEIINNKNDEA(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP > DEJFBNMNMOK.m_unIP || (OBNBCGOIMKE.m_unIP == DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_usQueryPort > DEJFBNMNMOK.m_usQueryPort);
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00018776 File Offset: 0x00016976
		public void EIEDDIAHONF(ushort KLBOAFDGBGD)
		{
			this.m_usQueryPort = KLBOAFDGBGD;
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x0001852B File Offset: 0x0001672B
		public int DBPPIBGCMAG(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP.CompareTo(LNBMEILJKDH.m_unIP) + this.m_usQueryPort.CompareTo(LNBMEILJKDH.m_usQueryPort) + this.m_usConnectionPort.CompareTo(LNBMEILJKDH.m_usConnectionPort);
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x00018660 File Offset: 0x00016860
		public static bool FEBLNNBLGEA(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return servernetadr_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x000187AD File Offset: 0x000169AD
		public static bool KIPJMBMOACK(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP < DEJFBNMNMOK.m_unIP || (OBNBCGOIMKE.m_unIP == DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_usQueryPort < DEJFBNMNMOK.m_usQueryPort);
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x000185F6 File Offset: 0x000167F6
		public static bool ECBCJIBHMHH(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP == DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_usQueryPort == DEJFBNMNMOK.m_usQueryPort && OBNBCGOIMKE.m_usConnectionPort == DEJFBNMNMOK.m_usConnectionPort;
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0001877F File Offset: 0x0001697F
		public bool KCAPPOKNPBN(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP != LNBMEILJKDH.m_unIP || this.m_usQueryPort != LNBMEILJKDH.m_usQueryPort || this.m_usConnectionPort == LNBMEILJKDH.m_usConnectionPort;
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00018624 File Offset: 0x00016824
		public static bool FDNFNILGILH(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP <= DEJFBNMNMOK.m_unIP && (OBNBCGOIMKE.m_unIP != DEJFBNMNMOK.m_unIP || OBNBCGOIMKE.m_usQueryPort > DEJFBNMNMOK.m_usQueryPort);
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x0001866C File Offset: 0x0001686C
		public void PCNIPMKGBAO(uint FLGFECHPNIF)
		{
			this.m_unIP = FLGFECHPNIF;
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0001873E File Offset: 0x0001693E
		public ushort HGJAIICCDKE()
		{
			return this.m_usConnectionPort;
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x0001890A File Offset: 0x00016B0A
		public string NDOKMIHIFKM()
		{
			return servernetadr_t.NKHFJMFHADI(this.m_unIP, this.m_usConnectionPort);
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x000186BE File Offset: 0x000168BE
		public static bool DCCFHGDNIBM(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP >= DEJFBNMNMOK.m_unIP && (OBNBCGOIMKE.m_unIP != DEJFBNMNMOK.m_unIP || OBNBCGOIMKE.m_usQueryPort < DEJFBNMNMOK.m_usQueryPort);
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x000186A3 File Offset: 0x000168A3
		public uint IJBAIBCPGND()
		{
			return this.m_unIP;
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00018688 File Offset: 0x00016888
		public ushort MKLGBANPDDL()
		{
			return this.m_usQueryPort;
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00018688 File Offset: 0x00016888
		public ushort EALDFGGNFOM()
		{
			return this.m_usQueryPort;
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x000186A3 File Offset: 0x000168A3
		public uint LLFODEGDFJJ()
		{
			return this.m_unIP;
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x0001873E File Offset: 0x0001693E
		public ushort FADFLHPKJIP()
		{
			return this.m_usConnectionPort;
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x0001871E File Offset: 0x0001691E
		public void GGBGAFNFKCI(ushort KLBOAFDGBGD)
		{
			this.m_usConnectionPort = KLBOAFDGBGD;
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x000185F6 File Offset: 0x000167F6
		public bool MDJCEENBHCF(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP == LNBMEILJKDH.m_unIP && this.m_usQueryPort == LNBMEILJKDH.m_usQueryPort && this.m_usConnectionPort == LNBMEILJKDH.m_usConnectionPort;
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x0001873E File Offset: 0x0001693E
		public ushort NOEJFDALMDN()
		{
			return this.m_usConnectionPort;
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x0001866C File Offset: 0x0001686C
		public void KCHPMHCLAHD(uint FLGFECHPNIF)
		{
			this.m_unIP = FLGFECHPNIF;
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x0001891D File Offset: 0x00016B1D
		public static bool FGPBPPLPDJA(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return !servernetadr_t.ILILDKIKFHN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x0001873E File Offset: 0x0001693E
		public ushort LMFIMJPHAAF()
		{
			return this.m_usConnectionPort;
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0001892C File Offset: 0x00016B2C
		public static string FFPLEFPLADA(uint FLGFECHPNIF, ushort KLBOAFDGBGD)
		{
			return string.Format("{0}.{1}.{2}.{3}:{4}", new object[]
			{
				(ulong)(FLGFECHPNIF >> 24) & 255UL,
				(ulong)(FLGFECHPNIF >> 16) & 255UL,
				(ulong)(FLGFECHPNIF >> 8) & 255UL,
				(ulong)FLGFECHPNIF & 255UL,
				KLBOAFDGBGD
			});
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x000188F7 File Offset: 0x00016AF7
		public string OEIKKFDEDBD()
		{
			return servernetadr_t.EEBEDKOFCOB(this.m_unIP, this.m_usQueryPort);
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x00018575 File Offset: 0x00016775
		public static bool NEFGNGBGAJI(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return !servernetadr_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x00018727 File Offset: 0x00016927
		public void NECNFJKICHN(uint PMMAHNECNIN, ushort KMLJPOGEMNO, ushort IGFEDDIMDAF)
		{
			this.m_unIP = PMMAHNECNIN;
			this.m_usQueryPort = KMLJPOGEMNO;
			this.m_usConnectionPort = IGFEDDIMDAF;
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x0001852B File Offset: 0x0001672B
		public int GOOANKMJIMN(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP.CompareTo(LNBMEILJKDH.m_unIP) + this.m_usQueryPort.CompareTo(LNBMEILJKDH.m_usQueryPort) + this.m_usConnectionPort.CompareTo(LNBMEILJKDH.m_usConnectionPort);
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x000189A0 File Offset: 0x00016BA0
		public static string EEBEDKOFCOB(uint FLGFECHPNIF, ushort KLBOAFDGBGD)
		{
			string format = "STEAMHTTP_INTERFACE_VERSION003";
			object[] array = new object[1];
			array[0] = ((ulong)(FLGFECHPNIF >> 25) & 92UL);
			array[1] = ((ulong)(FLGFECHPNIF >> -64) & 18446744073709551477UL);
			array[3] = ((ulong)(FLGFECHPNIF >> 3) & 88UL);
			array[5] = ((ulong)FLGFECHPNIF & 18446744073709551429UL);
			array[7] = KLBOAFDGBGD;
			return string.Format(format, array);
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x00018A12 File Offset: 0x00016C12
		public string NMGPKINCELL()
		{
			return servernetadr_t.AGHINCDCDCP(this.m_unIP, this.m_usQueryPort);
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x000186A3 File Offset: 0x000168A3
		public uint DJDGMDGMIOG()
		{
			return this.m_unIP;
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x00018A28 File Offset: 0x00016C28
		public static string IFHHKFIEDFP(uint FLGFECHPNIF, ushort KLBOAFDGBGD)
		{
			string format = "SteamNetworking006";
			object[] array = new object[8];
			array[0] = ((ulong)(FLGFECHPNIF >> -102) & 18446744073709551593UL);
			array[1] = ((ulong)(FLGFECHPNIF >> -116) & 18446744073709551549UL);
			array[2] = ((ulong)(FLGFECHPNIF >> 4) & 18446744073709551558UL);
			array[0] = ((ulong)FLGFECHPNIF & 97UL);
			array[7] = KLBOAFDGBGD;
			return string.Format(format, array);
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00018727 File Offset: 0x00016927
		public void PNDBPOCHIBK(uint PMMAHNECNIN, ushort KMLJPOGEMNO, ushort IGFEDDIMDAF)
		{
			this.m_unIP = PMMAHNECNIN;
			this.m_usQueryPort = KMLJPOGEMNO;
			this.m_usConnectionPort = IGFEDDIMDAF;
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00018A9A File Offset: 0x00016C9A
		public static bool LLMDIJLOFJF(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP <= DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_unIP == DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_usQueryPort > DEJFBNMNMOK.m_usQueryPort;
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x0001871E File Offset: 0x0001691E
		public void LHOHIFALJPL(ushort KLBOAFDGBGD)
		{
			this.m_usConnectionPort = KLBOAFDGBGD;
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x0001852B File Offset: 0x0001672B
		public int JHOEELHBEJJ(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP.CompareTo(LNBMEILJKDH.m_unIP) + this.m_usQueryPort.CompareTo(LNBMEILJKDH.m_usQueryPort) + this.m_usConnectionPort.CompareTo(LNBMEILJKDH.m_usConnectionPort);
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00018675 File Offset: 0x00016875
		public string NAIDKFCBKLF()
		{
			return servernetadr_t.HNLIALGFMJH(this.m_unIP, this.m_usQueryPort);
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x000186A3 File Offset: 0x000168A3
		public uint MHAPCALFLFN()
		{
			return this.m_unIP;
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x00018776 File Offset: 0x00016976
		public void IFBPHHLECCB(ushort KLBOAFDGBGD)
		{
			this.m_usQueryPort = KLBOAFDGBGD;
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x00018ACA File Offset: 0x00016CCA
		public string DFPFIOFNNGJ()
		{
			return servernetadr_t.NHDHDBEMJCC(this.m_unIP, this.m_usConnectionPort);
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x00018562 File Offset: 0x00016762
		public string MLFJMPNGIIB()
		{
			return servernetadr_t.FFPLEFPLADA(this.m_unIP, this.m_usConnectionPort);
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x00018746 File Offset: 0x00016946
		public static bool KGAKEMDNLKF(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP < DEJFBNMNMOK.m_unIP || OBNBCGOIMKE.m_unIP != DEJFBNMNMOK.m_unIP || OBNBCGOIMKE.m_usQueryPort < DEJFBNMNMOK.m_usQueryPort;
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x000186A3 File Offset: 0x000168A3
		public uint LKDFGEMFKFF()
		{
			return this.m_unIP;
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0001877F File Offset: 0x0001697F
		public bool OLIDABINOGH(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP != LNBMEILJKDH.m_unIP || this.m_usQueryPort != LNBMEILJKDH.m_usQueryPort || this.m_usConnectionPort == LNBMEILJKDH.m_usConnectionPort;
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x000186EE File Offset: 0x000168EE
		public static bool KABLHJIDODH(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP > DEJFBNMNMOK.m_unIP || (OBNBCGOIMKE.m_unIP == DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_usQueryPort > DEJFBNMNMOK.m_usQueryPort);
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x0001871E File Offset: 0x0001691E
		public void BCOAOGODOAI(ushort KLBOAFDGBGD)
		{
			this.m_usConnectionPort = KLBOAFDGBGD;
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0001871E File Offset: 0x0001691E
		public void PAGCOHHMMHI(ushort KLBOAFDGBGD)
		{
			this.m_usConnectionPort = KLBOAFDGBGD;
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x00018690 File Offset: 0x00016890
		public string GCLFCFHODDK()
		{
			return servernetadr_t.OKMIBIHFEHH(this.m_unIP, this.m_usConnectionPort);
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x000186EE File Offset: 0x000168EE
		public static bool DMFNFOFEGPJ(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP > DEJFBNMNMOK.m_unIP || (OBNBCGOIMKE.m_unIP == DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_usQueryPort > DEJFBNMNMOK.m_usQueryPort);
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x000185F6 File Offset: 0x000167F6
		public static bool ILILDKIKFHN(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP == DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_usQueryPort == DEJFBNMNMOK.m_usQueryPort && OBNBCGOIMKE.m_usConnectionPort == DEJFBNMNMOK.m_usConnectionPort;
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x00018ADD File Offset: 0x00016CDD
		public string PJEFGJPAIKH()
		{
			return servernetadr_t.AGHINCDCDCP(this.m_unIP, this.m_usConnectionPort);
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x00018ACA File Offset: 0x00016CCA
		public string FBLLLKNGKPJ()
		{
			return servernetadr_t.NHDHDBEMJCC(this.m_unIP, this.m_usConnectionPort);
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x0001852B File Offset: 0x0001672B
		public int JBBMFIDAPOB(servernetadr_t LNBMEILJKDH)
		{
			return this.m_unIP.CompareTo(LNBMEILJKDH.m_unIP) + this.m_usQueryPort.CompareTo(LNBMEILJKDH.m_usQueryPort) + this.m_usConnectionPort.CompareTo(LNBMEILJKDH.m_usConnectionPort);
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x0001866C File Offset: 0x0001686C
		public void BMHJEJHBLIM(uint FLGFECHPNIF)
		{
			this.m_unIP = FLGFECHPNIF;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00018AF0 File Offset: 0x00016CF0
		public static string NKHFJMFHADI(uint FLGFECHPNIF, ushort KLBOAFDGBGD)
		{
			string format = "originsOut must be the same size as Constants.STEAM_INPUT_MAX_ORIGINS!";
			object[] array = new object[]
			{
				null,
				(ulong)(FLGFECHPNIF >> 21) & 59UL
			};
			array[0] = ((ulong)(FLGFECHPNIF >> -20) & 18446744073709551560UL);
			array[6] = ((ulong)(FLGFECHPNIF >> 7) & 193UL);
			array[7] = ((ulong)FLGFECHPNIF & 80UL);
			array[4] = KLBOAFDGBGD;
			return string.Format(format, array);
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x000187AD File Offset: 0x000169AD
		public static bool NNONGKKOBKI(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP < DEJFBNMNMOK.m_unIP || (OBNBCGOIMKE.m_unIP == DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_usQueryPort < DEJFBNMNMOK.m_usQueryPort);
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x00018727 File Offset: 0x00016927
		public void GLFBHMMGHGL(uint PMMAHNECNIN, ushort KMLJPOGEMNO, ushort IGFEDDIMDAF)
		{
			this.m_unIP = PMMAHNECNIN;
			this.m_usQueryPort = KMLJPOGEMNO;
			this.m_usConnectionPort = IGFEDDIMDAF;
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x00018B62 File Offset: 0x00016D62
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is servernetadr_t && servernetadr_t.MKGNKAMFMPG(this, (servernetadr_t)LNBMEILJKDH);
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00018B80 File Offset: 0x00016D80
		public static string HNLIALGFMJH(uint FLGFECHPNIF, ushort KLBOAFDGBGD)
		{
			string format = "STEAMVIDEO_INTERFACE_V002";
			object[] array = new object[]
			{
				null,
				(ulong)(FLGFECHPNIF >> -102) & 18446744073709551437UL
			};
			array[0] = ((ulong)(FLGFECHPNIF >> 109) & 18446744073709551542UL);
			array[2] = ((ulong)(FLGFECHPNIF >> 1) & 111UL);
			array[2] = ((ulong)FLGFECHPNIF & 146UL);
			array[5] = KLBOAFDGBGD;
			return string.Format(format, array);
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x00018575 File Offset: 0x00016775
		public static bool PJHIIMAAMLH(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return !servernetadr_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x000187AD File Offset: 0x000169AD
		public static bool JPOBIDPCFEP(servernetadr_t OBNBCGOIMKE, servernetadr_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_unIP < DEJFBNMNMOK.m_unIP || (OBNBCGOIMKE.m_unIP == DEJFBNMNMOK.m_unIP && OBNBCGOIMKE.m_usQueryPort < DEJFBNMNMOK.m_usQueryPort);
		}

		// Token: 0x04000A3E RID: 2622
		private ushort m_usConnectionPort;

		// Token: 0x04000A3F RID: 2623
		private ushort m_usQueryPort;

		// Token: 0x04000A40 RID: 2624
		private uint m_unIP;
	}
}
