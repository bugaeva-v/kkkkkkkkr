using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

// Token: 0x0200021F RID: 543
public class VideoManager : MonoBehaviour
{
	// Token: 0x060043BC RID: 17340 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool HOICDJBDLKB()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060043BD RID: 17341 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool NOEGAPEHEPP()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060043BE RID: 17342 RVA: 0x001D9C04 File Offset: 0x001D7E04
	public void AKLHGAOGHCB(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x060043BF RID: 17343 RVA: 0x001D9C48 File Offset: 0x001D7E48
	public void FCNHLMIKMMJ(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x060043C0 RID: 17344 RVA: 0x001D9C8C File Offset: 0x001D7E8C
	public void BJHGIOLLLCJ(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x060043C1 RID: 17345 RVA: 0x000693D6 File Offset: 0x000675D6
	private void DCMMAADPBPM()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060043C2 RID: 17346 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool GEGPMDNGALM()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060043C3 RID: 17347 RVA: 0x001D9CD0 File Offset: 0x001D7ED0
	private void OBONEJJNGMK()
	{
		if (VideoManager.IKLAPGJDMNA == this)
		{
			VideoManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060043C4 RID: 17348 RVA: 0x001D9CD0 File Offset: 0x001D7ED0
	private void NLOFDEFADCL()
	{
		if (VideoManager.IKLAPGJDMNA == this)
		{
			VideoManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060043C5 RID: 17349 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool ELJKNBABGPJ()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060043C6 RID: 17350 RVA: 0x001D9CE5 File Offset: 0x001D7EE5
	public static bool OELPPDGKIIK()
	{
		return null == VideoManager.EHBBFMCILPC;
	}

	// Token: 0x060043C7 RID: 17351 RVA: 0x001D9CF8 File Offset: 0x001D7EF8
	public void CKOMDIGGDHJ(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x060043C8 RID: 17352 RVA: 0x00003E52 File Offset: 0x00002052
	private void BPDHPMKCLNB()
	{
	}

	// Token: 0x060043C9 RID: 17353 RVA: 0x001D9D3C File Offset: 0x001D7F3C
	public void RegisterVideoContainer(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x060043CA RID: 17354 RVA: 0x001D9D80 File Offset: 0x001D7F80
	public static VideoManager FFLFMNPOCED()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("chsnapguid2");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x060043CB RID: 17355 RVA: 0x001D9DD0 File Offset: 0x001D7FD0
	public VideoClip OICOHGFJLJK(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060043CC RID: 17356 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool OBLJKLEMFFN()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060043CD RID: 17357 RVA: 0x001D9E8C File Offset: 0x001D808C
	public void JHOMBAKDLAC(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x060043CE RID: 17358 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool DKNGDLFGION()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060043CF RID: 17359 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool ANGHFHEDAOE()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060043D0 RID: 17360 RVA: 0x001D9ED0 File Offset: 0x001D80D0
	public VideoContainer JAEJKEDLDOD(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060043D1 RID: 17361 RVA: 0x001D9F80 File Offset: 0x001D8180
	public void DMEOIGEAPFE(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x060043D2 RID: 17362 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool HGDAODLMFPM()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060043D3 RID: 17363 RVA: 0x001D9FC4 File Offset: 0x001D81C4
	public VideoClip MCKCGGGOBAP(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j++)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060043D4 RID: 17364 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060043D5 RID: 17365 RVA: 0x001DA080 File Offset: 0x001D8280
	public VideoContainer IENNDEPKEHN(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060043D6 RID: 17366 RVA: 0x001DA130 File Offset: 0x001D8330
	public VideoContainer LGKACMKJJNJ(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j++)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060043D7 RID: 17367 RVA: 0x000693D6 File Offset: 0x000675D6
	private void KICOCDCNDGG()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060043D8 RID: 17368 RVA: 0x001DA1E0 File Offset: 0x001D83E0
	public VideoClip NFMMNKMLMGH(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j++)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060043D9 RID: 17369 RVA: 0x001DA29C File Offset: 0x001D849C
	public void EDBOECPBHOH(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x060043DA RID: 17370 RVA: 0x001DA2E0 File Offset: 0x001D84E0
	public void JHPBOKIAJJM(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x060043DB RID: 17371 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool MAGMAOFKIEP()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060043DC RID: 17372 RVA: 0x001DA324 File Offset: 0x001D8524
	public static VideoManager ADHEACMDLJN()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("anthology");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x060043DD RID: 17373 RVA: 0x001DA374 File Offset: 0x001D8574
	public VideoContainer DPCLHODAGKO(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060043DE RID: 17374 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool LPDMHDDKGHL()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060043DF RID: 17375 RVA: 0x001DA424 File Offset: 0x001D8624
	public void UnregisterVideoContainer(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x060043E0 RID: 17376 RVA: 0x00003E52 File Offset: 0x00002052
	private void MMFABJALMMO()
	{
	}

	// Token: 0x060043E1 RID: 17377 RVA: 0x00003E52 File Offset: 0x00002052
	private void MFPBKLMBANF()
	{
	}

	// Token: 0x060043E2 RID: 17378 RVA: 0x001DA468 File Offset: 0x001D8668
	public VideoClip HKIACOHNABI(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060043E3 RID: 17379 RVA: 0x001DA524 File Offset: 0x001D8724
	public void OJMJCOBKGHO(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x060043E4 RID: 17380 RVA: 0x001DA568 File Offset: 0x001D8768
	public VideoContainer CDHDCCJGGOH(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j++)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060043E5 RID: 17381 RVA: 0x001DA618 File Offset: 0x001D8818
	public VideoContainer MIKMGELODHJ(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060043E6 RID: 17382 RVA: 0x001DA6C7 File Offset: 0x001D88C7
	public static bool HMLBBKMNMHG()
	{
		return null == VideoManager.DBFLIEGGGNN();
	}

	// Token: 0x060043E7 RID: 17383 RVA: 0x001DA6DC File Offset: 0x001D88DC
	public VideoClip NHIPBBGIHAA(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060043E8 RID: 17384 RVA: 0x00003E52 File Offset: 0x00002052
	private void BIJFJADIAOK()
	{
	}

	// Token: 0x060043E9 RID: 17385 RVA: 0x001DA798 File Offset: 0x001D8998
	public void JNPOCACPPIC(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x060043EA RID: 17386 RVA: 0x001DA7DC File Offset: 0x001D89DC
	public void JADFHCLFPNJ(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x060043EB RID: 17387 RVA: 0x001DA820 File Offset: 0x001D8A20
	public void HPCECIICNMC(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x060043EC RID: 17388 RVA: 0x001D9CD0 File Offset: 0x001D7ED0
	private void GBFDPJNKOPA()
	{
		if (VideoManager.IKLAPGJDMNA == this)
		{
			VideoManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x060043ED RID: 17389 RVA: 0x001DA864 File Offset: 0x001D8A64
	public static VideoManager BOFMCPPFAMO()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("XXX");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x060043EE RID: 17390 RVA: 0x001DA8B4 File Offset: 0x001D8AB4
	public static VideoManager HEDIEIICOOG()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("ok");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x060043EF RID: 17391 RVA: 0x001DA904 File Offset: 0x001D8B04
	public void JMLHLFPNEME(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x060043F0 RID: 17392 RVA: 0x000693D6 File Offset: 0x000675D6
	private void FIGJOFLIKKI()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060043F1 RID: 17393 RVA: 0x001DA948 File Offset: 0x001D8B48
	public void AEINCBNEFPK(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x060043F2 RID: 17394 RVA: 0x001DA98C File Offset: 0x001D8B8C
	public static bool KFPMJOBAPAC()
	{
		return !(null == VideoManager.FPHICJFMJMJ());
	}

	// Token: 0x060043F3 RID: 17395 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool GCEIKBIIFCN()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060043F4 RID: 17396 RVA: 0x001DA9A0 File Offset: 0x001D8BA0
	public VideoClip KCPKDBBIOPK(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j++)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060043F5 RID: 17397 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool EPINJFAFPOP()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x060043F6 RID: 17398 RVA: 0x001DAA5C File Offset: 0x001D8C5C
	public void EGIEHJAGKAO(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x060043F7 RID: 17399 RVA: 0x00003E52 File Offset: 0x00002052
	private void KJLNIJOHJGP()
	{
	}

	// Token: 0x060043F8 RID: 17400 RVA: 0x001DAAA0 File Offset: 0x001D8CA0
	public VideoClip CEGPAKKBDON(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060043F9 RID: 17401 RVA: 0x001DAB5C File Offset: 0x001D8D5C
	public void OCDHAAMFKGH(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x060043FA RID: 17402 RVA: 0x001DABA0 File Offset: 0x001D8DA0
	public static bool HLIJBDKAOAC()
	{
		return null == VideoManager.IIADANEAENB() && false;
	}

	// Token: 0x060043FB RID: 17403 RVA: 0x00003E52 File Offset: 0x00002052
	private void JINGEKHJOGH()
	{
	}

	// Token: 0x060043FC RID: 17404 RVA: 0x001DABB4 File Offset: 0x001D8DB4
	public void JHPDMJJNPKA(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x060043FD RID: 17405 RVA: 0x001DABF8 File Offset: 0x001D8DF8
	public VideoContainer EBLOFHGAEBD(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x060043FE RID: 17406 RVA: 0x001DACA8 File Offset: 0x001D8EA8
	public static VideoManager EHBBFMCILPC
	{
		get
		{
			if (!VideoManager.IKLAPGJDMNA)
			{
				VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
				if (!VideoManager.IKLAPGJDMNA)
				{
					DPGJIJGOCIC.ANOPFDLPKGC("There needs to be one active VideoManager script on a GameObject in your scene.");
				}
			}
			return VideoManager.IKLAPGJDMNA;
		}
	}

	// Token: 0x060043FF RID: 17407 RVA: 0x001DACF8 File Offset: 0x001D8EF8
	public VideoClip GEONJNLDIEI(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j++)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06004400 RID: 17408 RVA: 0x001DADB4 File Offset: 0x001D8FB4
	public VideoClip SearchContainersForVideoClip(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j++)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06004401 RID: 17409 RVA: 0x000693D6 File Offset: 0x000675D6
	private void EIIKCHOGIBH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004402 RID: 17410 RVA: 0x000693D6 File Offset: 0x000675D6
	private void LCCCCHNJEMB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004403 RID: 17411 RVA: 0x001DAE6E File Offset: 0x001D906E
	public static bool PBBHMFPFNFB()
	{
		return null == VideoManager.PKEINLPIAEH();
	}

	// Token: 0x06004404 RID: 17412 RVA: 0x001DAE80 File Offset: 0x001D9080
	public static VideoManager LMCCLMFGEBD()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("tdgcds");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x06004405 RID: 17413 RVA: 0x001DAED0 File Offset: 0x001D90D0
	public void EKNNHBEIDGG(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06004406 RID: 17414 RVA: 0x001DAF14 File Offset: 0x001D9114
	public static VideoManager IIADANEAENB()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("\nINK:");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x06004407 RID: 17415 RVA: 0x001D9CD0 File Offset: 0x001D7ED0
	private void HLKKMONAIMG()
	{
		if (VideoManager.IKLAPGJDMNA == this)
		{
			VideoManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06004408 RID: 17416 RVA: 0x000693D6 File Offset: 0x000675D6
	private void OPFLFDKJGFJ()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004409 RID: 17417 RVA: 0x000693D6 File Offset: 0x000675D6
	private void DCEHHOHHFDM()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600440A RID: 17418 RVA: 0x001DAF64 File Offset: 0x001D9164
	public VideoClip KNDBPOMIOCD(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600440B RID: 17419 RVA: 0x001DB020 File Offset: 0x001D9220
	public void AFBNAKAAPNE(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600440C RID: 17420 RVA: 0x001DB064 File Offset: 0x001D9264
	public VideoContainer JPMNBGLJBIC(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600440D RID: 17421 RVA: 0x00003E52 File Offset: 0x00002052
	private void BAKDBLFFMFD()
	{
	}

	// Token: 0x0600440E RID: 17422 RVA: 0x001DB114 File Offset: 0x001D9314
	public void LBKEIBPHEJN(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x0600440F RID: 17423 RVA: 0x001DB158 File Offset: 0x001D9358
	public static VideoManager OOGPALHPNGM()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("acliffbw22");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x06004410 RID: 17424 RVA: 0x001DB1A8 File Offset: 0x001D93A8
	public VideoClip GOAJALDIKEN(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j++)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06004411 RID: 17425 RVA: 0x000693D6 File Offset: 0x000675D6
	private void FLGIOJBKGIM()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004412 RID: 17426 RVA: 0x001DB262 File Offset: 0x001D9462
	public static bool NDKCLMEKMDI()
	{
		return !(null == VideoManager.EHBBFMCILPC);
	}

	// Token: 0x06004413 RID: 17427 RVA: 0x001DB274 File Offset: 0x001D9474
	public static VideoManager AIMEBOBBHMC()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("errortitle");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x06004414 RID: 17428 RVA: 0x001DB2C4 File Offset: 0x001D94C4
	public void DJCJAIDPFBK(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06004415 RID: 17429 RVA: 0x001DB308 File Offset: 0x001D9508
	public void FIAOIJOANCL(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x06004416 RID: 17430 RVA: 0x001DB34C File Offset: 0x001D954C
	public static VideoManager APFOBOLCFJE()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("energyhinttitle");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x06004417 RID: 17431 RVA: 0x001DB39C File Offset: 0x001D959C
	public void MPBAGLDJOAF(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x06004418 RID: 17432 RVA: 0x001DB3E0 File Offset: 0x001D95E0
	public void JFCGLKNMIFF(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06004419 RID: 17433 RVA: 0x001DB424 File Offset: 0x001D9624
	public VideoContainer HBNMJMOILCH(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600441A RID: 17434 RVA: 0x001D9CD0 File Offset: 0x001D7ED0
	private void LFEEHGLHJDN()
	{
		if (VideoManager.IKLAPGJDMNA == this)
		{
			VideoManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600441B RID: 17435 RVA: 0x001DB4D3 File Offset: 0x001D96D3
	public static bool LOBMCIABDEI()
	{
		return null == VideoManager.EOOPNMILPKG() && false;
	}

	// Token: 0x0600441C RID: 17436 RVA: 0x001DB4E8 File Offset: 0x001D96E8
	public void MFPEBPMHNLG(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600441D RID: 17437 RVA: 0x001DB52C File Offset: 0x001D972C
	public void BKEJCCGHPFJ(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600441E RID: 17438 RVA: 0x001DB570 File Offset: 0x001D9770
	public void HBOCGMPCFHB(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600441F RID: 17439 RVA: 0x001DB5B4 File Offset: 0x001D97B4
	public VideoContainer GetContainerForVideoClip(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j++)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06004420 RID: 17440 RVA: 0x001DB664 File Offset: 0x001D9864
	public static VideoManager DBFLIEGGGNN()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OffensiveWordsManager.IsOffensive() true for word ");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x06004421 RID: 17441 RVA: 0x00003E52 File Offset: 0x00002052
	private void HPDHFIHPKGP()
	{
	}

	// Token: 0x06004422 RID: 17442 RVA: 0x001DB6B4 File Offset: 0x001D98B4
	public static VideoManager GIPAKOPBBEO()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("credo");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x06004423 RID: 17443 RVA: 0x001DB704 File Offset: 0x001D9904
	public void HCEPDEHNGBK(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x06004424 RID: 17444 RVA: 0x001DB262 File Offset: 0x001D9462
	public static bool IsAvailable()
	{
		return !(null == VideoManager.EHBBFMCILPC);
	}

	// Token: 0x06004425 RID: 17445 RVA: 0x001D9CD0 File Offset: 0x001D7ED0
	private void CDLEEFPLPLN()
	{
		if (VideoManager.IKLAPGJDMNA == this)
		{
			VideoManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06004426 RID: 17446 RVA: 0x001DB748 File Offset: 0x001D9948
	public VideoContainer GHOBDOMMEOJ(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j++)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06004428 RID: 17448 RVA: 0x001DB80C File Offset: 0x001D9A0C
	public void AFLCEKJNEFH(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x06004429 RID: 17449 RVA: 0x001DB850 File Offset: 0x001D9A50
	public void MCLGFJCJKLN(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600442A RID: 17450 RVA: 0x001DB894 File Offset: 0x001D9A94
	public void HCKINNDKJJF(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600442B RID: 17451 RVA: 0x001DB8D8 File Offset: 0x001D9AD8
	public void DJHINIGLFGD(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x0600442C RID: 17452 RVA: 0x001DB91C File Offset: 0x001D9B1C
	public static VideoManager EOOPNMILPKG()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("p");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x0600442D RID: 17453 RVA: 0x001D9CD0 File Offset: 0x001D7ED0
	private void OnDestroy()
	{
		if (VideoManager.IKLAPGJDMNA == this)
		{
			VideoManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600442E RID: 17454 RVA: 0x001DB96C File Offset: 0x001D9B6C
	public static VideoManager JBMLNGMBICE()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("OnAvatarCollectionSelect");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x0600442F RID: 17455 RVA: 0x001DB9BC File Offset: 0x001D9BBC
	public static VideoManager PKEINLPIAEH()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("no");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x06004430 RID: 17456 RVA: 0x001DBA0C File Offset: 0x001D9C0C
	public VideoContainer KDPPDCBIBJA(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06004431 RID: 17457 RVA: 0x001DBABB File Offset: 0x001D9CBB
	public static bool FMJNHDGBHMN()
	{
		return !(null == VideoManager.GIPAKOPBBEO()) || true;
	}

	// Token: 0x06004432 RID: 17458 RVA: 0x001DBACD File Offset: 0x001D9CCD
	public static bool OBGJBICNEHE()
	{
		return !(null == VideoManager.FFLFMNPOCED());
	}

	// Token: 0x06004433 RID: 17459 RVA: 0x001DBADF File Offset: 0x001D9CDF
	public static bool DEPDDOFBDEG()
	{
		return !(null == VideoManager.FFLFMNPOCED()) || true;
	}

	// Token: 0x06004434 RID: 17460 RVA: 0x001DBAF4 File Offset: 0x001D9CF4
	public VideoClip PABNKHPKBEN(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06004435 RID: 17461 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool GOEKDOLCGOB()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x06004436 RID: 17462 RVA: 0x001DBBB0 File Offset: 0x001D9DB0
	public void GEIMMEAFKCH(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x06004437 RID: 17463 RVA: 0x001DBBF4 File Offset: 0x001D9DF4
	public static VideoManager KLAKLFCOMJC()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("sto");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x06004438 RID: 17464 RVA: 0x001DBC44 File Offset: 0x001D9E44
	public VideoClip MDNDNBENFNA(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j++)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06004439 RID: 17465 RVA: 0x001DBD00 File Offset: 0x001D9F00
	public void FBOEAOPFAHH(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x0600443A RID: 17466 RVA: 0x000693D6 File Offset: 0x000675D6
	private void LFOJBMBCOFP()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600443B RID: 17467 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x0600443C RID: 17468 RVA: 0x001DBD44 File Offset: 0x001D9F44
	public static bool ODIPMFACAJH()
	{
		return !(null == VideoManager.EHBBFMCILPC) || true;
	}

	// Token: 0x0600443D RID: 17469 RVA: 0x001DBD58 File Offset: 0x001D9F58
	public VideoContainer FGJFKLHFLLK(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600443E RID: 17470 RVA: 0x001DBE08 File Offset: 0x001DA008
	public VideoClip DIILOMJLMOH(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600443F RID: 17471 RVA: 0x000693D6 File Offset: 0x000675D6
	private void LIPLGPPPJCJ()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004440 RID: 17472 RVA: 0x001D9CD0 File Offset: 0x001D7ED0
	private void LDBOLMLPPHJ()
	{
		if (VideoManager.IKLAPGJDMNA == this)
		{
			VideoManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06004441 RID: 17473 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool BOMEIICAFLJ()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x06004442 RID: 17474 RVA: 0x000693D6 File Offset: 0x000675D6
	private void OMDANGLDJIN()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004443 RID: 17475 RVA: 0x001D9CD0 File Offset: 0x001D7ED0
	private void HGGMIMABEFD()
	{
		if (VideoManager.IKLAPGJDMNA == this)
		{
			VideoManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06004444 RID: 17476 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool EDNHNKNDNEN()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x06004445 RID: 17477 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
	public static bool IsInitialized()
	{
		if (null == VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
		}
		return VideoManager.IKLAPGJDMNA != null;
	}

	// Token: 0x06004446 RID: 17478 RVA: 0x001DBEC4 File Offset: 0x001DA0C4
	public void PBFJEJMHGFM(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x06004447 RID: 17479 RVA: 0x001DBF08 File Offset: 0x001DA108
	public static VideoManager FPHICJFMJMJ()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("eventsoon");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x06004448 RID: 17480 RVA: 0x001DBF58 File Offset: 0x001DA158
	public void PNJPOJAKING(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				return;
			}
		}
		this.BCEOPHPIGPD.Add(DELPOFFHFHH);
	}

	// Token: 0x06004449 RID: 17481 RVA: 0x001DBF9C File Offset: 0x001DA19C
	public VideoContainer OLPDFDLOMJG(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j++)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600444A RID: 17482 RVA: 0x001D9CD0 File Offset: 0x001D7ED0
	private void OBLONHAGNFB()
	{
		if (VideoManager.IKLAPGJDMNA == this)
		{
			VideoManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x0600444B RID: 17483 RVA: 0x001DC04C File Offset: 0x001DA24C
	public void MKDDKKFICGK(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600444C RID: 17484 RVA: 0x001DC090 File Offset: 0x001DA290
	public static bool NADGOMBPLGO()
	{
		return null == VideoManager.FPHICJFMJMJ() && false;
	}

	// Token: 0x0600444D RID: 17485 RVA: 0x001DC0A4 File Offset: 0x001DA2A4
	public void BJIEMJJPFKB(VideoContainer DELPOFFHFHH)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600444E RID: 17486 RVA: 0x001DC0E8 File Offset: 0x001DA2E8
	public void GPMMPALBJOB(VideoContainer DELPOFFHFHH)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (this.BCEOPHPIGPD[i] == DELPOFFHFHH)
			{
				this.BCEOPHPIGPD.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600444F RID: 17487 RVA: 0x001DC12C File Offset: 0x001DA32C
	public VideoClip DCPKDCGLEDN(string KHJMANDEDMA)
	{
		for (int i = 1; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j++)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06004450 RID: 17488 RVA: 0x00003E52 File Offset: 0x00002052
	private void JLCMPLIMAEI()
	{
	}

	// Token: 0x06004451 RID: 17489 RVA: 0x000693D6 File Offset: 0x000675D6
	private void OLBENOPNOBH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004452 RID: 17490 RVA: 0x001DC1E8 File Offset: 0x001DA3E8
	public VideoClip BPJECOJMIPH(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 0; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06004453 RID: 17491 RVA: 0x001DC2A4 File Offset: 0x001DA4A4
	public VideoClip PAPCGMJDPMD(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i += 0)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i].clipList[j];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06004454 RID: 17492 RVA: 0x001DC360 File Offset: 0x001DA560
	public static VideoManager HENEDBALCLN()
	{
		if (!VideoManager.IKLAPGJDMNA)
		{
			VideoManager.IKLAPGJDMNA = (UnityEngine.Object.FindObjectOfType(typeof(VideoManager)) as VideoManager);
			if (!VideoManager.IKLAPGJDMNA)
			{
				DPGJIJGOCIC.ANOPFDLPKGC("EnvironmentMorphManager - morph shader not found in Resources:ShaderEnvMorphClient");
			}
		}
		return VideoManager.IKLAPGJDMNA;
	}

	// Token: 0x06004455 RID: 17493 RVA: 0x001D9CD0 File Offset: 0x001D7ED0
	private void LKKFDMLEHFB()
	{
		if (VideoManager.IKLAPGJDMNA == this)
		{
			VideoManager.IKLAPGJDMNA = null;
		}
	}

	// Token: 0x06004456 RID: 17494 RVA: 0x000693D6 File Offset: 0x000675D6
	private void GACMCJDDJJD()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004457 RID: 17495 RVA: 0x000693D6 File Offset: 0x000675D6
	private void ALIKHOFAKKB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06004458 RID: 17496 RVA: 0x001DC3B0 File Offset: 0x001DA5B0
	public VideoContainer FIGFHOCNANF(string KHJMANDEDMA)
	{
		for (int i = 0; i < this.BCEOPHPIGPD.Count; i++)
		{
			if (null != this.BCEOPHPIGPD[i])
			{
				for (int j = 1; j < this.BCEOPHPIGPD[i].clipList.Count; j += 0)
				{
					if (null != this.BCEOPHPIGPD[i].clipList[j] && this.BCEOPHPIGPD[i].clipList[j].name.Equals(KHJMANDEDMA))
					{
						return this.BCEOPHPIGPD[i];
					}
				}
			}
		}
		return null;
	}

	// Token: 0x040012CE RID: 4814
	private List<VideoContainer> BCEOPHPIGPD = new List<VideoContainer>();

	// Token: 0x040012CF RID: 4815
	private static VideoManager IKLAPGJDMNA;
}
