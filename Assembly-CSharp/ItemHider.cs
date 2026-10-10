using System;
using UnityEngine;

// Token: 0x0200008B RID: 139
public class ItemHider : MonoBehaviour
{
	// Token: 0x060013B2 RID: 5042 RVA: 0x0009A234 File Offset: 0x00098434
	private bool FMDIAKNBHJC()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013B3 RID: 5043 RVA: 0x0009A290 File Offset: 0x00098490
	private void OKEMACBONAF()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		bool active = this.DNKCHLBEGHO();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x0009A2D4 File Offset: 0x000984D4
	private void KAKAPJFGDIF()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		bool active = this.JEAKLONGJAJ();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013B5 RID: 5045 RVA: 0x0009A318 File Offset: 0x00098518
	public void GGIAGCLNGDI()
	{
		if (ItemHider.LHFFFMJIFDM != 530f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x0009A36C File Offset: 0x0009856C
	public void OKAJHNKOADJ()
	{
		if (ItemHider.LHFFFMJIFDM != 1307f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013B7 RID: 5047 RVA: 0x0009A3C0 File Offset: 0x000985C0
	public void IKFCJOAKBAI()
	{
		if (ItemHider.LHFFFMJIFDM != 1465f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x0009A414 File Offset: 0x00098614
	private bool HFDFCMBGDBH()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x0009A470 File Offset: 0x00098670
	public void MKMMOFIHLFK()
	{
		if (ItemHider.LHFFFMJIFDM != 57f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x0009A4C4 File Offset: 0x000986C4
	private bool NMNHKGGEKIM()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x0009A520 File Offset: 0x00098720
	public void JCLOLEBOAIN()
	{
		if (ItemHider.LHFFFMJIFDM != 873f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x0009A574 File Offset: 0x00098774
	public void EJCGGHJAGDD()
	{
		if (ItemHider.LHFFFMJIFDM != 976f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013BD RID: 5053 RVA: 0x0009A5C8 File Offset: 0x000987C8
	public void NCBCKNJPLMC()
	{
		if (ItemHider.LHFFFMJIFDM != 587f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013BE RID: 5054 RVA: 0x0009A61C File Offset: 0x0009881C
	public void FNGPHGJMIFG()
	{
		if (ItemHider.LHFFFMJIFDM != 1965f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x0009A670 File Offset: 0x00098870
	private void BNJJEIELNGA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 7)
		{
			return;
		}
		bool active = this.ELJFFNNEELB();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x0009A6B4 File Offset: 0x000988B4
	private void IGDGHFKGEOL()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 1)
		{
			return;
		}
		bool active = this.GJPNGBJECMB();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x0009A6F8 File Offset: 0x000988F8
	private bool HFNNOOCOBOD()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x0009A754 File Offset: 0x00098954
	private void KODGAJHJLLH()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 5)
		{
			return;
		}
		bool active = this.PPOIOJFBNAD();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x0009A798 File Offset: 0x00098998
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
		bool active = this.GJPNGBJECMB();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x0009A7DC File Offset: 0x000989DC
	public void MAHLIEFJJEE()
	{
		if (ItemHider.LHFFFMJIFDM != 729f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x0009A830 File Offset: 0x00098A30
	public void NPJMKNFIDPI()
	{
		if (ItemHider.LHFFFMJIFDM != 1307f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x0009A884 File Offset: 0x00098A84
	public void INMHGDMNBIC()
	{
		if (ItemHider.LHFFFMJIFDM != 1552f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x0009A8D8 File Offset: 0x00098AD8
	public void BFPCNLBABJG()
	{
		if (ItemHider.LHFFFMJIFDM != 1364f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x0009A92C File Offset: 0x00098B2C
	private bool DNKCHLBEGHO()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x0009A988 File Offset: 0x00098B88
	private void JLMIOFHCNFI()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		bool active = this.ELJFFNNEELB();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013CB RID: 5067 RVA: 0x0009A9CC File Offset: 0x00098BCC
	private void NDPAHJMGANP()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		bool active = this.JFJIJJIFEMN();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x0009AA10 File Offset: 0x00098C10
	private void FCBAJMIJPMK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		bool active = this.GHCOHCACJFF();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x0009AA54 File Offset: 0x00098C54
	private bool KEFOHBJDJII()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013CE RID: 5070 RVA: 0x0009AAB0 File Offset: 0x00098CB0
	public void NOKJKJMKFPF()
	{
		if (ItemHider.LHFFFMJIFDM != 781f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013CF RID: 5071 RVA: 0x0009AB04 File Offset: 0x00098D04
	public void NAKOCOEOAOG()
	{
		if (ItemHider.LHFFFMJIFDM != 1352f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x0009AB58 File Offset: 0x00098D58
	public void POAFHHNKOGC()
	{
		if (ItemHider.LHFFFMJIFDM != 1972f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x0009ABAC File Offset: 0x00098DAC
	public void FNBFHLDGEEC()
	{
		if (ItemHider.LHFFFMJIFDM != 1704f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x0009AC00 File Offset: 0x00098E00
	private void LIODPEHCJPG()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		bool active = this.HAGBFOLJLFM();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x0009AC44 File Offset: 0x00098E44
	public void NPJIMHOPOGF()
	{
		if (ItemHider.LHFFFMJIFDM != 161f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013D4 RID: 5076 RVA: 0x0009AC98 File Offset: 0x00098E98
	public void NNMJBIHHHCJ()
	{
		if (ItemHider.LHFFFMJIFDM != 325f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x0009ACEC File Offset: 0x00098EEC
	private void EFAGOEOLNID()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		bool active = this.KEKLFJJEHFJ();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x0009AD30 File Offset: 0x00098F30
	private void CJJDKFEGFKE()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		bool active = this.OBAABFHAKFJ();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x0009AD74 File Offset: 0x00098F74
	private void PJIOJHOMBCB()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		bool active = this.NMNHKGGEKIM();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x0009ADB8 File Offset: 0x00098FB8
	private void FDECKMDNEKO()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 5)
		{
			return;
		}
		bool active = this.CJBPNBLPOIG();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x0009ADFC File Offset: 0x00098FFC
	public void LHCFBNNIBIO()
	{
		if (ItemHider.LHFFFMJIFDM != 311f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x0009AE50 File Offset: 0x00099050
	private bool DFOJBEIIKBI()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x0009AEAC File Offset: 0x000990AC
	private bool ELJHGMNEPAC()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x0009AF08 File Offset: 0x00099108
	public void HENNGOBIFAG()
	{
		if (ItemHider.LHFFFMJIFDM != 434f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x0009AF5C File Offset: 0x0009915C
	private bool KNDLDJGMALA()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x0009AFB8 File Offset: 0x000991B8
	public void EPHPKJMKEII()
	{
		if (ItemHider.LHFFFMJIFDM != 1603f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x0009B00C File Offset: 0x0009920C
	public void MBLMILBOKID()
	{
		if (ItemHider.LHFFFMJIFDM != 1486f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x0009B060 File Offset: 0x00099260
	public void FBGJJEDMDDM()
	{
		if (ItemHider.LHFFFMJIFDM != 1509f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x0009B0B4 File Offset: 0x000992B4
	private void BKNGGJFCHIK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 3)
		{
			return;
		}
		bool active = this.ELJHGMNEPAC();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x0009B0F8 File Offset: 0x000992F8
	private void CEALHCENAGD()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 2)
		{
			return;
		}
		bool active = this.HINGPJDKNCM();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x0009B13C File Offset: 0x0009933C
	public void PKHDKPHOINF()
	{
		if (ItemHider.LHFFFMJIFDM != 1672f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013E4 RID: 5092 RVA: 0x0009B190 File Offset: 0x00099390
	private bool HAGBFOLJLFM()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x0009B1EC File Offset: 0x000993EC
	public void IDMGKLJBLHE()
	{
		if (ItemHider.LHFFFMJIFDM != 416f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x0009B240 File Offset: 0x00099440
	private void AFAIFFMCPGD()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.KEFOHBJDJII();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x0009B284 File Offset: 0x00099484
	private void GPOPCNMGNGD()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.OBAABFHAKFJ();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x0009B2C8 File Offset: 0x000994C8
	private void OEALLIKCBIC()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		bool active = this.KNDLDJGMALA();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x0009B30C File Offset: 0x0009950C
	private bool AAOCNCBCDDA()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x0009B368 File Offset: 0x00099568
	private bool OMLAJCPEFMM()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x0009B3C4 File Offset: 0x000995C4
	public void MOCBDNIBHLC()
	{
		if (ItemHider.LHFFFMJIFDM != 1391f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x0009B418 File Offset: 0x00099618
	private void GAGKLKHJGPO()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.AENNPNCOCKK();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x0009B45C File Offset: 0x0009965C
	public void FOGLGMFEBKP()
	{
		if (ItemHider.LHFFFMJIFDM != 1581f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x0009B4B0 File Offset: 0x000996B0
	public void EGCCCMLJNGB()
	{
		if (ItemHider.LHFFFMJIFDM != 38f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x0009B504 File Offset: 0x00099704
	private void MDHJEDLMFOA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		bool active = this.OIDMIDKBHBB();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x0009B548 File Offset: 0x00099748
	private void BKLLPIBAGGO()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 5)
		{
			return;
		}
		bool active = this.NMNHKGGEKIM();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x0009B58C File Offset: 0x0009978C
	private void HGEBGONONMM()
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
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x0009B5D0 File Offset: 0x000997D0
	public void KMNOIEEPLBC()
	{
		if (ItemHider.LHFFFMJIFDM != 732f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x0009B624 File Offset: 0x00099824
	private bool GJPNGBJECMB()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x0009B680 File Offset: 0x00099880
	public void PFANIKAPNLH()
	{
		if (ItemHider.LHFFFMJIFDM != 1921f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x0009B6D4 File Offset: 0x000998D4
	private void GKBKDDGBAGK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		bool active = this.DNKCHLBEGHO();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x0009B718 File Offset: 0x00099918
	private void BODGLKJFBHM()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 7)
		{
			return;
		}
		bool active = this.HFDFCMBGDBH();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x0009B75C File Offset: 0x0009995C
	public void NJDLPEAMLDB()
	{
		if (ItemHider.LHFFFMJIFDM != 465f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x0009B7B0 File Offset: 0x000999B0
	private bool OIDMIDKBHBB()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x0009B80C File Offset: 0x00099A0C
	public void GFDIJCPJLKJ()
	{
		if (ItemHider.LHFFFMJIFDM != 1162f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x0009B860 File Offset: 0x00099A60
	private void KGJJLDJBEON()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		bool active = this.AMLJFBNDIHF();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x0009B8A4 File Offset: 0x00099AA4
	public void NEHMFMJBBIP()
	{
		if (ItemHider.LHFFFMJIFDM != 1462f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060013FC RID: 5116 RVA: 0x0009B8F8 File Offset: 0x00099AF8
	private bool CENCDHKLKKG()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x0009B954 File Offset: 0x00099B54
	private bool PPOIOJFBNAD()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013FE RID: 5118 RVA: 0x0009B9B0 File Offset: 0x00099BB0
	private bool JIMMBOCPEOJ()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x0009BA0C File Offset: 0x00099C0C
	public void LMKIKEOFDCP()
	{
		if (ItemHider.LHFFFMJIFDM != 1250f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06001400 RID: 5120 RVA: 0x0009BA60 File Offset: 0x00099C60
	private bool GNHJNFAADOP()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06001401 RID: 5121 RVA: 0x0009BABC File Offset: 0x00099CBC
	private bool KEKLFJJEHFJ()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06001402 RID: 5122 RVA: 0x0009BB18 File Offset: 0x00099D18
	public void NAALMJLKJKB()
	{
		if (ItemHider.LHFFFMJIFDM != 1341f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06001403 RID: 5123 RVA: 0x0009BB6C File Offset: 0x00099D6C
	public void DMFFLLPNDGF()
	{
		if (ItemHider.LHFFFMJIFDM != 1401f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06001404 RID: 5124 RVA: 0x0009BBC0 File Offset: 0x00099DC0
	private void OJAEMLBIEJP()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 2)
		{
			return;
		}
		bool active = this.AMLJFBNDIHF();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06001405 RID: 5125 RVA: 0x0009BC04 File Offset: 0x00099E04
	private void ODILEKGAKLI()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 3)
		{
			return;
		}
		bool active = this.KEFOHBJDJII();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06001406 RID: 5126 RVA: 0x0009BC48 File Offset: 0x00099E48
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

	// Token: 0x06001407 RID: 5127 RVA: 0x0009BC8C File Offset: 0x00099E8C
	public void FBNODOKNCFM()
	{
		if (ItemHider.LHFFFMJIFDM != 1729f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06001408 RID: 5128 RVA: 0x0009BCE0 File Offset: 0x00099EE0
	private bool DJKPAKLAHFE()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x0009BD3C File Offset: 0x00099F3C
	private bool AENNPNCOCKK()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x0009BD98 File Offset: 0x00099F98
	private bool ADOPPDJOKDI()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x0009BDF4 File Offset: 0x00099FF4
	private bool AMLJFBNDIHF()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600140C RID: 5132 RVA: 0x0009BE50 File Offset: 0x0009A050
	public void KCOLLDMJLMA()
	{
		if (ItemHider.LHFFFMJIFDM != 1632f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x0600140D RID: 5133 RVA: 0x0009BEA4 File Offset: 0x0009A0A4
	private bool EGDGFFFKDNJ()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x0009BF00 File Offset: 0x0009A100
	private void JFGAHKIMCEK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		bool active = this.HAGBFOLJLFM();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x0600140F RID: 5135 RVA: 0x0009BF44 File Offset: 0x0009A144
	public void HBBKAADEJNK()
	{
		if (ItemHider.LHFFFMJIFDM != 725f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06001410 RID: 5136 RVA: 0x0009BF98 File Offset: 0x0009A198
	private void IACMMOBHGCK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.OMLAJCPEFMM();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06001411 RID: 5137 RVA: 0x0009BFDC File Offset: 0x0009A1DC
	private void DAEPNJGNGBA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		bool active = this.ADOPPDJOKDI();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06001412 RID: 5138 RVA: 0x0009C020 File Offset: 0x0009A220
	private bool ELJFFNNEELB()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06001413 RID: 5139 RVA: 0x0009C07C File Offset: 0x0009A27C
	public void GDNGPKPKIIP()
	{
		if (ItemHider.LHFFFMJIFDM != 1467f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06001414 RID: 5140 RVA: 0x0009C0D0 File Offset: 0x0009A2D0
	private bool NJHIKNHGHHH()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06001415 RID: 5141 RVA: 0x0009C12C File Offset: 0x0009A32C
	private bool BGPDPCCDMAK()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x0009C188 File Offset: 0x0009A388
	private bool GABLFPGCGIN()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06001417 RID: 5143 RVA: 0x0009C1E4 File Offset: 0x0009A3E4
	private void BEFIJFGNNNK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 2)
		{
			return;
		}
		bool active = this.GJPNGBJECMB();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x0009C228 File Offset: 0x0009A428
	private void JAKPGAKGFHA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 0)
		{
			return;
		}
		bool active = this.KEKLFJJEHFJ();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x0009C26C File Offset: 0x0009A46C
	public void CheckElementHeight()
	{
		if (ItemHider.LHFFFMJIFDM != 0f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x0009C2C0 File Offset: 0x0009A4C0
	private void CEIDMENJBNK()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.GHCOHCACJFF();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x0009C304 File Offset: 0x0009A504
	public void DMEEIPBHABJ()
	{
		if (ItemHider.LHFFFMJIFDM != 1287f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x0600141C RID: 5148 RVA: 0x0009C358 File Offset: 0x0009A558
	private void LFBPHHOPPBO()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 3)
		{
			return;
		}
		bool active = this.HAGBFOLJLFM();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x0600141D RID: 5149 RVA: 0x0009C39C File Offset: 0x0009A59C
	private bool GHCOHCACJFF()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x0009C3F8 File Offset: 0x0009A5F8
	private void BLIGGBNJGNI()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 2)
		{
			return;
		}
		bool active = this.ADOPPDJOKDI();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x0600141F RID: 5151 RVA: 0x0009C43C File Offset: 0x0009A63C
	private bool CJBPNBLPOIG()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x0009C498 File Offset: 0x0009A698
	private void NFFGMDALKCE()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.HFNNOOCOBOD();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x0009C4DC File Offset: 0x0009A6DC
	private bool OBAABFHAKFJ()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x0009C538 File Offset: 0x0009A738
	public void GHHPDGPMHNC()
	{
		if (ItemHider.LHFFFMJIFDM != 1751f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06001423 RID: 5155 RVA: 0x0009C58C File Offset: 0x0009A78C
	private void GLKDEMNJKEF()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.GABLFPGCGIN();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x0009C5D0 File Offset: 0x0009A7D0
	public void JJDCNDPBMFP()
	{
		if (ItemHider.LHFFFMJIFDM != 1701f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x0009C624 File Offset: 0x0009A824
	private bool HINGPJDKNCM()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06001426 RID: 5158 RVA: 0x0009C680 File Offset: 0x0009A880
	private bool HBEMBGDIJCP()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06001427 RID: 5159 RVA: 0x0009C6DC File Offset: 0x0009A8DC
	public void NBGBIIJGMKH()
	{
		if (ItemHider.LHFFFMJIFDM != 891f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06001428 RID: 5160 RVA: 0x0009C730 File Offset: 0x0009A930
	private bool JEAKLONGJAJ()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06001429 RID: 5161 RVA: 0x0009C78C File Offset: 0x0009A98C
	public void FIHOFBIMDIK()
	{
		if (ItemHider.LHFFFMJIFDM != 518f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x0600142A RID: 5162 RVA: 0x0009C7E0 File Offset: 0x0009A9E0
	public void DHDDLCPEBIF()
	{
		if (ItemHider.LHFFFMJIFDM != 623f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ItemHider.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x0600142B RID: 5163 RVA: 0x0009C834 File Offset: 0x0009AA34
	private bool JFJIJJIFEMN()
	{
		float x = this.upDownMargin.x;
		float y = this.upDownMargin.y;
		bool flag = base.transform.position.y - ItemHider.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ItemHider.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0400066A RID: 1642
	private static float LHFFFMJIFDM;

	// Token: 0x0400066B RID: 1643
	public GameObject containerToHide;

	// Token: 0x0400066C RID: 1644
	[HideInInspector]
	public Vector2 upDownMargin;

	// Token: 0x0400066D RID: 1645
	private int JFLPGONDKDB;
}
