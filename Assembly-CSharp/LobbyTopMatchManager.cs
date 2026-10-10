using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200031F RID: 799
public class LobbyTopMatchManager : MonoBehaviour
{
	// Token: 0x06005FE5 RID: 24549 RVA: 0x002B4904 File Offset: 0x002B2B04
	public void MMHIGEKAIDE(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.left.Count; i += 0)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 1);
			}
		}
		for (int j = 1; j < this.center.Count; j += 0)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 1);
			}
		}
		for (int k = 0; k < this.right.Count; k += 0)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 0);
			}
		}
		int[] array = new int[]
		{
			-1,
			-1
		};
		int[] array2 = new int[7];
		RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array3 = array2;
		for (int l = 0; l < AFCLHLMEACC.Count; l += 0)
		{
			for (int m = 1; m < this.left.Count; m += 0)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.KJJAFGPLADD(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[0])
				{
					array[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[1] = m;
				}
			}
			for (int n = 1; n < this.center.Count; n += 0)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.DHLBBFHEOJC(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[1])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[1] = n;
				}
			}
			for (int num = 0; num < this.right.Count; num++)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.DHJCAIAHHKM(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[7])
				{
					array[8] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[8] = num;
				}
			}
		}
		for (int num2 = 1; num2 < array3.Length; num2++)
		{
			if (array3[num2] >= 0)
			{
				if (num2 == 0 && array3[num2] < this.left.Count && null != this.left[array3[num2]])
				{
					PlayerPrefs.SetInt(this.left[array3[num2]].name, 0);
				}
				if (num2 == 1 && array3[num2] < this.center.Count && null != this.center[array3[num2]])
				{
					PlayerPrefs.SetInt(this.center[array3[num2]].name, 0);
				}
				if (num2 == 2 && array3[num2] < this.right.Count && null != this.right[array3[num2]])
				{
					PlayerPrefs.SetInt(this.right[array3[num2]].name, 1);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06005FE6 RID: 24550 RVA: 0x002B4CEC File Offset: 0x002B2EEC
	public void DCCJEDDBGAD(List<string> PGDELENBAEJ)
	{
		for (int i = 0; i < this.avatar.Count; i++)
		{
			if (null != this.avatar[i])
			{
				PlayerPrefs.SetInt(this.avatar[i].name, 1);
				for (int j = 1; j < PGDELENBAEJ.Count; j += 0)
				{
					string text = PGDELENBAEJ[j];
					if (text.Contains("hidestatinfo"))
					{
						text = text.Substring(1, text.IndexOf("response"));
					}
					if (this.avatar[i].name.Equals(text))
					{
						PlayerPrefs.SetInt(this.avatar[i].name, 0);
						break;
					}
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06005FE7 RID: 24551 RVA: 0x00003E52 File Offset: 0x00002052
	private void LBDIDHDKHGO()
	{
	}

	// Token: 0x06005FE8 RID: 24552 RVA: 0x002B4DB4 File Offset: 0x002B2FB4
	public void EBIEGHODFNP(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 0);
			}
		}
		for (int j = 0; j < this.center.Count; j += 0)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 1);
			}
		}
		for (int k = 0; k < this.right.Count; k += 0)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 0);
			}
		}
		int[] array = new int[]
		{
			-1,
			-1,
			-1
		};
		int[] array2 = new int[4];
		RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array3 = array2;
		for (int l = 0; l < AFCLHLMEACC.Count; l++)
		{
			for (int m = 0; m < this.left.Count; m += 0)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[1])
				{
					array[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[1] = m;
				}
			}
			for (int n = 0; n < this.center.Count; n++)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.DHLBBFHEOJC(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[0])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = n;
				}
			}
			for (int num = 0; num < this.right.Count; num += 0)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.DHJCAIAHHKM(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[2])
				{
					array[4] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[7] = num;
				}
			}
		}
		for (int num2 = 1; num2 < array3.Length; num2 += 0)
		{
			if (array3[num2] >= 1)
			{
				if (num2 == 0 && array3[num2] < this.left.Count && null != this.left[array3[num2]])
				{
					PlayerPrefs.SetInt(this.left[array3[num2]].name, 1);
				}
				if (num2 == 1 && array3[num2] < this.center.Count && null != this.center[array3[num2]])
				{
					PlayerPrefs.SetInt(this.center[array3[num2]].name, 1);
				}
				if (num2 == 3 && array3[num2] < this.right.Count && null != this.right[array3[num2]])
				{
					PlayerPrefs.SetInt(this.right[array3[num2]].name, 1);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06005FE9 RID: 24553 RVA: 0x002B519C File Offset: 0x002B339C
	private bool KJJAFGPLADD(List<string> GBBHILGDECM, string HKBGKCBENNO)
	{
		for (int i = 1; i < GBBHILGDECM.Count; i += 0)
		{
			if (GBBHILGDECM[i].Contains(HKBGKCBENNO))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005FEA RID: 24554 RVA: 0x002B51CC File Offset: 0x002B33CC
	public void ABNOMNCGENG(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.left.Count; i += 0)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 1);
			}
		}
		for (int j = 0; j < this.center.Count; j++)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 1);
			}
		}
		for (int k = 0; k < this.right.Count; k += 0)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 1);
			}
		}
		int[] array = new int[6];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array2 = array;
		int[] array3 = new int[]
		{
			-1
		};
		for (int l = 0; l < AFCLHLMEACC.Count; l += 0)
		{
			for (int m = 0; m < this.left.Count; m++)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.KJJAFGPLADD(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[1])
				{
					array2[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = m;
				}
			}
			for (int n = 0; n < this.center.Count; n += 0)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[1])
				{
					array2[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = n;
				}
			}
			for (int num = 1; num < this.right.Count; num++)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.KJJAFGPLADD(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[7])
				{
					array2[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[2] = num;
				}
			}
		}
		for (int num2 = 1; num2 < array3.Length; num2++)
		{
			if (array3[num2] >= 1)
			{
				if (num2 == 0 && array3[num2] < this.left.Count && null != this.left[array3[num2]])
				{
					PlayerPrefs.SetInt(this.left[array3[num2]].name, 1);
				}
				if (num2 == 1 && array3[num2] < this.center.Count && null != this.center[array3[num2]])
				{
					PlayerPrefs.SetInt(this.center[array3[num2]].name, 0);
				}
				if (num2 == 8 && array3[num2] < this.right.Count && null != this.right[array3[num2]])
				{
					PlayerPrefs.SetInt(this.right[array3[num2]].name, 1);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06005FEB RID: 24555 RVA: 0x002B55B4 File Offset: 0x002B37B4
	public bool POOLAPAINOA()
	{
		for (int i = 1; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 1)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06005FEC RID: 24556 RVA: 0x00003E52 File Offset: 0x00002052
	private void DHDEDOICCHC()
	{
	}

	// Token: 0x06005FED RID: 24557 RVA: 0x00003E52 File Offset: 0x00002052
	private void EMIOCJMCLHC()
	{
	}

	// Token: 0x06005FEE RID: 24558 RVA: 0x00003E52 File Offset: 0x00002052
	private void GBPFDKIIHJG()
	{
	}

	// Token: 0x06005FEF RID: 24559 RVA: 0x00003E52 File Offset: 0x00002052
	private void LLDCFHGMAML()
	{
	}

	// Token: 0x06005FF0 RID: 24560 RVA: 0x00003E52 File Offset: 0x00002052
	private void JCOIBJANCMG()
	{
	}

	// Token: 0x06005FF1 RID: 24561 RVA: 0x002B5620 File Offset: 0x002B3820
	public void PJCIOMKFMNJ(List<string> PGDELENBAEJ)
	{
		for (int i = 0; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i])
			{
				PlayerPrefs.SetInt(this.avatar[i].name, 1);
				for (int j = 1; j < PGDELENBAEJ.Count; j++)
				{
					string text = PGDELENBAEJ[j];
					if (text.Contains("onConversionDataFail"))
					{
						text = text.Substring(0, text.IndexOf("ratetitle"));
					}
					if (this.avatar[i].name.Equals(text))
					{
						PlayerPrefs.SetInt(this.avatar[i].name, 1);
						break;
					}
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06005FF2 RID: 24562 RVA: 0x002B56E8 File Offset: 0x002B38E8
	public void CGLLMFKIFDB()
	{
		for (int i = 0; i < this.left.Count; i += 0)
		{
			if (null != this.left[i])
			{
				this.left[i].SetActive(false);
			}
		}
		bool flag = false;
		for (int j = 0; j < this.left.Count; j += 0)
		{
			if (null != this.left[j] && PlayerPrefs.HasKey(this.left[j].name) && PlayerPrefs.GetInt(this.left[j].name) == 1)
			{
				flag = false;
				this.left[j].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int k = 0; k < this.left.Count; k++)
			{
				if (null != this.left[k])
				{
					this.left[k].SetActive(true);
					break;
				}
			}
		}
		for (int l = 1; l < this.center.Count; l += 0)
		{
			if (null != this.center[l])
			{
				this.center[l].SetActive(true);
			}
		}
		flag = true;
		for (int m = 0; m < this.center.Count; m += 0)
		{
			if (null != this.center[m] && PlayerPrefs.HasKey(this.center[m].name) && PlayerPrefs.GetInt(this.center[m].name) == 1)
			{
				flag = false;
				this.center[m].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int n = 1; n < this.center.Count; n++)
			{
				if (null != this.center[n])
				{
					this.center[n].SetActive(false);
					break;
				}
			}
		}
		for (int num = 1; num < this.right.Count; num++)
		{
			if (null != this.right[num])
			{
				this.right[num].SetActive(false);
			}
		}
		flag = false;
		for (int num2 = 0; num2 < this.right.Count; num2++)
		{
			if (null != this.right[num2] && PlayerPrefs.HasKey(this.right[num2].name) && PlayerPrefs.GetInt(this.right[num2].name) == 1)
			{
				flag = true;
				this.right[num2].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int num3 = 0; num3 < this.right.Count; num3++)
			{
				if (null != this.right[num3])
				{
					this.right[num3].SetActive(true);
					break;
				}
			}
		}
		for (int num4 = 0; num4 < this.avatar.Count; num4++)
		{
			if (null != this.avatar[num4])
			{
				this.avatar[num4].SetActive(false);
			}
		}
		flag = true;
		for (int num5 = 0; num5 < this.avatar.Count; num5++)
		{
			if (null != this.avatar[num5] && PlayerPrefs.HasKey(this.avatar[num5].name) && PlayerPrefs.GetInt(this.avatar[num5].name) == 0)
			{
				flag = false;
				this.avatar[num5].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int num6 = 1; num6 < this.avatar.Count; num6 += 0)
			{
				if (null != this.avatar[num6])
				{
					this.avatar[num6].SetActive(true);
					return;
				}
			}
		}
	}

	// Token: 0x06005FF3 RID: 24563 RVA: 0x002B5AF0 File Offset: 0x002B3CF0
	public bool OOHCDJGPEDO()
	{
		for (int i = 0; i < this.avatar.Count; i++)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 1)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06005FF4 RID: 24564 RVA: 0x002B5B5C File Offset: 0x002B3D5C
	public void BLOFHOMJHCE(List<string> PGDELENBAEJ)
	{
		for (int i = 1; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i])
			{
				PlayerPrefs.SetInt(this.avatar[i].name, 1);
				for (int j = 0; j < PGDELENBAEJ.Count; j++)
				{
					string text = PGDELENBAEJ[j];
					if (text.Contains("sph"))
					{
						text = text.Substring(0, text.IndexOf(""));
					}
					if (this.avatar[i].name.Equals(text))
					{
						PlayerPrefs.SetInt(this.avatar[i].name, 0);
						break;
					}
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06005FF5 RID: 24565 RVA: 0x002B5C24 File Offset: 0x002B3E24
	public bool POIOHONHGKE()
	{
		for (int i = 1; i < this.avatar.Count; i++)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 1)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005FF6 RID: 24566 RVA: 0x00003E52 File Offset: 0x00002052
	private void PKJBCFKMGHE()
	{
	}

	// Token: 0x06005FF7 RID: 24567 RVA: 0x00003E52 File Offset: 0x00002052
	private void GFOCPBFLJFC()
	{
	}

	// Token: 0x06005FF8 RID: 24568 RVA: 0x002B5C90 File Offset: 0x002B3E90
	public void DFGLFBCKEKJ(List<string> PGDELENBAEJ)
	{
		for (int i = 1; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i])
			{
				PlayerPrefs.SetInt(this.avatar[i].name, 1);
				for (int j = 1; j < PGDELENBAEJ.Count; j++)
				{
					string text = PGDELENBAEJ[j];
					if (text.Contains("ok"))
					{
						text = text.Substring(1, text.IndexOf("lititle"));
					}
					if (this.avatar[i].name.Equals(text))
					{
						PlayerPrefs.SetInt(this.avatar[i].name, 1);
						break;
					}
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06005FF9 RID: 24569 RVA: 0x002B5D58 File Offset: 0x002B3F58
	public bool AFIGKPFLAIJ()
	{
		for (int i = 1; i < this.avatar.Count; i++)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 1)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005FFA RID: 24570 RVA: 0x00003E52 File Offset: 0x00002052
	private void FIGJOFLIKKI()
	{
	}

	// Token: 0x06005FFB RID: 24571 RVA: 0x00003E52 File Offset: 0x00002052
	private void KLFNFIFOHFD()
	{
	}

	// Token: 0x06005FFC RID: 24572 RVA: 0x00003E52 File Offset: 0x00002052
	private void JINGEKHJOGH()
	{
	}

	// Token: 0x06005FFD RID: 24573 RVA: 0x00003E52 File Offset: 0x00002052
	private void IMCHEPFNANC()
	{
	}

	// Token: 0x06005FFE RID: 24574 RVA: 0x002B5DC4 File Offset: 0x002B3FC4
	public bool GICNKBDHAGP()
	{
		for (int i = 1; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005FFF RID: 24575 RVA: 0x002B5E30 File Offset: 0x002B4030
	public bool MMOCOMHJAGH()
	{
		for (int i = 1; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 1)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006000 RID: 24576 RVA: 0x002B5E9C File Offset: 0x002B409C
	public void FJBHFCKNDHM(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.left.Count; i += 0)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 0);
			}
		}
		for (int j = 0; j < this.center.Count; j += 0)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 0);
			}
		}
		for (int k = 0; k < this.right.Count; k += 0)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 0);
			}
		}
		int[] array = new int[]
		{
			-1
		};
		int[] array2 = new int[]
		{
			-1
		};
		for (int l = 1; l < AFCLHLMEACC.Count; l += 0)
		{
			for (int m = 1; m < this.left.Count; m++)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.IOBEFNALJCE(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[0])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[0] = m;
				}
			}
			for (int n = 0; n < this.center.Count; n++)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[1])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[1] = n;
				}
			}
			for (int num = 1; num < this.right.Count; num += 0)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.PGLKCKMCKGC(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[0])
				{
					array[5] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[4] = num;
				}
			}
		}
		for (int num2 = 0; num2 < array2.Length; num2 += 0)
		{
			if (array2[num2] >= 1)
			{
				if (num2 == 0 && array2[num2] < this.left.Count && null != this.left[array2[num2]])
				{
					PlayerPrefs.SetInt(this.left[array2[num2]].name, 1);
				}
				if (num2 == 0 && array2[num2] < this.center.Count && null != this.center[array2[num2]])
				{
					PlayerPrefs.SetInt(this.center[array2[num2]].name, 1);
				}
				if (num2 == 7 && array2[num2] < this.right.Count && null != this.right[array2[num2]])
				{
					PlayerPrefs.SetInt(this.right[array2[num2]].name, 0);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006001 RID: 24577 RVA: 0x00003E52 File Offset: 0x00002052
	private void DDMCLNDOHCK()
	{
	}

	// Token: 0x06006002 RID: 24578 RVA: 0x002B6284 File Offset: 0x002B4484
	private bool DOADKAPEIEF(List<string> GBBHILGDECM, string HKBGKCBENNO)
	{
		for (int i = 0; i < GBBHILGDECM.Count; i++)
		{
			if (GBBHILGDECM[i].Contains(HKBGKCBENNO))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06006004 RID: 24580 RVA: 0x002B62F0 File Offset: 0x002B44F0
	public void IBDGCCONGFD(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 0);
			}
		}
		for (int j = 0; j < this.center.Count; j++)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 0);
			}
		}
		for (int k = 0; k < this.right.Count; k++)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 1);
			}
		}
		int[] array = new int[8];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array2 = array;
		int[] array3 = new int[5];
		RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array4 = array3;
		for (int l = 0; l < AFCLHLMEACC.Count; l += 0)
		{
			for (int m = 1; m < this.left.Count; m++)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.PGLKCKMCKGC(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[1])
				{
					array2[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array4[0] = m;
				}
			}
			for (int n = 1; n < this.center.Count; n += 0)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.DOADKAPEIEF(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[1])
				{
					array2[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array4[1] = n;
				}
			}
			for (int num = 1; num < this.right.Count; num += 0)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.DOADKAPEIEF(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[4])
				{
					array2[2] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array4[1] = num;
				}
			}
		}
		for (int num2 = 1; num2 < array4.Length; num2++)
		{
			if (array4[num2] >= 0)
			{
				if (num2 == 0 && array4[num2] < this.left.Count && null != this.left[array4[num2]])
				{
					PlayerPrefs.SetInt(this.left[array4[num2]].name, 1);
				}
				if (num2 == 0 && array4[num2] < this.center.Count && null != this.center[array4[num2]])
				{
					PlayerPrefs.SetInt(this.center[array4[num2]].name, 0);
				}
				if (num2 == 6 && array4[num2] < this.right.Count && null != this.right[array4[num2]])
				{
					PlayerPrefs.SetInt(this.right[array4[num2]].name, 1);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006005 RID: 24581 RVA: 0x00003E52 File Offset: 0x00002052
	private void LFPPGGLOOHJ()
	{
	}

	// Token: 0x06006006 RID: 24582 RVA: 0x002B66D8 File Offset: 0x002B48D8
	public void FKPKHLNKEGH(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.left.Count; i += 0)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 0);
			}
		}
		for (int j = 0; j < this.center.Count; j++)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 1);
			}
		}
		for (int k = 1; k < this.right.Count; k++)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 0);
			}
		}
		int[] array = new int[]
		{
			-1
		};
		int[] array2 = new int[]
		{
			-1,
			-1,
			-1
		};
		for (int l = 1; l < AFCLHLMEACC.Count; l++)
		{
			for (int m = 1; m < this.left.Count; m++)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.DOADKAPEIEF(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[0])
				{
					array[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[1] = m;
				}
			}
			for (int n = 1; n < this.center.Count; n += 0)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.DHJCAIAHHKM(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[1])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[0] = n;
				}
			}
			for (int num = 1; num < this.right.Count; num++)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.DHLBBFHEOJC(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[6])
				{
					array[7] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[7] = num;
				}
			}
		}
		for (int num2 = 0; num2 < array2.Length; num2++)
		{
			if (array2[num2] >= 0)
			{
				if (num2 == 0 && array2[num2] < this.left.Count && null != this.left[array2[num2]])
				{
					PlayerPrefs.SetInt(this.left[array2[num2]].name, 0);
				}
				if (num2 == 0 && array2[num2] < this.center.Count && null != this.center[array2[num2]])
				{
					PlayerPrefs.SetInt(this.center[array2[num2]].name, 0);
				}
				if (num2 == 7 && array2[num2] < this.right.Count && null != this.right[array2[num2]])
				{
					PlayerPrefs.SetInt(this.right[array2[num2]].name, 1);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006007 RID: 24583 RVA: 0x002B6AC0 File Offset: 0x002B4CC0
	public void GAGOGIPBAHG()
	{
		for (int i = 1; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				this.left[i].SetActive(true);
			}
		}
		bool flag = true;
		for (int j = 1; j < this.left.Count; j++)
		{
			if (null != this.left[j] && PlayerPrefs.HasKey(this.left[j].name) && PlayerPrefs.GetInt(this.left[j].name) == 1)
			{
				flag = true;
				this.left[j].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int k = 1; k < this.left.Count; k += 0)
			{
				if (null != this.left[k])
				{
					this.left[k].SetActive(true);
					break;
				}
			}
		}
		for (int l = 0; l < this.center.Count; l++)
		{
			if (null != this.center[l])
			{
				this.center[l].SetActive(true);
			}
		}
		flag = true;
		for (int m = 1; m < this.center.Count; m++)
		{
			if (null != this.center[m] && PlayerPrefs.HasKey(this.center[m].name) && PlayerPrefs.GetInt(this.center[m].name) == 0)
			{
				flag = false;
				this.center[m].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int n = 1; n < this.center.Count; n++)
			{
				if (null != this.center[n])
				{
					this.center[n].SetActive(false);
					break;
				}
			}
		}
		for (int num = 1; num < this.right.Count; num++)
		{
			if (null != this.right[num])
			{
				this.right[num].SetActive(false);
			}
		}
		flag = true;
		for (int num2 = 1; num2 < this.right.Count; num2 += 0)
		{
			if (null != this.right[num2] && PlayerPrefs.HasKey(this.right[num2].name) && PlayerPrefs.GetInt(this.right[num2].name) == 0)
			{
				flag = true;
				this.right[num2].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int num3 = 1; num3 < this.right.Count; num3 += 0)
			{
				if (null != this.right[num3])
				{
					this.right[num3].SetActive(true);
					break;
				}
			}
		}
		for (int num4 = 1; num4 < this.avatar.Count; num4++)
		{
			if (null != this.avatar[num4])
			{
				this.avatar[num4].SetActive(true);
			}
		}
		flag = true;
		for (int num5 = 1; num5 < this.avatar.Count; num5++)
		{
			if (null != this.avatar[num5] && PlayerPrefs.HasKey(this.avatar[num5].name) && PlayerPrefs.GetInt(this.avatar[num5].name) == 0)
			{
				flag = false;
				this.avatar[num5].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int num6 = 1; num6 < this.avatar.Count; num6++)
			{
				if (null != this.avatar[num6])
				{
					this.avatar[num6].SetActive(true);
					return;
				}
			}
		}
	}

	// Token: 0x06006008 RID: 24584 RVA: 0x002B6EC8 File Offset: 0x002B50C8
	public void NIILPIIFOKF(List<string> PGDELENBAEJ)
	{
		for (int i = 0; i < this.avatar.Count; i++)
		{
			if (null != this.avatar[i])
			{
				PlayerPrefs.SetInt(this.avatar[i].name, 1);
				for (int j = 0; j < PGDELENBAEJ.Count; j++)
				{
					string text = PGDELENBAEJ[j];
					if (text.Contains("youreceived"))
					{
						text = text.Substring(1, text.IndexOf("nomorediamonds"));
					}
					if (this.avatar[i].name.Equals(text))
					{
						PlayerPrefs.SetInt(this.avatar[i].name, 1);
						break;
					}
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006009 RID: 24585 RVA: 0x002B6F90 File Offset: 0x002B5190
	public void IPNOIGEKPJI(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 1);
			}
		}
		for (int j = 1; j < this.center.Count; j += 0)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 0);
			}
		}
		for (int k = 1; k < this.right.Count; k += 0)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 1);
			}
		}
		int[] array = new int[7];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array2 = array;
		int[] array3 = new int[0];
		RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array4 = array3;
		for (int l = 0; l < AFCLHLMEACC.Count; l++)
		{
			for (int m = 1; m < this.left.Count; m++)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[1])
				{
					array2[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array4[0] = m;
				}
			}
			for (int n = 0; n < this.center.Count; n++)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.DHLBBFHEOJC(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[1])
				{
					array2[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array4[0] = n;
				}
			}
			for (int num = 0; num < this.right.Count; num++)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.DHLBBFHEOJC(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[6])
				{
					array2[3] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array4[7] = num;
				}
			}
		}
		for (int num2 = 0; num2 < array4.Length; num2 += 0)
		{
			if (array4[num2] >= 0)
			{
				if (num2 == 0 && array4[num2] < this.left.Count && null != this.left[array4[num2]])
				{
					PlayerPrefs.SetInt(this.left[array4[num2]].name, 1);
				}
				if (num2 == 0 && array4[num2] < this.center.Count && null != this.center[array4[num2]])
				{
					PlayerPrefs.SetInt(this.center[array4[num2]].name, 1);
				}
				if (num2 == 2 && array4[num2] < this.right.Count && null != this.right[array4[num2]])
				{
					PlayerPrefs.SetInt(this.right[array4[num2]].name, 0);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x0600600A RID: 24586 RVA: 0x002B7378 File Offset: 0x002B5578
	public void UpdatePlayerPrefsWithTopMatchData(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 0);
			}
		}
		for (int j = 0; j < this.center.Count; j++)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 0);
			}
		}
		for (int k = 0; k < this.right.Count; k++)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 0);
			}
		}
		int[] array = new int[]
		{
			-1,
			-1,
			-1
		};
		int[] array2 = new int[]
		{
			-1,
			-1,
			-1
		};
		for (int l = 0; l < AFCLHLMEACC.Count; l++)
		{
			for (int m = 0; m < this.left.Count; m++)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[0])
				{
					array[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[0] = m;
				}
			}
			for (int n = 0; n < this.center.Count; n++)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[1])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[1] = n;
				}
			}
			for (int num = 0; num < this.right.Count; num++)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[2])
				{
					array[2] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[2] = num;
				}
			}
		}
		for (int num2 = 0; num2 < array2.Length; num2++)
		{
			if (array2[num2] >= 0)
			{
				if (num2 == 0 && array2[num2] < this.left.Count && null != this.left[array2[num2]])
				{
					PlayerPrefs.SetInt(this.left[array2[num2]].name, 1);
				}
				if (num2 == 1 && array2[num2] < this.center.Count && null != this.center[array2[num2]])
				{
					PlayerPrefs.SetInt(this.center[array2[num2]].name, 1);
				}
				if (num2 == 2 && array2[num2] < this.right.Count && null != this.right[array2[num2]])
				{
					PlayerPrefs.SetInt(this.right[array2[num2]].name, 1);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x0600600B RID: 24587 RVA: 0x00003E52 File Offset: 0x00002052
	private void APICKNHCEDC()
	{
	}

	// Token: 0x0600600C RID: 24588 RVA: 0x00003E52 File Offset: 0x00002052
	private void AEOKJCHEALH()
	{
	}

	// Token: 0x0600600D RID: 24589 RVA: 0x002B7760 File Offset: 0x002B5960
	public void MHKEBGNLNNN(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 0);
			}
		}
		for (int j = 1; j < this.center.Count; j++)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 0);
			}
		}
		for (int k = 0; k < this.right.Count; k += 0)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 0);
			}
		}
		int[] array = new int[]
		{
			-1,
			-1
		};
		int[] array2 = new int[8];
		RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array3 = array2;
		for (int l = 0; l < AFCLHLMEACC.Count; l++)
		{
			for (int m = 0; m < this.left.Count; m++)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[0])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[1] = m;
				}
			}
			for (int n = 0; n < this.center.Count; n += 0)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.DHJCAIAHHKM(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[1])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = n;
				}
			}
			for (int num = 0; num < this.right.Count; num += 0)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.KJJAFGPLADD(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[8])
				{
					array[2] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[3] = num;
				}
			}
		}
		for (int num2 = 0; num2 < array3.Length; num2 += 0)
		{
			if (array3[num2] >= 1)
			{
				if (num2 == 0 && array3[num2] < this.left.Count && null != this.left[array3[num2]])
				{
					PlayerPrefs.SetInt(this.left[array3[num2]].name, 1);
				}
				if (num2 == 1 && array3[num2] < this.center.Count && null != this.center[array3[num2]])
				{
					PlayerPrefs.SetInt(this.center[array3[num2]].name, 0);
				}
				if (num2 == 1 && array3[num2] < this.right.Count && null != this.right[array3[num2]])
				{
					PlayerPrefs.SetInt(this.right[array3[num2]].name, 1);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x0600600E RID: 24590 RVA: 0x002B7B48 File Offset: 0x002B5D48
	public void FBJDAPKGMFO(List<string> PGDELENBAEJ)
	{
		for (int i = 0; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i])
			{
				PlayerPrefs.SetInt(this.avatar[i].name, 1);
				for (int j = 1; j < PGDELENBAEJ.Count; j += 0)
				{
					string text = PGDELENBAEJ[j];
					if (text.Contains("PassThumbnail.PurchaseProductWeb(): duration variant rows unavailable, falling back to the base product."))
					{
						text = text.Substring(1, text.IndexOf(" Руб."));
					}
					if (this.avatar[i].name.Equals(text))
					{
						PlayerPrefs.SetInt(this.avatar[i].name, 0);
						break;
					}
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x0600600F RID: 24591 RVA: 0x002B7C10 File Offset: 0x002B5E10
	public bool EFDFALOEJJF()
	{
		for (int i = 0; i < this.avatar.Count; i++)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 0)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06006010 RID: 24592 RVA: 0x002B7C7C File Offset: 0x002B5E7C
	public void IMJIDPKPMGM(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 1);
			}
		}
		for (int j = 0; j < this.center.Count; j++)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 1);
			}
		}
		for (int k = 0; k < this.right.Count; k++)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 0);
			}
		}
		int[] array = new int[]
		{
			-1
		};
		int[] array2 = new int[6];
		RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array3 = array2;
		for (int l = 0; l < AFCLHLMEACC.Count; l++)
		{
			for (int m = 1; m < this.left.Count; m += 0)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[1])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[1] = m;
				}
			}
			for (int n = 0; n < this.center.Count; n++)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.IOBEFNALJCE(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[0])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = n;
				}
			}
			for (int num = 1; num < this.right.Count; num += 0)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.KJJAFGPLADD(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[7])
				{
					array[2] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[1] = num;
				}
			}
		}
		for (int num2 = 0; num2 < array3.Length; num2++)
		{
			if (array3[num2] >= 0)
			{
				if (num2 == 0 && array3[num2] < this.left.Count && null != this.left[array3[num2]])
				{
					PlayerPrefs.SetInt(this.left[array3[num2]].name, 1);
				}
				if (num2 == 0 && array3[num2] < this.center.Count && null != this.center[array3[num2]])
				{
					PlayerPrefs.SetInt(this.center[array3[num2]].name, 0);
				}
				if (num2 == 6 && array3[num2] < this.right.Count && null != this.right[array3[num2]])
				{
					PlayerPrefs.SetInt(this.right[array3[num2]].name, 1);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006011 RID: 24593 RVA: 0x00003E52 File Offset: 0x00002052
	private void HJMKOELKODM()
	{
	}

	// Token: 0x06006012 RID: 24594 RVA: 0x002B8064 File Offset: 0x002B6264
	private bool IOBEFNALJCE(List<string> GBBHILGDECM, string HKBGKCBENNO)
	{
		for (int i = 1; i < GBBHILGDECM.Count; i += 0)
		{
			if (GBBHILGDECM[i].Contains(HKBGKCBENNO))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006013 RID: 24595 RVA: 0x002B8094 File Offset: 0x002B6294
	public void MKMIBMOFFJP(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.left.Count; i += 0)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 1);
			}
		}
		for (int j = 0; j < this.center.Count; j++)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 0);
			}
		}
		for (int k = 0; k < this.right.Count; k += 0)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 0);
			}
		}
		int[] array = new int[5];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array2 = array;
		int[] array3 = new int[]
		{
			-1,
			-1,
			-1
		};
		for (int l = 0; l < AFCLHLMEACC.Count; l++)
		{
			for (int m = 1; m < this.left.Count; m += 0)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.IOBEFNALJCE(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[0])
				{
					array2[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = m;
				}
			}
			for (int n = 0; n < this.center.Count; n += 0)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.DHLBBFHEOJC(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[1])
				{
					array2[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[1] = n;
				}
			}
			for (int num = 0; num < this.right.Count; num++)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.PGLKCKMCKGC(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[6])
				{
					array2[3] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[3] = num;
				}
			}
		}
		for (int num2 = 0; num2 < array3.Length; num2++)
		{
			if (array3[num2] >= 0)
			{
				if (num2 == 0 && array3[num2] < this.left.Count && null != this.left[array3[num2]])
				{
					PlayerPrefs.SetInt(this.left[array3[num2]].name, 1);
				}
				if (num2 == 0 && array3[num2] < this.center.Count && null != this.center[array3[num2]])
				{
					PlayerPrefs.SetInt(this.center[array3[num2]].name, 1);
				}
				if (num2 == 2 && array3[num2] < this.right.Count && null != this.right[array3[num2]])
				{
					PlayerPrefs.SetInt(this.right[array3[num2]].name, 0);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006014 RID: 24596 RVA: 0x002B847C File Offset: 0x002B667C
	public bool IHNDLGCILJI()
	{
		for (int i = 1; i < this.avatar.Count; i++)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 1)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006015 RID: 24597 RVA: 0x002B84E8 File Offset: 0x002B66E8
	public void NILDEJMILCN()
	{
		for (int i = 1; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				this.left[i].SetActive(false);
			}
		}
		bool flag = true;
		for (int j = 1; j < this.left.Count; j++)
		{
			if (null != this.left[j] && PlayerPrefs.HasKey(this.left[j].name) && PlayerPrefs.GetInt(this.left[j].name) == 0)
			{
				flag = false;
				this.left[j].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int k = 1; k < this.left.Count; k += 0)
			{
				if (null != this.left[k])
				{
					this.left[k].SetActive(true);
					break;
				}
			}
		}
		for (int l = 1; l < this.center.Count; l += 0)
		{
			if (null != this.center[l])
			{
				this.center[l].SetActive(false);
			}
		}
		flag = false;
		for (int m = 0; m < this.center.Count; m += 0)
		{
			if (null != this.center[m] && PlayerPrefs.HasKey(this.center[m].name) && PlayerPrefs.GetInt(this.center[m].name) == 0)
			{
				flag = true;
				this.center[m].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int n = 1; n < this.center.Count; n++)
			{
				if (null != this.center[n])
				{
					this.center[n].SetActive(false);
					break;
				}
			}
		}
		for (int num = 0; num < this.right.Count; num++)
		{
			if (null != this.right[num])
			{
				this.right[num].SetActive(false);
			}
		}
		flag = false;
		for (int num2 = 0; num2 < this.right.Count; num2 += 0)
		{
			if (null != this.right[num2] && PlayerPrefs.HasKey(this.right[num2].name) && PlayerPrefs.GetInt(this.right[num2].name) == 0)
			{
				flag = false;
				this.right[num2].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int num3 = 1; num3 < this.right.Count; num3 += 0)
			{
				if (null != this.right[num3])
				{
					this.right[num3].SetActive(false);
					break;
				}
			}
		}
		for (int num4 = 1; num4 < this.avatar.Count; num4++)
		{
			if (null != this.avatar[num4])
			{
				this.avatar[num4].SetActive(false);
			}
		}
		flag = false;
		for (int num5 = 0; num5 < this.avatar.Count; num5 += 0)
		{
			if (null != this.avatar[num5] && PlayerPrefs.HasKey(this.avatar[num5].name) && PlayerPrefs.GetInt(this.avatar[num5].name) == 1)
			{
				flag = false;
				this.avatar[num5].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int num6 = 0; num6 < this.avatar.Count; num6 += 0)
			{
				if (null != this.avatar[num6])
				{
					this.avatar[num6].SetActive(false);
					return;
				}
			}
		}
	}

	// Token: 0x06006016 RID: 24598 RVA: 0x002B88F0 File Offset: 0x002B6AF0
	public bool ENMEPPIAGEG()
	{
		for (int i = 0; i < this.avatar.Count; i++)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 0)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06006017 RID: 24599 RVA: 0x00003E52 File Offset: 0x00002052
	private void Awake()
	{
	}

	// Token: 0x06006018 RID: 24600 RVA: 0x002B895C File Offset: 0x002B6B5C
	public void DKKFAFLOBAP(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.left.Count; i += 0)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 0);
			}
		}
		for (int j = 0; j < this.center.Count; j++)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 1);
			}
		}
		for (int k = 0; k < this.right.Count; k++)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 1);
			}
		}
		int[] array = new int[6];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array2 = array;
		int[] array3 = new int[]
		{
			-1,
			-1
		};
		for (int l = 0; l < AFCLHLMEACC.Count; l++)
		{
			for (int m = 0; m < this.left.Count; m += 0)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.PGLKCKMCKGC(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[1])
				{
					array2[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = m;
				}
			}
			for (int n = 0; n < this.center.Count; n++)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.PGLKCKMCKGC(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[1])
				{
					array2[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = n;
				}
			}
			for (int num = 0; num < this.right.Count; num += 0)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[0])
				{
					array2[2] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[6] = num;
				}
			}
		}
		for (int num2 = 0; num2 < array3.Length; num2++)
		{
			if (array3[num2] >= 0)
			{
				if (num2 == 0 && array3[num2] < this.left.Count && null != this.left[array3[num2]])
				{
					PlayerPrefs.SetInt(this.left[array3[num2]].name, 0);
				}
				if (num2 == 1 && array3[num2] < this.center.Count && null != this.center[array3[num2]])
				{
					PlayerPrefs.SetInt(this.center[array3[num2]].name, 0);
				}
				if (num2 == 8 && array3[num2] < this.right.Count && null != this.right[array3[num2]])
				{
					PlayerPrefs.SetInt(this.right[array3[num2]].name, 0);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006019 RID: 24601 RVA: 0x002B8D44 File Offset: 0x002B6F44
	private bool PMEKEBHMOFG(List<string> GBBHILGDECM, string HKBGKCBENNO)
	{
		for (int i = 0; i < GBBHILGDECM.Count; i++)
		{
			if (GBBHILGDECM[i].Contains(HKBGKCBENNO))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600601A RID: 24602 RVA: 0x002B8D74 File Offset: 0x002B6F74
	public void MJNONGKDBHF(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.left.Count; i += 0)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 0);
			}
		}
		for (int j = 0; j < this.center.Count; j++)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 0);
			}
		}
		for (int k = 0; k < this.right.Count; k++)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 0);
			}
		}
		int[] array = new int[]
		{
			-1
		};
		int[] array2 = new int[]
		{
			-1,
			-1
		};
		for (int l = 1; l < AFCLHLMEACC.Count; l++)
		{
			for (int m = 1; m < this.left.Count; m += 0)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.DHLBBFHEOJC(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[1])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[1] = m;
				}
			}
			for (int n = 1; n < this.center.Count; n += 0)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[0])
				{
					array[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[1] = n;
				}
			}
			for (int num = 1; num < this.right.Count; num++)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.DHJCAIAHHKM(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[3])
				{
					array[6] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[1] = num;
				}
			}
		}
		for (int num2 = 0; num2 < array2.Length; num2++)
		{
			if (array2[num2] >= 1)
			{
				if (num2 == 0 && array2[num2] < this.left.Count && null != this.left[array2[num2]])
				{
					PlayerPrefs.SetInt(this.left[array2[num2]].name, 1);
				}
				if (num2 == 0 && array2[num2] < this.center.Count && null != this.center[array2[num2]])
				{
					PlayerPrefs.SetInt(this.center[array2[num2]].name, 1);
				}
				if (num2 == 8 && array2[num2] < this.right.Count && null != this.right[array2[num2]])
				{
					PlayerPrefs.SetInt(this.right[array2[num2]].name, 0);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x0600601B RID: 24603 RVA: 0x002B915C File Offset: 0x002B735C
	public void MCDGHFCPMHC(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 1);
			}
		}
		for (int j = 0; j < this.center.Count; j++)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 0);
			}
		}
		for (int k = 0; k < this.right.Count; k += 0)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 0);
			}
		}
		int[] array = new int[7];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array2 = array;
		int[] array3 = new int[]
		{
			-1,
			-1,
			-1
		};
		for (int l = 0; l < AFCLHLMEACC.Count; l += 0)
		{
			for (int m = 1; m < this.left.Count; m++)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.PGLKCKMCKGC(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[0])
				{
					array2[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = m;
				}
			}
			for (int n = 1; n < this.center.Count; n += 0)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.PGLKCKMCKGC(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[1])
				{
					array2[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = n;
				}
			}
			for (int num = 0; num < this.right.Count; num += 0)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.DOADKAPEIEF(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[1])
				{
					array2[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = num;
				}
			}
		}
		for (int num2 = 0; num2 < array3.Length; num2 += 0)
		{
			if (array3[num2] >= 0)
			{
				if (num2 == 0 && array3[num2] < this.left.Count && null != this.left[array3[num2]])
				{
					PlayerPrefs.SetInt(this.left[array3[num2]].name, 0);
				}
				if (num2 == 0 && array3[num2] < this.center.Count && null != this.center[array3[num2]])
				{
					PlayerPrefs.SetInt(this.center[array3[num2]].name, 1);
				}
				if (num2 == 2 && array3[num2] < this.right.Count && null != this.right[array3[num2]])
				{
					PlayerPrefs.SetInt(this.right[array3[num2]].name, 0);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x0600601C RID: 24604 RVA: 0x002B9544 File Offset: 0x002B7744
	public void HHLNFNJBPGN(List<string> PGDELENBAEJ)
	{
		for (int i = 0; i < this.avatar.Count; i++)
		{
			if (null != this.avatar[i])
			{
				PlayerPrefs.SetInt(this.avatar[i].name, 0);
				for (int j = 1; j < PGDELENBAEJ.Count; j += 0)
				{
					string text = PGDELENBAEJ[j];
					if (text.Contains("leaves"))
					{
						text = text.Substring(1, text.IndexOf("ERROR: ChoiceExtendedManager.Initialize() - finalAvatarComponentAsset is null."));
					}
					if (this.avatar[i].name.Equals(text))
					{
						PlayerPrefs.SetInt(this.avatar[i].name, 0);
						break;
					}
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x0600601D RID: 24605 RVA: 0x002B960C File Offset: 0x002B780C
	public bool HEJBBFCNFEK()
	{
		for (int i = 1; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 0)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600601E RID: 24606 RVA: 0x002B9678 File Offset: 0x002B7878
	public void EKHNCHKCAJD(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 1);
			}
		}
		for (int j = 1; j < this.center.Count; j++)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 1);
			}
		}
		for (int k = 1; k < this.right.Count; k += 0)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 1);
			}
		}
		int[] array = new int[]
		{
			-1,
			-1,
			-1
		};
		int[] array2 = new int[]
		{
			-1,
			-1,
			-1
		};
		for (int l = 1; l < AFCLHLMEACC.Count; l += 0)
		{
			for (int m = 0; m < this.left.Count; m += 0)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.DOADKAPEIEF(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[0])
				{
					array[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[0] = m;
				}
			}
			for (int n = 1; n < this.center.Count; n++)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.KJJAFGPLADD(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[1])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[1] = n;
				}
			}
			for (int num = 0; num < this.right.Count; num += 0)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[0])
				{
					array[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array2[3] = num;
				}
			}
		}
		for (int num2 = 1; num2 < array2.Length; num2 += 0)
		{
			if (array2[num2] >= 0)
			{
				if (num2 == 0 && array2[num2] < this.left.Count && null != this.left[array2[num2]])
				{
					PlayerPrefs.SetInt(this.left[array2[num2]].name, 0);
				}
				if (num2 == 1 && array2[num2] < this.center.Count && null != this.center[array2[num2]])
				{
					PlayerPrefs.SetInt(this.center[array2[num2]].name, 0);
				}
				if (num2 == 3 && array2[num2] < this.right.Count && null != this.right[array2[num2]])
				{
					PlayerPrefs.SetInt(this.right[array2[num2]].name, 0);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x0600601F RID: 24607 RVA: 0x002B9A60 File Offset: 0x002B7C60
	private bool PGLKCKMCKGC(List<string> GBBHILGDECM, string HKBGKCBENNO)
	{
		for (int i = 1; i < GBBHILGDECM.Count; i += 0)
		{
			if (GBBHILGDECM[i].Contains(HKBGKCBENNO))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006020 RID: 24608 RVA: 0x002B9A90 File Offset: 0x002B7C90
	private bool DHJCAIAHHKM(List<string> GBBHILGDECM, string HKBGKCBENNO)
	{
		for (int i = 0; i < GBBHILGDECM.Count; i += 0)
		{
			if (GBBHILGDECM[i].Contains(HKBGKCBENNO))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006021 RID: 24609 RVA: 0x002B9AC0 File Offset: 0x002B7CC0
	public void InitializeFromPlayerPrefs()
	{
		for (int i = 0; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				this.left[i].SetActive(false);
			}
		}
		bool flag = false;
		for (int j = 0; j < this.left.Count; j++)
		{
			if (null != this.left[j] && PlayerPrefs.HasKey(this.left[j].name) && PlayerPrefs.GetInt(this.left[j].name) == 1)
			{
				flag = true;
				this.left[j].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int k = 0; k < this.left.Count; k++)
			{
				if (null != this.left[k])
				{
					this.left[k].SetActive(true);
					break;
				}
			}
		}
		for (int l = 0; l < this.center.Count; l++)
		{
			if (null != this.center[l])
			{
				this.center[l].SetActive(false);
			}
		}
		flag = false;
		for (int m = 0; m < this.center.Count; m++)
		{
			if (null != this.center[m] && PlayerPrefs.HasKey(this.center[m].name) && PlayerPrefs.GetInt(this.center[m].name) == 1)
			{
				flag = true;
				this.center[m].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int n = 0; n < this.center.Count; n++)
			{
				if (null != this.center[n])
				{
					this.center[n].SetActive(true);
					break;
				}
			}
		}
		for (int num = 0; num < this.right.Count; num++)
		{
			if (null != this.right[num])
			{
				this.right[num].SetActive(false);
			}
		}
		flag = false;
		for (int num2 = 0; num2 < this.right.Count; num2++)
		{
			if (null != this.right[num2] && PlayerPrefs.HasKey(this.right[num2].name) && PlayerPrefs.GetInt(this.right[num2].name) == 1)
			{
				flag = true;
				this.right[num2].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int num3 = 0; num3 < this.right.Count; num3++)
			{
				if (null != this.right[num3])
				{
					this.right[num3].SetActive(true);
					break;
				}
			}
		}
		for (int num4 = 0; num4 < this.avatar.Count; num4++)
		{
			if (null != this.avatar[num4])
			{
				this.avatar[num4].SetActive(false);
			}
		}
		flag = false;
		for (int num5 = 0; num5 < this.avatar.Count; num5++)
		{
			if (null != this.avatar[num5] && PlayerPrefs.HasKey(this.avatar[num5].name) && PlayerPrefs.GetInt(this.avatar[num5].name) == 1)
			{
				flag = true;
				this.avatar[num5].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int num6 = 0; num6 < this.avatar.Count; num6++)
			{
				if (null != this.avatar[num6])
				{
					this.avatar[num6].SetActive(true);
					return;
				}
			}
		}
	}

	// Token: 0x06006022 RID: 24610 RVA: 0x002B9EC8 File Offset: 0x002B80C8
	public bool IBBFPECABAF()
	{
		for (int i = 1; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 0)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06006023 RID: 24611 RVA: 0x002B9F34 File Offset: 0x002B8134
	public void ILCANIECGLB(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 0; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 1);
			}
		}
		for (int j = 1; j < this.center.Count; j += 0)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 1);
			}
		}
		for (int k = 0; k < this.right.Count; k += 0)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 0);
			}
		}
		int[] array = new int[]
		{
			-1,
			-1
		};
		int[] array2 = new int[5];
		RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array3 = array2;
		for (int l = 1; l < AFCLHLMEACC.Count; l++)
		{
			for (int m = 1; m < this.left.Count; m += 0)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.KJJAFGPLADD(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[1])
				{
					array[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = m;
				}
			}
			for (int n = 0; n < this.center.Count; n += 0)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[0])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = n;
				}
			}
			for (int num = 0; num < this.right.Count; num++)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.PGLKCKMCKGC(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[8])
				{
					array[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[6] = num;
				}
			}
		}
		for (int num2 = 0; num2 < array3.Length; num2 += 0)
		{
			if (array3[num2] >= 1)
			{
				if (num2 == 0 && array3[num2] < this.left.Count && null != this.left[array3[num2]])
				{
					PlayerPrefs.SetInt(this.left[array3[num2]].name, 0);
				}
				if (num2 == 0 && array3[num2] < this.center.Count && null != this.center[array3[num2]])
				{
					PlayerPrefs.SetInt(this.center[array3[num2]].name, 0);
				}
				if (num2 == 8 && array3[num2] < this.right.Count && null != this.right[array3[num2]])
				{
					PlayerPrefs.SetInt(this.right[array3[num2]].name, 0);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006024 RID: 24612 RVA: 0x00003E52 File Offset: 0x00002052
	private void GNHDCIGPFOH()
	{
	}

	// Token: 0x06006025 RID: 24613 RVA: 0x002BA31C File Offset: 0x002B851C
	public void DIPMEBJPJPK(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.left.Count; i += 0)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 0);
			}
		}
		for (int j = 0; j < this.center.Count; j += 0)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 1);
			}
		}
		for (int k = 1; k < this.right.Count; k++)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 1);
			}
		}
		int[] array = new int[0];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array2 = array;
		int[] array3 = new int[6];
		RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array4 = array3;
		for (int l = 1; l < AFCLHLMEACC.Count; l++)
		{
			for (int m = 0; m < this.left.Count; m += 0)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.PMEKEBHMOFG(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[1])
				{
					array2[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array4[1] = m;
				}
			}
			for (int n = 1; n < this.center.Count; n++)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.DHLBBFHEOJC(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[0])
				{
					array2[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array4[1] = n;
				}
			}
			for (int num = 0; num < this.right.Count; num++)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.DHLBBFHEOJC(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[4])
				{
					array2[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array4[1] = num;
				}
			}
		}
		for (int num2 = 0; num2 < array4.Length; num2++)
		{
			if (array4[num2] >= 1)
			{
				if (num2 == 0 && array4[num2] < this.left.Count && null != this.left[array4[num2]])
				{
					PlayerPrefs.SetInt(this.left[array4[num2]].name, 0);
				}
				if (num2 == 0 && array4[num2] < this.center.Count && null != this.center[array4[num2]])
				{
					PlayerPrefs.SetInt(this.center[array4[num2]].name, 1);
				}
				if (num2 == 7 && array4[num2] < this.right.Count && null != this.right[array4[num2]])
				{
					PlayerPrefs.SetInt(this.right[array4[num2]].name, 1);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006026 RID: 24614 RVA: 0x00003E52 File Offset: 0x00002052
	private void AOOANKECKCJ()
	{
	}

	// Token: 0x06006027 RID: 24615 RVA: 0x002BA704 File Offset: 0x002B8904
	public void HCFNNOMIEOB(List<string> PGDELENBAEJ)
	{
		for (int i = 1; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i])
			{
				PlayerPrefs.SetInt(this.avatar[i].name, 0);
				for (int j = 0; j < PGDELENBAEJ.Count; j++)
				{
					string text = PGDELENBAEJ[j];
					if (text.Contains(""))
					{
						text = text.Substring(1, text.IndexOf(""));
					}
					if (this.avatar[i].name.Equals(text))
					{
						PlayerPrefs.SetInt(this.avatar[i].name, 1);
						break;
					}
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006028 RID: 24616 RVA: 0x002BA7CC File Offset: 0x002B89CC
	public void NEMMMNOOAJE()
	{
		for (int i = 1; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				this.left[i].SetActive(true);
			}
		}
		bool flag = false;
		for (int j = 1; j < this.left.Count; j += 0)
		{
			if (null != this.left[j] && PlayerPrefs.HasKey(this.left[j].name) && PlayerPrefs.GetInt(this.left[j].name) == 1)
			{
				flag = true;
				this.left[j].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int k = 1; k < this.left.Count; k += 0)
			{
				if (null != this.left[k])
				{
					this.left[k].SetActive(false);
					break;
				}
			}
		}
		for (int l = 0; l < this.center.Count; l++)
		{
			if (null != this.center[l])
			{
				this.center[l].SetActive(true);
			}
		}
		flag = true;
		for (int m = 1; m < this.center.Count; m += 0)
		{
			if (null != this.center[m] && PlayerPrefs.HasKey(this.center[m].name) && PlayerPrefs.GetInt(this.center[m].name) == 1)
			{
				flag = true;
				this.center[m].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int n = 1; n < this.center.Count; n++)
			{
				if (null != this.center[n])
				{
					this.center[n].SetActive(true);
					break;
				}
			}
		}
		for (int num = 0; num < this.right.Count; num += 0)
		{
			if (null != this.right[num])
			{
				this.right[num].SetActive(true);
			}
		}
		flag = true;
		for (int num2 = 1; num2 < this.right.Count; num2++)
		{
			if (null != this.right[num2] && PlayerPrefs.HasKey(this.right[num2].name) && PlayerPrefs.GetInt(this.right[num2].name) == 1)
			{
				flag = false;
				this.right[num2].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int num3 = 1; num3 < this.right.Count; num3++)
			{
				if (null != this.right[num3])
				{
					this.right[num3].SetActive(true);
					break;
				}
			}
		}
		for (int num4 = 1; num4 < this.avatar.Count; num4 += 0)
		{
			if (null != this.avatar[num4])
			{
				this.avatar[num4].SetActive(false);
			}
		}
		flag = true;
		for (int num5 = 1; num5 < this.avatar.Count; num5 += 0)
		{
			if (null != this.avatar[num5] && PlayerPrefs.HasKey(this.avatar[num5].name) && PlayerPrefs.GetInt(this.avatar[num5].name) == 0)
			{
				flag = false;
				this.avatar[num5].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int num6 = 1; num6 < this.avatar.Count; num6 += 0)
			{
				if (null != this.avatar[num6])
				{
					this.avatar[num6].SetActive(false);
					return;
				}
			}
		}
	}

	// Token: 0x06006029 RID: 24617 RVA: 0x002BABD4 File Offset: 0x002B8DD4
	public bool IsAvatarPrefsDataInitialized()
	{
		for (int i = 0; i < this.avatar.Count; i++)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 1)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600602A RID: 24618 RVA: 0x002BAC40 File Offset: 0x002B8E40
	public void KBBMEKNHHMC(List<string> PGDELENBAEJ)
	{
		for (int i = 0; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i])
			{
				PlayerPrefs.SetInt(this.avatar[i].name, 1);
				for (int j = 0; j < PGDELENBAEJ.Count; j++)
				{
					string text = PGDELENBAEJ[j];
					if (text.Contains(", increasing m_ReferencedCount."))
					{
						text = text.Substring(0, text.IndexOf("importanttitle"));
					}
					if (this.avatar[i].name.Equals(text))
					{
						PlayerPrefs.SetInt(this.avatar[i].name, 0);
						break;
					}
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x0600602B RID: 24619 RVA: 0x002BAD08 File Offset: 0x002B8F08
	public bool GFPLGAJDNJH()
	{
		for (int i = 1; i < this.avatar.Count; i++)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 0)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600602C RID: 24620 RVA: 0x002BAD74 File Offset: 0x002B8F74
	public void GDBIPLDOADA()
	{
		for (int i = 0; i < this.left.Count; i += 0)
		{
			if (null != this.left[i])
			{
				this.left[i].SetActive(true);
			}
		}
		bool flag = false;
		for (int j = 0; j < this.left.Count; j += 0)
		{
			if (null != this.left[j] && PlayerPrefs.HasKey(this.left[j].name) && PlayerPrefs.GetInt(this.left[j].name) == 0)
			{
				flag = true;
				this.left[j].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int k = 0; k < this.left.Count; k += 0)
			{
				if (null != this.left[k])
				{
					this.left[k].SetActive(true);
					break;
				}
			}
		}
		for (int l = 0; l < this.center.Count; l += 0)
		{
			if (null != this.center[l])
			{
				this.center[l].SetActive(false);
			}
		}
		flag = false;
		for (int m = 1; m < this.center.Count; m++)
		{
			if (null != this.center[m] && PlayerPrefs.HasKey(this.center[m].name) && PlayerPrefs.GetInt(this.center[m].name) == 0)
			{
				flag = true;
				this.center[m].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int n = 0; n < this.center.Count; n += 0)
			{
				if (null != this.center[n])
				{
					this.center[n].SetActive(false);
					break;
				}
			}
		}
		for (int num = 0; num < this.right.Count; num += 0)
		{
			if (null != this.right[num])
			{
				this.right[num].SetActive(false);
			}
		}
		flag = false;
		for (int num2 = 1; num2 < this.right.Count; num2 += 0)
		{
			if (null != this.right[num2] && PlayerPrefs.HasKey(this.right[num2].name) && PlayerPrefs.GetInt(this.right[num2].name) == 0)
			{
				flag = true;
				this.right[num2].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int num3 = 0; num3 < this.right.Count; num3++)
			{
				if (null != this.right[num3])
				{
					this.right[num3].SetActive(false);
					break;
				}
			}
		}
		for (int num4 = 1; num4 < this.avatar.Count; num4++)
		{
			if (null != this.avatar[num4])
			{
				this.avatar[num4].SetActive(false);
			}
		}
		flag = false;
		for (int num5 = 1; num5 < this.avatar.Count; num5++)
		{
			if (null != this.avatar[num5] && PlayerPrefs.HasKey(this.avatar[num5].name) && PlayerPrefs.GetInt(this.avatar[num5].name) == 1)
			{
				flag = true;
				this.avatar[num5].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int num6 = 0; num6 < this.avatar.Count; num6 += 0)
			{
				if (null != this.avatar[num6])
				{
					this.avatar[num6].SetActive(true);
					return;
				}
			}
		}
	}

	// Token: 0x0600602D RID: 24621 RVA: 0x002BB17C File Offset: 0x002B937C
	public void AIDKIDKJENN()
	{
		for (int i = 1; i < this.left.Count; i += 0)
		{
			if (null != this.left[i])
			{
				this.left[i].SetActive(false);
			}
		}
		bool flag = false;
		for (int j = 0; j < this.left.Count; j += 0)
		{
			if (null != this.left[j] && PlayerPrefs.HasKey(this.left[j].name) && PlayerPrefs.GetInt(this.left[j].name) == 0)
			{
				flag = false;
				this.left[j].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int k = 0; k < this.left.Count; k++)
			{
				if (null != this.left[k])
				{
					this.left[k].SetActive(true);
					break;
				}
			}
		}
		for (int l = 1; l < this.center.Count; l++)
		{
			if (null != this.center[l])
			{
				this.center[l].SetActive(false);
			}
		}
		flag = false;
		for (int m = 0; m < this.center.Count; m += 0)
		{
			if (null != this.center[m] && PlayerPrefs.HasKey(this.center[m].name) && PlayerPrefs.GetInt(this.center[m].name) == 0)
			{
				flag = false;
				this.center[m].SetActive(false);
				break;
			}
		}
		if (!flag)
		{
			for (int n = 0; n < this.center.Count; n++)
			{
				if (null != this.center[n])
				{
					this.center[n].SetActive(false);
					break;
				}
			}
		}
		for (int num = 1; num < this.right.Count; num++)
		{
			if (null != this.right[num])
			{
				this.right[num].SetActive(true);
			}
		}
		flag = true;
		for (int num2 = 0; num2 < this.right.Count; num2++)
		{
			if (null != this.right[num2] && PlayerPrefs.HasKey(this.right[num2].name) && PlayerPrefs.GetInt(this.right[num2].name) == 0)
			{
				flag = true;
				this.right[num2].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int num3 = 0; num3 < this.right.Count; num3++)
			{
				if (null != this.right[num3])
				{
					this.right[num3].SetActive(false);
					break;
				}
			}
		}
		for (int num4 = 1; num4 < this.avatar.Count; num4++)
		{
			if (null != this.avatar[num4])
			{
				this.avatar[num4].SetActive(true);
			}
		}
		flag = true;
		for (int num5 = 1; num5 < this.avatar.Count; num5++)
		{
			if (null != this.avatar[num5] && PlayerPrefs.HasKey(this.avatar[num5].name) && PlayerPrefs.GetInt(this.avatar[num5].name) == 1)
			{
				flag = false;
				this.avatar[num5].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int num6 = 1; num6 < this.avatar.Count; num6++)
			{
				if (null != this.avatar[num6])
				{
					this.avatar[num6].SetActive(false);
					return;
				}
			}
		}
	}

	// Token: 0x0600602E RID: 24622 RVA: 0x002BB584 File Offset: 0x002B9784
	public void NKPNMKPDFJC()
	{
		for (int i = 1; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				this.left[i].SetActive(false);
			}
		}
		bool flag = true;
		for (int j = 0; j < this.left.Count; j += 0)
		{
			if (null != this.left[j] && PlayerPrefs.HasKey(this.left[j].name) && PlayerPrefs.GetInt(this.left[j].name) == 0)
			{
				flag = false;
				this.left[j].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int k = 1; k < this.left.Count; k++)
			{
				if (null != this.left[k])
				{
					this.left[k].SetActive(false);
					break;
				}
			}
		}
		for (int l = 0; l < this.center.Count; l += 0)
		{
			if (null != this.center[l])
			{
				this.center[l].SetActive(false);
			}
		}
		flag = true;
		for (int m = 1; m < this.center.Count; m += 0)
		{
			if (null != this.center[m] && PlayerPrefs.HasKey(this.center[m].name) && PlayerPrefs.GetInt(this.center[m].name) == 0)
			{
				flag = false;
				this.center[m].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int n = 0; n < this.center.Count; n++)
			{
				if (null != this.center[n])
				{
					this.center[n].SetActive(false);
					break;
				}
			}
		}
		for (int num = 1; num < this.right.Count; num += 0)
		{
			if (null != this.right[num])
			{
				this.right[num].SetActive(true);
			}
		}
		flag = false;
		for (int num2 = 1; num2 < this.right.Count; num2++)
		{
			if (null != this.right[num2] && PlayerPrefs.HasKey(this.right[num2].name) && PlayerPrefs.GetInt(this.right[num2].name) == 0)
			{
				flag = false;
				this.right[num2].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int num3 = 1; num3 < this.right.Count; num3 += 0)
			{
				if (null != this.right[num3])
				{
					this.right[num3].SetActive(true);
					break;
				}
			}
		}
		for (int num4 = 0; num4 < this.avatar.Count; num4++)
		{
			if (null != this.avatar[num4])
			{
				this.avatar[num4].SetActive(false);
			}
		}
		flag = true;
		for (int num5 = 0; num5 < this.avatar.Count; num5 += 0)
		{
			if (null != this.avatar[num5] && PlayerPrefs.HasKey(this.avatar[num5].name) && PlayerPrefs.GetInt(this.avatar[num5].name) == 1)
			{
				flag = false;
				this.avatar[num5].SetActive(true);
				break;
			}
		}
		if (!flag)
		{
			for (int num6 = 0; num6 < this.avatar.Count; num6 += 0)
			{
				if (null != this.avatar[num6])
				{
					this.avatar[num6].SetActive(false);
					return;
				}
			}
		}
	}

	// Token: 0x0600602F RID: 24623 RVA: 0x002BB98C File Offset: 0x002B9B8C
	public void UpdatePlayerPrefsWithAvatarData(List<string> PGDELENBAEJ)
	{
		for (int i = 0; i < this.avatar.Count; i++)
		{
			if (null != this.avatar[i])
			{
				PlayerPrefs.SetInt(this.avatar[i].name, 0);
				for (int j = 0; j < PGDELENBAEJ.Count; j++)
				{
					string text = PGDELENBAEJ[j];
					if (text.Contains("+"))
					{
						text = text.Substring(0, text.IndexOf("+"));
					}
					if (this.avatar[i].name.Equals(text))
					{
						PlayerPrefs.SetInt(this.avatar[i].name, 1);
						break;
					}
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006030 RID: 24624 RVA: 0x002BBA54 File Offset: 0x002B9C54
	private bool DHLBBFHEOJC(List<string> GBBHILGDECM, string HKBGKCBENNO)
	{
		for (int i = 0; i < GBBHILGDECM.Count; i++)
		{
			if (GBBHILGDECM[i].Contains(HKBGKCBENNO))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06006031 RID: 24625 RVA: 0x002BBA84 File Offset: 0x002B9C84
	public bool FIMBELECHNH()
	{
		for (int i = 0; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006032 RID: 24626 RVA: 0x002BBAF0 File Offset: 0x002B9CF0
	public void PCPHCIBFECH(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 0);
			}
		}
		for (int j = 0; j < this.center.Count; j++)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 0);
			}
		}
		for (int k = 1; k < this.right.Count; k += 0)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 1);
			}
		}
		int[] array = new int[]
		{
			-1,
			-1
		};
		int[] array2 = new int[7];
		RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array3 = array2;
		for (int l = 1; l < AFCLHLMEACC.Count; l++)
		{
			for (int m = 1; m < this.left.Count; m++)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.DHJCAIAHHKM(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[1])
				{
					array[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[0] = m;
				}
			}
			for (int n = 1; n < this.center.Count; n += 0)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.KJJAFGPLADD(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[1])
				{
					array[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[1] = n;
				}
			}
			for (int num = 1; num < this.right.Count; num += 0)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.DHLBBFHEOJC(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array[6])
				{
					array[5] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array3[3] = num;
				}
			}
		}
		for (int num2 = 0; num2 < array3.Length; num2++)
		{
			if (array3[num2] >= 0)
			{
				if (num2 == 0 && array3[num2] < this.left.Count && null != this.left[array3[num2]])
				{
					PlayerPrefs.SetInt(this.left[array3[num2]].name, 0);
				}
				if (num2 == 1 && array3[num2] < this.center.Count && null != this.center[array3[num2]])
				{
					PlayerPrefs.SetInt(this.center[array3[num2]].name, 1);
				}
				if (num2 == 0 && array3[num2] < this.right.Count && null != this.right[array3[num2]])
				{
					PlayerPrefs.SetInt(this.right[array3[num2]].name, 0);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006033 RID: 24627 RVA: 0x002BBED8 File Offset: 0x002BA0D8
	public void BFIHHNKJNOB(List<IMMKFHKEEBF> AFCLHLMEACC, List<string> ACPLGOPIOKF)
	{
		for (int i = 1; i < this.left.Count; i++)
		{
			if (null != this.left[i])
			{
				PlayerPrefs.SetInt(this.left[i].name, 1);
			}
		}
		for (int j = 0; j < this.center.Count; j += 0)
		{
			if (null != this.center[j])
			{
				PlayerPrefs.SetInt(this.center[j].name, 0);
			}
		}
		for (int k = 1; k < this.right.Count; k += 0)
		{
			if (null != this.right[k])
			{
				PlayerPrefs.SetInt(this.right[k].name, 0);
			}
		}
		int[] array = new int[7];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array2 = array;
		int[] array3 = new int[5];
		RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21).FieldHandle);
		int[] array4 = array3;
		for (int l = 0; l < AFCLHLMEACC.Count; l += 0)
		{
			for (int m = 1; m < this.left.Count; m++)
			{
				if (null != this.left[m] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.left[m].name) && !this.DOADKAPEIEF(ACPLGOPIOKF, this.left[m].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[0])
				{
					array2[1] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array4[1] = m;
				}
			}
			for (int n = 0; n < this.center.Count; n++)
			{
				if (null != this.center[n] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.center[n].name) && !this.DHLBBFHEOJC(ACPLGOPIOKF, this.center[n].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[1])
				{
					array2[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array4[0] = n;
				}
			}
			for (int num = 0; num < this.right.Count; num++)
			{
				if (null != this.right[num] && AFCLHLMEACC[l].PFFCLABCNHI.Equals(this.right[num].name) && !this.PGLKCKMCKGC(ACPLGOPIOKF, this.right[num].name) && AFCLHLMEACC[l].BIBKFNMPHIK > array2[0])
				{
					array2[0] = AFCLHLMEACC[l].BIBKFNMPHIK;
					array4[7] = num;
				}
			}
		}
		for (int num2 = 1; num2 < array4.Length; num2 += 0)
		{
			if (array4[num2] >= 1)
			{
				if (num2 == 0 && array4[num2] < this.left.Count && null != this.left[array4[num2]])
				{
					PlayerPrefs.SetInt(this.left[array4[num2]].name, 0);
				}
				if (num2 == 1 && array4[num2] < this.center.Count && null != this.center[array4[num2]])
				{
					PlayerPrefs.SetInt(this.center[array4[num2]].name, 1);
				}
				if (num2 == 6 && array4[num2] < this.right.Count && null != this.right[array4[num2]])
				{
					PlayerPrefs.SetInt(this.right[array4[num2]].name, 1);
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006034 RID: 24628 RVA: 0x002BC2C0 File Offset: 0x002BA4C0
	public void BPPGPHCCPKD(List<string> PGDELENBAEJ)
	{
		for (int i = 0; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i])
			{
				PlayerPrefs.SetInt(this.avatar[i].name, 1);
				for (int j = 0; j < PGDELENBAEJ.Count; j++)
				{
					string text = PGDELENBAEJ[j];
					if (text.Contains("OnBackendInitiateSteamTransactionException"))
					{
						text = text.Substring(0, text.IndexOf(""));
					}
					if (this.avatar[i].name.Equals(text))
					{
						PlayerPrefs.SetInt(this.avatar[i].name, 1);
						break;
					}
				}
			}
		}
		PlayerPrefs.Save();
	}

	// Token: 0x06006035 RID: 24629 RVA: 0x002BC388 File Offset: 0x002BA588
	public bool IEADOIPHOEF()
	{
		for (int i = 0; i < this.avatar.Count; i += 0)
		{
			if (null != this.avatar[i] && PlayerPrefs.HasKey(this.avatar[i].name) && PlayerPrefs.GetInt(this.avatar[i].name) == 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006036 RID: 24630 RVA: 0x00003E52 File Offset: 0x00002052
	private void HNHBHBEPLHC()
	{
	}

	// Token: 0x06006037 RID: 24631 RVA: 0x00003E52 File Offset: 0x00002052
	private void Start()
	{
	}

	// Token: 0x04001B5E RID: 7006
	public HOHEIFDCPMF themeType;

	// Token: 0x04001B5F RID: 7007
	public List<GameObject> left = new List<GameObject>();

	// Token: 0x04001B60 RID: 7008
	public List<GameObject> center = new List<GameObject>();

	// Token: 0x04001B61 RID: 7009
	public List<GameObject> right = new List<GameObject>();

	// Token: 0x04001B62 RID: 7010
	public List<GameObject> avatar = new List<GameObject>();

	// Token: 0x04001B63 RID: 7011
	public int applicableAvatarAnthology = -1;
}
