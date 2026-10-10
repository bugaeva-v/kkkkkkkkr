using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003CA RID: 970
public class DeviceResolutionAndOrientationChangeListener : MonoBehaviour
{
	// Token: 0x0600708E RID: 28814 RVA: 0x0032E3C1 File Offset: 0x0032C5C1
	private void IMCHEPFNANC()
	{
		base.StartCoroutine(this.ANIFLFMKLND());
	}

	// Token: 0x0600708F RID: 28815 RVA: 0x0032E3D0 File Offset: 0x0032C5D0
	private IEnumerator GEMCLILMDMD()
	{
		this.CLGEPMLAFBN.x = (float)Screen.width;
		this.CLGEPMLAFBN.y = (float)Screen.height;
		this.NMJABFLOKFJ = Input.deviceOrientation;
		while (this.AKDKHHBOIPF)
		{
			if (this.CLGEPMLAFBN.x != (float)Screen.width || this.CLGEPMLAFBN.y != (float)Screen.height)
			{
				this.CLGEPMLAFBN.x = (float)Screen.width;
				this.CLGEPMLAFBN.y = (float)Screen.height;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnResolutionChanged", 0f);
			}
			DeviceOrientation deviceOrientation = Input.deviceOrientation;
			if (deviceOrientation != DeviceOrientation.Unknown && deviceOrientation - DeviceOrientation.FaceUp > 1 && this.NMJABFLOKFJ != Input.deviceOrientation)
			{
				this.NMJABFLOKFJ = Input.deviceOrientation;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnOrientationChanged", 0f);
			}
			yield return new WaitForSeconds(this.OHGJGEICBKE);
		}
		yield break;
	}

	// Token: 0x06007090 RID: 28816 RVA: 0x0032E3DF File Offset: 0x0032C5DF
	private void NCLALOLOIGP()
	{
		base.StartCoroutine(this.IPELMIJEGPO());
	}

	// Token: 0x06007091 RID: 28817 RVA: 0x000693D6 File Offset: 0x000675D6
	private void AMAKEBJMCLG()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06007092 RID: 28818 RVA: 0x0032E3D0 File Offset: 0x0032C5D0
	private IEnumerator FBNGJBAAMPL()
	{
		this.CLGEPMLAFBN.x = (float)Screen.width;
		this.CLGEPMLAFBN.y = (float)Screen.height;
		this.NMJABFLOKFJ = Input.deviceOrientation;
		while (this.AKDKHHBOIPF)
		{
			if (this.CLGEPMLAFBN.x != (float)Screen.width || this.CLGEPMLAFBN.y != (float)Screen.height)
			{
				this.CLGEPMLAFBN.x = (float)Screen.width;
				this.CLGEPMLAFBN.y = (float)Screen.height;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnResolutionChanged", 0f);
			}
			DeviceOrientation deviceOrientation = Input.deviceOrientation;
			if (deviceOrientation != DeviceOrientation.Unknown && deviceOrientation - DeviceOrientation.FaceUp > 1 && this.NMJABFLOKFJ != Input.deviceOrientation)
			{
				this.NMJABFLOKFJ = Input.deviceOrientation;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnOrientationChanged", 0f);
			}
			yield return new WaitForSeconds(this.OHGJGEICBKE);
		}
		yield break;
	}

	// Token: 0x06007093 RID: 28819 RVA: 0x0032E3EE File Offset: 0x0032C5EE
	private void MOHLNGBBIOB()
	{
		this.AKDKHHBOIPF = false;
	}

	// Token: 0x06007094 RID: 28820 RVA: 0x0032E3EE File Offset: 0x0032C5EE
	private void NLOFDEFADCL()
	{
		this.AKDKHHBOIPF = false;
	}

	// Token: 0x06007095 RID: 28821 RVA: 0x0032E3EE File Offset: 0x0032C5EE
	private void OnDestroy()
	{
		this.AKDKHHBOIPF = false;
	}

	// Token: 0x06007096 RID: 28822 RVA: 0x000693D6 File Offset: 0x000675D6
	private void CJOOOIECMAE()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06007098 RID: 28824 RVA: 0x000693D6 File Offset: 0x000675D6
	private void AMNBHDNALGO()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06007099 RID: 28825 RVA: 0x000693D6 File Offset: 0x000675D6
	private void DFEDGLDNOBH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600709A RID: 28826 RVA: 0x0032E411 File Offset: 0x0032C611
	private void NKIEJIHEADI()
	{
		this.AKDKHHBOIPF = true;
	}

