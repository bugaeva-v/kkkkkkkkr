using System;
using Kino;
using UnityEngine;
using VideoGlitches;

// Token: 0x020004E9 RID: 1257
public class ImageEffectsSelectorOvr : MonoBehaviour
{
	// Token: 0x060097B0 RID: 38832 RVA: 0x004210A8 File Offset: 0x0041F2A8
	public void PGIDFAOMMCA(string JCFOOJCGKMO = "")
	{
		this.ADEFNANLAOF();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.FGIDLGIPKGG();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097B1 RID: 38833 RVA: 0x0042123C File Offset: 0x0041F43C
	public void EJBEHPOAPIN()
	{
		this.HONNHIIOMBN();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.MMNEKIKMGKI();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097B2 RID: 38834 RVA: 0x00421360 File Offset: 0x0041F560
	public void LNFLDPBCICC()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.MFGOHBMBCOO();
			}
		}
	}

	// Token: 0x060097B3 RID: 38835 RVA: 0x00421418 File Offset: 0x0041F618
	public void JPLHPBCNNNG(string JCFOOJCGKMO = "")
	{
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = true;
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = true;
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = true;
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = true;
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = false;
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = false;
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = false;
		}
	}

	// Token: 0x060097B4 RID: 38836 RVA: 0x00421565 File Offset: 0x0041F765
	private void LOACLFMGICF()
	{
		this.DFBLCAHODLN();
	}

	// Token: 0x060097B5 RID: 38837 RVA: 0x0042156D File Offset: 0x0041F76D
	private void DFEDGLDNOBH()
	{
		this.MGELCGPHEJP();
	}

	// Token: 0x060097B6 RID: 38838 RVA: 0x00421578 File Offset: 0x0041F778
	public void HONNHIIOMBN()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.DLHAMCJIEHI();
			}
		}
	}

	// Token: 0x060097B7 RID: 38839 RVA: 0x0042162D File Offset: 0x0041F82D
	private void OPPNHGEMHAB()
	{
		this.FJPCKENLAEE();
	}

	// Token: 0x060097B8 RID: 38840 RVA: 0x00421638 File Offset: 0x0041F838
	public void GJPHIPKCLMO(string JCFOOJCGKMO = "")
	{
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = true;
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = true;
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = false;
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = false;
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = false;
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = true;
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = true;
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x060097B9 RID: 38841 RVA: 0x00421788 File Offset: 0x0041F988
	public void JGDOPEIGNON(string JCFOOJCGKMO = "")
	{
		this.KECIFMLNOKP();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.NJPGEPBFMMK();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097BA RID: 38842 RVA: 0x0042191C File Offset: 0x0041FB1C
	public void MKNKJHOFPDD()
	{
		this.MGELCGPHEJP();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.MMNEKIKMGKI();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097BB RID: 38843 RVA: 0x00421A40 File Offset: 0x0041FC40
	public void DAEBFLOCPLF()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.DAEHECNAGMD();
			}
		}
	}

	// Token: 0x060097BC RID: 38844 RVA: 0x00421AF8 File Offset: 0x0041FCF8
	public void AHEIBMFBMDJ(string JCFOOJCGKMO = "")
	{
		this.DMPLHAEKBFK();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.NJPGEPBFMMK();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097BD RID: 38845 RVA: 0x00421C8C File Offset: 0x0041FE8C
	public void LMDBOOODDEK(string JCFOOJCGKMO = "")
	{
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = false;
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = true;
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = false;
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = true;
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = true;
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = true;
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x060097BE RID: 38846 RVA: 0x00421DDC File Offset: 0x0041FFDC
	public void ShowAllEffects()
	{
		this.AwakeEffects();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.JJIAJCCLPMM();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097BF RID: 38847 RVA: 0x00421F00 File Offset: 0x00420100
	public void GBGHPJBFMGH()
	{
		this.JADFENJPAKL();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.HIFIFJGKHMB();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097C0 RID: 38848 RVA: 0x00422021 File Offset: 0x00420221
	private void KFDAOONHJND()
	{
		this.ADEFNANLAOF();
	}

	// Token: 0x060097C1 RID: 38849 RVA: 0x00422029 File Offset: 0x00420229
	private void ILBAMCJFAAP()
	{
		this.BLMOFINNDCD();
	}

	// Token: 0x060097C2 RID: 38850 RVA: 0x00422034 File Offset: 0x00420234
	public void CGJINHCNPCA(string JCFOOJCGKMO = "")
	{
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = false;
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = false;
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = true;
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = false;
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = true;
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = false;
		}
	}

	// Token: 0x060097C3 RID: 38851 RVA: 0x00422181 File Offset: 0x00420381
	private void MHIHCHGGIDM()
	{
		this.HONNHIIOMBN();
	}

	// Token: 0x060097C4 RID: 38852 RVA: 0x00422189 File Offset: 0x00420389
	private void DJDLHIOMGJB()
	{
		this.DJANBAPBGLD();
	}

	// Token: 0x060097C5 RID: 38853 RVA: 0x00422194 File Offset: 0x00420394
	public void JLLGLBHDFHI()
	{
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = true;
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = true;
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = true;
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = true;
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = false;
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x060097C6 RID: 38854 RVA: 0x0042156D File Offset: 0x0041F76D
	private void PABMEBKPBJO()
	{
		this.MGELCGPHEJP();
	}

	// Token: 0x060097C7 RID: 38855 RVA: 0x00422271 File Offset: 0x00420471
	private void Start()
	{
		this.AwakeEffects();
	}

	// Token: 0x060097C8 RID: 38856 RVA: 0x00422279 File Offset: 0x00420479
	private void IGLMKDPEKNF()
	{
		this.DMPLHAEKBFK();
	}

	// Token: 0x060097C9 RID: 38857 RVA: 0x00422271 File Offset: 0x00420471
	private void Awake()
	{
		this.AwakeEffects();
	}

	// Token: 0x060097CA RID: 38858 RVA: 0x00422284 File Offset: 0x00420484
	public void ACPJKKBGLKJ(string JCFOOJCGKMO = "")
	{
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = false;
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = true;
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = true;
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = true;
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = false;
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x060097CB RID: 38859 RVA: 0x00422181 File Offset: 0x00420381
	private void DJLCHMAHJLG()
	{
		this.HONNHIIOMBN();
	}

	// Token: 0x060097CC RID: 38860 RVA: 0x004223D4 File Offset: 0x004205D4
	public void AwakeEffects()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.ShowAllEffects();
			}
		}
	}

	// Token: 0x060097CD RID: 38861 RVA: 0x0042162D File Offset: 0x0041F82D
	private void OOHKGEPBDIG()
	{
		this.FJPCKENLAEE();
	}

	// Token: 0x060097CE RID: 38862 RVA: 0x00422181 File Offset: 0x00420381
	private void CKKAKPFCPEG()
	{
		this.HONNHIIOMBN();
	}

	// Token: 0x060097CF RID: 38863 RVA: 0x00422489 File Offset: 0x00420689
	private void HLCCOGFOMHA()
	{
		this.DKANJKJMPNM();
	}

	// Token: 0x060097D0 RID: 38864 RVA: 0x00422494 File Offset: 0x00420694
	public void ICEEGBGIMOE()
	{
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = true;
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = true;
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = false;
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = true;
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = false;
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = false;
		}
	}

	// Token: 0x060097D1 RID: 38865 RVA: 0x00422574 File Offset: 0x00420774
	public void ICBMLNJNCHD(string JCFOOJCGKMO = "")
	{
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = true;
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = true;
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = false;
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = true;
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = true;
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = true;
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x060097D2 RID: 38866 RVA: 0x00422029 File Offset: 0x00420229
	private void EDFAPEMNFCH()
	{
		this.BLMOFINNDCD();
	}

	// Token: 0x060097D3 RID: 38867 RVA: 0x004226C4 File Offset: 0x004208C4
	public void DAEHECNAGMD()
	{
		this.DJANBAPBGLD();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.NJPGEPBFMMK();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097D4 RID: 38868 RVA: 0x004227E8 File Offset: 0x004209E8
	public void BDNONHBOENN()
	{
		this.DFBLCAHODLN();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.FGIDLGIPKGG();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097D5 RID: 38869 RVA: 0x00422909 File Offset: 0x00420B09
	private void ALOEGNGEFMM()
	{
		this.KECIFMLNOKP();
	}

	// Token: 0x060097D6 RID: 38870 RVA: 0x0042162D File Offset: 0x0041F82D
	private void KBGOLEGBMAP()
	{
		this.FJPCKENLAEE();
	}

	// Token: 0x060097D7 RID: 38871 RVA: 0x00422914 File Offset: 0x00420B14
	public void LCAPPCBDMOG()
	{
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = true;
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = true;
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = true;
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = false;
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = true;
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = false;
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x060097D8 RID: 38872 RVA: 0x004229F4 File Offset: 0x00420BF4
	public void KHBLJJLHIOM()
	{
		this.DMPLHAEKBFK();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.NJPGEPBFMMK();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097D9 RID: 38873 RVA: 0x00422B18 File Offset: 0x00420D18
	public void BAINLMGOHIE()
	{
		this.MGELCGPHEJP();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.FGIDLGIPKGG();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097DA RID: 38874 RVA: 0x00422909 File Offset: 0x00420B09
	private void NPFILNGGHGH()
	{
		this.KECIFMLNOKP();
	}

	// Token: 0x060097DB RID: 38875 RVA: 0x00422C3C File Offset: 0x00420E3C
	public void JBDEPPEAKEA(string JCFOOJCGKMO = "")
	{
		this.LNFLDPBCICC();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.JJIAJCCLPMM();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097DC RID: 38876 RVA: 0x00422DCD File Offset: 0x00420FCD
	private void HBLDAPMPKAB()
	{
		this.PGKJPGGOMHP();
	}

	// Token: 0x060097DD RID: 38877 RVA: 0x00422DD8 File Offset: 0x00420FD8
	public void JADFENJPAKL()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.AKIEOGHOOOP();
			}
		}
	}

	// Token: 0x060097DF RID: 38879 RVA: 0x00422F62 File Offset: 0x00421162
	private void AMNBHDNALGO()
	{
		this.DAEBFLOCPLF();
	}

	// Token: 0x060097E0 RID: 38880 RVA: 0x00422F6C File Offset: 0x0042116C
	public void CJEBOJCJAGN(string JCFOOJCGKMO = "")
	{
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = true;
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = false;
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = true;
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = true;
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = true;
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = true;
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x060097E1 RID: 38881 RVA: 0x004230BC File Offset: 0x004212BC
	public void LHBBHFCGDDG(string JCFOOJCGKMO = "")
	{
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = true;
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = false;
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = true;
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = true;
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = false;
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = true;
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = true;
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x060097E2 RID: 38882 RVA: 0x0042320C File Offset: 0x0042140C
	public void PHFIOBNKDAG(string JCFOOJCGKMO = "")
	{
		this.HONNHIIOMBN();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.FGIDLGIPKGG();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097E3 RID: 38883 RVA: 0x004233A0 File Offset: 0x004215A0
	public void BLMOFINNDCD()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.KHBLJJLHIOM();
			}
		}
	}

	// Token: 0x060097E4 RID: 38884 RVA: 0x00423458 File Offset: 0x00421658
	public void IPBMLMODJNF(string JCFOOJCGKMO = "")
	{
		this.HONNHIIOMBN();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.JJIAJCCLPMM();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097E5 RID: 38885 RVA: 0x004235EC File Offset: 0x004217EC
	public void FJPCKENLAEE()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = false;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.HCOCLEDFCAA();
			}
		}
	}

	// Token: 0x060097E6 RID: 38886 RVA: 0x004236A4 File Offset: 0x004218A4
	public void DKANJKJMPNM()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.KHBLJJLHIOM();
			}
		}
	}

	// Token: 0x060097E7 RID: 38887 RVA: 0x00423759 File Offset: 0x00421959
	private void EIMLAEEOBPD()
	{
		this.LNFLDPBCICC();
	}

	// Token: 0x060097E8 RID: 38888 RVA: 0x00423764 File Offset: 0x00421964
	public void DMPLHAEKBFK()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.ShowAllEffects();
			}
		}
	}

	// Token: 0x060097E9 RID: 38889 RVA: 0x00422271 File Offset: 0x00420471
	private void FMGJGMNOCMP()
	{
		this.AwakeEffects();
	}

	// Token: 0x060097EA RID: 38890 RVA: 0x0042156D File Offset: 0x0041F76D
	private void MNDPPAMNECC()
	{
		this.MGELCGPHEJP();
	}

	// Token: 0x060097EB RID: 38891 RVA: 0x0042381C File Offset: 0x00421A1C
	public void DLHAMCJIEHI()
	{
		this.AwakeEffects();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.JJIAJCCLPMM();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097EC RID: 38892 RVA: 0x00423940 File Offset: 0x00421B40
	public void ADEFNANLAOF()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.AKIEOGHOOOP();
			}
		}
	}

	// Token: 0x060097ED RID: 38893 RVA: 0x004239F8 File Offset: 0x00421BF8
	public void JJOFJDLLCNA(string JCFOOJCGKMO = "")
	{
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = true;
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = true;
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = false;
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = true;
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = false;
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = true;
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = false;
		}
	}

	// Token: 0x060097EE RID: 38894 RVA: 0x00423B48 File Offset: 0x00421D48
	public void PKLBJOHACAO(string JCFOOJCGKMO = "")
	{
		this.HONNHIIOMBN();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.FGIDLGIPKGG();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097EF RID: 38895 RVA: 0x00421565 File Offset: 0x0041F765
	private void KDLMMHEAPNH()
	{
		this.DFBLCAHODLN();
	}

	// Token: 0x060097F0 RID: 38896 RVA: 0x00423CDC File Offset: 0x00421EDC
	public void NGIMALKOOIH()
	{
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = true;
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = false;
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = true;
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = false;
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = false;
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = true;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = false;
		}
	}

	// Token: 0x060097F1 RID: 38897 RVA: 0x00422279 File Offset: 0x00420479
	private void GIOOKMFKLIO()
	{
		this.DMPLHAEKBFK();
	}

	// Token: 0x060097F2 RID: 38898 RVA: 0x0042156D File Offset: 0x0041F76D
	private void FNDDKLJKFEK()
	{
		this.MGELCGPHEJP();
	}

	// Token: 0x060097F3 RID: 38899 RVA: 0x00421565 File Offset: 0x0041F765
	private void AMAKEBJMCLG()
	{
		this.DFBLCAHODLN();
	}

	// Token: 0x060097F4 RID: 38900 RVA: 0x00423DBC File Offset: 0x00421FBC
	public void MFGOHBMBCOO()
	{
		this.AwakeEffects();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.JJIAJCCLPMM();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097F5 RID: 38901 RVA: 0x00422181 File Offset: 0x00420381
	private void FIGJOFLIKKI()
	{
		this.HONNHIIOMBN();
	}

	// Token: 0x060097F6 RID: 38902 RVA: 0x00423EE0 File Offset: 0x004220E0
	public void FBPCKAMLDAI(string JCFOOJCGKMO = "")
	{
		this.DKANJKJMPNM();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.LFEOGELABLI();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097F7 RID: 38903 RVA: 0x00424074 File Offset: 0x00422274
	public void KECIFMLNOKP()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = false;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.PILBCAENEMD();
			}
		}
	}

	// Token: 0x060097F8 RID: 38904 RVA: 0x00422489 File Offset: 0x00420689
	private void FNNKDFGKAEH()
	{
		this.DKANJKJMPNM();
	}

	// Token: 0x060097F9 RID: 38905 RVA: 0x0042412C File Offset: 0x0042232C
	public void ADABKPACKCJ(string JCFOOJCGKMO = "")
	{
		this.MGELCGPHEJP();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.FGIDLGIPKGG();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x060097FA RID: 38906 RVA: 0x004242C0 File Offset: 0x004224C0
	public void HideAllEffects()
	{
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = false;
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = false;
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = false;
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = false;
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = false;
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = false;
		}
	}

	// Token: 0x060097FB RID: 38907 RVA: 0x00423759 File Offset: 0x00421959
	private void HKMCOGEMFNH()
	{
		this.LNFLDPBCICC();
	}

	// Token: 0x060097FC RID: 38908 RVA: 0x00422DCD File Offset: 0x00420FCD
	private void LCCCCHNJEMB()
	{
		this.PGKJPGGOMHP();
	}

	// Token: 0x060097FD RID: 38909 RVA: 0x00422279 File Offset: 0x00420479
	private void IMCHEPFNANC()
	{
		this.DMPLHAEKBFK();
	}

	// Token: 0x060097FE RID: 38910 RVA: 0x00422DCD File Offset: 0x00420FCD
	private void MFFEIHJPAMF()
	{
		this.PGKJPGGOMHP();
	}

	// Token: 0x060097FF RID: 38911 RVA: 0x004243A0 File Offset: 0x004225A0
	public void GJNPOJGBIIK()
	{
		this.DAEBFLOCPLF();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.LFEOGELABLI();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x06009800 RID: 38912 RVA: 0x004244C4 File Offset: 0x004226C4
	public void PILBCAENEMD()
	{
		this.DFBLCAHODLN();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.MMNEKIKMGKI();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x06009801 RID: 38913 RVA: 0x00422F62 File Offset: 0x00421162
	private void COMPLLBGJPB()
	{
		this.DAEBFLOCPLF();
	}

	// Token: 0x06009802 RID: 38914 RVA: 0x004245E8 File Offset: 0x004227E8
	public void ONKCBCEMLBO(string JCFOOJCGKMO = "")
	{
		this.LNFLDPBCICC();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.NJPGEPBFMMK();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x06009803 RID: 38915 RVA: 0x0042162D File Offset: 0x0041F82D
	private void ECDLFGCLAGG()
	{
		this.FJPCKENLAEE();
	}

	// Token: 0x06009804 RID: 38916 RVA: 0x0042477C File Offset: 0x0042297C
	public void GGHEPJGCBJI()
	{
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = true;
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = true;
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = false;
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = true;
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = true;
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = true;
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = true;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x06009805 RID: 38917 RVA: 0x0042485C File Offset: 0x00422A5C
	public void HideAllEffectsWithTag(string JCFOOJCGKMO = "")
	{
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = false;
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = false;
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = false;
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = false;
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = false;
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = false;
		}
	}

	// Token: 0x06009806 RID: 38918 RVA: 0x00422489 File Offset: 0x00420689
	private void HMNOCDEFEJL()
	{
		this.DKANJKJMPNM();
	}

	// Token: 0x06009807 RID: 38919 RVA: 0x004249AC File Offset: 0x00422BAC
	public void AMCHLOKOFJK()
	{
		this.DMPLHAEKBFK();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.HIFIFJGKHMB();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x06009808 RID: 38920 RVA: 0x00424AD0 File Offset: 0x00422CD0
	public void ShowAllEffectsWithTag(string JCFOOJCGKMO = "")
	{
		this.AwakeEffects();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.JJIAJCCLPMM();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x06009809 RID: 38921 RVA: 0x00424C64 File Offset: 0x00422E64
	public void AKIEOGHOOOP()
	{
		this.PGKJPGGOMHP();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.HIFIFJGKHMB();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x0600980A RID: 38922 RVA: 0x00424D88 File Offset: 0x00422F88
	public void BDPLBFBBDPD(string JCFOOJCGKMO = "")
	{
		this.LNFLDPBCICC();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.JJIAJCCLPMM();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x0600980B RID: 38923 RVA: 0x0042162D File Offset: 0x0041F82D
	private void OGEFPECCDDE()
	{
		this.FJPCKENLAEE();
	}

	// Token: 0x0600980C RID: 38924 RVA: 0x00422271 File Offset: 0x00420471
	private void OnEnable()
	{
		this.AwakeEffects();
	}

	// Token: 0x0600980D RID: 38925 RVA: 0x00424F1C File Offset: 0x0042311C
	public void MGELCGPHEJP()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.HCOCLEDFCAA();
			}
		}
	}

	// Token: 0x0600980E RID: 38926 RVA: 0x00424FD4 File Offset: 0x004231D4
	public void PGKJPGGOMHP()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = false;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.BAINLMGOHIE();
			}
		}
	}

	// Token: 0x0600980F RID: 38927 RVA: 0x0042508C File Offset: 0x0042328C
	public void CIEKIPDHIIL(string JCFOOJCGKMO = "")
	{
		this.ADEFNANLAOF();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.LFEOGELABLI();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x06009810 RID: 38928 RVA: 0x00425220 File Offset: 0x00423420
	public void DJANBAPBGLD()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = false;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.ShowAllEffects();
			}
		}
	}

	// Token: 0x06009811 RID: 38929 RVA: 0x004252D8 File Offset: 0x004234D8
	public void JHEEIJGDEFK(string JCFOOJCGKMO = "")
	{
		this.LNFLDPBCICC();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.FGIDLGIPKGG();
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x06009812 RID: 38930 RVA: 0x0042546C File Offset: 0x0042366C
	public void HCOCLEDFCAA()
	{
		this.JADFENJPAKL();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.LFEOGELABLI();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x06009813 RID: 38931 RVA: 0x00422DCD File Offset: 0x00420FCD
	private void AILHMCGEMOG()
	{
		this.PGKJPGGOMHP();
	}

	// Token: 0x06009814 RID: 38932 RVA: 0x00425590 File Offset: 0x00423790
	public void AHAKANAEPHL()
	{
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = false;
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = false;
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = true;
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = false;
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = true;
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x06009815 RID: 38933 RVA: 0x00421565 File Offset: 0x0041F765
	private void OLEAIHHFBGB()
	{
		this.DFBLCAHODLN();
	}

	// Token: 0x06009816 RID: 38934 RVA: 0x00421565 File Offset: 0x0041F765
	private void FBACIBOFHJO()
	{
		this.DFBLCAHODLN();
	}

	// Token: 0x06009817 RID: 38935 RVA: 0x00425670 File Offset: 0x00423870
	public void FLBHKFFBHAN()
	{
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = true;
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = false;
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = true;
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = true;
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = false;
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = false;
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = false;
		}
	}

	// Token: 0x06009818 RID: 38936 RVA: 0x00425750 File Offset: 0x00423950
	public void CEOFKJNBCLF(string JCFOOJCGKMO = "")
	{
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = true;
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = false;
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = false;
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = true;
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = true;
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = true;
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = false;
		}
	}

	// Token: 0x06009819 RID: 38937 RVA: 0x004258A0 File Offset: 0x00423AA0
	public void LLOABPKAFKD()
	{
		this.AwakeEffects();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.FGIDLGIPKGG();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x0600981A RID: 38938 RVA: 0x004259C4 File Offset: 0x00423BC4
	public void LMOBDJAOBMB()
	{
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = false;
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = false;
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = false;
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = false;
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = true;
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = false;
		}
	}

	// Token: 0x0600981B RID: 38939 RVA: 0x00422F62 File Offset: 0x00421162
	private void JFEKHEIGPJD()
	{
		this.DAEBFLOCPLF();
	}

	// Token: 0x0600981C RID: 38940 RVA: 0x00425AA4 File Offset: 0x00423CA4
	public void PNLHGKOACKG(string JCFOOJCGKMO = "")
	{
		if (null != this.BKKHJBIEGCB && this.analogGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ && this.analogGlitch20Tag.Equals(JCFOOJCGKMO))
		{
			this.CGJIPMFMGCJ.enabled = true;
		}
		if (null != this.PBCLCNKNMHA && this.digitalGlitchTag.Equals(JCFOOJCGKMO))
		{
			this.PBCLCNKNMHA.enabled = true;
		}
		if (null != this.LKEJJKIELBE && this.videoGlitchNoiseAnalogTag.Equals(JCFOOJCGKMO))
		{
			this.LKEJJKIELBE.enabled = false;
		}
		if (null != this.MKCPLGOKFAD && this.videoGlitchNoiseDigitalTag.Equals(JCFOOJCGKMO))
		{
			this.MKCPLGOKFAD.enabled = false;
		}
		if (null != this.KGJKOHPGKFF && this.videoGlitchOldVHSTag.Equals(JCFOOJCGKMO))
		{
			this.KGJKOHPGKFF.enabled = false;
		}
		if (null != this.FJALIDLOAEH && this.videoGlitchSpectrumOffsetTag.Equals(JCFOOJCGKMO))
		{
			this.FJALIDLOAEH.enabled = true;
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = false;
		}
	}

	// Token: 0x0600981D RID: 38941 RVA: 0x00422279 File Offset: 0x00420479
	private void PEEKLFBDFEO()
	{
		this.DMPLHAEKBFK();
	}

	// Token: 0x0600981E RID: 38942 RVA: 0x00422DCD File Offset: 0x00420FCD
	private void BFGFJIJPMEH()
	{
		this.PGKJPGGOMHP();
	}

	// Token: 0x0600981F RID: 38943 RVA: 0x00425BF4 File Offset: 0x00423DF4
	public void DFBLCAHODLN()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = false;
			this.BKKHJBIEGCB = base.gameObject.GetComponent<AnalogGlitch>();
			this.CGJIPMFMGCJ = base.gameObject.GetComponent<AnalogGlitch20>();
			this.PBCLCNKNMHA = base.gameObject.GetComponent<DigitalGlitch>();
			this.LKEJJKIELBE = base.gameObject.GetComponent<VideoGlitchNoiseAnalog>();
			this.MKCPLGOKFAD = base.gameObject.GetComponent<VideoGlitchNoiseDigital>();
			this.KGJKOHPGKFF = base.gameObject.GetComponent<VideoGlitchOldVHS>();
			this.FJALIDLOAEH = base.gameObject.GetComponent<VideoGlitchSpectrumOffset>();
			this.CPKMOBOLFCM = base.gameObject.GetComponent<VideoGlitchVHSPause>();
			if (this.showOnAwake)
			{
				this.HCOCLEDFCAA();
			}
		}
	}

	// Token: 0x06009820 RID: 38944 RVA: 0x00422909 File Offset: 0x00420B09
	private void LLDCFHGMAML()
	{
		this.KECIFMLNOKP();
	}

	// Token: 0x06009821 RID: 38945 RVA: 0x00425CAC File Offset: 0x00423EAC
	public void JAAEPFJOHAI()
	{
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = false;
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = false;
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = false;
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = false;
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = true;
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = false;
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x06009822 RID: 38946 RVA: 0x00425D8C File Offset: 0x00423F8C
	public void ALIEGPJHAHE()
	{
		this.PGKJPGGOMHP();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.MMNEKIKMGKI();
		if (null != this.BKKHJBIEGCB)
		{
			this.BKKHJBIEGCB.enabled = this.analogGlitch[(int)kgiedhdalbm];
		}
		if (null != this.CGJIPMFMGCJ)
		{
			this.CGJIPMFMGCJ.enabled = this.analogGlitch20[(int)kgiedhdalbm];
		}
		if (null != this.PBCLCNKNMHA)
		{
			this.PBCLCNKNMHA.enabled = this.digitalGlitch[(int)kgiedhdalbm];
		}
		if (null != this.LKEJJKIELBE)
		{
			this.LKEJJKIELBE.enabled = this.videoGlitchNoiseAnalog[(int)kgiedhdalbm];
		}
		if (null != this.MKCPLGOKFAD)
		{
			this.MKCPLGOKFAD.enabled = this.videoGlitchNoiseDigital[(int)kgiedhdalbm];
		}
		if (null != this.KGJKOHPGKFF)
		{
			this.KGJKOHPGKFF.enabled = this.videoGlitchOldVHS[(int)kgiedhdalbm];
		}
		if (null != this.FJALIDLOAEH)
		{
			this.FJALIDLOAEH.enabled = this.videoGlitchSpectrumOffset[(int)kgiedhdalbm];
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = this.videoGlitchVHSPause[(int)kgiedhdalbm];
		}
	}

	// Token: 0x040029E0 RID: 10720
	public bool[] analogGlitch = new bool[3];

	// Token: 0x040029E1 RID: 10721
	public string analogGlitchTag = "";

	// Token: 0x040029E2 RID: 10722
	public bool[] analogGlitch20 = new bool[3];

	// Token: 0x040029E3 RID: 10723
	public string analogGlitch20Tag = "";

	// Token: 0x040029E4 RID: 10724
	public bool[] digitalGlitch = new bool[3];

	// Token: 0x040029E5 RID: 10725
	public string digitalGlitchTag = "";

	// Token: 0x040029E6 RID: 10726
	public bool[] videoGlitchNoiseAnalog = new bool[3];

	// Token: 0x040029E7 RID: 10727
	public string videoGlitchNoiseAnalogTag = "";

	// Token: 0x040029E8 RID: 10728
	public bool[] videoGlitchNoiseDigital = new bool[3];

	// Token: 0x040029E9 RID: 10729
	public string videoGlitchNoiseDigitalTag = "";

	// Token: 0x040029EA RID: 10730
	public bool[] videoGlitchOldVHS = new bool[3];

	// Token: 0x040029EB RID: 10731
	public string videoGlitchOldVHSTag = "";

	// Token: 0x040029EC RID: 10732
	public bool[] videoGlitchSpectrumOffset = new bool[3];

	// Token: 0x040029ED RID: 10733
	public string videoGlitchSpectrumOffsetTag = "";

	// Token: 0x040029EE RID: 10734
	public bool[] videoGlitchVHSPause = new bool[3];

	// Token: 0x040029EF RID: 10735
	public string videoGlitchVHSPauseTag = "";

	// Token: 0x040029F0 RID: 10736
	public bool showOnAwake = true;

	// Token: 0x040029F1 RID: 10737
	private AnalogGlitch BKKHJBIEGCB;

	// Token: 0x040029F2 RID: 10738
	private AnalogGlitch20 CGJIPMFMGCJ;

	// Token: 0x040029F3 RID: 10739
	private DigitalGlitch PBCLCNKNMHA;

	// Token: 0x040029F4 RID: 10740
	private VideoGlitchNoiseAnalog LKEJJKIELBE;

	// Token: 0x040029F5 RID: 10741
	private VideoGlitchNoiseDigital MKCPLGOKFAD;

	// Token: 0x040029F6 RID: 10742
	private VideoGlitchOldVHS KGJKOHPGKFF;

	// Token: 0x040029F7 RID: 10743
	private VideoGlitchSpectrumOffset FJALIDLOAEH;

	// Token: 0x040029F8 RID: 10744
	private VideoGlitchVHSPause CPKMOBOLFCM;

	// Token: 0x040029F9 RID: 10745
	private bool JIEPCIDINEH;
}
