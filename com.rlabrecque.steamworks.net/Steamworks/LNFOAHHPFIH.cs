using System;

namespace Steamworks
{
	// Token: 0x0200002A RID: 42
	public enum LNFOAHHPFIH
	{
		// Token: 0x04000160 RID: 352
		k_EResultNone,
		// Token: 0x04000161 RID: 353
		k_EResultOK,
		// Token: 0x04000162 RID: 354
		k_EResultFail,
		// Token: 0x04000163 RID: 355
		k_EResultNoConnection,
		// Token: 0x04000164 RID: 356
		k_EResultInvalidPassword = 5,
		// Token: 0x04000165 RID: 357
		k_EResultLoggedInElsewhere,
		// Token: 0x04000166 RID: 358
		k_EResultInvalidProtocolVer,
		// Token: 0x04000167 RID: 359
		k_EResultInvalidParam,
		// Token: 0x04000168 RID: 360
		k_EResultFileNotFound,
		// Token: 0x04000169 RID: 361
		k_EResultBusy,
		// Token: 0x0400016A RID: 362
		k_EResultInvalidState,
		// Token: 0x0400016B RID: 363
		k_EResultInvalidName,
		// Token: 0x0400016C RID: 364
		k_EResultInvalidEmail,
		// Token: 0x0400016D RID: 365
		k_EResultDuplicateName,
		// Token: 0x0400016E RID: 366
		k_EResultAccessDenied,
		// Token: 0x0400016F RID: 367
		k_EResultTimeout,
		// Token: 0x04000170 RID: 368
		k_EResultBanned,
		// Token: 0x04000171 RID: 369
		k_EResultAccountNotFound,
		// Token: 0x04000172 RID: 370
		k_EResultInvalidSteamID,
		// Token: 0x04000173 RID: 371
		k_EResultServiceUnavailable,
		// Token: 0x04000174 RID: 372
		k_EResultNotLoggedOn,
		// Token: 0x04000175 RID: 373
		k_EResultPending,
		// Token: 0x04000176 RID: 374
		k_EResultEncryptionFailure,
		// Token: 0x04000177 RID: 375
		k_EResultInsufficientPrivilege,
		// Token: 0x04000178 RID: 376
		k_EResultLimitExceeded,
		// Token: 0x04000179 RID: 377
		k_EResultRevoked,
		// Token: 0x0400017A RID: 378
		k_EResultExpired,
		// Token: 0x0400017B RID: 379
		k_EResultAlreadyRedeemed,
		// Token: 0x0400017C RID: 380
		k_EResultDuplicateRequest,
		// Token: 0x0400017D RID: 381
		k_EResultAlreadyOwned,
		// Token: 0x0400017E RID: 382
		k_EResultIPNotFound,
		// Token: 0x0400017F RID: 383
		k_EResultPersistFailed,
		// Token: 0x04000180 RID: 384
		k_EResultLockingFailed,
		// Token: 0x04000181 RID: 385
		k_EResultLogonSessionReplaced,
		// Token: 0x04000182 RID: 386
		k_EResultConnectFailed,
		// Token: 0x04000183 RID: 387
		k_EResultHandshakeFailed,
		// Token: 0x04000184 RID: 388
		k_EResultIOFailure,
		// Token: 0x04000185 RID: 389
		k_EResultRemoteDisconnect,
		// Token: 0x04000186 RID: 390
		k_EResultShoppingCartNotFound,
		// Token: 0x04000187 RID: 391
		k_EResultBlocked,
		// Token: 0x04000188 RID: 392
		k_EResultIgnored,
		// Token: 0x04000189 RID: 393
		k_EResultNoMatch,
		// Token: 0x0400018A RID: 394
		k_EResultAccountDisabled,
		// Token: 0x0400018B RID: 395
		k_EResultServiceReadOnly,
		// Token: 0x0400018C RID: 396
		k_EResultAccountNotFeatured,
		// Token: 0x0400018D RID: 397
		k_EResultAdministratorOK,
		// Token: 0x0400018E RID: 398
		k_EResultContentVersion,
		// Token: 0x0400018F RID: 399
		k_EResultTryAnotherCM,
		// Token: 0x04000190 RID: 400
		k_EResultPasswordRequiredToKickSession,
		// Token: 0x04000191 RID: 401
		k_EResultAlreadyLoggedInElsewhere,
		// Token: 0x04000192 RID: 402
		k_EResultSuspended,
		// Token: 0x04000193 RID: 403
		k_EResultCancelled,
		// Token: 0x04000194 RID: 404
		k_EResultDataCorruption,
		// Token: 0x04000195 RID: 405
		k_EResultDiskFull,
		// Token: 0x04000196 RID: 406
		k_EResultRemoteCallFailed,
		// Token: 0x04000197 RID: 407
		k_EResultPasswordUnset,
		// Token: 0x04000198 RID: 408
		k_EResultExternalAccountUnlinked,
		// Token: 0x04000199 RID: 409
		k_EResultPSNTicketInvalid,
		// Token: 0x0400019A RID: 410
		k_EResultExternalAccountAlreadyLinked,
		// Token: 0x0400019B RID: 411
		k_EResultRemoteFileConflict,
		// Token: 0x0400019C RID: 412
		k_EResultIllegalPassword,
		// Token: 0x0400019D RID: 413
		k_EResultSameAsPreviousValue,
		// Token: 0x0400019E RID: 414
		k_EResultAccountLogonDenied,
		// Token: 0x0400019F RID: 415
		k_EResultCannotUseOldPassword,
		// Token: 0x040001A0 RID: 416
		k_EResultInvalidLoginAuthCode,
		// Token: 0x040001A1 RID: 417
		k_EResultAccountLogonDeniedNoMail,
		// Token: 0x040001A2 RID: 418
		k_EResultHardwareNotCapableOfIPT,
		// Token: 0x040001A3 RID: 419
		k_EResultIPTInitError,
		// Token: 0x040001A4 RID: 420
		k_EResultParentalControlRestricted,
		// Token: 0x040001A5 RID: 421
		k_EResultFacebookQueryError,
		// Token: 0x040001A6 RID: 422
		k_EResultExpiredLoginAuthCode,
		// Token: 0x040001A7 RID: 423
		k_EResultIPLoginRestrictionFailed,
		// Token: 0x040001A8 RID: 424
		k_EResultAccountLockedDown,
		// Token: 0x040001A9 RID: 425
		k_EResultAccountLogonDeniedVerifiedEmailRequired,
		// Token: 0x040001AA RID: 426
		k_EResultNoMatchingURL,
		// Token: 0x040001AB RID: 427
		k_EResultBadResponse,
		// Token: 0x040001AC RID: 428
		k_EResultRequirePasswordReEntry,
		// Token: 0x040001AD RID: 429
		k_EResultValueOutOfRange,
		// Token: 0x040001AE RID: 430
		k_EResultUnexpectedError,
		// Token: 0x040001AF RID: 431
		k_EResultDisabled,
		// Token: 0x040001B0 RID: 432
		k_EResultInvalidCEGSubmission,
		// Token: 0x040001B1 RID: 433
		k_EResultRestrictedDevice,
		// Token: 0x040001B2 RID: 434
		k_EResultRegionLocked,
		// Token: 0x040001B3 RID: 435
		k_EResultRateLimitExceeded,
		// Token: 0x040001B4 RID: 436
		k_EResultAccountLoginDeniedNeedTwoFactor,
		// Token: 0x040001B5 RID: 437
		k_EResultItemDeleted,
		// Token: 0x040001B6 RID: 438
		k_EResultAccountLoginDeniedThrottle,
		// Token: 0x040001B7 RID: 439
		k_EResultTwoFactorCodeMismatch,
		// Token: 0x040001B8 RID: 440
		k_EResultTwoFactorActivationCodeMismatch,
		// Token: 0x040001B9 RID: 441
		k_EResultAccountAssociatedToMultiplePartners,
		// Token: 0x040001BA RID: 442
		k_EResultNotModified,
		// Token: 0x040001BB RID: 443
		k_EResultNoMobileDevice,
		// Token: 0x040001BC RID: 444
		k_EResultTimeNotSynced,
		// Token: 0x040001BD RID: 445
		k_EResultSmsCodeFailed,
		// Token: 0x040001BE RID: 446
		k_EResultAccountLimitExceeded,
		// Token: 0x040001BF RID: 447
		k_EResultAccountActivityLimitExceeded,
		// Token: 0x040001C0 RID: 448
		k_EResultPhoneActivityLimitExceeded,
		// Token: 0x040001C1 RID: 449
		k_EResultRefundToWallet,
		// Token: 0x040001C2 RID: 450
		k_EResultEmailSendFailure,
		// Token: 0x040001C3 RID: 451
		k_EResultNotSettled,
		// Token: 0x040001C4 RID: 452
		k_EResultNeedCaptcha,
		// Token: 0x040001C5 RID: 453
		k_EResultGSLTDenied,
		// Token: 0x040001C6 RID: 454
		k_EResultGSOwnerDenied,
		// Token: 0x040001C7 RID: 455
		k_EResultInvalidItemType,
		// Token: 0x040001C8 RID: 456
		k_EResultIPBanned,
		// Token: 0x040001C9 RID: 457
		k_EResultGSLTExpired,
		// Token: 0x040001CA RID: 458
		k_EResultInsufficientFunds,
		// Token: 0x040001CB RID: 459
		k_EResultTooManyPending,
		// Token: 0x040001CC RID: 460
		k_EResultNoSiteLicensesFound,
		// Token: 0x040001CD RID: 461
		k_EResultWGNetworkSendExceeded,
		// Token: 0x040001CE RID: 462
		k_EResultAccountNotFriends,
		// Token: 0x040001CF RID: 463
		k_EResultLimitedUserAccount,
		// Token: 0x040001D0 RID: 464
		k_EResultCantRemoveItem,
		// Token: 0x040001D1 RID: 465
		k_EResultAccountDeleted,
		// Token: 0x040001D2 RID: 466
		k_EResultExistingUserCancelledLicense,
		// Token: 0x040001D3 RID: 467
		k_EResultCommunityCooldown,
		// Token: 0x040001D4 RID: 468
		k_EResultNoLauncherSpecified,
		// Token: 0x040001D5 RID: 469
		k_EResultMustAgreeToSSA,
		// Token: 0x040001D6 RID: 470
		k_EResultLauncherMigrated,
		// Token: 0x040001D7 RID: 471
		k_EResultSteamRealmMismatch,
		// Token: 0x040001D8 RID: 472
		k_EResultInvalidSignature,
		// Token: 0x040001D9 RID: 473
		k_EResultParseFailure,
		// Token: 0x040001DA RID: 474
		k_EResultNoVerifiedPhone
	}
}