	// Token: 0x0600709B RID: 28827 RVA: 0x000693D6 File Offset: 0x000675D6
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600709C RID: 28828 RVA: 0x0032E3D0 File Offset: 0x0032C5D0
	private IEnumerator ANIFLFMKLND()
	{
		this.CLGEPMLAFBN.x = (float)Screen.width;
		this.CLGEPMLAFBN.y = (float)Screen.height;
		this.NMJABFLOKFJ = Input.deviceOrientation;
		while (this.AKDKHHBOIPF)
		{
			if (this.CLGEPMLAFBN.x != (float)Screen.width || this.CLGEPMLAFBN.y != (float)Screen.height)
			{
				this.CLGEPMLAFBN.x = (float)Screen.width;
				this.CLGEPMLAFBN.y = (float)Screen.height;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnResolutionChanged", 0f);
			}
			DeviceOrientation deviceOrientation = Input.deviceOrientation;
			if (deviceOrientation != DeviceOrientation.Unknown && deviceOrientation - DeviceOrientation.FaceUp > 1 && this.NMJABFLOKFJ != Input.deviceOrientation)
			{
				this.NMJABFLOKFJ = Input.deviceOrientation;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnOrientationChanged", 0f);
			}
			yield return new WaitForSeconds(this.OHGJGEICBKE);
		}
		yield break;
	}

	// Token: 0x0600709D RID: 28829 RVA: 0x0032E41A File Offset: 0x0032C61A
	private IEnumerator DJCPDLCFDOP()
	{
		DeviceResolutionAndOrientationChangeListener.DHBILIEOEBG dhbilieoebg = new DeviceResolutionAndOrientationChangeListener.DHBILIEOEBG(1);
		dhbilieoebg.<>4__this = this;
		return dhbilieoebg;
	}

	// Token: 0x0600709E RID: 28830 RVA: 0x000693D6 File Offset: 0x000675D6
	private void BNMJABILOKK()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600709F RID: 28831 RVA: 0x0032E3EE File Offset: 0x0032C5EE
	private void MFINONMBMLM()
	{
		this.AKDKHHBOIPF = false;
	}

	// Token: 0x060070A0 RID: 28832 RVA: 0x0032E3EE File Offset: 0x0032C5EE
	private void PFEIKOLDANA()
	{
		this.AKDKHHBOIPF = false;
	}

	// Token: 0x060070A1 RID: 28833 RVA: 0x0032E429 File Offset: 0x0032C629
	private void KGMBFKBNDPJ()
	{
		base.StartCoroutine(this.GEMCLILMDMD());
	}

	// Token: 0x060070A2 RID: 28834 RVA: 0x0032E411 File Offset: 0x0032C611
	private void OHNEKLLPBDN()
	{
		this.AKDKHHBOIPF = true;
	}

	// Token: 0x060070A3 RID: 28835 RVA: 0x0032E438 File Offset: 0x0032C638
	private void Start()
	{
		base.StartCoroutine(this.PHPKLGBEIEA());
	}

	// Token: 0x060070A4 RID: 28836 RVA: 0x0032E3D0 File Offset: 0x0032C5D0
	private IEnumerator PHPKLGBEIEA()
	{
		this.CLGEPMLAFBN.x = (float)Screen.width;
		this.CLGEPMLAFBN.y = (float)Screen.height;
		this.NMJABFLOKFJ = Input.deviceOrientation;
		while (this.AKDKHHBOIPF)
		{
			if (this.CLGEPMLAFBN.x != (float)Screen.width || this.CLGEPMLAFBN.y != (float)Screen.height)
			{
				this.CLGEPMLAFBN.x = (float)Screen.width;
				this.CLGEPMLAFBN.y = (float)Screen.height;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnResolutionChanged", 0f);
			}
			DeviceOrientation deviceOrientation = Input.deviceOrientation;
			if (deviceOrientation != DeviceOrientation.Unknown && deviceOrientation - DeviceOrientation.FaceUp > 1 && this.NMJABFLOKFJ != Input.deviceOrientation)
			{
				this.NMJABFLOKFJ = Input.deviceOrientation;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnOrientationChanged", 0f);
			}
			yield return new WaitForSeconds(this.OHGJGEICBKE);
		}
		yield break;
	}

