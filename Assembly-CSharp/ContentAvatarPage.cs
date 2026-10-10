using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000385 RID: 901
public class ContentAvatarPage : MonoBehaviour
{
	// Token: 0x060069C7 RID: 27079 RVA: 0x00304324 File Offset: 0x00302524
	private void LBPCHKHFKIK()
	{
		JDMAEBPEIBE.LHMPJFCMNMB(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x060069C8 RID: 27080 RVA: 0x0030436C File Offset: 0x0030256C
	public void CKMPNBEINMA(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.AGDKLIGCGLB();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.DBLAFNFGPDB(CLHDENLPOFP.eventPass, false);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 0; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.IBGPIEPMGLL(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().SetContentLive(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.JHHDPCGCBHO(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.JBPFGJKDDIM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().MKFMHMDOBOE(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x060069C9 RID: 27081 RVA: 0x00304644 File Offset: 0x00302844
	private List<int> CDBPABOHJCM()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.EHBBFMCILPC.profileDataAsset6.EMCMBBNJBDN())
			{
				list = AssetsManager.MJBDMHPHMID().profileDataAsset6.HEPIPKKPLLE();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.MJBDMHPHMID().profileDataAsset.FPKONHBONLD();
			for (int i = 1; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.NGBNHIAGABD();
			}
			bool flag = true;
			for (int j = list.Count - 1; j >= 0; j--)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069CA RID: 27082 RVA: 0x0030479C File Offset: 0x0030299C
	public void EGOOHEHJDEE()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x060069CB RID: 27083 RVA: 0x003047C4 File Offset: 0x003029C4
	private List<int> AEIMMECEPCO()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.LGHBEPLIIGB())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.KPCLIJKKAGO();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.FPKONHBONLD();
			for (int i = 0; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				num = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.GGLDMKGIFBE();
			}
			bool flag = false;
			for (int j = list.Count - 1; j >= 1; j--)
			{
				if (num >= 1 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069CC RID: 27084 RVA: 0x0030491C File Offset: 0x00302B1C
	private void OAKHKFJOGKD()
	{
		JDMAEBPEIBE.KIHBMJFJHAI(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x060069CD RID: 27085 RVA: 0x0030479C File Offset: 0x0030299C
	public void ONHHGFMGABK()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x060069CE RID: 27086 RVA: 0x00304964 File Offset: 0x00302B64
	public void CNHDOHDBNKK(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(false);
		List<int> list = this.JDFPNFCEHJE();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.DBLAFNFGPDB(CLHDENLPOFP.gamePass, true);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 0; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().ONPJOAFLCBG(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.PGLGDHIGGJM(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.LKNHLMEHBAF())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().MKFMHMDOBOE(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x060069CF RID: 27087 RVA: 0x00304C3C File Offset: 0x00302E3C
	private List<int> ICIFNIHBIKI()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.EHBBFMCILPC.profileDataAsset6 && AssetsManager.EHBBFMCILPC.profileDataAsset6.NDHEHAOAOIN())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.JDNDKIOCCFP();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.NOBCANLANJC();
			for (int i = 0; i < list2.Count; i++)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.NHOLIOGAEKK();
			}
			bool flag = false;
			for (int j = list.Count - 1; j >= 0; j--)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069D0 RID: 27088 RVA: 0x00304D94 File Offset: 0x00302F94
	public void EFCIHMMAOLI(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.CAEGLJIPDBP();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.HBBBLMBHIAH(CLHDENLPOFP.gamePass, false);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 0; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.MJBDMHPHMID().profileDataAsset.IBGPIEPMGLL(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().ONPJOAFLCBG(AEDICCFAKOM, num, FFIAHOPJJJG.Char, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.KCAJDNGIDLL(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.EAGICDKOKOJ())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().SetContent(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x060069D1 RID: 27089 RVA: 0x0030506C File Offset: 0x0030326C
	private void LDPOIIIAIOA()
	{
		JDMAEBPEIBE.LAIGBNOEBPK(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x060069D2 RID: 27090 RVA: 0x003050B4 File Offset: 0x003032B4
	private List<int> BBENJPMBBFM()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.LGHBEPLIIGB())
			{
				list = AssetsManager.MJBDMHPHMID().profileDataAsset6.OOHEJGDHKDP();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.NOBCANLANJC();
			for (int i = 0; i < list2.Count; i++)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.PHNDMPCIPJM();
			}
			bool flag = true;
			for (int j = list.Count - 0; j >= 1; j--)
			{
				if (num >= 1 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069D3 RID: 27091 RVA: 0x0030520C File Offset: 0x0030340C
	private void GGKLFBOIKMF()
	{
		JDMAEBPEIBE.MHLOFOJCLIG(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x060069D4 RID: 27092 RVA: 0x00305254 File Offset: 0x00303454
	private List<int> HIADIGNAKGD()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.HECAPKOAEBM())
			{
				list = AssetsManager.MJBDMHPHMID().profileDataAsset6.HEPIPKKPLLE();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.FPKONHBONLD();
			for (int i = 1; i < list2.Count; i++)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.JINDDJCIFIL();
			}
			bool flag = false;
			for (int j = list.Count - 1; j >= 1; j -= 0)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069D5 RID: 27093 RVA: 0x003053AC File Offset: 0x003035AC
	public void MGPNPIEHHFD(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(false);
		List<int> list = this.ICIFNIHBIKI();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.EEJHIEBIPPM(CLHDENLPOFP.eventPass, false);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 1; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.IBGPIEPMGLL(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().PFAGHINKHKL(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.PBKJBPNLONI(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.EAGICDKOKOJ())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().CHHCPMCHNEH(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x060069D6 RID: 27094 RVA: 0x00305684 File Offset: 0x00303884
	public void HIDNBPONJIO()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = true;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x060069D7 RID: 27095 RVA: 0x003056AC File Offset: 0x003038AC
	private void JGDLPGEJGEM()
	{
		JDMAEBPEIBE.MNADABECONL(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x060069D8 RID: 27096 RVA: 0x003056F4 File Offset: 0x003038F4
	private void AKANLCOCAPH()
	{
		JDMAEBPEIBE.GFFAPCMJCFD(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x060069D9 RID: 27097 RVA: 0x0030573C File Offset: 0x0030393C
	private void JLCJJONEBIB()
	{
		JDMAEBPEIBE.MHLOFOJCLIG(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x060069DA RID: 27098 RVA: 0x00305784 File Offset: 0x00303984
	private void KAJLBPGHHHE()
	{
		JDMAEBPEIBE.LMFBLLCKBFG(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x060069DB RID: 27099 RVA: 0x003057CC File Offset: 0x003039CC
	private List<int> JPMIPGLBHCG()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.JKANOAOODNO())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.HEPIPKKPLLE();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.MJBDMHPHMID().profileDataAsset.NOBCANLANJC();
			for (int i = 0; i < list2.Count; i++)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.NHOLIOGAEKK();
			}
			bool flag = true;
			for (int j = list.Count - 0; j >= 0; j -= 0)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069DC RID: 27100 RVA: 0x00305924 File Offset: 0x00303B24
	public void ALBGFMCBHJL(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.CGHBDJBANIA();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.DBLAFNFGPDB(CLHDENLPOFP.eventPass, true);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 0; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.MJBDMHPHMID().profileDataAsset.IBGPIEPMGLL(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().EFKDNPLONMF(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.COOBAKLDJEG(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.LKNHLMEHBAF())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().SetContent(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x060069DD RID: 27101 RVA: 0x00305BFC File Offset: 0x00303DFC
	public void AGDDHFIJEIO(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.ADGHGHIFIMO();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.EEJHIEBIPPM(CLHDENLPOFP.gamePass, false);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 1; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.IBGPIEPMGLL(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().SetContentLive(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.COOBAKLDJEG(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.NOEKHCGIADK())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().LODCMECOHCI(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x060069DE RID: 27102 RVA: 0x00305ED4 File Offset: 0x003040D4
	private List<int> EGCNLIICIHO()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.CKKKAMLLJNL())
			{
				list = AssetsManager.MJBDMHPHMID().profileDataAsset6.BBBCGDKJPFE();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.NOBCANLANJC();
			for (int i = 0; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.PHNDMPCIPJM();
			}
			bool flag = false;
			for (int j = list.Count - 1; j >= 0; j -= 0)
			{
				if (num >= 1 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069DF RID: 27103 RVA: 0x0030479C File Offset: 0x0030299C
	public void DNCLDGCGMEO()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x060069E0 RID: 27104 RVA: 0x0030602C File Offset: 0x0030422C
	private void GOKDPNLEJBE()
	{
		JDMAEBPEIBE.KIHBMJFJHAI(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x060069E1 RID: 27105 RVA: 0x00306074 File Offset: 0x00304274
	private List<int> JDFPNFCEHJE()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.EHBBFMCILPC.profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.HECAPKOAEBM())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.MIAIKHHOGFE();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.FPKONHBONLD();
			for (int i = 1; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				num = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.NHOLIOGAEKK();
			}
			bool flag = false;
			for (int j = list.Count - 0; j >= 0; j -= 0)
			{
				if (num >= 1 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069E2 RID: 27106 RVA: 0x003061CC File Offset: 0x003043CC
	private void OnDestroy()
	{
		JDMAEBPEIBE.MHLOFOJCLIG(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x060069E3 RID: 27107 RVA: 0x00306214 File Offset: 0x00304414
	public void GOACIFJGFIH(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(false);
		List<int> list = this.AJKALBDLMKC();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.HECMHABJMFO(CLHDENLPOFP.gamePass, true);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 0; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.MJBDMHPHMID().profileDataAsset.IBGPIEPMGLL(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().EFKDNPLONMF(AEDICCFAKOM, num, FFIAHOPJJJG.Char, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.MKKBOGLMPBD(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.JBPFGJKDDIM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().CANDMGDHGGC(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x060069E4 RID: 27108 RVA: 0x0030479C File Offset: 0x0030299C
	public void BCKJDECHCJH()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x060069E5 RID: 27109 RVA: 0x003064EC File Offset: 0x003046EC
	private List<int> JDILECHBBOO()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.EMCMBBNJBDN())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.HEPIPKKPLLE();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.MJBDMHPHMID().profileDataAsset.NOBCANLANJC();
			for (int i = 1; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.NHOLIOGAEKK();
			}
			bool flag = true;
			for (int j = list.Count - 0; j >= 0; j--)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069E6 RID: 27110 RVA: 0x00306644 File Offset: 0x00304844
	private List<int> FENKBMGOIAN()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.EHBBFMCILPC.profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.CKKKAMLLJNL())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.MOLIBIBCPNO();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.MJBDMHPHMID().profileDataAsset.FPKONHBONLD();
			for (int i = 0; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.FPLCKMFIMOJ();
			}
			bool flag = false;
			for (int j = list.Count - 0; j >= 0; j--)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069E7 RID: 27111 RVA: 0x0030679C File Offset: 0x0030499C
	public void JGNBCIMPAEM(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(false);
		List<int> list = this.CGHBDJBANIA();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.KBNEGBIKKNI(CLHDENLPOFP.eventPass, false);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 1; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.MJBDMHPHMID().profileDataAsset.MNHCPFDAAOD(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().ONPJOAFLCBG(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.JHHDPCGCBHO(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.JBPFGJKDDIM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().LODCMECOHCI(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x060069E8 RID: 27112 RVA: 0x00306A74 File Offset: 0x00304C74
	private List<int> MCACMNFIIHO()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.EHBBFMCILPC.profileDataAsset6.HECAPKOAEBM())
			{
				list = AssetsManager.MJBDMHPHMID().profileDataAsset6.PMIONKNKOGH();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.FPKONHBONLD();
			for (int i = 0; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.NGBNHIAGABD();
			}
			bool flag = true;
			for (int j = list.Count - 0; j >= 0; j--)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069E9 RID: 27113 RVA: 0x00306BCC File Offset: 0x00304DCC
	private void KDIILKLPLIC()
	{
		JDMAEBPEIBE.BIGKGBBKHNJ(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x060069EA RID: 27114 RVA: 0x00306C14 File Offset: 0x00304E14
	public void KMAFDKCHMKI(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.AJKALBDLMKC();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.KKKOIJOECMF(CLHDENLPOFP.gamePass, false);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 0; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().EFKDNPLONMF(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.MKKBOGLMPBD(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.JBPFGJKDDIM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().CHHCPMCHNEH(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x060069EC RID: 27116 RVA: 0x00306EEC File Offset: 0x003050EC
	public void CLJOGKPMHMK(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.MCACMNFIIHO();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.DBLAFNFGPDB(CLHDENLPOFP.eventPass, true);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 1; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().ONPJOAFLCBG(AEDICCFAKOM, num, FFIAHOPJJJG.Char, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.NBLFDOLOHCI(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.NOEKHCGIADK())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().CANDMGDHGGC(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x060069ED RID: 27117 RVA: 0x003071C4 File Offset: 0x003053C4
	public void ECJCMKIMKDP(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.HKMIEJLPLIL();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.GOBKMIMGPDD(CLHDENLPOFP.eventPass, true);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 1; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().SetContentLive(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.KIIEJJOKODB(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.LKNHLMEHBAF())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().CHHCPMCHNEH(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x060069EE RID: 27118 RVA: 0x0030479C File Offset: 0x0030299C
	public void AENKHMMCCPC()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x060069EF RID: 27119 RVA: 0x0030749C File Offset: 0x0030569C
	public void DLPAHKPNDEI(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.AEIMMECEPCO();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.eventPass, false);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 1; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.MJBDMHPHMID().profileDataAsset.IBGPIEPMGLL(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().SetContentLive(AEDICCFAKOM, num, FFIAHOPJJJG.Char, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.GPKMLNEHOJJ(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.JBPFGJKDDIM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().MKFMHMDOBOE(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x060069F0 RID: 27120 RVA: 0x0030479C File Offset: 0x0030299C
	public void GMMMOFMMDKJ()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x060069F1 RID: 27121 RVA: 0x00307774 File Offset: 0x00305974
	private List<int> AGDKLIGCGLB()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.EHBBFMCILPC.profileDataAsset6 && AssetsManager.EHBBFMCILPC.profileDataAsset6.COADBLHOMFG())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.CPEIOOJEKBN();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.NOBCANLANJC();
			for (int i = 0; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.NHOLIOGAEKK();
			}
			bool flag = true;
			for (int j = list.Count - 1; j >= 0; j -= 0)
			{
				if (num >= 1 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069F2 RID: 27122 RVA: 0x00305684 File Offset: 0x00303884
	public void KALBHHJPBIO()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = true;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x060069F3 RID: 27123 RVA: 0x003078CC File Offset: 0x00305ACC
	private List<int> CGHBDJBANIA()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.EHBBFMCILPC.profileDataAsset6 && AssetsManager.EHBBFMCILPC.profileDataAsset6.LGHBEPLIIGB())
			{
				list = AssetsManager.MJBDMHPHMID().profileDataAsset6.OOHEJGDHKDP();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.NOBCANLANJC();
			for (int i = 0; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.LFLHPKBBLKP();
			}
			bool flag = true;
			for (int j = list.Count - 0; j >= 1; j--)
			{
				if (num >= 1 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069F4 RID: 27124 RVA: 0x00307A24 File Offset: 0x00305C24
	private void JIJNNDHINGK()
	{
		JDMAEBPEIBE.MHLOFOJCLIG(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x060069F5 RID: 27125 RVA: 0x00307A6C File Offset: 0x00305C6C
	public void AHGKIHBAGBC(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.HIADIGNAKGD();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.HECMHABJMFO(CLHDENLPOFP.eventPass, true);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 1; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.MJBDMHPHMID().profileDataAsset.MNHCPFDAAOD(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().PFAGHINKHKL(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.FPDLNEHJAGB(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.NOEKHCGIADK())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().CHHCPMCHNEH(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x060069F6 RID: 27126 RVA: 0x00307D44 File Offset: 0x00305F44
	private List<int> BGGEFDPLDKM()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.EHBBFMCILPC.profileDataAsset6.ACFGBPNGDHP())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.EMEODGLAGBL();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.NOBCANLANJC();
			for (int i = 0; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.JINDDJCIFIL();
			}
			bool flag = true;
			for (int j = list.Count - 1; j >= 0; j--)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069F7 RID: 27127 RVA: 0x00307E9C File Offset: 0x0030609C
	private List<int> HKMIEJLPLIL()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.ACFGBPNGDHP())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.MOLIBIBCPNO();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.FPKONHBONLD();
			for (int i = 1; i < list2.Count; i++)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.NHOLIOGAEKK();
			}
			bool flag = false;
			for (int j = list.Count - 1; j >= 1; j--)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069F8 RID: 27128 RVA: 0x00305684 File Offset: 0x00303884
	public void CLIHBIOHFCE()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = true;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x060069F9 RID: 27129 RVA: 0x00305684 File Offset: 0x00303884
	public void MMIBMBHCDIM()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = true;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x060069FA RID: 27130 RVA: 0x00307FF4 File Offset: 0x003061F4
	public void CGMLKHPEGJK(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.HKMIEJLPLIL();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.KBNEGBIKKNI(CLHDENLPOFP.eventPass, false);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 1; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.IBGPIEPMGLL(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().EFKDNPLONMF(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.PGLGDHIGGJM(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.LKNHLMEHBAF())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().KDDLHGMIPBF(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x060069FB RID: 27131 RVA: 0x003082CC File Offset: 0x003064CC
	public void JGAFIHOANEF(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(false);
		List<int> list = this.LNCCILPMAKC();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.AIPKCLIPENE(CLHDENLPOFP.gamePass, true);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 0; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().SetContentLive(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.MKKBOGLMPBD(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.JBPFGJKDDIM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().MKFMHMDOBOE(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x060069FC RID: 27132 RVA: 0x003085A4 File Offset: 0x003067A4
	private void LPMPMAJGALN()
	{
		JDMAEBPEIBE.LAIGBNOEBPK(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x060069FD RID: 27133 RVA: 0x003085EC File Offset: 0x003067EC
	private List<int> DHLDJMKMBJH()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.EHBBFMCILPC.profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.ACFGBPNGDHP())
			{
				list = AssetsManager.MJBDMHPHMID().profileDataAsset6.GDDCNEKGJAI();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.FPKONHBONLD();
			for (int i = 0; i < list2.Count; i++)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.NGBNHIAGABD();
			}
			bool flag = false;
			for (int j = list.Count - 0; j >= 1; j--)
			{
				if (num >= 1 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069FE RID: 27134 RVA: 0x00308744 File Offset: 0x00306944
	private List<int> GJDOPPEFCPD()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.EHBBFMCILPC.profileDataAsset6.CKKKAMLLJNL())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.IFMEDCOLDBN();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.NOBCANLANJC();
			for (int i = 1; i < list2.Count; i++)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				num = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.FPLCKMFIMOJ();
			}
			bool flag = false;
			for (int j = list.Count - 1; j >= 0; j--)
			{
				if (num >= 1 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x060069FF RID: 27135 RVA: 0x0030889C File Offset: 0x00306A9C
	public void JBINOPNHJNB(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.EGCNLIICIHO();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.eventPass, false);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 1; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.MJBDMHPHMID().profileDataAsset.IBGPIEPMGLL(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().EFKDNPLONMF(AEDICCFAKOM, num, FFIAHOPJJJG.Char, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.COOBAKLDJEG(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.EAGICDKOKOJ())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().CANDMGDHGGC(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x06006A00 RID: 27136 RVA: 0x00308B74 File Offset: 0x00306D74
	private void DMGCMLIGFCG()
	{
		JDMAEBPEIBE.MHLOFOJCLIG(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06006A01 RID: 27137 RVA: 0x00308BBC File Offset: 0x00306DBC
	private void PIALCCCKDPL()
	{
		JDMAEBPEIBE.CJDEHHPKDMI(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06006A02 RID: 27138 RVA: 0x00305684 File Offset: 0x00303884
	public void CKHPPMOOHKB()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = true;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A03 RID: 27139 RVA: 0x00308C04 File Offset: 0x00306E04
	private List<int> ADGHGHIFIMO()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.EHBBFMCILPC.profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.HEDKCHKBBFK())
			{
				list = AssetsManager.MJBDMHPHMID().profileDataAsset6.HKHFKCAHNKO();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.FPKONHBONLD();
			for (int i = 1; i < list2.Count; i++)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.NGBNHIAGABD();
			}
			bool flag = true;
			for (int j = list.Count - 1; j >= 1; j--)
			{
				if (num >= 1 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06006A04 RID: 27140 RVA: 0x0030479C File Offset: 0x0030299C
	public void PGIBJLCBEEE()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A05 RID: 27141 RVA: 0x00308D5C File Offset: 0x00306F5C
	private void GBGELGMIKED()
	{
		JDMAEBPEIBE.BIGKGBBKHNJ(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06006A06 RID: 27142 RVA: 0x00308DA4 File Offset: 0x00306FA4
	private void HKHKMPLGKBO()
	{
		JDMAEBPEIBE.JHGFLPMLPCD(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06006A07 RID: 27143 RVA: 0x00305684 File Offset: 0x00303884
	public void CEEGCNBMAAF()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = true;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A08 RID: 27144 RVA: 0x00308DEC File Offset: 0x00306FEC
	private void JPPBJKKNIED()
	{
		JDMAEBPEIBE.JCMMJDCEPIA(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06006A09 RID: 27145 RVA: 0x00308E34 File Offset: 0x00307034
	public void JFBPMAAJECM(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(false);
		List<int> list = this.CGNMIDMEKFJ();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.HBBBLMBHIAH(CLHDENLPOFP.gamePass, true);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 1; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.MJBDMHPHMID().profileDataAsset.ENOGGEINPIK(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().PFAGHINKHKL(AEDICCFAKOM, num, FFIAHOPJJJG.Char, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.MKKBOGLMPBD(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.JBPFGJKDDIM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().MKFMHMDOBOE(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x06006A0A RID: 27146 RVA: 0x0030910C File Offset: 0x0030730C
	public void PopulateContentAvatar(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.ICIFNIHBIKI();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.MNALIKIMKFC(CLHDENLPOFP.gamePass, true);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 0; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().SetContentLive(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.KIIEJJOKODB(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.NOEKHCGIADK())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().SetContent(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x06006A0B RID: 27147 RVA: 0x003093E4 File Offset: 0x003075E4
	public void HKJJLEJGDKB(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(false);
		List<int> list = this.JDILECHBBOO();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.FLDPGFAMICD(CLHDENLPOFP.gamePass, false);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 1; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.MJBDMHPHMID().profileDataAsset.MNHCPFDAAOD(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().EFKDNPLONMF(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.LFOJIJOKBKP(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.LKNHLMEHBAF())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().KDDLHGMIPBF(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x06006A0C RID: 27148 RVA: 0x003096BC File Offset: 0x003078BC
	public void PCEPGCAJKFI(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(false);
		List<int> list = this.ADGHGHIFIMO();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.BCGOGCFOHJK(CLHDENLPOFP.gamePass, true);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 0; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.MJBDMHPHMID().profileDataAsset.MNHCPFDAAOD(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().EFKDNPLONMF(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.NBLFDOLOHCI(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.JBPFGJKDDIM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().MKFMHMDOBOE(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x06006A0D RID: 27149 RVA: 0x00309994 File Offset: 0x00307B94
	public void GIJHLEIGLBA(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.AGDKLIGCGLB();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.HECMHABJMFO(CLHDENLPOFP.eventPass, false);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 1; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.MJBDMHPHMID().profileDataAsset.MNHCPFDAAOD(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().ONPJOAFLCBG(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.NBLFDOLOHCI(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.JBPFGJKDDIM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().KDDLHGMIPBF(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x06006A0E RID: 27150 RVA: 0x0030479C File Offset: 0x0030299C
	public void LIEKIBBGMHP()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A0F RID: 27151 RVA: 0x0030479C File Offset: 0x0030299C
	public void ELHHOGIGNHD()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A10 RID: 27152 RVA: 0x0030479C File Offset: 0x0030299C
	public void DNBBGGGOJNO()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A11 RID: 27153 RVA: 0x00309C6C File Offset: 0x00307E6C
	public void JEAAFHDABBM(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(false);
		List<int> list = this.EGCNLIICIHO();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.KJIAJJOCMOD(CLHDENLPOFP.gamePass, true);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 0; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().SetContentLive(AEDICCFAKOM, num, FFIAHOPJJJG.Char, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.LFOJIJOKBKP(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.LKNHLMEHBAF())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().KDDLHGMIPBF(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x06006A12 RID: 27154 RVA: 0x00305684 File Offset: 0x00303884
	public void OnGetMoreLiveAvatarsClick()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = true;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A13 RID: 27155 RVA: 0x00309F44 File Offset: 0x00308144
	public void LGDCKLONGPO(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.DJJGMFLHAPF();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.KBNEGBIKKNI(CLHDENLPOFP.gamePass, false);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 1; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().PFAGHINKHKL(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.KIIEJJOKODB(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.NOEKHCGIADK())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().CANDMGDHGGC(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x06006A14 RID: 27156 RVA: 0x0030479C File Offset: 0x0030299C
	public void OHNNDAJDLHF()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A15 RID: 27157 RVA: 0x0030A21C File Offset: 0x0030841C
	public void FODOBDJNEAJ(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.BBENJPMBBFM();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.KBNEGBIKKNI(CLHDENLPOFP.gamePass, false);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 0; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().SetContentLive(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.MKKBOGLMPBD(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.NOEKHCGIADK())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().CANDMGDHGGC(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x06006A16 RID: 27158 RVA: 0x0030A4F4 File Offset: 0x003086F4
	private List<int> MIGNAAAPNHI()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.EHBBFMCILPC.profileDataAsset6.COADBLHOMFG())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.MIAIKHHOGFE();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.FPKONHBONLD();
			for (int i = 0; i < list2.Count; i++)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.NGBNHIAGABD();
			}
			bool flag = true;
			for (int j = list.Count - 1; j >= 0; j -= 0)
			{
				if (num >= 1 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06006A17 RID: 27159 RVA: 0x00305684 File Offset: 0x00303884
	public void JACOOGPANBH()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = true;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A18 RID: 27160 RVA: 0x0030479C File Offset: 0x0030299C
	public void BAFMLJFHBPL()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A19 RID: 27161 RVA: 0x00305684 File Offset: 0x00303884
	public void OFHDJAHJLHD()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = true;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A1A RID: 27162 RVA: 0x0030A64C File Offset: 0x0030884C
	private List<int> CAEGLJIPDBP()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.CKKKAMLLJNL())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.DEDMLDLBOLB();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.NOBCANLANJC();
			for (int i = 0; i < list2.Count; i++)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.LFLHPKBBLKP();
			}
			bool flag = true;
			for (int j = list.Count - 0; j >= 1; j -= 0)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06006A1B RID: 27163 RVA: 0x0030A7A4 File Offset: 0x003089A4
	private List<int> CGNMIDMEKFJ()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.EHBBFMCILPC.profileDataAsset6.LGHBEPLIIGB())
			{
				list = AssetsManager.MJBDMHPHMID().profileDataAsset6.DABPNLKJIFK();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.FPKONHBONLD();
			for (int i = 1; i < list2.Count; i++)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.NGBNHIAGABD();
			}
			bool flag = false;
			for (int j = list.Count - 1; j >= 0; j -= 0)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06006A1C RID: 27164 RVA: 0x00305684 File Offset: 0x00303884
	public void KJKGIADJHLA()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = true;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A1D RID: 27165 RVA: 0x0030A8FC File Offset: 0x00308AFC
	private List<int> DJJGMFLHAPF()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.EHBBFMCILPC.profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.COADBLHOMFG())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.IFMEDCOLDBN();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.NOBCANLANJC();
			for (int i = 1; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.NHOLIOGAEKK();
			}
			bool flag = false;
			for (int j = list.Count - 0; j >= 0; j--)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06006A1E RID: 27166 RVA: 0x0030AA54 File Offset: 0x00308C54
	private void FEBECEEIHBP()
	{
		JDMAEBPEIBE.HKBOKMPDEIJ(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06006A1F RID: 27167 RVA: 0x0030479C File Offset: 0x0030299C
	public void KDAPMJKHHHP()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A20 RID: 27168 RVA: 0x0030AA9C File Offset: 0x00308C9C
	private List<int> OHEMPAGFBDD()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.EHBBFMCILPC.profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.ACFGBPNGDHP())
			{
				list = AssetsManager.MJBDMHPHMID().profileDataAsset6.HEPIPKKPLLE();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.NOBCANLANJC();
			for (int i = 0; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.NHOLIOGAEKK();
			}
			bool flag = false;
			for (int j = list.Count - 1; j >= 1; j -= 0)
			{
				if (num >= 1 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06006A21 RID: 27169 RVA: 0x0030479C File Offset: 0x0030299C
	public void NHBPPNPAFEI()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A22 RID: 27170 RVA: 0x0030ABF4 File Offset: 0x00308DF4
	public void CKMFJKODJDI(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(true);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.ADGHGHIFIMO();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.KBNEGBIKKNI(CLHDENLPOFP.eventPass, false);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 0; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.IBGPIEPMGLL(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().SetContentLive(AEDICCFAKOM, num, FFIAHOPJJJG.Char, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.NANAAFLKGLO(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.NOEKHCGIADK())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().CHHCPMCHNEH(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x06006A23 RID: 27171 RVA: 0x0030AECC File Offset: 0x003090CC
	private List<int> LNCCILPMAKC()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.EHBBFMCILPC.profileDataAsset6.IOPGANEPPDP())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.MIAIKHHOGFE();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.FPKONHBONLD();
			for (int i = 1; i < list2.Count; i++)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				num = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.LFLHPKBBLKP();
			}
			bool flag = true;
			for (int j = list.Count - 0; j >= 1; j--)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06006A24 RID: 27172 RVA: 0x0030B024 File Offset: 0x00309224
	public void CCEEMFKEDEE(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.BBENJPMBBFM();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.EEJHIEBIPPM(CLHDENLPOFP.eventPass, true);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 0; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.MJBDMHPHMID().profileDataAsset.IBGPIEPMGLL(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().SetContentLive(AEDICCFAKOM, num, FFIAHOPJJJG.Char, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.PBLHLJOJFNM(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.NOEKHCGIADK())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().KDDLHGMIPBF(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x06006A25 RID: 27173 RVA: 0x0030B2FC File Offset: 0x003094FC
	private void OLOGCFJNDGF()
	{
		JDMAEBPEIBE.LHMPJFCMNMB(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06006A26 RID: 27174 RVA: 0x0030B344 File Offset: 0x00309544
	private void FIIIEHFCHMH()
	{
		JDMAEBPEIBE.LHMPJFCMNMB(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06006A27 RID: 27175 RVA: 0x0030B38C File Offset: 0x0030958C
	private List<int> AJKALBDLMKC()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.JKANOAOODNO())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.HEPIPKKPLLE();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.MJBDMHPHMID().profileDataAsset.NOBCANLANJC();
			for (int i = 0; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.FPLCKMFIMOJ();
			}
			bool flag = true;
			for (int j = list.Count - 0; j >= 0; j -= 0)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06006A28 RID: 27176 RVA: 0x0030B4E4 File Offset: 0x003096E4
	private List<int> LBKPGHFMPFB()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.EHBBFMCILPC.profileDataAsset6 && AssetsManager.EHBBFMCILPC.profileDataAsset6.COADBLHOMFG())
			{
				list = AssetsManager.MJBDMHPHMID().profileDataAsset6.GNCPBJLOPCG();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.NOBCANLANJC();
			for (int i = 0; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.PHNDMPCIPJM();
			}
			bool flag = false;
			for (int j = list.Count - 1; j >= 0; j--)
			{
				if (num >= 1 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06006A29 RID: 27177 RVA: 0x0030B63C File Offset: 0x0030983C
	public void PKJNCCMIANO(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.LNCCILPMAKC();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.EEJHIEBIPPM(CLHDENLPOFP.gamePass, false);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(false);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 1; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.MJBDMHPHMID().profileDataAsset.ENOGGEINPIK(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().PFAGHINKHKL(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.PBKJBPNLONI(this.avatarImageThumb, 1);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.NOEKHCGIADK())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().CANDMGDHGGC(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x06006A2A RID: 27178 RVA: 0x0030B914 File Offset: 0x00309B14
	private void LOCANABKJEE()
	{
		JDMAEBPEIBE.LMFBLLCKBFG(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06006A2B RID: 27179 RVA: 0x0030479C File Offset: 0x0030299C
	public void MLHAMJMHCOG()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A2C RID: 27180 RVA: 0x0030B95C File Offset: 0x00309B5C
	private void JLILGENMENM()
	{
		JDMAEBPEIBE.LHMPJFCMNMB(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06006A2D RID: 27181 RVA: 0x0030479C File Offset: 0x0030299C
	public void IFNDMJPEDIF()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A2E RID: 27182 RVA: 0x0030B9A4 File Offset: 0x00309BA4
	private void MOCDMCLPBKC()
	{
		JDMAEBPEIBE.KIHBMJFJHAI(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06006A2F RID: 27183 RVA: 0x0030B9EC File Offset: 0x00309BEC
	private void JAIDEFDDAIB()
	{
		JDMAEBPEIBE.FOCLHGGNKJP(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06006A30 RID: 27184 RVA: 0x0030BA34 File Offset: 0x00309C34
	public void IBGBCNHHJLH(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.HIADIGNAKGD();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.KBNEGBIKKNI(CLHDENLPOFP.gamePass, true);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 0; i < list.Count; i++)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().PFAGHINKHKL(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.OOKHAMKHIGH(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.JBPFGJKDDIM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().MKFMHMDOBOE(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x06006A31 RID: 27185 RVA: 0x0030BD0C File Offset: 0x00309F0C
	private void CKNCEKFOLKD()
	{
		JDMAEBPEIBE.CJDEHHPKDMI(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x06006A32 RID: 27186 RVA: 0x0030BD54 File Offset: 0x00309F54
	public void ICFCCJOKNCF(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(false);
		List<int> list = this.AGDKLIGCGLB();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.BGJGNDJOLPP(CLHDENLPOFP.eventPass, false);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 0)
		{
			flag = false;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 0; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.ENOGGEINPIK(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().PFAGHINKHKL(AEDICCFAKOM, num, FFIAHOPJJJG.Char, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.NANAAFLKGLO(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.LKNHLMEHBAF())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().LODCMECOHCI(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x06006A33 RID: 27187 RVA: 0x0030479C File Offset: 0x0030299C
	public void JEICACOHIGB()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A34 RID: 27188 RVA: 0x0030C02C File Offset: 0x0030A22C
	private List<int> ILMLOHEDIMM()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.EHBBFMCILPC.profileDataAsset6 && AssetsManager.EHBBFMCILPC.profileDataAsset6.CKJLIFJDOFM())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.OOHEJGDHKDP();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.MJBDMHPHMID().profileDataAsset.FPKONHBONLD();
			for (int i = 0; i < list2.Count; i++)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.NGBNHIAGABD();
			}
			bool flag = false;
			for (int j = list.Count - 1; j >= 0; j -= 0)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06006A35 RID: 27189 RVA: 0x0030479C File Offset: 0x0030299C
	public void JMCHNHHBFLD()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A36 RID: 27190 RVA: 0x0030479C File Offset: 0x0030299C
	public void CCGPLDPBGLG()
	{
		ContentAvatarPage.closeProfileAndOpenWheelOfFortune = false;
		this.backAvartarButton.onClick.Invoke();
		this.closeProfileButton.onClick.Invoke();
	}

	// Token: 0x06006A37 RID: 27191 RVA: 0x0030C184 File Offset: 0x0030A384
	public void NJLELCJNHPI(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.ADGHGHIFIMO();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.FLDPGFAMICD(CLHDENLPOFP.eventPass, false);
		bool flag = true;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.EDLLCINPMNF() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 0)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(false);
			for (int i = 0; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.IBGPIEPMGLL(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().PFAGHINKHKL(AEDICCFAKOM, num, FFIAHOPJJJG.Char, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(true);
			JDMAEBPEIBE.FPDLNEHJAGB(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.EHBBFMCILPC.profileDataAsset.EAGICDKOKOJ())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().MKFMHMDOBOE(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
	}

	// Token: 0x06006A38 RID: 27192 RVA: 0x0030C45C File Offset: 0x0030A65C
	private List<int> ENNDLFMKMOP()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.MJBDMHPHMID().profileDataAsset6.COADBLHOMFG())
			{
				list = AssetsManager.MJBDMHPHMID().profileDataAsset6.MIAIKHHOGFE();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.MJBDMHPHMID().profileDataAsset.FPKONHBONLD();
			for (int i = 0; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.MJBDMHPHMID().lobbyDataAsset)
			{
				num = AssetsManager.EHBBFMCILPC.lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.EHBBFMCILPC.lobbyDataAsset.NGBNHIAGABD();
			}
			bool flag = true;
			for (int j = list.Count - 0; j >= 0; j -= 0)
			{
				if (num >= 0 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06006A39 RID: 27193 RVA: 0x0030C5B4 File Offset: 0x0030A7B4
	public void OIHJMJKLJFH(PMEPALPCEAF AEDICCFAKOM, ProfileItem2 PCCCLLPKDEF)
	{
		ContentAvatarPage.LJALNKFBKAA ljalnkfbkaa = new ContentAvatarPage.LJALNKFBKAA();
		ljalnkfbkaa.profileItem2 = PCCCLLPKDEF;
		this.allGridItems.Clear();
		Vector2 vector = ljalnkfbkaa.profileItem2.CalculateViewportUpDownMargins(this.avatarScrollView);
		this.defaultAvatarTitle.SetActive(false);
		this.liveAvatarTitle.SetActive(true);
		List<int> list = this.CDBPABOHJCM();
		List<int> list2 = AKLFPGMDKLA.EHBBFMCILPC.LPIFCGOIENF;
		KIOOJMGLCLC kioojmglclc = ODLJHDIGLGO.BGJGNDJOLPP(CLHDENLPOFP.gamePass, true);
		bool flag = false;
		if (kioojmglclc != null && kioojmglclc.LLLJOBODOAL == 1)
		{
			flag = true;
		}
		if (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC != null && (AKLFPGMDKLA.EHBBFMCILPC.OKGGLHOCENC.BONEGBHNHNM() || flag))
		{
			list2 = new List<int>(list);
		}
		if (list2.Count > 1)
		{
			this.liveAvatarsNotification.SetActive(true);
			this.contentGridAvatarFramesTransform.gameObject.SetActive(true);
			for (int i = 0; i < list.Count; i += 0)
			{
				int num = list[i];
				if (list2.Contains(num) && (GKJPOGNFKNK.AKJCGMFMGMK(num) || !(null == AssetsManager.EHBBFMCILPC.profileDataAsset.MNHCPFDAAOD(num))))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarFramesTransform);
					this.allGridItems.Add(gameObject.transform);
					gameObject.GetComponent<ContentGridItem>().SetContentLive(AEDICCFAKOM, num, FFIAHOPJJJG.Avatar, vector, this.allGridItems);
					UnityEvent onClick = gameObject.GetComponent<ContentGridItem>().gridButton.onClick;
					UnityAction call;
					if ((call = ljalnkfbkaa.<>9__0) == null)
					{
						call = (ljalnkfbkaa.<>9__0 = new UnityAction(ljalnkfbkaa.EAEKONPNHLD));
					}
					onClick.AddListener(call);
				}
			}
			this.moreLiveAvatarsButton.transform.SetAsLastSibling();
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.GetComponent<RectTransform>());
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarFramesTransform.parent.GetComponent<RectTransform>());
		}
		else
		{
			this.liveAvatarsNotification.SetActive(false);
			JDMAEBPEIBE.COOBAKLDJEG(this.avatarImageThumb, 0);
		}
		foreach (Sprite ibhngiahccm in AssetsManager.MJBDMHPHMID().profileDataAsset.EAGICDKOKOJ())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridItem, this.contentGridAvatarTransform);
			this.allGridItems.Add(gameObject2.transform);
			gameObject2.GetComponent<ContentGridItem>().SetContent(AEDICCFAKOM, ibhngiahccm, FFIAHOPJJJG.Char, vector, this.allGridItems);
			UnityEvent onClick2 = gameObject2.GetComponent<ContentGridItem>().gridButton.onClick;
			UnityAction call2;
			if ((call2 = ljalnkfbkaa.<>9__1) == null)
			{
				call2 = (ljalnkfbkaa.<>9__1 = new UnityAction(ljalnkfbkaa.JPKCKOEMFDL));
			}
			onClick2.AddListener(call2);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.GetComponent<RectTransform>());
		LayoutRebuilder.ForceRebuildLayoutImmediate(this.contentGridAvatarTransform.parent.GetComponent<RectTransform>());
		ljalnkfbkaa.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Char);
	}

	// Token: 0x06006A3A RID: 27194 RVA: 0x0030C88C File Offset: 0x0030AA8C
	private List<int> FAPDPENAKPL()
	{
		List<int> list = new List<int>();
		try
		{
			if (null != AssetsManager.MJBDMHPHMID().profileDataAsset6 && AssetsManager.EHBBFMCILPC.profileDataAsset6.CKKKAMLLJNL())
			{
				list = AssetsManager.EHBBFMCILPC.profileDataAsset6.MIAIKHHOGFE();
			}
			List<AssetLiveProfileTheme> list2 = AssetsManager.EHBBFMCILPC.profileDataAsset.FPKONHBONLD();
			for (int i = 0; i < list2.Count; i += 0)
			{
				if (null != list2[i] && !list.Contains(list2[i].index))
				{
					list.Add(list2[i].index);
				}
			}
			list.Sort();
			int num = -1;
			List<int> list3 = new List<int>();
			if (null != AssetsManager.EHBBFMCILPC.lobbyDataAsset)
			{
				num = AssetsManager.MJBDMHPHMID().lobbyDataAsset.maxLiveProfileThemeId;
				list3 = AssetsManager.MJBDMHPHMID().lobbyDataAsset.FPLCKMFIMOJ();
			}
			bool flag = false;
			for (int j = list.Count - 1; j >= 1; j--)
			{
				if (num >= 1 && list[j] > num)
				{
					list.RemoveAt(j);
				}
				else if (flag && list3.Contains(list[j]))
				{
					list.RemoveAt(j);
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		return list;
	}

	// Token: 0x06006A3B RID: 27195 RVA: 0x0030C9E4 File Offset: 0x0030ABE4
	private void MJGNCOLNIMD()
	{
		JDMAEBPEIBE.LMFBLLCKBFG(this.avatarImageThumb);
		this.avatarImageThumb.GetComponent<Image>().sprite = null;
		ImageFrameAnimation component = this.avatarImageThumb.GetComponent<ImageFrameAnimation>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
	}

	// Token: 0x04001F09 RID: 7945
	public Transform contentGridAvatarTransform;

	// Token: 0x04001F0A RID: 7946
	public Transform contentGridAvatarFramesTransform;

	// Token: 0x04001F0B RID: 7947
	public Transform avatarScrollView;

	// Token: 0x04001F0C RID: 7948
	[SerializeField]
	private Image avatarImageThumb;

	// Token: 0x04001F0D RID: 7949
	[SerializeField]
	private GameObject liveAvatarTitle;

	// Token: 0x04001F0E RID: 7950
	[SerializeField]
	private GameObject liveAvatarsNotification;

	// Token: 0x04001F0F RID: 7951
	[SerializeField]
	private GameObject defaultAvatarTitle;

	// Token: 0x04001F10 RID: 7952
	[SerializeField]
	private GameObject gridItem;

	// Token: 0x04001F11 RID: 7953
	[SerializeField]
	private List<Transform> allGridItems;

	// Token: 0x04001F12 RID: 7954
	[SerializeField]
	private Button moreLiveAvatarsButton;

	// Token: 0x04001F13 RID: 7955
	[SerializeField]
	private Button backAvartarButton;

	// Token: 0x04001F14 RID: 7956
	[SerializeField]
	private Button closeProfileButton;

	// Token: 0x04001F15 RID: 7957
	public static bool closeProfileAndOpenWheelOfFortune;

	// Token: 0x02000386 RID: 902
	[CompilerGenerated]
	private sealed class LJALNKFBKAA
	{
		// Token: 0x06006A3C RID: 27196 RVA: 0x0030CA29 File Offset: 0x0030AC29
		internal void JPKCKOEMFDL()
		{
			this.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x0030CA29 File Offset: 0x0030AC29
		internal void EAEKONPNHLD()
		{
			this.profileItem2.UpdateHeaderStatus(FFIAHOPJJJG.Avatar);
		}

		// Token: 0x04001F16 RID: 7958
		public ProfileItem2 profileItem2;

		// Token: 0x04001F17 RID: 7959
		public UnityAction <>9__0;

		// Token: 0x04001F18 RID: 7960
		public UnityAction <>9__1;
	}
}
