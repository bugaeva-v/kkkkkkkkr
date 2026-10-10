using System;

namespace Steamworks
{
	// Token: 0x0200004A RID: 74
	[Serializable]
	public struct HSteamListenSocket : IEquatable<HSteamListenSocket>, IComparable<HSteamListenSocket>
	{
		// Token: 0x0600053F RID: 1343 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint DBFCFFCHFLB(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000586A File Offset: 0x00003A6A
		public override int GetHashCode()
		{
			return this.m_HSteamListenSocket.GetHashCode();
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool ODGOMOKAIBF(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket JAMBFIOAJNM(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0000588F File Offset: 0x00003A8F
		public int MEDKBMJEJEK(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00005877 File Offset: 0x00003A77
		public bool Equals(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0000588F File Offset: 0x00003A8F
		public int FDKFGNPDNPO(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint KMKPAEHLFGD(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x000058A2 File Offset: 0x00003AA2
		public static bool DBGIJLPDJMN(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000058AE File Offset: 0x00003AAE
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is HSteamListenSocket && HSteamListenSocket.MKGNKAMFMPG(this, (HSteamListenSocket)LNBMEILJKDH);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint NBKEGKHGGOH(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000058CB File Offset: 0x00003ACB
		public static bool IOAHIBPNMPP(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.FAMAMLIGBHA(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00005877 File Offset: 0x00003A77
		public bool EMNFLNOILHJ(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000058D7 File Offset: 0x00003AD7
		public static bool OODKONKMCBA(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.JHDBIABDGLI(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool CBMMJFPJEMP(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00005877 File Offset: 0x00003A77
		public bool JDDFHOOKAJM(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000058E3 File Offset: 0x00003AE3
		public static bool DFBOPLBLCLI(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.ANMCAPADKNB(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000058EF File Offset: 0x00003AEF
		public static bool JFPFILAOJMM(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.BPIJFACBBJF(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool EMFHKHOHCHK(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket BDDFEOKMDML(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint LDPFIFCFHIE(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint KDPKCGOAAPD(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000588F File Offset: 0x00003A8F
		public int ACHPBGOCABB(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool AIGHJIOMBMA(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00005877 File Offset: 0x00003A77
		public bool CBJMMJCBDGN(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00005877 File Offset: 0x00003A77
		public bool DPKAIFGJNOM(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket DJDKDNCPEIO(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000588F File Offset: 0x00003A8F
		public int PDKEBBKCEBJ(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool AKABDJCLIAP(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint HEGMONHPLPF(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket EOPHKNPBLNC(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket IGAJFACIMAH(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00005908 File Offset: 0x00003B08
		public static bool JMHHFGOGLBL(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return HSteamListenSocket.ICHPJJCEOGJ(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint APHBNOFJKHH(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket CJJJDNMOIIN(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00005914 File Offset: 0x00003B14
		public HSteamListenSocket(uint AJLPALFJHCC)
		{
			this.m_HSteamListenSocket = AJLPALFJHCC;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00005877 File Offset: 0x00003A77
		public bool IKBKHIFDGKK(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket CBMHIJAIMFN(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00005877 File Offset: 0x00003A77
		public bool EPBJEKJAJAM(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket CJBLMHBFKIL(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0000591D File Offset: 0x00003B1D
		public static bool OLLJJHFPAJP(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return HSteamListenSocket.AIGHJIOMBMA(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00005929 File Offset: 0x00003B29
		public static bool ICJDJJABLCH(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.CDNPFFJOFOM(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint MOIADICFIOP(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0000588F File Offset: 0x00003A8F
		public int FPLPEMNKGOK(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00005935 File Offset: 0x00003B35
		public static bool BDNKDLDIADM(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.COFGAMEDKMK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket PKFMPNHDENA(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00005877 File Offset: 0x00003A77
		public bool OCOEJHFHGLJ(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0000588F File Offset: 0x00003A8F
		public int CompareTo(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint PEAFCMBIENC(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00005941 File Offset: 0x00003B41
		public static bool DEIKAOMHGEC(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.AKAEDFOCJGG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0000588F File Offset: 0x00003A8F
		public int JCFNKNEOMEN(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0000588F File Offset: 0x00003A8F
		public int POKMMKCKGPO(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00005877 File Offset: 0x00003A77
		public bool BADPMBMDPIP(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00005877 File Offset: 0x00003A77
		public bool NEMCANGLGHM(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0000594D File Offset: 0x00003B4D
		public static bool ILNGPECJMGD(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.AKABDJCLIAP(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00005959 File Offset: 0x00003B59
		public static bool ODJOPEBBIME(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return HSteamListenSocket.FMMPLDOGJKC(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00005965 File Offset: 0x00003B65
		public static bool MJILGIMAPCM(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return HSteamListenSocket.AKAEDFOCJGG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool COFGAMEDKMK(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0000588F File Offset: 0x00003A8F
		public int DMHAPKJNPGH(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket HLNFKNJGCDL(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00005971 File Offset: 0x00003B71
		public static bool OPFKIHFEGFN(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return HSteamListenSocket.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00005877 File Offset: 0x00003A77
		public bool NNNJNIOCEPA(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0000588F File Offset: 0x00003A8F
		public int PILNKLAHNIM(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00005877 File Offset: 0x00003A77
		public bool BECNDLCCJPK(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000588F File Offset: 0x00003A8F
		public int OJJHPBHGDDM(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00005877 File Offset: 0x00003A77
		public bool OKBLEMBMHGB(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000597D File Offset: 0x00003B7D
		public static bool DCNEOCGBIFL(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return HSteamListenSocket.EMFHKHOHCHK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000588F File Offset: 0x00003A8F
		public int OLLLNIOKCDC(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool IKBEOPIFAFP(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00005929 File Offset: 0x00003B29
		public static bool BBLAEPJHKEE(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.CDNPFFJOFOM(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool ANMCAPADKNB(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0000588F File Offset: 0x00003A8F
		public int MBDCDIAPPKN(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00005877 File Offset: 0x00003A77
		public bool OAKKABIOMPN(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00005877 File Offset: 0x00003A77
		public bool ODLINHPHKIK(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00005989 File Offset: 0x00003B89
		public static bool LDJPKACOFHP(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return HSteamListenSocket.JKKPNIFHJJO(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000588F File Offset: 0x00003A8F
		public int IMNMELOMNLL(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00005877 File Offset: 0x00003A77
		public bool IHMHHKNBKKJ(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket PEAFCMBIENC(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00005877 File Offset: 0x00003A77
		public bool DPNFHEACCEH(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint JJBCKFJBGKE(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint NDKJBBBFHMJ(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0000588F File Offset: 0x00003A8F
		public int LLNKMPPCHEM(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket EMEEPNFJOCC(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00005959 File Offset: 0x00003B59
		public static bool LHHACIKDPOL(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return HSteamListenSocket.FMMPLDOGJKC(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0000588F File Offset: 0x00003A8F
		public int CHAFIKIKKIO(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool BGGAEBOCGJG(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool AKAEDFOCJGG(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool MKGNKAMFMPG(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket KGBGNMNLPKN(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket KOIGMCFBCII(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00005995 File Offset: 0x00003B95
		public override string ToString()
		{
			return this.m_HSteamListenSocket.ToString();
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket MJBDELEJHBJ(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket BCNFICECAMF(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000059A2 File Offset: 0x00003BA2
		public static bool GEDIHMHFNMI(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.AIGHJIOMBMA(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00005877 File Offset: 0x00003A77
		public bool HJMLEBEHMFA(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00005877 File Offset: 0x00003A77
		public bool GANJLFPOEHO(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool AHFPKACACBA(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint BNJHAOICCOF(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool BPIJFACBBJF(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool JHDBIABDGLI(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000058A2 File Offset: 0x00003AA2
		public static bool LJBNKEBHLGE(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket PKJMBHJMNGD(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00005877 File Offset: 0x00003A77
		public bool CLOLKCIAEFE(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint EHINDPIFDCP(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket LKNOJDPCCED(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool FAMAMLIGBHA(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000059AE File Offset: 0x00003BAE
		public static bool PJIMANKBPKE(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return HSteamListenSocket.AKABDJCLIAP(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool JKKPNIFHJJO(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0000588F File Offset: 0x00003A8F
		public int GODFLIMIJAM(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00005877 File Offset: 0x00003A77
		public bool MKIJFNEMLLO(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint OLDLOCJALFC(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00005965 File Offset: 0x00003B65
		public static bool KEDJFKAHBEO(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return HSteamListenSocket.AKAEDFOCJGG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0000588F File Offset: 0x00003A8F
		public int OEEAHJJOGHI(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00005877 File Offset: 0x00003A77
		public bool JADFDGCLPDG(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000059BA File Offset: 0x00003BBA
		public static bool NPEKIIDAPNG(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return HSteamListenSocket.CDNPFFJOFOM(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000059C6 File Offset: 0x00003BC6
		public static bool PGMOPFAIAEH(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.JKKPNIFHJJO(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint FNGKLAHPAOB(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket LHKLDDEFGFE(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00005877 File Offset: 0x00003A77
		public bool LOFCAANOECF(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket POBKLPDBJGK(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00005862 File Offset: 0x00003A62
		public static uint MACEAPLGLIL(HSteamListenSocket MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_HSteamListenSocket;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000588F File Offset: 0x00003A8F
		public int ECHAAFAAPPJ(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0000588F File Offset: 0x00003A8F
		public int CBPPGLNEFED(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool FMMPLDOGJKC(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool NFOOEHJIMCB(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00005877 File Offset: 0x00003A77
		public bool KCAPPOKNPBN(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool EPDABHOJHKA(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00005887 File Offset: 0x00003A87
		public static HSteamListenSocket GADOGIBOENF(uint AJLPALFJHCC)
		{
			return new HSteamListenSocket(AJLPALFJHCC);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00005877 File Offset: 0x00003A77
		public bool NBJIKEJCHCJ(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket == LNBMEILJKDH.m_HSteamListenSocket;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000588F File Offset: 0x00003A8F
		public int KJBBBHMHNFI(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool CDNPFFJOFOM(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000059D2 File Offset: 0x00003BD2
		public static bool ECLPKLJCBLI(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return HSteamListenSocket.AHFPKACACBA(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00005877 File Offset: 0x00003A77
		public static bool ICHPJJCEOGJ(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_HSteamListenSocket == DEJFBNMNMOK.m_HSteamListenSocket;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000588F File Offset: 0x00003A8F
		public int FJPFHEBNICF(HSteamListenSocket LNBMEILJKDH)
		{
			return this.m_HSteamListenSocket.CompareTo(LNBMEILJKDH.m_HSteamListenSocket);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x000058A2 File Offset: 0x00003AA2
		public static bool NEFGNGBGAJI(HSteamListenSocket OBNBCGOIMKE, HSteamListenSocket DEJFBNMNMOK)
		{
			return !HSteamListenSocket.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x04000294 RID: 660
		public static readonly HSteamListenSocket Invalid = new HSteamListenSocket(0U);

		// Token: 0x04000295 RID: 661
		public uint m_HSteamListenSocket;
	}
}
