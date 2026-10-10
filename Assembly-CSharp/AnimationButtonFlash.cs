using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000198 RID: 408
public class AnimationButtonFlash : MonoBehaviour
{
	// Token: 0x0600312F RID: 12591 RVA: 0x0014E703 File Offset: 0x0014C903
	private void OnDestroy()
	{
		if (this.EDNOMPCIPNI != null)
		{
			base.StopCoroutine(this.EDNOMPCIPNI);
			this.EDNOMPCIPNI = null;
		}
	}

	// Token: 0x06003130 RID: 12592 RVA: 0x0014E720 File Offset: 0x0014C920
	public void KDOGEJLNHHK()
	{
		if (null != this.EKAPJKKPPGG)
		{
			this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
		}
	}

	// Token: 0x06003131 RID: 12593 RVA: 0x0014E746 File Offset: 0x0014C946
	public void PCEHFHIGAEN()
	{
		if (null != this.EKAPJKKPPGG)
		{
			this.EKAPJKKPPGG.image.sprite = this.PMLHKMHOIOF;
		}
	}

	// Token: 0x06003132 RID: 12594 RVA: 0x0014E76C File Offset: 0x0014C96C
	private void OnEnable()
	{
		if (this.playAnimationOnEnable)
		{
			this.BFNALMBLDMK = this.idleTime + 1f;
		}
	}

	// Token: 0x06003133 RID: 12595 RVA: 0x0014E788 File Offset: 0x0014C988
	private void DJDLHIOMGJB()
	{
		if (this.playAnimationOnEnable)
		{
			this.BFNALMBLDMK = this.idleTime + 1405f;
		}
	}

	// Token: 0x06003134 RID: 12596 RVA: 0x0014E7A4 File Offset: 0x0014C9A4
	public void StopFlashAnimation()
	{
		this.BFNALMBLDMK = 0f;
		this.EJJDOBBGBBC = false;
		if (null != this.EKAPJKKPPGG)
		{
			this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
		}
	}

	// Token: 0x06003135 RID: 12597 RVA: 0x0014E7DC File Offset: 0x0014C9DC
	public void NOMFEFKDHLD()
	{
		this.BFNALMBLDMK = 1429f;
		this.EJJDOBBGBBC = false;
		if (null != this.EKAPJKKPPGG)
		{
			this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
		}
	}

	// Token: 0x06003136 RID: 12598 RVA: 0x0014E746 File Offset: 0x0014C946
	public void SetHighlightedSprite()
	{
		if (null != this.EKAPJKKPPGG)
		{
			this.EKAPJKKPPGG.image.sprite = this.PMLHKMHOIOF;
		}
	}

	// Token: 0x06003137 RID: 12599 RVA: 0x0014E814 File Offset: 0x0014CA14
	private void DDMCLNDOHCK()
	{
		this.EKAPJKKPPGG = base.gameObject.GetComponent<Button>();
		this.BIMGNFJBENN = this.EKAPJKKPPGG.image.sprite;
		this.PMLHKMHOIOF = this.EKAPJKKPPGG.spriteState.highlightedSprite;
	}

	// Token: 0x06003138 RID: 12600 RVA: 0x0014E861 File Offset: 0x0014CA61
	public void IBLPAAGIJIH()
	{
		this.BFNALMBLDMK = 613f;
		this.EJJDOBBGBBC = false;
		if (null != this.EKAPJKKPPGG)
		{
			this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
		}
	}

	// Token: 0x06003139 RID: 12601 RVA: 0x0014E703 File Offset: 0x0014C903
	private void MFINONMBMLM()
	{
		if (this.EDNOMPCIPNI != null)
		{
			base.StopCoroutine(this.EDNOMPCIPNI);
			this.EDNOMPCIPNI = null;
		}
	}

	// Token: 0x0600313A RID: 12602 RVA: 0x0014E899 File Offset: 0x0014CA99
	private void EFIBBLFAMGD()
	{
		if (this.playAnimationOnEnable)
		{
			this.BFNALMBLDMK = this.idleTime + 1529f;
		}
	}

	// Token: 0x0600313B RID: 12603 RVA: 0x0014E8B8 File Offset: 0x0014CAB8
	private void KPCLFGJLNJF()
	{
		if (null != this.EKAPJKKPPGG && this.EJJDOBBGBBC)
		{
			this.BFNALMBLDMK += Time.deltaTime;
			if (this.BFNALMBLDMK > this.idleTime && this.EKAPJKKPPGG.interactable)
			{
				this.BFNALMBLDMK = 1691f;
				this.EDNOMPCIPNI = base.StartCoroutine(this.LNEBFCHMHHB());
			}
		}
	}

