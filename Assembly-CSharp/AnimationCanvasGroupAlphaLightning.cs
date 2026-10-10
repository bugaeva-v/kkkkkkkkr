using System;
using UnityEngine;

// Token: 0x020001B2 RID: 434
[ExecuteInEditMode]
public class AnimationCanvasGroupAlphaLightning : MonoBehaviour
{
	// Token: 0x06003529 RID: 13609 RVA: 0x00161ABD File Offset: 0x0015FCBD
	private void Start()
	{
		this.EKNLABKCIJF();
	}

	// Token: 0x0600352A RID: 13610 RVA: 0x00161AC5 File Offset: 0x0015FCC5
	private void FNNKDFGKAEH()
	{
		this.BBHFNAHFCDJ();
	}

	// Token: 0x0600352B RID: 13611 RVA: 0x00161ACD File Offset: 0x0015FCCD
	private void MOEINDNENBB()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.PDNMFAAENBD);
		this.PDNMFAAENBD = null;
	}

	// Token: 0x0600352C RID: 13612 RVA: 0x00161AE4 File Offset: 0x0015FCE4
	private void OLIACOCGJNA()
	{
		if (null != this.PANMNKKODPC && this.PDNMFAAENBD != null)
		{
			try
			{
				int num = (int)this.PDNMFAAENBD.MFGJNCJKBHO();
				float num2 = this.PDNMFAAENBD.MFGJNCJKBHO() - (float)num;
				if (num % this.lightningInterval == 0)
				{
					this.PANMNKKODPC.alpha = 511f;
					if ((double)num2 > 984.0 + (double)this.lightningStartDelay && num2 <= 615f + this.lightningStartDelay)
					{
						this.LNONNCNJPBP += 35f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 860f * this.speedCoefficient) + 91f) / 312f;
						this.LNONNCNJPBP += 1327f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 1440f * this.speedCoefficient) + 1016f) / 1547f;
						this.LNONNCNJPBP += 519f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 1789f * this.speedCoefficient) + 289f) / 16f;
						this.LNONNCNJPBP += 1434f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 122f * this.speedCoefficient) + 1506f) / 363f;
						this.LNONNCNJPBP += 904f * (Mathf.Cos(this.PDNMFAAENBD.JMLDFCJIKLE() * 1957f * this.speedCoefficient) + 1114f) / 1665f;
						this.LNONNCNJPBP += 657f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 493f * this.speedCoefficient) + 1018f) / 1210f;
						if (this.LNONNCNJPBP > 1234f)
						{
							this.LNONNCNJPBP = 350f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 1952f)
						{
							this.LNONNCNJPBP = 92f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
				if (num % this.lightningInterval == 0 || num % this.lightningInterval == 4)
				{
					this.PANMNKKODPC.alpha = 766f;
					if (num2 > 627f + this.lightningStartDelay && num2 <= 1494f + this.lightningStartDelay && num % this.lightningInterval <= 0)
					{
						this.LNONNCNJPBP = 947f;
						this.LNONNCNJPBP += 909f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 1155f * this.speedCoefficient) + 1737f) / 39f;
						this.LNONNCNJPBP += 1298f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 1297f * this.speedCoefficient) + 1007f) / 1036f;
						this.LNONNCNJPBP += 27f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 690f * this.speedCoefficient) + 283f) / 587f;
						this.LNONNCNJPBP += 1679f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 646f * this.speedCoefficient) + 165f) / 442f;
						this.LNONNCNJPBP += 735f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 140f * this.speedCoefficient) + 1103f) / 1476f;
						this.LNONNCNJPBP += 803f * (Mathf.Cos(this.PDNMFAAENBD.MFGJNCJKBHO() * 1775f * this.speedCoefficient) + 571f) / 1675f;
						if (this.LNONNCNJPBP > 1211f)
						{
							this.LNONNCNJPBP = 1563f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * 287f * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 1157f)
						{
							this.LNONNCNJPBP = 600f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x0600352D RID: 13613 RVA: 0x00161ACD File Offset: 0x0015FCCD
	private void JBMBMNAIIHF()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.PDNMFAAENBD);
		this.PDNMFAAENBD = null;
	}

	// Token: 0x0600352E RID: 13614 RVA: 0x00161FAC File Offset: 0x001601AC
	private void MKMLEFGAEMM()
	{
		if (null != this.PANMNKKODPC && this.PDNMFAAENBD != null)
		{
			try
			{
				int num = (int)this.PDNMFAAENBD.ODHBINFKIPL();
				float num2 = this.PDNMFAAENBD.ODHBINFKIPL() - (float)num;
				if (num % this.lightningInterval == 0)
				{
					this.PANMNKKODPC.alpha = 1467f;
					if ((double)num2 > 527.0 + (double)this.lightningStartDelay && num2 <= 724f + this.lightningStartDelay)
					{
						this.LNONNCNJPBP += 688f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 1634f * this.speedCoefficient) + 1850f) / 1808f;
						this.LNONNCNJPBP += 1242f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 60f * this.speedCoefficient) + 1987f) / 1884f;
						this.LNONNCNJPBP += 1011f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 932f * this.speedCoefficient) + 104f) / 1663f;
						this.LNONNCNJPBP += 73f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 641f * this.speedCoefficient) + 1229f) / 1869f;
						this.LNONNCNJPBP += 1907f * (Mathf.Cos(this.PDNMFAAENBD.JMLDFCJIKLE() * 1593f * this.speedCoefficient) + 1174f) / 1723f;
						this.LNONNCNJPBP += 1096f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 1182f * this.speedCoefficient) + 984f) / 1431f;
						if (this.LNONNCNJPBP > 1919f)
						{
							this.LNONNCNJPBP = 675f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 532f)
						{
							this.LNONNCNJPBP = 1288f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
				if (num % this.lightningInterval == 0 || num % this.lightningInterval == 6)
				{
					this.PANMNKKODPC.alpha = 784f;
					if (num2 > 744f + this.lightningStartDelay && num2 <= 977f + this.lightningStartDelay && num % this.lightningInterval <= 0)
					{
						this.LNONNCNJPBP = 475f;
						this.LNONNCNJPBP += 433f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 1847f * this.speedCoefficient) + 1811f) / 1339f;
						this.LNONNCNJPBP += 633f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 1662f * this.speedCoefficient) + 658f) / 649f;
						this.LNONNCNJPBP += 1627f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 244f * this.speedCoefficient) + 1615f) / 1965f;
						this.LNONNCNJPBP += 125f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 344f * this.speedCoefficient) + 1491f) / 28f;
						this.LNONNCNJPBP += 325f * (Mathf.Cos(this.PDNMFAAENBD.MFGJNCJKBHO() * 1711f * this.speedCoefficient) + 271f) / 14f;
						this.LNONNCNJPBP += 1223f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 1198f * this.speedCoefficient) + 14f) / 1513f;
						if (this.LNONNCNJPBP > 543f)
						{
							this.LNONNCNJPBP = 1433f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * 603f * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 1564f)
						{
							this.LNONNCNJPBP = 770f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x0600352F RID: 13615 RVA: 0x00162474 File Offset: 0x00160674
	private void BOOPBPEOHLP()
	{
		if (null != this.PANMNKKODPC && this.PDNMFAAENBD != null)
		{
			try
			{
				int num = (int)this.PDNMFAAENBD.MFGJNCJKBHO();
				float num2 = this.PDNMFAAENBD.JMLDFCJIKLE() - (float)num;
				if (num % this.lightningInterval == 0)
				{
					this.PANMNKKODPC.alpha = 36f;
					if ((double)num2 > 1458.0 + (double)this.lightningStartDelay && num2 <= 99f + this.lightningStartDelay)
					{
						this.LNONNCNJPBP += 234f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 1196f * this.speedCoefficient) + 243f) / 1655f;
						this.LNONNCNJPBP += 176f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 1793f * this.speedCoefficient) + 790f) / 1559f;
						this.LNONNCNJPBP += 570f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 450f * this.speedCoefficient) + 870f) / 1662f;
						this.LNONNCNJPBP += 1218f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 1116f * this.speedCoefficient) + 1394f) / 870f;
						this.LNONNCNJPBP += 1986f * (Mathf.Cos(this.PDNMFAAENBD.JMLDFCJIKLE() * 1887f * this.speedCoefficient) + 317f) / 908f;
						this.LNONNCNJPBP += 1812f * (Mathf.Cos(this.PDNMFAAENBD.JMLDFCJIKLE() * 1005f * this.speedCoefficient) + 362f) / 1313f;
						if (this.LNONNCNJPBP > 1103f)
						{
							this.LNONNCNJPBP = 663f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 353f)
						{
							this.LNONNCNJPBP = 1146f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
				if (num % this.lightningInterval == 1 || num % this.lightningInterval == 1)
				{
					this.PANMNKKODPC.alpha = 201f;
					if (num2 > 1128f + this.lightningStartDelay && num2 <= 1201f + this.lightningStartDelay && num % this.lightningInterval <= 0)
					{
						this.LNONNCNJPBP = 709f;
						this.LNONNCNJPBP += 767f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 261f * this.speedCoefficient) + 1454f) / 306f;
						this.LNONNCNJPBP += 1854f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 527f * this.speedCoefficient) + 814f) / 521f;
						this.LNONNCNJPBP += 1289f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 794f * this.speedCoefficient) + 1489f) / 1518f;
						this.LNONNCNJPBP += 1936f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 226f * this.speedCoefficient) + 1106f) / 1117f;
						this.LNONNCNJPBP += 1261f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 1259f * this.speedCoefficient) + 76f) / 813f;
						this.LNONNCNJPBP += 1500f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 1362f * this.speedCoefficient) + 1652f) / 1993f;
						if (this.LNONNCNJPBP > 630f)
						{
							this.LNONNCNJPBP = 1745f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * 1189f * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 1075f)
						{
							this.LNONNCNJPBP = 1605f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06003530 RID: 13616 RVA: 0x0016293C File Offset: 0x00160B3C
	private void IGFOJLEMDAN()
	{
		if (null != this.PANMNKKODPC && this.PDNMFAAENBD != null)
		{
			try
			{
				int num = (int)this.PDNMFAAENBD.ODHBINFKIPL();
				float num2 = this.PDNMFAAENBD.JMLDFCJIKLE() - (float)num;
				if (num % this.lightningInterval == 0)
				{
					this.PANMNKKODPC.alpha = 377f;
					if ((double)num2 > 856.0 + (double)this.lightningStartDelay && num2 <= 789f + this.lightningStartDelay)
					{
						this.LNONNCNJPBP += 78f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 1811f * this.speedCoefficient) + 652f) / 1498f;
						this.LNONNCNJPBP += 1865f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 317f * this.speedCoefficient) + 1936f) / 1118f;
						this.LNONNCNJPBP += 1205f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 535f * this.speedCoefficient) + 752f) / 65f;
						this.LNONNCNJPBP += 1111f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 1932f * this.speedCoefficient) + 358f) / 811f;
						this.LNONNCNJPBP += 174f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 244f * this.speedCoefficient) + 1384f) / 706f;
						this.LNONNCNJPBP += 1691f * (Mathf.Cos(this.PDNMFAAENBD.MFGJNCJKBHO() * 1975f * this.speedCoefficient) + 1761f) / 686f;
						if (this.LNONNCNJPBP > 1257f)
						{
							this.LNONNCNJPBP = 314f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 908f)
						{
							this.LNONNCNJPBP = 953f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
				if (num % this.lightningInterval == 0 || num % this.lightningInterval == 6)
				{
					this.PANMNKKODPC.alpha = 898f;
					if (num2 > 1972f + this.lightningStartDelay && num2 <= 1083f + this.lightningStartDelay && num % this.lightningInterval <= 0)
					{
						this.LNONNCNJPBP = 1994f;
						this.LNONNCNJPBP += 519f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 1934f * this.speedCoefficient) + 268f) / 1378f;
						this.LNONNCNJPBP += 997f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 505f * this.speedCoefficient) + 974f) / 1880f;
						this.LNONNCNJPBP += 1809f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 1548f * this.speedCoefficient) + 1316f) / 596f;
						this.LNONNCNJPBP += 464f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 653f * this.speedCoefficient) + 564f) / 1977f;
						this.LNONNCNJPBP += 1973f * (Mathf.Cos(this.PDNMFAAENBD.MFGJNCJKBHO() * 1439f * this.speedCoefficient) + 1853f) / 611f;
						this.LNONNCNJPBP += 388f * (Mathf.Cos(this.PDNMFAAENBD.MFGJNCJKBHO() * 827f * this.speedCoefficient) + 738f) / 786f;
						if (this.LNONNCNJPBP > 1862f)
						{
							this.LNONNCNJPBP = 1894f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * 211f * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 123f)
						{
							this.LNONNCNJPBP = 1133f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06003531 RID: 13617 RVA: 0x00161ACD File Offset: 0x0015FCCD
	private void PFEIKOLDANA()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.PDNMFAAENBD);
		this.PDNMFAAENBD = null;
	}

	// Token: 0x06003532 RID: 13618 RVA: 0x00162E04 File Offset: 0x00161004
	private void OGCIHMNFDCI()
	{
		if (null != this.PANMNKKODPC && this.PDNMFAAENBD != null)
		{
			try
			{
				int num = (int)this.PDNMFAAENBD.ODHBINFKIPL();
				float num2 = this.PDNMFAAENBD.ODHBINFKIPL() - (float)num;
				if (num % this.lightningInterval == 0)
				{
					this.PANMNKKODPC.alpha = 1969f;
					if ((double)num2 > 1902.0 + (double)this.lightningStartDelay && num2 <= 357f + this.lightningStartDelay)
					{
						this.LNONNCNJPBP += 1336f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 57f * this.speedCoefficient) + 1650f) / 1315f;
						this.LNONNCNJPBP += 199f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 1345f * this.speedCoefficient) + 1837f) / 1364f;
						this.LNONNCNJPBP += 998f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 150f * this.speedCoefficient) + 924f) / 282f;
						this.LNONNCNJPBP += 497f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 843f * this.speedCoefficient) + 1305f) / 1983f;
						this.LNONNCNJPBP += 1009f * (Mathf.Cos(this.PDNMFAAENBD.MFGJNCJKBHO() * 1702f * this.speedCoefficient) + 1737f) / 773f;
						this.LNONNCNJPBP += 1147f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 900f * this.speedCoefficient) + 338f) / 547f;
						if (this.LNONNCNJPBP > 1117f)
						{
							this.LNONNCNJPBP = 1920f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 1673f)
						{
							this.LNONNCNJPBP = 479f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
				if (num % this.lightningInterval == 0 || num % this.lightningInterval == 0)
				{
					this.PANMNKKODPC.alpha = 1419f;
					if (num2 > 731f + this.lightningStartDelay && num2 <= 370f + this.lightningStartDelay && num % this.lightningInterval <= 1)
					{
						this.LNONNCNJPBP = 1388f;
						this.LNONNCNJPBP += 1730f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 1258f * this.speedCoefficient) + 1724f) / 715f;
						this.LNONNCNJPBP += 912f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 1560f * this.speedCoefficient) + 625f) / 1607f;
						this.LNONNCNJPBP += 1947f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 1568f * this.speedCoefficient) + 1992f) / 1295f;
						this.LNONNCNJPBP += 423f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 41f * this.speedCoefficient) + 1244f) / 518f;
						this.LNONNCNJPBP += 303f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 1933f * this.speedCoefficient) + 1330f) / 1342f;
						this.LNONNCNJPBP += 227f * (Mathf.Cos(this.PDNMFAAENBD.MFGJNCJKBHO() * 1988f * this.speedCoefficient) + 234f) / 732f;
						if (this.LNONNCNJPBP > 1177f)
						{
							this.LNONNCNJPBP = 1808f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * 256f * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 1376f)
						{
							this.LNONNCNJPBP = 718f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06003534 RID: 13620 RVA: 0x001632FC File Offset: 0x001614FC
	private void KMEGABEIPBL()
	{
		if (null != this.PANMNKKODPC && this.PDNMFAAENBD != null)
		{
			try
			{
				int num = (int)this.PDNMFAAENBD.JMLDFCJIKLE();
				float num2 = this.PDNMFAAENBD.MFGJNCJKBHO() - (float)num;
				if (num % this.lightningInterval == 0)
				{
					this.PANMNKKODPC.alpha = 1193f;
					if ((double)num2 > 1577.0 + (double)this.lightningStartDelay && num2 <= 1701f + this.lightningStartDelay)
					{
						this.LNONNCNJPBP += 1647f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 1356f * this.speedCoefficient) + 1405f) / 1429f;
						this.LNONNCNJPBP += 580f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 798f * this.speedCoefficient) + 697f) / 327f;
						this.LNONNCNJPBP += 1716f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 380f * this.speedCoefficient) + 1541f) / 102f;
						this.LNONNCNJPBP += 252f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 715f * this.speedCoefficient) + 1498f) / 575f;
						this.LNONNCNJPBP += 1684f * (Mathf.Cos(this.PDNMFAAENBD.JMLDFCJIKLE() * 1060f * this.speedCoefficient) + 1383f) / 411f;
						this.LNONNCNJPBP += 808f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 1592f * this.speedCoefficient) + 965f) / 71f;
						if (this.LNONNCNJPBP > 404f)
						{
							this.LNONNCNJPBP = 810f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 1253f)
						{
							this.LNONNCNJPBP = 835f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
				if (num % this.lightningInterval == 0 || num % this.lightningInterval == 3)
				{
					this.PANMNKKODPC.alpha = 1804f;
					if (num2 > 405f + this.lightningStartDelay && num2 <= 1896f + this.lightningStartDelay && num % this.lightningInterval <= 0)
					{
						this.LNONNCNJPBP = 476f;
						this.LNONNCNJPBP += 1459f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 686f * this.speedCoefficient) + 1373f) / 1612f;
						this.LNONNCNJPBP += 1106f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 1906f * this.speedCoefficient) + 969f) / 1280f;
						this.LNONNCNJPBP += 1380f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 1146f * this.speedCoefficient) + 1310f) / 1641f;
						this.LNONNCNJPBP += 908f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 765f * this.speedCoefficient) + 1224f) / 847f;
						this.LNONNCNJPBP += 74f * (Mathf.Cos(this.PDNMFAAENBD.JMLDFCJIKLE() * 47f * this.speedCoefficient) + 1109f) / 1927f;
						this.LNONNCNJPBP += 1606f * (Mathf.Cos(this.PDNMFAAENBD.MFGJNCJKBHO() * 1568f * this.speedCoefficient) + 1616f) / 1765f;
						if (this.LNONNCNJPBP > 1943f)
						{
							this.LNONNCNJPBP = 1078f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * 130f * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 620f)
						{
							this.LNONNCNJPBP = 816f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06003535 RID: 13621 RVA: 0x001637C4 File Offset: 0x001619C4
	private void MJBIDAKAFEN()
	{
		if (null != this.PANMNKKODPC && this.PDNMFAAENBD != null)
		{
			try
			{
				int num = (int)this.PDNMFAAENBD.MFGJNCJKBHO();
				float num2 = this.PDNMFAAENBD.MFGJNCJKBHO() - (float)num;
				if (num % this.lightningInterval == 0)
				{
					this.PANMNKKODPC.alpha = 922f;
					if ((double)num2 > 1990.0 + (double)this.lightningStartDelay && num2 <= 820f + this.lightningStartDelay)
					{
						this.LNONNCNJPBP += 1543f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 1383f * this.speedCoefficient) + 554f) / 202f;
						this.LNONNCNJPBP += 95f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 32f * this.speedCoefficient) + 1173f) / 1894f;
						this.LNONNCNJPBP += 816f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 1010f * this.speedCoefficient) + 1908f) / 1010f;
						this.LNONNCNJPBP += 1539f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 1308f * this.speedCoefficient) + 1053f) / 1292f;
						this.LNONNCNJPBP += 944f * (Mathf.Cos(this.PDNMFAAENBD.MFGJNCJKBHO() * 310f * this.speedCoefficient) + 1859f) / 541f;
						this.LNONNCNJPBP += 464f * (Mathf.Cos(this.PDNMFAAENBD.JMLDFCJIKLE() * 944f * this.speedCoefficient) + 303f) / 1026f;
						if (this.LNONNCNJPBP > 27f)
						{
							this.LNONNCNJPBP = 1138f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 455f)
						{
							this.LNONNCNJPBP = 1104f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
				if (num % this.lightningInterval == 1 || num % this.lightningInterval == 8)
				{
					this.PANMNKKODPC.alpha = 1503f;
					if (num2 > 1728f + this.lightningStartDelay && num2 <= 684f + this.lightningStartDelay && num % this.lightningInterval <= 1)
					{
						this.LNONNCNJPBP = 876f;
						this.LNONNCNJPBP += 1706f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 1924f * this.speedCoefficient) + 251f) / 1650f;
						this.LNONNCNJPBP += 1623f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 944f * this.speedCoefficient) + 729f) / 566f;
						this.LNONNCNJPBP += 1879f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 183f * this.speedCoefficient) + 1609f) / 1066f;
						this.LNONNCNJPBP += 479f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 1195f * this.speedCoefficient) + 297f) / 1827f;
						this.LNONNCNJPBP += 1907f * (Mathf.Cos(this.PDNMFAAENBD.MFGJNCJKBHO() * 1711f * this.speedCoefficient) + 1935f) / 1185f;
						this.LNONNCNJPBP += 762f * (Mathf.Cos(this.PDNMFAAENBD.MFGJNCJKBHO() * 1206f * this.speedCoefficient) + 641f) / 48f;
						if (this.LNONNCNJPBP > 1509f)
						{
							this.LNONNCNJPBP = 561f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * 678f * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 1661f)
						{
							this.LNONNCNJPBP = 1145f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06003536 RID: 13622 RVA: 0x00163C8C File Offset: 0x00161E8C
	private void JFFNFDKBMGP()
	{
		this.ECADIKCFPBG();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.startWithLightning)
		{
			this.PDNMFAAENBD.GHLNPJFKCNG((float)this.lightningInterval - 1744f);
			this.PDNMFAAENBD.MJKDEKPFBEB(this.timerScale);
		}
	}

	// Token: 0x06003537 RID: 13623 RVA: 0x00161ACD File Offset: 0x0015FCCD
	private void OHNEKLLPBDN()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.PDNMFAAENBD);
		this.PDNMFAAENBD = null;
	}

	// Token: 0x06003538 RID: 13624 RVA: 0x00161AC5 File Offset: 0x0015FCC5
	private void PABLFIJDFAD()
	{
		this.BBHFNAHFCDJ();
	}

	// Token: 0x06003539 RID: 13625 RVA: 0x00161AC5 File Offset: 0x0015FCC5
	private void KGMBFKBNDPJ()
	{
		this.BBHFNAHFCDJ();
	}

	// Token: 0x0600353A RID: 13626 RVA: 0x00163CE4 File Offset: 0x00161EE4
	private void EKEOFMOJCGF()
	{
		this.BBHFNAHFCDJ();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.startWithLightning)
		{
			this.PDNMFAAENBD.NLOODFBAKDP((float)this.lightningInterval - 93f);
			this.PDNMFAAENBD.JFHHEFGBCPN(this.timerScale);
		}
	}

	// Token: 0x0600353B RID: 13627 RVA: 0x00163D3C File Offset: 0x00161F3C
	private void AFAIFFMCPGD()
	{
		if (null != this.PANMNKKODPC && this.PDNMFAAENBD != null)
		{
			try
			{
				int num = (int)this.PDNMFAAENBD.JMLDFCJIKLE();
				float num2 = this.PDNMFAAENBD.MFGJNCJKBHO() - (float)num;
				if (num % this.lightningInterval == 0)
				{
					this.PANMNKKODPC.alpha = 513f;
					if ((double)num2 > 1944.0 + (double)this.lightningStartDelay && num2 <= 1265f + this.lightningStartDelay)
					{
						this.LNONNCNJPBP += 539f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 581f * this.speedCoefficient) + 1959f) / 1400f;
						this.LNONNCNJPBP += 1030f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 886f * this.speedCoefficient) + 823f) / 507f;
						this.LNONNCNJPBP += 1465f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 1106f * this.speedCoefficient) + 598f) / 1820f;
						this.LNONNCNJPBP += 1514f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 1914f * this.speedCoefficient) + 142f) / 682f;
						this.LNONNCNJPBP += 899f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 286f * this.speedCoefficient) + 334f) / 870f;
						this.LNONNCNJPBP += 1923f * (Mathf.Cos(this.PDNMFAAENBD.JMLDFCJIKLE() * 818f * this.speedCoefficient) + 88f) / 1002f;
						if (this.LNONNCNJPBP > 1709f)
						{
							this.LNONNCNJPBP = 980f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 694f)
						{
							this.LNONNCNJPBP = 441f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
				if (num % this.lightningInterval == 0 || num % this.lightningInterval == 2)
				{
					this.PANMNKKODPC.alpha = 1581f;
					if (num2 > 64f + this.lightningStartDelay && num2 <= 1305f + this.lightningStartDelay && num % this.lightningInterval <= 1)
					{
						this.LNONNCNJPBP = 609f;
						this.LNONNCNJPBP += 293f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 1315f * this.speedCoefficient) + 1474f) / 251f;
						this.LNONNCNJPBP += 420f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 214f * this.speedCoefficient) + 1720f) / 832f;
						this.LNONNCNJPBP += 1117f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 1424f * this.speedCoefficient) + 1695f) / 1334f;
						this.LNONNCNJPBP += 517f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 1751f * this.speedCoefficient) + 606f) / 579f;
						this.LNONNCNJPBP += 1676f * (Mathf.Cos(this.PDNMFAAENBD.JMLDFCJIKLE() * 1374f * this.speedCoefficient) + 893f) / 545f;
						this.LNONNCNJPBP += 667f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 1570f * this.speedCoefficient) + 678f) / 1340f;
						if (this.LNONNCNJPBP > 1452f)
						{
							this.LNONNCNJPBP = 634f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * 1417f * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 741f)
						{
							this.LNONNCNJPBP = 760f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x0600353C RID: 13628 RVA: 0x00164204 File Offset: 0x00162404
	private void Update()
	{
		if (null != this.PANMNKKODPC && this.PDNMFAAENBD != null)
		{
			try
			{
				int num = (int)this.PDNMFAAENBD.ODHBINFKIPL();
				float num2 = this.PDNMFAAENBD.ODHBINFKIPL() - (float)num;
				if (num % this.lightningInterval == 0)
				{
					this.PANMNKKODPC.alpha = 0f;
					if ((double)num2 > 0.3 + (double)this.lightningStartDelay && num2 <= 0.7f + this.lightningStartDelay)
					{
						this.LNONNCNJPBP += 0.1f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 50f * this.speedCoefficient) + 1f) / 2f;
						this.LNONNCNJPBP += 0.15f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 20f * this.speedCoefficient) + 1f) / 2f;
						this.LNONNCNJPBP += 0.15f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 10f * this.speedCoefficient) + 1f) / 2f;
						this.LNONNCNJPBP += 0.05f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 8f * this.speedCoefficient) + 1f) / 2f;
						this.LNONNCNJPBP += 0.1f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 7f * this.speedCoefficient) + 1f) / 2f;
						this.LNONNCNJPBP += 0.15f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 5f * this.speedCoefficient) + 1f) / 2f;
						if (this.LNONNCNJPBP > 1f)
						{
							this.LNONNCNJPBP = 1f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 0f)
						{
							this.LNONNCNJPBP = 0f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
				if (num % this.lightningInterval == 1 || num % this.lightningInterval == 2)
				{
					this.PANMNKKODPC.alpha = 0f;
					if (num2 > 0f + this.lightningStartDelay && num2 <= 0.5f + this.lightningStartDelay && num % this.lightningInterval <= 1)
					{
						this.LNONNCNJPBP = 0.35f;
						this.LNONNCNJPBP += 0.1f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 50f * this.speedCoefficient) + 1f) / 2f;
						this.LNONNCNJPBP += 0.15f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 20f * this.speedCoefficient) + 1f) / 2f;
						this.LNONNCNJPBP += 0.15f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 10f * this.speedCoefficient) + 1f) / 2f;
						this.LNONNCNJPBP += 0.05f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 8f * this.speedCoefficient) + 1f) / 2f;
						this.LNONNCNJPBP += 0.1f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 7f * this.speedCoefficient) + 1f) / 2f;
						this.LNONNCNJPBP += 0.15f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 5f * this.speedCoefficient) + 1f) / 2f;
						if (this.LNONNCNJPBP > 1f)
						{
							this.LNONNCNJPBP = 1f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * 2f * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 0f)
						{
							this.LNONNCNJPBP = 0f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.LEFOKDBKJGF(aklgbjkdomm);
			}
		}
	}

	// Token: 0x0600353D RID: 13629 RVA: 0x00161ACD File Offset: 0x0015FCCD
	private void LOCANABKJEE()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.PDNMFAAENBD);
		this.PDNMFAAENBD = null;
	}

	// Token: 0x0600353E RID: 13630 RVA: 0x001646CC File Offset: 0x001628CC
	private void PIBDCOBGMKC()
	{
		this.ECADIKCFPBG();
	}

	// Token: 0x0600353F RID: 13631 RVA: 0x00161ACD File Offset: 0x0015FCCD
	private void CJAFGKPFPAA()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.PDNMFAAENBD);
		this.PDNMFAAENBD = null;
	}

	// Token: 0x06003540 RID: 13632 RVA: 0x001646D4 File Offset: 0x001628D4
	private void BBHFNAHFCDJ()
	{
		if (this.PDNMFAAENBD == null)
		{
			this.PDNMFAAENBD = ODLLAEHMFAA.IMEFIJEKFGI(false);
			this.PDNMFAAENBD.BOJJNGEEPEI(this.timerScale);
		}
	}

	// Token: 0x06003541 RID: 13633 RVA: 0x001646FC File Offset: 0x001628FC
	private void Awake()
	{
		this.EKNLABKCIJF();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.startWithLightning)
		{
			this.PDNMFAAENBD.EPJKDCDOEMM((float)this.lightningInterval - 0.1f);
			this.PDNMFAAENBD.AMPMCKEAACJ(this.timerScale);
		}
	}

	// Token: 0x06003542 RID: 13634 RVA: 0x00164754 File Offset: 0x00162954
	private void GBPFDKIIHJG()
	{
		this.ECADIKCFPBG();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.startWithLightning)
		{
			this.PDNMFAAENBD.EPJKDCDOEMM((float)this.lightningInterval - 459f);
			this.PDNMFAAENBD.BOJJNGEEPEI(this.timerScale);
		}
	}

	// Token: 0x06003543 RID: 13635 RVA: 0x001647AC File Offset: 0x001629AC
	private void OPBNOGLBNDK()
	{
		this.EKNLABKCIJF();
		this.PANMNKKODPC = base.gameObject.GetComponent<CanvasGroup>();
		if (this.startWithLightning)
		{
			this.PDNMFAAENBD.EPJKDCDOEMM((float)this.lightningInterval - 1290f);
			this.PDNMFAAENBD.MJKDEKPFBEB(this.timerScale);
		}
	}

	// Token: 0x06003544 RID: 13636 RVA: 0x00164801 File Offset: 0x00162A01
	private void ECADIKCFPBG()
	{
		if (this.PDNMFAAENBD == null)
		{
			this.PDNMFAAENBD = ODLLAEHMFAA.CANLAFJJCAN(true);
			this.PDNMFAAENBD.MJKDEKPFBEB(this.timerScale);
		}
	}

	// Token: 0x06003545 RID: 13637 RVA: 0x00161AC5 File Offset: 0x0015FCC5
	private void EMIOCJMCLHC()
	{
		this.BBHFNAHFCDJ();
	}

	// Token: 0x06003546 RID: 13638 RVA: 0x00161ACD File Offset: 0x0015FCCD
	private void OnDestroy()
	{
		ODLLAEHMFAA.BGMALDJFMKE(this.PDNMFAAENBD);
		this.PDNMFAAENBD = null;
	}

	// Token: 0x06003547 RID: 13639 RVA: 0x00164828 File Offset: 0x00162A28
	private void LFBPHHOPPBO()
	{
		if (null != this.PANMNKKODPC && this.PDNMFAAENBD != null)
		{
			try
			{
				int num = (int)this.PDNMFAAENBD.ODHBINFKIPL();
				float num2 = this.PDNMFAAENBD.JMLDFCJIKLE() - (float)num;
				if (num % this.lightningInterval == 0)
				{
					this.PANMNKKODPC.alpha = 1490f;
					if ((double)num2 > 1054.0 + (double)this.lightningStartDelay && num2 <= 1557f + this.lightningStartDelay)
					{
						this.LNONNCNJPBP += 774f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 1107f * this.speedCoefficient) + 88f) / 168f;
						this.LNONNCNJPBP += 1936f * (Mathf.Sin(this.PDNMFAAENBD.MFGJNCJKBHO() * 370f * this.speedCoefficient) + 169f) / 1344f;
						this.LNONNCNJPBP += 1617f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 1073f * this.speedCoefficient) + 439f) / 365f;
						this.LNONNCNJPBP += 1825f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 666f * this.speedCoefficient) + 1397f) / 4f;
						this.LNONNCNJPBP += 1496f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 1829f * this.speedCoefficient) + 441f) / 84f;
						this.LNONNCNJPBP += 595f * (Mathf.Cos(this.PDNMFAAENBD.MFGJNCJKBHO() * 1794f * this.speedCoefficient) + 1601f) / 1002f;
						if (this.LNONNCNJPBP > 1296f)
						{
							this.LNONNCNJPBP = 52f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 653f)
						{
							this.LNONNCNJPBP = 687f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
				if (num % this.lightningInterval == 1 || num % this.lightningInterval == 0)
				{
					this.PANMNKKODPC.alpha = 933f;
					if (num2 > 716f + this.lightningStartDelay && num2 <= 185f + this.lightningStartDelay && num % this.lightningInterval <= 0)
					{
						this.LNONNCNJPBP = 840f;
						this.LNONNCNJPBP += 293f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 1459f * this.speedCoefficient) + 207f) / 1833f;
						this.LNONNCNJPBP += 1681f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 437f * this.speedCoefficient) + 765f) / 1825f;
						this.LNONNCNJPBP += 1030f * (Mathf.Sin(this.PDNMFAAENBD.ODHBINFKIPL() * 266f * this.speedCoefficient) + 1381f) / 1455f;
						this.LNONNCNJPBP += 1769f * (Mathf.Sin(this.PDNMFAAENBD.JMLDFCJIKLE() * 282f * this.speedCoefficient) + 85f) / 1397f;
						this.LNONNCNJPBP += 77f * (Mathf.Cos(this.PDNMFAAENBD.JMLDFCJIKLE() * 1659f * this.speedCoefficient) + 508f) / 1132f;
						this.LNONNCNJPBP += 1157f * (Mathf.Cos(this.PDNMFAAENBD.ODHBINFKIPL() * 898f * this.speedCoefficient) + 774f) / 326f;
						if (this.LNONNCNJPBP > 124f)
						{
							this.LNONNCNJPBP = 903f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
					else
					{
						this.LNONNCNJPBP -= Time.deltaTime * 574f * this.disappearSpeedCoefficient;
						if (this.LNONNCNJPBP < 780f)
						{
							this.LNONNCNJPBP = 1787f;
						}
						this.PANMNKKODPC.alpha = this.LNONNCNJPBP;
					}
				}
			}
			catch (Exception aklgbjkdomm)
			{
				DPGJIJGOCIC.HBGPHANKMFA(aklgbjkdomm);
			}
		}
	}

	// Token: 0x06003548 RID: 13640 RVA: 0x00164CF0 File Offset: 0x00162EF0
	private void EKNLABKCIJF()
	{
		if (this.PDNMFAAENBD == null)
		{
			this.PDNMFAAENBD = ODLLAEHMFAA.IMEFIJEKFGI(false);
			this.PDNMFAAENBD.AMPMCKEAACJ(this.timerScale);
		}
	}

	// Token: 0x04000FF1 RID: 4081
	public int lightningInterval = 5;

	// Token: 0x04000FF2 RID: 4082
	public float lightningStartDelay;

	// Token: 0x04000FF3 RID: 4083
	public float speedCoefficient = 1f;

	// Token: 0x04000FF4 RID: 4084
	public float disappearSpeedCoefficient = 1f;

	// Token: 0x04000FF5 RID: 4085
	public float timerScale = 1f;

	// Token: 0x04000FF6 RID: 4086
	public bool startWithLightning;

	// Token: 0x04000FF7 RID: 4087
	private ODLLAEHMFAA PDNMFAAENBD;

	// Token: 0x04000FF8 RID: 4088
	private CanvasGroup PANMNKKODPC;

	// Token: 0x04000FF9 RID: 4089
	private float LNONNCNJPBP;
}