	// Token: 0x060070A5 RID: 28837 RVA: 0x000693D6 File Offset: 0x000675D6
	private void IAKKINHMFNA()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060070A6 RID: 28838 RVA: 0x0032E3D0 File Offset: 0x0032C5D0
	private IEnumerator EFKBCACIKHL()
	{
		this.CLGEPMLAFBN.x = (float)Screen.width;
		this.CLGEPMLAFBN.y = (float)Screen.height;
		this.NMJABFLOKFJ = Input.deviceOrientation;
		while (this.AKDKHHBOIPF)
		{
			if (this.CLGEPMLAFBN.x != (float)Screen.width || this.CLGEPMLAFBN.y != (float)Screen.height)
			{
				this.CLGEPMLAFBN.x = (float)Screen.width;
				this.CLGEPMLAFBN.y = (float)Screen.height;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnResolutionChanged", 0f);
			}
			DeviceOrientation deviceOrientation = Input.deviceOrientation;
			if (deviceOrientation != DeviceOrientation.Unknown && deviceOrientation - DeviceOrientation.FaceUp > 1 && this.NMJABFLOKFJ != Input.deviceOrientation)
			{
				this.NMJABFLOKFJ = Input.deviceOrientation;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnOrientationChanged", 0f);
			}
			yield return new WaitForSeconds(this.OHGJGEICBKE);
		}
		yield break;
	}

	// Token: 0x060070A7 RID: 28839 RVA: 0x0032E438 File Offset: 0x0032C638
	private void JLHGINADNCA()
	{
		base.StartCoroutine(this.PHPKLGBEIEA());
	}

	// Token: 0x060070A8 RID: 28840 RVA: 0x0032E429 File Offset: 0x0032C629
	private void HFCMCNBJPEE()
	{
		base.StartCoroutine(this.GEMCLILMDMD());
	}

	// Token: 0x060070A9 RID: 28841 RVA: 0x0032E3EE File Offset: 0x0032C5EE
	private void OHPAOPGNPJA()
	{
		this.AKDKHHBOIPF = false;
	}

	// Token: 0x060070AA RID: 28842 RVA: 0x0032E3D0 File Offset: 0x0032C5D0
	private IEnumerator LDMGMMHJFEO()
	{
		this.CLGEPMLAFBN.x = (float)Screen.width;
		this.CLGEPMLAFBN.y = (float)Screen.height;
		this.NMJABFLOKFJ = Input.deviceOrientation;
		while (this.AKDKHHBOIPF)
		{
			if (this.CLGEPMLAFBN.x != (float)Screen.width || this.CLGEPMLAFBN.y != (float)Screen.height)
			{
				this.CLGEPMLAFBN.x = (float)Screen.width;
				this.CLGEPMLAFBN.y = (float)Screen.height;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnResolutionChanged", 0f);
			}
			DeviceOrientation deviceOrientation = Input.deviceOrientation;
			if (deviceOrientation != DeviceOrientation.Unknown && deviceOrientation - DeviceOrientation.FaceUp > 1 && this.NMJABFLOKFJ != Input.deviceOrientation)
			{
				this.NMJABFLOKFJ = Input.deviceOrientation;
				AOBJLALDBAA.EHBBFMCILPC.EGELHPJBAIC("OnOrientationChanged", 0f);
			}
			yield return new WaitForSeconds(this.OHGJGEICBKE);
		}
		yield break;
	}

	// Token: 0x060070AB RID: 28843 RVA: 0x0032E411 File Offset: 0x0032C611
	private void GMNFLAHGEHF()
	{
		this.AKDKHHBOIPF = true;
	}

	// Token: 0x060070AC RID: 28844 RVA: 0x0032E41A File Offset: 0x0032C61A
	private IEnumerator IPELMIJEGPO()
	{
		DeviceResolutionAndOrientationChangeListener.DHBILIEOEBG dhbilieoebg = new DeviceResolutionAndOrientationChangeListener.DHBILIEOEBG(1);
		dhbilieoebg.<>4__this = this;
		return dhbilieoebg;
	}

	// Token: 0x060070AD RID: 28845 RVA: 0x000693D6 File Offset: 0x000675D6
	private void GBPFDKIIHJG()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0400219F RID: 8607
	public const string onResolutionChanged = "OnResolutionChanged";

	// Token: 0x040021A0 RID: 8608
	public const string onOrientationChanged = "OnOrientationChanged";

	// Token: 0x040021A1 RID: 8609
	private float OHGJGEICBKE = 1f;

	// Token: 0x040021A2 RID: 8610
	private Vector2 CLGEPMLAFBN;

	// Token: 0x040021A3 RID: 8611
	private DeviceOrientation NMJABFLOKFJ;

	// Token: 0x040021A4 RID: 8612
	private bool AKDKHHBOIPF = true;
}
