using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Steamworks
{
	// Token: 0x02000037 RID: 55
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 372)]
	public class gameserveritem_t
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x00004836 File Offset: 0x00002A36
		public void MIEKEONDBMN(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "{0}.{1}.{2}.{3}:{4}");
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00004853 File Offset: 0x00002A53
		public void BOCAECFPHME(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "SteamMatchMaking009");
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00004870 File Offset: 0x00002A70
		public void FKPFIIBMNGN(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "SteamNetworkingSockets012");
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000488D File Offset: 0x00002A8D
		public string JCIHKGDAMKL()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 1, Array.IndexOf<byte>(this.m_szGameTags, 1));
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000048AC File Offset: 0x00002AAC
		public void MMDIEHKHPEK(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "\0");
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000048C9 File Offset: 0x00002AC9
		public string BIKMMBPABNI()
		{
			return Encoding.UTF8.GetString(this.m_szGameDescription, 1, Array.IndexOf<byte>(this.m_szGameDescription, 1));
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000048C9 File Offset: 0x00002AC9
		public string GGCHINFJEGB()
		{
			return Encoding.UTF8.GetString(this.m_szGameDescription, 1, Array.IndexOf<byte>(this.m_szGameDescription, 1));
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000048E8 File Offset: 0x00002AE8
		public string BFCFPMIKGNJ()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 1, Array.IndexOf<byte>(this.m_szGameTags, 0));
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00004907 File Offset: 0x00002B07
		public void POBGLCOCBCF(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "STEAMPARENTALSETTINGS_INTERFACE_VERSION001");
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000488D File Offset: 0x00002A8D
		public string DHJEILFGDPB()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 1, Array.IndexOf<byte>(this.m_szGameTags, 1));
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00004924 File Offset: 0x00002B24
		public void OPGHECHHIJB(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "pBasePrices must be the same size as unArrayLength!");
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00004870 File Offset: 0x00002A70
		public void LBEFGJDFGOD(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "SteamNetworkingSockets012");
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000488D File Offset: 0x00002A8D
		public string MGPCMBGJIPD()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 1, Array.IndexOf<byte>(this.m_szGameTags, 1));
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00004941 File Offset: 0x00002B41
		public string FLCKGHMIKHF()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 0, Array.IndexOf<byte>(this.m_szGameTags, 0));
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00004960 File Offset: 0x00002B60
		public string OBCKOPBELHO()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 0, Array.IndexOf<byte>(this.m_szGameDir, 0));
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000497F File Offset: 0x00002B7F
		public string EMEBKMKDLHD()
		{
			return Encoding.UTF8.GetString(this.m_szMap, 0, Array.IndexOf<byte>(this.m_szMap, 0));
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000499E File Offset: 0x00002B9E
		public void GCIANILEAMC(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "pBasePrices must be the same size as unArrayLength!");
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000049BB File Offset: 0x00002BBB
		public void HFFADPMAJJG(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "\0");
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000049D8 File Offset: 0x00002BD8
		public void GOPGECJHMJE(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "pItemDefIDs must be the same size as punItemDefIDsArraySize!");
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000049F5 File Offset: 0x00002BF5
		public string JLEIJBLGCKH()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 0, Array.IndexOf<byte>(this.m_szGameDir, 1));
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000497F File Offset: 0x00002B7F
		public string CILOCAEMBHI()
		{
			return Encoding.UTF8.GetString(this.m_szMap, 0, Array.IndexOf<byte>(this.m_szMap, 0));
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00004A14 File Offset: 0x00002C14
		public void MCOCAPDJJKO(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "\0");
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00004A31 File Offset: 0x00002C31
		public void KCALKLLIDGP(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "SteamFriends017");
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00004A4E File Offset: 0x00002C4E
		public string BEICGKGFKCF()
		{
			return Encoding.UTF8.GetString(this.m_szMap, 0, Array.IndexOf<byte>(this.m_szMap, 1));
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000488D File Offset: 0x00002A8D
		public string HNNMMJDFOGP()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 1, Array.IndexOf<byte>(this.m_szGameTags, 1));
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00004A6D File Offset: 0x00002C6D
		public void PKIEDJKLIDH(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "STEAMINVENTORY_INTERFACE_V003");
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00004A8A File Offset: 0x00002C8A
		public void FPJLDMAIOEA(string FOEFCKGEPJA)
		{
			this.m_szMap = Encoding.UTF8.GetBytes(FOEFCKGEPJA + "handlesOut must be the same size as Constants.STEAM_INPUT_MAX_COUNT!");
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00004A8A File Offset: 0x00002C8A
		public void MLEOJIOIKOB(string FOEFCKGEPJA)
		{
			this.m_szMap = Encoding.UTF8.GetBytes(FOEFCKGEPJA + "handlesOut must be the same size as Constants.STEAM_INPUT_MAX_COUNT!");
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00004AA7 File Offset: 0x00002CA7
		public string JAANJHADMMK()
		{
			return Encoding.UTF8.GetString(this.m_szGameDescription, 0, Array.IndexOf<byte>(this.m_szGameDescription, 0));
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000488D File Offset: 0x00002A8D
		public string OMKNLPNBFHK()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 1, Array.IndexOf<byte>(this.m_szGameTags, 1));
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00004AC6 File Offset: 0x00002CC6
		public void FMOJBJIKCDF(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "STEAMREMOTEPLAY_INTERFACE_VERSION001");
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000049BB File Offset: 0x00002BBB
		public void HADFMCIHHAN(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "\0");
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00004AE3 File Offset: 0x00002CE3
		public string ADBFJFNBFHO()
		{
			if (this.m_szServerName[0] == 0)
			{
				return this.m_NetAdr.PJEFGJPAIKH();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 0, Array.IndexOf<byte>(this.m_szServerName, 1));
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00004B18 File Offset: 0x00002D18
		public void CNNBMODCHBD(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "STEAMUGC_INTERFACE_VERSION016");
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00004B35 File Offset: 0x00002D35
		public void AKCIBAKEAMM(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "STEAMMUSIC_INTERFACE_VERSION001");
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00004B52 File Offset: 0x00002D52
		public string LAIPIFKCHIA()
		{
			if (this.m_szServerName[1] == 0)
			{
				return this.m_NetAdr.DFPFIOFNNGJ();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 0, Array.IndexOf<byte>(this.m_szServerName, 1));
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000049D8 File Offset: 0x00002BD8
		public void LPCKKOPBBPF(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "pItemDefIDs must be the same size as punItemDefIDsArraySize!");
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00004B87 File Offset: 0x00002D87
		public string MHACKPDINML()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 1, Array.IndexOf<byte>(this.m_szGameDir, 0));
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00004BA6 File Offset: 0x00002DA6
		public void BLACFAFPOME(string FOEFCKGEPJA)
		{
			this.m_szMap = Encoding.UTF8.GetBytes(FOEFCKGEPJA + "STEAMREMOTEPLAY_INTERFACE_VERSION001");
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00004BC3 File Offset: 0x00002DC3
		public string KIFEFFDDOOL()
		{
			if (this.m_szServerName[1] == 0)
			{
				return this.m_NetAdr.CKLGFFPLKIE();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 1, Array.IndexOf<byte>(this.m_szServerName, 1));
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00004941 File Offset: 0x00002B41
		public string OONLCCCBKMB()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 0, Array.IndexOf<byte>(this.m_szGameTags, 0));
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00004C00 File Offset: 0x00002E00
		public string FMLBOFLGFEB()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 1, Array.IndexOf<byte>(this.m_szGameDir, 1));
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00004C1F File Offset: 0x00002E1F
		public void EGPBCCGKCIC(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "SteamMatchMaking009");
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00004C3C File Offset: 0x00002E3C
		public void IHEICJFACHC(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "STEAMHTMLSURFACE_INTERFACE_VERSION_005");
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00004C59 File Offset: 0x00002E59
		public string HBHAJBPEBBH()
		{
			if (this.m_szServerName[0] == 0)
			{
				return this.m_NetAdr.GCLFCFHODDK();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 0, Array.IndexOf<byte>(this.m_szServerName, 1));
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000497F File Offset: 0x00002B7F
		public string MMPKHMALLHG()
		{
			return Encoding.UTF8.GetString(this.m_szMap, 0, Array.IndexOf<byte>(this.m_szMap, 0));
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000048C9 File Offset: 0x00002AC9
		public string NMFFPCGIBLM()
		{
			return Encoding.UTF8.GetString(this.m_szGameDescription, 1, Array.IndexOf<byte>(this.m_szGameDescription, 1));
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00004C8E File Offset: 0x00002E8E
		public void AAOJGBNHPNN(string FOEFCKGEPJA)
		{
			this.m_szMap = Encoding.UTF8.GetBytes(FOEFCKGEPJA + "\0");
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00004CAB File Offset: 0x00002EAB
		public void PKHOLCKONDM(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "SteamNetworkingUtils004");
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000497F File Offset: 0x00002B7F
		public string FILEFKKOIFK()
		{
			return Encoding.UTF8.GetString(this.m_szMap, 0, Array.IndexOf<byte>(this.m_szMap, 0));
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00004CC8 File Offset: 0x00002EC8
		public void HKCLOCDAALO(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "STEAMVIDEO_INTERFACE_V002");
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00004CE5 File Offset: 0x00002EE5
		public void PJHGLHGMPHG(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "SteamNetworking006");
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000048C9 File Offset: 0x00002AC9
		public string DJPAFMPFFEE()
		{
			return Encoding.UTF8.GetString(this.m_szGameDescription, 1, Array.IndexOf<byte>(this.m_szGameDescription, 1));
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00004D02 File Offset: 0x00002F02
		public void IMDGFGDKGPG(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "SteamClient020");
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00004D1F File Offset: 0x00002F1F
		public string MECJEKJFBBK()
		{
			if (this.m_szServerName[0] == 0)
			{
				return this.m_NetAdr.NDOKMIHIFKM();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 0, Array.IndexOf<byte>(this.m_szServerName, 0));
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00004D54 File Offset: 0x00002F54
		public string MFDPLCIGKJM()
		{
			return Encoding.UTF8.GetString(this.m_szMap, 1, Array.IndexOf<byte>(this.m_szMap, 1));
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00004B87 File Offset: 0x00002D87
		public string GGAFMKOOMPC()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 1, Array.IndexOf<byte>(this.m_szGameDir, 0));
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00004D73 File Offset: 0x00002F73
		public string DFMBNPIGCHN()
		{
			if (this.m_szServerName[0] == 0)
			{
				return this.m_NetAdr.CKLGFFPLKIE();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 0, Array.IndexOf<byte>(this.m_szServerName, 0));
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00004DA8 File Offset: 0x00002FA8
		public void BOIMMLCKEAC(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "pOutItemsArray must be the same size as punOutItemsArraySize!");
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00004DC5 File Offset: 0x00002FC5
		public void IAHCILJHOKJ(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "STEAMHTMLSURFACE_INTERFACE_VERSION_005");
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000488D File Offset: 0x00002A8D
		public string HNMGINKPPIG()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 1, Array.IndexOf<byte>(this.m_szGameTags, 1));
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00004DE2 File Offset: 0x00002FE2
		public void KIBMFHNDEIE(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "STEAMINVENTORY_INTERFACE_V003");
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00004DFF File Offset: 0x00002FFF
		public void PINGPLGBIKA(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "Callback function must not be null.");
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00004E1C File Offset: 0x0000301C
		public void FHDPIJHFJHP(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "SteamFriends017");
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00004E39 File Offset: 0x00003039
		public void KFBEILCEDKE(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "Steamworks GameServer is not initialized.");
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00004E56 File Offset: 0x00003056
		public void LFMIDPEAMBN(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "SteamUtils010");
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00004E73 File Offset: 0x00003073
		public string BIEGJAACJGE()
		{
			return Encoding.UTF8.GetString(this.m_szGameDescription, 1, Array.IndexOf<byte>(this.m_szGameDescription, 0));
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00004960 File Offset: 0x00002B60
		public string PIKADHKPPOL()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 0, Array.IndexOf<byte>(this.m_szGameDir, 0));
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00004BA6 File Offset: 0x00002DA6
		public void NIIKIGBHMDF(string FOEFCKGEPJA)
		{
			this.m_szMap = Encoding.UTF8.GetBytes(FOEFCKGEPJA + "STEAMREMOTEPLAY_INTERFACE_VERSION001");
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00004E92 File Offset: 0x00003092
		public string NHLPDEMAFAM()
		{
			if (this.m_szServerName[0] == 0)
			{
				return this.m_NetAdr.NDOKMIHIFKM();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 0, Array.IndexOf<byte>(this.m_szServerName, 1));
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000488D File Offset: 0x00002A8D
		public string NINOFDGCAGL()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 1, Array.IndexOf<byte>(this.m_szGameTags, 1));
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00004960 File Offset: 0x00002B60
		public string FBIFMGNIPBE()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 0, Array.IndexOf<byte>(this.m_szGameDir, 0));
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00004EC7 File Offset: 0x000030C7
		public void PDMPAGMDJPH(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "SteamFriends017");
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00004EE4 File Offset: 0x000030E4
		public void OAMIGGOBMCL(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "pCurrentPrices must be the same size as unArrayLength!");
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00004941 File Offset: 0x00002B41
		public string ODEGHDCPDGI()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 0, Array.IndexOf<byte>(this.m_szGameTags, 0));
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00004F01 File Offset: 0x00003101
		public void MBMCCDJBLDL(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "\0");
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00004F1E File Offset: 0x0000311E
		public void NNPEJPKLIIM(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "handlesOut must be the same size as Constants.STEAM_INPUT_MAX_COUNT!");
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000048E8 File Offset: 0x00002AE8
		public string LADABKBIPNK()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 1, Array.IndexOf<byte>(this.m_szGameTags, 0));
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00004E73 File Offset: 0x00003073
		public string JGCBIEDGNLB()
		{
			return Encoding.UTF8.GetString(this.m_szGameDescription, 1, Array.IndexOf<byte>(this.m_szGameDescription, 0));
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00004F3B File Offset: 0x0000313B
		public void MALKOJAFNCP(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "pBasePrices must be the same size as unArrayLength!");
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00004AA7 File Offset: 0x00002CA7
		public string DPGLELAHOJD()
		{
			return Encoding.UTF8.GetString(this.m_szGameDescription, 0, Array.IndexOf<byte>(this.m_szGameDescription, 0));
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000048E8 File Offset: 0x00002AE8
		public string IGHBIGKAAEA()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 1, Array.IndexOf<byte>(this.m_szGameTags, 0));
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00004924 File Offset: 0x00002B24
		public void ONMFOGGEJAK(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "pBasePrices must be the same size as unArrayLength!");
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00004F58 File Offset: 0x00003158
		public void JGHLIGKLCOH(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "SteamNetworkingUtils004");
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00004F75 File Offset: 0x00003175
		public string GKGCLBIDCDA()
		{
			if (this.m_szServerName[1] == 0)
			{
				return this.m_NetAdr.PJEFGJPAIKH();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 1, Array.IndexOf<byte>(this.m_szServerName, 0));
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00004FAA File Offset: 0x000031AA
		public string KELJDBGOGJG()
		{
			return Encoding.UTF8.GetString(this.m_szMap, 1, Array.IndexOf<byte>(this.m_szMap, 0));
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00004FC9 File Offset: 0x000031C9
		public void MHODOJJJPGI(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "Callback number not found for struct ");
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00004FE6 File Offset: 0x000031E6
		public void JIENDMLJJPJ(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "{0}.{1}.{2}.{3}:{4}");
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000048E8 File Offset: 0x00002AE8
		public string MPLJINNMAIM()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 1, Array.IndexOf<byte>(this.m_szGameTags, 0));
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00005003 File Offset: 0x00003203
		public void CHFLAGCOMLH(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "STEAMINVENTORY_INTERFACE_V003");
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00004B87 File Offset: 0x00002D87
		public string BCIKPEIJIIA()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 1, Array.IndexOf<byte>(this.m_szGameDir, 0));
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00005020 File Offset: 0x00003220
		public string PHLCMLFHCGB()
		{
			if (this.m_szServerName[1] == 0)
			{
				return this.m_NetAdr.JCOHONGHMNM();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 0, Array.IndexOf<byte>(this.m_szServerName, 1));
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00005055 File Offset: 0x00003255
		public string IBDGHCADKOE()
		{
			if (this.m_szServerName[1] == 0)
			{
				return this.m_NetAdr.GCLFCFHODDK();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 0, Array.IndexOf<byte>(this.m_szServerName, 0));
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000508A File Offset: 0x0000328A
		public void DHBDKDPHMCJ(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "SteamNetworking006");
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00004960 File Offset: 0x00002B60
		public string ENPPLCPEFPE()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 0, Array.IndexOf<byte>(this.m_szGameDir, 0));
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000497F File Offset: 0x00002B7F
		public string NNOHEEDEDIN()
		{
			return Encoding.UTF8.GetString(this.m_szMap, 0, Array.IndexOf<byte>(this.m_szMap, 0));
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00004D54 File Offset: 0x00002F54
		public string BGCMBNDNPOF()
		{
			return Encoding.UTF8.GetString(this.m_szMap, 1, Array.IndexOf<byte>(this.m_szMap, 1));
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000050A7 File Offset: 0x000032A7
		public void GKFOLBNJLIP(string FOEFCKGEPJA)
		{
			this.m_szMap = Encoding.UTF8.GetBytes(FOEFCKGEPJA + "Steamworks GameServer is not initialized.");
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000050C4 File Offset: 0x000032C4
		public void HCDJHADCFIO(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "pArrayItemDefs must be the same size as unArrayLength!");
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000050E1 File Offset: 0x000032E1
		public void IKHHOCIKONH(string FOEFCKGEPJA)
		{
			this.m_szMap = Encoding.UTF8.GetBytes(FOEFCKGEPJA + "SteamUtils010");
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00004D54 File Offset: 0x00002F54
		public string PMIIKALKHFD()
		{
			return Encoding.UTF8.GetString(this.m_szMap, 1, Array.IndexOf<byte>(this.m_szMap, 1));
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000050FE File Offset: 0x000032FE
		public void KJBDNLGDFPE(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "STEAMVIDEO_INTERFACE_V002");
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000049BB File Offset: 0x00002BBB
		public void IODOCOPFPCH(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "\0");
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00004941 File Offset: 0x00002B41
		public string NJEDDJGNGOG()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 0, Array.IndexOf<byte>(this.m_szGameTags, 0));
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00004960 File Offset: 0x00002B60
		public string JMJIEEGLGNB()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 0, Array.IndexOf<byte>(this.m_szGameDir, 0));
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000049BB File Offset: 0x00002BBB
		public void NCPOPKIGBCC(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "\0");
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000511B File Offset: 0x0000331B
		public void CNLMFDHMJAA(string FOEFCKGEPJA)
		{
			this.m_szMap = Encoding.UTF8.GetBytes(FOEFCKGEPJA + "STEAMUGC_INTERFACE_VERSION016");
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00005138 File Offset: 0x00003338
		public string CFPIMOKHONO()
		{
			if (this.m_szServerName[0] == 0)
			{
				return this.m_NetAdr.JCOHONGHMNM();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 0, Array.IndexOf<byte>(this.m_szServerName, 0));
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000516D File Offset: 0x0000336D
		public void FAAEOPCEPMK(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "pOutItemsArray must be the same size as punOutItemsArraySize!");
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000518A File Offset: 0x0000338A
		public void DNBLOLGAKGI(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "pItemDefIDs must be the same size as punItemDefIDsArraySize!");
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00004E56 File Offset: 0x00003056
		public void MMOOIKLFOKL(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "SteamUtils010");
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00004D54 File Offset: 0x00002F54
		public string EJPHACCEOAM()
		{
			return Encoding.UTF8.GetString(this.m_szMap, 1, Array.IndexOf<byte>(this.m_szMap, 1));
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000051A7 File Offset: 0x000033A7
		public void IBMHCLIGBBK(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "handlesOut must be the same size as Constants.STEAM_INPUT_MAX_COUNT!");
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00005003 File Offset: 0x00003203
		public void CLIBMOCINOM(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "STEAMINVENTORY_INTERFACE_V003");
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000051C4 File Offset: 0x000033C4
		public void PPEPCANEOHN(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "SteamUtils010");
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000051E1 File Offset: 0x000033E1
		public string ANLAMCFKNOA()
		{
			if (this.m_szServerName[1] == 0)
			{
				return this.m_NetAdr.PJEFGJPAIKH();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 0, Array.IndexOf<byte>(this.m_szServerName, 1));
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00005216 File Offset: 0x00003416
		public void IJIKFHEGNDD(string FOEFCKGEPJA)
		{
			this.m_szMap = Encoding.UTF8.GetBytes(FOEFCKGEPJA + "SteamGameServer014");
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000049F5 File Offset: 0x00002BF5
		public string AADBBIFGEFI()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 0, Array.IndexOf<byte>(this.m_szGameDir, 1));
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00004960 File Offset: 0x00002B60
		public string LJGHHECPKOG()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 0, Array.IndexOf<byte>(this.m_szGameDir, 0));
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00004960 File Offset: 0x00002B60
		public string PCIJKLGKMIP()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 0, Array.IndexOf<byte>(this.m_szGameDir, 0));
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00005233 File Offset: 0x00003433
		public string JFBINPMAJBL()
		{
			if (this.m_szServerName[0] == 0)
			{
				return this.m_NetAdr.MLFJMPNGIIB();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 0, Array.IndexOf<byte>(this.m_szServerName, 0));
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00004A4E File Offset: 0x00002C4E
		public string NHBPALIDPEL()
		{
			return Encoding.UTF8.GetString(this.m_szMap, 0, Array.IndexOf<byte>(this.m_szMap, 1));
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000048E8 File Offset: 0x00002AE8
		public string EAEIKEIHANF()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 1, Array.IndexOf<byte>(this.m_szGameTags, 0));
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00005268 File Offset: 0x00003468
		public void FBGMPOBFMKL(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "STEAMPARENTALSETTINGS_INTERFACE_VERSION001");
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000049D8 File Offset: 0x00002BD8
		public void MJJJDMKHKLC(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "pItemDefIDs must be the same size as punItemDefIDsArraySize!");
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000516D File Offset: 0x0000336D
		public void CAIIJNCJMAK(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "pOutItemsArray must be the same size as punOutItemsArraySize!");
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00004B87 File Offset: 0x00002D87
		public string BJODPOILPFL()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 1, Array.IndexOf<byte>(this.m_szGameDir, 0));
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00004E73 File Offset: 0x00003073
		public string HOGMHDMHOPJ()
		{
			return Encoding.UTF8.GetString(this.m_szGameDescription, 1, Array.IndexOf<byte>(this.m_szGameDescription, 0));
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00005285 File Offset: 0x00003485
		public string ECPFCGHBBCF()
		{
			if (this.m_szServerName[0] == 0)
			{
				return this.m_NetAdr.CKLGFFPLKIE();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 1, Array.IndexOf<byte>(this.m_szServerName, 0));
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00005055 File Offset: 0x00003255
		public string BCMODDCLMNG()
		{
			if (this.m_szServerName[1] == 0)
			{
				return this.m_NetAdr.GCLFCFHODDK();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 0, Array.IndexOf<byte>(this.m_szServerName, 0));
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000052BA File Offset: 0x000034BA
		public string LEOLAJNDPPH()
		{
			return Encoding.UTF8.GetString(this.m_szGameDescription, 0, Array.IndexOf<byte>(this.m_szGameDescription, 1));
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000052D9 File Offset: 0x000034D9
		public void LLPHGLEOBPO(string APMIAIEKIHD)
		{
			this.m_szGameDescription = Encoding.UTF8.GetBytes(APMIAIEKIHD + "SteamClient020");
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00004AA7 File Offset: 0x00002CA7
		public string LPOLJKIMGGB()
		{
			return Encoding.UTF8.GetString(this.m_szGameDescription, 0, Array.IndexOf<byte>(this.m_szGameDescription, 0));
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000049F5 File Offset: 0x00002BF5
		public string LNOOCKCEGEI()
		{
			return Encoding.UTF8.GetString(this.m_szGameDir, 0, Array.IndexOf<byte>(this.m_szGameDir, 1));
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00004907 File Offset: 0x00002B07
		public void PCKPOGKBPLF(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "STEAMPARENTALSETTINGS_INTERFACE_VERSION001");
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00004E73 File Offset: 0x00003073
		public string NIADKGJKDLO()
		{
			return Encoding.UTF8.GetString(this.m_szGameDescription, 1, Array.IndexOf<byte>(this.m_szGameDescription, 0));
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00004941 File Offset: 0x00002B41
		public string FAPCLLAFPLP()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 0, Array.IndexOf<byte>(this.m_szGameTags, 0));
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000052F6 File Offset: 0x000034F6
		public string HKLODLIFFMP()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 0, Array.IndexOf<byte>(this.m_szGameTags, 1));
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000052F6 File Offset: 0x000034F6
		public string MFNFNEGIOHH()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 0, Array.IndexOf<byte>(this.m_szGameTags, 1));
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00004D1F File Offset: 0x00002F1F
		public string KKMCLNNPDGN()
		{
			if (this.m_szServerName[0] == 0)
			{
				return this.m_NetAdr.NDOKMIHIFKM();
			}
			return Encoding.UTF8.GetString(this.m_szServerName, 0, Array.IndexOf<byte>(this.m_szServerName, 0));
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000052F6 File Offset: 0x000034F6
		public string GBBEDMADOCE()
		{
			return Encoding.UTF8.GetString(this.m_szGameTags, 0, Array.IndexOf<byte>(this.m_szGameTags, 1));
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00004F01 File Offset: 0x00003101
		public void MDMAEKBCFCL(string GMOFJDAKAEM)
		{
			this.m_szGameTags = Encoding.UTF8.GetBytes(GMOFJDAKAEM + "\0");
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00005315 File Offset: 0x00003515
		public void AMDPKEEMDJO(string FOEFCKGEPJA)
		{
			this.m_szMap = Encoding.UTF8.GetBytes(FOEFCKGEPJA + "SteamNetworking006");
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00005332 File Offset: 0x00003532
		public void ANCNKCJPLLE(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "SteamUser021");
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000518A File Offset: 0x0000338A
		public void PMKCGCOCCFI(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "pItemDefIDs must be the same size as punItemDefIDsArraySize!");
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000534F File Offset: 0x0000354F
		public void KJDDJGLEAFD(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "STEAMUGC_INTERFACE_VERSION016");
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000536C File Offset: 0x0000356C
		public void PNBGJOOOJDK(string ODGNIFJGEHL)
		{
			this.m_szServerName = Encoding.UTF8.GetBytes(ODGNIFJGEHL + "Callback function must not be null.");
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00005389 File Offset: 0x00003589
		public void PCKPIGOOEFF(string BMDNNFBJCNJ)
		{
			this.m_szGameDir = Encoding.UTF8.GetBytes(BMDNNFBJCNJ + "pItemDefIDs must be the same size as punItemDefIDsArraySize!");
		}

		// Token: 0x04000209 RID: 521
		public servernetadr_t m_NetAdr;

		// Token: 0x0400020A RID: 522
		public int m_nPing;

		// Token: 0x0400020B RID: 523
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bHadSuccessfulResponse;

		// Token: 0x0400020C RID: 524
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bDoNotRefresh;

		// Token: 0x0400020D RID: 525
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		private byte[] m_szGameDir;

		// Token: 0x0400020E RID: 526
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		private byte[] m_szMap;

		// Token: 0x0400020F RID: 527
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private byte[] m_szGameDescription;

		// Token: 0x04000210 RID: 528
		public uint m_nAppID;

		// Token: 0x04000211 RID: 529
		public int m_nPlayers;

		// Token: 0x04000212 RID: 530
		public int m_nMaxPlayers;

		// Token: 0x04000213 RID: 531
		public int m_nBotPlayers;

		// Token: 0x04000214 RID: 532
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bPassword;

		// Token: 0x04000215 RID: 533
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSecure;

		// Token: 0x04000216 RID: 534
		public uint m_ulTimeLastPlayed;

		// Token: 0x04000217 RID: 535
		public int m_nServerVersion;

		// Token: 0x04000218 RID: 536
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private byte[] m_szServerName;

		// Token: 0x04000219 RID: 537
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		private byte[] m_szGameTags;

		// Token: 0x0400021A RID: 538
		public CSteamID m_steamID;
	}
}