	// Token: 0x0600313C RID: 12604 RVA: 0x0014E928 File Offset: 0x0014CB28
	private void Update()
	{
		if (null != this.EKAPJKKPPGG && this.EJJDOBBGBBC)
		{
			this.BFNALMBLDMK += Time.deltaTime;
			if (this.BFNALMBLDMK > this.idleTime && this.EKAPJKKPPGG.interactable)
			{
				this.BFNALMBLDMK = 0f;
				this.EDNOMPCIPNI = base.StartCoroutine(this.CFGFAEIONCA());
			}
		}
	}

	// Token: 0x0600313D RID: 12605 RVA: 0x0014E720 File Offset: 0x0014C920
	public void LLLGNOACALC()
	{
		if (null != this.EKAPJKKPPGG)
		{
			this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
		}
	}

	// Token: 0x0600313E RID: 12606 RVA: 0x0014E746 File Offset: 0x0014C946
	public void ECBGECBIBPJ()
	{
		if (null != this.EKAPJKKPPGG)
		{
			this.EKAPJKKPPGG.image.sprite = this.PMLHKMHOIOF;
		}
	}

	// Token: 0x0600313F RID: 12607 RVA: 0x0014E995 File Offset: 0x0014CB95
	private IEnumerator PHJDKHHCBKE()
	{
		AnimationButtonFlash.HDGJNNAECJD hdgjnnaecjd = new AnimationButtonFlash.HDGJNNAECJD(1);
		hdgjnnaecjd.<>4__this = this;
		return hdgjnnaecjd;
	}

	// Token: 0x06003140 RID: 12608 RVA: 0x0014E9A4 File Offset: 0x0014CBA4
	private void MIEEIOCPCNL()
	{
		if (this.EDNOMPCIPNI != null)
		{
			base.StopCoroutine(this.EDNOMPCIPNI);
			if (null != this.EKAPJKKPPGG)
			{
				this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
			}
			this.EDNOMPCIPNI = null;
		}
	}

	// Token: 0x06003141 RID: 12609 RVA: 0x0014E9F0 File Offset: 0x0014CBF0
	private void IGFOJLEMDAN()
	{
		if (null != this.EKAPJKKPPGG && this.EJJDOBBGBBC)
		{
			this.BFNALMBLDMK += Time.deltaTime;
			if (this.BFNALMBLDMK > this.idleTime && this.EKAPJKKPPGG.interactable)
			{
				this.BFNALMBLDMK = 667f;
				this.EDNOMPCIPNI = base.StartCoroutine(this.CFGFAEIONCA());
			}
		}
	}

	// Token: 0x06003143 RID: 12611 RVA: 0x0014EA69 File Offset: 0x0014CC69
	private IEnumerator CFGFAEIONCA()
	{
		int num;
		for (int i = 0; i < this.flashCount; i = num + 1)
		{
			this.EKAPJKKPPGG.image.sprite = this.PMLHKMHOIOF;
			if (this.otherComponentsToSync != null)
			{
				for (int j = 0; j < this.otherComponentsToSync.Count; j++)
				{
					if (null != this.otherComponentsToSync[j])
					{
						this.otherComponentsToSync[j].SetHighlightedSprite();
					}
				}
			}
			yield return new WaitForSeconds(this.flashTime);
			this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
			if (this.otherComponentsToSync != null)
			{
				for (int k = 0; k < this.otherComponentsToSync.Count; k++)
				{
					if (null != this.otherComponentsToSync[k])
					{
						this.otherComponentsToSync[k].SetIdleSprite();
					}
				}
			}
			yield return new WaitForSeconds(this.flashTime);
			num = i;
		}
		this.BFNALMBLDMK = 0f;
		yield break;
	}

	// Token: 0x06003144 RID: 12612 RVA: 0x0014EA69 File Offset: 0x0014CC69
	private IEnumerator KMEOKNHHKOP()
	{
		int num;
		for (i = 0; i < this.flashCount; i = num + 1)
		{
			this.EKAPJKKPPGG.image.sprite = this.PMLHKMHOIOF;
			if (this.otherComponentsToSync != null)
			{
				for (int j = 0; j < this.otherComponentsToSync.Count; j++)
				{
					if (null != this.otherComponentsToSync[j])
					{
						this.otherComponentsToSync[j].SetHighlightedSprite();
					}
				}
			}
			yield return new WaitForSeconds(this.flashTime);
			this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
			if (this.otherComponentsToSync != null)
			{
				for (int k = 0; k < this.otherComponentsToSync.Count; k++)
				{
					if (null != this.otherComponentsToSync[k])
					{
						this.otherComponentsToSync[k].SetIdleSprite();
					}
				}
			}
			yield return new WaitForSeconds(this.flashTime);
			num = i;
		}
		this.BFNALMBLDMK = 0f;
		yield break;
	}

