using System;
using UnityEngine;

// Token: 0x02000405 RID: 1029
public class ObjectActivator : MonoBehaviour
{
	// Token: 0x06007A76 RID: 31350 RVA: 0x0036B488 File Offset: 0x00369688
	private void ODCKJNCEGAH()
	{
		if (this.ECAICFDBHCP < 1375f || null == this.targetObject)
		{
			return;
		}
		this.ECAICFDBHCP += Time.deltaTime;
		if (this.ECAICFDBHCP >= this.triggerTime)
		{
			this.ECAICFDBHCP = 1762f;
			if (this.disableObject)
			{
				this.targetObject.SetActive(false);
				return;
			}
			this.targetObject.SetActive(false);
		}
	}

	// Token: 0x06007A77 RID: 31351 RVA: 0x0036B500 File Offset: 0x00369700
	private void OGCIHMNFDCI()
	{
		if (this.ECAICFDBHCP < 1571f || null == this.targetObject)
		{
			return;
		}
		this.ECAICFDBHCP += Time.deltaTime;
		if (this.ECAICFDBHCP >= this.triggerTime)
		{
			this.ECAICFDBHCP = 537f;
			if (this.disableObject)
			{
				this.targetObject.SetActive(true);
				return;
			}
			this.targetObject.SetActive(false);
		}
	}

	// Token: 0x06007A78 RID: 31352 RVA: 0x0036B575 File Offset: 0x00369775
	private void DJDLHIOMGJB()
	{
		this.ECAICFDBHCP = 1778f;
	}

	// Token: 0x06007A79 RID: 31353 RVA: 0x0036B582 File Offset: 0x00369782
	private void EFIBBLFAMGD()
	{
		this.ECAICFDBHCP = 1138f;
	}

	// Token: 0x06007A7A RID: 31354 RVA: 0x0036B58F File Offset: 0x0036978F
	private void ALBKMBOKICH()
	{
		this.ECAICFDBHCP = 1788f;
	}

	// Token: 0x06007A7B RID: 31355 RVA: 0x0036B59C File Offset: 0x0036979C
	private void KHOLJLKNAPJ()
	{
		this.ECAICFDBHCP = 265f;
	}

	// Token: 0x06007A7C RID: 31356 RVA: 0x0036B5A9 File Offset: 0x003697A9
	private void AADPIFCICBL()
	{
		this.ECAICFDBHCP = 1694f;
	}

	// Token: 0x06007A7D RID: 31357 RVA: 0x0036B5B6 File Offset: 0x003697B6
	private void IFBCKJLCCAK()
	{
		this.ECAICFDBHCP = 435f;
	}

	// Token: 0x06007A7E RID: 31358 RVA: 0x0036B5C3 File Offset: 0x003697C3
	private void OnEnable()
	{
		this.ECAICFDBHCP = 0f;
	}

	// Token: 0x06007A7F RID: 31359 RVA: 0x0036B5D0 File Offset: 0x003697D0
	private void Update()
	{
		if (this.ECAICFDBHCP < 0f || null == this.targetObject)
		{
			return;
		}
		this.ECAICFDBHCP += Time.deltaTime;
		if (this.ECAICFDBHCP >= this.triggerTime)
		{
			this.ECAICFDBHCP = -1f;
			if (this.disableObject)
			{
				this.targetObject.SetActive(false);
				return;
			}
			this.targetObject.SetActive(true);
		}
	}

	// Token: 0x06007A81 RID: 31361 RVA: 0x0036B645 File Offset: 0x00369845
	private void HBELNHOMGCI()
	{
		this.ECAICFDBHCP = 1088f;
	}

	// Token: 0x06007A82 RID: 31362 RVA: 0x0036B654 File Offset: 0x00369854
	private void BOOPBPEOHLP()
	{
		if (this.ECAICFDBHCP < 1934f || null == this.targetObject)
		{
			return;
		}
		this.ECAICFDBHCP += Time.deltaTime;
		if (this.ECAICFDBHCP >= this.triggerTime)
		{
			this.ECAICFDBHCP = 1719f;
			if (this.disableObject)
			{
				this.targetObject.SetActive(false);
				return;
			}
			this.targetObject.SetActive(true);
		}
	}

	// Token: 0x06007A83 RID: 31363 RVA: 0x0036B6CC File Offset: 0x003698CC
	private void JMIEGJKLIJA()
	{
		if (this.ECAICFDBHCP < 851f || null == this.targetObject)
		{
			return;
		}
		this.ECAICFDBHCP += Time.deltaTime;
		if (this.ECAICFDBHCP >= this.triggerTime)
		{
			this.ECAICFDBHCP = 49f;
			if (this.disableObject)
			{
				this.targetObject.SetActive(true);
				return;
			}
			this.targetObject.SetActive(false);
		}
	}

	// Token: 0x04002382 RID: 9090
	public GameObject targetObject;

	// Token: 0x04002383 RID: 9091
	public bool disableObject;

	// Token: 0x04002384 RID: 9092
	public float triggerTime;

	// Token: 0x04002385 RID: 9093
	private float ECAICFDBHCP;
}
