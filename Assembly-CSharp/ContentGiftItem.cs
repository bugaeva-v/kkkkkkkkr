using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000294 RID: 660
public class ContentGiftItem : MonoBehaviour
{
	// Token: 0x060052E6 RID: 21222 RVA: 0x002475D5 File Offset: 0x002457D5
	public void LODCMECOHCI(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.FNJBFDJLLMF();
	}

	// Token: 0x060052E7 RID: 21223 RVA: 0x002475E4 File Offset: 0x002457E4
	private void DHDLGFAACND()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 1100f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentGiftItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060052E8 RID: 21224 RVA: 0x00247638 File Offset: 0x00245838
	private bool KCLMDFPFBHC()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060052E9 RID: 21225 RVA: 0x00247694 File Offset: 0x00245894
	private bool DJKPAKLAHFE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060052EA RID: 21226 RVA: 0x002476F0 File Offset: 0x002458F0
	private bool OALENANEECF()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060052EB RID: 21227 RVA: 0x0024774C File Offset: 0x0024594C
	private void FOEIHAANBEI()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 11f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentGiftItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060052EC RID: 21228 RVA: 0x002477A0 File Offset: 0x002459A0
	private void KJNLBAEHLEI()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 8)
		{
			return;
		}
		bool active = this.PGAJLCNNJPD();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060052ED RID: 21229 RVA: 0x002477E4 File Offset: 0x002459E4
	private bool FNFKAKCADOJ()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060052EE RID: 21230 RVA: 0x00247840 File Offset: 0x00245A40
	private void OFEFHGNPCPE()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		bool active = this.HFNFHLCOIFA();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060052EF RID: 21231 RVA: 0x00247883 File Offset: 0x00245A83
	public void KDDLHGMIPBF(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.DHDLGFAACND();
	}

	// Token: 0x060052F0 RID: 21232 RVA: 0x00247894 File Offset: 0x00245A94
	private void BIMCNGLLIOC()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.BLELCOBBKFN();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060052F1 RID: 21233 RVA: 0x002478D8 File Offset: 0x00245AD8
	private void GPHOBCEMEMN()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 3)
		{
			return;
		}
		bool active = this.DPHIBCKFBAN();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060052F2 RID: 21234 RVA: 0x0024791C File Offset: 0x00245B1C
	private void CONJNNGBLOB()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 5)
		{
			return;
		}
		bool active = this.FNFKAKCADOJ();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x060052F3 RID: 21235 RVA: 0x00247960 File Offset: 0x00245B60
	private bool PLFLCHLCEHE()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060052F4 RID: 21236 RVA: 0x002479BC File Offset: 0x00245BBC
	private void EGJLAHPEAGG()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 1880f)
		{
			return;
		}
		Vector3[] array = new Vector3[0];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentGiftItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060052F5 RID: 21237 RVA: 0x00247A10 File Offset: 0x00245C10
	private void EBDLBINPKGD()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 1550f)
		{
			return;
		}
		Vector3[] array = new Vector3[6];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentGiftItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060052F6 RID: 21238 RVA: 0x00247A64 File Offset: 0x00245C64
	private void FDAFABPIBMP()
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

	// Token: 0x060052F7 RID: 21239 RVA: 0x00247AA7 File Offset: 0x00245CA7
	public void GIONKOFHDED(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.ENGJEOEMNHA();
	}

	// Token: 0x060052F8 RID: 21240 RVA: 0x00247AB8 File Offset: 0x00245CB8
	private bool EDAELBKJONL()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060052F9 RID: 21241 RVA: 0x00247B14 File Offset: 0x00245D14
	private void JCLOLEBOAIN()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 691f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentGiftItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x060052FA RID: 21242 RVA: 0x00247B66 File Offset: 0x00245D66
	public void LFJADOIGPPL(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NDKJNKCLKGN();
	}

	// Token: 0x060052FB RID: 21243 RVA: 0x00247B78 File Offset: 0x00245D78
	private bool EHKPLFFAMHG()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060052FC RID: 21244 RVA: 0x00247BD4 File Offset: 0x00245DD4
	private bool EPHBNBENKJI()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x060052FD RID: 21245 RVA: 0x00247C30 File Offset: 0x00245E30
	private void KENDFFKLLBP()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 1579f)
		{
			return;
		}
		Vector3[] array = new Vector3[8];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentGiftItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x060052FE RID: 21246 RVA: 0x00247B66 File Offset: 0x00245D66
	public void SetContent(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NDKJNKCLKGN();
	}

	// Token: 0x060052FF RID: 21247 RVA: 0x00247C84 File Offset: 0x00245E84
	private void FNJBFDJLLMF()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 1574f)
		{
			return;
		}
		Vector3[] array = new Vector3[2];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentGiftItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06005300 RID: 21248 RVA: 0x00247B66 File Offset: 0x00245D66
	public void BNOBDONHIGG(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NDKJNKCLKGN();
	}

	// Token: 0x06005301 RID: 21249 RVA: 0x002475D5 File Offset: 0x002457D5
	public void KCIKGOCKPKB(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.FNJBFDJLLMF();
	}

	// Token: 0x06005302 RID: 21250 RVA: 0x00247CD8 File Offset: 0x00245ED8
	private void AADMBDFACAJ()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 3)
		{
			return;
		}
		bool active = this.DPHIBCKFBAN();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06005303 RID: 21251 RVA: 0x00247D1C File Offset: 0x00245F1C
	private bool LPLFPGECHCP()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06005304 RID: 21252 RVA: 0x00247D76 File Offset: 0x00245F76
	public void KDDKBEBCLMI(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.JNIDPJAELLH();
	}

	// Token: 0x06005305 RID: 21253 RVA: 0x00247D88 File Offset: 0x00245F88
	private bool JIMMBOCPEOJ()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06005306 RID: 21254 RVA: 0x00247DE4 File Offset: 0x00245FE4
	private void NDKJNKCLKGN()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 0f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentGiftItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06005307 RID: 21255 RVA: 0x00247E38 File Offset: 0x00246038
	private void MFOIOHCLMFK()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 1752f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentGiftItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06005308 RID: 21256 RVA: 0x00247E8C File Offset: 0x0024608C
	private bool DGJEKKLKMMN()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06005309 RID: 21257 RVA: 0x00247EE8 File Offset: 0x002460E8
	private void KGJJLDJBEON()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 2)
		{
			return;
		}
		bool active = this.FNFKAKCADOJ();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x0600530A RID: 21258 RVA: 0x00247F2C File Offset: 0x0024612C
	private void EMHDMMPMDJC()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 3)
		{
			return;
		}
		bool active = this.HFNFHLCOIFA();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x0600530B RID: 21259 RVA: 0x00247F6F File Offset: 0x0024616F
	public void BGIJEOHAPPF(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.DEMJHBIGPKA();
	}

	// Token: 0x0600530C RID: 21260 RVA: 0x00247883 File Offset: 0x00245A83
	public void DEFHMDCPDDD(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.DHDLGFAACND();
	}

	// Token: 0x0600530D RID: 21261 RVA: 0x00247F80 File Offset: 0x00246180
	private bool OPKBEHPEHPC()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600530E RID: 21262 RVA: 0x00247FDA File Offset: 0x002461DA
	public void CANDMGDHGGC(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.KENDFFKLLBP();
	}

	// Token: 0x0600530F RID: 21263 RVA: 0x00247FEC File Offset: 0x002461EC
	private void JNIDPJAELLH()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 1824f)
		{
			return;
		}
		Vector3[] array = new Vector3[3];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentGiftItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06005310 RID: 21264 RVA: 0x0024803E File Offset: 0x0024623E
	public void LHHFFLOPLOH(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.GJOKABDPIOI();
	}

	// Token: 0x06005311 RID: 21265 RVA: 0x0024804D File Offset: 0x0024624D
	public void FCCPIJKPKLH(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.GHHPDGPMHNC();
	}

	// Token: 0x06005312 RID: 21266 RVA: 0x0024805C File Offset: 0x0024625C
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
		bool active = this.KCLMDFPFBHC();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06005313 RID: 21267 RVA: 0x0024803E File Offset: 0x0024623E
	public void LPHKGBIIDGM(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.GJOKABDPIOI();
	}

	// Token: 0x06005314 RID: 21268 RVA: 0x002480A0 File Offset: 0x002462A0
	private void AFAIFFMCPGD()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		bool active = this.KCLMDFPFBHC();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06005315 RID: 21269 RVA: 0x002480E4 File Offset: 0x002462E4
	private void KNBBPNKLFAA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 6)
		{
			return;
		}
		bool active = this.ELJHGMNEPAC();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06005316 RID: 21270 RVA: 0x00248128 File Offset: 0x00246328
	private void IKPBFJDDALA()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 4)
		{
			return;
		}
		bool active = this.LPLFPGECHCP();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06005317 RID: 21271 RVA: 0x00247F6F File Offset: 0x0024616F
	public void CHHCPMCHNEH(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.DEMJHBIGPKA();
	}

	// Token: 0x06005318 RID: 21272 RVA: 0x0024816C File Offset: 0x0024636C
	private bool HFNFHLCOIFA()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06005319 RID: 21273 RVA: 0x002481C6 File Offset: 0x002463C6
	public void NILDDCFCEGK(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.EGJLAHPEAGG();
	}

	// Token: 0x0600531A RID: 21274 RVA: 0x002481D8 File Offset: 0x002463D8
	private void BLIGGBNJGNI()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 3)
		{
			return;
		}
		bool active = this.DGJEKKLKMMN();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x0600531B RID: 21275 RVA: 0x0024821C File Offset: 0x0024641C
	private void GHHPDGPMHNC()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 1683f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentGiftItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x0600531C RID: 21276 RVA: 0x00248270 File Offset: 0x00246470
	private bool PGAJLCNNJPD()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600531D RID: 21277 RVA: 0x00247B66 File Offset: 0x00245D66
	public void HGGFKAJMJHC(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.NDKJNKCLKGN();
	}

	// Token: 0x0600531E RID: 21278 RVA: 0x002482CC File Offset: 0x002464CC
	private void ENGJEOEMNHA()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 912f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentGiftItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x0600531F RID: 21279 RVA: 0x00248320 File Offset: 0x00246520
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

	// Token: 0x06005320 RID: 21280 RVA: 0x00248364 File Offset: 0x00246564
	private void ILLMKMLEHMI()
	{
		if (this.JFLPGONDKDB == 0)
		{
			this.JFLPGONDKDB = Time.frameCount;
		}
		if (Time.frameCount - this.JFLPGONDKDB < 7)
		{
			return;
		}
		bool active = this.ELJHGMNEPAC();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06005321 RID: 21281 RVA: 0x002483A8 File Offset: 0x002465A8
	private void APHDHGDDHPC()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 1636f)
		{
			return;
		}
		Vector3[] array = new Vector3[4];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentGiftItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06005322 RID: 21282 RVA: 0x002483FA File Offset: 0x002465FA
	public void HHBAMGNJFLO(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.FOEIHAANBEI();
	}

	// Token: 0x06005323 RID: 21283 RVA: 0x0024840C File Offset: 0x0024660C
	private bool GHGCFEKOGND()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06005324 RID: 21284 RVA: 0x00248468 File Offset: 0x00246668
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
		bool active = this.PGAJLCNNJPD();
		this.containerToHide.SetActive(active);
	}

	// Token: 0x06005325 RID: 21285 RVA: 0x002484AC File Offset: 0x002466AC
	private void EEECNELBDFB()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 1275f)
		{
			return;
		}
		Vector3[] array = new Vector3[7];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentGiftItem.LHFFFMJIFDM = array[1].y - vector.y;
	}

	// Token: 0x06005326 RID: 21286 RVA: 0x0024803E File Offset: 0x0024623E
	public void CBGIDNBIBAP(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.GJOKABDPIOI();
	}

	// Token: 0x06005327 RID: 21287 RVA: 0x00248500 File Offset: 0x00246700
	private void GJOKABDPIOI()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 1659f)
		{
			return;
		}
		Vector3[] array = new Vector3[1];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[1];
		ContentGiftItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x06005328 RID: 21288 RVA: 0x00248554 File Offset: 0x00246754
	private bool ELJHGMNEPAC()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x06005329 RID: 21289 RVA: 0x002485B0 File Offset: 0x002467B0
	private bool BLELCOBBKFN()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600532A RID: 21290 RVA: 0x0024860C File Offset: 0x0024680C
	private void DEMJHBIGPKA()
	{
		if (ContentGiftItem.LHFFFMJIFDM != 620f)
		{
			return;
		}
		Vector3[] array = new Vector3[5];
		((RectTransform)base.transform).GetWorldCorners(array);
		Vector3 vector = array[0];
		ContentGiftItem.LHFFFMJIFDM = array[0].y - vector.y;
	}

	// Token: 0x0600532C RID: 21292 RVA: 0x00248660 File Offset: 0x00246860
	private bool JBBFIMJCIIM()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x0600532D RID: 21293 RVA: 0x002483FA File Offset: 0x002465FA
	public void MHJMGGPKNBE(Vector2 ONKONHLJKPG)
	{
		this.ONKONHLJKPG = ONKONHLJKPG;
		this.FOEIHAANBEI();
	}

	// Token: 0x0600532E RID: 21294 RVA: 0x002486BC File Offset: 0x002468BC
	private bool DPHIBCKFBAN()
	{
		float x = this.ONKONHLJKPG.x;
		float y = this.ONKONHLJKPG.y;
		bool flag = base.transform.position.y - ContentGiftItem.LHFFFMJIFDM < x;
		bool flag2 = base.transform.position.y + ContentGiftItem.LHFFFMJIFDM > y;
		return flag && flag2;
	}

	// Token: 0x04001732 RID: 5938
	private static float LHFFFMJIFDM;

	// Token: 0x04001733 RID: 5939
	public Button showGiftButton;

	// Token: 0x04001734 RID: 5940
	[SerializeField]
	private GameObject containerToHide;

	// Token: 0x04001735 RID: 5941
	private Vector2 ONKONHLJKPG;

	// Token: 0x04001736 RID: 5942
	private int JFLPGONDKDB;
}
