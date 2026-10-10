using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000277 RID: 631
public class ContentAnthologyAchievementGridItem : MonoBehaviour
{
	// Token: 0x06004D55 RID: 19797 RVA: 0x00226110 File Offset: 0x00224310
	private void MKMLEFGAEMM()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		bool active = this.ELJHGMNEPAC();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004D56 RID: 19798 RVA: 0x00226158 File Offset: 0x00224358
	public void SetContent(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.dark)
				{
					this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.NDKJNKCLKGN();
	}

	// Token: 0x06004D57 RID: 19799 RVA: 0x002261FC File Offset: 0x002243FC
	private bool DNKCHLBEGHO()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D58 RID: 19800 RVA: 0x00226258 File Offset: 0x00224458
	private void KJNLBAEHLEI()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 2)
		{
			return;
		}
		bool active = this.OMLAJCPEFMM();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004D59 RID: 19801 RVA: 0x002262A0 File Offset: 0x002244A0
	private void GKBKDDGBAGK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 1)
		{
			return;
		}
		bool active = this.GHGCFEKOGND();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004D5A RID: 19802 RVA: 0x002262E8 File Offset: 0x002244E8
	private void DMEEIPBHABJ()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 1936f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06004D5B RID: 19803 RVA: 0x0022633C File Offset: 0x0022453C
	public void DEFHMDCPDDD(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.dark)
				{
					this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.GHHPDGPMHNC();
	}

	// Token: 0x06004D5C RID: 19804 RVA: 0x002263E0 File Offset: 0x002245E0
	private void LFBPHHOPPBO()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 1)
		{
			return;
		}
		bool active = this.KJHFGKEPGIP();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004D5D RID: 19805 RVA: 0x00226428 File Offset: 0x00224628
	private bool DJKPAKLAHFE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D5E RID: 19806 RVA: 0x00226484 File Offset: 0x00224684
	public void MFKDPFEGKMG(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.bright)
				{
					this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.NPJMKNFIDPI();
	}

	// Token: 0x06004D5F RID: 19807 RVA: 0x00226528 File Offset: 0x00224728
	private void ILLMKMLEHMI()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		bool active = this.DNKCHLBEGHO();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004D60 RID: 19808 RVA: 0x00226570 File Offset: 0x00224770
	public void COCLEMFDEHK(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.bright)
				{
					this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.DMEEIPBHABJ();
	}

	// Token: 0x06004D61 RID: 19809 RVA: 0x00226614 File Offset: 0x00224814
	private bool HHEIHHAJBKM()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D62 RID: 19810 RVA: 0x00226670 File Offset: 0x00224870
	private void LJAOJLFMFAG()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 1604f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06004D63 RID: 19811 RVA: 0x002266C4 File Offset: 0x002248C4
	private void CJHFPCNEHGB()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.JANOOJMKHCG();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004D64 RID: 19812 RVA: 0x0022670C File Offset: 0x0022490C
	private void BKFCGNCKFEC()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		bool active = this.DGPKFAGNHID();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004D65 RID: 19813 RVA: 0x00226754 File Offset: 0x00224954
	private bool JANOOJMKHCG()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D66 RID: 19814 RVA: 0x002267B0 File Offset: 0x002249B0
	private void IKPBFJDDALA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		bool active = this.GHGCFEKOGND();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004D67 RID: 19815 RVA: 0x002267F8 File Offset: 0x002249F8
	private bool NJHIKNHGHHH()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D68 RID: 19816 RVA: 0x00226854 File Offset: 0x00224A54
	private bool HINGPJDKNCM()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D69 RID: 19817 RVA: 0x002268B0 File Offset: 0x00224AB0
	private void NMEEMBCCKHA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 2)
		{
			return;
		}
		bool active = this.NJHIKNHGHHH();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004D6A RID: 19818 RVA: 0x002268F8 File Offset: 0x00224AF8
	private void DEMJHBIGPKA()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 872f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06004D6C RID: 19820 RVA: 0x0022694C File Offset: 0x00224B4C
	private void NAKENAOAAPF()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 1301f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06004D6D RID: 19821 RVA: 0x002269A0 File Offset: 0x00224BA0
	private bool DGPKFAGNHID()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D6E RID: 19822 RVA: 0x002269FC File Offset: 0x00224BFC
	private void KPCLFGJLNJF()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		bool active = this.KJHFGKEPGIP();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004D6F RID: 19823 RVA: 0x00226A44 File Offset: 0x00224C44
	private void GHHPDGPMHNC()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 1164f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06004D70 RID: 19824 RVA: 0x00226A98 File Offset: 0x00224C98
	private bool LCOEGMGECCD()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D71 RID: 19825 RVA: 0x00226AF4 File Offset: 0x00224CF4
	private void NPJMKNFIDPI()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 919f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06004D72 RID: 19826 RVA: 0x00226B48 File Offset: 0x00224D48
	public void KABPKMCFAIH(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.dark)
				{
					this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.NPJMKNFIDPI();
	}

	// Token: 0x06004D73 RID: 19827 RVA: 0x00226BEC File Offset: 0x00224DEC
	private void NDKJNKCLKGN()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 0f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06004D74 RID: 19828 RVA: 0x00226C40 File Offset: 0x00224E40
	public void HDDNBODLFEN(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.dark)
				{
					this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.HJJNEACAIMF();
	}

	// Token: 0x06004D75 RID: 19829 RVA: 0x00226CE4 File Offset: 0x00224EE4
	public void IOPLLLDIKMP(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.bright)
				{
					this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.PFANIKAPNLH();
	}

	// Token: 0x06004D76 RID: 19830 RVA: 0x00226D88 File Offset: 0x00224F88
	public void MFHJBGBCAFA(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.dark)
				{
					this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.NPJMKNFIDPI();
	}

	// Token: 0x06004D77 RID: 19831 RVA: 0x00226E2C File Offset: 0x0022502C
	private void FCAMNIPFPJB()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 77f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06004D78 RID: 19832 RVA: 0x00226E80 File Offset: 0x00225080
	private void BAMCDABLKAI()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 828f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06004D79 RID: 19833 RVA: 0x00226ED4 File Offset: 0x002250D4
	private void EEHHDMJADIB()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 51f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06004D7A RID: 19834 RVA: 0x00226F28 File Offset: 0x00225128
	private void OJLOFBGGHML()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 1215f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06004D7B RID: 19835 RVA: 0x00226F7C File Offset: 0x0022517C
	public void LHKLJOIGDBE(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.bright)
				{
					this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.DMEEIPBHABJ();
	}

	// Token: 0x06004D7C RID: 19836 RVA: 0x00227020 File Offset: 0x00225220
	private bool OIDMIDKBHBB()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D7D RID: 19837 RVA: 0x0022707C File Offset: 0x0022527C
	private void BKPNFPNKHOI()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 196f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06004D7E RID: 19838 RVA: 0x002270D0 File Offset: 0x002252D0
	private void MBLMILBOKID()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 1767f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06004D7F RID: 19839 RVA: 0x00227124 File Offset: 0x00225324
	private bool KJHFGKEPGIP()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D80 RID: 19840 RVA: 0x00227180 File Offset: 0x00225380
	private void CBCJABBJFAN()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 7)
		{
			return;
		}
		bool active = this.JANOOJMKHCG();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004D81 RID: 19841 RVA: 0x002271C8 File Offset: 0x002253C8
	private bool ELJHGMNEPAC()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D82 RID: 19842 RVA: 0x00227224 File Offset: 0x00225424
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

	// Token: 0x06004D83 RID: 19843 RVA: 0x0022726C File Offset: 0x0022546C
	public void GLFPBCIMPOF(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.bright)
				{
					this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.LJAOOKDAABI();
	}

	// Token: 0x06004D84 RID: 19844 RVA: 0x00227310 File Offset: 0x00225510
	private bool CJBPNBLPOIG()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D85 RID: 19845 RVA: 0x0022736C File Offset: 0x0022556C
	public void DAFPJHCHLMH(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.dark)
				{
					this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.BAMCDABLKAI();
	}

	// Token: 0x06004D86 RID: 19846 RVA: 0x00227410 File Offset: 0x00225610
	private void HJJNEACAIMF()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 1896f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06004D87 RID: 19847 RVA: 0x00227464 File Offset: 0x00225664
	public void IPLLLKMPAHE(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.PINBMHFHEHD();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.dark)
				{
					this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[1];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.NPJMKNFIDPI();
	}

	// Token: 0x06004D88 RID: 19848 RVA: 0x00227508 File Offset: 0x00225708
	private void LJAOOKDAABI()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 886f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06004D89 RID: 19849 RVA: 0x0022755C File Offset: 0x0022575C
	private void OFEFHGNPCPE()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 7)
		{
			return;
		}
		bool active = this.NJHIKNHGHHH();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004D8A RID: 19850 RVA: 0x002275A4 File Offset: 0x002257A4
	public void FFMBAGFFCLH(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.bright)
				{
					this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[1];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.BAMCDABLKAI();
	}

	// Token: 0x06004D8B RID: 19851 RVA: 0x00227648 File Offset: 0x00225848
	private void EBDLBINPKGD()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 880f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06004D8C RID: 19852 RVA: 0x0022769C File Offset: 0x0022589C
	public void KDDKBEBCLMI(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.ICEOGOCOMJL();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.bright)
				{
					this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.EEHHDMJADIB();
	}

	// Token: 0x06004D8D RID: 19853 RVA: 0x00227740 File Offset: 0x00225940
	private void PFANIKAPNLH()
	{
		if (ContentAnthologyAchievementGridItem.LHFFFMJIFDM != 660f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentAnthologyAchievementGridItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06004D8E RID: 19854 RVA: 0x00227794 File Offset: 0x00225994
	private bool OMLAJCPEFMM()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D8F RID: 19855 RVA: 0x002277F0 File Offset: 0x002259F0
	private void DNCGCGGCJNE()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 5)
		{
			return;
		}
		bool active = this.KJHFGKEPGIP();
		this.gridButton.gameObject.SetActive(active);
	}

	// Token: 0x06004D90 RID: 19856 RVA: 0x00227838 File Offset: 0x00225A38
	private bool GHGCFEKOGND()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentAnthologyAchievementGridItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentAnthologyAchievementGridItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06004D91 RID: 19857 RVA: 0x00227894 File Offset: 0x00225A94
	public void GGNPLGJNJBA(PMEPALPCEAF FOKFGMIEEDB, Sprite IBHNGIAHCCM, Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.profile = FOKFGMIEEDB;
		this.spriteName = IBHNGIAHCCM.name;
		if (!this.profile.HBELJGFJILO(this.spriteName))
		{
			HGCFJKCOKPM hgcfjkcokpm = AKLFPGMDKLA.EHBBFMCILPC.JKCEGIPAANK();
			if (hgcfjkcokpm != HGCFJKCOKPM.bright)
			{
				if (hgcfjkcokpm == HGCFJKCOKPM.bright)
				{
					this.imageThumb.sprite = AssetsManager.EHBBFMCILPC.lobbyDataAsset.achievementLockedSprites[0];
				}
			}
			else
			{
				this.imageThumb.sprite = AssetsManager.MJBDMHPHMID().lobbyDataAsset.achievementLockedSprites[0];
			}
		}
		else
		{
			this.imageThumb.sprite = IBHNGIAHCCM;
		}
		this.EBDLBINPKGD();
	}

	// Token: 0x04001642 RID: 5698
	private static float LHFFFMJIFDM;

	// Token: 0x04001643 RID: 5699
	public Button gridButton;

	// Token: 0x04001644 RID: 5700
	public Image imageThumb;

	// Token: 0x04001645 RID: 5701
	public PMEPALPCEAF profile;

	// Token: 0x04001646 RID: 5702
	public string spriteName;

	// Token: 0x04001647 RID: 5703
	private Vector2 ONKONHLJKPG;

	// Token: 0x04001648 RID: 5704
	private int JFLPGONDKDB;
}
