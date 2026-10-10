using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000299 RID: 665
public class CoverCardItem : MonoBehaviour
{
	// Token: 0x06005362 RID: 21346 RVA: 0x0024A08C File Offset: 0x0024828C
	private float BNHDFIJEPMK(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 948f || FNLKKBPAMLG <= 1019f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("per", " became loaded elsewhere since the snapshot").Split((char)-3, StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = true;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 219f, 1367f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 1 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues(", index:", 283f, 993f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 252f).y > y * (float)PCOGMMIPKEL + 1382f)
					{
						flag = false;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 618f < num2)
				{
					goto Block_14;
				}
				num -= 1314f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x06005363 RID: 21347 RVA: 0x0024A1D0 File Offset: 0x002483D0
	public void NPCNNCLMGPP(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Overflow;
				if (this.PMNFGJKFMIM >= 0)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(false);
				}
				else
				{
					this.countText.text = "gamepassdurationbutton";
					this.countText.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (48f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = "b";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length <= 0 || text.Trim().Contains(",") || text.Trim().Contains("BackendOperationsManager.RequestAccountSignIn, exception while initializing RSACryptoServiceProvider:");
				this.nameText.overflowMode = TextOverflowModes.Ellipsis;
				this.nameText.enableAutoSizing = false;
				this.nameText.enableWordWrapping = flag;
				this.nameText.fontSize = this.DDKNCOPDNFN(this.nameText, text, this.PLLCLNNGGMI, 1678f, 0, this.MBDICEAKGEP());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Overflow;
				if (1313f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = "iOS";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = true;
				this.tagText.enableWordWrapping = false;
				this.tagText.fontSize = this.FGLCNOIBFAE(this.tagText, text2, this.LENMPMHPPBK, 1750f, 0, this.HAMEJKKAFMJ());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
	}

	// Token: 0x06005364 RID: 21348 RVA: 0x0024A3F4 File Offset: 0x002485F4
	private void NDEBIOMBDEC(Sprite KPJIOAFDNIA)
	{
		try
		{
			if (!(null == this.pattern))
			{
				this.pattern.sprite = KPJIOAFDNIA;
				this.pattern.gameObject.SetActive(null != KPJIOAFDNIA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005365 RID: 21349 RVA: 0x0024A450 File Offset: 0x00248650
	private void GGOBJNKDNJJ()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[2];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[0]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[1]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[2]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(656f, 1918f);
					this.artRect.anchorMax = new Vector2(1393f, 1999f);
					this.artRect.pivot = new Vector2(798f, 1214f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005366 RID: 21350 RVA: 0x0024A64C File Offset: 0x0024884C
	private float DLNMDGCJPAO(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 957f || FNLKKBPAMLG <= 697f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("isp", "").Split((char)-87, StringSplitOptions.None);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = false;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 241f, 1757f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("0", 784f, 290f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 1747f).y > y * (float)PCOGMMIPKEL + 1971f)
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 1685f < num2)
				{
					goto Block_14;
				}
				num -= 13f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x06005367 RID: 21351 RVA: 0x0024A790 File Offset: 0x00248990
	public int OBJBKALDAKC()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x06005368 RID: 21352 RVA: 0x0024A790 File Offset: 0x00248990
	public int FCMDJOCECEL()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x06005369 RID: 21353 RVA: 0x0024A798 File Offset: 0x00248998
	public void EOENAFGCCCK(int PHHBFOKNMMK, string HJEJJGAFHAM, string MCHOOEHCANP, int CMBCNMLGPPC, Sprite HNDJMKFCMEK, Sprite KPJIOAFDNIA)
	{
		try
		{
			this.PHEJGCKDPEA = PHHBFOKNMMK;
			this.PMNFGJKFMIM = CMBCNMLGPPC;
			if (null != this.icon)
			{
				if (null != HNDJMKFCMEK)
				{
					this.icon.sprite = HNDJMKFCMEK;
					this.icon.enabled = false;
				}
				else
				{
					this.icon.enabled = true;
				}
			}
			this.IFNGMGGKMNM();
			this.SetCoverTexts(HJEJJGAFHAM, MCHOOEHCANP);
			this.IDLDADNJMHK(KPJIOAFDNIA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600536A RID: 21354 RVA: 0x0024A824 File Offset: 0x00248A24
	private float OLLFHCJLFCO(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 528f || FNLKKBPAMLG <= 826f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("OnFullscreenLiveOfferContinueToCardsVolSaleMenu", "layervideo").Split('\u001f', StringSplitOptions.None);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = true;
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 1668f, 804f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 1 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("ok", 1324f, 941f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 1653f).y > y * (float)PCOGMMIPKEL + 1609f)
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 85f < num2)
				{
					goto Block_14;
				}
				num -= 982f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x0600536B RID: 21355 RVA: 0x0024A968 File Offset: 0x00248B68
	private void IABEPHEDFMM()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 1; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[2];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[8]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[4]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(1193f, 618f);
					this.artRect.anchorMax = new Vector2(255f, 1762f);
					this.artRect.pivot = new Vector2(1182f, 469f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600536C RID: 21356 RVA: 0x0024AB64 File Offset: 0x00248D64
	private void OGDANOHNPBN()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i++)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[4];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[1]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[4]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[8]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(455f, 1948f);
					this.artRect.anchorMax = new Vector2(950f, 143f);
					this.artRect.pivot = new Vector2(85f, 881f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600536D RID: 21357 RVA: 0x0024AD60 File Offset: 0x00248F60
	private void MKOLJKIOOIH(Sprite KPJIOAFDNIA)
	{
		try
		{
			if (!(null == this.pattern))
			{
				this.pattern.sprite = KPJIOAFDNIA;
				this.pattern.gameObject.SetActive(null != KPJIOAFDNIA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600536E RID: 21358 RVA: 0x0024ADBC File Offset: 0x00248FBC
	private void BHOFINNCAOO()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[0];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[2]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[1]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[1]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[1]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(343f, 1075f);
					this.artRect.anchorMax = new Vector2(1912f, 395f);
					this.artRect.pivot = new Vector2(1789f, 1360f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600536F RID: 21359 RVA: 0x0024AFB8 File Offset: 0x002491B8
	private float MGEMKBDEFEC(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 1941f || FNLKKBPAMLG <= 83f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("vhspause_1", "CHATOPEN").Split((char)-118, StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = false;
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 1298f, 340f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("nick", 1684f, 1290f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 642f).y > y * (float)PCOGMMIPKEL + 113f)
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 863f < num2)
				{
					goto Block_14;
				}
				num -= 1334f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x06005370 RID: 21360 RVA: 0x0024B0FC File Offset: 0x002492FC
	private float HPFCDPPACGG()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 0f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 0f;
	}

	// Token: 0x06005371 RID: 21361 RVA: 0x0024B1CC File Offset: 0x002493CC
	private void IFNGMGGKMNM()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 1; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[1];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[2]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[1]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[6]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(1140f, 107f);
					this.artRect.anchorMax = new Vector2(1826f, 501f);
					this.artRect.pivot = new Vector2(538f, 859f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005372 RID: 21362 RVA: 0x0024B3C8 File Offset: 0x002495C8
	public void LOPGLAPCJGL(int PHHBFOKNMMK, string HJEJJGAFHAM, string MCHOOEHCANP, int CMBCNMLGPPC, Sprite HNDJMKFCMEK, Sprite KPJIOAFDNIA)
	{
		try
		{
			this.PHEJGCKDPEA = PHHBFOKNMMK;
			this.PMNFGJKFMIM = CMBCNMLGPPC;
			if (null != this.icon)
			{
				if (null != HNDJMKFCMEK)
				{
					this.icon.sprite = HNDJMKFCMEK;
					this.icon.enabled = true;
				}
				else
				{
					this.icon.enabled = false;
				}
			}
			this.EGOKCEHDFAK();
			this.NPCNNCLMGPP(HJEJJGAFHAM, MCHOOEHCANP);
			this.NDEBIOMBDEC(KPJIOAFDNIA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005373 RID: 21363 RVA: 0x0024B454 File Offset: 0x00249654
	public void SetCoverTexts(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Overflow;
				if (this.PMNFGJKFMIM >= 0)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(true);
				}
				else
				{
					this.countText.text = "";
					this.countText.gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (0f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = "";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length > 0 && !text.Trim().Contains(" ") && !text.Trim().Contains("-");
				this.nameText.overflowMode = TextOverflowModes.Overflow;
				this.nameText.enableAutoSizing = false;
				this.nameText.enableWordWrapping = !flag;
				this.nameText.fontSize = this.LCJELODIOJG(this.nameText, text, this.PLLCLNNGGMI, 0.6f, 3, this.HPFCDPPACGG());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Overflow;
				if (0f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = "";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = false;
				this.tagText.enableWordWrapping = true;
				this.tagText.fontSize = this.LCJELODIOJG(this.tagText, text2, this.LENMPMHPPBK, 0.7f, 3, this.HPFCDPPACGG());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
	}

	// Token: 0x06005374 RID: 21364 RVA: 0x0024B678 File Offset: 0x00249878
	private float DJAKNAGNBLP(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 1750f || FNLKKBPAMLG <= 1667f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("trialmode", "lobby").Split((char)-54, StringSplitOptions.None);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = true;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 531f, 417f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("ablec", 1761f, 1567f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 962f).y > y * (float)PCOGMMIPKEL + 681f)
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 750f < num2)
				{
					goto Block_14;
				}
				num -= 1796f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x06005375 RID: 21365 RVA: 0x0024A790 File Offset: 0x00248990
	public int AOCAOJNKFLH()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x06005376 RID: 21366 RVA: 0x0024B7BC File Offset: 0x002499BC
	private void ONEDDOFHMPM()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 1; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[7];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[8]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[1]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[1]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[5]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(46f, 858f);
					this.artRect.anchorMax = new Vector2(1580f, 474f);
					this.artRect.pivot = new Vector2(145f, 1740f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005377 RID: 21367 RVA: 0x0024B9B8 File Offset: 0x00249BB8
	public void ELLNOAIFMNA(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Ellipsis;
				if (this.PMNFGJKFMIM >= 1)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(true);
				}
				else
				{
					this.countText.text = "NarrowScreenScaler(): reverted scale to original";
					this.countText.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (1753f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = "-";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length > 0 && !text.Trim().Contains("'") && text.Trim().Contains("spinsbuttoncustomize");
				this.nameText.overflowMode = TextOverflowModes.Overflow;
				this.nameText.enableAutoSizing = true;
				this.nameText.enableWordWrapping = flag;
				this.nameText.fontSize = this.FGLCNOIBFAE(this.nameText, text, this.PLLCLNNGGMI, 146f, 2, this.CKNOGANAOFP());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Overflow;
				if (1656f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = "ok";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = false;
				this.tagText.enableWordWrapping = true;
				this.tagText.fontSize = this.JKGOHLCKLAL(this.tagText, text2, this.LENMPMHPPBK, 1795f, 6, this.JJOJBAOGNDM());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
	}

	// Token: 0x06005378 RID: 21368 RVA: 0x0024A790 File Offset: 0x00248990
	public int IPMKDFLEJHI()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x06005379 RID: 21369 RVA: 0x0024A790 File Offset: 0x00248990
	public int PDNMHGGEOKN()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x0600537A RID: 21370 RVA: 0x0024BBDC File Offset: 0x00249DDC
	private float LKAPGKIPDJG()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1388f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 1238f;
	}

	// Token: 0x0600537B RID: 21371 RVA: 0x0024BCAC File Offset: 0x00249EAC
	private void JGHDIPMALJE(Sprite KPJIOAFDNIA)
	{
		try
		{
			if (!(null == this.pattern))
			{
				this.pattern.sprite = KPJIOAFDNIA;
				this.pattern.gameObject.SetActive(null != KPJIOAFDNIA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600537C RID: 21372 RVA: 0x0024BD08 File Offset: 0x00249F08
	private float FGLCNOIBFAE(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 1704f || FNLKKBPAMLG <= 468f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("PlaySfx() file not found:", "0.##").Split('\v', StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = true;
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 228f, 1467f).x > DDMMDDFIALL)
					{
						flag = false;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 1 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("Key:", 1137f, 150f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 489f).y > y * (float)PCOGMMIPKEL + 1699f)
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 399f < num2)
				{
					goto Block_14;
				}
				num -= 136f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x0600537D RID: 21373 RVA: 0x0024BE4C File Offset: 0x0024A04C
	public void FOOLACNIKKB(int PHHBFOKNMMK, string HJEJJGAFHAM, string MCHOOEHCANP, int CMBCNMLGPPC, Sprite HNDJMKFCMEK, Sprite KPJIOAFDNIA)
	{
		try
		{
			this.PHEJGCKDPEA = PHHBFOKNMMK;
			this.PMNFGJKFMIM = CMBCNMLGPPC;
			if (null != this.icon)
			{
				if (null != HNDJMKFCMEK)
				{
					this.icon.sprite = HNDJMKFCMEK;
					this.icon.enabled = false;
				}
				else
				{
					this.icon.enabled = true;
				}
			}
			this.LKEINOIJAJB();
			this.MOEAOGENCKK(HJEJJGAFHAM, MCHOOEHCANP);
			this.BFMIPKBEMKF(KPJIOAFDNIA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600537E RID: 21374 RVA: 0x0024BED8 File Offset: 0x0024A0D8
	private float DJKHHAEIJHP()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 376f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 1873f;
	}

	// Token: 0x0600537F RID: 21375 RVA: 0x0024BFA8 File Offset: 0x0024A1A8
	private float JBLCFMMMKKO()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1130f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 1954f;
	}

	// Token: 0x06005380 RID: 21376 RVA: 0x0024C078 File Offset: 0x0024A278
	private void MIBGBCBNHHE()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 1; i < base.transform.parent.childCount; i++)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[3];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[1]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[7]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[7]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(992f, 5f);
					this.artRect.anchorMax = new Vector2(486f, 16f);
					this.artRect.pivot = new Vector2(471f, 1989f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005381 RID: 21377 RVA: 0x0024C274 File Offset: 0x0024A474
	public void GAHPMCBLBMH(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Overflow;
				if (this.PMNFGJKFMIM >= 0)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(false);
				}
				else
				{
					this.countText.text = "";
					this.countText.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (794f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = "SearchBarContent";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length > 0 && !text.Trim().Contains(", ") && text.Trim().Contains(": ");
				this.nameText.overflowMode = TextOverflowModes.Overflow;
				this.nameText.enableAutoSizing = true;
				this.nameText.enableWordWrapping = flag;
				this.nameText.fontSize = this.MGEMKBDEFEC(this.nameText, text, this.PLLCLNNGGMI, 1388f, 3, this.JFNBDOAMEGO());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Overflow;
				if (100f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = " ";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = true;
				this.tagText.enableWordWrapping = true;
				this.tagText.fontSize = this.DLNMDGCJPAO(this.tagText, text2, this.LENMPMHPPBK, 207f, 8, this.CKNOGANAOFP());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
	}

	// Token: 0x06005382 RID: 21378 RVA: 0x0024C498 File Offset: 0x0024A698
	public void ENOABFFIFAI(int PHHBFOKNMMK, string HJEJJGAFHAM, string MCHOOEHCANP, int CMBCNMLGPPC, Sprite HNDJMKFCMEK, Sprite KPJIOAFDNIA)
	{
		try
		{
			this.PHEJGCKDPEA = PHHBFOKNMMK;
			this.PMNFGJKFMIM = CMBCNMLGPPC;
			if (null != this.icon)
			{
				if (null != HNDJMKFCMEK)
				{
					this.icon.sprite = HNDJMKFCMEK;
					this.icon.enabled = true;
				}
				else
				{
					this.icon.enabled = true;
				}
			}
			this.FJDMJCENJON();
			this.DJOIMKJNNNO(HJEJJGAFHAM, MCHOOEHCANP);
			this.KJGHCKMHIGJ(KPJIOAFDNIA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005383 RID: 21379 RVA: 0x0024C524 File Offset: 0x0024A724
	private float FLFNLCNIBOH()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 331f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 1143f;
	}

	// Token: 0x06005384 RID: 21380 RVA: 0x0024C5F4 File Offset: 0x0024A7F4
	private void HGJBDOFGBJI()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 1; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[2];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[1]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[6]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[1]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[3]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(1790f, 1473f);
					this.artRect.anchorMax = new Vector2(1740f, 323f);
					this.artRect.pivot = new Vector2(806f, 1494f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005385 RID: 21381 RVA: 0x0024A790 File Offset: 0x00248990
	public int DIJHDNHKGKM()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x06005386 RID: 21382 RVA: 0x0024C7F0 File Offset: 0x0024A9F0
	public void GBCBELKCLDE(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Ellipsis;
				if (this.PMNFGJKFMIM >= 0)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(false);
				}
				else
				{
					this.countText.text = "congratstitle";
					this.countText.gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (1032f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = "OnLiveProfileThemesLoaderStart";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length > 1 && !text.Trim().Contains(" ") && !text.Trim().Contains("avatar");
				this.nameText.overflowMode = TextOverflowModes.Ellipsis;
				this.nameText.enableAutoSizing = true;
				this.nameText.enableWordWrapping = !flag;
				this.nameText.fontSize = this.OFJLGLABDIF(this.nameText, text, this.PLLCLNNGGMI, 421f, 1, this.DJKHHAEIJHP());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Ellipsis;
				if (1408f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = "OnLobbyProfileDataCdnSuccess";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = false;
				this.tagText.enableWordWrapping = true;
				this.tagText.fontSize = this.IBKHGDDMKHO(this.tagText, text2, this.LENMPMHPPBK, 1584f, 5, this.LKAPGKIPDJG());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
	}

	// Token: 0x06005387 RID: 21383 RVA: 0x0024CA14 File Offset: 0x0024AC14
	private float MBDICEAKGEP()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1971f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return 1244f;
	}

	// Token: 0x06005388 RID: 21384 RVA: 0x0024CAE4 File Offset: 0x0024ACE4
	private float IBALHHNHIEP(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 1413f || FNLKKBPAMLG <= 1549f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("achiev", "<RSAKeyValue><Exponent>AQAB</Exponent><Modulus>").Split('\u0003', StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = false;
				for (int i = 0; i < array.Length; i += 0)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 1487f, 1109f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("importanttitle", 1916f, 1177f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 1741f).y > y * (float)PCOGMMIPKEL + 1027f)
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 136f < num2)
				{
					goto Block_14;
				}
				num -= 1942f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x06005389 RID: 21385 RVA: 0x0024CC28 File Offset: 0x0024AE28
	private float GCOPLOCFKAH()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1197f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 1847f;
	}

	// Token: 0x0600538A RID: 21386 RVA: 0x0024A790 File Offset: 0x00248990
	public int ECBLNFHBMFL()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x0600538B RID: 21387 RVA: 0x0024A790 File Offset: 0x00248990
	public int BNEPHFBDANA()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x0600538C RID: 21388 RVA: 0x0024CCF8 File Offset: 0x0024AEF8
	private void BJCANBPAKLH()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[1];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[1]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[2]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[1]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[8]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(1379f, 1727f);
					this.artRect.anchorMax = new Vector2(1829f, 1408f);
					this.artRect.pivot = new Vector2(1919f, 502f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600538E RID: 21390 RVA: 0x0024CF0C File Offset: 0x0024B10C
	private float IBKHGDDMKHO(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 1380f || FNLKKBPAMLG <= 705f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("loop", "").Split((char)-2, StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = true;
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 182f, 1132f).x > DDMMDDFIALL)
					{
						flag = false;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("errortitle", 1909f, 1610f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 1948f).y > y * (float)PCOGMMIPKEL + 1205f)
					{
						flag = false;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 1321f < num2)
				{
					goto Block_14;
				}
				num -= 1894f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x0600538F RID: 21391 RVA: 0x0024D050 File Offset: 0x0024B250
	public void BMJDNBLFOBP(int PHHBFOKNMMK, string HJEJJGAFHAM, string MCHOOEHCANP, int CMBCNMLGPPC, Sprite HNDJMKFCMEK, Sprite KPJIOAFDNIA)
	{
		try
		{
			this.PHEJGCKDPEA = PHHBFOKNMMK;
			this.PMNFGJKFMIM = CMBCNMLGPPC;
			if (null != this.icon)
			{
				if (null != HNDJMKFCMEK)
				{
					this.icon.sprite = HNDJMKFCMEK;
					this.icon.enabled = true;
				}
				else
				{
					this.icon.enabled = false;
				}
			}
			this.LKEINOIJAJB();
			this.GBCBELKCLDE(HJEJJGAFHAM, MCHOOEHCANP);
			this.NDEBIOMBDEC(KPJIOAFDNIA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005390 RID: 21392 RVA: 0x0024D0DC File Offset: 0x0024B2DC
	private float CDMEFLFCKLC()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1996f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return 683f;
	}

	// Token: 0x06005391 RID: 21393 RVA: 0x0024D1AC File Offset: 0x0024B3AC
	private float MCBGIIOPNFC(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 1372f || FNLKKBPAMLG <= 629f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("ProfileItem2.GetCardUpgradeLocalizedCostData() - productData is null.", "htme").Split((char)-1, StringSplitOptions.None);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = true;
				for (int i = 0; i < array.Length; i += 0)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 318f, 548f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 1 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("", 1972f, 493f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 11f).y > y * (float)PCOGMMIPKEL + 1065f)
					{
						flag = false;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 1503f < num2)
				{
					goto Block_14;
				}
				num -= 1345f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x06005392 RID: 21394 RVA: 0x0024D2F0 File Offset: 0x0024B4F0
	private void NOIILLJPJMA()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[6];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[2]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[7]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(471f, 1038f);
					this.artRect.anchorMax = new Vector2(0f, 350f);
					this.artRect.pivot = new Vector2(577f, 1579f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005393 RID: 21395 RVA: 0x0024D4EC File Offset: 0x0024B6EC
	private float JFNBDOAMEGO()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1306f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return 271f;
	}

	// Token: 0x06005394 RID: 21396 RVA: 0x0024D5BC File Offset: 0x0024B7BC
	private void FGGMBIKBCHE()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[8];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[1]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[5]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[1]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[6]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(887f, 1077f);
					this.artRect.anchorMax = new Vector2(221f, 755f);
					this.artRect.pivot = new Vector2(1291f, 1738f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005395 RID: 21397 RVA: 0x0024D7B8 File Offset: 0x0024B9B8
	private void IPOAKMEBKHA()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[8];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[1]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[7]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[3]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(60f, 1732f);
					this.artRect.anchorMax = new Vector2(1707f, 476f);
					this.artRect.pivot = new Vector2(1715f, 279f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005396 RID: 21398 RVA: 0x0024D9B4 File Offset: 0x0024BBB4
	private void GFIABPDCPKB()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i++)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[1];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[1]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[4]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[5]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(1330f, 1829f);
					this.artRect.anchorMax = new Vector2(771f, 1663f);
					this.artRect.pivot = new Vector2(1213f, 1303f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005397 RID: 21399 RVA: 0x0024DBB0 File Offset: 0x0024BDB0
	private void JHHNBNHNGND()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i++)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[4];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[2]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[2]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(0f, 1f);
					this.artRect.anchorMax = new Vector2(0f, 1f);
					this.artRect.pivot = new Vector2(0f, 1f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06005398 RID: 21400 RVA: 0x0024DDAC File Offset: 0x0024BFAC
	private void DAHABHKMDLH()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[5];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[2]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[2]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(249f, 1175f);
					this.artRect.anchorMax = new Vector2(1535f, 692f);
					this.artRect.pivot = new Vector2(312f, 1f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06005399 RID: 21401 RVA: 0x0024DFA8 File Offset: 0x0024C1A8
	private void EOMPBDBDDLG(Sprite KPJIOAFDNIA)
	{
		try
		{
			if (!(null == this.pattern))
			{
				this.pattern.sprite = KPJIOAFDNIA;
				this.pattern.gameObject.SetActive(null != KPJIOAFDNIA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600539A RID: 21402 RVA: 0x0024E004 File Offset: 0x0024C204
	private void GMAAAEMIMHK()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[5];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[1]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[4]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[1]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[1]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(1860f, 1244f);
					this.artRect.anchorMax = new Vector2(907f, 58f);
					this.artRect.pivot = new Vector2(7f, 1322f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600539B RID: 21403 RVA: 0x0024E200 File Offset: 0x0024C400
	public void HLMJLPGIDKL(int PHHBFOKNMMK, string HJEJJGAFHAM, string MCHOOEHCANP, int CMBCNMLGPPC, Sprite HNDJMKFCMEK, Sprite KPJIOAFDNIA)
	{
		try
		{
			this.PHEJGCKDPEA = PHHBFOKNMMK;
			this.PMNFGJKFMIM = CMBCNMLGPPC;
			if (null != this.icon)
			{
				if (null != HNDJMKFCMEK)
				{
					this.icon.sprite = HNDJMKFCMEK;
					this.icon.enabled = true;
				}
				else
				{
					this.icon.enabled = false;
				}
			}
			this.LKEINOIJAJB();
			this.DNICNNLGEIP(HJEJJGAFHAM, MCHOOEHCANP);
			this.EIDOBOCHPJD(KPJIOAFDNIA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600539C RID: 21404 RVA: 0x0024E28C File Offset: 0x0024C48C
	private float HAMEJKKAFMJ()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 724f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 401f;
	}

	// Token: 0x0600539D RID: 21405 RVA: 0x0024A790 File Offset: 0x00248990
	public int GetGroupIndex()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x0600539E RID: 21406 RVA: 0x0024E35C File Offset: 0x0024C55C
	public void LAMMPMMKKEH(int PHHBFOKNMMK, string HJEJJGAFHAM, string MCHOOEHCANP, int CMBCNMLGPPC, Sprite HNDJMKFCMEK, Sprite KPJIOAFDNIA)
	{
		try
		{
			this.PHEJGCKDPEA = PHHBFOKNMMK;
			this.PMNFGJKFMIM = CMBCNMLGPPC;
			if (null != this.icon)
			{
				if (null != HNDJMKFCMEK)
				{
					this.icon.sprite = HNDJMKFCMEK;
					this.icon.enabled = false;
				}
				else
				{
					this.icon.enabled = true;
				}
			}
			this.BHOFINNCAOO();
			this.JNDEHDHMLHF(HJEJJGAFHAM, MCHOOEHCANP);
			this.EOMPBDBDDLG(KPJIOAFDNIA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x0600539F RID: 21407 RVA: 0x0024E3E8 File Offset: 0x0024C5E8
	private void EEAAHHGHCBF()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 1; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[2];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[2]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[1]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[1]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[2]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(1071f, 1778f);
					this.artRect.anchorMax = new Vector2(1435f, 1652f);
					this.artRect.pivot = new Vector2(1763f, 1315f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053A0 RID: 21408 RVA: 0x0024E5E4 File Offset: 0x0024C7E4
	public void AAOMAOOJBPN(int PHHBFOKNMMK, string HJEJJGAFHAM, string MCHOOEHCANP, int CMBCNMLGPPC, Sprite HNDJMKFCMEK, Sprite KPJIOAFDNIA)
	{
		try
		{
			this.PHEJGCKDPEA = PHHBFOKNMMK;
			this.PMNFGJKFMIM = CMBCNMLGPPC;
			if (null != this.icon)
			{
				if (null != HNDJMKFCMEK)
				{
					this.icon.sprite = HNDJMKFCMEK;
					this.icon.enabled = true;
				}
				else
				{
					this.icon.enabled = true;
				}
			}
			this.LKEINOIJAJB();
			this.HEMDCPOCKFJ(HJEJJGAFHAM, MCHOOEHCANP);
			this.ELDDOCEJJEM(KPJIOAFDNIA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053A1 RID: 21409 RVA: 0x0024E670 File Offset: 0x0024C870
	private void LKEINOIJAJB()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[3];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[1]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[1]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[1]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[4]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(227f, 1286f);
					this.artRect.anchorMax = new Vector2(236f, 876f);
					this.artRect.pivot = new Vector2(1764f, 1808f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060053A2 RID: 21410 RVA: 0x0024E86C File Offset: 0x0024CA6C
	private float DDECCLJIEBA(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 1081f || FNLKKBPAMLG <= 850f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("", " <i>").Split((char)-73, StringSplitOptions.None);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = false;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 1724f, 611f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 1 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("</i>", 708f, 1585f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 115f).y > y * (float)PCOGMMIPKEL + 881f)
					{
						flag = false;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 1048f < num2)
				{
					goto Block_14;
				}
				num -= 306f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053A3 RID: 21411 RVA: 0x0024E9B0 File Offset: 0x0024CBB0
	public void SetCover(int PHHBFOKNMMK, string HJEJJGAFHAM, string MCHOOEHCANP, int CMBCNMLGPPC, Sprite HNDJMKFCMEK, Sprite KPJIOAFDNIA)
	{
		try
		{
			this.PHEJGCKDPEA = PHHBFOKNMMK;
			this.PMNFGJKFMIM = CMBCNMLGPPC;
			if (null != this.icon)
			{
				if (null != HNDJMKFCMEK)
				{
					this.icon.sprite = HNDJMKFCMEK;
					this.icon.enabled = true;
				}
				else
				{
					this.icon.enabled = false;
				}
			}
			this.JHHNBNHNGND();
			this.SetCoverTexts(HJEJJGAFHAM, MCHOOEHCANP);
			this.EOMPBDBDDLG(KPJIOAFDNIA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053A4 RID: 21412 RVA: 0x0024EA3C File Offset: 0x0024CC3C
	private float MMPOPEKCMKG()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1817f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 1301f;
	}

	// Token: 0x060053A5 RID: 21413 RVA: 0x0024EB0C File Offset: 0x0024CD0C
	private float HAENNPKLACE(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 1788f || FNLKKBPAMLG <= 807f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("hoursshort", "OnAccountSignInRequestException").Split((char)-86, StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = false;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 1299f, 1824f).x > DDMMDDFIALL)
					{
						flag = false;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 1 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("ok", 922f, 947f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 40f).y > y * (float)PCOGMMIPKEL + 1777f)
					{
						flag = false;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 1466f < num2)
				{
					goto Block_14;
				}
				num -= 1051f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053A6 RID: 21414 RVA: 0x0024EC50 File Offset: 0x0024CE50
	private void DFOAFHAJNOF()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 1; i < base.transform.parent.childCount; i++)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[2];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[3]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[1]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[0]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(1546f, 1365f);
					this.artRect.anchorMax = new Vector2(924f, 1636f);
					this.artRect.pivot = new Vector2(524f, 670f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053A7 RID: 21415 RVA: 0x0024EE4C File Offset: 0x0024D04C
	public void DNICNNLGEIP(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Overflow;
				if (this.PMNFGJKFMIM >= 1)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(true);
				}
				else
				{
					this.countText.text = "%";
					this.countText.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (798f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = "collect";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length > 1 && !text.Trim().Contains(".") && !text.Trim().Contains("ZZZ");
				this.nameText.overflowMode = TextOverflowModes.Ellipsis;
				this.nameText.enableAutoSizing = false;
				this.nameText.enableWordWrapping = !flag;
				this.nameText.fontSize = this.MHAPLHDMHJC(this.nameText, text, this.PLLCLNNGGMI, 1375f, 5, this.CKNOGANAOFP());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Overflow;
				if (1033f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = "OnSceneLobbyManagerRound0AssetsDownloadSuccess";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = true;
				this.tagText.enableWordWrapping = true;
				this.tagText.fontSize = this.DDKNCOPDNFN(this.tagText, text2, this.LENMPMHPPBK, 1538f, 4, this.FLFNLCNIBOH());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
	}

	// Token: 0x060053A8 RID: 21416 RVA: 0x0024F070 File Offset: 0x0024D270
	private void FJDMJCENJON()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 1; i < base.transform.parent.childCount; i++)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[7];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[3]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[1]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[6]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(1814f, 476f);
					this.artRect.anchorMax = new Vector2(1702f, 669f);
					this.artRect.pivot = new Vector2(1388f, 1785f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060053A9 RID: 21417 RVA: 0x0024A790 File Offset: 0x00248990
	public int GNBACEJEKPF()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x060053AA RID: 21418 RVA: 0x0024F26C File Offset: 0x0024D46C
	private float CKEINDNNBBL(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 673f || FNLKKBPAMLG <= 291f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("+", "OnLobbyWheelDataDataCdnFailed").Split((char)-55, StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = true;
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 201f, 1671f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("congratstitle", 1510f, 601f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 1784f).y > y * (float)PCOGMMIPKEL + 927f)
					{
						flag = false;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 803f < num2)
				{
					goto Block_14;
				}
				num -= 1321f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053AB RID: 21419 RVA: 0x0024F3B0 File Offset: 0x0024D5B0
	public void PFKMMOMFIOB(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Overflow;
				if (this.PMNFGJKFMIM >= 1)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(false);
				}
				else
				{
					this.countText.text = "stat2long";
					this.countText.gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (1153f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = ")";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length > 0 && !text.Trim().Contains(",Confirmation Failure Details: ") && !text.Trim().Contains("retry");
				this.nameText.overflowMode = TextOverflowModes.Ellipsis;
				this.nameText.enableAutoSizing = true;
				this.nameText.enableWordWrapping = flag;
				this.nameText.fontSize = this.IBKHGDDMKHO(this.nameText, text, this.PLLCLNNGGMI, 1565f, 4, this.JBLCFMMMKKO());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Ellipsis;
				if (1324f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = "lck";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = false;
				this.tagText.enableWordWrapping = false;
				this.tagText.fontSize = this.BIGBNOILJME(this.tagText, text2, this.LENMPMHPPBK, 403f, 2, this.OLAEHOMLJPH());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
	}

	// Token: 0x060053AC RID: 21420 RVA: 0x0024A790 File Offset: 0x00248990
	public int DEMAOPPILHG()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x060053AD RID: 21421 RVA: 0x0024F5D4 File Offset: 0x0024D7D4
	private void AEDLBNPCLFD(Sprite KPJIOAFDNIA)
	{
		try
		{
			if (!(null == this.pattern))
			{
				this.pattern.sprite = KPJIOAFDNIA;
				this.pattern.gameObject.SetActive(null != KPJIOAFDNIA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053AE RID: 21422 RVA: 0x0024F630 File Offset: 0x0024D830
	private float EFFCBKNLJBB()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1068f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 822f;
	}

	// Token: 0x060053AF RID: 21423 RVA: 0x0024F700 File Offset: 0x0024D900
	private void JANLIJPELDM()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 1; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[2];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[7]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[1]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[1]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[7]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(525f, 1090f);
					this.artRect.anchorMax = new Vector2(1376f, 869f);
					this.artRect.pivot = new Vector2(1720f, 433f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053B0 RID: 21424 RVA: 0x0024F8FC File Offset: 0x0024DAFC
	public void DJOIMKJNNNO(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Overflow;
				if (this.PMNFGJKFMIM >= 1)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(true);
				}
				else
				{
					this.countText.text = "";
					this.countText.gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (1395f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = "$CHAPTSTART";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length > 0 && !text.Trim().Contains(" DIRECT CACHE FILES path SUCCEEDED: chain loaded from the recorded cache files") && !text.Trim().Contains("mypzerocutscenes");
				this.nameText.overflowMode = TextOverflowModes.Overflow;
				this.nameText.enableAutoSizing = false;
				this.nameText.enableWordWrapping = flag;
				this.nameText.fontSize = this.MGEMKBDEFEC(this.nameText, text, this.PLLCLNNGGMI, 274f, 3, this.FLFNLCNIBOH());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Ellipsis;
				if (1975f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = " cut ";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = true;
				this.tagText.enableWordWrapping = true;
				this.tagText.fontSize = this.MCBGIIOPNFC(this.tagText, text2, this.LENMPMHPPBK, 623f, 3, this.MELEKKADMNO());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
	}

	// Token: 0x060053B1 RID: 21425 RVA: 0x0024FB20 File Offset: 0x0024DD20
	private void JOJBHOMFEHH(Sprite KPJIOAFDNIA)
	{
		try
		{
			if (!(null == this.pattern))
			{
				this.pattern.sprite = KPJIOAFDNIA;
				this.pattern.gameObject.SetActive(null != KPJIOAFDNIA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060053B2 RID: 21426 RVA: 0x0024FB7C File Offset: 0x0024DD7C
	private float LCJELODIOJG(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 0f || FNLKKBPAMLG <= 0f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("-", "- ").Split(' ', StringSplitOptions.None);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = true;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 100000f, 100000f).x > DDMMDDFIALL)
					{
						flag = false;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("Xg", 100000f, 100000f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 100000f).y > y * (float)PCOGMMIPKEL + 1f)
					{
						flag = false;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 1f < num2)
				{
					goto Block_14;
				}
				num -= 1f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053B3 RID: 21427 RVA: 0x0024FCC0 File Offset: 0x0024DEC0
	public void FPFDKOOJCNM(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Overflow;
				if (this.PMNFGJKFMIM >= 0)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(true);
				}
				else
				{
					this.countText.text = "?uid=";
					this.countText.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (1028f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = "XXX";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length > 1 && !text.Trim().Contains("suid") && text.Trim().Contains("<");
				this.nameText.overflowMode = TextOverflowModes.Ellipsis;
				this.nameText.enableAutoSizing = true;
				this.nameText.enableWordWrapping = !flag;
				this.nameText.fontSize = this.LCJELODIOJG(this.nameText, text, this.PLLCLNNGGMI, 259f, 2, this.MBDICEAKGEP());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Ellipsis;
				if (1863f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = "suid";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = false;
				this.tagText.enableWordWrapping = false;
				this.tagText.fontSize = this.IBALHHNHIEP(this.tagText, text2, this.LENMPMHPPBK, 1465f, 0, this.OIFAMDHKAMB());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
	}

	// Token: 0x060053B4 RID: 21428 RVA: 0x0024FEE4 File Offset: 0x0024E0E4
	public void KOHFANGHNJB(int PHHBFOKNMMK, string HJEJJGAFHAM, string MCHOOEHCANP, int CMBCNMLGPPC, Sprite HNDJMKFCMEK, Sprite KPJIOAFDNIA)
	{
		try
		{
			this.PHEJGCKDPEA = PHHBFOKNMMK;
			this.PMNFGJKFMIM = CMBCNMLGPPC;
			if (null != this.icon)
			{
				if (null != HNDJMKFCMEK)
				{
					this.icon.sprite = HNDJMKFCMEK;
					this.icon.enabled = true;
				}
				else
				{
					this.icon.enabled = true;
				}
			}
			this.DFOAFHAJNOF();
			this.FPFDKOOJCNM(HJEJJGAFHAM, MCHOOEHCANP);
			this.AEDLBNPCLFD(KPJIOAFDNIA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053B5 RID: 21429 RVA: 0x0024FF70 File Offset: 0x0024E170
	private float JNOGKHEJODO()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1923f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 313f;
	}

	// Token: 0x060053B6 RID: 21430 RVA: 0x00250040 File Offset: 0x0024E240
	private float JJOJBAOGNDM()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1067f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 1984f;
	}

	// Token: 0x060053B7 RID: 21431 RVA: 0x00250110 File Offset: 0x0024E310
	public void MOEAOGENCKK(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Ellipsis;
				if (this.PMNFGJKFMIM >= 0)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(true);
				}
				else
				{
					this.countText.text = " from the recorded cache files";
					this.countText.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (628f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = "ablpt";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length <= 1 || text.Trim().Contains("_Speed") || text.Trim().Contains("lightmodebtn1");
				this.nameText.overflowMode = TextOverflowModes.Overflow;
				this.nameText.enableAutoSizing = true;
				this.nameText.enableWordWrapping = flag;
				this.nameText.fontSize = this.FGLCNOIBFAE(this.nameText, text, this.PLLCLNNGGMI, 817f, 5, this.OIFAMDHKAMB());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Ellipsis;
				if (1230f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = "Critical error, could not load asset bundle:";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = false;
				this.tagText.enableWordWrapping = false;
				this.tagText.fontSize = this.LCJELODIOJG(this.tagText, text2, this.LENMPMHPPBK, 1026f, 7, this.JNOGKHEJODO());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
	}

	// Token: 0x060053B8 RID: 21432 RVA: 0x00250334 File Offset: 0x0024E534
	private float AONIBEEDNLJ(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 1900f || FNLKKBPAMLG <= 156f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("cardsvolchancesmsgbody", "eps").Split((char)-26, StringSplitOptions.None);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = false;
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 1580f, 577f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("lowendversion", 19f, 1384f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 1228f).y > y * (float)PCOGMMIPKEL + 903f)
					{
						flag = false;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 1073f < num2)
				{
					goto Block_14;
				}
				num -= 1235f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053B9 RID: 21433 RVA: 0x00250478 File Offset: 0x0024E678
	private float PNHHMOBPGGK(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 543f || FNLKKBPAMLG <= 1013f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("gpoptionsclickchar", "p").Split((char)-44, StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = true;
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 143f, 1510f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("p", 364f, 538f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 1422f).y > y * (float)PCOGMMIPKEL + 388f)
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 201f < num2)
				{
					goto Block_14;
				}
				num -= 1885f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053BA RID: 21434 RVA: 0x002505BC File Offset: 0x0024E7BC
	private void BFMIPKBEMKF(Sprite KPJIOAFDNIA)
	{
		try
		{
			if (!(null == this.pattern))
			{
				this.pattern.sprite = KPJIOAFDNIA;
				this.pattern.gameObject.SetActive(null != KPJIOAFDNIA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053BB RID: 21435 RVA: 0x00250618 File Offset: 0x0024E818
	private void PCIKMODOGBL()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 1; i < base.transform.parent.childCount; i++)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[3];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[1]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[6]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[0]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(1577f, 1395f);
					this.artRect.anchorMax = new Vector2(940f, 1537f);
					this.artRect.pivot = new Vector2(1024f, 689f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053BC RID: 21436 RVA: 0x00250814 File Offset: 0x0024EA14
	private void EGOKCEHDFAK()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 1; i < base.transform.parent.childCount; i++)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[4];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[1]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[7]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[1]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[8]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(1445f, 1544f);
					this.artRect.anchorMax = new Vector2(802f, 1964f);
					this.artRect.pivot = new Vector2(1002f, 352f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053BD RID: 21437 RVA: 0x0024A790 File Offset: 0x00248990
	public int HDPOCCJALJB()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x060053BE RID: 21438 RVA: 0x00250A10 File Offset: 0x0024EC10
	private float MELEKKADMNO()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1164f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return 1112f;
	}

	// Token: 0x060053BF RID: 21439 RVA: 0x00250AE0 File Offset: 0x0024ECE0
	public void HEMDCPOCKFJ(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Overflow;
				if (this.PMNFGJKFMIM >= 0)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(false);
				}
				else
				{
					this.countText.text = "post";
					this.countText.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (1863f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = "</i>";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length <= 1 || text.Trim().Contains("veff") || !text.Trim().Contains("keychain-{0}.dat");
				this.nameText.overflowMode = TextOverflowModes.Ellipsis;
				this.nameText.enableAutoSizing = false;
				this.nameText.enableWordWrapping = flag;
				this.nameText.fontSize = this.MGEMKBDEFEC(this.nameText, text, this.PLLCLNNGGMI, 1406f, 2, this.FLFNLCNIBOH());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Overflow;
				if (773f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = " already being downloaded, skip request but remember reference to it.";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = false;
				this.tagText.enableWordWrapping = true;
				this.tagText.fontSize = this.MGEMKBDEFEC(this.tagText, text2, this.LENMPMHPPBK, 705f, 3, this.JFNBDOAMEGO());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
	}

	// Token: 0x060053C0 RID: 21440 RVA: 0x00250D04 File Offset: 0x0024EF04
	private void EIDOBOCHPJD(Sprite KPJIOAFDNIA)
	{
		try
		{
			if (!(null == this.pattern))
			{
				this.pattern.sprite = KPJIOAFDNIA;
				this.pattern.gameObject.SetActive(null != KPJIOAFDNIA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060053C1 RID: 21441 RVA: 0x00250D60 File Offset: 0x0024EF60
	public void EGPGPEHDNAI(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Overflow;
				if (this.PMNFGJKFMIM >= 0)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(false);
				}
				else
				{
					this.countText.text = "cut";
					this.countText.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (1440f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = "title";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length <= 1 || text.Trim().Contains("freepasssuccess") || !text.Trim().Contains("socialbadgelocked");
				this.nameText.overflowMode = TextOverflowModes.Overflow;
				this.nameText.enableAutoSizing = false;
				this.nameText.enableWordWrapping = !flag;
				this.nameText.fontSize = this.KPOJKBFJHML(this.nameText, text, this.PLLCLNNGGMI, 294f, 1, this.LKAPGKIPDJG());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Overflow;
				if (591f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = "retry";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = true;
				this.tagText.enableWordWrapping = true;
				this.tagText.fontSize = this.DJAKNAGNBLP(this.tagText, text2, this.LENMPMHPPBK, 1973f, 0, this.CDMEFLFCKLC());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
	}

	// Token: 0x060053C2 RID: 21442 RVA: 0x00250F84 File Offset: 0x0024F184
	private float DDKNCOPDNFN(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 190f || FNLKKBPAMLG <= 1494f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("cardoptionsloadingthemefree", "").Split((char)-106, StringSplitOptions.None);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = true;
				for (int i = 0; i < array.Length; i += 0)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 129f, 800f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("", 1850f, 839f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 1969f).y > y * (float)PCOGMMIPKEL + 1753f)
					{
						flag = false;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 1863f < num2)
				{
					goto Block_14;
				}
				num -= 848f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053C3 RID: 21443 RVA: 0x002510C8 File Offset: 0x0024F2C8
	private void ELDDOCEJJEM(Sprite KPJIOAFDNIA)
	{
		try
		{
			if (!(null == this.pattern))
			{
				this.pattern.sprite = KPJIOAFDNIA;
				this.pattern.gameObject.SetActive(null != KPJIOAFDNIA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053C4 RID: 21444 RVA: 0x00251124 File Offset: 0x0024F324
	private void HFLLOPJIJIK()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i++)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[0];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[0]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[1]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[8]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(1775f, 1883f);
					this.artRect.anchorMax = new Vector2(1061f, 1182f);
					this.artRect.pivot = new Vector2(1222f, 57f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060053C5 RID: 21445 RVA: 0x00251320 File Offset: 0x0024F520
	private float JNJAEDBPCJM(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 741f || FNLKKBPAMLG <= 261f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("CLIENT.AVATAR.FACE", "OnGenericPopupManagerHide").Split((char)-55, StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = true;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 990f, 1856f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("def", 425f, 605f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 1383f).y > y * (float)PCOGMMIPKEL + 795f)
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 848f < num2)
				{
					goto Block_14;
				}
				num -= 1689f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053C6 RID: 21446 RVA: 0x00251464 File Offset: 0x0024F664
	private void IJMAPECDKGK()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 0; i < base.transform.parent.childCount; i += 0)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[8];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[0]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[1]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[0]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[7]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(731f, 1071f);
					this.artRect.anchorMax = new Vector2(1511f, 943f);
					this.artRect.pivot = new Vector2(806f, 1601f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053C7 RID: 21447 RVA: 0x00251660 File Offset: 0x0024F860
	public void JNDEHDHMLHF(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Ellipsis;
				if (this.PMNFGJKFMIM >= 1)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(false);
				}
				else
				{
					this.countText.text = "OnResolutionChanged";
					this.countText.gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (669f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = "OnSketchViewLeft";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length <= 0 || text.Trim().Contains("OnBackendRequestFriendAcceptException") || !text.Trim().Contains("OnBackendGetSketchesBalanceSuccess");
				this.nameText.overflowMode = TextOverflowModes.Overflow;
				this.nameText.enableAutoSizing = true;
				this.nameText.enableWordWrapping = flag;
				this.nameText.fontSize = this.BIGBNOILJME(this.nameText, text, this.PLLCLNNGGMI, 320f, 8, this.HPFCDPPACGG());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Overflow;
				if (712f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = "gnr";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = false;
				this.tagText.enableWordWrapping = false;
				this.tagText.fontSize = this.AAPAKHBCEPF(this.tagText, text2, this.LENMPMHPPBK, 475f, 8, this.KJBLKAPLFOK());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
	}

	// Token: 0x060053C8 RID: 21448 RVA: 0x00251884 File Offset: 0x0024FA84
	private float CKNOGANAOFP()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1067f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 775f;
	}

	// Token: 0x060053C9 RID: 21449 RVA: 0x00251954 File Offset: 0x0024FB54
	private float OLAEHOMLJPH()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 52f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return 1427f;
	}

	// Token: 0x060053CA RID: 21450 RVA: 0x00251A24 File Offset: 0x0024FC24
	private float JKGOHLCKLAL(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 1192f || FNLKKBPAMLG <= 641f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("", "p").Split('3', StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = false;
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 1029f, 1573f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("OnStoryCurrencyInfoClick", 1951f, 6f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 1041f).y > y * (float)PCOGMMIPKEL + 1601f)
					{
						flag = false;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 1551f < num2)
				{
					goto Block_14;
				}
				num -= 530f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053CB RID: 21451 RVA: 0x00251B68 File Offset: 0x0024FD68
	private float AAPAKHBCEPF(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 1963f || FNLKKBPAMLG <= 978f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace(" cached requests.", "OnPopupStoryRestartManagerRestartStory0").Split((char)-61, StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = false;
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 1857f, 1446f).x > DDMMDDFIALL)
					{
						flag = false;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("socialbadgelocked", 1048f, 557f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 1446f).y > y * (float)PCOGMMIPKEL + 33f)
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 748f < num2)
				{
					goto Block_14;
				}
				num -= 1227f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053CC RID: 21452 RVA: 0x00251CAC File Offset: 0x0024FEAC
	public void DCEPLDDGHGP(int PHHBFOKNMMK, string HJEJJGAFHAM, string MCHOOEHCANP, int CMBCNMLGPPC, Sprite HNDJMKFCMEK, Sprite KPJIOAFDNIA)
	{
		try
		{
			this.PHEJGCKDPEA = PHHBFOKNMMK;
			this.PMNFGJKFMIM = CMBCNMLGPPC;
			if (null != this.icon)
			{
				if (null != HNDJMKFCMEK)
				{
					this.icon.sprite = HNDJMKFCMEK;
					this.icon.enabled = true;
				}
				else
				{
					this.icon.enabled = true;
				}
			}
			this.FGGMBIKBCHE();
			this.GBCBELKCLDE(HJEJJGAFHAM, MCHOOEHCANP);
			this.ELDDOCEJJEM(KPJIOAFDNIA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053CD RID: 21453 RVA: 0x00251D38 File Offset: 0x0024FF38
	private float KJBLKAPLFOK()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 871f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 19f;
	}

	// Token: 0x060053CE RID: 21454 RVA: 0x00251E08 File Offset: 0x00250008
	private float OFJLGLABDIF(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 849f || FNLKKBPAMLG <= 1428f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("?uid=", "ext").Split('0', StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = true;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 1358f, 835f).x > DDMMDDFIALL)
					{
						flag = false;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues(" not found.", 603f, 1560f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 1330f).y > y * (float)PCOGMMIPKEL + 1987f)
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 1728f < num2)
				{
					goto Block_14;
				}
				num -= 1990f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053CF RID: 21455 RVA: 0x00251F4C File Offset: 0x0025014C
	private float KPOJKBFJHML(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 1359f || FNLKKBPAMLG <= 26f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("cindbns", "acomp2").Split((char)-19, StringSplitOptions.None);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = false;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 396f, 1416f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 1 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("OnDialogReadInputEndEdit", 1455f, 11f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 602f).y > y * (float)PCOGMMIPKEL + 203f)
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 233f < num2)
				{
					goto Block_14;
				}
				num -= 1995f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053D0 RID: 21456 RVA: 0x00252090 File Offset: 0x00250290
	private void ACCEOPAJLCN()
	{
		try
		{
			if (!(null == this.artRect) && !(null == base.transform.parent))
			{
				ThumbnailItem thumbnailItem = null;
				for (int i = 1; i < base.transform.parent.childCount; i++)
				{
					thumbnailItem = base.transform.parent.GetChild(i).GetComponent<ThumbnailItem>();
					if (null != thumbnailItem)
					{
						break;
					}
				}
				if (!(null == thumbnailItem) && !(null == thumbnailItem.thumbnail))
				{
					RectTransform component = base.GetComponent<RectTransform>();
					RectTransform component2 = thumbnailItem.GetComponent<RectTransform>();
					RectTransform rectTransform = base.transform.parent as RectTransform;
					Vector3[] array = new Vector3[3];
					thumbnailItem.thumbnail.rectTransform.GetWorldCorners(array);
					Vector3 vector = rectTransform.InverseTransformPoint(array[1]);
					Vector3 vector2 = rectTransform.InverseTransformPoint(array[0]);
					component2.GetWorldCorners(array);
					Vector3 vector3 = rectTransform.InverseTransformPoint(array[0]);
					component.GetWorldCorners(array);
					rectTransform.InverseTransformPoint(array[1]);
					ref Vector3 ptr = rectTransform.InverseTransformPoint(array[7]);
					float x = vector.x - vector3.x;
					float num = ptr.y - vector2.y;
					float x2 = vector2.x - vector.x;
					float y = vector2.y - vector.y;
					this.artRect.anchorMin = new Vector2(1399f, 324f);
					this.artRect.anchorMax = new Vector2(1862f, 1278f);
					this.artRect.pivot = new Vector2(542f, 762f);
					this.artRect.anchoredPosition = new Vector2(x, -num);
					this.artRect.sizeDelta = new Vector2(x2, y);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060053D1 RID: 21457 RVA: 0x0025228C File Offset: 0x0025048C
	public void CMBHCHGBJKD(int PHHBFOKNMMK, string HJEJJGAFHAM, string MCHOOEHCANP, int CMBCNMLGPPC, Sprite HNDJMKFCMEK, Sprite KPJIOAFDNIA)
	{
		try
		{
			this.PHEJGCKDPEA = PHHBFOKNMMK;
			this.PMNFGJKFMIM = CMBCNMLGPPC;
			if (null != this.icon)
			{
				if (null != HNDJMKFCMEK)
				{
					this.icon.sprite = HNDJMKFCMEK;
					this.icon.enabled = true;
				}
				else
				{
					this.icon.enabled = true;
				}
			}
			this.JHHNBNHNGND();
			this.EGPGPEHDNAI(HJEJJGAFHAM, MCHOOEHCANP);
			this.EOMPBDBDDLG(KPJIOAFDNIA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060053D2 RID: 21458 RVA: 0x0024A790 File Offset: 0x00248990
	public int CGDHICMJABE()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x060053D3 RID: 21459 RVA: 0x00252318 File Offset: 0x00250518
	private float OIFAMDHKAMB()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1717f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return 912f;
	}

	// Token: 0x060053D4 RID: 21460 RVA: 0x002523E8 File Offset: 0x002505E8
	private void ILBNNNJFJPO(Sprite KPJIOAFDNIA)
	{
		try
		{
			if (!(null == this.pattern))
			{
				this.pattern.sprite = KPJIOAFDNIA;
				this.pattern.gameObject.SetActive(null != KPJIOAFDNIA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060053D5 RID: 21461 RVA: 0x00252444 File Offset: 0x00250644
	private void IDLDADNJMHK(Sprite KPJIOAFDNIA)
	{
		try
		{
			if (!(null == this.pattern))
			{
				this.pattern.sprite = KPJIOAFDNIA;
				this.pattern.gameObject.SetActive(null != KPJIOAFDNIA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060053D6 RID: 21462 RVA: 0x002524A0 File Offset: 0x002506A0
	private float MHAPLHDMHJC(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 191f || FNLKKBPAMLG <= 1751f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("OnRestorePurchasesFailedInvalidPlatform", "stats").Split((char)-63, StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = true;
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 1641f, 1088f).x > DDMMDDFIALL)
					{
						flag = false;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("notenoughstats", 1654f, 58f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 235f).y > y * (float)PCOGMMIPKEL + 186f)
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 1248f < num2)
				{
					goto Block_14;
				}
				num -= 1049f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053D7 RID: 21463 RVA: 0x002525E4 File Offset: 0x002507E4
	private float KCGMKAPGDKL()
	{
		try
		{
			if (null != this.artRect && null != this.nameText)
			{
				RectTransform rectTransform = this.nameText.transform.parent as RectTransform;
				if (null != rectTransform && rectTransform.parent == this.artRect)
				{
					float num = this.artRect.rect.width + rectTransform.sizeDelta.x;
					if (num > 1306f)
					{
						return num;
					}
				}
			}
			if (null != this.nameText)
			{
				return this.nameText.rectTransform.rect.width;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return 1030f;
	}

	// Token: 0x060053D8 RID: 21464 RVA: 0x002526B4 File Offset: 0x002508B4
	private float BIGBNOILJME(TextMeshProUGUI DIMBCOBNMAM, string FMJNOIIKHLM, float FNLKKBPAMLG, float KLOGGDEKFMN, int PCOGMMIPKEL, float DDMMDDFIALL)
	{
		float num = FNLKKBPAMLG;
		try
		{
			if (null == DIMBCOBNMAM || FMJNOIIKHLM == null || FMJNOIIKHLM.Trim().Length == 0 || DDMMDDFIALL <= 1666f || FNLKKBPAMLG <= 586f)
			{
				return FNLKKBPAMLG;
			}
			float num2 = FNLKKBPAMLG * KLOGGDEKFMN;
			string[] array = FMJNOIIKHLM.Replace("tradewishcardoption0", "SceneAvatarManager.AddOrUpdateAvatarCollection(): invalid title or component id").Split('|', StringSplitOptions.RemoveEmptyEntries);
			for (;;)
			{
				DIMBCOBNMAM.fontSize = num;
				bool flag = false;
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].Length != 0 && DIMBCOBNMAM.GetPreferredValues(array[i], 759f, 1566f).x > DDMMDDFIALL)
					{
						flag = true;
						break;
					}
				}
				if (flag && PCOGMMIPKEL > 0 && DIMBCOBNMAM.enableWordWrapping)
				{
					float y = DIMBCOBNMAM.GetPreferredValues("ProductThumbnailManager.Initialize() - _productBalance is null, aborting.", 1760f, 1497f).y;
					if (DIMBCOBNMAM.GetPreferredValues(FMJNOIIKHLM, DDMMDDFIALL, 468f).y > y * (float)PCOGMMIPKEL + 1607f)
					{
						flag = false;
					}
				}
				if (flag)
				{
					break;
				}
				if (num - 376f < num2)
				{
					goto Block_14;
				}
				num -= 676f;
			}
			return num;
			Block_14:
			return num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return num;
	}

	// Token: 0x060053D9 RID: 21465 RVA: 0x002527F8 File Offset: 0x002509F8
	public void ILKIGDMFLAK(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Overflow;
				if (this.PMNFGJKFMIM >= 0)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(false);
				}
				else
				{
					this.countText.text = "skuManual";
					this.countText.gameObject.SetActive(false);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (1374f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = "";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length > 0 && !text.Trim().Contains("acomp2") && !text.Trim().Contains(")");
				this.nameText.overflowMode = TextOverflowModes.Overflow;
				this.nameText.enableAutoSizing = false;
				this.nameText.enableWordWrapping = !flag;
				this.nameText.fontSize = this.MCBGIIOPNFC(this.nameText, text, this.PLLCLNNGGMI, 415f, 1, this.HPFCDPPACGG());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Ellipsis;
				if (1404f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = "ember";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = false;
				this.tagText.enableWordWrapping = false;
				this.tagText.fontSize = this.MCBGIIOPNFC(this.tagText, text2, this.LENMPMHPPBK, 1468f, 6, this.GCOPLOCFKAH());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm3);
		}
	}

	// Token: 0x060053DA RID: 21466 RVA: 0x0024A790 File Offset: 0x00248990
	public int FFGCHBOHNAE()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x060053DB RID: 21467 RVA: 0x00252A1C File Offset: 0x00250C1C
	public void MHDJGLPMHCM(int PHHBFOKNMMK, string HJEJJGAFHAM, string MCHOOEHCANP, int CMBCNMLGPPC, Sprite HNDJMKFCMEK, Sprite KPJIOAFDNIA)
	{
		try
		{
			this.PHEJGCKDPEA = PHHBFOKNMMK;
			this.PMNFGJKFMIM = CMBCNMLGPPC;
			if (null != this.icon)
			{
				if (null != HNDJMKFCMEK)
				{
					this.icon.sprite = HNDJMKFCMEK;
					this.icon.enabled = true;
				}
				else
				{
					this.icon.enabled = false;
				}
			}
			this.FJDMJCENJON();
			this.GAHPMCBLBMH(HJEJJGAFHAM, MCHOOEHCANP);
			this.JOJBHOMFEHH(KPJIOAFDNIA);
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053DC RID: 21468 RVA: 0x00252AA8 File Offset: 0x00250CA8
	private void BEHHKFIEKLH(Sprite KPJIOAFDNIA)
	{
		try
		{
			if (!(null == this.pattern))
			{
				this.pattern.sprite = KPJIOAFDNIA;
				this.pattern.gameObject.SetActive(null != KPJIOAFDNIA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x060053DD RID: 21469 RVA: 0x00252B04 File Offset: 0x00250D04
	public void JJEBKKLBHCP(string HJEJJGAFHAM, string MCHOOEHCANP)
	{
		try
		{
			if (null != this.countText)
			{
				this.countText.overflowMode = TextOverflowModes.Overflow;
				if (this.PMNFGJKFMIM >= 0)
				{
					this.countText.text = this.PMNFGJKFMIM.ToString();
					this.countText.gameObject.SetActive(true);
				}
				else
				{
					this.countText.text = "yes";
					this.countText.gameObject.SetActive(true);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		try
		{
			if (null != this.nameText)
			{
				if (0f == this.PLLCLNNGGMI)
				{
					this.PLLCLNNGGMI = this.nameText.fontSize;
				}
				string text = ", index:";
				if (HJEJJGAFHAM != null)
				{
					text = HJEJJGAFHAM;
				}
				bool flag = text.Trim().Length <= 0 || text.Trim().Contains("sshrpp") || text.Trim().Contains("1");
				this.nameText.overflowMode = TextOverflowModes.Overflow;
				this.nameText.enableAutoSizing = true;
				this.nameText.enableWordWrapping = flag;
				this.nameText.fontSize = this.MHAPLHDMHJC(this.nameText, text, this.PLLCLNNGGMI, 1922f, 3, this.CDMEFLFCKLC());
				this.nameText.text = text;
			}
		}
		catch (Exception aklgbjkdomm2)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm2);
		}
		try
		{
			if (null != this.tagText)
			{
				this.tagText.overflowMode = TextOverflowModes.Overflow;
				if (123f == this.LENMPMHPPBK)
				{
					this.LENMPMHPPBK = this.tagText.fontSize;
				}
				string text2 = "needtorestartgeneric";
				if (MCHOOEHCANP != null)
				{
					text2 = MCHOOEHCANP;
				}
				this.tagText.enableAutoSizing = true;
				this.tagText.enableWordWrapping = true;
				this.tagText.fontSize = this.JKGOHLCKLAL(this.tagText, text2, this.LENMPMHPPBK, 1840f, 6, this.JFNBDOAMEGO());
				this.tagText.text = text2;
			}
		}
		catch (Exception aklgbjkdomm3)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm3);
		}
	}

	// Token: 0x060053DE RID: 21470 RVA: 0x00252D28 File Offset: 0x00250F28
	private void KJGHCKMHIGJ(Sprite KPJIOAFDNIA)
	{
		try
		{
			if (!(null == this.pattern))
			{
				this.pattern.sprite = KPJIOAFDNIA;
				this.pattern.gameObject.SetActive(null != KPJIOAFDNIA);
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x060053DF RID: 21471 RVA: 0x0024A790 File Offset: 0x00248990
	public int NCAFKFJGEII()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x060053E0 RID: 21472 RVA: 0x0024A790 File Offset: 0x00248990
	public int NMGACPCCGON()
	{
		return this.PHEJGCKDPEA;
	}

	// Token: 0x04001770 RID: 6000
	public Image icon;

	// Token: 0x04001771 RID: 6001
	public TextMeshProUGUI nameText;

	// Token: 0x04001772 RID: 6002
	public TextMeshProUGUI tagText;

	// Token: 0x04001773 RID: 6003
	public TextMeshProUGUI countText;

	// Token: 0x04001774 RID: 6004
	public RectTransform artRect;

	// Token: 0x04001775 RID: 6005
	public Image pattern;

	// Token: 0x04001776 RID: 6006
	private int PHEJGCKDPEA = -1;

	// Token: 0x04001777 RID: 6007
	private int PMNFGJKFMIM = -1;

	// Token: 0x04001778 RID: 6008
	private float PLLCLNNGGMI;

	// Token: 0x04001779 RID: 6009
	private float LENMPMHPPBK;

	// Token: 0x0400177A RID: 6010
	private const float HKNFAIHNPDA = 0.6f;

	// Token: 0x0400177B RID: 6011
	private const float BAJMNJNMEGD = 0.7f;

	// Token: 0x0400177C RID: 6012
	private const int MPJCOOPJFMA = 3;

	// Token: 0x0400177D RID: 6013
	private const int MPAPPIBOKJO = 3;

	// Token: 0x0400177E RID: 6014
	private const float BMOOJOCANBE = 100000f;
}
