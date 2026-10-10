using System;
using Kino;
using UnityEngine;
using UnityStandardAssets.ImageEffects;
using VideoGlitches;

// Token: 0x0200050F RID: 1295
public class ImageEffectsSelector : MonoBehaviour
{
	// Token: 0x06009C41 RID: 40001 RVA: 0x00435A8C File Offset: 0x00433C8C
	public TealTone DDMMEEPMJCD()
	{
		return this.JBGPOFKDEJO;
	}

	// Token: 0x06009C42 RID: 40002 RVA: 0x00435A94 File Offset: 0x00433C94
	public Bloom GetBloomEffect()
	{
		return this.OIFCMKDJLHI;
	}

	// Token: 0x06009C43 RID: 40003 RVA: 0x00435A94 File Offset: 0x00433C94
	public Bloom MHLFPEHPKOD()
	{
		return this.OIFCMKDJLHI;
	}

	// Token: 0x06009C44 RID: 40004 RVA: 0x00435A9C File Offset: 0x00433C9C
	public VignetteAndChromaticAberration EBBLENOFNGM()
	{
		return this.JIMDOMJOCLF;
	}

	// Token: 0x06009C45 RID: 40005 RVA: 0x00435A9C File Offset: 0x00433C9C
	public VignetteAndChromaticAberration PEACHLHMPOI()
	{
		return this.JIMDOMJOCLF;
	}

	// Token: 0x06009C46 RID: 40006 RVA: 0x00435A9C File Offset: 0x00433C9C
	public VignetteAndChromaticAberration JLHPDCFNPMC()
	{
		return this.JIMDOMJOCLF;
	}

	// Token: 0x06009C47 RID: 40007 RVA: 0x00435A8C File Offset: 0x00433C8C
	public TealTone HDMLNAOIKHH()
	{
		return this.JBGPOFKDEJO;
	}

