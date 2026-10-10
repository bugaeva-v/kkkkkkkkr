using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200021E RID: 542
public class ContentGridItem : MonoBehaviour
{
	// Token: 0x0600437B RID: 17275 RVA: 0x001D76EC File Offset: 0x001D58EC
	private void HNPDAIBKJIO()
	{
		if (ContentGridItem.LHFFFMJIFDM != 169f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentGridItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x0600437C RID: 17276 RVA: 0x001D7740 File Offset: 0x001D5940
	public void PFAGHINKHKL(PMEPALPCEAF FOKFGMIEEDB, int OAJKHHOKLHA, FFIAHOPJJJG PBKAAIONJOB, Vector2 HNFALJJAEJC, List<Transform> PFDJOGMLHGM)
	{
		this.CDBKEJNBMLK = PFDJOGMLHGM;
		this.ONKONHLJKPG = HNFALJJAEJC;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = HEIDEJOPKAA.AssetAnthologyPreview2.ToString().ToLower() + OAJKHHOKLHA.ToString();
		JDMAEBPEIBE.COOBAKLDJEG(this.imageThumb, OAJKHHOKLHA);
		this.BAPAGHLFADF = this.imageThumb.GetComponent<ImageFrameAnimation>();
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.NEIOHLOGFAF == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = false;
		}
		this.GGIAGCLNGDI();
	}

	// Token: 0x0600437D RID: 17277 RVA: 0x001D77E9 File Offset: 0x001D59E9
	public void FCDKFGJHJNL()
	{
		this.isSelected = true;
		this.selectedBorder.SetActive(true);
	}

	// Token: 0x0600437E RID: 17278 RVA: 0x001D7800 File Offset: 0x001D5A00
	private void JDBILDJENPA(List<string> DNICFPADPDC, int FPFHCOCAHJG)
	{
		if (DNICFPADPDC.Count == FPFHCOCAHJG + 1)
		{
			foreach (object obj in base.transform.parent.transform)
			{
				Transform transform = (Transform)obj;
				if (transform.GetComponent<ContentGridItem>().imageThumb.sprite.name == DNICFPADPDC[0])
				{
					transform.GetComponent<ContentGridItem>().ResetItem();
				}
			}
			DNICFPADPDC.RemoveAt(0);
		}
	}

	// Token: 0x0600437F RID: 17279 RVA: 0x001D789C File Offset: 0x001D5A9C
	public void ResetItem()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(false);
	}

