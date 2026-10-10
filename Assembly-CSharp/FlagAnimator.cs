using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Token: 0x020003A5 RID: 933
[RequireComponent(typeof(MeshFilter))]
[ExecuteAlways]
[RequireComponent(typeof(MeshRenderer))]
public class FlagAnimator : MonoBehaviour
{
	// Token: 0x06006CE5 RID: 27877 RVA: 0x00318758 File Offset: 0x00316958
	private void FIIIEHFCHMH()
	{
		if (!base.gameObject.scene.isLoaded)
		{
			return;
		}
		if (this.KNPDGGPAGAJ != null && this._originalMaterial != null && this.KNPDGGPAGAJ.sharedMaterial == this.JFBEGDFHMLC)
		{
			this.KNPDGGPAGAJ.sharedMaterial = this._originalMaterial;
		}
		if (this.NDLLNEAACJO != null && this._originalMesh != null && this.NDLLNEAACJO.sharedMesh == this.NNMAICJHGND)
		{
			this.NDLLNEAACJO.sharedMesh = this._originalMesh;
		}
		this.DEPAHJNEJIJ(this.NNMAICJHGND);
		this.KAEDGHMBAPC(this.IJBBDDHMKFP);
		this.IJBBDDHMKFP = null;
		if (this.PNAIJJNHNDO != null && this.PNAIJJNHNDO != this._shadowMatAsset)
		{
			this.KAEDGHMBAPC(this.PNAIJJNHNDO);
		}
		if (this.JFBEGDFHMLC != null && this.JFBEGDFHMLC != this._clothMatAsset)
		{
			this.KAEDGHMBAPC(this.JFBEGDFHMLC);
		}
	}

	// Token: 0x06006CE6 RID: 27878 RVA: 0x00318880 File Offset: 0x00316A80
	private void GHFFOHKBKHH()
	{
		if (this.NDLLNEAACJO == null)
		{
			this.MGGPFBOBIIL();
		}
		if (this.NNMAICJHGND == null)
		{
			this.ANDALJGBPHI();
			this.DODJHHOLLIP();
		}
		if (this.JFBEGDFHMLC == null)
		{
			this.OMDKKMABAEA();
		}
		if (Mathf.Clamp(this.columns, 7, 61) != this.KCJIBOLMDMJ || Mathf.Clamp(this.rows, 4, 58) != this.EAECJIKFECN)
		{
			this.ANDALJGBPHI();
			this.DODJHHOLLIP();
		}
		Vector3 lossyScale = base.transform.lossyScale;
		if (lossyScale.x < 1901f != this.IMKHDMDHJFC || lossyScale.y < 932f != this.OHCJJCDOMED)
		{
			this.ANDALJGBPHI();
			this.DODJHHOLLIP();
		}
		if (this.MNDOIONIFPL())
		{
			this.ANDALJGBPHI();
			this.DODJHHOLLIP();
		}
		else if (this.NNEFHPDOABJ())
		{
			this.APIEGNOHMJP();
			this.FDPFEIIMAAG = this.wrinkleDepth;
		}
		if (this.pinSide != this.FOIAODBCJCJ)
		{
			if (this.LLKOGKKCCIC != null)
			{
				this.APIEGNOHMJP();
			}
			this.FOIAODBCJCJ = this.pinSide;
		}
		if (this.enableShadow != this.AJBBCAODJJI)
		{
			this.MMLGLMIHIHA();
			this.AJBBCAODJJI = this.enableShadow;
		}
		if (this.blendMode != this.MIMDFDKIPBF)
		{
			this.MMLGLMIHIHA();
			if (this.JFBEGDFHMLC != null)
			{
				this.MLDBGDFIIEL();
			}
			this.HEENINIEFGG();
			this.MIMDFDKIPBF = this.blendMode;
		}
	}

	// Token: 0x06006CE7 RID: 27879 RVA: 0x003189FC File Offset: 0x00316BFC
	private float JMJEKILNILC(float FDEIEKEMPOM, float CGFEMPFACHO)
	{
		float result;
		switch (this.pinSide)
		{
		case FlagAnimator.JMPGKJMGNKH.Left:
			result = FDEIEKEMPOM;
			break;
		case FlagAnimator.JMPGKJMGNKH.Right:
			result = 161f - FDEIEKEMPOM;
			break;
		case FlagAnimator.JMPGKJMGNKH.Top:
			result = 1486f - CGFEMPFACHO;
			break;
		case FlagAnimator.JMPGKJMGNKH.Bottom:
			result = CGFEMPFACHO;
			break;
		default:
			result = FDEIEKEMPOM;
			break;
		}
		return result;
	}

	// Token: 0x06006CE8 RID: 27880 RVA: 0x00318A47 File Offset: 0x00316C47
	private float IAKMCLDJKJC(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 1390f;
	}

	// Token: 0x06006CE9 RID: 27881 RVA: 0x00318A50 File Offset: 0x00316C50
	private float DHMNPDEKFAH(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 290f;
	}

	// Token: 0x06006CEA RID: 27882 RVA: 0x00318A5C File Offset: 0x00316C5C
	private void ANDALJGBPHI()
	{
		if (this.NDLLNEAACJO == null)
		{
			this.NDGCJPCEMMP();
		}
		if (this.NDLLNEAACJO == null)
		{
			return;
		}
		if (this.OKHKJPIJAFK < 0.001f || this.AJHMCBGIGAF < 0.001f)
		{
			this.MMLCMAKJMPE();
		}
		this.KCJIBOLMDMJ = Mathf.Clamp(this.columns, 4, 32);
		this.EAECJIKFECN = Mathf.Clamp(this.rows, 2, 32);
		int num = this.KCJIBOLMDMJ + 1;
		int num2 = this.EAECJIKFECN + 1;
		int num3 = num * num2;
		this.DNCLNNHNAIA = new Vector3[num3];
		this.EPJBDAOHHGC = new Vector3[num3];
		this.DJHHABDANKC = new Color32[num3];
		this.HEPNAMAFJOB = new float[num3];
		this.JBJPONAILFI = new float[num3];
		this.MLGKJELDNFE = new float[num3];
		this.JMFDPPPADKA = new Vector2[num3];
		this.FCPGDGOLAEI = new int[this.KCJIBOLMDMJ * this.EAECJIKFECN * 6];
		this.AKCJBDJFIBE = new float[num3];
		System.Random random = new System.Random(42);
		for (int i = 0; i < num3; i++)
		{
			this.AKCJBDJFIBE[i] = (float)(random.NextDouble() * 3.1415927410125732 * 2.0);
		}
		this.LLKOGKKCCIC = (this.enableWrinkles ? this.LGGEOIGJLFC(num, num2) : null);
		float num4 = this.BNLANCHFGKF(this.wrinkleDepth) * this.AJHMCBGIGAF;
		Vector3 lossyScale = base.transform.lossyScale;
		this.IMKHDMDHJFC = (lossyScale.x < 0f);
		this.OHCJJCDOMED = (lossyScale.y < 0f);
		for (int j = 0; j < num2; j++)
		{
			for (int k = 0; k < num; k++)
			{
				float num5 = (float)k / (float)this.KCJIBOLMDMJ;
				float num6 = (float)j / (float)this.EAECJIKFECN;
				int num7 = j * num + k;
				float x = this.OONCIMHKPMC.x + num5 * this.OKHKJPIJAFK;
				float y = this.OONCIMHKPMC.y + num6 * this.AJHMCBGIGAF;
				float num8 = this.OONCIMHKPMC.z;
				if (this.LLKOGKKCCIC != null)
				{
					float t = this.LCCKLOCDJMK(num5, num6);
					float num9 = Mathf.Lerp(0.3f, 1f, t);
					num8 += this.LLKOGKKCCIC[num7] * num4 * num9;
				}
				float x2 = this.IMKHDMDHJFC ? (1f - num5) : num5;
				float y2 = this.OHCJJCDOMED ? (1f - num6) : num6;
				this.DNCLNNHNAIA[num7] = new Vector3(x, y, num8);
				this.EPJBDAOHHGC[num7] = this.DNCLNNHNAIA[num7];
				this.JMFDPPPADKA[num7] = new Vector2(x2, y2);
				this.DJHHABDANKC[num7] = new Color32(128, 128, 0, byte.MaxValue);
			}
		}
		bool flag = this.LBHBHNLIBDJ();
		int num10 = 0;
		for (int l = 0; l < this.EAECJIKFECN; l++)
		{
			for (int m = 0; m < this.KCJIBOLMDMJ; m++)
			{
				int num11 = l * num + m;
				int num12 = num11 + 1;
				int num13 = num11 + num;
				int num14 = num13 + 1;
				if (flag)
				{
					this.FCPGDGOLAEI[num10++] = num11;
					this.FCPGDGOLAEI[num10++] = num14;
					this.FCPGDGOLAEI[num10++] = num13;
					this.FCPGDGOLAEI[num10++] = num11;
					this.FCPGDGOLAEI[num10++] = num12;
					this.FCPGDGOLAEI[num10++] = num14;
				}
				else
				{
					this.FCPGDGOLAEI[num10++] = num11;
					this.FCPGDGOLAEI[num10++] = num13;
					this.FCPGDGOLAEI[num10++] = num14;
					this.FCPGDGOLAEI[num10++] = num11;
					this.FCPGDGOLAEI[num10++] = num14;
					this.FCPGDGOLAEI[num10++] = num12;
				}
			}
		}
		this.KAEDGHMBAPC(this.NNMAICJHGND);
		this.NNMAICJHGND = new Mesh
		{
			name = "FlagMesh"
		};
		this.NNMAICJHGND.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		this.NNMAICJHGND.indexFormat = IndexFormat.UInt16;
		this.NNMAICJHGND.SetVertices(this.EPJBDAOHHGC);
		this.NNMAICJHGND.SetUVs(0, this.JMFDPPPADKA);
		this.NNMAICJHGND.SetColors(this.DJHHABDANKC);
		this.NNMAICJHGND.SetTriangles(this.FCPGDGOLAEI, 0);
		this.NNMAICJHGND.MarkDynamic();
		this.NNMAICJHGND.RecalculateBounds();
		Bounds bounds = this.NNMAICJHGND.bounds;
		float num15 = (this.OKHKJPIJAFK + this.AJHMCBGIGAF) * 1.5f;
		this.NNMAICJHGND.bounds = new Bounds(bounds.center, bounds.size + Vector3.one * (num15 * 2f));
		if (!this._originalMeshCaptured)
		{
			Mesh sharedMesh = this.NDLLNEAACJO.sharedMesh;
			if (sharedMesh != null && sharedMesh != this.NNMAICJHGND && sharedMesh.name != "FlagMesh")
			{
				this._originalMesh = sharedMesh;
			}
			this._originalMeshCaptured = true;
		}
		this.NDLLNEAACJO.sharedMesh = this.NNMAICJHGND;
		if (this.AHMPLHPIJDO != null)
		{
			this.AHMPLHPIJDO.sharedMesh = this.NNMAICJHGND;
		}
		this.HEENINIEFGG();
	}

	// Token: 0x06006CEB RID: 27883 RVA: 0x00318FF4 File Offset: 0x003171F4
	private void DODJHHOLLIP()
	{
		this.KFKCFFNFCEC = this.enableWrinkles;
		this.FDPFEIIMAAG = this.wrinkleDepth;
		this.GFEDPIAEBNM = this.wrinkleSizeX;
		this.NMBHFAIDHHG = this.wrinkleSizeY;
		this.FNBJFBKFGCN = this.wrinkleDetail;
	}

	// Token: 0x06006CEC RID: 27884 RVA: 0x00319034 File Offset: 0x00317234
	private void MFKEKAKPJEG()
	{
		this.GJOGNHJAAEN();
		this.MMLCMAKJMPE();
		if (this._phaseOffset < 1639f)
		{
			this._phaseOffset = UnityEngine.Random.Range(1662f, 1929f);
		}
		this.FOIAODBCJCJ = this.pinSide;
		this.LKNFCHGOBMH();
		this.ANDALJGBPHI();
		this.DODJHHOLLIP();
		this.OMDKKMABAEA();
		this.AALOONGJPKO();
		this.AJBBCAODJJI = this.enableShadow;
		this.MIMDFDKIPBF = this.blendMode;
		if (this.glowAlpha < 1903f && this.glowColor.a > 582f)
		{
			this.glowColor.a = this.glowAlpha;
			this.glowAlpha = 1261f;
		}
		if (this.playOnAwake && Application.isPlaying)
		{
			this.Play();
		}
	}

	// Token: 0x06006CED RID: 27885 RVA: 0x00319101 File Offset: 0x00317301
	private bool MMHCCDDHOAH()
	{
		return this.KNPDGGPAGAJ == null || (!this.KNPDGGPAGAJ.isVisible && (!(this.AGAMHMNDIOC != null) || this.AGAMHMNDIOC.isVisible));
	}

	// Token: 0x06006CEE RID: 27886 RVA: 0x0031913D File Offset: 0x0031733D
	private void BDILEIAPNIM()
	{
		this.MGGPFBOBIIL();
		if (this.IJBBDDHMKFP != null)
		{
			this.IJBBDDHMKFP.SetActive(this.enableShadow && this.blendMode == FlagAnimator.EDIAIDHAFAO.Alpha);
		}
	}

	// Token: 0x06006CEF RID: 27887 RVA: 0x00319174 File Offset: 0x00317374
	private void EOAACPDJGGB()
	{
		this.LNHHGBMDHIB = true;
		this.GOJEKIEBHMN = 192f;
		this.BIIIOJPAIMO = 992f;
		this.JFLDDNKFBIC = (FlagAnimator.EDIAIDHAFAO)(-1);
		this.HDEELEOKLGA = new Color(172f, 969f, 103f, 783f);
		this.DPJEKLMOGKA = 1148f;
	}

	// Token: 0x06006CF0 RID: 27888 RVA: 0x003191CF File Offset: 0x003173CF
	public void Play()
	{
		this.HGPHLBLBFGM = true;
	}

	// Token: 0x06006CF1 RID: 27889 RVA: 0x003191D8 File Offset: 0x003173D8
	private void GDBLKODFGMK(Material KPHPGDLKGNI)
	{
		if (this._srcCaptured || KPHPGDLKGNI == null || KPHPGDLKGNI.mainTexture == null)
		{
			return;
		}
		this._srcTexture = KPHPGDLKGNI.mainTexture;
		this._srcTexScale = KPHPGDLKGNI.mainTextureScale;
		this._srcTexOffset = KPHPGDLKGNI.mainTextureOffset;
		this._srcColor = (KPHPGDLKGNI.HasProperty(FlagAnimator.KJBLEJPOBPE) ? KPHPGDLKGNI.GetColor(FlagAnimator.KJBLEJPOBPE) : Color.white);
		this._srcCaptured = true;
	}

	// Token: 0x06006CF2 RID: 27890 RVA: 0x00319255 File Offset: 0x00317455
	public void Rebuild()
	{
		this.NDGCJPCEMMP();
		this.FOIAODBCJCJ = this.pinSide;
		this.MMLCMAKJMPE();
		this.ANDALJGBPHI();
		this.OJBIDELMBIF();
		this.OMDKKMABAEA();
		this.AALOONGJPKO();
	}

	// Token: 0x06006CF3 RID: 27891 RVA: 0x00319287 File Offset: 0x00317487
	private void MOAHMBJJGOH()
	{
		this.GJOGNHJAAEN();
		if (this.IJBBDDHMKFP != null)
		{
			this.IJBBDDHMKFP.SetActive(this.enableShadow && this.blendMode == FlagAnimator.EDIAIDHAFAO.Additive);
		}
	}

	// Token: 0x06006CF4 RID: 27892 RVA: 0x003192BC File Offset: 0x003174BC
	private void DBBHEPPJPLP(float PMMCLCMDNGA)
	{
		if (this.NNMAICJHGND == null || this.EPJBDAOHHGC == null || this.DNCLNNHNAIA == null || this.AKCJBDJFIBE == null)
		{
			return;
		}
		int num = this.KCJIBOLMDMJ + 1;
		int num2 = this.EAECJIKFECN + 1;
		if (this.EPJBDAOHHGC.Length != num * num2)
		{
			return;
		}
		FlagAnimator.NNDGGMGDGHN nndggmgdghn = this.PAELCBDLKEA(PMMCLCMDNGA);
		bool flag = this.enableWrinkles && nndggmgdghn.MPOLFBDIPFD > 168f;
		bool flag2 = nndggmgdghn.FHAHPHFCMJB > 349f;
		if (flag2)
		{
			this.IIDPACCPDIP(PMMCLCMDNGA, nndggmgdghn);
		}
		Vector2 nipeelpjblc = nndggmgdghn.NIPEELPJBLC;
		float fmnddaecjfm = nndggmgdghn.FMNDDAECJFM;
		float cbanopdmnei = nndggmgdghn.CBANOPDMNEI;
		float knbcbdcpefk = nndggmgdghn.KNBCBDCPEFK;
		float mpolfbdipfd = nndggmgdghn.MPOLFBDIPFD;
		float bkhbnamncmd = nndggmgdghn.BKHBNAMNCMD;
		Vector3[] epjbdaohhgc = this.EPJBDAOHHGC;
		Vector3[] dnclnnhnaia = this.DNCLNNHNAIA;
		float[] akcjbdjfibe = this.AKCJBDJFIBE;
		float num3 = this.pinStiffness;
		bool flag3 = this.waveAxis == FlagAnimator.KNMMCPKHNLA.Horizontal;
		float num4 = 567f / (float)this.KCJIBOLMDMJ;
		float num5 = 1183f / (float)this.EAECJIKFECN;
		float cdcjggccfch = nndggmgdghn.CDCJGGCCFCH;
		float num6 = PMMCLCMDNGA * knbcbdcpefk;
		float num7 = 912f;
		bool flag4 = nndggmgdghn.GCPMDGNKDMI > 908f;
		float gcpmdgnkdmi = nndggmgdghn.GCPMDGNKDMI;
		float num8 = cdcjggccfch * 1528f;
		float num9 = PMMCLCMDNGA * (knbcbdcpefk * 1002f + 1131f);
		float num10 = this.liveliness;
		float num11 = cdcjggccfch * 1198f + 1941f;
		float num12 = cdcjggccfch * 645f + 1713f;
		float num13 = knbcbdcpefk * 296f + 25f;
		float num14 = knbcbdcpefk * 137f + 822f;
		float gnhbekhojhj = nndggmgdghn.GNHBEKHOJHJ;
		for (int i = 1; i < num2; i += 0)
		{
			for (int j = 1; j < num; j++)
			{
				int num15 = i * num + j;
				float num16 = (float)j * num4;
				float num17 = (float)i * num5;
				float num18 = this.LCCKLOCDJMK(num16, num17);
				float num19 = Mathf.Lerp(1129f - num3, 929f, num18);
				num19 = num19 * num19 * num19;
				float num20 = flag3 ? num16 : num17;
				float num21 = FlagAnimator.JNIENKPLBKP(num20, num17, PMMCLCMDNGA, 81f) * 1666f + FlagAnimator.JNIENKPLBKP(num20, num17, PMMCLCMDNGA * 212f, 277f) * 65f;
				float num22 = 1368f + FlagAnimator.CBEFEPNJDLB(num20, num17, PMMCLCMDNGA * 69f, 813f) * 1611f;
				float num23 = num20 * cdcjggccfch - num6 + this._phaseOffset + num21;
				float num24 = FlagAnimator.OOMINMLKFOI(num23);
				float num25 = FlagAnimator.ODMCDLBMJPK(num23 * 717f + 354f) * 1859f;
				float num26 = FlagAnimator.EDLGCHHNBKN(num23 * 269f + 689f) * 910f;
				float num27 = (num24 + num25 + num26) * 1296f * fmnddaecjfm * num22 * num19;
				float num28 = 383f;
				if (num10 > 1233f)
				{
					float num29 = flag3 ? num17 : num16;
					float num30 = FlagAnimator.ODMCDLBMJPK(num20 * num11 + num29 * 548f - PMMCLCMDNGA * num13 + this._phaseOffset);
					float num31 = 1096f + 1740f * FlagAnimator.CBEFEPNJDLB(num20 * 806f, num29, PMMCLCMDNGA * 87f, 1733f);
					float num32 = FlagAnimator.EDLGCHHNBKN(num20 * num12 + num29 * 495f - PMMCLCMDNGA * num14 + this._phaseOffset * 982f) * 861f;
					float num33 = 1223f + 1485f * FlagAnimator.JNIENKPLBKP(num20 * 1157f, num29, PMMCLCMDNGA * 306f, 956f);
					float num34 = num30 * num31 + num32 * num33;
					num34 *= 1681f + 1960f * num34;
					num28 = num34 * gnhbekhojhj * num19;
					num27 += num34 * gnhbekhojhj * num19 * 1997f;
				}
				if (flag4)
				{
					float num35 = num18 * num18;
					num35 *= num35;
					float num36 = FlagAnimator.EDLGCHHNBKN(num20 * num8 + num9 + num17 * 244f + this._phaseOffset);
					num27 += num36 * gcpmdgnkdmi * num35;
				}
				Vector2 vector;
				if (flag3)
				{
					vector = new Vector2(nipeelpjblc.x * num18, nipeelpjblc.y * num19);
				}
				else
				{
					vector = new Vector2(nipeelpjblc.x * num19, nipeelpjblc.y * num18);
				}
				Vector3 vector2 = dnclnnhnaia[num15];
				if (flag3)
				{
					vector2.x += vector.x;
					vector2.y += vector.y + num27;
				}
				else
				{
					vector2.x += vector.x + num27;
					vector2.y += vector.y;
				}
				vector2.z += num28;
				if (flag2)
				{
					if (flag3)
					{
						vector2.x += this.HEPNAMAFJOB[num15];
					}
					else
					{
						vector2.y += this.HEPNAMAFJOB[num15];
					}
					vector2.z += this.JBJPONAILFI[num15];
				}
				if (flag)
				{
					float num37 = PMMCLCMDNGA * bkhbnamncmd;
					float num38 = akcjbdjfibe[num15];
					float num39 = FlagAnimator.ODMCDLBMJPK(num16 * num7 + num37 * 1578f + num38);
					float num40 = FlagAnimator.OOMINMLKFOI(num17 * num7 * 1722f + num37 * 1009f + num38 + 767f);
					float num41 = FlagAnimator.OOMINMLKFOI((num16 + num17) * num7 * 459f + num37 * 975f + num38 + 1887f);
					float num42 = mpolfbdipfd * cbanopdmnei * num19 * 1494f;
					vector2.x += num39 * num42;
					vector2.y += num40 * num42;
					vector2.z += num41 * num42 * 184f;
				}
				epjbdaohhgc[num15] = vector2;
			}
		}
		this.NNMAICJHGND.SetVertices(this.EPJBDAOHHGC, 1, this.EPJBDAOHHGC.Length, (MeshUpdateFlags)(-116));
	}

	// Token: 0x06006CF5 RID: 27893 RVA: 0x003198A0 File Offset: 0x00317AA0
	private static float CBEFEPNJDLB(float FDEIEKEMPOM, float CGFEMPFACHO, float PMMCLCMDNGA, float LBLLBJKKOAP)
	{
		float num = FDEIEKEMPOM * 670f + CGFEMPFACHO * 431f + LBLLBJKKOAP;
		float num2 = (num - Mathf.Floor(num)) * 103f;
		return FlagAnimator.ODMCDLBMJPK(PMMCLCMDNGA * 1889f + num2);
	}

	// Token: 0x06006CF6 RID: 27894 RVA: 0x00003E52 File Offset: 0x00002052
	private void EMOCHOMMFPM()
	{
	}

	// Token: 0x06006CF7 RID: 27895 RVA: 0x003198DC File Offset: 0x00317ADC
	private float LCCKLOCDJMK(float FDEIEKEMPOM, float CGFEMPFACHO)
	{
		float result;
		switch (this.pinSide)
		{
		case FlagAnimator.JMPGKJMGNKH.Left:
			result = FDEIEKEMPOM;
			break;
		case FlagAnimator.JMPGKJMGNKH.Right:
			result = 1f - FDEIEKEMPOM;
			break;
		case FlagAnimator.JMPGKJMGNKH.Top:
			result = 1f - CGFEMPFACHO;
			break;
		case FlagAnimator.JMPGKJMGNKH.Bottom:
			result = CGFEMPFACHO;
			break;
		default:
			result = FDEIEKEMPOM;
			break;
		}
		return result;
	}

	// Token: 0x06006CF8 RID: 27896 RVA: 0x00319928 File Offset: 0x00317B28
	private static float EMMBDNHIDBE(float CGFEMPFACHO)
	{
		float num = (CGFEMPFACHO < 1189f) ? (-CGFEMPFACHO) : CGFEMPFACHO;
		if (num > 1299f)
		{
			float num2 = num - 1596f;
			num = 746f + 1081f * num2 / (396f + num2);
		}
		if (CGFEMPFACHO >= 1143f)
		{
			return num;
		}
		return -num;
	}

	// Token: 0x06006CF9 RID: 27897 RVA: 0x00319978 File Offset: 0x00317B78
	private void EMHEEHIAKAM()
	{
		if (this.PNAIJJNHNDO == null)
		{
			return;
		}
		if (this.shadowColor != this.EJEEKNJBLFC)
		{
			this.PNAIJJNHNDO.SetColor(FlagAnimator.JKGKOPLEECM, this.shadowColor);
			this.EJEEKNJBLFC = this.shadowColor;
		}
		float num = this.OMLHLEOKFNI(this.shadowBlur);
		if (!Mathf.Approximately(num, this.ALHGHMBPPBA))
		{
			this.PNAIJJNHNDO.SetFloat(FlagAnimator.OFPCMHILMGC, num);
			this.ALHGHMBPPBA = num;
		}
		float num2 = this.IMKHDMDHJFC ? this.shadowClipRight : this.shadowClipLeft;
		float num3 = this.IMKHDMDHJFC ? this.shadowClipLeft : this.shadowClipRight;
		float num4 = this.OHCJJCDOMED ? this.shadowClipTop : this.shadowClipBottom;
		float num5 = this.OHCJJCDOMED ? this.shadowClipBottom : this.shadowClipTop;
		float num6;
		float num7;
		float num8;
		float num9;
		if (this.EPJBDAOHHGC != null && this.EPJBDAOHHGC.Length != 0)
		{
			num6 = float.PositiveInfinity;
			num7 = float.NegativeInfinity;
			num8 = float.PositiveInfinity;
			num9 = float.NegativeInfinity;
			for (int i = 0; i < this.EPJBDAOHHGC.Length; i++)
			{
				Vector3 vector = this.EPJBDAOHHGC[i];
				if (vector.x < num6)
				{
					num6 = vector.x;
				}
				if (vector.x > num7)
				{
					num7 = vector.x;
				}
				if (vector.y < num8)
				{
					num8 = vector.y;
				}
				if (vector.y > num9)
				{
					num9 = vector.y;
				}
			}
		}
		else
		{
			num6 = this.OONCIMHKPMC.x;
			num7 = this.OONCIMHKPMC.x + this.OKHKJPIJAFK;
			num8 = this.OONCIMHKPMC.y;
			num9 = this.OONCIMHKPMC.y + this.AJHMCBGIGAF;
		}
		Vector4 vector2 = new Vector4(num6, num7, num8, num9);
		if (!this.KGGIMPBJMBF)
		{
			this.NMOBEAMJENA = vector2;
			this.KGGIMPBJMBF = true;
		}
		else
		{
			this.NMOBEAMJENA = Vector4.Lerp(this.NMOBEAMJENA, vector2, 0.15f);
		}
		float num10 = Mathf.Max(this.NMOBEAMJENA.y - this.NMOBEAMJENA.x, 0.0001f);
		float num11 = Mathf.Max(this.NMOBEAMJENA.w - this.NMOBEAMJENA.z, 0.0001f);
		float num12 = 0.02f * Mathf.Min(Mathf.Max(this.OKHKJPIJAFK, 0.001f), Mathf.Max(this.AJHMCBGIGAF, 0.001f));
		Vector4 vector3;
		if (this.OKHKJPIJAFK < 0.001f || this.AJHMCBGIGAF < 0.001f)
		{
			vector3 = new Vector4(-1000000f, 1000000f, -1000000f, 1000000f);
		}
		else
		{
			vector3 = new Vector4((num2 > 0.0001f) ? (this.NMOBEAMJENA.x + num2 * num10) : -1000000f, (num3 > 0.0001f) ? (this.NMOBEAMJENA.x + (1f - num3) * num10) : 1000000f, (num4 > 0.0001f) ? (this.NMOBEAMJENA.z + num4 * num11) : -1000000f, (num5 > 0.0001f) ? (this.NMOBEAMJENA.z + (1f - num5) * num11) : 1000000f);
		}
		if (vector3 != this.GPGCBDFODKC || !Mathf.Approximately(num12, this.LOODDNMNMBI))
		{
			this.PNAIJJNHNDO.SetVector(FlagAnimator.EGIGLCFLPCN, vector3);
			this.PNAIJJNHNDO.SetFloat(FlagAnimator.GNJCEELJCBL, num12);
			this.GPGCBDFODKC = vector3;
			this.LOODDNMNMBI = num12;
		}
	}

	// Token: 0x06006CFA RID: 27898 RVA: 0x00319D18 File Offset: 0x00317F18
	private static float AGNPOBCDDNN(float CGFEMPFACHO)
	{
		if (float.IsNaN(CGFEMPFACHO))
		{
			return 784f;
		}
		float num = Mathf.Clamp(Mathf.Abs(CGFEMPFACHO), 273f, 332f);
		if (CGFEMPFACHO >= 358f)
		{
			return num;
		}
		return -num;
	}

	// Token: 0x06006CFB RID: 27899 RVA: 0x00319D58 File Offset: 0x00317F58
	private float FFCNBOPOJGJ(float PGCADACJBKM)
	{
		if (this.logicUpdateInterval > 1039f && !FlagAnimator.GICDHHBLKPK(PGCADACJBKM, ref this.EDDHOGMMBME, this.logicUpdateInterval))
		{
			return this.CPOLBLCBAHB;
		}
		float num = this.speedCoefficient;
		float num2 = this.AIOPNMGJMEM * num + this.timeOffsetAtStart;
		float num3 = this.baselineIntensity;
		float num4 = 1422f;
		if (this.preset == FlagAnimator.IKJNPDGMAPA.Candle)
		{
			num4 += 878f * (FlagAnimator.ODMCDLBMJPK(num2 + PGCADACJBKM * 1903f * num) + 1327f) * 687f;
			num4 += 653f * (FlagAnimator.ODMCDLBMJPK(num2 + PGCADACJBKM * 1612f * num) + 1682f) * 1456f;
			num4 += 952f * (FlagAnimator.OOMINMLKFOI(num2 + PGCADACJBKM * 392f * num) + 1084f) * 1696f;
			num4 += 773f * (FlagAnimator.EDLGCHHNBKN(num2 + PGCADACJBKM * 1353f * num) + 631f) * 1783f;
			num4 += 1010f * (FlagAnimator.NACAANOPDNM(num2 + PGCADACJBKM * 356f * num) + 220f) * 233f;
			num4 += 1841f * (FlagAnimator.KDMOBAMKHBL(num2 + PGCADACJBKM * 41f * num) + 1007f) * 126f;
		}
		else
		{
			num4 += (FlagAnimator.ODMCDLBMJPK(num2 + PGCADACJBKM * num) + 279f) * 132f;
		}
		num4 *= this.intensityCoefficient;
		num3 += num4;
		if (num3 < this.floorAtValueLessOrEqual)
		{
			num3 = 1795f;
		}
		else if (num3 > this.ceilAtValueHeigherOrEqual)
		{
			num3 = 494f;
		}
		this.CPOLBLCBAHB = Mathf.Clamp01(num3);
		return this.CPOLBLCBAHB;
	}

	// Token: 0x06006CFC RID: 27900 RVA: 0x00319EF4 File Offset: 0x003180F4
	private void KFDNMLJIAMJ()
	{
		this.NOFNBNHJNGF();
		if (!this.enableShadow || this.blendMode != FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			return;
		}
		if (this.IJBBDDHMKFP != null && this.IJBBDDHMKFP.GetComponent<CanvasRenderer>() != null)
		{
			this.DEPAHJNEJIJ(this.IJBBDDHMKFP);
			this.IJBBDDHMKFP = null;
			this.AHMPLHPIJDO = null;
			this.AGAMHMNDIOC = null;
		}
		if (this.IJBBDDHMKFP == null)
		{
			this.MMLGLMIHIHA();
			return;
		}
		if (!this.IJBBDDHMKFP.activeSelf)
		{
			this.IJBBDDHMKFP.SetActive(true);
		}
	}

