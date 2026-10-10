using System;

// Token: 0x020003C3 RID: 963
public enum BGHLMGPPCNN
{
	// Token: 0x04002129 RID: 8489
	mntOfferShow,
	// Token: 0x0400212A RID: 8490
	mntOfferClose,
	// Token: 0x0400212B RID: 8491
	mntOfferCont,
	// Token: 0x0400212C RID: 8492
	mntRemAdsShow,
	// Token: 0x0400212D RID: 8493
	mntRemAdsClose,
	// Token: 0x0400212E RID: 8494
	mntRemAdsCont,
	// Token: 0x0400212F RID: 8495
	cdnLbyLoad,
	// Token: 0x04002130 RID: 8496
	cdnLbyLoadPt1,
	// Token: 0x04002131 RID: 8497
	cdnLbyLoadPt2,
	// Token: 0x04002132 RID: 8498
	cdnSplToSty,
	// Token: 0x04002133 RID: 8499
	cdnStyToAvt,
	// Token: 0x04002134 RID: 8500
	cdnStyToRew,
	// Token: 0x04002135 RID: 8501
	cdnStyOnDemand,
	// Token: 0x04002136 RID: 8502
	cdnLbyToAvt,
	// Token: 0x04002137 RID: 8503
	cdnLbyToSpl,
	// Token: 0x04002138 RID: 8504
	d1Open,
	// Token: 0x04002139 RID: 8505
	d1NewUsr,
	// Token: 0x0400213A RID: 8506
	d1BackendSt,
	// Token: 0x0400213B RID: 8507
	d1CdnSt,
	// Token: 0x0400213C RID: 8508
	d1LobbyOpen,
	// Token: 0x0400213D RID: 8509
	d1LobbyOfrC0,
	// Token: 0x0400213E RID: 8510
	d1LobbyOfrC1,
	// Token: 0x0400213F RID: 8511
	d1LobbyOfrC2,
	// Token: 0x04002140 RID: 8512
	d1LobbyLoaded,
	// Token: 0x04002141 RID: 8513
	d1SigninSt,
	// Token: 0x04002142 RID: 8514
	d1SplashCdnSt,
	// Token: 0x04002143 RID: 8515
	d1StoryCdnSt,
	// Token: 0x04002144 RID: 8516
	d1ChaptSt,
	// Token: 0x04002145 RID: 8517
	d1ChaptStOfr,
	// Token: 0x04002146 RID: 8518
	d1ChaptStOld,
	// Token: 0x04002147 RID: 8519
	d1ChaptEnd,
	// Token: 0x04002148 RID: 8520
	d1ChaptEndOfr,
	// Token: 0x04002149 RID: 8521
	d1ChaptEndOld,
	// Token: 0x0400214A RID: 8522
	d1Reward,
	// Token: 0x0400214B RID: 8523
	d1AdSplashSt,
	// Token: 0x0400214C RID: 8524
	d1AdSplashEnd,
	// Token: 0x0400214D RID: 8525
	d1AdStorySt,
	// Token: 0x0400214E RID: 8526
	d1AdStoryEnd,
	// Token: 0x0400214F RID: 8527
	d1StoryTap,
	// Token: 0x04002150 RID: 8528
	bugCmeta0Ch,
	// Token: 0x04002151 RID: 8529
	bugDupStr,
	// Token: 0x04002152 RID: 8530
	bugCdnDdlck,
	// Token: 0x04002153 RID: 8531
	gmLocOnb,
	// Token: 0x04002154 RID: 8532
	gmLocSett,
	// Token: 0x04002155 RID: 8533
	gnrLocOnb,
	// Token: 0x04002156 RID: 8534
	vidsup,
	// Token: 0x04002157 RID: 8535
	vidnosup,
	// Token: 0x04002158 RID: 8536
	resloadalw,
	// Token: 0x04002159 RID: 8537
	resloadskp,
	// Token: 0x0400215A RID: 8538
	postsup,
	// Token: 0x0400215B RID: 8539
	postnosup,
	// Token: 0x0400215C RID: 8540
	socEditName,
	// Token: 0x0400215D RID: 8541
	socEditCredo,
	// Token: 0x0400215E RID: 8542
	socEditLove,
	// Token: 0x0400215F RID: 8543
	socEditPic,
	// Token: 0x04002160 RID: 8544
	cdnLbyToPrf,
	// Token: 0x04002161 RID: 8545
	cdnPrfToCut,
	// Token: 0x04002162 RID: 8546
	socCutSave,
	// Token: 0x04002163 RID: 8547
	socCutView,
	// Token: 0x04002164 RID: 8548
	slt,
	// Token: 0x04002165 RID: 8549
	cdnPrfToCrd,
	// Token: 0x04002166 RID: 8550
	cdnLbyToWof,
	// Token: 0x04002167 RID: 8551
	cdnWofToCut,
	// Token: 0x04002168 RID: 8552
	cdnWofToSkt,
	// Token: 0x04002169 RID: 8553
	cdnWofToCrd,
	// Token: 0x0400216A RID: 8554
	cdnWofToLpt,
	// Token: 0x0400216B RID: 8555
	under3,
	// Token: 0x0400216C RID: 8556
	under10,
	// Token: 0x0400216D RID: 8557
	under30,
	// Token: 0x0400216E RID: 8558
	under50,
	// Token: 0x0400216F RID: 8559
	under100,
	// Token: 0x04002170 RID: 8560
	under500,
	// Token: 0x04002171 RID: 8561
	under1000,
	// Token: 0x04002172 RID: 8562
	under5000,
	// Token: 0x04002173 RID: 8563
	under10000,
	// Token: 0x04002174 RID: 8564
	under100000,
	// Token: 0x04002175 RID: 8565
	bugPrgrReset,
	// Token: 0x04002176 RID: 8566
	lbySrvTry,
	// Token: 0x04002177 RID: 8567
	lbyCdnTry,
	// Token: 0x04002178 RID: 8568
	bugSltOutOfRng,
	// Token: 0x04002179 RID: 8569
	cdnStyToLng,
	// Token: 0x0400217A RID: 8570
	cdnLbyToLng,
	// Token: 0x0400217B RID: 8571
	cdnLbyToSks,
	// Token: 0x0400217C RID: 8572
	nofw,
	// Token: 0x0400217D RID: 8573
	dur1m,
	// Token: 0x0400217E RID: 8574
	dur3m,
	// Token: 0x0400217F RID: 8575
	dur6m,
	// Token: 0x04002180 RID: 8576
	dur12m,
	// Token: 0x04002181 RID: 8577
	subHint,
	// Token: 0x04002182 RID: 8578
	subAvColl,
	// Token: 0x04002183 RID: 8579
	subLdgTheme,
	// Token: 0x04002184 RID: 8580
	subLook,
	// Token: 0x04002185 RID: 8581
	subLngLook,
	// Token: 0x04002186 RID: 8582
	subFwd,
	// Token: 0x04002187 RID: 8583
	subAuto,
	// Token: 0x04002188 RID: 8584
	subRewind,
	// Token: 0x04002189 RID: 8585
	subUndo,
	// Token: 0x0400218A RID: 8586
	subChpSnap,
	// Token: 0x0400218B RID: 8587
	subSaveSlt,
	// Token: 0x0400218C RID: 8588
	cdnLbyToSkt,
	// Token: 0x0400218D RID: 8589
	cdnLbyToLdt,
	// Token: 0x0400218E RID: 8590
	cens,
	// Token: 0x0400218F RID: 8591
	intl
}