	// Token: 0x06003145 RID: 12613 RVA: 0x0014EA78 File Offset: 0x0014CC78
	public void RestartFlashAnimation()
	{
		this.BFNALMBLDMK = 0f;
		this.EJJDOBBGBBC = true;
		if (null != this.EKAPJKKPPGG)
		{
			this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
		}
	}

	// Token: 0x06003146 RID: 12614 RVA: 0x0014EAB0 File Offset: 0x0014CCB0
	private void FDFMDEOMJBH()
	{
		this.EKAPJKKPPGG = base.gameObject.GetComponent<Button>();
		this.BIMGNFJBENN = this.EKAPJKKPPGG.image.sprite;
		this.PMLHKMHOIOF = this.EKAPJKKPPGG.spriteState.highlightedSprite;
	}

	// Token: 0x06003147 RID: 12615 RVA: 0x0014EB00 File Offset: 0x0014CD00
	private void KGMBFKBNDPJ()
	{
		this.EKAPJKKPPGG = base.gameObject.GetComponent<Button>();
		this.BIMGNFJBENN = this.EKAPJKKPPGG.image.sprite;
		this.PMLHKMHOIOF = this.EKAPJKKPPGG.spriteState.highlightedSprite;
	}

	// Token: 0x06003148 RID: 12616 RVA: 0x0014E703 File Offset: 0x0014C903
	private void DMGCMLIGFCG()
	{
		if (this.EDNOMPCIPNI != null)
		{
			base.StopCoroutine(this.EDNOMPCIPNI);
			this.EDNOMPCIPNI = null;
		}
	}

	// Token: 0x06003149 RID: 12617 RVA: 0x0014EB50 File Offset: 0x0014CD50
	private void KJNLBAEHLEI()
	{
		if (null != this.EKAPJKKPPGG && this.EJJDOBBGBBC)
		{
			this.BFNALMBLDMK += Time.deltaTime;
			if (this.BFNALMBLDMK > this.idleTime && this.EKAPJKKPPGG.interactable)
			{
				this.BFNALMBLDMK = 295f;
				this.EDNOMPCIPNI = base.StartCoroutine(this.LNEBFCHMHHB());
			}
		}
	}

	// Token: 0x0600314A RID: 12618 RVA: 0x0014E720 File Offset: 0x0014C920
	public void SetIdleSprite()
	{
		if (null != this.EKAPJKKPPGG)
		{
			this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
		}
	}

	// Token: 0x0600314B RID: 12619 RVA: 0x0014EBBD File Offset: 0x0014CDBD
	private void JJIGCFGKFHO()
	{
		if (this.playAnimationOnEnable)
		{
			this.BFNALMBLDMK = this.idleTime + 1545f;
		}
	}

	// Token: 0x0600314C RID: 12620 RVA: 0x0014E703 File Offset: 0x0014C903
	private void CFHFGNOIPEC()
	{
		if (this.EDNOMPCIPNI != null)
		{
			base.StopCoroutine(this.EDNOMPCIPNI);
			this.EDNOMPCIPNI = null;
		}
	}

	// Token: 0x0600314D RID: 12621 RVA: 0x0014E720 File Offset: 0x0014C920
	public void LDIBOOFLADH()
	{
		if (null != this.EKAPJKKPPGG)
		{
			this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
		}
	}

	// Token: 0x0600314E RID: 12622 RVA: 0x0014EA69 File Offset: 0x0014CC69
	private IEnumerator MCOMKPBAHHA()
	{
		int num;
		for (i = 0; i < this.flashCount; i = num + 1)
		{
			this.EKAPJKKPPGG.image.sprite = this.PMLHKMHOIOF;
			if (this.otherComponentsToSync != null)
			{
				for (int j = 0; j < this.otherComponentsToSync.Count; j++)
				{
					if (null != this.otherComponentsToSync[j])
					{
						this.otherComponentsToSync[j].SetHighlightedSprite();
					}
				}
			}
			yield return new WaitForSeconds(this.flashTime);
			this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
			if (this.otherComponentsToSync != null)
			{
				for (int k = 0; k < this.otherComponentsToSync.Count; k++)
				{
					if (null != this.otherComponentsToSync[k])
					{
						this.otherComponentsToSync[k].SetIdleSprite();
					}
				}
			}
			yield return new WaitForSeconds(this.flashTime);
			num = i;
		}
		this.BFNALMBLDMK = 0f;
		yield break;
	}

	// Token: 0x0600314F RID: 12623 RVA: 0x0014E746 File Offset: 0x0014C946
	public void BLHONGGKPJD()
	{
		if (null != this.EKAPJKKPPGG)
		{
			this.EKAPJKKPPGG.image.sprite = this.PMLHKMHOIOF;
		}
	}

