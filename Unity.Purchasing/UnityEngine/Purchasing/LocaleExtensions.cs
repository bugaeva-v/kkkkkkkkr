using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000B3 RID: 179
	public static class LocaleExtensions
	{
		// Token: 0x06000328 RID: 808 RVA: 0x00007894 File Offset: 0x00005A94
		public static string[] GetLabelsWithSupportedPlatforms()
		{
			if (LocaleExtensions.LabelsWithSupportedPlatforms != null)
			{
				return LocaleExtensions.LabelsWithSupportedPlatforms;
			}
			LocaleExtensions.LabelsWithSupportedPlatforms = new string[Enum.GetValues(typeof(TranslationLocale)).Length];
			List<TranslationLocale> list = LocaleExtensions.GoogleLocales.ToList<TranslationLocale>();
			List<TranslationLocale> list2 = LocaleExtensions.AppleLocales.ToList<TranslationLocale>();
			int num = 0;
			foreach (object obj in Enum.GetValues(typeof(TranslationLocale)))
			{
				TranslationLocale item = (TranslationLocale)obj;
				List<string> list3 = new List<string>();
				if (list.Contains(item))
				{
					list3.Add("Google Play");
				}
				if (list2.Contains(item))
				{
					list3.Add("Apple");
				}
				string str = string.Join(", ", list3.ToArray());
				LocaleExtensions.LabelsWithSupportedPlatforms[num] = LocaleExtensions.Labels[num] + " (" + str + ")";
				num++;
			}
			return LocaleExtensions.LabelsWithSupportedPlatforms;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000079A4 File Offset: 0x00005BA4
		public static bool SupportedOnApple(this TranslationLocale locale)
		{
			return LocaleExtensions.AppleLocales.Contains(locale);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000079B1 File Offset: 0x00005BB1
		public static bool SupportedOnGoogle(this TranslationLocale locale)
		{
			return LocaleExtensions.GoogleLocales.Contains(locale);
		}

		// Token: 0x0400014B RID: 331
		private static readonly string[] Labels = new string[]
		{
			"Afrikaans",
			"Albanian",
			"Amharic",
			"Arabic",
			"Armenian",
			"Azerbaijani",
			"Bangla",
			"Basque",
			"Belarusian",
			"Bulgarian",
			"Burmese",
			"Catalan",
			"Chinese (Hong Kong)",
			"Chinese (Simplified)",
			"Chinese (Traditional)",
			"Croatian",
			"Czech",
			"Danish",
			"Dutch",
			"English (Australia)",
			"English (Canada)",
			"English (United States)",
			"English (United Kingdom)",
			"English",
			"English",
			"English",
			"Estonian",
			"Filipino",
			"Finnish",
			"French (Canada)",
			"French (France)",
			"Galician",
			"Georgian",
			"German",
			"Greek",
			"Gujarati",
			"Hebrew",
			"Hindi",
			"Hungarian",
			"Icelandic",
			"Indonesian",
			"Italian",
			"Japanese",
			"Kannada",
			"Kazakh",
			"Khmer",
			"Korean",
			"Kyrgyz",
			"Lao",
			"Latvian",
			"Lithuanian",
			"Macedonian",
			"Malay (Malaysia)",
			"Malay",
			"Malayalam",
			"Marathi",
			"Mongolian",
			"Nepali",
			"Norwegian",
			"Persian",
			"Persian",
			"Persian",
			"Persian",
			"Polish",
			"Portuguese (Brazil)",
			"Portuguese (Portugal)",
			"Punjabi",
			"Romanian",
			"Romansh",
			"Russian",
			"Serbian",
			"Sinhala",
			"Slovak",
			"Slovenian",
			"Spanish (Latin America)",
			"Spanish (Spain)",
			"Spanish (Mexico)",
			"Spanish (United States)",
			"Swahili",
			"Swedish",
			"Tamil",
			"Telugu",
			"Thai",
			"Turkish",
			"Ukrainian",
			"Urdu",
			"Vietnamese",
			"Zulu"
		};

		// Token: 0x0400014C RID: 332
		private static readonly TranslationLocale[] GoogleLocales = new TranslationLocale[]
		{
			TranslationLocale.af_ZA,
			TranslationLocale.sq_SQ,
			TranslationLocale.am_ET,
			TranslationLocale.ar_AE,
			TranslationLocale.hy_AM,
			TranslationLocale.az_AZ,
			TranslationLocale.bn_BD,
			TranslationLocale.eu_ES,
			TranslationLocale.be_BY,
			TranslationLocale.bg_BG,
			TranslationLocale.my_MM,
			TranslationLocale.ca_CA,
			TranslationLocale.zh_HK,
			TranslationLocale.zh_CN,
			TranslationLocale.zh_TW,
			TranslationLocale.hr_HR,
			TranslationLocale.cs_CZ,
			TranslationLocale.da_DK,
			TranslationLocale.nl_NL,
			TranslationLocale.en_AU,
			TranslationLocale.en_CA,
			TranslationLocale.en_US,
			TranslationLocale.en_GB,
			TranslationLocale.en_IN,
			TranslationLocale.en_SG,
			TranslationLocale.en_ZA,
			TranslationLocale.et_EE,
			TranslationLocale.fil_FIL,
			TranslationLocale.fi_FI,
			TranslationLocale.fr_CA,
			TranslationLocale.fr_FR,
			TranslationLocale.gl_ES,
			TranslationLocale.ka_GE,
			TranslationLocale.de_DE,
			TranslationLocale.el_GR,
			TranslationLocale.gu_IN,
			TranslationLocale.iw_IL,
			TranslationLocale.hi_IN,
			TranslationLocale.hu_HU,
			TranslationLocale.is_IS,
			TranslationLocale.id_ID,
			TranslationLocale.it_IT,
			TranslationLocale.ja_JP,
			TranslationLocale.kn_IN,
			TranslationLocale.kk_KZ,
			TranslationLocale.km_KH,
			TranslationLocale.ko_KR,
			TranslationLocale.ky_KG,
			TranslationLocale.lo_LA,
			TranslationLocale.lv_LV,
			TranslationLocale.lt_LT,
			TranslationLocale.mk_MK,
			TranslationLocale.ms_MY,
			TranslationLocale.ms_MS,
			TranslationLocale.ml_IN,
			TranslationLocale.mr_IN,
			TranslationLocale.mn_MN,
			TranslationLocale.ne_NP,
			TranslationLocale.no_NO,
			TranslationLocale.fa_FA,
			TranslationLocale.fa_AE,
			TranslationLocale.fa_AF,
			TranslationLocale.fa_IR,
			TranslationLocale.pl_PL,
			TranslationLocale.pt_BR,
			TranslationLocale.pt_PT,
			TranslationLocale.pa_IN,
			TranslationLocale.ro_RO,
			TranslationLocale.rm_CH,
			TranslationLocale.ru_RU,
			TranslationLocale.sr_RS,
			TranslationLocale.si_LK,
			TranslationLocale.sk_SK,
			TranslationLocale.sl_SI,
			TranslationLocale.es_419,
			TranslationLocale.es_ES,
			TranslationLocale.es_US,
			TranslationLocale.sw_KE,
			TranslationLocale.sv_SE,
			TranslationLocale.ta_IN,
			TranslationLocale.te_IN,
			TranslationLocale.th_TH,
			TranslationLocale.tr_TR,
			TranslationLocale.uk_UA,
			TranslationLocale.ur_UZ,
			TranslationLocale.vi_VN,
			TranslationLocale.zu_ZA
		};

		// Token: 0x0400014D RID: 333
		private static readonly TranslationLocale[] AppleLocales = new TranslationLocale[]
		{
			TranslationLocale.ar_AE,
			TranslationLocale.ca_CA,
			TranslationLocale.zh_CN,
			TranslationLocale.zh_TW,
			TranslationLocale.hr_HR,
			TranslationLocale.cs_CZ,
			TranslationLocale.da_DK,
			TranslationLocale.nl_NL,
			TranslationLocale.en_AU,
			TranslationLocale.en_CA,
			TranslationLocale.en_GB,
			TranslationLocale.en_US,
			TranslationLocale.fi_FI,
			TranslationLocale.fr_FR,
			TranslationLocale.fr_CA,
			TranslationLocale.de_DE,
			TranslationLocale.el_GR,
			TranslationLocale.iw_IL,
			TranslationLocale.hi_IN,
			TranslationLocale.hu_HU,
			TranslationLocale.id_ID,
			TranslationLocale.it_IT,
			TranslationLocale.ja_JP,
			TranslationLocale.ko_KR,
			TranslationLocale.ms_MY,
			TranslationLocale.no_NO,
			TranslationLocale.pl_PL,
			TranslationLocale.pt_BR,
			TranslationLocale.pt_PT,
			TranslationLocale.ro_RO,
			TranslationLocale.ru_RU,
			TranslationLocale.es_MX,
			TranslationLocale.es_ES,
			TranslationLocale.sv_SE,
			TranslationLocale.th_TH,
			TranslationLocale.tr_TR,
			TranslationLocale.uk_UA,
			TranslationLocale.vi_VN
		};

		// Token: 0x0400014E RID: 334
		private static string[] LabelsWithSupportedPlatforms;
	}
}