	// Token: 0x06004380 RID: 17280 RVA: 0x001D78B4 File Offset: 0x001D5AB4
	private bool JEAKLONGJAJ()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004381 RID: 17281 RVA: 0x001D7910 File Offset: 0x001D5B10
	public void AMLPNMNBKBL()
	{
		if (this.selectedBorder.activeSelf)
		{
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				List<string> list = this.AEDICCFAKOM.FJHCBIPBEBG();
				list.Remove(this.OBOKPAAOLDO);
				this.AEDICCFAKOM.GDIKJNLCAFA(list);
				this.selectedBorder.SetActive(true);
				this.isSelected = true;
			}
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Story)
			{
				List<string> list2 = this.AEDICCFAKOM.CFDOLDIADOP();
				list2.Remove(this.OBOKPAAOLDO);
				this.AEDICCFAKOM.NKGDPNMBHFJ(list2);
				this.selectedBorder.SetActive(false);
				this.isSelected = false;
				return;
			}
		}
		else
		{
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				foreach (Transform transform in this.CDBKEJNBMLK)
				{
					transform.GetComponent<ContentGridItem>().selectedBorder.SetActive(false);
				}
				this.AEDICCFAKOM.CHGABDFMBJO(this.NEIOHLOGFAF);
			}
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Char)
			{
				List<string> list3 = this.AEDICCFAKOM.FJHCBIPBEBG();
				list3.Add(this.OBOKPAAOLDO);
				int fpfhcocahjg = 106;
				this.JPIGJLEENPB(list3, fpfhcocahjg);
				this.AEDICCFAKOM.GDIKJNLCAFA(list3);
			}
			if (this.OBKCKGHFMDN == (FFIAHOPJJJG)5)
			{
				List<string> list4 = this.AEDICCFAKOM.CFDOLDIADOP();
				list4.Add(this.OBOKPAAOLDO);
				int fpfhcocahjg2 = 112;
				this.AJNIFONPIOC(list4, fpfhcocahjg2);
				this.AEDICCFAKOM.NKGDPNMBHFJ(list4);
			}
			this.selectedBorder.SetActive(true);
			this.isSelected = true;
		}
	}

	// Token: 0x06004382 RID: 17282 RVA: 0x001D7AA8 File Offset: 0x001D5CA8
	public void KHBPKEBMDMJ()
	{
		if (this.selectedBorder.activeSelf)
		{
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				List<string> list = this.AEDICCFAKOM.FJHCBIPBEBG();
				list.Remove(this.OBOKPAAOLDO);
				this.AEDICCFAKOM.GDIKJNLCAFA(list);
				this.selectedBorder.SetActive(false);
				this.isSelected = true;
			}
			if (this.OBKCKGHFMDN == (FFIAHOPJJJG)5)
			{
				List<string> list2 = this.AEDICCFAKOM.CFDOLDIADOP();
				list2.Remove(this.OBOKPAAOLDO);
				this.AEDICCFAKOM.NKGDPNMBHFJ(list2);
				this.selectedBorder.SetActive(true);
				this.isSelected = true;
				return;
			}
		}
		else
		{
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				foreach (Transform transform in this.CDBKEJNBMLK)
				{
					transform.GetComponent<ContentGridItem>().selectedBorder.SetActive(false);
				}
				this.AEDICCFAKOM.CHGABDFMBJO(this.NEIOHLOGFAF);
			}
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				List<string> list3 = this.AEDICCFAKOM.FJHCBIPBEBG();
				list3.Add(this.OBOKPAAOLDO);
				int fpfhcocahjg = 20;
				this.DIAPCDBILLG(list3, fpfhcocahjg);
				this.AEDICCFAKOM.GDIKJNLCAFA(list3);
			}
			if (this.OBKCKGHFMDN == (FFIAHOPJJJG)7)
			{
				List<string> list4 = this.AEDICCFAKOM.CFDOLDIADOP();
				list4.Add(this.OBOKPAAOLDO);
				int fpfhcocahjg2 = -90;
				this.ODOGJCGCKGB(list4, fpfhcocahjg2);
				this.AEDICCFAKOM.NKGDPNMBHFJ(list4);
			}
			this.selectedBorder.SetActive(false);
			this.isSelected = false;
		}
	}

	// Token: 0x06004383 RID: 17283 RVA: 0x001D7C40 File Offset: 0x001D5E40
	private void CKNCEKFOLKD()
	{
		JDMAEBPEIBE.GFFAPCMJCFD(this.imageThumb);
		this.imageThumb.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.gridButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06004384 RID: 17284 RVA: 0x001D7C90 File Offset: 0x001D5E90
	private void JLFFPPGACOE(List<string> DNICFPADPDC, int FPFHCOCAHJG)
	{
		if (DNICFPADPDC.Count == FPFHCOCAHJG + 0)
		{
			foreach (object obj in base.transform.parent.transform)
			{
				Transform transform = (Transform)obj;
				if (transform.GetComponent<ContentGridItem>().imageThumb.sprite.name == DNICFPADPDC[1])
				{
					transform.GetComponent<ContentGridItem>().ResetItem();
				}
			}
			DNICFPADPDC.RemoveAt(0);
		}
	}

	// Token: 0x06004385 RID: 17285 RVA: 0x001D789C File Offset: 0x001D5A9C
	public void IILJLBBEJHO()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(false);
	}

	// Token: 0x06004386 RID: 17286 RVA: 0x001D7D2C File Offset: 0x001D5F2C
	private bool AAOCNCBCDDA()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004387 RID: 17287 RVA: 0x001D7D88 File Offset: 0x001D5F88
	private void DGFFPEKIFAP()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 2)
		{
			return;
		}
		bool active = this.AAOCNCBCDDA();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004388 RID: 17288 RVA: 0x001D7DD0 File Offset: 0x001D5FD0
	public void SetContentFrames(PMEPALPCEAF FOKFGMIEEDB, AssetLiveProfileTheme HLCLBIBCPNM, FFIAHOPJJJG PBKAAIONJOB, Vector2 ONKONHLJKPG, List<Transform> NLEJANGPDGK)
	{
		this.CDBKEJNBMLK = NLEJANGPDGK;
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = HEIDEJOPKAA.AssetLiveProfileTheme.ToString().ToLower() + HLCLBIBCPNM.index.ToString();
		this.BAPAGHLFADF = this.imageThumb.gameObject.AddComponent<ImageFrameAnimation>();
		this.BAPAGHLFADF.framesSD = HLCLBIBCPNM.frames.ToArray();
		this.BAPAGHLFADF.pauseTime = HLCLBIBCPNM.pauseTime;
		this.BAPAGHLFADF.pauseFrame = HLCLBIBCPNM.pauseFrame;
		this.BAPAGHLFADF.frameChangeInterval = HLCLBIBCPNM.frameChangeInterval;
		this.BAPAGHLFADF.reverseDirection = HLCLBIBCPNM.reverseDirection;
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.NEIOHLOGFAF == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = true;
		}
		this.NDKJNKCLKGN();
	}

	// Token: 0x06004389 RID: 17289 RVA: 0x001D7ED0 File Offset: 0x001D60D0
	private void DIAPCDBILLG(List<string> DNICFPADPDC, int FPFHCOCAHJG)
	{
		if (DNICFPADPDC.Count == FPFHCOCAHJG + 1)
		{
			foreach (object obj in base.transform.parent.transform)
			{
				Transform transform = (Transform)obj;
				if (transform.GetComponent<ContentGridItem>().imageThumb.sprite.name == DNICFPADPDC[0])
				{
					transform.GetComponent<ContentGridItem>().ResetItem();
				}
			}
			DNICFPADPDC.RemoveAt(0);
		}
	}

	// Token: 0x0600438A RID: 17290 RVA: 0x001D7F6C File Offset: 0x001D616C
	private void HIIFPFHIDEP()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		bool active = this.AAOCNCBCDDA();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x0600438B RID: 17291 RVA: 0x001D7FB4 File Offset: 0x001D61B4
	public void LODCMECOHCI(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, FFIAHOPJJJG PBKAAIONJOB, Vector2 ONKONHLJKPG, List<Transform> NLEJANGPDGK)
	{
		this.CDBKEJNBMLK = NLEJANGPDGK;
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBOKPAAOLDO = IBHNGIAHCCM.name;
		this.imageThumb.sprite = IBHNGIAHCCM;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = this.OBOKPAAOLDO;
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.OBOKPAAOLDO == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = false;
		}
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Char && this.AEDICCFAKOM.FJHCBIPBEBG().Contains(this.OBOKPAAOLDO))
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = false;
		}
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Story && this.AEDICCFAKOM.CFDOLDIADOP().Contains(this.OBOKPAAOLDO))
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = true;
		}
		this.NDKJNKCLKGN();
	}

	// Token: 0x0600438C RID: 17292 RVA: 0x001D80A4 File Offset: 0x001D62A4
	private void NAKENAOAAPF()
	{
		if (ContentGridItem.LHFFFMJIFDM != 1475f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentGridItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x0600438D RID: 17293 RVA: 0x001D80F8 File Offset: 0x001D62F8
	private void AJNIFONPIOC(List<string> DNICFPADPDC, int FPFHCOCAHJG)
	{
		if (DNICFPADPDC.Count == FPFHCOCAHJG + 1)
		{
			foreach (object obj in base.transform.parent.transform)
			{
				Transform transform = (Transform)obj;
				if (transform.GetComponent<ContentGridItem>().imageThumb.sprite.name == DNICFPADPDC[1])
				{
					transform.GetComponent<ContentGridItem>().FBIJBDOFENH();
				}
			}
			DNICFPADPDC.RemoveAt(0);
		}
	}

	// Token: 0x0600438E RID: 17294 RVA: 0x001D8194 File Offset: 0x001D6394
	private void BKNGGJFCHIK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 1)
		{
			return;
		}
		bool active = this.AAOCNCBCDDA();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x0600438F RID: 17295 RVA: 0x001D81DC File Offset: 0x001D63DC
	private void DLBAEDOFAKM()
	{
		JDMAEBPEIBE.CJDEHHPKDMI(this.imageThumb);
		this.imageThumb.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.gridButton.onClick.RemoveAllListeners();
	}

	// Token: 0x06004390 RID: 17296 RVA: 0x001D822C File Offset: 0x001D642C
	private void ADKKEBKIPJF()
	{
		if (ContentGridItem.LHFFFMJIFDM != 955f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06004391 RID: 17297 RVA: 0x001D8280 File Offset: 0x001D6480
	public void GCGEECALBPK()
	{
		if (this.selectedBorder.activeSelf)
		{
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				List<string> list = this.AEDICCFAKOM.FJHCBIPBEBG();
				list.Remove(this.OBOKPAAOLDO);
				this.AEDICCFAKOM.GDIKJNLCAFA(list);
				this.selectedBorder.SetActive(true);
				this.isSelected = false;
			}
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Story)
			{
				List<string> list2 = this.AEDICCFAKOM.CFDOLDIADOP();
				list2.Remove(this.OBOKPAAOLDO);
				this.AEDICCFAKOM.NKGDPNMBHFJ(list2);
				this.selectedBorder.SetActive(false);
				this.isSelected = false;
				return;
			}
		}
		else
		{
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				foreach (Transform transform in this.CDBKEJNBMLK)
				{
					transform.GetComponent<ContentGridItem>().selectedBorder.SetActive(true);
				}
				this.AEDICCFAKOM.CHGABDFMBJO(this.NEIOHLOGFAF);
			}
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				List<string> list3 = this.AEDICCFAKOM.FJHCBIPBEBG();
				list3.Add(this.OBOKPAAOLDO);
				int fpfhcocahjg = -43;
				this.ABPILFCJPGM(list3, fpfhcocahjg);
				this.AEDICCFAKOM.GDIKJNLCAFA(list3);
			}
			if (this.OBKCKGHFMDN == (FFIAHOPJJJG)8)
			{
				List<string> list4 = this.AEDICCFAKOM.CFDOLDIADOP();
				list4.Add(this.OBOKPAAOLDO);
				int fpfhcocahjg2 = -7;
				this.JDBILDJENPA(list4, fpfhcocahjg2);
				this.AEDICCFAKOM.NKGDPNMBHFJ(list4);
			}
			this.selectedBorder.SetActive(false);
			this.isSelected = false;
		}
	}

	// Token: 0x06004392 RID: 17298 RVA: 0x001D8418 File Offset: 0x001D6618
	public void MAKEJIFOJCB()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(true);
	}

	// Token: 0x06004393 RID: 17299 RVA: 0x001D8430 File Offset: 0x001D6630
	public void CHHCPMCHNEH(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, FFIAHOPJJJG PBKAAIONJOB, Vector2 ONKONHLJKPG, List<Transform> NLEJANGPDGK)
	{
		this.CDBKEJNBMLK = NLEJANGPDGK;
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBOKPAAOLDO = IBHNGIAHCCM.name;
		this.imageThumb.sprite = IBHNGIAHCCM;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = this.OBOKPAAOLDO;
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.OBOKPAAOLDO == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(false);
			this.isSelected = true;
		}
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.AEDICCFAKOM.FJHCBIPBEBG().Contains(this.OBOKPAAOLDO))
		{
			this.selectedBorder.SetActive(false);
			this.isSelected = true;
		}
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Story && this.AEDICCFAKOM.CFDOLDIADOP().Contains(this.OBOKPAAOLDO))
		{
			this.selectedBorder.SetActive(false);
			this.isSelected = true;
		}
		this.NDKJNKCLKGN();
	}

	// Token: 0x06004394 RID: 17300 RVA: 0x001D8520 File Offset: 0x001D6720
	public void JGMELBIDOPA()
	{
		if (this.selectedBorder.activeSelf)
		{
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				List<string> list = this.AEDICCFAKOM.FJHCBIPBEBG();
				list.Remove(this.OBOKPAAOLDO);
				this.AEDICCFAKOM.GDIKJNLCAFA(list);
				this.selectedBorder.SetActive(true);
				this.isSelected = false;
			}
			if (this.OBKCKGHFMDN == (FFIAHOPJJJG)4)
			{
				List<string> list2 = this.AEDICCFAKOM.CFDOLDIADOP();
				list2.Remove(this.OBOKPAAOLDO);
				this.AEDICCFAKOM.NKGDPNMBHFJ(list2);
				this.selectedBorder.SetActive(false);
				this.isSelected = true;
				return;
			}
		}
		else
		{
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				foreach (Transform transform in this.CDBKEJNBMLK)
				{
					transform.GetComponent<ContentGridItem>().selectedBorder.SetActive(true);
				}
				this.AEDICCFAKOM.CHGABDFMBJO(this.NEIOHLOGFAF);
			}
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Char)
			{
				List<string> list3 = this.AEDICCFAKOM.FJHCBIPBEBG();
				list3.Add(this.OBOKPAAOLDO);
				int fpfhcocahjg = 19;
				this.JPIGJLEENPB(list3, fpfhcocahjg);
				this.AEDICCFAKOM.GDIKJNLCAFA(list3);
			}
			if (this.OBKCKGHFMDN == (FFIAHOPJJJG)8)
			{
				List<string> list4 = this.AEDICCFAKOM.CFDOLDIADOP();
				list4.Add(this.OBOKPAAOLDO);
				int fpfhcocahjg2 = 37;
				this.ODOGJCGCKGB(list4, fpfhcocahjg2);
				this.AEDICCFAKOM.NKGDPNMBHFJ(list4);
			}
			this.selectedBorder.SetActive(true);
			this.isSelected = true;
		}
	}

	// Token: 0x06004395 RID: 17301 RVA: 0x001D86B8 File Offset: 0x001D68B8
	public void OnItemSelect()
	{
		if (this.selectedBorder.activeSelf)
		{
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Char)
			{
				List<string> list = this.AEDICCFAKOM.FJHCBIPBEBG();
				list.Remove(this.OBOKPAAOLDO);
				this.AEDICCFAKOM.GDIKJNLCAFA(list);
				this.selectedBorder.SetActive(false);
				this.isSelected = false;
			}
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Story)
			{
				List<string> list2 = this.AEDICCFAKOM.CFDOLDIADOP();
				list2.Remove(this.OBOKPAAOLDO);
				this.AEDICCFAKOM.NKGDPNMBHFJ(list2);
				this.selectedBorder.SetActive(false);
				this.isSelected = false;
				return;
			}
		}
		else
		{
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				foreach (Transform transform in this.CDBKEJNBMLK)
				{
					transform.GetComponent<ContentGridItem>().selectedBorder.SetActive(false);
				}
				this.AEDICCFAKOM.CHGABDFMBJO(this.NEIOHLOGFAF);
			}
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Char)
			{
				List<string> list3 = this.AEDICCFAKOM.FJHCBIPBEBG();
				list3.Add(this.OBOKPAAOLDO);
				int fpfhcocahjg = 18;
				this.JDBILDJENPA(list3, fpfhcocahjg);
				this.AEDICCFAKOM.GDIKJNLCAFA(list3);
			}
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Story)
			{
				List<string> list4 = this.AEDICCFAKOM.CFDOLDIADOP();
				list4.Add(this.OBOKPAAOLDO);
				int fpfhcocahjg2 = 18;
				this.JDBILDJENPA(list4, fpfhcocahjg2);
				this.AEDICCFAKOM.NKGDPNMBHFJ(list4);
			}
			this.selectedBorder.SetActive(true);
			this.isSelected = true;
		}
	}

	// Token: 0x06004396 RID: 17302 RVA: 0x001D8850 File Offset: 0x001D6A50
	private void ABPILFCJPGM(List<string> DNICFPADPDC, int FPFHCOCAHJG)
	{
		if (DNICFPADPDC.Count == FPFHCOCAHJG + 1)
		{
			foreach (object obj in base.transform.parent.transform)
			{
				Transform transform = (Transform)obj;
				if (transform.GetComponent<ContentGridItem>().imageThumb.sprite.name == DNICFPADPDC[0])
				{
					transform.GetComponent<ContentGridItem>().MAKEJIFOJCB();
				}
			}
			DNICFPADPDC.RemoveAt(0);
		}
	}

	// Token: 0x06004397 RID: 17303 RVA: 0x001D88EC File Offset: 0x001D6AEC
	private void GGIAGCLNGDI()
	{
		if (ContentGridItem.LHFFFMJIFDM != 1779f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06004398 RID: 17304 RVA: 0x001D8940 File Offset: 0x001D6B40
	private void NFFGMDALKCE()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		bool active = this.DJKPAKLAHFE();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004399 RID: 17305 RVA: 0x001D8988 File Offset: 0x001D6B88
	private bool JIMMBOCPEOJ()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600439A RID: 17306 RVA: 0x001D89E4 File Offset: 0x001D6BE4
	private bool OBAABFHAKFJ()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600439B RID: 17307 RVA: 0x001D8A40 File Offset: 0x001D6C40
	private void NKPBKBHKJMA()
	{
		JDMAEBPEIBE.BIGKGBBKHNJ(this.imageThumb);
		this.imageThumb.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.gridButton.onClick.RemoveAllListeners();
	}

	// Token: 0x0600439C RID: 17308 RVA: 0x001D8A90 File Offset: 0x001D6C90
	public void MKFMHMDOBOE(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, FFIAHOPJJJG PBKAAIONJOB, Vector2 ONKONHLJKPG, List<Transform> NLEJANGPDGK)
	{
		this.CDBKEJNBMLK = NLEJANGPDGK;
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBOKPAAOLDO = IBHNGIAHCCM.name;
		this.imageThumb.sprite = IBHNGIAHCCM;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = this.OBOKPAAOLDO;
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.OBOKPAAOLDO == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(false);
			this.isSelected = true;
		}
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Char && this.AEDICCFAKOM.FJHCBIPBEBG().Contains(this.OBOKPAAOLDO))
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = false;
		}
		if (this.OBKCKGHFMDN == (FFIAHOPJJJG)7 && this.AEDICCFAKOM.CFDOLDIADOP().Contains(this.OBOKPAAOLDO))
		{
			this.selectedBorder.SetActive(false);
			this.isSelected = false;
		}
		this.ADKKEBKIPJF();
	}

	// Token: 0x0600439E RID: 17310 RVA: 0x001D8B80 File Offset: 0x001D6D80
	private void GLKIIPNDLKB()
	{
		if (ContentGridItem.LHFFFMJIFDM != 1822f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x0600439F RID: 17311 RVA: 0x001D8BD4 File Offset: 0x001D6DD4
	private void OnDestroy()
	{
		JDMAEBPEIBE.MHLOFOJCLIG(this.imageThumb);
		this.imageThumb.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.gridButton.onClick.RemoveAllListeners();
	}

	// Token: 0x060043A0 RID: 17312 RVA: 0x001D8C24 File Offset: 0x001D6E24
	public void ONPJOAFLCBG(PMEPALPCEAF FOKFGMIEEDB, int OAJKHHOKLHA, FFIAHOPJJJG PBKAAIONJOB, Vector2 HNFALJJAEJC, List<Transform> PFDJOGMLHGM)
	{
		this.CDBKEJNBMLK = PFDJOGMLHGM;
		this.ONKONHLJKPG = HNFALJJAEJC;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = ((HEIDEJOPKAA)89).ToString().ToLower() + OAJKHHOKLHA.ToString();
		JDMAEBPEIBE.KIIEJJOKODB(this.imageThumb, OAJKHHOKLHA);
		this.BAPAGHLFADF = this.imageThumb.GetComponent<ImageFrameAnimation>();
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.NEIOHLOGFAF == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = false;
		}
		this.ADKKEBKIPJF();
	}

	// Token: 0x060043A1 RID: 17313 RVA: 0x001D8CD0 File Offset: 0x001D6ED0
	public void EFKDNPLONMF(PMEPALPCEAF FOKFGMIEEDB, int OAJKHHOKLHA, FFIAHOPJJJG PBKAAIONJOB, Vector2 HNFALJJAEJC, List<Transform> PFDJOGMLHGM)
	{
		this.CDBKEJNBMLK = PFDJOGMLHGM;
		this.ONKONHLJKPG = HNFALJJAEJC;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = ((HEIDEJOPKAA)(-90)).ToString().ToLower() + OAJKHHOKLHA.ToString();
		JDMAEBPEIBE.JHHDPCGCBHO(this.imageThumb, OAJKHHOKLHA);
		this.BAPAGHLFADF = this.imageThumb.GetComponent<ImageFrameAnimation>();
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.NEIOHLOGFAF == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = true;
		}
		this.NNMJBIHHHCJ();
	}

	// Token: 0x060043A2 RID: 17314 RVA: 0x001D8D7C File Offset: 0x001D6F7C
	private void NDKJNKCLKGN()
	{
		if (ContentGridItem.LHFFFMJIFDM != 0f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060043A3 RID: 17315 RVA: 0x001D8DD0 File Offset: 0x001D6FD0
	public void KINIOJMBIEI(PMEPALPCEAF FOKFGMIEEDB, AssetLiveProfileTheme HLCLBIBCPNM, FFIAHOPJJJG PBKAAIONJOB, Vector2 ONKONHLJKPG, List<Transform> NLEJANGPDGK)
	{
		this.CDBKEJNBMLK = NLEJANGPDGK;
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = ((HEIDEJOPKAA)92).ToString().ToLower() + HLCLBIBCPNM.index.ToString();
		this.BAPAGHLFADF = this.imageThumb.gameObject.AddComponent<ImageFrameAnimation>();
		this.BAPAGHLFADF.framesSD = HLCLBIBCPNM.frames.ToArray();
		this.BAPAGHLFADF.pauseTime = HLCLBIBCPNM.pauseTime;
		this.BAPAGHLFADF.pauseFrame = HLCLBIBCPNM.pauseFrame;
		this.BAPAGHLFADF.frameChangeInterval = HLCLBIBCPNM.frameChangeInterval;
		this.BAPAGHLFADF.reverseDirection = HLCLBIBCPNM.reverseDirection;
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.NEIOHLOGFAF == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = false;
		}
		this.GGIAGCLNGDI();
	}

	// Token: 0x060043A4 RID: 17316 RVA: 0x001D8ED0 File Offset: 0x001D70D0
	private void NAKFGFJPBBK()
	{
		JDMAEBPEIBE.GFFAPCMJCFD(this.imageThumb);
		this.imageThumb.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.gridButton.onClick.RemoveAllListeners();
	}

	// Token: 0x060043A5 RID: 17317 RVA: 0x001D8F20 File Offset: 0x001D7120
	private void DDCAEGOCKOJ()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 3)
		{
			return;
		}
		bool active = this.JIPLIJIAKEJ();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x060043A6 RID: 17318 RVA: 0x001D8F68 File Offset: 0x001D7168
	private void Update()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.DJKPAKLAHFE();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x060043A7 RID: 17319 RVA: 0x001D8FB0 File Offset: 0x001D71B0
	public void BMDBJHDKFCN(PMEPALPCEAF FOKFGMIEEDB, AssetLiveProfileTheme HLCLBIBCPNM, FFIAHOPJJJG PBKAAIONJOB, Vector2 ONKONHLJKPG, List<Transform> NLEJANGPDGK)
	{
		this.CDBKEJNBMLK = NLEJANGPDGK;
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = ((HEIDEJOPKAA)106).ToString().ToLower() + HLCLBIBCPNM.index.ToString();
		this.BAPAGHLFADF = this.imageThumb.gameObject.AddComponent<ImageFrameAnimation>();
		this.BAPAGHLFADF.framesSD = HLCLBIBCPNM.frames.ToArray();
		this.BAPAGHLFADF.pauseTime = HLCLBIBCPNM.pauseTime;
		this.BAPAGHLFADF.pauseFrame = HLCLBIBCPNM.pauseFrame;
		this.BAPAGHLFADF.frameChangeInterval = HLCLBIBCPNM.frameChangeInterval;
		this.BAPAGHLFADF.reverseDirection = HLCLBIBCPNM.reverseDirection;
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.NEIOHLOGFAF == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = false;
		}
		this.GGIAGCLNGDI();
	}

	// Token: 0x060043A8 RID: 17320 RVA: 0x001D90B0 File Offset: 0x001D72B0
	private void BLIGGBNJGNI()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.JEAKLONGJAJ();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x060043A9 RID: 17321 RVA: 0x001D90F8 File Offset: 0x001D72F8
	private bool JIPLIJIAKEJ()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060043AA RID: 17322 RVA: 0x001D9154 File Offset: 0x001D7354
	public void SetContent(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, FFIAHOPJJJG PBKAAIONJOB, Vector2 ONKONHLJKPG, List<Transform> NLEJANGPDGK)
	{
		this.CDBKEJNBMLK = NLEJANGPDGK;
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBOKPAAOLDO = IBHNGIAHCCM.name;
		this.imageThumb.sprite = IBHNGIAHCCM;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = this.OBOKPAAOLDO;
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.OBOKPAAOLDO == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = true;
		}
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Char && this.AEDICCFAKOM.FJHCBIPBEBG().Contains(this.OBOKPAAOLDO))
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = true;
		}
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Story && this.AEDICCFAKOM.CFDOLDIADOP().Contains(this.OBOKPAAOLDO))
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = true;
		}
		this.NDKJNKCLKGN();
	}

	// Token: 0x060043AB RID: 17323 RVA: 0x001D9244 File Offset: 0x001D7444
	public void NJGBNFJGLLL(PMEPALPCEAF FOKFGMIEEDB, AssetLiveProfileTheme HLCLBIBCPNM, FFIAHOPJJJG PBKAAIONJOB, Vector2 ONKONHLJKPG, List<Transform> NLEJANGPDGK)
	{
		this.CDBKEJNBMLK = NLEJANGPDGK;
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = ((HEIDEJOPKAA)84).ToString().ToLower() + HLCLBIBCPNM.index.ToString();
		this.BAPAGHLFADF = this.imageThumb.gameObject.AddComponent<ImageFrameAnimation>();
		this.BAPAGHLFADF.framesSD = HLCLBIBCPNM.frames.ToArray();
		this.BAPAGHLFADF.pauseTime = HLCLBIBCPNM.pauseTime;
		this.BAPAGHLFADF.pauseFrame = HLCLBIBCPNM.pauseFrame;
		this.BAPAGHLFADF.frameChangeInterval = HLCLBIBCPNM.frameChangeInterval;
		this.BAPAGHLFADF.reverseDirection = HLCLBIBCPNM.reverseDirection;
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.NEIOHLOGFAF == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(false);
			this.isSelected = true;
		}
		this.GLKIIPNDLKB();
	}

	// Token: 0x060043AC RID: 17324 RVA: 0x001D9344 File Offset: 0x001D7544
	private void DJIFHJDBBHN()
	{
		JDMAEBPEIBE.FOCLHGGNKJP(this.imageThumb);
		this.imageThumb.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.gridButton.onClick.RemoveAllListeners();
	}

	// Token: 0x060043AD RID: 17325 RVA: 0x001D9394 File Offset: 0x001D7594
	public void KDDLHGMIPBF(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, FFIAHOPJJJG PBKAAIONJOB, Vector2 ONKONHLJKPG, List<Transform> NLEJANGPDGK)
	{
		this.CDBKEJNBMLK = NLEJANGPDGK;
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBOKPAAOLDO = IBHNGIAHCCM.name;
		this.imageThumb.sprite = IBHNGIAHCCM;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = this.OBOKPAAOLDO;
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.OBOKPAAOLDO == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(false);
			this.isSelected = true;
		}
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.AEDICCFAKOM.FJHCBIPBEBG().Contains(this.OBOKPAAOLDO))
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = false;
		}
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Story && this.AEDICCFAKOM.CFDOLDIADOP().Contains(this.OBOKPAAOLDO))
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = true;
		}
		this.NNMJBIHHHCJ();
	}

	// Token: 0x060043AE RID: 17326 RVA: 0x001D9484 File Offset: 0x001D7684
	public void SetContentLive(PMEPALPCEAF FOKFGMIEEDB, int OAJKHHOKLHA, FFIAHOPJJJG PBKAAIONJOB, Vector2 HNFALJJAEJC, List<Transform> PFDJOGMLHGM)
	{
		this.CDBKEJNBMLK = PFDJOGMLHGM;
		this.ONKONHLJKPG = HNFALJJAEJC;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = HEIDEJOPKAA.AssetLiveProfileTheme.ToString().ToLower() + OAJKHHOKLHA.ToString();
		JDMAEBPEIBE.KIIEJJOKODB(this.imageThumb, OAJKHHOKLHA);
		this.BAPAGHLFADF = this.imageThumb.GetComponent<ImageFrameAnimation>();
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.NEIOHLOGFAF == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = true;
		}
		this.NDKJNKCLKGN();
	}

	// Token: 0x060043AF RID: 17327 RVA: 0x001D9530 File Offset: 0x001D7730
	public void FINFODIECAP()
	{
		if (this.selectedBorder.activeSelf)
		{
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				List<string> list = this.AEDICCFAKOM.FJHCBIPBEBG();
				list.Remove(this.OBOKPAAOLDO);
				this.AEDICCFAKOM.GDIKJNLCAFA(list);
				this.selectedBorder.SetActive(false);
				this.isSelected = true;
			}
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Story)
			{
				List<string> list2 = this.AEDICCFAKOM.CFDOLDIADOP();
				list2.Remove(this.OBOKPAAOLDO);
				this.AEDICCFAKOM.NKGDPNMBHFJ(list2);
				this.selectedBorder.SetActive(false);
				this.isSelected = true;
				return;
			}
		}
		else
		{
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				foreach (Transform transform in this.CDBKEJNBMLK)
				{
					transform.GetComponent<ContentGridItem>().selectedBorder.SetActive(true);
				}
				this.AEDICCFAKOM.CHGABDFMBJO(this.NEIOHLOGFAF);
			}
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar)
			{
				List<string> list3 = this.AEDICCFAKOM.FJHCBIPBEBG();
				list3.Add(this.OBOKPAAOLDO);
				int fpfhcocahjg = 36;
				this.DIAPCDBILLG(list3, fpfhcocahjg);
				this.AEDICCFAKOM.GDIKJNLCAFA(list3);
			}
			if (this.OBKCKGHFMDN == FFIAHOPJJJG.Story)
			{
				List<string> list4 = this.AEDICCFAKOM.CFDOLDIADOP();
				list4.Add(this.OBOKPAAOLDO);
				int fpfhcocahjg2 = 83;
				this.JDBILDJENPA(list4, fpfhcocahjg2);
				this.AEDICCFAKOM.NKGDPNMBHFJ(list4);
			}
			this.selectedBorder.SetActive(true);
			this.isSelected = false;
		}
	}

	// Token: 0x060043B0 RID: 17328 RVA: 0x001D96C8 File Offset: 0x001D78C8
	private void PIHOFDGILPJ()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 7)
		{
			return;
		}
		bool active = this.JIPLIJIAKEJ();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x060043B1 RID: 17329 RVA: 0x001D8418 File Offset: 0x001D6618
	public void FBIJBDOFENH()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(true);
	}

	// Token: 0x060043B2 RID: 17330 RVA: 0x001D9710 File Offset: 0x001D7910
	public void BBIGFJOPOCE(PMEPALPCEAF FOKFGMIEEDB, AssetLiveProfileTheme HLCLBIBCPNM, FFIAHOPJJJG PBKAAIONJOB, Vector2 ONKONHLJKPG, List<Transform> NLEJANGPDGK)
	{
		this.CDBKEJNBMLK = NLEJANGPDGK;
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = ((HEIDEJOPKAA)(-48)).ToString().ToLower() + HLCLBIBCPNM.index.ToString();
		this.BAPAGHLFADF = this.imageThumb.gameObject.AddComponent<ImageFrameAnimation>();
		this.BAPAGHLFADF.framesSD = HLCLBIBCPNM.frames.ToArray();
		this.BAPAGHLFADF.pauseTime = HLCLBIBCPNM.pauseTime;
		this.BAPAGHLFADF.pauseFrame = HLCLBIBCPNM.pauseFrame;
		this.BAPAGHLFADF.frameChangeInterval = HLCLBIBCPNM.frameChangeInterval;
		this.BAPAGHLFADF.reverseDirection = HLCLBIBCPNM.reverseDirection;
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.NEIOHLOGFAF == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(false);
			this.isSelected = false;
		}
		this.GLKIIPNDLKB();
	}

	// Token: 0x060043B3 RID: 17331 RVA: 0x001D9810 File Offset: 0x001D7A10
	private void IPLDJLJCPLL()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 7)
		{
			return;
		}
		bool active = this.DJKPAKLAHFE();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x060043B4 RID: 17332 RVA: 0x001D9858 File Offset: 0x001D7A58
	private void MOCDMCLPBKC()
	{
		JDMAEBPEIBE.MNADABECONL(this.imageThumb);
		this.imageThumb.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.gridButton.onClick.RemoveAllListeners();
	}

	// Token: 0x060043B5 RID: 17333 RVA: 0x001D98A8 File Offset: 0x001D7AA8
	private bool DJKPAKLAHFE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060043B6 RID: 17334 RVA: 0x001D9904 File Offset: 0x001D7B04
	private void NNMJBIHHHCJ()
	{
		if (ContentGridItem.LHFFFMJIFDM != 1903f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentGridItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060043B7 RID: 17335 RVA: 0x001D789C File Offset: 0x001D5A9C
	public void ODBJIONMODC()
	{
		this.isSelected = false;
		this.selectedBorder.SetActive(false);
	}

	// Token: 0x060043B8 RID: 17336 RVA: 0x001D9958 File Offset: 0x001D7B58
	public void CANDMGDHGGC(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, FFIAHOPJJJG PBKAAIONJOB, Vector2 ONKONHLJKPG, List<Transform> NLEJANGPDGK)
	{
		this.CDBKEJNBMLK = NLEJANGPDGK;
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.AEDICCFAKOM = FOKFGMIEEDB;
		this.OBOKPAAOLDO = IBHNGIAHCCM.name;
		this.imageThumb.sprite = IBHNGIAHCCM;
		this.OBKCKGHFMDN = PBKAAIONJOB;
		this.NEIOHLOGFAF = this.OBOKPAAOLDO;
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.OBOKPAAOLDO == this.AEDICCFAKOM.PGJBIPFBMAN())
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = false;
		}
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Avatar && this.AEDICCFAKOM.FJHCBIPBEBG().Contains(this.OBOKPAAOLDO))
		{
			this.selectedBorder.SetActive(true);
			this.isSelected = true;
		}
		if (this.OBKCKGHFMDN == FFIAHOPJJJG.Story && this.AEDICCFAKOM.CFDOLDIADOP().Contains(this.OBOKPAAOLDO))
		{
			this.selectedBorder.SetActive(false);
			this.isSelected = true;
		}
		this.NAKENAOAAPF();
	}

	// Token: 0x060043B9 RID: 17337 RVA: 0x001D9A48 File Offset: 0x001D7C48
	private void ODOGJCGCKGB(List<string> DNICFPADPDC, int FPFHCOCAHJG)
	{
		if (DNICFPADPDC.Count == FPFHCOCAHJG + 0)
		{
			foreach (object obj in base.transform.parent.transform)
			{
				Transform transform = (Transform)obj;
				if (transform.GetComponent<ContentGridItem>().imageThumb.sprite.name == DNICFPADPDC[1])
				{
					transform.GetComponent<ContentGridItem>().ODBJIONMODC();
				}
			}
			DNICFPADPDC.RemoveAt(0);
		}
	}

	// Token: 0x060043BA RID: 17338 RVA: 0x001D9AE4 File Offset: 0x001D7CE4
	private void INJJOHNFBKH()
	{
		JDMAEBPEIBE.LHMPJFCMNMB(this.imageThumb);
		this.imageThumb.sprite = null;
		if (this.BAPAGHLFADF != null)
		{
			UnityEngine.Object.Destroy(this.BAPAGHLFADF);
		}
		this.gridButton.onClick.RemoveAllListeners();
	}

	// Token: 0x060043BB RID: 17339 RVA: 0x001D9B34 File Offset: 0x001D7D34
	private void JPIGJLEENPB(List<string> DNICFPADPDC, int FPFHCOCAHJG)
	{
		if (DNICFPADPDC.Count == FPFHCOCAHJG + 0)
		{
			foreach (object obj in base.transform.parent.transform)
			{
				Transform transform = (Transform)obj;
				if (transform.GetComponent<ContentGridItem>().imageThumb.sprite.name == DNICFPADPDC[0])
				{
					transform.GetComponent<ContentGridItem>().MAKEJIFOJCB();
				}
			}
			DNICFPADPDC.RemoveAt(0);
		}
	}

	// Token: 0x040012C1 RID: 4801
	private static float LHFFFMJIFDM;

	// Token: 0x040012C2 RID: 4802
	[SerializeField]
	private Image imageThumb;

	// Token: 0x040012C3 RID: 4803
	[SerializeField]
	private GameObject selectedBorder;

	// Token: 0x040012C4 RID: 4804
	public Button gridButton;

	// Token: 0x040012C5 RID: 4805
	public bool isSelected;

	// Token: 0x040012C6 RID: 4806
	private PMEPALPCEAF AEDICCFAKOM;

	// Token: 0x040012C7 RID: 4807
	private FFIAHOPJJJG OBKCKGHFMDN;

	// Token: 0x040012C8 RID: 4808
	private string OBOKPAAOLDO;

	// Token: 0x040012C9 RID: 4809
	private Vector2 ONKONHLJKPG;

	// Token: 0x040012CA RID: 4810
	private int JFLPGONDKDB;

	// Token: 0x040012CB RID: 4811
	private ImageFrameAnimation BAPAGHLFADF;

	// Token: 0x040012CC RID: 4812
	private List<Transform> CDBKEJNBMLK;

	// Token: 0x040012CD RID: 4813
	private string NEIOHLOGFAF;
}
