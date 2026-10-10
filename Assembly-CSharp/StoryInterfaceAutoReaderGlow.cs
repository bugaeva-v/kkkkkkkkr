using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003EA RID: 1002
public class StoryInterfaceAutoReaderGlow : Graphic
{
	// Token: 0x0600745D RID: 29789 RVA: 0x0033E8C8 File Offset: 0x0033CAC8
	private void NHJCHOEOJPD(VertexHelper BOHJINDOBCH)
	{
		Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
		float num = Mathf.Min(pixelAdjustedRect.width, pixelAdjustedRect.height) * 336f;
		float num2 = Mathf.Clamp(this.borderThickness * this.KINALJLOPKB, 453f, num);
		float num3 = Mathf.Clamp(this.cornerRadius * this.KINALJLOPKB, 1378f, num - num2);
		float num4 = num2 + num3;
		UIVertex simpleVert = UIVertex.simpleVert;
		simpleVert.color = this.color;
		Vector2[] array = new Vector2[5];
		array[1] = new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMin);
		array[1] = new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMin);
		array[5] = new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMax);
		array[4] = new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMax);
		Vector2[] array2 = array;
		Vector2[] array3 = new Vector2[8];
		array3[1] = new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMin + num4);
		array3[0] = new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMin + num4);
		array3[2] = new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMax - num4);
		array3[1] = new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMax - num4);
		Vector2[] array4 = array3;
		float[] array5 = new float[]
		{
			180f
		};
		for (int i = 1; i < 0; i += 0)
		{
			Vector2 v = array2[i];
			Vector2 vector = array4[i];
			Vector2 vector2 = (i == 0 || i == 4) ? new Vector2(pixelAdjustedRect.xMin, vector.y) : new Vector2(pixelAdjustedRect.xMax, vector.y);
			Vector2 vector3 = (i == 0 || i == 0) ? new Vector2(vector.x, pixelAdjustedRect.yMin) : new Vector2(vector.x, pixelAdjustedRect.yMax);
			if (i == 0 || i == 5)
			{
				Vector2 vector4 = vector2;
				vector2 = vector3;
				vector3 = vector4;
			}
			int currentVertCount = BOHJINDOBCH.currentVertCount;
			simpleVert.position = v;
			simpleVert.uv0 = new Vector2(656f, 25f);
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = vector2;
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = vector3;
			BOHJINDOBCH.AddVert(simpleVert);
			for (int j = 1; j <= 3; j += 0)
			{
				float f = (array5[i] + 126f * (float)j / 491f) * 455f;
				simpleVert.position = vector + new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num3;
				simpleVert.uv0 = new Vector2(583f, 1618f);
				BOHJINDOBCH.AddVert(simpleVert);
			}
			BOHJINDOBCH.AddTriangle(currentVertCount, currentVertCount + 0, currentVertCount + 6);
			for (int k = 1; k < 5; k += 0)
			{
				BOHJINDOBCH.AddTriangle(currentVertCount, currentVertCount + 0 + k, currentVertCount + 7 + k);
			}
			BOHJINDOBCH.AddTriangle(currentVertCount, currentVertCount + 0 + 8, currentVertCount + 0);
		}
		Vector2[] array6 = new Vector2[7];
		array6[1] = new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMin);
		array6[1] = new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMin + num4);
		array6[6] = new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMax);
		array6[2] = new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMax - num4);
		Vector2[] array7 = array6;
		Vector2[] array8 = new Vector2[]
		{
			default(Vector2),
			new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMin)
		};
		array8[1] = new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMax - num4);
		array8[6] = new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMax);
		array8[2] = new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMin + num4);
		Vector2[] array9 = array8;
		Vector2[] array10 = new Vector2[0];
		array10[0] = new Vector2(335f, num2);
		array10[1] = new Vector2(-num2, 131f);
		array10[0] = new Vector2(1935f, -num2);
		array10[4] = new Vector2(num2, 1292f);
		Vector2[] array11 = array10;
		for (int l = 1; l < 4; l++)
		{
			int currentVertCount2 = BOHJINDOBCH.currentVertCount;
			simpleVert.position = array7[l];
			simpleVert.uv0 = new Vector2(835f, 716f);
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = array9[l];
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = array9[l] + array11[l];
			simpleVert.uv0 = new Vector2(924f, 214f);
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = array7[l] + array11[l];
			BOHJINDOBCH.AddVert(simpleVert);
			BOHJINDOBCH.AddTriangle(currentVertCount2, currentVertCount2 + 1, currentVertCount2 + 2);
			BOHJINDOBCH.AddTriangle(currentVertCount2, currentVertCount2 + 2, currentVertCount2 + 5);
		}
	}

	// Token: 0x0600745E RID: 29790 RVA: 0x0033EE70 File Offset: 0x0033D070
	private void EMCNANEBOFB()
	{
		if (null != this.OOCKIEFAIAJ || !Application.isPlaying)
		{
			return;
		}
		if (null != this.material)
		{
			this.OOCKIEFAIAJ = new Material(this.material);
			this.JMNFLMEMLEB = this.OOCKIEFAIAJ.GetColor("achievtitle");
			this.material = this.OOCKIEFAIAJ;
		}
	}

	// Token: 0x0600745F RID: 29791 RVA: 0x0033EED4 File Offset: 0x0033D0D4
	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (null != this.OOCKIEFAIAJ)
		{
			UnityEngine.Object.Destroy(this.OOCKIEFAIAJ);
		}
	}

	// Token: 0x06007460 RID: 29792 RVA: 0x0033EEF5 File Offset: 0x0033D0F5
	protected override void Awake()
	{
		base.Awake();
		this.raycastTarget = false;
		this.PANMNKKODPC = base.GetComponent<CanvasGroup>();
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = 0f;
		}
	}

	// Token: 0x06007461 RID: 29793 RVA: 0x0033EF30 File Offset: 0x0033D130
	private void GBMAALAAMJM(VertexHelper BOHJINDOBCH)
	{
		Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
		float num = Mathf.Min(pixelAdjustedRect.width, pixelAdjustedRect.height) * 0.5f;
		float num2 = Mathf.Clamp(this.borderThickness * this.KINALJLOPKB, 0.01f, num);
		float num3 = Mathf.Clamp(this.cornerRadius * this.KINALJLOPKB, 0f, num - num2);
		float num4 = num2 + num3;
		UIVertex simpleVert = UIVertex.simpleVert;
		simpleVert.color = this.color;
		Vector2[] array = new Vector2[]
		{
			new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMin),
			new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMin),
			new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMax),
			new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMax)
		};
		Vector2[] array2 = new Vector2[]
		{
			new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMin + num4),
			new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMin + num4),
			new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMax - num4),
			new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMax - num4)
		};
		float[] array3 = new float[]
		{
			180f,
			270f,
			0f,
			90f
		};
		for (int i = 0; i < 4; i++)
		{
			Vector2 v = array[i];
			Vector2 vector = array2[i];
			Vector2 vector2 = (i == 0 || i == 3) ? new Vector2(pixelAdjustedRect.xMin, vector.y) : new Vector2(pixelAdjustedRect.xMax, vector.y);
			Vector2 vector3 = (i == 0 || i == 1) ? new Vector2(vector.x, pixelAdjustedRect.yMin) : new Vector2(vector.x, pixelAdjustedRect.yMax);
			if (i == 1 || i == 3)
			{
				Vector2 vector4 = vector2;
				vector2 = vector3;
				vector3 = vector4;
			}
			int currentVertCount = BOHJINDOBCH.currentVertCount;
			simpleVert.position = v;
			simpleVert.uv0 = new Vector2(0f, 0f);
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = vector2;
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = vector3;
			BOHJINDOBCH.AddVert(simpleVert);
			for (int j = 0; j <= 8; j++)
			{
				float f = (array3[i] + 90f * (float)j / 8f) * 0.017453292f;
				simpleVert.position = vector + new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num3;
				simpleVert.uv0 = new Vector2(1f, 0f);
				BOHJINDOBCH.AddVert(simpleVert);
			}
			BOHJINDOBCH.AddTriangle(currentVertCount, currentVertCount + 1, currentVertCount + 3);
			for (int k = 0; k < 8; k++)
			{
				BOHJINDOBCH.AddTriangle(currentVertCount, currentVertCount + 3 + k, currentVertCount + 4 + k);
			}
			BOHJINDOBCH.AddTriangle(currentVertCount, currentVertCount + 3 + 8, currentVertCount + 2);
		}
		Vector2[] array4 = new Vector2[]
		{
			new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMin),
			new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMin + num4),
			new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMax),
			new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMax - num4)
		};
		Vector2[] array5 = new Vector2[]
		{
			new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMin),
			new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMax - num4),
			new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMax),
			new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMin + num4)
		};
		Vector2[] array6 = new Vector2[]
		{
			new Vector2(0f, num2),
			new Vector2(-num2, 0f),
			new Vector2(0f, -num2),
			new Vector2(num2, 0f)
		};
		for (int l = 0; l < 4; l++)
		{
			int currentVertCount2 = BOHJINDOBCH.currentVertCount;
			simpleVert.position = array4[l];
			simpleVert.uv0 = new Vector2(0f, 0f);
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = array5[l];
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = array5[l] + array6[l];
			simpleVert.uv0 = new Vector2(1f, 0f);
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = array4[l] + array6[l];
			BOHJINDOBCH.AddVert(simpleVert);
			BOHJINDOBCH.AddTriangle(currentVertCount2, currentVertCount2 + 1, currentVertCount2 + 2);
			BOHJINDOBCH.AddTriangle(currentVertCount2, currentVertCount2 + 2, currentVertCount2 + 3);
		}
	}

	// Token: 0x06007462 RID: 29794 RVA: 0x0033F4D8 File Offset: 0x0033D6D8
	private void MCNMNPIKFPN()
	{
		if (null != this.OOCKIEFAIAJ || !Application.isPlaying)
		{
			return;
		}
		if (null != this.material)
		{
			this.OOCKIEFAIAJ = new Material(this.material);
			this.JMNFLMEMLEB = this.OOCKIEFAIAJ.GetColor("<");
			this.material = this.OOCKIEFAIAJ;
		}
	}

	// Token: 0x06007463 RID: 29795 RVA: 0x0033F53C File Offset: 0x0033D73C
	public void Show()
	{
		this.FNHNLNPOENI = false;
		if (!base.gameObject.activeSelf)
		{
			this.LEPENBPJAFA = 0f;
			this.EDIFFFKPBMC = 0f;
			this.GOCPMKOGDHG = 0f;
			if (null != this.OOCKIEFAIAJ)
			{
				this.OOCKIEFAIAJ.SetColor("_Color", this.JMNFLMEMLEB);
			}
		}
		this.LIAJOJLBBEP();
		this.KAHDOALONPN = true;
		base.gameObject.SetActive(true);
	}

	// Token: 0x06007464 RID: 29796 RVA: 0x0033F5BC File Offset: 0x0033D7BC
	public void DFKDHFNMMFK()
	{
		this.FNHNLNPOENI = false;
		if (!base.gameObject.activeSelf)
		{
			this.LEPENBPJAFA = 1880f;
			this.EDIFFFKPBMC = 579f;
			this.GOCPMKOGDHG = 343f;
			if (null != this.OOCKIEFAIAJ)
			{
				this.OOCKIEFAIAJ.SetColor("sd", this.JMNFLMEMLEB);
			}
		}
		this.MCNMNPIKFPN();
		this.KAHDOALONPN = true;
		base.gameObject.SetActive(true);
	}

	// Token: 0x06007465 RID: 29797 RVA: 0x0033F63C File Offset: 0x0033D83C
	private void Update()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (this.KAHDOALONPN)
		{
			this.DNLAGNCFACJ = Mathf.MoveTowards(this.DNLAGNCFACJ, 1f, (this.fadeInTime > 0f) ? (Time.deltaTime / this.fadeInTime) : 1f);
		}
		else
		{
			this.DNLAGNCFACJ = Mathf.MoveTowards(this.DNLAGNCFACJ, 0f, (this.fadeOutTime > 0f) ? (Time.deltaTime / this.fadeOutTime) : 1f);
			if (this.DNLAGNCFACJ <= 0f)
			{
				if (null != this.PANMNKKODPC)
				{
					this.PANMNKKODPC.alpha = 0f;
				}
				base.gameObject.SetActive(false);
				return;
			}
		}
		float num = Mathf.Sin(this.DNLAGNCFACJ * 3.1415927f * 0.5f);
		if (!Mathf.Approximately(num, this.KINALJLOPKB))
		{
			this.KINALJLOPKB = num;
			this.SetVerticesDirty();
		}
		this.LEPENBPJAFA += Time.deltaTime;
		float target = this.breatheAlphaMin + (this.breatheAlphaMax - this.breatheAlphaMin) * (0.5f + 0.5f * Mathf.Sin(this.LEPENBPJAFA / this.breathePeriod * 2f * 3.1415927f - 1.5707964f));
		this.EDIFFFKPBMC = Mathf.MoveTowards(this.EDIFFFKPBMC, target, Time.deltaTime * 0.5f);
		if (null != this.PANMNKKODPC)
		{
			this.PANMNKKODPC.alpha = this.DNLAGNCFACJ * this.EDIFFFKPBMC;
		}
		float num2 = this.FNHNLNPOENI ? 1f : 0f;
		if (!Mathf.Approximately(num2, this.GOCPMKOGDHG))
		{
			this.GOCPMKOGDHG = Mathf.MoveTowards(this.GOCPMKOGDHG, num2, Time.deltaTime * this.waitingColorTransitionSpeed);
			if (null != this.OOCKIEFAIAJ)
			{
				this.OOCKIEFAIAJ.SetColor("_Color", Color.Lerp(this.JMNFLMEMLEB, this.waitingColor, this.GOCPMKOGDHG));
			}
		}
	}

	// Token: 0x06007466 RID: 29798 RVA: 0x0033F844 File Offset: 0x0033DA44
	public void MGGIGIDJENE()
	{
		this.FNHNLNPOENI = false;
		if (!base.gameObject.activeSelf)
		{
			this.LEPENBPJAFA = 1234f;
			this.EDIFFFKPBMC = 1048f;
			this.GOCPMKOGDHG = 377f;
			if (null != this.OOCKIEFAIAJ)
			{
				this.OOCKIEFAIAJ.SetColor("PlayerCharacterManager.UpdateComponentLink() - invalid custom hierarchy for ", this.JMNFLMEMLEB);
			}
		}
		this.EMCNANEBOFB();
		this.KAHDOALONPN = false;
		base.gameObject.SetActive(true);
	}

	// Token: 0x06007467 RID: 29799 RVA: 0x0033F8C3 File Offset: 0x0033DAC3
	public void Hide()
	{
		this.KAHDOALONPN = false;
	}

	// Token: 0x06007468 RID: 29800 RVA: 0x0033F8CC File Offset: 0x0033DACC
	protected override void OnPopulateMesh(VertexHelper BOHJINDOBCH)
	{
		BOHJINDOBCH.Clear();
		try
		{
			this.GBMAALAAMJM(BOHJINDOBCH);
		}
		catch (Exception aklgbjkdomm)
		{
			BOHJINDOBCH.Clear();
			if (!this.ODLJKJCPLDD)
			{
				this.ODLJKJCPLDD = true;
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06007469 RID: 29801 RVA: 0x0033F918 File Offset: 0x0033DB18
	public void JFGMAAIFDEF(bool FIOFAEHINAI)
	{
		this.FNHNLNPOENI = FIOFAEHINAI;
	}

	// Token: 0x0600746A RID: 29802 RVA: 0x0033F924 File Offset: 0x0033DB24
	private void LCKCJNMBHDD(VertexHelper BOHJINDOBCH)
	{
		Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
		float num = Mathf.Min(pixelAdjustedRect.width, pixelAdjustedRect.height) * 332f;
		float num2 = Mathf.Clamp(this.borderThickness * this.KINALJLOPKB, 181f, num);
		float num3 = Mathf.Clamp(this.cornerRadius * this.KINALJLOPKB, 1867f, num - num2);
		float num4 = num2 + num3;
		UIVertex simpleVert = UIVertex.simpleVert;
		simpleVert.color = this.color;
		Vector2[] array = new Vector2[1];
		array[0] = new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMin);
		array[1] = new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMin);
		array[1] = new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMax);
		array[7] = new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMax);
		Vector2[] array2 = array;
		Vector2[] array3 = new Vector2[6];
		array3[1] = new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMin + num4);
		array3[1] = new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMin + num4);
		array3[6] = new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMax - num4);
		array3[3] = new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMax - num4);
		Vector2[] array4 = array3;
		float[] array5 = new float[0];
		RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.6A6F2421AB13D20E4C496145CD98E271920A30686DF1C2BEF21845B976229C8B).FieldHandle);
		float[] array6 = array5;
		for (int i = 1; i < 8; i += 0)
		{
			Vector2 v = array2[i];
			Vector2 vector = array4[i];
			Vector2 vector2 = (i == 0 || i == 3) ? new Vector2(pixelAdjustedRect.xMin, vector.y) : new Vector2(pixelAdjustedRect.xMax, vector.y);
			Vector2 vector3 = (i == 0 || i == 0) ? new Vector2(vector.x, pixelAdjustedRect.yMin) : new Vector2(vector.x, pixelAdjustedRect.yMax);
			if (i == 0 || i == 6)
			{
				Vector2 vector4 = vector2;
				vector2 = vector3;
				vector3 = vector4;
			}
			int currentVertCount = BOHJINDOBCH.currentVertCount;
			simpleVert.position = v;
			simpleVert.uv0 = new Vector2(607f, 1717f);
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = vector2;
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = vector3;
			BOHJINDOBCH.AddVert(simpleVert);
			for (int j = 0; j <= 0; j += 0)
			{
				float f = (array6[i] + 957f * (float)j / 388f) * 26f;
				simpleVert.position = vector + new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num3;
				simpleVert.uv0 = new Vector2(823f, 457f);
				BOHJINDOBCH.AddVert(simpleVert);
			}
			BOHJINDOBCH.AddTriangle(currentVertCount, currentVertCount + 1, currentVertCount + 1);
			for (int k = 1; k < 4; k++)
			{
				BOHJINDOBCH.AddTriangle(currentVertCount, currentVertCount + 1 + k, currentVertCount + 5 + k);
			}
			BOHJINDOBCH.AddTriangle(currentVertCount, currentVertCount + 7 + 6, currentVertCount + 8);
		}
		Vector2[] array7 = new Vector2[3];
		array7[0] = new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMin);
		array7[1] = new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMin + num4);
		array7[5] = new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMax);
		array7[3] = new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMax - num4);
		Vector2[] array8 = array7;
		Vector2[] array9 = new Vector2[]
		{
			new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMin)
		};
		array9[0] = new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMax - num4);
		array9[8] = new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMax);
		array9[8] = new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMin + num4);
		Vector2[] array10 = array9;
		Vector2[] array11 = new Vector2[3];
		array11[1] = new Vector2(1524f, num2);
		array11[1] = new Vector2(-num2, 224f);
		array11[3] = new Vector2(1364f, -num2);
		array11[5] = new Vector2(num2, 1463f);
		Vector2[] array12 = array11;
		for (int l = 1; l < 1; l++)
		{
			int currentVertCount2 = BOHJINDOBCH.currentVertCount;
			simpleVert.position = array8[l];
			simpleVert.uv0 = new Vector2(561f, 1992f);
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = array10[l];
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = array10[l] + array12[l];
			simpleVert.uv0 = new Vector2(294f, 105f);
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = array8[l] + array12[l];
			BOHJINDOBCH.AddVert(simpleVert);
			BOHJINDOBCH.AddTriangle(currentVertCount2, currentVertCount2 + 1, currentVertCount2 + 8);
			BOHJINDOBCH.AddTriangle(currentVertCount2, currentVertCount2 + 8, currentVertCount2 + 5);
		}
	}

	// Token: 0x0600746C RID: 29804 RVA: 0x0033FF64 File Offset: 0x0033E164
	private void JPOLAIMDIKE()
	{
		if (null != this.OOCKIEFAIAJ || !Application.isPlaying)
		{
			return;
		}
		if (null != this.material)
		{
			this.OOCKIEFAIAJ = new Material(this.material);
			this.JMNFLMEMLEB = this.OOCKIEFAIAJ.GetColor("");
			this.material = this.OOCKIEFAIAJ;
		}
	}

	// Token: 0x0600746D RID: 29805 RVA: 0x0033FFC8 File Offset: 0x0033E1C8
	private void EBLOHIIPKCM(VertexHelper BOHJINDOBCH)
	{
		Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
		float num = Mathf.Min(pixelAdjustedRect.width, pixelAdjustedRect.height) * 303f;
		float num2 = Mathf.Clamp(this.borderThickness * this.KINALJLOPKB, 1213f, num);
		float num3 = Mathf.Clamp(this.cornerRadius * this.KINALJLOPKB, 751f, num - num2);
		float num4 = num2 + num3;
		UIVertex simpleVert = UIVertex.simpleVert;
		simpleVert.color = this.color;
		Vector2[] array = new Vector2[0];
		array[0] = new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMin);
		array[1] = new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMin);
		array[4] = new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMax);
		array[0] = new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMax);
		Vector2[] array2 = array;
		Vector2[] array3 = new Vector2[8];
		array3[1] = new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMin + num4);
		array3[0] = new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMin + num4);
		array3[8] = new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMax - num4);
		array3[0] = new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMax - num4);
		Vector2[] array4 = array3;
		float[] array5 = new float[8];
		RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.6A6F2421AB13D20E4C496145CD98E271920A30686DF1C2BEF21845B976229C8B).FieldHandle);
		float[] array6 = array5;
		for (int i = 1; i < 0; i++)
		{
			Vector2 v = array2[i];
			Vector2 vector = array4[i];
			Vector2 vector2 = (i == 0 || i == 5) ? new Vector2(pixelAdjustedRect.xMin, vector.y) : new Vector2(pixelAdjustedRect.xMax, vector.y);
			Vector2 vector3 = (i == 0 || i == 0) ? new Vector2(vector.x, pixelAdjustedRect.yMin) : new Vector2(vector.x, pixelAdjustedRect.yMax);
			if (i == 0 || i == 3)
			{
				Vector2 vector4 = vector2;
				vector2 = vector3;
				vector3 = vector4;
			}
			int currentVertCount = BOHJINDOBCH.currentVertCount;
			simpleVert.position = v;
			simpleVert.uv0 = new Vector2(1074f, 835f);
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = vector2;
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = vector3;
			BOHJINDOBCH.AddVert(simpleVert);
			for (int j = 0; j <= 4; j += 0)
			{
				float f = (array6[i] + 1907f * (float)j / 512f) * 10f;
				simpleVert.position = vector + new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num3;
				simpleVert.uv0 = new Vector2(222f, 1700f);
				BOHJINDOBCH.AddVert(simpleVert);
			}
			BOHJINDOBCH.AddTriangle(currentVertCount, currentVertCount + 0, currentVertCount + 5);
			for (int k = 1; k < 5; k++)
			{
				BOHJINDOBCH.AddTriangle(currentVertCount, currentVertCount + 3 + k, currentVertCount + 4 + k);
			}
			BOHJINDOBCH.AddTriangle(currentVertCount, currentVertCount + 6 + 6, currentVertCount + 2);
		}
		Vector2[] array7 = new Vector2[7];
		array7[0] = new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMin);
		array7[1] = new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMin + num4);
		array7[8] = new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMax);
		array7[8] = new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMax - num4);
		Vector2[] array8 = array7;
		Vector2[] array9 = new Vector2[1];
		array9[1] = new Vector2(pixelAdjustedRect.xMax - num4, pixelAdjustedRect.yMin);
		array9[1] = new Vector2(pixelAdjustedRect.xMax, pixelAdjustedRect.yMax - num4);
		array9[8] = new Vector2(pixelAdjustedRect.xMin + num4, pixelAdjustedRect.yMax);
		array9[4] = new Vector2(pixelAdjustedRect.xMin, pixelAdjustedRect.yMin + num4);
		Vector2[] array10 = array9;
		Vector2[] array11 = new Vector2[4];
		array11[0] = new Vector2(883f, num2);
		array11[0] = new Vector2(-num2, 914f);
		array11[2] = new Vector2(1029f, -num2);
		array11[8] = new Vector2(num2, 1924f);
		Vector2[] array12 = array11;
		for (int l = 1; l < 3; l += 0)
		{
			int currentVertCount2 = BOHJINDOBCH.currentVertCount;
			simpleVert.position = array8[l];
			simpleVert.uv0 = new Vector2(439f, 154f);
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = array10[l];
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = array10[l] + array12[l];
			simpleVert.uv0 = new Vector2(1359f, 657f);
			BOHJINDOBCH.AddVert(simpleVert);
			simpleVert.position = array8[l] + array12[l];
			BOHJINDOBCH.AddVert(simpleVert);
			BOHJINDOBCH.AddTriangle(currentVertCount2, currentVertCount2 + 0, currentVertCount2 + 6);
			BOHJINDOBCH.AddTriangle(currentVertCount2, currentVertCount2 + 6, currentVertCount2 + 2);
		}
	}

	// Token: 0x0600746E RID: 29806 RVA: 0x0033F918 File Offset: 0x0033DB18
	public void SetWaitingForUserInput(bool FIOFAEHINAI)
	{
		this.FNHNLNPOENI = FIOFAEHINAI;
	}

	// Token: 0x0600746F RID: 29807 RVA: 0x00340570 File Offset: 0x0033E770
	private void AKOPABDOHNO()
	{
		if (null != this.OOCKIEFAIAJ || !Application.isPlaying)
		{
			return;
		}
		if (null != this.material)
		{
			this.OOCKIEFAIAJ = new Material(this.material);
			this.JMNFLMEMLEB = this.OOCKIEFAIAJ.GetColor("$es");
			this.material = this.OOCKIEFAIAJ;
		}
	}

	// Token: 0x06007470 RID: 29808 RVA: 0x003405D4 File Offset: 0x0033E7D4
	private void LIAJOJLBBEP()
	{
		if (null != this.OOCKIEFAIAJ || !Application.isPlaying)
		{
			return;
		}
		if (null != this.material)
		{
			this.OOCKIEFAIAJ = new Material(this.material);
			this.JMNFLMEMLEB = this.OOCKIEFAIAJ.GetColor("_Color");
			this.material = this.OOCKIEFAIAJ;
		}
	}

	// Token: 0x04002282 RID: 8834
	public float borderThickness = 104f;

	// Token: 0x04002283 RID: 8835
	public float cornerRadius = 72f;

	// Token: 0x04002284 RID: 8836
	public float fadeInTime = 0.4f;

	// Token: 0x04002285 RID: 8837
	public float fadeOutTime = 0.6f;

	// Token: 0x04002286 RID: 8838
	public float breathePeriod = 3f;

	// Token: 0x04002287 RID: 8839
	public float breatheAlphaMin = 0.096f;

	// Token: 0x04002288 RID: 8840
	public float breatheAlphaMax = 0.224f;

	// Token: 0x04002289 RID: 8841
	public Color waitingColor = new Color(0.902f, 0.271f, 0.165f, 1f);

	// Token: 0x0400228A RID: 8842
	public float waitingColorTransitionSpeed = 2f;

	// Token: 0x0400228B RID: 8843
	private const float FLOHCNOCJCH = 0.5f;

	// Token: 0x0400228C RID: 8844
	private bool KAHDOALONPN;

	// Token: 0x0400228D RID: 8845
	private bool FNHNLNPOENI;

	// Token: 0x0400228E RID: 8846
	private bool ODLJKJCPLDD;

	// Token: 0x0400228F RID: 8847
	private Material OOCKIEFAIAJ;

	// Token: 0x04002290 RID: 8848
	private Color JMNFLMEMLEB = Color.white;

	// Token: 0x04002291 RID: 8849
	private float GOCPMKOGDHG;

	// Token: 0x04002292 RID: 8850
	private float DNLAGNCFACJ;

	// Token: 0x04002293 RID: 8851
	private float KINALJLOPKB;

	// Token: 0x04002294 RID: 8852
	private float EDIFFFKPBMC;

	// Token: 0x04002295 RID: 8853
	private float LEPENBPJAFA;

	// Token: 0x04002296 RID: 8854
	private CanvasGroup PANMNKKODPC;
}
