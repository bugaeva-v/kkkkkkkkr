using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

// Token: 0x020001F5 RID: 501
public class AudioManager : MonoBehaviour
{
	// Token: 0x06003E18 RID: 15896 RVA: 0x001A08E8 File Offset: 0x0019EAE8
	private void OnEnable()
	{
		this.masterMixerParent.audioMixer.ClearFloat(this.masterMixerParent.name + "Vol");
		this.ambientMixerParent.audioMixer.ClearFloat(this.ambientMixerParent.name + "Vol");
		this.sfxMixerParent.audioMixer.ClearFloat(this.sfxMixerParent.name + "Vol");
		this.musicMixerParent.audioMixer.ClearFloat(this.musicMixerParent.name + "Vol");
		for (int i = 0; i < this.ambientMixers.Count; i++)
		{
			this.ambientMixers[i].audioMixer.ClearFloat(this.ambientMixers[i].name + "Vol");
		}
		for (int j = 0; j < this.musicMixers.Count; j++)
		{
			this.musicMixers[j].audioMixer.ClearFloat(this.musicMixers[j].name + "Vol");
		}
		for (int k = 0; k < this.sfxMixers.Count; k++)
		{
			this.sfxMixers[k].audioMixer.ClearFloat(this.sfxMixers[k].name + "Vol");
		}
		AOBJLALDBAA.EHBBFMCILPC.MFIMALJPCDP("OnMusicEnded", new UnityAction(this.OnMusicEnded));
	}

