using System;

// Token: 0x02000335 RID: 821
public enum FFPHBMFGCNN
{
	// Token: 0x04001C16 RID: 7190
	reqFailSem,
	// Token: 0x04001C17 RID: 7191
	reqInfnt,
	// Token: 0x04001C18 RID: 7192
	reqCback1,
	// Token: 0x04001C19 RID: 7193
	reqCback2,
	// Token: 0x04001C1A RID: 7194
	reqExc,
	// Token: 0x04001C1B RID: 7195
	reqExcRpt,
	// Token: 0x04001C1C RID: 7196
	mntOffer,
	// Token: 0x04001C1D RID: 7197
	mntRemAds,
	// Token: 0x04001C1E RID: 7198
	dldStart,
	// Token: 0x04001C1F RID: 7199
	dldCompl,
	// Token: 0x04001C20 RID: 7200
	dldFail,
	// Token: 0x04001C21 RID: 7201
	d1Board,
	// Token: 0x04001C22 RID: 7202
	chpStart,
	// Token: 0x04001C23 RID: 7203
	chpCompl,
	// Token: 0x04001C24 RID: 7204
	handBfix,
	// Token: 0x04001C25 RID: 7205
	gmLite,
	// Token: 0x04001C26 RID: 7206
	gmFull,
	// Token: 0x04001C27 RID: 7207
	video,
	// Token: 0x04001C28 RID: 7208
	tier,
	// Token: 0x04001C29 RID: 7209
	ram,
	// Token: 0x04001C2A RID: 7210
	post,
	// Token: 0x04001C2B RID: 7211
	socView,
	// Token: 0x04001C2C RID: 7212
	socShuffle,
	// Token: 0x04001C2D RID: 7213
	socEdit,
	// Token: 0x04001C2E RID: 7214
	socCut,
	// Token: 0x04001C2F RID: 7215
	socReport,
	// Token: 0x04001C30 RID: 7216
	newSaveErr0,
	// Token: 0x04001C31 RID: 7217
	newSaveErr1,
	// Token: 0x04001C32 RID: 7218
	newSaveErr2,
	// Token: 0x04001C33 RID: 7219
	accCollision,
	// Token: 0x04001C34 RID: 7220
	cdnSigUltra,
	// Token: 0x04001C35 RID: 7221
	cdnSigHigh,
	// Token: 0x04001C36 RID: 7222
	cdnSigMid,
	// Token: 0x04001C37 RID: 7223
	cdnSigLow,
	// Token: 0x04001C38 RID: 7224
	cdnCmnTimeout,
	// Token: 0x04001C39 RID: 7225
	cdnCmnTimeoutRetry,
	// Token: 0x04001C3A RID: 7226
	cdnForceOne,
	// Token: 0x04001C3B RID: 7227
	sltChng,
	// Token: 0x04001C3C RID: 7228
	cdViewCardFull,
	// Token: 0x04001C3D RID: 7229
	cdSendCard,
	// Token: 0x04001C3E RID: 7230
	cdSendCardMsg,
	// Token: 0x04001C3F RID: 7231
	cdSendCardUID,
	// Token: 0x04001C40 RID: 7232
	cdSendCardPID,
	// Token: 0x04001C41 RID: 7233
	frSendMsg,
	// Token: 0x04001C42 RID: 7234
	frSendGems,
	// Token: 0x04001C43 RID: 7235
	frRequest,
	// Token: 0x04001C44 RID: 7236
	frRequestUID,
	// Token: 0x04001C45 RID: 7237
	frRequestPID,
	// Token: 0x04001C46 RID: 7238
	frAccept,
	// Token: 0x04001C47 RID: 7239
	frReject,
	// Token: 0x04001C48 RID: 7240
	frDelete,
	// Token: 0x04001C49 RID: 7241
	frView,
	// Token: 0x04001C4A RID: 7242
	frReachHof,
	// Token: 0x04001C4B RID: 7243
	frAccHoff,
	// Token: 0x04001C4C RID: 7244
	bdgUnlock,
	// Token: 0x04001C4D RID: 7245
	wofFree,
	// Token: 0x04001C4E RID: 7246
	wofPaid,
	// Token: 0x04001C4F RID: 7247
	wofDblOddsAct,
	// Token: 0x04001C50 RID: 7248
	coVerah,
	// Token: 0x04001C51 RID: 7249
	coVerdvcid,
	// Token: 0x04001C52 RID: 7250
	coVerpsk,
	// Token: 0x04001C53 RID: 7251
	coVerfailed,
	// Token: 0x04001C54 RID: 7252
	ccFixForw,
	// Token: 0x04001C55 RID: 7253
	ccFixBack,
	// Token: 0x04001C56 RID: 7254
	frRequestNick,
	// Token: 0x04001C57 RID: 7255
	cdSendCardNick,
	// Token: 0x04001C58 RID: 7256
	profUpdFriends,
	// Token: 0x04001C59 RID: 7257
	profNoDistOn,
	// Token: 0x04001C5A RID: 7258
	profNoDistOff,
	// Token: 0x04001C5B RID: 7259
	engAmt,
	// Token: 0x04001C5C RID: 7260
	hardAmt,
	// Token: 0x04001C5D RID: 7261
	sp0Amt,
	// Token: 0x04001C5E RID: 7262
	sp1Amt,
	// Token: 0x04001C5F RID: 7263
	sp2Amt,
	// Token: 0x04001C60 RID: 7264
	colCds,
	// Token: 0x04001C61 RID: 7265
	frCount,
	// Token: 0x04001C62 RID: 7266
	lbyStart,
	// Token: 0x04001C63 RID: 7267
	lbyEnd,
	// Token: 0x04001C64 RID: 7268
	quickConnect,
	// Token: 0x04001C65 RID: 7269
	unsyncErr,
	// Token: 0x04001C66 RID: 7270
	subYes,
	// Token: 0x04001C67 RID: 7271
	durPick,
	// Token: 0x04001C68 RID: 7272
	durPickStore,
	// Token: 0x04001C69 RID: 7273
	durPickWeb,
	// Token: 0x04001C6A RID: 7274
	durPickOfferStore,
	// Token: 0x04001C6B RID: 7275
	durPickOfferWeb,
	// Token: 0x04001C6C RID: 7276
	reqOk,
	// Token: 0x04001C6D RID: 7277
	sltCopy,
	// Token: 0x04001C6E RID: 7278
	sltDup
}