	// Token: 0x06009C48 RID: 40008 RVA: 0x00435AA4 File Offset: 0x00433CA4
	public void PNJCFFFDMJD()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.HHDEDMFJPNE = base.gameObject.GetComponent<BloomOptimized>();
			this.OIFCMKDJLHI = base.gameObject.GetComponent<Bloom>();
			this.HGIDMONOBOL = base.gameObject.GetComponent<BlurOptimized>();
			this.JIMDOMJOCLF = base.gameObject.GetComponent<VignetteAndChromaticAberration>();
			this.GOLJDIADJFH = base.gameObject.GetComponent<NoiseAndGrain>();
			this.PJOBCHFCIGC = base.gameObject.GetComponent<Grayscale>();
			this.JBGPOFKDEJO = base.gameObject.GetComponent<TealTone>();
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
				this.DNPGILIDLGJ();
			}
		}
	}

	// Token: 0x06009C49 RID: 40009 RVA: 0x00435BD0 File Offset: 0x00433DD0
	private void AOIJOKHACJL()
	{
		this.MJKIMLPDKGD();
	}

	// Token: 0x06009C4A RID: 40010 RVA: 0x00435A9C File Offset: 0x00433C9C
	public VignetteAndChromaticAberration GEAACPOGIMB()
	{
		return this.JIMDOMJOCLF;
	}

	// Token: 0x06009C4B RID: 40011 RVA: 0x00435BD8 File Offset: 0x00433DD8
	public BlurOptimized JKPBBAONHPH()
	{
		return this.HGIDMONOBOL;
	}

	// Token: 0x06009C4C RID: 40012 RVA: 0x00435BE0 File Offset: 0x00433DE0
	public void FEFDOKKPLLE(string JCFOOJCGKMO = "")
	{
		if (null != this.HHDEDMFJPNE && this.bloomOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HHDEDMFJPNE.enabled = true;
		}
		if (null != this.OIFCMKDJLHI && this.bloomTag.Equals(JCFOOJCGKMO))
		{
			this.OIFCMKDJLHI.enabled = true;
		}
		if (null != this.HGIDMONOBOL && this.blurOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HGIDMONOBOL.enabled = false;
		}
		if (null != this.JIMDOMJOCLF && this.vignetteAndChromaticAberationTag.Equals(JCFOOJCGKMO))
		{
			this.JIMDOMJOCLF.enabled = true;
		}
		if (null != this.GOLJDIADJFH && this.noiseAndGrainTag.Equals(JCFOOJCGKMO))
		{
			this.GOLJDIADJFH.enabled = false;
		}
		if (null != this.PJOBCHFCIGC && this.grayscaleTag.Equals(JCFOOJCGKMO))
		{
			this.PJOBCHFCIGC.enabled = true;
		}
		if (null != this.JBGPOFKDEJO && this.tealTag.Equals(JCFOOJCGKMO))
		{
			this.JBGPOFKDEJO.enabled = false;
		}
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
			this.FJALIDLOAEH.enabled = true;
		}
		if (null != this.CPKMOBOLFCM && this.videoGlitchVHSPauseTag.Equals(JCFOOJCGKMO))
		{
			this.CPKMOBOLFCM.enabled = false;
		}
	}

	// Token: 0x06009C4D RID: 40013 RVA: 0x00435A9C File Offset: 0x00433C9C
	public VignetteAndChromaticAberration FFNDKFLEMBM()
	{
		return this.JIMDOMJOCLF;
	}

	// Token: 0x06009C4E RID: 40014 RVA: 0x00435E45 File Offset: 0x00434045
	public NoiseAndGrain CAMJHLOLIID()
	{
		return this.GOLJDIADJFH;
	}

	// Token: 0x06009C4F RID: 40015 RVA: 0x00435E50 File Offset: 0x00434050
	public void HideAllEffects()
	{
		if (null != this.OIFCMKDJLHI)
		{
			this.OIFCMKDJLHI.enabled = false;
		}
		if (null != this.HHDEDMFJPNE)
		{
			this.HHDEDMFJPNE.enabled = false;
		}
		if (null != this.HGIDMONOBOL)
		{
			this.HGIDMONOBOL.enabled = false;
		}
		if (null != this.JIMDOMJOCLF)
		{
			this.JIMDOMJOCLF.enabled = false;
		}
		if (null != this.GOLJDIADJFH)
		{
			this.GOLJDIADJFH.enabled = false;
		}
		if (null != this.PJOBCHFCIGC)
		{
			this.PJOBCHFCIGC.enabled = false;
		}
		if (null != this.JBGPOFKDEJO)
		{
			this.JBGPOFKDEJO.enabled = false;
		}
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

	// Token: 0x06009C50 RID: 40016 RVA: 0x00435FE3 File Offset: 0x004341E3
	private void HPGLEEHELDN()
	{
		this.AAJFMAPMINO();
	}

	// Token: 0x06009C51 RID: 40017 RVA: 0x00435A8C File Offset: 0x00433C8C
	public TealTone CBKKGGCBFMC()
	{
		return this.JBGPOFKDEJO;
	}

	// Token: 0x06009C52 RID: 40018 RVA: 0x00435FEB File Offset: 0x004341EB
	private void LBDIDHDKHGO()
	{
		this.PNJCFFFDMJD();
	}

	// Token: 0x06009C53 RID: 40019 RVA: 0x00435FF3 File Offset: 0x004341F3
	private void FBACIBOFHJO()
	{
		this.ADEFNANLAOF();
	}

	// Token: 0x06009C54 RID: 40020 RVA: 0x00435BD8 File Offset: 0x00433DD8
	public BlurOptimized PHBAIGOPLJG()
	{
		return this.HGIDMONOBOL;
	}

	// Token: 0x06009C55 RID: 40021 RVA: 0x00435FFC File Offset: 0x004341FC
	public void LKAICIJJBMC(string JCFOOJCGKMO = "")
	{
		this.MJKIMLPDKGD();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.LFEOGELABLI();
		if (null != this.HHDEDMFJPNE && this.bloomOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HHDEDMFJPNE.enabled = this.bloomOptimized[(int)kgiedhdalbm];
		}
		if (null != this.OIFCMKDJLHI && this.bloomTag.Equals(JCFOOJCGKMO))
		{
			this.OIFCMKDJLHI.enabled = this.bloom[(int)kgiedhdalbm];
		}
		if (null != this.HGIDMONOBOL && this.blurOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HGIDMONOBOL.enabled = this.blurOptimized[(int)kgiedhdalbm];
		}
		if (null != this.JIMDOMJOCLF && this.vignetteAndChromaticAberationTag.Equals(JCFOOJCGKMO))
		{
			this.JIMDOMJOCLF.enabled = this.vignetteAndChromaticAberation[(int)kgiedhdalbm];
		}
		if (null != this.GOLJDIADJFH && this.noiseAndGrainTag.Equals(JCFOOJCGKMO))
		{
			this.GOLJDIADJFH.enabled = this.noiseAndGrain[(int)kgiedhdalbm];
		}
		if (null != this.PJOBCHFCIGC && this.grayscaleTag.Equals(JCFOOJCGKMO))
		{
			this.PJOBCHFCIGC.enabled = this.grayscale[(int)kgiedhdalbm];
		}
		if (null != this.JBGPOFKDEJO && this.tealTag.Equals(JCFOOJCGKMO))
		{
			this.JBGPOFKDEJO.enabled = this.teal[(int)kgiedhdalbm];
		}
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

	// Token: 0x06009C56 RID: 40022 RVA: 0x004362D6 File Offset: 0x004344D6
	private void Awake()
	{
		this.AwakeEffects();
	}

	// Token: 0x06009C57 RID: 40023 RVA: 0x00435BD8 File Offset: 0x00433DD8
	public BlurOptimized HIACNEKIEKP()
	{
		return this.HGIDMONOBOL;
	}

	// Token: 0x06009C58 RID: 40024 RVA: 0x004362E0 File Offset: 0x004344E0
	public void FJJBPIJFLJA()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.HHDEDMFJPNE = base.gameObject.GetComponent<BloomOptimized>();
			this.OIFCMKDJLHI = base.gameObject.GetComponent<Bloom>();
			this.HGIDMONOBOL = base.gameObject.GetComponent<BlurOptimized>();
			this.JIMDOMJOCLF = base.gameObject.GetComponent<VignetteAndChromaticAberration>();
			this.GOLJDIADJFH = base.gameObject.GetComponent<NoiseAndGrain>();
			this.PJOBCHFCIGC = base.gameObject.GetComponent<Grayscale>();
			this.JBGPOFKDEJO = base.gameObject.GetComponent<TealTone>();
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

	// Token: 0x06009C59 RID: 40025 RVA: 0x0043640C File Offset: 0x0043460C
	public BloomOptimized JMOEFEMIAKF()
	{
		return this.HHDEDMFJPNE;
	}

	// Token: 0x06009C5A RID: 40026 RVA: 0x00436414 File Offset: 0x00434614
	public void BGNBKKEBJBF()
	{
		this.ADEFNANLAOF();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.FGIDLGIPKGG();
		if (null != this.HHDEDMFJPNE)
		{
			this.HHDEDMFJPNE.enabled = this.bloomOptimized[(int)kgiedhdalbm];
		}
		if (null != this.OIFCMKDJLHI)
		{
			this.OIFCMKDJLHI.enabled = this.bloom[(int)kgiedhdalbm];
		}
		if (null != this.HGIDMONOBOL)
		{
			this.HGIDMONOBOL.enabled = this.blurOptimized[(int)kgiedhdalbm];
		}
		if (null != this.JIMDOMJOCLF)
		{
			this.JIMDOMJOCLF.enabled = this.vignetteAndChromaticAberation[(int)kgiedhdalbm];
		}
		if (null != this.GOLJDIADJFH)
		{
			this.GOLJDIADJFH.enabled = this.noiseAndGrain[(int)kgiedhdalbm];
		}
		if (null != this.PJOBCHFCIGC)
		{
			this.PJOBCHFCIGC.enabled = this.grayscale[(int)kgiedhdalbm];
		}
		if (null != this.JBGPOFKDEJO)
		{
			this.JBGPOFKDEJO.enabled = this.teal[(int)kgiedhdalbm];
		}
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

	// Token: 0x06009C5B RID: 40027 RVA: 0x0043661C File Offset: 0x0043481C
	public void ShowAllEffects()
	{
		this.AwakeEffects();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.JJIAJCCLPMM();
		if (null != this.HHDEDMFJPNE)
		{
			this.HHDEDMFJPNE.enabled = this.bloomOptimized[(int)kgiedhdalbm];
		}
		if (null != this.OIFCMKDJLHI)
		{
			this.OIFCMKDJLHI.enabled = this.bloom[(int)kgiedhdalbm];
		}
		if (null != this.HGIDMONOBOL)
		{
			this.HGIDMONOBOL.enabled = this.blurOptimized[(int)kgiedhdalbm];
		}
		if (null != this.JIMDOMJOCLF)
		{
			this.JIMDOMJOCLF.enabled = this.vignetteAndChromaticAberation[(int)kgiedhdalbm];
		}
		if (null != this.GOLJDIADJFH)
		{
			this.GOLJDIADJFH.enabled = this.noiseAndGrain[(int)kgiedhdalbm];
		}
		if (null != this.PJOBCHFCIGC)
		{
			this.PJOBCHFCIGC.enabled = this.grayscale[(int)kgiedhdalbm];
		}
		if (null != this.JBGPOFKDEJO)
		{
			this.JBGPOFKDEJO.enabled = this.teal[(int)kgiedhdalbm];
		}
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

	// Token: 0x06009C5C RID: 40028 RVA: 0x00436824 File Offset: 0x00434A24
	public void HideAllEffectsWithTag(string JCFOOJCGKMO = "")
	{
		if (null != this.HHDEDMFJPNE && this.bloomOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HHDEDMFJPNE.enabled = false;
		}
		if (null != this.OIFCMKDJLHI && this.bloomTag.Equals(JCFOOJCGKMO))
		{
			this.OIFCMKDJLHI.enabled = false;
		}
		if (null != this.HGIDMONOBOL && this.blurOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HGIDMONOBOL.enabled = false;
		}
		if (null != this.JIMDOMJOCLF && this.vignetteAndChromaticAberationTag.Equals(JCFOOJCGKMO))
		{
			this.JIMDOMJOCLF.enabled = false;
		}
		if (null != this.GOLJDIADJFH && this.noiseAndGrainTag.Equals(JCFOOJCGKMO))
		{
			this.GOLJDIADJFH.enabled = false;
		}
		if (null != this.PJOBCHFCIGC && this.grayscaleTag.Equals(JCFOOJCGKMO))
		{
			this.PJOBCHFCIGC.enabled = false;
		}
		if (null != this.JBGPOFKDEJO && this.tealTag.Equals(JCFOOJCGKMO))
		{
			this.JBGPOFKDEJO.enabled = false;
		}
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

	// Token: 0x06009C5D RID: 40029 RVA: 0x00436A8C File Offset: 0x00434C8C
	public void BHKGIEGICDI(string JCFOOJCGKMO = "")
	{
		this.MJKIMLPDKGD();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.NJPGEPBFMMK();
		if (null != this.HHDEDMFJPNE && this.bloomOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HHDEDMFJPNE.enabled = this.bloomOptimized[(int)kgiedhdalbm];
		}
		if (null != this.OIFCMKDJLHI && this.bloomTag.Equals(JCFOOJCGKMO))
		{
			this.OIFCMKDJLHI.enabled = this.bloom[(int)kgiedhdalbm];
		}
		if (null != this.HGIDMONOBOL && this.blurOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HGIDMONOBOL.enabled = this.blurOptimized[(int)kgiedhdalbm];
		}
		if (null != this.JIMDOMJOCLF && this.vignetteAndChromaticAberationTag.Equals(JCFOOJCGKMO))
		{
			this.JIMDOMJOCLF.enabled = this.vignetteAndChromaticAberation[(int)kgiedhdalbm];
		}
		if (null != this.GOLJDIADJFH && this.noiseAndGrainTag.Equals(JCFOOJCGKMO))
		{
			this.GOLJDIADJFH.enabled = this.noiseAndGrain[(int)kgiedhdalbm];
		}
		if (null != this.PJOBCHFCIGC && this.grayscaleTag.Equals(JCFOOJCGKMO))
		{
			this.PJOBCHFCIGC.enabled = this.grayscale[(int)kgiedhdalbm];
		}
		if (null != this.JBGPOFKDEJO && this.tealTag.Equals(JCFOOJCGKMO))
		{
			this.JBGPOFKDEJO.enabled = this.teal[(int)kgiedhdalbm];
		}
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

	// Token: 0x06009C5E RID: 40030 RVA: 0x00435A8C File Offset: 0x00433C8C
	public TealTone GetTealEffect()
	{
		return this.JBGPOFKDEJO;
	}

	// Token: 0x06009C5F RID: 40031 RVA: 0x004362D6 File Offset: 0x004344D6
	private void Start()
	{
		this.AwakeEffects();
	}

	// Token: 0x06009C60 RID: 40032 RVA: 0x00436D68 File Offset: 0x00434F68
	public void GFMDFJCFMGI()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.HHDEDMFJPNE = base.gameObject.GetComponent<BloomOptimized>();
			this.OIFCMKDJLHI = base.gameObject.GetComponent<Bloom>();
			this.HGIDMONOBOL = base.gameObject.GetComponent<BlurOptimized>();
			this.JIMDOMJOCLF = base.gameObject.GetComponent<VignetteAndChromaticAberration>();
			this.GOLJDIADJFH = base.gameObject.GetComponent<NoiseAndGrain>();
			this.PJOBCHFCIGC = base.gameObject.GetComponent<Grayscale>();
			this.JBGPOFKDEJO = base.gameObject.GetComponent<TealTone>();
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
				this.BGNBKKEBJBF();
			}
		}
	}

	// Token: 0x06009C61 RID: 40033 RVA: 0x00436E94 File Offset: 0x00435094
	public void AwakeEffects()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.HHDEDMFJPNE = base.gameObject.GetComponent<BloomOptimized>();
			this.OIFCMKDJLHI = base.gameObject.GetComponent<Bloom>();
			this.HGIDMONOBOL = base.gameObject.GetComponent<BlurOptimized>();
			this.JIMDOMJOCLF = base.gameObject.GetComponent<VignetteAndChromaticAberration>();
			this.GOLJDIADJFH = base.gameObject.GetComponent<NoiseAndGrain>();
			this.PJOBCHFCIGC = base.gameObject.GetComponent<Grayscale>();
			this.JBGPOFKDEJO = base.gameObject.GetComponent<TealTone>();
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

	// Token: 0x06009C62 RID: 40034 RVA: 0x00435A94 File Offset: 0x00433C94
	public Bloom PAMKEEADLIE()
	{
		return this.OIFCMKDJLHI;
	}

	// Token: 0x06009C63 RID: 40035 RVA: 0x00436FC0 File Offset: 0x004351C0
	public void ShowAllEffectsWithTag(string JCFOOJCGKMO = "")
	{
		this.AwakeEffects();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.JJIAJCCLPMM();
		if (null != this.HHDEDMFJPNE && this.bloomOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HHDEDMFJPNE.enabled = this.bloomOptimized[(int)kgiedhdalbm];
		}
		if (null != this.OIFCMKDJLHI && this.bloomTag.Equals(JCFOOJCGKMO))
		{
			this.OIFCMKDJLHI.enabled = this.bloom[(int)kgiedhdalbm];
		}
		if (null != this.HGIDMONOBOL && this.blurOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HGIDMONOBOL.enabled = this.blurOptimized[(int)kgiedhdalbm];
		}
		if (null != this.JIMDOMJOCLF && this.vignetteAndChromaticAberationTag.Equals(JCFOOJCGKMO))
		{
			this.JIMDOMJOCLF.enabled = this.vignetteAndChromaticAberation[(int)kgiedhdalbm];
		}
		if (null != this.GOLJDIADJFH && this.noiseAndGrainTag.Equals(JCFOOJCGKMO))
		{
			this.GOLJDIADJFH.enabled = this.noiseAndGrain[(int)kgiedhdalbm];
		}
		if (null != this.PJOBCHFCIGC && this.grayscaleTag.Equals(JCFOOJCGKMO))
		{
			this.PJOBCHFCIGC.enabled = this.grayscale[(int)kgiedhdalbm];
		}
		if (null != this.JBGPOFKDEJO && this.tealTag.Equals(JCFOOJCGKMO))
		{
			this.JBGPOFKDEJO.enabled = this.teal[(int)kgiedhdalbm];
		}
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

	// Token: 0x06009C64 RID: 40036 RVA: 0x0043729C File Offset: 0x0043549C
	public void ADEFNANLAOF()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = false;
			this.HHDEDMFJPNE = base.gameObject.GetComponent<BloomOptimized>();
			this.OIFCMKDJLHI = base.gameObject.GetComponent<Bloom>();
			this.HGIDMONOBOL = base.gameObject.GetComponent<BlurOptimized>();
			this.JIMDOMJOCLF = base.gameObject.GetComponent<VignetteAndChromaticAberration>();
			this.GOLJDIADJFH = base.gameObject.GetComponent<NoiseAndGrain>();
			this.PJOBCHFCIGC = base.gameObject.GetComponent<Grayscale>();
			this.JBGPOFKDEJO = base.gameObject.GetComponent<TealTone>();
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
				this.JEAALFEOJHD();
			}
		}
	}

	// Token: 0x06009C65 RID: 40037 RVA: 0x004362D6 File Offset: 0x004344D6
	private void OnEnable()
	{
		this.AwakeEffects();
	}

	// Token: 0x06009C66 RID: 40038 RVA: 0x00435BD8 File Offset: 0x00433DD8
	public BlurOptimized GetBlurOptimizedEffect()
	{
		return this.HGIDMONOBOL;
	}

	// Token: 0x06009C67 RID: 40039 RVA: 0x004373C8 File Offset: 0x004355C8
	private void JDMOENJPHOE()
	{
		this.JADFENJPAKL();
	}

	// Token: 0x06009C68 RID: 40040 RVA: 0x004373D0 File Offset: 0x004355D0
	public Grayscale HPGCIJBOFLH()
	{
		return this.PJOBCHFCIGC;
	}

	// Token: 0x06009C69 RID: 40041 RVA: 0x00435FF3 File Offset: 0x004341F3
	private void PMKKOENBNOM()
	{
		this.ADEFNANLAOF();
	}

	// Token: 0x06009C6A RID: 40042 RVA: 0x004373D8 File Offset: 0x004355D8
	public void MNGLEOOEHCG()
	{
		if (null != this.OIFCMKDJLHI)
		{
			this.OIFCMKDJLHI.enabled = false;
		}
		if (null != this.HHDEDMFJPNE)
		{
			this.HHDEDMFJPNE.enabled = true;
		}
		if (null != this.HGIDMONOBOL)
		{
			this.HGIDMONOBOL.enabled = true;
		}
		if (null != this.JIMDOMJOCLF)
		{
			this.JIMDOMJOCLF.enabled = true;
		}
		if (null != this.GOLJDIADJFH)
		{
			this.GOLJDIADJFH.enabled = true;
		}
		if (null != this.PJOBCHFCIGC)
		{
			this.PJOBCHFCIGC.enabled = false;
		}
		if (null != this.JBGPOFKDEJO)
		{
			this.JBGPOFKDEJO.enabled = true;
		}
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
			this.FJALIDLOAEH.enabled = true;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x06009C6B RID: 40043 RVA: 0x00435A9C File Offset: 0x00433C9C
	public VignetteAndChromaticAberration LFOGMEIOFFE()
	{
		return this.JIMDOMJOCLF;
	}

	// Token: 0x06009C6C RID: 40044 RVA: 0x004373D0 File Offset: 0x004355D0
	public Grayscale MECDBEOLGLM()
	{
		return this.PJOBCHFCIGC;
	}

	// Token: 0x06009C6D RID: 40045 RVA: 0x0043756C File Offset: 0x0043576C
	public void JADFENJPAKL()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = false;
			this.HHDEDMFJPNE = base.gameObject.GetComponent<BloomOptimized>();
			this.OIFCMKDJLHI = base.gameObject.GetComponent<Bloom>();
			this.HGIDMONOBOL = base.gameObject.GetComponent<BlurOptimized>();
			this.JIMDOMJOCLF = base.gameObject.GetComponent<VignetteAndChromaticAberration>();
			this.GOLJDIADJFH = base.gameObject.GetComponent<NoiseAndGrain>();
			this.PJOBCHFCIGC = base.gameObject.GetComponent<Grayscale>();
			this.JBGPOFKDEJO = base.gameObject.GetComponent<TealTone>();
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
				this.DFGDMBHEBPN();
			}
		}
	}

	// Token: 0x06009C6E RID: 40046 RVA: 0x00435BD8 File Offset: 0x00433DD8
	public BlurOptimized NCBLPEIPFHI()
	{
		return this.HGIDMONOBOL;
	}

	// Token: 0x06009C6F RID: 40047 RVA: 0x00437698 File Offset: 0x00435898
	public void KPPMMLPFDPC()
	{
		if (null != this.OIFCMKDJLHI)
		{
			this.OIFCMKDJLHI.enabled = false;
		}
		if (null != this.HHDEDMFJPNE)
		{
			this.HHDEDMFJPNE.enabled = true;
		}
		if (null != this.HGIDMONOBOL)
		{
			this.HGIDMONOBOL.enabled = false;
		}
		if (null != this.JIMDOMJOCLF)
		{
			this.JIMDOMJOCLF.enabled = true;
		}
		if (null != this.GOLJDIADJFH)
		{
			this.GOLJDIADJFH.enabled = false;
		}
		if (null != this.PJOBCHFCIGC)
		{
			this.PJOBCHFCIGC.enabled = true;
		}
		if (null != this.JBGPOFKDEJO)
		{
			this.JBGPOFKDEJO.enabled = false;
		}
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
			this.FJALIDLOAEH.enabled = true;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x06009C70 RID: 40048 RVA: 0x00435BD0 File Offset: 0x00433DD0
	private void OJGELECJGJC()
	{
		this.MJKIMLPDKGD();
	}

	// Token: 0x06009C71 RID: 40049 RVA: 0x00435FEB File Offset: 0x004341EB
	private void JLHGINADNCA()
	{
		this.PNJCFFFDMJD();
	}

	// Token: 0x06009C72 RID: 40050 RVA: 0x0043640C File Offset: 0x0043460C
	public BloomOptimized KFHJMEECMOC()
	{
		return this.HHDEDMFJPNE;
	}

	// Token: 0x06009C73 RID: 40051 RVA: 0x00435BD8 File Offset: 0x00433DD8
	public BlurOptimized CDLGMFNGPBO()
	{
		return this.HGIDMONOBOL;
	}

	// Token: 0x06009C74 RID: 40052 RVA: 0x0043640C File Offset: 0x0043460C
	public BloomOptimized HKJGFOPBANE()
	{
		return this.HHDEDMFJPNE;
	}

	// Token: 0x06009C75 RID: 40053 RVA: 0x0043640C File Offset: 0x0043460C
	public BloomOptimized EMKMNLMEGIK()
	{
		return this.HHDEDMFJPNE;
	}

	// Token: 0x06009C76 RID: 40054 RVA: 0x0043782C File Offset: 0x00435A2C
	public void ANDHMLHGAOJ()
	{
		this.FJJBPIJFLJA();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.MMNEKIKMGKI();
		if (null != this.HHDEDMFJPNE)
		{
			this.HHDEDMFJPNE.enabled = this.bloomOptimized[(int)kgiedhdalbm];
		}
		if (null != this.OIFCMKDJLHI)
		{
			this.OIFCMKDJLHI.enabled = this.bloom[(int)kgiedhdalbm];
		}
		if (null != this.HGIDMONOBOL)
		{
			this.HGIDMONOBOL.enabled = this.blurOptimized[(int)kgiedhdalbm];
		}
		if (null != this.JIMDOMJOCLF)
		{
			this.JIMDOMJOCLF.enabled = this.vignetteAndChromaticAberation[(int)kgiedhdalbm];
		}
		if (null != this.GOLJDIADJFH)
		{
			this.GOLJDIADJFH.enabled = this.noiseAndGrain[(int)kgiedhdalbm];
		}
		if (null != this.PJOBCHFCIGC)
		{
			this.PJOBCHFCIGC.enabled = this.grayscale[(int)kgiedhdalbm];
		}
		if (null != this.JBGPOFKDEJO)
		{
			this.JBGPOFKDEJO.enabled = this.teal[(int)kgiedhdalbm];
		}
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

	// Token: 0x06009C77 RID: 40055 RVA: 0x00437A34 File Offset: 0x00435C34
	public void JEAALFEOJHD()
	{
		this.JADFENJPAKL();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.NJPGEPBFMMK();
		if (null != this.HHDEDMFJPNE)
		{
			this.HHDEDMFJPNE.enabled = this.bloomOptimized[(int)kgiedhdalbm];
		}
		if (null != this.OIFCMKDJLHI)
		{
			this.OIFCMKDJLHI.enabled = this.bloom[(int)kgiedhdalbm];
		}
		if (null != this.HGIDMONOBOL)
		{
			this.HGIDMONOBOL.enabled = this.blurOptimized[(int)kgiedhdalbm];
		}
		if (null != this.JIMDOMJOCLF)
		{
			this.JIMDOMJOCLF.enabled = this.vignetteAndChromaticAberation[(int)kgiedhdalbm];
		}
		if (null != this.GOLJDIADJFH)
		{
			this.GOLJDIADJFH.enabled = this.noiseAndGrain[(int)kgiedhdalbm];
		}
		if (null != this.PJOBCHFCIGC)
		{
			this.PJOBCHFCIGC.enabled = this.grayscale[(int)kgiedhdalbm];
		}
		if (null != this.JBGPOFKDEJO)
		{
			this.JBGPOFKDEJO.enabled = this.teal[(int)kgiedhdalbm];
		}
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

	// Token: 0x06009C78 RID: 40056 RVA: 0x00435FEB File Offset: 0x004341EB
	private void ODOOIGEDLKB()
	{
		this.PNJCFFFDMJD();
	}

	// Token: 0x06009C79 RID: 40057 RVA: 0x00435E45 File Offset: 0x00434045
	public NoiseAndGrain OMBKPBHHNLN()
	{
		return this.GOLJDIADJFH;
	}

	// Token: 0x06009C7A RID: 40058 RVA: 0x00437C3C File Offset: 0x00435E3C
	public void MJKIMLPDKGD()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = false;
			this.HHDEDMFJPNE = base.gameObject.GetComponent<BloomOptimized>();
			this.OIFCMKDJLHI = base.gameObject.GetComponent<Bloom>();
			this.HGIDMONOBOL = base.gameObject.GetComponent<BlurOptimized>();
			this.JIMDOMJOCLF = base.gameObject.GetComponent<VignetteAndChromaticAberration>();
			this.GOLJDIADJFH = base.gameObject.GetComponent<NoiseAndGrain>();
			this.PJOBCHFCIGC = base.gameObject.GetComponent<Grayscale>();
			this.JBGPOFKDEJO = base.gameObject.GetComponent<TealTone>();
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
				this.JEAALFEOJHD();
			}
		}
	}

	// Token: 0x06009C7B RID: 40059 RVA: 0x00437D68 File Offset: 0x00435F68
	public void LOLEHLPMJIJ(string JCFOOJCGKMO = "")
	{
		this.PNJCFFFDMJD();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.FGIDLGIPKGG();
		if (null != this.HHDEDMFJPNE && this.bloomOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HHDEDMFJPNE.enabled = this.bloomOptimized[(int)kgiedhdalbm];
		}
		if (null != this.OIFCMKDJLHI && this.bloomTag.Equals(JCFOOJCGKMO))
		{
			this.OIFCMKDJLHI.enabled = this.bloom[(int)kgiedhdalbm];
		}
		if (null != this.HGIDMONOBOL && this.blurOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HGIDMONOBOL.enabled = this.blurOptimized[(int)kgiedhdalbm];
		}
		if (null != this.JIMDOMJOCLF && this.vignetteAndChromaticAberationTag.Equals(JCFOOJCGKMO))
		{
			this.JIMDOMJOCLF.enabled = this.vignetteAndChromaticAberation[(int)kgiedhdalbm];
		}
		if (null != this.GOLJDIADJFH && this.noiseAndGrainTag.Equals(JCFOOJCGKMO))
		{
			this.GOLJDIADJFH.enabled = this.noiseAndGrain[(int)kgiedhdalbm];
		}
		if (null != this.PJOBCHFCIGC && this.grayscaleTag.Equals(JCFOOJCGKMO))
		{
			this.PJOBCHFCIGC.enabled = this.grayscale[(int)kgiedhdalbm];
		}
		if (null != this.JBGPOFKDEJO && this.tealTag.Equals(JCFOOJCGKMO))
		{
			this.JBGPOFKDEJO.enabled = this.teal[(int)kgiedhdalbm];
		}
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

	// Token: 0x06009C7C RID: 40060 RVA: 0x00438044 File Offset: 0x00436244
	public void MGEKEDODMPM(string JCFOOJCGKMO = "")
	{
		if (null != this.HHDEDMFJPNE && this.bloomOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HHDEDMFJPNE.enabled = false;
		}
		if (null != this.OIFCMKDJLHI && this.bloomTag.Equals(JCFOOJCGKMO))
		{
			this.OIFCMKDJLHI.enabled = false;
		}
		if (null != this.HGIDMONOBOL && this.blurOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HGIDMONOBOL.enabled = false;
		}
		if (null != this.JIMDOMJOCLF && this.vignetteAndChromaticAberationTag.Equals(JCFOOJCGKMO))
		{
			this.JIMDOMJOCLF.enabled = false;
		}
		if (null != this.GOLJDIADJFH && this.noiseAndGrainTag.Equals(JCFOOJCGKMO))
		{
			this.GOLJDIADJFH.enabled = true;
		}
		if (null != this.PJOBCHFCIGC && this.grayscaleTag.Equals(JCFOOJCGKMO))
		{
			this.PJOBCHFCIGC.enabled = false;
		}
		if (null != this.JBGPOFKDEJO && this.tealTag.Equals(JCFOOJCGKMO))
		{
			this.JBGPOFKDEJO.enabled = false;
		}
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
			this.CPKMOBOLFCM.enabled = false;
		}
	}

	// Token: 0x06009C7D RID: 40061 RVA: 0x0043640C File Offset: 0x0043460C
	public BloomOptimized PNGIMIPGLPK()
	{
		return this.HHDEDMFJPNE;
	}

	// Token: 0x06009C7E RID: 40062 RVA: 0x00435FF3 File Offset: 0x004341F3
	private void ILBAMCJFAAP()
	{
		this.ADEFNANLAOF();
	}

	// Token: 0x06009C7F RID: 40063 RVA: 0x00435A9C File Offset: 0x00433C9C
	public VignetteAndChromaticAberration GetVignetteAndChromaticAberrationEffect()
	{
		return this.JIMDOMJOCLF;
	}

	// Token: 0x06009C80 RID: 40064 RVA: 0x004382AC File Offset: 0x004364AC
	public void NGAIENKCICP(string JCFOOJCGKMO = "")
	{
		this.PNJCFFFDMJD();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.LFEOGELABLI();
		if (null != this.HHDEDMFJPNE && this.bloomOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HHDEDMFJPNE.enabled = this.bloomOptimized[(int)kgiedhdalbm];
		}
		if (null != this.OIFCMKDJLHI && this.bloomTag.Equals(JCFOOJCGKMO))
		{
			this.OIFCMKDJLHI.enabled = this.bloom[(int)kgiedhdalbm];
		}
		if (null != this.HGIDMONOBOL && this.blurOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HGIDMONOBOL.enabled = this.blurOptimized[(int)kgiedhdalbm];
		}
		if (null != this.JIMDOMJOCLF && this.vignetteAndChromaticAberationTag.Equals(JCFOOJCGKMO))
		{
			this.JIMDOMJOCLF.enabled = this.vignetteAndChromaticAberation[(int)kgiedhdalbm];
		}
		if (null != this.GOLJDIADJFH && this.noiseAndGrainTag.Equals(JCFOOJCGKMO))
		{
			this.GOLJDIADJFH.enabled = this.noiseAndGrain[(int)kgiedhdalbm];
		}
		if (null != this.PJOBCHFCIGC && this.grayscaleTag.Equals(JCFOOJCGKMO))
		{
			this.PJOBCHFCIGC.enabled = this.grayscale[(int)kgiedhdalbm];
		}
		if (null != this.JBGPOFKDEJO && this.tealTag.Equals(JCFOOJCGKMO))
		{
			this.JBGPOFKDEJO.enabled = this.teal[(int)kgiedhdalbm];
		}
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

	// Token: 0x06009C82 RID: 40066 RVA: 0x004373D0 File Offset: 0x004355D0
	public Grayscale ONBNEJPFMAP()
	{
		return this.PJOBCHFCIGC;
	}

	// Token: 0x06009C83 RID: 40067 RVA: 0x00435FF3 File Offset: 0x004341F3
	private void MNNHONLLGCD()
	{
		this.ADEFNANLAOF();
	}

	// Token: 0x06009C84 RID: 40068 RVA: 0x00435BD8 File Offset: 0x00433DD8
	public BlurOptimized GIABDBKBGPP()
	{
		return this.HGIDMONOBOL;
	}

	// Token: 0x06009C85 RID: 40069 RVA: 0x0043640C File Offset: 0x0043460C
	public BloomOptimized GetBloomOptimizedEffect()
	{
		return this.HHDEDMFJPNE;
	}

	// Token: 0x06009C86 RID: 40070 RVA: 0x004386FC File Offset: 0x004368FC
	public void DFGDMBHEBPN()
	{
		this.FJJBPIJFLJA();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.FGIDLGIPKGG();
		if (null != this.HHDEDMFJPNE)
		{
			this.HHDEDMFJPNE.enabled = this.bloomOptimized[(int)kgiedhdalbm];
		}
		if (null != this.OIFCMKDJLHI)
		{
			this.OIFCMKDJLHI.enabled = this.bloom[(int)kgiedhdalbm];
		}
		if (null != this.HGIDMONOBOL)
		{
			this.HGIDMONOBOL.enabled = this.blurOptimized[(int)kgiedhdalbm];
		}
		if (null != this.JIMDOMJOCLF)
		{
			this.JIMDOMJOCLF.enabled = this.vignetteAndChromaticAberation[(int)kgiedhdalbm];
		}
		if (null != this.GOLJDIADJFH)
		{
			this.GOLJDIADJFH.enabled = this.noiseAndGrain[(int)kgiedhdalbm];
		}
		if (null != this.PJOBCHFCIGC)
		{
			this.PJOBCHFCIGC.enabled = this.grayscale[(int)kgiedhdalbm];
		}
		if (null != this.JBGPOFKDEJO)
		{
			this.JBGPOFKDEJO.enabled = this.teal[(int)kgiedhdalbm];
		}
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

	// Token: 0x06009C87 RID: 40071 RVA: 0x004373D0 File Offset: 0x004355D0
	public Grayscale PBOKEPGFFHP()
	{
		return this.PJOBCHFCIGC;
	}

	// Token: 0x06009C88 RID: 40072 RVA: 0x00438904 File Offset: 0x00436B04
	public void AAJFMAPMINO()
	{
		if (!this.JIEPCIDINEH)
		{
			this.JIEPCIDINEH = true;
			this.HHDEDMFJPNE = base.gameObject.GetComponent<BloomOptimized>();
			this.OIFCMKDJLHI = base.gameObject.GetComponent<Bloom>();
			this.HGIDMONOBOL = base.gameObject.GetComponent<BlurOptimized>();
			this.JIMDOMJOCLF = base.gameObject.GetComponent<VignetteAndChromaticAberration>();
			this.GOLJDIADJFH = base.gameObject.GetComponent<NoiseAndGrain>();
			this.PJOBCHFCIGC = base.gameObject.GetComponent<Grayscale>();
			this.JBGPOFKDEJO = base.gameObject.GetComponent<TealTone>();
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
				this.JEAALFEOJHD();
			}
		}
	}

	// Token: 0x06009C89 RID: 40073 RVA: 0x00435A8C File Offset: 0x00433C8C
	public TealTone OLLIHDPKGLH()
	{
		return this.JBGPOFKDEJO;
	}

	// Token: 0x06009C8A RID: 40074 RVA: 0x00438A30 File Offset: 0x00436C30
	public void DNPGILIDLGJ()
	{
		this.AAJFMAPMINO();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.JJIAJCCLPMM();
		if (null != this.HHDEDMFJPNE)
		{
			this.HHDEDMFJPNE.enabled = this.bloomOptimized[(int)kgiedhdalbm];
		}
		if (null != this.OIFCMKDJLHI)
		{
			this.OIFCMKDJLHI.enabled = this.bloom[(int)kgiedhdalbm];
		}
		if (null != this.HGIDMONOBOL)
		{
			this.HGIDMONOBOL.enabled = this.blurOptimized[(int)kgiedhdalbm];
		}
		if (null != this.JIMDOMJOCLF)
		{
			this.JIMDOMJOCLF.enabled = this.vignetteAndChromaticAberation[(int)kgiedhdalbm];
		}
		if (null != this.GOLJDIADJFH)
		{
			this.GOLJDIADJFH.enabled = this.noiseAndGrain[(int)kgiedhdalbm];
		}
		if (null != this.PJOBCHFCIGC)
		{
			this.PJOBCHFCIGC.enabled = this.grayscale[(int)kgiedhdalbm];
		}
		if (null != this.JBGPOFKDEJO)
		{
			this.JBGPOFKDEJO.enabled = this.teal[(int)kgiedhdalbm];
		}
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

	// Token: 0x06009C8B RID: 40075 RVA: 0x00435BD8 File Offset: 0x00433DD8
	public BlurOptimized JBBMGIECOJF()
	{
		return this.HGIDMONOBOL;
	}

	// Token: 0x06009C8C RID: 40076 RVA: 0x004373D0 File Offset: 0x004355D0
	public Grayscale GetGrayscaleEffect()
	{
		return this.PJOBCHFCIGC;
	}

	// Token: 0x06009C8D RID: 40077 RVA: 0x00438C38 File Offset: 0x00436E38
	public void CGJINHCNPCA(string JCFOOJCGKMO = "")
	{
		if (null != this.HHDEDMFJPNE && this.bloomOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HHDEDMFJPNE.enabled = false;
		}
		if (null != this.OIFCMKDJLHI && this.bloomTag.Equals(JCFOOJCGKMO))
		{
			this.OIFCMKDJLHI.enabled = true;
		}
		if (null != this.HGIDMONOBOL && this.blurOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HGIDMONOBOL.enabled = false;
		}
		if (null != this.JIMDOMJOCLF && this.vignetteAndChromaticAberationTag.Equals(JCFOOJCGKMO))
		{
			this.JIMDOMJOCLF.enabled = true;
		}
		if (null != this.GOLJDIADJFH && this.noiseAndGrainTag.Equals(JCFOOJCGKMO))
		{
			this.GOLJDIADJFH.enabled = true;
		}
		if (null != this.PJOBCHFCIGC && this.grayscaleTag.Equals(JCFOOJCGKMO))
		{
			this.PJOBCHFCIGC.enabled = true;
		}
		if (null != this.JBGPOFKDEJO && this.tealTag.Equals(JCFOOJCGKMO))
		{
			this.JBGPOFKDEJO.enabled = false;
		}
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
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x06009C8E RID: 40078 RVA: 0x00438EA0 File Offset: 0x004370A0
	public void MPPOKGDIMMG(string JCFOOJCGKMO = "")
	{
		if (null != this.HHDEDMFJPNE && this.bloomOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HHDEDMFJPNE.enabled = false;
		}
		if (null != this.OIFCMKDJLHI && this.bloomTag.Equals(JCFOOJCGKMO))
		{
			this.OIFCMKDJLHI.enabled = false;
		}
		if (null != this.HGIDMONOBOL && this.blurOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HGIDMONOBOL.enabled = true;
		}
		if (null != this.JIMDOMJOCLF && this.vignetteAndChromaticAberationTag.Equals(JCFOOJCGKMO))
		{
			this.JIMDOMJOCLF.enabled = true;
		}
		if (null != this.GOLJDIADJFH && this.noiseAndGrainTag.Equals(JCFOOJCGKMO))
		{
			this.GOLJDIADJFH.enabled = false;
		}
		if (null != this.PJOBCHFCIGC && this.grayscaleTag.Equals(JCFOOJCGKMO))
		{
			this.PJOBCHFCIGC.enabled = false;
		}
		if (null != this.JBGPOFKDEJO && this.tealTag.Equals(JCFOOJCGKMO))
		{
			this.JBGPOFKDEJO.enabled = false;
		}
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

	// Token: 0x06009C8F RID: 40079 RVA: 0x00439108 File Offset: 0x00437308
	public void ODJNJHCNMFG(string JCFOOJCGKMO = "")
	{
		this.GFMDFJCFMGI();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.FGIDLGIPKGG();
		if (null != this.HHDEDMFJPNE && this.bloomOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HHDEDMFJPNE.enabled = this.bloomOptimized[(int)kgiedhdalbm];
		}
		if (null != this.OIFCMKDJLHI && this.bloomTag.Equals(JCFOOJCGKMO))
		{
			this.OIFCMKDJLHI.enabled = this.bloom[(int)kgiedhdalbm];
		}
		if (null != this.HGIDMONOBOL && this.blurOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HGIDMONOBOL.enabled = this.blurOptimized[(int)kgiedhdalbm];
		}
		if (null != this.JIMDOMJOCLF && this.vignetteAndChromaticAberationTag.Equals(JCFOOJCGKMO))
		{
			this.JIMDOMJOCLF.enabled = this.vignetteAndChromaticAberation[(int)kgiedhdalbm];
		}
		if (null != this.GOLJDIADJFH && this.noiseAndGrainTag.Equals(JCFOOJCGKMO))
		{
			this.GOLJDIADJFH.enabled = this.noiseAndGrain[(int)kgiedhdalbm];
		}
		if (null != this.PJOBCHFCIGC && this.grayscaleTag.Equals(JCFOOJCGKMO))
		{
			this.PJOBCHFCIGC.enabled = this.grayscale[(int)kgiedhdalbm];
		}
		if (null != this.JBGPOFKDEJO && this.tealTag.Equals(JCFOOJCGKMO))
		{
			this.JBGPOFKDEJO.enabled = this.teal[(int)kgiedhdalbm];
		}
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

	// Token: 0x06009C90 RID: 40080 RVA: 0x00435A9C File Offset: 0x00433C9C
	public VignetteAndChromaticAberration LNFMKCJFLKH()
	{
		return this.JIMDOMJOCLF;
	}

	// Token: 0x06009C91 RID: 40081 RVA: 0x004393E4 File Offset: 0x004375E4
	public void NILOLGICBNO(string JCFOOJCGKMO = "")
	{
		this.MJKIMLPDKGD();
		KGIEDHDALBM kgiedhdalbm = NBDLBFJOEGN.LFEOGELABLI();
		if (null != this.HHDEDMFJPNE && this.bloomOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HHDEDMFJPNE.enabled = this.bloomOptimized[(int)kgiedhdalbm];
		}
		if (null != this.OIFCMKDJLHI && this.bloomTag.Equals(JCFOOJCGKMO))
		{
			this.OIFCMKDJLHI.enabled = this.bloom[(int)kgiedhdalbm];
		}
		if (null != this.HGIDMONOBOL && this.blurOptimizedTag.Equals(JCFOOJCGKMO))
		{
			this.HGIDMONOBOL.enabled = this.blurOptimized[(int)kgiedhdalbm];
		}
		if (null != this.JIMDOMJOCLF && this.vignetteAndChromaticAberationTag.Equals(JCFOOJCGKMO))
		{
			this.JIMDOMJOCLF.enabled = this.vignetteAndChromaticAberation[(int)kgiedhdalbm];
		}
		if (null != this.GOLJDIADJFH && this.noiseAndGrainTag.Equals(JCFOOJCGKMO))
		{
			this.GOLJDIADJFH.enabled = this.noiseAndGrain[(int)kgiedhdalbm];
		}
		if (null != this.PJOBCHFCIGC && this.grayscaleTag.Equals(JCFOOJCGKMO))
		{
			this.PJOBCHFCIGC.enabled = this.grayscale[(int)kgiedhdalbm];
		}
		if (null != this.JBGPOFKDEJO && this.tealTag.Equals(JCFOOJCGKMO))
		{
			this.JBGPOFKDEJO.enabled = this.teal[(int)kgiedhdalbm];
		}
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

	// Token: 0x06009C92 RID: 40082 RVA: 0x004373D0 File Offset: 0x004355D0
	public Grayscale GLJJIADJHII()
	{
		return this.PJOBCHFCIGC;
	}

	// Token: 0x06009C93 RID: 40083 RVA: 0x004373D0 File Offset: 0x004355D0
	public Grayscale IGMKOOJDLPD()
	{
		return this.PJOBCHFCIGC;
	}

	// Token: 0x06009C94 RID: 40084 RVA: 0x00435E45 File Offset: 0x00434045
	public NoiseAndGrain GetNoiseAndGrainEffect()
	{
		return this.GOLJDIADJFH;
	}

	// Token: 0x06009C95 RID: 40085 RVA: 0x004396C0 File Offset: 0x004378C0
	public void HANKGPDCHDF()
	{
		if (null != this.OIFCMKDJLHI)
		{
			this.OIFCMKDJLHI.enabled = false;
		}
		if (null != this.HHDEDMFJPNE)
		{
			this.HHDEDMFJPNE.enabled = false;
		}
		if (null != this.HGIDMONOBOL)
		{
			this.HGIDMONOBOL.enabled = false;
		}
		if (null != this.JIMDOMJOCLF)
		{
			this.JIMDOMJOCLF.enabled = true;
		}
		if (null != this.GOLJDIADJFH)
		{
			this.GOLJDIADJFH.enabled = true;
		}
		if (null != this.PJOBCHFCIGC)
		{
			this.PJOBCHFCIGC.enabled = false;
		}
		if (null != this.JBGPOFKDEJO)
		{
			this.JBGPOFKDEJO.enabled = false;
		}
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
			this.FJALIDLOAEH.enabled = true;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x06009C96 RID: 40086 RVA: 0x00435A8C File Offset: 0x00433C8C
	public TealTone HGCCBKBDDND()
	{
		return this.JBGPOFKDEJO;
	}

	// Token: 0x06009C97 RID: 40087 RVA: 0x00435BD8 File Offset: 0x00433DD8
	public BlurOptimized FMHDFDEFGME()
	{
		return this.HGIDMONOBOL;
	}

	// Token: 0x06009C98 RID: 40088 RVA: 0x00439854 File Offset: 0x00437A54
	public void BEJEIHKMKNP()
	{
		if (null != this.OIFCMKDJLHI)
		{
			this.OIFCMKDJLHI.enabled = false;
		}
		if (null != this.HHDEDMFJPNE)
		{
			this.HHDEDMFJPNE.enabled = true;
		}
		if (null != this.HGIDMONOBOL)
		{
			this.HGIDMONOBOL.enabled = false;
		}
		if (null != this.JIMDOMJOCLF)
		{
			this.JIMDOMJOCLF.enabled = false;
		}
		if (null != this.GOLJDIADJFH)
		{
			this.GOLJDIADJFH.enabled = false;
		}
		if (null != this.PJOBCHFCIGC)
		{
			this.PJOBCHFCIGC.enabled = false;
		}
		if (null != this.JBGPOFKDEJO)
		{
			this.JBGPOFKDEJO.enabled = true;
		}
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
			this.LKEJJKIELBE.enabled = false;
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
			this.FJALIDLOAEH.enabled = false;
		}
		if (null != this.CPKMOBOLFCM)
		{
			this.CPKMOBOLFCM.enabled = true;
		}
	}

	// Token: 0x06009C99 RID: 40089 RVA: 0x004373C8 File Offset: 0x004355C8
	private void KBIIMONICOB()
	{
		this.JADFENJPAKL();
	}

	// Token: 0x06009C9A RID: 40090 RVA: 0x00435A94 File Offset: 0x00433C94
	public Bloom LKBJGDOGJEG()
	{
		return this.OIFCMKDJLHI;
	}

	// Token: 0x04002B5B RID: 11099
	public bool[] bloomOptimized = new bool[3];

	// Token: 0x04002B5C RID: 11100
	public string bloomOptimizedTag = "";

	// Token: 0x04002B5D RID: 11101
	public bool[] bloom = new bool[3];

	// Token: 0x04002B5E RID: 11102
	public string bloomTag = "";

	// Token: 0x04002B5F RID: 11103
	public bool[] blurOptimized = new bool[3];

	// Token: 0x04002B60 RID: 11104
	public string blurOptimizedTag = "";

	// Token: 0x04002B61 RID: 11105
	public bool[] vignetteAndChromaticAberation = new bool[3];

	// Token: 0x04002B62 RID: 11106
	public string vignetteAndChromaticAberationTag = "";

	// Token: 0x04002B63 RID: 11107
	public bool[] noiseAndGrain = new bool[3];

	// Token: 0x04002B64 RID: 11108
	public string noiseAndGrainTag = "";

	// Token: 0x04002B65 RID: 11109
	public bool[] grayscale = new bool[3];

	// Token: 0x04002B66 RID: 11110
	public string grayscaleTag = "";

	// Token: 0x04002B67 RID: 11111
	public bool[] teal = new bool[3];

	// Token: 0x04002B68 RID: 11112
	public string tealTag = "";

	// Token: 0x04002B69 RID: 11113
	public bool[] analogGlitch = new bool[3];

	// Token: 0x04002B6A RID: 11114
	public string analogGlitchTag = "";

	// Token: 0x04002B6B RID: 11115
	public bool[] analogGlitch20 = new bool[3];

	// Token: 0x04002B6C RID: 11116
	public string analogGlitch20Tag = "";

	// Token: 0x04002B6D RID: 11117
	public bool[] digitalGlitch = new bool[3];

	// Token: 0x04002B6E RID: 11118
	public string digitalGlitchTag = "";

	// Token: 0x04002B6F RID: 11119
	public bool[] videoGlitchNoiseAnalog = new bool[3];

	// Token: 0x04002B70 RID: 11120
	public string videoGlitchNoiseAnalogTag = "";

	// Token: 0x04002B71 RID: 11121
	public bool[] videoGlitchNoiseDigital = new bool[3];

	// Token: 0x04002B72 RID: 11122
	public string videoGlitchNoiseDigitalTag = "";

	// Token: 0x04002B73 RID: 11123
	public bool[] videoGlitchOldVHS = new bool[3];

	// Token: 0x04002B74 RID: 11124
	public string videoGlitchOldVHSTag = "";

	// Token: 0x04002B75 RID: 11125
	public bool[] videoGlitchSpectrumOffset = new bool[3];

	// Token: 0x04002B76 RID: 11126
	public string videoGlitchSpectrumOffsetTag = "";

	// Token: 0x04002B77 RID: 11127
	public bool[] videoGlitchVHSPause = new bool[3];

	// Token: 0x04002B78 RID: 11128
	public string videoGlitchVHSPauseTag = "";

	// Token: 0x04002B79 RID: 11129
	public bool showOnAwake = true;

	// Token: 0x04002B7A RID: 11130
	private BloomOptimized HHDEDMFJPNE;

	// Token: 0x04002B7B RID: 11131
	private Bloom OIFCMKDJLHI;

	// Token: 0x04002B7C RID: 11132
	private BlurOptimized HGIDMONOBOL;

	// Token: 0x04002B7D RID: 11133
	private VignetteAndChromaticAberration JIMDOMJOCLF;

	// Token: 0x04002B7E RID: 11134
	private NoiseAndGrain GOLJDIADJFH;

	// Token: 0x04002B7F RID: 11135
	private Grayscale PJOBCHFCIGC;

	// Token: 0x04002B80 RID: 11136
	private TealTone JBGPOFKDEJO;

	// Token: 0x04002B81 RID: 11137
	private AnalogGlitch BKKHJBIEGCB;

	// Token: 0x04002B82 RID: 11138
	private AnalogGlitch20 CGJIPMFMGCJ;

	// Token: 0x04002B83 RID: 11139
	private DigitalGlitch PBCLCNKNMHA;

	// Token: 0x04002B84 RID: 11140
	private VideoGlitchNoiseAnalog LKEJJKIELBE;

	// Token: 0x04002B85 RID: 11141
	private VideoGlitchNoiseDigital MKCPLGOKFAD;

	// Token: 0x04002B86 RID: 11142
	private VideoGlitchOldVHS KGJKOHPGKFF;

	// Token: 0x04002B87 RID: 11143
	private VideoGlitchSpectrumOffset FJALIDLOAEH;

	// Token: 0x04002B88 RID: 11144
	private VideoGlitchVHSPause CPKMOBOLFCM;

	// Token: 0x04002B89 RID: 11145
	private bool JIEPCIDINEH;
}