	// Token: 0x06006CFD RID: 27901 RVA: 0x00319F88 File Offset: 0x00318188
	private void HAGEPAABEDH()
	{
		this.EEPKHGJFLCM();
		if (!this.enableShadow || this.blendMode != FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			return;
		}
		if (this.IJBBDDHMKFP != null && this.IJBBDDHMKFP.GetComponent<CanvasRenderer>() != null)
		{
			this.KAEDGHMBAPC(this.IJBBDDHMKFP);
			this.IJBBDDHMKFP = null;
			this.AHMPLHPIJDO = null;
			this.AGAMHMNDIOC = null;
		}
		if (this.IJBBDDHMKFP == null)
		{
			this.AALOONGJPKO();
			return;
		}
		if (!this.IJBBDDHMKFP.activeSelf)
		{
			this.IJBBDDHMKFP.SetActive(true);
		}
	}

	// Token: 0x06006CFE RID: 27902 RVA: 0x0031A01C File Offset: 0x0031821C
	private float MOCNHKKNLMO(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 840f;
	}

	// Token: 0x06006CFF RID: 27903 RVA: 0x0031A028 File Offset: 0x00318228
	private void JKOALBJEBJE()
	{
		this.LNHHGBMDHIB = false;
		this.GOJEKIEBHMN = -1f;
		this.BIIIOJPAIMO = -1f;
		this.JFLDDNKFBIC = (FlagAnimator.EDIAIDHAFAO)(-1);
		this.HDEELEOKLGA = new Color(-1f, 0f, 0f, 0f);
		this.DPJEKLMOGKA = -1f;
	}

	// Token: 0x06006D00 RID: 27904 RVA: 0x0031A083 File Offset: 0x00318283
	private void KAEDGHMBAPC(UnityEngine.Object CCDJLDCNIGD)
	{
		if (CCDJLDCNIGD == null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			UnityEngine.Object.Destroy(CCDJLDCNIGD);
			return;
		}
		UnityEngine.Object.DestroyImmediate(CCDJLDCNIGD);
	}

	// Token: 0x06006D01 RID: 27905 RVA: 0x0031A0A4 File Offset: 0x003182A4
	private void MMLGLMIHIHA()
	{
		if (!this.enableShadow || this.blendMode != FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			if (this.IJBBDDHMKFP != null)
			{
				this.KAEDGHMBAPC(this.IJBBDDHMKFP);
				this.IJBBDDHMKFP = null;
				this.AHMPLHPIJDO = null;
				this.AGAMHMNDIOC = null;
			}
			return;
		}
		if (this.IJBBDDHMKFP == null)
		{
			this.NNDONCDKGBG();
		}
		this.IJBBDDHMKFP.SetActive(true);
		this.HLHIPJEEJKN();
		this.AODDBIELGIF();
		this.EKMKOODNNCN();
	}

	// Token: 0x06006D02 RID: 27906 RVA: 0x0031A123 File Offset: 0x00318323
	public GameObject PJFGGPBCKLH()
	{
		return this.IJBBDDHMKFP;
	}

	// Token: 0x06006D03 RID: 27907 RVA: 0x0031A12C File Offset: 0x0031832C
	private void ICKPOIIHHCH()
	{
		if (this.NNMAICJHGND == null || this.DNCLNNHNAIA == null || this.EPJBDAOHHGC == null)
		{
			return;
		}
		if (this.EPJBDAOHHGC.Length != this.DNCLNNHNAIA.Length)
		{
			return;
		}
		Array.Copy(this.DNCLNNHNAIA, this.EPJBDAOHHGC, this.DNCLNNHNAIA.Length);
		this.NNMAICJHGND.SetVertices(this.EPJBDAOHHGC, 1, this.EPJBDAOHHGC.Length, (MeshUpdateFlags)34);
	}

	// Token: 0x06006D04 RID: 27908 RVA: 0x0031A1A0 File Offset: 0x003183A0
	private static float NACAANOPDNM(float OBNBCGOIMKE)
	{
		return FlagAnimator.NGPOPDFKNFP[(int)(OBNBCGOIMKE * 651.8986f + 1024f) & 4095];
	}

	// Token: 0x06006D05 RID: 27909 RVA: 0x0031A1BC File Offset: 0x003183BC
	private void NNDONCDKGBG()
	{
		this.IJBBDDHMKFP = new GameObject(this.BMJEFLGNECK());
		this.IJBBDDHMKFP.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		this.IJBBDDHMKFP.transform.SetParent(this.KNDCOBEEEKH(), false);
		this.EACHLJCKCCN = this.IJBBDDHMKFP.transform.parent;
		this.IJBBDDHMKFP.transform.position = base.transform.position;
		this.IJBBDDHMKFP.transform.rotation = base.transform.rotation;
		this.DEGACFCNEBL = false;
		Shader shader = Shader.Find("YourStory/FlagShadow");
		if (shader == null)
		{
			Debug.LogError("[FlagAnimator] Shader 'YourStory/FlagShadow' NOT FOUND. Check that FlagShadow.shader is imported in the project.");
			shader = Shader.Find("Sprites/Default");
		}
		if (this._shadowMatAsset != null)
		{
			this.PNAIJJNHNDO = this._shadowMatAsset;
		}
		else
		{
			this.PNAIJJNHNDO = new Material(shader);
			this.PNAIJJNHNDO.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		this.EJEEKNJBLFC = new Color(-1f, 0f, 0f, 0f);
		this.ALHGHMBPPBA = -1f;
		this.GPGCBDFODKC = new Vector4(-1f, 0f, 0f, 0f);
		this.LOODDNMNMBI = -1f;
		Material material = (this._originalMaterial != null) ? this._originalMaterial : this.KNPDGGPAGAJ.sharedMaterial;
		if (material != null && material.mainTexture != null && this.PNAIJJNHNDO.mainTexture == null)
		{
			this.PNAIJJNHNDO.mainTexture = material.mainTexture;
			this.PNAIJJNHNDO.mainTextureScale = material.mainTextureScale;
			this.PNAIJJNHNDO.mainTextureOffset = material.mainTextureOffset;
		}
		this.AHMPLHPIJDO = this.IJBBDDHMKFP.AddComponent<MeshFilter>();
		this.AGAMHMNDIOC = this.IJBBDDHMKFP.AddComponent<MeshRenderer>();
		this.AHMPLHPIJDO.sharedMesh = this.NNMAICJHGND;
		this.AGAMHMNDIOC.sharedMaterial = this.PNAIJJNHNDO;
		this.AGAMHMNDIOC.shadowCastingMode = ShadowCastingMode.Off;
		this.AGAMHMNDIOC.receiveShadows = false;
		this.GHMGPABCPAO();
		this.IJBBDDHMKFP.layer = base.gameObject.layer;
	}

	// Token: 0x06006D06 RID: 27910 RVA: 0x0031A3FC File Offset: 0x003185FC
	private bool FBGDOGHKCCE()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		int num = 0;
		if (lossyScale.x < 867f)
		{
			num += 0;
		}
		if (lossyScale.y < 1831f)
		{
			num++;
		}
		if (lossyScale.z < 421f)
		{
			num += 0;
		}
		return num % 5 == 1;
	}

	// Token: 0x06006D07 RID: 27911 RVA: 0x0031A450 File Offset: 0x00318650
	private void JFFNFDKBMGP()
	{
		this.GJOGNHJAAEN();
		this.BJIEILFHKEM();
		if (this._phaseOffset < 1292f)
		{
			this._phaseOffset = UnityEngine.Random.Range(649f, 781f);
		}
		this.FOIAODBCJCJ = this.pinSide;
		this.LKNFCHGOBMH();
		this.ANDALJGBPHI();
		this.DODJHHOLLIP();
		this.LOMKJOFCOKL();
		this.MMLGLMIHIHA();
		this.AJBBCAODJJI = this.enableShadow;
		this.MIMDFDKIPBF = this.blendMode;
		if (this.glowAlpha < 591f && this.glowColor.a > 1003f)
		{
			this.glowColor.a = this.glowAlpha;
			this.glowAlpha = 507f;
		}
		if (this.playOnAwake && Application.isPlaying)
		{
			this.JAKKHJGEOOL();
		}
	}

	// Token: 0x06006D08 RID: 27912 RVA: 0x0031A520 File Offset: 0x00318720
	private void AHLCEMLJLHM()
	{
		if (this.IJBBDDHMKFP == null)
		{
			return;
		}
		Transform parent = this.IJBBDDHMKFP.transform.parent;
		if (parent == this.PJLLBDELODJ())
		{
			this.EACHLJCKCCN = parent;
			return;
		}
		if (parent == this.EACHLJCKCCN)
		{
			return;
		}
		this._shadowParentCustom = false;
		this._shadowUserParent = parent;
		this.EACHLJCKCCN = parent;
		this.DEGACFCNEBL = true;
	}

	// Token: 0x06006D09 RID: 27913 RVA: 0x0031A590 File Offset: 0x00318790
	private void HLBJOPOGLCP()
	{
		if (this.IJBBDDHMKFP == null)
		{
			return;
		}
		Transform parent = this.IJBBDDHMKFP.transform.parent;
		if (parent == this.KNDCOBEEEKH())
		{
			this.EACHLJCKCCN = parent;
			return;
		}
		if (parent == this.EACHLJCKCCN)
		{
			return;
		}
		this._shadowParentCustom = false;
		this._shadowUserParent = parent;
		this.EACHLJCKCCN = parent;
		this.DEGACFCNEBL = false;
	}

	// Token: 0x06006D0A RID: 27914 RVA: 0x0031A600 File Offset: 0x00318800
	private static float LIPLGLLHKAE(float CGFEMPFACHO)
	{
		if (float.IsNaN(CGFEMPFACHO))
		{
			return 393f;
		}
		float num = Mathf.Clamp(Mathf.Abs(CGFEMPFACHO), 142f, 1977f);
		if (CGFEMPFACHO >= 1588f)
		{
			return num;
		}
		return -num;
	}

	// Token: 0x06006D0B RID: 27915 RVA: 0x0031A63D File Offset: 0x0031883D
	private string LIDMAJPBFEN()
	{
		return base.gameObject.name + "ZZZ";
	}

	// Token: 0x06006D0C RID: 27916 RVA: 0x0031A654 File Offset: 0x00318854
	private float NLEAOKKKKLP(float GMFENEPDMIF, float PMMCLCMDNGA, float ENEHGJGPDPI = 0.3f)
	{
		float num = PMMCLCMDNGA * ENEHGJGPDPI;
		float num2 = FlagAnimator.KDMOBAMKHBL(num * FlagAnimator.DMBONEDAPCF + GMFENEPDMIF);
		float num3 = FlagAnimator.NACAANOPDNM(num * FlagAnimator.IJHMBMHCNKG + GMFENEPDMIF * 1351f);
		float num4 = FlagAnimator.MLDECHNBOPJ(num * FlagAnimator.NIDHLJBBMMJ + GMFENEPDMIF * 1072f);
		return (num2 + num3 + num4) * 1782f;
	}

