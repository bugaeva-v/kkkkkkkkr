using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200018A RID: 394
[CreateAssetMenu(fileName = "assetAnthologyX", menuName = "ROMANCE/Create assetAnthologyX", order = 1)]
public class AssetAnthology : ScriptableObject
{
	// Token: 0x060030DE RID: 12510 RVA: 0x0014B884 File Offset: 0x00149A84
	public bool BFANHGMODJD(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.DMKKBMEAFLE(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030DF RID: 12511 RVA: 0x0014B958 File Offset: 0x00149B58
	public bool KKDKNOPFFOG(string LDKIOGKEDKD)
	{
		if (AppManager.PCJEMMDDCIF().environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.IKIAHBFHPMG(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030E0 RID: 12512 RVA: 0x0014BA2C File Offset: 0x00149C2C
	public bool KPILDMCCEAN(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030E1 RID: 12513 RVA: 0x0014BB00 File Offset: 0x00149D00
	public bool ONFCDEBJOGH(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.DMKKBMEAFLE(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030E2 RID: 12514 RVA: 0x0014BBD4 File Offset: 0x00149DD4
	public bool OECLKENNIAB(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.EMOGEHNPMHL(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030E3 RID: 12515 RVA: 0x0014BCA8 File Offset: 0x00149EA8
	public bool GJPFDBAHLAH(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030E4 RID: 12516 RVA: 0x0014BD7C File Offset: 0x00149F7C
	public bool GHJINLBCPKJ(string LDKIOGKEDKD)
	{
		if (AppManager.PCJEMMDDCIF().environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030E5 RID: 12517 RVA: 0x0014BE50 File Offset: 0x0014A050
	public bool KMGDBDIMAAM(string LDKIOGKEDKD)
	{
		if (AppManager.JMDJPKKOHNI().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.DMKKBMEAFLE(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030E6 RID: 12518 RVA: 0x0014BF24 File Offset: 0x0014A124
	public bool KMHICCNMCBL(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030E7 RID: 12519 RVA: 0x0014BFF8 File Offset: 0x0014A1F8
	public bool PMNGOOACDBH(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.DMKKBMEAFLE(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030E8 RID: 12520 RVA: 0x0014C0CC File Offset: 0x0014A2CC
	public bool JFPGJNCIGFK(string LDKIOGKEDKD)
	{
		if (AppManager.JMDJPKKOHNI().environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.DMKKBMEAFLE(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030E9 RID: 12521 RVA: 0x0014C1A0 File Offset: 0x0014A3A0
	public bool MCELBBBDMLN(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.EMOGEHNPMHL(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030EA RID: 12522 RVA: 0x0014C274 File Offset: 0x0014A474
	public bool JJHAKHJKDJB(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.EMOGEHNPMHL(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030EC RID: 12524 RVA: 0x0014C370 File Offset: 0x0014A570
	public bool LEMCLJHFAKC(string LDKIOGKEDKD)
	{
		if (AppManager.PCJEMMDDCIF().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.IKIAHBFHPMG(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030ED RID: 12525 RVA: 0x0014C444 File Offset: 0x0014A644
	public bool KJGMGMELKOA(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.DMKKBMEAFLE(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030EE RID: 12526 RVA: 0x0014C518 File Offset: 0x0014A718
	public bool CFOIKPJCBLG(string LDKIOGKEDKD)
	{
		if (AppManager.PCJEMMDDCIF().environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030EF RID: 12527 RVA: 0x0014C5EC File Offset: 0x0014A7EC
	public bool NHHOFIILBAG(string LDKIOGKEDKD)
	{
		if (AppManager.JMDJPKKOHNI().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.EMOGEHNPMHL(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030F0 RID: 12528 RVA: 0x0014C6C0 File Offset: 0x0014A8C0
	public bool FAACBEHJJDH(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.IKIAHBFHPMG(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030F1 RID: 12529 RVA: 0x0014C794 File Offset: 0x0014A994
	public bool AFACDHOPFJC(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.EMOGEHNPMHL(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030F2 RID: 12530 RVA: 0x0014C868 File Offset: 0x0014AA68
	public bool CEKCGMGBABG(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.EMOGEHNPMHL(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030F3 RID: 12531 RVA: 0x0014C93C File Offset: 0x0014AB3C
	public bool EIGJEADDMDG(string LDKIOGKEDKD)
	{
		if (AppManager.PCJEMMDDCIF().environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.DMKKBMEAFLE(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030F4 RID: 12532 RVA: 0x0014CA10 File Offset: 0x0014AC10
	public bool DPHEABLNJAN(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.EMOGEHNPMHL(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030F5 RID: 12533 RVA: 0x0014CAE4 File Offset: 0x0014ACE4
	public bool KJHDBDHKOFA(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.DMKKBMEAFLE(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030F6 RID: 12534 RVA: 0x0014CBB8 File Offset: 0x0014ADB8
	public bool BACDGMINGPK(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.IKIAHBFHPMG(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030F7 RID: 12535 RVA: 0x0014CC8C File Offset: 0x0014AE8C
	public bool EEFKEAANION(string LDKIOGKEDKD)
	{
		if (AppManager.PCJEMMDDCIF().environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030F8 RID: 12536 RVA: 0x0014CD60 File Offset: 0x0014AF60
	public bool LOFGNOEJAJA(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030F9 RID: 12537 RVA: 0x0014CE34 File Offset: 0x0014B034
	public bool EAMJNMGKLFI(string LDKIOGKEDKD)
	{
		if (AppManager.PCJEMMDDCIF().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030FA RID: 12538 RVA: 0x0014CF08 File Offset: 0x0014B108
	public bool MPKBANLLEKE(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.EMOGEHNPMHL(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030FB RID: 12539 RVA: 0x0014CFDC File Offset: 0x0014B1DC
	public bool HIIOCEHLEPL(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.EMOGEHNPMHL(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030FC RID: 12540 RVA: 0x0014D0B0 File Offset: 0x0014B2B0
	public bool JKILLAHJHDD(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.DMKKBMEAFLE(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030FD RID: 12541 RVA: 0x0014D184 File Offset: 0x0014B384
	public bool BMDGONJGCGH(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.IKIAHBFHPMG(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030FE RID: 12542 RVA: 0x0014D258 File Offset: 0x0014B458
	public bool IKNDCOCDDLO(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.IKIAHBFHPMG(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x060030FF RID: 12543 RVA: 0x0014D32C File Offset: 0x0014B52C
	public bool HGCGEBCHMBD(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.IKIAHBFHPMG(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x06003100 RID: 12544 RVA: 0x0014D400 File Offset: 0x0014B600
	public bool FMJONLDHPHN(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x06003101 RID: 12545 RVA: 0x0014D4D4 File Offset: 0x0014B6D4
	public bool MIJABIJDHIN(string LDKIOGKEDKD)
	{
		if (AppManager.PCJEMMDDCIF().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.EMOGEHNPMHL(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x06003102 RID: 12546 RVA: 0x0014D5A8 File Offset: 0x0014B7A8
	public bool KOJJCMPJHKO(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x06003103 RID: 12547 RVA: 0x0014D67C File Offset: 0x0014B87C
	public bool AILIOOLPDGC(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.DMKKBMEAFLE(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x06003104 RID: 12548 RVA: 0x0014D750 File Offset: 0x0014B950
	public bool ELKNHPCEGKM(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.IKIAHBFHPMG(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x06003105 RID: 12549 RVA: 0x0014D824 File Offset: 0x0014BA24
	public bool MIIDHNMEHNH(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x06003106 RID: 12550 RVA: 0x0014D8F8 File Offset: 0x0014BAF8
	public bool DOPEFCPAMEM(string LDKIOGKEDKD)
	{
		if (AppManager.JMDJPKKOHNI().environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x06003107 RID: 12551 RVA: 0x0014D9CC File Offset: 0x0014BBCC
	public bool KPNPFOCAHJP(string LDKIOGKEDKD)
	{
		if (AppManager.EHBBFMCILPC.environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages == null || this.supportedLanguagesGeoOverride[i].supportedLanguages.Length == 0 || this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x06003108 RID: 12552 RVA: 0x0014DAA0 File Offset: 0x0014BCA0
	public bool LONHNNNKLGM(string LDKIOGKEDKD)
	{
		if (AppManager.JMDJPKKOHNI().environmentSettings.enableLanguagesSupportGeoOverride == 1 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.ConfirmGeo(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages == null || this.supportedLanguages.Length == 0 || this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x06003109 RID: 12553 RVA: 0x0014DB74 File Offset: 0x0014BD74
	public bool JCOJPIJDEGN(string LDKIOGKEDKD)
	{
		if (AppManager.PCJEMMDDCIF().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 0)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.DMKKBMEAFLE(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x0600310A RID: 12554 RVA: 0x0014DC48 File Offset: 0x0014BE48
	public bool HAFIKOGDODP(string LDKIOGKEDKD)
	{
		if (AppManager.JMDJPKKOHNI().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 0; i < this.supportedLanguagesGeoOverride.Count; i++)
			{
				if (GeoLocationManager.IKIAHBFHPMG(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x0600310B RID: 12555 RVA: 0x0014DD1C File Offset: 0x0014BF1C
	public bool CIJIFCNJKNC(string LDKIOGKEDKD)
	{
		if (AppManager.AGANFKKBPFO().environmentSettings.enableLanguagesSupportGeoOverride == 0 && this.supportedLanguagesGeoOverride != null && this.supportedLanguagesGeoOverride.Count > 1)
		{
			for (int i = 1; i < this.supportedLanguagesGeoOverride.Count; i += 0)
			{
				if (GeoLocationManager.EMOGEHNPMHL(this.supportedLanguagesGeoOverride[i].countryCode))
				{
					return this.supportedLanguagesGeoOverride[i].supportedLanguages != null && this.supportedLanguagesGeoOverride[i].supportedLanguages.Length != 0 && this.supportedLanguagesGeoOverride[i].supportedLanguages.Contains(LDKIOGKEDKD);
				}
			}
		}
		return this.supportedLanguages != null && this.supportedLanguages.Length != 0 && this.supportedLanguages.Contains(LDKIOGKEDKD);
	}

	// Token: 0x04000EF9 RID: 3833
	public AssetAnthologyHeader header;

	// Token: 0x04000EFA RID: 3834
	public bool lowEndVersionAvailable;

	// Token: 0x04000EFB RID: 3835
	public bool miniVersionAvailable;

	// Token: 0x04000EFC RID: 3836
	public bool mini2VersionAvailable;

	// Token: 0x04000EFD RID: 3837
	public bool splashLowEndVersionAvailable;

	// Token: 0x04000EFE RID: 3838
	public string supportedLanguages = "";

	// Token: 0x04000EFF RID: 3839
	public string unsupportedLanguagesCensored = "";

	// Token: 0x04000F00 RID: 3840
	public List<SupportedLanguageGeoOverride> supportedLanguagesGeoOverride = new List<SupportedLanguageGeoOverride>();

	// Token: 0x04000F01 RID: 3841
	public int minRevision;
}
