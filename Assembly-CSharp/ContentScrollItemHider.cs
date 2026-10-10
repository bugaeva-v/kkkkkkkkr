using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001F1 RID: 497
public class ContentScrollItemHider : MonoBehaviour
{
	// Token: 0x06003D66 RID: 15718 RVA: 0x0019500C File Offset: 0x0019320C
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
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003D67 RID: 15719 RVA: 0x00195050 File Offset: 0x00193250
	private bool CENCDHKLKKG()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003D68 RID: 15720 RVA: 0x001950AC File Offset: 0x001932AC
	private void NOJOALDCNJA()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 729f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003D69 RID: 15721 RVA: 0x00195100 File Offset: 0x00193300
	public void OnSetContent(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.CalculateViewportUpDownMargins(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.NDKJNKCLKGN();
	}

	// Token: 0x06003D6A RID: 15722 RVA: 0x00195124 File Offset: 0x00193324
	private void BKLLPIBAGGO()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 2)
		{
			return;
		}
		bool active = this.DFOJBEIIKBI();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003D6B RID: 15723 RVA: 0x00195168 File Offset: 0x00193368
	private void AOGHGIOBGNG()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1511f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06003D6C RID: 15724 RVA: 0x001951BC File Offset: 0x001933BC
	private bool DJKPAKLAHFE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003D6D RID: 15725 RVA: 0x00195218 File Offset: 0x00193418
	private void DNGCBNEPDBM()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1656f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003D6E RID: 15726 RVA: 0x0019526C File Offset: 0x0019346C
	private void DHDDLCPEBIF()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 105f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentScrollItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06003D6F RID: 15727 RVA: 0x001952C0 File Offset: 0x001934C0
	public Vector2 NGGPPPDFCFB(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[5];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06003D70 RID: 15728 RVA: 0x00195300 File Offset: 0x00193500
	private void KNEOGAFILPE()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		bool active = this.OHPLBLMIBFK();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003D71 RID: 15729 RVA: 0x00195344 File Offset: 0x00193544
	private void DEMJHBIGPKA()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1741f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06003D72 RID: 15730 RVA: 0x00195398 File Offset: 0x00193598
	private void IACMMOBHGCK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 2)
		{
			return;
		}
		bool active = this.OHPLBLMIBFK();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003D73 RID: 15731 RVA: 0x001953DC File Offset: 0x001935DC
	public Vector2 BNAAOLIBIDO(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[4];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06003D74 RID: 15732 RVA: 0x0019541C File Offset: 0x0019361C
	private void FNGPHGJMIFG()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1817f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003D75 RID: 15733 RVA: 0x00195470 File Offset: 0x00193670
	public void KIGNOOINKLO(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.BJCEONJONBH(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.JCLOLEBOAIN();
	}

	// Token: 0x06003D76 RID: 15734 RVA: 0x00195494 File Offset: 0x00193694
	public void IAMPILENHLI(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.HFBMOIKCOIK(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.KILHDPCNHDI();
	}

	// Token: 0x06003D77 RID: 15735 RVA: 0x001954B8 File Offset: 0x001936B8
	public Vector2 NLDLNPOJLAB(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[0];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06003D78 RID: 15736 RVA: 0x001954F8 File Offset: 0x001936F8
	private bool HINGPJDKNCM()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003D79 RID: 15737 RVA: 0x00195554 File Offset: 0x00193754
	private void IHMDAFMIHHH()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		bool active = this.GABLFPGCGIN();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003D7B RID: 15739 RVA: 0x00195598 File Offset: 0x00193798
	private void FNBFHLDGEEC()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 681f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003D7C RID: 15740 RVA: 0x001955EC File Offset: 0x001937EC
	private void FOEIHAANBEI()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1107f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentScrollItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06003D7D RID: 15741 RVA: 0x00195640 File Offset: 0x00193840
	public Vector2 IOGAPKGNCJN(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[3];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06003D7E RID: 15742 RVA: 0x00195680 File Offset: 0x00193880
	public void MCPDGNJGICJ(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.NLDLNPOJLAB(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.HNPDAIBKJIO();
	}

	// Token: 0x06003D7F RID: 15743 RVA: 0x001956A4 File Offset: 0x001938A4
	private bool DGPKFAGNHID()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003D80 RID: 15744 RVA: 0x00195700 File Offset: 0x00193900
	private void JCLOLEBOAIN()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 238f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003D81 RID: 15745 RVA: 0x00195754 File Offset: 0x00193954
	public void JHFHDJNKNOK(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.NLDLNPOJLAB(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.HNPDAIBKJIO();
	}

	// Token: 0x06003D82 RID: 15746 RVA: 0x00195778 File Offset: 0x00193978
	private void PIHOFDGILPJ()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		bool active = this.AIFNFHCJFKC();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003D83 RID: 15747 RVA: 0x001957BC File Offset: 0x001939BC
	private void FGMLDGAENED()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		bool active = this.DHHLBOJHMDE();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003D84 RID: 15748 RVA: 0x00195800 File Offset: 0x00193A00
	private void NGEKGIDCIGC()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1008f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003D85 RID: 15749 RVA: 0x00195854 File Offset: 0x00193A54
	public Vector2 BJCEONJONBH(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[7];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[0].y, vector.y);
	}

	// Token: 0x06003D86 RID: 15750 RVA: 0x00195894 File Offset: 0x00193A94
	private void CDGCBAKKPDI()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 3)
		{
			return;
		}
		bool active = this.GCDDKJAJNIC();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003D87 RID: 15751 RVA: 0x001958D8 File Offset: 0x00193AD8
	private void CAONBDOIHMH()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1950f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003D88 RID: 15752 RVA: 0x0019592C File Offset: 0x00193B2C
	private bool DCKINOJFDKC()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003D89 RID: 15753 RVA: 0x00195988 File Offset: 0x00193B88
	public void ENBEPLCBGAB(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.LICMOPGEDPF(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.APHDHGDDHPC();
	}

	// Token: 0x06003D8A RID: 15754 RVA: 0x001959AC File Offset: 0x00193BAC
	private void EIFBOAHPDMC()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1658f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003D8B RID: 15755 RVA: 0x00195A00 File Offset: 0x00193C00
	public Vector2 CalculateViewportUpDownMargins(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[4];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06003D8C RID: 15756 RVA: 0x00195A40 File Offset: 0x00193C40
	public void LJLFLDDNLLO(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.EPCNLKDOAIL(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.PKHDKPHOINF();
	}

	// Token: 0x06003D8D RID: 15757 RVA: 0x00195A64 File Offset: 0x00193C64
	private void BEFIJFGNNNK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		bool active = this.DIDDKKHMACC();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003D8E RID: 15758 RVA: 0x00195AA8 File Offset: 0x00193CA8
	private bool EDAELBKJONL()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003D8F RID: 15759 RVA: 0x00195B04 File Offset: 0x00193D04
	public void PJBIMGCKEOE(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.NODGEJAHKKJ(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.FNGPHGJMIFG();
	}

	// Token: 0x06003D90 RID: 15760 RVA: 0x00195B28 File Offset: 0x00193D28
	private void KENBKMCKIEN()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 616f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003D91 RID: 15761 RVA: 0x00195B7C File Offset: 0x00193D7C
	private void BKNGGJFCHIK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.DIDDKKHMACC();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003D92 RID: 15762 RVA: 0x00195BC0 File Offset: 0x00193DC0
	private void NEHMFMJBBIP()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 897f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003D93 RID: 15763 RVA: 0x00195C14 File Offset: 0x00193E14
	private void NDKJNKCLKGN()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 0f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003D94 RID: 15764 RVA: 0x00195C68 File Offset: 0x00193E68
	private void POJBBACBAAO()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1866f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentScrollItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06003D95 RID: 15765 RVA: 0x00195CBC File Offset: 0x00193EBC
	private bool LPLFPGECHCP()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003D96 RID: 15766 RVA: 0x00195D18 File Offset: 0x00193F18
	private bool GJPNGBJECMB()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003D97 RID: 15767 RVA: 0x00195D74 File Offset: 0x00193F74
	private bool DHHLBOJHMDE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003D98 RID: 15768 RVA: 0x00195DD0 File Offset: 0x00193FD0
	private void INMHGDMNBIC()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1021f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06003D99 RID: 15769 RVA: 0x00195E24 File Offset: 0x00194024
	private void HNPDAIBKJIO()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1452f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003D9A RID: 15770 RVA: 0x00195E78 File Offset: 0x00194078
	public void IDINMHCHHLF(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.FBLFHPGINFP(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.DNGCBNEPDBM();
	}

	// Token: 0x06003D9B RID: 15771 RVA: 0x00195E9C File Offset: 0x0019409C
	private void OKEMACBONAF()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 1)
		{
			return;
		}
		bool active = this.DFOJBEIIKBI();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003D9C RID: 15772 RVA: 0x00195EE0 File Offset: 0x001940E0
	private void GGIAGCLNGDI()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1153f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentScrollItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06003D9D RID: 15773 RVA: 0x00195F34 File Offset: 0x00194134
	public Vector2 NODGEJAHKKJ(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[2];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06003D9E RID: 15774 RVA: 0x00195F74 File Offset: 0x00194174
	private void NJINDDEAIDA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 1)
		{
			return;
		}
		bool active = this.LPLFPGECHCP();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003D9F RID: 15775 RVA: 0x00195FB8 File Offset: 0x001941B8
	public Vector2 IOKFNMAKPKE(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[8];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06003DA0 RID: 15776 RVA: 0x00195FF8 File Offset: 0x001941F8
	public void NNDICCPJOIH(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.CalculateViewportUpDownMargins(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.CBJJGBNDCNI();
	}

	// Token: 0x06003DA1 RID: 15777 RVA: 0x0019601C File Offset: 0x0019421C
	public void PCNKPKDMIGE(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.HFBMOIKCOIK(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.DEMJHBIGPKA();
	}

	// Token: 0x06003DA2 RID: 15778 RVA: 0x00196040 File Offset: 0x00194240
	private void IKPBFJDDALA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 7)
		{
			return;
		}
		bool active = this.CJBPNBLPOIG();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003DA3 RID: 15779 RVA: 0x00196084 File Offset: 0x00194284
	private void FIJDKGJEPGC()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		bool active = this.DIDDKKHMACC();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003DA4 RID: 15780 RVA: 0x001960C8 File Offset: 0x001942C8
	public void CPCFCPJOGIG(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.FBLFHPGINFP(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.POJBBACBAAO();
	}

	// Token: 0x06003DA5 RID: 15781 RVA: 0x001960EC File Offset: 0x001942EC
	public Vector2 LICMOPGEDPF(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[8];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[0].y, vector.y);
	}

	// Token: 0x06003DA6 RID: 15782 RVA: 0x0019612C File Offset: 0x0019432C
	private void LJAOJLFMFAG()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1236f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003DA7 RID: 15783 RVA: 0x00196180 File Offset: 0x00194380
	private void NGGNOMPBPFH()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1023f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003DA8 RID: 15784 RVA: 0x001961D4 File Offset: 0x001943D4
	private void PFANIKAPNLH()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1135f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003DA9 RID: 15785 RVA: 0x00196228 File Offset: 0x00194428
	public Vector2 BGECLHPIMLM(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[4];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06003DAA RID: 15786 RVA: 0x00196268 File Offset: 0x00194468
	private bool GCDDKJAJNIC()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003DAB RID: 15787 RVA: 0x001962C4 File Offset: 0x001944C4
	public Vector2 AGIBPBLADCK(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[2];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06003DAC RID: 15788 RVA: 0x00196304 File Offset: 0x00194504
	public Vector2 HKIDPOGHDKC(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[6];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[0].y, vector.y);
	}

	// Token: 0x06003DAD RID: 15789 RVA: 0x00196344 File Offset: 0x00194544
	public void JPDELALNANK(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.NLDLNPOJLAB(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.GGIAGCLNGDI();
	}

	// Token: 0x06003DAE RID: 15790 RVA: 0x00196368 File Offset: 0x00194568
	private void PAPNIONKJAP()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 1)
		{
			return;
		}
		bool active = this.AIFNFHCJFKC();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003DAF RID: 15791 RVA: 0x001963AC File Offset: 0x001945AC
	private bool GABLFPGCGIN()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003DB0 RID: 15792 RVA: 0x00196408 File Offset: 0x00194608
	private void PKHDKPHOINF()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 994f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003DB1 RID: 15793 RVA: 0x0019645C File Offset: 0x0019465C
	private bool OHPLBLMIBFK()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003DB2 RID: 15794 RVA: 0x001964B8 File Offset: 0x001946B8
	public void FAMLMICLGNF(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.EPCNLKDOAIL(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.NOJOALDCNJA();
	}

	// Token: 0x06003DB3 RID: 15795 RVA: 0x001964DC File Offset: 0x001946DC
	private bool DIDDKKHMACC()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003DB4 RID: 15796 RVA: 0x00196538 File Offset: 0x00194738
	private void IGFOJLEMDAN()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		bool active = this.JIPLIJIAKEJ();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003DB5 RID: 15797 RVA: 0x0019657C File Offset: 0x0019477C
	public Vector2 LGACCNLGPAP(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[7];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[0].y, vector.y);
	}

	// Token: 0x06003DB6 RID: 15798 RVA: 0x001965BC File Offset: 0x001947BC
	public void PFGGKGGIFJO(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.NLDLNPOJLAB(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.KENBKMCKIEN();
	}

	// Token: 0x06003DB7 RID: 15799 RVA: 0x001965E0 File Offset: 0x001947E0
	private bool ADOPPDJOKDI()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003DB8 RID: 15800 RVA: 0x0019663C File Offset: 0x0019483C
	private void GCKCPKPJEIO()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 131f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06003DB9 RID: 15801 RVA: 0x00196690 File Offset: 0x00194890
	public void EAHANMIJNOB(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.OJAIHHFJPEI(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.HNPDAIBKJIO();
	}

	// Token: 0x06003DBA RID: 15802 RVA: 0x001966B4 File Offset: 0x001948B4
	private bool KMANDFDJICG()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003DBB RID: 15803 RVA: 0x00196710 File Offset: 0x00194910
	public Vector2 PENOLLMJKAK(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[5];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06003DBC RID: 15804 RVA: 0x00196750 File Offset: 0x00194950
	public Vector2 FBLFHPGINFP(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[2];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[0].y, vector.y);
	}

	// Token: 0x06003DBD RID: 15805 RVA: 0x00196790 File Offset: 0x00194990
	private bool AIFNFHCJFKC()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003DBE RID: 15806 RVA: 0x001967EC File Offset: 0x001949EC
	private void MAHLIEFJJEE()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 624f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06003DBF RID: 15807 RVA: 0x00196840 File Offset: 0x00194A40
	public Vector2 OJAIHHFJPEI(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[3];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[0].y, vector.y);
	}

	// Token: 0x06003DC0 RID: 15808 RVA: 0x00196880 File Offset: 0x00194A80
	private void KMMEFNOCPOO()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		bool active = this.CJBPNBLPOIG();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003DC1 RID: 15809 RVA: 0x001968C4 File Offset: 0x00194AC4
	private void KILHDPCNHDI()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1116f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003DC2 RID: 15810 RVA: 0x00196918 File Offset: 0x00194B18
	public Vector2 OIENCODPBLF(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[7];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06003DC3 RID: 15811 RVA: 0x00196958 File Offset: 0x00194B58
	private bool JIPLIJIAKEJ()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003DC4 RID: 15812 RVA: 0x001969B4 File Offset: 0x00194BB4
	public void KHLAJNCIKGK(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.NLDLNPOJLAB(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.NGGNOMPBPFH();
	}

	// Token: 0x06003DC5 RID: 15813 RVA: 0x001969D8 File Offset: 0x00194BD8
	public void CNJJDBAPPAD(ScrollRect CHMDIFAGMAG)
	{
		Vector2 onkonhljkpg = this.IOGAPKGNCJN(CHMDIFAGMAG);
		this.ONKONHLJKPG = onkonhljkpg;
		this.HNPDAIBKJIO();
	}

	// Token: 0x06003DC6 RID: 15814 RVA: 0x001969FC File Offset: 0x00194BFC
	private bool DFOJBEIIKBI()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06003DC7 RID: 15815 RVA: 0x00196A58 File Offset: 0x00194C58
	public Vector2 HFBMOIKCOIK(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[3];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[0].y, vector.y);
	}

	// Token: 0x06003DC8 RID: 15816 RVA: 0x00196A98 File Offset: 0x00194C98
	private void LFBPHHOPPBO()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		bool active = this.EDAELBKJONL();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003DC9 RID: 15817 RVA: 0x00196ADC File Offset: 0x00194CDC
	private void OBIEMFIHIKK()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1234f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentScrollItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06003DCA RID: 15818 RVA: 0x00196B30 File Offset: 0x00194D30
	private void FDECKMDNEKO()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		bool active = this.AIFNFHCJFKC();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003DCB RID: 15819 RVA: 0x00196B74 File Offset: 0x00194D74
	public Vector2 IIIBOCOHNGI(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[4];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[1];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06003DCC RID: 15820 RVA: 0x00196BB4 File Offset: 0x00194DB4
	private void CBJJGBNDCNI()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1673f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentScrollItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06003DCD RID: 15821 RVA: 0x00196C08 File Offset: 0x00194E08
	private void APHDHGDDHPC()
	{
		if (ContentScrollItemHider.LHFFFMJIFDM != 1042f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentScrollItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06003DCE RID: 15822 RVA: 0x00196C5C File Offset: 0x00194E5C
	private void FKOPCAFJEKE()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		bool active = this.GJPNGBJECMB();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003DCF RID: 15823 RVA: 0x00196CA0 File Offset: 0x00194EA0
	private void KPCLFGJLNJF()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 5)
		{
			return;
		}
		bool active = this.DGPKFAGNHID();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06003DD0 RID: 15824 RVA: 0x00196CE4 File Offset: 0x00194EE4
	public Vector2 EPCNLKDOAIL(ScrollRect CHMDIFAGMAG)
	{
		RectTransform viewport = CHMDIFAGMAG.viewport;
		Vector3[] array = new Vector3[3];
		viewport.GetWorldCorners(array);
		Vector3 vector = array[0];
		return new Vector2(array[1].y, vector.y);
	}

	// Token: 0x06003DD1 RID: 15825 RVA: 0x00196D24 File Offset: 0x00194F24
	private bool CJBPNBLPOIG()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentScrollItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentScrollItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x04001184 RID: 4484
	private static float LHFFFMJIFDM;

	// Token: 0x04001185 RID: 4485
	private Vector2 ONKONHLJKPG;

	// Token: 0x04001186 RID: 4486
	private int JFLPGONDKDB;

	// Token: 0x04001187 RID: 4487
	public GameObject containerToHide;
}
