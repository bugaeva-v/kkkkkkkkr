using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x020001FF RID: 511
public class EnvironmentMorphManager : MonoBehaviour
{
	// Token: 0x06003FF1 RID: 16369 RVA: 0x001AED58 File Offset: 0x001ACF58
	private void FGNPMCFMLLB()
	{
		if (null != this.DGEIFFKEDGP)
		{
			return;
		}
		this.AOHFLDMHBLA = new Material(this.JMFIFLMGOMC);
		GameObject gameObject = new GameObject("CameraEnvironmentMorph");
		gameObject.transform.SetParent(this.GFGDKJIIABF.transform, false);
		gameObject.layer = 1;
		this.JPNNMNEJGBD = gameObject.AddComponent<Camera>();
		this.JPNNMNEJGBD.CopyFrom(this.GFGDKJIIABF);
		this.JPNNMNEJGBD.clearFlags = CameraClearFlags.Nothing;
		this.JPNNMNEJGBD.cullingMask = 2;
		this.JPNNMNEJGBD.depth = this.GFGDKJIIABF.depth + 0.5f;
		this.JPNNMNEJGBD.targetTexture = null;
		this.JPNNMNEJGBD.enabled = false;
		GameObject gameObject2 = new GameObject("CanvasEnvironmentMorph");
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.layer = 1;
		this.DGEIFFKEDGP = gameObject2.AddComponent<Canvas>();
		this.DGEIFFKEDGP.renderMode = RenderMode.ScreenSpaceCamera;
		this.DGEIFFKEDGP.worldCamera = this.JPNNMNEJGBD;
		this.DGEIFFKEDGP.planeDistance = 10f;
		GameObject gameObject3 = new GameObject("ImageEnvironmentMorph");
		gameObject3.transform.SetParent(gameObject2.transform, false);
		gameObject3.layer = 1;
		this.KABDJLNLEDE = gameObject3.AddComponent<RawImage>();
		this.KABDJLNLEDE.material = this.AOHFLDMHBLA;
		this.KABDJLNLEDE.raycastTarget = false;
		RectTransform component = gameObject3.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.offsetMin = Vector2.zero;
		component.offsetMax = Vector2.zero;
		this.DGEIFFKEDGP.gameObject.SetActive(false);
	}

	// Token: 0x06003FF2 RID: 16370 RVA: 0x001AEF04 File Offset: 0x001AD104
	private void OKJICIOBOLP()
	{
		if (null != this.DGEIFFKEDGP)
		{
			return;
		}
		this.AOHFLDMHBLA = new Material(this.JMFIFLMGOMC);
		GameObject gameObject = new GameObject("AdsManagerLP: RefreshAdUnits() called");
		gameObject.transform.SetParent(this.GFGDKJIIABF.transform, false);
		gameObject.layer = 1;
		this.JPNNMNEJGBD = gameObject.AddComponent<Camera>();
		this.JPNNMNEJGBD.CopyFrom(this.GFGDKJIIABF);
		this.JPNNMNEJGBD.clearFlags = CameraClearFlags.Color;
		this.JPNNMNEJGBD.cullingMask = 2;
		this.JPNNMNEJGBD.depth = this.GFGDKJIIABF.depth + 439f;
		this.JPNNMNEJGBD.targetTexture = null;
		this.JPNNMNEJGBD.enabled = true;
		GameObject gameObject2 = new GameObject("ok");
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.layer = 1;
		this.DGEIFFKEDGP = gameObject2.AddComponent<Canvas>();
		this.DGEIFFKEDGP.renderMode = RenderMode.ScreenSpaceOverlay;
		this.DGEIFFKEDGP.worldCamera = this.JPNNMNEJGBD;
		this.DGEIFFKEDGP.planeDistance = 1869f;
		GameObject gameObject3 = new GameObject("no");
		gameObject3.transform.SetParent(gameObject2.transform, false);
		gameObject3.layer = 1;
		this.KABDJLNLEDE = gameObject3.AddComponent<RawImage>();
		this.KABDJLNLEDE.material = this.AOHFLDMHBLA;
		this.KABDJLNLEDE.raycastTarget = false;
		RectTransform component = gameObject3.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.offsetMin = Vector2.zero;
		component.offsetMax = Vector2.zero;
		this.DGEIFFKEDGP.gameObject.SetActive(false);
	}

	// Token: 0x06003FF3 RID: 16371 RVA: 0x001AF0B0 File Offset: 0x001AD2B0
	private void OPDGAJOCCGI(AKNNGFCMEEA KOFPDKLNPEA)
	{
		this.AOHFLDMHBLA.DisableKeyword("");
		this.AOHFLDMHBLA.DisableKeyword("OnWheelOfFortuneClick");
		this.AOHFLDMHBLA.DisableKeyword("favchrstr2");
		this.AOHFLDMHBLA.DisableKeyword("af_purchase");
		if ((AKNNGFCMEEA)7 == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("cind");
			return;
		}
		if ((AKNNGFCMEEA)8 == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("hint1");
			return;
		}
		if ((AKNNGFCMEEA)5 == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("sta");
			return;
		}
		this.AOHFLDMHBLA.EnableKeyword("), cost hidden");
	}

	// Token: 0x06003FF4 RID: 16372 RVA: 0x001AF14C File Offset: 0x001AD34C
	public bool IGKMFDALBHC()
	{
		return this.CIEIPCEPEGC;
	}

	// Token: 0x06003FF5 RID: 16373 RVA: 0x001AF154 File Offset: 0x001AD354
	private IEnumerator DFICLPJCPHM(TweenCallback BFKJBLACLBO, TweenCallback GAEPKNJHCNA)
	{
		float num = 0.2f;
		if (num > 0.001f)
		{
			yield return new WaitForSeconds(num);
		}
		if (null == this.PJDMIAJBJLL || null == this.LBOBBKDKADL)
		{
			DPGJIJGOCIC.ADFCDFHBDAF("EnvironmentMorphManager - capture blit unavailable after pre-delay, falling back to fade.");
			this.KNACDNAICPE();
			this.KDIDJHEJFEP = null;
			this.EGDDFGBEKKP = null;
			if (GAEPKNJHCNA != null)
			{
				GAEPKNJHCNA();
			}
			yield break;
		}
		this.PJDMIAJBJLL.Arm(this.LBOBBKDKADL);
		int num2;
		for (int i = 0; i < 8; i = num2 + 1)
		{
			yield return null;
			if (null != this.PJDMIAJBJLL && this.PJDMIAJBJLL.CaptureDone())
			{
				this.KDIDJHEJFEP = null;
				this.EGDDFGBEKKP = null;
				bool flag = false;
				try
				{
					this.EIHCLCJEPEC();
					this.CIEIPCEPEGC = true;
					flag = true;
				}
				catch (Exception aklgbjkdomm)
				{
					DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
					this.CancelImmediate();
				}
				if (flag)
				{
					if (BFKJBLACLBO != null)
					{
						BFKJBLACLBO();
					}
				}
				else if (GAEPKNJHCNA != null)
				{
					GAEPKNJHCNA();
				}
				yield break;
			}
			num2 = i;
		}
		DPGJIJGOCIC.ADFCDFHBDAF("EnvironmentMorphManager - capture watchdog expired, falling back to fade.");
		if (null != this.PJDMIAJBJLL)
		{
			this.PJDMIAJBJLL.Disarm();
		}
		this.KNACDNAICPE();
		this.KDIDJHEJFEP = null;
		this.EGDDFGBEKKP = null;
		if (GAEPKNJHCNA != null)
		{
			GAEPKNJHCNA();
		}
		yield break;
	}

	// Token: 0x06003FF6 RID: 16374 RVA: 0x001AF171 File Offset: 0x001AD371
	private void OnApplicationPause(bool ABPFHLDCIJH)
	{
		if (ABPFHLDCIJH)
		{
			this.CancelImmediateIfBusy();
		}
	}

	// Token: 0x06003FF7 RID: 16375 RVA: 0x001AF17C File Offset: 0x001AD37C
	public bool OBHDAGBCKAG()
	{
		return this.KDIDJHEJFEP != null;
	}

