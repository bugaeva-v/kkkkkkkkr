using System;
using GleyPushNotifications;

// Token: 0x020004DB RID: 1243
public static class PPDMOMECGGC
{
	// Token: 0x060095A3 RID: 38307 RVA: 0x00419ADF File Offset: 0x00417CDF
	public static void IIOFIOCMFJE(string BPMFHNDCBOH, string KIPCNAMEGPD, TimeSpan OJFEDOOPPPM, TimeSpan? PIMNEJABNEO, string LJMOKCLPPEL = null, string DJIFAPJOFNB = null, string CJPBKKDHJMN = "")
	{
		NotificationManager.EHBBFMCILPC.ADIJBJHNNHI(BPMFHNDCBOH, KIPCNAMEGPD, OJFEDOOPPPM, LJMOKCLPPEL, DJIFAPJOFNB, CJPBKKDHJMN, PIMNEJABNEO);
	}

	// Token: 0x060095A4 RID: 38308 RVA: 0x00419AF5 File Offset: 0x00417CF5
	public static void BAMHPOCKBML()
	{
		NotificationManager.EHBBFMCILPC.Initialize(true);
	}

	// Token: 0x060095A5 RID: 38309 RVA: 0x00419B04 File Offset: 0x00417D04
	public static void ADIJBJHNNHI(string BPMFHNDCBOH, string KIPCNAMEGPD, int MFFONHLCILJ, int FDMMMGIANEG, int AIJFJMKHAOO, string LJMOKCLPPEL = null, string DJIFAPJOFNB = null, string CJPBKKDHJMN = "")
	{
		NotificationManager.EHBBFMCILPC.ADIJBJHNNHI(BPMFHNDCBOH, KIPCNAMEGPD, new TimeSpan(MFFONHLCILJ, FDMMMGIANEG, AIJFJMKHAOO), LJMOKCLPPEL, DJIFAPJOFNB, CJPBKKDHJMN, null);
	}

	// Token: 0x060095A6 RID: 38310 RVA: 0x00419B35 File Offset: 0x00417D35
	public static void BAMHPOCKBML(bool LEPPBOIBKBI = true)
	{
		NotificationManager.EHBBFMCILPC.Initialize(LEPPBOIBKBI);
	}

	// Token: 0x060095A7 RID: 38311 RVA: 0x00419B44 File Offset: 0x00417D44
	public static void ADIJBJHNNHI(string BPMFHNDCBOH, string KIPCNAMEGPD, TimeSpan OJFEDOOPPPM, string LJMOKCLPPEL = null, string DJIFAPJOFNB = null, string CJPBKKDHJMN = "")
	{
		NotificationManager.EHBBFMCILPC.ADIJBJHNNHI(BPMFHNDCBOH, KIPCNAMEGPD, OJFEDOOPPPM, LJMOKCLPPEL, DJIFAPJOFNB, CJPBKKDHJMN, null);
	}

	// Token: 0x060095A8 RID: 38312 RVA: 0x00419B6C File Offset: 0x00417D6C
	public static string FEPFEBNNBPG()
	{
		return NotificationManager.EHBBFMCILPC.AppWasOpenFromNotification();
	}
}
