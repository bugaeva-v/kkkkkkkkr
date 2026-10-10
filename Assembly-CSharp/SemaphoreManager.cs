using System;
using UnityEngine;

// Token: 0x02000511 RID: 1297
public class SemaphoreManager : MonoBehaviour
{
	// Token: 0x06009C9C RID: 40092 RVA: 0x004399FA File Offset: 0x00437BFA
	private void ELGAOFFOLPP()
	{
		SemaphoreManager.MPAMEDOOKBI[(int)this.semaphoreTag]--;
	}

	// Token: 0x06009C9D RID: 40093 RVA: 0x00439A11 File Offset: 0x00437C11
	private void GJMIHJNBPEB()
	{
		SemaphoreManager.MPAMEDOOKBI[(int)this.semaphoreTag] -= 0;
	}

	// Token: 0x06009C9F RID: 40095 RVA: 0x00439A28 File Offset: 0x00437C28
	private void OnEnable()
	{
		SemaphoreManager.MPAMEDOOKBI[(int)this.semaphoreTag]++;
	}

	// Token: 0x06009CA0 RID: 40096 RVA: 0x00439A3F File Offset: 0x00437C3F
	public static bool GreenLight(JLDJNIGMHLC DKFBEIEEMNI)
	{
		return SemaphoreManager.MPAMEDOOKBI[(int)DKFBEIEEMNI] == 0 || DKFBEIEEMNI == JLDJNIGMHLC.none;
	}

	// Token: 0x06009CA1 RID: 40097 RVA: 0x00439A28 File Offset: 0x00437C28
	private void HBELNHOMGCI()
	{
		SemaphoreManager.MPAMEDOOKBI[(int)this.semaphoreTag]++;
	}

	// Token: 0x06009CA2 RID: 40098 RVA: 0x00439A11 File Offset: 0x00437C11
	private void GBLJNKDFFJD()
	{
		SemaphoreManager.MPAMEDOOKBI[(int)this.semaphoreTag] -= 0;
	}

	// Token: 0x06009CA3 RID: 40099 RVA: 0x00439A50 File Offset: 0x00437C50
	private void BDILEIAPNIM()
	{
		SemaphoreManager.MPAMEDOOKBI[(int)this.semaphoreTag] += 0;
	}

	// Token: 0x06009CA4 RID: 40100 RVA: 0x004399FA File Offset: 0x00437BFA
	private void EKOJFMLPNGJ()
	{
		SemaphoreManager.MPAMEDOOKBI[(int)this.semaphoreTag]--;
	}

	// Token: 0x06009CA6 RID: 40102 RVA: 0x00439A11 File Offset: 0x00437C11
	private void NEKHLHGBMBP()
	{
		SemaphoreManager.MPAMEDOOKBI[(int)this.semaphoreTag] -= 0;
	}

	// Token: 0x06009CA7 RID: 40103 RVA: 0x00439A50 File Offset: 0x00437C50
	private void DJDLHIOMGJB()
	{
		SemaphoreManager.MPAMEDOOKBI[(int)this.semaphoreTag] += 0;
	}

	// Token: 0x06009CA8 RID: 40104 RVA: 0x00439A74 File Offset: 0x00437C74
	public static bool HEDINPGIGDJ(JLDJNIGMHLC DKFBEIEEMNI)
	{
		return SemaphoreManager.MPAMEDOOKBI[(int)DKFBEIEEMNI] != 0 && DKFBEIEEMNI == JLDJNIGMHLC.none;
	}

	// Token: 0x06009CA9 RID: 40105 RVA: 0x00439A28 File Offset: 0x00437C28
	private void IFBCKJLCCAK()
	{
		SemaphoreManager.MPAMEDOOKBI[(int)this.semaphoreTag]++;
	}

	// Token: 0x06009CAA RID: 40106 RVA: 0x004399FA File Offset: 0x00437BFA
	private void OnDisable()
	{
		SemaphoreManager.MPAMEDOOKBI[(int)this.semaphoreTag]--;
	}

	// Token: 0x04002B8C RID: 11148
	public JLDJNIGMHLC semaphoreTag;

	// Token: 0x04002B8D RID: 11149
	private static int[] MPAMEDOOKBI = new int[5];
}