	// Token: 0x06003151 RID: 12625 RVA: 0x0014EC08 File Offset: 0x0014CE08
	private void MJBIDAKAFEN()
	{
		if (null != this.EKAPJKKPPGG && this.EJJDOBBGBBC)
		{
			this.BFNALMBLDMK += Time.deltaTime;
			if (this.BFNALMBLDMK > this.idleTime && this.EKAPJKKPPGG.interactable)
			{
				this.BFNALMBLDMK = 1510f;
				this.EDNOMPCIPNI = base.StartCoroutine(this.CFGFAEIONCA());
			}
		}
	}

	// Token: 0x06003152 RID: 12626 RVA: 0x0014EC78 File Offset: 0x0014CE78
	private void OnDisable()
	{
		if (this.EDNOMPCIPNI != null)
		{
			base.StopCoroutine(this.EDNOMPCIPNI);
			if (null != this.EKAPJKKPPGG)
			{
				this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
			}
			this.EDNOMPCIPNI = null;
		}
	}

	// Token: 0x06003153 RID: 12627 RVA: 0x0014E703 File Offset: 0x0014C903
	private void CJAFGKPFPAA()
	{
		if (this.EDNOMPCIPNI != null)
		{
			base.StopCoroutine(this.EDNOMPCIPNI);
			this.EDNOMPCIPNI = null;
		}
	}

	// Token: 0x06003154 RID: 12628 RVA: 0x0014ECC4 File Offset: 0x0014CEC4
	private void BHHNFCEKGCP()
	{
		if (this.playAnimationOnEnable)
		{
			this.BFNALMBLDMK = this.idleTime + 1118f;
		}
	}

	// Token: 0x06003155 RID: 12629 RVA: 0x0014ECE0 File Offset: 0x0014CEE0
	private void Start()
	{
		this.EKAPJKKPPGG = base.gameObject.GetComponent<Button>();
		this.BIMGNFJBENN = this.EKAPJKKPPGG.image.sprite;
		this.PMLHKMHOIOF = this.EKAPJKKPPGG.spriteState.highlightedSprite;
	}

	// Token: 0x06003156 RID: 12630 RVA: 0x0014EA69 File Offset: 0x0014CC69
	private IEnumerator LNEBFCHMHHB()
	{
		int num;
		for (i = 0; i < this.flashCount; i = num + 1)
		{
			this.EKAPJKKPPGG.image.sprite = this.PMLHKMHOIOF;
			if (this.otherComponentsToSync != null)
			{
				for (int j = 0; j < this.otherComponentsToSync.Count; j++)
				{
					if (null != this.otherComponentsToSync[j])
					{
						this.otherComponentsToSync[j].SetHighlightedSprite();
					}
				}
			}
			yield return new WaitForSeconds(this.flashTime);
			this.EKAPJKKPPGG.image.sprite = this.BIMGNFJBENN;
			if (this.otherComponentsToSync != null)
			{
				for (int k = 0; k < this.otherComponentsToSync.Count; k++)
				{
					if (null != this.otherComponentsToSync[k])
					{
						this.otherComponentsToSync[k].SetIdleSprite();
					}
				}
			}
			yield return new WaitForSeconds(this.flashTime);
			num = i;
		}
		this.BFNALMBLDMK = 0f;
		yield break;
	}

	// Token: 0x04000F6B RID: 3947
	public static readonly string _flickerSeed = "gnN0WpMJk+tpXLwSkabw8w2cF8qEBlPEl4VCcX35Cn2ygkZ/Wf4m5Djn1ZdGwNeNgFN/H";

	// Token: 0x04000F6C RID: 3948
	public float idleTime = 3f;

	// Token: 0x04000F6D RID: 3949
	public float flashTime = 0.15f;

	// Token: 0x04000F6E RID: 3950
	public int flashCount = 3;

	// Token: 0x04000F6F RID: 3951
	public bool playAnimationOnEnable;

	// Token: 0x04000F70 RID: 3952
	public List<AnimationButtonFlash> otherComponentsToSync;

	// Token: 0x04000F71 RID: 3953
	private float BFNALMBLDMK;

	// Token: 0x04000F72 RID: 3954
	private Button EKAPJKKPPGG;

	// Token: 0x04000F73 RID: 3955
	private Sprite BIMGNFJBENN;

	// Token: 0x04000F74 RID: 3956
	private Sprite PMLHKMHOIOF;

	// Token: 0x04000F75 RID: 3957
	private bool EJJDOBBGBBC = true;

	// Token: 0x04000F76 RID: 3958
	private Coroutine EDNOMPCIPNI;
}