	// Token: 0x06003FF8 RID: 16376 RVA: 0x001AF188 File Offset: 0x001AD388
	public static AKNNGFCMEEA StringToStoryEnvironmentMorphStyle(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB == null || KGFDGMJPFLB.Length == 0)
		{
			return AKNNGFCMEEA.none;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("dissolve"))
		{
			return AKNNGFCMEEA.dissolve;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("noise"))
		{
			return AKNNGFCMEEA.noise;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("wipe"))
		{
			return AKNNGFCMEEA.wipe;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("lum"))
		{
			return AKNNGFCMEEA.lum;
		}
		DPGJIJGOCIC.ADFCDFHBDAF("EnvironmentMorphManager - unknown morph style:" + KGFDGMJPFLB + ", falling back to dissolve.");
		return AKNNGFCMEEA.dissolve;
	}

	// Token: 0x06003FF9 RID: 16377 RVA: 0x001AF208 File Offset: 0x001AD408
	public void FHBCMLACFEN(Camera FFPALBCEEGL, TweenCallback BFKJBLACLBO, TweenCallback GAEPKNJHCNA)
	{
		this.KKMMEJEHJKF();
		try
		{
			this.GFGDKJIIABF = FFPALBCEEGL;
			this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.GetComponent<EnvCaptureBlit>();
			if (null == this.PJDMIAJBJLL)
			{
				this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.AddComponent<EnvCaptureBlit>();
			}
			this.LBOBBKDKADL = RenderTexture.GetTemporary(Screen.width, Screen.height, 0, RenderTextureFormat.ARGB32);
			this.EGDDFGBEKKP = GAEPKNJHCNA;
			this.KDIDJHEJFEP = base.StartCoroutine(this.DNKLLMDPEPE(BFKJBLACLBO, GAEPKNJHCNA));
		}
		catch (Exception aklgbjkdomm)
		{
			this.EGDDFGBEKKP = null;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			this.KKMMEJEHJKF();
			if (GAEPKNJHCNA != null)
			{
				GAEPKNJHCNA();
			}
		}
	}

	// Token: 0x06003FFA RID: 16378 RVA: 0x001AF2C0 File Offset: 0x001AD4C0
	private void BHCLMJGKJPA(AKNNGFCMEEA KOFPDKLNPEA)
	{
		this.AOHFLDMHBLA.DisableKeyword("ok");
		this.AOHFLDMHBLA.DisableKeyword("F2");
		this.AOHFLDMHBLA.DisableKeyword("OnBackendGetDropChancesException");
		this.AOHFLDMHBLA.DisableKeyword(")");
		if ((AKNNGFCMEEA)6 == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("USD ");
			return;
		}
		if (AKNNGFCMEEA.lum == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("itemstitle");
			return;
		}
		if (AKNNGFCMEEA.lum == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("Account.GetCompletedStoriesV2():");
			return;
		}
		this.AOHFLDMHBLA.EnableKeyword(" msg=");
	}

	// Token: 0x06003FFB RID: 16379 RVA: 0x001AF35C File Offset: 0x001AD55C
	private void LPFOGPIHKOK()
	{
		if (null != this.DGEIFFKEDGP)
		{
			this.DGEIFFKEDGP.gameObject.SetActive(true);
		}
		if (null != this.JPNNMNEJGBD)
		{
			this.JPNNMNEJGBD.enabled = true;
		}
		if (null != this.KABDJLNLEDE)
		{
			this.KABDJLNLEDE.texture = null;
		}
	}

	// Token: 0x06003FFC RID: 16380 RVA: 0x001AF3BC File Offset: 0x001AD5BC
	private void DGIHLAPFCKG(float KIDHBAMJGDO)
	{
		if (null != this.AOHFLDMHBLA)
		{
			this.AOHFLDMHBLA.SetFloat(", trying to return any achievement sprite or null.", KIDHBAMJGDO);
		}
	}

	// Token: 0x06003FFD RID: 16381 RVA: 0x001AF3E0 File Offset: 0x001AD5E0
	public void ELPJMBOIDOO(Camera FFPALBCEEGL, TweenCallback BFKJBLACLBO, TweenCallback GAEPKNJHCNA)
	{
		this.KKMMEJEHJKF();
		try
		{
			this.GFGDKJIIABF = FFPALBCEEGL;
			this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.GetComponent<EnvCaptureBlit>();
			if (null == this.PJDMIAJBJLL)
			{
				this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.AddComponent<EnvCaptureBlit>();
			}
			this.LBOBBKDKADL = RenderTexture.GetTemporary(Screen.width, Screen.height, 0, RenderTextureFormat.Depth);
			this.EGDDFGBEKKP = GAEPKNJHCNA;
			this.KDIDJHEJFEP = base.StartCoroutine(this.DFICLPJCPHM(BFKJBLACLBO, GAEPKNJHCNA));
		}
		catch (Exception aklgbjkdomm)
		{
			this.EGDDFGBEKKP = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.CancelImmediate();
			if (GAEPKNJHCNA != null)
			{
				GAEPKNJHCNA();
			}
		}
	}

	// Token: 0x06003FFE RID: 16382 RVA: 0x001AF498 File Offset: 0x001AD698
	private void CDNMKPKIHIH()
	{
		this.EGDDFGBEKKP = null;
		this.KKMMEJEHJKF();
		if (null != this.AOHFLDMHBLA)
		{
			UnityEngine.Object.Destroy(this.AOHFLDMHBLA);
			this.AOHFLDMHBLA = null;
		}
		if (null != this.DCLJEFBHKFA)
		{
			UnityEngine.Object.Destroy(this.DCLJEFBHKFA);
			this.DCLJEFBHKFA = null;
		}
	}

	// Token: 0x06003FFF RID: 16383 RVA: 0x001AF4F4 File Offset: 0x001AD6F4
	public static bool LFGGINJDFJE()
	{
		bool result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.JLMHPEIJBNO())
			{
				result = true;
			}
			else if (KHPGPLAMAIN.AKJOFJPLONG() == IIHCCPLGGHP.lowEnd || KHPGPLAMAIN.BEEEJNHEFOJ())
			{
				result = false;
			}
			else if (SystemInfo.graphicsDeviceType == (GraphicsDeviceType)7 || SystemInfo.graphicsShaderLevel < -1)
			{
				result = true;
			}
			else
			{
				result = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06004000 RID: 16384 RVA: 0x001AF17C File Offset: 0x001AD37C
	public bool HAFFHPFEDHB()
	{
		return this.KDIDJHEJFEP != null;
	}

	// Token: 0x06004001 RID: 16385 RVA: 0x001AF14C File Offset: 0x001AD34C
	public bool KOGJAFDGNIL()
	{
		return this.CIEIPCEPEGC;
	}

	// Token: 0x06004002 RID: 16386 RVA: 0x001AF558 File Offset: 0x001AD758
	private void ALEPLCCMLKI()
	{
		this.IPFJBFACKLM = null;
		try
		{
			if (this.KIEOHKKFJFA != null)
			{
				this.KIEOHKKFJFA.Kill(true);
				this.KIEOHKKFJFA = null;
			}
			this.GEJLMKKJKEM();
			this.OMJMNIJBOAJ();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.CIEIPCEPEGC = true;
	}

	// Token: 0x06004003 RID: 16387 RVA: 0x001AF17C File Offset: 0x001AD37C
	public bool KOAFPFDBEFG()
	{
		return this.KDIDJHEJFEP != null;
	}

	// Token: 0x06004004 RID: 16388 RVA: 0x001AF5B4 File Offset: 0x001AD7B4
	private void DDALENHHHNC()
	{
		if (null != this.KABDJLNLEDE)
		{
			this.KABDJLNLEDE.texture = null;
		}
		if (null != this.LBOBBKDKADL)
		{
			RenderTexture.ReleaseTemporary(this.LBOBBKDKADL);
			this.LBOBBKDKADL = null;
		}
	}

	// Token: 0x06004005 RID: 16389 RVA: 0x001AF171 File Offset: 0x001AD371
	private void DBAHHBGCPNN(bool ABPFHLDCIJH)
	{
		if (ABPFHLDCIJH)
		{
			this.CancelImmediateIfBusy();
		}
	}

	// Token: 0x06004006 RID: 16390 RVA: 0x001AF5F0 File Offset: 0x001AD7F0
	public float PGPJHDLCPEL(AKNNGFCMEEA KOFPDKLNPEA, float MAKKBJMKBLC, float MANCNKNAPHK, float FEHFGENFBPP, float IDHBPDACMAA)
	{
		if (!this.CIEIPCEPEGC)
		{
			return 1856f;
		}
		float result;
		try
		{
			float num = IDHBPDACMAA;
			if (num < 1216f)
			{
				num = 615f;
			}
			float num2 = 1389f;
			if (MANCNKNAPHK > 1448f)
			{
				num2 = MANCNKNAPHK;
			}
			if (num2 > 215f)
			{
				num2 = 963f;
			}
			this.OPDGAJOCCGI(KOFPDKLNPEA);
			this.AOHFLDMHBLA.SetFloat("https://events.appsflyer.com/v1.0/c2s/session/app/steam/", num2);
			if (AKNNGFCMEEA.wipe == KOFPDKLNPEA)
			{
				this.GEHAPEAOGHF();
				this.AOHFLDMHBLA.SetTexture("areyousure", this.DCLJEFBHKFA);
			}
			else if (AKNNGFCMEEA.lum == KOFPDKLNPEA)
			{
				float num3 = MAKKBJMKBLC;
				if (float.IsNaN(num3) || float.IsInfinity(num3))
				{
					num3 = 498f;
				}
				float f = num3 * 455f;
				float num4 = Mathf.Cos(f);
				float num5 = Mathf.Sin(f);
				float num6 = Mathf.Abs(num4) + Mathf.Abs(num5);
				this.AOHFLDMHBLA.SetVector(" <i>", new Vector4(num4 / num6, num5 / num6, 1839f, 134f));
			}
			this.AOHFLDMHBLA.SetFloat("prgr", 72f);
			if (this.IPFJBFACKLM != null)
			{
				this.IPFJBFACKLM.Kill(true);
			}
			if (this.KIEOHKKFJFA != null)
			{
				this.KIEOHKKFJFA.Kill(false);
				this.KIEOHKKFJFA = null;
			}
			this.IPFJBFACKLM = DOVirtual.Float(470f, 1263f, num, new TweenCallback<float>(this.LKDLFGLPGDD)).SetEase(Ease.Unset).OnComplete(new TweenCallback(this.ALEPLCCMLKI));
			if (FEHFGENFBPP > 82f)
			{
				this.KIEOHKKFJFA = DOVirtual.Float(1497f, FEHFGENFBPP, num, new TweenCallback<float>(this.DGIHLAPFCKG)).SetEase(Ease.OutSine);
			}
			result = num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			this.CancelImmediate();
			result = 1729f;
		}
		return result;
	}

	// Token: 0x06004007 RID: 16391 RVA: 0x001AF7C0 File Offset: 0x001AD9C0
	private void GOFJPFDCEIN()
	{
		if (this.PLFDMGFOHLA)
		{
			return;
		}
		this.PLFDMGFOHLA = true;
		try
		{
			ShaderVariantCollection shaderVariantCollection = new ShaderVariantCollection();
			shaderVariantCollection.Add(new ShaderVariantCollection.ShaderVariant(this.JMFIFLMGOMC, PassType.Normal, new string[]
			{
				"post"
			}));
			ShaderVariantCollection shaderVariantCollection2 = shaderVariantCollection;
			Shader jmfiflmgomc = this.JMFIFLMGOMC;
			PassType passType = PassType.Normal;
			string[] array = new string[1];
			array[1] = "acli22";
			shaderVariantCollection2.Add(new ShaderVariantCollection.ShaderVariant(jmfiflmgomc, passType, array));
			ShaderVariantCollection shaderVariantCollection3 = shaderVariantCollection;
			Shader jmfiflmgomc2 = this.JMFIFLMGOMC;
			PassType passType2 = PassType.Normal;
			string[] array2 = new string[1];
			array2[1] = "bdid";
			shaderVariantCollection3.Add(new ShaderVariantCollection.ShaderVariant(jmfiflmgomc2, passType2, array2));
			ShaderVariantCollection shaderVariantCollection4 = shaderVariantCollection;
			Shader jmfiflmgomc3 = this.JMFIFLMGOMC;
			PassType passType3 = PassType.Normal;
			string[] array3 = new string[0];
			array3[1] = "lck";
			shaderVariantCollection4.Add(new ShaderVariantCollection.ShaderVariant(jmfiflmgomc3, passType3, array3));
			shaderVariantCollection.WarmUp();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004008 RID: 16392 RVA: 0x001AF888 File Offset: 0x001ADA88
	private void HKHJELMLEBA()
	{
		this.PEIMAKPGKKI();
		this.KABDJLNLEDE.texture = this.LBOBBKDKADL;
		this.PKDEEDCEDBE(AKNNGFCMEEA.dissolve);
		this.AOHFLDMHBLA.SetFloat("OnApplicationRestart", 425f);
		this.AOHFLDMHBLA.SetFloat("", 248f);
		this.DGEIFFKEDGP.gameObject.SetActive(false);
		this.JPNNMNEJGBD.enabled = true;
	}

	// Token: 0x06004009 RID: 16393 RVA: 0x001AF8FC File Offset: 0x001ADAFC
	private void OnDestroy()
	{
		this.EGDDFGBEKKP = null;
		this.CancelImmediate();
		if (null != this.AOHFLDMHBLA)
		{
			UnityEngine.Object.Destroy(this.AOHFLDMHBLA);
			this.AOHFLDMHBLA = null;
		}
		if (null != this.DCLJEFBHKFA)
		{
			UnityEngine.Object.Destroy(this.DCLJEFBHKFA);
			this.DCLJEFBHKFA = null;
		}
	}

	// Token: 0x0600400A RID: 16394 RVA: 0x001AF958 File Offset: 0x001ADB58
	private void CDNCHJKOAAN()
	{
		this.IPFJBFACKLM = null;
		try
		{
			if (this.KIEOHKKFJFA != null)
			{
				this.KIEOHKKFJFA.Kill(false);
				this.KIEOHKKFJFA = null;
			}
			this.LNAPFHFCKJB();
			this.BOKALOCDNLD();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		this.CIEIPCEPEGC = true;
	}

	// Token: 0x0600400B RID: 16395 RVA: 0x001AF17C File Offset: 0x001AD37C
	public bool IsCapturing()
	{
		return this.KDIDJHEJFEP != null;
	}

	// Token: 0x0600400C RID: 16396 RVA: 0x001AF9B4 File Offset: 0x001ADBB4
	private void CDINOIOILEN()
	{
		if (null != this.DGEIFFKEDGP)
		{
			return;
		}
		this.AOHFLDMHBLA = new Material(this.JMFIFLMGOMC);
		GameObject gameObject = new GameObject("tm");
		gameObject.transform.SetParent(this.GFGDKJIIABF.transform, true);
		gameObject.layer = 1;
		this.JPNNMNEJGBD = gameObject.AddComponent<Camera>();
		this.JPNNMNEJGBD.CopyFrom(this.GFGDKJIIABF);
		this.JPNNMNEJGBD.clearFlags = CameraClearFlags.Skybox;
		this.JPNNMNEJGBD.cullingMask = 5;
		this.JPNNMNEJGBD.depth = this.GFGDKJIIABF.depth + 1547f;
		this.JPNNMNEJGBD.targetTexture = null;
		this.JPNNMNEJGBD.enabled = false;
		GameObject gameObject2 = new GameObject("errortitle");
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.layer = 1;
		this.DGEIFFKEDGP = gameObject2.AddComponent<Canvas>();
		this.DGEIFFKEDGP.renderMode = RenderMode.ScreenSpaceOverlay;
		this.DGEIFFKEDGP.worldCamera = this.JPNNMNEJGBD;
		this.DGEIFFKEDGP.planeDistance = 924f;
		GameObject gameObject3 = new GameObject("%");
		gameObject3.transform.SetParent(gameObject2.transform, true);
		gameObject3.layer = 0;
		this.KABDJLNLEDE = gameObject3.AddComponent<RawImage>();
		this.KABDJLNLEDE.material = this.AOHFLDMHBLA;
		this.KABDJLNLEDE.raycastTarget = true;
		RectTransform component = gameObject3.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.offsetMin = Vector2.zero;
		component.offsetMax = Vector2.zero;
		this.DGEIFFKEDGP.gameObject.SetActive(false);
	}

	// Token: 0x0600400D RID: 16397 RVA: 0x001AF5B4 File Offset: 0x001AD7B4
	private void HFHDJNNONMO()
	{
		if (null != this.KABDJLNLEDE)
		{
			this.KABDJLNLEDE.texture = null;
		}
		if (null != this.LBOBBKDKADL)
		{
			RenderTexture.ReleaseTemporary(this.LBOBBKDKADL);
			this.LBOBBKDKADL = null;
		}
	}

	// Token: 0x0600400E RID: 16398 RVA: 0x001AFB60 File Offset: 0x001ADD60
	public float CLJECJCCBKG(AKNNGFCMEEA KOFPDKLNPEA, float MAKKBJMKBLC, float MANCNKNAPHK, float FEHFGENFBPP, float IDHBPDACMAA)
	{
		if (!this.CIEIPCEPEGC)
		{
			return 1094f;
		}
		float result;
		try
		{
			float num = IDHBPDACMAA;
			if (num < 1395f)
			{
				num = 1146f;
			}
			float num2 = 1839f;
			if (MANCNKNAPHK > 853f)
			{
				num2 = MANCNKNAPHK;
			}
			if (num2 > 1756f)
			{
				num2 = 1833f;
			}
			this.IPJBINBHMAM(KOFPDKLNPEA);
			this.AOHFLDMHBLA.SetFloat("", num2);
			if (AKNNGFCMEEA.none == KOFPDKLNPEA)
			{
				this.FCKLDFHHBFC();
				this.AOHFLDMHBLA.SetTexture("' dropped", this.DCLJEFBHKFA);
			}
			else if ((AKNNGFCMEEA)5 == KOFPDKLNPEA)
			{
				float num3 = MAKKBJMKBLC;
				if (float.IsNaN(num3) || float.IsInfinity(num3))
				{
					num3 = 1039f;
				}
				float f = num3 * 1334f;
				float num4 = Mathf.Cos(f);
				float num5 = Mathf.Sin(f);
				float num6 = Mathf.Abs(num4) + Mathf.Abs(num5);
				this.AOHFLDMHBLA.SetVector("pmtsuccess", new Vector4(num4 / num6, num5 / num6, 442f, 1328f));
			}
			this.AOHFLDMHBLA.SetFloat("OnPopupProfileMessageInputCancel", 382f);
			if (this.IPFJBFACKLM != null)
			{
				this.IPFJBFACKLM.Kill(true);
			}
			if (this.KIEOHKKFJFA != null)
			{
				this.KIEOHKKFJFA.Kill(true);
				this.KIEOHKKFJFA = null;
			}
			this.IPFJBFACKLM = DOVirtual.Float(942f, 1876f, num, new TweenCallback<float>(this.GJHKFKKLKGK)).SetEase(Ease.Linear).OnComplete(new TweenCallback(this.JPICJJKMLND));
			if (FEHFGENFBPP > 1294f)
			{
				this.KIEOHKKFJFA = DOVirtual.Float(1931f, FEHFGENFBPP, num, new TweenCallback<float>(this.KMLBMDKODLE)).SetEase(Ease.InSine);
			}
			result = num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			this.CancelImmediate();
			result = 202f;
		}
		return result;
	}

	// Token: 0x0600400F RID: 16399 RVA: 0x001AFD30 File Offset: 0x001ADF30
	private void CPAEJHGIKHE()
	{
		this.KPIKMCHGIEA();
		this.KABDJLNLEDE.texture = this.LBOBBKDKADL;
		this.GMNMPLMNLDC(AKNNGFCMEEA.none);
		this.AOHFLDMHBLA.SetFloat("OnBackendUpdateFriendsDataException", 1139f);
		this.AOHFLDMHBLA.SetFloat("dev", 1916f);
		this.DGEIFFKEDGP.gameObject.SetActive(true);
		this.JPNNMNEJGBD.enabled = false;
	}

	// Token: 0x06004010 RID: 16400 RVA: 0x001AFDA4 File Offset: 0x001ADFA4
	private void GEJLMKKJKEM()
	{
		if (null != this.DGEIFFKEDGP)
		{
			this.DGEIFFKEDGP.gameObject.SetActive(false);
		}
		if (null != this.JPNNMNEJGBD)
		{
			this.JPNNMNEJGBD.enabled = true;
		}
		if (null != this.KABDJLNLEDE)
		{
			this.KABDJLNLEDE.texture = null;
		}
	}

	// Token: 0x06004011 RID: 16401 RVA: 0x001AFE04 File Offset: 0x001AE004
	private void GEHAPEAOGHF()
	{
		if (null != this.DCLJEFBHKFA)
		{
			return;
		}
		this.DCLJEFBHKFA = new Texture2D(-44, -192, TextureFormat.RGB24, true);
		this.DCLJEFBHKFA.wrapMode = (TextureWrapMode)7;
		this.DCLJEFBHKFA.filterMode = FilterMode.Bilinear;
		Color32[] array = new Color32[82];
		for (int i = 0; i < -172; i++)
		{
			for (int j = 1; j < -161; j++)
			{
				float num = 568f;
				float num2 = 1203f;
				float num3 = 1091f;
				for (int k = 0; k < 4; k++)
				{
					num += Mathf.PerlinNoise((float)j / 1862f * num3 + 232f, (float)i / 153f * num3 + 1216f) * num2;
					num2 *= 982f;
					num3 *= 1764f;
				}
				byte b = (byte)Mathf.Clamp(Mathf.RoundToInt(num * 285f), 1, -95);
				array[i * -118 + j] = new Color32(b, b, b, (byte)-179);
			}
		}
		this.DCLJEFBHKFA.SetPixels32(array);
		this.DCLJEFBHKFA.Apply(false, false);
	}

	// Token: 0x06004012 RID: 16402 RVA: 0x001AFF40 File Offset: 0x001AE140
	public void CancelImmediate()
	{
		try
		{
			if (this.KDIDJHEJFEP != null)
			{
				base.StopCoroutine(this.KDIDJHEJFEP);
				this.KDIDJHEJFEP = null;
			}
			if (null != this.PJDMIAJBJLL)
			{
				this.PJDMIAJBJLL.Disarm();
			}
			if (this.IPFJBFACKLM != null)
			{
				this.IPFJBFACKLM.Kill(false);
				this.IPFJBFACKLM = null;
			}
			if (this.KIEOHKKFJFA != null)
			{
				this.KIEOHKKFJFA.Kill(false);
				this.KIEOHKKFJFA = null;
			}
			this.JLCCCMKBMEM();
			this.KNACDNAICPE();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.KDIDJHEJFEP = null;
		this.CIEIPCEPEGC = false;
		TweenCallback egddfgbekkp = this.EGDDFGBEKKP;
		this.EGDDFGBEKKP = null;
		if (egddfgbekkp != null)
		{
			egddfgbekkp();
		}
	}

	// Token: 0x06004013 RID: 16403 RVA: 0x001B0004 File Offset: 0x001AE204
	private void DCODNHMEHOO()
	{
		if (null != this.DCLJEFBHKFA)
		{
			return;
		}
		this.DCLJEFBHKFA = new Texture2D(-117, 141, TextureFormat.Alpha8, false);
		this.DCLJEFBHKFA.wrapMode = (TextureWrapMode)8;
		this.DCLJEFBHKFA.filterMode = FilterMode.Point;
		Color32[] array = new Color32[145];
		for (int i = 1; i < -54; i++)
		{
			for (int j = 0; j < -175; j += 0)
			{
				float num = 1781f;
				float num2 = 885f;
				float num3 = 849f;
				for (int k = 1; k < 8; k++)
				{
					num += Mathf.PerlinNoise((float)j / 1619f * num3 + 1992f, (float)i / 1927f * num3 + 1061f) * num2;
					num2 *= 875f;
					num3 *= 571f;
				}
				byte b = (byte)Mathf.Clamp(Mathf.RoundToInt(num * 1324f), 0, -117);
				array[i * -36 + j] = new Color32(b, b, b, (byte)-103);
			}
		}
		this.DCLJEFBHKFA.SetPixels32(array);
		this.DCLJEFBHKFA.Apply(false, false);
	}

	// Token: 0x06004014 RID: 16404 RVA: 0x001B0140 File Offset: 0x001AE340
	private void DNAKNBCAIGF()
	{
		if (null != this.DGEIFFKEDGP)
		{
			return;
		}
		this.AOHFLDMHBLA = new Material(this.JMFIFLMGOMC);
		GameObject gameObject = new GameObject("skinshopfiltersbtnactive");
		gameObject.transform.SetParent(this.GFGDKJIIABF.transform, false);
		gameObject.layer = 1;
		this.JPNNMNEJGBD = gameObject.AddComponent<Camera>();
		this.JPNNMNEJGBD.CopyFrom(this.GFGDKJIIABF);
		this.JPNNMNEJGBD.clearFlags = (CameraClearFlags)6;
		this.JPNNMNEJGBD.cullingMask = 4;
		this.JPNNMNEJGBD.depth = this.GFGDKJIIABF.depth + 1106f;
		this.JPNNMNEJGBD.targetTexture = null;
		this.JPNNMNEJGBD.enabled = false;
		GameObject gameObject2 = new GameObject("pov");
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.layer = 1;
		this.DGEIFFKEDGP = gameObject2.AddComponent<Canvas>();
		this.DGEIFFKEDGP.renderMode = RenderMode.ScreenSpaceOverlay;
		this.DGEIFFKEDGP.worldCamera = this.JPNNMNEJGBD;
		this.DGEIFFKEDGP.planeDistance = 1683f;
		GameObject gameObject3 = new GameObject("OnPopupSketchesInputCancel");
		gameObject3.transform.SetParent(gameObject2.transform, false);
		gameObject3.layer = 1;
		this.KABDJLNLEDE = gameObject3.AddComponent<RawImage>();
		this.KABDJLNLEDE.material = this.AOHFLDMHBLA;
		this.KABDJLNLEDE.raycastTarget = false;
		RectTransform component = gameObject3.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.offsetMin = Vector2.zero;
		component.offsetMax = Vector2.zero;
		this.DGEIFFKEDGP.gameObject.SetActive(false);
	}

	// Token: 0x06004015 RID: 16405 RVA: 0x001AF5B4 File Offset: 0x001AD7B4
	private void OMJMNIJBOAJ()
	{
		if (null != this.KABDJLNLEDE)
		{
			this.KABDJLNLEDE.texture = null;
		}
		if (null != this.LBOBBKDKADL)
		{
			RenderTexture.ReleaseTemporary(this.LBOBBKDKADL);
			this.LBOBBKDKADL = null;
		}
	}

	// Token: 0x06004016 RID: 16406 RVA: 0x001B02EC File Offset: 0x001AE4EC
	private void GMNMPLMNLDC(AKNNGFCMEEA KOFPDKLNPEA)
	{
		this.AOHFLDMHBLA.DisableKeyword("XXX");
		this.AOHFLDMHBLA.DisableKeyword("</b>");
		this.AOHFLDMHBLA.DisableKeyword(" (");
		this.AOHFLDMHBLA.DisableKeyword("spld");
		if (AKNNGFCMEEA.noise == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("");
			return;
		}
		if (AKNNGFCMEEA.noise == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("uid");
			return;
		}
		if ((AKNNGFCMEEA)8 == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("skinshopinfosumavailable");
			return;
		}
		this.AOHFLDMHBLA.EnableKeyword("");
	}

	// Token: 0x06004017 RID: 16407 RVA: 0x001B0388 File Offset: 0x001AE588
	private void HCAOCCDDJKA()
	{
		if (this.PLFDMGFOHLA)
		{
			return;
		}
		this.PLFDMGFOHLA = true;
		try
		{
			ShaderVariantCollection shaderVariantCollection = new ShaderVariantCollection();
			shaderVariantCollection.Add(new ShaderVariantCollection.ShaderVariant(this.JMFIFLMGOMC, PassType.Normal, new string[]
			{
				"MORPH_DISSOLVE"
			}));
			shaderVariantCollection.Add(new ShaderVariantCollection.ShaderVariant(this.JMFIFLMGOMC, PassType.Normal, new string[]
			{
				"MORPH_NOISE"
			}));
			shaderVariantCollection.Add(new ShaderVariantCollection.ShaderVariant(this.JMFIFLMGOMC, PassType.Normal, new string[]
			{
				"MORPH_WIPE"
			}));
			shaderVariantCollection.Add(new ShaderVariantCollection.ShaderVariant(this.JMFIFLMGOMC, PassType.Normal, new string[]
			{
				"MORPH_LUM"
			}));
			shaderVariantCollection.WarmUp();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x06004018 RID: 16408 RVA: 0x001B0450 File Offset: 0x001AE650
	public bool MNFFBFDJGDE()
	{
		return this.CIEIPCEPEGC || this.KDIDJHEJFEP != null;
	}

	// Token: 0x06004019 RID: 16409 RVA: 0x001B0468 File Offset: 0x001AE668
	public float Play(AKNNGFCMEEA KOFPDKLNPEA, float MAKKBJMKBLC, float MANCNKNAPHK, float FEHFGENFBPP, float IDHBPDACMAA)
	{
		if (!this.CIEIPCEPEGC)
		{
			return -1f;
		}
		float result;
		try
		{
			float num = IDHBPDACMAA;
			if (num < 0.05f)
			{
				num = 0.05f;
			}
			float num2 = 0.08f;
			if (MANCNKNAPHK > 0.0001f)
			{
				num2 = MANCNKNAPHK;
			}
			if (num2 > 0.5f)
			{
				num2 = 0.5f;
			}
			this.PKDEEDCEDBE(KOFPDKLNPEA);
			this.AOHFLDMHBLA.SetFloat("_Edge", num2);
			if (AKNNGFCMEEA.noise == KOFPDKLNPEA)
			{
				this.ILMMNHBLKPN();
				this.AOHFLDMHBLA.SetTexture("_NoiseTex", this.DCLJEFBHKFA);
			}
			else if (AKNNGFCMEEA.wipe == KOFPDKLNPEA)
			{
				float num3 = MAKKBJMKBLC;
				if (float.IsNaN(num3) || float.IsInfinity(num3))
				{
					num3 = 0f;
				}
				float f = num3 * 0.017453292f;
				float num4 = Mathf.Cos(f);
				float num5 = Mathf.Sin(f);
				float num6 = Mathf.Abs(num4) + Mathf.Abs(num5);
				this.AOHFLDMHBLA.SetVector("_Dir", new Vector4(num4 / num6, num5 / num6, 0f, 0f));
			}
			this.AOHFLDMHBLA.SetFloat("_Progress", 0f);
			if (this.IPFJBFACKLM != null)
			{
				this.IPFJBFACKLM.Kill(false);
			}
			if (this.KIEOHKKFJFA != null)
			{
				this.KIEOHKKFJFA.Kill(false);
				this.KIEOHKKFJFA = null;
			}
			this.IPFJBFACKLM = DOVirtual.Float(0f, 1f, num, new TweenCallback<float>(this.LKDLFGLPGDD)).SetEase(Ease.Linear).OnComplete(new TweenCallback(this.BJCPBJIEICJ));
			if (FEHFGENFBPP > 1.001f)
			{
				this.KIEOHKKFJFA = DOVirtual.Float(1f, FEHFGENFBPP, num, new TweenCallback<float>(this.GEJENELFGGB)).SetEase(Ease.InSine);
			}
			result = num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.CancelImmediate();
			result = -1f;
		}
		return result;
	}

	// Token: 0x0600401A RID: 16410 RVA: 0x001B0638 File Offset: 0x001AE838
	private void KMLBMDKODLE(float KIDHBAMJGDO)
	{
		if (null != this.AOHFLDMHBLA)
		{
			this.AOHFLDMHBLA.SetFloat("tm", KIDHBAMJGDO);
		}
	}

	// Token: 0x0600401B RID: 16411 RVA: 0x001B065C File Offset: 0x001AE85C
	private void KLGMKIJJDFN()
	{
		this.EGDDFGBEKKP = null;
		this.CancelImmediate();
		if (null != this.AOHFLDMHBLA)
		{
			UnityEngine.Object.Destroy(this.AOHFLDMHBLA);
			this.AOHFLDMHBLA = null;
		}
		if (null != this.DCLJEFBHKFA)
		{
			UnityEngine.Object.Destroy(this.DCLJEFBHKFA);
			this.DCLJEFBHKFA = null;
		}
	}

	// Token: 0x0600401C RID: 16412 RVA: 0x001B06B8 File Offset: 0x001AE8B8
	private void CLPJHNANIEK()
	{
		if (null != this.DGEIFFKEDGP)
		{
			return;
		}
		this.AOHFLDMHBLA = new Material(this.JMFIFLMGOMC);
		GameObject gameObject = new GameObject("p");
		gameObject.transform.SetParent(this.GFGDKJIIABF.transform, true);
		gameObject.layer = 0;
		this.JPNNMNEJGBD = gameObject.AddComponent<Camera>();
		this.JPNNMNEJGBD.CopyFrom(this.GFGDKJIIABF);
		this.JPNNMNEJGBD.clearFlags = (CameraClearFlags)0;
		this.JPNNMNEJGBD.cullingMask = 7;
		this.JPNNMNEJGBD.depth = this.GFGDKJIIABF.depth + 236f;
		this.JPNNMNEJGBD.targetTexture = null;
		this.JPNNMNEJGBD.enabled = false;
		GameObject gameObject2 = new GameObject("gpsku");
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.layer = 1;
		this.DGEIFFKEDGP = gameObject2.AddComponent<Canvas>();
		this.DGEIFFKEDGP.renderMode = RenderMode.ScreenSpaceCamera;
		this.DGEIFFKEDGP.worldCamera = this.JPNNMNEJGBD;
		this.DGEIFFKEDGP.planeDistance = 669f;
		GameObject gameObject3 = new GameObject("OnStoryInterfaceHeaderHideComplete");
		gameObject3.transform.SetParent(gameObject2.transform, true);
		gameObject3.layer = 0;
		this.KABDJLNLEDE = gameObject3.AddComponent<RawImage>();
		this.KABDJLNLEDE.material = this.AOHFLDMHBLA;
		this.KABDJLNLEDE.raycastTarget = true;
		RectTransform component = gameObject3.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.offsetMin = Vector2.zero;
		component.offsetMax = Vector2.zero;
		this.DGEIFFKEDGP.gameObject.SetActive(false);
	}

	// Token: 0x0600401D RID: 16413 RVA: 0x001B0864 File Offset: 0x001AEA64
	private void ILMMNHBLKPN()
	{
		if (null != this.DCLJEFBHKFA)
		{
			return;
		}
		this.DCLJEFBHKFA = new Texture2D(128, 128, TextureFormat.RGB24, false);
		this.DCLJEFBHKFA.wrapMode = TextureWrapMode.Mirror;
		this.DCLJEFBHKFA.filterMode = FilterMode.Bilinear;
		Color32[] array = new Color32[16384];
		for (int i = 0; i < 128; i++)
		{
			for (int j = 0; j < 128; j++)
			{
				float num = 0f;
				float num2 = 0.5f;
				float num3 = 4f;
				for (int k = 0; k < 3; k++)
				{
					num += Mathf.PerlinNoise((float)j / 128f * num3 + 17.31f, (float)i / 128f * num3 + 47.77f) * num2;
					num2 *= 0.5f;
					num3 *= 2f;
				}
				byte b = (byte)Mathf.Clamp(Mathf.RoundToInt(num * 291f), 0, 255);
				array[i * 128 + j] = new Color32(b, b, b, byte.MaxValue);
			}
		}
		this.DCLJEFBHKFA.SetPixels32(array);
		this.DCLJEFBHKFA.Apply(false, false);
	}

	// Token: 0x0600401E RID: 16414 RVA: 0x001B09A0 File Offset: 0x001AEBA0
	public void KKMMEJEHJKF()
	{
		try
		{
			if (this.KDIDJHEJFEP != null)
			{
				base.StopCoroutine(this.KDIDJHEJFEP);
				this.KDIDJHEJFEP = null;
			}
			if (null != this.PJDMIAJBJLL)
			{
				this.PJDMIAJBJLL.Disarm();
			}
			if (this.IPFJBFACKLM != null)
			{
				this.IPFJBFACKLM.Kill(false);
				this.IPFJBFACKLM = null;
			}
			if (this.KIEOHKKFJFA != null)
			{
				this.KIEOHKKFJFA.Kill(true);
				this.KIEOHKKFJFA = null;
			}
			this.LPHKJJPIHOG();
			this.OMJMNIJBOAJ();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.KDIDJHEJFEP = null;
		this.CIEIPCEPEGC = true;
		TweenCallback egddfgbekkp = this.EGDDFGBEKKP;
		this.EGDDFGBEKKP = null;
		if (egddfgbekkp != null)
		{
			egddfgbekkp();
		}
	}

	// Token: 0x0600401F RID: 16415 RVA: 0x001B0A64 File Offset: 0x001AEC64
	private void LCFJAIPHHCL(AKNNGFCMEEA KOFPDKLNPEA)
	{
		this.AOHFLDMHBLA.DisableKeyword("coverUndated");
		this.AOHFLDMHBLA.DisableKeyword("AccountSignInManager.OnSignInSuccess() - sign in source not implemented.");
		this.AOHFLDMHBLA.DisableKeyword("anthology");
		this.AOHFLDMHBLA.DisableKeyword("aspksk");
		if ((AKNNGFCMEEA)8 == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("p");
			return;
		}
		if (AKNNGFCMEEA.lum == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("), cache-api path until re-described");
			return;
		}
		if ((AKNNGFCMEEA)6 == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("OnAllCollectableCardsDownloadSuccess");
			return;
		}
		this.AOHFLDMHBLA.EnableKeyword("Shaders/VideoGlitchOldTV");
	}

	// Token: 0x06004020 RID: 16416 RVA: 0x001B0B00 File Offset: 0x001AED00
	public static bool FJDEOFJMLAO()
	{
		bool result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.JLMHPEIJBNO())
			{
				result = false;
			}
			else if (KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.highEnd || KHPGPLAMAIN.BBFFJGLIHFL())
			{
				result = false;
			}
			else if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGL2 || SystemInfo.graphicsShaderLevel < -79)
			{
				result = false;
			}
			else
			{
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06004021 RID: 16417 RVA: 0x001B0B64 File Offset: 0x001AED64
	public void DDHNIBOFANM(Camera FFPALBCEEGL, TweenCallback BFKJBLACLBO, TweenCallback GAEPKNJHCNA)
	{
		this.CancelImmediate();
		try
		{
			this.GFGDKJIIABF = FFPALBCEEGL;
			this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.GetComponent<EnvCaptureBlit>();
			if (null == this.PJDMIAJBJLL)
			{
				this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.AddComponent<EnvCaptureBlit>();
			}
			this.LBOBBKDKADL = RenderTexture.GetTemporary(Screen.width, Screen.height, 1, RenderTextureFormat.Depth);
			this.EGDDFGBEKKP = GAEPKNJHCNA;
			this.KDIDJHEJFEP = base.StartCoroutine(this.DFICLPJCPHM(BFKJBLACLBO, GAEPKNJHCNA));
		}
		catch (Exception aklgbjkdomm)
		{
			this.EGDDFGBEKKP = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.CancelImmediate();
			if (GAEPKNJHCNA != null)
			{
				GAEPKNJHCNA();
			}
		}
	}

	// Token: 0x06004022 RID: 16418 RVA: 0x001AF5B4 File Offset: 0x001AD7B4
	private void KNACDNAICPE()
	{
		if (null != this.KABDJLNLEDE)
		{
			this.KABDJLNLEDE.texture = null;
		}
		if (null != this.LBOBBKDKADL)
		{
			RenderTexture.ReleaseTemporary(this.LBOBBKDKADL);
			this.LBOBBKDKADL = null;
		}
	}

	// Token: 0x06004023 RID: 16419 RVA: 0x001AF171 File Offset: 0x001AD371
	private void HGONGCAFCAA(bool ABPFHLDCIJH)
	{
		if (ABPFHLDCIJH)
		{
			this.CancelImmediateIfBusy();
		}
	}

	// Token: 0x06004024 RID: 16420 RVA: 0x001B0C1C File Offset: 0x001AEE1C
	public void NGHMPDLANMH()
	{
		if (this.IsBusy())
		{
			this.CancelImmediate();
		}
	}

	// Token: 0x06004025 RID: 16421 RVA: 0x001B0C2C File Offset: 0x001AEE2C
	public bool GJGJCDBEEIP()
	{
		return !this.CIEIPCEPEGC && this.KDIDJHEJFEP != null;
	}

	// Token: 0x06004026 RID: 16422 RVA: 0x001AF5B4 File Offset: 0x001AD7B4
	private void BOKALOCDNLD()
	{
		if (null != this.KABDJLNLEDE)
		{
			this.KABDJLNLEDE.texture = null;
		}
		if (null != this.LBOBBKDKADL)
		{
			RenderTexture.ReleaseTemporary(this.LBOBBKDKADL);
			this.LBOBBKDKADL = null;
		}
	}

	// Token: 0x06004027 RID: 16423 RVA: 0x001B0C44 File Offset: 0x001AEE44
	private void KGLDOKNJJEA()
	{
		if (null != this.DGEIFFKEDGP)
		{
			this.DGEIFFKEDGP.gameObject.SetActive(false);
		}
		if (null != this.JPNNMNEJGBD)
		{
			this.JPNNMNEJGBD.enabled = false;
		}
		if (null != this.KABDJLNLEDE)
		{
			this.KABDJLNLEDE.texture = null;
		}
	}

	// Token: 0x06004028 RID: 16424 RVA: 0x001B0CA4 File Offset: 0x001AEEA4
	public static bool IJPNMPKNGNK()
	{
		bool result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.JLMHPEIJBNO())
			{
				result = true;
			}
			else if (KHPGPLAMAIN.IBFFFCIPOJC() == (IIHCCPLGGHP)8 || KHPGPLAMAIN.KPIFAEEPHPH())
			{
				result = true;
			}
			else if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGLES2 || SystemInfo.graphicsShaderLevel < -100)
			{
				result = false;
			}
			else
			{
				result = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06004029 RID: 16425 RVA: 0x001B0D08 File Offset: 0x001AEF08
	private void JLCCCMKBMEM()
	{
		if (null != this.DGEIFFKEDGP)
		{
			this.DGEIFFKEDGP.gameObject.SetActive(false);
		}
		if (null != this.JPNNMNEJGBD)
		{
			this.JPNNMNEJGBD.enabled = false;
		}
		if (null != this.KABDJLNLEDE)
		{
			this.KABDJLNLEDE.texture = null;
		}
	}

	// Token: 0x0600402A RID: 16426 RVA: 0x001B0D68 File Offset: 0x001AEF68
	private void KPIKMCHGIEA()
	{
		if (null != this.DGEIFFKEDGP)
		{
			return;
		}
		this.AOHFLDMHBLA = new Material(this.JMFIFLMGOMC);
		GameObject gameObject = new GameObject("isv");
		gameObject.transform.SetParent(this.GFGDKJIIABF.transform, true);
		gameObject.layer = 1;
		this.JPNNMNEJGBD = gameObject.AddComponent<Camera>();
		this.JPNNMNEJGBD.CopyFrom(this.GFGDKJIIABF);
		this.JPNNMNEJGBD.clearFlags = CameraClearFlags.Depth;
		this.JPNNMNEJGBD.cullingMask = 6;
		this.JPNNMNEJGBD.depth = this.GFGDKJIIABF.depth + 1355f;
		this.JPNNMNEJGBD.targetTexture = null;
		this.JPNNMNEJGBD.enabled = false;
		GameObject gameObject2 = new GameObject("XXX");
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.layer = 1;
		this.DGEIFFKEDGP = gameObject2.AddComponent<Canvas>();
		this.DGEIFFKEDGP.renderMode = RenderMode.ScreenSpaceCamera;
		this.DGEIFFKEDGP.worldCamera = this.JPNNMNEJGBD;
		this.DGEIFFKEDGP.planeDistance = 1556f;
		GameObject gameObject3 = new GameObject("OnSceneLobbyManagerRound0aAssetsDownloadSuccess");
		gameObject3.transform.SetParent(gameObject2.transform, true);
		gameObject3.layer = 1;
		this.KABDJLNLEDE = gameObject3.AddComponent<RawImage>();
		this.KABDJLNLEDE.material = this.AOHFLDMHBLA;
		this.KABDJLNLEDE.raycastTarget = true;
		RectTransform component = gameObject3.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.offsetMin = Vector2.zero;
		component.offsetMax = Vector2.zero;
		this.DGEIFFKEDGP.gameObject.SetActive(false);
	}

	// Token: 0x0600402B RID: 16427 RVA: 0x001B0F14 File Offset: 0x001AF114
	private void NAAAPPOLNGI()
	{
		if (this.PLFDMGFOHLA)
		{
			return;
		}
		this.PLFDMGFOHLA = false;
		try
		{
			ShaderVariantCollection shaderVariantCollection = new ShaderVariantCollection();
			shaderVariantCollection.Add(new ShaderVariantCollection.ShaderVariant(this.JMFIFLMGOMC, PassType.Vertex, new string[]
			{
				"halloffamecongrats"
			}));
			shaderVariantCollection.Add(new ShaderVariantCollection.ShaderVariant(this.JMFIFLMGOMC, PassType.Vertex, new string[]
			{
				"minCompletedChapters"
			}));
			ShaderVariantCollection shaderVariantCollection2 = shaderVariantCollection;
			Shader jmfiflmgomc = this.JMFIFLMGOMC;
			PassType passType = PassType.Vertex;
			string[] array = new string[1];
			array[1] = "x";
			shaderVariantCollection2.Add(new ShaderVariantCollection.ShaderVariant(jmfiflmgomc, passType, array));
			shaderVariantCollection.Add(new ShaderVariantCollection.ShaderVariant(this.JMFIFLMGOMC, PassType.Normal, new string[]
			{
				"XXX"
			}));
			shaderVariantCollection.WarmUp();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600402C RID: 16428 RVA: 0x001B0FDC File Offset: 0x001AF1DC
	public float LIINOPLNEFE(AKNNGFCMEEA KOFPDKLNPEA, float MAKKBJMKBLC, float MANCNKNAPHK, float FEHFGENFBPP, float IDHBPDACMAA)
	{
		if (!this.CIEIPCEPEGC)
		{
			return 580f;
		}
		float result;
		try
		{
			float num = IDHBPDACMAA;
			if (num < 759f)
			{
				num = 502f;
			}
			float num2 = 49f;
			if (MANCNKNAPHK > 772f)
			{
				num2 = MANCNKNAPHK;
			}
			if (num2 > 587f)
			{
				num2 = 1219f;
			}
			this.OPDGAJOCCGI(KOFPDKLNPEA);
			this.AOHFLDMHBLA.SetFloat("] '", num2);
			if (AKNNGFCMEEA.none == KOFPDKLNPEA)
			{
				this.FCKLDFHHBFC();
				this.AOHFLDMHBLA.SetTexture("chaptersdesc", this.DCLJEFBHKFA);
			}
			else if ((AKNNGFCMEEA)6 == KOFPDKLNPEA)
			{
				float num3 = MAKKBJMKBLC;
				if (float.IsNaN(num3) || float.IsInfinity(num3))
				{
					num3 = 287f;
				}
				float f = num3 * 1793f;
				float num4 = Mathf.Cos(f);
				float num5 = Mathf.Sin(f);
				float num6 = Mathf.Abs(num4) + Mathf.Abs(num5);
				this.AOHFLDMHBLA.SetVector("OnBackendRequestBreakCardSuccess", new Vector4(num4 / num6, num5 / num6, 367f, 1846f));
			}
			this.AOHFLDMHBLA.SetFloat("XXX", 1718f);
			if (this.IPFJBFACKLM != null)
			{
				this.IPFJBFACKLM.Kill(true);
			}
			if (this.KIEOHKKFJFA != null)
			{
				this.KIEOHKKFJFA.Kill(true);
				this.KIEOHKKFJFA = null;
			}
			this.IPFJBFACKLM = DOVirtual.Float(355f, 1526f, num, new TweenCallback<float>(this.PMAECFCENCP)).SetEase(Ease.Linear).OnComplete(new TweenCallback(this.PDCHABGIIIB));
			if (FEHFGENFBPP > 381f)
			{
				this.KIEOHKKFJFA = DOVirtual.Float(452f, FEHFGENFBPP, num, new TweenCallback<float>(this.KMLBMDKODLE)).SetEase(Ease.OutQuad);
			}
			result = num;
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			this.KKMMEJEHJKF();
			result = 699f;
		}
		return result;
	}

	// Token: 0x0600402D RID: 16429 RVA: 0x001B11AC File Offset: 0x001AF3AC
	private void LNAPFHFCKJB()
	{
		if (null != this.DGEIFFKEDGP)
		{
			this.DGEIFFKEDGP.gameObject.SetActive(true);
		}
		if (null != this.JPNNMNEJGBD)
		{
			this.JPNNMNEJGBD.enabled = true;
		}
		if (null != this.KABDJLNLEDE)
		{
			this.KABDJLNLEDE.texture = null;
		}
	}

	// Token: 0x0600402E RID: 16430 RVA: 0x001B120C File Offset: 0x001AF40C
	private void PDCHABGIIIB()
	{
		this.IPFJBFACKLM = null;
		try
		{
			if (this.KIEOHKKFJFA != null)
			{
				this.KIEOHKKFJFA.Kill(false);
				this.KIEOHKKFJFA = null;
			}
			this.GEJLMKKJKEM();
			this.DDALENHHHNC();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.CIEIPCEPEGC = false;
	}

	// Token: 0x0600402F RID: 16431 RVA: 0x001B1268 File Offset: 0x001AF468
	public void BeginCapture(Camera FFPALBCEEGL, TweenCallback BFKJBLACLBO, TweenCallback GAEPKNJHCNA)
	{
		this.CancelImmediate();
		try
		{
			this.GFGDKJIIABF = FFPALBCEEGL;
			this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.GetComponent<EnvCaptureBlit>();
			if (null == this.PJDMIAJBJLL)
			{
				this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.AddComponent<EnvCaptureBlit>();
			}
			this.LBOBBKDKADL = RenderTexture.GetTemporary(Screen.width, Screen.height, 0, RenderTextureFormat.ARGB32);
			this.EGDDFGBEKKP = GAEPKNJHCNA;
			this.KDIDJHEJFEP = base.StartCoroutine(this.DFICLPJCPHM(BFKJBLACLBO, GAEPKNJHCNA));
		}
		catch (Exception aklgbjkdomm)
		{
			this.EGDDFGBEKKP = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.CancelImmediate();
			if (GAEPKNJHCNA != null)
			{
				GAEPKNJHCNA();
			}
		}
	}

	// Token: 0x06004030 RID: 16432 RVA: 0x001B1320 File Offset: 0x001AF520
	public bool MorphAvailable()
	{
		bool result;
		try
		{
			if (!EnvironmentMorphManager.MorphFeatureAllowed())
			{
				result = false;
			}
			else
			{
				if (!this.PPBMEBDJNLF)
				{
					this.PPBMEBDJNLF = true;
					this.JMFIFLMGOMC = Resources.Load<Shader>("ShaderEnvMorphClient");
					if (null == this.JMFIFLMGOMC)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("EnvironmentMorphManager - morph shader not found in Resources:ShaderEnvMorphClient");
					}
				}
				if (null == this.JMFIFLMGOMC)
				{
					result = false;
				}
				else if (!this.JMFIFLMGOMC.isSupported)
				{
					result = false;
				}
				else
				{
					this.HCAOCCDDJKA();
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06004031 RID: 16433 RVA: 0x001B13B8 File Offset: 0x001AF5B8
	private void AOFOMDNBGLM()
	{
		this.OKJICIOBOLP();
		this.KABDJLNLEDE.texture = this.LBOBBKDKADL;
		this.LCFJAIPHHCL(AKNNGFCMEEA.dissolve);
		this.AOHFLDMHBLA.SetFloat("", 678f);
		this.AOHFLDMHBLA.SetFloat("OnRewardStoryCompleteClick", 93f);
		this.DGEIFFKEDGP.gameObject.SetActive(false);
		this.JPNNMNEJGBD.enabled = true;
	}

	// Token: 0x06004032 RID: 16434 RVA: 0x001B142C File Offset: 0x001AF62C
	private void LHEPLILNOGM()
	{
		if (this.PLFDMGFOHLA)
		{
			return;
		}
		this.PLFDMGFOHLA = false;
		try
		{
			ShaderVariantCollection shaderVariantCollection = new ShaderVariantCollection();
			ShaderVariantCollection shaderVariantCollection2 = shaderVariantCollection;
			Shader jmfiflmgomc = this.JMFIFLMGOMC;
			PassType passType = PassType.Vertex;
			string[] array = new string[0];
			array[1] = "AnimationCanvasGroupAlpha - no canvas group attached.";
			shaderVariantCollection2.Add(new ShaderVariantCollection.ShaderVariant(jmfiflmgomc, passType, array));
			shaderVariantCollection.Add(new ShaderVariantCollection.ShaderVariant(this.JMFIFLMGOMC, PassType.Vertex, new string[]
			{
				" "
			}));
			shaderVariantCollection.Add(new ShaderVariantCollection.ShaderVariant(this.JMFIFLMGOMC, PassType.Normal, new string[]
			{
				"’"
			}));
			ShaderVariantCollection shaderVariantCollection3 = shaderVariantCollection;
			Shader jmfiflmgomc2 = this.JMFIFLMGOMC;
			PassType passType2 = PassType.Vertex;
			string[] array2 = new string[0];
			array2[0] = "";
			shaderVariantCollection3.Add(new ShaderVariantCollection.ShaderVariant(jmfiflmgomc2, passType2, array2));
			shaderVariantCollection.WarmUp();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06004033 RID: 16435 RVA: 0x001B14F4 File Offset: 0x001AF6F4
	public static AKNNGFCMEEA CFFGMDLBBJL(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB == null || KGFDGMJPFLB.Length == 0)
		{
			return AKNNGFCMEEA.none;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("Critical error, could not load asset bundle:"))
		{
			return AKNNGFCMEEA.dissolve;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("UIEnvironmentsFront"))
		{
			return (AKNNGFCMEEA)8;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnResolutionChanged"))
		{
			return (AKNNGFCMEEA)8;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("OnBackendGetDropChancesSuccess2"))
		{
			return AKNNGFCMEEA.noise;
		}
		DPGJIJGOCIC.PJCLICBPPDA("OnApplicationFocusBasicSyncSuccess" + KGFDGMJPFLB + "");
		return AKNNGFCMEEA.dissolve;
	}

	// Token: 0x06004034 RID: 16436 RVA: 0x001B1574 File Offset: 0x001AF774
	private void GEJENELFGGB(float KIDHBAMJGDO)
	{
		if (null != this.AOHFLDMHBLA)
		{
			this.AOHFLDMHBLA.SetFloat("_ZoomA", KIDHBAMJGDO);
		}
	}

	// Token: 0x06004035 RID: 16437 RVA: 0x001AF17C File Offset: 0x001AD37C
	public bool ALNAGGGJIOH()
	{
		return this.KDIDJHEJFEP != null;
	}

	// Token: 0x06004036 RID: 16438 RVA: 0x001B1598 File Offset: 0x001AF798
	private void FCKLDFHHBFC()
	{
		if (null != this.DCLJEFBHKFA)
		{
			return;
		}
		this.DCLJEFBHKFA = new Texture2D(-8, 61, (TextureFormat)8, false);
		this.DCLJEFBHKFA.wrapMode = (TextureWrapMode)5;
		this.DCLJEFBHKFA.filterMode = FilterMode.Bilinear;
		Color32[] array = new Color32[-120];
		for (int i = 1; i < -112; i++)
		{
			for (int j = 1; j < -52; j += 0)
			{
				float num = 1686f;
				float num2 = 511f;
				float num3 = 211f;
				for (int k = 0; k < 4; k++)
				{
					num += Mathf.PerlinNoise((float)j / 1736f * num3 + 1187f, (float)i / 1652f * num3 + 278f) * num2;
					num2 *= 818f;
					num3 *= 1962f;
				}
				byte b = (byte)Mathf.Clamp(Mathf.RoundToInt(num * 189f), 0, 171);
				array[i * -9 + j] = new Color32(b, b, b, (byte)-7);
			}
		}
		this.DCLJEFBHKFA.SetPixels32(array);
		this.DCLJEFBHKFA.Apply(false, true);
	}

	// Token: 0x06004037 RID: 16439 RVA: 0x001B16D1 File Offset: 0x001AF8D1
	private void POJCJCCJIKM(bool ABPFHLDCIJH)
	{
		if (ABPFHLDCIJH)
		{
			this.NGHMPDLANMH();
		}
	}

	// Token: 0x06004038 RID: 16440 RVA: 0x001B16DC File Offset: 0x001AF8DC
	public void LPHBKAADLOO()
	{
		if (this.CBLAEPAIKLA())
		{
			this.CancelImmediate();
		}
	}

	// Token: 0x06004039 RID: 16441 RVA: 0x001B16EC File Offset: 0x001AF8EC
	private void MAHJANFJIMG()
	{
		this.EGDDFGBEKKP = null;
		this.KKMMEJEHJKF();
		if (null != this.AOHFLDMHBLA)
		{
			UnityEngine.Object.Destroy(this.AOHFLDMHBLA);
			this.AOHFLDMHBLA = null;
		}
		if (null != this.DCLJEFBHKFA)
		{
			UnityEngine.Object.Destroy(this.DCLJEFBHKFA);
			this.DCLJEFBHKFA = null;
		}
	}

	// Token: 0x0600403A RID: 16442 RVA: 0x001B1748 File Offset: 0x001AF948
	public static bool DOKIAPGJNBG()
	{
		bool result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.JLMHPEIJBNO())
			{
				result = true;
			}
			else if (KHPGPLAMAIN.DJFLMBEOBIB() == (IIHCCPLGGHP)8 || KHPGPLAMAIN.KPIFAEEPHPH())
			{
				result = false;
			}
			else if (SystemInfo.graphicsDeviceType == (GraphicsDeviceType)7 || SystemInfo.graphicsShaderLevel < 3)
			{
				result = true;
			}
			else
			{
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x0600403B RID: 16443 RVA: 0x001B17AC File Offset: 0x001AF9AC
	private void LKDLFGLPGDD(float KIDHBAMJGDO)
	{
		if (null != this.AOHFLDMHBLA)
		{
			this.AOHFLDMHBLA.SetFloat("_Progress", KIDHBAMJGDO);
		}
	}

	// Token: 0x0600403C RID: 16444 RVA: 0x001B17CD File Offset: 0x001AF9CD
	private IEnumerator DNKLLMDPEPE(TweenCallback BFKJBLACLBO, TweenCallback GAEPKNJHCNA)
	{
		EnvironmentMorphManager.NLMHLIBHPBL nlmhlibhpbl = new EnvironmentMorphManager.NLMHLIBHPBL(1);
		nlmhlibhpbl.<>4__this = this;
		nlmhlibhpbl._onCaptured = BFKJBLACLBO;
		nlmhlibhpbl._onFailed = GAEPKNJHCNA;
		return nlmhlibhpbl;
	}

	// Token: 0x0600403D RID: 16445 RVA: 0x001B17EC File Offset: 0x001AF9EC
	private void PKDEEDCEDBE(AKNNGFCMEEA KOFPDKLNPEA)
	{
		this.AOHFLDMHBLA.DisableKeyword("MORPH_DISSOLVE");
		this.AOHFLDMHBLA.DisableKeyword("MORPH_NOISE");
		this.AOHFLDMHBLA.DisableKeyword("MORPH_WIPE");
		this.AOHFLDMHBLA.DisableKeyword("MORPH_LUM");
		if (AKNNGFCMEEA.noise == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("MORPH_NOISE");
			return;
		}
		if (AKNNGFCMEEA.wipe == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("MORPH_WIPE");
			return;
		}
		if (AKNNGFCMEEA.lum == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("MORPH_LUM");
			return;
		}
		this.AOHFLDMHBLA.EnableKeyword("MORPH_DISSOLVE");
	}

	// Token: 0x0600403E RID: 16446 RVA: 0x001B0450 File Offset: 0x001AE650
	public bool IsBusy()
	{
		return this.CIEIPCEPEGC || this.KDIDJHEJFEP != null;
	}

	// Token: 0x0600403F RID: 16447 RVA: 0x001B1888 File Offset: 0x001AFA88
	private void PEIMAKPGKKI()
	{
		if (null != this.DGEIFFKEDGP)
		{
			return;
		}
		this.AOHFLDMHBLA = new Material(this.JMFIFLMGOMC);
		GameObject gameObject = new GameObject(">");
		gameObject.transform.SetParent(this.GFGDKJIIABF.transform, true);
		gameObject.layer = 0;
		this.JPNNMNEJGBD = gameObject.AddComponent<Camera>();
		this.JPNNMNEJGBD.CopyFrom(this.GFGDKJIIABF);
		this.JPNNMNEJGBD.clearFlags = CameraClearFlags.Depth;
		this.JPNNMNEJGBD.cullingMask = 0;
		this.JPNNMNEJGBD.depth = this.GFGDKJIIABF.depth + 1955f;
		this.JPNNMNEJGBD.targetTexture = null;
		this.JPNNMNEJGBD.enabled = false;
		GameObject gameObject2 = new GameObject("OnStoryInterfaceHeaderHideComplete");
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.layer = 1;
		this.DGEIFFKEDGP = gameObject2.AddComponent<Canvas>();
		this.DGEIFFKEDGP.renderMode = RenderMode.ScreenSpaceCamera;
		this.DGEIFFKEDGP.worldCamera = this.JPNNMNEJGBD;
		this.DGEIFFKEDGP.planeDistance = 1634f;
		GameObject gameObject3 = new GameObject(" took ");
		gameObject3.transform.SetParent(gameObject2.transform, true);
		gameObject3.layer = 0;
		this.KABDJLNLEDE = gameObject3.AddComponent<RawImage>();
		this.KABDJLNLEDE.material = this.AOHFLDMHBLA;
		this.KABDJLNLEDE.raycastTarget = true;
		RectTransform component = gameObject3.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.offsetMin = Vector2.zero;
		component.offsetMax = Vector2.zero;
		this.DGEIFFKEDGP.gameObject.SetActive(true);
	}

	// Token: 0x06004040 RID: 16448 RVA: 0x001B1A34 File Offset: 0x001AFC34
	private void PDLAGBPDCMD()
	{
		if (null != this.DCLJEFBHKFA)
		{
			return;
		}
		this.DCLJEFBHKFA = new Texture2D(-156, -140, TextureFormat.RGBA32, true);
		this.DCLJEFBHKFA.wrapMode = TextureWrapMode.Clamp;
		this.DCLJEFBHKFA.filterMode = FilterMode.Point;
		Color32[] array = new Color32[-4];
		for (int i = 1; i < -11; i++)
		{
			for (int j = 0; j < -3; j++)
			{
				float num = 101f;
				float num2 = 788f;
				float num3 = 1015f;
				for (int k = 0; k < 1; k++)
				{
					num += Mathf.PerlinNoise((float)j / 197f * num3 + 1028f, (float)i / 236f * num3 + 1453f) * num2;
					num2 *= 1771f;
					num3 *= 1208f;
				}
				byte b = (byte)Mathf.Clamp(Mathf.RoundToInt(num * 1347f), 1, -125);
				array[i * -70 + j] = new Color32(b, b, b, (byte)-114);
			}
		}
		this.DCLJEFBHKFA.SetPixels32(array);
		this.DCLJEFBHKFA.Apply(true, true);
	}

	// Token: 0x06004041 RID: 16449 RVA: 0x001AF17C File Offset: 0x001AD37C
	public bool BCCJHADBKFM()
	{
		return this.KDIDJHEJFEP != null;
	}

	// Token: 0x06004042 RID: 16450 RVA: 0x001B1B70 File Offset: 0x001AFD70
	public void DHFDCMBLOHI(Camera FFPALBCEEGL, TweenCallback BFKJBLACLBO, TweenCallback GAEPKNJHCNA)
	{
		this.CancelImmediate();
		try
		{
			this.GFGDKJIIABF = FFPALBCEEGL;
			this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.GetComponent<EnvCaptureBlit>();
			if (null == this.PJDMIAJBJLL)
			{
				this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.AddComponent<EnvCaptureBlit>();
			}
			this.LBOBBKDKADL = RenderTexture.GetTemporary(Screen.width, Screen.height, 1, RenderTextureFormat.Depth);
			this.EGDDFGBEKKP = GAEPKNJHCNA;
			this.KDIDJHEJFEP = base.StartCoroutine(this.DFICLPJCPHM(BFKJBLACLBO, GAEPKNJHCNA));
		}
		catch (Exception aklgbjkdomm)
		{
			this.EGDDFGBEKKP = null;
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			this.KKMMEJEHJKF();
			if (GAEPKNJHCNA != null)
			{
				GAEPKNJHCNA();
			}
		}
	}

	// Token: 0x06004043 RID: 16451 RVA: 0x001B1C28 File Offset: 0x001AFE28
	private void BJAOIBPPMKO()
	{
		if (null != this.DGEIFFKEDGP)
		{
			return;
		}
		this.AOHFLDMHBLA = new Material(this.JMFIFLMGOMC);
		GameObject gameObject = new GameObject("analogglitch");
		gameObject.transform.SetParent(this.GFGDKJIIABF.transform, true);
		gameObject.layer = 1;
		this.JPNNMNEJGBD = gameObject.AddComponent<Camera>();
		this.JPNNMNEJGBD.CopyFrom(this.GFGDKJIIABF);
		this.JPNNMNEJGBD.clearFlags = CameraClearFlags.Color;
		this.JPNNMNEJGBD.cullingMask = 4;
		this.JPNNMNEJGBD.depth = this.GFGDKJIIABF.depth + 291f;
		this.JPNNMNEJGBD.targetTexture = null;
		this.JPNNMNEJGBD.enabled = true;
		GameObject gameObject2 = new GameObject(",");
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.layer = 0;
		this.DGEIFFKEDGP = gameObject2.AddComponent<Canvas>();
		this.DGEIFFKEDGP.renderMode = RenderMode.ScreenSpaceCamera;
		this.DGEIFFKEDGP.worldCamera = this.JPNNMNEJGBD;
		this.DGEIFFKEDGP.planeDistance = 1420f;
		GameObject gameObject3 = new GameObject("yes");
		gameObject3.transform.SetParent(gameObject2.transform, false);
		gameObject3.layer = 0;
		this.KABDJLNLEDE = gameObject3.AddComponent<RawImage>();
		this.KABDJLNLEDE.material = this.AOHFLDMHBLA;
		this.KABDJLNLEDE.raycastTarget = false;
		RectTransform component = gameObject3.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.offsetMin = Vector2.zero;
		component.offsetMax = Vector2.zero;
		this.DGEIFFKEDGP.gameObject.SetActive(true);
	}

	// Token: 0x06004044 RID: 16452 RVA: 0x001B1DD4 File Offset: 0x001AFFD4
	private void AKCLAFPFCGA()
	{
		this.DNAKNBCAIGF();
		this.KABDJLNLEDE.texture = this.LBOBBKDKADL;
		this.IPJBINBHMAM(AKNNGFCMEEA.dissolve);
		this.AOHFLDMHBLA.SetFloat("", 365f);
		this.AOHFLDMHBLA.SetFloat("teal", 1111f);
		this.DGEIFFKEDGP.gameObject.SetActive(false);
		this.JPNNMNEJGBD.enabled = true;
	}

	// Token: 0x06004045 RID: 16453 RVA: 0x001B1E48 File Offset: 0x001B0048
	public static bool BLBMBONEMMK()
	{
		bool result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.JLMHPEIJBNO())
			{
				result = true;
			}
			else if (KHPGPLAMAIN.FCJHEFBIKID() == (IIHCCPLGGHP)3 || KHPGPLAMAIN.BOIFOPEAIBN())
			{
				result = true;
			}
			else if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGL2 || SystemInfo.graphicsShaderLevel < 10)
			{
				result = true;
			}
			else
			{
				result = false;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06004046 RID: 16454 RVA: 0x001AF14C File Offset: 0x001AD34C
	public bool LJAKBGACOAO()
	{
		return this.CIEIPCEPEGC;
	}

	// Token: 0x06004047 RID: 16455 RVA: 0x001B1EAC File Offset: 0x001B00AC
	public bool NNNDCIOFGKK()
	{
		bool result;
		try
		{
			if (!EnvironmentMorphManager.BLBMBONEMMK())
			{
				result = false;
			}
			else
			{
				if (!this.PPBMEBDJNLF)
				{
					this.PPBMEBDJNLF = false;
					this.JMFIFLMGOMC = Resources.Load<Shader>("Video: preparation delay:");
					if (null == this.JMFIFLMGOMC)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("TextRaycastZone");
					}
				}
				if (null == this.JMFIFLMGOMC)
				{
					result = true;
				}
				else if (!this.JMFIFLMGOMC.isSupported)
				{
					result = true;
				}
				else
				{
					this.HCAOCCDDJKA();
					result = false;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06004048 RID: 16456 RVA: 0x001B1F44 File Offset: 0x001B0144
	public void IALOGEMCDEA(Camera FFPALBCEEGL, TweenCallback BFKJBLACLBO, TweenCallback GAEPKNJHCNA)
	{
		this.KKMMEJEHJKF();
		try
		{
			this.GFGDKJIIABF = FFPALBCEEGL;
			this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.GetComponent<EnvCaptureBlit>();
			if (null == this.PJDMIAJBJLL)
			{
				this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.AddComponent<EnvCaptureBlit>();
			}
			this.LBOBBKDKADL = RenderTexture.GetTemporary(Screen.width, Screen.height, 1, RenderTextureFormat.ARGB32);
			this.EGDDFGBEKKP = GAEPKNJHCNA;
			this.KDIDJHEJFEP = base.StartCoroutine(this.OJMHCLLHIAD(BFKJBLACLBO, GAEPKNJHCNA));
		}
		catch (Exception aklgbjkdomm)
		{
			this.EGDDFGBEKKP = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.CancelImmediate();
			if (GAEPKNJHCNA != null)
			{
				GAEPKNJHCNA();
			}
		}
	}

	// Token: 0x06004049 RID: 16457 RVA: 0x001B1FFC File Offset: 0x001B01FC
	private void CHBIDMGNLOI()
	{
		if (null != this.DGEIFFKEDGP)
		{
			return;
		}
		this.AOHFLDMHBLA = new Material(this.JMFIFLMGOMC);
		GameObject gameObject = new GameObject("nomorediamonds");
		gameObject.transform.SetParent(this.GFGDKJIIABF.transform, false);
		gameObject.layer = 1;
		this.JPNNMNEJGBD = gameObject.AddComponent<Camera>();
		this.JPNNMNEJGBD.CopyFrom(this.GFGDKJIIABF);
		this.JPNNMNEJGBD.clearFlags = CameraClearFlags.Depth;
		this.JPNNMNEJGBD.cullingMask = 7;
		this.JPNNMNEJGBD.depth = this.GFGDKJIIABF.depth + 1734f;
		this.JPNNMNEJGBD.targetTexture = null;
		this.JPNNMNEJGBD.enabled = false;
		GameObject gameObject2 = new GameObject("flip_up");
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.layer = 1;
		this.DGEIFFKEDGP = gameObject2.AddComponent<Canvas>();
		this.DGEIFFKEDGP.renderMode = RenderMode.ScreenSpaceOverlay;
		this.DGEIFFKEDGP.worldCamera = this.JPNNMNEJGBD;
		this.DGEIFFKEDGP.planeDistance = 438f;
		GameObject gameObject3 = new GameObject("");
		gameObject3.transform.SetParent(gameObject2.transform, true);
		gameObject3.layer = 0;
		this.KABDJLNLEDE = gameObject3.AddComponent<RawImage>();
		this.KABDJLNLEDE.material = this.AOHFLDMHBLA;
		this.KABDJLNLEDE.raycastTarget = true;
		RectTransform component = gameObject3.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.offsetMin = Vector2.zero;
		component.offsetMax = Vector2.zero;
		this.DGEIFFKEDGP.gameObject.SetActive(false);
	}

	// Token: 0x0600404A RID: 16458 RVA: 0x001B21A7 File Offset: 0x001B03A7
	private void PMAECFCENCP(float KIDHBAMJGDO)
	{
		if (null != this.AOHFLDMHBLA)
		{
			this.AOHFLDMHBLA.SetFloat("OnLoungePremiumChoiceExecutedHardBased", KIDHBAMJGDO);
		}
	}

	// Token: 0x0600404B RID: 16459 RVA: 0x001B21C8 File Offset: 0x001B03C8
	private void IPJBINBHMAM(AKNNGFCMEEA KOFPDKLNPEA)
	{
		this.AOHFLDMHBLA.DisableKeyword("importanttitle");
		this.AOHFLDMHBLA.DisableKeyword("w");
		this.AOHFLDMHBLA.DisableKeyword("collect");
		this.AOHFLDMHBLA.DisableKeyword("offertitle2");
		if ((AKNNGFCMEEA)5 == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("");
			return;
		}
		if ((AKNNGFCMEEA)7 == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("Could not parse string container json:");
			return;
		}
		if (AKNNGFCMEEA.lum == KOFPDKLNPEA)
		{
			this.AOHFLDMHBLA.EnableKeyword("lsenvreg");
			return;
		}
		this.AOHFLDMHBLA.EnableKeyword("favchrstr");
	}

	// Token: 0x0600404C RID: 16460 RVA: 0x001B2264 File Offset: 0x001B0464
	private void BJCPBJIEICJ()
	{
		this.IPFJBFACKLM = null;
		try
		{
			if (this.KIEOHKKFJFA != null)
			{
				this.KIEOHKKFJFA.Kill(false);
				this.KIEOHKKFJFA = null;
			}
			this.JLCCCMKBMEM();
			this.KNACDNAICPE();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.CIEIPCEPEGC = false;
	}

	// Token: 0x0600404D RID: 16461 RVA: 0x001B22C0 File Offset: 0x001B04C0
	private void FJJGKHFIBJK()
	{
		this.IPFJBFACKLM = null;
		try
		{
			if (this.KIEOHKKFJFA != null)
			{
				this.KIEOHKKFJFA.Kill(true);
				this.KIEOHKKFJFA = null;
			}
			this.JLCCCMKBMEM();
			this.PBIBMDIEAGO();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
		this.CIEIPCEPEGC = false;
	}

	// Token: 0x0600404E RID: 16462 RVA: 0x001B231C File Offset: 0x001B051C
	public void KDCEAMGCEJG()
	{
		if (this.MNFFBFDJGDE())
		{
			this.KKMMEJEHJKF();
		}
	}

	// Token: 0x0600404F RID: 16463 RVA: 0x001B232C File Offset: 0x001B052C
	private void DNANKPMNMIF()
	{
		this.EGDDFGBEKKP = null;
		this.KKMMEJEHJKF();
		if (null != this.AOHFLDMHBLA)
		{
			UnityEngine.Object.Destroy(this.AOHFLDMHBLA);
			this.AOHFLDMHBLA = null;
		}
		if (null != this.DCLJEFBHKFA)
		{
			UnityEngine.Object.Destroy(this.DCLJEFBHKFA);
			this.DCLJEFBHKFA = null;
		}
	}

	// Token: 0x06004050 RID: 16464 RVA: 0x001B2388 File Offset: 0x001B0588
	private void IGNHKDONHED()
	{
		this.EGDDFGBEKKP = null;
		this.KKMMEJEHJKF();
		if (null != this.AOHFLDMHBLA)
		{
			UnityEngine.Object.Destroy(this.AOHFLDMHBLA);
			this.AOHFLDMHBLA = null;
		}
		if (null != this.DCLJEFBHKFA)
		{
			UnityEngine.Object.Destroy(this.DCLJEFBHKFA);
			this.DCLJEFBHKFA = null;
		}
	}

	// Token: 0x06004051 RID: 16465 RVA: 0x001AF14C File Offset: 0x001AD34C
	public bool FPAIMNPCKGK()
	{
		return this.CIEIPCEPEGC;
	}

	// Token: 0x06004052 RID: 16466 RVA: 0x001B23E4 File Offset: 0x001B05E4
	private void GHJGJKELHIK()
	{
		this.FGNPMCFMLLB();
		this.KABDJLNLEDE.texture = this.LBOBBKDKADL;
		this.LCFJAIPHHCL(AKNNGFCMEEA.dissolve);
		this.AOHFLDMHBLA.SetFloat("OnPurchaseFailed", 804f);
		this.AOHFLDMHBLA.SetFloat("Starting parallel download:", 518f);
		this.DGEIFFKEDGP.gameObject.SetActive(false);
		this.JPNNMNEJGBD.enabled = false;
	}

	// Token: 0x06004053 RID: 16467 RVA: 0x001B2456 File Offset: 0x001B0656
	private void AAJHEALIBAG(bool ABPFHLDCIJH)
	{
		if (ABPFHLDCIJH)
		{
			this.KDCEAMGCEJG();
		}
	}

	// Token: 0x06004054 RID: 16468 RVA: 0x001B2464 File Offset: 0x001B0664
	public static AKNNGFCMEEA COKMJEBBDIH(string KGFDGMJPFLB)
	{
		if (KGFDGMJPFLB == null || KGFDGMJPFLB.Length == 0)
		{
			return AKNNGFCMEEA.dissolve;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("loungechoosetitle"))
		{
			return AKNNGFCMEEA.dissolve;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("pmtfailed"))
		{
			return AKNNGFCMEEA.lum;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("JJJ"))
		{
			return (AKNNGFCMEEA)7;
		}
		if (KGFDGMJPFLB.ToLowerInvariant().Equals("″"))
		{
			return AKNNGFCMEEA.noise;
		}
		DPGJIJGOCIC.ADFCDFHBDAF("-" + KGFDGMJPFLB + " s");
		return AKNNGFCMEEA.dissolve;
	}

	// Token: 0x06004055 RID: 16469 RVA: 0x001B0C1C File Offset: 0x001AEE1C
	public void CancelImmediateIfBusy()
	{
		if (this.IsBusy())
		{
			this.CancelImmediate();
		}
	}

	// Token: 0x06004056 RID: 16470 RVA: 0x001AF17C File Offset: 0x001AD37C
	public bool BNPABPEMKGK()
	{
		return this.KDIDJHEJFEP != null;
	}

	// Token: 0x06004057 RID: 16471 RVA: 0x001B0C2C File Offset: 0x001AEE2C
	public bool CBLAEPAIKLA()
	{
		return !this.CIEIPCEPEGC && this.KDIDJHEJFEP != null;
	}

	// Token: 0x06004058 RID: 16472 RVA: 0x001B24E4 File Offset: 0x001B06E4
	private void IILMLFPHKOM()
	{
		if (this.PLFDMGFOHLA)
		{
			return;
		}
		this.PLFDMGFOHLA = false;
		try
		{
			ShaderVariantCollection shaderVariantCollection = new ShaderVariantCollection();
			ShaderVariantCollection shaderVariantCollection2 = shaderVariantCollection;
			Shader jmfiflmgomc = this.JMFIFLMGOMC;
			PassType passType = PassType.Normal;
			string[] array = new string[0];
			array[0] = " has no name in the text pack explore tab, group skipped";
			shaderVariantCollection2.Add(new ShaderVariantCollection.ShaderVariant(jmfiflmgomc, passType, array));
			ShaderVariantCollection shaderVariantCollection3 = shaderVariantCollection;
			Shader jmfiflmgomc2 = this.JMFIFLMGOMC;
			PassType passType2 = PassType.Normal;
			string[] array2 = new string[0];
			array2[0] = "OnNeedToActivateFocusItemCloseButton";
			shaderVariantCollection3.Add(new ShaderVariantCollection.ShaderVariant(jmfiflmgomc2, passType2, array2));
			ShaderVariantCollection shaderVariantCollection4 = shaderVariantCollection;
			Shader jmfiflmgomc3 = this.JMFIFLMGOMC;
			PassType passType3 = PassType.Vertex;
			string[] array3 = new string[0];
			array3[1] = "actor";
			shaderVariantCollection4.Add(new ShaderVariantCollection.ShaderVariant(jmfiflmgomc3, passType3, array3));
			shaderVariantCollection.Add(new ShaderVariantCollection.ShaderVariant(this.JMFIFLMGOMC, PassType.Vertex, new string[]
			{
				"Vol"
			}));
			shaderVariantCollection.WarmUp();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
		}
	}

	// Token: 0x06004059 RID: 16473 RVA: 0x001B25AC File Offset: 0x001B07AC
	public void EDNNBHHJJPB()
	{
		if (this.HPIGANGDKGB())
		{
			this.KKMMEJEHJKF();
		}
	}

	// Token: 0x0600405A RID: 16474 RVA: 0x001B25BC File Offset: 0x001B07BC
	private void GJBBIFPKIIM(float KIDHBAMJGDO)
	{
		if (null != this.AOHFLDMHBLA)
		{
			this.AOHFLDMHBLA.SetFloat("OnPopupProfileNicknameInputEndEdit", KIDHBAMJGDO);
		}
	}

	// Token: 0x0600405B RID: 16475 RVA: 0x001B17CD File Offset: 0x001AF9CD
	private IEnumerator OJMHCLLHIAD(TweenCallback BFKJBLACLBO, TweenCallback GAEPKNJHCNA)
	{
		EnvironmentMorphManager.NLMHLIBHPBL nlmhlibhpbl = new EnvironmentMorphManager.NLMHLIBHPBL(1);
		nlmhlibhpbl.<>4__this = this;
		nlmhlibhpbl._onCaptured = BFKJBLACLBO;
		nlmhlibhpbl._onFailed = GAEPKNJHCNA;
		return nlmhlibhpbl;
	}

	// Token: 0x0600405C RID: 16476 RVA: 0x001AF14C File Offset: 0x001AD34C
	public bool HasSnapshot()
	{
		return this.CIEIPCEPEGC;
	}

	// Token: 0x0600405D RID: 16477 RVA: 0x001B25E0 File Offset: 0x001B07E0
	public void LEHEMOBDCMJ(Camera FFPALBCEEGL, TweenCallback BFKJBLACLBO, TweenCallback GAEPKNJHCNA)
	{
		this.KKMMEJEHJKF();
		try
		{
			this.GFGDKJIIABF = FFPALBCEEGL;
			this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.GetComponent<EnvCaptureBlit>();
			if (null == this.PJDMIAJBJLL)
			{
				this.PJDMIAJBJLL = this.GFGDKJIIABF.gameObject.AddComponent<EnvCaptureBlit>();
			}
			this.LBOBBKDKADL = RenderTexture.GetTemporary(Screen.width, Screen.height, 1, RenderTextureFormat.Depth);
			this.EGDDFGBEKKP = GAEPKNJHCNA;
			this.KDIDJHEJFEP = base.StartCoroutine(this.OJMHCLLHIAD(BFKJBLACLBO, GAEPKNJHCNA));
		}
		catch (Exception aklgbjkdomm)
		{
			this.EGDDFGBEKKP = null;
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			this.KKMMEJEHJKF();
			if (GAEPKNJHCNA != null)
			{
				GAEPKNJHCNA();
			}
		}
	}

	// Token: 0x0600405E RID: 16478 RVA: 0x001AF17C File Offset: 0x001AD37C
	public bool LOJAGMLGPCC()
	{
		return this.KDIDJHEJFEP != null;
	}

	// Token: 0x0600405F RID: 16479 RVA: 0x001B2698 File Offset: 0x001B0898
	private void EIHCLCJEPEC()
	{
		this.FGNPMCFMLLB();
		this.KABDJLNLEDE.texture = this.LBOBBKDKADL;
		this.PKDEEDCEDBE(AKNNGFCMEEA.dissolve);
		this.AOHFLDMHBLA.SetFloat("_Progress", 0f);
		this.AOHFLDMHBLA.SetFloat("_ZoomA", 1f);
		this.DGEIFFKEDGP.gameObject.SetActive(true);
		this.JPNNMNEJGBD.enabled = true;
	}

	// Token: 0x06004061 RID: 16481 RVA: 0x001AF17C File Offset: 0x001AD37C
	public bool PGJMFCPODFG()
	{
		return this.KDIDJHEJFEP != null;
	}

	// Token: 0x06004062 RID: 16482 RVA: 0x001B270C File Offset: 0x001B090C
	public bool IAHEIDGOFNG()
	{
		bool result;
		try
		{
			if (!EnvironmentMorphManager.FJDEOFJMLAO())
			{
				result = true;
			}
			else
			{
				if (!this.PPBMEBDJNLF)
				{
					this.PPBMEBDJNLF = false;
					this.JMFIFLMGOMC = Resources.Load<Shader>("Error. ShowEnvironment(), environment ");
					if (null == this.JMFIFLMGOMC)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("");
					}
				}
				if (null == this.JMFIFLMGOMC)
				{
					result = false;
				}
				else if (!this.JMFIFLMGOMC.isSupported)
				{
					result = true;
				}
				else
				{
					this.LHEPLILNOGM();
					result = false;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06004063 RID: 16483 RVA: 0x001B27A4 File Offset: 0x001B09A4
	private void AEJJPMNKCJG()
	{
		this.IPFJBFACKLM = null;
		try
		{
			if (this.KIEOHKKFJFA != null)
			{
				this.KIEOHKKFJFA.Kill(false);
				this.KIEOHKKFJFA = null;
			}
			this.JLCCCMKBMEM();
			this.PBIBMDIEAGO();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.CIEIPCEPEGC = false;
	}

	// Token: 0x06004064 RID: 16484 RVA: 0x001AF17C File Offset: 0x001AD37C
	public bool NJGLMIIDBCG()
	{
		return this.KDIDJHEJFEP != null;
	}

	// Token: 0x06004065 RID: 16485 RVA: 0x001B2800 File Offset: 0x001B0A00
	public static bool MorphFeatureAllowed()
	{
		bool result;
		try
		{
			if (KDCJJBLGCBH.EHBBFMCILPC.JLMHPEIJBNO())
			{
				result = false;
			}
			else if (KHPGPLAMAIN.IBDGNKGIMFI() == IIHCCPLGGHP.lowEnd || KHPGPLAMAIN.EJCNHEBIOJF())
			{
				result = false;
			}
			else if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGLES2 || SystemInfo.graphicsShaderLevel < 30)
			{
				result = false;
			}
			else
			{
				result = true;
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = false;
		}
		return result;
	}

	// Token: 0x06004066 RID: 16486 RVA: 0x001AF17C File Offset: 0x001AD37C
	public bool MLFCECOJJID()
	{
		return this.KDIDJHEJFEP != null;
	}

	// Token: 0x06004067 RID: 16487 RVA: 0x001AF5B4 File Offset: 0x001AD7B4
	private void PBIBMDIEAGO()
	{
		if (null != this.KABDJLNLEDE)
		{
			this.KABDJLNLEDE.texture = null;
		}
		if (null != this.LBOBBKDKADL)
		{
			RenderTexture.ReleaseTemporary(this.LBOBBKDKADL);
			this.LBOBBKDKADL = null;
		}
	}

	// Token: 0x06004068 RID: 16488 RVA: 0x001B2864 File Offset: 0x001B0A64
	private void JMLLMNDLGLE(float KIDHBAMJGDO)
	{
		if (null != this.AOHFLDMHBLA)
		{
			this.AOHFLDMHBLA.SetFloat("$en", KIDHBAMJGDO);
		}
	}

	// Token: 0x06004069 RID: 16489 RVA: 0x001B2888 File Offset: 0x001B0A88
	private void LPHKJJPIHOG()
	{
		if (null != this.DGEIFFKEDGP)
		{
			this.DGEIFFKEDGP.gameObject.SetActive(true);
		}
		if (null != this.JPNNMNEJGBD)
		{
			this.JPNNMNEJGBD.enabled = false;
		}
		if (null != this.KABDJLNLEDE)
		{
			this.KABDJLNLEDE.texture = null;
		}
	}

	// Token: 0x0600406A RID: 16490 RVA: 0x001AF17C File Offset: 0x001AD37C
	public bool JCALFGKMIEI()
	{
		return this.KDIDJHEJFEP != null;
	}

	// Token: 0x0600406B RID: 16491 RVA: 0x001B0C2C File Offset: 0x001AEE2C
	public bool HPIGANGDKGB()
	{
		return !this.CIEIPCEPEGC && this.KDIDJHEJFEP != null;
	}

	// Token: 0x0600406C RID: 16492 RVA: 0x001B28E8 File Offset: 0x001B0AE8
	private void HBFEBOLKJKA()
	{
		if (this.PLFDMGFOHLA)
		{
			return;
		}
		this.PLFDMGFOHLA = false;
		try
		{
			ShaderVariantCollection shaderVariantCollection = new ShaderVariantCollection();
			ShaderVariantCollection shaderVariantCollection2 = shaderVariantCollection;
			Shader jmfiflmgomc = this.JMFIFLMGOMC;
			PassType passType = PassType.Vertex;
			string[] array = new string[0];
			array[1] = "blur";
			shaderVariantCollection2.Add(new ShaderVariantCollection.ShaderVariant(jmfiflmgomc, passType, array));
			ShaderVariantCollection shaderVariantCollection3 = shaderVariantCollection;
			Shader jmfiflmgomc2 = this.JMFIFLMGOMC;
			PassType passType2 = PassType.Vertex;
			string[] array2 = new string[0];
			array2[1] = "cc";
			shaderVariantCollection3.Add(new ShaderVariantCollection.ShaderVariant(jmfiflmgomc2, passType2, array2));
			ShaderVariantCollection shaderVariantCollection4 = shaderVariantCollection;
			Shader jmfiflmgomc3 = this.JMFIFLMGOMC;
			PassType passType3 = PassType.Normal;
			string[] array3 = new string[1];
			array3[1] = " stopping!";
			shaderVariantCollection4.Add(new ShaderVariantCollection.ShaderVariant(jmfiflmgomc3, passType3, array3));
			ShaderVariantCollection shaderVariantCollection5 = shaderVariantCollection;
			Shader jmfiflmgomc4 = this.JMFIFLMGOMC;
			PassType passType4 = PassType.Normal;
			string[] array4 = new string[0];
			array4[0] = "OnDailyRewardPopupHide";
			shaderVariantCollection5.Add(new ShaderVariantCollection.ShaderVariant(jmfiflmgomc4, passType4, array4));
			shaderVariantCollection.WarmUp();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
	}

	// Token: 0x0600406D RID: 16493 RVA: 0x001AF17C File Offset: 0x001AD37C
	public bool MAMHHHBKCPK()
	{
		return this.KDIDJHEJFEP != null;
	}

	// Token: 0x0600406E RID: 16494 RVA: 0x001B29B0 File Offset: 0x001B0BB0
	public bool DNJJDJJNNOD()
	{
		bool result;
		try
		{
			if (!EnvironmentMorphManager.IJPNMPKNGNK())
			{
				result = true;
			}
			else
			{
				if (!this.PPBMEBDJNLF)
				{
					this.PPBMEBDJNLF = false;
					this.JMFIFLMGOMC = Resources.Load<Shader>("_Dev");
					if (null == this.JMFIFLMGOMC)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("player");
					}
				}
				if (null == this.JMFIFLMGOMC)
				{
					result = false;
				}
				else if (!this.JMFIFLMGOMC.isSupported)
				{
					result = true;
				}
				else
				{
					this.HBFEBOLKJKA();
					result = false;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x0600406F RID: 16495 RVA: 0x001B2A48 File Offset: 0x001B0C48
	private void JPICJJKMLND()
	{
		this.IPFJBFACKLM = null;
		try
		{
			if (this.KIEOHKKFJFA != null)
			{
				this.KIEOHKKFJFA.Kill(true);
				this.KIEOHKKFJFA = null;
			}
			this.GEJLMKKJKEM();
			this.HFHDJNNONMO();
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
		}
		this.CIEIPCEPEGC = true;
	}

	// Token: 0x06004070 RID: 16496 RVA: 0x001B2AA4 File Offset: 0x001B0CA4
	public bool BPBIINCPFGA()
	{
		bool result;
		try
		{
			if (!EnvironmentMorphManager.LFGGINJDFJE())
			{
				result = false;
			}
			else
			{
				if (!this.PPBMEBDJNLF)
				{
					this.PPBMEBDJNLF = false;
					this.JMFIFLMGOMC = Resources.Load<Shader>("areyousurerestartchapter0");
					if (null == this.JMFIFLMGOMC)
					{
						DPGJIJGOCIC.ANOPFDLPKGC("lck");
					}
				}
				if (null == this.JMFIFLMGOMC)
				{
					result = false;
				}
				else if (!this.JMFIFLMGOMC.isSupported)
				{
					result = false;
				}
				else
				{
					this.GOFJPFDCEIN();
					result = true;
				}
			}
		}
		catch (Exception aklgbjkdomm)
		{
			DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			result = true;
		}
		return result;
	}

	// Token: 0x06004071 RID: 16497 RVA: 0x001B2B3C File Offset: 0x001B0D3C
	private void GJHKFKKLKGK(float KIDHBAMJGDO)
	{
		if (null != this.AOHFLDMHBLA)
		{
			this.AOHFLDMHBLA.SetFloat("spld", KIDHBAMJGDO);
		}
	}

	// Token: 0x04001209 RID: 4617
	private const string IKEPAONHEAM = "ShaderEnvMorphClient";

	// Token: 0x0400120A RID: 4618
	private const int PJLBCBHENHA = 8;

	// Token: 0x0400120B RID: 4619
	private const int CDOICECFMAJ = 1;

	// Token: 0x0400120C RID: 4620
	private const int NCMNLPHGDKO = 128;

	// Token: 0x0400120D RID: 4621
	private const float NPKCBJPJLFO = 0.08f;

	// Token: 0x0400120E RID: 4622
	private const float ILLFIELCLCC = 0.5f;

	// Token: 0x0400120F RID: 4623
	private const float FDENJCCOPLM = 0f;

	// Token: 0x04001210 RID: 4624
	private const float ALLIMHOEGEJ = 0.05f;

	// Token: 0x04001211 RID: 4625
	private const float DOCIEBAPANF = 0.2f;

	// Token: 0x04001212 RID: 4626
	private Shader JMFIFLMGOMC;

	// Token: 0x04001213 RID: 4627
	private bool PPBMEBDJNLF;

	// Token: 0x04001214 RID: 4628
	private bool PLFDMGFOHLA;

	// Token: 0x04001215 RID: 4629
	private Material AOHFLDMHBLA;

	// Token: 0x04001216 RID: 4630
	private Texture2D DCLJEFBHKFA;

	// Token: 0x04001217 RID: 4631
	private RenderTexture LBOBBKDKADL;

	// Token: 0x04001218 RID: 4632
	private Camera GFGDKJIIABF;

	// Token: 0x04001219 RID: 4633
	private EnvCaptureBlit PJDMIAJBJLL;

	// Token: 0x0400121A RID: 4634
	private Camera JPNNMNEJGBD;

	// Token: 0x0400121B RID: 4635
	private Canvas DGEIFFKEDGP;

	// Token: 0x0400121C RID: 4636
	private RawImage KABDJLNLEDE;

	// Token: 0x0400121D RID: 4637
	private bool CIEIPCEPEGC;

	// Token: 0x0400121E RID: 4638
	private Tween IPFJBFACKLM;

	// Token: 0x0400121F RID: 4639
	private Tween KIEOHKKFJFA;

	// Token: 0x04001220 RID: 4640
	private Coroutine KDIDJHEJFEP;

	// Token: 0x04001221 RID: 4641
	private TweenCallback EGDDFGBEKKP;
}