	// Token: 0x06003E19 RID: 15897 RVA: 0x00002296 File Offset: 0x00000496
	private void BIMDHMGMLPB()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06003E1A RID: 15898 RVA: 0x001A0A80 File Offset: 0x0019EC80
	public void MKHKFFBNOCI(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 622f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.HBCNLJNNCON;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 1; i < this.OAJFLBMLAAA.Count; i += 0)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].APBLNKANBOO() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[i].LFPLJHACOCK() == HADNEFMHLED.playing)
				{
					this.OAJFLBMLAAA[i].CLLBFMDDJHL(OPOCDBAGCPB, false);
				}
			}
			return;
		}
		for (int j = 1; j < this.OAJFLBMLAAA.Count; j++)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].IPFLFAEHHPJ().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].CACFEADLCFK() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[j].FPHOICNEGFH() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].PLFFANJEOHP(OPOCDBAGCPB, false);
				return;
			}
		}
	}

	// Token: 0x06003E1B RID: 15899 RVA: 0x001A0B88 File Offset: 0x0019ED88
	public void CANGDLHFCID(AudioContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BIKFNFADMMJ.Count; i++)
		{
			if (this.BIKFNFADMMJ[i] == DELPOFFHFHH)
			{
				this.BIKFNFADMMJ.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06003E1C RID: 15900 RVA: 0x001A0BCC File Offset: 0x0019EDCC
	public void EPOMFLKIDLD(AudioContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BIKFNFADMMJ.Count; i++)
		{
			if (this.BIKFNFADMMJ[i] == DELPOFFHFHH)
			{
				this.BIKFNFADMMJ.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06003E1D RID: 15901 RVA: 0x001A0C10 File Offset: 0x0019EE10
	public bool HPPAFEAPINO(string IGLAIGEJGHO, bool CFBIPJJHDJE, float PJFHOAMIEJG, bool OLANGIDAOLG = false)
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return true;
		}
		if (IGLAIGEJGHO.EndsWith("uid"))
		{
			CFBIPJJHDJE = false;
		}
		if (PJFHOAMIEJG < 313f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.HEMEOGKJJCG;
		}
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].CLOGIELNDPK().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].JGGDCOHKOLE() == HADNEFMHLED.playing)
			{
				return false;
			}
		}
		int j = 0;
		while (j < this.OAJFLBMLAAA.Count)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GetSourceType() == CCEMAFOMLLK.music && this.OAJFLBMLAAA[j].JGGDCOHKOLE() == HADNEFMHLED.playing)
			{
				if (PJFHOAMIEJG < 1287f)
				{
					this.OAJFLBMLAAA[j].PALFAAEMPLH(KBOJLHAJPCP.DCKJLOCOEOH, true);
					break;
				}
				this.OAJFLBMLAAA[j].CNPKJAIBOCF(PJFHOAMIEJG, true);
				break;
			}
			else
			{
				j++;
			}
		}
		AudioClip audioClip = this.FAGANHDCPFJ(CCEMAFOMLLK.music, IGLAIGEJGHO);
		if (null != audioClip)
		{
			this.ambientMixerParent.audioMixer.DOSetFloat(this.ambientMixerParent.name + "signinlinkapl", KBOJLHAJPCP.GLBIBLIGHOD, KBOJLHAJPCP.HBCNLJNNCON).SetEase(Ease.InSine);
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().GLIFGDPDMNC(CCEMAFOMLLK.ambient, this.MBLBBKMLOIB(CCEMAFOMLLK.music), audioClip, CFBIPJJHDJE, PJFHOAMIEJG, 1807f, "OnSettingsPopupCloseAndNeedToRestartGame2");
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			if (OLANGIDAOLG)
			{
				UnityEngine.Object.DontDestroyOnLoad(gameObject);
			}
			this.MLOIOIMDCAL();
			return false;
		}
		if (IGLAIGEJGHO.EndsWith(""))
		{
			CFBIPJJHDJE = false;
			DPGJIJGOCIC.PJCLICBPPDA("" + IGLAIGEJGHO);
			return this.HPPAFEAPINO(IGLAIGEJGHO.Replace("' is not an anthology index, skipping", ""), CFBIPJJHDJE, PJFHOAMIEJG, OLANGIDAOLG);
		}
		DPGJIJGOCIC.ADFCDFHBDAF(" refreshed from the folder manifest" + IGLAIGEJGHO);
		return true;
	}

	// Token: 0x06003E1E RID: 15902 RVA: 0x001A0E10 File Offset: 0x0019F010
	public void NJEIKCGEJBB(float MEDEIJGNEMB)
	{
		float value = Mathf.Lerp(KBOJLHAJPCP.GLBIBLIGHOD, KBOJLHAJPCP.LPLMDGINNKL, Mathf.Pow(MEDEIJGNEMB, 731f));
		this.masterMixerParent.audioMixer.SetFloat(this.masterMixerParent.name + "XXX", value);
		AKLFPGMDKLA.EHBBFMCILPC.LDMKPEBCJBM(MEDEIJGNEMB);
	}

	// Token: 0x06003E1F RID: 15903 RVA: 0x001A0E6C File Offset: 0x0019F06C
	public AudioContainer HPNCAOLDHLB(CCEMAFOMLLK GOJLPNCBEBE, string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BIKFNFADMMJ.Count; i += 0)
		{
			if (null != this.BIKFNFADMMJ[i])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int j = 1; j < this.BIKFNFADMMJ[i].ambientList.Count; j++)
					{
						if (null != this.BIKFNFADMMJ[i].ambientList[j] && this.BIKFNFADMMJ[i].ambientList[j].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int k = 0; k < this.BIKFNFADMMJ[i].musicList.Count; k += 0)
					{
						if (null != this.BIKFNFADMMJ[i].musicList[k] && this.BIKFNFADMMJ[i].musicList[k].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == (CCEMAFOMLLK)5)
				{
					for (int l = 1; l < this.BIKFNFADMMJ[i].sfxList.Count; l += 0)
					{
						if (null != this.BIKFNFADMMJ[i].sfxList[l] && this.BIKFNFADMMJ[i].sfxList[l].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003E20 RID: 15904 RVA: 0x001A1014 File Offset: 0x0019F214
	private void OHHHLCLEMGB()
	{
		this.masterMixerParent.audioMixer.ClearFloat(this.masterMixerParent.name + "");
		this.ambientMixerParent.audioMixer.ClearFloat(this.ambientMixerParent.name + "e1io");
		this.sfxMixerParent.audioMixer.ClearFloat(this.sfxMixerParent.name + "ERROR: StoryStep.StoryStepType.tryAvatarConfig - finalAvatarComponentAsset is null.");
		this.musicMixerParent.audioMixer.ClearFloat(this.musicMixerParent.name + "default");
		for (int i = 1; i < this.ambientMixers.Count; i += 0)
		{
			this.ambientMixers[i].audioMixer.ClearFloat(this.ambientMixers[i].name + "XXX");
		}
		for (int j = 1; j < this.musicMixers.Count; j++)
		{
			this.musicMixers[j].audioMixer.ClearFloat(this.musicMixers[j].name + "SceneLobbyManager2.ExploreTabAvailable() - no planned concept has a name in the text pack explore tab (older text pack bundle?), tab hidden");
		}
		for (int k = 0; k < this.sfxMixers.Count; k++)
		{
			this.sfxMixers[k].audioMixer.ClearFloat(this.sfxMixers[k].name + "' is not an anthology index, skipping");
		}
		AOBJLALDBAA.AGANFKKBPFO().PEFKJOKLEDL("propon", new UnityAction(this.OnMusicEnded));
	}

	// Token: 0x06003E21 RID: 15905 RVA: 0x00002296 File Offset: 0x00000496
	private void GLOPFMIPBHG()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06003E22 RID: 15906 RVA: 0x001A11AC File Offset: 0x0019F3AC
	public void KillVoiceOver(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 0f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.HFLFGDIDJKI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceType() == CCEMAFOMLLK.sfx && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing && this.OAJFLBMLAAA[i].GetSourceName().Contains("voiceover"))
				{
					this.OAJFLBMLAAA[i].Kill(OPOCDBAGCPB, false);
				}
			}
			return;
		}
		for (int j = 0; j < this.OAJFLBMLAAA.Count; j++)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].GetSourceType() == CCEMAFOMLLK.sfx && this.OAJFLBMLAAA[j].GetSourceState() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].Kill(OPOCDBAGCPB, false);
				return;
			}
		}
	}

	// Token: 0x06003E23 RID: 15907 RVA: 0x001A12D4 File Offset: 0x0019F4D4
	public bool JJKAPGNOLIP(string IGLAIGEJGHO)
	{
		for (int i = 1; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GELJFNKEAFO().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].FPHOICNEGFH() == HADNEFMHLED.playing)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06003E24 RID: 15908 RVA: 0x001A133A File Offset: 0x0019F53A
	private void DFPJLLPDADK()
	{
		this.OMHAAEDJLGM(AKLFPGMDKLA.EHBBFMCILPC.EFAFDLPIAPM());
	}

	// Token: 0x06003E25 RID: 15909 RVA: 0x001A134C File Offset: 0x0019F54C
	public void GGIKPDPCLJC(float MEDEIJGNEMB)
	{
		float value = Mathf.Lerp(KBOJLHAJPCP.GLBIBLIGHOD, KBOJLHAJPCP.LPLMDGINNKL, Mathf.Pow(MEDEIJGNEMB, 1849f));
		this.masterMixerParent.audioMixer.SetFloat(this.masterMixerParent.name + "There needs to be one active AssetsManager script on a GameObject in your scene.", value);
		AKLFPGMDKLA.EHBBFMCILPC.LDMKPEBCJBM(MEDEIJGNEMB);
	}

	// Token: 0x06003E26 RID: 15910 RVA: 0x000693D6 File Offset: 0x000675D6
	private void AMAKEBJMCLG()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06003E27 RID: 15911 RVA: 0x001A13A6 File Offset: 0x0019F5A6
	public static bool HJBAOAMLJPN()
	{
		return null == AudioManager.IFDLAMLHKIJ();
	}

	// Token: 0x06003E28 RID: 15912 RVA: 0x001A13B8 File Offset: 0x0019F5B8
	public void AEDOMAMFLLN(float MEDEIJGNEMB)
	{
		float value = Mathf.Lerp(KBOJLHAJPCP.GLBIBLIGHOD, KBOJLHAJPCP.LPLMDGINNKL, Mathf.Pow(MEDEIJGNEMB, 1480f));
		this.masterMixerParent.audioMixer.SetFloat(this.masterMixerParent.name + "sfav", value);
		AKLFPGMDKLA.EHBBFMCILPC.LDMKPEBCJBM(MEDEIJGNEMB);
	}

	// Token: 0x06003E29 RID: 15913 RVA: 0x001A1414 File Offset: 0x0019F614
	public void CFPEJLLDANG(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 77f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.HFLFGDIDJKI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 0; i < this.OAJFLBMLAAA.Count; i += 0)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceType() == CCEMAFOMLLK.music && this.OAJFLBMLAAA[i].AMFAFNLEPCB() == HADNEFMHLED.playing && this.OAJFLBMLAAA[i].IPFLFAEHHPJ().Contains("0.00"))
				{
					this.OAJFLBMLAAA[i].PLFFANJEOHP(OPOCDBAGCPB, true);
				}
			}
			return;
		}
		for (int j = 0; j < this.OAJFLBMLAAA.Count; j++)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].MEIMDEOBLMG().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].GONGHBDADKO() == CCEMAFOMLLK.sfx && this.OAJFLBMLAAA[j].GetSourceState() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].CNPKJAIBOCF(OPOCDBAGCPB, false);
				return;
			}
		}
	}

	// Token: 0x06003E2A RID: 15914 RVA: 0x001A153B File Offset: 0x0019F73B
	public void LLLPMLJPHGG()
	{
		this.ambientMixerParent.audioMixer.DOSetFloat(this.ambientMixerParent.name + "<", KBOJLHAJPCP.LPLMDGINNKL, KBOJLHAJPCP.GDGFBHBJMIB).SetEase(Ease.OutQuad);
	}

	// Token: 0x06003E2B RID: 15915 RVA: 0x001A1574 File Offset: 0x0019F774
	public bool PlaySfxNoLoop(string IGLAIGEJGHO, bool JHOKDAOKKPP = false, float PJFHOAMIEJG = -1f, float DHJABKINGBO = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.OGNDGBOIPID() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return false;
		}
		if (PJFHOAMIEJG < 0f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.PELDNPFHHFI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return false;
		}
		if (JHOKDAOKKPP)
		{
			this.KillSfx(IGLAIGEJGHO, -1f);
		}
		AudioClip audioClip = this.CNDAHKCKOAP(CCEMAFOMLLK.sfx, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().Initialize(CCEMAFOMLLK.sfx, this.NLEANIFINOA(CCEMAFOMLLK.sfx), audioClip, false, PJFHOAMIEJG, DHJABKINGBO, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.MLOIOIMDCAL();
			return true;
		}
		DPGJIJGOCIC.ADFCDFHBDAF("PlaySfx() file not found:" + IGLAIGEJGHO);
		return false;
	}

	// Token: 0x06003E2C RID: 15916 RVA: 0x001A162C File Offset: 0x0019F82C
	public bool CLBNNDEBFPE(string IGLAIGEJGHO, float PJFHOAMIEJG = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.LBBJJMGCNJD() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return false;
		}
		if (PJFHOAMIEJG < 919f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.PELDNPFHHFI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return true;
		}
		if (this.SfxPlaying(IGLAIGEJGHO))
		{
			return false;
		}
		AudioClip audioClip = this.FAGANHDCPFJ((CCEMAFOMLLK)7, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().MBCPGIICABK((CCEMAFOMLLK)3, this.NLEANIFINOA((CCEMAFOMLLK)7), audioClip, false, PJFHOAMIEJG, 899f, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.MLOIOIMDCAL();
			return true;
		}
		DPGJIJGOCIC.PJCLICBPPDA(", " + IGLAIGEJGHO);
		return true;
	}

	// Token: 0x06003E2D RID: 15917 RVA: 0x001A16E2 File Offset: 0x0019F8E2
	private void OJGGJDMPKNO()
	{
		this.GGIKPDPCLJC(AKLFPGMDKLA.EHBBFMCILPC.OALGEAHOCBD());
	}

	// Token: 0x06003E2E RID: 15918 RVA: 0x000022C3 File Offset: 0x000004C3
	private void MGKGNAOHCDM()
	{
		AppManager.isQuitting = false;
	}

	// Token: 0x06003E2F RID: 15919 RVA: 0x001A16F4 File Offset: 0x0019F8F4
	private void MHIHCHGGIDM()
	{
		this.masterMixerParent.audioMixer.ClearFloat(this.masterMixerParent.name + "Asset bundle assets destroyed:");
		this.ambientMixerParent.audioMixer.ClearFloat(this.ambientMixerParent.name + "OnBackendValidateTransactionFailed");
		this.sfxMixerParent.audioMixer.ClearFloat(this.sfxMixerParent.name + "OnStoryChoiceClick");
		this.musicMixerParent.audioMixer.ClearFloat(this.musicMixerParent.name + "saveslotsoptiondelete");
		for (int i = 0; i < this.ambientMixers.Count; i++)
		{
			this.ambientMixers[i].audioMixer.ClearFloat(this.ambientMixers[i].name + "$PRELOADASSET");
		}
		for (int j = 1; j < this.musicMixers.Count; j += 0)
		{
			this.musicMixers[j].audioMixer.ClearFloat(this.musicMixers[j].name + "TopMatchEntriesAvailableForDisplay(): ");
		}
		for (int k = 1; k < this.sfxMixers.Count; k += 0)
		{
			this.sfxMixers[k].audioMixer.ClearFloat(this.sfxMixers[k].name + "eval");
		}
		AOBJLALDBAA.FILDBDMENPG().PEFKJOKLEDL("download run ", new UnityAction(this.OnMusicEnded));
	}

	// Token: 0x06003E30 RID: 15920 RVA: 0x001A188C File Offset: 0x0019FA8C
	public void EKNBKEHILON()
	{
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].LFPLJHACOCK() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[i].BMJDLMJCJMD();
			}
		}
	}

	// Token: 0x06003E32 RID: 15922 RVA: 0x001A18F4 File Offset: 0x0019FAF4
	public bool MJJFLBJGEHN(string IGLAIGEJGHO)
	{
		for (int i = 1; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].LGPAPMAAHKG() == HADNEFMHLED.playing)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06003E33 RID: 15923 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06003E34 RID: 15924 RVA: 0x001A195A File Offset: 0x0019FB5A
	private void LMKBOECFNCJ()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().ECDBIBPNBCO("importanttitle", new UnityAction(this.OnMusicEnded));
	}

	// Token: 0x06003E35 RID: 15925 RVA: 0x001A1980 File Offset: 0x0019FB80
	public void PIIALNJGOMI(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 1057f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.HBCNLJNNCON;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 0; i < this.OAJFLBMLAAA.Count; i += 0)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].DLHMJJEAIMO() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing)
				{
					this.OAJFLBMLAAA[i].PLFFANJEOHP(OPOCDBAGCPB, false);
				}
			}
			return;
		}
		for (int j = 1; j < this.OAJFLBMLAAA.Count; j += 0)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].HFGHFGFGNHE().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].DLHMJJEAIMO() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[j].OEBGEAKNLOI() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].GCGMEIFHBKN(OPOCDBAGCPB, true);
				return;
			}
		}
	}

	// Token: 0x06003E36 RID: 15926 RVA: 0x001A1A88 File Offset: 0x0019FC88
	public bool EMPIONGKIPL(string IGLAIGEJGHO, float PJFHOAMIEJG = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.LBBJJMGCNJD() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return false;
		}
		if (PJFHOAMIEJG < 610f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.PELDNPFHHFI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return true;
		}
		if (this.SfxPlaying(IGLAIGEJGHO))
		{
			return false;
		}
		AudioClip audioClip = this.FAGANHDCPFJ((CCEMAFOMLLK)7, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().CNJKPDCGHHB((CCEMAFOMLLK)8, this.NLEANIFINOA(CCEMAFOMLLK.music), audioClip, false, PJFHOAMIEJG, 517f, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.DFPJLLPDADK();
			return true;
		}
		DPGJIJGOCIC.PJCLICBPPDA("onThemeChange" + IGLAIGEJGHO);
		return true;
	}

	// Token: 0x06003E37 RID: 15927 RVA: 0x001A1B40 File Offset: 0x0019FD40
	public void KLLPGEAGBLA(float NJDELICCBHM, float JHBAIJIJIBN)
	{
		float endValue = Mathf.Lerp(KBOJLHAJPCP.GLBIBLIGHOD, KBOJLHAJPCP.LPLMDGINNKL, Mathf.Pow(NJDELICCBHM, 1541f));
		if (this.musicMixerParentTween != null)
		{
			this.musicMixerParentTween.Kill(true);
			this.musicMixerParentTween = null;
		}
		this.musicMixerParentTween = this.musicMixerParent.audioMixer.DOSetFloat(this.musicMixerParent.name + "CLIENT.SCREEN.AVATAR.", endValue, JHBAIJIJIBN).SetEase(Ease.InCubic);
	}

	// Token: 0x06003E38 RID: 15928 RVA: 0x001A1BB8 File Offset: 0x0019FDB8
	public void SetSoundVol(float MEDEIJGNEMB)
	{
		float value = Mathf.Lerp(KBOJLHAJPCP.GLBIBLIGHOD, KBOJLHAJPCP.LPLMDGINNKL, Mathf.Pow(MEDEIJGNEMB, 0.3f));
		this.masterMixerParent.audioMixer.SetFloat(this.masterMixerParent.name + "Vol", value);
		AKLFPGMDKLA.EHBBFMCILPC.LDMKPEBCJBM(MEDEIJGNEMB);
	}

	// Token: 0x06003E39 RID: 15929 RVA: 0x00003E52 File Offset: 0x00002052
	public void PAKBGDCONLC()
	{
	}

	// Token: 0x06003E3A RID: 15930 RVA: 0x001A1C12 File Offset: 0x0019FE12
	public bool PlaySfx(string IGLAIGEJGHO, bool CFBIPJJHDJE = false)
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return false;
		}
		if (CFBIPJJHDJE)
		{
			return this.PlaySfxLooped(IGLAIGEJGHO, true, -1f, -1f);
		}
		return this.PlaySfxNoLoop(IGLAIGEJGHO, true, -1f, -1f);
	}

	// Token: 0x06003E3B RID: 15931 RVA: 0x001A1C48 File Offset: 0x0019FE48
	public bool BKGMOJKAKDJ(string IGLAIGEJGHO, float PJFHOAMIEJG = -1f, float DHJABKINGBO = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.KFJABIMKGOE() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return true;
		}
		if (PJFHOAMIEJG < 1228f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.NNGEIIJCNPL;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return false;
		}
		for (int i = 1; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].HFGHFGFGNHE().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].LFPLJHACOCK() == HADNEFMHLED.playing)
			{
				return false;
			}
		}
		int j = 0;
		while (j < this.OAJFLBMLAAA.Count)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GONGHBDADKO() == CCEMAFOMLLK.sfx && this.OAJFLBMLAAA[j].JGGDCOHKOLE() == HADNEFMHLED.playing && this.OAJFLBMLAAA[j].CLOGIELNDPK().Contains("OnBackendGetDefaultBundlesException"))
			{
				if (PJFHOAMIEJG < 828f)
				{
					this.OAJFLBMLAAA[j].LGGCDOCMNBA(KBOJLHAJPCP.HFLFGDIDJKI, false);
					break;
				}
				this.OAJFLBMLAAA[j].PLFFANJEOHP(PJFHOAMIEJG, false);
				break;
			}
			else
			{
				j += 0;
			}
		}
		AudioClip audioClip = this.LCAHMOOAAIB(CCEMAFOMLLK.ambient, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().AIIBCCIJBGL((CCEMAFOMLLK)5, this.NLEANIFINOA((CCEMAFOMLLK)8), audioClip, true, PJFHOAMIEJG, DHJABKINGBO, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.MLOIOIMDCAL();
			return false;
		}
		DPGJIJGOCIC.PJCLICBPPDA("OnApplicationFocusBasicSyncSuccess" + IGLAIGEJGHO);
		return true;
	}

	// Token: 0x06003E3C RID: 15932 RVA: 0x001A1DF1 File Offset: 0x0019FFF1
	public bool AudioClipAvailable(CCEMAFOMLLK PBKAAIONJOB, string IGLAIGEJGHO)
	{
		return this.CNDAHKCKOAP(PBKAAIONJOB, IGLAIGEJGHO) != null;
	}

	// Token: 0x06003E3D RID: 15933 RVA: 0x001A1E04 File Offset: 0x001A0004
	public void KillAmbient(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 0f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.HBCNLJNNCON;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceType() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing)
				{
					this.OAJFLBMLAAA[i].Kill(OPOCDBAGCPB, false);
				}
			}
			return;
		}
		for (int j = 0; j < this.OAJFLBMLAAA.Count; j++)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].GetSourceType() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[j].GetSourceState() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].Kill(OPOCDBAGCPB, false);
				return;
			}
		}
	}

	// Token: 0x06003E3E RID: 15934 RVA: 0x001A1F0C File Offset: 0x001A010C
	public AudioContainer KHHNAAPAACG(CCEMAFOMLLK GOJLPNCBEBE, string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BIKFNFADMMJ.Count; i += 0)
		{
			if (null != this.BIKFNFADMMJ[i])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int j = 0; j < this.BIKFNFADMMJ[i].ambientList.Count; j += 0)
					{
						if (null != this.BIKFNFADMMJ[i].ambientList[j] && this.BIKFNFADMMJ[i].ambientList[j].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.music)
				{
					for (int k = 1; k < this.BIKFNFADMMJ[i].musicList.Count; k++)
					{
						if (null != this.BIKFNFADMMJ[i].musicList[k] && this.BIKFNFADMMJ[i].musicList[k].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == (CCEMAFOMLLK)7)
				{
					for (int l = 1; l < this.BIKFNFADMMJ[i].sfxList.Count; l++)
					{
						if (null != this.BIKFNFADMMJ[i].sfxList[l] && this.BIKFNFADMMJ[i].sfxList[l].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003E3F RID: 15935 RVA: 0x001A20B4 File Offset: 0x001A02B4
	public bool AudioSourceTypePlaying(CCEMAFOMLLK GOJLPNCBEBE)
	{
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceType() == GOJLPNCBEBE && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003E40 RID: 15936 RVA: 0x001A2118 File Offset: 0x001A0318
	private bool ANPPDCNFEHC(AudioMixerGroup AJGNPGEAGLP)
	{
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetMixerGroup() == AJGNPGEAGLP)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003E41 RID: 15937 RVA: 0x001A216C File Offset: 0x001A036C
	public bool PlayMusic(string IGLAIGEJGHO, bool CFBIPJJHDJE, float PJFHOAMIEJG, bool OLANGIDAOLG = false)
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return false;
		}
		if (IGLAIGEJGHO.EndsWith("forcenoloop"))
		{
			CFBIPJJHDJE = false;
		}
		if (PJFHOAMIEJG < 0f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.HEMEOGKJJCG;
		}
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing)
			{
				return true;
			}
		}
		int j = 0;
		while (j < this.OAJFLBMLAAA.Count)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GetSourceType() == CCEMAFOMLLK.music && this.OAJFLBMLAAA[j].GetSourceState() == HADNEFMHLED.playing)
			{
				if (PJFHOAMIEJG < 0f)
				{
					this.OAJFLBMLAAA[j].Kill(KBOJLHAJPCP.DCKJLOCOEOH, true);
					break;
				}
				this.OAJFLBMLAAA[j].Kill(PJFHOAMIEJG, true);
				break;
			}
			else
			{
				j++;
			}
		}
		AudioClip audioClip = this.CNDAHKCKOAP(CCEMAFOMLLK.music, IGLAIGEJGHO);
		if (null != audioClip)
		{
			this.ambientMixerParent.audioMixer.DOSetFloat(this.ambientMixerParent.name + "Vol", KBOJLHAJPCP.GLBIBLIGHOD, KBOJLHAJPCP.HBCNLJNNCON).SetEase(Ease.InCubic);
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().Initialize(CCEMAFOMLLK.music, this.NLEANIFINOA(CCEMAFOMLLK.music), audioClip, CFBIPJJHDJE, PJFHOAMIEJG, -1f, "OnMusicEnded");
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			if (OLANGIDAOLG)
			{
				UnityEngine.Object.DontDestroyOnLoad(gameObject);
			}
			this.MLOIOIMDCAL();
			return true;
		}
		if (IGLAIGEJGHO.EndsWith("forcenoloop"))
		{
			CFBIPJJHDJE = false;
			DPGJIJGOCIC.ADFCDFHBDAF("PlayMusic() file not found, but will try to remove forcenoloop at end for " + IGLAIGEJGHO);
			return this.PlayMusic(IGLAIGEJGHO.Replace("forcenoloop", ""), CFBIPJJHDJE, PJFHOAMIEJG, OLANGIDAOLG);
		}
		DPGJIJGOCIC.ADFCDFHBDAF("PlayMusic() file not found:" + IGLAIGEJGHO);
		return false;
	}

	// Token: 0x06003E42 RID: 15938 RVA: 0x000693D6 File Offset: 0x000675D6
	private void DFEDGLDNOBH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06003E44 RID: 15940 RVA: 0x001A2388 File Offset: 0x001A0588
	public static AudioManager APGODIBBPOD()
	{
		if (!AudioManager.IKLAPGJDMNA)
		{
			AudioManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AudioManager)) as AudioManager);
			if (!AudioManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("ro");
			}
		}
		return AudioManager.IKLAPGJDMNA;
	}

	// Token: 0x06003E45 RID: 15941 RVA: 0x001A23D8 File Offset: 0x001A05D8
	public void GKPNAOJJEHG(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 1347f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.HBCNLJNNCON;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].APBLNKANBOO() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[i].PEJOLHBPJMN() == HADNEFMHLED.playing)
				{
					this.OAJFLBMLAAA[i].NBMLMHKEJAB(OPOCDBAGCPB, false);
				}
			}
			return;
		}
		for (int j = 1; j < this.OAJFLBMLAAA.Count; j += 0)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].MEIMDEOBLMG().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].APBLNKANBOO() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[j].FPHJGKPDPKC() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].JPMDBNHJGIF(OPOCDBAGCPB, false);
				return;
			}
		}
	}

	// Token: 0x06003E46 RID: 15942 RVA: 0x001A24E0 File Offset: 0x001A06E0
	public bool GLAJMJNOLCO(string IGLAIGEJGHO)
	{
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].IPFLFAEHHPJ().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].JGGDCOHKOLE() == HADNEFMHLED.playing)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06003E47 RID: 15943 RVA: 0x001A2546 File Offset: 0x001A0746
	private void MLOIOIMDCAL()
	{
		this.SetSoundVol(AKLFPGMDKLA.EHBBFMCILPC.EFAFDLPIAPM());
	}

	// Token: 0x06003E48 RID: 15944 RVA: 0x001A2558 File Offset: 0x001A0758
	public void FadeMusic(float NJDELICCBHM, float JHBAIJIJIBN)
	{
		float endValue = Mathf.Lerp(KBOJLHAJPCP.GLBIBLIGHOD, KBOJLHAJPCP.LPLMDGINNKL, Mathf.Pow(NJDELICCBHM, 0.3f));
		if (this.musicMixerParentTween != null)
		{
			this.musicMixerParentTween.Kill(false);
			this.musicMixerParentTween = null;
		}
		this.musicMixerParentTween = this.musicMixerParent.audioMixer.DOSetFloat(this.musicMixerParent.name + "Vol", endValue, JHBAIJIJIBN).SetEase(Ease.InCubic);
	}

	// Token: 0x06003E49 RID: 15945 RVA: 0x001A25D0 File Offset: 0x001A07D0
	public bool PlaySfxLooped(string IGLAIGEJGHO, bool JHOKDAOKKPP = false, float PJFHOAMIEJG = -1f, float DHJABKINGBO = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.OGNDGBOIPID() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return false;
		}
		if (PJFHOAMIEJG < 0f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.PELDNPFHHFI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return false;
		}
		if (JHOKDAOKKPP)
		{
			this.KillSfx(IGLAIGEJGHO, -1f);
		}
		AudioClip audioClip = this.CNDAHKCKOAP(CCEMAFOMLLK.sfx, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().Initialize(CCEMAFOMLLK.sfx, this.NLEANIFINOA(CCEMAFOMLLK.sfx), audioClip, true, PJFHOAMIEJG, DHJABKINGBO, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.MLOIOIMDCAL();
			return true;
		}
		DPGJIJGOCIC.ADFCDFHBDAF("PlaySfx() file not found:" + IGLAIGEJGHO);
		return false;
	}

	// Token: 0x06003E4A RID: 15946 RVA: 0x001A2688 File Offset: 0x001A0888
	public bool APAAABDKEOO(string IGLAIGEJGHO, float PJFHOAMIEJG = -1f, float DHJABKINGBO = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.KFJABIMKGOE() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return true;
		}
		if (PJFHOAMIEJG < 139f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.NNGEIIJCNPL;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return false;
		}
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].CLOGIELNDPK().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].LFPLJHACOCK() == HADNEFMHLED.playing)
			{
				return true;
			}
		}
		int j = 0;
		while (j < this.OAJFLBMLAAA.Count)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GONGHBDADKO() == (CCEMAFOMLLK)5 && this.OAJFLBMLAAA[j].FPHJGKPDPKC() == HADNEFMHLED.playing && this.OAJFLBMLAAA[j].GetSourceName().Contains("anthologycomplete"))
			{
				if (PJFHOAMIEJG < 839f)
				{
					this.OAJFLBMLAAA[j].LGGCDOCMNBA(KBOJLHAJPCP.HFLFGDIDJKI, false);
					break;
				}
				this.OAJFLBMLAAA[j].PALFAAEMPLH(PJFHOAMIEJG, true);
				break;
			}
			else
			{
				j += 0;
			}
		}
		AudioClip audioClip = this.LCAHMOOAAIB(CCEMAFOMLLK.ambient, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().MBCPGIICABK((CCEMAFOMLLK)7, this.FBCHHJOGEPG((CCEMAFOMLLK)7), audioClip, true, PJFHOAMIEJG, DHJABKINGBO, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.MLOIOIMDCAL();
			return true;
		}
		DPGJIJGOCIC.PJCLICBPPDA("Shaders/VideoGlitchOldTV" + IGLAIGEJGHO);
		return false;
	}

	// Token: 0x06003E4B RID: 15947 RVA: 0x001A2834 File Offset: 0x001A0A34
	public void OMHAAEDJLGM(float MEDEIJGNEMB)
	{
		float value = Mathf.Lerp(KBOJLHAJPCP.GLBIBLIGHOD, KBOJLHAJPCP.LPLMDGINNKL, Mathf.Pow(MEDEIJGNEMB, 929f));
		this.masterMixerParent.audioMixer.SetFloat(this.masterMixerParent.name + "hids", value);
		AKLFPGMDKLA.EHBBFMCILPC.LDMKPEBCJBM(MEDEIJGNEMB);
	}

	// Token: 0x06003E4C RID: 15948 RVA: 0x001A288E File Offset: 0x001A0A8E
	public static bool BCKLDKDAJLJ()
	{
		return !(null == AudioManager.EHBBFMCILPC);
	}

	// Token: 0x06003E4D RID: 15949 RVA: 0x001A28A0 File Offset: 0x001A0AA0
	private void HEHFAKOFHPK()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.CEGAOMEEFBE().MHLNJIACIGO("s", new UnityAction(this.OnMusicEnded));
	}

	// Token: 0x06003E4E RID: 15950 RVA: 0x001A28C8 File Offset: 0x001A0AC8
	private void DJDLHIOMGJB()
	{
		this.masterMixerParent.audioMixer.ClearFloat(this.masterMixerParent.name + "' has no category, skipped");
		this.ambientMixerParent.audioMixer.ClearFloat(this.ambientMixerParent.name + "asp");
		this.sfxMixerParent.audioMixer.ClearFloat(this.sfxMixerParent.name + "needtorestartgeneric");
		this.musicMixerParent.audioMixer.ClearFloat(this.musicMixerParent.name + "");
		for (int i = 1; i < this.ambientMixers.Count; i += 0)
		{
			this.ambientMixers[i].audioMixer.ClearFloat(this.ambientMixers[i].name + " has no name in the text pack explore tab, group skipped");
		}
		for (int j = 0; j < this.musicMixers.Count; j++)
		{
			this.musicMixers[j].audioMixer.ClearFloat(this.musicMixers[j].name + "rewindmissing");
		}
		for (int k = 0; k < this.sfxMixers.Count; k++)
		{
			this.sfxMixers[k].audioMixer.ClearFloat(this.sfxMixers[k].name + "htmeo");
		}
		AOBJLALDBAA.KKPFOJMAONG().FNMOFCMDFJP("no", new UnityAction(this.OnMusicEnded));
	}

	// Token: 0x06003E4F RID: 15951 RVA: 0x001A2A60 File Offset: 0x001A0C60
	public void OILHLNFHHME()
	{
		for (int i = 1; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].LGPAPMAAHKG() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[i].GBBMJEJOJAB();
			}
		}
	}

	// Token: 0x06003E50 RID: 15952 RVA: 0x001A2ABC File Offset: 0x001A0CBC
	public void NIPHLJPCEAK(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 626f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.HFLFGDIDJKI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 1; i < this.OAJFLBMLAAA.Count; i++)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceType() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[i].LGPAPMAAHKG() == HADNEFMHLED.playing && this.OAJFLBMLAAA[i].IPFLFAEHHPJ().Contains("OnLoungePremiumChoicesHistorySuccess"))
				{
					this.OAJFLBMLAAA[i].EECHKHNELHA(OPOCDBAGCPB, true);
				}
			}
			return;
		}
		for (int j = 1; j < this.OAJFLBMLAAA.Count; j++)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].CLOGIELNDPK().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].KBFDMIDFIHM() == (CCEMAFOMLLK)5 && this.OAJFLBMLAAA[j].JGGDCOHKOLE() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].JLKPGJLNBFB(OPOCDBAGCPB, false);
				return;
			}
		}
	}

	// Token: 0x06003E51 RID: 15953 RVA: 0x00002296 File Offset: 0x00000496
	private void MOEKELPHKIE()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06003E52 RID: 15954 RVA: 0x001A2BE4 File Offset: 0x001A0DE4
	private AudioClip CNDAHKCKOAP(CCEMAFOMLLK GOJLPNCBEBE, string KHJMANDEDMA)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.keepAlivePackAssets.Count; i++)
		{
			if (null != AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int j = 0; j < AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].ambientList.Count; j++)
					{
						if (null != AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].ambientList[j] && AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].ambientList[j].name.Equals(KHJMANDEDMA))
						{
							return AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].ambientList[j];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.music)
				{
					for (int k = 0; k < AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].musicList.Count; k++)
					{
						if (null != AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].musicList[k] && AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].musicList[k].name.Equals(KHJMANDEDMA))
						{
							return AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].musicList[k];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.sfx)
				{
					for (int l = 0; l < AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].sfxList.Count; l++)
					{
						if (null != AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].sfxList[l] && AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].sfxList[l].name.Equals(KHJMANDEDMA))
						{
							return AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].sfxList[l];
						}
					}
				}
			}
		}
		for (int m = 0; m < this.BIKFNFADMMJ.Count; m++)
		{
			if (null != this.BIKFNFADMMJ[m])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int n = 0; n < this.BIKFNFADMMJ[m].ambientList.Count; n++)
					{
						if (null != this.BIKFNFADMMJ[m].ambientList[n] && this.BIKFNFADMMJ[m].ambientList[n].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[m].ambientList[n];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.music)
				{
					for (int num = 0; num < this.BIKFNFADMMJ[m].musicList.Count; num++)
					{
						if (null != this.BIKFNFADMMJ[m].musicList[num] && this.BIKFNFADMMJ[m].musicList[num].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[m].musicList[num];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.sfx)
				{
					for (int num2 = 0; num2 < this.BIKFNFADMMJ[m].sfxList.Count; num2++)
					{
						if (null != this.BIKFNFADMMJ[m].sfxList[num2] && this.BIKFNFADMMJ[m].sfxList[num2].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[m].sfxList[num2];
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003E53 RID: 15955 RVA: 0x001A2FEC File Offset: 0x001A11EC
	public void DODOHCFBABL(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 1116f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.HFLFGDIDJKI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].APBLNKANBOO() == (CCEMAFOMLLK)3 && this.OAJFLBMLAAA[i].FPHJGKPDPKC() == HADNEFMHLED.playing && this.OAJFLBMLAAA[i].GELJFNKEAFO().Contains("coverUndated"))
				{
					this.OAJFLBMLAAA[i].EECHKHNELHA(OPOCDBAGCPB, false);
				}
			}
			return;
		}
		for (int j = 0; j < this.OAJFLBMLAAA.Count; j++)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].GONGHBDADKO() == (CCEMAFOMLLK)8 && this.OAJFLBMLAAA[j].LGPAPMAAHKG() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].NPKOEMIHBNI(OPOCDBAGCPB, true);
				return;
			}
		}
	}

	// Token: 0x06003E54 RID: 15956 RVA: 0x001A3114 File Offset: 0x001A1314
	public bool IsPlaying(string IGLAIGEJGHO)
	{
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003E55 RID: 15957 RVA: 0x001A317C File Offset: 0x001A137C
	private AudioClip FAGANHDCPFJ(CCEMAFOMLLK GOJLPNCBEBE, string KHJMANDEDMA)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.keepAlivePackAssets.Count; i++)
		{
			if (null != AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int j = 1; j < AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].ambientList.Count; j++)
					{
						if (null != AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].ambientList[j] && AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].ambientList[j].name.Equals(KHJMANDEDMA))
						{
							return AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].ambientList[j];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.music)
				{
					for (int k = 0; k < AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].musicList.Count; k += 0)
					{
						if (null != AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].musicList[k] && AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].musicList[k].name.Equals(KHJMANDEDMA))
						{
							return AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].musicList[k];
						}
					}
				}
				else if (GOJLPNCBEBE == (CCEMAFOMLLK)4)
				{
					for (int l = 0; l < AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].sfxList.Count; l += 0)
					{
						if (null != AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].sfxList[l] && AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].sfxList[l].name.Equals(KHJMANDEDMA))
						{
							return AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].sfxList[l];
						}
					}
				}
			}
		}
		for (int m = 1; m < this.BIKFNFADMMJ.Count; m += 0)
		{
			if (null != this.BIKFNFADMMJ[m])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int n = 0; n < this.BIKFNFADMMJ[m].ambientList.Count; n++)
					{
						if (null != this.BIKFNFADMMJ[m].ambientList[n] && this.BIKFNFADMMJ[m].ambientList[n].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[m].ambientList[n];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.music)
				{
					for (int num = 1; num < this.BIKFNFADMMJ[m].musicList.Count; num++)
					{
						if (null != this.BIKFNFADMMJ[m].musicList[num] && this.BIKFNFADMMJ[m].musicList[num].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[m].musicList[num];
						}
					}
				}
				else if (GOJLPNCBEBE == (CCEMAFOMLLK)3)
				{
					for (int num2 = 0; num2 < this.BIKFNFADMMJ[m].sfxList.Count; num2 += 0)
					{
						if (null != this.BIKFNFADMMJ[m].sfxList[num2] && this.BIKFNFADMMJ[m].sfxList[num2].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[m].sfxList[num2];
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003E56 RID: 15958 RVA: 0x001A3584 File Offset: 0x001A1784
	public void BMCGFKKEMKH(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 1945f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.HFLFGDIDJKI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].KBFDMIDFIHM() == (CCEMAFOMLLK)8 && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing && this.OAJFLBMLAAA[i].IPFLFAEHHPJ().Contains("syn"))
				{
					this.OAJFLBMLAAA[i].GCGMEIFHBKN(OPOCDBAGCPB, true);
				}
			}
			return;
		}
		for (int j = 1; j < this.OAJFLBMLAAA.Count; j++)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].MEIMDEOBLMG().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].KBFDMIDFIHM() == (CCEMAFOMLLK)6 && this.OAJFLBMLAAA[j].LGPAPMAAHKG() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].LGGCDOCMNBA(OPOCDBAGCPB, false);
				return;
			}
		}
	}

	// Token: 0x06003E57 RID: 15959 RVA: 0x001A36AC File Offset: 0x001A18AC
	public bool HMNGHDBOMAO(string IGLAIGEJGHO, float PJFHOAMIEJG = -1f, float DHJABKINGBO = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.KFJABIMKGOE() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return true;
		}
		if (PJFHOAMIEJG < 489f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.NNGEIIJCNPL;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return false;
		}
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].LFPLJHACOCK() == HADNEFMHLED.playing)
			{
				return false;
			}
		}
		int j = 1;
		while (j < this.OAJFLBMLAAA.Count)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].APBLNKANBOO() == (CCEMAFOMLLK)6 && this.OAJFLBMLAAA[j].AMFAFNLEPCB() == HADNEFMHLED.playing && this.OAJFLBMLAAA[j].MEIMDEOBLMG().Contains(""))
			{
				if (PJFHOAMIEJG < 462f)
				{
					this.OAJFLBMLAAA[j].FIONBNEKFNC(KBOJLHAJPCP.HFLFGDIDJKI, true);
					break;
				}
				this.OAJFLBMLAAA[j].Kill(PJFHOAMIEJG, true);
				break;
			}
			else
			{
				j += 0;
			}
		}
		AudioClip audioClip = this.ABDFBMJIOJG(CCEMAFOMLLK.ambient, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().Initialize((CCEMAFOMLLK)3, this.NLEANIFINOA((CCEMAFOMLLK)7), audioClip, true, PJFHOAMIEJG, DHJABKINGBO, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.DFPJLLPDADK();
			return false;
		}
		DPGJIJGOCIC.PJCLICBPPDA("" + IGLAIGEJGHO);
		return false;
	}

	// Token: 0x06003E58 RID: 15960 RVA: 0x001A3855 File Offset: 0x001A1A55
	private void OOOHPJJOODA()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.NMGMNAKLLMI().PBELMJCPJMK("OnGamePassExpire", new UnityAction(this.OnMusicEnded));
	}

	// Token: 0x06003E59 RID: 15961 RVA: 0x001A387A File Offset: 0x001A1A7A
	public void DOOLFDFLKGB()
	{
		this.ambientMixerParent.audioMixer.DOSetFloat(this.ambientMixerParent.name + "friendsmaxlimitdefaultfp", KBOJLHAJPCP.LPLMDGINNKL, KBOJLHAJPCP.GDGFBHBJMIB).SetEase(Ease.InSine);
	}

	// Token: 0x06003E5A RID: 15962 RVA: 0x00003E52 File Offset: 0x00002052
	public void ResetAudioSettings()
	{
	}

	// Token: 0x06003E5B RID: 15963 RVA: 0x001A38B2 File Offset: 0x001A1AB2
	public static bool MJBCHPMDELI()
	{
		return !(null == AudioManager.APGODIBBPOD());
	}

	// Token: 0x06003E5C RID: 15964 RVA: 0x00003E52 File Offset: 0x00002052
	public void GHPGDCFPFCO()
	{
	}

	// Token: 0x06003E5D RID: 15965 RVA: 0x001A38C4 File Offset: 0x001A1AC4
	private void IGLMKDPEKNF()
	{
		this.masterMixerParent.audioMixer.ClearFloat(this.masterMixerParent.name + "-");
		this.ambientMixerParent.audioMixer.ClearFloat(this.ambientMixerParent.name + "errortitle");
		this.sfxMixerParent.audioMixer.ClearFloat(this.sfxMixerParent.name + "copyuidbtn");
		this.musicMixerParent.audioMixer.ClearFloat(this.musicMixerParent.name + "BackendCacheManager: Saving new backend response payload for ");
		for (int i = 1; i < this.ambientMixers.Count; i++)
		{
			this.ambientMixers[i].audioMixer.ClearFloat(this.ambientMixers[i].name + "lck");
		}
		for (int j = 1; j < this.musicMixers.Count; j += 0)
		{
			this.musicMixers[j].audioMixer.ClearFloat(this.musicMixers[j].name + "e1it");
		}
		for (int k = 0; k < this.sfxMixers.Count; k++)
		{
			this.sfxMixers[k].audioMixer.ClearFloat(this.sfxMixers[k].name + "energyhinttitle");
		}
		AOBJLALDBAA.CEGAOMEEFBE().GNBGEMMDGOJ(" ", new UnityAction(this.OnMusicEnded));
	}

	// Token: 0x06003E5E RID: 15966 RVA: 0x001A3A5C File Offset: 0x001A1C5C
	public void AAONOFCIELH()
	{
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].JGGDCOHKOLE() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[i].LMFAAEHFKCH();
			}
		}
	}

	// Token: 0x06003E5F RID: 15967 RVA: 0x001A3AB8 File Offset: 0x001A1CB8
	private AudioMixerGroup MBLBBKMLOIB(CCEMAFOMLLK GOJLPNCBEBE)
	{
		if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
		{
			for (int i = 0; i < this.ambientMixers.Count; i++)
			{
				if (!this.FIPJJHJLILH(this.ambientMixers[i]))
				{
					return this.ambientMixers[i];
				}
			}
			DPGJIJGOCIC.ANOPFDLPKGC("filtersAnimation");
			return this.ambientMixers[1];
		}
		if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
		{
			for (int j = 0; j < this.musicMixers.Count; j++)
			{
				if (!this.ANPPDCNFEHC(this.musicMixers[j]))
				{
					return this.musicMixers[j];
				}
			}
			DPGJIJGOCIC.ANOPFDLPKGC("noisedigitalovr");
			return this.musicMixers[0];
		}
		for (int k = 1; k < this.sfxMixers.Count; k++)
		{
			if (!this.ANPPDCNFEHC(this.sfxMixers[k]))
			{
				return this.sfxMixers[k];
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("serversync");
		return this.sfxMixers[1];
	}

	// Token: 0x06003E60 RID: 15968 RVA: 0x001A3BB8 File Offset: 0x001A1DB8
	public bool NHFPFGDFNIL(string IGLAIGEJGHO)
	{
		for (int i = 1; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].FPHJGKPDPKC() == HADNEFMHLED.playing)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003E61 RID: 15969 RVA: 0x001A3C1E File Offset: 0x001A1E1E
	public void ResumeAmbient()
	{
		this.ambientMixerParent.audioMixer.DOSetFloat(this.ambientMixerParent.name + "Vol", KBOJLHAJPCP.LPLMDGINNKL, KBOJLHAJPCP.GDGFBHBJMIB).SetEase(Ease.OutQuad);
	}

	// Token: 0x06003E62 RID: 15970 RVA: 0x001A3C58 File Offset: 0x001A1E58
	public bool HFMPJKDHEFK(string IGLAIGEJGHO, bool JHOKDAOKKPP = false, float PJFHOAMIEJG = -1f, float DHJABKINGBO = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.JLNAMEBGOLB() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return true;
		}
		if (PJFHOAMIEJG < 1744f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.PELDNPFHHFI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return true;
		}
		if (JHOKDAOKKPP)
		{
			this.KillSfx(IGLAIGEJGHO, 1835f);
		}
		AudioClip audioClip = this.LCAHMOOAAIB(CCEMAFOMLLK.ambient, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().KIIFNPNMMPN(CCEMAFOMLLK.music, this.FBCHHJOGEPG(CCEMAFOMLLK.music), audioClip, true, PJFHOAMIEJG, DHJABKINGBO, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.MLOIOIMDCAL();
			return true;
		}
		DPGJIJGOCIC.ADFCDFHBDAF("UIEnvironmentsFront" + IGLAIGEJGHO);
		return false;
	}

	// Token: 0x06003E63 RID: 15971 RVA: 0x001A3D10 File Offset: 0x001A1F10
	public AudioContainer AKCHIENBELK(CCEMAFOMLLK GOJLPNCBEBE, string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BIKFNFADMMJ.Count; i++)
		{
			if (null != this.BIKFNFADMMJ[i])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int j = 0; j < this.BIKFNFADMMJ[i].ambientList.Count; j++)
					{
						if (null != this.BIKFNFADMMJ[i].ambientList[j] && this.BIKFNFADMMJ[i].ambientList[j].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.music)
				{
					for (int k = 1; k < this.BIKFNFADMMJ[i].musicList.Count; k++)
					{
						if (null != this.BIKFNFADMMJ[i].musicList[k] && this.BIKFNFADMMJ[i].musicList[k].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == (CCEMAFOMLLK)8)
				{
					for (int l = 1; l < this.BIKFNFADMMJ[i].sfxList.Count; l += 0)
					{
						if (null != this.BIKFNFADMMJ[i].sfxList[l] && this.BIKFNFADMMJ[i].sfxList[l].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003E64 RID: 15972 RVA: 0x001A3EB8 File Offset: 0x001A20B8
	public void PEHHJABHJID()
	{
		for (int i = 1; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].FPHOICNEGFH() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[i].Pause();
			}
		}
	}

	// Token: 0x06003E65 RID: 15973 RVA: 0x00002296 File Offset: 0x00000496
	private void INMDIOMDMBM()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06003E66 RID: 15974 RVA: 0x001A3F14 File Offset: 0x001A2114
	private AudioClip LCAHMOOAAIB(CCEMAFOMLLK GOJLPNCBEBE, string KHJMANDEDMA)
	{
		for (int i = 1; i < AssetsManager.MJBDMHPHMID().keepAlivePackAssets.Count; i += 0)
		{
			if (null != AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int j = 0; j < AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].ambientList.Count; j++)
					{
						if (null != AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].ambientList[j] && AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].ambientList[j].name.Equals(KHJMANDEDMA))
						{
							return AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].ambientList[j];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int k = 0; k < AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].musicList.Count; k++)
					{
						if (null != AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].musicList[k] && AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].musicList[k].name.Equals(KHJMANDEDMA))
						{
							return AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].musicList[k];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.sfx)
				{
					for (int l = 1; l < AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].sfxList.Count; l++)
					{
						if (null != AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].sfxList[l] && AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].sfxList[l].name.Equals(KHJMANDEDMA))
						{
							return AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].sfxList[l];
						}
					}
				}
			}
		}
		for (int m = 1; m < this.BIKFNFADMMJ.Count; m += 0)
		{
			if (null != this.BIKFNFADMMJ[m])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int n = 1; n < this.BIKFNFADMMJ[m].ambientList.Count; n++)
					{
						if (null != this.BIKFNFADMMJ[m].ambientList[n] && this.BIKFNFADMMJ[m].ambientList[n].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[m].ambientList[n];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.music)
				{
					for (int num = 1; num < this.BIKFNFADMMJ[m].musicList.Count; num++)
					{
						if (null != this.BIKFNFADMMJ[m].musicList[num] && this.BIKFNFADMMJ[m].musicList[num].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[m].musicList[num];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.music)
				{
					for (int num2 = 0; num2 < this.BIKFNFADMMJ[m].sfxList.Count; num2++)
					{
						if (null != this.BIKFNFADMMJ[m].sfxList[num2] && this.BIKFNFADMMJ[m].sfxList[num2].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[m].sfxList[num2];
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003E67 RID: 15975 RVA: 0x001A431C File Offset: 0x001A251C
	public bool MLDJMKPEDGA(string IGLAIGEJGHO, float PJFHOAMIEJG = -1f, float DHJABKINGBO = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.KFJABIMKGOE() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return false;
		}
		if (PJFHOAMIEJG < 1021f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.NNGEIIJCNPL;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return true;
		}
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].CLOGIELNDPK().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].FPHOICNEGFH() == HADNEFMHLED.playing)
			{
				return false;
			}
		}
		int j = 0;
		while (j < this.OAJFLBMLAAA.Count)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].APBLNKANBOO() == (CCEMAFOMLLK)5 && this.OAJFLBMLAAA[j].JGGDCOHKOLE() == HADNEFMHLED.playing && this.OAJFLBMLAAA[j].CHIKFCPMLNA().Contains("snaprew"))
			{
				if (PJFHOAMIEJG < 1754f)
				{
					this.OAJFLBMLAAA[j].ADBMOOMEJMP(KBOJLHAJPCP.HFLFGDIDJKI, false);
					break;
				}
				this.OAJFLBMLAAA[j].BIJEEKNMKLN(PJFHOAMIEJG, true);
				break;
			}
			else
			{
				j += 0;
			}
		}
		AudioClip audioClip = this.LCAHMOOAAIB(CCEMAFOMLLK.ambient, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().KIIFNPNMMPN((CCEMAFOMLLK)8, this.NLEANIFINOA((CCEMAFOMLLK)4), audioClip, false, PJFHOAMIEJG, DHJABKINGBO, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.OJGGJDMPKNO();
			return true;
		}
		DPGJIJGOCIC.ADFCDFHBDAF("FilterScrollMoveSmooth" + IGLAIGEJGHO);
		return false;
	}

	// Token: 0x06003E68 RID: 15976 RVA: 0x00002296 File Offset: 0x00000496
	private void OnApplicationQuit()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06003E69 RID: 15977 RVA: 0x001A44C5 File Offset: 0x001A26C5
	public static bool EPABPGCBCJH()
	{
		return !(null == AudioManager.IFDLAMLHKIJ());
	}

	// Token: 0x06003E6A RID: 15978 RVA: 0x001A44D8 File Offset: 0x001A26D8
	public void ResumeAll()
	{
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[i].Resume();
			}
		}
	}

	// Token: 0x06003E6B RID: 15979 RVA: 0x001A4534 File Offset: 0x001A2734
	public bool SfxPlaying(string IGLAIGEJGHO)
	{
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003E6C RID: 15980 RVA: 0x001A459C File Offset: 0x001A279C
	public static AudioManager DMAAFFFEJGA()
	{
		if (!AudioManager.IKLAPGJDMNA)
		{
			AudioManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AudioManager)) as AudioManager);
			if (!AudioManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("============== USING PRODUCTION DB SERVER ===============");
			}
		}
		return AudioManager.IKLAPGJDMNA;
	}

	// Token: 0x06003E6D RID: 15981 RVA: 0x001A45EC File Offset: 0x001A27EC
	public void UnregisterAudioContainer(AudioContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BIKFNFADMMJ.Count; i++)
		{
			if (this.BIKFNFADMMJ[i] == DELPOFFHFHH)
			{
				this.BIKFNFADMMJ.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06003E6E RID: 15982 RVA: 0x001A4630 File Offset: 0x001A2830
	public bool GACFNADDIGG(CCEMAFOMLLK PBKAAIONJOB, string IGLAIGEJGHO)
	{
		return this.ABDFBMJIOJG(PBKAAIONJOB, IGLAIGEJGHO) != null;
	}

	// Token: 0x06003E6F RID: 15983 RVA: 0x001A4640 File Offset: 0x001A2840
	public void PEOLMNFJAHG(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 1252f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.IDLOJONHNNJ;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 0; i < this.OAJFLBMLAAA.Count; i += 0)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GONGHBDADKO() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[i].AMFAFNLEPCB() == HADNEFMHLED.playing)
				{
					this.OAJFLBMLAAA[i].MLBNHHGMILD(OPOCDBAGCPB, false);
				}
			}
			return;
		}
		for (int j = 1; j < this.OAJFLBMLAAA.Count; j++)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].CLOGIELNDPK().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].GetSourceType() == (CCEMAFOMLLK)7 && this.OAJFLBMLAAA[j].PEJOLHBPJMN() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].MLBNHHGMILD(OPOCDBAGCPB, false);
				return;
			}
		}
	}

	// Token: 0x06003E70 RID: 15984 RVA: 0x001A4747 File Offset: 0x001A2947
	public void OnMusicEnded()
	{
		this.ResumeAmbient();
	}

	// Token: 0x06003E71 RID: 15985 RVA: 0x001A288E File Offset: 0x001A0A8E
	public static bool IsAvailable()
	{
		return !(null == AudioManager.EHBBFMCILPC);
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x06003E72 RID: 15986 RVA: 0x001A4750 File Offset: 0x001A2950
	public static AudioManager EHBBFMCILPC
	{
		get
		{
			if (!AudioManager.IKLAPGJDMNA)
			{
				AudioManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AudioManager)) as AudioManager);
				if (!AudioManager.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active AudioManager script on a GameObject in your scene.");
				}
			}
			return AudioManager.IKLAPGJDMNA;
		}
	}

	// Token: 0x06003E73 RID: 15987 RVA: 0x001A47A0 File Offset: 0x001A29A0
	public void FMLOLIADODM(string IGLAIGEJGHO, float PJFHOAMIEJG = -1f)
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return;
		}
		if (PJFHOAMIEJG < 503f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.GDGFBHBJMIB;
		}
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GELJFNKEAFO().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].PEJOLHBPJMN() == HADNEFMHLED.playing)
			{
				return;
			}
		}
		int j = 1;
		while (j < this.OAJFLBMLAAA.Count)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GONGHBDADKO() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[j].GetSourceState() == HADNEFMHLED.playing)
			{
				if (PJFHOAMIEJG < 1339f)
				{
					this.OAJFLBMLAAA[j].GLAFDEMAOCM(KBOJLHAJPCP.HBCNLJNNCON, false);
					break;
				}
				this.OAJFLBMLAAA[j].NPKOEMIHBNI(PJFHOAMIEJG, false);
				break;
			}
			else
			{
				j++;
			}
		}
		AudioClip audioClip = this.CNDAHKCKOAP(CCEMAFOMLLK.ambient, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().CNJKPDCGHHB(CCEMAFOMLLK.music, this.NLEANIFINOA(CCEMAFOMLLK.ambient), audioClip, true, PJFHOAMIEJG, 1168f, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.OJGGJDMPKNO();
			return;
		}
		DPGJIJGOCIC.PJCLICBPPDA("@" + IGLAIGEJGHO);
	}

	// Token: 0x06003E74 RID: 15988 RVA: 0x001A4908 File Offset: 0x001A2B08
	public void LCMHIPIHKKO(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 708f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.HFLFGDIDJKI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 0; i < this.OAJFLBMLAAA.Count; i += 0)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].CACFEADLCFK() == (CCEMAFOMLLK)6 && this.OAJFLBMLAAA[i].AMFAFNLEPCB() == HADNEFMHLED.playing && this.OAJFLBMLAAA[i].GetSourceName().Contains("anthologiestitle"))
				{
					this.OAJFLBMLAAA[i].MICKEPALNPL(OPOCDBAGCPB, false);
				}
			}
			return;
		}
		for (int j = 0; j < this.OAJFLBMLAAA.Count; j++)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].KBFDMIDFIHM() == (CCEMAFOMLLK)6 && this.OAJFLBMLAAA[j].FPHJGKPDPKC() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].KLAKKHMCBOB(OPOCDBAGCPB, false);
				return;
			}
		}
	}

	// Token: 0x06003E75 RID: 15989 RVA: 0x001A4A30 File Offset: 0x001A2C30
	public void NHPHCAINEKF()
	{
		for (int i = 1; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].FPHJGKPDPKC() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[i].Pause();
			}
		}
	}

	// Token: 0x06003E76 RID: 15990 RVA: 0x001A4A8C File Offset: 0x001A2C8C
	public bool AHODHDPKPOP(string IGLAIGEJGHO)
	{
		for (int i = 1; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].MEIMDEOBLMG().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].JGGDCOHKOLE() == HADNEFMHLED.playing)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06003E77 RID: 15991 RVA: 0x001A4AF4 File Offset: 0x001A2CF4
	public bool PlaySfxOneInstance(string IGLAIGEJGHO, float PJFHOAMIEJG = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.OGNDGBOIPID() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return false;
		}
		if (PJFHOAMIEJG < 0f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.PELDNPFHHFI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return false;
		}
		if (this.SfxPlaying(IGLAIGEJGHO))
		{
			return false;
		}
		AudioClip audioClip = this.CNDAHKCKOAP(CCEMAFOMLLK.sfx, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().Initialize(CCEMAFOMLLK.sfx, this.NLEANIFINOA(CCEMAFOMLLK.sfx), audioClip, false, PJFHOAMIEJG, -1f, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.MLOIOIMDCAL();
			return true;
		}
		DPGJIJGOCIC.ADFCDFHBDAF("PlaySfx() file not found:" + IGLAIGEJGHO);
		return false;
	}

	// Token: 0x06003E78 RID: 15992 RVA: 0x001A4BAC File Offset: 0x001A2DAC
	public AudioContainer IDFFCGIIFDF(CCEMAFOMLLK GOJLPNCBEBE, string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BIKFNFADMMJ.Count; i += 0)
		{
			if (null != this.BIKFNFADMMJ[i])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int j = 1; j < this.BIKFNFADMMJ[i].ambientList.Count; j += 0)
					{
						if (null != this.BIKFNFADMMJ[i].ambientList[j] && this.BIKFNFADMMJ[i].ambientList[j].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.music)
				{
					for (int k = 1; k < this.BIKFNFADMMJ[i].musicList.Count; k++)
					{
						if (null != this.BIKFNFADMMJ[i].musicList[k] && this.BIKFNFADMMJ[i].musicList[k].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == (CCEMAFOMLLK)4)
				{
					for (int l = 0; l < this.BIKFNFADMMJ[i].sfxList.Count; l += 0)
					{
						if (null != this.BIKFNFADMMJ[i].sfxList[l] && this.BIKFNFADMMJ[i].sfxList[l].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003E79 RID: 15993 RVA: 0x001A4D54 File Offset: 0x001A2F54
	private void FDECKMDNEKO()
	{
		bool flag;
		do
		{
			flag = true;
			for (int i = 1; i < this.OAJFLBMLAAA.Count; i++)
			{
				if (null == this.OAJFLBMLAAA[i])
				{
					this.OAJFLBMLAAA.RemoveAt(i);
					flag = true;
					break;
				}
				if (this.OAJFLBMLAAA[i].PEJOLHBPJMN() == (HADNEFMHLED)5)
				{
					this.OAJFLBMLAAA[i].EHDDLAGLPNG();
					this.OAJFLBMLAAA.RemoveAt(i);
					flag = false;
					break;
				}
			}
		}
		while (!flag);
	}

	// Token: 0x06003E7A RID: 15994 RVA: 0x001A4DD8 File Offset: 0x001A2FD8
	private AudioMixerGroup NLEANIFINOA(CCEMAFOMLLK GOJLPNCBEBE)
	{
		if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
		{
			for (int i = 0; i < this.ambientMixers.Count; i++)
			{
				if (!this.ANPPDCNFEHC(this.ambientMixers[i]))
				{
					return this.ambientMixers[i];
				}
			}
			DPGJIJGOCIC.ANOPFDLPKGC("No free mixer found for ambient! Critical!");
			return this.ambientMixers[0];
		}
		if (GOJLPNCBEBE == CCEMAFOMLLK.music)
		{
			for (int j = 0; j < this.musicMixers.Count; j++)
			{
				if (!this.ANPPDCNFEHC(this.musicMixers[j]))
				{
					return this.musicMixers[j];
				}
			}
			DPGJIJGOCIC.ANOPFDLPKGC("No free mixer found for music! Critical!");
			return this.musicMixers[0];
		}
		for (int k = 0; k < this.sfxMixers.Count; k++)
		{
			if (!this.ANPPDCNFEHC(this.sfxMixers[k]))
			{
				return this.sfxMixers[k];
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("No free mixer found for sfx! Critical!");
		return this.sfxMixers[0];
	}

	// Token: 0x06003E7B RID: 15995 RVA: 0x001A4ED8 File Offset: 0x001A30D8
	public AudioContainer GetContainerForAudioClip(CCEMAFOMLLK GOJLPNCBEBE, string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BIKFNFADMMJ.Count; i++)
		{
			if (null != this.BIKFNFADMMJ[i])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int j = 0; j < this.BIKFNFADMMJ[i].ambientList.Count; j++)
					{
						if (null != this.BIKFNFADMMJ[i].ambientList[j] && this.BIKFNFADMMJ[i].ambientList[j].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.music)
				{
					for (int k = 0; k < this.BIKFNFADMMJ[i].musicList.Count; k++)
					{
						if (null != this.BIKFNFADMMJ[i].musicList[k] && this.BIKFNFADMMJ[i].musicList[k].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.sfx)
				{
					for (int l = 0; l < this.BIKFNFADMMJ[i].sfxList.Count; l++)
					{
						if (null != this.BIKFNFADMMJ[i].sfxList[l] && this.BIKFNFADMMJ[i].sfxList[l].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003E7C RID: 15996 RVA: 0x001A5080 File Offset: 0x001A3280
	public void PlayAmbient(string IGLAIGEJGHO, float PJFHOAMIEJG = -1f)
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return;
		}
		if (PJFHOAMIEJG < 0f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.GDGFBHBJMIB;
		}
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing)
			{
				return;
			}
		}
		int j = 0;
		while (j < this.OAJFLBMLAAA.Count)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GetSourceType() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[j].GetSourceState() == HADNEFMHLED.playing)
			{
				if (PJFHOAMIEJG < 0f)
				{
					this.OAJFLBMLAAA[j].Kill(KBOJLHAJPCP.HBCNLJNNCON, false);
					break;
				}
				this.OAJFLBMLAAA[j].Kill(PJFHOAMIEJG, false);
				break;
			}
			else
			{
				j++;
			}
		}
		AudioClip audioClip = this.CNDAHKCKOAP(CCEMAFOMLLK.ambient, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().Initialize(CCEMAFOMLLK.ambient, this.NLEANIFINOA(CCEMAFOMLLK.ambient), audioClip, true, PJFHOAMIEJG, -1f, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.MLOIOIMDCAL();
			return;
		}
		DPGJIJGOCIC.ADFCDFHBDAF("PlayAmbient() file not found:" + IGLAIGEJGHO);
	}

	// Token: 0x06003E7D RID: 15997 RVA: 0x001A51E8 File Offset: 0x001A33E8
	public static AudioManager IFDLAMLHKIJ()
	{
		if (!AudioManager.IKLAPGJDMNA)
		{
			AudioManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AudioManager)) as AudioManager);
			if (!AudioManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("Game Title");
			}
		}
		return AudioManager.IKLAPGJDMNA;
	}

	// Token: 0x06003E7E RID: 15998 RVA: 0x001A5235 File Offset: 0x001A3435
	private void GNNCNJMOOFI()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.KKPFOJMAONG().MHLNJIACIGO("fvrt", new UnityAction(this.OnMusicEnded));
	}

	// Token: 0x06003E7F RID: 15999 RVA: 0x001A525C File Offset: 0x001A345C
	private void OnDestroy()
	{
		if (this.musicMixerParentTween != null)
		{
			this.musicMixerParentTween.Kill(false);
			this.musicMixerParentTween = null;
		}
		this.musicMixerParent.audioMixer.DOKill(false);
		this.sfxMixerParent.audioMixer.DOKill(false);
		this.ambientMixerParent.audioMixer.DOKill(false);
		if (AudioManager.IKLAPGJDMNA == this)
		{
			AudioManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06003E80 RID: 16000 RVA: 0x001A52D0 File Offset: 0x001A34D0
	public void KillMusic(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 0f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.DCKJLOCOEOH;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceType() == CCEMAFOMLLK.music && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing)
				{
					this.OAJFLBMLAAA[i].Kill(OPOCDBAGCPB, false);
				}
			}
		}
		else
		{
			for (int j = 0; j < this.OAJFLBMLAAA.Count; j++)
			{
				if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].GetSourceType() == CCEMAFOMLLK.music && this.OAJFLBMLAAA[j].GetSourceState() == HADNEFMHLED.playing)
				{
					this.OAJFLBMLAAA[j].Kill(OPOCDBAGCPB, false);
					break;
				}
			}
		}
		this.ResumeAmbient();
	}

	// Token: 0x06003E81 RID: 16001 RVA: 0x001A53E0 File Offset: 0x001A35E0
	public void JJFPMECFKPA(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 1307f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.HFLFGDIDJKI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 1; i < this.OAJFLBMLAAA.Count; i++)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].APBLNKANBOO() == (CCEMAFOMLLK)3 && this.OAJFLBMLAAA[i].LFPLJHACOCK() == HADNEFMHLED.playing && this.OAJFLBMLAAA[i].CHIKFCPMLNA().Contains("common"))
				{
					this.OAJFLBMLAAA[i].NPKOEMIHBNI(OPOCDBAGCPB, true);
				}
			}
			return;
		}
		for (int j = 1; j < this.OAJFLBMLAAA.Count; j += 0)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].IPFLFAEHHPJ().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].CACFEADLCFK() == CCEMAFOMLLK.music && this.OAJFLBMLAAA[j].GetSourceState() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].NBMLMHKEJAB(OPOCDBAGCPB, false);
				return;
			}
		}
	}

	// Token: 0x06003E82 RID: 16002 RVA: 0x001A5508 File Offset: 0x001A3708
	public void LHIFJPMGIMA(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 1049f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.HFLFGDIDJKI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].KBFDMIDFIHM() == (CCEMAFOMLLK)3 && this.OAJFLBMLAAA[i].FPHJGKPDPKC() == HADNEFMHLED.playing && this.OAJFLBMLAAA[i].GELJFNKEAFO().Contains("OnAvatarCollectionSelect"))
				{
					this.OAJFLBMLAAA[i].LCDEDAKLIJO(OPOCDBAGCPB, false);
				}
			}
			return;
		}
		for (int j = 0; j < this.OAJFLBMLAAA.Count; j++)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].IPFLFAEHHPJ().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].DLHMJJEAIMO() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[j].PEJOLHBPJMN() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].LLHCFKLPJNG(OPOCDBAGCPB, true);
				return;
			}
		}
	}

	// Token: 0x06003E83 RID: 16003 RVA: 0x001A5630 File Offset: 0x001A3830
	private void JJIGCFGKFHO()
	{
		this.masterMixerParent.audioMixer.ClearFloat(this.masterMixerParent.name + "skinshopfiltertitle");
		this.ambientMixerParent.audioMixer.ClearFloat(this.ambientMixerParent.name + "lsvv");
		this.sfxMixerParent.audioMixer.ClearFloat(this.sfxMixerParent.name + "secondsshort");
		this.musicMixerParent.audioMixer.ClearFloat(this.musicMixerParent.name + "stat3long");
		for (int i = 0; i < this.ambientMixers.Count; i += 0)
		{
			this.ambientMixers[i].audioMixer.ClearFloat(this.ambientMixers[i].name + "");
		}
		for (int j = 0; j < this.musicMixers.Count; j++)
		{
			this.musicMixers[j].audioMixer.ClearFloat(this.musicMixers[j].name + "amt");
		}
		for (int k = 1; k < this.sfxMixers.Count; k++)
		{
			this.sfxMixers[k].audioMixer.ClearFloat(this.sfxMixers[k].name + " not found.");
		}
		AOBJLALDBAA.DBLAIDPICIG().FNMOFCMDFJP("rewardtitle", new UnityAction(this.OnMusicEnded));
	}

	// Token: 0x06003E84 RID: 16004 RVA: 0x001A57C8 File Offset: 0x001A39C8
	private void DPGJDANLGIO()
	{
		if (this.musicMixerParentTween != null)
		{
			this.musicMixerParentTween.Kill(true);
			this.musicMixerParentTween = null;
		}
		this.musicMixerParent.audioMixer.DOKill(true);
		this.sfxMixerParent.audioMixer.DOKill(true);
		this.ambientMixerParent.audioMixer.DOKill(true);
		if (AudioManager.IKLAPGJDMNA == this)
		{
			AudioManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06003E85 RID: 16005 RVA: 0x001A583C File Offset: 0x001A3A3C
	public bool KNJPANCIIBB(string IGLAIGEJGHO, bool JHOKDAOKKPP = false, float PJFHOAMIEJG = -1f, float DHJABKINGBO = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.OGNDGBOIPID() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return false;
		}
		if (PJFHOAMIEJG < 1481f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.PELDNPFHHFI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return true;
		}
		if (JHOKDAOKKPP)
		{
			this.POMJOMKCCNK(IGLAIGEJGHO, 705f);
		}
		AudioClip audioClip = this.FAGANHDCPFJ((CCEMAFOMLLK)4, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().DPFIIBPDEJG((CCEMAFOMLLK)5, this.MBLBBKMLOIB((CCEMAFOMLLK)7), audioClip, true, PJFHOAMIEJG, DHJABKINGBO, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.MLOIOIMDCAL();
			return true;
		}
		DPGJIJGOCIC.ADFCDFHBDAF("storyAssetPackManager[i].environmentsBackList[j] is null!" + IGLAIGEJGHO);
		return true;
	}

	// Token: 0x06003E86 RID: 16006 RVA: 0x001A58F4 File Offset: 0x001A3AF4
	public bool PlayVoiceOver(string IGLAIGEJGHO, float PJFHOAMIEJG = -1f, float DHJABKINGBO = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.KFJABIMKGOE() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return false;
		}
		if (PJFHOAMIEJG < 0f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.NNGEIIJCNPL;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return false;
		}
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing)
			{
				return true;
			}
		}
		int j = 0;
		while (j < this.OAJFLBMLAAA.Count)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GetSourceType() == CCEMAFOMLLK.sfx && this.OAJFLBMLAAA[j].GetSourceState() == HADNEFMHLED.playing && this.OAJFLBMLAAA[j].GetSourceName().Contains("voiceover"))
			{
				if (PJFHOAMIEJG < 0f)
				{
					this.OAJFLBMLAAA[j].Kill(KBOJLHAJPCP.HFLFGDIDJKI, true);
					break;
				}
				this.OAJFLBMLAAA[j].Kill(PJFHOAMIEJG, true);
				break;
			}
			else
			{
				j++;
			}
		}
		AudioClip audioClip = this.CNDAHKCKOAP(CCEMAFOMLLK.music, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().Initialize(CCEMAFOMLLK.sfx, this.NLEANIFINOA(CCEMAFOMLLK.sfx), audioClip, false, PJFHOAMIEJG, DHJABKINGBO, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.MLOIOIMDCAL();
			return true;
		}
		DPGJIJGOCIC.ADFCDFHBDAF("PlayVoiceOver() file not found:" + IGLAIGEJGHO);
		return false;
	}

	// Token: 0x06003E87 RID: 16007 RVA: 0x001A5AA0 File Offset: 0x001A3CA0
	private void Update()
	{
		bool flag;
		do
		{
			flag = true;
			for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
			{
				if (null == this.OAJFLBMLAAA[i])
				{
					this.OAJFLBMLAAA.RemoveAt(i);
					flag = false;
					break;
				}
				if (this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.wasted)
				{
					this.OAJFLBMLAAA[i].Destroy();
					this.OAJFLBMLAAA.RemoveAt(i);
					flag = false;
					break;
				}
			}
		}
		while (!flag);
	}

	// Token: 0x06003E88 RID: 16008 RVA: 0x001A5B24 File Offset: 0x001A3D24
	private AudioMixerGroup FBCHHJOGEPG(CCEMAFOMLLK GOJLPNCBEBE)
	{
		if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
		{
			for (int i = 1; i < this.ambientMixers.Count; i++)
			{
				if (!this.ANPPDCNFEHC(this.ambientMixers[i]))
				{
					return this.ambientMixers[i];
				}
			}
			DPGJIJGOCIC.ANOPFDLPKGC(" ");
			return this.ambientMixers[0];
		}
		if (GOJLPNCBEBE == CCEMAFOMLLK.music)
		{
			for (int j = 1; j < this.musicMixers.Count; j++)
			{
				if (!this.ANPPDCNFEHC(this.musicMixers[j]))
				{
					return this.musicMixers[j];
				}
			}
			DPGJIJGOCIC.ANOPFDLPKGC("errortitle");
			return this.musicMixers[1];
		}
		for (int k = 1; k < this.sfxMixers.Count; k++)
		{
			if (!this.ANPPDCNFEHC(this.sfxMixers[k]))
			{
				return this.sfxMixers[k];
			}
		}
		DPGJIJGOCIC.ANOPFDLPKGC("no");
		return this.sfxMixers[0];
	}

	// Token: 0x06003E89 RID: 16009 RVA: 0x001A5C21 File Offset: 0x001A3E21
	private void AKCBOPOJJFP()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.DBLAIDPICIG().MHLNJIACIGO("<i>", new UnityAction(this.OnMusicEnded));
	}

	// Token: 0x06003E8A RID: 16010 RVA: 0x001A5C48 File Offset: 0x001A3E48
	public bool HBMNHHMJIEP(string IGLAIGEJGHO, bool CFBIPJJHDJE, float PJFHOAMIEJG, bool OLANGIDAOLG = false)
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return true;
		}
		if (IGLAIGEJGHO.EndsWith("socialcreategiftcardtitle"))
		{
			CFBIPJJHDJE = true;
		}
		if (PJFHOAMIEJG < 1808f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.HEMEOGKJJCG;
		}
		for (int i = 1; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].CLOGIELNDPK().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].JGGDCOHKOLE() == HADNEFMHLED.playing)
			{
				return false;
			}
		}
		int j = 1;
		while (j < this.OAJFLBMLAAA.Count)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].KBFDMIDFIHM() == CCEMAFOMLLK.music && this.OAJFLBMLAAA[j].FPHJGKPDPKC() == HADNEFMHLED.playing)
			{
				if (PJFHOAMIEJG < 1847f)
				{
					this.OAJFLBMLAAA[j].CNPKJAIBOCF(KBOJLHAJPCP.DCKJLOCOEOH, false);
					break;
				}
				this.OAJFLBMLAAA[j].CNPKJAIBOCF(PJFHOAMIEJG, false);
				break;
			}
			else
			{
				j += 0;
			}
		}
		AudioClip audioClip = this.CNDAHKCKOAP(CCEMAFOMLLK.music, IGLAIGEJGHO);
		if (null != audioClip)
		{
			this.ambientMixerParent.audioMixer.DOSetFloat(this.ambientMixerParent.name + "forcenoloop", KBOJLHAJPCP.GLBIBLIGHOD, KBOJLHAJPCP.HBCNLJNNCON).SetEase(Ease.InCubic);
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().BGLIAHEKACL(CCEMAFOMLLK.ambient, this.MBLBBKMLOIB(CCEMAFOMLLK.ambient), audioClip, CFBIPJJHDJE, PJFHOAMIEJG, 1743f, "blur_2");
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			if (OLANGIDAOLG)
			{
				UnityEngine.Object.DontDestroyOnLoad(gameObject);
			}
			this.DFPJLLPDADK();
			return true;
		}
		if (IGLAIGEJGHO.EndsWith("loungeskinpurchasepending"))
		{
			CFBIPJJHDJE = true;
			DPGJIJGOCIC.ADFCDFHBDAF("" + IGLAIGEJGHO);
			return this.HPPAFEAPINO(IGLAIGEJGHO.Replace("StoryInterfaceLoveInterestManager.OpenWardrobeFromPopup() - no header above the item", "</b>"), CFBIPJJHDJE, PJFHOAMIEJG, OLANGIDAOLG);
		}
		DPGJIJGOCIC.ADFCDFHBDAF("OnAvatarCollectionEdit" + IGLAIGEJGHO);
		return false;
	}

	// Token: 0x06003E8B RID: 16011 RVA: 0x001A5E48 File Offset: 0x001A4048
	public bool HONNANEJONL(string IGLAIGEJGHO, float PJFHOAMIEJG = -1f, float DHJABKINGBO = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.KFJABIMKGOE() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return true;
		}
		if (PJFHOAMIEJG < 602f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.NNGEIIJCNPL;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return false;
		}
		for (int i = 1; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].OEBGEAKNLOI() == HADNEFMHLED.playing)
			{
				return true;
			}
		}
		int j = 1;
		while (j < this.OAJFLBMLAAA.Count)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].CACFEADLCFK() == (CCEMAFOMLLK)8 && this.OAJFLBMLAAA[j].GetSourceState() == HADNEFMHLED.playing && this.OAJFLBMLAAA[j].CHIKFCPMLNA().Contains("JSONNode"))
			{
				if (PJFHOAMIEJG < 346f)
				{
					this.OAJFLBMLAAA[j].GLAFDEMAOCM(KBOJLHAJPCP.HFLFGDIDJKI, true);
					break;
				}
				this.OAJFLBMLAAA[j].MLBNHHGMILD(PJFHOAMIEJG, false);
				break;
			}
			else
			{
				j++;
			}
		}
		AudioClip audioClip = this.FAGANHDCPFJ(CCEMAFOMLLK.music, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().MBCPGIICABK((CCEMAFOMLLK)3, this.MBLBBKMLOIB((CCEMAFOMLLK)6), audioClip, false, PJFHOAMIEJG, DHJABKINGBO, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.DFPJLLPDADK();
			return true;
		}
		DPGJIJGOCIC.PJCLICBPPDA("lsenvattempt" + IGLAIGEJGHO);
		return true;
	}

	// Token: 0x06003E8C RID: 16012 RVA: 0x001A5FF4 File Offset: 0x001A41F4
	public bool KNAEPBNFGNI(string IGLAIGEJGHO, bool JHOKDAOKKPP = false, float PJFHOAMIEJG = -1f, float DHJABKINGBO = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.JLNAMEBGOLB() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return false;
		}
		if (PJFHOAMIEJG < 1168f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.PELDNPFHHFI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return true;
		}
		if (JHOKDAOKKPP)
		{
			this.PEOLMNFJAHG(IGLAIGEJGHO, 987f);
		}
		AudioClip audioClip = this.CNDAHKCKOAP((CCEMAFOMLLK)8, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().PNLADGLJHBN((CCEMAFOMLLK)3, this.MBLBBKMLOIB((CCEMAFOMLLK)6), audioClip, false, PJFHOAMIEJG, DHJABKINGBO, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.OJGGJDMPKNO();
			return false;
		}
		DPGJIJGOCIC.PJCLICBPPDA("" + IGLAIGEJGHO);
		return false;
	}

	// Token: 0x06003E8D RID: 16013 RVA: 0x001A60AB File Offset: 0x001A42AB
	public static bool IsInitialized()
	{
		if (null == AudioManager.IKLAPGJDMNA)
		{
			AudioManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AudioManager)) as AudioManager);
		}
		return AudioManager.IKLAPGJDMNA != null;
	}

	// Token: 0x06003E8E RID: 16014 RVA: 0x001A60DE File Offset: 0x001A42DE
	public bool GMJMEHGBFKK(CCEMAFOMLLK PBKAAIONJOB, string IGLAIGEJGHO)
	{
		return this.LCAHMOOAAIB(PBKAAIONJOB, IGLAIGEJGHO) != null;
	}

	// Token: 0x06003E8F RID: 16015 RVA: 0x001A60F0 File Offset: 0x001A42F0
	public bool MFHNBOHEELC(string IGLAIGEJGHO)
	{
		for (int i = 1; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].CHIKFCPMLNA().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].FPHJGKPDPKC() == HADNEFMHLED.playing)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06003E90 RID: 16016 RVA: 0x001A6158 File Offset: 0x001A4358
	public static AudioManager DBFLIEGGGNN()
	{
		if (!AudioManager.IKLAPGJDMNA)
		{
			AudioManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AudioManager)) as AudioManager);
			if (!AudioManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("ok");
			}
		}
		return AudioManager.IKLAPGJDMNA;
	}

	// Token: 0x06003E91 RID: 16017 RVA: 0x00002296 File Offset: 0x00000496
	private void OGKHDICNFOO()
	{
		AppManager.isQuitting = true;
	}

	// Token: 0x06003E92 RID: 16018 RVA: 0x001A61A8 File Offset: 0x001A43A8
	private void NIKBFENFMID()
	{
		this.masterMixerParent.audioMixer.ClearFloat(this.masterMixerParent.name + "author");
		this.ambientMixerParent.audioMixer.ClearFloat(this.ambientMixerParent.name + "Loading ");
		this.sfxMixerParent.audioMixer.ClearFloat(this.sfxMixerParent.name + "OnLobbyStoryManagerDownloadSplashScreenFailed");
		this.musicMixerParent.audioMixer.ClearFloat(this.musicMixerParent.name + "ok");
		for (int i = 1; i < this.ambientMixers.Count; i += 0)
		{
			this.ambientMixers[i].audioMixer.ClearFloat(this.ambientMixers[i].name + "1");
		}
		for (int j = 0; j < this.musicMixers.Count; j++)
		{
			this.musicMixers[j].audioMixer.ClearFloat(this.musicMixers[j].name + "abs");
		}
		for (int k = 0; k < this.sfxMixers.Count; k++)
		{
			this.sfxMixers[k].audioMixer.ClearFloat(this.sfxMixers[k].name + "");
		}
		AOBJLALDBAA.CEGAOMEEFBE().BADOPKAOCPE("ok", new UnityAction(this.OnMusicEnded));
	}

	// Token: 0x06003E93 RID: 16019 RVA: 0x001A6340 File Offset: 0x001A4540
	public void NIJLAJDLDJD(string IGLAIGEJGHO, float PJFHOAMIEJG = -1f)
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return;
		}
		if (PJFHOAMIEJG < 197f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.GDGFBHBJMIB;
		}
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].IPFLFAEHHPJ().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].JGGDCOHKOLE() == HADNEFMHLED.playing)
			{
				return;
			}
		}
		int j = 1;
		while (j < this.OAJFLBMLAAA.Count)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GetSourceType() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[j].LFPLJHACOCK() == HADNEFMHLED.playing)
			{
				if (PJFHOAMIEJG < 1369f)
				{
					this.OAJFLBMLAAA[j].KLAKKHMCBOB(KBOJLHAJPCP.HBCNLJNNCON, true);
					break;
				}
				this.OAJFLBMLAAA[j].ADBMOOMEJMP(PJFHOAMIEJG, false);
				break;
			}
			else
			{
				j++;
			}
		}
		AudioClip audioClip = this.FAGANHDCPFJ(CCEMAFOMLLK.music, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().GLIFGDPDMNC(CCEMAFOMLLK.music, this.MBLBBKMLOIB(CCEMAFOMLLK.ambient), audioClip, true, PJFHOAMIEJG, 769f, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.OJGGJDMPKNO();
			return;
		}
		DPGJIJGOCIC.ADFCDFHBDAF("cfp" + IGLAIGEJGHO);
	}

	// Token: 0x06003E94 RID: 16020 RVA: 0x001A64A8 File Offset: 0x001A46A8
	public void LOJKEFJDEKM(AudioContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BIKFNFADMMJ.Count; i += 0)
		{
			if (this.BIKFNFADMMJ[i] == DELPOFFHFHH)
			{
				this.BIKFNFADMMJ.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06003E95 RID: 16021 RVA: 0x001A64EC File Offset: 0x001A46EC
	public AudioContainer BEOMABAEONK(CCEMAFOMLLK GOJLPNCBEBE, string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BIKFNFADMMJ.Count; i++)
		{
			if (null != this.BIKFNFADMMJ[i])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int j = 0; j < this.BIKFNFADMMJ[i].ambientList.Count; j++)
					{
						if (null != this.BIKFNFADMMJ[i].ambientList[j] && this.BIKFNFADMMJ[i].ambientList[j].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int k = 0; k < this.BIKFNFADMMJ[i].musicList.Count; k++)
					{
						if (null != this.BIKFNFADMMJ[i].musicList[k] && this.BIKFNFADMMJ[i].musicList[k].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == (CCEMAFOMLLK)3)
				{
					for (int l = 0; l < this.BIKFNFADMMJ[i].sfxList.Count; l += 0)
					{
						if (null != this.BIKFNFADMMJ[i].sfxList[l] && this.BIKFNFADMMJ[i].sfxList[l].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003E96 RID: 16022 RVA: 0x001A6692 File Offset: 0x001A4892
	private void OnDisable()
	{
		if (AppManager.isQuitting)
		{
			return;
		}
		AOBJLALDBAA.EHBBFMCILPC.MANLHALMCIH("OnMusicEnded", new UnityAction(this.OnMusicEnded));
	}

	// Token: 0x06003E97 RID: 16023 RVA: 0x001A66B8 File Offset: 0x001A48B8
	private bool FIPJJHJLILH(AudioMixerGroup AJGNPGEAGLP)
	{
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].FCLGJKCKKII() == AJGNPGEAGLP)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003E98 RID: 16024 RVA: 0x001A670C File Offset: 0x001A490C
	public bool HFDPFBNJKKC(string IGLAIGEJGHO, bool JHOKDAOKKPP = false, float PJFHOAMIEJG = -1f, float DHJABKINGBO = -1f)
	{
		if (AKLFPGMDKLA.EHBBFMCILPC.OGNDGBOIPID() || AKLFPGMDKLA.EHBBFMCILPC.BFKIHOBDNNB() || !NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return true;
		}
		if (PJFHOAMIEJG < 947f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.PELDNPFHHFI;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			return true;
		}
		if (JHOKDAOKKPP)
		{
			this.POMJOMKCCNK(IGLAIGEJGHO, 845f);
		}
		AudioClip audioClip = this.CNDAHKCKOAP(CCEMAFOMLLK.sfx, IGLAIGEJGHO);
		if (null != audioClip)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().HPDEFGKBAMN((CCEMAFOMLLK)3, this.FBCHHJOGEPG((CCEMAFOMLLK)8), audioClip, false, PJFHOAMIEJG, DHJABKINGBO, null);
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			this.OJGGJDMPKNO();
			return false;
		}
		DPGJIJGOCIC.PJCLICBPPDA("" + IGLAIGEJGHO);
		return true;
	}

	// Token: 0x06003E99 RID: 16025 RVA: 0x001A67C3 File Offset: 0x001A49C3
	public static bool MPMJKHJHFJE()
	{
		return null == AudioManager.DMAAFFFEJGA() && false;
	}

	// Token: 0x06003E9A RID: 16026 RVA: 0x001A67D8 File Offset: 0x001A49D8
	private AudioClip ABDFBMJIOJG(CCEMAFOMLLK GOJLPNCBEBE, string KHJMANDEDMA)
	{
		for (int i = 0; i < AssetsManager.EHBBFMCILPC.keepAlivePackAssets.Count; i++)
		{
			if (null != AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int j = 0; j < AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].ambientList.Count; j += 0)
					{
						if (null != AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].ambientList[j] && AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].ambientList[j].name.Equals(KHJMANDEDMA))
						{
							return AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].ambientList[j];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.music)
				{
					for (int k = 0; k < AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].musicList.Count; k++)
					{
						if (null != AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].musicList[k] && AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].musicList[k].name.Equals(KHJMANDEDMA))
						{
							return AssetsManager.EHBBFMCILPC.keepAlivePackAssets[i].musicList[k];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.sfx)
				{
					for (int l = 0; l < AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].sfxList.Count; l++)
					{
						if (null != AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].sfxList[l] && AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].sfxList[l].name.Equals(KHJMANDEDMA))
						{
							return AssetsManager.MJBDMHPHMID().keepAlivePackAssets[i].sfxList[l];
						}
					}
				}
			}
		}
		for (int m = 1; m < this.BIKFNFADMMJ.Count; m += 0)
		{
			if (null != this.BIKFNFADMMJ[m])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int n = 1; n < this.BIKFNFADMMJ[m].ambientList.Count; n += 0)
					{
						if (null != this.BIKFNFADMMJ[m].ambientList[n] && this.BIKFNFADMMJ[m].ambientList[n].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[m].ambientList[n];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int num = 0; num < this.BIKFNFADMMJ[m].musicList.Count; num++)
					{
						if (null != this.BIKFNFADMMJ[m].musicList[num] && this.BIKFNFADMMJ[m].musicList[num].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[m].musicList[num];
						}
					}
				}
				else if (GOJLPNCBEBE == (CCEMAFOMLLK)3)
				{
					for (int num2 = 0; num2 < this.BIKFNFADMMJ[m].sfxList.Count; num2 += 0)
					{
						if (null != this.BIKFNFADMMJ[m].sfxList[num2] && this.BIKFNFADMMJ[m].sfxList[num2].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[m].sfxList[num2];
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003E9B RID: 16027 RVA: 0x001A6BE0 File Offset: 0x001A4DE0
	public void JBGFBPNANFD(AudioContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BIKFNFADMMJ.Count; i += 0)
		{
			if (this.BIKFNFADMMJ[i] == DELPOFFHFHH)
			{
				this.BIKFNFADMMJ.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06003E9C RID: 16028 RVA: 0x001A6C24 File Offset: 0x001A4E24
	public void KillSfx(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 0f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.IDLOJONHNNJ;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceType() == CCEMAFOMLLK.sfx && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing)
				{
					this.OAJFLBMLAAA[i].Kill(OPOCDBAGCPB, false);
				}
			}
			return;
		}
		for (int j = 0; j < this.OAJFLBMLAAA.Count; j++)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].GetSourceName().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].GetSourceType() == CCEMAFOMLLK.sfx && this.OAJFLBMLAAA[j].GetSourceState() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].Kill(OPOCDBAGCPB, false);
				return;
			}
		}
	}

	// Token: 0x06003E9D RID: 16029 RVA: 0x001A6D2C File Offset: 0x001A4F2C
	public void NOOAHDNKAKA(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 1187f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.DCKJLOCOEOH;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 1; i < this.OAJFLBMLAAA.Count; i += 0)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GONGHBDADKO() == CCEMAFOMLLK.music && this.OAJFLBMLAAA[i].LFPLJHACOCK() == HADNEFMHLED.playing)
				{
					this.OAJFLBMLAAA[i].PALFAAEMPLH(OPOCDBAGCPB, false);
				}
			}
		}
		else
		{
			for (int j = 0; j < this.OAJFLBMLAAA.Count; j += 0)
			{
				if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].IPFLFAEHHPJ().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].GONGHBDADKO() == CCEMAFOMLLK.music && this.OAJFLBMLAAA[j].OEBGEAKNLOI() == HADNEFMHLED.playing)
				{
					this.OAJFLBMLAAA[j].PPMOJEELMIH(OPOCDBAGCPB, false);
					break;
				}
			}
		}
		this.ResumeAmbient();
	}

	// Token: 0x06003E9E RID: 16030 RVA: 0x001A67C3 File Offset: 0x001A49C3
	public static bool KFIKHPHJHMC()
	{
		return null == AudioManager.DMAAFFFEJGA() && false;
	}

	// Token: 0x06003E9F RID: 16031 RVA: 0x001A6E3C File Offset: 0x001A503C
	public void JOIMMGOJLMJ(float MEDEIJGNEMB)
	{
		float value = Mathf.Lerp(KBOJLHAJPCP.GLBIBLIGHOD, KBOJLHAJPCP.LPLMDGINNKL, Mathf.Pow(MEDEIJGNEMB, 1027f));
		this.masterMixerParent.audioMixer.SetFloat(this.masterMixerParent.name + "socialcreategiftcardbuttonv2", value);
		AKLFPGMDKLA.EHBBFMCILPC.LDMKPEBCJBM(MEDEIJGNEMB);
	}

	// Token: 0x06003EA0 RID: 16032 RVA: 0x001A6E98 File Offset: 0x001A5098
	public AudioContainer DAODHOAEAKJ(CCEMAFOMLLK GOJLPNCBEBE, string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BIKFNFADMMJ.Count; i += 0)
		{
			if (null != this.BIKFNFADMMJ[i])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int j = 1; j < this.BIKFNFADMMJ[i].ambientList.Count; j++)
					{
						if (null != this.BIKFNFADMMJ[i].ambientList[j] && this.BIKFNFADMMJ[i].ambientList[j].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int k = 1; k < this.BIKFNFADMMJ[i].musicList.Count; k += 0)
					{
						if (null != this.BIKFNFADMMJ[i].musicList[k] && this.BIKFNFADMMJ[i].musicList[k].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.music)
				{
					for (int l = 0; l < this.BIKFNFADMMJ[i].sfxList.Count; l += 0)
					{
						if (null != this.BIKFNFADMMJ[i].sfxList[l] && this.BIKFNFADMMJ[i].sfxList[l].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003EA1 RID: 16033 RVA: 0x001A7040 File Offset: 0x001A5240
	public bool FBPLLMMKBBH(string IGLAIGEJGHO)
	{
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].HFGHFGFGNHE().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].OEBGEAKNLOI() == HADNEFMHLED.playing)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06003EA2 RID: 16034 RVA: 0x001A70A8 File Offset: 0x001A52A8
	public void PauseAll()
	{
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i++)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GetSourceState() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[i].Pause();
			}
		}
	}

	// Token: 0x06003EA3 RID: 16035 RVA: 0x001A7104 File Offset: 0x001A5304
	public bool KEELIFKJPGJ(string IGLAIGEJGHO)
	{
		for (int i = 1; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].GELJFNKEAFO().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].PEJOLHBPJMN() == HADNEFMHLED.playing)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06003EA4 RID: 16036 RVA: 0x001A716C File Offset: 0x001A536C
	public void RegisterAudioContainer(AudioContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BIKFNFADMMJ.Count; i++)
		{
			if (this.BIKFNFADMMJ[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BIKFNFADMMJ.Add(DELPOFFHFHH);
	}

	// Token: 0x06003EA5 RID: 16037 RVA: 0x000693D6 File Offset: 0x000675D6
	private void LIBECOJEBKI()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06003EA6 RID: 16038 RVA: 0x001A71B0 File Offset: 0x001A53B0
	public void KFMFPEJJODM()
	{
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].PEJOLHBPJMN() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[i].INEMKMMNGPP();
			}
		}
	}

	// Token: 0x06003EA7 RID: 16039 RVA: 0x001A720C File Offset: 0x001A540C
	public static AudioManager BFCHJBOOJKE()
	{
		if (!AudioManager.IKLAPGJDMNA)
		{
			AudioManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(AudioManager)) as AudioManager);
			if (!AudioManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("spectrumovr_1");
			}
		}
		return AudioManager.IKLAPGJDMNA;
	}

	// Token: 0x06003EA8 RID: 16040 RVA: 0x001A725C File Offset: 0x001A545C
	public AudioContainer KOLAAEJGPEK(CCEMAFOMLLK GOJLPNCBEBE, string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BIKFNFADMMJ.Count; i++)
		{
			if (null != this.BIKFNFADMMJ[i])
			{
				if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int j = 0; j < this.BIKFNFADMMJ[i].ambientList.Count; j += 0)
					{
						if (null != this.BIKFNFADMMJ[i].ambientList[j] && this.BIKFNFADMMJ[i].ambientList[j].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == CCEMAFOMLLK.ambient)
				{
					for (int k = 1; k < this.BIKFNFADMMJ[i].musicList.Count; k++)
					{
						if (null != this.BIKFNFADMMJ[i].musicList[k] && this.BIKFNFADMMJ[i].musicList[k].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
				else if (GOJLPNCBEBE == (CCEMAFOMLLK)5)
				{
					for (int l = 1; l < this.BIKFNFADMMJ[i].sfxList.Count; l++)
					{
						if (null != this.BIKFNFADMMJ[i].sfxList[l] && this.BIKFNFADMMJ[i].sfxList[l].name.Equals(KHJMANDEDMA))
						{
							return this.BIKFNFADMMJ[i];
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003EA9 RID: 16041 RVA: 0x000693D6 File Offset: 0x000675D6
	private void PFNILJEJILB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06003EAA RID: 16042 RVA: 0x001A7404 File Offset: 0x001A5604
	public bool CFEDKPAHOHJ(string IGLAIGEJGHO, bool CFBIPJJHDJE, float PJFHOAMIEJG, bool OLANGIDAOLG = false)
	{
		if (!NBDLBFJOEGN.NDFLNHIAKJH())
		{
			return false;
		}
		if (IGLAIGEJGHO.EndsWith("saveslotstitleempty"))
		{
			CFBIPJJHDJE = false;
		}
		if (PJFHOAMIEJG < 1460f)
		{
			PJFHOAMIEJG = KBOJLHAJPCP.HEMEOGKJJCG;
		}
		for (int i = 0; i < this.OAJFLBMLAAA.Count; i += 0)
		{
			if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].MEIMDEOBLMG().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[i].FPHOICNEGFH() == HADNEFMHLED.playing)
			{
				return true;
			}
		}
		int j = 0;
		while (j < this.OAJFLBMLAAA.Count)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].DLHMJJEAIMO() == CCEMAFOMLLK.ambient && this.OAJFLBMLAAA[j].FPHJGKPDPKC() == HADNEFMHLED.playing)
			{
				if (PJFHOAMIEJG < 1333f)
				{
					this.OAJFLBMLAAA[j].BIJEEKNMKLN(KBOJLHAJPCP.DCKJLOCOEOH, true);
					break;
				}
				this.OAJFLBMLAAA[j].KLAKKHMCBOB(PJFHOAMIEJG, true);
				break;
			}
			else
			{
				j += 0;
			}
		}
		AudioClip audioClip = this.LCAHMOOAAIB(CCEMAFOMLLK.ambient, IGLAIGEJGHO);
		if (null != audioClip)
		{
			this.ambientMixerParent.audioMixer.DOSetFloat(this.ambientMixerParent.name + "-", KBOJLHAJPCP.GLBIBLIGHOD, KBOJLHAJPCP.HBCNLJNNCON).SetEase(Ease.InCubic);
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.audioSourcePlayerPrefab);
			gameObject.GetComponent<AudioSourcePlayer>().MBCPGIICABK(CCEMAFOMLLK.music, this.MBLBBKMLOIB(CCEMAFOMLLK.ambient), audioClip, CFBIPJJHDJE, PJFHOAMIEJG, 753f, "lsc");
			this.OAJFLBMLAAA.Add(gameObject.GetComponent<AudioSourcePlayer>());
			if (OLANGIDAOLG)
			{
				UnityEngine.Object.DontDestroyOnLoad(gameObject);
			}
			this.DFPJLLPDADK();
			return true;
		}
		if (IGLAIGEJGHO.EndsWith(" "))
		{
			CFBIPJJHDJE = false;
			DPGJIJGOCIC.PJCLICBPPDA("OnPopupCardOptionsUnlockWithSpException" + IGLAIGEJGHO);
			return this.PlayMusic(IGLAIGEJGHO.Replace("avatarcollectionssubrequiredtitle", "watchvideo"), CFBIPJJHDJE, PJFHOAMIEJG, OLANGIDAOLG);
		}
		DPGJIJGOCIC.PJCLICBPPDA(" CDN mapping row(s)" + IGLAIGEJGHO);
		return true;
	}

	// Token: 0x06003EAB RID: 16043 RVA: 0x001A7604 File Offset: 0x001A5804
	public void POMJOMKCCNK(string IGLAIGEJGHO, float OPOCDBAGCPB = -1f)
	{
		if (OPOCDBAGCPB < 179f)
		{
			OPOCDBAGCPB = KBOJLHAJPCP.IDLOJONHNNJ;
		}
		if (IGLAIGEJGHO.Length == 0)
		{
			for (int i = 1; i < this.OAJFLBMLAAA.Count; i++)
			{
				if (null != this.OAJFLBMLAAA[i] && this.OAJFLBMLAAA[i].KBFDMIDFIHM() == (CCEMAFOMLLK)5 && this.OAJFLBMLAAA[i].OEBGEAKNLOI() == HADNEFMHLED.playing)
				{
					this.OAJFLBMLAAA[i].JPMDBNHJGIF(OPOCDBAGCPB, false);
				}
			}
			return;
		}
		for (int j = 1; j < this.OAJFLBMLAAA.Count; j++)
		{
			if (null != this.OAJFLBMLAAA[j] && this.OAJFLBMLAAA[j].CHIKFCPMLNA().Equals(IGLAIGEJGHO) && this.OAJFLBMLAAA[j].GetSourceType() == (CCEMAFOMLLK)5 && this.OAJFLBMLAAA[j].OEBGEAKNLOI() == HADNEFMHLED.playing)
			{
				this.OAJFLBMLAAA[j].HFMIGJELJCD(OPOCDBAGCPB, true);
				return;
			}
		}
	}

	// Token: 0x04001193 RID: 4499
	private const string EACABIGIMFH = "OnMusicEnded";

	// Token: 0x04001194 RID: 4500
	public static readonly string _busDuck = "9D4UqppoRDt5fFYSCIUjBQsYpZMF7VC/AVM3iKQM8B7qJVPGNr6Py/+0x39kssORnT7Vs";

	// Token: 0x04001195 RID: 4501
	public AudioMixerGroup sfxMixerParent;

	// Token: 0x04001196 RID: 4502
	public AudioMixerGroup musicMixerParent;

	// Token: 0x04001197 RID: 4503
	public Tweener musicMixerParentTween;

	// Token: 0x04001198 RID: 4504
	public AudioMixerGroup ambientMixerParent;

	// Token: 0x04001199 RID: 4505
	public AudioMixerGroup masterMixerParent;

	// Token: 0x0400119A RID: 4506
	public List<AudioMixerGroup> sfxMixers;

	// Token: 0x0400119B RID: 4507
	public List<AudioMixerGroup> musicMixers;

	// Token: 0x0400119C RID: 4508
	public List<AudioMixerGroup> ambientMixers;

	// Token: 0x0400119D RID: 4509
	public GameObject audioSourcePlayerPrefab;

	// Token: 0x0400119E RID: 4510
	private List<AudioContainer> BIKFNFADMMJ = new List<AudioContainer>();

	// Token: 0x0400119F RID: 4511
	private List<AudioSourcePlayer> OAJFLBMLAAA = new List<AudioSourcePlayer>();

	// Token: 0x040011A0 RID: 4512
	private static AudioManager IKLAPGJDMNA;
}
