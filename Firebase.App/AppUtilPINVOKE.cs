using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Firebase
{
	// Token: 0x0200001A RID: 26
	internal class AppUtilPINVOKE
	{
		// Token: 0x060001B0 RID: 432
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_ExportFix")]
		public static extern void ExportFix();

		// Token: 0x060001B1 RID: 433
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_FutureBase__SWIG_0")]
		public static extern IntPtr new_FutureBase__SWIG_0();

		// Token: 0x060001B2 RID: 434
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_delete_FutureBase")]
		public static extern void delete_FutureBase(HandleRef jarg1);

		// Token: 0x060001B3 RID: 435
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_FutureBase__SWIG_1")]
		public static extern IntPtr new_FutureBase__SWIG_1(HandleRef jarg1);

		// Token: 0x060001B4 RID: 436
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureBase_Release")]
		public static extern void FutureBase_Release(HandleRef jarg1);

		// Token: 0x060001B5 RID: 437
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureBase_status")]
		public static extern int FutureBase_status(HandleRef jarg1);

		// Token: 0x060001B6 RID: 438
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureBase_error")]
		public static extern int FutureBase_error(HandleRef jarg1);

		// Token: 0x060001B7 RID: 439
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureBase_error_message")]
		public static extern string FutureBase_error_message(HandleRef jarg1);

		// Token: 0x060001B8 RID: 440
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_StringStringMap__SWIG_0")]
		public static extern IntPtr new_StringStringMap__SWIG_0();

		// Token: 0x060001B9 RID: 441
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_StringStringMap__SWIG_1")]
		public static extern IntPtr new_StringStringMap__SWIG_1(HandleRef jarg1);

		// Token: 0x060001BA RID: 442
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringStringMap_size")]
		public static extern uint StringStringMap_size(HandleRef jarg1);

		// Token: 0x060001BB RID: 443
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringStringMap_empty")]
		public static extern bool StringStringMap_empty(HandleRef jarg1);

		// Token: 0x060001BC RID: 444
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringStringMap_Clear")]
		public static extern void StringStringMap_Clear(HandleRef jarg1);

		// Token: 0x060001BD RID: 445
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringStringMap_getitem")]
		public static extern string StringStringMap_getitem(HandleRef jarg1, string jarg2);

		// Token: 0x060001BE RID: 446
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringStringMap_setitem")]
		public static extern void StringStringMap_setitem(HandleRef jarg1, string jarg2, string jarg3);

		// Token: 0x060001BF RID: 447
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringStringMap_ContainsKey")]
		public static extern bool StringStringMap_ContainsKey(HandleRef jarg1, string jarg2);

		// Token: 0x060001C0 RID: 448
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringStringMap_Add")]
		public static extern void StringStringMap_Add(HandleRef jarg1, string jarg2, string jarg3);

		// Token: 0x060001C1 RID: 449
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringStringMap_Remove")]
		public static extern bool StringStringMap_Remove(HandleRef jarg1, string jarg2);

		// Token: 0x060001C2 RID: 450
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringStringMap_create_iterator_begin")]
		public static extern IntPtr StringStringMap_create_iterator_begin(HandleRef jarg1);

		// Token: 0x060001C3 RID: 451
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringStringMap_get_next_key")]
		public static extern string StringStringMap_get_next_key(HandleRef jarg1, IntPtr jarg2);

		// Token: 0x060001C4 RID: 452
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringStringMap_destroy_iterator")]
		public static extern void StringStringMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		// Token: 0x060001C5 RID: 453
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_delete_StringStringMap")]
		public static extern void delete_StringStringMap(HandleRef jarg1);

		// Token: 0x060001C6 RID: 454
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_StringList__SWIG_0")]
		public static extern IntPtr new_StringList__SWIG_0();

		// Token: 0x060001C7 RID: 455
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_StringList__SWIG_1")]
		public static extern IntPtr new_StringList__SWIG_1(HandleRef jarg1);

		// Token: 0x060001C8 RID: 456
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_Clear")]
		public static extern void StringList_Clear(HandleRef jarg1);

		// Token: 0x060001C9 RID: 457
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_Add")]
		public static extern void StringList_Add(HandleRef jarg1, string jarg2);

		// Token: 0x060001CA RID: 458
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_size")]
		public static extern uint StringList_size(HandleRef jarg1);

		// Token: 0x060001CB RID: 459
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_empty")]
		public static extern bool StringList_empty(HandleRef jarg1);

		// Token: 0x060001CC RID: 460
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_capacity")]
		public static extern uint StringList_capacity(HandleRef jarg1);

		// Token: 0x060001CD RID: 461
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_reserve")]
		public static extern void StringList_reserve(HandleRef jarg1, uint jarg2);

		// Token: 0x060001CE RID: 462
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_StringList__SWIG_2")]
		public static extern IntPtr new_StringList__SWIG_2(int jarg1);

		// Token: 0x060001CF RID: 463
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_getitemcopy")]
		public static extern string StringList_getitemcopy(HandleRef jarg1, int jarg2);

		// Token: 0x060001D0 RID: 464
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_getitem")]
		public static extern string StringList_getitem(HandleRef jarg1, int jarg2);

		// Token: 0x060001D1 RID: 465
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_setitem")]
		public static extern void StringList_setitem(HandleRef jarg1, int jarg2, string jarg3);

		// Token: 0x060001D2 RID: 466
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_AddRange")]
		public static extern void StringList_AddRange(HandleRef jarg1, HandleRef jarg2);

		// Token: 0x060001D3 RID: 467
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_GetRange")]
		public static extern IntPtr StringList_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		// Token: 0x060001D4 RID: 468
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_Insert")]
		public static extern void StringList_Insert(HandleRef jarg1, int jarg2, string jarg3);

		// Token: 0x060001D5 RID: 469
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_InsertRange")]
		public static extern void StringList_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		// Token: 0x060001D6 RID: 470
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_RemoveAt")]
		public static extern void StringList_RemoveAt(HandleRef jarg1, int jarg2);

		// Token: 0x060001D7 RID: 471
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_RemoveRange")]
		public static extern void StringList_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		// Token: 0x060001D8 RID: 472
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_Repeat")]
		public static extern IntPtr StringList_Repeat(string jarg1, int jarg2);

		// Token: 0x060001D9 RID: 473
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_Reverse__SWIG_0")]
		public static extern void StringList_Reverse__SWIG_0(HandleRef jarg1);

		// Token: 0x060001DA RID: 474
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_Reverse__SWIG_1")]
		public static extern void StringList_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		// Token: 0x060001DB RID: 475
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_SetRange")]
		public static extern void StringList_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		// Token: 0x060001DC RID: 476
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_Contains")]
		public static extern bool StringList_Contains(HandleRef jarg1, string jarg2);

		// Token: 0x060001DD RID: 477
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_IndexOf")]
		public static extern int StringList_IndexOf(HandleRef jarg1, string jarg2);

		// Token: 0x060001DE RID: 478
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_LastIndexOf")]
		public static extern int StringList_LastIndexOf(HandleRef jarg1, string jarg2);

		// Token: 0x060001DF RID: 479
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_StringList_Remove")]
		public static extern bool StringList_Remove(HandleRef jarg1, string jarg2);

		// Token: 0x060001E0 RID: 480
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_delete_StringList")]
		public static extern void delete_StringList(HandleRef jarg1);

		// Token: 0x060001E1 RID: 481
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_CharVector__SWIG_0")]
		public static extern IntPtr new_CharVector__SWIG_0();

		// Token: 0x060001E2 RID: 482
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_CharVector__SWIG_1")]
		public static extern IntPtr new_CharVector__SWIG_1(HandleRef jarg1);

		// Token: 0x060001E3 RID: 483
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_Clear")]
		public static extern void CharVector_Clear(HandleRef jarg1);

		// Token: 0x060001E4 RID: 484
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_Add")]
		public static extern void CharVector_Add(HandleRef jarg1, byte jarg2);

		// Token: 0x060001E5 RID: 485
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_size")]
		public static extern uint CharVector_size(HandleRef jarg1);

		// Token: 0x060001E6 RID: 486
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_empty")]
		public static extern bool CharVector_empty(HandleRef jarg1);

		// Token: 0x060001E7 RID: 487
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_capacity")]
		public static extern uint CharVector_capacity(HandleRef jarg1);

		// Token: 0x060001E8 RID: 488
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_reserve")]
		public static extern void CharVector_reserve(HandleRef jarg1, uint jarg2);

		// Token: 0x060001E9 RID: 489
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_CharVector__SWIG_2")]
		public static extern IntPtr new_CharVector__SWIG_2(int jarg1);

		// Token: 0x060001EA RID: 490
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_getitemcopy")]
		public static extern byte CharVector_getitemcopy(HandleRef jarg1, int jarg2);

		// Token: 0x060001EB RID: 491
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_getitem")]
		public static extern byte CharVector_getitem(HandleRef jarg1, int jarg2);

		// Token: 0x060001EC RID: 492
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_setitem")]
		public static extern void CharVector_setitem(HandleRef jarg1, int jarg2, byte jarg3);

		// Token: 0x060001ED RID: 493
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_AddRange")]
		public static extern void CharVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		// Token: 0x060001EE RID: 494
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_GetRange")]
		public static extern IntPtr CharVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		// Token: 0x060001EF RID: 495
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_Insert")]
		public static extern void CharVector_Insert(HandleRef jarg1, int jarg2, byte jarg3);

		// Token: 0x060001F0 RID: 496
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_InsertRange")]
		public static extern void CharVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		// Token: 0x060001F1 RID: 497
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_RemoveAt")]
		public static extern void CharVector_RemoveAt(HandleRef jarg1, int jarg2);

		// Token: 0x060001F2 RID: 498
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_RemoveRange")]
		public static extern void CharVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		// Token: 0x060001F3 RID: 499
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_Repeat")]
		public static extern IntPtr CharVector_Repeat(byte jarg1, int jarg2);

		// Token: 0x060001F4 RID: 500
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_Reverse__SWIG_0")]
		public static extern void CharVector_Reverse__SWIG_0(HandleRef jarg1);

		// Token: 0x060001F5 RID: 501
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_Reverse__SWIG_1")]
		public static extern void CharVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		// Token: 0x060001F6 RID: 502
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_SetRange")]
		public static extern void CharVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		// Token: 0x060001F7 RID: 503
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_Contains")]
		public static extern bool CharVector_Contains(HandleRef jarg1, byte jarg2);

		// Token: 0x060001F8 RID: 504
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_IndexOf")]
		public static extern int CharVector_IndexOf(HandleRef jarg1, byte jarg2);

		// Token: 0x060001F9 RID: 505
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_LastIndexOf")]
		public static extern int CharVector_LastIndexOf(HandleRef jarg1, byte jarg2);

		// Token: 0x060001FA RID: 506
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CharVector_Remove")]
		public static extern bool CharVector_Remove(HandleRef jarg1, byte jarg2);

		// Token: 0x060001FB RID: 507
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_delete_CharVector")]
		public static extern void delete_CharVector(HandleRef jarg1);

		// Token: 0x060001FC RID: 508
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_FutureString")]
		public static extern IntPtr new_FutureString();

		// Token: 0x060001FD RID: 509
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureString_SWIG_OnCompletion")]
		public static extern IntPtr FutureString_SWIG_OnCompletion(HandleRef jarg1, FutureString.SWIG_CompletionDelegate jarg2, int jarg3);

		// Token: 0x060001FE RID: 510
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureString_SWIG_FreeCompletionData")]
		public static extern void FutureString_SWIG_FreeCompletionData(IntPtr jarg1);

		// Token: 0x060001FF RID: 511
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureString_GetResult")]
		public static extern string FutureString_GetResult(HandleRef jarg1);

		// Token: 0x06000200 RID: 512
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_delete_FutureString")]
		public static extern void delete_FutureString(HandleRef jarg1);

		// Token: 0x06000201 RID: 513
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_FutureVoid")]
		public static extern IntPtr new_FutureVoid();

		// Token: 0x06000202 RID: 514
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureVoid_SWIG_OnCompletion")]
		public static extern IntPtr FutureVoid_SWIG_OnCompletion(HandleRef jarg1, FutureVoid.SWIG_CompletionDelegate jarg2, int jarg3);

		// Token: 0x06000203 RID: 515
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureVoid_SWIG_FreeCompletionData")]
		public static extern void FutureVoid_SWIG_FreeCompletionData(IntPtr jarg1);

		// Token: 0x06000204 RID: 516
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_delete_FutureVoid")]
		public static extern void delete_FutureVoid(HandleRef jarg1);

		// Token: 0x06000205 RID: 517
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_FutureBool")]
		public static extern IntPtr new_FutureBool();

		// Token: 0x06000206 RID: 518
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureBool_SWIG_OnCompletion")]
		public static extern IntPtr FutureBool_SWIG_OnCompletion(HandleRef jarg1, FutureBool.SWIG_CompletionDelegate jarg2, int jarg3);

		// Token: 0x06000207 RID: 519
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureBool_SWIG_FreeCompletionData")]
		public static extern void FutureBool_SWIG_FreeCompletionData(IntPtr jarg1);

		// Token: 0x06000208 RID: 520
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureBool_GetResult")]
		public static extern bool FutureBool_GetResult(HandleRef jarg1);

		// Token: 0x06000209 RID: 521
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_delete_FutureBool")]
		public static extern void delete_FutureBool(HandleRef jarg1);

		// Token: 0x0600020A RID: 522
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_AppOptionsInternal")]
		internal static extern IntPtr new_AppOptionsInternal();

		// Token: 0x0600020B RID: 523
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_SetDatabaseUrlInternal")]
		internal static extern void AppOptionsInternal_SetDatabaseUrlInternal(HandleRef jarg1, string jarg2);

		// Token: 0x0600020C RID: 524
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_GetDatabaseUrlInternal")]
		internal static extern string AppOptionsInternal_GetDatabaseUrlInternal(HandleRef jarg1);

		// Token: 0x0600020D RID: 525
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_LoadFromJsonConfig__SWIG_0")]
		public static extern IntPtr AppOptionsInternal_LoadFromJsonConfig__SWIG_0(string jarg1, HandleRef jarg2);

		// Token: 0x0600020E RID: 526
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_LoadFromJsonConfig__SWIG_1")]
		public static extern IntPtr AppOptionsInternal_LoadFromJsonConfig__SWIG_1(string jarg1);

		// Token: 0x0600020F RID: 527
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_AppId_set")]
		public static extern void AppOptionsInternal_AppId_set(HandleRef jarg1, string jarg2);

		// Token: 0x06000210 RID: 528
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_AppId_get")]
		public static extern string AppOptionsInternal_AppId_get(HandleRef jarg1);

		// Token: 0x06000211 RID: 529
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_ApiKey_set")]
		public static extern void AppOptionsInternal_ApiKey_set(HandleRef jarg1, string jarg2);

		// Token: 0x06000212 RID: 530
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_ApiKey_get")]
		public static extern string AppOptionsInternal_ApiKey_get(HandleRef jarg1);

		// Token: 0x06000213 RID: 531
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_MessageSenderId_set")]
		public static extern void AppOptionsInternal_MessageSenderId_set(HandleRef jarg1, string jarg2);

		// Token: 0x06000214 RID: 532
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_MessageSenderId_get")]
		public static extern string AppOptionsInternal_MessageSenderId_get(HandleRef jarg1);

		// Token: 0x06000215 RID: 533
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_StorageBucket_set")]
		public static extern void AppOptionsInternal_StorageBucket_set(HandleRef jarg1, string jarg2);

		// Token: 0x06000216 RID: 534
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_StorageBucket_get")]
		public static extern string AppOptionsInternal_StorageBucket_get(HandleRef jarg1);

		// Token: 0x06000217 RID: 535
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_ProjectId_set")]
		public static extern void AppOptionsInternal_ProjectId_set(HandleRef jarg1, string jarg2);

		// Token: 0x06000218 RID: 536
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_ProjectId_get")]
		public static extern string AppOptionsInternal_ProjectId_get(HandleRef jarg1);

		// Token: 0x06000219 RID: 537
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_PackageName_set")]
		public static extern void AppOptionsInternal_PackageName_set(HandleRef jarg1, string jarg2);

		// Token: 0x0600021A RID: 538
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsInternal_PackageName_get")]
		public static extern string AppOptionsInternal_PackageName_get(HandleRef jarg1);

		// Token: 0x0600021B RID: 539
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_delete_AppOptionsInternal")]
		internal static extern void delete_AppOptionsInternal(HandleRef jarg1);

		// Token: 0x0600021C RID: 540
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_delete_FirebaseApp")]
		public static extern void delete_FirebaseApp(HandleRef jarg1);

		// Token: 0x0600021D RID: 541
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_options")]
		public static extern IntPtr FirebaseApp_options(HandleRef jarg1);

		// Token: 0x0600021E RID: 542
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_SetDataCollectionDefaultEnabledInternal")]
		internal static extern void FirebaseApp_SetDataCollectionDefaultEnabledInternal(HandleRef jarg1, bool jarg2);

		// Token: 0x0600021F RID: 543
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_IsDataCollectionDefaultEnabledInternal")]
		internal static extern bool FirebaseApp_IsDataCollectionDefaultEnabledInternal(HandleRef jarg1);

		// Token: 0x06000220 RID: 544
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_NameInternal_get")]
		public static extern string FirebaseApp_NameInternal_get(HandleRef jarg1);

		// Token: 0x06000221 RID: 545
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_CreateInternal__SWIG_0")]
		public static extern IntPtr FirebaseApp_CreateInternal__SWIG_0();

		// Token: 0x06000222 RID: 546
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_CreateInternal__SWIG_1")]
		public static extern IntPtr FirebaseApp_CreateInternal__SWIG_1(HandleRef jarg1);

		// Token: 0x06000223 RID: 547
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_CreateInternal__SWIG_2")]
		public static extern IntPtr FirebaseApp_CreateInternal__SWIG_2(HandleRef jarg1, string jarg2);

		// Token: 0x06000224 RID: 548
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_ReleaseReferenceInternal")]
		internal static extern void FirebaseApp_ReleaseReferenceInternal(HandleRef jarg1);

		// Token: 0x06000225 RID: 549
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_SetLogLevelInternal")]
		internal static extern void FirebaseApp_SetLogLevelInternal(int jarg1);

		// Token: 0x06000226 RID: 550
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_GetLogLevelInternal")]
		internal static extern int FirebaseApp_GetLogLevelInternal();

		// Token: 0x06000227 RID: 551
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_RegisterLibrariesInternal")]
		internal static extern void FirebaseApp_RegisterLibrariesInternal(HandleRef jarg1);

		// Token: 0x06000228 RID: 552
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_LogHeartbeatInternal")]
		internal static extern void FirebaseApp_LogHeartbeatInternal(HandleRef jarg1);

		// Token: 0x06000229 RID: 553
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_AppSetDefaultConfigPath")]
		public static extern void FirebaseApp_AppSetDefaultConfigPath(string jarg1);

		// Token: 0x0600022A RID: 554
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FirebaseApp_DefaultName_get")]
		public static extern string FirebaseApp_DefaultName_get();

		// Token: 0x0600022B RID: 555
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_SetLogLevel")]
		public static extern void SetLogLevel(int jarg1);

		// Token: 0x0600022C RID: 556
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_GetLogLevel")]
		public static extern int GetLogLevel();

		// Token: 0x0600022D RID: 557
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_PollCallbacks")]
		public static extern void PollCallbacks();

		// Token: 0x0600022E RID: 558
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppEnableLogCallback")]
		public static extern void AppEnableLogCallback(bool jarg1);

		// Token: 0x0600022F RID: 559
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppGetLogLevel")]
		public static extern int AppGetLogLevel();

		// Token: 0x06000230 RID: 560
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_SetEnabledAllAppCallbacks")]
		public static extern void SetEnabledAllAppCallbacks(bool jarg1);

		// Token: 0x06000231 RID: 561
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_SetEnabledAppCallbackByName")]
		public static extern void SetEnabledAppCallbackByName(string jarg1, bool jarg2);

		// Token: 0x06000232 RID: 562
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_GetEnabledAppCallbackByName")]
		public static extern bool GetEnabledAppCallbackByName(string jarg1);

		// Token: 0x06000233 RID: 563
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_SetLogFunction")]
		public static extern void SetLogFunction(LogUtil.LogMessageDelegate jarg1);

		// Token: 0x06000234 RID: 564
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_AppOptionsLoadFromJsonConfig")]
		public static extern IntPtr AppOptionsLoadFromJsonConfig(string jarg1);

		// Token: 0x06000235 RID: 565
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_CheckAndroidDependencies")]
		public static extern int CheckAndroidDependencies();

		// Token: 0x06000236 RID: 566
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FixAndroidDependencies")]
		public static extern IntPtr FixAndroidDependencies();

		// Token: 0x06000237 RID: 567
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_InitializePlayServicesInternal")]
		internal static extern void InitializePlayServicesInternal();

		// Token: 0x06000238 RID: 568
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_TerminatePlayServicesInternal")]
		internal static extern void TerminatePlayServicesInternal();

		// Token: 0x06000239 RID: 569
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_VariantVariantMap__SWIG_0")]
		public static extern IntPtr new_VariantVariantMap__SWIG_0();

		// Token: 0x0600023A RID: 570
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_VariantVariantMap__SWIG_1")]
		public static extern IntPtr new_VariantVariantMap__SWIG_1(HandleRef jarg1);

		// Token: 0x0600023B RID: 571
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantVariantMap_size")]
		public static extern uint VariantVariantMap_size(HandleRef jarg1);

		// Token: 0x0600023C RID: 572
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantVariantMap_empty")]
		public static extern bool VariantVariantMap_empty(HandleRef jarg1);

		// Token: 0x0600023D RID: 573
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantVariantMap_Clear")]
		public static extern void VariantVariantMap_Clear(HandleRef jarg1);

		// Token: 0x0600023E RID: 574
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantVariantMap_getitem")]
		public static extern IntPtr VariantVariantMap_getitem(HandleRef jarg1, HandleRef jarg2);

		// Token: 0x0600023F RID: 575
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantVariantMap_setitem")]
		public static extern void VariantVariantMap_setitem(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		// Token: 0x06000240 RID: 576
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantVariantMap_ContainsKey")]
		public static extern bool VariantVariantMap_ContainsKey(HandleRef jarg1, HandleRef jarg2);

		// Token: 0x06000241 RID: 577
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantVariantMap_Add")]
		public static extern void VariantVariantMap_Add(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		// Token: 0x06000242 RID: 578
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantVariantMap_Remove")]
		public static extern bool VariantVariantMap_Remove(HandleRef jarg1, HandleRef jarg2);

		// Token: 0x06000243 RID: 579
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantVariantMap_create_iterator_begin")]
		public static extern IntPtr VariantVariantMap_create_iterator_begin(HandleRef jarg1);

		// Token: 0x06000244 RID: 580
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantVariantMap_get_next_key")]
		public static extern IntPtr VariantVariantMap_get_next_key(HandleRef jarg1, IntPtr jarg2);

		// Token: 0x06000245 RID: 581
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantVariantMap_destroy_iterator")]
		public static extern void VariantVariantMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		// Token: 0x06000246 RID: 582
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_delete_VariantVariantMap")]
		public static extern void delete_VariantVariantMap(HandleRef jarg1);

		// Token: 0x06000247 RID: 583
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_VariantList__SWIG_0")]
		public static extern IntPtr new_VariantList__SWIG_0();

		// Token: 0x06000248 RID: 584
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_VariantList__SWIG_1")]
		public static extern IntPtr new_VariantList__SWIG_1(HandleRef jarg1);

		// Token: 0x06000249 RID: 585
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_Clear")]
		public static extern void VariantList_Clear(HandleRef jarg1);

		// Token: 0x0600024A RID: 586
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_Add")]
		public static extern void VariantList_Add(HandleRef jarg1, HandleRef jarg2);

		// Token: 0x0600024B RID: 587
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_size")]
		public static extern uint VariantList_size(HandleRef jarg1);

		// Token: 0x0600024C RID: 588
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_empty")]
		public static extern bool VariantList_empty(HandleRef jarg1);

		// Token: 0x0600024D RID: 589
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_capacity")]
		public static extern uint VariantList_capacity(HandleRef jarg1);

		// Token: 0x0600024E RID: 590
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_reserve")]
		public static extern void VariantList_reserve(HandleRef jarg1, uint jarg2);

		// Token: 0x0600024F RID: 591
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_new_VariantList__SWIG_2")]
		public static extern IntPtr new_VariantList__SWIG_2(int jarg1);

		// Token: 0x06000250 RID: 592
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_getitemcopy")]
		public static extern IntPtr VariantList_getitemcopy(HandleRef jarg1, int jarg2);

		// Token: 0x06000251 RID: 593
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_getitem")]
		public static extern IntPtr VariantList_getitem(HandleRef jarg1, int jarg2);

		// Token: 0x06000252 RID: 594
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_setitem")]
		public static extern void VariantList_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		// Token: 0x06000253 RID: 595
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_AddRange")]
		public static extern void VariantList_AddRange(HandleRef jarg1, HandleRef jarg2);

		// Token: 0x06000254 RID: 596
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_GetRange")]
		public static extern IntPtr VariantList_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		// Token: 0x06000255 RID: 597
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_Insert")]
		public static extern void VariantList_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		// Token: 0x06000256 RID: 598
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_InsertRange")]
		public static extern void VariantList_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		// Token: 0x06000257 RID: 599
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_RemoveAt")]
		public static extern void VariantList_RemoveAt(HandleRef jarg1, int jarg2);

		// Token: 0x06000258 RID: 600
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_RemoveRange")]
		public static extern void VariantList_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		// Token: 0x06000259 RID: 601
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_Repeat")]
		public static extern IntPtr VariantList_Repeat(HandleRef jarg1, int jarg2);

		// Token: 0x0600025A RID: 602
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_Reverse__SWIG_0")]
		public static extern void VariantList_Reverse__SWIG_0(HandleRef jarg1);

		// Token: 0x0600025B RID: 603
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_Reverse__SWIG_1")]
		public static extern void VariantList_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		// Token: 0x0600025C RID: 604
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_VariantList_SetRange")]
		public static extern void VariantList_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		// Token: 0x0600025D RID: 605
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_delete_VariantList")]
		public static extern void delete_VariantList(HandleRef jarg1);

		// Token: 0x0600025E RID: 606
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_delete_Variant")]
		public static extern void delete_Variant(HandleRef jarg1);

		// Token: 0x0600025F RID: 607
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_Null")]
		public static extern IntPtr Variant_Null();

		// Token: 0x06000260 RID: 608
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_EmptyVector")]
		public static extern IntPtr Variant_EmptyVector();

		// Token: 0x06000261 RID: 609
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_EmptyMap")]
		public static extern IntPtr Variant_EmptyMap();

		// Token: 0x06000262 RID: 610
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_EmptyMutableBlob")]
		public static extern IntPtr Variant_EmptyMutableBlob(uint jarg1);

		// Token: 0x06000263 RID: 611
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_type")]
		public static extern int Variant_type(HandleRef jarg1);

		// Token: 0x06000264 RID: 612
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_is_string")]
		public static extern bool Variant_is_string(HandleRef jarg1);

		// Token: 0x06000265 RID: 613
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_is_fundamental_type")]
		public static extern bool Variant_is_fundamental_type(HandleRef jarg1);

		// Token: 0x06000266 RID: 614
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_AsString")]
		public static extern IntPtr Variant_AsString(HandleRef jarg1);

		// Token: 0x06000267 RID: 615
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_blob_size")]
		public static extern uint Variant_blob_size(HandleRef jarg1);

		// Token: 0x06000268 RID: 616
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_vector__SWIG_0")]
		public static extern IntPtr Variant_vector__SWIG_0(HandleRef jarg1);

		// Token: 0x06000269 RID: 617
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_map__SWIG_0")]
		public static extern IntPtr Variant_map__SWIG_0(HandleRef jarg1);

		// Token: 0x0600026A RID: 618
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_int64_value")]
		public static extern long Variant_int64_value(HandleRef jarg1);

		// Token: 0x0600026B RID: 619
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_double_value")]
		public static extern double Variant_double_value(HandleRef jarg1);

		// Token: 0x0600026C RID: 620
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_bool_value")]
		public static extern bool Variant_bool_value(HandleRef jarg1);

		// Token: 0x0600026D RID: 621
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_string_value")]
		public static extern string Variant_string_value(HandleRef jarg1);

		// Token: 0x0600026E RID: 622
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_FromInt64")]
		public static extern IntPtr Variant_FromInt64(long jarg1);

		// Token: 0x0600026F RID: 623
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_FromDouble")]
		public static extern IntPtr Variant_FromDouble(double jarg1);

		// Token: 0x06000270 RID: 624
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_FromBool")]
		public static extern IntPtr Variant_FromBool(bool jarg1);

		// Token: 0x06000271 RID: 625
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_FromString")]
		public static extern IntPtr Variant_FromString(string jarg1);

		// Token: 0x06000272 RID: 626
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_Variant_untyped_mutable_blob_data")]
		public static extern IntPtr Variant_untyped_mutable_blob_data(HandleRef jarg1);

		// Token: 0x06000273 RID: 627
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureString_SWIGUpcast")]
		public static extern IntPtr FutureString_SWIGUpcast(IntPtr jarg1);

		// Token: 0x06000274 RID: 628
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureVoid_SWIGUpcast")]
		public static extern IntPtr FutureVoid_SWIGUpcast(IntPtr jarg1);

		// Token: 0x06000275 RID: 629
		[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "Firebase_App_CSharp_FutureBool_SWIGUpcast")]
		public static extern IntPtr FutureBool_SWIGUpcast(IntPtr jarg1);

		// Token: 0x04000067 RID: 103
		protected static AppUtilPINVOKE.SWIGExceptionHelper swigExceptionHelper = new AppUtilPINVOKE.SWIGExceptionHelper();

		// Token: 0x04000068 RID: 104
		protected static AppUtilPINVOKE.SWIGStringHelper swigStringHelper = new AppUtilPINVOKE.SWIGStringHelper();

		// Token: 0x02000038 RID: 56
		protected class SWIGExceptionHelper
		{
			// Token: 0x060002F6 RID: 758
			[DllImport("FirebaseCppApp-12_10_1")]
			public static extern void SWIGRegisterExceptionCallbacks_AppUtil(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);

			// Token: 0x060002F7 RID: 759
			[DllImport("FirebaseCppApp-12_10_1", EntryPoint = "SWIGRegisterExceptionArgumentCallbacks_AppUtil")]
			public static extern void SWIGRegisterExceptionCallbacksArgument_AppUtil(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			// Token: 0x060002F8 RID: 760 RVA: 0x000094EB File Offset: 0x000076EB
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingApplicationException(string message)
			{
				AppUtilPINVOKE.SWIGPendingException.Set(new ApplicationException(message, AppUtilPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x000094FF File Offset: 0x000076FF
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingArithmeticException(string message)
			{
				AppUtilPINVOKE.SWIGPendingException.Set(new ArithmeticException(message, AppUtilPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060002FA RID: 762 RVA: 0x00009513 File Offset: 0x00007713
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingDivideByZeroException(string message)
			{
				AppUtilPINVOKE.SWIGPendingException.Set(new DivideByZeroException(message, AppUtilPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060002FB RID: 763 RVA: 0x00009527 File Offset: 0x00007727
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
				AppUtilPINVOKE.SWIGPendingException.Set(new IndexOutOfRangeException(message, AppUtilPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060002FC RID: 764 RVA: 0x0000953B File Offset: 0x0000773B
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingInvalidCastException(string message)
			{
				AppUtilPINVOKE.SWIGPendingException.Set(new InvalidCastException(message, AppUtilPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060002FD RID: 765 RVA: 0x0000954F File Offset: 0x0000774F
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingInvalidOperationException(string message)
			{
				AppUtilPINVOKE.SWIGPendingException.Set(new InvalidOperationException(message, AppUtilPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060002FE RID: 766 RVA: 0x00009563 File Offset: 0x00007763
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingIOException(string message)
			{
				AppUtilPINVOKE.SWIGPendingException.Set(new IOException(message, AppUtilPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x060002FF RID: 767 RVA: 0x00009577 File Offset: 0x00007777
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingNullReferenceException(string message)
			{
				AppUtilPINVOKE.SWIGPendingException.Set(new NullReferenceException(message, AppUtilPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x06000300 RID: 768 RVA: 0x0000958B File Offset: 0x0000778B
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingOutOfMemoryException(string message)
			{
				AppUtilPINVOKE.SWIGPendingException.Set(new OutOfMemoryException(message, AppUtilPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x06000301 RID: 769 RVA: 0x0000959F File Offset: 0x0000779F
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingOverflowException(string message)
			{
				AppUtilPINVOKE.SWIGPendingException.Set(new OverflowException(message, AppUtilPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x06000302 RID: 770 RVA: 0x000095B3 File Offset: 0x000077B3
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate))]
			private static void SetPendingSystemException(string message)
			{
				AppUtilPINVOKE.SWIGPendingException.Set(new SystemException(message, AppUtilPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x06000303 RID: 771 RVA: 0x000095C7 File Offset: 0x000077C7
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
			private static void SetPendingArgumentException(string message, string paramName)
			{
				AppUtilPINVOKE.SWIGPendingException.Set(new ArgumentException(message, paramName, AppUtilPINVOKE.SWIGPendingException.Retrieve()));
			}

			// Token: 0x06000304 RID: 772 RVA: 0x000095DC File Offset: 0x000077DC
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
				Exception ex = AppUtilPINVOKE.SWIGPendingException.Retrieve();
				bool flag = ex != null;
				if (flag)
				{
					message = message + " Inner Exception: " + ex.Message;
				}
				AppUtilPINVOKE.SWIGPendingException.Set(new ArgumentNullException(paramName, message));
			}

			// Token: 0x06000305 RID: 773 RVA: 0x00009618 File Offset: 0x00007818
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate))]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
				Exception ex = AppUtilPINVOKE.SWIGPendingException.Retrieve();
				bool flag = ex != null;
				if (flag)
				{
					message = message + " Inner Exception: " + ex.Message;
				}
				AppUtilPINVOKE.SWIGPendingException.Set(new ArgumentOutOfRangeException(paramName, message));
			}

			// Token: 0x06000306 RID: 774 RVA: 0x00009654 File Offset: 0x00007854
			static SWIGExceptionHelper()
			{
				AppUtilPINVOKE.SWIGExceptionHelper.SWIGRegisterExceptionCallbacks_AppUtil(AppUtilPINVOKE.SWIGExceptionHelper.applicationDelegate, AppUtilPINVOKE.SWIGExceptionHelper.arithmeticDelegate, AppUtilPINVOKE.SWIGExceptionHelper.divideByZeroDelegate, AppUtilPINVOKE.SWIGExceptionHelper.indexOutOfRangeDelegate, AppUtilPINVOKE.SWIGExceptionHelper.invalidCastDelegate, AppUtilPINVOKE.SWIGExceptionHelper.invalidOperationDelegate, AppUtilPINVOKE.SWIGExceptionHelper.ioDelegate, AppUtilPINVOKE.SWIGExceptionHelper.nullReferenceDelegate, AppUtilPINVOKE.SWIGExceptionHelper.outOfMemoryDelegate, AppUtilPINVOKE.SWIGExceptionHelper.overflowDelegate, AppUtilPINVOKE.SWIGExceptionHelper.systemDelegate);
				AppUtilPINVOKE.SWIGExceptionHelper.SWIGRegisterExceptionCallbacksArgument_AppUtil(AppUtilPINVOKE.SWIGExceptionHelper.argumentDelegate, AppUtilPINVOKE.SWIGExceptionHelper.argumentNullDelegate, AppUtilPINVOKE.SWIGExceptionHelper.argumentOutOfRangeDelegate);
			}

			// Token: 0x040000A4 RID: 164
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingApplicationException);

			// Token: 0x040000A5 RID: 165
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingArithmeticException);

			// Token: 0x040000A6 RID: 166
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingDivideByZeroException);

			// Token: 0x040000A7 RID: 167
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingIndexOutOfRangeException);

			// Token: 0x040000A8 RID: 168
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingInvalidCastException);

			// Token: 0x040000A9 RID: 169
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingInvalidOperationException);

			// Token: 0x040000AA RID: 170
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingIOException);

			// Token: 0x040000AB RID: 171
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingNullReferenceException);

			// Token: 0x040000AC RID: 172
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingOutOfMemoryException);

			// Token: 0x040000AD RID: 173
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingOverflowException);

			// Token: 0x040000AE RID: 174
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingSystemException);

			// Token: 0x040000AF RID: 175
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingArgumentException);

			// Token: 0x040000B0 RID: 176
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingArgumentNullException);

			// Token: 0x040000B1 RID: 177
			private static AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate = new AppUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate(AppUtilPINVOKE.SWIGExceptionHelper.SetPendingArgumentOutOfRangeException);

			// Token: 0x0200003B RID: 59
			// (Invoke) Token: 0x06000312 RID: 786
			public delegate void ExceptionDelegate(string message);

			// Token: 0x0200003C RID: 60
			// (Invoke) Token: 0x06000316 RID: 790
			public delegate void ExceptionArgumentDelegate(string message, string paramName);
		}

		// Token: 0x02000039 RID: 57
		public class SWIGPendingException
		{
			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000308 RID: 776 RVA: 0x000097A4 File Offset: 0x000079A4
			public static bool Pending
			{
				get
				{
					bool result = false;
					bool flag = AppUtilPINVOKE.SWIGPendingException.numExceptionsPending > 0;
					if (flag)
					{
						bool flag2 = AppUtilPINVOKE.SWIGPendingException.pendingException != null;
						if (flag2)
						{
							result = true;
						}
					}
					return result;
				}
			}

			// Token: 0x06000309 RID: 777 RVA: 0x000097D4 File Offset: 0x000079D4
			public static void Set(Exception e)
			{
				bool flag = AppUtilPINVOKE.SWIGPendingException.pendingException != null;
				if (flag)
				{
					throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + AppUtilPINVOKE.SWIGPendingException.pendingException.ToString() + ")", e);
				}
				AppUtilPINVOKE.SWIGPendingException.pendingException = e;
				object obj = AppUtilPINVOKE.SWIGPendingException.exceptionsLock;
				lock (obj)
				{
					AppUtilPINVOKE.SWIGPendingException.numExceptionsPending++;
				}
			}

			// Token: 0x0600030A RID: 778 RVA: 0x00009850 File Offset: 0x00007A50
			public static Exception Retrieve()
			{
				Exception result = null;
				bool flag = AppUtilPINVOKE.SWIGPendingException.numExceptionsPending > 0;
				if (flag)
				{
					bool flag2 = AppUtilPINVOKE.SWIGPendingException.pendingException != null;
					if (flag2)
					{
						result = AppUtilPINVOKE.SWIGPendingException.pendingException;
						AppUtilPINVOKE.SWIGPendingException.pendingException = null;
						object obj = AppUtilPINVOKE.SWIGPendingException.exceptionsLock;
						lock (obj)
						{
							AppUtilPINVOKE.SWIGPendingException.numExceptionsPending--;
						}
					}
				}
				return result;
			}

			// Token: 0x0600030B RID: 779 RVA: 0x000098D0 File Offset: 0x00007AD0
			static SWIGPendingException()
			{
				AppUtilPINVOKE.SWIGPendingException.exceptionsLock = new object();
			}

			// Token: 0x040000B2 RID: 178
			[ThreadStatic]
			private static Exception pendingException = null;

			// Token: 0x040000B3 RID: 179
			private static int numExceptionsPending = 0;

			// Token: 0x040000B4 RID: 180
			private static object exceptionsLock = null;
		}

		// Token: 0x0200003A RID: 58
		protected class SWIGStringHelper
		{
			// Token: 0x0600030D RID: 781
			[DllImport("FirebaseCppApp-12_10_1")]
			public static extern void SWIGRegisterStringCallback_AppUtil(AppUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);

			// Token: 0x0600030E RID: 782 RVA: 0x000098F0 File Offset: 0x00007AF0
			[MonoPInvokeCallback(typeof(AppUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate))]
			private static string CreateString(string cString)
			{
				return cString;
			}

			// Token: 0x0600030F RID: 783 RVA: 0x00009903 File Offset: 0x00007B03
			static SWIGStringHelper()
			{
				AppUtilPINVOKE.SWIGStringHelper.SWIGRegisterStringCallback_AppUtil(AppUtilPINVOKE.SWIGStringHelper.stringDelegate);
			}

			// Token: 0x040000B5 RID: 181
			private static AppUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate = new AppUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate(AppUtilPINVOKE.SWIGStringHelper.CreateString);

			// Token: 0x0200003D RID: 61
			// (Invoke) Token: 0x0600031A RID: 794
			public delegate string SWIGStringDelegate(string message);
		}
	}
}
