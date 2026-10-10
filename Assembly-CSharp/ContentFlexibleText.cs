using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000339 RID: 825
public class ContentFlexibleText : MonoBehaviour
{
	// Token: 0x06006224 RID: 25124 RVA: 0x002D2BD4 File Offset: 0x002D0DD4
	private void AIDCNCFKNBJ()
	{
		this.KJEDBDLEDGF.SetText(this.KNCFKDLOPGA, false);
		RectTransform component = this.KJEDBDLEDGF.GetComponent<RectTransform>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(component);
		this.AMLFAFOLDFE = component.rect.width;
		if (this.GIOBIKIBMNC)
		{
			if (this.AMLFAFOLDFE > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				if (this.AAAKFJIAPGJ)
				{
					ContentFlexibleText.LIOBKLLKIIM(this.KJEDBDLEDGF);
				}
			}
		}
		else if (this.AMLFAFOLDFE > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
			if (this.AAAKFJIAPGJ)
			{
				ContentFlexibleText.GHABODNHBEI(this.KJEDBDLEDGF);
			}
		}
		this.KJEDBDLEDGF.GetComponent<HorizontalLayoutGroup>().enabled = false;
		this.KJEDBDLEDGF.GetComponent<ContentSizeFitter>().enabled = false;
	}

	// Token: 0x06006225 RID: 25125 RVA: 0x002D2CB4 File Offset: 0x002D0EB4
	private void DJDCGDDMKEL()
	{
		this.KJEDBDLEDGF.SetText(this.KNCFKDLOPGA, false);
		RectTransform component = this.KJEDBDLEDGF.GetComponent<RectTransform>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(component);
		this.AMLFAFOLDFE = component.rect.width;
		if (this.GIOBIKIBMNC)
		{
			if (this.AMLFAFOLDFE > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				if (this.AAAKFJIAPGJ)
				{
					ContentFlexibleText.KKICLFFALMF(this.KJEDBDLEDGF);
				}
			}
		}
		else if (this.AMLFAFOLDFE > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
			if (this.AAAKFJIAPGJ)
			{
				ContentFlexibleText.LIOBKLLKIIM(this.KJEDBDLEDGF);
			}
		}
		this.KJEDBDLEDGF.GetComponent<HorizontalLayoutGroup>().enabled = false;
		this.KJEDBDLEDGF.GetComponent<ContentSizeFitter>().enabled = false;
	}