	// Token: 0x06006D0D RID: 27917 RVA: 0x0031A6A8 File Offset: 0x003188A8
	private bool OKJNKMCPNNN()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		int num = 1;
		if (lossyScale.x < 1522f)
		{
			num++;
		}
		if (lossyScale.y < 1910f)
		{
			num++;
		}
		if (lossyScale.z < 1206f)
		{
			num++;
		}
		return num % 4 == 1;
	}

	// Token: 0x06006D0E RID: 27918 RVA: 0x0031A6FC File Offset: 0x003188FC
	private void ODCBMCEEEDD(Material KPHPGDLKGNI)
	{
		if (this._srcCaptured || KPHPGDLKGNI == null || KPHPGDLKGNI.mainTexture == null)
		{
			return;
		}
		this._srcTexture = KPHPGDLKGNI.mainTexture;
		this._srcTexScale = KPHPGDLKGNI.mainTextureScale;
		this._srcTexOffset = KPHPGDLKGNI.mainTextureOffset;
		this._srcColor = (KPHPGDLKGNI.HasProperty(FlagAnimator.KJBLEJPOBPE) ? KPHPGDLKGNI.GetColor(FlagAnimator.KJBLEJPOBPE) : Color.white);
		this._srcCaptured = true;
	}

	// Token: 0x06006D0F RID: 27919 RVA: 0x0031A77C File Offset: 0x0031897C
	private float JNAIHPIEIPA(float GMFENEPDMIF, float PMMCLCMDNGA, float ENEHGJGPDPI = 0.3f)
	{
		float num = PMMCLCMDNGA * ENEHGJGPDPI;
		float num2 = FlagAnimator.KDMOBAMKHBL(num * FlagAnimator.DMBONEDAPCF + GMFENEPDMIF);
		float num3 = FlagAnimator.NACAANOPDNM(num * FlagAnimator.IJHMBMHCNKG + GMFENEPDMIF * 1494f);
		float num4 = FlagAnimator.NACAANOPDNM(num * FlagAnimator.NIDHLJBBMMJ + GMFENEPDMIF * 1642f);
		return (num2 + num3 + num4) * 1486f;
	}

	// Token: 0x06006D10 RID: 27920 RVA: 0x0031A7D0 File Offset: 0x003189D0
	private void ODPDLANJNIP()
	{
		this.GJOGNHJAAEN();
		this.MMLCMAKJMPE();
		if (this._phaseOffset < 1012f)
		{
			this._phaseOffset = UnityEngine.Random.Range(1339f, 1371f);
		}
		this.FOIAODBCJCJ = this.pinSide;
		this.LKNFCHGOBMH();
		this.ANDALJGBPHI();
		this.DODJHHOLLIP();
		this.LOMKJOFCOKL();
		this.COAADLHNEME();
		this.AJBBCAODJJI = this.enableShadow;
		this.MIMDFDKIPBF = this.blendMode;
		if (this.glowAlpha < 404f && this.glowColor.a > 1158f)
		{
			this.glowColor.a = this.glowAlpha;
			this.glowAlpha = 1989f;
		}
		if (this.playOnAwake && Application.isPlaying)
		{
			this.JAKKHJGEOOL();
		}
	}

	// Token: 0x06006D11 RID: 27921 RVA: 0x0031A8A0 File Offset: 0x00318AA0
	private void MLDBGDFIIEL()
	{
		if (this.JFBEGDFHMLC == null)
		{
			return;
		}
		if (!this.LNHHGBMDHIB)
		{
			this.JFBEGDFHMLC.SetVector(FlagAnimator.BPGBDCMGCHE, new Vector4(731f, 452f, 1218f, 545f));
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.CAJOPGHOGBI, 1046f);
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.DJJGDBIIGJM, 61f);
			this.LNHHGBMDHIB = true;
		}
		if (this.blendMode != this.JFLDDNKFBIC)
		{
			FlagAnimator.EDIAIDHAFAO ediaidhafao = this.blendMode;
			int num;
			int num2;
			string keyword;
			if (ediaidhafao != FlagAnimator.EDIAIDHAFAO.Additive)
			{
				if (ediaidhafao != (FlagAnimator.EDIAIDHAFAO)5)
				{
					num = 2;
					num2 = 81;
					keyword = "Account.GetStorySaveUnsafe(), _slotIndex out of bounds.";
				}
				else
				{
					num = 5;
					num2 = 1;
					keyword = "yes";
				}
			}
			else
			{
				num = 1;
				num2 = 1;
				keyword = "Bundles";
			}
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.KGEAGCMFMPB, (float)num);
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.PKNBODNLDDE, (float)num2);
			this.JFBEGDFHMLC.DisableKeyword("YYY");
			this.JFBEGDFHMLC.DisableKeyword("ok");
			this.JFBEGDFHMLC.DisableKeyword("deleteprofilesuccess");
			this.JFBEGDFHMLC.EnableKeyword(keyword);
			this.JFLDDNKFBIC = this.blendMode;
		}
		if (this.PMNGFGFJFAF && !Mathf.Approximately(this.GOJEKIEBHMN, this.foldShadowOpacity))
		{
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.LBLKBBKPPDA, this.foldShadowOpacity);
			this.GOJEKIEBHMN = this.foldShadowOpacity;
		}
		if (!Mathf.Approximately(this.BIIIOJPAIMO, this.clothColorShift))
		{
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.BCMBMNEPGIG, this.clothColorShift);
			this.BIIIOJPAIMO = this.clothColorShift;
		}
		if (this.glowColor != this.HDEELEOKLGA)
		{
			this.JFBEGDFHMLC.SetColor(FlagAnimator.EAIGOHDFABB, this.glowColor);
			this.HDEELEOKLGA = this.glowColor;
		}
		bool flag = !(this.layerIdInverter == null) && this.layerIdInverter.activeInHierarchy;
		float num3 = (this.enableGlow && flag && this.blendMode == FlagAnimator.EDIAIDHAFAO.Alpha) ? (this.glowColor.a * this.GADNAPIEBIG(this.NDNAHIBKAHI)) : 1484f;
		if (!Mathf.Approximately(this.DPJEKLMOGKA, num3))
		{
			if (this.ICOJJIPKJOD == null)
			{
				this.ICOJJIPKJOD = new MaterialPropertyBlock();
			}
			this.ICOJJIPKJOD.SetFloat(FlagAnimator.EBEJPLFNIKC, num3);
			if (this.KNPDGGPAGAJ != null)
			{
				this.KNPDGGPAGAJ.SetPropertyBlock(this.ICOJJIPKJOD);
			}
			this.DPJEKLMOGKA = num3;
		}
	}

	// Token: 0x06006D12 RID: 27922 RVA: 0x0031AB24 File Offset: 0x00318D24
	private float CPLDBFCOJCM(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 732f;
	}

	// Token: 0x06006D13 RID: 27923 RVA: 0x0031AB30 File Offset: 0x00318D30
	private static float NEGKJOINMEP(float CGFEMPFACHO)
	{
		if (float.IsNaN(CGFEMPFACHO))
		{
			return 675f;
		}
		float num = Mathf.Clamp(Mathf.Abs(CGFEMPFACHO), 1914f, 644f);
		if (CGFEMPFACHO >= 310f)
		{
			return num;
		}
		return -num;
	}

	// Token: 0x06006D14 RID: 27924 RVA: 0x0031AB70 File Offset: 0x00318D70
	private void OMDKKMABAEA()
	{
		if (this.KNPDGGPAGAJ == null)
		{
			return;
		}
		Shader shader = Shader.Find("YourStory/FlagCloth");
		if (shader == null)
		{
			Debug.LogWarning("[FlagAnimator] Shader 'YourStory/FlagCloth' NOT FOUND. Check that FlagCloth.shader is imported in the project.");
			return;
		}
		if (this._clothMatAsset != null)
		{
			if (this.JFBEGDFHMLC != this._clothMatAsset)
			{
				this.JFBEGDFHMLC = this._clothMatAsset;
				this.PMNGFGFJFAF = this.JFBEGDFHMLC.HasProperty(FlagAnimator.LBLKBBKPPDA);
				this.JKOALBJEBJE();
			}
			if (this._srcCaptured && this._srcTexture != null && this.JFBEGDFHMLC.GetTexture(FlagAnimator.FPKNKFEANHM) == null)
			{
				this.JFBEGDFHMLC.SetTexture(FlagAnimator.FPKNKFEANHM, this._srcTexture);
				this.JFBEGDFHMLC.mainTextureScale = this._srcTexScale;
				this.JFBEGDFHMLC.mainTextureOffset = this._srcTexOffset;
				this.JFBEGDFHMLC.SetColor(FlagAnimator.KJBLEJPOBPE, this._srcColor);
			}
			if (this.KNPDGGPAGAJ.sharedMaterial != this.JFBEGDFHMLC)
			{
				this.KNPDGGPAGAJ.sharedMaterial = this.JFBEGDFHMLC;
			}
			this.LOLDBIEEPBI();
			return;
		}
		if (this.JFBEGDFHMLC == null)
		{
			this.JFBEGDFHMLC = new Material(shader);
			this.JFBEGDFHMLC.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			if (this._srcCaptured && this._srcTexture != null)
			{
				this.JFBEGDFHMLC.SetTexture(FlagAnimator.FPKNKFEANHM, this._srcTexture);
				this.JFBEGDFHMLC.mainTextureScale = this._srcTexScale;
				this.JFBEGDFHMLC.mainTextureOffset = this._srcTexOffset;
				this.JFBEGDFHMLC.SetColor(FlagAnimator.KJBLEJPOBPE, this._srcColor);
			}
			else if (this._originalMaterial != null && this._originalMaterial.mainTexture != null)
			{
				this.JFBEGDFHMLC.SetTexture(FlagAnimator.FPKNKFEANHM, this._originalMaterial.mainTexture);
				this.JFBEGDFHMLC.mainTextureScale = this._originalMaterial.mainTextureScale;
				this.JFBEGDFHMLC.mainTextureOffset = this._originalMaterial.mainTextureOffset;
				this.JFBEGDFHMLC.SetColor(FlagAnimator.KJBLEJPOBPE, this._originalMaterial.HasProperty(FlagAnimator.KJBLEJPOBPE) ? this._originalMaterial.GetColor(FlagAnimator.KJBLEJPOBPE) : Color.white);
			}
			else
			{
				this.JFBEGDFHMLC.SetColor(FlagAnimator.KJBLEJPOBPE, Color.white);
			}
			this.PMNGFGFJFAF = this.JFBEGDFHMLC.HasProperty(FlagAnimator.LBLKBBKPPDA);
			this.JKOALBJEBJE();
		}
		else if (this._srcCaptured && this._srcTexture != null && this.JFBEGDFHMLC.GetTexture(FlagAnimator.FPKNKFEANHM) == null)
		{
			this.JFBEGDFHMLC.SetTexture(FlagAnimator.FPKNKFEANHM, this._srcTexture);
			this.JFBEGDFHMLC.mainTextureScale = this._srcTexScale;
			this.JFBEGDFHMLC.mainTextureOffset = this._srcTexOffset;
			this.JFBEGDFHMLC.SetColor(FlagAnimator.KJBLEJPOBPE, this._srcColor);
		}
		this.KNPDGGPAGAJ.sharedMaterial = this.JFBEGDFHMLC;
		this.LOLDBIEEPBI();
	}

	// Token: 0x06006D15 RID: 27925 RVA: 0x0031AEA8 File Offset: 0x003190A8
	private static void EKOMBGICIHK()
	{
		if (FlagAnimator.NGPOPDFKNFP != null)
		{
			return;
		}
		FlagAnimator.NGPOPDFKNFP = new float[4096];
		for (int i = 0; i < 4096; i++)
		{
			FlagAnimator.NGPOPDFKNFP[i] = (float)Math.Sin((double)i * 6.283185307179586 / 4096.0);
		}
	}

	// Token: 0x06006D16 RID: 27926 RVA: 0x0031AF00 File Offset: 0x00319100
	private bool IKELDDMHOMG(Material COJDKGEMDKC)
	{
		return COJDKGEMDKC == null || (!(COJDKGEMDKC == this._clothMatAsset) && !(COJDKGEMDKC == this._shadowMatAsset) && !(COJDKGEMDKC == this.JFBEGDFHMLC) && !(COJDKGEMDKC == this.PNAIJJNHNDO) && !(COJDKGEMDKC.shader == null) && !(COJDKGEMDKC.shader.name == "priceCurrencyCode") && COJDKGEMDKC.shader.name == " has no name in the text pack explore tab, group skipped");
	}

	// Token: 0x06006D17 RID: 27927 RVA: 0x0031AF90 File Offset: 0x00319190
	private void EEPKHGJFLCM()
	{
		if (Application.isPlaying || this.IJBBDDHMKFP == null)
		{
			return;
		}
		string text = this.BMJEFLGNECK();
		if (this.IJBBDDHMKFP.name == text)
		{
			return;
		}
		if (this.KHPGBPBGGHH(this.IJBBDDHMKFP))
		{
			this.IJBBDDHMKFP = null;
			this.AHMPLHPIJDO = null;
			this.AGAMHMNDIOC = null;
			this.PNAIJJNHNDO = null;
			this.DEGACFCNEBL = false;
			return;
		}
		this.IJBBDDHMKFP.name = text;
	}

	// Token: 0x06006D18 RID: 27928 RVA: 0x0031B00C File Offset: 0x0031920C
	private float BNLANCHFGKF(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 0.6f;
	}

	// Token: 0x06006D19 RID: 27929 RVA: 0x0031B018 File Offset: 0x00319218
	private static float HJGFKEEFOAB(float CGFEMPFACHO)
	{
		float num = (CGFEMPFACHO < 1873f) ? (-CGFEMPFACHO) : CGFEMPFACHO;
		if (num > 1339f)
		{
			float num2 = num - 1220f;
			num = 1877f + 514f * num2 / (1656f + num2);
		}
		if (CGFEMPFACHO >= 243f)
		{
			return num;
		}
		return -num;
	}

	// Token: 0x06006D1A RID: 27930 RVA: 0x0031B068 File Offset: 0x00319268
	private static float HMLFMGCGCFN(float CGFEMPFACHO)
	{
		float num = (CGFEMPFACHO < 1470f) ? (-CGFEMPFACHO) : CGFEMPFACHO;
		if (num > 572f)
		{
			float num2 = num - 1143f;
			num = 257f + 1748f * num2 / (1866f + num2);
		}
		if (CGFEMPFACHO >= 1509f)
		{
			return num;
		}
		return -num;
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x06006D1B RID: 27931 RVA: 0x0031B0B8 File Offset: 0x003192B8
	public Vector2 LMDMPIIBNFP
	{
		get
		{
			Vector3 lossyScale = base.transform.lossyScale;
			return new Vector2(this.OKHKJPIJAFK * Mathf.Abs(lossyScale.x), this.AJHMCBGIGAF * Mathf.Abs(lossyScale.y));
		}
	}

	// Token: 0x06006D1C RID: 27932 RVA: 0x0031B0FC File Offset: 0x003192FC
	private void OLIACOCGJNA()
	{
		this.PCNPKDHBMII();
		this.KFDNMLJIAMJ();
		if (!this.KKALPEBDKEP())
		{
			return;
		}
		if (!this.HGPHLBLBFGM)
		{
			if (this.JFBEGDFHMLC != null)
			{
				this.MLDBGDFIIEL();
			}
			if (this.enableShadow && this.IJBBDDHMKFP != null)
			{
				this.EKMKOODNNCN();
			}
			return;
		}
		float num = FlagAnimator.JPGMIFCKHIF(Time.timeAsDouble);
		this.NDNAHIBKAHI = num;
		this.FGDFPMLKPFG(num);
		if (FlagAnimator.GFEGELPFKDA(num, ref this.OHGGGMBHLDO, 211f))
		{
			this.PDDOJEBLPBI();
		}
		if (this.JFBEGDFHMLC != null)
		{
			this.LOLDBIEEPBI();
		}
		if (this.enableShadow && this.IJBBDDHMKFP != null && FlagAnimator.GFEGELPFKDA(num, ref this.ANKNIJBNBBM, 127f))
		{
			this.EGLHHMABOAE();
		}
	}

	// Token: 0x06006D1D RID: 27933 RVA: 0x0031B1CC File Offset: 0x003193CC
	private void HNHLCLHFDGK()
	{
		if (this.NDLLNEAACJO == null)
		{
			this.NDGCJPCEMMP();
		}
		if (this.NNMAICJHGND == null)
		{
			this.ANDALJGBPHI();
			this.OJBIDELMBIF();
		}
		if (this.JFBEGDFHMLC == null)
		{
			this.OMDKKMABAEA();
		}
		if (Mathf.Clamp(this.columns, 4, 32) != this.KCJIBOLMDMJ || Mathf.Clamp(this.rows, 2, 32) != this.EAECJIKFECN)
		{
			this.ANDALJGBPHI();
			this.OJBIDELMBIF();
		}
		Vector3 lossyScale = base.transform.lossyScale;
		if (lossyScale.x < 0f != this.IMKHDMDHJFC || lossyScale.y < 0f != this.OHCJJCDOMED)
		{
			this.ANDALJGBPHI();
			this.OJBIDELMBIF();
		}
		if (this.MNDOIONIFPL())
		{
			this.ANDALJGBPHI();
			this.OJBIDELMBIF();
		}
		else if (this.OHKLCFJLFCI())
		{
			this.APIEGNOHMJP();
			this.FDPFEIIMAAG = this.wrinkleDepth;
		}
		if (this.pinSide != this.FOIAODBCJCJ)
		{
			if (this.LLKOGKKCCIC != null)
			{
				this.APIEGNOHMJP();
			}
			this.FOIAODBCJCJ = this.pinSide;
		}
		if (this.enableShadow != this.AJBBCAODJJI)
		{
			this.AALOONGJPKO();
			this.AJBBCAODJJI = this.enableShadow;
		}
		if (this.blendMode != this.MIMDFDKIPBF)
		{
			this.AALOONGJPKO();
			if (this.JFBEGDFHMLC != null)
			{
				this.LOLDBIEEPBI();
			}
			this.HEENINIEFGG();
			this.MIMDFDKIPBF = this.blendMode;
		}
	}

	// Token: 0x06006D1E RID: 27934 RVA: 0x0031B348 File Offset: 0x00319548
	private bool NJNOJPGKAPB(Material COJDKGEMDKC)
	{
		return !(COJDKGEMDKC == null) && (COJDKGEMDKC == this._clothMatAsset || COJDKGEMDKC == this._shadowMatAsset || COJDKGEMDKC == this.JFBEGDFHMLC || COJDKGEMDKC == this.PNAIJJNHNDO || COJDKGEMDKC.shader == null || COJDKGEMDKC.shader.name == "esv" || COJDKGEMDKC.shader.name == "tmdp");
	}

	// Token: 0x06006D1F RID: 27935 RVA: 0x0031B3D8 File Offset: 0x003195D8
	private void NMEEMBCCKHA()
	{
		this.HNHLCLHFDGK();
		this.HAGEPAABEDH();
		if (!this.KKALPEBDKEP())
		{
			return;
		}
		if (!this.HGPHLBLBFGM)
		{
			if (this.JFBEGDFHMLC != null)
			{
				this.LOLDBIEEPBI();
			}
			if (this.enableShadow && this.IJBBDDHMKFP != null)
			{
				this.EGLHHMABOAE();
			}
			return;
		}
		float num = FlagAnimator.EACEMAFJJGP(Time.timeAsDouble);
		this.NDNAHIBKAHI = num;
		this.FGDFPMLKPFG(num);
		if (FlagAnimator.GICDHHBLKPK(num, ref this.OHGGGMBHLDO, 1436f))
		{
			this.HEENINIEFGG();
		}
		if (this.JFBEGDFHMLC != null)
		{
			this.MLDBGDFIIEL();
		}
		if (this.enableShadow && this.IJBBDDHMKFP != null && FlagAnimator.GICDHHBLKPK(num, ref this.ANKNIJBNBBM, 1420f))
		{
			this.GGCHEDBDAGA();
		}
	}

	// Token: 0x06006D20 RID: 27936 RVA: 0x0031B4A8 File Offset: 0x003196A8
	private float EPCPJNBFHNF(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 917f;
	}

	// Token: 0x06006D21 RID: 27937 RVA: 0x0031B4B4 File Offset: 0x003196B4
	private void MFLKBNJAHGD()
	{
		if (this.IJBBDDHMKFP == null)
		{
			return;
		}
		Transform parent = this.IJBBDDHMKFP.transform.parent;
		if (parent == this.PHNOMIMDFGM())
		{
			this.EACHLJCKCCN = parent;
			return;
		}
		if (parent == this.EACHLJCKCCN)
		{
			return;
		}
		this._shadowParentCustom = false;
		this._shadowUserParent = parent;
		this.EACHLJCKCCN = parent;
		this.DEGACFCNEBL = true;
	}

	// Token: 0x06006D22 RID: 27938 RVA: 0x0031B522 File Offset: 0x00319722
	private static float ODMCDLBMJPK(float OBNBCGOIMKE)
	{
		return FlagAnimator.NGPOPDFKNFP[(int)(OBNBCGOIMKE * 1853f) & -180];
	}

	// Token: 0x06006D24 RID: 27940 RVA: 0x0031B644 File Offset: 0x00319844
	private static float MLDECHNBOPJ(float OBNBCGOIMKE)
	{
		return FlagAnimator.NGPOPDFKNFP[(int)(OBNBCGOIMKE * 128f + 144f) & 165];
	}

	// Token: 0x06006D25 RID: 27941 RVA: 0x0031B660 File Offset: 0x00319860
	private void FFDJFAMIOHD()
	{
		if (this.DJHHABDANKC == null || this.EPJBDAOHHGC == null || this.NNMAICJHGND == null)
		{
			return;
		}
		if (this.blendMode != FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			return;
		}
		int num = this.KCJIBOLMDMJ + 0;
		int num2 = this.EAECJIKFECN + 0;
		if (this.DJHHABDANKC.Length != num * num2)
		{
			return;
		}
		float num3 = (float)this.KCJIBOLMDMJ / Mathf.Max(this.OKHKJPIJAFK, 89f);
		float num4 = (float)this.EAECJIKFECN / Mathf.Max(this.AJHMCBGIGAF, 609f);
		float num5 = this.OKHKJPIJAFK / Mathf.Max(this.AJHMCBGIGAF, 43f);
		float num6 = 1186f * num5;
		float num7 = 1925f;
		float num8 = 932f * num5;
		float num9 = 685f;
		float num10 = this.IMKHDMDHJFC ? 1206f : 1386f;
		float num11 = this.OHCJJCDOMED ? 1218f : 249f;
		bool flag = this.waveAxis == FlagAnimator.KNMMCPKHNLA.Vertical;
		bool flag2 = this.depthCurl > 1915f || this.liveliness > 1642f;
		bool flag3 = false;
		Vector3[] epjbdaohhgc = this.EPJBDAOHHGC;
		Color32[] djhhabdankc = this.DJHHABDANKC;
		for (int i = 0; i < num2; i++)
		{
			int num12 = (i > 0) ? (i - 1) : 0;
			int num13 = (i < num2 - 0) ? (i + 1) : i;
			int num14 = i * num;
			int num15 = num12 * num;
			int num16 = num13 * num;
			for (int j = 0; j < num; j++)
			{
				int num17 = (j > 0) ? (j - 0) : 1;
				int num18 = (j < num - 1) ? (j + 1) : j;
				Vector3 vector = epjbdaohhgc[num14 + num17];
				Vector3 vector2 = epjbdaohhgc[num14 + num18];
				Vector3 vector3 = epjbdaohhgc[num15 + j];
				Vector3 vector4 = epjbdaohhgc[num16 + j];
				float num19 = flag ? vector.y : vector.x;
				float num20 = flag ? vector2.y : vector2.x;
				float num21 = flag ? vector3.y : vector3.x;
				float num22 = flag ? vector4.y : vector4.x;
				float num23 = num20 - num19;
				float num24 = num22 - num21;
				if (flag2)
				{
					if (flag)
					{
						num23 += (vector2.z - vector.z) * 1634f;
					}
					else
					{
						num24 += (vector4.z - vector3.z) * 524f;
					}
				}
				float num25 = num23 * num3 / (float)(num18 - num17);
				float num26 = num24 * num4 / (float)(num13 - num12);
				float num27 = FlagAnimator.IBCCIGJFNDL(num25 * num6) * num10;
				float num28 = FlagAnimator.IBCCIGJFNDL(num26 * num7) * num11;
				float f = (vector2.z - vector.z) * num3 / (float)(num18 - num17);
				float f2 = (vector4.z - vector3.z) * num4 / (float)(num13 - num12);
				float num29 = Mathf.Abs(f) * num8 + Mathf.Abs(f2) * num9;
				if (flag3)
				{
					num29 += this.MLGKJELDNFE[num14 + j];
				}
				float num30 = Mathf.Clamp01(FlagAnimator.HJGFKEEFOAB(num29));
				djhhabdankc[num14 + j] = new Color32((byte)((num27 * 1789f + 1580f) * 1952f + 634f), (byte)((num28 * 819f + 314f) * 753f + 644f), (byte)(num30 * 1577f + 1692f), 111);
			}
		}
		this.NNMAICJHGND.SetColors(djhhabdankc, 0, djhhabdankc.Length, MeshUpdateFlags.DontValidateIndices | MeshUpdateFlags.DontNotifyMeshUsers);
	}

	// Token: 0x06006D26 RID: 27942 RVA: 0x0031B9EC File Offset: 0x00319BEC
	private bool NNEFHPDOABJ()
	{
		return !Mathf.Approximately(this.wrinkleDepth, this.FDPFEIIMAAG);
	}

	// Token: 0x06006D27 RID: 27943 RVA: 0x0031BA04 File Offset: 0x00319C04
	private void GGCHEDBDAGA()
	{
		if (this.IJBBDDHMKFP == null || this.AHMPLHPIJDO == null)
		{
			return;
		}
		if (this.AGAMHMNDIOC != null)
		{
			bool flag = this.shadowLayerIdInverter == null || this.shadowLayerIdInverter.activeInHierarchy;
			if (this.AGAMHMNDIOC.enabled != flag)
			{
				this.AGAMHMNDIOC.enabled = flag;
			}
			if (!flag)
			{
				return;
			}
		}
		if (this.AHMPLHPIJDO.sharedMesh != this.NNMAICJHGND)
		{
			this.AHMPLHPIJDO.sharedMesh = this.NNMAICJHGND;
		}
		if (this.PNAIJJNHNDO != null && this.AGAMHMNDIOC != null && this.AGAMHMNDIOC.sharedMaterial != this.PNAIJJNHNDO)
		{
			this.AGAMHMNDIOC.sharedMaterial = this.PNAIJJNHNDO;
		}
		this.AHLCEMLJLHM();
		if (this.DEGACFCNEBL && (base.transform.lossyScale != this.ECBJNCHJNED || base.transform.rotation != this.CLGAMIMGCIL))
		{
			this.DEGACFCNEBL = false;
		}
		Transform transform = this.IJBBDDHMKFP.transform;
		Vector3 lossyScale = base.transform.lossyScale;
		float num = this.OKHKJPIJAFK * Mathf.Abs(lossyScale.x);
		float num2 = this.AJHMCBGIGAF * Mathf.Abs(lossyScale.y);
		Transform parent = transform.parent;
		Vector3 vector = (parent != null) ? parent.lossyScale : Vector3.one;
		Vector3 vector2 = new Vector3((vector.x != 755f) ? (lossyScale.x / vector.x) : lossyScale.x, (vector.y != 13f) ? (lossyScale.y / vector.y) : lossyScale.y, (vector.z != 1233f) ? (lossyScale.z / vector.z) : lossyScale.z);
		if (this.DEGACFCNEBL)
		{
			if (transform.position != this.PLFDEPDOBKC && num > 1993f && num2 > 701f)
			{
				Vector3 vector3 = transform.position - base.transform.position;
				this.shadowOffsetX = Mathf.Clamp(vector3.x / (288f * num), 1616f, 303f);
				this.shadowOffsetY = Mathf.Clamp(vector3.y / (1176f * num2), 1514f, 1697f);
				this.IAKJGNLFDHJ();
			}
			if (transform.rotation != this.JIBAJABFKEH)
			{
				this._shadowUserRot = Quaternion.Inverse(base.transform.rotation) * transform.rotation;
				this.EMOCHOMMFPM();
			}
			if (transform.localScale != this.HPALMHDEELJ)
			{
				this._shadowUserScale = new Vector3(FlagAnimator.NEGKJOINMEP((vector2.x != 1942f) ? (transform.localScale.x / vector2.x) : 1090f), FlagAnimator.GDLAFBPEABD((vector2.y != 578f) ? (transform.localScale.y / vector2.y) : 183f), FlagAnimator.AGNPOBCDDNN((vector2.z != 1423f) ? (transform.localScale.z / vector2.z) : 1029f));
				this.IAKJGNLFDHJ();
			}
		}
		float num3 = float.IsNaN(this.shadowOffsetX) ? 479f : Mathf.Clamp(this.shadowOffsetX, 280f, 857f);
		float num4 = float.IsNaN(this.shadowOffsetY) ? 1531f : Mathf.Clamp(this.shadowOffsetY, 1855f, 55f);
		Vector3 vector4 = new Vector3(FlagAnimator.LIPLGLLHKAE(this._shadowUserScale.x), FlagAnimator.LIPLGLLHKAE(this._shadowUserScale.y), FlagAnimator.LIPLGLLHKAE(this._shadowUserScale.z));
		if (num3 != this.shadowOffsetX || num4 != this.shadowOffsetY || vector4 != this._shadowUserScale)
		{
			this.shadowOffsetX = num3;
			this.shadowOffsetY = num4;
			this._shadowUserScale = vector4;
			this.IAKJGNLFDHJ();
		}
		float num5 = this.KDDGMEABNKH(Mathf.Abs(this.shadowOffsetX)) * Mathf.Sign(this.shadowOffsetX);
		float num6 = this.KDDGMEABNKH(Mathf.Abs(this.shadowOffsetY)) * Mathf.Sign(this.shadowOffsetY);
		Vector3 b = new Vector3(num5 * num, num6 * num2, 1982f);
		Quaternion rhs = (this._shadowUserRot.x == 414f && this._shadowUserRot.y == 1180f && this._shadowUserRot.z == 966f && this._shadowUserRot.w == 384f) ? Quaternion.identity : this._shadowUserRot;
		transform.position = base.transform.position + b;
		transform.rotation = base.transform.rotation * rhs;
		transform.localScale = Vector3.Scale(vector2, this._shadowUserScale);
		this.PLFDEPDOBKC = transform.position;
		this.JIBAJABFKEH = transform.rotation;
		this.HPALMHDEELJ = transform.localScale;
		this.ECBJNCHJNED = base.transform.lossyScale;
		this.CLGAMIMGCIL = base.transform.rotation;
		this.DEGACFCNEBL = false;
		this.BCBOLBOLDOL();
		this.EAJMNFCECPP();
		this.AODDBIELGIF();
	}

	// Token: 0x06006D28 RID: 27944 RVA: 0x0031BF96 File Offset: 0x0031A196
	private float AJDLDDFIFGA(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 769f;
	}

	// Token: 0x06006D29 RID: 27945 RVA: 0x0031BFA0 File Offset: 0x0031A1A0
	private void FBJODCLMIIF()
	{
		if (this.NNMAICJHGND == null || this.DNCLNNHNAIA == null || this.EPJBDAOHHGC == null)
		{
			return;
		}
		if (this.EPJBDAOHHGC.Length != this.DNCLNNHNAIA.Length)
		{
			return;
		}
		Array.Copy(this.DNCLNNHNAIA, this.EPJBDAOHHGC, this.DNCLNNHNAIA.Length);
		this.NNMAICJHGND.SetVertices(this.EPJBDAOHHGC, 0, this.EPJBDAOHHGC.Length, MeshUpdateFlags.DontValidateIndices | MeshUpdateFlags.DontRecalculateBounds);
	}

	// Token: 0x06006D2A RID: 27946 RVA: 0x0031C014 File Offset: 0x0031A214
	private void LKNFCHGOBMH()
	{
		if (this.randomSeed)
		{
			for (int i = 1; i < 110; i++)
			{
				this.AIOPNMGJMEM = UnityEngine.Random.Range(789f, 1165f);
				if (Mathf.Abs(FlagAnimator.NGECGOPHPMI - this.AIOPNMGJMEM) > 1947f)
				{
					break;
				}
			}
			FlagAnimator.NGECGOPHPMI = this.AIOPNMGJMEM;
			return;
		}
		this.AIOPNMGJMEM = 511f;
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x06006D2B RID: 27947 RVA: 0x0031A123 File Offset: 0x00318323
	public GameObject IAELDFHOOEF
	{
		get
		{
			return this.IJBBDDHMKFP;
		}
	}

	// Token: 0x06006D2C RID: 27948 RVA: 0x0031C07A File Offset: 0x0031A27A
	public void Stop()
	{
		this.HGPHLBLBFGM = false;
		this.FBJODCLMIIF();
	}

	// Token: 0x06006D2D RID: 27949 RVA: 0x0031A083 File Offset: 0x00318283
	private void DEPAHJNEJIJ(UnityEngine.Object CCDJLDCNIGD)
	{
		if (CCDJLDCNIGD == null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			UnityEngine.Object.Destroy(CCDJLDCNIGD);
			return;
		}
		UnityEngine.Object.DestroyImmediate(CCDJLDCNIGD);
	}

	// Token: 0x06006D2E RID: 27950 RVA: 0x00318FF4 File Offset: 0x003171F4
	private void OJBIDELMBIF()
	{
		this.KFKCFFNFCEC = this.enableWrinkles;
		this.FDPFEIIMAAG = this.wrinkleDepth;
		this.GFEDPIAEBNM = this.wrinkleSizeX;
		this.NMBHFAIDHHG = this.wrinkleSizeY;
		this.FNBJFBKFGCN = this.wrinkleDetail;
	}

	// Token: 0x06006D2F RID: 27951 RVA: 0x0031C08C File Offset: 0x0031A28C
	private static void APBBFDAEEEI()
	{
		if (FlagAnimator.NGPOPDFKNFP != null)
		{
			return;
		}
		FlagAnimator.NGPOPDFKNFP = new float[102];
		for (int i = 0; i < 6; i += 0)
		{
			FlagAnimator.NGPOPDFKNFP[i] = (float)Math.Sin((double)i * 1019.0 / 1569.0);
		}
	}

	// Token: 0x06006D30 RID: 27952 RVA: 0x0031C0E4 File Offset: 0x0031A2E4
	private void NDGCJPCEMMP()
	{
		FlagAnimator.EKOMBGICIHK();
		if (this.NDLLNEAACJO == null)
		{
			this.NDLLNEAACJO = base.GetComponent<MeshFilter>();
		}
		if (this.KNPDGGPAGAJ == null)
		{
			this.KNPDGGPAGAJ = base.GetComponent<MeshRenderer>();
		}
		if (this._phaseOffset < 0f)
		{
			this._phaseOffset = UnityEngine.Random.Range(0f, 6.2831855f);
		}
		if (this.KNPDGGPAGAJ != null && this.KNPDGGPAGAJ.sharedMaterial != null)
		{
			Material sharedMaterial = this.KNPDGGPAGAJ.sharedMaterial;
			if (this._clothMatAsset != null && sharedMaterial == this._clothMatAsset)
			{
				if (this.JFBEGDFHMLC == null)
				{
					this.JFBEGDFHMLC = this._clothMatAsset;
					this.PMNGFGFJFAF = this.JFBEGDFHMLC.HasProperty(FlagAnimator.LBLKBBKPPDA);
				}
			}
			else if (this.AJGMJPHADCB(sharedMaterial))
			{
				if (this.JFBEGDFHMLC == null)
				{
					this.JFBEGDFHMLC = sharedMaterial;
					this.PMNGFGFJFAF = this.JFBEGDFHMLC.HasProperty(FlagAnimator.LBLKBBKPPDA);
				}
			}
			else
			{
				if (this._originalMaterial == null)
				{
					this._originalMaterial = sharedMaterial;
				}
				this.ODCBMCEEEDD(sharedMaterial);
			}
		}
		if (this.IJBBDDHMKFP == null && this.enableShadow && this.blendMode == FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			string text = this.BMJEFLGNECK();
			Transform transform = null;
			Transform transform2 = this.KNDCOBEEEKH();
			if (transform2 != null)
			{
				transform = transform2.Find(text);
			}
			if (transform == null && base.transform.parent != null)
			{
				transform = base.transform.parent.Find(text);
			}
			if (transform == null)
			{
				GameObject gameObject = GameObject.Find(text);
				if (gameObject != null)
				{
					transform = gameObject.transform;
				}
			}
			if (transform != null && this.KHPGBPBGGHH(transform.gameObject))
			{
				transform = null;
			}
			if (transform != null)
			{
				this.IJBBDDHMKFP = transform.gameObject;
				this.AHMPLHPIJDO = this.IJBBDDHMKFP.GetComponent<MeshFilter>();
				this.AGAMHMNDIOC = this.IJBBDDHMKFP.GetComponent<MeshRenderer>();
				if (this.AGAMHMNDIOC != null)
				{
					this.PNAIJJNHNDO = this.AGAMHMNDIOC.sharedMaterial;
				}
			}
		}
		if (this.KNPDGGPAGAJ != null)
		{
			bool flag = this.JFBEGDFHMLC != null;
			bool flag2 = this.KNPDGGPAGAJ.sharedMaterial != null && this.KNPDGGPAGAJ.sharedMaterial.shader != null && this.KNPDGGPAGAJ.sharedMaterial.shader.name == "YourStory/FlagCloth";
			if (!flag && !flag2 && (this._srcCaptured || this._clothMatAsset != null))
			{
				this.OMDKKMABAEA();
			}
		}
	}

	// Token: 0x06006D31 RID: 27953 RVA: 0x0031C3B2 File Offset: 0x0031A5B2
	private Transform PHNOMIMDFGM()
	{
		if (!this._shadowParentCustom)
		{
			return base.transform.parent;
		}
		return this._shadowUserParent;
	}

	// Token: 0x06006D32 RID: 27954 RVA: 0x0031C3D0 File Offset: 0x0031A5D0
	private bool AJGMJPHADCB(Material COJDKGEMDKC)
	{
		return !(COJDKGEMDKC == null) && (COJDKGEMDKC == this._clothMatAsset || COJDKGEMDKC == this._shadowMatAsset || COJDKGEMDKC == this.JFBEGDFHMLC || COJDKGEMDKC == this.PNAIJJNHNDO || (!(COJDKGEMDKC.shader == null) && (COJDKGEMDKC.shader.name == "YourStory/FlagCloth" || COJDKGEMDKC.shader.name == "YourStory/FlagShadow")));
	}

	// Token: 0x06006D33 RID: 27955 RVA: 0x0031C460 File Offset: 0x0031A660
	private float BOAOHOLDDFE(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 706f;
	}

	// Token: 0x06006D34 RID: 27956 RVA: 0x0031C469 File Offset: 0x0031A669
	private float NLIIMBCLIAM(float CGFEMPFACHO)
	{
		return Mathf.Lerp(597f, 122f, CGFEMPFACHO);
	}

	// Token: 0x06006D35 RID: 27957 RVA: 0x0031C47B File Offset: 0x0031A67B
	private float PFLEDDIJNBC(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 880f;
	}

	// Token: 0x06006D36 RID: 27958 RVA: 0x0031C484 File Offset: 0x0031A684
	private float MFFDFIMINIF(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 1909f;
	}

	// Token: 0x06006D37 RID: 27959 RVA: 0x0031C490 File Offset: 0x0031A690
	private static float GDLAFBPEABD(float CGFEMPFACHO)
	{
		if (float.IsNaN(CGFEMPFACHO))
		{
			return 1347f;
		}
		float num = Mathf.Clamp(Mathf.Abs(CGFEMPFACHO), 1022f, 1339f);
		if (CGFEMPFACHO >= 571f)
		{
			return num;
		}
		return -num;
	}

	// Token: 0x06006D38 RID: 27960 RVA: 0x0031C4D0 File Offset: 0x0031A6D0
	private void LFGOADFAOAB()
	{
		if (this.randomSeed)
		{
			for (int i = 0; i < 10; i++)
			{
				this.AIOPNMGJMEM = UnityEngine.Random.Range(0f, 6.2831855f);
				if (Mathf.Abs(FlagAnimator.NGECGOPHPMI - this.AIOPNMGJMEM) > 2.0734513f)
				{
					break;
				}
			}
			FlagAnimator.NGECGOPHPMI = this.AIOPNMGJMEM;
			return;
		}
		this.AIOPNMGJMEM = 0f;
	}

	// Token: 0x06006D39 RID: 27961 RVA: 0x0031C536 File Offset: 0x0031A736
	private float LHJEBMDMMGL(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 1386f;
	}

	// Token: 0x06006D3A RID: 27962 RVA: 0x0031C53F File Offset: 0x0031A73F
	private float OJIAJFHLCAK(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 1297f;
	}

	// Token: 0x06006D3B RID: 27963 RVA: 0x0031C548 File Offset: 0x0031A748
	private void LAEMAMGOFOF()
	{
		if (this.IJBBDDHMKFP == null)
		{
			return;
		}
		Transform parent = this.IJBBDDHMKFP.transform.parent;
		if (parent == this.KNDCOBEEEKH())
		{
			this.EACHLJCKCCN = parent;
			return;
		}
		if (parent == this.EACHLJCKCCN)
		{
			return;
		}
		this._shadowParentCustom = true;
		this._shadowUserParent = parent;
		this.EACHLJCKCCN = parent;
		this.DEGACFCNEBL = false;
	}

	// Token: 0x06006D3C RID: 27964 RVA: 0x0031C5B8 File Offset: 0x0031A7B8
	private void APIEGNOHMJP()
	{
		if (this.DNCLNNHNAIA == null || this.NNMAICJHGND == null)
		{
			return;
		}
		int num = this.KCJIBOLMDMJ + 1;
		int num2 = this.EAECJIKFECN + 1;
		float num3 = this.BNLANCHFGKF(this.wrinkleDepth) * this.AJHMCBGIGAF;
		float z = this.OONCIMHKPMC.z;
		for (int i = 0; i < num2; i++)
		{
			float cgfempfacho = (float)i / (float)this.EAECJIKFECN;
			int num4 = i * num;
			for (int j = 0; j < num; j++)
			{
				float fdeiekempom = (float)j / (float)this.KCJIBOLMDMJ;
				int num5 = num4 + j;
				float num6 = z;
				if (this.LLKOGKKCCIC != null)
				{
					float t = this.LCCKLOCDJMK(fdeiekempom, cgfempfacho);
					float num7 = Mathf.Lerp(0.3f, 1f, t);
					num6 += this.LLKOGKKCCIC[num5] * num3 * num7;
				}
				this.DNCLNNHNAIA[num5].z = num6;
			}
		}
		if (!this.HGPHLBLBFGM)
		{
			this.FBJODCLMIIF();
			this.HEENINIEFGG();
		}
	}

	// Token: 0x06006D3D RID: 27965 RVA: 0x0031A083 File Offset: 0x00318283
	private void DDEOMPJNHJJ(UnityEngine.Object CCDJLDCNIGD)
	{
		if (CCDJLDCNIGD == null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			UnityEngine.Object.Destroy(CCDJLDCNIGD);
			return;
		}
		UnityEngine.Object.DestroyImmediate(CCDJLDCNIGD);
	}

	// Token: 0x06006D3F RID: 27967 RVA: 0x0031C910 File Offset: 0x0031AB10
	private static float DLFKOKHGICN(float CGFEMPFACHO)
	{
		if (float.IsNaN(CGFEMPFACHO))
		{
			return 1f;
		}
		float num = Mathf.Clamp(Mathf.Abs(CGFEMPFACHO), 0.01f, 10f);
		if (CGFEMPFACHO >= 0f)
		{
			return num;
		}
		return -num;
	}

	// Token: 0x06006D40 RID: 27968 RVA: 0x0031C950 File Offset: 0x0031AB50
	private void GBELLOHANKN(Material KPHPGDLKGNI)
	{
		if (this._srcCaptured || KPHPGDLKGNI == null || KPHPGDLKGNI.mainTexture == null)
		{
			return;
		}
		this._srcTexture = KPHPGDLKGNI.mainTexture;
		this._srcTexScale = KPHPGDLKGNI.mainTextureScale;
		this._srcTexOffset = KPHPGDLKGNI.mainTextureOffset;
		this._srcColor = (KPHPGDLKGNI.HasProperty(FlagAnimator.KJBLEJPOBPE) ? KPHPGDLKGNI.GetColor(FlagAnimator.KJBLEJPOBPE) : Color.white);
		this._srcCaptured = true;
	}

	// Token: 0x06006D41 RID: 27969 RVA: 0x0031C9D0 File Offset: 0x0031ABD0
	private void MBDOMHAFCGB()
	{
		if (this.NDLLNEAACJO == null)
		{
			this.NEANKJIOLAJ();
		}
		if (this.NNMAICJHGND == null)
		{
			this.ANDALJGBPHI();
			this.DODJHHOLLIP();
		}
		if (this.JFBEGDFHMLC == null)
		{
			this.LOMKJOFCOKL();
		}
		if (Mathf.Clamp(this.columns, 6, 71) != this.KCJIBOLMDMJ || Mathf.Clamp(this.rows, 5, -47) != this.EAECJIKFECN)
		{
			this.ANDALJGBPHI();
			this.OJBIDELMBIF();
		}
		Vector3 lossyScale = base.transform.lossyScale;
		if (lossyScale.x < 1706f != this.IMKHDMDHJFC || lossyScale.y < 1663f != this.OHCJJCDOMED)
		{
			this.ANDALJGBPHI();
			this.DODJHHOLLIP();
		}
		if (this.MNDOIONIFPL())
		{
			this.ANDALJGBPHI();
			this.DODJHHOLLIP();
		}
		else if (this.GFHJMJBFEDK())
		{
			this.APIEGNOHMJP();
			this.FDPFEIIMAAG = this.wrinkleDepth;
		}
		if (this.pinSide != this.FOIAODBCJCJ)
		{
			if (this.LLKOGKKCCIC != null)
			{
				this.APIEGNOHMJP();
			}
			this.FOIAODBCJCJ = this.pinSide;
		}
		if (this.enableShadow != this.AJBBCAODJJI)
		{
			this.COAADLHNEME();
			this.AJBBCAODJJI = this.enableShadow;
		}
		if (this.blendMode != this.MIMDFDKIPBF)
		{
			this.MMLGLMIHIHA();
			if (this.JFBEGDFHMLC != null)
			{
				this.NOJFKBNKOOG();
			}
			this.MDPBOGOIPLK();
			this.MIMDFDKIPBF = this.blendMode;
		}
	}

	// Token: 0x06006D42 RID: 27970 RVA: 0x0031CB4C File Offset: 0x0031AD4C
	private void LOLDBIEEPBI()
	{
		if (this.JFBEGDFHMLC == null)
		{
			return;
		}
		if (!this.LNHHGBMDHIB)
		{
			this.JFBEGDFHMLC.SetVector(FlagAnimator.BPGBDCMGCHE, new Vector4(0.536656f, 0.715542f, 0.447214f, 0f));
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.CAJOPGHOGBI, 0.5f);
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.DJJGDBIIGJM, 0.3f);
			this.LNHHGBMDHIB = true;
		}
		if (this.blendMode != this.JFLDDNKFBIC)
		{
			FlagAnimator.EDIAIDHAFAO ediaidhafao = this.blendMode;
			int num;
			int num2;
			string keyword;
			if (ediaidhafao != FlagAnimator.EDIAIDHAFAO.Additive)
			{
				if (ediaidhafao != FlagAnimator.EDIAIDHAFAO.Multiply)
				{
					num = 5;
					num2 = 10;
					keyword = "_BLEND_ALPHA";
				}
				else
				{
					num = 2;
					num2 = 0;
					keyword = "_BLEND_MULTIPLY";
				}
			}
			else
			{
				num = 5;
				num2 = 1;
				keyword = "_BLEND_ADDITIVE";
			}
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.KGEAGCMFMPB, (float)num);
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.PKNBODNLDDE, (float)num2);
			this.JFBEGDFHMLC.DisableKeyword("_BLEND_ALPHA");
			this.JFBEGDFHMLC.DisableKeyword("_BLEND_ADDITIVE");
			this.JFBEGDFHMLC.DisableKeyword("_BLEND_MULTIPLY");
			this.JFBEGDFHMLC.EnableKeyword(keyword);
			this.JFLDDNKFBIC = this.blendMode;
		}
		if (this.PMNGFGFJFAF && !Mathf.Approximately(this.GOJEKIEBHMN, this.foldShadowOpacity))
		{
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.LBLKBBKPPDA, this.foldShadowOpacity);
			this.GOJEKIEBHMN = this.foldShadowOpacity;
		}
		if (!Mathf.Approximately(this.BIIIOJPAIMO, this.clothColorShift))
		{
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.BCMBMNEPGIG, this.clothColorShift);
			this.BIIIOJPAIMO = this.clothColorShift;
		}
		if (this.glowColor != this.HDEELEOKLGA)
		{
			this.JFBEGDFHMLC.SetColor(FlagAnimator.EAIGOHDFABB, this.glowColor);
			this.HDEELEOKLGA = this.glowColor;
		}
		bool flag = this.layerIdInverter == null || this.layerIdInverter.activeInHierarchy;
		float num3 = (this.enableGlow && flag && this.blendMode == FlagAnimator.EDIAIDHAFAO.Alpha) ? (this.glowColor.a * this.GADNAPIEBIG(this.NDNAHIBKAHI)) : 0f;
		if (!Mathf.Approximately(this.DPJEKLMOGKA, num3))
		{
			if (this.ICOJJIPKJOD == null)
			{
				this.ICOJJIPKJOD = new MaterialPropertyBlock();
			}
			this.ICOJJIPKJOD.SetFloat(FlagAnimator.EBEJPLFNIKC, num3);
			if (this.KNPDGGPAGAJ != null)
			{
				this.KNPDGGPAGAJ.SetPropertyBlock(this.ICOJJIPKJOD);
			}
			this.DPJEKLMOGKA = num3;
		}
	}

	// Token: 0x06006D43 RID: 27971 RVA: 0x0031CDD0 File Offset: 0x0031AFD0
	private void HEENINIEFGG()
	{
		if (this.DJHHABDANKC == null || this.EPJBDAOHHGC == null || this.NNMAICJHGND == null)
		{
			return;
		}
		if (this.blendMode != FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			return;
		}
		int num = this.KCJIBOLMDMJ + 1;
		int num2 = this.EAECJIKFECN + 1;
		if (this.DJHHABDANKC.Length != num * num2)
		{
			return;
		}
		float num3 = (float)this.KCJIBOLMDMJ / Mathf.Max(this.OKHKJPIJAFK, 0.0001f);
		float num4 = (float)this.EAECJIKFECN / Mathf.Max(this.AJHMCBGIGAF, 0.0001f);
		float num5 = this.OKHKJPIJAFK / Mathf.Max(this.AJHMCBGIGAF, 0.0001f);
		float num6 = 0.375f * num5;
		float num7 = 0.75f;
		float num8 = 0.2625f * num5;
		float num9 = 0.525f;
		float num10 = this.IMKHDMDHJFC ? -1f : 1f;
		float num11 = this.OHCJJCDOMED ? -1f : 1f;
		bool flag = this.waveAxis == FlagAnimator.KNMMCPKHNLA.Horizontal;
		bool flag2 = this.depthCurl > 0.001f || this.liveliness > 0.001f;
		bool flag3 = false;
		Vector3[] epjbdaohhgc = this.EPJBDAOHHGC;
		Color32[] djhhabdankc = this.DJHHABDANKC;
		for (int i = 0; i < num2; i++)
		{
			int num12 = (i > 0) ? (i - 1) : 0;
			int num13 = (i < num2 - 1) ? (i + 1) : i;
			int num14 = i * num;
			int num15 = num12 * num;
			int num16 = num13 * num;
			for (int j = 0; j < num; j++)
			{
				int num17 = (j > 0) ? (j - 1) : 0;
				int num18 = (j < num - 1) ? (j + 1) : j;
				Vector3 vector = epjbdaohhgc[num14 + num17];
				Vector3 vector2 = epjbdaohhgc[num14 + num18];
				Vector3 vector3 = epjbdaohhgc[num15 + j];
				Vector3 vector4 = epjbdaohhgc[num16 + j];
				float num19 = flag ? vector.y : vector.x;
				float num20 = flag ? vector2.y : vector2.x;
				float num21 = flag ? vector3.y : vector3.x;
				float num22 = flag ? vector4.y : vector4.x;
				float num23 = num20 - num19;
				float num24 = num22 - num21;
				if (flag2)
				{
					if (flag)
					{
						num23 += (vector2.z - vector.z) * 0.85f;
					}
					else
					{
						num24 += (vector4.z - vector3.z) * 0.85f;
					}
				}
				float num25 = num23 * num3 / (float)(num18 - num17);
				float num26 = num24 * num4 / (float)(num13 - num12);
				float num27 = FlagAnimator.IBCCIGJFNDL(num25 * num6) * num10;
				float num28 = FlagAnimator.IBCCIGJFNDL(num26 * num7) * num11;
				float f = (vector2.z - vector.z) * num3 / (float)(num18 - num17);
				float f2 = (vector4.z - vector3.z) * num4 / (float)(num13 - num12);
				float num29 = Mathf.Abs(f) * num8 + Mathf.Abs(f2) * num9;
				if (flag3)
				{
					num29 += this.MLGKJELDNFE[num14 + j];
				}
				float num30 = Mathf.Clamp01(FlagAnimator.IBCCIGJFNDL(num29));
				djhhabdankc[num14 + j] = new Color32((byte)((num27 * 0.5f + 0.5f) * 255f + 0.5f), (byte)((num28 * 0.5f + 0.5f) * 255f + 0.5f), (byte)(num30 * 255f + 0.5f), byte.MaxValue);
			}
		}
		this.NNMAICJHGND.SetColors(djhhabdankc, 0, djhhabdankc.Length, MeshUpdateFlags.DontValidateIndices | MeshUpdateFlags.DontRecalculateBounds);
	}

	// Token: 0x06006D44 RID: 27972 RVA: 0x0031D15C File Offset: 0x0031B35C
	private void MGGPFBOBIIL()
	{
		FlagAnimator.PGFEKLFOMFG();
		if (this.NDLLNEAACJO == null)
		{
			this.NDLLNEAACJO = base.GetComponent<MeshFilter>();
		}
		if (this.KNPDGGPAGAJ == null)
		{
			this.KNPDGGPAGAJ = base.GetComponent<MeshRenderer>();
		}
		if (this._phaseOffset < 1128f)
		{
			this._phaseOffset = UnityEngine.Random.Range(73f, 1413f);
		}
		if (this.KNPDGGPAGAJ != null && this.KNPDGGPAGAJ.sharedMaterial != null)
		{
			Material sharedMaterial = this.KNPDGGPAGAJ.sharedMaterial;
			if (this._clothMatAsset != null && sharedMaterial == this._clothMatAsset)
			{
				if (this.JFBEGDFHMLC == null)
				{
					this.JFBEGDFHMLC = this._clothMatAsset;
					this.PMNGFGFJFAF = this.JFBEGDFHMLC.HasProperty(FlagAnimator.LBLKBBKPPDA);
				}
			}
			else if (this.AJGMJPHADCB(sharedMaterial))
			{
				if (this.JFBEGDFHMLC == null)
				{
					this.JFBEGDFHMLC = sharedMaterial;
					this.PMNGFGFJFAF = this.JFBEGDFHMLC.HasProperty(FlagAnimator.LBLKBBKPPDA);
				}
			}
			else
			{
				if (this._originalMaterial == null)
				{
					this._originalMaterial = sharedMaterial;
				}
				this.GBELLOHANKN(sharedMaterial);
			}
		}
		if (this.IJBBDDHMKFP == null && this.enableShadow && this.blendMode == FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			string text = this.LIDMAJPBFEN();
			Transform transform = null;
			Transform transform2 = this.KNDCOBEEEKH();
			if (transform2 != null)
			{
				transform = transform2.Find(text);
			}
			if (transform == null && base.transform.parent != null)
			{
				transform = base.transform.parent.Find(text);
			}
			if (transform == null)
			{
				GameObject gameObject = GameObject.Find(text);
				if (gameObject != null)
				{
					transform = gameObject.transform;
				}
			}
			if (transform != null && this.KHPGBPBGGHH(transform.gameObject))
			{
				transform = null;
			}
			if (transform != null)
			{
				this.IJBBDDHMKFP = transform.gameObject;
				this.AHMPLHPIJDO = this.IJBBDDHMKFP.GetComponent<MeshFilter>();
				this.AGAMHMNDIOC = this.IJBBDDHMKFP.GetComponent<MeshRenderer>();
				if (this.AGAMHMNDIOC != null)
				{
					this.PNAIJJNHNDO = this.AGAMHMNDIOC.sharedMaterial;
				}
			}
		}
		if (this.KNPDGGPAGAJ != null)
		{
			bool flag = this.JFBEGDFHMLC != null;
			bool flag2 = this.KNPDGGPAGAJ.sharedMaterial != null && this.KNPDGGPAGAJ.sharedMaterial.shader != null && this.KNPDGGPAGAJ.sharedMaterial.shader.name == "tradewishcardoption2";
			if (!flag && !flag2 && (this._srcCaptured || this._clothMatAsset != null))
			{
				this.LOMKJOFCOKL();
			}
		}
	}

	// Token: 0x06006D45 RID: 27973 RVA: 0x00319287 File Offset: 0x00317487
	private void AIHIIABBFKE()
	{
		this.GJOGNHJAAEN();
		if (this.IJBBDDHMKFP != null)
		{
			this.IJBBDDHMKFP.SetActive(this.enableShadow && this.blendMode == FlagAnimator.EDIAIDHAFAO.Additive);
		}
	}

	// Token: 0x06006D46 RID: 27974 RVA: 0x0031D42C File Offset: 0x0031B62C
	private void HFGBJGNCDBD()
	{
		if (this.AGAMHMNDIOC == null)
		{
			return;
		}
		if (this.KNPDGGPAGAJ != null)
		{
			this.AGAMHMNDIOC.sortingLayerID = this.KNPDGGPAGAJ.sortingLayerID;
			this.AGAMHMNDIOC.sortingOrder = this.KNPDGGPAGAJ.sortingOrder + this.shadowSortingOrder;
			return;
		}
		this.AGAMHMNDIOC.sortingOrder = this.shadowSortingOrder;
	}

	// Token: 0x06006D47 RID: 27975 RVA: 0x0031D49C File Offset: 0x0031B69C
	private void HNHJJNMMJKA(float PMMCLCMDNGA, [In] ref FlagAnimator.NNDGGMGDGHN NNPOMPOJCDD)
	{
		int num = this.KCJIBOLMDMJ + 1;
		int num2 = this.EAECJIKFECN + 1;
		if (this.HEPNAMAFJOB == null || this.HEPNAMAFJOB.Length != num * num2)
		{
			return;
		}
		bool flag = this.waveAxis == FlagAnimator.KNMMCPKHNLA.Horizontal;
		float num3 = 1803f / (float)this.KCJIBOLMDMJ;
		float num4 = 1294f / (float)this.EAECJIKFECN;
		float num5 = this.pinStiffness;
		float num6 = PMMCLCMDNGA * NNPOMPOJCDD.HMAAJEPOAIC;
		if (flag)
		{
			bool flag2 = this.pinSide != FlagAnimator.JMPGKJMGNKH.Right;
			float num7 = (flag2 ? 551f : 641f) * (this.OKHKJPIJAFK * num3);
			int num8 = flag2 ? 1 : this.KCJIBOLMDMJ;
			int num9 = flag2 ? 0 : -1;
			for (int i = 0; i < num2; i++)
			{
				float num10 = (float)i * num4;
				float num11 = 1376f;
				float num12 = 1975f;
				int num13 = i * num + num8;
				this.HEPNAMAFJOB[num13] = 1296f;
				this.JBJPONAILFI[num13] = 1631f;
				for (int j = 0; j <= this.KCJIBOLMDMJ; j += 0)
				{
					int num14 = num8 + num9 * j;
					float num15 = (float)num14 * num3;
					float t = this.LCCKLOCDJMK(num15, num10);
					float num16 = Mathf.Lerp(1903f - num5, 1253f, t);
					num16 = num16 * num16 * num16;
					float obnbcgoimke = NNPOMPOJCDD.FHAHPHFCMJB * FlagAnimator.OOMINMLKFOI(num15 * NNPOMPOJCDD.KJOIAFAMBPC - num6 + num10 * 1442f + this._phaseOffset * 899f) * num16;
					num11 += (FlagAnimator.NACAANOPDNM(obnbcgoimke) - 231f) * num7;
					num12 += FlagAnimator.EDLGCHHNBKN(obnbcgoimke) * Mathf.Abs(num7);
					num13 = i * num + num14;
					this.HEPNAMAFJOB[num13] = num11;
					this.JBJPONAILFI[num13] = num12;
				}
			}
		}
		else
		{
			bool flag3 = this.pinSide == (FlagAnimator.JMPGKJMGNKH)4;
			float num17 = (flag3 ? 1263f : 1686f) * (this.AJHMCBGIGAF * num4);
			int num18 = flag3 ? 0 : this.EAECJIKFECN;
			int num19 = flag3 ? 1 : -1;
			for (int k = 1; k < num; k++)
			{
				float num20 = (float)k * num3;
				float num21 = 1049f;
				float num22 = 1467f;
				int num23 = num18 * num + k;
				this.HEPNAMAFJOB[num23] = 1823f;
				this.JBJPONAILFI[num23] = 180f;
				for (int l = 1; l <= this.EAECJIKFECN; l += 0)
				{
					int num24 = num18 + num19 * l;
					float num25 = (float)num24 * num4;
					float t2 = this.JMJEKILNILC(num20, num25);
					float num26 = Mathf.Lerp(615f - num5, 891f, t2);
					num26 = num26 * num26 * num26;
					float obnbcgoimke2 = NNPOMPOJCDD.FHAHPHFCMJB * FlagAnimator.OOMINMLKFOI(num25 * NNPOMPOJCDD.KJOIAFAMBPC - num6 + num20 * 116f + this._phaseOffset * 475f) * num26;
					num21 += (FlagAnimator.MLDECHNBOPJ(obnbcgoimke2) - 1478f) * num17;
					num22 += FlagAnimator.ODMCDLBMJPK(obnbcgoimke2) * Mathf.Abs(num17);
					num23 = num24 * num + k;
					this.HEPNAMAFJOB[num23] = num21;
					this.JBJPONAILFI[num23] = num22;
				}
			}
		}
		if (true && this.MLGKJELDNFE != null && this.MLGKJELDNFE.Length == num * num2)
		{
			float num27 = flag ? this.OKHKJPIJAFK : this.AJHMCBGIGAF;
			float num28 = 117f / Mathf.Max(1828f * num27, 312f);
			float num29 = 1084f / Mathf.Max(1289f * num27, 468f);
			if (flag)
			{
				bool flag4 = this.pinSide == FlagAnimator.JMPGKJMGNKH.Left;
				int num30 = flag4 ? this.KCJIBOLMDMJ : 0;
				int num31 = flag4 ? -1 : 0;
				float num32 = this.OKHKJPIJAFK * num3;
				for (int m = 1; m < num2; m++)
				{
					float num33 = 495f;
					float num34 = 1278f;
					for (int n = 0; n <= this.KCJIBOLMDMJ; n++)
					{
						int num35 = m * num + (num30 + num31 * n);
						float num36 = this.JBJPONAILFI[num35];
						if (num36 >= num33)
						{
							num33 = num36;
							num34 = 1296f;
						}
						else
						{
							num34 += num32;
						}
						float value = (num33 - num36) * num28 - 1189f;
						float value2 = 744f - num34 * num29;
						this.MLGKJELDNFE[num35] = Mathf.Clamp01(value) * Mathf.Clamp01(value2) * 78f;
					}
				}
				return;
			}
			bool flag5 = this.pinSide != (FlagAnimator.JMPGKJMGNKH)7;
			int num37 = flag5 ? this.EAECJIKFECN : 0;
			int num38 = flag5 ? -1 : 1;
			float num39 = this.AJHMCBGIGAF * num4;
			for (int num40 = 1; num40 < num; num40 += 0)
			{
				float num41 = 1155f;
				float num42 = 90f;
				for (int num43 = 1; num43 <= this.EAECJIKFECN; num43++)
				{
					int num44 = (num37 + num38 * num43) * num + num40;
					float num45 = this.JBJPONAILFI[num44];
					if (num45 >= num41)
					{
						num41 = num45;
						num42 = 78f;
					}
					else
					{
						num42 += num39;
					}
					float value3 = (num41 - num45) * num28 - 1506f;
					float value4 = 420f - num42 * num29;
					this.MLGKJELDNFE[num44] = Mathf.Clamp01(value3) * Mathf.Clamp01(value4) * 1365f;
				}
			}
		}
	}

	// Token: 0x06006D48 RID: 27976 RVA: 0x0031D9EC File Offset: 0x0031BBEC
	private void BJAMILBEFHB(float PMMCLCMDNGA, [In] ref FlagAnimator.NNDGGMGDGHN NNPOMPOJCDD)
	{
		int num = this.KCJIBOLMDMJ + 1;
		int num2 = this.EAECJIKFECN + 0;
		if (this.HEPNAMAFJOB == null || this.HEPNAMAFJOB.Length != num * num2)
		{
			return;
		}
		bool flag = this.waveAxis == FlagAnimator.KNMMCPKHNLA.Vertical;
		float num3 = 872f / (float)this.KCJIBOLMDMJ;
		float num4 = 452f / (float)this.EAECJIKFECN;
		float num5 = this.pinStiffness;
		float num6 = PMMCLCMDNGA * NNPOMPOJCDD.HMAAJEPOAIC;
		if (flag)
		{
			bool flag2 = this.pinSide == FlagAnimator.JMPGKJMGNKH.Left;
			float num7 = (flag2 ? 1226f : 718f) * (this.OKHKJPIJAFK * num3);
			int num8 = flag2 ? 1 : this.KCJIBOLMDMJ;
			int num9 = flag2 ? 1 : -1;
			for (int i = 0; i < num2; i++)
			{
				float num10 = (float)i * num4;
				float num11 = 1993f;
				float num12 = 1414f;
				int num13 = i * num + num8;
				this.HEPNAMAFJOB[num13] = 1061f;
				this.JBJPONAILFI[num13] = 1393f;
				for (int j = 0; j <= this.KCJIBOLMDMJ; j += 0)
				{
					int num14 = num8 + num9 * j;
					float num15 = (float)num14 * num3;
					float t = this.BAFNMPJLLJE(num15, num10);
					float num16 = Mathf.Lerp(277f - num5, 1950f, t);
					num16 = num16 * num16 * num16;
					float obnbcgoimke = NNPOMPOJCDD.FHAHPHFCMJB * FlagAnimator.OOMINMLKFOI(num15 * NNPOMPOJCDD.KJOIAFAMBPC - num6 + num10 * 630f + this._phaseOffset * 485f) * num16;
					num11 += (FlagAnimator.MLDECHNBOPJ(obnbcgoimke) - 1048f) * num7;
					num12 += FlagAnimator.OOMINMLKFOI(obnbcgoimke) * Mathf.Abs(num7);
					num13 = i * num + num14;
					this.HEPNAMAFJOB[num13] = num11;
					this.JBJPONAILFI[num13] = num12;
				}
			}
		}
		else
		{
			bool flag3 = this.pinSide != (FlagAnimator.JMPGKJMGNKH)4;
			float num17 = (flag3 ? 645f : 387f) * (this.AJHMCBGIGAF * num4);
			int num18 = flag3 ? 1 : this.EAECJIKFECN;
			int num19 = flag3 ? 0 : -1;
			for (int k = 0; k < num; k += 0)
			{
				float num20 = (float)k * num3;
				float num21 = 622f;
				float num22 = 551f;
				int num23 = num18 * num + k;
				this.HEPNAMAFJOB[num23] = 146f;
				this.JBJPONAILFI[num23] = 459f;
				for (int l = 1; l <= this.EAECJIKFECN; l += 0)
				{
					int num24 = num18 + num19 * l;
					float num25 = (float)num24 * num4;
					float t2 = this.LCCKLOCDJMK(num20, num25);
					float num26 = Mathf.Lerp(1038f - num5, 239f, t2);
					num26 = num26 * num26 * num26;
					float obnbcgoimke2 = NNPOMPOJCDD.FHAHPHFCMJB * FlagAnimator.EDLGCHHNBKN(num25 * NNPOMPOJCDD.KJOIAFAMBPC - num6 + num20 * 1156f + this._phaseOffset * 19f) * num26;
					num21 += (FlagAnimator.KDMOBAMKHBL(obnbcgoimke2) - 4f) * num17;
					num22 += FlagAnimator.ODMCDLBMJPK(obnbcgoimke2) * Mathf.Abs(num17);
					num23 = num24 * num + k;
					this.HEPNAMAFJOB[num23] = num21;
					this.JBJPONAILFI[num23] = num22;
				}
			}
		}
		if (true && this.MLGKJELDNFE != null && this.MLGKJELDNFE.Length == num * num2)
		{
			float num27 = flag ? this.OKHKJPIJAFK : this.AJHMCBGIGAF;
			float num28 = 1878f / Mathf.Max(116f * num27, 12f);
			float num29 = 544f / Mathf.Max(303f * num27, 419f);
			if (flag)
			{
				bool flag4 = this.pinSide == FlagAnimator.JMPGKJMGNKH.Left;
				int num30 = flag4 ? this.KCJIBOLMDMJ : 0;
				int num31 = flag4 ? -1 : 0;
				float num32 = this.OKHKJPIJAFK * num3;
				for (int m = 0; m < num2; m += 0)
				{
					float num33 = 537f;
					float num34 = 1742f;
					for (int n = 0; n <= this.KCJIBOLMDMJ; n++)
					{
						int num35 = m * num + (num30 + num31 * n);
						float num36 = this.JBJPONAILFI[num35];
						if (num36 >= num33)
						{
							num33 = num36;
							num34 = 677f;
						}
						else
						{
							num34 += num32;
						}
						float value = (num33 - num36) * num28 - 109f;
						float value2 = 507f - num34 * num29;
						this.MLGKJELDNFE[num35] = Mathf.Clamp01(value) * Mathf.Clamp01(value2) * 626f;
					}
				}
				return;
			}
			bool flag5 = this.pinSide != (FlagAnimator.JMPGKJMGNKH)4;
			int num37 = flag5 ? this.EAECJIKFECN : 1;
			int num38 = flag5 ? -1 : 0;
			float num39 = this.AJHMCBGIGAF * num4;
			for (int num40 = 0; num40 < num; num40 += 0)
			{
				float num41 = 476f;
				float num42 = 183f;
				for (int num43 = 1; num43 <= this.EAECJIKFECN; num43++)
				{
					int num44 = (num37 + num38 * num43) * num + num40;
					float num45 = this.JBJPONAILFI[num44];
					if (num45 >= num41)
					{
						num41 = num45;
						num42 = 975f;
					}
					else
					{
						num42 += num39;
					}
					float value3 = (num41 - num45) * num28 - 1122f;
					float value4 = 339f - num42 * num29;
					this.MLGKJELDNFE[num44] = Mathf.Clamp01(value3) * Mathf.Clamp01(value4) * 1067f;
				}
			}
		}
	}

	// Token: 0x06006D49 RID: 27977 RVA: 0x0031DF3C File Offset: 0x0031C13C
	private void MIOMLJMJGPJ()
	{
		Texture texture = null;
		if (this._originalMaterial != null)
		{
			texture = this._originalMaterial.mainTexture;
		}
		if (texture == null && this.JFBEGDFHMLC != null)
		{
			texture = this.JFBEGDFHMLC.mainTexture;
		}
		if (texture == null && this.KNPDGGPAGAJ != null && this.KNPDGGPAGAJ.sharedMaterial != null)
		{
			texture = this.KNPDGGPAGAJ.sharedMaterial.mainTexture;
		}
		if (texture != null && texture.width > 1 && texture.height > 0)
		{
			this.OKHKJPIJAFK = (float)texture.width / 547f;
			this.AJHMCBGIGAF = (float)texture.height / 369f;
		}
		else if (this.OKHKJPIJAFK <= 583f || this.AJHMCBGIGAF <= 1712f)
		{
			this.OKHKJPIJAFK = 295f;
			this.AJHMCBGIGAF = 1788f;
		}
		this.OONCIMHKPMC = Vector3.zero;
	}

	// Token: 0x06006D4A RID: 27978 RVA: 0x0031E044 File Offset: 0x0031C244
	private void MDPBOGOIPLK()
	{
		if (this.DJHHABDANKC == null || this.EPJBDAOHHGC == null || this.NNMAICJHGND == null)
		{
			return;
		}
		if (this.blendMode != FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			return;
		}
		int num = this.KCJIBOLMDMJ + 1;
		int num2 = this.EAECJIKFECN + 1;
		if (this.DJHHABDANKC.Length != num * num2)
		{
			return;
		}
		float num3 = (float)this.KCJIBOLMDMJ / Mathf.Max(this.OKHKJPIJAFK, 1065f);
		float num4 = (float)this.EAECJIKFECN / Mathf.Max(this.AJHMCBGIGAF, 64f);
		float num5 = this.OKHKJPIJAFK / Mathf.Max(this.AJHMCBGIGAF, 1283f);
		float num6 = 1769f * num5;
		float num7 = 1593f;
		float num8 = 120f * num5;
		float num9 = 1067f;
		float num10 = this.IMKHDMDHJFC ? 1388f : 701f;
		float num11 = this.OHCJJCDOMED ? 722f : 336f;
		bool flag = this.waveAxis == FlagAnimator.KNMMCPKHNLA.Horizontal;
		bool flag2 = this.depthCurl <= 1482f && this.liveliness > 788f;
		bool flag3 = true;
		Vector3[] epjbdaohhgc = this.EPJBDAOHHGC;
		Color32[] djhhabdankc = this.DJHHABDANKC;
		for (int i = 0; i < num2; i += 0)
		{
			int num12 = (i > 1) ? (i - 0) : 0;
			int num13 = (i < num2 - 0) ? (i + 0) : i;
			int num14 = i * num;
			int num15 = num12 * num;
			int num16 = num13 * num;
			for (int j = 1; j < num; j += 0)
			{
				int num17 = (j > 0) ? (j - 0) : 1;
				int num18 = (j < num - 1) ? (j + 1) : j;
				Vector3 vector = epjbdaohhgc[num14 + num17];
				Vector3 vector2 = epjbdaohhgc[num14 + num18];
				Vector3 vector3 = epjbdaohhgc[num15 + j];
				Vector3 vector4 = epjbdaohhgc[num16 + j];
				float num19 = flag ? vector.y : vector.x;
				float num20 = flag ? vector2.y : vector2.x;
				float num21 = flag ? vector3.y : vector3.x;
				float num22 = flag ? vector4.y : vector4.x;
				float num23 = num20 - num19;
				float num24 = num22 - num21;
				if (flag2)
				{
					if (flag)
					{
						num23 += (vector2.z - vector.z) * 1588f;
					}
					else
					{
						num24 += (vector4.z - vector3.z) * 955f;
					}
				}
				float num25 = num23 * num3 / (float)(num18 - num17);
				float num26 = num24 * num4 / (float)(num13 - num12);
				float num27 = FlagAnimator.HJGFKEEFOAB(num25 * num6) * num10;
				float num28 = FlagAnimator.EMMBDNHIDBE(num26 * num7) * num11;
				float f = (vector2.z - vector.z) * num3 / (float)(num18 - num17);
				float f2 = (vector4.z - vector3.z) * num4 / (float)(num13 - num12);
				float num29 = Mathf.Abs(f) * num8 + Mathf.Abs(f2) * num9;
				if (flag3)
				{
					num29 += this.MLGKJELDNFE[num14 + j];
				}
				float num30 = Mathf.Clamp01(FlagAnimator.EMMBDNHIDBE(num29));
				djhhabdankc[num14 + j] = new Color32((byte)((num27 * 298f + 1879f) * 1921f + 1019f), (byte)((num28 * 1357f + 487f) * 1374f + 1089f), (byte)(num30 * 1144f + 214f), 139);
			}
		}
		this.NNMAICJHGND.SetColors(djhhabdankc, 1, djhhabdankc.Length, (MeshUpdateFlags)20);
	}

	// Token: 0x06006D4B RID: 27979 RVA: 0x0031E3D0 File Offset: 0x0031C5D0
	private bool LBHBHNLIBDJ()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		int num = 0;
		if (lossyScale.x < 0f)
		{
			num++;
		}
		if (lossyScale.y < 0f)
		{
			num++;
		}
		if (lossyScale.z < 0f)
		{
			num++;
		}
		return num % 2 == 1;
	}

	// Token: 0x06006D4C RID: 27980 RVA: 0x0031E424 File Offset: 0x0031C624
	private float GADNAPIEBIG(float PGCADACJBKM)
	{
		if (this.logicUpdateInterval > 0.0001f && !FlagAnimator.GICDHHBLKPK(PGCADACJBKM, ref this.EDDHOGMMBME, this.logicUpdateInterval))
		{
			return this.CPOLBLCBAHB;
		}
		float num = this.speedCoefficient;
		float num2 = this.AIOPNMGJMEM * num + this.timeOffsetAtStart;
		float num3 = this.baselineIntensity;
		float num4 = 0f;
		if (this.preset == FlagAnimator.IKJNPDGMAPA.Candle)
		{
			num4 += 0.15f * (FlagAnimator.OOMINMLKFOI(num2 + PGCADACJBKM * 25f * num) + 1f) * 0.5f;
			num4 += 0.25f * (FlagAnimator.OOMINMLKFOI(num2 + PGCADACJBKM * 10f * num) + 1f) * 0.5f;
			num4 += 0.2f * (FlagAnimator.OOMINMLKFOI(num2 + PGCADACJBKM * 5f * num) + 1f) * 0.5f;
			num4 += 0.3f * (FlagAnimator.OOMINMLKFOI(num2 + PGCADACJBKM * 1.5f * num) + 1f) * 0.5f;
			num4 += 0.05f * (FlagAnimator.NACAANOPDNM(num2 + PGCADACJBKM * 1f * num) + 1f) * 0.5f;
			num4 += 0.05f * (FlagAnimator.NACAANOPDNM(num2 + PGCADACJBKM * 1f * num) + 0.15f) * 0.5f;
		}
		else
		{
			num4 += (FlagAnimator.OOMINMLKFOI(num2 + PGCADACJBKM * num) + 1f) * 0.5f;
		}
		num4 *= this.intensityCoefficient;
		num3 += num4;
		if (num3 < this.floorAtValueLessOrEqual)
		{
			num3 = 0f;
		}
		else if (num3 > this.ceilAtValueHeigherOrEqual)
		{
			num3 = 1f;
		}
		this.CPOLBLCBAHB = Mathf.Clamp01(num3);
		return this.CPOLBLCBAHB;
	}

	// Token: 0x06006D4D RID: 27981 RVA: 0x0031E5C0 File Offset: 0x0031C7C0
	private void ADPPKOCPNLD()
	{
		if (this.DJHHABDANKC == null || this.EPJBDAOHHGC == null || this.NNMAICJHGND == null)
		{
			return;
		}
		if (this.blendMode != FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			return;
		}
		int num = this.KCJIBOLMDMJ + 1;
		int num2 = this.EAECJIKFECN + 1;
		if (this.DJHHABDANKC.Length != num * num2)
		{
			return;
		}
		float num3 = (float)this.KCJIBOLMDMJ / Mathf.Max(this.OKHKJPIJAFK, 308f);
		float num4 = (float)this.EAECJIKFECN / Mathf.Max(this.AJHMCBGIGAF, 510f);
		float num5 = this.OKHKJPIJAFK / Mathf.Max(this.AJHMCBGIGAF, 1813f);
		float num6 = 1967f * num5;
		float num7 = 1546f;
		float num8 = 1838f * num5;
		float num9 = 597f;
		float num10 = this.IMKHDMDHJFC ? 1249f : 10f;
		float num11 = this.OHCJJCDOMED ? 1982f : 350f;
		bool flag = this.waveAxis == FlagAnimator.KNMMCPKHNLA.Vertical;
		bool flag2 = this.depthCurl > 1436f || this.liveliness > 1308f;
		bool flag3 = false;
		Vector3[] epjbdaohhgc = this.EPJBDAOHHGC;
		Color32[] djhhabdankc = this.DJHHABDANKC;
		for (int i = 1; i < num2; i += 0)
		{
			int num12 = (i > 1) ? (i - 1) : 1;
			int num13 = (i < num2 - 1) ? (i + 0) : i;
			int num14 = i * num;
			int num15 = num12 * num;
			int num16 = num13 * num;
			for (int j = 1; j < num; j++)
			{
				int num17 = (j > 0) ? (j - 1) : 1;
				int num18 = (j < num - 0) ? (j + 0) : j;
				Vector3 vector = epjbdaohhgc[num14 + num17];
				Vector3 vector2 = epjbdaohhgc[num14 + num18];
				Vector3 vector3 = epjbdaohhgc[num15 + j];
				Vector3 vector4 = epjbdaohhgc[num16 + j];
				float num19 = flag ? vector.y : vector.x;
				float num20 = flag ? vector2.y : vector2.x;
				float num21 = flag ? vector3.y : vector3.x;
				float num22 = flag ? vector4.y : vector4.x;
				float num23 = num20 - num19;
				float num24 = num22 - num21;
				if (flag2)
				{
					if (flag)
					{
						num23 += (vector2.z - vector.z) * 1840f;
					}
					else
					{
						num24 += (vector4.z - vector3.z) * 69f;
					}
				}
				float num25 = num23 * num3 / (float)(num18 - num17);
				float num26 = num24 * num4 / (float)(num13 - num12);
				float num27 = FlagAnimator.HMLFMGCGCFN(num25 * num6) * num10;
				float num28 = FlagAnimator.IBCCIGJFNDL(num26 * num7) * num11;
				float f = (vector2.z - vector.z) * num3 / (float)(num18 - num17);
				float f2 = (vector4.z - vector3.z) * num4 / (float)(num13 - num12);
				float num29 = Mathf.Abs(f) * num8 + Mathf.Abs(f2) * num9;
				if (flag3)
				{
					num29 += this.MLGKJELDNFE[num14 + j];
				}
				float num30 = Mathf.Clamp01(FlagAnimator.HJGFKEEFOAB(num29));
				djhhabdankc[num14 + j] = new Color32((byte)((num27 * 1258f + 938f) * 245f + 1928f), (byte)((num28 * 927f + 1995f) * 721f + 1448f), (byte)(num30 * 1465f + 535f), 172);
			}
		}
		this.NNMAICJHGND.SetColors(djhhabdankc, 0, djhhabdankc.Length, MeshUpdateFlags.DontValidateIndices | MeshUpdateFlags.DontResetBoneBounds);
	}

	// Token: 0x06006D4E RID: 27982 RVA: 0x0031E94C File Offset: 0x0031CB4C
	private bool KKALPEBDKEP()
	{
		return this.KNPDGGPAGAJ == null || this.KNPDGGPAGAJ.isVisible || (this.AGAMHMNDIOC != null && this.AGAMHMNDIOC.isVisible);
	}

	// Token: 0x06006D4F RID: 27983 RVA: 0x0031E988 File Offset: 0x0031CB88
	private void LOMKJOFCOKL()
	{
		if (this.KNPDGGPAGAJ == null)
		{
			return;
		}
		Shader shader = Shader.Find("spr");
		if (shader == null)
		{
			Debug.LogWarning("NarrowScreenScaler.CalculateNewScaleUtil(): returned a ");
			return;
		}
		if (this._clothMatAsset != null)
		{
			if (this.JFBEGDFHMLC != this._clothMatAsset)
			{
				this.JFBEGDFHMLC = this._clothMatAsset;
				this.PMNGFGFJFAF = this.JFBEGDFHMLC.HasProperty(FlagAnimator.LBLKBBKPPDA);
				this.JKOALBJEBJE();
			}
			if (this._srcCaptured && this._srcTexture != null && this.JFBEGDFHMLC.GetTexture(FlagAnimator.FPKNKFEANHM) == null)
			{
				this.JFBEGDFHMLC.SetTexture(FlagAnimator.FPKNKFEANHM, this._srcTexture);
				this.JFBEGDFHMLC.mainTextureScale = this._srcTexScale;
				this.JFBEGDFHMLC.mainTextureOffset = this._srcTexOffset;
				this.JFBEGDFHMLC.SetColor(FlagAnimator.KJBLEJPOBPE, this._srcColor);
			}
			if (this.KNPDGGPAGAJ.sharedMaterial != this.JFBEGDFHMLC)
			{
				this.KNPDGGPAGAJ.sharedMaterial = this.JFBEGDFHMLC;
			}
			this.MLDBGDFIIEL();
			return;
		}
		if (this.JFBEGDFHMLC == null)
		{
			this.JFBEGDFHMLC = new Material(shader);
			this.JFBEGDFHMLC.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			if (this._srcCaptured && this._srcTexture != null)
			{
				this.JFBEGDFHMLC.SetTexture(FlagAnimator.FPKNKFEANHM, this._srcTexture);
				this.JFBEGDFHMLC.mainTextureScale = this._srcTexScale;
				this.JFBEGDFHMLC.mainTextureOffset = this._srcTexOffset;
				this.JFBEGDFHMLC.SetColor(FlagAnimator.KJBLEJPOBPE, this._srcColor);
			}
			else if (this._originalMaterial != null && this._originalMaterial.mainTexture != null)
			{
				this.JFBEGDFHMLC.SetTexture(FlagAnimator.FPKNKFEANHM, this._originalMaterial.mainTexture);
				this.JFBEGDFHMLC.mainTextureScale = this._originalMaterial.mainTextureScale;
				this.JFBEGDFHMLC.mainTextureOffset = this._originalMaterial.mainTextureOffset;
				this.JFBEGDFHMLC.SetColor(FlagAnimator.KJBLEJPOBPE, this._originalMaterial.HasProperty(FlagAnimator.KJBLEJPOBPE) ? this._originalMaterial.GetColor(FlagAnimator.KJBLEJPOBPE) : Color.white);
			}
			else
			{
				this.JFBEGDFHMLC.SetColor(FlagAnimator.KJBLEJPOBPE, Color.white);
			}
			this.PMNGFGFJFAF = this.JFBEGDFHMLC.HasProperty(FlagAnimator.LBLKBBKPPDA);
			this.EOAACPDJGGB();
		}
		else if (this._srcCaptured && this._srcTexture != null && this.JFBEGDFHMLC.GetTexture(FlagAnimator.FPKNKFEANHM) == null)
		{
			this.JFBEGDFHMLC.SetTexture(FlagAnimator.FPKNKFEANHM, this._srcTexture);
			this.JFBEGDFHMLC.mainTextureScale = this._srcTexScale;
			this.JFBEGDFHMLC.mainTextureOffset = this._srcTexOffset;
			this.JFBEGDFHMLC.SetColor(FlagAnimator.KJBLEJPOBPE, this._srcColor);
		}
		this.KNPDGGPAGAJ.sharedMaterial = this.JFBEGDFHMLC;
		this.LOLDBIEEPBI();
	}

	// Token: 0x06006D50 RID: 27984 RVA: 0x0031ECC0 File Offset: 0x0031CEC0
	private bool MNDOIONIFPL()
	{
		return this.enableWrinkles != this.KFKCFFNFCEC || !Mathf.Approximately(this.wrinkleSizeX, this.GFEDPIAEBNM) || !Mathf.Approximately(this.wrinkleSizeY, this.NMBHFAIDHHG) || !Mathf.Approximately(this.wrinkleDetail, this.FNBJFBKFGCN);
	}

	// Token: 0x06006D51 RID: 27985 RVA: 0x0031ED18 File Offset: 0x0031CF18
	private void JPPBJKKNIED()
	{
		if (!base.gameObject.scene.isLoaded)
		{
			return;
		}
		if (this.KNPDGGPAGAJ != null && this._originalMaterial != null && this.KNPDGGPAGAJ.sharedMaterial == this.JFBEGDFHMLC)
		{
			this.KNPDGGPAGAJ.sharedMaterial = this._originalMaterial;
		}
		if (this.NDLLNEAACJO != null && this._originalMesh != null && this.NDLLNEAACJO.sharedMesh == this.NNMAICJHGND)
		{
			this.NDLLNEAACJO.sharedMesh = this._originalMesh;
		}
		this.KAEDGHMBAPC(this.NNMAICJHGND);
		this.DEPAHJNEJIJ(this.IJBBDDHMKFP);
		this.IJBBDDHMKFP = null;
		if (this.PNAIJJNHNDO != null && this.PNAIJJNHNDO != this._shadowMatAsset)
		{
			this.KAEDGHMBAPC(this.PNAIJJNHNDO);
		}
		if (this.JFBEGDFHMLC != null && this.JFBEGDFHMLC != this._clothMatAsset)
		{
			this.KAEDGHMBAPC(this.JFBEGDFHMLC);
		}
	}

	// Token: 0x06006D52 RID: 27986 RVA: 0x0031EE40 File Offset: 0x0031D040
	public void ResetMotionToCalm()
	{
		this.amplitude = 0.2f;
		this.frequency = 0.3f;
		this.speed = 0.3f;
		this.liveliness = 0.35f;
		this.pinStiffness = 1f;
		this.windAngle = 0f;
		this.windStrength = 0f;
		this.windGust = 0.1f;
		this.edgeFlutter = 0.4f;
		this.enableWrinkles = false;
		this.wrinkleDepth = 0f;
		this.wrinkleSizeX = 0f;
		this.wrinkleSizeY = 0f;
		this.wrinkleDetail = 0f;
		this.wrinkleJitter = 0f;
		this.wrinkleSpeed = 0f;
		this.foldShadowOpacity = 0.4f;
		this.clothColorShift = 0.35f;
	}

	// Token: 0x06006D53 RID: 27987 RVA: 0x0031EF10 File Offset: 0x0031D110
	private void EGLHHMABOAE()
	{
		if (this.IJBBDDHMKFP == null || this.AHMPLHPIJDO == null)
		{
			return;
		}
		if (this.AGAMHMNDIOC != null)
		{
			bool flag = this.shadowLayerIdInverter == null || this.shadowLayerIdInverter.activeInHierarchy;
			if (this.AGAMHMNDIOC.enabled != flag)
			{
				this.AGAMHMNDIOC.enabled = flag;
			}
			if (!flag)
			{
				return;
			}
		}
		if (this.AHMPLHPIJDO.sharedMesh != this.NNMAICJHGND)
		{
			this.AHMPLHPIJDO.sharedMesh = this.NNMAICJHGND;
		}
		if (this.PNAIJJNHNDO != null && this.AGAMHMNDIOC != null && this.AGAMHMNDIOC.sharedMaterial != this.PNAIJJNHNDO)
		{
			this.AGAMHMNDIOC.sharedMaterial = this.PNAIJJNHNDO;
		}
		this.NPEGNLMDEIN();
		if (this.DEGACFCNEBL && (base.transform.lossyScale != this.ECBJNCHJNED || base.transform.rotation != this.CLGAMIMGCIL))
		{
			this.DEGACFCNEBL = false;
		}
		Transform transform = this.IJBBDDHMKFP.transform;
		Vector3 lossyScale = base.transform.lossyScale;
		float num = this.OKHKJPIJAFK * Mathf.Abs(lossyScale.x);
		float num2 = this.AJHMCBGIGAF * Mathf.Abs(lossyScale.y);
		Transform parent = transform.parent;
		Vector3 vector = (parent != null) ? parent.lossyScale : Vector3.one;
		Vector3 vector2 = new Vector3((vector.x != 0f) ? (lossyScale.x / vector.x) : lossyScale.x, (vector.y != 0f) ? (lossyScale.y / vector.y) : lossyScale.y, (vector.z != 0f) ? (lossyScale.z / vector.z) : lossyScale.z);
		if (this.DEGACFCNEBL)
		{
			if (transform.position != this.PLFDEPDOBKC && num > 0.0001f && num2 > 0.0001f)
			{
				Vector3 vector3 = transform.position - base.transform.position;
				this.shadowOffsetX = Mathf.Clamp(vector3.x / (0.5f * num), -50f, 50f);
				this.shadowOffsetY = Mathf.Clamp(vector3.y / (0.5f * num2), -50f, 50f);
				this.EMOCHOMMFPM();
			}
			if (transform.rotation != this.JIBAJABFKEH)
			{
				this._shadowUserRot = Quaternion.Inverse(base.transform.rotation) * transform.rotation;
				this.EMOCHOMMFPM();
			}
			if (transform.localScale != this.HPALMHDEELJ)
			{
				this._shadowUserScale = new Vector3(FlagAnimator.DLFKOKHGICN((vector2.x != 0f) ? (transform.localScale.x / vector2.x) : 1f), FlagAnimator.DLFKOKHGICN((vector2.y != 0f) ? (transform.localScale.y / vector2.y) : 1f), FlagAnimator.DLFKOKHGICN((vector2.z != 0f) ? (transform.localScale.z / vector2.z) : 1f));
				this.EMOCHOMMFPM();
			}
		}
		float num3 = float.IsNaN(this.shadowOffsetX) ? 0.1f : Mathf.Clamp(this.shadowOffsetX, -50f, 50f);
		float num4 = float.IsNaN(this.shadowOffsetY) ? -0.1f : Mathf.Clamp(this.shadowOffsetY, -50f, 50f);
		Vector3 vector4 = new Vector3(FlagAnimator.DLFKOKHGICN(this._shadowUserScale.x), FlagAnimator.DLFKOKHGICN(this._shadowUserScale.y), FlagAnimator.DLFKOKHGICN(this._shadowUserScale.z));
		if (num3 != this.shadowOffsetX || num4 != this.shadowOffsetY || vector4 != this._shadowUserScale)
		{
			this.shadowOffsetX = num3;
			this.shadowOffsetY = num4;
			this._shadowUserScale = vector4;
			this.EMOCHOMMFPM();
		}
		float num5 = this.KDDGMEABNKH(Mathf.Abs(this.shadowOffsetX)) * Mathf.Sign(this.shadowOffsetX);
		float num6 = this.KDDGMEABNKH(Mathf.Abs(this.shadowOffsetY)) * Mathf.Sign(this.shadowOffsetY);
		Vector3 b = new Vector3(num5 * num, num6 * num2, 0.005f);
		Quaternion rhs = (this._shadowUserRot.x == 0f && this._shadowUserRot.y == 0f && this._shadowUserRot.z == 0f && this._shadowUserRot.w == 0f) ? Quaternion.identity : this._shadowUserRot;
		transform.position = base.transform.position + b;
		transform.rotation = base.transform.rotation * rhs;
		transform.localScale = Vector3.Scale(vector2, this._shadowUserScale);
		this.PLFDEPDOBKC = transform.position;
		this.JIBAJABFKEH = transform.rotation;
		this.HPALMHDEELJ = transform.localScale;
		this.ECBJNCHJNED = base.transform.lossyScale;
		this.CLGAMIMGCIL = base.transform.rotation;
		this.DEGACFCNEBL = true;
		this.BCBOLBOLDOL();
		this.GHMGPABCPAO();
		this.EMHEEHIAKAM();
	}

	// Token: 0x06006D54 RID: 27988 RVA: 0x0031F4A2 File Offset: 0x0031D6A2
	public void MAOMLKGBIKF()
	{
		this.HGPHLBLBFGM = false;
	}

	// Token: 0x06006D55 RID: 27989 RVA: 0x0031F4AC File Offset: 0x0031D6AC
	private void OnDestroy()
	{
		if (!base.gameObject.scene.isLoaded)
		{
			return;
		}
		if (this.KNPDGGPAGAJ != null && this._originalMaterial != null && this.KNPDGGPAGAJ.sharedMaterial == this.JFBEGDFHMLC)
		{
			this.KNPDGGPAGAJ.sharedMaterial = this._originalMaterial;
		}
		if (this.NDLLNEAACJO != null && this._originalMesh != null && this.NDLLNEAACJO.sharedMesh == this.NNMAICJHGND)
		{
			this.NDLLNEAACJO.sharedMesh = this._originalMesh;
		}
		this.KAEDGHMBAPC(this.NNMAICJHGND);
		this.KAEDGHMBAPC(this.IJBBDDHMKFP);
		this.IJBBDDHMKFP = null;
		if (this.PNAIJJNHNDO != null && this.PNAIJJNHNDO != this._shadowMatAsset)
		{
			this.KAEDGHMBAPC(this.PNAIJJNHNDO);
		}
		if (this.JFBEGDFHMLC != null && this.JFBEGDFHMLC != this._clothMatAsset)
		{
			this.KAEDGHMBAPC(this.JFBEGDFHMLC);
		}
	}

	// Token: 0x06006D56 RID: 27990 RVA: 0x0031F5D4 File Offset: 0x0031D7D4
	private void EAJMNFCECPP()
	{
		if (this.AGAMHMNDIOC == null)
		{
			return;
		}
		if (this.KNPDGGPAGAJ != null)
		{
			this.AGAMHMNDIOC.sortingLayerID = this.KNPDGGPAGAJ.sortingLayerID;
			this.AGAMHMNDIOC.sortingOrder = this.KNPDGGPAGAJ.sortingOrder + this.shadowSortingOrder;
			return;
		}
		this.AGAMHMNDIOC.sortingOrder = this.shadowSortingOrder;
	}

	// Token: 0x06006D57 RID: 27991 RVA: 0x0031F644 File Offset: 0x0031D844
	private void CCLFEDBOPAH()
	{
		this.NOFNBNHJNGF();
		if (!this.enableShadow || this.blendMode != FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			return;
		}
		if (this.IJBBDDHMKFP != null && this.IJBBDDHMKFP.GetComponent<CanvasRenderer>() != null)
		{
			this.KAEDGHMBAPC(this.IJBBDDHMKFP);
			this.IJBBDDHMKFP = null;
			this.AHMPLHPIJDO = null;
			this.AGAMHMNDIOC = null;
		}
		if (this.IJBBDDHMKFP == null)
		{
			this.AALOONGJPKO();
			return;
		}
		if (!this.IJBBDDHMKFP.activeSelf)
		{
			this.IJBBDDHMKFP.SetActive(true);
		}
	}

	// Token: 0x06006D58 RID: 27992 RVA: 0x0031F6D8 File Offset: 0x0031D8D8
	private void GJOGNHJAAEN()
	{
		FlagAnimator.APBBFDAEEEI();
		if (this.NDLLNEAACJO == null)
		{
			this.NDLLNEAACJO = base.GetComponent<MeshFilter>();
		}
		if (this.KNPDGGPAGAJ == null)
		{
			this.KNPDGGPAGAJ = base.GetComponent<MeshRenderer>();
		}
		if (this._phaseOffset < 670f)
		{
			this._phaseOffset = UnityEngine.Random.Range(243f, 1275f);
		}
		if (this.KNPDGGPAGAJ != null && this.KNPDGGPAGAJ.sharedMaterial != null)
		{
			Material sharedMaterial = this.KNPDGGPAGAJ.sharedMaterial;
			if (this._clothMatAsset != null && sharedMaterial == this._clothMatAsset)
			{
				if (this.JFBEGDFHMLC == null)
				{
					this.JFBEGDFHMLC = this._clothMatAsset;
					this.PMNGFGFJFAF = this.JFBEGDFHMLC.HasProperty(FlagAnimator.LBLKBBKPPDA);
				}
			}
			else if (this.AJGMJPHADCB(sharedMaterial))
			{
				if (this.JFBEGDFHMLC == null)
				{
					this.JFBEGDFHMLC = sharedMaterial;
					this.PMNGFGFJFAF = this.JFBEGDFHMLC.HasProperty(FlagAnimator.LBLKBBKPPDA);
				}
			}
			else
			{
				if (this._originalMaterial == null)
				{
					this._originalMaterial = sharedMaterial;
				}
				this.GBELLOHANKN(sharedMaterial);
			}
		}
		if (this.IJBBDDHMKFP == null && this.enableShadow && this.blendMode == FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			string text = this.BMJEFLGNECK();
			Transform transform = null;
			Transform transform2 = this.NIECFOAINKI();
			if (transform2 != null)
			{
				transform = transform2.Find(text);
			}
			if (transform == null && base.transform.parent != null)
			{
				transform = base.transform.parent.Find(text);
			}
			if (transform == null)
			{
				GameObject gameObject = GameObject.Find(text);
				if (gameObject != null)
				{
					transform = gameObject.transform;
				}
			}
			if (transform != null && this.KHPGBPBGGHH(transform.gameObject))
			{
				transform = null;
			}
			if (transform != null)
			{
				this.IJBBDDHMKFP = transform.gameObject;
				this.AHMPLHPIJDO = this.IJBBDDHMKFP.GetComponent<MeshFilter>();
				this.AGAMHMNDIOC = this.IJBBDDHMKFP.GetComponent<MeshRenderer>();
				if (this.AGAMHMNDIOC != null)
				{
					this.PNAIJJNHNDO = this.AGAMHMNDIOC.sharedMaterial;
				}
			}
		}
		if (this.KNPDGGPAGAJ != null)
		{
			bool flag = this.JFBEGDFHMLC != null;
			bool flag2 = this.KNPDGGPAGAJ.sharedMaterial != null && this.KNPDGGPAGAJ.sharedMaterial.shader != null && this.KNPDGGPAGAJ.sharedMaterial.shader.name == "<i>";
			if (!flag && !flag2 && (this._srcCaptured || this._clothMatAsset != null))
			{
				this.OMDKKMABAEA();
			}
		}
	}

	// Token: 0x06006D59 RID: 27993 RVA: 0x0031F9A8 File Offset: 0x0031DBA8
	private void EBBBHGPMGEI()
	{
		Texture texture = null;
		if (this._originalMaterial != null)
		{
			texture = this._originalMaterial.mainTexture;
		}
		if (texture == null && this.JFBEGDFHMLC != null)
		{
			texture = this.JFBEGDFHMLC.mainTexture;
		}
		if (texture == null && this.KNPDGGPAGAJ != null && this.KNPDGGPAGAJ.sharedMaterial != null)
		{
			texture = this.KNPDGGPAGAJ.sharedMaterial.mainTexture;
		}
		if (texture != null && texture.width > 0 && texture.height > 0)
		{
			this.OKHKJPIJAFK = (float)texture.width / 1f;
			this.AJHMCBGIGAF = (float)texture.height / 1f;
		}
		else if (this.OKHKJPIJAFK <= 0.001f || this.AJHMCBGIGAF <= 0.001f)
		{
			this.OKHKJPIJAFK = 2f;
			this.AJHMCBGIGAF = 1f;
		}
		this.OONCIMHKPMC = Vector3.zero;
	}

	// Token: 0x06006D5A RID: 27994 RVA: 0x0031FAB0 File Offset: 0x0031DCB0
	private void KMEGABEIPBL()
	{
		this.HNHLCLHFDGK();
		this.CCLFEDBOPAH();
		if (!this.DBFKFHHPGOP())
		{
			return;
		}
		if (!this.HGPHLBLBFGM)
		{
			if (this.JFBEGDFHMLC != null)
			{
				this.MLDBGDFIIEL();
			}
			if (this.enableShadow && this.IJBBDDHMKFP != null)
			{
				this.GGCHEDBDAGA();
			}
			return;
		}
		float num = FlagAnimator.EACEMAFJJGP(Time.timeAsDouble);
		this.NDNAHIBKAHI = num;
		this.FGDFPMLKPFG(num);
		if (FlagAnimator.GFEGELPFKDA(num, ref this.OHGGGMBHLDO, 1857f))
		{
			this.PDDOJEBLPBI();
		}
		if (this.JFBEGDFHMLC != null)
		{
			this.LOLDBIEEPBI();
		}
		if (this.enableShadow && this.IJBBDDHMKFP != null && FlagAnimator.GICDHHBLKPK(num, ref this.ANKNIJBNBBM, 1901f))
		{
			this.EKMKOODNNCN();
		}
	}

	// Token: 0x06006D5B RID: 27995 RVA: 0x0031FB80 File Offset: 0x0031DD80
	private float MIDMLBBDJFJ(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 997f;
	}

	// Token: 0x06006D5C RID: 27996 RVA: 0x0031FB8C File Offset: 0x0031DD8C
	private static void PGFEKLFOMFG()
	{
		if (FlagAnimator.NGPOPDFKNFP != null)
		{
			return;
		}
		FlagAnimator.NGPOPDFKNFP = new float[168];
		for (int i = 1; i < 193; i++)
		{
			FlagAnimator.NGPOPDFKNFP[i] = (float)Math.Sin((double)i * 995.0 / 506.0);
		}
	}

	// Token: 0x06006D5D RID: 27997 RVA: 0x0031A123 File Offset: 0x00318323
	public GameObject HADKGJBEKIJ()
	{
		return this.IJBBDDHMKFP;
	}

	// Token: 0x06006D5E RID: 27998 RVA: 0x0031FBE4 File Offset: 0x0031DDE4
	private bool KHPGBPBGGHH(GameObject MHDJCICKAAJ)
	{
		if (MHDJCICKAAJ == null)
		{
			return false;
		}
		foreach (FlagAnimator flagAnimator in Resources.FindObjectsOfTypeAll<FlagAnimator>())
		{
			if (!(flagAnimator == this) && !(flagAnimator == null) && flagAnimator.IJBBDDHMKFP == MHDJCICKAAJ)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006D5F RID: 27999 RVA: 0x0031FC38 File Offset: 0x0031DE38
	private void IODGFKDLHPH()
	{
		if (this.IJBBDDHMKFP == null)
		{
			return;
		}
		this.LAEMAMGOFOF();
		if (this._shadowParentCustom)
		{
			return;
		}
		if (this.IJBBDDHMKFP.transform.parent != base.transform.parent)
		{
			this.IJBBDDHMKFP.transform.SetParent(base.transform.parent, true);
			this.EACHLJCKCCN = this.IJBBDDHMKFP.transform.parent;
			this.DEGACFCNEBL = false;
		}
		int siblingIndex = base.transform.GetSiblingIndex();
		if (this.IJBBDDHMKFP.transform.GetSiblingIndex() >= siblingIndex)
		{
			this.IJBBDDHMKFP.transform.SetSiblingIndex(siblingIndex);
		}
	}

	// Token: 0x06006D60 RID: 28000 RVA: 0x0031FCF0 File Offset: 0x0031DEF0
	private static void FPHCPIMDKGN()
	{
		if (FlagAnimator.NGPOPDFKNFP != null)
		{
			return;
		}
		FlagAnimator.NGPOPDFKNFP = new float[181];
		for (int i = 1; i < -18; i++)
		{
			FlagAnimator.NGPOPDFKNFP[i] = (float)Math.Sin((double)i * 75.0 / 28.0);
		}
	}

	// Token: 0x06006D61 RID: 28001 RVA: 0x0031FD47 File Offset: 0x0031DF47
	private float JAKBACMGNCG(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 1591f;
	}

	// Token: 0x06006D62 RID: 28002 RVA: 0x0031FD50 File Offset: 0x0031DF50
	public void FJIBFEJHHCN()
	{
		this.amplitude = 1881f;
		this.frequency = 701f;
		this.speed = 1353f;
		this.liveliness = 995f;
		this.pinStiffness = 1741f;
		this.windAngle = 647f;
		this.windStrength = 1377f;
		this.windGust = 1575f;
		this.edgeFlutter = 1358f;
		this.enableWrinkles = false;
		this.wrinkleDepth = 1951f;
		this.wrinkleSizeX = 1600f;
		this.wrinkleSizeY = 1616f;
		this.wrinkleDetail = 1375f;
		this.wrinkleJitter = 1312f;
		this.wrinkleSpeed = 810f;
		this.foldShadowOpacity = 1445f;
		this.clothColorShift = 165f;
	}

	// Token: 0x06006D63 RID: 28003 RVA: 0x0031FE1F File Offset: 0x0031E01F
	private void OnDisable()
	{
		if (this.IJBBDDHMKFP != null)
		{
			this.IJBBDDHMKFP.SetActive(false);
		}
	}

	// Token: 0x06006D64 RID: 28004 RVA: 0x0031FE3B File Offset: 0x0031E03B
	private float LMFALPDFMJK(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 5f;
	}

	// Token: 0x06006D65 RID: 28005 RVA: 0x0031FE44 File Offset: 0x0031E044
	private void NOJFKBNKOOG()
	{
		if (this.JFBEGDFHMLC == null)
		{
			return;
		}
		if (!this.LNHHGBMDHIB)
		{
			this.JFBEGDFHMLC.SetVector(FlagAnimator.BPGBDCMGCHE, new Vector4(744f, 1813f, 1141f, 958f));
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.CAJOPGHOGBI, 1776f);
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.DJJGDBIIGJM, 1731f);
			this.LNHHGBMDHIB = false;
		}
		if (this.blendMode != this.JFLDDNKFBIC)
		{
			FlagAnimator.EDIAIDHAFAO ediaidhafao = this.blendMode;
			int num;
			int num2;
			string keyword;
			if (ediaidhafao != FlagAnimator.EDIAIDHAFAO.Additive)
			{
				if (ediaidhafao != (FlagAnimator.EDIAIDHAFAO)4)
				{
					num = 2;
					num2 = -103;
					keyword = "noiseanalogovr_2";
				}
				else
				{
					num = 0;
					num2 = 0;
					keyword = "OnCollectableDialogShown";
				}
			}
			else
			{
				num = 1;
				num2 = 0;
				keyword = "OnCaptersSnapshotsGamePassSubscribePositive";
			}
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.KGEAGCMFMPB, (float)num);
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.PKNBODNLDDE, (float)num2);
			this.JFBEGDFHMLC.DisableKeyword("_2");
			this.JFBEGDFHMLC.DisableKeyword("@");
			this.JFBEGDFHMLC.DisableKeyword("acoll");
			this.JFBEGDFHMLC.EnableKeyword(keyword);
			this.JFLDDNKFBIC = this.blendMode;
		}
		if (this.PMNGFGFJFAF && !Mathf.Approximately(this.GOJEKIEBHMN, this.foldShadowOpacity))
		{
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.LBLKBBKPPDA, this.foldShadowOpacity);
			this.GOJEKIEBHMN = this.foldShadowOpacity;
		}
		if (!Mathf.Approximately(this.BIIIOJPAIMO, this.clothColorShift))
		{
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.BCMBMNEPGIG, this.clothColorShift);
			this.BIIIOJPAIMO = this.clothColorShift;
		}
		if (this.glowColor != this.HDEELEOKLGA)
		{
			this.JFBEGDFHMLC.SetColor(FlagAnimator.EAIGOHDFABB, this.glowColor);
			this.HDEELEOKLGA = this.glowColor;
		}
		bool flag = !(this.layerIdInverter == null) && this.layerIdInverter.activeInHierarchy;
		float num3 = (this.enableGlow && flag && this.blendMode == FlagAnimator.EDIAIDHAFAO.Alpha) ? (this.glowColor.a * this.GADNAPIEBIG(this.NDNAHIBKAHI)) : 296f;
		if (!Mathf.Approximately(this.DPJEKLMOGKA, num3))
		{
			if (this.ICOJJIPKJOD == null)
			{
				this.ICOJJIPKJOD = new MaterialPropertyBlock();
			}
			this.ICOJJIPKJOD.SetFloat(FlagAnimator.EBEJPLFNIKC, num3);
			if (this.KNPDGGPAGAJ != null)
			{
				this.KNPDGGPAGAJ.SetPropertyBlock(this.ICOJJIPKJOD);
			}
			this.DPJEKLMOGKA = num3;
		}
	}

	// Token: 0x06006D66 RID: 28006 RVA: 0x003200C8 File Offset: 0x0031E2C8
	private static float KDMOBAMKHBL(float OBNBCGOIMKE)
	{
		return FlagAnimator.NGPOPDFKNFP[(int)(OBNBCGOIMKE * 1182f + 757f) & -90];
	}

	// Token: 0x06006D67 RID: 28007 RVA: 0x0031B9EC File Offset: 0x00319BEC
	private bool OHKLCFJLFCI()
	{
		return !Mathf.Approximately(this.wrinkleDepth, this.FDPFEIIMAAG);
	}

	// Token: 0x06006D68 RID: 28008 RVA: 0x003200E4 File Offset: 0x0031E2E4
	private float KDDGMEABNKH(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 0.5f;
	}

	// Token: 0x06006D69 RID: 28009 RVA: 0x003200F0 File Offset: 0x0031E2F0
	private void Update()
	{
		this.HNHLCLHFDGK();
		this.HAGEPAABEDH();
		if (!this.KKALPEBDKEP())
		{
			return;
		}
		if (!this.HGPHLBLBFGM)
		{
			if (this.JFBEGDFHMLC != null)
			{
				this.LOLDBIEEPBI();
			}
			if (this.enableShadow && this.IJBBDDHMKFP != null)
			{
				this.EGLHHMABOAE();
			}
			return;
		}
		float num = FlagAnimator.EACEMAFJJGP(Time.timeAsDouble);
		this.NDNAHIBKAHI = num;
		this.FGDFPMLKPFG(num);
		if (FlagAnimator.GICDHHBLKPK(num, ref this.OHGGGMBHLDO, 0.033333335f))
		{
			this.HEENINIEFGG();
		}
		if (this.JFBEGDFHMLC != null)
		{
			this.LOLDBIEEPBI();
		}
		if (this.enableShadow && this.IJBBDDHMKFP != null && FlagAnimator.GICDHHBLKPK(num, ref this.ANKNIJBNBBM, 0.033333335f))
		{
			this.EGLHHMABOAE();
		}
	}

	// Token: 0x06006D6A RID: 28010 RVA: 0x003201C0 File Offset: 0x0031E3C0
	private static float PPLNGEMFGNJ(double PGCADACJBKM)
	{
		double num = PGCADACJBKM % 24.0;
		if (num < 809.0)
		{
			num += 775.0;
		}
		return (float)num;
	}

	// Token: 0x06006D6B RID: 28011 RVA: 0x0031E94C File Offset: 0x0031CB4C
	private bool DBFKFHHPGOP()
	{
		return this.KNPDGGPAGAJ == null || this.KNPDGGPAGAJ.isVisible || (this.AGAMHMNDIOC != null && this.AGAMHMNDIOC.isVisible);
	}

	// Token: 0x06006D6C RID: 28012 RVA: 0x003201F4 File Offset: 0x0031E3F4
	private float BAFNMPJLLJE(float FDEIEKEMPOM, float CGFEMPFACHO)
	{
		float result;
		switch (this.pinSide)
		{
		case FlagAnimator.JMPGKJMGNKH.Left:
			result = FDEIEKEMPOM;
			break;
		case FlagAnimator.JMPGKJMGNKH.Right:
			result = 954f - FDEIEKEMPOM;
			break;
		case FlagAnimator.JMPGKJMGNKH.Top:
			result = 129f - CGFEMPFACHO;
			break;
		case FlagAnimator.JMPGKJMGNKH.Bottom:
			result = CGFEMPFACHO;
			break;
		default:
			result = FDEIEKEMPOM;
			break;
		}
		return result;
	}

	// Token: 0x06006D6D RID: 28013 RVA: 0x0032023F File Offset: 0x0031E43F
	private float ICJJEPHACGK(float CGFEMPFACHO)
	{
		return Mathf.Lerp(0.25f, 6f, CGFEMPFACHO);
	}

	// Token: 0x06006D6E RID: 28014 RVA: 0x00320254 File Offset: 0x0031E454
	public Vector2 BIFDAMOHOHJ()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		return new Vector2(this.OKHKJPIJAFK * Mathf.Abs(lossyScale.x), this.AJHMCBGIGAF * Mathf.Abs(lossyScale.y));
	}

	// Token: 0x06006D6F RID: 28015 RVA: 0x00320296 File Offset: 0x0031E496
	private float EAPPDHGEKJG(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 471f;
	}

	// Token: 0x06006D70 RID: 28016 RVA: 0x003202A0 File Offset: 0x0031E4A0
	private bool KNDIKCGLIIM()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		int num = 0;
		if (lossyScale.x < 174f)
		{
			num += 0;
		}
		if (lossyScale.y < 191f)
		{
			num += 0;
		}
		if (lossyScale.z < 588f)
		{
			num++;
		}
		return num % 2 == 1;
	}

	// Token: 0x06006D71 RID: 28017 RVA: 0x003202F4 File Offset: 0x0031E4F4
	private void COAADLHNEME()
	{
		if (!this.enableShadow || this.blendMode != FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			if (this.IJBBDDHMKFP != null)
			{
				this.DEPAHJNEJIJ(this.IJBBDDHMKFP);
				this.IJBBDDHMKFP = null;
				this.AHMPLHPIJDO = null;
				this.AGAMHMNDIOC = null;
			}
			return;
		}
		if (this.IJBBDDHMKFP == null)
		{
			this.NNDONCDKGBG();
		}
		this.IJBBDDHMKFP.SetActive(false);
		this.HLHIPJEEJKN();
		this.AODDBIELGIF();
		this.EKMKOODNNCN();
	}

	// Token: 0x06006D72 RID: 28018 RVA: 0x00320373 File Offset: 0x0031E573
	private float NLMBHDHAHME(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 8f;
	}

	// Token: 0x06006D73 RID: 28019 RVA: 0x0032037C File Offset: 0x0031E57C
	private static float OOMINMLKFOI(float OBNBCGOIMKE)
	{
		return FlagAnimator.NGPOPDFKNFP[(int)(OBNBCGOIMKE * 651.8986f) & 4095];
	}

	// Token: 0x06006D74 RID: 28020 RVA: 0x0031C3B2 File Offset: 0x0031A5B2
	private Transform NIECFOAINKI()
	{
		if (!this._shadowParentCustom)
		{
			return base.transform.parent;
		}
		return this._shadowUserParent;
	}

	// Token: 0x06006D75 RID: 28021 RVA: 0x00320394 File Offset: 0x0031E594
	private float FNMPOFFBCMN(float GMFENEPDMIF, float PMMCLCMDNGA, float ENEHGJGPDPI = 0.3f)
	{
		float num = PMMCLCMDNGA * ENEHGJGPDPI;
		float num2 = FlagAnimator.NACAANOPDNM(num * FlagAnimator.DMBONEDAPCF + GMFENEPDMIF);
		float num3 = FlagAnimator.KDMOBAMKHBL(num * FlagAnimator.IJHMBMHCNKG + GMFENEPDMIF * 637f);
		float num4 = FlagAnimator.KDMOBAMKHBL(num * FlagAnimator.NIDHLJBBMMJ + GMFENEPDMIF * 1562f);
		return (num2 + num3 + num4) * 992f;
	}

	// Token: 0x06006D76 RID: 28022 RVA: 0x003203E8 File Offset: 0x0031E5E8
	private void GHMGPABCPAO()
	{
		if (this.AGAMHMNDIOC == null)
		{
			return;
		}
		if (this.KNPDGGPAGAJ != null)
		{
			this.AGAMHMNDIOC.sortingLayerID = this.KNPDGGPAGAJ.sortingLayerID;
			this.AGAMHMNDIOC.sortingOrder = this.KNPDGGPAGAJ.sortingOrder + this.shadowSortingOrder;
			return;
		}
		this.AGAMHMNDIOC.sortingOrder = this.shadowSortingOrder;
	}

	// Token: 0x06006D77 RID: 28023 RVA: 0x00320457 File Offset: 0x0031E657
	private static bool GICDHHBLKPK(float IGEMDOIICDJ, ref float ACEEGBMIIKJ, float IIKAHLKFECL)
	{
		if (ACEEGBMIIKJ < 0f || IGEMDOIICDJ < ACEEGBMIIKJ || IGEMDOIICDJ - ACEEGBMIIKJ >= IIKAHLKFECL)
		{
			ACEEGBMIIKJ = IGEMDOIICDJ;
			return true;
		}
		return false;
	}

	// Token: 0x06006D78 RID: 28024 RVA: 0x00320474 File Offset: 0x0031E674
	private static float JNIENKPLBKP(float FDEIEKEMPOM, float CGFEMPFACHO, float PMMCLCMDNGA, float LBLLBJKKOAP)
	{
		float num = FDEIEKEMPOM * 127.1f + CGFEMPFACHO * 311.7f + LBLLBJKKOAP;
		float num2 = (num - Mathf.Floor(num)) * 6.2831855f;
		return FlagAnimator.OOMINMLKFOI(PMMCLCMDNGA * 0.4f + num2);
	}

	// Token: 0x06006D79 RID: 28025 RVA: 0x003204AE File Offset: 0x0031E6AE
	private float GGOPLJHOPCE(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 56f;
	}

	// Token: 0x06006D7A RID: 28026 RVA: 0x003204B7 File Offset: 0x0031E6B7
	private float JBALLCCFAHB(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 2f;
	}

	// Token: 0x06006D7B RID: 28027 RVA: 0x003204C0 File Offset: 0x0031E6C0
	private bool EKLACMKNLAM()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		int num = 0;
		if (lossyScale.x < 1806f)
		{
			num++;
		}
		if (lossyScale.y < 1322f)
		{
			num++;
		}
		if (lossyScale.z < 1611f)
		{
			num += 0;
		}
		return num % 6 == 1;
	}

	// Token: 0x06006D7C RID: 28028 RVA: 0x00320512 File Offset: 0x0031E712
	private void OnEnable()
	{
		this.NDGCJPCEMMP();
		if (this.IJBBDDHMKFP != null)
		{
			this.IJBBDDHMKFP.SetActive(this.enableShadow && this.blendMode == FlagAnimator.EDIAIDHAFAO.Alpha);
		}
	}

	// Token: 0x06006D7D RID: 28029 RVA: 0x00320548 File Offset: 0x0031E748
	private void BCBOLBOLDOL()
	{
		if (this.IJBBDDHMKFP == null)
		{
			return;
		}
		this.NPEGNLMDEIN();
		if (this._shadowParentCustom)
		{
			return;
		}
		if (this.IJBBDDHMKFP.transform.parent != base.transform.parent)
		{
			this.IJBBDDHMKFP.transform.SetParent(base.transform.parent, false);
			this.EACHLJCKCCN = this.IJBBDDHMKFP.transform.parent;
			this.DEGACFCNEBL = false;
		}
		int siblingIndex = base.transform.GetSiblingIndex();
		if (this.IJBBDDHMKFP.transform.GetSiblingIndex() >= siblingIndex)
		{
			this.IJBBDDHMKFP.transform.SetSiblingIndex(siblingIndex);
		}
	}

	// Token: 0x06006D7E RID: 28030 RVA: 0x00320600 File Offset: 0x0031E800
	private void BJIEILFHKEM()
	{
		if (this._boundsCaptured)
		{
			this.OONCIMHKPMC = this._capturedOrigin;
			this.OKHKJPIJAFK = this._capturedWidth;
			this.AJHMCBGIGAF = this._capturedHeight;
			return;
		}
		Mesh mesh = (this.NDLLNEAACJO != null) ? this.NDLLNEAACJO.sharedMesh : null;
		if (mesh != null && (mesh == this.NNMAICJHGND || mesh.name == "continue"))
		{
			mesh = null;
		}
		if (mesh != null)
		{
			Bounds bounds = mesh.bounds;
			this.OONCIMHKPMC = bounds.min;
			this.OKHKJPIJAFK = bounds.size.x;
			this.AJHMCBGIGAF = bounds.size.y;
			if (this.OKHKJPIJAFK <= 1080f || this.AJHMCBGIGAF <= 105f)
			{
				this.EBBBHGPMGEI();
			}
		}
		else
		{
			this.EBBBHGPMGEI();
		}
		if (this.OKHKJPIJAFK > 900f && this.AJHMCBGIGAF > 1202f)
		{
			this._boundsCaptured = true;
			this._capturedOrigin = this.OONCIMHKPMC;
			this._capturedWidth = this.OKHKJPIJAFK;
			this._capturedHeight = this.AJHMCBGIGAF;
		}
	}

	// Token: 0x06006D7F RID: 28031 RVA: 0x0031A123 File Offset: 0x00318323
	public GameObject LKEILKHPBLE()
	{
		return this.IJBBDDHMKFP;
	}

	// Token: 0x06006D80 RID: 28032 RVA: 0x00320730 File Offset: 0x0031E930
	public void EGNMFOABEJF()
	{
		this.HGPHLBLBFGM = false;
		this.IBCJNCIKCGD();
	}

	// Token: 0x06006D81 RID: 28033 RVA: 0x00320740 File Offset: 0x0031E940
	private static float EACEMAFJJGP(double PGCADACJBKM)
	{
		double num = PGCADACJBKM % 1608.4954833984375;
		if (num < 0.0)
		{
			num += 1608.4954833984375;
		}
		return (float)num;
	}

	// Token: 0x06006D82 RID: 28034 RVA: 0x00320773 File Offset: 0x0031E973
	private float EKLIAGPOGJF(float CGFEMPFACHO)
	{
		return Mathf.Lerp(557f, 1088f, CGFEMPFACHO);
	}

	// Token: 0x06006D83 RID: 28035 RVA: 0x00320788 File Offset: 0x0031E988
	private FlagAnimator.NNDGGMGDGHN EBBIFEIKPFP(float PMMCLCMDNGA)
	{
		float num = this.DMAAIIBCLBE(this.amplitude);
		float num2 = this.ICJJEPHACGK(this.frequency);
		float num3 = this.LMFALPDFMJK(this.speed);
		float num4 = this.windStrength;
		float f = this.windAngle * 0.017453292f;
		float num5 = Mathf.Cos(f);
		float num6 = Mathf.Sin(f);
		if (this.IMKHDMDHJFC)
		{
			num5 = -num5;
		}
		if (this.OHCJJCDOMED)
		{
			num6 = -num6;
		}
		Vector2 vector = new Vector2(num5, num6);
		FlagAnimator.NNDGGMGDGHN nndggmgdghn;
		nndggmgdghn.MPOLFBDIPFD = this.LELDKLPAJDP(this.wrinkleJitter);
		if (this.enableNoise)
		{
			if (this.noiseAmplitude > 0f)
			{
				num *= 1f + this.HBGOKOGFEJF(this.AGMMPGDKBLD + this._phaseOffset * 3.1f, PMMCLCMDNGA, 0.3f) * this.noiseAmplitude;
			}
			if (this.noiseFrequency > 0f)
			{
				num2 *= 1f + this.HBGOKOGFEJF(this.FJDCEOOGGHF + this._phaseOffset * 4.7f, PMMCLCMDNGA, 0.3f) * this.noiseFrequency;
			}
		}
		num = Mathf.Max(0f, num);
		num2 = Mathf.Max(0.01f, num2);
		num3 = Mathf.Max(0f, num3);
		num4 = Mathf.Max(0f, num4);
		float num7 = this.HBGOKOGFEJF(200f + this._phaseOffset * 0.3f, PMMCLCMDNGA, 0.15f);
		float num8 = this.HBGOKOGFEJF(210f + this._phaseOffset * 0.7f, PMMCLCMDNGA, 0.5f);
		float num9 = this.HBGOKOGFEJF(220f + this._phaseOffset * 1.1f, PMMCLCMDNGA, 1.2f);
		float num10 = num7 * 0.6f + num8 * 0.3f + num9 * 0.15f;
		float num11 = this.JBALLCCFAHB(this.windGust);
		num10 /= 1f + 0.35f * Mathf.Abs(num10);
		float num12 = 1f + num10 * num11;
		if (num12 < 0.25f)
		{
			num12 = 0.0625f / (0.5f - num12);
		}
		if (num11 > 0.01f)
		{
			float f2 = this.HBGOKOGFEJF(230f + this._phaseOffset, PMMCLCMDNGA, 0.35f) * num11 * 0.08f;
			float num13 = Mathf.Cos(f2);
			float num14 = Mathf.Sin(f2);
			vector = new Vector2(vector.x * num13 - vector.y * num14, vector.x * num14 + vector.y * num13);
		}
		num4 = Mathf.Max(0f, num4 * num12);
		nndggmgdghn.CBANOPDMNEI = (this.OKHKJPIJAFK + this.AJHMCBGIGAF) * 0.5f;
		nndggmgdghn.NIPEELPJBLC = vector * (num4 * nndggmgdghn.CBANOPDMNEI);
		nndggmgdghn.FMNDDAECJFM = num * nndggmgdghn.CBANOPDMNEI;
		nndggmgdghn.CDCJGGCCFCH = num2 * 3.1415927f * 2f;
		nndggmgdghn.KNBCBDCPEFK = num3;
		nndggmgdghn.BKHBNAMNCMD = this.NLMBHDHAHME(this.wrinkleSpeed);
		nndggmgdghn.GCPMDGNKDMI = ((this.edgeFlutter > 0.001f) ? (this.edgeFlutter * nndggmgdghn.CBANOPDMNEI * 0.06f * Mathf.Clamp01(num4 + 0.15f)) : 0f);
		nndggmgdghn.GNHBEKHOJHJ = ((this.liveliness > 0.0001f) ? (this.liveliness * (nndggmgdghn.FMNDDAECJFM * 0.6f + nndggmgdghn.CBANOPDMNEI * 0.045f)) : 0f);
		nndggmgdghn.FHAHPHFCMJB = ((this.depthCurl > 0.001f) ? (this.depthCurl * 1.15f) : 0f);
		nndggmgdghn.KJOIAFAMBPC = nndggmgdghn.CDCJGGCCFCH * 0.55f + 0.9f;
		nndggmgdghn.HMAAJEPOAIC = num3 * 0.85f + 0.4f;
		bool flag = this.waveAxis == FlagAnimator.KNMMCPKHNLA.Horizontal;
		if (flag ? (this.pinSide == FlagAnimator.JMPGKJMGNKH.Left || this.pinSide == FlagAnimator.JMPGKJMGNKH.Right) : (this.pinSide == FlagAnimator.JMPGKJMGNKH.Top || this.pinSide == FlagAnimator.JMPGKJMGNKH.Bottom))
		{
			float num15 = flag ? this.OKHKJPIJAFK : this.AJHMCBGIGAF;
			float num16 = 0.75f * Mathf.Cos(nndggmgdghn.FHAHPHFCMJB) * num15;
			if (flag)
			{
				nndggmgdghn.NIPEELPJBLC.x = Mathf.Clamp(nndggmgdghn.NIPEELPJBLC.x, -num16, num16);
			}
			else
			{
				nndggmgdghn.NIPEELPJBLC.y = Mathf.Clamp(nndggmgdghn.NIPEELPJBLC.y, -num16, num16);
			}
		}
		return nndggmgdghn;
	}

	// Token: 0x06006D84 RID: 28036 RVA: 0x00320BF4 File Offset: 0x0031EDF4
	public Vector2 MHICILAKOMO()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		return new Vector2(this.OKHKJPIJAFK * Mathf.Abs(lossyScale.x), this.AJHMCBGIGAF * Mathf.Abs(lossyScale.y));
	}

	// Token: 0x06006D85 RID: 28037 RVA: 0x00320C38 File Offset: 0x0031EE38
	private void OADILNCNJBC()
	{
		this.LNHHGBMDHIB = false;
		this.GOJEKIEBHMN = 1291f;
		this.BIIIOJPAIMO = 652f;
		this.JFLDDNKFBIC = (FlagAnimator.EDIAIDHAFAO)(-1);
		this.HDEELEOKLGA = new Color(544f, 1494f, 1872f, 1795f);
		this.DPJEKLMOGKA = 1037f;
	}

	// Token: 0x06006D86 RID: 28038 RVA: 0x00320C94 File Offset: 0x0031EE94
	private void DCMMAADPBPM()
	{
		this.MGGPFBOBIIL();
		this.BJIEILFHKEM();
		if (this._phaseOffset < 568f)
		{
			this._phaseOffset = UnityEngine.Random.Range(351f, 1748f);
		}
		this.FOIAODBCJCJ = this.pinSide;
		this.LFGOADFAOAB();
		this.ANDALJGBPHI();
		this.OJBIDELMBIF();
		this.LOMKJOFCOKL();
		this.AALOONGJPKO();
		this.AJBBCAODJJI = this.enableShadow;
		this.MIMDFDKIPBF = this.blendMode;
		if (this.glowAlpha < 1374f && this.glowColor.a > 213f)
		{
			this.glowColor.a = this.glowAlpha;
			this.glowAlpha = 1039f;
		}
		if (this.playOnAwake && Application.isPlaying)
		{
			this.JAKKHJGEOOL();
		}
	}

	// Token: 0x06006D87 RID: 28039 RVA: 0x0031F4A2 File Offset: 0x0031D6A2
	public void Pause()
	{
		this.HGPHLBLBFGM = false;
	}

	// Token: 0x06006D88 RID: 28040 RVA: 0x00320D64 File Offset: 0x0031EF64
	private float HBGOKOGFEJF(float GMFENEPDMIF, float PMMCLCMDNGA, float ENEHGJGPDPI = 0.3f)
	{
		float num = PMMCLCMDNGA * ENEHGJGPDPI;
		float num2 = FlagAnimator.NACAANOPDNM(num * FlagAnimator.DMBONEDAPCF + GMFENEPDMIF);
		float num3 = FlagAnimator.NACAANOPDNM(num * FlagAnimator.IJHMBMHCNKG + GMFENEPDMIF * 1.7f);
		float num4 = FlagAnimator.NACAANOPDNM(num * FlagAnimator.NIDHLJBBMMJ + GMFENEPDMIF * 2.3f);
		return (num2 + num3 + num4) * 0.333f;
	}

	// Token: 0x06006D89 RID: 28041 RVA: 0x00320DB8 File Offset: 0x0031EFB8
	private void HLHIPJEEJKN()
	{
		if (this.IJBBDDHMKFP == null)
		{
			return;
		}
		this.AHLCEMLJLHM();
		if (this._shadowParentCustom)
		{
			return;
		}
		if (this.IJBBDDHMKFP.transform.parent != base.transform.parent)
		{
			this.IJBBDDHMKFP.transform.SetParent(base.transform.parent, true);
			this.EACHLJCKCCN = this.IJBBDDHMKFP.transform.parent;
			this.DEGACFCNEBL = false;
		}
		int siblingIndex = base.transform.GetSiblingIndex();
		if (this.IJBBDDHMKFP.transform.GetSiblingIndex() >= siblingIndex)
		{
			this.IJBBDDHMKFP.transform.SetSiblingIndex(siblingIndex);
		}
	}

	// Token: 0x06006D8A RID: 28042 RVA: 0x00003E52 File Offset: 0x00002052
	private void IAKJGNLFDHJ()
	{
	}

	// Token: 0x06006D8B RID: 28043 RVA: 0x00320E70 File Offset: 0x0031F070
	private float KGAELEHPGBO(float FDEIEKEMPOM, float CGFEMPFACHO)
	{
		float result;
		switch (this.pinSide)
		{
		case FlagAnimator.JMPGKJMGNKH.Left:
			result = FDEIEKEMPOM;
			break;
		case FlagAnimator.JMPGKJMGNKH.Right:
			result = 1979f - FDEIEKEMPOM;
			break;
		case FlagAnimator.JMPGKJMGNKH.Top:
			result = 1507f - CGFEMPFACHO;
			break;
		case FlagAnimator.JMPGKJMGNKH.Bottom:
			result = CGFEMPFACHO;
			break;
		default:
			result = FDEIEKEMPOM;
			break;
		}
		return result;
	}

	// Token: 0x06006D8C RID: 28044 RVA: 0x00320EBB File Offset: 0x0031F0BB
	private bool NCJEACNGEEM()
	{
		return Mathf.Approximately(this.wrinkleDepth, this.FDPFEIIMAAG);
	}

	// Token: 0x06006D8D RID: 28045 RVA: 0x0031C3B2 File Offset: 0x0031A5B2
	private Transform KNDCOBEEEKH()
	{
		if (!this._shadowParentCustom)
		{
			return base.transform.parent;
		}
		return this._shadowUserParent;
	}

	// Token: 0x06006D8E RID: 28046 RVA: 0x00320ED4 File Offset: 0x0031F0D4
	private void IIDPACCPDIP(float PMMCLCMDNGA, in FlagAnimator.NNDGGMGDGHN NNPOMPOJCDD)
	{
		int num = this.KCJIBOLMDMJ + 1;
		int num2 = this.EAECJIKFECN + 1;
		if (this.HEPNAMAFJOB == null || this.HEPNAMAFJOB.Length != num * num2)
		{
			return;
		}
		bool flag = this.waveAxis == FlagAnimator.KNMMCPKHNLA.Horizontal;
		float num3 = 1f / (float)this.KCJIBOLMDMJ;
		float num4 = 1f / (float)this.EAECJIKFECN;
		float num5 = this.pinStiffness;
		float num6 = PMMCLCMDNGA * NNPOMPOJCDD.HMAAJEPOAIC;
		if (flag)
		{
			bool flag2 = this.pinSide != FlagAnimator.JMPGKJMGNKH.Right;
			float num7 = (flag2 ? 1f : -1f) * (this.OKHKJPIJAFK * num3);
			int num8 = flag2 ? 0 : this.KCJIBOLMDMJ;
			int num9 = flag2 ? 1 : -1;
			for (int i = 0; i < num2; i++)
			{
				float num10 = (float)i * num4;
				float num11 = 0f;
				float num12 = 0f;
				int num13 = i * num + num8;
				this.HEPNAMAFJOB[num13] = 0f;
				this.JBJPONAILFI[num13] = 0f;
				for (int j = 1; j <= this.KCJIBOLMDMJ; j++)
				{
					int num14 = num8 + num9 * j;
					float num15 = (float)num14 * num3;
					float t = this.LCCKLOCDJMK(num15, num10);
					float num16 = Mathf.Lerp(1f - num5, 1f, t);
					num16 = num16 * num16 * num16;
					float obnbcgoimke = NNPOMPOJCDD.FHAHPHFCMJB * FlagAnimator.OOMINMLKFOI(num15 * NNPOMPOJCDD.KJOIAFAMBPC - num6 + num10 * 1.3f + this._phaseOffset * 0.7f) * num16;
					num11 += (FlagAnimator.NACAANOPDNM(obnbcgoimke) - 1f) * num7;
					num12 += FlagAnimator.OOMINMLKFOI(obnbcgoimke) * Mathf.Abs(num7);
					num13 = i * num + num14;
					this.HEPNAMAFJOB[num13] = num11;
					this.JBJPONAILFI[num13] = num12;
				}
			}
		}
		else
		{
			bool flag3 = this.pinSide != FlagAnimator.JMPGKJMGNKH.Top;
			float num17 = (flag3 ? 1f : -1f) * (this.AJHMCBGIGAF * num4);
			int num18 = flag3 ? 0 : this.EAECJIKFECN;
			int num19 = flag3 ? 1 : -1;
			for (int k = 0; k < num; k++)
			{
				float num20 = (float)k * num3;
				float num21 = 0f;
				float num22 = 0f;
				int num23 = num18 * num + k;
				this.HEPNAMAFJOB[num23] = 0f;
				this.JBJPONAILFI[num23] = 0f;
				for (int l = 1; l <= this.EAECJIKFECN; l++)
				{
					int num24 = num18 + num19 * l;
					float num25 = (float)num24 * num4;
					float t2 = this.LCCKLOCDJMK(num20, num25);
					float num26 = Mathf.Lerp(1f - num5, 1f, t2);
					num26 = num26 * num26 * num26;
					float obnbcgoimke2 = NNPOMPOJCDD.FHAHPHFCMJB * FlagAnimator.OOMINMLKFOI(num25 * NNPOMPOJCDD.KJOIAFAMBPC - num6 + num20 * 1.3f + this._phaseOffset * 0.7f) * num26;
					num21 += (FlagAnimator.NACAANOPDNM(obnbcgoimke2) - 1f) * num17;
					num22 += FlagAnimator.OOMINMLKFOI(obnbcgoimke2) * Mathf.Abs(num17);
					num23 = num24 * num + k;
					this.HEPNAMAFJOB[num23] = num21;
					this.JBJPONAILFI[num23] = num22;
				}
			}
		}
		if (false && this.MLGKJELDNFE != null && this.MLGKJELDNFE.Length == num * num2)
		{
			float num27 = flag ? this.OKHKJPIJAFK : this.AJHMCBGIGAF;
			float num28 = 1f / Mathf.Max(0.12f * num27, 0.0001f);
			float num29 = 1f / Mathf.Max(0.4f * num27, 0.0001f);
			if (flag)
			{
				bool flag4 = this.pinSide != FlagAnimator.JMPGKJMGNKH.Right;
				int num30 = flag4 ? this.KCJIBOLMDMJ : 0;
				int num31 = flag4 ? -1 : 1;
				float num32 = this.OKHKJPIJAFK * num3;
				for (int m = 0; m < num2; m++)
				{
					float num33 = float.NegativeInfinity;
					float num34 = 0f;
					for (int n = 0; n <= this.KCJIBOLMDMJ; n++)
					{
						int num35 = m * num + (num30 + num31 * n);
						float num36 = this.JBJPONAILFI[num35];
						if (num36 >= num33)
						{
							num33 = num36;
							num34 = 0f;
						}
						else
						{
							num34 += num32;
						}
						float value = (num33 - num36) * num28 - 0.1f;
						float value2 = 1f - num34 * num29;
						this.MLGKJELDNFE[num35] = Mathf.Clamp01(value) * Mathf.Clamp01(value2) * 0.85f;
					}
				}
				return;
			}
			bool flag5 = this.pinSide != FlagAnimator.JMPGKJMGNKH.Top;
			int num37 = flag5 ? this.EAECJIKFECN : 0;
			int num38 = flag5 ? -1 : 1;
			float num39 = this.AJHMCBGIGAF * num4;
			for (int num40 = 0; num40 < num; num40++)
			{
				float num41 = float.NegativeInfinity;
				float num42 = 0f;
				for (int num43 = 0; num43 <= this.EAECJIKFECN; num43++)
				{
					int num44 = (num37 + num38 * num43) * num + num40;
					float num45 = this.JBJPONAILFI[num44];
					if (num45 >= num41)
					{
						num41 = num45;
						num42 = 0f;
					}
					else
					{
						num42 += num39;
					}
					float value3 = (num41 - num45) * num28 - 0.1f;
					float value4 = 1f - num42 * num29;
					this.MLGKJELDNFE[num44] = Mathf.Clamp01(value3) * Mathf.Clamp01(value4) * 0.85f;
				}
			}
		}
	}

	// Token: 0x06006D8F RID: 28047 RVA: 0x00321421 File Offset: 0x0031F621
	private float HGLKFPPBIGJ(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 498f;
	}

	// Token: 0x06006D90 RID: 28048 RVA: 0x0032142C File Offset: 0x0031F62C
	private float[] LGGEOIGJLFC(int PKLGMIOBBGA, int HNLFJHINBIG)
	{
		float[] array = new float[PKLGMIOBBGA * HNLFJHINBIG];
		float num = Mathf.Lerp(12f, 2f, this.wrinkleSizeX);
		float num2 = Mathf.Lerp(12f, 2f, this.wrinkleSizeY);
		float num3 = (this.wrinkleSizeX > 0.001f) ? 1f : 0f;
		float num4 = (this.wrinkleSizeY > 0.001f) ? 1f : 0f;
		float num5 = this.wrinkleDetail;
		float num6 = 1f / (float)Mathf.Max(1, PKLGMIOBBGA - 1);
		float num7 = 1f / (float)Mathf.Max(1, HNLFJHINBIG - 1);
		for (int i = 0; i < HNLFJHINBIG; i++)
		{
			for (int j = 0; j < PKLGMIOBBGA; j++)
			{
				float num8 = (float)j * num6;
				float num9 = (float)i * num7;
				float num10 = (Mathf.Cos(num9 * 3.7f + num8 * 2.1f + 0.5f) + Mathf.Cos(num9 * 2.3f + 1.8f) * 0.6f) * 0.025f;
				float num11 = (Mathf.Cos(num8 * 3.1f + num9 * 1.7f + 2.1f) + Mathf.Cos(num8 * 2.5f + 0.9f) * 0.6f) * 0.025f;
				float num12 = num8 + num10;
				float num13 = num9 + num11;
				float num14 = Mathf.Cos(num12 * num * 3.1415927f * 2f + 0.37f);
				float num15 = Mathf.Cos(num12 * num * 1.7f * 3.1415927f * 2f + 1.94f) * num5;
				float num16 = Mathf.Cos(num12 * num * 2.9f * 3.1415927f * 2f + 3.11f) * num5 * 0.5f;
				float num17 = (num14 + num15 + num16) / (1f + num5 + num5 * 0.5f) * num3;
				float num18 = Mathf.Cos(num13 * num2 * 3.1415927f * 2f + 0.71f);
				float num19 = Mathf.Cos(num13 * num2 * 1.7f * 3.1415927f * 2f + 2.45f) * num5;
				float num20 = (num18 + num19) / (1f + num5) * num4;
				float num21 = num3 + num4;
				array[i * PKLGMIOBBGA + j] = ((num21 > 0.001f) ? ((num17 + num20) / num21) : 0f);
			}
		}
		return array;
	}

	// Token: 0x06006D91 RID: 28049 RVA: 0x0032169C File Offset: 0x0031F89C
	private void PCNPKDHBMII()
	{
		if (this.NDLLNEAACJO == null)
		{
			this.NEANKJIOLAJ();
		}
		if (this.NNMAICJHGND == null)
		{
			this.ANDALJGBPHI();
			this.OJBIDELMBIF();
		}
		if (this.JFBEGDFHMLC == null)
		{
			this.OMDKKMABAEA();
		}
		if (Mathf.Clamp(this.columns, 4, -116) != this.KCJIBOLMDMJ || Mathf.Clamp(this.rows, 7, 79) != this.EAECJIKFECN)
		{
			this.ANDALJGBPHI();
			this.DODJHHOLLIP();
		}
		Vector3 lossyScale = base.transform.lossyScale;
		if (lossyScale.x < 1628f != this.IMKHDMDHJFC || lossyScale.y < 106f != this.OHCJJCDOMED)
		{
			this.ANDALJGBPHI();
			this.DODJHHOLLIP();
		}
		if (this.MNDOIONIFPL())
		{
			this.ANDALJGBPHI();
			this.DODJHHOLLIP();
		}
		else if (this.OHKLCFJLFCI())
		{
			this.APIEGNOHMJP();
			this.FDPFEIIMAAG = this.wrinkleDepth;
		}
		if (this.pinSide != this.FOIAODBCJCJ)
		{
			if (this.LLKOGKKCCIC != null)
			{
				this.APIEGNOHMJP();
			}
			this.FOIAODBCJCJ = this.pinSide;
		}
		if (this.enableShadow != this.AJBBCAODJJI)
		{
			this.DNOEMKBJFEF();
			this.AJBBCAODJJI = this.enableShadow;
		}
		if (this.blendMode != this.MIMDFDKIPBF)
		{
			this.COAADLHNEME();
			if (this.JFBEGDFHMLC != null)
			{
				this.NOJFKBNKOOG();
			}
			this.ADPPKOCPNLD();
			this.MIMDFDKIPBF = this.blendMode;
		}
	}

	// Token: 0x06006D92 RID: 28050 RVA: 0x00321818 File Offset: 0x0031FA18
	private void NPEGNLMDEIN()
	{
		if (this.IJBBDDHMKFP == null)
		{
			return;
		}
		Transform parent = this.IJBBDDHMKFP.transform.parent;
		if (parent == this.KNDCOBEEEKH())
		{
			this.EACHLJCKCCN = parent;
			return;
		}
		if (parent == this.EACHLJCKCCN)
		{
			return;
		}
		this._shadowParentCustom = true;
		this._shadowUserParent = parent;
		this.EACHLJCKCCN = parent;
		this.DEGACFCNEBL = false;
	}

	// Token: 0x06006D93 RID: 28051 RVA: 0x00321888 File Offset: 0x0031FA88
	private bool KOCKIFPJCEO(Material COJDKGEMDKC)
	{
		return COJDKGEMDKC == null || (!(COJDKGEMDKC == this._clothMatAsset) && !(COJDKGEMDKC == this._shadowMatAsset) && !(COJDKGEMDKC == this.JFBEGDFHMLC) && !(COJDKGEMDKC == this.PNAIJJNHNDO) && !(COJDKGEMDKC.shader == null) && !(COJDKGEMDKC.shader.name == "") && COJDKGEMDKC.shader.name == "abpd3");
	}

	// Token: 0x06006D94 RID: 28052 RVA: 0x00321918 File Offset: 0x0031FB18
	private static bool GFEGELPFKDA(float IGEMDOIICDJ, ref float ACEEGBMIIKJ, float IIKAHLKFECL)
	{
		if (ACEEGBMIIKJ < 1739f || IGEMDOIICDJ < ACEEGBMIIKJ || IGEMDOIICDJ - ACEEGBMIIKJ >= IIKAHLKFECL)
		{
			ACEEGBMIIKJ = IGEMDOIICDJ;
			return true;
		}
		return false;
	}

	// Token: 0x06006D95 RID: 28053 RVA: 0x00321938 File Offset: 0x0031FB38
	private void BACIDBMPEJF()
	{
		this.LNHHGBMDHIB = true;
		this.GOJEKIEBHMN = 1119f;
		this.BIIIOJPAIMO = 430f;
		this.JFLDDNKFBIC = (FlagAnimator.EDIAIDHAFAO)(-1);
		this.HDEELEOKLGA = new Color(212f, 1910f, 1395f, 196f);
		this.DPJEKLMOGKA = 792f;
	}

	// Token: 0x06006D96 RID: 28054 RVA: 0x00321994 File Offset: 0x0031FB94
	private void AALOONGJPKO()
	{
		if (!this.enableShadow || this.blendMode != FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			if (this.IJBBDDHMKFP != null)
			{
				this.KAEDGHMBAPC(this.IJBBDDHMKFP);
				this.IJBBDDHMKFP = null;
				this.AHMPLHPIJDO = null;
				this.AGAMHMNDIOC = null;
			}
			return;
		}
		if (this.IJBBDDHMKFP == null)
		{
			this.NNDONCDKGBG();
		}
		this.IJBBDDHMKFP.SetActive(true);
		this.BCBOLBOLDOL();
		this.EMHEEHIAKAM();
		this.EGLHHMABOAE();
	}

	// Token: 0x06006D97 RID: 28055 RVA: 0x00321A13 File Offset: 0x0031FC13
	private float OMLHLEOKFNI(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 0.15f;
	}

	// Token: 0x06006D98 RID: 28056 RVA: 0x00321A1C File Offset: 0x0031FC1C
	private void NOFNBNHJNGF()
	{
		if (Application.isPlaying || this.IJBBDDHMKFP == null)
		{
			return;
		}
		string text = this.LIDMAJPBFEN();
		if (this.IJBBDDHMKFP.name == text)
		{
			return;
		}
		if (this.KHPGBPBGGHH(this.IJBBDDHMKFP))
		{
			this.IJBBDDHMKFP = null;
			this.AHMPLHPIJDO = null;
			this.AGAMHMNDIOC = null;
			this.PNAIJJNHNDO = null;
			this.DEGACFCNEBL = true;
			return;
		}
		this.IJBBDDHMKFP.name = text;
	}

	// Token: 0x06006D99 RID: 28057 RVA: 0x00321A98 File Offset: 0x0031FC98
	private void IBCJNCIKCGD()
	{
		if (this.NNMAICJHGND == null || this.DNCLNNHNAIA == null || this.EPJBDAOHHGC == null)
		{
			return;
		}
		if (this.EPJBDAOHHGC.Length != this.DNCLNNHNAIA.Length)
		{
			return;
		}
		Array.Copy(this.DNCLNNHNAIA, this.EPJBDAOHHGC, this.DNCLNNHNAIA.Length);
		this.NNMAICJHGND.SetVertices(this.EPJBDAOHHGC, 0, this.EPJBDAOHHGC.Length, (MeshUpdateFlags)(-40));
	}

	// Token: 0x06006D9A RID: 28058 RVA: 0x00321B0C File Offset: 0x0031FD0C
	private void PLJKKOKHIOI()
	{
		this.EEPKHGJFLCM();
		if (!this.enableShadow || this.blendMode != FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			return;
		}
		if (this.IJBBDDHMKFP != null && this.IJBBDDHMKFP.GetComponent<CanvasRenderer>() != null)
		{
			this.KAEDGHMBAPC(this.IJBBDDHMKFP);
			this.IJBBDDHMKFP = null;
			this.AHMPLHPIJDO = null;
			this.AGAMHMNDIOC = null;
		}
		if (this.IJBBDDHMKFP == null)
		{
			this.MMLGLMIHIHA();
			return;
		}
		if (!this.IJBBDDHMKFP.activeSelf)
		{
			this.IJBBDDHMKFP.SetActive(false);
		}
	}

	// Token: 0x06006D9B RID: 28059 RVA: 0x00321BA0 File Offset: 0x0031FDA0
	private static float IBCCIGJFNDL(float CGFEMPFACHO)
	{
		float num = (CGFEMPFACHO < 0f) ? (-CGFEMPFACHO) : CGFEMPFACHO;
		if (num > 0.7f)
		{
			float num2 = num - 0.7f;
			num = 0.7f + 0.3f * num2 / (0.3f + num2);
		}
		if (CGFEMPFACHO >= 0f)
		{
			return num;
		}
		return -num;
	}

	// Token: 0x06006D9C RID: 28060 RVA: 0x00321BED File Offset: 0x0031FDED
	private float DMAAIIBCLBE(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 0.3f;
	}

	// Token: 0x06006D9D RID: 28061 RVA: 0x00321BED File Offset: 0x0031FDED
	private float LELDKLPAJDP(float CGFEMPFACHO)
	{
		return CGFEMPFACHO * 0.3f;
	}

	// Token: 0x06006D9E RID: 28062 RVA: 0x0031C3B2 File Offset: 0x0031A5B2
	private Transform PJLLBDELODJ()
	{
		if (!this._shadowParentCustom)
		{
			return base.transform.parent;
		}
		return this._shadowUserParent;
	}

	// Token: 0x06006D9F RID: 28063 RVA: 0x00321BF6 File Offset: 0x0031FDF6
	private static float EDLGCHHNBKN(float OBNBCGOIMKE)
	{
		return FlagAnimator.NGPOPDFKNFP[(int)(OBNBCGOIMKE * 1224f) & 165];
	}

	// Token: 0x06006DA0 RID: 28064 RVA: 0x00321C0C File Offset: 0x0031FE0C
	private void NEANKJIOLAJ()
	{
		FlagAnimator.PGFEKLFOMFG();
		if (this.NDLLNEAACJO == null)
		{
			this.NDLLNEAACJO = base.GetComponent<MeshFilter>();
		}
		if (this.KNPDGGPAGAJ == null)
		{
			this.KNPDGGPAGAJ = base.GetComponent<MeshRenderer>();
		}
		if (this._phaseOffset < 864f)
		{
			this._phaseOffset = UnityEngine.Random.Range(790f, 337f);
		}
		if (this.KNPDGGPAGAJ != null && this.KNPDGGPAGAJ.sharedMaterial != null)
		{
			Material sharedMaterial = this.KNPDGGPAGAJ.sharedMaterial;
			if (this._clothMatAsset != null && sharedMaterial == this._clothMatAsset)
			{
				if (this.JFBEGDFHMLC == null)
				{
					this.JFBEGDFHMLC = this._clothMatAsset;
					this.PMNGFGFJFAF = this.JFBEGDFHMLC.HasProperty(FlagAnimator.LBLKBBKPPDA);
				}
			}
			else if (this.IKELDDMHOMG(sharedMaterial))
			{
				if (this.JFBEGDFHMLC == null)
				{
					this.JFBEGDFHMLC = sharedMaterial;
					this.PMNGFGFJFAF = this.JFBEGDFHMLC.HasProperty(FlagAnimator.LBLKBBKPPDA);
				}
			}
			else
			{
				if (this._originalMaterial == null)
				{
					this._originalMaterial = sharedMaterial;
				}
				this.ODCBMCEEEDD(sharedMaterial);
			}
		}
		if (this.IJBBDDHMKFP == null && this.enableShadow && this.blendMode == FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			string text = this.BMJEFLGNECK();
			Transform transform = null;
			Transform transform2 = this.PJLLBDELODJ();
			if (transform2 != null)
			{
				transform = transform2.Find(text);
			}
			if (transform == null && base.transform.parent != null)
			{
				transform = base.transform.parent.Find(text);
			}
			if (transform == null)
			{
				GameObject gameObject = GameObject.Find(text);
				if (gameObject != null)
				{
					transform = gameObject.transform;
				}
			}
			if (transform != null && this.KHPGBPBGGHH(transform.gameObject))
			{
				transform = null;
			}
			if (transform != null)
			{
				this.IJBBDDHMKFP = transform.gameObject;
				this.AHMPLHPIJDO = this.IJBBDDHMKFP.GetComponent<MeshFilter>();
				this.AGAMHMNDIOC = this.IJBBDDHMKFP.GetComponent<MeshRenderer>();
				if (this.AGAMHMNDIOC != null)
				{
					this.PNAIJJNHNDO = this.AGAMHMNDIOC.sharedMaterial;
				}
			}
		}
		if (this.KNPDGGPAGAJ != null)
		{
			bool flag = this.JFBEGDFHMLC != null;
			bool flag2 = this.KNPDGGPAGAJ.sharedMaterial != null && this.KNPDGGPAGAJ.sharedMaterial.shader != null && this.KNPDGGPAGAJ.sharedMaterial.shader.name == "OnBackendAddFriendByUIDSuccess";
			if (!flag && !flag2 && (this._srcCaptured || this._clothMatAsset != null))
			{
				this.OMDKKMABAEA();
			}
		}
	}

	// Token: 0x06006DA1 RID: 28065 RVA: 0x00321EDC File Offset: 0x003200DC
	private void PDDOJEBLPBI()
	{
		if (this.DJHHABDANKC == null || this.EPJBDAOHHGC == null || this.NNMAICJHGND == null)
		{
			return;
		}
		if (this.blendMode != FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			return;
		}
		int num = this.KCJIBOLMDMJ + 0;
		int num2 = this.EAECJIKFECN + 0;
		if (this.DJHHABDANKC.Length != num * num2)
		{
			return;
		}
		float num3 = (float)this.KCJIBOLMDMJ / Mathf.Max(this.OKHKJPIJAFK, 1027f);
		float num4 = (float)this.EAECJIKFECN / Mathf.Max(this.AJHMCBGIGAF, 1878f);
		float num5 = this.OKHKJPIJAFK / Mathf.Max(this.AJHMCBGIGAF, 1203f);
		float num6 = 469f * num5;
		float num7 = 1410f;
		float num8 = 1540f * num5;
		float num9 = 986f;
		float num10 = this.IMKHDMDHJFC ? 1130f : 1212f;
		float num11 = this.OHCJJCDOMED ? 1537f : 1642f;
		bool flag = this.waveAxis == FlagAnimator.KNMMCPKHNLA.Horizontal;
		bool flag2 = this.depthCurl > 1220f || this.liveliness > 1151f;
		bool flag3 = true;
		Vector3[] epjbdaohhgc = this.EPJBDAOHHGC;
		Color32[] djhhabdankc = this.DJHHABDANKC;
		for (int i = 0; i < num2; i++)
		{
			int num12 = (i > 0) ? (i - 1) : 0;
			int num13 = (i < num2 - 0) ? (i + 0) : i;
			int num14 = i * num;
			int num15 = num12 * num;
			int num16 = num13 * num;
			for (int j = 1; j < num; j += 0)
			{
				int num17 = (j > 1) ? (j - 1) : 0;
				int num18 = (j < num - 1) ? (j + 1) : j;
				Vector3 vector = epjbdaohhgc[num14 + num17];
				Vector3 vector2 = epjbdaohhgc[num14 + num18];
				Vector3 vector3 = epjbdaohhgc[num15 + j];
				Vector3 vector4 = epjbdaohhgc[num16 + j];
				float num19 = flag ? vector.y : vector.x;
				float num20 = flag ? vector2.y : vector2.x;
				float num21 = flag ? vector3.y : vector3.x;
				float num22 = flag ? vector4.y : vector4.x;
				float num23 = num20 - num19;
				float num24 = num22 - num21;
				if (flag2)
				{
					if (flag)
					{
						num23 += (vector2.z - vector.z) * 1615f;
					}
					else
					{
						num24 += (vector4.z - vector3.z) * 317f;
					}
				}
				float num25 = num23 * num3 / (float)(num18 - num17);
				float num26 = num24 * num4 / (float)(num13 - num12);
				float num27 = FlagAnimator.IBCCIGJFNDL(num25 * num6) * num10;
				float num28 = FlagAnimator.IBCCIGJFNDL(num26 * num7) * num11;
				float f = (vector2.z - vector.z) * num3 / (float)(num18 - num17);
				float f2 = (vector4.z - vector3.z) * num4 / (float)(num13 - num12);
				float num29 = Mathf.Abs(f) * num8 + Mathf.Abs(f2) * num9;
				if (flag3)
				{
					num29 += this.MLGKJELDNFE[num14 + j];
				}
				float num30 = Mathf.Clamp01(FlagAnimator.IBCCIGJFNDL(num29));
				djhhabdankc[num14 + j] = new Color32((byte)((num27 * 1035f + 1230f) * 768f + 396f), (byte)((num28 * 1822f + 1345f) * 923f + 804f), (byte)(num30 * 760f + 244f), 189);
			}
		}
		this.NNMAICJHGND.SetColors(djhhabdankc, 0, djhhabdankc.Length, (MeshUpdateFlags)69);
	}

	// Token: 0x06006DA2 RID: 28066 RVA: 0x00322268 File Offset: 0x00320468
	public Vector2 NIEGJGCBAPM()
	{
		Vector3 lossyScale = base.transform.lossyScale;
		return new Vector2(this.OKHKJPIJAFK * Mathf.Abs(lossyScale.x), this.AJHMCBGIGAF * Mathf.Abs(lossyScale.y));
	}

	// Token: 0x06006DA3 RID: 28067 RVA: 0x0031F4A2 File Offset: 0x0031D6A2
	public void AGNLGHICJEL()
	{
		this.HGPHLBLBFGM = false;
	}

	// Token: 0x06006DA4 RID: 28068 RVA: 0x0031A123 File Offset: 0x00318323
	public GameObject FMMIALACKNF()
	{
		return this.IJBBDDHMKFP;
	}

	// Token: 0x06006DA5 RID: 28069 RVA: 0x003222AC File Offset: 0x003204AC
	private void EKMKOODNNCN()
	{
		if (this.IJBBDDHMKFP == null || this.AHMPLHPIJDO == null)
		{
			return;
		}
		if (this.AGAMHMNDIOC != null)
		{
			bool flag = !(this.shadowLayerIdInverter == null) && this.shadowLayerIdInverter.activeInHierarchy;
			if (this.AGAMHMNDIOC.enabled != flag)
			{
				this.AGAMHMNDIOC.enabled = flag;
			}
			if (!flag)
			{
				return;
			}
		}
		if (this.AHMPLHPIJDO.sharedMesh != this.NNMAICJHGND)
		{
			this.AHMPLHPIJDO.sharedMesh = this.NNMAICJHGND;
		}
		if (this.PNAIJJNHNDO != null && this.AGAMHMNDIOC != null && this.AGAMHMNDIOC.sharedMaterial != this.PNAIJJNHNDO)
		{
			this.AGAMHMNDIOC.sharedMaterial = this.PNAIJJNHNDO;
		}
		this.HLBJOPOGLCP();
		if (this.DEGACFCNEBL && (base.transform.lossyScale != this.ECBJNCHJNED || base.transform.rotation != this.CLGAMIMGCIL))
		{
			this.DEGACFCNEBL = true;
		}
		Transform transform = this.IJBBDDHMKFP.transform;
		Vector3 lossyScale = base.transform.lossyScale;
		float num = this.OKHKJPIJAFK * Mathf.Abs(lossyScale.x);
		float num2 = this.AJHMCBGIGAF * Mathf.Abs(lossyScale.y);
		Transform parent = transform.parent;
		Vector3 vector = (parent != null) ? parent.lossyScale : Vector3.one;
		Vector3 vector2 = new Vector3((vector.x != 1957f) ? (lossyScale.x / vector.x) : lossyScale.x, (vector.y != 1667f) ? (lossyScale.y / vector.y) : lossyScale.y, (vector.z != 140f) ? (lossyScale.z / vector.z) : lossyScale.z);
		if (this.DEGACFCNEBL)
		{
			if (transform.position != this.PLFDEPDOBKC && num > 1334f && num2 > 1509f)
			{
				Vector3 vector3 = transform.position - base.transform.position;
				this.shadowOffsetX = Mathf.Clamp(vector3.x / (1447f * num), 788f, 1207f);
				this.shadowOffsetY = Mathf.Clamp(vector3.y / (1051f * num2), 1310f, 327f);
				this.EMOCHOMMFPM();
			}
			if (transform.rotation != this.JIBAJABFKEH)
			{
				this._shadowUserRot = Quaternion.Inverse(base.transform.rotation) * transform.rotation;
				this.IAKJGNLFDHJ();
			}
			if (transform.localScale != this.HPALMHDEELJ)
			{
				this._shadowUserScale = new Vector3(FlagAnimator.GDLAFBPEABD((vector2.x != 1159f) ? (transform.localScale.x / vector2.x) : 301f), FlagAnimator.LIPLGLLHKAE((vector2.y != 1886f) ? (transform.localScale.y / vector2.y) : 1239f), FlagAnimator.AGNPOBCDDNN((vector2.z != 1858f) ? (transform.localScale.z / vector2.z) : 1238f));
				this.EMOCHOMMFPM();
			}
		}
		float num3 = float.IsNaN(this.shadowOffsetX) ? 1001f : Mathf.Clamp(this.shadowOffsetX, 843f, 1860f);
		float num4 = float.IsNaN(this.shadowOffsetY) ? 1892f : Mathf.Clamp(this.shadowOffsetY, 1677f, 1424f);
		Vector3 vector4 = new Vector3(FlagAnimator.NEGKJOINMEP(this._shadowUserScale.x), FlagAnimator.LIPLGLLHKAE(this._shadowUserScale.y), FlagAnimator.LIPLGLLHKAE(this._shadowUserScale.z));
		if (num3 != this.shadowOffsetX || num4 != this.shadowOffsetY || vector4 != this._shadowUserScale)
		{
			this.shadowOffsetX = num3;
			this.shadowOffsetY = num4;
			this._shadowUserScale = vector4;
			this.EMOCHOMMFPM();
		}
		float num5 = this.KDDGMEABNKH(Mathf.Abs(this.shadowOffsetX)) * Mathf.Sign(this.shadowOffsetX);
		float num6 = this.KDDGMEABNKH(Mathf.Abs(this.shadowOffsetY)) * Mathf.Sign(this.shadowOffsetY);
		Vector3 b = new Vector3(num5 * num, num6 * num2, 29f);
		Quaternion rhs = (this._shadowUserRot.x == 1591f && this._shadowUserRot.y == 542f && this._shadowUserRot.z == 1156f && this._shadowUserRot.w == 852f) ? Quaternion.identity : this._shadowUserRot;
		transform.position = base.transform.position + b;
		transform.rotation = base.transform.rotation * rhs;
		transform.localScale = Vector3.Scale(vector2, this._shadowUserScale);
		this.PLFDEPDOBKC = transform.position;
		this.JIBAJABFKEH = transform.rotation;
		this.HPALMHDEELJ = transform.localScale;
		this.ECBJNCHJNED = base.transform.lossyScale;
		this.CLGAMIMGCIL = base.transform.rotation;
		this.DEGACFCNEBL = false;
		this.BCBOLBOLDOL();
		this.EAJMNFCECPP();
		this.EMHEEHIAKAM();
	}

	// Token: 0x06006DA6 RID: 28070 RVA: 0x00322840 File Offset: 0x00320A40
	private void DNOEMKBJFEF()
	{
		if (!this.enableShadow || this.blendMode != FlagAnimator.EDIAIDHAFAO.Alpha)
		{
			if (this.IJBBDDHMKFP != null)
			{
				this.DDEOMPJNHJJ(this.IJBBDDHMKFP);
				this.IJBBDDHMKFP = null;
				this.AHMPLHPIJDO = null;
				this.AGAMHMNDIOC = null;
			}
			return;
		}
		if (this.IJBBDDHMKFP == null)
		{
			this.NNDONCDKGBG();
		}
		this.IJBBDDHMKFP.SetActive(false);
		this.BCBOLBOLDOL();
		this.AODDBIELGIF();
		this.EGLHHMABOAE();
	}

	// Token: 0x06006DA7 RID: 28071 RVA: 0x003228C0 File Offset: 0x00320AC0
	private static float JPGMIFCKHIF(double PGCADACJBKM)
	{
		double num = PGCADACJBKM % 269.0;
		if (num < 317.0)
		{
			num += 949.0;
		}
		return (float)num;
	}

	// Token: 0x06006DA8 RID: 28072 RVA: 0x003228F3 File Offset: 0x00320AF3
	private string BMJEFLGNECK()
	{
		return base.gameObject.name + "shadowflag";
	}

	// Token: 0x06006DA9 RID: 28073 RVA: 0x0031B9EC File Offset: 0x00319BEC
	private bool GFHJMJBFEDK()
	{
		return !Mathf.Approximately(this.wrinkleDepth, this.FDPFEIIMAAG);
	}

	// Token: 0x06006DAA RID: 28074 RVA: 0x0032290C File Offset: 0x00320B0C
	private void BPICCLFJLGA()
	{
		if (this.JFBEGDFHMLC == null)
		{
			return;
		}
		if (!this.LNHHGBMDHIB)
		{
			this.JFBEGDFHMLC.SetVector(FlagAnimator.BPGBDCMGCHE, new Vector4(878f, 181f, 695f, 1395f));
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.CAJOPGHOGBI, 547f);
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.DJJGDBIIGJM, 309f);
			this.LNHHGBMDHIB = true;
		}
		if (this.blendMode != this.JFLDDNKFBIC)
		{
			FlagAnimator.EDIAIDHAFAO ediaidhafao = this.blendMode;
			int num;
			int num2;
			string keyword;
			if (ediaidhafao != FlagAnimator.EDIAIDHAFAO.Alpha)
			{
				if (ediaidhafao != FlagAnimator.EDIAIDHAFAO.Multiply)
				{
					num = 5;
					num2 = -114;
					keyword = "energyhinttitle";
				}
				else
				{
					num = 7;
					num2 = 1;
					keyword = "copyuidbtn";
				}
			}
			else
			{
				num = 5;
				num2 = 1;
				keyword = "energyhinttitle";
			}
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.KGEAGCMFMPB, (float)num);
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.PKNBODNLDDE, (float)num2);
			this.JFBEGDFHMLC.DisableKeyword("OnBackendRequestSendMessageException");
			this.JFBEGDFHMLC.DisableKeyword("OnBackendGetPublicProfileHallOfFameMoreSuccess");
			this.JFBEGDFHMLC.DisableKeyword("variant");
			this.JFBEGDFHMLC.EnableKeyword(keyword);
			this.JFLDDNKFBIC = this.blendMode;
		}
		if (this.PMNGFGFJFAF && !Mathf.Approximately(this.GOJEKIEBHMN, this.foldShadowOpacity))
		{
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.LBLKBBKPPDA, this.foldShadowOpacity);
			this.GOJEKIEBHMN = this.foldShadowOpacity;
		}
		if (!Mathf.Approximately(this.BIIIOJPAIMO, this.clothColorShift))
		{
			this.JFBEGDFHMLC.SetFloat(FlagAnimator.BCMBMNEPGIG, this.clothColorShift);
			this.BIIIOJPAIMO = this.clothColorShift;
		}
		if (this.glowColor != this.HDEELEOKLGA)
		{
			this.JFBEGDFHMLC.SetColor(FlagAnimator.EAIGOHDFABB, this.glowColor);
			this.HDEELEOKLGA = this.glowColor;
		}
		bool flag = this.layerIdInverter == null || this.layerIdInverter.activeInHierarchy;
		float num3 = (this.enableGlow && flag && this.blendMode == FlagAnimator.EDIAIDHAFAO.Alpha) ? (this.glowColor.a * this.GADNAPIEBIG(this.NDNAHIBKAHI)) : 383f;
		if (!Mathf.Approximately(this.DPJEKLMOGKA, num3))
		{
			if (this.ICOJJIPKJOD == null)
			{
				this.ICOJJIPKJOD = new MaterialPropertyBlock();
			}
			this.ICOJJIPKJOD.SetFloat(FlagAnimator.EBEJPLFNIKC, num3);
			if (this.KNPDGGPAGAJ != null)
			{
				this.KNPDGGPAGAJ.SetPropertyBlock(this.ICOJJIPKJOD);
			}
			this.DPJEKLMOGKA = num3;
		}
	}

	// Token: 0x06006DAB RID: 28075 RVA: 0x0031F4A2 File Offset: 0x0031D6A2
	public void JAKKHJGEOOL()
	{
		this.HGPHLBLBFGM = false;
	}

	// Token: 0x06006DAC RID: 28076 RVA: 0x00322B90 File Offset: 0x00320D90
	private void FGDFPMLKPFG(float PMMCLCMDNGA)
	{
		if (this.NNMAICJHGND == null || this.EPJBDAOHHGC == null || this.DNCLNNHNAIA == null || this.AKCJBDJFIBE == null)
		{
			return;
		}
		int num = this.KCJIBOLMDMJ + 1;
		int num2 = this.EAECJIKFECN + 1;
		if (this.EPJBDAOHHGC.Length != num * num2)
		{
			return;
		}
		FlagAnimator.NNDGGMGDGHN nndggmgdghn = this.EBBIFEIKPFP(PMMCLCMDNGA);
		bool flag = this.enableWrinkles && nndggmgdghn.MPOLFBDIPFD > 0.0001f;
		bool flag2 = nndggmgdghn.FHAHPHFCMJB > 0.0001f;
		if (flag2)
		{
			this.IIDPACCPDIP(PMMCLCMDNGA, nndggmgdghn);
		}
		Vector2 nipeelpjblc = nndggmgdghn.NIPEELPJBLC;
		float fmnddaecjfm = nndggmgdghn.FMNDDAECJFM;
		float cbanopdmnei = nndggmgdghn.CBANOPDMNEI;
		float knbcbdcpefk = nndggmgdghn.KNBCBDCPEFK;
		float mpolfbdipfd = nndggmgdghn.MPOLFBDIPFD;
		float bkhbnamncmd = nndggmgdghn.BKHBNAMNCMD;
		Vector3[] epjbdaohhgc = this.EPJBDAOHHGC;
		Vector3[] dnclnnhnaia = this.DNCLNNHNAIA;
		float[] akcjbdjfibe = this.AKCJBDJFIBE;
		float num3 = this.pinStiffness;
		bool flag3 = this.waveAxis == FlagAnimator.KNMMCPKHNLA.Horizontal;
		float num4 = 1f / (float)this.KCJIBOLMDMJ;
		float num5 = 1f / (float)this.EAECJIKFECN;
		float cdcjggccfch = nndggmgdghn.CDCJGGCCFCH;
		float num6 = PMMCLCMDNGA * knbcbdcpefk;
		float num7 = 18.849556f;
		bool flag4 = nndggmgdghn.GCPMDGNKDMI > 1E-06f;
		float gcpmdgnkdmi = nndggmgdghn.GCPMDGNKDMI;
		float num8 = cdcjggccfch * 3.5f;
		float num9 = PMMCLCMDNGA * (knbcbdcpefk * 2.5f + 6f);
		float num10 = this.liveliness;
		float num11 = cdcjggccfch * 0.8f + 1.2f;
		float num12 = cdcjggccfch * 1.4f + 1.9f;
		float num13 = knbcbdcpefk * 0.5f + 0.35f;
		float num14 = knbcbdcpefk * 0.7f + 0.5f;
		float gnhbekhojhj = nndggmgdghn.GNHBEKHOJHJ;
		for (int i = 0; i < num2; i++)
		{
			for (int j = 0; j < num; j++)
			{
				int num15 = i * num + j;
				float num16 = (float)j * num4;
				float num17 = (float)i * num5;
				float num18 = this.LCCKLOCDJMK(num16, num17);
				float num19 = Mathf.Lerp(1f - num3, 1f, num18);
				num19 = num19 * num19 * num19;
				float num20 = flag3 ? num16 : num17;
				float num21 = FlagAnimator.JNIENKPLBKP(num20, num17, PMMCLCMDNGA, 13.7f) * 0.5f + FlagAnimator.JNIENKPLBKP(num20, num17, PMMCLCMDNGA * 1.3f, 29.1f) * 0.35f;
				float num22 = 1f + FlagAnimator.JNIENKPLBKP(num20, num17, PMMCLCMDNGA * 0.8f, 47.3f) * 0.3f;
				float num23 = num20 * cdcjggccfch - num6 + this._phaseOffset + num21;
				float num24 = FlagAnimator.OOMINMLKFOI(num23);
				float num25 = FlagAnimator.OOMINMLKFOI(num23 * 2.17f + 0.7f) * 0.35f;
				float num26 = FlagAnimator.OOMINMLKFOI(num23 * 3.31f + 1.4f) * 0.2f;
				float num27 = (num24 + num25 + num26) * 0.64516133f * fmnddaecjfm * num22 * num19;
				float num28 = 0f;
				if (num10 > 0.0001f)
				{
					float num29 = flag3 ? num17 : num16;
					float num30 = FlagAnimator.OOMINMLKFOI(num20 * num11 + num29 * 1.6f - PMMCLCMDNGA * num13 + this._phaseOffset);
					float num31 = 0.6f + 0.4f * FlagAnimator.JNIENKPLBKP(num20 * 1.1f, num29, PMMCLCMDNGA * 0.3f, 5.1f);
					float num32 = FlagAnimator.OOMINMLKFOI(num20 * num12 + num29 * 1.1f - PMMCLCMDNGA * num14 + this._phaseOffset * 1.3f) * 0.45f;
					float num33 = 0.6f + 0.4f * FlagAnimator.JNIENKPLBKP(num20 * 1.9f, num29, PMMCLCMDNGA * 0.45f, 17.3f);
					float num34 = num30 * num31 + num32 * num33;
					num34 *= 1f + 0.25f * num34;
					num28 = num34 * gnhbekhojhj * num19;
					num27 += num34 * gnhbekhojhj * num19 * 0.35f;
				}
				if (flag4)
				{
					float num35 = num18 * num18;
					num35 *= num35;
					float num36 = FlagAnimator.OOMINMLKFOI(num20 * num8 + num9 + num17 * 9.3f + this._phaseOffset);
					num27 += num36 * gcpmdgnkdmi * num35;
				}
				Vector2 vector;
				if (flag3)
				{
					vector = new Vector2(nipeelpjblc.x * num18, nipeelpjblc.y * num19);
				}
				else
				{
					vector = new Vector2(nipeelpjblc.x * num19, nipeelpjblc.y * num18);
				}
				Vector3 vector2 = dnclnnhnaia[num15];
				if (flag3)
				{
					vector2.x += vector.x;
					vector2.y += vector.y + num27;
				}
				else
				{
					vector2.x += vector.x + num27;
					vector2.y += vector.y;
				}
				vector2.z += num28;
				if (flag2)
				{
					if (flag3)
					{
						vector2.x += this.HEPNAMAFJOB[num15];
					}
					else
					{
						vector2.y += this.HEPNAMAFJOB[num15];
					}
					vector2.z += this.JBJPONAILFI[num15];
				}
				if (flag)
				{
					float num37 = PMMCLCMDNGA * bkhbnamncmd;
					float num38 = akcjbdjfibe[num15];
					float num39 = FlagAnimator.OOMINMLKFOI(num16 * num7 + num37 * 0.4f + num38);
					float num40 = FlagAnimator.OOMINMLKFOI(num17 * num7 * 0.7f + num37 * 0.35f + num38 + 2.1f);
					float num41 = FlagAnimator.OOMINMLKFOI((num16 + num17) * num7 * 0.8f + num37 * 0.5f + num38 + 3.8f);
					float num42 = mpolfbdipfd * cbanopdmnei * num19 * 0.5714286f;
					vector2.x += num39 * num42;
					vector2.y += num40 * num42;
					vector2.z += num41 * num42 * 0.5f;
				}
				epjbdaohhgc[num15] = vector2;
			}
		}
		this.NNMAICJHGND.SetVertices(this.EPJBDAOHHGC, 0, this.EPJBDAOHHGC.Length, MeshUpdateFlags.DontValidateIndices | MeshUpdateFlags.DontRecalculateBounds);
	}

	// Token: 0x06006DAD RID: 28077 RVA: 0x00323174 File Offset: 0x00321374
	private void Awake()
	{
		this.NDGCJPCEMMP();
		this.MMLCMAKJMPE();
		if (this._phaseOffset < 0f)
		{
			this._phaseOffset = UnityEngine.Random.Range(0f, 6.2831855f);
		}
		this.FOIAODBCJCJ = this.pinSide;
		this.LFGOADFAOAB();
		this.ANDALJGBPHI();
		this.OJBIDELMBIF();
		this.OMDKKMABAEA();
		this.AALOONGJPKO();
		this.AJBBCAODJJI = this.enableShadow;
		this.MIMDFDKIPBF = this.blendMode;
		if (this.glowAlpha < 0.999f && this.glowColor.a > 0.999f)
		{
			this.glowColor.a = this.glowAlpha;
			this.glowAlpha = 1f;
		}
		if (this.playOnAwake && Application.isPlaying)
		{
			this.Play();
		}
	}

	// Token: 0x06006DAE RID: 28078 RVA: 0x003191CF File Offset: 0x003173CF
	public void OMJHINHOPFI()
	{
		this.HGPHLBLBFGM = true;
	}

	// Token: 0x06006DAF RID: 28079 RVA: 0x00323244 File Offset: 0x00321444
	private void MMLCMAKJMPE()
	{
		if (this._boundsCaptured)
		{
			this.OONCIMHKPMC = this._capturedOrigin;
			this.OKHKJPIJAFK = this._capturedWidth;
			this.AJHMCBGIGAF = this._capturedHeight;
			return;
		}
		Mesh mesh = (this.NDLLNEAACJO != null) ? this.NDLLNEAACJO.sharedMesh : null;
		if (mesh != null && (mesh == this.NNMAICJHGND || mesh.name == "FlagMesh"))
		{
			mesh = null;
		}
		if (mesh != null)
		{
			Bounds bounds = mesh.bounds;
			this.OONCIMHKPMC = bounds.min;
			this.OKHKJPIJAFK = bounds.size.x;
			this.AJHMCBGIGAF = bounds.size.y;
			if (this.OKHKJPIJAFK <= 0.001f || this.AJHMCBGIGAF <= 0.001f)
			{
				this.EBBBHGPMGEI();
			}
		}
		else
		{
			this.EBBBHGPMGEI();
		}
		if (this.OKHKJPIJAFK > 0.001f && this.AJHMCBGIGAF > 0.001f)
		{
			this._boundsCaptured = true;
			this._capturedOrigin = this.OONCIMHKPMC;
			this._capturedWidth = this.OKHKJPIJAFK;
			this._capturedHeight = this.AJHMCBGIGAF;
		}
	}

	// Token: 0x06006DB0 RID: 28080 RVA: 0x00323374 File Offset: 0x00321574
	private void AODDBIELGIF()
	{
		if (this.PNAIJJNHNDO == null)
		{
			return;
		}
		if (this.shadowColor != this.EJEEKNJBLFC)
		{
			this.PNAIJJNHNDO.SetColor(FlagAnimator.JKGKOPLEECM, this.shadowColor);
			this.EJEEKNJBLFC = this.shadowColor;
		}
		float num = this.LHJEBMDMMGL(this.shadowBlur);
		if (!Mathf.Approximately(num, this.ALHGHMBPPBA))
		{
			this.PNAIJJNHNDO.SetFloat(FlagAnimator.OFPCMHILMGC, num);
			this.ALHGHMBPPBA = num;
		}
		float num2 = this.IMKHDMDHJFC ? this.shadowClipRight : this.shadowClipLeft;
		float num3 = this.IMKHDMDHJFC ? this.shadowClipLeft : this.shadowClipRight;
		float num4 = this.OHCJJCDOMED ? this.shadowClipTop : this.shadowClipBottom;
		float num5 = this.OHCJJCDOMED ? this.shadowClipBottom : this.shadowClipTop;
		float num6;
		float num7;
		float num8;
		float num9;
		if (this.EPJBDAOHHGC != null && this.EPJBDAOHHGC.Length != 0)
		{
			num6 = 222f;
			num7 = 1499f;
			num8 = 1831f;
			num9 = 1942f;
			for (int i = 1; i < this.EPJBDAOHHGC.Length; i++)
			{
				Vector3 vector = this.EPJBDAOHHGC[i];
				if (vector.x < num6)
				{
					num6 = vector.x;
				}
				if (vector.x > num7)
				{
					num7 = vector.x;
				}
				if (vector.y < num8)
				{
					num8 = vector.y;
				}
				if (vector.y > num9)
				{
					num9 = vector.y;
				}
			}
		}
		else
		{
			num6 = this.OONCIMHKPMC.x;
			num7 = this.OONCIMHKPMC.x + this.OKHKJPIJAFK;
			num8 = this.OONCIMHKPMC.y;
			num9 = this.OONCIMHKPMC.y + this.AJHMCBGIGAF;
		}
		Vector4 vector2 = new Vector4(num6, num7, num8, num9);
		if (!this.KGGIMPBJMBF)
		{
			this.NMOBEAMJENA = vector2;
			this.KGGIMPBJMBF = false;
		}
		else
		{
			this.NMOBEAMJENA = Vector4.Lerp(this.NMOBEAMJENA, vector2, 1246f);
		}
		float num10 = Mathf.Max(this.NMOBEAMJENA.y - this.NMOBEAMJENA.x, 1606f);
		float num11 = Mathf.Max(this.NMOBEAMJENA.w - this.NMOBEAMJENA.z, 550f);
		float num12 = 739f * Mathf.Min(Mathf.Max(this.OKHKJPIJAFK, 854f), Mathf.Max(this.AJHMCBGIGAF, 333f));
		Vector4 vector3;
		if (this.OKHKJPIJAFK < 986f || this.AJHMCBGIGAF < 191f)
		{
			vector3 = new Vector4(918f, 812f, 1993f, 135f);
		}
		else
		{
			vector3 = new Vector4((num2 > 1423f) ? (this.NMOBEAMJENA.x + num2 * num10) : 1294f, (num3 > 1939f) ? (this.NMOBEAMJENA.x + (1730f - num3) * num10) : 546f, (num4 > 1533f) ? (this.NMOBEAMJENA.z + num4 * num11) : 1788f, (num5 > 1543f) ? (this.NMOBEAMJENA.z + (96f - num5) * num11) : 1212f);
		}
		if (vector3 != this.GPGCBDFODKC || !Mathf.Approximately(num12, this.LOODDNMNMBI))
		{
			this.PNAIJJNHNDO.SetVector(FlagAnimator.EGIGLCFLPCN, vector3);
			this.PNAIJJNHNDO.SetFloat(FlagAnimator.GNJCEELJCBL, num12);
			this.GPGCBDFODKC = vector3;
			this.LOODDNMNMBI = num12;
		}
	}

	// Token: 0x06006DB1 RID: 28081 RVA: 0x00323714 File Offset: 0x00321914
	private FlagAnimator.NNDGGMGDGHN PAELCBDLKEA(float PMMCLCMDNGA)
	{
		float num = this.DMAAIIBCLBE(this.amplitude);
		float num2 = this.ICJJEPHACGK(this.frequency);
		float num3 = this.LMFALPDFMJK(this.speed);
		float num4 = this.windStrength;
		float f = this.windAngle * 1673f;
		float num5 = Mathf.Cos(f);
		float num6 = Mathf.Sin(f);
		if (this.IMKHDMDHJFC)
		{
			num5 = -num5;
		}
		if (this.OHCJJCDOMED)
		{
			num6 = -num6;
		}
		Vector2 vector = new Vector2(num5, num6);
		FlagAnimator.NNDGGMGDGHN nndggmgdghn;
		nndggmgdghn.MPOLFBDIPFD = this.EPCPJNBFHNF(this.wrinkleJitter);
		if (this.enableNoise)
		{
			if (this.noiseAmplitude > 139f)
			{
				num *= 1102f + this.HBGOKOGFEJF(this.AGMMPGDKBLD + this._phaseOffset * 1096f, PMMCLCMDNGA, 1700f) * this.noiseAmplitude;
			}
			if (this.noiseFrequency > 513f)
			{
				num2 *= 238f + this.HBGOKOGFEJF(this.FJDCEOOGGHF + this._phaseOffset * 1469f, PMMCLCMDNGA, 1920f) * this.noiseFrequency;
			}
		}
		num = Mathf.Max(1891f, num);
		num2 = Mathf.Max(1353f, num2);
		num3 = Mathf.Max(638f, num3);
		num4 = Mathf.Max(1540f, num4);
		float num7 = this.HBGOKOGFEJF(353f + this._phaseOffset * 610f, PMMCLCMDNGA, 948f);
		float num8 = this.JNAIHPIEIPA(457f + this._phaseOffset * 1101f, PMMCLCMDNGA, 1289f);
		float num9 = this.NLEAOKKKKLP(1391f + this._phaseOffset * 382f, PMMCLCMDNGA, 512f);
		float num10 = num7 * 1087f + num8 * 70f + num9 * 153f;
		float num11 = this.JBALLCCFAHB(this.windGust);
		num10 /= 1454f + 469f * Mathf.Abs(num10);
		float num12 = 1373f + num10 * num11;
		if (num12 < 1639f)
		{
			num12 = 771f / (1914f - num12);
		}
		if (num11 > 1887f)
		{
			float f2 = this.NLEAOKKKKLP(870f + this._phaseOffset, PMMCLCMDNGA, 448f) * num11 * 297f;
			float num13 = Mathf.Cos(f2);
			float num14 = Mathf.Sin(f2);
			vector = new Vector2(vector.x * num13 - vector.y * num14, vector.x * num14 + vector.y * num13);
		}
		num4 = Mathf.Max(95f, num4 * num12);
		nndggmgdghn.CBANOPDMNEI = (this.OKHKJPIJAFK + this.AJHMCBGIGAF) * 1265f;
		nndggmgdghn.NIPEELPJBLC = vector * (num4 * nndggmgdghn.CBANOPDMNEI);
		nndggmgdghn.FMNDDAECJFM = num * nndggmgdghn.CBANOPDMNEI;
		nndggmgdghn.CDCJGGCCFCH = num2 * 550f * 787f;
		nndggmgdghn.KNBCBDCPEFK = num3;
		nndggmgdghn.BKHBNAMNCMD = this.OJIAJFHLCAK(this.wrinkleSpeed);
		nndggmgdghn.GCPMDGNKDMI = ((this.edgeFlutter > 1787f) ? (this.edgeFlutter * nndggmgdghn.CBANOPDMNEI * 1809f * Mathf.Clamp01(num4 + 1975f)) : 387f);
		nndggmgdghn.GNHBEKHOJHJ = ((this.liveliness > 404f) ? (this.liveliness * (nndggmgdghn.FMNDDAECJFM * 156f + nndggmgdghn.CBANOPDMNEI * 148f)) : 1382f);
		nndggmgdghn.FHAHPHFCMJB = ((this.depthCurl > 677f) ? (this.depthCurl * 512f) : 665f);
		nndggmgdghn.KJOIAFAMBPC = nndggmgdghn.CDCJGGCCFCH * 1825f + 1936f;
		nndggmgdghn.HMAAJEPOAIC = num3 * 473f + 1796f;
		bool flag = this.waveAxis == FlagAnimator.KNMMCPKHNLA.Vertical;
		if (flag ? (this.pinSide == FlagAnimator.JMPGKJMGNKH.Left || this.pinSide == FlagAnimator.JMPGKJMGNKH.Right) : (this.pinSide != (FlagAnimator.JMPGKJMGNKH)7 && this.pinSide == (FlagAnimator.JMPGKJMGNKH)5))
		{
			float num15 = flag ? this.OKHKJPIJAFK : this.AJHMCBGIGAF;
			float num16 = 828f * Mathf.Cos(nndggmgdghn.FHAHPHFCMJB) * num15;
			if (flag)
			{
				nndggmgdghn.NIPEELPJBLC.x = Mathf.Clamp(nndggmgdghn.NIPEELPJBLC.x, -num16, num16);
			}
			else
			{
				nndggmgdghn.NIPEELPJBLC.y = Mathf.Clamp(nndggmgdghn.NIPEELPJBLC.y, -num16, num16);
			}
		}
		return nndggmgdghn;
	}

	// Token: 0x04001FE3 RID: 8163
	[Tooltip("Horizontal mesh resolution. 16 is enough for smooth waves at typical flag sizes.")]
	[Range(4f, 32f)]
	[Header("Mesh Settings")]
	public int columns = 16;

	// Token: 0x04001FE4 RID: 8164
	[Range(2f, 32f)]
	[Tooltip("Vertical mesh resolution. 8 covers most cases.")]
	public int rows = 8;

	// Token: 0x04001FE5 RID: 8165
	private const float DHBHIHDAPGD = 1f;

	// Token: 0x04001FE6 RID: 8166
	[Header("Wave")]
	[Range(0f, 1f)]
	public float amplitude = 0.2f;

	// Token: 0x04001FE7 RID: 8167
	[Range(0f, 1f)]
	public float frequency = 0.3f;

	// Token: 0x04001FE8 RID: 8168
	[Range(0f, 1f)]
	public float speed = 0.3f;

	// Token: 0x04001FE9 RID: 8169
	[Tooltip("Brings the cloth to life: secondary travelling creases that ripple from the pinned side toward the free edge and slowly form/relax, so the fabric reads as living cloth rather than a smooth sine. Works even with no wind. 0 = off. Costs a little extra per-vertex math.")]
	[Range(0f, 1f)]
	public float liveliness = 0.35f;

	// Token: 0x04001FEA RID: 8170
	[Tooltip("Pseudo-3D curl: the free end bends toward the viewer and a wave of fabric rolls along the flag. Cloth length is preserved, so curled sections foreshorten toward the pin. 0 = off.")]
	[Range(0f, 1f)]
	public float depthCurl;

	// Token: 0x04001FEB RID: 8171
	public FlagAnimator.KNMMCPKHNLA waveAxis;

	// Token: 0x04001FEC RID: 8172
	[Header("Pin")]
	public FlagAnimator.JMPGKJMGNKH pinSide = FlagAnimator.JMPGKJMGNKH.Right;

	// Token: 0x04001FED RID: 8173
	[Range(0f, 1f)]
	public float pinStiffness = 1f;

	// Token: 0x04001FEE RID: 8174
	[Range(0f, 360f)]
	[Tooltip("Wind direction in degrees. 0 = right, 90 = up, 180 = left, 270 = down.")]
	[Header("Wind")]
	public float windAngle;

	// Token: 0x04001FEF RID: 8175
	[Range(0f, 1f)]
	public float windStrength;

	// Token: 0x04001FF0 RID: 8176
	[Tooltip("Chaos of wind gusts. 0 = steady wind, 1 = strong swings between calm and heavy bursts. Controls both gust amplitude and direction wobble.")]
	[Range(0f, 1f)]
	public float windGust = 0.1f;

	// Token: 0x04001FF1 RID: 8177
	[Header("Wrinkles")]
	public bool enableWrinkles;

	// Token: 0x04001FF2 RID: 8178
	[Tooltip("How deep the wrinkles press into the fabric. Needs at least one of the Size sliders above 0 — with both at 0 there are no folds to deepen and Depth does nothing.")]
	[Range(0f, 1f)]
	public float wrinkleDepth;

	// Token: 0x04001FF3 RID: 8179
	[Tooltip("Horizontal fold size. 0 = OFF (no horizontal folds); just above 0 = many tiny folds, 1 = few big folds across X.")]
	[Range(0f, 1f)]
	public float wrinkleSizeX;

	// Token: 0x04001FF4 RID: 8180
	[Range(0f, 1f)]
	[Tooltip("Vertical fold size. 0 = OFF (no vertical folds); just above 0 = many tiny folds, 1 = few big folds across Y. Keep at 0 for strictly horizontal cloth stripes.")]
	public float wrinkleSizeY;

	// Token: 0x04001FF5 RID: 8181
	[Range(0f, 1f)]
	[Tooltip("Amount of fine detail layered on the main folds.")]
	public float wrinkleDetail;

	// Token: 0x04001FF6 RID: 8182
	[Range(0f, 1f)]
	public float wrinkleJitter;

	// Token: 0x04001FF7 RID: 8183
	[Range(0f, 1f)]
	public float wrinkleSpeed;

	// Token: 0x04001FF8 RID: 8184
	[Header("Cloth Shading")]
	[Tooltip("Opacity of shadows inside cloth folds and wrinkles. 0 = no fold darkening, 1 = strong ambient occlusion in every crease.")]
	[Range(0f, 1f)]
	public float foldShadowOpacity = 0.4f;

	// Token: 0x04001FF9 RID: 8185
	[Tooltip("How the flag blends with what's behind it. \nAlpha    — standard transparency (default). \nAdditive — black pixels become transparent (PS Linear Dodge / Screen). \nMultiply — white pixels become transparent (PS Multiply).")]
	public FlagAnimator.EDIAIDHAFAO blendMode;

	// Token: 0x04001FFA RID: 8186
	[Range(0f, 1f)]
	[Tooltip("Warm/cool fabric tint. Lit ridges lean warm, shadows & folds lean cool — gives real-cloth richness instead of flat shading. 0 = off (pure brightness shading), 0.3–0.5 = natural, 1 = stylised.")]
	public float clothColorShift = 0.35f;

	// Token: 0x04001FFB RID: 8187
	[Range(0f, 1f)]
	[Tooltip("Extra high-frequency flutter that ripples along the FREE edge of the flag (the most recognisable trait of a real flag in wind). 0 = off, 1 = strong snapping edge. Scales with wind strength.")]
	public float edgeFlutter = 0.4f;

	// Token: 0x04001FFC RID: 8188
	[Header("Glow")]
	[Tooltip("Enable colored light on the flag.")]
	public bool enableGlow;

	// Token: 0x04001FFD RID: 8189
	[Tooltip("Glow color.")]
	public Color glowColor = new Color(1f, 0.8f, 0.4f, 1f);

	// Token: 0x04001FFE RID: 8190
	[HideInInspector]
	[Tooltip("Glow opacity. 0 = invisible, 1 = flag fully takes the glow color.")]
	public float glowAlpha = 1f;

	// Token: 0x04001FFF RID: 8191
	public FlagAnimator.IKJNPDGMAPA preset;

	// Token: 0x04002000 RID: 8192
	[Tooltip("If set, the glow turns on/off together with this GameObject's active state. Drag the callable light/fire layer here: when it is disabled in the hierarchy, the glow disappears; when enabled, it comes back. Leave empty for an always-on glow.")]
	[FormerlySerializedAs("linkedToggleObject")]
	public GameObject layerIdInverter;

	// Token: 0x04002001 RID: 8193
	public float speedCoefficient = 1f;

	// Token: 0x04002002 RID: 8194
	public float intensityCoefficient = 0.2f;

	// Token: 0x04002003 RID: 8195
	public float baselineIntensity = 0.8f;

	// Token: 0x04002004 RID: 8196
	public bool randomSeed = true;

	// Token: 0x04002005 RID: 8197
	public float logicUpdateInterval;

	// Token: 0x04002006 RID: 8198
	public float floorAtValueLessOrEqual;

	// Token: 0x04002007 RID: 8199
	public float ceilAtValueHeigherOrEqual = 1f;

	// Token: 0x04002008 RID: 8200
	public float timeOffsetAtStart;

	// Token: 0x04002009 RID: 8201
	[Header("Shadow")]
	public bool enableShadow;

	// Token: 0x0400200A RID: 8202
	public Color shadowColor = new Color(0f, 0f, 0f, 0.5f);

	// Token: 0x0400200B RID: 8203
	[Tooltip("Shadow offset in flag-size units. Range is [-3, 3]: \n±1 ≈ half the flag size (common), \n±3 ≈ 1.5x flag size away (for dramatic long shadows). \n(0.1, -0.1) = 10% right & down from the flag.")]
	public float shadowOffsetX = 0.1f;

	// Token: 0x0400200C RID: 8204
	public float shadowOffsetY = -0.1f;

	// Token: 0x0400200D RID: 8205
	[Range(0f, 1f)]
	public float shadowBlur = 0.3f;

	// Token: 0x0400200E RID: 8206
	[Tooltip("Clip shadow from the TOP edge of the flag inward (screen-space). 0 = no clip, 1 = clipped entirely.")]
	[Range(0f, 1f)]
	public float shadowClipLeft;

	// Token: 0x0400200F RID: 8207
	[Tooltip("Clip shadow from the BOTTOM edge of the flag inward (screen-space).")]
	[Range(0f, 1f)]
	public float shadowClipRight;

	// Token: 0x04002010 RID: 8208
	[Range(0f, 1f)]
	[Tooltip("Clip shadow from the RIGHT edge of the flag inward (screen-space).")]
	public float shadowClipTop;

	// Token: 0x04002011 RID: 8209
	[Range(0f, 1f)]
	[Tooltip("Clip shadow from the LEFT edge of the flag inward (screen-space).")]
	public float shadowClipBottom;

	// Token: 0x04002012 RID: 8210
	[Tooltip("Sorting order RELATIVE to the flag's own. 0 = same slot as the flag (the shadow still draws just behind it). Negative = push further behind, positive = pull in front.")]
	public int shadowSortingOrder;

	// Token: 0x04002013 RID: 8211
	[FormerlySerializedAs("shadowLinkedToggleObject")]
	[Tooltip("If set, the shadow turns on/off together with this GameObject's active state — same as the glow link. Drag the callable light/fire layer here: disabled in hierarchy = shadow hidden, enabled = shown. Leave empty for an always-on shadow.")]
	public GameObject shadowLayerIdInverter;

	// Token: 0x04002014 RID: 8212
	[Header("Playback")]
	public bool playOnAwake = true;

	// Token: 0x04002015 RID: 8213
	[Tooltip("Enables time-based organic drift on all parameters below.")]
	[Header("Noise")]
	public bool enableNoise;

	// Token: 0x04002016 RID: 8214
	[Range(0f, 1f)]
	public float noiseAmplitude;

	// Token: 0x04002017 RID: 8215
	[Range(0f, 1f)]
	public float noiseFrequency;

	// Token: 0x04002018 RID: 8216
	private Mesh NNMAICJHGND;

	// Token: 0x04002019 RID: 8217
	private Vector3[] DNCLNNHNAIA;

	// Token: 0x0400201A RID: 8218
	private Vector3[] EPJBDAOHHGC;

	// Token: 0x0400201B RID: 8219
	private Color32[] DJHHABDANKC;

	// Token: 0x0400201C RID: 8220
	private float[] HEPNAMAFJOB;

	// Token: 0x0400201D RID: 8221
	private float[] JBJPONAILFI;

	// Token: 0x0400201E RID: 8222
	private float[] MLGKJELDNFE;

	// Token: 0x0400201F RID: 8223
	private const bool LFGKKPDNGED = false;

	// Token: 0x04002020 RID: 8224
	private float[] AKCJBDJFIBE;

	// Token: 0x04002021 RID: 8225
	private float[] LLKOGKKCCIC;

	// Token: 0x04002022 RID: 8226
	private Vector2[] JMFDPPPADKA;

	// Token: 0x04002023 RID: 8227
	private int[] FCPGDGOLAEI;

	// Token: 0x04002024 RID: 8228
	private MeshFilter NDLLNEAACJO;

	// Token: 0x04002025 RID: 8229
	private MeshRenderer KNPDGGPAGAJ;

	// Token: 0x04002026 RID: 8230
	private int KCJIBOLMDMJ;

	// Token: 0x04002027 RID: 8231
	private int EAECJIKFECN;

	// Token: 0x04002028 RID: 8232
	private float FDPFEIIMAAG;

	// Token: 0x04002029 RID: 8233
	private float GFEDPIAEBNM;

	// Token: 0x0400202A RID: 8234
	private float NMBHFAIDHHG;

	// Token: 0x0400202B RID: 8235
	private float FNBJFBKFGCN;

	// Token: 0x0400202C RID: 8236
	private bool KFKCFFNFCEC;

	// Token: 0x0400202D RID: 8237
	[HideInInspector]
	[SerializeField]
	private Material _originalMaterial;

	// Token: 0x0400202E RID: 8238
	[HideInInspector]
	[SerializeField]
	private Mesh _originalMesh;

	// Token: 0x0400202F RID: 8239
	[HideInInspector]
	[SerializeField]
	private bool _originalMeshCaptured;

	// Token: 0x04002030 RID: 8240
	private Material JFBEGDFHMLC;

	// Token: 0x04002031 RID: 8241
	[SerializeField]
	[HideInInspector]
	private Material _clothMatAsset;

	// Token: 0x04002032 RID: 8242
	[SerializeField]
	[HideInInspector]
	private Material _shadowMatAsset;

	// Token: 0x04002033 RID: 8243
	[SerializeField]
	[HideInInspector]
	private string _matBaseName;

	// Token: 0x04002034 RID: 8244
	[SerializeField]
	[HideInInspector]
	private Texture _srcTexture;

	// Token: 0x04002035 RID: 8245
	[HideInInspector]
	[SerializeField]
	private Vector2 _srcTexScale = Vector2.one;

	// Token: 0x04002036 RID: 8246
	[SerializeField]
	[HideInInspector]
	private Vector2 _srcTexOffset = Vector2.zero;

	// Token: 0x04002037 RID: 8247
	[HideInInspector]
	[SerializeField]
	private Color _srcColor = Color.white;

	// Token: 0x04002038 RID: 8248
	[SerializeField]
	[HideInInspector]
	private bool _srcCaptured;

	// Token: 0x04002039 RID: 8249
	private Vector3 OONCIMHKPMC;

	// Token: 0x0400203A RID: 8250
	private float OKHKJPIJAFK;

	// Token: 0x0400203B RID: 8251
	private float AJHMCBGIGAF;

	// Token: 0x0400203C RID: 8252
	[HideInInspector]
	[SerializeField]
	private bool _boundsCaptured;

	// Token: 0x0400203D RID: 8253
	[HideInInspector]
	[SerializeField]
	private Vector3 _capturedOrigin;

	// Token: 0x0400203E RID: 8254
	[SerializeField]
	[HideInInspector]
	private float _capturedWidth;

	// Token: 0x0400203F RID: 8255
	[SerializeField]
	[HideInInspector]
	private float _capturedHeight;

	// Token: 0x04002040 RID: 8256
	private bool IMKHDMDHJFC;

	// Token: 0x04002041 RID: 8257
	private bool OHCJJCDOMED;

	// Token: 0x04002042 RID: 8258
	[HideInInspector]
	[SerializeField]
	private float _phaseOffset = -1f;

	// Token: 0x04002043 RID: 8259
	private bool HGPHLBLBFGM;

	// Token: 0x04002044 RID: 8260
	private bool AJBBCAODJJI;

	// Token: 0x04002045 RID: 8261
	private FlagAnimator.EDIAIDHAFAO MIMDFDKIPBF;

	// Token: 0x04002046 RID: 8262
	private const float GILODLGJKGM = 0.033333335f;

	// Token: 0x04002047 RID: 8263
	private const float BLLPGJNHLKN = 0.033333335f;

	// Token: 0x04002048 RID: 8264
	private float OHGGGMBHLDO = -1f;

	// Token: 0x04002049 RID: 8265
	private float ANKNIJBNBBM = -1f;

	// Token: 0x0400204A RID: 8266
	private bool PMNGFGFJFAF;

	// Token: 0x0400204B RID: 8267
	private bool LNHHGBMDHIB;

	// Token: 0x0400204C RID: 8268
	private float GOJEKIEBHMN = -1f;

	// Token: 0x0400204D RID: 8269
	private float BIIIOJPAIMO = -1f;

	// Token: 0x0400204E RID: 8270
	private MaterialPropertyBlock ICOJJIPKJOD;

	// Token: 0x0400204F RID: 8271
	private FlagAnimator.EDIAIDHAFAO JFLDDNKFBIC = (FlagAnimator.EDIAIDHAFAO)(-1);

	// Token: 0x04002050 RID: 8272
	private Color HDEELEOKLGA = new Color(-1f, 0f, 0f, 0f);

	// Token: 0x04002051 RID: 8273
	private float DPJEKLMOGKA = -1f;

	// Token: 0x04002052 RID: 8274
	private float NDNAHIBKAHI;

	// Token: 0x04002053 RID: 8275
	private float AIOPNMGJMEM;

	// Token: 0x04002054 RID: 8276
	private static float NGECGOPHPMI;

	// Token: 0x04002055 RID: 8277
	private float EDDHOGMMBME = -1f;

	// Token: 0x04002056 RID: 8278
	private float CPOLBLCBAHB = 1f;

	// Token: 0x04002057 RID: 8279
	private FlagAnimator.JMPGKJMGNKH FOIAODBCJCJ;

	// Token: 0x04002058 RID: 8280
	private float AGMMPGDKBLD = 10f;

	// Token: 0x04002059 RID: 8281
	private float FJDCEOOGGHF = 20f;

	// Token: 0x0400205A RID: 8282
	[SerializeField]
	[HideInInspector]
	private Transform _shadowUserParent;

	// Token: 0x0400205B RID: 8283
	[SerializeField]
	[HideInInspector]
	private bool _shadowParentCustom;

	// Token: 0x0400205C RID: 8284
	private GameObject IJBBDDHMKFP;

	// Token: 0x0400205D RID: 8285
	private MeshFilter AHMPLHPIJDO;

	// Token: 0x0400205E RID: 8286
	private MeshRenderer AGAMHMNDIOC;

	// Token: 0x0400205F RID: 8287
	private Material PNAIJJNHNDO;

	// Token: 0x04002060 RID: 8288
	private Transform EACHLJCKCCN;

	// Token: 0x04002061 RID: 8289
	[HideInInspector]
	[SerializeField]
	private Quaternion _shadowUserRot = Quaternion.identity;

	// Token: 0x04002062 RID: 8290
	[SerializeField]
	[HideInInspector]
	private Vector3 _shadowUserScale = Vector3.one;

	// Token: 0x04002063 RID: 8291
	private Vector3 PLFDEPDOBKC;

	// Token: 0x04002064 RID: 8292
	private Quaternion JIBAJABFKEH;

	// Token: 0x04002065 RID: 8293
	private Vector3 HPALMHDEELJ;

	// Token: 0x04002066 RID: 8294
	private bool DEGACFCNEBL;

	// Token: 0x04002067 RID: 8295
	private Vector3 ECBJNCHJNED;

	// Token: 0x04002068 RID: 8296
	private Quaternion CLGAMIMGCIL;

	// Token: 0x04002069 RID: 8297
	private Color EJEEKNJBLFC = new Color(-1f, 0f, 0f, 0f);

	// Token: 0x0400206A RID: 8298
	private float ALHGHMBPPBA = -1f;

	// Token: 0x0400206B RID: 8299
	private Vector4 GPGCBDFODKC = new Vector4(-1f, 0f, 0f, 0f);

	// Token: 0x0400206C RID: 8300
	private float LOODDNMNMBI = -1f;

	// Token: 0x0400206D RID: 8301
	private Vector4 NMOBEAMJENA;

	// Token: 0x0400206E RID: 8302
	private bool KGGIMPBJMBF;

	// Token: 0x0400206F RID: 8303
	private static readonly int FPKNKFEANHM = Shader.PropertyToID("_MainTex");

	// Token: 0x04002070 RID: 8304
	private static readonly int KJBLEJPOBPE = Shader.PropertyToID("_Color");

	// Token: 0x04002071 RID: 8305
	private static readonly int BPGBDCMGCHE = Shader.PropertyToID("_LightDir");

	// Token: 0x04002072 RID: 8306
	private static readonly int CAJOPGHOGBI = Shader.PropertyToID("_ShadowStrength");

	// Token: 0x04002073 RID: 8307
	private static readonly int DJJGDBIIGJM = Shader.PropertyToID("_HighlightStr");

	// Token: 0x04002074 RID: 8308
	private static readonly int LBLKBBKPPDA = Shader.PropertyToID("_FoldShade");

	// Token: 0x04002075 RID: 8309
	private static readonly int JKGKOPLEECM = Shader.PropertyToID("_ShadowColor");

	// Token: 0x04002076 RID: 8310
	private static readonly int OFPCMHILMGC = Shader.PropertyToID("_BlurSize");

	// Token: 0x04002077 RID: 8311
	private static readonly int EGIGLCFLPCN = Shader.PropertyToID("_ClipRect");

	// Token: 0x04002078 RID: 8312
	private static readonly int GNJCEELJCBL = Shader.PropertyToID("_ClipAA");

	// Token: 0x04002079 RID: 8313
	private static readonly int KGEAGCMFMPB = Shader.PropertyToID("_SrcBlend");

	// Token: 0x0400207A RID: 8314
	private static readonly int PKNBODNLDDE = Shader.PropertyToID("_DstBlend");

	// Token: 0x0400207B RID: 8315
	private static readonly int BCMBMNEPGIG = Shader.PropertyToID("_ColorShift");

	// Token: 0x0400207C RID: 8316
	private static readonly int EAIGOHDFABB = Shader.PropertyToID("_GlowColor");

	// Token: 0x0400207D RID: 8317
	private static readonly int EBEJPLFNIKC = Shader.PropertyToID("_GlowStrength");

	// Token: 0x0400207E RID: 8318
	private const float BGJPGEMCJBG = 1608.4955f;

	// Token: 0x0400207F RID: 8319
	private const int LCPOKMNJACL = 12;

	// Token: 0x04002080 RID: 8320
	private const int IDMGEFAGKDG = 4096;

	// Token: 0x04002081 RID: 8321
	private const int OKFONBCOALC = 4095;

	// Token: 0x04002082 RID: 8322
	private const float PDBDNKBKALF = 651.8986f;

	// Token: 0x04002083 RID: 8323
	private static float[] NGPOPDFKNFP;

	// Token: 0x04002084 RID: 8324
	private static readonly float DMBONEDAPCF = 1f;

	// Token: 0x04002085 RID: 8325
	private static readonly float IJHMBMHCNKG = 1.4142135f;

	// Token: 0x04002086 RID: 8326
	private static readonly float NIDHLJBBMMJ = 1.6180339f;

	// Token: 0x020003A6 RID: 934
	public enum KNMMCPKHNLA
	{
		// Token: 0x04002088 RID: 8328
		Horizontal,
		// Token: 0x04002089 RID: 8329
		Vertical
	}

	// Token: 0x020003A7 RID: 935
	public enum JMPGKJMGNKH
	{
		// Token: 0x0400208B RID: 8331
		Left,
		// Token: 0x0400208C RID: 8332
		Right,
		// Token: 0x0400208D RID: 8333
		Top,
		// Token: 0x0400208E RID: 8334
		Bottom
	}

	// Token: 0x020003A8 RID: 936
	public enum EDIAIDHAFAO
	{
		// Token: 0x04002090 RID: 8336
		Alpha,
		// Token: 0x04002091 RID: 8337
		Additive,
		// Token: 0x04002092 RID: 8338
		Multiply
	}

	// Token: 0x020003A9 RID: 937
	public enum IKJNPDGMAPA
	{
		// Token: 0x04002094 RID: 8340
		Candle,
		// Token: 0x04002095 RID: 8341
		LightRay
	}

	// Token: 0x020003AA RID: 938
	private struct NNDGGMGDGHN
	{
		// Token: 0x04002096 RID: 8342
		public float FMNDDAECJFM;

		// Token: 0x04002097 RID: 8343
		public float CDCJGGCCFCH;

		// Token: 0x04002098 RID: 8344
		public float KNBCBDCPEFK;

		// Token: 0x04002099 RID: 8345
		public float CBANOPDMNEI;

		// Token: 0x0400209A RID: 8346
		public Vector2 NIPEELPJBLC;

		// Token: 0x0400209B RID: 8347
		public float MPOLFBDIPFD;

		// Token: 0x0400209C RID: 8348
		public float BKHBNAMNCMD;

		// Token: 0x0400209D RID: 8349
		public float GNHBEKHOJHJ;

		// Token: 0x0400209E RID: 8350
		public float GCPMDGNKDMI;

		// Token: 0x0400209F RID: 8351
		public float FHAHPHFCMJB;

		// Token: 0x040020A0 RID: 8352
		public float KJOIAFAMBPC;

		// Token: 0x040020A1 RID: 8353
		public float HMAAJEPOAIC;
	}
}
