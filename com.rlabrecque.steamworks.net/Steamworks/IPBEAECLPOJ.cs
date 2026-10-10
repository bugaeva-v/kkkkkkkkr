using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Steamworks
{
	// Token: 0x0200008F RID: 143
	[SuppressUnmanagedCodeSecurity]
	internal static class IPBEAECLPOJ
	{
		// Token: 0x06000A8D RID: 2701
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_UploadLeaderboardScore")]
		public static extern ulong IBJANNEKAHI(IntPtr DNNEHDJMMBE, SteamLeaderboard_t KFLCGDMDANA, BJIFCDIHIHG NKDCKCIOMAP, int KNMEPNKBMGN, [In] [Out] int[] CBNGEADBKJN, int EKCLIMLANJC);

		// Token: 0x06000A8E RID: 2702
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetAppName")]
		public static extern int PHLFICLDAHJ(IntPtr DNNEHDJMMBE, AppId_t MINMIFBPLGA, IntPtr DECMMMNKHKM, int FCNCOPLFPFG);

		// Token: 0x06000A8F RID: 2703
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_Play")]
		public static extern void EJOOGIFMDGC(IntPtr DNNEHDJMMBE);

		// Token: 0x06000A90 RID: 2704
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_IsFakeIP")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DLCHEKGJGEK(ref SteamNetworkingIPAddr DPAHMPHNPMK);

		// Token: 0x06000A91 RID: 2705
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetCoplayFriend")]
		public static extern ulong ODIIPCBBDFG(IntPtr DNNEHDJMMBE, int HPKHCKBPCFD);

		// Token: 0x06000A92 RID: 2706
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetCachedUGCCount")]
		public static extern int MJMAHECKDKE(IntPtr DNNEHDJMMBE);

		// Token: 0x06000A93 RID: 2707
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamUtils")]
		public static extern IntPtr FFGBPKPKLPK(IntPtr DNNEHDJMMBE, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000A94 RID: 2708
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_CreateBrowser")]
		public static extern ulong GIJNELBEDKO(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI CAHOIIMJGIL, MBLFNIBGODG.LJANJDBDBJI KLJOBDIKJDN);

		// Token: 0x06000A95 RID: 2709
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_SetConnectionPollGroup")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HJBOJNBPDNF(IntPtr DNNEHDJMMBE, HSteamNetConnection KLJAKJFEEIC, HSteamNetPollGroup HJBCPEEDMKC);

		// Token: 0x06000A96 RID: 2710
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_TransferItemQuantity")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JOPFFNLPDCN(IntPtr DNNEHDJMMBE, out SteamInventoryResult_t DONIEBGGKMH, SteamItemInstanceID_t AHAOBDNIGIG, uint HPAEDHHMDFM, SteamItemInstanceID_t GIKDPIGCHDD);

		// Token: 0x06000A97 RID: 2711
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnableShuffled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NOAJGJJCMMN(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool OFLAMEMDFGK);

		// Token: 0x06000A98 RID: 2712
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MNCIGLKPCMF(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, uint FOAONLEEBOE);

		// Token: 0x06000A99 RID: 2713
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetNumberOfCurrentPlayers")]
		public static extern ulong CEIILEDAMDJ(IntPtr DNNEHDJMMBE);

		// Token: 0x06000A9A RID: 2714
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_RequestGlobalAchievementPercentages")]
		public static extern ulong EGCFPOGNMJO(IntPtr DNNEHDJMMBE);

		// Token: 0x06000A9B RID: 2715
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetItemPrice")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GLDAOFAMBHE(IntPtr DNNEHDJMMBE, SteamItemDef_t GBBOHNKFKMJ, out ulong CODHMGCCMHE, out ulong ALINFHMILAG);

		// Token: 0x06000A9C RID: 2716
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanOfficerByIndex")]
		public static extern ulong NNKFEOBAKKO(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI, int IOCGJKABLLF);

		// Token: 0x06000A9D RID: 2717
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_StopPlaytimeTrackingForAllItems")]
		public static extern ulong EIMMADIJCHP(IntPtr DNNEHDJMMBE);

		// Token: 0x06000A9E RID: 2718
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_BOverlayNeedsPresent")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HBMCAPHJOAL(IntPtr DNNEHDJMMBE);

		// Token: 0x06000A9F RID: 2719
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_GetPlaybackStatus")]
		public static extern FGFIPOHIMFP IEJGBANHICH(IntPtr DNNEHDJMMBE);

		// Token: 0x06000AA0 RID: 2720
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ManualDispatch_GetAPICallResult")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EPDNFBHCDFE(HSteamPipe CMIMOPGNCKB, SteamAPICall_t MANNBDDGHDG, IntPtr KBIIJJJNAND, int MAHPBKLIIGA, int OCDEGGHNMPK, out bool HFDJMCJKOJO);

		// Token: 0x06000AA1 RID: 2721
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetUserStatInt32")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AONHNMCJHEF(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out int EENCENODOOG);

		// Token: 0x06000AA2 RID: 2722
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetSteamID")]
		public static extern ulong KPEOFLFCICC(ref SteamNetworkingIdentity DPAHMPHNPMK);

		// Token: 0x06000AA3 RID: 2723
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_CreateUnauthenticatedUserConnection")]
		public static extern ulong GPLACGHFABE(IntPtr DNNEHDJMMBE);

		// Token: 0x06000AA4 RID: 2724
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamWriteChunk")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OBGEKLCBNDI(IntPtr DNNEHDJMMBE, UGCFileWriteStreamHandle_t ONPIEANOOAB, byte[] CMKDMIPPNGN, int DNFELHKNIIP);

		// Token: 0x06000AA5 RID: 2725
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SendHTTPRequestAndStreamResponse")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DCMGEKGFINL(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, out SteamAPICall_t JNCOLEIILBD);

		// Token: 0x06000AA6 RID: 2726
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnAdditionalPreviews")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KMPNJGBHGGL(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, [MarshalAs(UnmanagedType.I1)] bool NHFNJMLIPHG);

		// Token: 0x06000AA7 RID: 2727
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetPublishedFileDetails")]
		public static extern ulong DMAPAMGPGGP(IntPtr DNNEHDJMMBE, PublishedFileId_t JPCGPJHIMMP, uint DFLALFABBAA);

		// Token: 0x06000AA8 RID: 2728
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsBehindNAT")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CEFBCDCLLCC(IntPtr DNNEHDJMMBE);

		// Token: 0x06000AA9 RID: 2729
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetSecondsSinceComputerActive")]
		public static extern uint KFEMAMMIHEP(IntPtr DNNEHDJMMBE);

		// Token: 0x06000AAA RID: 2730
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_DownloadLeaderboardEntriesForUsers")]
		public static extern ulong KOBCKOPKBDH(IntPtr DNNEHDJMMBE, SteamLeaderboard_t KFLCGDMDANA, [In] [Out] CSteamID[] CJKIGBIKMLC, int JDEOAOENCFB);

		// Token: 0x06000AAB RID: 2731
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_TriggerVibration")]
		public static extern void MBNPMEHHPNM(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, ushort LMGHFJIJEGD, ushort HJJDNGHCIOC);

		// Token: 0x06000AAC RID: 2732
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetPOPList")]
		public static extern int LNFFMAAENLB(IntPtr DNNEHDJMMBE, out SteamNetworkingPOPID HKOODGACHPK, int ALMCGDNIKNF);

		// Token: 0x06000AAD RID: 2733
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_RequestUserStats")]
		public static extern ulong KGIELOMAMMF(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE);

		// Token: 0x06000AAE RID: 2734
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetQueueEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DKOBLDADHEF(IntPtr DNNEHDJMMBE, int HBNODOOKPKG, int KFLNLPAIBKH, MBLFNIBGODG.LJANJDBDBJI KGKLDKEDBIM);

		// Token: 0x06000AAF RID: 2735
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetRegion")]
		public static extern void KLKKMMIOBGK(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI PBCPEIMEAKM);

		// Token: 0x06000AB0 RID: 2736
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_BSecure")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CNHNPEOHAGM(IntPtr DNNEHDJMMBE);

		// Token: 0x06000AB1 RID: 2737
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_ServerRules")]
		public static extern int IOBKCEJGIDL(IntPtr DNNEHDJMMBE, uint FLGFECHPNIF, ushort KLBOAFDGBGD, IntPtr POEEGAJBLKJ);

		// Token: 0x06000AB2 RID: 2738
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetFavoriteGameCount")]
		public static extern int JFIKPBPAFHB(IntPtr DNNEHDJMMBE);

		// Token: 0x06000AB3 RID: 2739
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseDoubleClick")]
		public static extern void DOOLAFEPKEH(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, LLBDBBLHDJH GIAGILLMLDD);

		// Token: 0x06000AB4 RID: 2740
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamOpen")]
		public static extern ulong NBJOLNFAAFK(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ);

		// Token: 0x06000AB5 RID: 2741
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetDetailedConnectionStatus")]
		public static extern int NDBPBNKNMJB(IntPtr DNNEHDJMMBE, HSteamNetConnection KLJAKJFEEIC, IntPtr LPEFIJAIHCE, int FGHMOMPAOFF);

		// Token: 0x06000AB6 RID: 2742
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardEntryCount")]
		public static extern int ADGGCMEEAPL(IntPtr DNNEHDJMMBE, SteamLeaderboard_t KFLCGDMDANA);

		// Token: 0x06000AB7 RID: 2743
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetCookie")]
		public static extern void GKHJMPBDBDE(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI NPHIHJCNEOB, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE, MBLFNIBGODG.LJANJDBDBJI OIABIHIJPJN, MBLFNIBGODG.LJANJDBDBJI EGKJALKLBJB, uint CNIOGAGPBFE, [MarshalAs(UnmanagedType.I1)] bool LEJAMHICGHI, [MarshalAs(UnmanagedType.I1)] bool MKFMKEMMLNB);

		// Token: 0x06000AB8 RID: 2744
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetIPv4Addr")]
		public static extern void ICFOGIMLABN(ref SteamNetworkingIdentity DPAHMPHNPMK, uint KGLEJGCAGBD, ushort MLHPDILCKGP);

		// Token: 0x06000AB9 RID: 2745
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetRealIdentityForFakeIP")]
		public static extern LNFOAHHPFIH MEHLNIIPCAN(IntPtr DNNEHDJMMBE, ref SteamNetworkingIPAddr GJBAOFDHFDF, out SteamNetworkingIdentity GGFHANHEJDE);

		// Token: 0x06000ABA RID: 2746
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileRead")]
		public static extern int ONHHBCMIJLN(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ, byte[] CMKDMIPPNGN, int DGDHMGAIPEL);

		// Token: 0x06000ABB RID: 2747
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_OpenDeveloperTools")]
		public static extern void BGPIFOMDLKN(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD);

		// Token: 0x06000ABC RID: 2748
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_QueueWillChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BFNKONNPPHM(IntPtr DNNEHDJMMBE);

		// Token: 0x06000ABD RID: 2749
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnablePlayNext")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MFOGJHOGLGB(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool OFLAMEMDFGK);

		// Token: 0x06000ABE RID: 2750
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCStatistic")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HNGHKCPJBBB(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint GGICIBLJIKI, LIMKNJJECAM NANNPGCNJEM, out ulong JMIBBPEDCFI);

		// Token: 0x06000ABF RID: 2751
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_UserHasLicenseForApp")]
		public static extern HCEDMHEOKCK KPOLDDLCGLL(IntPtr DNNEHDJMMBE, CSteamID EKCOJJGHNAN, AppId_t NCFIHMEHIOE);

		// Token: 0x06000AC0 RID: 2752
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_DeactivateAllActionSetLayers")]
		public static extern void KNCNAMNOGBG(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA);

		// Token: 0x06000AC1 RID: 2753
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_IterateGenericEditableConfigValues")]
		public static extern JHEBPHGLLMK KADFEKMEAPA(IntPtr DNNEHDJMMBE, JHEBPHGLLMK FMHPPFAFLCI, [MarshalAs(UnmanagedType.I1)] bool FDEBIMEKPGL);

		// Token: 0x06000AC2 RID: 2754
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementDisplayAttribute")]
		public static extern IntPtr MFINPBFMCLD(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE);

		// Token: 0x06000AC3 RID: 2755
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SendClanChatMessage")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PBFPLFAAIEG(IntPtr DNNEHDJMMBE, CSteamID IEMJIPDDFAF, MBLFNIBGODG.LJANJDBDBJI HGOFKBNCMNK);

		// Token: 0x06000AC4 RID: 2756
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UGCDownloadToLocation")]
		public static extern ulong CILIMNFJGOM(IntPtr DNNEHDJMMBE, UGCHandle_t DNBPDFIIBHN, MBLFNIBGODG.LJANJDBDBJI CDAEAMMFFIC, uint AOMKGBLMINK);

		// Token: 0x06000AC5 RID: 2757
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanActivityCounts")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DAGKLMDPIGF(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI, out int IDCGDMMDOKE, out int DJGAIBOCDNP, out int LFPBOBDLIOF);

		// Token: 0x06000AC6 RID: 2758
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyOwner")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GLBFIAJJEKN(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, CSteamID DKCHHMHDOEO);

		// Token: 0x06000AC7 RID: 2759
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRichPresenceKeyByIndex")]
		public static extern IntPtr HCEPDJIAEDA(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE, int IFLKBIPIDNP);

		// Token: 0x06000AC8 RID: 2760
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_CommitPublishedFileUpdate")]
		public static extern ulong ADMJLEBGGAE(IntPtr DNNEHDJMMBE, PublishedFileUpdateHandle_t OGPKKNDEDFI);

		// Token: 0x06000AC9 RID: 2761
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetAuthenticationStatus")]
		public static extern DNEHHBIPLOF MFPLMPMDIMJ(IntPtr DNNEHDJMMBE, out CPENIBKCDIL NNBNPPJLBJB);

		// Token: 0x06000ACA RID: 2762
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_ReadP2PPacket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IELBJDCPNFJ(IntPtr DNNEHDJMMBE, byte[] LJANICMPHHI, uint KPHGENMNKJO, out uint KNKBMPIDGDN, out CSteamID FPPMAPKPLMA, int KDOGMEOPDJN);

		// Token: 0x06000ACB RID: 2763
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_RunCallbacks")]
		public static extern void JANMGMOKAGL(IntPtr DNNEHDJMMBE);

		// Token: 0x06000ACC RID: 2764
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BIsLicenseBorrowed")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IHHMGNKOPGO([In] [Out] byte[] OJNJHJOIJDG, uint HADHJKAMIBG);

		// Token: 0x06000ACD RID: 2765
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_CloseClanChatWindowInSteam")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PKBJHJNKJJF(IntPtr DNNEHDJMMBE, CSteamID IEMJIPDDFAF);

		// Token: 0x06000ACE RID: 2766
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetUserStatFloat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EOHJHNHCEKL(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out float EENCENODOOG);

		// Token: 0x06000ACF RID: 2767
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_InviteUserToGame")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AHLCHKHLEEJ(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE, MBLFNIBGODG.LJANJDBDBJI KBIODGLGHOJ);

		// Token: 0x06000AD0 RID: 2768
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_UnregisterCallback")]
		public static extern void EBLNAIENMKC(IntPtr KBIIJJJNAND);

		// Token: 0x06000AD1 RID: 2769
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_ClearAllKeyValues")]
		public static extern void JPGBHHLHCJK(IntPtr DNNEHDJMMBE);

		// Token: 0x06000AD2 RID: 2770
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreateListenSocketP2PFakeIP")]
		public static extern uint BPLIHPJEMKB(IntPtr DNNEHDJMMBE, int JCEDFNLIKBO, int HHJMCLMABHG, [In] [Out] SteamNetworkingConfigValue_t[] NKNGPCMOHCH);

		// Token: 0x06000AD3 RID: 2771
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetEnteredGamepadTextInput")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EMIDIPKHOAG(IntPtr DNNEHDJMMBE, IntPtr HGOFKBNCMNK, uint KMFADIJJLAF);

		// Token: 0x06000AD4 RID: 2772
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCoplayGame")]
		public static extern uint GAIHCJCOJGI(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE);

		// Token: 0x06000AD5 RID: 2773
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_UpdateItemPreviewFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KAHGJKEIOGF(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, uint GGICIBLJIKI, MBLFNIBGODG.LJANJDBDBJI ELIICLHPPGH);

		// Token: 0x06000AD6 RID: 2774
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_ResetPlaylistEntries")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool APCJGBNDHMH(IntPtr DNNEHDJMMBE);

		// Token: 0x06000AD7 RID: 2775
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetItemDefinitionIDs")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CPEFPPOCDFK(IntPtr DNNEHDJMMBE, [In] [Out] SteamItemDef_t[] HHJEKGOHNOE, ref uint FKNFFLFFAGF);

		// Token: 0x06000AD8 RID: 2776
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetCurrentPlaylistEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KEKEEMPOFCI(IntPtr DNNEHDJMMBE, int HBNODOOKPKG);

		// Token: 0x06000AD9 RID: 2777
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseHeaderValue")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PAFOFHANFKB(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, MBLFNIBGODG.LJANJDBDBJI LFGHDBMIGJD, byte[] HBLMABEMFIP, uint NJILDPDADEM);

		// Token: 0x06000ADA RID: 2778
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_ParseString")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GFIDGLNDGGK(ref SteamNetworkingIPAddr DPAHMPHNPMK, MBLFNIBGODG.LJANJDBDBJI OBJAIHPGOJN);

		// Token: 0x06000ADB RID: 2779
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_ShowFloatingGamepadTextInput")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CFIPHECDANG(IntPtr DNNEHDJMMBE, KKGOGDCPPEB PLJNEIAKDAL, int NMNDPKMGOOL, int AGAIPBFJIDK, int EGHOCIDJGGJ, int EBJJFHDOBPC);

		// Token: 0x06000ADC RID: 2780
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetWorkshopEULAStatus")]
		public static extern ulong JIGFPDALBKL(IntPtr DNNEHDJMMBE);

		// Token: 0x06000ADD RID: 2781
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetUGCDetails")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MMADLEKPJHO(IntPtr DNNEHDJMMBE, UGCHandle_t DNBPDFIIBHN, out AppId_t MCFPBIONEAH, out IntPtr KGCAFGILOKJ, out int LLOBOAPLNIL, out CSteamID LOIFNMIONFE);

		// Token: 0x06000ADE RID: 2782
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetLocalHost")]
		public static extern void JCBCFMCJOOK(ref SteamNetworkingIdentity DPAHMPHNPMK);

		// Token: 0x06000ADF RID: 2783
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BIsTicketSigned")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GLCIFHEKEMB([In] [Out] byte[] OJNJHJOIJDG, uint HADHJKAMIBG, [In] [Out] byte[] BCFKAODCPLM, uint ICGBFGIFEGB);

		// Token: 0x06000AE0 RID: 2784
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParties_GetAvailableBeaconLocations")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AENNKPCFGGH(IntPtr DNNEHDJMMBE, [In] [Out] LAMANAOFFOF[] EMHHPBJPEDN, uint KGJJADLKMMJ);

		// Token: 0x06000AE1 RID: 2785
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetIPv4FakeIPType")]
		public static extern HJNNPCJKHBP CKLKOOOBBOF(IntPtr DNNEHDJMMBE, uint KGLEJGCAGBD);

		// Token: 0x06000AE2 RID: 2786
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetCurrentBatteryPower")]
		public static extern byte KNFIFMAKADF(IntPtr DNNEHDJMMBE);

		// Token: 0x06000AE3 RID: 2787
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyDataCount")]
		public static extern int IONNHEIMBLP(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK);

		// Token: 0x06000AE4 RID: 2788
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsFeatureBlocked")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EJLPNKKFBHL(IntPtr DNNEHDJMMBE, EOKNMIPAHFM FMJCJGGGCKH);

		// Token: 0x06000AE5 RID: 2789
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ReceivedP2PCustomSignal")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CEOMEGAFGHO(IntPtr DNNEHDJMMBE, IntPtr MFIJCBDPKMP, int DONIGFFDKIF, out ISteamNetworkingSignalingRecvContext FMFJAJAJJEL);

		// Token: 0x06000AE6 RID: 2790
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_DownloadItem")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FHMHIEFMEFE(IntPtr DNNEHDJMMBE, PublishedFileId_t GGEBDPEOMDI, [MarshalAs(UnmanagedType.I1)] bool JFJACCMOJCC);

		// Token: 0x06000AE7 RID: 2791
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetAppInstallDir")]
		public static extern int DEFKKPMPAIG(IntPtr DNNEHDJMMBE, AppId_t MINMIFBPLGA, IntPtr DAEMIIJHMFG, int FCNCOPLFPFG);

		// Token: 0x06000AE8 RID: 2792
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FKBCKEBDHOL(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM);

		// Token: 0x06000AE9 RID: 2793
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SubscribeItem")]
		public static extern ulong IHCFHOJOIFD(IntPtr DNNEHDJMMBE, PublishedFileId_t GGEBDPEOMDI);

		// Token: 0x06000AEA RID: 2794
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_BInitWorkshopForGameServer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JIKCGINEBIJ(IntPtr DNNEHDJMMBE, DepotId_t CEGCLIKLCIO, MBLFNIBGODG.LJANJDBDBJI KIEGJADOECP);

		// Token: 0x06000AEB RID: 2795
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RefreshServer")]
		public static extern void ININEHDGHEG(IntPtr DNNEHDJMMBE, HServerListRequest JMMGPGJONFK, int AANPFBNELOC);

		// Token: 0x06000AEC RID: 2796
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_RequestEncryptedAppTicket")]
		public static extern ulong MENFNKAIIBP(IntPtr DNNEHDJMMBE, byte[] CHHINJLKDIG, int BKAANNIJECJ);

		// Token: 0x06000AED RID: 2797
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialog")]
		public static extern void ILAGCINGADA(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK);

		// Token: 0x06000AEE RID: 2798
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SendUserConnectAndAuthenticate_DEPRECATED")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EEKHAFLMODB(IntPtr DNNEHDJMMBE, uint DKDEPJHHPJA, byte[] KIAECPMFNOP, uint OIMPKBGDGMA, out CSteamID BEDJEEPEIFG);

		// Token: 0x06000AEF RID: 2799
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_SetLEDColor")]
		public static extern void OAEABGCOGIM(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, byte IOLDBDIMPCK, byte ELEPOEJNDPB, byte DKBFNKDMMMO, uint NJPPDMDFJGM);

		// Token: 0x06000AF0 RID: 2800
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_TriggerVibrationExtended")]
		public static extern void ILDJBIKHJCP(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, ushort LMGHFJIJEGD, ushort HJJDNGHCIOC, ushort FJEOMKHEDDE, ushort FCCDNILGKLC);

		// Token: 0x06000AF1 RID: 2801
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_CreateLobby")]
		public static extern ulong PFFGCOEKEEA(IntPtr DNNEHDJMMBE, KBKCDOCDIOG OJKAEDNPFIO, int MHDDCDHOMKE);

		// Token: 0x06000AF2 RID: 2802
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ReceiveMessagesOnConnection")]
		public static extern int DMHAHADBNBL(IntPtr DNNEHDJMMBE, HSteamNetConnection KLJAKJFEEIC, [In] [Out] IntPtr[] OEJHILDLJMA, int FGGDIFEKDHH);

		// Token: 0x06000AF3 RID: 2803
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_AdvertiseGame")]
		public static extern void HAFODGICNHN(IntPtr DNNEHDJMMBE, CSteamID NPGPIHJKJKL, uint KBEGLOAIKDH, ushort FEODOCNHGBA);

		// Token: 0x06000AF4 RID: 2804
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetDigitalActionOrigins")]
		public static extern int JBIODJFNHHG(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, InputActionSetHandle_t DDMHFIOGJMM, InputDigitalActionHandle_t DKOKEGDKMNP, [In] [Out] FMPMIBBOIAM[] GMLKDCDEIIM);

		// Token: 0x06000AF5 RID: 2805
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryAllUGCRequestPage")]
		public static extern ulong KNBKECAENIA(IntPtr DNNEHDJMMBE, DBJPCBDMANI FOAFHNBELNA, GGBFGPNFANI PNNMCOENFNM, AppId_t HPKODIICKAI, AppId_t FELDDNEJJND, uint GMGLDEBLDNK);

		// Token: 0x06000AF6 RID: 2806
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamApps")]
		public static extern IntPtr LLEGKMPMOBC(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000AF7 RID: 2807
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_GetUserVariableData")]
		public static extern IntPtr CNKDLOONMKB([In] [Out] byte[] OJNJHJOIJDG, uint HADHJKAMIBG, out uint PAGKDAPPIAL);

		// Token: 0x06000AF8 RID: 2808
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStatDouble")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KJHBCHFCKEP(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI FMEDOEGOAPD, out double EENCENODOOG);

		// Token: 0x06000AF9 RID: 2809
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_SetStatInt32")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FKAOMMANDGD(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, int EEJHBDOCDLB);

		// Token: 0x06000AFA RID: 2810
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_RequestUserGroupStatus")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LLALAMECLDP(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, CSteamID FIMKBFPNOJH);

		// Token: 0x06000AFB RID: 2811
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanCount")]
		public static extern int MKAJDFPAPIG(IntPtr DNNEHDJMMBE);

		// Token: 0x06000AFC RID: 2812
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_UseBreakpadCrashHandler")]
		public static extern void LMPHNFGENFE(MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI, MBLFNIBGODG.LJANJDBDBJI JEHMMHGEBDE, MBLFNIBGODG.LJANJDBDBJI MKIFMGBKKOJ, [MarshalAs(UnmanagedType.I1)] bool KLLIMKBAEDM, IntPtr NPNEOCPOBNH, IntPtr IODDGDBPBPO);

		// Token: 0x06000AFD RID: 2813
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_RegisterCallback")]
		public static extern void MGCPBGOBEGI(IntPtr KBIIJJJNAND, int PFGNHABKHFF);

		// Token: 0x06000AFE RID: 2814
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnOnlyIDs")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HPHGLLMOEHA(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, [MarshalAs(UnmanagedType.I1)] bool MNKEIPKMCHN);

		// Token: 0x06000AFF RID: 2815
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetNumInstalledApps")]
		public static extern uint NABDJGOGEHI(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B00 RID: 2816
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRelationship")]
		public static extern GGKMBJDKJBP GANJMHMFKEM(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE);

		// Token: 0x06000B01 RID: 2817
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFilePreviewFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AHDFDENJMDE(IntPtr DNNEHDJMMBE, PublishedFileUpdateHandle_t OGPKKNDEDFI, MBLFNIBGODG.LJANJDBDBJI GCBFBPOGCJH);

		// Token: 0x06000B02 RID: 2818
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetBotPlayerCount")]
		public static extern void FFPOFFGLOLA(IntPtr DNNEHDJMMBE, int JPCFMCCLDLN);

		// Token: 0x06000B03 RID: 2819
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetSearchText")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LIMDEDJEAID(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI CGODINGIAPO);

		// Token: 0x06000B04 RID: 2820
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_LogOn")]
		public static extern void MFKAMGHEPPC(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DCGBOBAMILN);

		// Token: 0x06000B05 RID: 2821
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemTitle")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HPCGGJFNIBM(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI OGKPBGKNHGB);

		// Token: 0x06000B06 RID: 2822
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_GetServerCount")]
		public static extern int DDHJKDGPMAD(IntPtr DNNEHDJMMBE, HServerListRequest JMMGPGJONFK);

		// Token: 0x06000B07 RID: 2823
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateCurrentEntryText")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LCAACCJGBNG(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI HGOFKBNCMNK);

		// Token: 0x06000B08 RID: 2824
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_BActivationSuccess")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PNHGPPHOICP(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool OFLAMEMDFGK);

		// Token: 0x06000B09 RID: 2825
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_ConnectToGlobalUser")]
		public static extern int AMNNJOLHOPD(IntPtr DNNEHDJMMBE, HSteamPipe CMIMOPGNCKB);

		// Token: 0x06000B0A RID: 2826
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_CancelQuery")]
		public static extern void BJIFKKLFKCD(IntPtr DNNEHDJMMBE, HServerListRequest JMMGPGJONFK);

		// Token: 0x06000B0B RID: 2827
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ManualDispatch_GetNextCallback")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PEJDFNMNDNM(HSteamPipe CMIMOPGNCKB, IntPtr NJKHHMKOHJJ);

		// Token: 0x06000B0C RID: 2828
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_AcceptGame")]
		public static extern BIPOIENHHDB PIBNBDFLBBB(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B0D RID: 2829
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetUserAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LODJFDEBICC(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out bool LAEOHDNHABG);

		// Token: 0x06000B0E RID: 2830
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateCurrentEntryCoverArt")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JKIMLOPONKL(IntPtr DNNEHDJMMBE, byte[] KMHBNOFCMCJ, uint NFIHMJGHGAA);

		// Token: 0x06000B0F RID: 2831
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetBackgroundMode")]
		public static extern void CJOAHPEJAAI(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, [MarshalAs(UnmanagedType.I1)] bool BLBPCBMCJEB);

		// Token: 0x06000B10 RID: 2832
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddItemPreviewFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KONPGBHMOEE(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI ELIICLHPPGH, AEEIMFAGCJP OBKCKGHFMDN);

		// Token: 0x06000B11 RID: 2833
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetAPICallFailureReason")]
		public static extern KDPLPHMCCPC IPKGKHNKCKL(IntPtr DNNEHDJMMBE, SteamAPICall_t MANNBDDGHDG);

		// Token: 0x06000B12 RID: 2834
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyGameServer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PCFOFDBLOGH(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, out uint KPPNIFIMJBO, out ushort LGEEOKMLEBE, out CSteamID EHLPFJDPJJP);

		// Token: 0x06000B13 RID: 2835
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_WriteScreenshot")]
		public static extern uint DOHJLAEFDEK(IntPtr DNNEHDJMMBE, byte[] PFHPDOPHAJN, uint MABNICDOIIJ, int FMGAFHBLOAJ, int HEIJKMFOAPM);

		// Token: 0x06000B14 RID: 2836
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BLoggedOn")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DCKLBEFLCFP(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B15 RID: 2837
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_TriggerItemDrop")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BJFBIEJHJKO(IntPtr DNNEHDJMMBE, out SteamInventoryResult_t DONIEBGGKMH, SteamItemDef_t KKAFLCCFEKF);

		// Token: 0x06000B16 RID: 2838
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_CurrentEntryDidChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HMJBDOHDPKE(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B17 RID: 2839
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnPlaytimeStats")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PKGFEABPPMF(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint HOGEIIFKLAL);

		// Token: 0x06000B18 RID: 2840
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetPlayedWith")]
		public static extern void LNLMMMBMLCK(IntPtr DNNEHDJMMBE, CSteamID DKLLADPHDMK);

		// Token: 0x06000B19 RID: 2841
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_IsScreenshotsHooked")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FHDHHNFHNKB(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B1A RID: 2842
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsFollowing")]
		public static extern ulong LEDCFBPBLGG(IntPtr DNNEHDJMMBE, CSteamID EKCOJJGHNAN);

		// Token: 0x06000B1B RID: 2843
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_StopVoiceRecording")]
		public static extern void CBCAKMILLJN(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B1C RID: 2844
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsClanChatAdmin")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PFGDFGKEHIH(IntPtr DNNEHDJMMBE, CSteamID IEMJIPDDFAF, CSteamID AIIMBIAIIJE);

		// Token: 0x06000B1D RID: 2845
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetDownloadedLeaderboardEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BFAILPHJOIJ(IntPtr DNNEHDJMMBE, SteamLeaderboardEntries_t PLPBEJGPMEN, int GGICIBLJIKI, out HJBHJDPLPAF HOJAMOJAJFC, [In] [Out] int[] NNBNPPJLBJB, int JHOKFMKKKFM);

		// Token: 0x06000B1E RID: 2846
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_Legacy_TriggerHapticPulse")]
		public static extern void GGKBLNFHGFA(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, LGLCIHJJPHM HKFJJGIFBCF, ushort LKMPIGIFGHB);

		// Token: 0x06000B1F RID: 2847
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCNumKeyValueTags")]
		public static extern uint FICEFAILAFO(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint GGICIBLJIKI);

		// Token: 0x06000B20 RID: 2848
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_Shutdown")]
		public static extern void CAOMNEJECHP();

		// Token: 0x06000B21 RID: 2849
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_ViewSource")]
		public static extern void JJBEAILBLHB(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD);

		// Token: 0x06000B22 RID: 2850
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseDown")]
		public static extern void FFCDMKJBGFF(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, LLBDBBLHDJH GIAGILLMLDD);

		// Token: 0x06000B23 RID: 2851
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveAppDependency")]
		public static extern ulong KMFCGEAMAAA(IntPtr DNNEHDJMMBE, PublishedFileId_t GGEBDPEOMDI, AppId_t MINMIFBPLGA);

		// Token: 0x06000B24 RID: 2852
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetCurrentBetaName")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CDPMDAHFHEJ(IntPtr DNNEHDJMMBE, IntPtr DECMMMNKHKM, int LOANEKLELKE);

		// Token: 0x06000B25 RID: 2853
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_ActivateActionSet")]
		public static extern void KCFOIOLEOPM(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, InputActionSetHandle_t DDMHFIOGJMM);

		// Token: 0x06000B26 RID: 2854
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddExcludedTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CJKKFLOFIAD(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI DGJLIDOAHMA);

		// Token: 0x06000B27 RID: 2855
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_FindRelayAuthTicketForServer")]
		public static extern int MEIOCDPNJJP(IntPtr DNNEHDJMMBE, ref SteamNetworkingIdentity KKEHIADLCJB, int CGFFFNBFNLM, out SteamDatagramRelayAuthTicket HKCLNAPAJJI);

		// Token: 0x06000B28 RID: 2856
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumeratePublishedFilesByUserAction")]
		public static extern ulong LDHJKJIIEGF(IntPtr DNNEHDJMMBE, HHBMAKCBGJI MMCPCCBPOGG, uint CMKIMAENFKO);

		// Token: 0x06000B29 RID: 2857
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_UnregisterCallResult")]
		public static extern void OCPHJBMONHJ(IntPtr KBIIJJJNAND, ulong MNKAEOKBKBL);

		// Token: 0x06000B2A RID: 2858
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_CreateSteamPipe")]
		public static extern int PFGGCGJJJJH(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B2B RID: 2859
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnablePlayPrevious")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DFPJGLHOGMF(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool OFLAMEMDFGK);

		// Token: 0x06000B2C RID: 2860
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_StopPlaytimeTracking")]
		public static extern ulong KFHMKPOOGLJ(IntPtr DNNEHDJMMBE, [In] [Out] PublishedFileId_t[] LMJGFJPENLP, uint GEALEAJEMDJ);

		// Token: 0x06000B2D RID: 2861
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupMembersCount")]
		public static extern int EKGOLLICCEK(IntPtr DNNEHDJMMBE, FriendsGroupID_t NKGLGJEPBBC);

		// Token: 0x06000B2E RID: 2862
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetSteamID64")]
		public static extern void FMKJBCFAEFI(ref SteamNetworkingIdentity DPAHMPHNPMK, ulong EKCOJJGHNAN);

		// Token: 0x06000B2F RID: 2863
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SetMiniDumpComment")]
		public static extern void PBOPLEGOABL(MBLFNIBGODG.LJANJDBDBJI KJOFPFHLPJP);

		// Token: 0x06000B30 RID: 2864
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCPreviewURL")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CPBEBFDCPDE(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint GGICIBLJIKI, IntPtr PJICBBBIOCG, uint OLJLBBCHGPK);

		// Token: 0x06000B31 RID: 2865
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SetPropertyString")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool APLDBHNIBLC(IntPtr DNNEHDJMMBE, SteamInventoryUpdateHandle_t CCCPIFNDMGF, SteamItemInstanceID_t FNBDJJIEEJC, MBLFNIBGODG.LJANJDBDBJI AGIKLDMPJPE, MBLFNIBGODG.LJANJDBDBJI CGHBDIMJGFC);

		// Token: 0x06000B32 RID: 2866
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SteamNetworkingIdentity_ParseString")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AFFNIIGCBPG(IntPtr DNNEHDJMMBE, out SteamNetworkingIdentity JDOLBOKDBLA, MBLFNIBGODG.LJANJDBDBJI OBJAIHPGOJN);

		// Token: 0x06000B33 RID: 2867
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_TradeItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AMIMNKBANHM(IntPtr DNNEHDJMMBE, out SteamInventoryResult_t DONIEBGGKMH, CSteamID ACNNAFCICCK, [In] [Out] SteamItemInstanceID_t[] LDENOIMKGGH, [In] [Out] uint[] DIFLCBADCDE, uint PDGOLJFANKI, [In] [Out] SteamItemInstanceID_t[] JFOFLPAGMFH, [In] [Out] uint[] IEDJOBHNHOO, uint KGDGFGIBCPJ);

		// Token: 0x06000B34 RID: 2868
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPStreamingResponseBodyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NNNONOAMMOM(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, uint BJODAJPANIA, byte[] MLCELDADLAL, uint NJILDPDADEM);

		// Token: 0x06000B35 RID: 2869
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseBodyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FINPKNKJDKF(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, byte[] MLCELDADLAL, uint NJILDPDADEM);

		// Token: 0x06000B36 RID: 2870
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetEnteredGamepadTextLength")]
		public static extern uint EGOPKBPAENI(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B37 RID: 2871
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_GetVolume")]
		public static extern float CJLOBOLJJJC(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B38 RID: 2872
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetLocalPingLocation")]
		public static extern float NFLDGMDHDKF(IntPtr DNNEHDJMMBE, out FJNHNDBKGFH NCPLJJLBHLA);

		// Token: 0x06000B39 RID: 2873
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetPingToDataCenter")]
		public static extern int DLIHHFANJGB(IntPtr DNNEHDJMMBE, SteamNetworkingPOPID NOPOBGMPHIB, out SteamNetworkingPOPID OHDAJOBFJEN);

		// Token: 0x06000B3A RID: 2874
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_AcceptP2PSessionWithUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CIMFOMJHDMA(IntPtr DNNEHDJMMBE, CSteamID KHBNBCJABCI);

		// Token: 0x06000B3B RID: 2875
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_ConsumeItem")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EJCNLBEKOMG(IntPtr DNNEHDJMMBE, out SteamInventoryResult_t DONIEBGGKMH, SteamItemInstanceID_t DJAAFBMGIBA, uint HPAEDHHMDFM);

		// Token: 0x06000B3C RID: 2876
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileSize")]
		public static extern int PMIMCKOGAKM(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ);

		// Token: 0x06000B3D RID: 2877
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCNumAdditionalPreviews")]
		public static extern uint PAHFIPLHNOM(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint GGICIBLJIKI);

		// Token: 0x06000B3E RID: 2878
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayToStore")]
		public static extern void GNKMEPJABFI(IntPtr DNNEHDJMMBE, AppId_t MINMIFBPLGA, NIAGEJIKNCJ CELKGFFNJBI);

		// Token: 0x06000B3F RID: 2879
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamGenericInterface")]
		public static extern IntPtr LMDDOOBMBCD(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000B40 RID: 2880
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingMessage_t_Release")]
		public static extern void LLDPNDPOEEN(IntPtr DPAHMPHNPMK);

		// Token: 0x06000B41 RID: 2881
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCount")]
		public static extern int POEFCFFHFAC(IntPtr DNNEHDJMMBE, PKIJCNBOGAH HMMINHBNAFA);

		// Token: 0x06000B42 RID: 2882
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_DeregisterSteamMusicRemote")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MBKECDBFAHA(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B43 RID: 2883
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetItemsByID")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LNFFEOEPHAM(IntPtr DNNEHDJMMBE, out SteamInventoryResult_t DONIEBGGKMH, [In] [Out] SteamItemInstanceID_t[] BLILHKPJJAD, uint HKIOKDNFCGI);

		// Token: 0x06000B44 RID: 2884
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SetPropertyFloat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FHJPOKBGEJJ(IntPtr DNNEHDJMMBE, SteamInventoryUpdateHandle_t CCCPIFNDMGF, SteamItemInstanceID_t FNBDJJIEEJC, MBLFNIBGODG.LJANJDBDBJI AGIKLDMPJPE, float DCGJPJIACHO);

		// Token: 0x06000B45 RID: 2885
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetLocalFileChangeCount")]
		public static extern int EGPLACBOBPA(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B46 RID: 2886
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddItemPreviewVideo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GDOAGCHPIPO(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI KFFLFHKNKPC);

		// Token: 0x06000B47 RID: 2887
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_PlayerDetails")]
		public static extern int LFGFBAGIOJL(IntPtr DNNEHDJMMBE, uint FLGFECHPNIF, ushort KLBOAFDGBGD, IntPtr POEEGAJBLKJ);

		// Token: 0x06000B48 RID: 2888
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsClanPublic")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HNCIMFLEPAK(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI);

		// Token: 0x06000B49 RID: 2889
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamGameServer_GetHSteamUser")]
		public static extern int JELPPGBJPKP();

		// Token: 0x06000B4A RID: 2890
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_GetSteamInstallPath")]
		public static extern int NANOOHMCLBC();

		// Token: 0x06000B4B RID: 2891
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTitle")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NMFEOMNAOGP(IntPtr DNNEHDJMMBE, PublishedFileUpdateHandle_t OGPKKNDEDFI, MBLFNIBGODG.LJANJDBDBJI OGKPBGKNHGB);

		// Token: 0x06000B4C RID: 2892
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetLargeFriendAvatar")]
		public static extern int AMBPGFMCAMG(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE);

		// Token: 0x06000B4D RID: 2893
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetAPICallResult")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MNAHKCGEADB(IntPtr DNNEHDJMMBE, SteamAPICall_t MANNBDDGHDG, IntPtr KBIIJJJNAND, int MAHPBKLIIGA, int OCDEGGHNMPK, out bool HFDJMCJKOJO);

		// Token: 0x06000B4E RID: 2894
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddItemKeyValueTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HAHFCEDGGFG(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE, MBLFNIBGODG.LJANJDBDBJI OIABIHIJPJN);

		// Token: 0x06000B4F RID: 2895
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsDlcInstalled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CLJOIPFFNDB(IntPtr DNNEHDJMMBE, AppId_t NCFIHMEHIOE);

		// Token: 0x06000B50 RID: 2896
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_DestroyResult")]
		public static extern void LHGGPHFAKLP(IntPtr DNNEHDJMMBE, SteamInventoryResult_t PDIGNGHLDII);

		// Token: 0x06000B51 RID: 2897
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_GoForward")]
		public static extern void HHOCIECMNEN(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD);

		// Token: 0x06000B52 RID: 2898
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CreateP2PConnectionSocket")]
		public static extern uint LEHGGGMJJLD(IntPtr DNNEHDJMMBE, CSteamID JJIMHCEPCEJ, int LLOAPLKBDFI, int AKOPLPAKHLK, [MarshalAs(UnmanagedType.I1)] bool CNMFEMBPLLB);

		// Token: 0x06000B53 RID: 2899
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseWheel")]
		public static extern void IOJMJCGMEAJ(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, int KNKNFHCNHLC);

		// Token: 0x06000B54 RID: 2900
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetResultStatus")]
		public static extern LNFOAHHPFIH NCGKPLDOKKP(IntPtr DNNEHDJMMBE, SteamInventoryResult_t PDIGNGHLDII);

		// Token: 0x06000B55 RID: 2901
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetIPCountry")]
		public static extern IntPtr CEAHICBIJIG(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B56 RID: 2902
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_IsRefreshing")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IKKDLJOPFCD(IntPtr DNNEHDJMMBE, HServerListRequest JMMGPGJONFK);

		// Token: 0x06000B57 RID: 2903
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetCertificateRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MBIAODPKLFG(IntPtr DNNEHDJMMBE, out int DIIEGPGNBMA, IntPtr HKJGMGLNCNI, out SteamNetworkingErrMsg LIJKILOLJCG);

		// Token: 0x06000B58 RID: 2904
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_RetrieveConnectionDetails")]
		public static extern BIPOIENHHDB BOLNBCCHIJG(IntPtr DNNEHDJMMBE, CSteamID NNAOGJGCJAG, IntPtr CAJDJBPODAJ, int HECBNAKMPJL);

		// Token: 0x06000B59 RID: 2905
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_Clear")]
		public static extern void ALGGJPDHCFJ(ref SteamNetworkingIdentity DPAHMPHNPMK);

		// Token: 0x06000B5A RID: 2906
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_StartVoiceRecording")]
		public static extern void JOBLIAKJPLB(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B5B RID: 2907
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPDownloadProgressPct")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NLMGHDEEHLO(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, out float FKAJEKKNCOP);

		// Token: 0x06000B5C RID: 2908
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLinkedLobby")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FIEIGEJMACF(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, CSteamID LKBFEKIPPIB);

		// Token: 0x06000B5D RID: 2909
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamGameServer_RunCallbacks")]
		public static extern void DENFJPIMHGN();

		// Token: 0x06000B5E RID: 2910
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_EstimatePingTimeBetweenTwoLocations")]
		public static extern int IMJEPEDDKNO(IntPtr DNNEHDJMMBE, ref FJNHNDBKGFH FLBNGHHDOMJ, ref FJNHNDBKGFH DBBCEHKHFOD);

		// Token: 0x06000B5F RID: 2911
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_CancelAuthTicket")]
		public static extern void MKMAMGAFMLF(IntPtr DNNEHDJMMBE, HAuthTicket FPPNJFFHOBM);

		// Token: 0x06000B60 RID: 2912
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_ReleaseRequest")]
		public static extern void PMCEDMMHECF(IntPtr DNNEHDJMMBE, HServerListRequest NBJKMJKAGEE);

		// Token: 0x06000B61 RID: 2913
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetInputTypeForHandle")]
		public static extern CNMNFDBIGJE OPIKMHBBLIK(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA);

		// Token: 0x06000B62 RID: 2914
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_LogOff")]
		public static extern void GHHPIHMAPLL(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B63 RID: 2915
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_CheckResultSteamID")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KHIEMDGDAPA(IntPtr DNNEHDJMMBE, SteamInventoryResult_t PDIGNGHLDII, CSteamID KBHBABCJODP);

		// Token: 0x06000B64 RID: 2916
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_PlaylistWillChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JEPNLKMKKBK(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B65 RID: 2917
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UGCRead")]
		public static extern int JHFPLMBNBBK(IntPtr DNNEHDJMMBE, UGCHandle_t DNBPDFIIBHN, byte[] CMKDMIPPNGN, int DGDHMGAIPEL, uint BJODAJPANIA, ACKDMIEOIID MMCPCCBPOGG);

		// Token: 0x06000B66 RID: 2918
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsParentalLockEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BHLKAMKLHOF(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B67 RID: 2919
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_CurrentEntryIsAvailable")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EBCFOLPJEFP(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool DEHOFOBPCGJ);

		// Token: 0x06000B68 RID: 2920
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetAppBuildId")]
		public static extern int JJHCNKLBODJ(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B69 RID: 2921
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemContent")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ADHKEAIHOEB(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI PFGIGEMFKEK);

		// Token: 0x06000B6A RID: 2922
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetGameDescription")]
		public static extern void CFEIFHIOKFJ(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI ONAOGECJOPI);

		// Token: 0x06000B6B RID: 2923
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddAppDependency")]
		public static extern ulong KDAJOFPKCCH(IntPtr DNNEHDJMMBE, PublishedFileId_t GGEBDPEOMDI, AppId_t MINMIFBPLGA);

		// Token: 0x06000B6C RID: 2924
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_TriggerScreenshot")]
		public static extern void NOLANKCGAGI(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B6D RID: 2925
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetGenericString")]
		public static extern IntPtr LAABDAHFJPD(ref SteamNetworkingIdentity DPAHMPHNPMK);

		// Token: 0x06000B6E RID: 2926
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListStringFilter")]
		public static extern void MOEEEBLFKHJ(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI FGNGIMIEEAA, MBLFNIBGODG.LJANJDBDBJI GBDDODCMGKJ, FGMHAMAEGFJ PFAINDBEANH);

		// Token: 0x06000B6F RID: 2927
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_IndicateAchievementProgress")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DBOOFMLPNLM(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, uint PCGNPNFODDG, uint PLDGAMDNIKJ);

		// Token: 0x06000B70 RID: 2928
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ReplyToFriendMessage")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JFFEAIIOGHA(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE, MBLFNIBGODG.LJANJDBDBJI KKLMOHFPPMO);

		// Token: 0x06000B71 RID: 2929
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanTag")]
		public static extern IntPtr DJIINEHGPDH(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI);

		// Token: 0x06000B72 RID: 2930
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_IsIPv6AllZeros")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CCBJLMBMJDI(ref SteamNetworkingIPAddr DPAHMPHNPMK);

		// Token: 0x06000B73 RID: 2931
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetEarliestPurchaseUnixTime")]
		public static extern uint CJHEPNEPAFG(IntPtr DNNEHDJMMBE, AppId_t MINMIFBPLGA);

		// Token: 0x06000B74 RID: 2932
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamGameSearch")]
		public static extern IntPtr KEBFGAPOECH(IntPtr DNNEHDJMMBE, HSteamUser MPMPFFFHHLH, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000B75 RID: 2933
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_GetServerDetails")]
		public static extern IntPtr IDANBJHJBGN(IntPtr DNNEHDJMMBE, HServerListRequest JMMGPGJONFK, int AANPFBNELOC);

		// Token: 0x06000B76 RID: 2934
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BLBCHJJIALJ(IntPtr DNNEHDJMMBE, PublishedFileUpdateHandle_t OGPKKNDEDFI, MBLFNIBGODG.LJANJDBDBJI PINGELGCLCP);

		// Token: 0x06000B77 RID: 2935
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdatePlaybackStatus")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AGOGOIGBOID(IntPtr DNNEHDJMMBE, FGFIPOHIMFP IJDBOHIIFKF);

		// Token: 0x06000B78 RID: 2936
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetMaxPlayerCount")]
		public static extern void FEPFNHLAEJC(IntPtr DNNEHDJMMBE, int FHBGDADMCPD);

		// Token: 0x06000B79 RID: 2937
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetListenSocketInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EIFHNOLNLMH(IntPtr DNNEHDJMMBE, SNetListenSocket_t ODPEHFBKGIP, out SteamIPAddress_t LPJKMDBPHLA, out ushort MDBABPDKMIC);

		// Token: 0x06000B7A RID: 2938
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_LoadURL")]
		public static extern void HOOICNGLDBO(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, MBLFNIBGODG.LJANJDBDBJI PJICBBBIOCG, MBLFNIBGODG.LJANJDBDBJI KFMOJEBDOAH);

		// Token: 0x06000B7B RID: 2939
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_SetIPv6LocalHost")]
		public static extern void ABPLILLDOKN(ref SteamNetworkingIPAddr DPAHMPHNPMK, ushort MLHPDILCKGP);

		// Token: 0x06000B7C RID: 2940
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamClose")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IMNODNLKPON(IntPtr DNNEHDJMMBE, UGCFileWriteStreamHandle_t ONPIEANOOAB);

		// Token: 0x06000B7D RID: 2941
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_AttachLeaderboardUGC")]
		public static extern ulong AOOGKLJALNM(IntPtr DNNEHDJMMBE, SteamLeaderboard_t KFLCGDMDANA, UGCHandle_t LLBOIOOALKM);

		// Token: 0x06000B7E RID: 2942
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetGlyphForXboxOrigin")]
		public static extern IntPtr AJLCNDBGAGK(IntPtr DNNEHDJMMBE, KLMECMKLLGJ HAEIMJBBKOH);

		// Token: 0x06000B7F RID: 2943
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_SetWarningMessageHook")]
		public static extern void EJNIJMEDDDB(IntPtr DNNEHDJMMBE, NNMLFJGPMHE CHEGPLOODLB);

		// Token: 0x06000B80 RID: 2944
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_OpenClanChatWindowInSteam")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ALBBIJCFJMF(IntPtr DNNEHDJMMBE, CSteamID IEMJIPDDFAF);

		// Token: 0x06000B81 RID: 2945
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetSmallFriendAvatar")]
		public static extern int MGOLEBCKIOI(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE);

		// Token: 0x06000B82 RID: 2946
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_IsInvalid")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EKBIKMBBAJD(ref SteamNetworkingIdentity DPAHMPHNPMK);

		// Token: 0x06000B83 RID: 2947
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTags")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NPFEOINHMMD(IntPtr DNNEHDJMMBE, PublishedFileUpdateHandle_t OGPKKNDEDFI, IntPtr ICGNMKEHAGF);

		// Token: 0x06000B84 RID: 2948
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetModDir")]
		public static extern void KKKBBBGCIIG(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI EGFDADDEEKM);

		// Token: 0x06000B85 RID: 2949
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayToUser")]
		public static extern void BHKCPGPGPOP(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI NIKEALKJCND, CSteamID EKCOJJGHNAN);

		// Token: 0x06000B86 RID: 2950
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamGameServer_Shutdown")]
		public static extern void OOKOFFAHFKD();

		// Token: 0x06000B87 RID: 2951
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetLanguage")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool APHCBPDLHIH(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI LBEEKAMNEML);

		// Token: 0x06000B88 RID: 2952
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyMemberByIndex")]
		public static extern ulong IBCBMKMIBKP(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, int OGHECBLNOAP);

		// Token: 0x06000B89 RID: 2953
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCTagDisplayName")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OPADJKFNLAL(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint GGICIBLJIKI, uint JDIFEODBGFE, IntPtr OIABIHIJPJN, uint BJPOEIBIELI);

		// Token: 0x06000B8A RID: 2954
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestInternetServerList")]
		public static extern IntPtr HHFLCKKKGLM(IntPtr DNNEHDJMMBE, AppId_t GDIHJPFCLKN, IntPtr GAFCEHKPODN, uint ODAKHIGHAHO, IntPtr POEEGAJBLKJ);

		// Token: 0x06000B8B RID: 2955
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamGameServer_ReleaseCurrentThreadMemory")]
		public static extern void NEHDMJIGCLP();

		// Token: 0x06000B8C RID: 2956
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseMove")]
		public static extern void FMDEGHMFFBJ(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, int OBNBCGOIMKE, int DEJFBNMNMOK);

		// Token: 0x06000B8D RID: 2957
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsClanOfficialGameGroup")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PJAIMBEBEJK(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI);

		// Token: 0x06000B8E RID: 2958
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetItemsWithPrices")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DEHMHFGCBJK(IntPtr DNNEHDJMMBE, [In] [Out] SteamItemDef_t[] HPIHEINFIEO, [In] [Out] ulong[] JLDIFNAKOJB, [In] [Out] ulong[] CEOIHPHPPAO, uint OIPDLADCLOC);

		// Token: 0x06000B8F RID: 2959
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_EndGameSearch")]
		public static extern BIPOIENHHDB KHFCMPCOEDK(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B90 RID: 2960
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionID")]
		public static extern uint HCKCBACJBDO(IntPtr DNNEHDJMMBE, int AHKPGKJPPAH);

		// Token: 0x06000B91 RID: 2961
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ConnectP2PCustomSignaling")]
		public static extern uint CMHGCCMBNOG(IntPtr DNNEHDJMMBE, out ISteamNetworkingConnectionSignaling MMFDLIMPINF, ref SteamNetworkingIdentity PJIHKLMAEEJ, int CGFFFNBFNLM, int HHJMCLMABHG, [In] [Out] SteamNetworkingConfigValue_t[] NKNGPCMOHCH);

		// Token: 0x06000B92 RID: 2962
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetStringForAnalogActionName")]
		public static extern IntPtr LCBJPJKKAJL(IntPtr DNNEHDJMMBE, InputAnalogActionHandle_t JENLGNOHOFO);

		// Token: 0x06000B93 RID: 2963
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_SetSyncPlatforms")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IIAIGCADPOG(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ, EKHDJPGMBFP KALJOHHCDBD);

		// Token: 0x06000B94 RID: 2964
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetNumSubscribedItems")]
		public static extern uint OMNBKAAEMAF(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B95 RID: 2965
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_AddHeader")]
		public static extern void IOPFFBKKPJF(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE, MBLFNIBGODG.LJANJDBDBJI OIABIHIJPJN);

		// Token: 0x06000B96 RID: 2966
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_ReleaseQueryUGCRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EIEDJHCMAIP(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF);

		// Token: 0x06000B97 RID: 2967
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetGameCoordinatorServerLogin")]
		public static extern LNFOAHHPFIH LKHGIHNEKMH(IntPtr DNNEHDJMMBE, IntPtr PHAKFPAEDGO, out int BJIMIHJMDKN, IntPtr HKJGMGLNCNI);

		// Token: 0x06000B98 RID: 2968
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetUserPublishedItemVoteDetails")]
		public static extern ulong DGBJDKGNKKA(IntPtr DNNEHDJMMBE, PublishedFileId_t JPCGPJHIMMP);

		// Token: 0x06000B99 RID: 2969
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BUserIsVacBanned")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LAPDHBKCNFL([In] [Out] byte[] OJNJHJOIJDG, uint HADHJKAMIBG);

		// Token: 0x06000B9A RID: 2970
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_SetCertificate")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OEGOLAPAEPP(IntPtr DNNEHDJMMBE, IntPtr LJCJEHILPBN, int IOEEKOFPHOK, out SteamNetworkingErrMsg LIJKILOLJCG);

		// Token: 0x06000B9B RID: 2971
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsSteamRunningOnSteamDeck")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CACOMKLNGAL(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B9C RID: 2972
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_ShowWorkshopEULA")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LPEIPPDFFPD(IntPtr DNNEHDJMMBE);

		// Token: 0x06000B9D RID: 2973
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetFavoriteGame")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JAIDKBKLBHL(IntPtr DNNEHDJMMBE, int LGODMFHOJEB, out AppId_t MCFPBIONEAH, out uint LPJKMDBPHLA, out ushort JIFBDMHJJEB, out ushort JBANFMPNAJL, out uint BGGHBBJALIJ, out uint OOEDLPIIAPG);

		// Token: 0x06000B9E RID: 2974
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetCloudFileNameFilter")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BLGNOPNPKGP(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI DDLHOFANPPD);

		// Token: 0x06000B9F RID: 2975
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_IsFakeIP")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CMKGMDKLMOM(ref SteamNetworkingIdentity DPAHMPHNPMK);

		// Token: 0x06000BA0 RID: 2976
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileTimestamp")]
		public static extern long PFBLIHIIABP(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ);

		// Token: 0x06000BA1 RID: 2977
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreateListenSocketIP")]
		public static extern uint FGDFGNJEEGJ(IntPtr DNNEHDJMMBE, ref SteamNetworkingIPAddr BLJEPEOEMAD, int HHJMCLMABHG, [In] [Out] SteamNetworkingConfigValue_t[] NKNGPCMOHCH);

		// Token: 0x06000BA2 RID: 2978
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SendUserDisconnect_DEPRECATED")]
		public static extern void BOBPIMCAKDA(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE);

		// Token: 0x06000BA3 RID: 2979
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_TranslateActionOrigin")]
		public static extern FMPMIBBOIAM MLHCMBAJJAO(IntPtr DNNEHDJMMBE, CNMNFDBIGJE OGIAODPOLLP, FMPMIBBOIAM OBCKBIDNNDJ);

		// Token: 0x06000BA4 RID: 2980
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_CreateHTTPRequest")]
		public static extern uint CDEHFBONEED(IntPtr DNNEHDJMMBE, IPENMDLKAIE INCNHCKOLOD, MBLFNIBGODG.LJANJDBDBJI HALFKGGDICN);

		// Token: 0x06000BA5 RID: 2981
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OPFLFFPPGOD(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE, MBLFNIBGODG.LJANJDBDBJI OIABIHIJPJN);

		// Token: 0x06000BA6 RID: 2982
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetGameBadgeLevel")]
		public static extern int GOIBDPLFOLP(IntPtr DNNEHDJMMBE, int ECKKPLHJHPG, [MarshalAs(UnmanagedType.I1)] bool EKBKCFAADPA);

		// Token: 0x06000BA7 RID: 2983
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_SetUserPublishedFileAction")]
		public static extern ulong GIFHBDOPKIF(IntPtr DNNEHDJMMBE, PublishedFileId_t JPCGPJHIMMP, HHBMAKCBGJI MMCPCCBPOGG);

		// Token: 0x06000BA8 RID: 2984
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnableQueue")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CJAFPEBPMNA(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool OFLAMEMDFGK);

		// Token: 0x06000BA9 RID: 2985
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetGenericBytes")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ANBCNJLNGBB(ref SteamNetworkingIdentity DPAHMPHNPMK, [In] [Out] byte[] GDAFFANBJED, uint DLPBEGLKBJL);

		// Token: 0x06000BAA RID: 2986
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetSteamUILanguage")]
		public static extern IntPtr BEEEMGDMOHF(IntPtr DNNEHDJMMBE);

		// Token: 0x06000BAB RID: 2987
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_InviteUserToLobby")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FFCLGDGFLHL(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, CSteamID CJHAKDDBFLN);

		// Token: 0x06000BAC RID: 2988
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetDirectPingToPOP")]
		public static extern int NDLBFJJJLFJ(IntPtr DNNEHDJMMBE, SteamNetworkingPOPID NOPOBGMPHIB);

		// Token: 0x06000BAD RID: 2989
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetItemInstallInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OGGIKHIMGFJ(IntPtr DNNEHDJMMBE, PublishedFileId_t GGEBDPEOMDI, out ulong CAKCJJCCGIG, IntPtr BBPBGIBGOKD, uint DKJGAAHANCG, out uint HPKMKFPNBMC);

		// Token: 0x06000BAE RID: 2990
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CreateListenSocket")]
		public static extern uint OJOBGGCBMIJ(IntPtr DNNEHDJMMBE, int DFJBMAECICH, SteamIPAddress_t LGNJMHPGCFK, ushort MLHPDILCKGP, [MarshalAs(UnmanagedType.I1)] bool CNMFEMBPLLB);

		// Token: 0x06000BAF RID: 2991
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_ReleaseUser")]
		public static extern void JJIKPKCENMB(IntPtr DNNEHDJMMBE, HSteamPipe CMIMOPGNCKB, HSteamUser MIHMANIDOBJ);

		// Token: 0x06000BB0 RID: 2992
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsAPICallCompleted")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AGLIGCKDNMK(IntPtr DNNEHDJMMBE, SteamAPICall_t MANNBDDGHDG, out bool HFDJMCJKOJO);

		// Token: 0x06000BB1 RID: 2993
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetImageRGBA")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PFCOGHJPPEA(IntPtr DNNEHDJMMBE, int HAKFMIIOCKF, byte[] LJANICMPHHI, int LAPMACHBLMG);

		// Token: 0x06000BB2 RID: 2994
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribedApp")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IHLPCBAJJFB(IntPtr DNNEHDJMMBE, AppId_t NCFIHMEHIOE);

		// Token: 0x06000BB3 RID: 2995
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_StartVRDashboard")]
		public static extern void MAPBEMMNONH(IntPtr DNNEHDJMMBE);

		// Token: 0x06000BB4 RID: 2996
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetPersonaName")]
		public static extern IntPtr JIBNIOONKEP(IntPtr DNNEHDJMMBE);

		// Token: 0x06000BB5 RID: 2997
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetAnalogActionOrigins")]
		public static extern int BOLJDODGBJP(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, InputActionSetHandle_t DDMHFIOGJMM, InputAnalogActionHandle_t BOFOOAFFNBN, [In] [Out] FMPMIBBOIAM[] GMLKDCDEIIM);

		// Token: 0x06000BB6 RID: 2998
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_IsSteamRunning")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MBCGDIJGDAE();

		// Token: 0x06000BB7 RID: 2999
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetXboxPairwiseID")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FIAFKJCMKAD(ref SteamNetworkingIdentity DPAHMPHNPMK, MBLFNIBGODG.LJANJDBDBJI MCOLDANPEJC);

		// Token: 0x06000BB8 RID: 3000
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_SetGameLauncherMode")]
		public static extern void EOOHHDBGIEK(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool DBMPLMFPKIP);

		// Token: 0x06000BB9 RID: 3001
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_FlushMessagesOnConnection")]
		public static extern LNFOAHHPFIH OBBHGGOPGLJ(IntPtr DNNEHDJMMBE, HSteamNetConnection KLJAKJFEEIC);

		// Token: 0x06000BBA RID: 3002
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_Init")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FHHLJOMCMAB(IntPtr DNNEHDJMMBE);

		// Token: 0x06000BBB RID: 3003
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyMemberLimit")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LPJJPEKOGLC(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, int MHDDCDHOMKE);

		// Token: 0x06000BBC RID: 3004
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddItemToFavorites")]
		public static extern ulong KHNOFPMJPFP(IntPtr DNNEHDJMMBE, AppId_t PENOMDECAOM, PublishedFileId_t GGEBDPEOMDI);

		// Token: 0x06000BBD RID: 3005
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamGameServer_GetSteamID")]
		public static extern ulong FFEKOKHHGNA();

		// Token: 0x06000BBE RID: 3006
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreateFakeUDPPort")]
		public static extern IntPtr ELNLNHEBOMK(IntPtr DNNEHDJMMBE, int MPFFOLPIOFL);

		// Token: 0x06000BBF RID: 3007
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetRelayNetworkStatus")]
		public static extern DNEHHBIPLOF CCCACAHLLEH(IntPtr DNNEHDJMMBE, out HJEAPDAHODL NNBNPPJLBJB);

		// Token: 0x06000BC0 RID: 3008
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsAppBlocked")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LHMPPCADEKN(IntPtr DNNEHDJMMBE, AppId_t MINMIFBPLGA);

		// Token: 0x06000BC1 RID: 3009
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParties_GetBeaconDetails")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KKHPPHFHNJL(IntPtr DNNEHDJMMBE, PartyBeaconID_t EDBIODFMAON, out CSteamID DEKGJBELPKE, out LAMANAOFFOF FLGMGKMHCLA, IntPtr CKNGJJCGEKB, int BIFMDDHLNMC);

		// Token: 0x06000BC2 RID: 3010
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetTimeUpdatedDateRange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NLBODDBJECM(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint BJCBCDACDMM, uint JKPOJHGGCJN);

		// Token: 0x06000BC3 RID: 3011
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateLooped")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CNDLDOCNECJ(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool OFLAMEMDFGK);

		// Token: 0x06000BC4 RID: 3012
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_AllowP2PPacketRelay")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BHONFAMOHIH(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool NCPLLDLHMDO);

		// Token: 0x06000BC5 RID: 3013
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetServerRealTime")]
		public static extern uint KNJAIBKKEII(IntPtr DNNEHDJMMBE);

		// Token: 0x06000BC6 RID: 3014
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetAllowLegacyUpload")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EAPMEDCBEMO(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, [MarshalAs(UnmanagedType.I1)] bool ADPNFAOPBMN);

		// Token: 0x06000BC7 RID: 3015
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_TagPublishedFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OCKLDGCGKAE(IntPtr DNNEHDJMMBE, ScreenshotHandle CJNPEFMLHCC, PublishedFileId_t HLNFFLGPJMM);

		// Token: 0x06000BC8 RID: 3016
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_FindLeaderboard")]
		public static extern ulong CKCHDCOALCF(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI IEKKCEPPKFA);

		// Token: 0x06000BC9 RID: 3017
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_HostConfirmGameStart")]
		public static extern BIPOIENHHDB MGHMDGOBGKM(IntPtr DNNEHDJMMBE, ulong PKPKIKFPDID);

		// Token: 0x06000BCA RID: 3018
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupIDByIndex")]
		public static extern short EPAGBEKHNHK(IntPtr DNNEHDJMMBE, int NKKAKMHJJPK);

		// Token: 0x06000BCB RID: 3019
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetItemDefinitionProperty")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ILFDOGHBLNA(IntPtr DNNEHDJMMBE, SteamItemDef_t GBBOHNKFKMJ, MBLFNIBGODG.LJANJDBDBJI AGIKLDMPJPE, IntPtr IEMHFECBNOD, ref uint JPIJOPFKOJO);

		// Token: 0x06000BCC RID: 3020
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemMetadata")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ENOLODMFGOP(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI LKJIKFFDNPK);

		// Token: 0x06000BCD RID: 3021
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetAllItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NDKDNAMJEAD(IntPtr DNNEHDJMMBE, out SteamInventoryResult_t DONIEBGGKMH);

		// Token: 0x06000BCE RID: 3022
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetUserRestrictions")]
		public static extern uint FLMFLONCIKB(IntPtr DNNEHDJMMBE);

		// Token: 0x06000BCF RID: 3023
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStatHistoryDouble")]
		public static extern int MDDFBGFHINL(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI FMEDOEGOAPD, [In] [Out] double[] EENCENODOOG, uint DNFELHKNIIP);

		// Token: 0x06000BD0 RID: 3024
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_TrackAppUsageEvent")]
		public static extern void EDEEHMOGNMC(IntPtr DNNEHDJMMBE, CGameID KMMJEMMAGML, int BKLDCOMIMGA, MBLFNIBGODG.LJANJDBDBJI JMAOPFDJNEN);

		// Token: 0x06000BD1 RID: 3025
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_ParsePingLocationString")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AJJCDGFECFE(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI MCOLDANPEJC, out FJNHNDBKGFH NCPLJJLBHLA);

		// Token: 0x06000BD2 RID: 3026
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestLANServerList")]
		public static extern IntPtr EBBKGIPNIKP(IntPtr DNNEHDJMMBE, AppId_t GDIHJPFCLKN, IntPtr POEEGAJBLKJ);

		// Token: 0x06000BD3 RID: 3027
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamAppList")]
		public static extern IntPtr OOEBIDJDCCN(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000BD4 RID: 3028
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_DestroyPollGroup")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AJMGOJLFCJH(IntPtr DNNEHDJMMBE, HSteamNetPollGroup HJBCPEEDMKC);

		// Token: 0x06000BD5 RID: 3029
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_IsDataAvailable")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OIFLBEMHAKF(IntPtr DNNEHDJMMBE, SNetListenSocket_t ODPEHFBKGIP, out uint KNKBMPIDGDN, out SNetSocket_t NEDPBLFHBLK);

		// Token: 0x06000BD6 RID: 3030
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumerateUserPublishedFiles")]
		public static extern ulong CEGKDPFDEFP(IntPtr DNNEHDJMMBE, uint CMKIMAENFKO);

		// Token: 0x06000BD7 RID: 3031
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SetBreakpadAppID")]
		public static extern void NGICLIOJPGF(uint AFHNDJCGNPE);

		// Token: 0x06000BD8 RID: 3032
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserStatFloat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ENIHKAGNGGC(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out float EENCENODOOG);

		// Token: 0x06000BD9 RID: 3033
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_PingServer")]
		public static extern int LPHBKBEPCNJ(IntPtr DNNEHDJMMBE, uint FLGFECHPNIF, ushort KLBOAFDGBGD, IntPtr POEEGAJBLKJ);

		// Token: 0x06000BDA RID: 3034
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_SetConnectionDetails")]
		public static extern BIPOIENHHDB LKEFBLGBPIE(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI CAJDJBPODAJ, int HECBNAKMPJL);

		// Token: 0x06000BDB RID: 3035
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_CancelAuthTicket")]
		public static extern void DJEEJHNAEMD(IntPtr DNNEHDJMMBE, HAuthTicket FPPNJFFHOBM);

		// Token: 0x06000BDC RID: 3036
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_KeyUp")]
		public static extern void CJDDCDNMCCJ(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, uint HDHJKLHPEPI, ALLPEMGCAMA PLJNDMGBDIP);

		// Token: 0x06000BDD RID: 3037
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetChatMemberByIndex")]
		public static extern ulong LJDIMAGDGNG(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI, int OAALGIAJMEE);

		// Token: 0x06000BDE RID: 3038
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnLongDescription")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GNEIGGCLFNB(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, [MarshalAs(UnmanagedType.I1)] bool NDHNMIODDLO);

		// Token: 0x06000BDF RID: 3039
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_RequestPrices")]
		public static extern ulong KAEBPJPLCMK(IntPtr DNNEHDJMMBE);

		// Token: 0x06000BE0 RID: 3040
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CloseP2PSessionWithUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DJGHALMIODN(IntPtr DNNEHDJMMBE, CSteamID KHBNBCJABCI);

		// Token: 0x06000BE1 RID: 3041
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetAvailableGameLanguages")]
		public static extern IntPtr JHHBIKLIHMP(IntPtr DNNEHDJMMBE);

		// Token: 0x06000BE2 RID: 3042
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetDPIScalingFactor")]
		public static extern void MPFALMAKOBA(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, float CKEHDIOIMHA);

		// Token: 0x06000BE3 RID: 3043
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementIcon")]
		public static extern int FIALLPICEMC(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM);

		// Token: 0x06000BE4 RID: 3044
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetLocalFileChange")]
		public static extern IntPtr BJHMBFPHMKL(IntPtr DNNEHDJMMBE, int ECOFDINFCIO, out MKEBEFLDFDO DOCDFKGDIIK, out EHHMBKOJMBH GBBKJAGKLBM);

		// Token: 0x06000BE5 RID: 3045
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestUserAgentInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OFCJAHIFAMC(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, MBLFNIBGODG.LJANJDBDBJI HBAGLLHPFIE);

		// Token: 0x06000BE6 RID: 3046
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyMemberLimit")]
		public static extern int FKEIOOBMHNB(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK);

		// Token: 0x06000BE7 RID: 3047
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_SetIPv4")]
		public static extern void JHAFFOONECI(ref SteamNetworkingIPAddr DPAHMPHNPMK, uint LGNJMHPGCFK, ushort MLHPDILCKGP);

		// Token: 0x06000BE8 RID: 3048
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemUpdateLanguage")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MNCKPBIEHGM(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI LBEEKAMNEML);

		// Token: 0x06000BE9 RID: 3049
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_StopLoad")]
		public static extern void JOALDHMCEHA(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD);

		// Token: 0x06000BEA RID: 3050
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_SetVolume")]
		public static extern void DHGDFIHLOBB(IntPtr DNNEHDJMMBE, float GJCGCKKJJKK);

		// Token: 0x06000BEB RID: 3051
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendPersonaState")]
		public static extern KPICCGBIAOC EKMKAHPMJEB(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE);

		// Token: 0x06000BEC RID: 3052
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamHTMLSurface")]
		public static extern IntPtr AJDAIOOFOIN(IntPtr DNNEHDJMMBE, HSteamUser MPMPFFFHHLH, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000BED RID: 3053
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UGCDownload")]
		public static extern ulong LLAEICJMJJH(IntPtr DNNEHDJMMBE, UGCHandle_t DNBPDFIIBHN, uint AOMKGBLMINK);

		// Token: 0x06000BEE RID: 3054
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_RequestEligiblePromoItemDefinitionsIDs")]
		public static extern ulong FJEEJGKNEPH(IntPtr DNNEHDJMMBE, CSteamID EKCOJJGHNAN);

		// Token: 0x06000BEF RID: 3055
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_BUpdateUserData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PKENFBGEJLK(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI KLHPKBBACND, uint ELMCIDDJEJM);

		// Token: 0x06000BF0 RID: 3056
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_IsLocalHost")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LPPFGPMNIHA(ref SteamNetworkingIdentity DPAHMPHNPMK);

		// Token: 0x06000BF1 RID: 3057
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_IsEqualTo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OKOPENOKKJL(ref SteamNetworkingIdentity DPAHMPHNPMK, ref SteamNetworkingIdentity OBNBCGOIMKE);

		// Token: 0x06000BF2 RID: 3058
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SerializeResult")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PEGAPJFLOKA(IntPtr DNNEHDJMMBE, SteamInventoryResult_t PDIGNGHLDII, byte[] OPJNJDBGCHL, out uint NPKCNEHBJJC);

		// Token: 0x06000BF3 RID: 3059
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStatInt64")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PMLBMGBMNKM(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI FMEDOEGOAPD, out long EENCENODOOG);

		// Token: 0x06000BF4 RID: 3060
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_DeletePublishedFile")]
		public static extern ulong KDIKPFIKHFB(IntPtr DNNEHDJMMBE, PublishedFileId_t JPCGPJHIMMP);

		// Token: 0x06000BF5 RID: 3061
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SteamNetworkingIdentity_ToString")]
		public static extern void DHNEBMOLMOC(IntPtr DNNEHDJMMBE, ref SteamNetworkingIdentity BPKPFNGKEDO, IntPtr CFHBIAJPGMC, uint FGHMOMPAOFF);

		// Token: 0x06000BF6 RID: 3062
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetSteamID")]
		public static extern ulong FLFJCNBGMOO(IntPtr DNNEHDJMMBE);

		// Token: 0x06000BF7 RID: 3063
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCAdditionalPreview")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KKILPEKJNOE(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint GGICIBLJIKI, uint NCOLPIGABEC, IntPtr CLPELHODMJO, uint OLJLBBCHGPK, IntPtr CDJBBKDCKOJ, uint CDOFPJJHPHG, out AEEIMFAGCJP NBAALAMNLMI);

		// Token: 0x06000BF8 RID: 3064
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileDescription")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OKIEFHBOHBJ(IntPtr DNNEHDJMMBE, PublishedFileUpdateHandle_t OGPKKNDEDFI, MBLFNIBGODG.LJANJDBDBJI IBFLDFKEAON);

		// Token: 0x06000BF9 RID: 3065
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_RetrieveData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IKNIAKEDCEF(IntPtr DNNEHDJMMBE, SNetListenSocket_t ODPEHFBKGIP, byte[] LJANICMPHHI, uint KPHGENMNKJO, out uint KNKBMPIDGDN, out SNetSocket_t NEDPBLFHBLK);

		// Token: 0x06000BFA RID: 3066
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementName")]
		public static extern IntPtr GJJCNPEMNOB(IntPtr DNNEHDJMMBE, uint OEOIIAOBLCL);

		// Token: 0x06000BFB RID: 3067
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_RetrieveDataFromSocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IAGACKHCBPI(IntPtr DNNEHDJMMBE, SNetSocket_t MEBHGGLPOGA, byte[] LJANICMPHHI, uint KPHGENMNKJO, out uint KNKBMPIDGDN);

		// Token: 0x06000BFC RID: 3068
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_MarkContentCorrupt")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OCACLJEHALF(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool FELNCPAAFCI);

		// Token: 0x06000BFD RID: 3069
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetCookie")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DPMMCGLJDJN(IntPtr DNNEHDJMMBE, HTTPCookieContainerHandle KCODEGFCIHE, MBLFNIBGODG.LJANJDBDBJI JDGNEKIIKKK, MBLFNIBGODG.LJANJDBDBJI CJPNOBAIKHF, MBLFNIBGODG.LJANJDBDBJI OIOHGFBHOMA);

		// Token: 0x06000BFE RID: 3070
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneVerified")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ABALBFJCPMM(IntPtr DNNEHDJMMBE);

		// Token: 0x06000BFF RID: 3071
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendPersonaNameHistory")]
		public static extern IntPtr BGPPCMMEECP(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE, int LKBNOMDJLLG);

		// Token: 0x06000C00 RID: 3072
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingConnectionSignaling_Release")]
		public static extern void EFAFPMDNALI(ref ISteamNetworkingConnectionSignaling DPAHMPHNPMK);

		// Token: 0x06000C01 RID: 3073
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingConnectionSignaling_SendSignal")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ODFKCKCNJCO(ref ISteamNetworkingConnectionSignaling DPAHMPHNPMK, HSteamNetConnection KLJAKJFEEIC, ref HLANBPHOFND OHCDFPLACOP, IntPtr MFIJCBDPKMP, int DONIGFFDKIF);

		// Token: 0x06000C02 RID: 3074
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParties_GetNumActiveBeacons")]
		public static extern uint CGKGOABKCFK(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C03 RID: 3075
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestRawPostBody")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ADICAJMLLDI(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, MBLFNIBGODG.LJANJDBDBJI ADPMAMCNFCP, byte[] CFPNGKLAGJK, uint GDJOGLGELNF);

		// Token: 0x06000C04 RID: 3076
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetConfigValue")]
		public static extern ICELMIPCIKJ HEGODEOONKL(IntPtr DNNEHDJMMBE, JHEBPHGLLMK BJEDEGNPCHB, ENAHGAAGOIF MFPNDHABCAL, IntPtr GICOGGMEKOE, out AIGCOFEJAIF LHMAIDKBAOJ, IntPtr PHLNIJEJJGO, ref ulong FPABOGIMEKK);

		// Token: 0x06000C05 RID: 3077
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnChildren")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ABEJGEBMPEB(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, [MarshalAs(UnmanagedType.I1)] bool OBKOJBIDECK);

		// Token: 0x06000C06 RID: 3078
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetAdvertiseServerActive")]
		public static extern void MCJEPGIKFNM(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool FIMIOHCACNK);

		// Token: 0x06000C07 RID: 3079
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetEncryptedAppTicket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GKGNAFIKLMG(IntPtr DNNEHDJMMBE, byte[] EOJICCJIPLO, int CBLNENJMGIE, out uint EJDEKGHCOLF);

		// Token: 0x06000C08 RID: 3080
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable")]
		public static extern void BCLJEGCLPIK(IntPtr DNNEHDJMMBE, int NGPFFNPLGNM);

		// Token: 0x06000C09 RID: 3081
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileCount")]
		public static extern int ACIFCOGPKIM(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C0A RID: 3082
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsSteamInBigPictureMode")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DGDLOJHHDAA(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C0B RID: 3083
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_PlayPrevious")]
		public static extern void IPBCBIDPAHG(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C0C RID: 3084
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribedFromFreeWeekend")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KCJBNBKHEDN(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C0D RID: 3085
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyByIndex")]
		public static extern ulong CLLGAONBLGN(IntPtr DNNEHDJMMBE, int CBCICJLMEAJ);

		// Token: 0x06000C0E RID: 3086
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_UpdateAvgRateStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ABAEPAJOEGP(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, float JDDODCEOJGI, double AGKILKOHHDH);

		// Token: 0x06000C0F RID: 3087
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnablePlaylists")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GOAOCHFLKAB(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool OFLAMEMDFGK);

		// Token: 0x06000C10 RID: 3088
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_EnumerateFollowingList")]
		public static extern ulong HPAOJFDDFPE(IntPtr DNNEHDJMMBE, uint CMKIMAENFKO);

		// Token: 0x06000C11 RID: 3089
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetCurrentGameLanguage")]
		public static extern IntPtr PPDNKMGMOFO(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C12 RID: 3090
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_InitRelayNetworkAccess")]
		public static extern void BNIFABAHGMG(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C13 RID: 3091
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileExists")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LIIIEFPBOEO(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ);

		// Token: 0x06000C14 RID: 3092
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetUserItemVote")]
		public static extern ulong BBNCPGBJOMH(IntPtr DNNEHDJMMBE, PublishedFileId_t GGEBDPEOMDI, [MarshalAs(UnmanagedType.I1)] bool CGCLBGAFDHI);

		// Token: 0x06000C15 RID: 3093
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SteamNetworkingIPAddr_ParseString")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DBFILNBBGAK(IntPtr DNNEHDJMMBE, out SteamNetworkingIPAddr EJALCABGADI, MBLFNIBGODG.LJANJDBDBJI OBJAIHPGOJN);

		// Token: 0x06000C16 RID: 3094
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddRequiredTagGroup")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CNPDAKOBEIO(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, IntPtr HJPMKDMPNML);

		// Token: 0x06000C17 RID: 3095
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementProgressLimitsInt32")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NFKOJLIONJF(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out int HMIIIFKPPOH, out int LGGONGEHABF);

		// Token: 0x06000C18 RID: 3096
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetVoice")]
		public static extern PHFILJEGLIL ALNOCMCCLMD(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool OMINPGIMIDL, byte[] CKNAPJEBFMJ, uint NCJNENKJBMH, out uint NLMHENOBHLM, [MarshalAs(UnmanagedType.I1)] bool NKLMAOCLIDG, IntPtr INNIHJFNKCP, uint DINHBIOFHPF, IntPtr FKHMKLOCPCN, uint JCANHPLIPHH);

		// Token: 0x06000C19 RID: 3097
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetGameTags")]
		public static extern void FGPJONIIGBE(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI OOKOPFLNIOE);

		// Token: 0x06000C1A RID: 3098
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GMFKNLEOBBE(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint GGICIBLJIKI, uint JDIFEODBGFE, IntPtr OIABIHIJPJN, uint BJPOEIBIELI);

		// Token: 0x06000C1B RID: 3099
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SendItemDropHeartbeat")]
		public static extern void NLHBDABJIPL(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C1C RID: 3100
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetDigitalActionData")]
		public static extern AFIFGIEEBFC HMEHHJACKMP(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, InputDigitalActionHandle_t DKOKEGDKMNP);

		// Token: 0x06000C1D RID: 3101
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetUserItemVote")]
		public static extern ulong OHCHOMLDBHM(IntPtr DNNEHDJMMBE, PublishedFileId_t GGEBDPEOMDI);

		// Token: 0x06000C1E RID: 3102
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamMusic")]
		public static extern IntPtr GFFBJOKCDGG(IntPtr DNNEHDJMMBE, HSteamUser MPMPFFFHHLH, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000C1F RID: 3103
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetLaunchQueryParam")]
		public static extern IntPtr KGDFNKJMJDL(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE);

		// Token: 0x06000C20 RID: 3104
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListResultCountFilter")]
		public static extern void CPMHELCCIED(IntPtr DNNEHDJMMBE, int LNEBNCOJBJL);

		// Token: 0x06000C21 RID: 3105
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BSetDurationControlOnlineState")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IGFFJHJDEEA(IntPtr DNNEHDJMMBE, EELMHLHPMPM FLEHEGNPDEM);

		// Token: 0x06000C22 RID: 3106
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SendHTTPRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FDFOHAPHNAB(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, out SteamAPICall_t JNCOLEIILBD);

		// Token: 0x06000C23 RID: 3107
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanChatMessage")]
		public static extern int DHFKMGPLDDE(IntPtr DNNEHDJMMBE, CSteamID IEMJIPDDFAF, int MKMKGLKBDAD, IntPtr LLICGALBBBI, int GODPEJAKIKJ, out JAHKIBJGEDE PABOKFFKIMJ, out CSteamID ABPFFLBBCFF);

		// Token: 0x06000C24 RID: 3108
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParties_CancelReservation")]
		public static extern void IHBFGCNGNOH(IntPtr DNNEHDJMMBE, PartyBeaconID_t NIJLJHGMCHD, CSteamID AIIMBIAIIJE);

		// Token: 0x06000C25 RID: 3109
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_WriteMiniDump")]
		public static extern void NEMMHDDHCHC(uint KBPAGIJMGDK, IntPtr BPNPBMOEJHB, uint OFFOLGJPJIP);

		// Token: 0x06000C26 RID: 3110
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryUserUGCRequest")]
		public static extern ulong KIAOLAHCIDO(IntPtr DNNEHDJMMBE, AccountID_t FBJBNIJOFGP, KJCBNEEICKO JHKKOJOMDOE, GGBFGPNFANI DJFAPBONDCC, FBECHDMCFHK LNFPFKDEBCJ, AppId_t HPKODIICKAI, AppId_t FELDDNEJJND, uint GMGLDEBLDNK);

		// Token: 0x06000C27 RID: 3111
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_JoinClanChatRoom")]
		public static extern ulong EOIGAIIAFBN(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI);

		// Token: 0x06000C28 RID: 3112
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_AddPromoItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ICJCIHOFLBF(IntPtr DNNEHDJMMBE, out SteamInventoryResult_t DONIEBGGKMH, [In] [Out] SteamItemDef_t[] HPIHEINFIEO, uint OIPDLADCLOC);

		// Token: 0x06000C29 RID: 3113
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_JoinLobby")]
		public static extern ulong CHGANIPJHBF(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK);

		// Token: 0x06000C2A RID: 3114
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetXboxPairwiseID")]
		public static extern IntPtr PEOLJIHGLMP(ref SteamNetworkingIdentity DPAHMPHNPMK);

		// Token: 0x06000C2B RID: 3115
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetPlaylistEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KALCPJKOACA(IntPtr DNNEHDJMMBE, int HBNODOOKPKG, int KFLNLPAIBKH, MBLFNIBGODG.LJANJDBDBJI KGKLDKEDBIM);

		// Token: 0x06000C2C RID: 3116
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UnsubscribePublishedFile")]
		public static extern ulong MGOEAAALMLL(IntPtr DNNEHDJMMBE, PublishedFileId_t JPCGPJHIMMP);

		// Token: 0x06000C2D RID: 3117
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CloseListenSocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LNBEHKGLCOB(IntPtr DNNEHDJMMBE, HSteamListenSocket MEBHGGLPOGA);

		// Token: 0x06000C2E RID: 3118
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_UninstallDLC")]
		public static extern void BLBFCONKIFA(IntPtr DNNEHDJMMBE, AppId_t MINMIFBPLGA);

		// Token: 0x06000C2F RID: 3119
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetMaxPacketSize")]
		public static extern int OBJOHMFKFBL(IntPtr DNNEHDJMMBE, SNetSocket_t MEBHGGLPOGA);

		// Token: 0x06000C30 RID: 3120
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveItemPreview")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AENCIDFIFED(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, uint GGICIBLJIKI);

		// Token: 0x06000C31 RID: 3121
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamFriends")]
		public static extern IntPtr GKKCFHEBENK(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000C32 RID: 3122
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetNextMostAchievedAchievementInfo")]
		public static extern int CKOHNMKFMCH(IntPtr DNNEHDJMMBE, int DIDOKPGBHHB, IntPtr DECMMMNKHKM, uint JLFBFLAIGJD, out float CJPPICBGGJJ, out bool LAEOHDNHABG);

		// Token: 0x06000C33 RID: 3123
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetRankedByTrendDays")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FDDHGEAKDCL(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint HOGEIIFKLAL);

		// Token: 0x06000C34 RID: 3124
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EndFileWriteBatch")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NNEAJIKFCJD(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C35 RID: 3125
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupMembersList")]
		public static extern void GPCKPGKPHHH(IntPtr DNNEHDJMMBE, FriendsGroupID_t NKGLGJEPBBC, [In] [Out] CSteamID[] FDNJACKLJJE, int LGAJGOJGFDL);

		// Token: 0x06000C36 RID: 3126
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamVideo_GetVideoURL")]
		public static extern void PFNALAAMNMB(IntPtr DNNEHDJMMBE, AppId_t OAEOLFEOPLA);

		// Token: 0x06000C37 RID: 3127
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetActiveActionSetLayers")]
		public static extern int GNFGMBMAFPK(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, [In] [Out] InputActionSetHandle_t[] HKKMNPGFODA);

		// Token: 0x06000C38 RID: 3128
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_KeyDown")]
		public static extern void DDHOEOLIPIH(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, uint HDHJKLHPEPI, ALLPEMGCAMA PLJNDMGBDIP, [MarshalAs(UnmanagedType.I1)] bool JEPBCAFGJLG);

		// Token: 0x06000C39 RID: 3129
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter")]
		public static extern void KNFCGANANEB(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK);

		// Token: 0x06000C3A RID: 3130
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserStatInt32")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ONPIELHJALG(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, int EEJHBDOCDLB);

		// Token: 0x06000C3B RID: 3131
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetDLCCount")]
		public static extern int JLNDLFNMENE(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C3C RID: 3132
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ResetIdentity")]
		public static extern void KIECJHFABDF(IntPtr DNNEHDJMMBE, ref SteamNetworkingIdentity JDOLBOKDBLA);

		// Token: 0x06000C3D RID: 3133
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetP2PSessionState")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GFEFLDJHLEJ(IntPtr DNNEHDJMMBE, CSteamID KHBNBCJABCI, out BDMPKENOBEI CGGJOHDDHID);

		// Token: 0x06000C3E RID: 3134
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListNearValueFilter")]
		public static extern void FHMPMIIPLOL(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI FGNGIMIEEAA, int BMAODHGBGBC);

		// Token: 0x06000C3F RID: 3135
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetServerName")]
		public static extern void HMKLMCLBBED(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI OGPIAFOHLGF);

		// Token: 0x06000C40 RID: 3136
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_UpdateUserAvgRateStat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PFGJJJNHMJL(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, float JDDODCEOJGI, double AGKILKOHHDH);

		// Token: 0x06000C41 RID: 3137
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetSocketInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KEPDNCPBBHG(IntPtr DNNEHDJMMBE, SNetSocket_t MEBHGGLPOGA, out CSteamID FJEIBKMENGM, out int OJALLCKABFF, out SteamIPAddress_t LJLNKEDPNKF, out ushort BLJNIAGPCNH);

		// Token: 0x06000C42 RID: 3138
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParties_DestroyBeacon")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GCCFGLENCLM(IntPtr DNNEHDJMMBE, PartyBeaconID_t NIJLJHGMCHD);

		// Token: 0x06000C43 RID: 3139
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamRemotePlay")]
		public static extern IntPtr BGJLACLJPNO(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000C44 RID: 3140
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListDistanceFilter")]
		public static extern void AHDFLLAEOCG(IntPtr DNNEHDJMMBE, AAKBLMDKPJN HHNCOEBFDOI);

		// Token: 0x06000C45 RID: 3141
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetHorizontalScroll")]
		public static extern void FFKPLMHGNLA(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, uint MPCNJDLELIC);

		// Token: 0x06000C46 RID: 3142
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetPlayerSteamLevel")]
		public static extern int GNKABBFKNKO(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C47 RID: 3143
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_FilterText")]
		public static extern int MHKGMCDNLLO(IntPtr DNNEHDJMMBE, OHPEHCOGCGB LODHKIEKDLL, CSteamID AKLMDHOHBFJ, MBLFNIBGODG.LJANJDBDBJI DFFJDDCCPMC, IntPtr FFDKPKEFCGO, uint KOJLCMFPAEI);

		// Token: 0x06000C48 RID: 3144
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_AllowStartRequest")]
		public static extern void MBBFAOFIHBK(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, [MarshalAs(UnmanagedType.I1)] bool MDDGMHBEGMH);

		// Token: 0x06000C49 RID: 3145
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_RequestUserInformation")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FJJBOHFOEOO(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, [MarshalAs(UnmanagedType.I1)] bool GGCDJDDAMBN);

		// Token: 0x06000C4A RID: 3146
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetHostedDedicatedServerPOPID")]
		public static extern uint NMGFDDINDKM(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C4B RID: 3147
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParties_GetNumAvailableBeaconLocations")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IADAIIMAPCN(IntPtr DNNEHDJMMBE, out uint AGCGBOEMHAG);

		// Token: 0x06000C4C RID: 3148
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamGameServer_BSecure")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool COABEHKADOC();

		// Token: 0x06000C4D RID: 3149
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetIPv6ConnectivityState")]
		public static extern LFNOPJFDEPH IJBANFADFBL(IntPtr DNNEHDJMMBE, AKMCIPJLMDM PDGMJBNBBGL);

		// Token: 0x06000C4E RID: 3150
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_BLoggedOn")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LJCCOLJANDA(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C4F RID: 3151
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetKeyValue")]
		public static extern void FPOBPINMOBM(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI LCGHPLHNHCD, MBLFNIBGODG.LJANJDBDBJI PIBJFEJAJDH);

		// Token: 0x06000C50 RID: 3152
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyData")]
		public static extern IntPtr ICNFFFINHFD(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE);

		// Token: 0x06000C51 RID: 3153
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddFavoriteGame")]
		public static extern int DFBNLKBPKMA(IntPtr DNNEHDJMMBE, AppId_t MINMIFBPLGA, uint LGNJMHPGCFK, ushort OBEPOKKJFCE, ushort DEANMIHCILI, uint JLKHOFPHIEK, uint BHOCBJPNGCH);

		// Token: 0x06000C52 RID: 3154
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_EstimatePingTimeFromLocalHost")]
		public static extern int CJPJKDDIOEN(IntPtr DNNEHDJMMBE, ref FJNHNDBKGFH BBHKAOGPPGG);

		// Token: 0x06000C53 RID: 3155
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestGetOrPostParameter")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JDACNHCCPEC(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, MBLFNIBGODG.LJANJDBDBJI BPKILMDFIKC, MBLFNIBGODG.LJANJDBDBJI EOPOJPHAOIO);

		// Token: 0x06000C54 RID: 3156
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateVolume")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JAPIAKDFNLP(IntPtr DNNEHDJMMBE, float DCGJPJIACHO);

		// Token: 0x06000C55 RID: 3157
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardName")]
		public static extern IntPtr PDEDMGLCBIC(IntPtr DNNEHDJMMBE, SteamLeaderboard_t KFLCGDMDANA);

		// Token: 0x06000C56 RID: 3158
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileForget")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NIADPIOFENF(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ);

		// Token: 0x06000C57 RID: 3159
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnKeyValueTags")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IEDJHKBPNOE(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, [MarshalAs(UnmanagedType.I1)] bool PBBEFKDOGLB);

		// Token: 0x06000C58 RID: 3160
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_BNewDataAvailable")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CALMCJGELFN(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C59 RID: 3161
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendByIndex")]
		public static extern ulong JKLMHGAEMGA(IntPtr DNNEHDJMMBE, int OEAAFODCAHN, PKIJCNBOGAH HMMINHBNAFA);

		// Token: 0x06000C5A RID: 3162
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_RemoveFavoriteGame")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AOPFDKBFDHG(IntPtr DNNEHDJMMBE, AppId_t MINMIFBPLGA, uint LGNJMHPGCFK, ushort OBEPOKKJFCE, ushort DEANMIHCILI, uint JLKHOFPHIEK);

		// Token: 0x06000C5B RID: 3163
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_StartPlaytimeTracking")]
		public static extern ulong OOJLHHHMCFA(IntPtr DNNEHDJMMBE, [In] [Out] PublishedFileId_t[] LMJGFJPENLP, uint GEALEAJEMDJ);

		// Token: 0x06000C5C RID: 3164
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetDeviceBindingRevision")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LANLMBBAOBG(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, out int DLDJPDEHAMF, out int MNLEOABDGCJ);

		// Token: 0x06000C5D RID: 3165
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_Shutdown")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JDLOPGOIMJB(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C5E RID: 3166
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveAllItemKeyValueTags")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BFGNCDLMDJD(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF);

		// Token: 0x06000C5F RID: 3167
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GHJGCIECGAI(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, [MarshalAs(UnmanagedType.I1)] bool NKIJAGDJMEP);

		// Token: 0x06000C60 RID: 3168
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetActionSetHandle")]
		public static extern ulong DMLDMILGAFB(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI IKNPPHIPOCF);

		// Token: 0x06000C61 RID: 3169
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_DeactivateActionSetLayer")]
		public static extern void LDBNKPJCMEJ(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, InputActionSetHandle_t PKGPLBJAJHI);

		// Token: 0x06000C62 RID: 3170
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamVideo")]
		public static extern IntPtr FMCFGLCMEOC(IntPtr DNNEHDJMMBE, HSteamUser MPMPFFFHHLH, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000C63 RID: 3171
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetGlyphForActionOrigin_Legacy")]
		public static extern IntPtr NCPCGLABCCP(IntPtr DNNEHDJMMBE, FMPMIBBOIAM HAEIMJBBKOH);

		// Token: 0x06000C64 RID: 3172
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_RequestCurrentStats")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KAFJGJGPIMC(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C65 RID: 3173
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamInternal_FindOrCreateGameServerInterface")]
		public static extern IntPtr CIOEELDKKDI(HSteamUser OOFCLIELINA, MBLFNIBGODG.LJANJDBDBJI ICLMGNNBPJG);

		// Token: 0x06000C66 RID: 3174
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_KeyChar")]
		public static extern void HLCKBDEALNC(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, uint CIHDAJIFBLN, ALLPEMGCAMA PLJNDMGBDIP);

		// Token: 0x06000C67 RID: 3175
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetAnalogActionHandle")]
		public static extern ulong KCHBOLLBIOI(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI JAHGEMECDOA);

		// Token: 0x06000C68 RID: 3176
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetPersonaName")]
		public static extern ulong HLPPHJFHMPK(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI GGIBMMEBCDG);

		// Token: 0x06000C69 RID: 3177
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_SetOverlayNotificationPosition")]
		public static extern void KKAFKEMJBDH(IntPtr DNNEHDJMMBE, IICBECGEDBA FJBMDHFJGAH);

		// Token: 0x06000C6A RID: 3178
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_AddScreenshotToLibrary")]
		public static extern uint FCFKMJKMACH(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI JBEGMFMOAPK, MBLFNIBGODG.LJANJDBDBJI AEMCINJJDHN, int FMGAFHBLOAJ, int HEIJKMFOAPM);

		// Token: 0x06000C6B RID: 3179
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_StoreUserStats")]
		public static extern ulong JLLJBNLHGJP(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE);

		// Token: 0x06000C6C RID: 3180
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_PlaylistDidChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CNNLAEFLCDH(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C6D RID: 3181
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_InitiateGameConnection_DEPRECATED")]
		public static extern int HCFJCJGGMIH(IntPtr DNNEHDJMMBE, byte[] MDNEGBACKLD, int FDBOMBLLAEB, CSteamID NPGPIHJKJKL, uint KBEGLOAIKDH, ushort FEODOCNHGBA, [MarshalAs(UnmanagedType.I1)] bool LEJAMHICGHI);

		// Token: 0x06000C6E RID: 3182
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_LoadItemDefinitions")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DFODHAMBFGC(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C6F RID: 3183
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyDataByIndex")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JFJPKOELELE(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, int NKPHMHFCGDG, IntPtr ILEEIANOGJE, int HFGMNHMJFBG, IntPtr OIABIHIJPJN, int CKFEJPMEKHD);

		// Token: 0x06000C70 RID: 3184
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_FindOrCreateLeaderboard")]
		public static extern ulong OFKCJDBGFOL(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI IEKKCEPPKFA, FACAHAKJMLA ENADNICEKME, ACIMDHIJCKD AFEBGNGOIHE);

		// Token: 0x06000C71 RID: 3185
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_DeserializeResult")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AHCHCMEFJEL(IntPtr DNNEHDJMMBE, out SteamInventoryResult_t LBHCNJGDJGJ, byte[] GCJJKAOLLFG, uint NJILDPDADEM, [MarshalAs(UnmanagedType.I1)] bool MFEJNALGBAI);

		// Token: 0x06000C72 RID: 3186
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_DestroySocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NNAADDFOJDH(IntPtr DNNEHDJMMBE, SNetSocket_t MEBHGGLPOGA, [MarshalAs(UnmanagedType.I1)] bool KEDKAMODOCN);

		// Token: 0x06000C73 RID: 3187
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumeratePublishedWorkshopFiles")]
		public static extern ulong DGNEMFIODIM(IntPtr DNNEHDJMMBE, BFCLOEMIGMI EAKLMOBMGKP, uint CMKIMAENFKO, uint CNAMDEPONKJ, uint HOGEIIFKLAL, IntPtr ICGNMKEHAGF, IntPtr LNOLBEDMCOJ);

		// Token: 0x06000C74 RID: 3188
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParties_ChangeNumOpenSlots")]
		public static extern ulong AGNJPCBDDDE(IntPtr DNNEHDJMMBE, PartyBeaconID_t NIJLJHGMCHD, uint HCIHFDNJCMC);

		// Token: 0x06000C75 RID: 3189
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementAchievedPercent")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FGFNFDOHHEH(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out float CJPPICBGGJJ);

		// Token: 0x06000C76 RID: 3190
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetDedicatedServer")]
		public static extern void PPNPHPKAGIM(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool JKPBDEFINIH);

		// Token: 0x06000C77 RID: 3191
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetAppBuildId")]
		public static extern int POGAGJECFJJ(IntPtr DNNEHDJMMBE, AppId_t MINMIFBPLGA);

		// Token: 0x06000C78 RID: 3192
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestSpectatorServerList")]
		public static extern IntPtr BBKENDGOHPP(IntPtr DNNEHDJMMBE, AppId_t GDIHJPFCLKN, IntPtr GAFCEHKPODN, uint ODAKHIGHAHO, IntPtr POEEGAJBLKJ);

		// Token: 0x06000C79 RID: 3193
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_StartUpdateProperties")]
		public static extern ulong FPKPHFICMOO(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C7A RID: 3194
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamVideo_GetOPFStringForApp")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CFPOIKEGBMD(IntPtr DNNEHDJMMBE, AppId_t OAEOLFEOPLA, IntPtr BMBAOHEBHDL, ref int GJAEKMLBCKD);

		// Token: 0x06000C7B RID: 3195
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsSteamChinaLauncher")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MPJPLHKAJGM(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C7C RID: 3196
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetSubscribedItems")]
		public static extern uint NJLDIGHCMME(IntPtr DNNEHDJMMBE, [In] [Out] PublishedFileId_t[] LMJGFJPENLP, uint EGPNNKCJHFJ);

		// Token: 0x06000C7D RID: 3197
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_GetTicketAppID")]
		public static extern uint BHBNCAMBJLN([In] [Out] byte[] OJNJHJOIJDG, uint HADHJKAMIBG);

		// Token: 0x06000C7E RID: 3198
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_TerminateGameConnection_DEPRECATED")]
		public static extern void HFBJPKGHEGJ(IntPtr DNNEHDJMMBE, uint KBEGLOAIKDH, ushort FEODOCNHGBA);

		// Token: 0x06000C7F RID: 3199
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_Pause")]
		public static extern void DKJDHPOGMCD(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C80 RID: 3200
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddRequiredKeyValueTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NDDGDLGKFEJ(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI LCGHPLHNHCD, MBLFNIBGODG.LJANJDBDBJI PIBJFEJAJDH);

		// Token: 0x06000C81 RID: 3201
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveDependency")]
		public static extern ulong MBNECFJCKIE(IntPtr DNNEHDJMMBE, PublishedFileId_t HACFFCALOKJ, PublishedFileId_t ANCFJDCJOKG);

		// Token: 0x06000C82 RID: 3202
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListNumericalFilter")]
		public static extern void AGGEOJMIHJC(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI FGNGIMIEEAA, int JDPBLAKLOEJ, FGMHAMAEGFJ PFAINDBEANH);

		// Token: 0x06000C83 RID: 3203
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_ToString")]
		public static extern void FBIAKMDLJLL(ref SteamNetworkingIdentity DPAHMPHNPMK, IntPtr CFHBIAJPGMC, uint FGHMOMPAOFF);

		// Token: 0x06000C84 RID: 3204
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_SetInputActionManifestFilePath")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FEKLNMEHAPJ(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DBBADCPEGMD);

		// Token: 0x06000C85 RID: 3205
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamHTTP")]
		public static extern IntPtr LAGDHALMGNN(IntPtr DNNEHDJMMBE, HSteamUser MPMPFFFHHLH, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000C86 RID: 3206
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCountFromSource")]
		public static extern int OCELMLNJGPA(IntPtr DNNEHDJMMBE, CSteamID DAHMOBOFOFB);

		// Token: 0x06000C87 RID: 3207
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardSortMethod")]
		public static extern FACAHAKJMLA BBFDCBEGCPK(IntPtr DNNEHDJMMBE, SteamLeaderboard_t KFLCGDMDANA);

		// Token: 0x06000C88 RID: 3208
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestNetworkActivityTimeout")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IGHMICLIFBB(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, uint HEPNHAOJHND);

		// Token: 0x06000C89 RID: 3209
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetRichPresence")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DOEMIEFICBL(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE, MBLFNIBGODG.LJANJDBDBJI OIABIHIJPJN);

		// Token: 0x06000C8A RID: 3210
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetNumChatsWithUnreadPriorityMessages")]
		public static extern int OLFKGLMEMAF(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C8B RID: 3211
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamMatchmakingServers")]
		public static extern IntPtr PAFINADLNBP(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000C8C RID: 3212
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetDlcDownloadProgress")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JPOIBNEEKEF(IntPtr DNNEHDJMMBE, AppId_t MINMIFBPLGA, out ulong CPEIDJEGJBL, out ulong GGIOPEJJECD);

		// Token: 0x06000C8D RID: 3213
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetDigitalActionHandle")]
		public static extern ulong MJHPHEMHKPO(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI JAHGEMECDOA);

		// Token: 0x06000C8E RID: 3214
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_StopFind")]
		public static extern void DDDMMAFIIFA(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD);

		// Token: 0x06000C8F RID: 3215
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateShuffled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CKKAIHJIKKI(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool OFLAMEMDFGK);

		// Token: 0x06000C90 RID: 3216
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_ToString")]
		public static extern void FDKOPMOINEB(ref SteamNetworkingIPAddr DPAHMPHNPMK, IntPtr CFHBIAJPGMC, uint FGHMOMPAOFF, [MarshalAs(UnmanagedType.I1)] bool JMJACPGFCGP);

		// Token: 0x06000C91 RID: 3217
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetResultItemProperty")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HDEHFDIADFE(IntPtr DNNEHDJMMBE, SteamInventoryResult_t PDIGNGHLDII, uint AFKILBGMEEC, MBLFNIBGODG.LJANJDBDBJI AGIKLDMPJPE, IntPtr IEMHFECBNOD, ref uint JPIJOPFKOJO);

		// Token: 0x06000C92 RID: 3218
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParties_JoinParty")]
		public static extern ulong NFJPGNALIPF(IntPtr DNNEHDJMMBE, PartyBeaconID_t EDBIODFMAON);

		// Token: 0x06000C93 RID: 3219
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_IsCloudEnabledForApp")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DJDKBPLOAOC(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C94 RID: 3220
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_DestroyListenSocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IIEHKDFFIKG(IntPtr DNNEHDJMMBE, SNetListenSocket_t MEBHGGLPOGA, [MarshalAs(UnmanagedType.I1)] bool KEDKAMODOCN);

		// Token: 0x06000C95 RID: 3221
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupName")]
		public static extern IntPtr EMLFPNHDFED(IntPtr DNNEHDJMMBE, FriendsGroupID_t NKGLGJEPBBC);

		// Token: 0x06000C96 RID: 3222
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendPersonaName")]
		public static extern IntPtr IHCEDJGNPFM(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE);

		// Token: 0x06000C97 RID: 3223
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_SetWarningMessageHook")]
		public static extern void BEOOACKBNGL(IntPtr DNNEHDJMMBE, NNMLFJGPMHE CHEGPLOODLB);

		// Token: 0x06000C98 RID: 3224
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetAppDependencies")]
		public static extern ulong BMCEGJEDAFO(IntPtr DNNEHDJMMBE, PublishedFileId_t GGEBDPEOMDI);

		// Token: 0x06000C99 RID: 3225
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_SendDataOnSocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HGEEOIHHLGI(IntPtr DNNEHDJMMBE, SNetSocket_t MEBHGGLPOGA, byte[] IGJCKJIFGEK, uint DNFELHKNIIP, [MarshalAs(UnmanagedType.I1)] bool PFEHIDMBDCF);

		// Token: 0x06000C9A RID: 3226
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreateListenSocketP2P")]
		public static extern uint KCOHFOGBAGD(IntPtr DNNEHDJMMBE, int DFBNIOJELNC, int HHJMCLMABHG, [In] [Out] SteamNetworkingConfigValue_t[] NKNGPCMOHCH);

		// Token: 0x06000C9B RID: 3227
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetImageSize")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IIHOBPJJIHF(IntPtr DNNEHDJMMBE, int HAKFMIIOCKF, out uint FFOIIOMOCBI, out uint OBMGMJAMCOD);

		// Token: 0x06000C9C RID: 3228
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetLocalTimestamp")]
		public static extern long NKHOEAFHEPF(IntPtr DNNEHDJMMBE);

		// Token: 0x06000C9D RID: 3229
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SteamNetworkingIPAddr_ToString")]
		public static extern void DLAHDDEONIH(IntPtr DNNEHDJMMBE, ref SteamNetworkingIPAddr KKFIELAEFFK, IntPtr CFHBIAJPGMC, uint FGHMOMPAOFF, [MarshalAs(UnmanagedType.I1)] bool JMJACPGFCGP);

		// Token: 0x06000C9E RID: 3230
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetStatInt32")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IHLFEHPEAPA(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out int EENCENODOOG);

		// Token: 0x06000C9F RID: 3231
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreateSocketPair")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FNHCHMBMIIF(IntPtr DNNEHDJMMBE, out HSteamNetConnection BJBKHBAMJFN, out HSteamNetConnection DBPHDNMNDIB, [MarshalAs(UnmanagedType.I1)] bool KNLGIJDCJJC, ref SteamNetworkingIdentity IDNODILGPJI, ref SteamNetworkingIdentity FKINKDOHMEL);

		// Token: 0x06000CA0 RID: 3232
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BeginAuthSession")]
		public static extern HOKGCIMJHIK NPOGAMCICOG(IntPtr DNNEHDJMMBE, byte[] BDLODBOOBHK, int IJPDCFDLFFA, CSteamID EKCOJJGHNAN);

		// Token: 0x06000CA1 RID: 3233
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetTimeCreatedDateRange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OOOECBFJFHP(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint BJCBCDACDMM, uint JKPOJHGGCJN);

		// Token: 0x06000CA2 RID: 3234
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsClanChatWindowOpenInSteam")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LNNGDFNAEKM(IntPtr DNNEHDJMMBE, CSteamID IEMJIPDDFAF);

		// Token: 0x06000CA3 RID: 3235
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_GetHSteamPipe")]
		public static extern int IJFIDBHJDJO();

		// Token: 0x06000CA4 RID: 3236
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetFileDetails")]
		public static extern ulong GLLKFKBCLFD(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI AJAEKIAPOLE);

		// Token: 0x06000CA5 RID: 3237
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetConfigValueInfo")]
		public static extern IntPtr BKDGPKBCBMN(IntPtr DNNEHDJMMBE, JHEBPHGLLMK BJEDEGNPCHB, out AIGCOFEJAIF LHMAIDKBAOJ, out ENAHGAAGOIF BMMHCIBGOIE);

		// Token: 0x06000CA6 RID: 3238
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_SetIPv6")]
		public static extern void NCGBNNODMBA(ref SteamNetworkingIPAddr DPAHMPHNPMK, [In] [Out] byte[] HMMDEHPNLOC, ushort MLHPDILCKGP);

		// Token: 0x06000CA7 RID: 3239
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamClient")]
		public static extern IntPtr KIICNLGIIAC();

		// Token: 0x06000CA8 RID: 3240
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_GoBack")]
		public static extern void KDNBCNFJHJH(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD);

		// Token: 0x06000CA9 RID: 3241
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_SetConnectionUserData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FEPPEFDAMKM(IntPtr DNNEHDJMMBE, HSteamNetConnection CHFHNPJJBEH, long IFEKPLCADIC);

		// Token: 0x06000CAA RID: 3242
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetMapName")]
		public static extern void DONGAFEDBLK(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DJMJPAEDCKJ);

		// Token: 0x06000CAB RID: 3243
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetConnectionUserData")]
		public static extern long LPJNOOHNIOJ(IntPtr DNNEHDJMMBE, HSteamNetConnection CHFHNPJJBEH);

		// Token: 0x06000CAC RID: 3244
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFollowerCount")]
		public static extern ulong CEHIFBHOOEE(IntPtr DNNEHDJMMBE, CSteamID EKCOJJGHNAN);

		// Token: 0x06000CAD RID: 3245
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestCookieContainer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ODKBGJCENNG(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, HTTPCookieContainerHandle KCODEGFCIHE);

		// Token: 0x06000CAE RID: 3246
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanOwner")]
		public static extern ulong MBPNJHCDPMM(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI);

		// Token: 0x06000CAF RID: 3247
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCChildren")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MJHCHIICNOF(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint GGICIBLJIKI, [In] [Out] PublishedFileId_t[] LMJGFJPENLP, uint EGPNNKCJHFJ);

		// Token: 0x06000CB0 RID: 3248
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetAnalogActionData")]
		public static extern DBHPFDFKFHC JBIBIADMOON(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, InputAnalogActionHandle_t BOFOOAFFNBN);

		// Token: 0x06000CB1 RID: 3249
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamInternal_CreateInterface")]
		public static extern IntPtr NPHIMOLOODA(MBLFNIBGODG.LJANJDBDBJI MEPIPPJPKGJ);

		// Token: 0x06000CB2 RID: 3250
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetCoplayFriendCount")]
		public static extern int ACNFIALJJNG(IntPtr DNNEHDJMMBE);

		// Token: 0x06000CB3 RID: 3251
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_ClearUserAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FNPLHMBODFJ(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM);

		// Token: 0x06000CB4 RID: 3252
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlay")]
		public static extern void POPOKALHDMM(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI NIKEALKJCND);

		// Token: 0x06000CB5 RID: 3253
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyJoinable")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OGMGAGNABPJ(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, [MarshalAs(UnmanagedType.I1)] bool HJBPHDJJMDJ);

		// Token: 0x06000CB6 RID: 3254
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetListenForFriendsMessages")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OAADELFKCGJ(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool LMEAGMDKKGG);

		// Token: 0x06000CB7 RID: 3255
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RefreshQuery")]
		public static extern void MGIMILJBILN(IntPtr DNNEHDJMMBE, HServerListRequest JMMGPGJONFK);

		// Token: 0x06000CB8 RID: 3256
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetAvailableVoice")]
		public static extern PHFILJEGLIL GODHAHMCLHC(IntPtr DNNEHDJMMBE, out uint ECMIAFCLHBL, IntPtr HILAOBFNIBB, uint JCANHPLIPHH);

		// Token: 0x06000CB9 RID: 3257
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_StartItemUpdate")]
		public static extern ulong DMDJHPJBFEL(IntPtr DNNEHDJMMBE, AppId_t AIFBKIMDCPH, PublishedFileId_t GGEBDPEOMDI);

		// Token: 0x06000CBA RID: 3258
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamInternal_ContextInit")]
		public static extern IntPtr MMJDACHFPBD(IntPtr MDFIAGGIAPL);

		// Token: 0x06000CBB RID: 3259
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetGameData")]
		public static extern void NPDJJKANPMG(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI JEDMFHEHIDE);

		// Token: 0x06000CBC RID: 3260
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_GetTicketSteamID")]
		public static extern void DEDJABKGAGN([In] [Out] byte[] OJNJHJOIJDG, uint HADHJKAMIBG, out CSteamID DFIKLBFHDDB);

		// Token: 0x06000CBD RID: 3261
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_TagUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BIOIGLGLAJP(IntPtr DNNEHDJMMBE, ScreenshotHandle CJNPEFMLHCC, CSteamID EKCOJJGHNAN);

		// Token: 0x06000CBE RID: 3262
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BGetDLCDataByIndex")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KBANDHLMJPD(IntPtr DNNEHDJMMBE, int DNHHNGDFBBK, out AppId_t DMHIKIBKAGP, out bool OPGLNABDHIJ, IntPtr DECMMMNKHKM, int LOANEKLELKE);

		// Token: 0x06000CBF RID: 3263
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_ExchangeItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CDPMAONEOLF(IntPtr DNNEHDJMMBE, out SteamInventoryResult_t DONIEBGGKMH, [In] [Out] SteamItemDef_t[] JACDGOFNFNM, [In] [Out] uint[] HOGOCIDNBBP, uint FAPGDHCGHKP, [In] [Out] SteamItemInstanceID_t[] BBBJFLEFDGM, [In] [Out] uint[] KOCHMHBHOMJ, uint LAFAOGPPGFB);

		// Token: 0x06000CC0 RID: 3264
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_PublishWorkshopFile")]
		public static extern ulong PNBFDLOAPLB(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ, MBLFNIBGODG.LJANJDBDBJI GCBFBPOGCJH, AppId_t AIFBKIMDCPH, MBLFNIBGODG.LJANJDBDBJI OGKPBGKNHGB, MBLFNIBGODG.LJANJDBDBJI IBFLDFKEAON, OAGKEPBKEMA LAGMCOMKMHL, IntPtr ICGNMKEHAGF, CMDODJKKNGO ECAEFLKGAIF);

		// Token: 0x06000CC1 RID: 3265
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BUserOwnsAppInTicket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DLCCMFBCHEO([In] [Out] byte[] OJNJHJOIJDG, uint HADHJKAMIBG, AppId_t MINMIFBPLGA);

		// Token: 0x06000CC2 RID: 3266
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetPublicIP")]
		public static extern SteamIPAddress_t CFPAEBLKKBK(IntPtr DNNEHDJMMBE);

		// Token: 0x06000CC3 RID: 3267
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamGameServer")]
		public static extern IntPtr ENAFJOAFJKM(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000CC4 RID: 3268
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_GetSocketConnectionType")]
		public static extern LHFFDDPHFMO KJBHHDGDBMM(IntPtr DNNEHDJMMBE, SNetSocket_t MEBHGGLPOGA);

		// Token: 0x06000CC5 RID: 3269
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsParentalLockLocked")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IGEAGBBHNNP(IntPtr DNNEHDJMMBE);

		// Token: 0x06000CC6 RID: 3270
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_RequestUserStats")]
		public static extern ulong OCAGHJNHGDA(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE);

		// Token: 0x06000CC7 RID: 3271
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetAppInstallDir")]
		public static extern uint FLFIEGFKFMH(IntPtr DNNEHDJMMBE, AppId_t NCFIHMEHIOE, IntPtr BBPBGIBGOKD, uint LBINOGJPKDA);

		// Token: 0x06000CC8 RID: 3272
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetIPAddr")]
		public static extern IntPtr AKKLLMAJAKF(ref SteamNetworkingIdentity DPAHMPHNPMK, ref SteamNetworkingIPAddr KKFIELAEFFK);

		// Token: 0x06000CC9 RID: 3273
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetMediumFriendAvatar")]
		public static extern int APHPADHIPPJ(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE);

		// Token: 0x06000CCA RID: 3274
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParties_GetBeaconByIndex")]
		public static extern ulong OPIFOCGCAHP(IntPtr DNNEHDJMMBE, uint IHLIGJNMPGC);

		// Token: 0x06000CCB RID: 3275
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsTimedTrial")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JBBFPMKNFKM(IntPtr DNNEHDJMMBE, out uint JFMMGIGLDGJ, out uint HFBHPLGFKIK);

		// Token: 0x06000CCC RID: 3276
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetQuota")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MDDAKJNCDAP(IntPtr DNNEHDJMMBE, out ulong CLCOODAHCCM, out ulong HANPFFPOELL);

		// Token: 0x06000CCD RID: 3277
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ConfigureConnectionLanes")]
		public static extern LNFOAHHPFIH GLDGBKIALMP(IntPtr DNNEHDJMMBE, HSteamNetConnection KLJAKJFEEIC, int OCADDNPJNPF, out int DLBJDBCNFPB, out ushort BJJIJLCCIJI);

		// Token: 0x06000CCE RID: 3278
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_BeginAsyncRequestFakeIP")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LIAMJCGHJAK(IntPtr DNNEHDJMMBE, int NBJPDLKHEEH);

		// Token: 0x06000CCF RID: 3279
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_StopAnalogActionMomentum")]
		public static extern void LPJFAHHKBMP(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, InputAnalogActionHandle_t MMCPCCBPOGG);

		// Token: 0x06000CD0 RID: 3280
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamInput")]
		public static extern IntPtr FDFHHMBJMKH(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000CD1 RID: 3281
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetPasswordProtected")]
		public static extern void DAOAMOBKHCE(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool MIFPBKELLMG);

		// Token: 0x06000CD2 RID: 3282
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetStringForDigitalActionName")]
		public static extern IntPtr NBBFCKMOMOH(IntPtr DNNEHDJMMBE, InputDigitalActionHandle_t JENLGNOHOFO);

		// Token: 0x06000CD3 RID: 3283
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_EndAuthSession")]
		public static extern void OEBKNFADFLO(IntPtr DNNEHDJMMBE, CSteamID EKCOJJGHNAN);

		// Token: 0x06000CD4 RID: 3284
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetServerReputation")]
		public static extern ulong LKEPECECLOA(IntPtr DNNEHDJMMBE);

		// Token: 0x06000CD5 RID: 3285
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FLMMFCALINC(IntPtr DNNEHDJMMBE, int IJGKPMJJNBN);

		// Token: 0x06000CD6 RID: 3286
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_DeleteLobbyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CBCBBGLMLCA(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE);

		// Token: 0x06000CD7 RID: 3287
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayToWebPage")]
		public static extern void DINOLGEOKHG(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI PJICBBBIOCG, BCNFCLJALCI HBNDEGHBBIJ);

		// Token: 0x06000CD8 RID: 3288
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingMessages_CloseSessionWithUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BIFCGABBCJC(IntPtr DNNEHDJMMBE, ref SteamNetworkingIdentity EGNOINEIEFP);

		// Token: 0x06000CD9 RID: 3289
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetSyncPlatforms")]
		public static extern EKHDJPGMBFP CMBPKFHNNHK(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ);

		// Token: 0x06000CDA RID: 3290
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamVideo_IsBroadcasting")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HCOICHGKLOI(IntPtr DNNEHDJMMBE, out int FNFKBHCEBDN);

		// Token: 0x06000CDB RID: 3291
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingMessages_GetSessionConnectionInfo")]
		public static extern BALPMDPLGKH HNLDBPMOPDC(IntPtr DNNEHDJMMBE, ref SteamNetworkingIdentity EGNOINEIEFP, out HLANBPHOFND CCCKLKPOMFC, out DGNKMGPCDKN DKHIEEOBOJH);

		// Token: 0x06000CDC RID: 3292
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_AddPromoItem")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PJKHHIPNMHF(IntPtr DNNEHDJMMBE, out SteamInventoryResult_t DONIEBGGKMH, SteamItemDef_t FKNOHONPAEA);

		// Token: 0x06000CDD RID: 3293
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_SetInGameVoiceSpeaking")]
		public static extern void OJIKCDEACAP(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, [MarshalAs(UnmanagedType.I1)] bool NKGAHNGDNBN);

		// Token: 0x06000CDE RID: 3294
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_RegisterSteamMusicRemote")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PILAOGAFKGI(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM);

		// Token: 0x06000CDF RID: 3295
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_StartPurchase")]
		public static extern ulong GHIBMMNDAAL(IntPtr DNNEHDJMMBE, [In] [Out] SteamItemDef_t[] HPIHEINFIEO, [In] [Out] uint[] DKCHIEOKNMA, uint OIPDLADCLOC);

		// Token: 0x06000CE0 RID: 3296
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_ShowGamepadTextInput")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OHLFPNALFFG(IntPtr DNNEHDJMMBE, BFJELNOJHEL JKGDKCBDJJN, NEBHGELIKDH FOHBNGJPMCA, MBLFNIBGODG.LJANJDBDBJI IBFLDFKEAON, uint JJFMLBLIDHM, MBLFNIBGODG.LJANJDBDBJI FLKJAJHJAJP);

		// Token: 0x06000CE1 RID: 3297
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetSize")]
		public static extern void FJGOPFNJOAM(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, uint GDFIHHLHCIH, uint KKECEFDHIAA);

		// Token: 0x06000CE2 RID: 3298
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_Legacy_TriggerRepeatedHapticPulse")]
		public static extern void JKOCLLBMLKP(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, LGLCIHJJPHM HKFJJGIFBCF, ushort LKMPIGIFGHB, ushort GFMICJMMKBK, ushort HJAFDMJBNIF, uint NJPPDMDFJGM);

		// Token: 0x06000CE3 RID: 3299
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_SetGameHostParams")]
		public static extern BIPOIENHHDB EMJEKEAEGPD(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE, MBLFNIBGODG.LJANJDBDBJI OIABIHIJPJN);

		// Token: 0x06000CE4 RID: 3300
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileReadAsyncComplete")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OACNCCMPJFB(IntPtr DNNEHDJMMBE, SteamAPICall_t DIMDNDFHANH, byte[] KMHBNOFCMCJ, uint HBNOFKAIDDL);

		// Token: 0x06000CE5 RID: 3301
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_RegisterCallResult")]
		public static extern void OODELEIJHCI(IntPtr KBIIJJJNAND, ulong MNKAEOKBKBL);

		// Token: 0x06000CE6 RID: 3302
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_PasteFromClipboard")]
		public static extern void GKELACKCKBB(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD);

		// Token: 0x06000CE7 RID: 3303
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_GetLinkAtPosition")]
		public static extern void BFFLCBJONNP(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, int OBNBCGOIMKE, int DEJFBNMNMOK);

		// Token: 0x06000CE8 RID: 3304
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetRemoteFakeIPForConnection")]
		public static extern LNFOAHHPFIH MEMAKLDFIBJ(IntPtr DNNEHDJMMBE, HSteamNetConnection KLJAKJFEEIC, out SteamNetworkingIPAddr ADOOIMKPAKA);

		// Token: 0x06000CE9 RID: 3305
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_DeclineGame")]
		public static extern BIPOIENHHDB PEKKEPJGLJN(IntPtr DNNEHDJMMBE);

		// Token: 0x06000CEA RID: 3306
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetPOPCount")]
		public static extern int IAMAACGHJOK(IntPtr DNNEHDJMMBE);

		// Token: 0x06000CEB RID: 3307
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParties_GetBeaconLocationData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EENBEKMIHKE(IntPtr DNNEHDJMMBE, LAMANAOFFOF EOGHJKBEABE, CCACIEPKHPL CMJLIPGFCHO, IntPtr LEKPEILNODG, int FKKEFADFANB);

		// Token: 0x06000CEC RID: 3308
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardDisplayType")]
		public static extern ACIMDHIJCKD OOHBEOGIAEO(IntPtr DNNEHDJMMBE, SteamLeaderboard_t KFLCGDMDANA);

		// Token: 0x06000CED RID: 3309
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_RequestClanOfficerList")]
		public static extern ulong NKNKIDCKOID(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI);

		// Token: 0x06000CEE RID: 3310
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetIPv4")]
		public static extern uint MOCLAFKEJKM(ref SteamNetworkingIdentity DPAHMPHNPMK);

		// Token: 0x06000CEF RID: 3311
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseUp")]
		public static extern void OOPEKKJEEHH(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, LLBDBBLHDJH GIAGILLMLDD);

		// Token: 0x06000CF0 RID: 3312
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCResult")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FCJDIAPBKGJ(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint GGICIBLJIKI, out ELIAAKNHCJD NNBNPPJLBJB);

		// Token: 0x06000CF1 RID: 3313
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseHeaderSize")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MGCENKKBPLH(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, MBLFNIBGODG.LJANJDBDBJI LFGHDBMIGJD, out uint HPJMAPKFHBF);

		// Token: 0x06000CF2 RID: 3314
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CloseConnection")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OHMJJACHJBP(IntPtr DNNEHDJMMBE, HSteamNetConnection CHFHNPJJBEH, int FADGEBKOIAN, MBLFNIBGODG.LJANJDBDBJI ECHBJADIGAP, [MarshalAs(UnmanagedType.I1)] bool GIIEKHLHJEH);

		// Token: 0x06000CF3 RID: 3315
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_SearchForGameWithLobby")]
		public static extern BIPOIENHHDB BLEFLEKOLAI(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, int BAPOLOILGPN, int EDLMHOCEAJD);

		// Token: 0x06000CF4 RID: 3316
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanByIndex")]
		public static extern ulong ICKOJDKHHGB(IntPtr DNNEHDJMMBE, int HPMLEHAPPDP);

		// Token: 0x06000CF5 RID: 3317
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetSessionInputConfigurationSettings")]
		public static extern ushort FHMLDJMIMFB(IntPtr DNNEHDJMMBE);

		// Token: 0x06000CF6 RID: 3318
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_EnableLooped")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BGLFLEKEIGG(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool OFLAMEMDFGK);

		// Token: 0x06000CF7 RID: 3319
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileDelete")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HDJGMOPHKDK(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ);

		// Token: 0x06000CF8 RID: 3320
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryAllUGCRequestCursor")]
		public static extern ulong GAAHKILIKAI(IntPtr DNNEHDJMMBE, DBJPCBDMANI FOAFHNBELNA, GGBFGPNFANI PNNMCOENFNM, AppId_t HPKODIICKAI, AppId_t FELDDNEJJND, MBLFNIBGODG.LJANJDBDBJI ALNMMPEDOEF);

		// Token: 0x06000CF9 RID: 3321
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_Init")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GKBJOLAGDOO();

		// Token: 0x06000CFA RID: 3322
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveItemFromFavorites")]
		public static extern ulong OLAEHPMOJNP(IntPtr DNNEHDJMMBE, AppId_t PENOMDECAOM, PublishedFileId_t GGEBDPEOMDI);

		// Token: 0x06000CFB RID: 3323
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_IsIPv4")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GCALPHFPFJA(ref SteamNetworkingIPAddr DPAHMPHNPMK);

		// Token: 0x06000CFC RID: 3324
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_CreateItem")]
		public static extern ulong CBBDEGHMOBH(IntPtr DNNEHDJMMBE, AppId_t AIFBKIMDCPH, CMDODJKKNGO ANANHBNJMCD);

		// Token: 0x06000CFD RID: 3325
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetIPCCallCount")]
		public static extern uint KFBHMEACOCK(IntPtr DNNEHDJMMBE);

		// Token: 0x06000CFE RID: 3326
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetDebugOutputFunction")]
		public static extern void IKCDPBALLOD(IntPtr DNNEHDJMMBE, OKBCHCIDNDH NMAHBGPDFPO, NENNIKDLNKO FEDDJFFOEFK);

		// Token: 0x06000CFF RID: 3327
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingMessages_ReceiveMessagesOnChannel")]
		public static extern int FHJHJMBOJKB(IntPtr DNNEHDJMMBE, int COKJGDPJGEO, [In] [Out] IntPtr[] OEJHILDLJMA, int FGGDIFEKDHH);

		// Token: 0x06000D00 RID: 3328
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CloseP2PChannelWithUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JGFNLANGMEC(IntPtr DNNEHDJMMBE, CSteamID KHBNBCJABCI, int KDOGMEOPDJN);

		// Token: 0x06000D01 RID: 3329
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetStringForActionOrigin")]
		public static extern IntPtr HMFHHIOFFMF(IntPtr DNNEHDJMMBE, FMPMIBBOIAM HAEIMJBBKOH);

		// Token: 0x06000D02 RID: 3330
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreatePollGroup")]
		public static extern uint PJEODLCEMHH(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D03 RID: 3331
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_IsFakeIPv4")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JBIAJKJAIJI(IntPtr DNNEHDJMMBE, uint KGLEJGCAGBD);

		// Token: 0x06000D04 RID: 3332
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_CopyToClipboard")]
		public static extern void KINJFHLEELP(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD);

		// Token: 0x06000D05 RID: 3333
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingMessages_CloseChannelWithUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KPABMDAPFMB(IntPtr DNNEHDJMMBE, ref SteamNetworkingIdentity EGNOINEIEFP, int COKJGDPJGEO);

		// Token: 0x06000D06 RID: 3334
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserStatInt32")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KNFOHKFELHK(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out int EENCENODOOG);

		// Token: 0x06000D07 RID: 3335
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetItemState")]
		public static extern uint NCNDBCDMAGL(IntPtr DNNEHDJMMBE, PublishedFileId_t GGEBDPEOMDI);

		// Token: 0x06000D08 RID: 3336
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyMemberData")]
		public static extern void ELJIHDNPHNA(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE, MBLFNIBGODG.LJANJDBDBJI OIABIHIJPJN);

		// Token: 0x06000D09 RID: 3337
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_Shutdown")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JIEKMENIGON(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D0A RID: 3338
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_GetFakeIPType")]
		public static extern HJNNPCJKHBP KLHHMBNPMFG(ref SteamNetworkingIPAddr DPAHMPHNPMK);

		// Token: 0x06000D0B RID: 3339
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GrantPromoItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MDOOAAPEMBG(IntPtr DNNEHDJMMBE, out SteamInventoryResult_t DONIEBGGKMH);

		// Token: 0x06000D0C RID: 3340
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ConnectToHostedDedicatedServer")]
		public static extern uint MJDGENNMOKG(IntPtr DNNEHDJMMBE, ref SteamNetworkingIdentity NHDFINMNBLA, int CGFFFNBFNLM, int HHJMCLMABHG, [In] [Out] SteamNetworkingConfigValue_t[] NKNGPCMOHCH);

		// Token: 0x06000D0D RID: 3341
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_IsCloudEnabledForAccount")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NGPBIDALLKO(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D0E RID: 3342
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_BWaitForData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HGMGIIOJKJD(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool KNMFLFMLDPN, uint EFAACHNKIPL);

		// Token: 0x06000D0F RID: 3343
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_ReleaseHTTPRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EKPHEAHOINN(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK);

		// Token: 0x06000D10 RID: 3344
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_GetHSteamUser")]
		public static extern int DMFIAIPLNGN();

		// Token: 0x06000D11 RID: 3345
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetUGCDownloadProgress")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EMMNCMHKJOO(IntPtr DNNEHDJMMBE, UGCHandle_t DNBPDFIIBHN, out int ADGGKDIAKDD, out int LJALDPIOKMN);

		// Token: 0x06000D12 RID: 3346
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_SetAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FKBHNKPOAGN(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM);

		// Token: 0x06000D13 RID: 3347
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_InitAuthentication")]
		public static extern DNEHHBIPLOF KELHCJEEGJN(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D14 RID: 3348
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SubmitItemUpdate")]
		public static extern ulong FJOEDNPNMHO(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI MDGKNJIBKHG);

		// Token: 0x06000D15 RID: 3349
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_ExecuteJavascript")]
		public static extern void CGDHAFMHMJJ(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, MBLFNIBGODG.LJANJDBDBJI COGMHFNCJPG);

		// Token: 0x06000D16 RID: 3350
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSignalingRecvContext_SendRejectionSignal")]
		public static extern void BPKBBMLHLEO(ref ISteamNetworkingSignalingRecvContext DPAHMPHNPMK, ref SteamNetworkingIdentity JFLJIHHHPBJ, IntPtr MFIJCBDPKMP, int DONIGFFDKIF);

		// Token: 0x06000D17 RID: 3351
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetInstalledDepots")]
		public static extern uint HBMJBLOLGLM(IntPtr DNNEHDJMMBE, AppId_t NCFIHMEHIOE, [In] [Out] DepotId_t[] AAPKNOPHCFB, uint NCCFOBCDLCI);

		// Token: 0x06000D18 RID: 3352
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_HasFriend")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JNBLONEODBI(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE, PKIJCNBOGAH HMMINHBNAFA);

		// Token: 0x06000D19 RID: 3353
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendMessage")]
		public static extern int CGPBGOCFCFB(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE, int DFHPDJBAFAJ, IntPtr CMKDMIPPNGN, int DNFELHKNIIP, out JAHKIBJGEDE PABOKFFKIMJ);

		// Token: 0x06000D1A RID: 3354
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionCount")]
		public static extern uint HIJIMPEKEKB(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D1B RID: 3355
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_SetCloudEnabledForApp")]
		public static extern void KBALCNMFMFG(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool BGJGABGJGIO);

		// Token: 0x06000D1C RID: 3356
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamInternal_GameServer_Init")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GGNOJMNMGKK(uint FLGFECHPNIF, ushort KLBOAFDGBGD, ushort HCOECGJHAJA, ushort KMLJPOGEMNO, ILOLDAKCIIK FMHKKKFMNDB, MBLFNIBGODG.LJANJDBDBJI DJADHKEDJCE);

		// Token: 0x06000D1D RID: 3357
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetVerticalScroll")]
		public static extern void INNAJLBHNJN(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, uint MPCNJDLELIC);

		// Token: 0x06000D1E RID: 3358
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_UpdateItemPreviewVideo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IGKAGILIPCN(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, uint GGICIBLJIKI, MBLFNIBGODG.LJANJDBDBJI KFFLFHKNKPC);

		// Token: 0x06000D1F RID: 3359
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsSteamRunningInVR")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BGJALPBIIKJ(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D20 RID: 3360
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamGameServerClient")]
		public static extern IntPtr AAJGGBGJOMA();

		// Token: 0x06000D21 RID: 3361
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRichPresenceKeyCount")]
		public static extern int HONIAALKKMP(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE);

		// Token: 0x06000D22 RID: 3362
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_SendP2PPacket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KGCGJMNMGAK(IntPtr DNNEHDJMMBE, CSteamID KHBNBCJABCI, byte[] IGJCKJIFGEK, uint DNFELHKNIIP, OFHJIJJNPEL PLDCHGKLMDA, int KDOGMEOPDJN);

		// Token: 0x06000D23 RID: 3363
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_DownloadLeaderboardEntries")]
		public static extern ulong LMONEOHLJKJ(IntPtr DNNEHDJMMBE, SteamLeaderboard_t KFLCGDMDANA, CJJHIMGFCDP LFAJNHGCAAP, int PNJIKMJAAEN, int HALIJHDJFLO);

		// Token: 0x06000D24 RID: 3364
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendFromSourceByIndex")]
		public static extern ulong MHACAOBOLAG(IntPtr DNNEHDJMMBE, CSteamID DAHMOBOFOFB, int OEAAFODCAHN);

		// Token: 0x06000D25 RID: 3365
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ReceiveMessagesOnPollGroup")]
		public static extern int FAJGGMPEPCH(IntPtr DNNEHDJMMBE, HSteamNetPollGroup HJBCPEEDMKC, [In] [Out] IntPtr[] OEJHILDLJMA, int FGGDIFEKDHH);

		// Token: 0x06000D26 RID: 3366
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetMarketEligibility")]
		public static extern ulong PBGNPKJMAKK(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D27 RID: 3367
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BDecryptTicket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KHMKCDNODAN([In] [Out] byte[] HNIHDAHAAGP, uint JJKNJEFHKEJ, [In] [Out] byte[] OJNJHJOIJDG, ref uint BDODEONIHFA, [MarshalAs(UnmanagedType.LPArray, SizeConst = 32)] byte[] JAEHDCMHEPH, int OOKNMDNFGJM);

		// Token: 0x06000D28 RID: 3368
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetConnectionRealTimeStatus")]
		public static extern LNFOAHHPFIH BAEJBAEDJNM(IntPtr DNNEHDJMMBE, HSteamNetConnection KLJAKJFEEIC, ref DGNKMGPCDKN BMGPOOLCBED, int KJLMAOOFIAP, ref FKCIBNBJJPM PHCNANGIMAE);

		// Token: 0x06000D29 RID: 3369
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetActionOriginFromXboxOrigin")]
		public static extern FMPMIBBOIAM NCKEHLMKENG(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, KLMECMKLLGJ HAEIMJBBKOH);

		// Token: 0x06000D2A RID: 3370
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_SubscribePublishedFile")]
		public static extern ulong CONDJPMJELA(IntPtr DNNEHDJMMBE, PublishedFileId_t JPCGPJHIMMP);

		// Token: 0x06000D2B RID: 3371
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_JSDialogResponse")]
		public static extern void GPIEKOPMPJG(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, [MarshalAs(UnmanagedType.I1)] bool KFKLKJMKFHE);

		// Token: 0x06000D2C RID: 3372
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_BIsCurrentMusicRemote")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BHONOBGHHEI(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D2D RID: 3373
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdateUserPublishedItemVote")]
		public static extern ulong NIIOPMIICFG(IntPtr DNNEHDJMMBE, PublishedFileId_t JPCGPJHIMMP, [MarshalAs(UnmanagedType.I1)] bool CGCLBGAFDHI);

		// Token: 0x06000D2E RID: 3374
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseBodySize")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BOAHLIKLDDO(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, out uint KAONAMCCCGP);

		// Token: 0x06000D2F RID: 3375
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetSteamID")]
		public static extern ulong KLLHEMJDPJB(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D30 RID: 3376
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_IsUserInSource")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JFBLHDJBFBJ(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, CSteamID DAHMOBOFOFB);

		// Token: 0x06000D31 RID: 3377
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ReleaseCurrentThreadMemory")]
		public static extern void JGCCHMGNNOB();

		// Token: 0x06000D32 RID: 3378
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_PrioritizeHTTPRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OONOHLPHEEG(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK);

		// Token: 0x06000D33 RID: 3379
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetCurrentQueueEntry")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IKPHBBKLAMK(IntPtr DNNEHDJMMBE, int HBNODOOKPKG);

		// Token: 0x06000D34 RID: 3380
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_IsP2PPacketAvailable")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HHLCJHAKJEJ(IntPtr DNNEHDJMMBE, out uint KNKBMPIDGDN, int KDOGMEOPDJN);

		// Token: 0x06000D35 RID: 3381
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamVideo_GetOPFSettings")]
		public static extern void FEMCOGBFCMH(IntPtr DNNEHDJMMBE, AppId_t OAEOLFEOPLA);

		// Token: 0x06000D36 RID: 3382
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyChatEntry")]
		public static extern int MIDAIOEFDLE(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, int HAINKJIBEPG, out CSteamID BEDJEEPEIFG, byte[] CMKDMIPPNGN, int DNFELHKNIIP, out JAHKIBJGEDE PABOKFFKIMJ);

		// Token: 0x06000D37 RID: 3383
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ConnectP2P")]
		public static extern uint GIMGJIJPMFA(IntPtr DNNEHDJMMBE, ref SteamNetworkingIdentity EGNOINEIEFP, int CGFFFNBFNLM, int HHJMCLMABHG, [In] [Out] SteamNetworkingConfigValue_t[] NKNGPCMOHCH);

		// Token: 0x06000D38 RID: 3384
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsTwoFactorEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BFNLLFOJCHN(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D39 RID: 3385
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetRemotePlaySessionID")]
		public static extern uint LBEEPFOCAAG(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA);

		// Token: 0x06000D3A RID: 3386
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendGamePlayed")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JGFJAGNEEEF(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE, out PDJJNMEHKLP EPEANMBMPOO);

		// Token: 0x06000D3B RID: 3387
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamNetworking")]
		public static extern IntPtr JCNOPNBBJFD(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000D3C RID: 3388
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_SetStatFloat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ANOIGDEEEHD(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, float EJHFKJCPOKE);

		// Token: 0x06000D3D RID: 3389
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BIsLicenseTemporary")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BPJDCCAOPMJ([In] [Out] byte[] OJNJHJOIJDG, uint HADHJKAMIBG);

		// Token: 0x06000D3E RID: 3390
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_StoreStats")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JLOAJGKOCOL(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D3F RID: 3391
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCNumTags")]
		public static extern uint FHNBBJLCPOH(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint GGICIBLJIKI);

		// Token: 0x06000D40 RID: 3392
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemotePlay_BGetSessionClientResolution")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EFEADMBAPCI(IntPtr DNNEHDJMMBE, RemotePlaySessionID_t PMCEJNGFFCB, out int AGJHGCCNACH, out int FGPGKKAOKAP);

		// Token: 0x06000D41 RID: 3393
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_LogOnAnonymous")]
		public static extern void GDAKJMBOINM(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D42 RID: 3394
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_CreateConnectionSocket")]
		public static extern uint MLHKAPPJNDG(IntPtr DNNEHDJMMBE, SteamIPAddress_t LGNJMHPGCFK, ushort MLHPDILCKGP, int AKOPLPAKHLK);

		// Token: 0x06000D43 RID: 3395
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetEligiblePromoItemDefinitionIDs")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HGLHIDHHOPM(IntPtr DNNEHDJMMBE, CSteamID EKCOJJGHNAN, [In] [Out] SteamItemDef_t[] HHJEKGOHNOE, ref uint FKNFFLFFAGF);

		// Token: 0x06000D44 RID: 3396
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetConnectedUniverse")]
		public static extern PLGPFJMBLEI NLBEPJKLFED(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D45 RID: 3397
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingMessages_AcceptSessionWithUser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GGENFMNOCPD(IntPtr DNNEHDJMMBE, ref SteamNetworkingIdentity EGNOINEIEFP);

		// Token: 0x06000D46 RID: 3398
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetPageScaleFactor")]
		public static extern void BLFPBLPCKFN(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, float JEEIPFKEOFO, int LGDIDBNMKBB, int FKCEFHNEALO);

		// Token: 0x06000D47 RID: 3399
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ConnectByIPAddress")]
		public static extern uint OPKAHOGJAMA(IntPtr DNNEHDJMMBE, ref SteamNetworkingIPAddr CKLNODNMLMM, int HHJMCLMABHG, [In] [Out] SteamNetworkingConfigValue_t[] NKNGPCMOHCH);

		// Token: 0x06000D48 RID: 3400
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_SendMessages")]
		public static extern void DILHIMMCDAG(IntPtr DNNEHDJMMBE, int CEMOKPJMIJO, [In] [Out] SteamNetworkingMessage_t[] GCJNPGDIPEE, [In] [Out] long[] CPLHECDEHPK);

		// Token: 0x06000D49 RID: 3401
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetUserDataFolder")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DBCBPDLNCJC(IntPtr DNNEHDJMMBE, IntPtr BMBAOHEBHDL, int IDEPLJMDCEI);

		// Token: 0x06000D4A RID: 3402
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_AddVRScreenshotToLibrary")]
		public static extern uint ODGMLDEOBHL(IntPtr DNNEHDJMMBE, NEEBEBPHBNE BCHMCGBFFEE, MBLFNIBGODG.LJANJDBDBJI JBEGMFMOAPK, MBLFNIBGODG.LJANJDBDBJI KBMKMGMDHFF);

		// Token: 0x06000D4B RID: 3403
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_RunCallbacks")]
		public static extern void APAFHPDGJBM();

		// Token: 0x06000D4C RID: 3404
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ManualDispatch_FreeLastCallback")]
		public static extern void JBFJPEACOKG(HSteamPipe CMIMOPGNCKB);

		// Token: 0x06000D4D RID: 3405
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementAndUnlockTime")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OGAMCMJHGIM(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out bool LAEOHDNHABG, out uint NLAPNHKCCEE);

		// Token: 0x06000D4E RID: 3406
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_RunFrame")]
		public static extern void PDLNBKPJKEL(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool OLNBAHLMOBG);

		// Token: 0x06000D4F RID: 3407
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanName")]
		public static extern IntPtr HADCNNIJGDM(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI);

		// Token: 0x06000D50 RID: 3408
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsVACBanned")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ONFNPIFIKAC(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D51 RID: 3409
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemTags")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LDLILOEJALL(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t OGPKKNDEDFI, IntPtr ICGNMKEHAGF);

		// Token: 0x06000D52 RID: 3410
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStatHistoryInt64")]
		public static extern int GKONHGOAICJ(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI FMEDOEGOAPD, [In] [Out] long[] EENCENODOOG, uint DNFELHKNIIP);

		// Token: 0x06000D53 RID: 3411
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RequestUGCDetails")]
		public static extern ulong CMGGOIKANDN(IntPtr DNNEHDJMMBE, PublishedFileId_t GGEBDPEOMDI, uint LIJJLMCBFJC);

		// Token: 0x06000D54 RID: 3412
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamAppList_GetInstalledApps")]
		public static extern uint DKGMBHIIHJK(IntPtr DNNEHDJMMBE, [In] [Out] AppId_t[] MOEAKPOFCON, uint NBECIMPPBKJ);

		// Token: 0x06000D55 RID: 3413
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_RequestAllProofOfPurchaseKeys")]
		public static extern void BFGLHJKGLJJ(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D56 RID: 3414
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_SendMessageToConnection")]
		public static extern LNFOAHHPFIH NLPMIOBAKAC(IntPtr DNNEHDJMMBE, HSteamNetConnection KLJAKJFEEIC, IntPtr EENCENODOOG, uint PBINDFLMANO, int GMOHBFLBHHL, out long PMLONNJHFMI);

		// Token: 0x06000D57 RID: 3415
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemVisibility")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OCMJKDFLEIB(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, OAGKEPBKEMA LAGMCOMKMHL);

		// Token: 0x06000D58 RID: 3416
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribed")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PHIFGGLMKHO(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D59 RID: 3417
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_SearchForGameSolo")]
		public static extern BIPOIENHHDB MMCBDFBPNCI(IntPtr DNNEHDJMMBE, int BAPOLOILGPN, int EDLMHOCEAJD);

		// Token: 0x06000D5A RID: 3418
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddDependency")]
		public static extern ulong FHOGIKNNKGH(IntPtr DNNEHDJMMBE, PublishedFileId_t HACFFCALOKJ, PublishedFileId_t ANCFJDCJOKG);

		// Token: 0x06000D5B RID: 3419
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_CreateCookieContainer")]
		public static extern uint PHPFGLPDILH(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool DDDAIPCJABN);

		// Token: 0x06000D5C RID: 3420
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamInternal_FindOrCreateUserInterface")]
		public static extern IntPtr NHMHKBOCGDI(HSteamUser OOFCLIELINA, MBLFNIBGODG.LJANJDBDBJI ICLMGNNBPJG);

		// Token: 0x06000D5D RID: 3421
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamGameServer_GetHSteamPipe")]
		public static extern int FCPHJGJEDPH();

		// Token: 0x06000D5E RID: 3422
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestHistoryServerList")]
		public static extern IntPtr CBIMCPCPMGL(IntPtr DNNEHDJMMBE, AppId_t GDIHJPFCLKN, IntPtr GAFCEHKPODN, uint ODAKHIGHAHO, IntPtr POEEGAJBLKJ);

		// Token: 0x06000D5F RID: 3423
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetAuthSessionTicket")]
		public static extern uint GHCLIEHHPOC(IntPtr DNNEHDJMMBE, byte[] EOJICCJIPLO, int CBLNENJMGIE, out uint EJDEKGHCOLF);

		// Token: 0x06000D60 RID: 3424
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_AcceptConnection")]
		public static extern LNFOAHHPFIH EJIOMOCBIKI(IntPtr DNNEHDJMMBE, HSteamNetConnection KLJAKJFEEIC);

		// Token: 0x06000D61 RID: 3425
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestFavoritesServerList")]
		public static extern IntPtr ODJJHDKDPIL(IntPtr DNNEHDJMMBE, AppId_t GDIHJPFCLKN, IntPtr GAFCEHKPODN, uint ODAKHIGHAHO, IntPtr POEEGAJBLKJ);

		// Token: 0x06000D62 RID: 3426
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetUserAchievementAndUnlockTime")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ELDMEIJLHJL(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out bool LAEOHDNHABG, out uint NLAPNHKCCEE);

		// Token: 0x06000D63 RID: 3427
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetPersonaState")]
		public static extern KPICCGBIAOC JLGMCNEMFBP(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D64 RID: 3428
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetSteamID64")]
		public static extern ulong CODAIFMEECI(ref SteamNetworkingIdentity DPAHMPHNPMK);

		// Token: 0x06000D65 RID: 3429
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_DownloadClanActivityCounts")]
		public static extern ulong IGCEBEOHMAM(IntPtr DNNEHDJMMBE, [In] [Out] CSteamID[] DOCJENDBBHI, int CHPKDFIJEPP);

		// Token: 0x06000D66 RID: 3430
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsVRHeadsetStreamingEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OJCDEGHNKFL(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D67 RID: 3431
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_RequestAppProofOfPurchaseKey")]
		public static extern void PAEDMEMCGKB(IntPtr DNNEHDJMMBE, AppId_t MINMIFBPLGA);

		// Token: 0x06000D68 RID: 3432
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamParties")]
		public static extern IntPtr PEPBECEHEHH(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000D69 RID: 3433
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GenerateItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BNPAJEBLFEJ(IntPtr DNNEHDJMMBE, out SteamInventoryResult_t DONIEBGGKMH, [In] [Out] SteamItemDef_t[] HPIHEINFIEO, [In] [Out] uint[] DKCHIEOKNMA, uint OIPDLADCLOC);

		// Token: 0x06000D6A RID: 3434
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_CheckFileSignature")]
		public static extern ulong FKFHNEEABLJ(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI MGJAEMNNPGN);

		// Token: 0x06000D6B RID: 3435
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_RequestLobbyList")]
		public static extern ulong HBHPFPJAGNF(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D6C RID: 3436
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_ClearAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KAAANGACEJL(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM);

		// Token: 0x06000D6D RID: 3437
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetAppOwner")]
		public static extern ulong JNHJGOCJFHL(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D6E RID: 3438
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyMemberData")]
		public static extern IntPtr AGFNOGEJHAC(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE);

		// Token: 0x06000D6F RID: 3439
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_CheckPingDataUpToDate")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HLFJDBBOJGM(IntPtr DNNEHDJMMBE, float JPGBFBDDFAD);

		// Token: 0x06000D70 RID: 3440
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetIPCCallCount")]
		public static extern uint NBCEBNFJAIJ(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D71 RID: 3441
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileShare")]
		public static extern ulong LEMHEKGPPEB(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ);

		// Token: 0x06000D72 RID: 3442
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_SetLocation")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool COAFDAEGPFK(IntPtr DNNEHDJMMBE, ScreenshotHandle CJNPEFMLHCC, MBLFNIBGODG.LJANJDBDBJI CDAEAMMFFIC);

		// Token: 0x06000D73 RID: 3443
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_InspectItem")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NBNBGAKKECD(IntPtr DNNEHDJMMBE, out SteamInventoryResult_t DONIEBGGKMH, MBLFNIBGODG.LJANJDBDBJI IHMGMIIFOMI);

		// Token: 0x06000D74 RID: 3444
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetIPAddr")]
		public static extern IntPtr IFGLKHLELHK(ref SteamNetworkingIdentity DPAHMPHNPMK);

		// Token: 0x06000D75 RID: 3445
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamController")]
		public static extern IntPtr KGJKEOPMELH(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000D76 RID: 3446
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyGameServer")]
		public static extern void AOIOPAFFODD(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, uint JFOOCIMGEJG, ushort FBHDBFACFMM, CSteamID NPGPIHJKJKL);

		// Token: 0x06000D77 RID: 3447
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_SetVRHeadsetStreamingEnabled")]
		public static extern void CGCIICPOAGB(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool BGJGABGJGIO);

		// Token: 0x06000D78 RID: 3448
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsAppInstalled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NADJPAIGOIH(IntPtr DNNEHDJMMBE, AppId_t NCFIHMEHIOE);

		// Token: 0x06000D79 RID: 3449
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetGameplayStats")]
		public static extern void MHOFKACBJKE(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D7A RID: 3450
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_ShowBindingPanel")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PFDEEAJFPKD(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA);

		// Token: 0x06000D7B RID: 3451
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ManualDispatch_RunFrame")]
		public static extern void CHEHCACDNGB(HSteamPipe CMIMOPGNCKB);

		// Token: 0x06000D7C RID: 3452
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamScreenshots")]
		public static extern IntPtr FJEIHHKEGJO(IntPtr DNNEHDJMMBE, HSteamUser MPMPFFFHHLH, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000D7D RID: 3453
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetAuthSessionTicket")]
		public static extern uint BLCHEMNOPJG(IntPtr DNNEHDJMMBE, byte[] EOJICCJIPLO, int CBLNENJMGIE, out uint EJDEKGHCOLF);

		// Token: 0x06000D7E RID: 3454
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_Init")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LBCEFAEHNKA(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool KGEINMMBPIL);

		// Token: 0x06000D7F RID: 3455
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamUserStats")]
		public static extern IntPtr JPJCOCNEBBJ(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000D80 RID: 3456
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_AddGameSearchParams")]
		public static extern BIPOIENHHDB AEOCNMEKNMK(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI LFFJDDFBJGF, MBLFNIBGODG.LJANJDBDBJI KIDNDCDPLNF);

		// Token: 0x06000D81 RID: 3457
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendSteamLevel")]
		public static extern int KOPDNFKMAGJ(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE);

		// Token: 0x06000D82 RID: 3458
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetResultItems")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MFHCHKFBNFC(IntPtr DNNEHDJMMBE, SteamInventoryResult_t PDIGNGHLDII, [In] [Out] KECLCPJHOAJ[] PAANBDPBBBF, ref uint NLGOICHNFME);

		// Token: 0x06000D83 RID: 3459
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsFeatureInBlockList")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MHCPCONMFKC(IntPtr DNNEHDJMMBE, EOKNMIPAHFM FMJCJGGGCKH);

		// Token: 0x06000D84 RID: 3460
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetGenericBytes")]
		public static extern IntPtr MPKKICOPJFI(ref SteamNetworkingIdentity DPAHMPHNPMK, out int DLPBEGLKBJL);

		// Token: 0x06000D85 RID: 3461
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileReadAsync")]
		public static extern ulong OGMGCKFOJKI(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ, uint MKNFEPFEHBG, uint HBNOFKAIDDL);

		// Token: 0x06000D86 RID: 3462
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_ReleaseCookieContainer")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JJLOIJAPKHE(IntPtr DNNEHDJMMBE, HTTPCookieContainerHandle KCODEGFCIHE);

		// Token: 0x06000D87 RID: 3463
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SetTryCatchCallbacks")]
		public static extern void DMPKCFOENHN([MarshalAs(UnmanagedType.I1)] bool LOMGPHBCFKK);

		// Token: 0x06000D88 RID: 3464
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_InitFilterText")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CFCIDHGGFFI(IntPtr DNNEHDJMMBE, uint OGFEBIHNFHA);

		// Token: 0x06000D89 RID: 3465
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsAppInBlockList")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OBGLOIAIMID(IntPtr DNNEHDJMMBE, AppId_t MINMIFBPLGA);

		// Token: 0x06000D8A RID: 3466
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyType")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PIACLCEIENG(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, KBKCDOCDIOG OJKAEDNPFIO);

		// Token: 0x06000D8B RID: 3467
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_CancelRequestPlayersForGame")]
		public static extern BIPOIENHHDB LOMAILDCFOF(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D8C RID: 3468
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetDurationControl")]
		public static extern ulong NKINPDFEBBM(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D8D RID: 3469
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_GetTicketIssueTime")]
		public static extern uint EHFCHNGDOPO([In] [Out] byte[] OJNJHJOIJDG, uint HADHJKAMIBG);

		// Token: 0x06000D8E RID: 3470
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileFile")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GDMGAJALNNL(IntPtr DNNEHDJMMBE, PublishedFileUpdateHandle_t OGPKKNDEDFI, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ);

		// Token: 0x06000D8F RID: 3471
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneIdentifying")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BOLPIJILPLN(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D90 RID: 3472
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetCachedUGCHandle")]
		public static extern ulong MNFOADMONDD(IntPtr DNNEHDJMMBE, int POFCBCCBAID);

		// Token: 0x06000D91 RID: 3473
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetFakeIP")]
		public static extern void BMGKBNCEJKC(IntPtr DNNEHDJMMBE, int PHALGOOLMNJ, out AEOLBPBPKBF OHGGHJNFFMK);

		// Token: 0x06000D92 RID: 3474
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_BeginFileWriteBatch")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HNNAPGHEKHA(IntPtr DNNEHDJMMBE);

		// Token: 0x06000D93 RID: 3475
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PJJLCDJADDB(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out bool LAEOHDNHABG);

		// Token: 0x06000D94 RID: 3476
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetStringForXboxOrigin")]
		public static extern IntPtr GIOKOOIOOIP(IntPtr DNNEHDJMMBE, KLMECMKLLGJ HAEIMJBBKOH);

		// Token: 0x06000D95 RID: 3477
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SendQueryUGCRequest")]
		public static extern ulong EKFHBOPGAKF(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF);

		// Token: 0x06000D96 RID: 3478
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParties_CreateBeacon")]
		public static extern ulong LPJCOGOGMFM(IntPtr DNNEHDJMMBE, uint HCIHFDNJCMC, ref LAMANAOFFOF BGFBBBFLPII, MBLFNIBGODG.LJANJDBDBJI KBIODGLGHOJ, MBLFNIBGODG.LJANJDBDBJI CKNGJJCGEKB);

		// Token: 0x06000D97 RID: 3479
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamInventory")]
		public static extern IntPtr GCLNMKMMJHF(IntPtr DNNEHDJMMBE, HSteamUser MPMPFFFHHLH, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000D98 RID: 3480
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_AssociateWithClan")]
		public static extern ulong BGPPIKLMHEO(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI);

		// Token: 0x06000D99 RID: 3481
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_Find")]
		public static extern void DABPDPCOABG(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, MBLFNIBGODG.LJANJDBDBJI BLOBOAKECFN, [MarshalAs(UnmanagedType.I1)] bool JKDKECFHPOP, [MarshalAs(UnmanagedType.I1)] bool IDGJMPNGKGD);

		// Token: 0x06000D9A RID: 3482
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_RequestPlayersForGame")]
		public static extern BIPOIENHHDB FKBMEMIPGIP(IntPtr DNNEHDJMMBE, int BAPOLOILGPN, int EDLMHOCEAJD, int NGEDOAMBHJB);

		// Token: 0x06000D9B RID: 3483
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCoplayTime")]
		public static extern int HAFDCPKJPPF(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE);

		// Token: 0x06000D9C RID: 3484
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_UserHasLicenseForApp")]
		public static extern HCEDMHEOKCK HINJGCFAMFB(IntPtr DNNEHDJMMBE, CSteamID EKCOJJGHNAN, AppId_t NCFIHMEHIOE);

		// Token: 0x06000D9D RID: 3485
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SetPropertyBool")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MGJACEIGPPL(IntPtr DNNEHDJMMBE, SteamInventoryUpdateHandle_t CCCPIFNDMGF, SteamItemInstanceID_t FNBDJJIEEJC, MBLFNIBGODG.LJANJDBDBJI AGIKLDMPJPE, [MarshalAs(UnmanagedType.I1)] bool OFLAMEMDFGK);

		// Token: 0x06000D9E RID: 3486
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnTotalOnly")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GEJNPKOFPPA(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, [MarshalAs(UnmanagedType.I1)] bool DOAHPHNEPDA);

		// Token: 0x06000D9F RID: 3487
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_CancelServerQuery")]
		public static extern void OAKKMDOKJOL(IntPtr DNNEHDJMMBE, HServerQuery KLPOKCCONHJ);

		// Token: 0x06000DA0 RID: 3488
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetConfigValue")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GDKPAIKBDLD(IntPtr DNNEHDJMMBE, JHEBPHGLLMK BJEDEGNPCHB, ENAHGAAGOIF MFPNDHABCAL, IntPtr GICOGGMEKOE, AIGCOFEJAIF LPKOIDDKMLJ, IntPtr DGHIDGOKCNP);

		// Token: 0x06000DA1 RID: 3489
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetNumLobbyMembers")]
		public static extern int EMNFAPAALBA(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK);

		// Token: 0x06000DA2 RID: 3490
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSignalingRecvContext_OnConnectRequest")]
		public static extern IntPtr POHDKLJCMBD(ref ISteamNetworkingSignalingRecvContext DPAHMPHNPMK, HSteamNetConnection KLJAKJFEEIC, ref SteamNetworkingIdentity JFLJIHHHPBJ, int DFBNIOJELNC);

		// Token: 0x06000DA3 RID: 3491
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_AllocateMessage")]
		public static extern IntPtr PHELKJJNCBF(IntPtr DNNEHDJMMBE, int KACNCPBNNKG);

		// Token: 0x06000DA4 RID: 3492
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_ResetAllStats")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OPCBONNDNPJ(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool CFOKCOPHGEK);

		// Token: 0x06000DA5 RID: 3493
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ReceivedRelayAuthTicket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AIECOAKOADK(IntPtr DNNEHDJMMBE, IntPtr CDHCFCJFNME, int FPAMOJJNEJG, out SteamDatagramRelayAuthTicket HKCLNAPAJJI);

		// Token: 0x06000DA6 RID: 3494
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_Clear")]
		public static extern void FJPPGNEDPOA(ref SteamNetworkingIPAddr DPAHMPHNPMK);

		// Token: 0x06000DA7 RID: 3495
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamUser")]
		public static extern IntPtr JHHAJILHBEO(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000DA8 RID: 3496
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ClearRichPresence")]
		public static extern void LDEPDFGNEIF(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DA9 RID: 3497
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SuspendDownloads")]
		public static extern void MKKHGPPDNPL(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool JAFJFPKFPAO);

		// Token: 0x06000DAA RID: 3498
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsCybercafe")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IFJKIBNOJPJ(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DAB RID: 3499
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribedFromFamilySharing")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ABMJBHLDPDM(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DAC RID: 3500
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_BIsPlaying")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BDEEIIJMAOK(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DAD RID: 3501
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetNumItemsWithPrices")]
		public static extern uint GBCCFNBMLIO(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DAE RID: 3502
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_DismissFloatingGamepadTextInput")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HDKBKCEIKGL(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DAF RID: 3503
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_BShutdownIfAllPipesClosed")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CFNBDGOAANK(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DB0 RID: 3504
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetProduct")]
		public static extern void MFLKLGDFFDD(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI ODKICEJNPFM);

		// Token: 0x06000DB1 RID: 3505
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_WasRestartRequested")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool EBJPCCLKJCL(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DB2 RID: 3506
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyOwner")]
		public static extern ulong BMCHDPAIHAP(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK);

		// Token: 0x06000DB3 RID: 3507
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_RequestStoreAuthURL")]
		public static extern ulong HBEFFGICFGJ(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI HNCNEHCIIML);

		// Token: 0x06000DB4 RID: 3508
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetControllerForGamepadIndex")]
		public static extern ulong GBPPBNIABMN(IntPtr DNNEHDJMMBE, int ELJINAEMHBO);

		// Token: 0x06000DB5 RID: 3509
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_ConvertPingLocationToString")]
		public static extern void DNGHKIKLMKB(IntPtr DNNEHDJMMBE, ref FJNHNDBKGFH AKPCLBEPHMD, IntPtr LPEFIJAIHCE, int EPJFGEHEHHH);

		// Token: 0x06000DB6 RID: 3510
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamParties_OnReservationCompleted")]
		public static extern void BGALNBBOAAC(IntPtr DNNEHDJMMBE, PartyBeaconID_t NIJLJHGMCHD, CSteamID AIIMBIAIIJE);

		// Token: 0x06000DB7 RID: 3511
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteAsync")]
		public static extern ulong OOLBOIBHJGG(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ, byte[] CMKDMIPPNGN, uint DNFELHKNIIP);

		// Token: 0x06000DB8 RID: 3512
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_SubmitPlayerResult")]
		public static extern BIPOIENHHDB PBJADPGKJAL(IntPtr DNNEHDJMMBE, ulong PKPKIKFPDID, CSteamID MIGICNIFHLE, BOHKOCNDADD HHBJEHPLBHF);

		// Token: 0x06000DB9 RID: 3513
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_EnableDeviceCallbacks")]
		public static extern void LJJHMCCECBH(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DBA RID: 3514
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_DecompressVoice")]
		public static extern PHFILJEGLIL IOCKCBKAIIA(IntPtr DNNEHDJMMBE, byte[] DIKAAONDPOJ, uint PEFPEPEKPFA, byte[] CKNAPJEBFMJ, uint NCJNENKJBMH, out uint NLMHENOBHLM, uint LAKHABNMFKO);

		// Token: 0x06000DBB RID: 3515
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_EndAuthSession")]
		public static extern void LJNEPIACFGC(IntPtr DNNEHDJMMBE, CSteamID EKCOJJGHNAN);

		// Token: 0x06000DBC RID: 3516
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_RemoveItemKeyValueTags")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KIGKFBPBMIC(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE);

		// Token: 0x06000DBD RID: 3517
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_RemoveBrowser")]
		public static extern void PAACFMMLAEB(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD);

		// Token: 0x06000DBE RID: 3518
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_GetResultTimestamp")]
		public static extern uint PBNCIIFGHCM(IntPtr DNNEHDJMMBE, SteamInventoryResult_t PDIGNGHLDII);

		// Token: 0x06000DBF RID: 3519
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamMusicRemote")]
		public static extern IntPtr KPLIKHKHGJE(IntPtr DNNEHDJMMBE, HSteamUser MPMPFFFHHLH, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000DC0 RID: 3520
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamGameServerStats")]
		public static extern IntPtr AIOCMBPKFMN(IntPtr DNNEHDJMMBE, HSteamUser MPMPFFFHHLH, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000DC1 RID: 3521
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetGlyphSVGForActionOrigin")]
		public static extern IntPtr NDHOJLFDNKO(IntPtr DNNEHDJMMBE, FMPMIBBOIAM HAEIMJBBKOH, uint JLKHOFPHIEK);

		// Token: 0x06000DC2 RID: 3522
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileVisibility")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NFMBKMAEEJF(IntPtr DNNEHDJMMBE, PublishedFileUpdateHandle_t OGPKKNDEDFI, OAGKEPBKEMA LAGMCOMKMHL);

		// Token: 0x06000DC3 RID: 3523
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles")]
		public static extern ulong PBAAANJAJLN(IntPtr DNNEHDJMMBE, CSteamID NIDDOGGMHAA, uint CMKIMAENFKO, IntPtr GJEBIGBNIFB, IntPtr GJKNNHOIKFL);

		// Token: 0x06000DC4 RID: 3524
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamRemoteStorage")]
		public static extern IntPtr HNLDCLJIMNK(IntPtr DNNEHDJMMBE, HSteamUser MPMPFFFHHLH, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000DC5 RID: 3525
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_LeaveClanChatRoom")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FKIGKPENAKC(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI);

		// Token: 0x06000DC6 RID: 3526
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetStatFloat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IOAJNOBNJKJ(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out float EENCENODOOG);

		// Token: 0x06000DC7 RID: 3527
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetGlyphPNGForActionOrigin")]
		public static extern IntPtr OLIGCPKGCJI(IntPtr DNNEHDJMMBE, FMPMIBBOIAM HAEIMJBBKOH, GOHKKDPHOKO OOFEPPOCDCO, uint JLKHOFPHIEK);

		// Token: 0x06000DC8 RID: 3528
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestFriendsServerList")]
		public static extern IntPtr CINADGFBJDA(IntPtr DNNEHDJMMBE, AppId_t GDIHJPFCLKN, IntPtr GAFCEHKPODN, uint ODAKHIGHAHO, IntPtr POEEGAJBLKJ);

		// Token: 0x06000DC9 RID: 3529
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetHostedDedicatedServerAddress")]
		public static extern LNFOAHHPFIH ACMHNEANMED(IntPtr DNNEHDJMMBE, out SteamDatagramHostedAddress CDGLLLMEBMM);

		// Token: 0x06000DCA RID: 3530
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_CurrentEntryWillChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FAHEDJMMBOF(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DCB RID: 3531
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetVoiceOptimalSampleRate")]
		public static extern uint FLLAENBPPGE(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DCC RID: 3532
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_LeaveLobby")]
		public static extern void GIAHPBNALPC(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK);

		// Token: 0x06000DCD RID: 3533
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_CreatePublishedFileUpdateRequest")]
		public static extern ulong LAJJNOHLCKB(IntPtr DNNEHDJMMBE, PublishedFileId_t JPCGPJHIMMP);

		// Token: 0x06000DCE RID: 3534
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SteamNetworkingIPAddr_GetFakeIPType")]
		public static extern HJNNPCJKHBP EDHEJGNIIJN(IntPtr DNNEHDJMMBE, ref SteamNetworkingIPAddr KKFIELAEFFK);

		// Token: 0x06000DCF RID: 3535
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_BReleaseSteamPipe")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LBCBEJIOBEO(IntPtr DNNEHDJMMBE, HSteamPipe CMIMOPGNCKB);

		// Token: 0x06000DD0 RID: 3536
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_EnableActionEventCallbacks")]
		public static extern void KNPJOIDCJAK(IntPtr DNNEHDJMMBE, DJPEOEEPIJD KBIIJJJNAND);

		// Token: 0x06000DD1 RID: 3537
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetSecondsSinceAppActive")]
		public static extern uint MBIACOGFMDN(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DD2 RID: 3538
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_SetConnectionName")]
		public static extern void HBHNNHMHLCM(IntPtr DNNEHDJMMBE, HSteamNetConnection CHFHNPJJBEH, MBLFNIBGODG.LJANJDBDBJI HHAAGMIDBHH);

		// Token: 0x06000DD3 RID: 3539
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemotePlay_BSendRemotePlayTogetherInvite")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CCJFOCPOGKE(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE);

		// Token: 0x06000DD4 RID: 3540
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FilePersisted")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JBBJHMPNBEM(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ);

		// Token: 0x06000DD5 RID: 3541
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_GetIPv4")]
		public static extern uint MGIBHEBKPPI(ref SteamNetworkingIPAddr DPAHMPHNPMK);

		// Token: 0x06000DD6 RID: 3542
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_RequestFriendRichPresence")]
		public static extern void BCEGMEFIEOE(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE);

		// Token: 0x06000DD7 RID: 3543
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemDescription")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LCJFKJINPPB(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI IBFLDFKEAON);

		// Token: 0x06000DD8 RID: 3544
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreateHostedDedicatedServerListenSocket")]
		public static extern uint AJCPGNCPAAO(IntPtr DNNEHDJMMBE, int DFBNIOJELNC, int HHJMCLMABHG, [In] [Out] SteamNetworkingConfigValue_t[] NKNGPCMOHCH);

		// Token: 0x06000DD9 RID: 3545
		[DllImport("sdkencryptedappticket64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BIsTicketForApp")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GMPMFMKNNKH([In] [Out] byte[] OJNJHJOIJDG, uint HADHJKAMIBG, AppId_t MINMIFBPLGA);

		// Token: 0x06000DDA RID: 3546
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetConnectionInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GPOOOBBCMDI(IntPtr DNNEHDJMMBE, HSteamNetConnection KLJAKJFEEIC, out HLANBPHOFND OHGGHJNFFMK);

		// Token: 0x06000DDB RID: 3547
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetMotionData")]
		public static extern IKBDHGHBCML IPKCGFJPLLG(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA);

		// Token: 0x06000DDC RID: 3548
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetKeyFocus")]
		public static extern void FGEJJOHAEBN(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, [MarshalAs(UnmanagedType.I1)] bool JBIOPOCFBHM);

		// Token: 0x06000DDD RID: 3549
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_FileLoadDialogResponse")]
		public static extern void FKJOALFHNAG(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD, IntPtr IOFOMCHJKHB);

		// Token: 0x06000DDE RID: 3550
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileNameAndSize")]
		public static extern IntPtr EIAPMMNJKMC(IntPtr DNNEHDJMMBE, int ECOFDINFCIO, out int LLOBOAPLNIL);

		// Token: 0x06000DDF RID: 3551
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetCurrentActionSet")]
		public static extern ulong LMPAACDHCHD(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA);

		// Token: 0x06000DE0 RID: 3552
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetItemPreview")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BHAENHACIDP(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI ELIICLHPPGH);

		// Token: 0x06000DE1 RID: 3553
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTMLSurface_Reload")]
		public static extern void JDOKLHPDADI(IntPtr DNNEHDJMMBE, HHTMLBrowser ILPMIJNLJMD);

		// Token: 0x06000DE2 RID: 3554
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPRequestWasTimedOut")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NDMLMINGGLF(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, out bool KKDANEFHDGN);

		// Token: 0x06000DE3 RID: 3555
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworking_IsDataAvailableOnSocket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KHIFLCBENHA(IntPtr DNNEHDJMMBE, SNetSocket_t MEBHGGLPOGA, out uint KNKBMPIDGDN);

		// Token: 0x06000DE4 RID: 3556
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetItemUpdateProgress")]
		public static extern HBBHKDBDKPF CGHPFNNIDAO(IntPtr DNNEHDJMMBE, UGCUpdateHandle_t CCCPIFNDMGF, out ulong DKONMNHBEPE, out ulong GGIOPEJJECD);

		// Token: 0x06000DE5 RID: 3557
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SetPropertyInt64")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GDAAEFICAHO(IntPtr DNNEHDJMMBE, SteamInventoryUpdateHandle_t CCCPIFNDMGF, SteamItemInstanceID_t FNBDJJIEEJC, MBLFNIBGODG.LJANJDBDBJI AGIKLDMPJPE, long IJGKPMJJNBN);

		// Token: 0x06000DE6 RID: 3558
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_IsOverlayEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ANHJELJFOEG(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DE7 RID: 3559
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_PlayNext")]
		public static extern void ENNHBEMKMHO(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DE8 RID: 3560
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_RegisterProtocolInOverlayBrowser")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LIBDGAHONIO(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI FGICBADELLG);

		// Token: 0x06000DE9 RID: 3561
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_RestartAppIfNecessary")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PHHBPLCHHOP(AppId_t EBDIAOBEHEM);

		// Token: 0x06000DEA RID: 3562
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetMatchAnyTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BKPJNLAGOAG(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, [MarshalAs(UnmanagedType.I1)] bool NELLEBAAGPJ);

		// Token: 0x06000DEB RID: 3563
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementProgressLimitsFloat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HFHOAJJAMGC(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out float MNMLAMMNPCH, out float KGKBJGOADKL);

		// Token: 0x06000DEC RID: 3564
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialogConnectString")]
		public static extern void KLGNHHELFLK(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI KBIODGLGHOJ);

		// Token: 0x06000DED RID: 3565
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserStatFloat")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IPLEOCIKKAD(IntPtr DNNEHDJMMBE, CSteamID AIIMBIAIIJE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, float EJHFKJCPOKE);

		// Token: 0x06000DEE RID: 3566
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRichPresence")]
		public static extern IntPtr HFOAPDHFMKK(IntPtr DNNEHDJMMBE, CSteamID PBAIDADJGLE, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE);

		// Token: 0x06000DEF RID: 3567
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingMessages_SendMessageToUser")]
		public static extern LNFOAHHPFIH EFGBHDDKAAK(IntPtr DNNEHDJMMBE, ref SteamNetworkingIdentity EGNOINEIEFP, IntPtr IGJCKJIFGEK, uint DNFELHKNIIP, int GMOHBFLBHHL, int IGBHFJLECBJ);

		// Token: 0x06000DF0 RID: 3568
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetSpectatorServerName")]
		public static extern void ABJANOHDMPD(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DIHJFHLCJFL);

		// Token: 0x06000DF1 RID: 3569
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCMetadata")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ABGNLBLLIOF(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint GGICIBLJIKI, IntPtr CKNGJJCGEKB, uint DEAMPPIIFAJ);

		// Token: 0x06000DF2 RID: 3570
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetPlayerNickname")]
		public static extern IntPtr NFACFDADOAB(IntPtr DNNEHDJMMBE, CSteamID MIGICNIFHLE);

		// Token: 0x06000DF3 RID: 3571
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_PublishVideo")]
		public static extern ulong BEHNEFPKPOA(IntPtr DNNEHDJMMBE, AOPICOIJGJL MGMNENOFJDM, MBLFNIBGODG.LJANJDBDBJI CBFOLMMHEGL, MBLFNIBGODG.LJANJDBDBJI APECMFFDLPB, MBLFNIBGODG.LJANJDBDBJI GCBFBPOGCJH, AppId_t AIFBKIMDCPH, MBLFNIBGODG.LJANJDBDBJI OGKPBGKNHGB, MBLFNIBGODG.LJANJDBDBJI IBFLDFKEAON, OAGKEPBKEMA LAGMCOMKMHL, IntPtr ICGNMKEHAGF);

		// Token: 0x06000DF4 RID: 3572
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetGenericString")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LMFDGOKPIIH(ref SteamNetworkingIdentity DPAHMPHNPMK, MBLFNIBGODG.LJANJDBDBJI MCOLDANPEJC);

		// Token: 0x06000DF5 RID: 3573
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_RequestGlobalStats")]
		public static extern ulong LNHCEADLGPF(IntPtr DNNEHDJMMBE, int IPJOHDAHMCI);

		// Token: 0x06000DF6 RID: 3574
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamCancel")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IODMOONCADC(IntPtr DNNEHDJMMBE, UGCFileWriteStreamHandle_t ONPIEANOOAB);

		// Token: 0x06000DF7 RID: 3575
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_GetHSteamUser")]
		public static extern int JIFOMLFGFFJ(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DF8 RID: 3576
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_CreateLocalUser")]
		public static extern int FDDGLBOBIFC(IntPtr DNNEHDJMMBE, out HSteamPipe KKBJAOGBGJF, FPKHIMINDDO OONLCOBCNHA);

		// Token: 0x06000DF9 RID: 3577
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetNumAchievements")]
		public static extern uint DJLKFGBKEJM(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DFA RID: 3578
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetHostedDedicatedServerPort")]
		public static extern ushort HMNDCPGIIGM(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DFB RID: 3579
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestContextValue")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CELIGINAEBF(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, ulong AGNMNGMHGHP);

		// Token: 0x06000DFC RID: 3580
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionSteamID")]
		public static extern ulong NEJCKLBKLLB(IntPtr DNNEHDJMMBE, RemotePlaySessionID_t PMCEJNGFFCB);

		// Token: 0x06000DFD RID: 3581
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_GetAppID")]
		public static extern uint JBNAOAJNDAE(IntPtr DNNEHDJMMBE);

		// Token: 0x06000DFE RID: 3582
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_UnsubscribeItem")]
		public static extern ulong DOAEMOJENLF(IntPtr DNNEHDJMMBE, PublishedFileId_t GGEBDPEOMDI);

		// Token: 0x06000DFF RID: 3583
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_QueueDidChange")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LKMFBNPAFLB(IntPtr DNNEHDJMMBE);

		// Token: 0x06000E00 RID: 3584
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetIdentity")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BENBJJDBFGO(IntPtr DNNEHDJMMBE, out SteamNetworkingIdentity JDOLBOKDBLA);

		// Token: 0x06000E01 RID: 3585
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_ResetQueueEntries")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PKMLEJCAEFD(IntPtr DNNEHDJMMBE);

		// Token: 0x06000E02 RID: 3586
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_DeferHTTPRequest")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CAKCBAADJNJ(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK);

		// Token: 0x06000E03 RID: 3587
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_RemoveProperty")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KJMPCHJCBKG(IntPtr DNNEHDJMMBE, SteamInventoryUpdateHandle_t CCCPIFNDMGF, SteamItemInstanceID_t FNBDJJIEEJC, MBLFNIBGODG.LJANJDBDBJI AGIKLDMPJPE);

		// Token: 0x06000E04 RID: 3588
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_SetSpectatorPort")]
		public static extern void CPNFIPJDAII(IntPtr DNNEHDJMMBE, ushort NLFCIPNPGEL);

		// Token: 0x06000E05 RID: 3589
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_SendLobbyChatMsg")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool OLCDIAODKGB(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK, byte[] HGGLJKNKCPP, int KGLAIBGIIGA);

		// Token: 0x06000E06 RID: 3590
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetAllowCachedResponse")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool CMALBJCFJCM(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint LIJJLMCBFJC);

		// Token: 0x06000E07 RID: 3591
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_AddRequiredTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool MPMFGLFEPDN(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, MBLFNIBGODG.LJANJDBDBJI DGJLIDOAHMA);

		// Token: 0x06000E08 RID: 3592
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamMatchmaking")]
		public static extern IntPtr HJJGHGBOELA(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000E09 RID: 3593
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_SetReturnMetadata")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AGDNODCLDML(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, [MarshalAs(UnmanagedType.I1)] bool DMKDKCCBIDI);

		// Token: 0x06000E0A RID: 3594
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamScreenshots_HookScreenshots")]
		public static extern void BEDAIGGEFPJ(IntPtr DNNEHDJMMBE, [MarshalAs(UnmanagedType.I1)] bool LJEHDLFLJGK);

		// Token: 0x06000E0B RID: 3595
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionClientFormFactor")]
		public static extern HKNMEFAFILE GODBDPAODPG(IntPtr DNNEHDJMMBE, RemotePlaySessionID_t PMCEJNGFFCB);

		// Token: 0x06000E0C RID: 3596
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_SetLocalIPBinding")]
		public static extern void GEFOJHBIAEA(IntPtr DNNEHDJMMBE, ref SteamIPAddress_t FLGFECHPNIF, ushort KLBOAFDGBGD);

		// Token: 0x06000E0D RID: 3597
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanChatMemberCount")]
		public static extern int OHKPJBMEOFE(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI);

		// Token: 0x06000E0E RID: 3598
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_BeginAuthSession")]
		public static extern HOKGCIMJHIK AIAHANIPBPF(IntPtr DNNEHDJMMBE, byte[] BDLODBOOBHK, int IJPDCFDLFFA, CSteamID EKCOJJGHNAN);

		// Token: 0x06000E0F RID: 3599
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetConnectionName")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GCPKMKOJEOB(IntPtr DNNEHDJMMBE, HSteamNetConnection CHFHNPJJBEH, IntPtr HHAAGMIDBHH, int AHLKOMMIGLL);

		// Token: 0x06000E10 RID: 3600
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamParentalSettings")]
		public static extern IntPtr PKIDBFLHNAM(IntPtr DNNEHDJMMBE, HSteamUser MPMPFFFHHLH, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000E11 RID: 3601
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetClanOfficerCount")]
		public static extern int IIJKMAAGIEC(IntPtr DNNEHDJMMBE, CSteamID MPGHHEFJJBI);

		// Token: 0x06000E12 RID: 3602
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetFakeIPType")]
		public static extern HJNNPCJKHBP DADELMHCEBE(ref SteamNetworkingIdentity DPAHMPHNPMK);

		// Token: 0x06000E13 RID: 3603
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetSteamID")]
		public static extern void OILGMBGKOPD(ref SteamNetworkingIdentity DPAHMPHNPMK, ulong EKCOJJGHNAN);

		// Token: 0x06000E14 RID: 3604
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ManualDispatch_Init")]
		public static extern void KILJPCHBMDJ();

		// Token: 0x06000E15 RID: 3605
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetConnectedControllers")]
		public static extern int CBLFMLCLPNO(IntPtr DNNEHDJMMBE, [In] [Out] InputHandle_t[] HKKMNPGFODA);

		// Token: 0x06000E16 RID: 3606
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_TriggerSimpleHapticEvent")]
		public static extern void CBFMIDELMON(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, NLFLBPLHLPN DGFFJPMGNCK, byte LMJGIJPMDKD, char GJKHIODCFMK, byte BHOHONHOJFA, char GMECNLHGGNB);

		// Token: 0x06000E17 RID: 3607
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_GetLaunchCommandLine")]
		public static extern int LOBJNCIPMCN(IntPtr DNNEHDJMMBE, IntPtr FGJIDKKCOLJ, int HIFFLHCBNIM);

		// Token: 0x06000E18 RID: 3608
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_IsLocalHost")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DBMDJOLLDLA(ref SteamNetworkingIPAddr DPAHMPHNPMK);

		// Token: 0x06000E19 RID: 3609
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameSearch_EndGame")]
		public static extern BIPOIENHHDB BOHDFMFOMHH(IntPtr DNNEHDJMMBE, ulong PKPKIKFPDID);

		// Token: 0x06000E1A RID: 3610
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusic_BIsEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FNEFJOLDMIM(IntPtr DNNEHDJMMBE);

		// Token: 0x06000E1B RID: 3611
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWrite")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GIBHJDDKIKJ(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI BGENGGGJLCJ, byte[] CMKDMIPPNGN, int DNFELHKNIIP);

		// Token: 0x06000E1C RID: 3612
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_IsEqualTo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AACLNIPKEHB(ref SteamNetworkingIPAddr DPAHMPHNPMK, ref SteamNetworkingIPAddr OBNBCGOIMKE);

		// Token: 0x06000E1D RID: 3613
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_ComputeNewPlayerCompatibility")]
		public static extern ulong NMOIHHLDIJK(IntPtr DNNEHDJMMBE, CSteamID MPBFBEOONGD);

		// Token: 0x06000E1E RID: 3614
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetItemDownloadInfo")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FCICLBGDDCG(IntPtr DNNEHDJMMBE, PublishedFileId_t GGEBDPEOMDI, out ulong CPEIDJEGJBL, out ulong GGIOPEJJECD);

		// Token: 0x06000E1F RID: 3615
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_ActivateActionSetLayer")]
		public static extern void OOMFKFEHFHF(IntPtr DNNEHDJMMBE, InputHandle_t PPEBFFGKFLA, InputActionSetHandle_t PKGPLBJAJHI);

		// Token: 0x06000E20 RID: 3616
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievement")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool HHHMPMAGOJK(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI DECMMMNKHKM, out bool LAEOHDNHABG);

		// Token: 0x06000E21 RID: 3617
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetListenSocketAddress")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool PAFKPFCJPEH(IntPtr DNNEHDJMMBE, HSteamListenSocket MEBHGGLPOGA, out SteamNetworkingIPAddr CKLNODNMLMM);

		// Token: 0x06000E22 RID: 3618
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryUGCDetailsRequest")]
		public static extern ulong FDMNHAKGMNC(IntPtr DNNEHDJMMBE, [In] [Out] PublishedFileId_t[] LMJGFJPENLP, uint GEALEAJEMDJ);

		// Token: 0x06000E23 RID: 3619
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetDisplayName")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool JGDDKIGEPLM(IntPtr DNNEHDJMMBE, MBLFNIBGODG.LJANJDBDBJI JJBBANMNDOA);

		// Token: 0x06000E24 RID: 3620
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMatchmaking_RequestLobbyData")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ICCIPFKIHII(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK);

		// Token: 0x06000E25 RID: 3621
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupCount")]
		public static extern int OMEJBFOELDB(IntPtr DNNEHDJMMBE);

		// Token: 0x06000E26 RID: 3622
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInventory_SubmitUpdateProperties")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ILAFIKGGPLB(IntPtr DNNEHDJMMBE, SteamInventoryUpdateHandle_t CCCPIFNDMGF, out SteamInventoryResult_t DONIEBGGKMH);

		// Token: 0x06000E27 RID: 3623
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamClient_GetISteamUGC")]
		public static extern IntPtr ONHJKBJAGIM(IntPtr DNNEHDJMMBE, HSteamUser OOFCLIELINA, HSteamPipe CMIMOPGNCKB, MBLFNIBGODG.LJANJDBDBJI LPDEOHEBKAI);

		// Token: 0x06000E28 RID: 3624
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUtils_SetOverlayNotificationInset")]
		public static extern void NHPANDNPNJA(IntPtr DNNEHDJMMBE, int LFFPGLICCAO, int OOFCFPIGILI);

		// Token: 0x06000E29 RID: 3625
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUserStats_GetMostAchievedAchievementInfo")]
		public static extern int AIAAODIPJFN(IntPtr DNNEHDJMMBE, IntPtr DECMMMNKHKM, uint JLFBFLAIGJD, out float CJPPICBGGJJ, out bool LAEOHDNHABG);

		// Token: 0x06000E2A RID: 3626
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_HandleIncomingPacket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LHJJGHMDMAA(IntPtr DNNEHDJMMBE, byte[] EENCENODOOG, int PBINDFLMANO, uint DIOPGMNFEGG, ushort NAHIAGMMJLN);

		// Token: 0x06000E2B RID: 3627
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionClientName")]
		public static extern IntPtr LOCOLFDEBOF(IntPtr DNNEHDJMMBE, RemotePlaySessionID_t PMCEJNGFFCB);

		// Token: 0x06000E2C RID: 3628
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumerateUserSubscribedFiles")]
		public static extern ulong BACLLOBDGOC(IntPtr DNNEHDJMMBE, uint CMKIMAENFKO);

		// Token: 0x06000E2D RID: 3629
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryFirstUGCKeyValueTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool GEBKBGACJMK(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint GGICIBLJIKI, MBLFNIBGODG.LJANJDBDBJI ILEEIANOGJE, IntPtr OIABIHIJPJN, uint BJPOEIBIELI);

		// Token: 0x06000E2E RID: 3630
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamMusicRemote_SetPNGIcon_64x64")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool DHDEMKBDMLE(IntPtr DNNEHDJMMBE, byte[] KMHBNOFCMCJ, uint NFIHMJGHGAA);

		// Token: 0x06000E2F RID: 3631
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestHeaderValue")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool FBKIJHDBCAA(IntPtr DNNEHDJMMBE, HTTPRequestHandle JMMGPGJONFK, MBLFNIBGODG.LJANJDBDBJI LFGHDBMIGJD, MBLFNIBGODG.LJANJDBDBJI DMCOPOKBGJG);

		// Token: 0x06000E30 RID: 3632
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCKeyValueTag")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool KECBKJNBOIJ(IntPtr DNNEHDJMMBE, UGCQueryHandle_t CCCPIFNDMGF, uint GGICIBLJIKI, uint MMLFJINIIDF, IntPtr ILEEIANOGJE, uint IKJPHBILMAC, IntPtr OIABIHIJPJN, uint BJPOEIBIELI);

		// Token: 0x06000E31 RID: 3633
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamInput_GetGamepadIndexForController")]
		public static extern int EHAGPFDOGJE(IntPtr DNNEHDJMMBE, InputHandle_t FGDJEJEFEKC);

		// Token: 0x06000E32 RID: 3634
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_InstallDLC")]
		public static extern void HGELFMBJEDA(IntPtr DNNEHDJMMBE, AppId_t MINMIFBPLGA);

		// Token: 0x06000E33 RID: 3635
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingIdentity_ParseString")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool LOHCIIOIPPB(ref SteamNetworkingIdentity DPAHMPHNPMK, MBLFNIBGODG.LJANJDBDBJI OBJAIHPGOJN);

		// Token: 0x06000E34 RID: 3636
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamGameServer_GetNextOutgoingPacket")]
		public static extern int CODCIEMOICN(IntPtr DNNEHDJMMBE, byte[] KGKGODAJIAJ, int FGIOPEKLLIA, out uint CHKOLGPCIDP, out ushort AMHMLCAPDGO);

		// Token: 0x06000E35 RID: 3637
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetPublishedItemVoteDetails")]
		public static extern ulong BLIKNLCEAPM(IntPtr DNNEHDJMMBE, PublishedFileId_t JPCGPJHIMMP);

		// Token: 0x06000E36 RID: 3638
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayRemotePlayTogetherInviteDialog")]
		public static extern void APDOOONEMBM(IntPtr DNNEHDJMMBE, CSteamID FEJDPLKLGOK);

		// Token: 0x06000E37 RID: 3639
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneRequiringVerification")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool NDBHKENBDGG(IntPtr DNNEHDJMMBE);

		// Token: 0x06000E38 RID: 3640
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamApps_BIsLowViolence")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BIHJLBCCDEI(IntPtr DNNEHDJMMBE);

		// Token: 0x06000E39 RID: 3641
		[DllImport("steam_api64", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_ISteamUGC_DeleteItem")]
		public static extern ulong MDENCNAGGEF(IntPtr DNNEHDJMMBE, PublishedFileId_t GGEBDPEOMDI);

		// Token: 0x04000397 RID: 919
		internal const string NFFKJLMIPFN = "steam_api64";

		// Token: 0x04000398 RID: 920
		internal const string GHPFCKOJNPO = "sdkencryptedappticket64";
	}
}
