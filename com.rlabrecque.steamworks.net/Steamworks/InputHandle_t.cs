using System;

namespace Steamworks
{
	// Token: 0x0200014C RID: 332
	[Serializable]
	public struct InputHandle_t : IEquatable<InputHandle_t>, IComparable<InputHandle_t>
	{
		// Token: 0x06001BA4 RID: 7076 RVA: 0x00013206 File Offset: 0x00011406
		public bool OEHGPCPILFB(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00013216 File Offset: 0x00011416
		public override bool Equals(object LNBMEILJKDH)
		{
			return LNBMEILJKDH is InputHandle_t && InputHandle_t.MKGNKAMFMPG(this, (InputHandle_t)LNBMEILJKDH);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00013233 File Offset: 0x00011433
		public static bool FOIPLEELFDJ(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return InputHandle_t.NFDGMMCNNMN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong POBKLPDBJGK(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00013247 File Offset: 0x00011447
		public static bool OLLJJHFPAJP(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return !InputHandle_t.PEKPHJBBIGP(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x00013253 File Offset: 0x00011453
		public static bool ICJDJJABLCH(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return !InputHandle_t.NMOCADNHGKO(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00013206 File Offset: 0x00011406
		public static bool PEKPHJBBIGP(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00013206 File Offset: 0x00011406
		public static bool HADHNLAFNNK(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong PJCFLLGPNKB(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00013206 File Offset: 0x00011406
		public static bool LDMNACBGBPK(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x0001325F File Offset: 0x0001145F
		public InputHandle_t(ulong AJLPALFJHCC)
		{
			this.m_InputHandle = AJLPALFJHCC;
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00013206 File Offset: 0x00011406
		public bool EKEPMIJHKEP(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00013268 File Offset: 0x00011468
		public int GOOANKMJIMN(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle.CompareTo(LNBMEILJKDH.m_InputHandle);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00013206 File Offset: 0x00011406
		public bool DFMMFPLNFFK(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00013268 File Offset: 0x00011468
		public int KBFAANOGHEG(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle.CompareTo(LNBMEILJKDH.m_InputHandle);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong PCFJPKPGCKC(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t EOLJJPADGDN(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x00013206 File Offset: 0x00011406
		public static bool IGDLLAKOACE(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00013268 File Offset: 0x00011468
		public int MIJEKLEPEIJ(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle.CompareTo(LNBMEILJKDH.m_InputHandle);
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00013206 File Offset: 0x00011406
		public static bool ALFPOHOCKDE(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x00013268 File Offset: 0x00011468
		public int FPGCPBNLBCL(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle.CompareTo(LNBMEILJKDH.m_InputHandle);
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00013206 File Offset: 0x00011406
		public static bool AKABDJCLIAP(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t CJBLMHBFKIL(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00013283 File Offset: 0x00011483
		public static bool AKCGBMIACGD(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return InputHandle_t.PEKPHJBBIGP(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00013268 File Offset: 0x00011468
		public int ECEGOEPHPDF(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle.CompareTo(LNBMEILJKDH.m_InputHandle);
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t EFIDMFLMNJM(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong MDDPANGMIHL(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00013268 File Offset: 0x00011468
		public int BJHBCAGHIEA(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle.CompareTo(LNBMEILJKDH.m_InputHandle);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00013206 File Offset: 0x00011406
		public bool ADACHEBJFAE(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t NHFENIAGPGH(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00013206 File Offset: 0x00011406
		public static bool ANMCAPADKNB(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t FNGKLAHPAOB(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong GFMFFKFBOIA(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x0001328F File Offset: 0x0001148F
		public static bool GECOHHBDPGD(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return InputHandle_t.IBOCKEKAMCM(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00013268 File Offset: 0x00011468
		public int JHOEELHBEJJ(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle.CompareTo(LNBMEILJKDH.m_InputHandle);
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0001329B File Offset: 0x0001149B
		public static bool AKCKCACICKH(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return !InputHandle_t.FOPAIHBJEFL(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x000132A7 File Offset: 0x000114A7
		public static bool DFDJEKOGCDC(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return !InputHandle_t.MLKCDBHJOFC(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00013206 File Offset: 0x00011406
		public bool GNBMHLJHCNC(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00013268 File Offset: 0x00011468
		public int CompareTo(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle.CompareTo(LNBMEILJKDH.m_InputHandle);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00013206 File Offset: 0x00011406
		public static bool CAGEBEMJDMJ(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00013206 File Offset: 0x00011406
		public static bool MKGNKAMFMPG(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00013233 File Offset: 0x00011433
		public static bool JOCBDEADFOO(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return InputHandle_t.NFDGMMCNNMN(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong JMOHKKGFEAB(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0001329B File Offset: 0x0001149B
		public static bool LEAOCOAOLDK(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return !InputHandle_t.FOPAIHBJEFL(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong BPFLDKEBKED(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t IILDEMMMPHE(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong ECPEBBPPHMN(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t DJDKDNCPEIO(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t JPKEBFLFOIF(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00013206 File Offset: 0x00011406
		public static bool FMMPLDOGJKC(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x000132B3 File Offset: 0x000114B3
		public static bool LHHACIKDPOL(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return InputHandle_t.ALFPOHOCKDE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong BCNFICECAMF(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong BDDFEOKMDML(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong PEAFCMBIENC(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x000132BF File Offset: 0x000114BF
		public static bool DOELMPHIGAG(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return !InputHandle_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t KDMCDHGNCBF(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x000132CB File Offset: 0x000114CB
		public static bool PJAPLIAIDCM(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return InputHandle_t.IGDLLAKOACE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00013206 File Offset: 0x00011406
		public bool LBFHFGGCAJP(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong DBFCFFCHFLB(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x00013206 File Offset: 0x00011406
		public static bool EMFHKHOHCHK(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong JLMEKJCNHMJ(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00013268 File Offset: 0x00011468
		public int FEAMPHPBLDN(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle.CompareTo(LNBMEILJKDH.m_InputHandle);
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00013206 File Offset: 0x00011406
		public bool GFPAGHPGHHG(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x000132D7 File Offset: 0x000114D7
		public static bool PNPPOPMEIGG(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return InputHandle_t.AKABDJCLIAP(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t JMOIKGMJBJD(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t FEJNJFAMEOE(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000132E3 File Offset: 0x000114E3
		public override int GetHashCode()
		{
			return this.m_InputHandle.GetHashCode();
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x00013206 File Offset: 0x00011406
		public static bool CDNPFFJOFOM(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00013206 File Offset: 0x00011406
		public bool NNLBEINPECL(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x000132F0 File Offset: 0x000114F0
		public override string ToString()
		{
			return this.m_InputHandle.ToString();
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x00013206 File Offset: 0x00011406
		public static bool NFDGMMCNNMN(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t NFKIKJLFHBG(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x000132FD File Offset: 0x000114FD
		public static bool PALENFIECHL(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return !InputHandle_t.EMFHKHOHCHK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x000132B3 File Offset: 0x000114B3
		public static bool IMGNFFLCCIG(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return InputHandle_t.ALFPOHOCKDE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t LIDCAILIGIK(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00013206 File Offset: 0x00011406
		public bool KMGLKIINEPE(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00013206 File Offset: 0x00011406
		public static bool MLKCDBHJOFC(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong EENFFODLOCF(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00013206 File Offset: 0x00011406
		public bool BADPMBMDPIP(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00013309 File Offset: 0x00011509
		public static bool AONOBDMGABM(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return !InputHandle_t.IGDLLAKOACE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x00013315 File Offset: 0x00011515
		public static bool EIMCIEKFJDN(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return InputHandle_t.EMFHKHOHCHK(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00013206 File Offset: 0x00011406
		public bool OLIDABINOGH(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00013206 File Offset: 0x00011406
		public static bool IBOCKEKAMCM(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00013206 File Offset: 0x00011406
		public static bool KJIGDINCECD(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00013206 File Offset: 0x00011406
		public bool IHMHHKNBKKJ(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x00013206 File Offset: 0x00011406
		public bool CIAJOOGLMAG(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00013206 File Offset: 0x00011406
		public static bool NPLJHPCGBNH(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong LOEIJPMCCPF(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t PEAFCMBIENC(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t MFKKKOBBPNG(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong MPOEPCABICJ(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x00013206 File Offset: 0x00011406
		public static bool FOPAIHBJEFL(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t LLOCKDHOJBG(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00013206 File Offset: 0x00011406
		public bool EOKAGCFACDP(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00013206 File Offset: 0x00011406
		public static bool NFOOEHJIMCB(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00013268 File Offset: 0x00011468
		public int DIDNDFEIIPI(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle.CompareTo(LNBMEILJKDH.m_InputHandle);
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00013268 File Offset: 0x00011468
		public int PCPOOFNGNMC(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle.CompareTo(LNBMEILJKDH.m_InputHandle);
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00013268 File Offset: 0x00011468
		public int NAIBHAPJOKA(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle.CompareTo(LNBMEILJKDH.m_InputHandle);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t CNPAFOGFAIM(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong OEFDMNAIJAE(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00013206 File Offset: 0x00011406
		public bool Equals(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00013206 File Offset: 0x00011406
		public bool CCLPOCKCEFC(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00013206 File Offset: 0x00011406
		public bool DEJOOBGLHCH(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x000132CB File Offset: 0x000114CB
		public static bool IOALMFOPPJI(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return InputHandle_t.IGDLLAKOACE(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t OFOPKGCKJMB(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong ECPDGDCBJOL(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00013206 File Offset: 0x00011406
		public static bool NMOCADNHGKO(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return OBNBCGOIMKE.m_InputHandle == DEJFBNMNMOK.m_InputHandle;
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00013268 File Offset: 0x00011468
		public int GENCLGDMCPM(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle.CompareTo(LNBMEILJKDH.m_InputHandle);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00013206 File Offset: 0x00011406
		public bool NEMCANGLGHM(InputHandle_t LNBMEILJKDH)
		{
			return this.m_InputHandle == LNBMEILJKDH.m_InputHandle;
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong LHKLDDEFGFE(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong PKJMBHJMNGD(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0001327B File Offset: 0x0001147B
		public static InputHandle_t FNJIHAPANFK(ulong AJLPALFJHCC)
		{
			return new InputHandle_t(AJLPALFJHCC);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000132BF File Offset: 0x000114BF
		public static bool NEFGNGBGAJI(InputHandle_t OBNBCGOIMKE, InputHandle_t DEJFBNMNMOK)
		{
			return !InputHandle_t.MKGNKAMFMPG(OBNBCGOIMKE, DEJFBNMNMOK);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0001323F File Offset: 0x0001143F
		public static ulong GGOHAPLJANG(InputHandle_t MECNHBOFHJB)
		{
			return MECNHBOFHJB.m_InputHandle;
		}

		// Token: 0x04000837 RID: 2103
		public ulong m_InputHandle;
	}
}
