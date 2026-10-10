using System;
using UnityEngine;

// Token: 0x0200050E RID: 1294
public class EnvCaptureBlit : MonoBehaviour
{
	// Token: 0x06009C2A RID: 39978 RVA: 0x0043586E File Offset: 0x00433A6E
	public void LBJEDDCMKNB()
	{
		this.LHKGLALJLBD = null;
		base.enabled = true;
	}

	// Token: 0x06009C2B RID: 39979 RVA: 0x0043587E File Offset: 0x00433A7E
	private void LDDEIAOCBGB()
	{
		base.enabled = true;
	}

	// Token: 0x06009C2C RID: 39980 RVA: 0x00435887 File Offset: 0x00433A87
	public void MIKIHKHECPG(RenderTexture JFKDEMMNEGP)
	{
		this.LHKGLALJLBD = JFKDEMMNEGP;
		this.DCBGGBAGFJP = false;
		base.enabled = true;
	}

	// Token: 0x06009C2D RID: 39981 RVA: 0x0043589E File Offset: 0x00433A9E
	private void CDHHGBKGGDG()
	{
		base.enabled = false;
	}

	// Token: 0x06009C2E RID: 39982 RVA: 0x0043586E File Offset: 0x00433A6E
	public void FGAMEJOLOGE()
	{
		this.LHKGLALJLBD = null;
		base.enabled = true;
	}

	// Token: 0x06009C2F RID: 39983 RVA: 0x0043589E File Offset: 0x00433A9E
	private void Awake()
	{
		base.enabled = false;
	}

	// Token: 0x06009C30 RID: 39984 RVA: 0x0043587E File Offset: 0x00433A7E
	private void GNHDCIGPFOH()
	{
		base.enabled = true;
	}

	// Token: 0x06009C32 RID: 39986 RVA: 0x0043587E File Offset: 0x00433A7E
	private void FNDDKLJKFEK()
	{
		base.enabled = true;
	}

	// Token: 0x06009C33 RID: 39987 RVA: 0x004358A7 File Offset: 0x00433AA7
	public void IOPHLELBIOB()
	{
		this.LHKGLALJLBD = null;
		base.enabled = false;
	}

	// Token: 0x06009C34 RID: 39988 RVA: 0x004358B8 File Offset: 0x00433AB8
	private void FBMGHEAMPCE(RenderTexture CCIAGBPILGF, RenderTexture AABGCONAGAC)
	{
		Graphics.Blit(CCIAGBPILGF, AABGCONAGAC);
		if (null != this.LHKGLALJLBD)
		{
			try
			{
				Graphics.Blit(CCIAGBPILGF, this.LHKGLALJLBD);
				this.DCBGGBAGFJP = false;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			this.LHKGLALJLBD = null;
			base.enabled = false;
		}
	}

	// Token: 0x06009C35 RID: 39989 RVA: 0x00435914 File Offset: 0x00433B14
	private void OnRenderImage(RenderTexture CCIAGBPILGF, RenderTexture AABGCONAGAC)
	{
		Graphics.Blit(CCIAGBPILGF, AABGCONAGAC);
		if (null != this.LHKGLALJLBD)
		{
			try
			{
				Graphics.Blit(CCIAGBPILGF, this.LHKGLALJLBD);
				this.DCBGGBAGFJP = true;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.LHKGLALJLBD = null;
			base.enabled = false;
		}
	}

	// Token: 0x06009C36 RID: 39990 RVA: 0x00435887 File Offset: 0x00433A87
	public void Arm(RenderTexture JFKDEMMNEGP)
	{
		this.LHKGLALJLBD = JFKDEMMNEGP;
		this.DCBGGBAGFJP = false;
		base.enabled = true;
	}

	// Token: 0x06009C37 RID: 39991 RVA: 0x00435970 File Offset: 0x00433B70
	public bool CaptureDone()
	{
		return this.DCBGGBAGFJP;
	}

	// Token: 0x06009C38 RID: 39992 RVA: 0x004358A7 File Offset: 0x00433AA7
	public void Disarm()
	{
		this.LHKGLALJLBD = null;
		base.enabled = false;
	}

	// Token: 0x06009C39 RID: 39993 RVA: 0x00435970 File Offset: 0x00433B70
	public bool HNKHJBNEMIB()
	{
		return this.DCBGGBAGFJP;
	}

	// Token: 0x06009C3A RID: 39994 RVA: 0x00435978 File Offset: 0x00433B78
	private void BNOBBMCJDNH(RenderTexture CCIAGBPILGF, RenderTexture AABGCONAGAC)
	{
		Graphics.Blit(CCIAGBPILGF, AABGCONAGAC);
		if (null != this.LHKGLALJLBD)
		{
			try
			{
				Graphics.Blit(CCIAGBPILGF, this.LHKGLALJLBD);
				this.DCBGGBAGFJP = false;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.LHKGLALJLBD = null;
			base.enabled = true;
		}
	}

	// Token: 0x06009C3B RID: 39995 RVA: 0x0043587E File Offset: 0x00433A7E
	private void EKEOFMOJCGF()
	{
		base.enabled = true;
	}

	// Token: 0x06009C3C RID: 39996 RVA: 0x0043586E File Offset: 0x00433A6E
	public void DBCANDLNDBG()
	{
		this.LHKGLALJLBD = null;
		base.enabled = true;
	}

	// Token: 0x06009C3D RID: 39997 RVA: 0x0043587E File Offset: 0x00433A7E
	private void LBDIDHDKHGO()
	{
		base.enabled = true;
	}

	// Token: 0x06009C3E RID: 39998 RVA: 0x0043587E File Offset: 0x00433A7E
	private void ALIKHOFAKKB()
	{
		base.enabled = true;
	}

	// Token: 0x06009C3F RID: 39999 RVA: 0x004359D4 File Offset: 0x00433BD4
	private void LPOODHHOEIF(RenderTexture CCIAGBPILGF, RenderTexture AABGCONAGAC)
	{
		Graphics.Blit(CCIAGBPILGF, AABGCONAGAC);
		if (null != this.LHKGLALJLBD)
		{
			try
			{
				Graphics.Blit(CCIAGBPILGF, this.LHKGLALJLBD);
				this.DCBGGBAGFJP = true;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
			this.LHKGLALJLBD = null;
			base.enabled = false;
		}
	}

	// Token: 0x06009C40 RID: 40000 RVA: 0x00435A30 File Offset: 0x00433C30
	private void BHEGLJNBAMP(RenderTexture CCIAGBPILGF, RenderTexture AABGCONAGAC)
	{
		Graphics.Blit(CCIAGBPILGF, AABGCONAGAC);
		if (null != this.LHKGLALJLBD)
		{
			try
			{
				Graphics.Blit(CCIAGBPILGF, this.LHKGLALJLBD);
				this.DCBGGBAGFJP = false;
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
			this.LHKGLALJLBD = null;
			base.enabled = false;
		}
	}

	// Token: 0x04002B59 RID: 11097
	private RenderTexture LHKGLALJLBD;

	// Token: 0x04002B5A RID: 11098
	private bool DCBGGBAGFJP;
}