	// Token: 0x06006226 RID: 25126 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void OFDKGFIDLBO(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006227 RID: 25127 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void FCPHBNEFHHL(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006228 RID: 25128 RVA: 0x002D2DB4 File Offset: 0x002D0FB4
	public void CHOMJEMBGAG(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x06006229 RID: 25129 RVA: 0x002D2E48 File Offset: 0x002D1048
	public static void BNBJJAOHNJD(TextMeshProUGUI JJNMILAKBAA)
	{
		JJNMILAKBAA.ForceMeshUpdate(false, false);
		if (JJNMILAKBAA.text.Length > 0 && JJNMILAKBAA.textInfo != null)
		{
			int characterCount = JJNMILAKBAA.textInfo.characterCount;
			string text = JJNMILAKBAA.text;
			int length = JJNMILAKBAA.text.Length;
			string text2 = "apc";
			if (length > characterCount)
			{
				text = text.Remove(characterCount - text2.Length);
				int num = text2.Length + 0;
				while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
				{
					text = text.Remove(characterCount - num);
					num += 0;
				}
				text += text2;
				JJNMILAKBAA.text = text;
				JJNMILAKBAA.SetText(text, false);
			}
		}
	}

	// Token: 0x0600622A RID: 25130 RVA: 0x002D2F00 File Offset: 0x002D1100
	private void PMKKOENBNOM()
	{
		this.KJEDBDLEDGF.SetText(this.KNCFKDLOPGA, false);
		RectTransform component = this.KJEDBDLEDGF.GetComponent<RectTransform>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(component);
		this.AMLFAFOLDFE = component.rect.width;
		if (this.GIOBIKIBMNC)
		{
			if (this.AMLFAFOLDFE > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				if (this.AAAKFJIAPGJ)
				{
					ContentFlexibleText.LIOBKLLKIIM(this.KJEDBDLEDGF);
				}
			}
		}
		else if (this.AMLFAFOLDFE > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
			if (this.AAAKFJIAPGJ)
			{
				ContentFlexibleText.KKICLFFALMF(this.KJEDBDLEDGF);
			}
		}
		this.KJEDBDLEDGF.GetComponent<HorizontalLayoutGroup>().enabled = true;
		this.KJEDBDLEDGF.GetComponent<ContentSizeFitter>().enabled = true;
	}

	// Token: 0x0600622B RID: 25131 RVA: 0x002D2FE0 File Offset: 0x002D11E0
	private void LJJJIPGIJJC()
	{
		this.KJEDBDLEDGF.SetText(this.KNCFKDLOPGA, true);
		RectTransform component = this.KJEDBDLEDGF.GetComponent<RectTransform>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(component);
		this.AMLFAFOLDFE = component.rect.width;
		if (this.GIOBIKIBMNC)
		{
			if (this.AMLFAFOLDFE > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				if (this.AAAKFJIAPGJ)
				{
					ContentFlexibleText.EJICHHEPFOA(this.KJEDBDLEDGF);
				}
			}
		}
		else if (this.AMLFAFOLDFE > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
			if (this.AAAKFJIAPGJ)
			{
				ContentFlexibleText.ACLAFJKFFEB(this.KJEDBDLEDGF);
			}
		}
		this.KJEDBDLEDGF.GetComponent<HorizontalLayoutGroup>().enabled = false;
		this.KJEDBDLEDGF.GetComponent<ContentSizeFitter>().enabled = false;
	}

	// Token: 0x0600622C RID: 25132 RVA: 0x002D30C0 File Offset: 0x002D12C0
	public void MFCOFGNPACI(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x0600622D RID: 25133 RVA: 0x002D3154 File Offset: 0x002D1354
	private void EAKEDEEHEDD()
	{
		this.KJEDBDLEDGF.SetText(this.KNCFKDLOPGA, false);
		RectTransform component = this.KJEDBDLEDGF.GetComponent<RectTransform>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(component);
		this.AMLFAFOLDFE = component.rect.width;
		if (this.GIOBIKIBMNC)
		{
			if (this.AMLFAFOLDFE > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				if (this.AAAKFJIAPGJ)
				{
					ContentFlexibleText.NPCKDIEGJCM(this.KJEDBDLEDGF);
				}
			}
		}
		else if (this.AMLFAFOLDFE > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
			if (this.AAAKFJIAPGJ)
			{
				ContentFlexibleText.PMFMNLKAMPB(this.KJEDBDLEDGF);
			}
		}
		this.KJEDBDLEDGF.GetComponent<HorizontalLayoutGroup>().enabled = false;
		this.KJEDBDLEDGF.GetComponent<ContentSizeFitter>().enabled = true;
	}

	// Token: 0x0600622E RID: 25134 RVA: 0x002D3234 File Offset: 0x002D1434
	public void JCKFLKHBOHL(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x0600622F RID: 25135 RVA: 0x002D32C8 File Offset: 0x002D14C8
	public void GMBNAKINKIG(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x06006230 RID: 25136 RVA: 0x002D335C File Offset: 0x002D155C
	private void AOIJOKHACJL()
	{
		this.KJEDBDLEDGF.SetText(this.KNCFKDLOPGA, false);
		RectTransform component = this.KJEDBDLEDGF.GetComponent<RectTransform>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(component);
		this.AMLFAFOLDFE = component.rect.width;
		if (this.GIOBIKIBMNC)
		{
			if (this.AMLFAFOLDFE > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				if (this.AAAKFJIAPGJ)
				{
					ContentFlexibleText.LIOBKLLKIIM(this.KJEDBDLEDGF);
				}
			}
		}
		else if (this.AMLFAFOLDFE > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
			if (this.AAAKFJIAPGJ)
			{
				ContentFlexibleText.PMFMNLKAMPB(this.KJEDBDLEDGF);
			}
		}
		this.KJEDBDLEDGF.GetComponent<HorizontalLayoutGroup>().enabled = true;
		this.KJEDBDLEDGF.GetComponent<ContentSizeFitter>().enabled = true;
	}

	// Token: 0x06006231 RID: 25137 RVA: 0x002D343C File Offset: 0x002D163C
	public static void KKICLFFALMF(TextMeshProUGUI JJNMILAKBAA)
	{
		JJNMILAKBAA.ForceMeshUpdate(false, false);
		if (JJNMILAKBAA.text.Length > 1 && JJNMILAKBAA.textInfo != null)
		{
			int characterCount = JJNMILAKBAA.textInfo.characterCount;
			string text = JJNMILAKBAA.text;
			int length = JJNMILAKBAA.text.Length;
			string text2 = "D";
			if (length > characterCount)
			{
				text = text.Remove(characterCount - text2.Length);
				int num = text2.Length + 0;
				while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
				{
					text = text.Remove(characterCount - num);
					num++;
				}
				text += text2;
				JJNMILAKBAA.text = text;
				JJNMILAKBAA.SetText(text, true);
			}
		}
	}

	// Token: 0x06006232 RID: 25138 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void IIEOANDAGOF(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006233 RID: 25139 RVA: 0x002D34F4 File Offset: 0x002D16F4
	private void JFEKHEIGPJD()
	{
		this.KJEDBDLEDGF.SetText(this.KNCFKDLOPGA, false);
		RectTransform component = this.KJEDBDLEDGF.GetComponent<RectTransform>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(component);
		this.AMLFAFOLDFE = component.rect.width;
		if (this.GIOBIKIBMNC)
		{
			if (this.AMLFAFOLDFE > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				if (this.AAAKFJIAPGJ)
				{
					ContentFlexibleText.AAIBIAMKEFM(this.KJEDBDLEDGF);
				}
			}
		}
		else if (this.AMLFAFOLDFE > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
			if (this.AAAKFJIAPGJ)
			{
				ContentFlexibleText.NPCKDIEGJCM(this.KJEDBDLEDGF);
			}
		}
		this.KJEDBDLEDGF.GetComponent<HorizontalLayoutGroup>().enabled = false;
		this.KJEDBDLEDGF.GetComponent<ContentSizeFitter>().enabled = true;
	}

	// Token: 0x06006234 RID: 25140 RVA: 0x002D35D4 File Offset: 0x002D17D4
	public static void PMFMNLKAMPB(TextMeshProUGUI JJNMILAKBAA)
	{
		JJNMILAKBAA.ForceMeshUpdate(false, true);
		if (JJNMILAKBAA.text.Length > 1 && JJNMILAKBAA.textInfo != null)
		{
			int characterCount = JJNMILAKBAA.textInfo.characterCount;
			string text = JJNMILAKBAA.text;
			int length = JJNMILAKBAA.text.Length;
			string text2 = "@";
			if (length > characterCount)
			{
				text = text.Remove(characterCount - text2.Length);
				int num = text2.Length + 0;
				while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
				{
					text = text.Remove(characterCount - num);
					num++;
				}
				text += text2;
				JJNMILAKBAA.text = text;
				JJNMILAKBAA.SetText(text, true);
			}
		}
	}

	// Token: 0x06006235 RID: 25141 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void OLEHPLMIJMO(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006236 RID: 25142 RVA: 0x002D368C File Offset: 0x002D188C
	public static void OAJJEFGJJMA(TextMeshProUGUI JJNMILAKBAA)
	{
		JJNMILAKBAA.ForceMeshUpdate(false, false);
		if (JJNMILAKBAA.text.Length > 0 && JJNMILAKBAA.textInfo != null)
		{
			int characterCount = JJNMILAKBAA.textInfo.characterCount;
			string text = JJNMILAKBAA.text;
			int length = JJNMILAKBAA.text.Length;
			string text2 = "</i>";
			if (length > characterCount)
			{
				text = text.Remove(characterCount - text2.Length);
				int num = text2.Length + 1;
				while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
				{
					text = text.Remove(characterCount - num);
					num += 0;
				}
				text += text2;
				JJNMILAKBAA.text = text;
				JJNMILAKBAA.SetText(text, false);
			}
		}
	}

	// Token: 0x06006237 RID: 25143 RVA: 0x002D3744 File Offset: 0x002D1944
	public static void EJICHHEPFOA(TextMeshProUGUI JJNMILAKBAA)
	{
		JJNMILAKBAA.ForceMeshUpdate(false, true);
		if (JJNMILAKBAA.text.Length > 1 && JJNMILAKBAA.textInfo != null)
		{
			int characterCount = JJNMILAKBAA.textInfo.characterCount;
			string text = JJNMILAKBAA.text;
			int length = JJNMILAKBAA.text.Length;
			string text2 = "countryCode";
			if (length > characterCount)
			{
				text = text.Remove(characterCount - text2.Length);
				int num = text2.Length + 1;
				while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
				{
					text = text.Remove(characterCount - num);
					num++;
				}
				text += text2;
				JJNMILAKBAA.text = text;
				JJNMILAKBAA.SetText(text, true);
			}
		}
	}

	// Token: 0x06006238 RID: 25144 RVA: 0x002D37FC File Offset: 0x002D19FC
	private void MFPBKLMBANF()
	{
		this.KJEDBDLEDGF.SetText(this.KNCFKDLOPGA, false);
		RectTransform component = this.KJEDBDLEDGF.GetComponent<RectTransform>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(component);
		this.AMLFAFOLDFE = component.rect.width;
		if (this.GIOBIKIBMNC)
		{
			if (this.AMLFAFOLDFE > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				if (this.AAAKFJIAPGJ)
				{
					ContentFlexibleText.OAJJEFGJJMA(this.KJEDBDLEDGF);
				}
			}
		}
		else if (this.AMLFAFOLDFE > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
			if (this.AAAKFJIAPGJ)
			{
				ContentFlexibleText.CICGEOGMDNL(this.KJEDBDLEDGF);
			}
		}
		this.KJEDBDLEDGF.GetComponent<HorizontalLayoutGroup>().enabled = true;
		this.KJEDBDLEDGF.GetComponent<ContentSizeFitter>().enabled = true;
	}

	// Token: 0x06006239 RID: 25145 RVA: 0x002D38DC File Offset: 0x002D1ADC
	public static void CICGEOGMDNL(TextMeshProUGUI JJNMILAKBAA)
	{
		JJNMILAKBAA.ForceMeshUpdate(false, false);
		if (JJNMILAKBAA.text.Length > 0 && JJNMILAKBAA.textInfo != null)
		{
			int characterCount = JJNMILAKBAA.textInfo.characterCount;
			string text = JJNMILAKBAA.text;
			int length = JJNMILAKBAA.text.Length;
			string text2 = "";
			if (length > characterCount)
			{
				text = text.Remove(characterCount - text2.Length);
				int num = text2.Length + 0;
				while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
				{
					text = text.Remove(characterCount - num);
					num += 0;
				}
				text += text2;
				JJNMILAKBAA.text = text;
				JJNMILAKBAA.SetText(text, true);
			}
		}
	}

	// Token: 0x0600623A RID: 25146 RVA: 0x002D3994 File Offset: 0x002D1B94
	public void ADKILDPEBBH(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x0600623B RID: 25147 RVA: 0x002D3A28 File Offset: 0x002D1C28
	public void MFNANICACMF(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x0600623C RID: 25148 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void HHJJGJPIINN(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x0600623D RID: 25149 RVA: 0x002D3ABC File Offset: 0x002D1CBC
	public static void AAIBIAMKEFM(TextMeshProUGUI JJNMILAKBAA)
	{
		JJNMILAKBAA.ForceMeshUpdate(false, false);
		if (JJNMILAKBAA.text.Length > 0 && JJNMILAKBAA.textInfo != null)
		{
			int characterCount = JJNMILAKBAA.textInfo.characterCount;
			string text = JJNMILAKBAA.text;
			int length = JJNMILAKBAA.text.Length;
			string text2 = "Cdn host asset {0} is a {1} host. It must reference a {2} one.";
			if (length > characterCount)
			{
				text = text.Remove(characterCount - text2.Length);
				int num = text2.Length + 1;
				while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
				{
					text = text.Remove(characterCount - num);
					num++;
				}
				text += text2;
				JJNMILAKBAA.text = text;
				JJNMILAKBAA.SetText(text, false);
			}
		}
	}

	// Token: 0x0600623E RID: 25150 RVA: 0x002D3B74 File Offset: 0x002D1D74
	private void IMCHEPFNANC()
	{
		this.KJEDBDLEDGF.SetText(this.KNCFKDLOPGA, true);
		RectTransform component = this.KJEDBDLEDGF.GetComponent<RectTransform>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(component);
		this.AMLFAFOLDFE = component.rect.width;
		if (this.GIOBIKIBMNC)
		{
			if (this.AMLFAFOLDFE > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				if (this.AAAKFJIAPGJ)
				{
					ContentFlexibleText.CICGEOGMDNL(this.KJEDBDLEDGF);
				}
			}
		}
		else if (this.AMLFAFOLDFE > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
			if (this.AAAKFJIAPGJ)
			{
				ContentFlexibleText.KKICLFFALMF(this.KJEDBDLEDGF);
			}
		}
		this.KJEDBDLEDGF.GetComponent<HorizontalLayoutGroup>().enabled = true;
		this.KJEDBDLEDGF.GetComponent<ContentSizeFitter>().enabled = true;
	}

	// Token: 0x0600623F RID: 25151 RVA: 0x002D3C54 File Offset: 0x002D1E54
	public void NBPLAAKGGNB(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x06006240 RID: 25152 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void NONLCDOFDGC(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006241 RID: 25153 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void MPHAHAKMPHH(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006242 RID: 25154 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void GMEBOKAKLCH(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006243 RID: 25155 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void LJOCDMBPLGD(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006244 RID: 25156 RVA: 0x002D3CE8 File Offset: 0x002D1EE8
	public static void GHABODNHBEI(TextMeshProUGUI JJNMILAKBAA)
	{
		JJNMILAKBAA.ForceMeshUpdate(false, false);
		if (JJNMILAKBAA.text.Length > 1 && JJNMILAKBAA.textInfo != null)
		{
			int characterCount = JJNMILAKBAA.textInfo.characterCount;
			string text = JJNMILAKBAA.text;
			int length = JJNMILAKBAA.text.Length;
			string text2 = "</i>";
			if (length > characterCount)
			{
				text = text.Remove(characterCount - text2.Length);
				int num = text2.Length + 0;
				while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
				{
					text = text.Remove(characterCount - num);
					num += 0;
				}
				text += text2;
				JJNMILAKBAA.text = text;
				JJNMILAKBAA.SetText(text, true);
			}
		}
	}

	// Token: 0x06006245 RID: 25157 RVA: 0x002D3DA0 File Offset: 0x002D1FA0
	private void DDMCLNDOHCK()
	{
		this.KJEDBDLEDGF.SetText(this.KNCFKDLOPGA, true);
		RectTransform component = this.KJEDBDLEDGF.GetComponent<RectTransform>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(component);
		this.AMLFAFOLDFE = component.rect.width;
		if (this.GIOBIKIBMNC)
		{
			if (this.AMLFAFOLDFE > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				if (this.AAAKFJIAPGJ)
				{
					ContentFlexibleText.NPJBIKEGKJJ(this.KJEDBDLEDGF);
				}
			}
		}
		else if (this.AMLFAFOLDFE > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
			if (this.AAAKFJIAPGJ)
			{
				ContentFlexibleText.EJICHHEPFOA(this.KJEDBDLEDGF);
			}
		}
		this.KJEDBDLEDGF.GetComponent<HorizontalLayoutGroup>().enabled = true;
		this.KJEDBDLEDGF.GetComponent<ContentSizeFitter>().enabled = true;
	}

	// Token: 0x06006246 RID: 25158 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void FMLNBONKICH(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006247 RID: 25159 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void SetText(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006248 RID: 25160 RVA: 0x002D3E80 File Offset: 0x002D2080
	public static void NPCKDIEGJCM(TextMeshProUGUI JJNMILAKBAA)
	{
		JJNMILAKBAA.ForceMeshUpdate(false, false);
		if (JJNMILAKBAA.text.Length > 1 && JJNMILAKBAA.textInfo != null)
		{
			int characterCount = JJNMILAKBAA.textInfo.characterCount;
			string text = JJNMILAKBAA.text;
			int length = JJNMILAKBAA.text.Length;
			string text2 = "spinres";
			if (length > characterCount)
			{
				text = text.Remove(characterCount - text2.Length);
				int num = text2.Length + 0;
				while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
				{
					text = text.Remove(characterCount - num);
					num++;
				}
				text += text2;
				JJNMILAKBAA.text = text;
				JJNMILAKBAA.SetText(text, false);
			}
		}
	}

	// Token: 0x06006249 RID: 25161 RVA: 0x002D3F38 File Offset: 0x002D2138
	public void ResizeTextRect(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x0600624A RID: 25162 RVA: 0x002D3FCC File Offset: 0x002D21CC
	public void EGOELFOKLCK(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x0600624B RID: 25163 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void IBMKOAKBPLB(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x0600624C RID: 25164 RVA: 0x002D4060 File Offset: 0x002D2260
	public void FOBADHFFEAI(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x0600624E RID: 25166 RVA: 0x002D4114 File Offset: 0x002D2314
	private void CJPNMBNKLOO()
	{
		this.KJEDBDLEDGF.SetText(this.KNCFKDLOPGA, true);
		RectTransform component = this.KJEDBDLEDGF.GetComponent<RectTransform>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(component);
		this.AMLFAFOLDFE = component.rect.width;
		if (this.GIOBIKIBMNC)
		{
			if (this.AMLFAFOLDFE > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				if (this.AAAKFJIAPGJ)
				{
					ContentFlexibleText.CICGEOGMDNL(this.KJEDBDLEDGF);
				}
			}
		}
		else if (this.AMLFAFOLDFE > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
			if (this.AAAKFJIAPGJ)
			{
				ContentFlexibleText.OAJJEFGJJMA(this.KJEDBDLEDGF);
			}
		}
		this.KJEDBDLEDGF.GetComponent<HorizontalLayoutGroup>().enabled = false;
		this.KJEDBDLEDGF.GetComponent<ContentSizeFitter>().enabled = true;
	}

	// Token: 0x0600624F RID: 25167 RVA: 0x002D41F4 File Offset: 0x002D23F4
	private void Start()
	{
		this.KJEDBDLEDGF.SetText(this.KNCFKDLOPGA, true);
		RectTransform component = this.KJEDBDLEDGF.GetComponent<RectTransform>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(component);
		this.AMLFAFOLDFE = component.rect.width;
		if (this.GIOBIKIBMNC)
		{
			if (this.AMLFAFOLDFE > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				if (this.AAAKFJIAPGJ)
				{
					ContentFlexibleText.AddThreePointsAtTheEndOfVisibleText(this.KJEDBDLEDGF);
				}
			}
		}
		else if (this.AMLFAFOLDFE > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
			if (this.AAAKFJIAPGJ)
			{
				ContentFlexibleText.AddThreePointsAtTheEndOfVisibleText(this.KJEDBDLEDGF);
			}
		}
		this.KJEDBDLEDGF.GetComponent<HorizontalLayoutGroup>().enabled = false;
		this.KJEDBDLEDGF.GetComponent<ContentSizeFitter>().enabled = false;
	}

	// Token: 0x06006250 RID: 25168 RVA: 0x002D42D4 File Offset: 0x002D24D4
	public void INMLOKDCMCO(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x06006251 RID: 25169 RVA: 0x002D4368 File Offset: 0x002D2568
	public static void LIOBKLLKIIM(TextMeshProUGUI JJNMILAKBAA)
	{
		JJNMILAKBAA.ForceMeshUpdate(true, true);
		if (JJNMILAKBAA.text.Length > 1 && JJNMILAKBAA.textInfo != null)
		{
			int characterCount = JJNMILAKBAA.textInfo.characterCount;
			string text = JJNMILAKBAA.text;
			int length = JJNMILAKBAA.text.Length;
			string text2 = "x";
			if (length > characterCount)
			{
				text = text.Remove(characterCount - text2.Length);
				int num = text2.Length + 0;
				while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
				{
					text = text.Remove(characterCount - num);
					num += 0;
				}
				text += text2;
				JJNMILAKBAA.text = text;
				JJNMILAKBAA.SetText(text, true);
			}
		}
	}

	// Token: 0x06006252 RID: 25170 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void KEJEHBDACGO(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006253 RID: 25171 RVA: 0x002D4420 File Offset: 0x002D2620
	public void BAJGDJHPOCI(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x06006254 RID: 25172 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void APBEENNCIPE(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006255 RID: 25173 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void DIBEKEKFEHK(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006256 RID: 25174 RVA: 0x002D44B4 File Offset: 0x002D26B4
	public void FAAPKMLNCLG(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x06006257 RID: 25175 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void PACBMMDOAOB(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006258 RID: 25176 RVA: 0x002D4548 File Offset: 0x002D2748
	public void HMCPLPDJDCK(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x06006259 RID: 25177 RVA: 0x002D45DC File Offset: 0x002D27DC
	private void GANNEJBHDIM()
	{
		this.KJEDBDLEDGF.SetText(this.KNCFKDLOPGA, true);
		RectTransform component = this.KJEDBDLEDGF.GetComponent<RectTransform>();
		LayoutRebuilder.ForceRebuildLayoutImmediate(component);
		this.AMLFAFOLDFE = component.rect.width;
		if (this.GIOBIKIBMNC)
		{
			if (this.AMLFAFOLDFE > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				if (this.AAAKFJIAPGJ)
				{
					ContentFlexibleText.PMFMNLKAMPB(this.KJEDBDLEDGF);
				}
			}
		}
		else if (this.AMLFAFOLDFE > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
			if (this.AAAKFJIAPGJ)
			{
				ContentFlexibleText.CICGEOGMDNL(this.KJEDBDLEDGF);
			}
		}
		this.KJEDBDLEDGF.GetComponent<HorizontalLayoutGroup>().enabled = false;
		this.KJEDBDLEDGF.GetComponent<ContentSizeFitter>().enabled = true;
	}

	// Token: 0x0600625A RID: 25178 RVA: 0x002D46BC File Offset: 0x002D28BC
	public static void ACLAFJKFFEB(TextMeshProUGUI JJNMILAKBAA)
	{
		JJNMILAKBAA.ForceMeshUpdate(false, true);
		if (JJNMILAKBAA.text.Length > 0 && JJNMILAKBAA.textInfo != null)
		{
			int characterCount = JJNMILAKBAA.textInfo.characterCount;
			string text = JJNMILAKBAA.text;
			int length = JJNMILAKBAA.text.Length;
			string text2 = "OnStoryInterfaceFastForwardActivate";
			if (length > characterCount)
			{
				text = text.Remove(characterCount - text2.Length);
				int num = text2.Length + 0;
				while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
				{
					text = text.Remove(characterCount - num);
					num++;
				}
				text += text2;
				JJNMILAKBAA.text = text;
				JJNMILAKBAA.SetText(text, true);
			}
		}
	}

	// Token: 0x0600625B RID: 25179 RVA: 0x002D4774 File Offset: 0x002D2974
	public void FFHOFPMJOFG(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x0600625C RID: 25180 RVA: 0x002D4808 File Offset: 0x002D2A08
	public static void AddThreePointsAtTheEndOfVisibleText(TextMeshProUGUI JJNMILAKBAA)
	{
		JJNMILAKBAA.ForceMeshUpdate(false, false);
		if (JJNMILAKBAA.text.Length > 0 && JJNMILAKBAA.textInfo != null)
		{
			int characterCount = JJNMILAKBAA.textInfo.characterCount;
			string text = JJNMILAKBAA.text;
			int length = JJNMILAKBAA.text.Length;
			string text2 = "...";
			if (length > characterCount)
			{
				text = text.Remove(characterCount - text2.Length);
				int num = text2.Length + 1;
				while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
				{
					text = text.Remove(characterCount - num);
					num++;
				}
				text += text2;
				JJNMILAKBAA.text = text;
				JJNMILAKBAA.SetText(text, true);
			}
		}
	}

	// Token: 0x0600625D RID: 25181 RVA: 0x002D48C0 File Offset: 0x002D2AC0
	public void BEBABHKMLDL(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x0600625E RID: 25182 RVA: 0x002D4954 File Offset: 0x002D2B54
	public void KNDELMDPPFD(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x0600625F RID: 25183 RVA: 0x002D49E8 File Offset: 0x002D2BE8
	public static void NPJBIKEGKJJ(TextMeshProUGUI JJNMILAKBAA)
	{
		JJNMILAKBAA.ForceMeshUpdate(true, true);
		if (JJNMILAKBAA.text.Length > 1 && JJNMILAKBAA.textInfo != null)
		{
			int characterCount = JJNMILAKBAA.textInfo.characterCount;
			string text = JJNMILAKBAA.text;
			int length = JJNMILAKBAA.text.Length;
			string text2 = "FranchisesHub.Populate() - fid ";
			if (length > characterCount)
			{
				text = text.Remove(characterCount - text2.Length);
				int num = text2.Length + 0;
				while (char.IsPunctuation(text[characterCount - num]) || char.IsWhiteSpace(text[characterCount - num]))
				{
					text = text.Remove(characterCount - num);
					num += 0;
				}
				text += text2;
				JJNMILAKBAA.text = text;
				JJNMILAKBAA.SetText(text, true);
			}
		}
	}

	// Token: 0x06006260 RID: 25184 RVA: 0x002D4AA0 File Offset: 0x002D2CA0
	public void LPDFHENBPOO(bool CPOKMEFCGCN)
	{
		this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.AMLFAFOLDFE);
		if (CPOKMEFCGCN)
		{
			if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthOnActiveIcon)
			{
				this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthOnActiveIcon);
				return;
			}
		}
		else if (this.KJEDBDLEDGF.GetComponent<RectTransform>().rect.width > this.maxNameWidthDefault)
		{
			this.KJEDBDLEDGF.GetComponent<RectTransform>().EFOCKEJENAC(this.maxNameWidthDefault);
		}
	}

	// Token: 0x06006261 RID: 25185 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void DMJGOBJBCBK(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x06006262 RID: 25186 RVA: 0x002D2D93 File Offset: 0x002D0F93
	public void CEKNPBODPLC(TextMeshProUGUI KJEDBDLEDGF, string KNCFKDLOPGA, bool GIOBIKIBMNC, bool AAAKFJIAPGJ = false)
	{
		this.KJEDBDLEDGF = KJEDBDLEDGF;
		this.KNCFKDLOPGA = KNCFKDLOPGA;
		this.GIOBIKIBMNC = GIOBIKIBMNC;
		this.AAAKFJIAPGJ = AAAKFJIAPGJ;
	}

	// Token: 0x04001C88 RID: 7304
	private float AMLFAFOLDFE;

	// Token: 0x04001C89 RID: 7305
	public float maxNameWidthDefault = 205f;

	// Token: 0x04001C8A RID: 7306
	public float maxNameWidthOnActiveIcon = 175f;

	// Token: 0x04001C8B RID: 7307
	private TextMeshProUGUI KJEDBDLEDGF;

	// Token: 0x04001C8C RID: 7308
	private string KNCFKDLOPGA;

	// Token: 0x04001C8D RID: 7309
	private bool GIOBIKIBMNC;

	// Token: 0x04001C8E RID: 7310
	private bool AAAKFJIAPGJ;
}
