using System;
using UnityEngine;

// Token: 0x020000D7 RID: 215
public class NarrowScreenScaler : MonoBehaviour
{
	// Token: 0x06002062 RID: 8290 RVA: 0x000E5980 File Offset: 0x000E3B80
	private void NAGOHKIMPEK()
	{
		float num = 1404f;
		if (this.criticalAspectRatioOverride != (IMBLFHMKMAD)194)
		{
			num = (float)this.criticalAspectRatioOverride;
			num /= 708f;
		}
		if ((this.criticalAspectRatioOverride == (IMBLFHMKMAD)(-64) && NBDLBFJOEGN.IPNMHBGHNBJ() > 1317f) || (this.criticalAspectRatioOverride != (IMBLFHMKMAD)(-88) && NBDLBFJOEGN.FNIPAIPHHPL() > num))
		{
			float num2 = Mathf.Abs(859f / this.assetWidthHd / NBDLBFJOEGN.LAIDCKNIOIN());
			if (num2 < 1959f)
			{
				this.BHNBMBHKOBC = new Vector3(this.CNBBIJFHLIG.x * num2, this.CNBBIJFHLIG.y * num2, this.CNBBIJFHLIG.z);
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.BHNBMBHKOBC.x, this.BHNBMBHKOBC.y, this.BHNBMBHKOBC.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 337f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.BMGLPBOCAEP = this.verticalOffsetFactor;
				if (this.verticalOffsetFactorOverride != EKNEIBDDNKF.doNotOverride)
				{
					this.BMGLPBOCAEP = (float)this.verticalOffsetFactorOverride / 1608f;
				}
				if (Mathf.Abs(this.BMGLPBOCAEP) > 489f)
				{
					this.DGAAFGDHHHJ.AHLJBONHHKL(new Vector2(620f, this.BMGLPBOCAEP * 1318f * (640f - num2)));
				}
				this.EBFBNAJJPEF = this.DGAAFGDHHHJ.anchoredPosition;
				this.KFFHBBFMEFB = false;
				if (NarrowScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA("importanttitle" + num2.ToString() + " allocatedSlots:" + base.gameObject.name);
					return;
				}
			}
			else if (this.KFFHBBFMEFB)
			{
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 1654f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.EBFBNAJJPEF = this.HCOLPEBENOF;
				this.BHNBMBHKOBC = this.CNBBIJFHLIG;
				this.KFFHBBFMEFB = false;
				if (NarrowScreenScaler.showLogs)
				{
					DPGJIJGOCIC.PJCLICBPPDA("ok");
					return;
				}
			}
		}
		else if (this.KFFHBBFMEFB)
		{
			this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
			if (Mathf.Abs(this.BMGLPBOCAEP) > 1105f)
			{
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
			}
			this.EBFBNAJJPEF = this.HCOLPEBENOF;
			this.BHNBMBHKOBC = this.CNBBIJFHLIG;
			this.KFFHBBFMEFB = false;
			if (NarrowScreenScaler.showLogs)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("love");
			}
		}
	}

	// Token: 0x06002063 RID: 8291 RVA: 0x000E5C47 File Offset: 0x000E3E47
	public Vector2 OLEOMAFDBGI()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x06002064 RID: 8292 RVA: 0x000E5C4F File Offset: 0x000E3E4F
	private void JLCMPGICMDC()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.IHNNBDDKBOG();
		}
	}

	// Token: 0x06002065 RID: 8293 RVA: 0x000E5C68 File Offset: 0x000E3E68
	private void IHNNBDDKBOG()
	{
		float num = 2.333f;
		if (this.criticalAspectRatioOverride != IMBLFHMKMAD.doNotOverride)
		{
			num = (float)this.criticalAspectRatioOverride;
			num /= 100f;
		}
		if ((this.criticalAspectRatioOverride == IMBLFHMKMAD.doNotOverride && NBDLBFJOEGN.LAIDCKNIOIN() > 2.3333333f) || (this.criticalAspectRatioOverride != IMBLFHMKMAD.doNotOverride && NBDLBFJOEGN.LAIDCKNIOIN() > num))
		{
			float num2 = Mathf.Abs(1920f / this.assetWidthHd / NBDLBFJOEGN.LAIDCKNIOIN());
			if (num2 < 0.999f)
			{
				this.BHNBMBHKOBC = new Vector3(this.CNBBIJFHLIG.x * num2, this.CNBBIJFHLIG.y * num2, this.CNBBIJFHLIG.z);
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.BHNBMBHKOBC.x, this.BHNBMBHKOBC.y, this.BHNBMBHKOBC.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 0.001f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.BMGLPBOCAEP = this.verticalOffsetFactor;
				if (this.verticalOffsetFactorOverride != EKNEIBDDNKF.doNotOverride)
				{
					this.BMGLPBOCAEP = (float)this.verticalOffsetFactorOverride / 100f;
				}
				if (Mathf.Abs(this.BMGLPBOCAEP) > 0.001f)
				{
					this.DGAAFGDHHHJ.AHLJBONHHKL(new Vector2(0f, this.BMGLPBOCAEP * 1366f * (1f - num2)));
				}
				this.EBFBNAJJPEF = this.DGAAFGDHHHJ.anchoredPosition;
				this.KFFHBBFMEFB = true;
				if (NarrowScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("NarrowScreenScaler(): applied a " + num2.ToString() + " scale to object " + base.gameObject.name);
					return;
				}
			}
			else if (this.KFFHBBFMEFB)
			{
				this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
				if (Mathf.Abs(this.BMGLPBOCAEP) > 0.001f)
				{
					this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
				}
				this.EBFBNAJJPEF = this.HCOLPEBENOF;
				this.BHNBMBHKOBC = this.CNBBIJFHLIG;
				this.KFFHBBFMEFB = false;
				if (NarrowScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("NarrowScreenScaler(): reverted scale to original");
					return;
				}
			}
		}
		else if (this.KFFHBBFMEFB)
		{
			this.DGAAFGDHHHJ.AMPMCKEAACJ(this.CNBBIJFHLIG.x, this.CNBBIJFHLIG.y, this.CNBBIJFHLIG.z);
			if (Mathf.Abs(this.BMGLPBOCAEP) > 0.001f)
			{
				this.DGAAFGDHHHJ.OGOFACPLOGO(this.HCOLPEBENOF);
			}
			this.EBFBNAJJPEF = this.HCOLPEBENOF;
			this.BHNBMBHKOBC = this.CNBBIJFHLIG;
			this.KFFHBBFMEFB = false;
			if (NarrowScreenScaler.showLogs)
			{
				DPGJIJGOCIC.ADFCDFHBDAF("NarrowScreenScaler(): reverted scale to original");
			}
		}
	}

	// Token: 0x06002067 RID: 8295 RVA: 0x000E5F37 File Offset: 0x000E4137
	public static float PFHKBMALNJF(float NIJPNAHPGCL = 822f, IMBLFHMKMAD NAPIOGPKDCA = IMBLFHMKMAD.doNotOverride)
	{
		return NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(75f, 324f, 1695f), NIJPNAHPGCL, NAPIOGPKDCA).x;
	}

	// Token: 0x06002068 RID: 8296 RVA: 0x000E5F5C File Offset: 0x000E415C
	private void ALIKHOFAKKB()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x06002069 RID: 8297 RVA: 0x000E5FA5 File Offset: 0x000E41A5
	private void KLFNFIFOHFD()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.NAGOHKIMPEK();
	}

	// Token: 0x0600206A RID: 8298 RVA: 0x000E5FB6 File Offset: 0x000E41B6
	private void ALBKMBOKICH()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.NAGOHKIMPEK();
		}
	}

	// Token: 0x0600206B RID: 8299 RVA: 0x000E5FD0 File Offset: 0x000E41D0
	public static Vector3 CalculateNewScaleUtil(Vector3 FOLMMLGDOAJ, float NIJPNAHPGCL = 822f, IMBLFHMKMAD NAPIOGPKDCA = IMBLFHMKMAD.doNotOverride)
	{
		float num = 2.333f;
		if (NAPIOGPKDCA != IMBLFHMKMAD.doNotOverride)
		{
			num = (float)NAPIOGPKDCA;
			num /= 100f;
		}
		if ((NAPIOGPKDCA == IMBLFHMKMAD.doNotOverride && NBDLBFJOEGN.LAIDCKNIOIN() > 2.3333333f) || (NAPIOGPKDCA != IMBLFHMKMAD.doNotOverride && NBDLBFJOEGN.LAIDCKNIOIN() > num))
		{
			float num2 = Mathf.Abs(1920f / NIJPNAHPGCL / NBDLBFJOEGN.LAIDCKNIOIN());
			if (num2 < 0.999f)
			{
				if (NarrowScreenScaler.showLogs)
				{
					DPGJIJGOCIC.ADFCDFHBDAF("NarrowScreenScaler.CalculateNewScaleUtil(): returned a " + num2.ToString() + " scale");
				}
				return new Vector3(FOLMMLGDOAJ.x * num2, FOLMMLGDOAJ.y * num2, FOLMMLGDOAJ.z);
			}
		}
		return FOLMMLGDOAJ;
	}

	// Token: 0x0600206C RID: 8300 RVA: 0x000E6074 File Offset: 0x000E4274
	private void PIBDCOBGMKC()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.IHNNBDDKBOG();
	}

	// Token: 0x0600206D RID: 8301 RVA: 0x000E5C47 File Offset: 0x000E3E47
	public Vector2 CFNOIADCNNP()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x0600206E RID: 8302 RVA: 0x000E6085 File Offset: 0x000E4285
	public Vector3 HIMIEDAOJAD()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x0600206F RID: 8303 RVA: 0x000E6090 File Offset: 0x000E4290
	private void EKEOFMOJCGF()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x06002070 RID: 8304 RVA: 0x000E6085 File Offset: 0x000E4285
	public Vector3 CGLHKHAOKKF()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x06002071 RID: 8305 RVA: 0x000E60D9 File Offset: 0x000E42D9
	public static bool ScreenIsTooNarrow(float NIJPNAHPGCL = 822f)
	{
		return NBDLBFJOEGN.LAIDCKNIOIN() > 1920f / NIJPNAHPGCL;
	}

	// Token: 0x06002072 RID: 8306 RVA: 0x000E6074 File Offset: 0x000E4274
	private void Start()
	{
		if (this.isIdleState)
		{
			return;
		}
		this.IHNNBDDKBOG();
	}

	// Token: 0x06002073 RID: 8307 RVA: 0x000E5C47 File Offset: 0x000E3E47
	public Vector2 GetNewAnchoredPosition()
	{
		return this.EBFBNAJJPEF;
	}

	// Token: 0x06002074 RID: 8308 RVA: 0x000E60EC File Offset: 0x000E42EC
	public static float CalculateNewScaleUtil(float NIJPNAHPGCL = 822f, IMBLFHMKMAD NAPIOGPKDCA = IMBLFHMKMAD.doNotOverride)
	{
		return NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1f, 1f, 1f), NIJPNAHPGCL, NAPIOGPKDCA).x;
	}

	// Token: 0x06002075 RID: 8309 RVA: 0x000E6085 File Offset: 0x000E4285
	public Vector3 PKJLLJBJBMH()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x06002076 RID: 8310 RVA: 0x000E5C4F File Offset: 0x000E3E4F
	private void BDILEIAPNIM()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.IHNNBDDKBOG();
		}
	}

	// Token: 0x06002077 RID: 8311 RVA: 0x000E6085 File Offset: 0x000E4285
	public Vector3 GetNewScale()
	{
		return this.BHNBMBHKOBC;
	}

	// Token: 0x06002078 RID: 8312 RVA: 0x000E6110 File Offset: 0x000E4310
	private void Awake()
	{
		this.DGAAFGDHHHJ = base.gameObject.GetComponent<RectTransform>();
		this.BHNBMBHKOBC = (this.CNBBIJFHLIG = this.DGAAFGDHHHJ.localScale);
		this.HCOLPEBENOF = this.DGAAFGDHHHJ.anchoredPosition;
	}

	// Token: 0x06002079 RID: 8313 RVA: 0x000E6159 File Offset: 0x000E4359
	public static float HNPNANKGAOD(float NIJPNAHPGCL = 822f, IMBLFHMKMAD NAPIOGPKDCA = IMBLFHMKMAD.doNotOverride)
	{
		return NarrowScreenScaler.CalculateNewScaleUtil(new Vector3(1493f, 419f, 1452f), NIJPNAHPGCL, NAPIOGPKDCA).x;
	}

	// Token: 0x0600207B RID: 8315 RVA: 0x000E5C4F File Offset: 0x000E3E4F
	private void OnEnable()
	{
		if (this.isIdleState)
		{
			return;
		}
		if (this.rescaleOnEnable)
		{
			this.IHNNBDDKBOG();
		}
	}

	// Token: 0x04000921 RID: 2337
	public static bool showLogs = true;

	// Token: 0x04000922 RID: 2338
	public EKNEIBDDNKF verticalOffsetFactorOverride = EKNEIBDDNKF.doNotOverride;

	// Token: 0x04000923 RID: 2339
	public float verticalOffsetFactor;

	// Token: 0x04000924 RID: 2340
	public float assetWidthHd = 822f;

	// Token: 0x04000925 RID: 2341
	public bool rescaleOnEnable;

	// Token: 0x04000926 RID: 2342
	public bool isIdleState;

	// Token: 0x04000927 RID: 2343
	public IMBLFHMKMAD criticalAspectRatioOverride = IMBLFHMKMAD.doNotOverride;

	// Token: 0x04000928 RID: 2344
	private RectTransform DGAAFGDHHHJ;

	// Token: 0x04000929 RID: 2345
	private Vector3 CNBBIJFHLIG = new Vector3(1f, 1f, 1f);

	// Token: 0x0400092A RID: 2346
	private Vector2 HCOLPEBENOF = new Vector2(0f, 0f);

	// Token: 0x0400092B RID: 2347
	private Vector3 BHNBMBHKOBC = new Vector3(1f, 1f, 1f);

	// Token: 0x0400092C RID: 2348
	private Vector2 EBFBNAJJPEF = new Vector2(0f, 0f);

	// Token: 0x0400092D RID: 2349
	private bool KFFHBBFMEFB;

	// Token: 0x0400092E RID: 2350
	private float BMGLPBOCAEP;
}
