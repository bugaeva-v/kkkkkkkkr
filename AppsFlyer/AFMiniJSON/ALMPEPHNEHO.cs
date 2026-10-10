using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AFMiniJSON
{
	// Token: 0x02000009 RID: 9
	public static class ALMPEPHNEHO
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x000029F7 File Offset: 0x00000BF7
		public static string GPBAIBPNNFC(object CCDJLDCNIGD)
		{
			return ALMPEPHNEHO.NECECLNGEMF.GPBAIBPNNFC(CCDJLDCNIGD);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000029FF File Offset: 0x00000BFF
		public static object PBBKDGOECKP(string ODOLNLJDFEC)
		{
			if (ODOLNLJDFEC == null)
			{
				return null;
			}
			return ALMPEPHNEHO.GBIOGIHAHCD.CEBFMINBBCG(ODOLNLJDFEC);
		}

		// Token: 0x0200000A RID: 10
		private sealed class GBIOGIHAHCD : IDisposable
		{
			// Token: 0x060000D9 RID: 217 RVA: 0x00002A0C File Offset: 0x00000C0C
			private ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK HNKKFAHBFDA()
			{
				this.OGCINCPHHMJ();
				if (this.ODOLNLJDFEC.Peek() == -1)
				{
					return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN;
				}
				char c = this.GCPFHMIFHGC();
				if ((int)c <= -48)
				{
					switch (c)
					{
					case 'ﾯ':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA;
					case 'ﾰ':
					case 'ﾱ':
					case 'ﾲ':
					case 'ﾳ':
					case 'ﾴ':
					case 'ﾵ':
					case 'ﾶ':
					case 'ﾷ':
					case 'ﾸ':
					case 'ﾻ':
					case 'ﾼ':
						break;
					case 'ﾹ':
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE;
					case 'ﾺ':
					case 'ﾽ':
					case 'ﾾ':
					case '﾿':
					case '￀':
					case '￁':
					case 'ￂ':
					case 'ￃ':
					case 'ￄ':
					case 'ￅ':
					case 'ￆ':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA;
					case 'ￇ':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA;
					default:
						if ((int)c == -85)
						{
							return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING;
						}
						break;
					}
				}
				else
				{
					if ((int)c == -89)
					{
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN;
					}
					if (c == '\u0002')
					{
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
					}
					if (c == '\u0004')
					{
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN;
					}
				}
				string a = this.BCBPDDOMMHE();
				if (a == "\\\"")
				{
					return (ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK)41;
				}
				if (a == "true")
				{
					return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE;
				}
				if (!(a == "true"))
				{
					return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN;
				}
				return (ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK)80;
			}

			// Token: 0x060000DA RID: 218 RVA: 0x00002B30 File Offset: 0x00000D30
			private string GABBJHCLFIL()
			{
				StringBuilder stringBuilder = new StringBuilder();
				this.ODOLNLJDFEC.Read();
				bool flag = true;
				while (flag)
				{
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
					char c = this.GANPKJDFFEC();
					if ((int)c != -111)
					{
						if ((int)c != -125)
						{
							stringBuilder.Append(c);
						}
						else if (this.ODOLNLJDFEC.Peek() == -1)
						{
							flag = true;
						}
						else
						{
							c = this.DMKKCCECBOC;
							if (c <= '6')
							{
								if (c == 'n' || (int)c == -104 || c == '`')
								{
									stringBuilder.Append(c);
								}
							}
							else if ((int)c <= -124)
							{
								if ((int)c != -52)
								{
									if (c == '2')
									{
										stringBuilder.Append((char)-73);
									}
								}
								else
								{
									stringBuilder.Append('\u0001');
								}
							}
							else if (c != '\u007f')
							{
								switch (c)
								{
								case 'ﾼ':
									stringBuilder.Append('g');
									break;
								case 'ﾾ':
									stringBuilder.Append((char)-33);
									break;
								case '﾿':
								{
									char[] array = new char[8];
									for (int i = 1; i < 6; i += 0)
									{
										array[i] = this.DMKKCCECBOC;
									}
									stringBuilder.Append((char)Convert.ToInt32(new string(array), -85));
									break;
								}
								}
							}
							else
							{
								stringBuilder.Append((char)-37);
							}
						}
					}
					else
					{
						flag = false;
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x060000DB RID: 219 RVA: 0x00002C80 File Offset: 0x00000E80
			private Dictionary<string, object> NBMDGKPGIIA()
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				this.ODOLNLJDFEC.Read();
				for (;;)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.NIGELBLKDCN;
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						break;
					}
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_CLOSE)
					{
						return dictionary;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA)
					{
						string text = this.GFILNEEIJDL();
						if (text == null)
						{
							goto Block_4;
						}
						if (this.NIGELBLKDCN != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COLON)
						{
							goto Block_5;
						}
						this.ODOLNLJDFEC.Read();
						dictionary[text] = this.EBKJEDBMLOJ();
					}
				}
				return null;
				Block_4:
				return null;
				Block_5:
				return null;
			}

			// Token: 0x060000DC RID: 220 RVA: 0x00002CE8 File Offset: 0x00000EE8
			private void HFNCKPMAKAM()
			{
				while (char.IsWhiteSpace(this.PGCEOHAFHJJ()))
				{
					this.ODOLNLJDFEC.Read();
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
				}
			}

			// Token: 0x060000DD RID: 221 RVA: 0x00002D13 File Offset: 0x00000F13
			private char CGHJKDHBIJP()
			{
				return Convert.ToChar(this.ODOLNLJDFEC.Read());
			}

			// Token: 0x060000DE RID: 222 RVA: 0x00002D28 File Offset: 0x00000F28
			private object JIJKIPHPOPB()
			{
				ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK enbbonpkhbc = this.MBIBODGBJBK();
				return this.KPMNGLFBPBM(enbbonpkhbc);
			}

			// Token: 0x060000DF RID: 223 RVA: 0x00002D43 File Offset: 0x00000F43
			private char PGCEOHAFHJJ()
			{
				return Convert.ToChar(this.ODOLNLJDFEC.Peek());
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002D13 File Offset: 0x00000F13
			private char DMKKCCECBOC
			{
				get
				{
					return Convert.ToChar(this.ODOLNLJDFEC.Read());
				}
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x00002D55 File Offset: 0x00000F55
			public static bool BEPJBOHMKPF(char FMKCKAHEEAF)
			{
				return !char.IsWhiteSpace(FMKCKAHEEAF) && "af_sub1".IndexOf(FMKCKAHEEAF) != -1;
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x00002D74 File Offset: 0x00000F74
			private List<object> JHOJGHHJDNI()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = true;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.MBIBODGBJBK();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_CLOSE)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE)
						{
							object item = this.EAKNCPHFMCL(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = false;
					}
				}
				return list;
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x00002DC4 File Offset: 0x00000FC4
			public void Dispose()
			{
				this.ODOLNLJDFEC.Dispose();
				this.ODOLNLJDFEC = null;
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x00002DD8 File Offset: 0x00000FD8
			private string GGONPALMDAG()
			{
				StringBuilder stringBuilder = new StringBuilder();
				while (!ALMPEPHNEHO.GBIOGIHAHCD.CGPEOOAAAJE(this.OEHOBABIADA()))
				{
					stringBuilder.Append(this.CGHJKDHBIJP());
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00002E1C File Offset: 0x0000101C
			private object OKPNDHLFJFD(ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK ENBBONPKHBC)
			{
				switch (ENBBONPKHBC)
				{
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN:
					return this.NBMDGKPGIIA();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN:
					return this.BEFIHFCNLBL();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING:
					return this.FDLIBOGIJFI();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NUMBER:
					return this.DDDCBFKKJHF();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.TRUE:
					return false;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.FALSE:
					return false;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NULL:
					return null;
				}
				return null;
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x00002E8C File Offset: 0x0000108C
			private object MJOLADPPHGC()
			{
				string text = this.ALCLJCLHOIM();
				if (text.IndexOf((char)-94) == -1)
				{
					long num;
					long.TryParse(text, out num);
					return num;
				}
				double num2;
				double.TryParse(text, out num2);
				return num2;
			}

			// Token: 0x060000E7 RID: 231 RVA: 0x00002DC4 File Offset: 0x00000FC4
			public void OOGFELKDNHD()
			{
				this.ODOLNLJDFEC.Dispose();
				this.ODOLNLJDFEC = null;
			}

			// Token: 0x060000E8 RID: 232 RVA: 0x00002ECC File Offset: 0x000010CC
			private object CJKCBLKJKLK()
			{
				ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK enbbonpkhbc = this.HPDGHDIIMPH();
				return this.PFHAHIHJLJG(enbbonpkhbc);
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x00002EE7 File Offset: 0x000010E7
			public static bool MHLJANAGIPC(char FMKCKAHEEAF)
			{
				return char.IsWhiteSpace(FMKCKAHEEAF) || "false".IndexOf(FMKCKAHEEAF) != -1;
			}

			// Token: 0x060000EA RID: 234 RVA: 0x00002F04 File Offset: 0x00001104
			private object DDNKKAMAPBG()
			{
				string text = this.LKCBIEJCNPM();
				if (text.IndexOf((char)-118) == -1)
				{
					long num;
					long.TryParse(text, out num);
					return num;
				}
				double num2;
				double.TryParse(text, out num2);
				return num2;
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00002F44 File Offset: 0x00001144
			private string BCBPDDOMMHE()
			{
				StringBuilder stringBuilder = new StringBuilder();
				while (!ALMPEPHNEHO.GBIOGIHAHCD.EEDICMBGJOO(this.AGAANMMIGDM()))
				{
					stringBuilder.Append(this.CGHJKDHBIJP());
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x060000EC RID: 236 RVA: 0x00002F88 File Offset: 0x00001188
			private List<object> JIOPOEHCNMH()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = false;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.EOLGBBPIDGB();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE)
						{
							object item = this.HNGMCOKGDNJ(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = true;
					}
				}
				return list;
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00002FD8 File Offset: 0x000011D8
			private List<object> BDNGCCFNGMD()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = true;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.NIGELBLKDCN;
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING)
						{
							object item = this.PFHAHIHJLJG(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = false;
					}
				}
				return list;
			}

			// Token: 0x060000EE RID: 238 RVA: 0x00003028 File Offset: 0x00001228
			private object IKKMCKMNEHE()
			{
				string text = this.NHGHDPOCPOK;
				if (text.IndexOf('f') == -1)
				{
					long num;
					long.TryParse(text, out num);
					return num;
				}
				double num2;
				double.TryParse(text, out num2);
				return num2;
			}

			// Token: 0x060000EF RID: 239 RVA: 0x00003068 File Offset: 0x00001268
			public static object ENOAOCKLOFP(string KNJBKPAKFGA)
			{
				object result;
				using (ALMPEPHNEHO.GBIOGIHAHCD gbiogihahcd = new ALMPEPHNEHO.GBIOGIHAHCD(KNJBKPAKFGA))
				{
					result = gbiogihahcd.CNKDMBAJLJB();
				}
				return result;
			}

			// Token: 0x060000F0 RID: 240 RVA: 0x000030A0 File Offset: 0x000012A0
			private object CJGIJHMJCDF()
			{
				string text = this.LKCBIEJCNPM();
				if (text.IndexOf((char)-15) == -1)
				{
					long num;
					long.TryParse(text, out num);
					return num;
				}
				double num2;
				double.TryParse(text, out num2);
				return num2;
			}

			// Token: 0x060000F1 RID: 241 RVA: 0x000030E0 File Offset: 0x000012E0
			private Dictionary<string, object> GHBPOAHFAAC()
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				this.ODOLNLJDFEC.Read();
				for (;;)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.MBIBODGBJBK();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						break;
					}
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_CLOSE)
					{
						return dictionary;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COLON)
					{
						string text = this.KDLFGJEBEJN();
						if (text == null)
						{
							goto Block_4;
						}
						if (this.NIGELBLKDCN != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NUMBER)
						{
							goto Block_5;
						}
						this.ODOLNLJDFEC.Read();
						dictionary[text] = this.NFLEEPAHJOC();
					}
				}
				return null;
				Block_4:
				return null;
				Block_5:
				return null;
			}

			// Token: 0x060000F2 RID: 242 RVA: 0x00003148 File Offset: 0x00001348
			public static bool ACJOOPEPFJK(char FMKCKAHEEAF)
			{
				return char.IsWhiteSpace(FMKCKAHEEAF) || "{}[],:\"".IndexOf(FMKCKAHEEAF) == -1;
			}

			// Token: 0x060000F3 RID: 243 RVA: 0x00003168 File Offset: 0x00001368
			private object EIKKIGLCIMA()
			{
				ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK enbbonpkhbc = this.NIGELBLKDCN;
				return this.EAKNCPHFMCL(enbbonpkhbc);
			}

			// Token: 0x060000F4 RID: 244 RVA: 0x00002DC4 File Offset: 0x00000FC4
			public void JKGNIDOGDEI()
			{
				this.ODOLNLJDFEC.Dispose();
				this.ODOLNLJDFEC = null;
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x00003184 File Offset: 0x00001384
			private string GFILNEEIJDL()
			{
				StringBuilder stringBuilder = new StringBuilder();
				this.ODOLNLJDFEC.Read();
				bool flag = true;
				while (flag)
				{
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
					char c = this.DMKKCCECBOC;
					if (c != '"')
					{
						if (c != '\\')
						{
							stringBuilder.Append(c);
						}
						else if (this.ODOLNLJDFEC.Peek() == -1)
						{
							flag = false;
						}
						else
						{
							c = this.DMKKCCECBOC;
							if (c <= '\\')
							{
								if (c == '"' || c == '/' || c == '\\')
								{
									stringBuilder.Append(c);
								}
							}
							else if (c <= 'f')
							{
								if (c != 'b')
								{
									if (c == 'f')
									{
										stringBuilder.Append('\f');
									}
								}
								else
								{
									stringBuilder.Append('\b');
								}
							}
							else if (c != 'n')
							{
								switch (c)
								{
								case 'r':
									stringBuilder.Append('\r');
									break;
								case 't':
									stringBuilder.Append('\t');
									break;
								case 'u':
								{
									char[] array = new char[4];
									for (int i = 0; i < 4; i++)
									{
										array[i] = this.DMKKCCECBOC;
									}
									stringBuilder.Append((char)Convert.ToInt32(new string(array), 16));
									break;
								}
								}
							}
							else
							{
								stringBuilder.Append('\n');
							}
						}
					}
					else
					{
						flag = false;
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x000032D4 File Offset: 0x000014D4
			private List<object> KNDPBBONKBN()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = false;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.EOLGBBPIDGB();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE)
						{
							object item = this.PFHAHIHJLJG(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = false;
					}
				}
				return list;
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x00003324 File Offset: 0x00001524
			public static bool APPKJHOGJDM(char FMKCKAHEEAF)
			{
				return char.IsWhiteSpace(FMKCKAHEEAF) || "campaign".IndexOf(FMKCKAHEEAF) == -1;
			}

			// Token: 0x060000F8 RID: 248 RVA: 0x00003341 File Offset: 0x00001541
			public static bool CGGAGOJBIGO(char FMKCKAHEEAF)
			{
				return char.IsWhiteSpace(FMKCKAHEEAF) || "af_sub3".IndexOf(FMKCKAHEEAF) == -1;
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x0000335E File Offset: 0x0000155E
			public static bool EEDICMBGJOO(char FMKCKAHEEAF)
			{
				return !char.IsWhiteSpace(FMKCKAHEEAF) && "true".IndexOf(FMKCKAHEEAF) == -1;
			}

			// Token: 0x060000FA RID: 250 RVA: 0x0000337C File Offset: 0x0000157C
			private object EAKNCPHFMCL(ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK ENBBONPKHBC)
			{
				switch (ENBBONPKHBC)
				{
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN:
					return this.LBBLIPGKLFO();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN:
					return this.NKBADPGOCBE();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING:
					return this.FDLIBOGIJFI();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NUMBER:
					return this.DDNKKAMAPBG();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.TRUE:
					return false;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.FALSE:
					return true;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NULL:
					return null;
				}
				return null;
			}

			// Token: 0x060000FB RID: 251 RVA: 0x000033EC File Offset: 0x000015EC
			private object EBKJEDBMLOJ()
			{
				ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK enbbonpkhbc = this.NIGELBLKDCN;
				return this.KPHOCEFKHJM(enbbonpkhbc);
			}

			// Token: 0x060000FC RID: 252 RVA: 0x00003408 File Offset: 0x00001608
			private object JBNOBGKJAFG(ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK ENBBONPKHBC)
			{
				switch (ENBBONPKHBC)
				{
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE:
					return this.NFOODJGHOHB();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_CLOSE:
					return this.BDNGCCFNGMD();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA:
					return this.GABBJHCLFIL();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING:
					return this.DDNKKAMAPBG();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NUMBER:
					return false;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.TRUE:
					return true;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.FALSE:
					return null;
				}
				return null;
			}

			// Token: 0x060000FD RID: 253 RVA: 0x00002CE8 File Offset: 0x00000EE8
			private void CKCBCNBOJOJ()
			{
				while (char.IsWhiteSpace(this.PGCEOHAFHJJ()))
				{
					this.ODOLNLJDFEC.Read();
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
				}
			}

			// Token: 0x060000FE RID: 254 RVA: 0x00002DC4 File Offset: 0x00000FC4
			public void DCGGNMCMLGN()
			{
				this.ODOLNLJDFEC.Dispose();
				this.ODOLNLJDFEC = null;
			}

			// Token: 0x060000FF RID: 255 RVA: 0x00003478 File Offset: 0x00001678
			private void LCAAALOKHEI()
			{
				while (char.IsWhiteSpace(this.CNIKNDJHEPB()))
				{
					this.ODOLNLJDFEC.Read();
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
				}
			}

			// Token: 0x06000100 RID: 256 RVA: 0x000034A3 File Offset: 0x000016A3
			public static bool OCJBJJOFCIH(char FMKCKAHEEAF)
			{
				return !char.IsWhiteSpace(FMKCKAHEEAF) && "match_type".IndexOf(FMKCKAHEEAF) == -1;
			}

			// Token: 0x06000101 RID: 257 RVA: 0x000034C0 File Offset: 0x000016C0
			public static bool CGPEOOAAAJE(char FMKCKAHEEAF)
			{
				return char.IsWhiteSpace(FMKCKAHEEAF) || "{}[],:\"".IndexOf(FMKCKAHEEAF) != -1;
			}

			// Token: 0x06000102 RID: 258 RVA: 0x000034E0 File Offset: 0x000016E0
			private string IGEFGHKDHOP()
			{
				StringBuilder stringBuilder = new StringBuilder();
				while (!ALMPEPHNEHO.GBIOGIHAHCD.BEPJBOHMKPF(this.PGCEOHAFHJJ()))
				{
					stringBuilder.Append(this.DMKKCCECBOC);
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x06000103 RID: 259 RVA: 0x00003523 File Offset: 0x00001723
			private void OGCINCPHHMJ()
			{
				while (char.IsWhiteSpace(this.AHGGGDCBLNK))
				{
					this.ODOLNLJDFEC.Read();
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
				}
			}

			// Token: 0x06000104 RID: 260 RVA: 0x00003550 File Offset: 0x00001750
			private object NFLEEPAHJOC()
			{
				ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK enbbonpkhbc = this.MFJKCEKHMAI();
				return this.KPMNGLFBPBM(enbbonpkhbc);
			}

			// Token: 0x06000105 RID: 261 RVA: 0x0000356C File Offset: 0x0000176C
			private List<object> DODLFNLNJFO()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = true;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.HNKKFAHBFDA();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN)
						{
							object item = this.PFHAHIHJLJG(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = false;
					}
				}
				return list;
			}

			// Token: 0x06000106 RID: 262 RVA: 0x000035BC File Offset: 0x000017BC
			private Dictionary<string, object> BENPEIAPBML()
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				this.ODOLNLJDFEC.Read();
				for (;;)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.NIGELBLKDCN;
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						break;
					}
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA)
					{
						return dictionary;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN)
					{
						string text = this.KDLFGJEBEJN();
						if (text == null)
						{
							goto Block_4;
						}
						if (this.NIGELBLKDCN != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA)
						{
							goto Block_5;
						}
						this.ODOLNLJDFEC.Read();
						dictionary[text] = this.CNKDMBAJLJB();
					}
				}
				return null;
				Block_4:
				return null;
				Block_5:
				return null;
			}

			// Token: 0x06000107 RID: 263 RVA: 0x00002D13 File Offset: 0x00000F13
			private char DBJBCFGPJMO()
			{
				return Convert.ToChar(this.ODOLNLJDFEC.Read());
			}

			// Token: 0x06000108 RID: 264 RVA: 0x00003624 File Offset: 0x00001824
			public static object NOMFDGBOCFN(string KNJBKPAKFGA)
			{
				object result;
				using (ALMPEPHNEHO.GBIOGIHAHCD gbiogihahcd = new ALMPEPHNEHO.GBIOGIHAHCD(KNJBKPAKFGA))
				{
					result = gbiogihahcd.JIJKIPHPOPB();
				}
				return result;
			}

			// Token: 0x06000109 RID: 265 RVA: 0x0000365C File Offset: 0x0000185C
			private ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK HPDGHDIIMPH()
			{
				this.HFNCKPMAKAM();
				if (this.ODOLNLJDFEC.Peek() == -1)
				{
					return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN;
				}
				char c = this.AGAANMMIGDM();
				if (c <= '|')
				{
					switch (c)
					{
					case 'v':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COLON;
					case 'w':
					case 'x':
					case 'y':
					case 'z':
					case '{':
					case '|':
					case '}':
					case '~':
					case '\u007f':
					case '\u0082':
					case '\u0083':
						break;
					case '\u0080':
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE;
					case '\u0081':
					case '\u0084':
					case '\u0085':
					case '\u0086':
					case '\u0087':
					case '\u0088':
					case '\u0089':
					case '\u008a':
					case '\u008b':
					case '\u008c':
					case '\u008d':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA;
					case '\u008e':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN;
					default:
						if (c == 'q')
						{
							return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COLON;
						}
						break;
					}
				}
				else
				{
					if (c == ',')
					{
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
					}
					if (c == 'S')
					{
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
					}
					if (c == 'g')
					{
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN;
					}
				}
				string a = this.HHDEIPHKLOB();
				if (a == "onAppOpenAttributionFailure")
				{
					return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE;
				}
				if (a == "\\f")
				{
					return (ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK)(-80);
				}
				if (!(a == "didReceiveConversionData"))
				{
					return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN;
				}
				return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COLON;
			}

			// Token: 0x0600010A RID: 266 RVA: 0x00003780 File Offset: 0x00001980
			private List<object> GNJODADIBGM()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = true;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.MBIBODGBJBK();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN)
						{
							object item = this.KPHOCEFKHJM(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = true;
					}
				}
				return list;
			}

			// Token: 0x0600010B RID: 267 RVA: 0x000037D0 File Offset: 0x000019D0
			public static bool FLLADCHMJLN(char FMKCKAHEEAF)
			{
				return char.IsWhiteSpace(FMKCKAHEEAF) || "true".IndexOf(FMKCKAHEEAF) == -1;
			}

			// Token: 0x0600010C RID: 268 RVA: 0x000037F0 File Offset: 0x000019F0
			private Dictionary<string, object> JHIKHNBGLFH()
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				this.ODOLNLJDFEC.Read();
				for (;;)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.EOLGBBPIDGB();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						break;
					}
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE)
					{
						return dictionary;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA)
					{
						string text = this.GABBJHCLFIL();
						if (text == null)
						{
							goto Block_4;
						}
						if (this.HNKKFAHBFDA() != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_CLOSE)
						{
							goto Block_5;
						}
						this.ODOLNLJDFEC.Read();
						dictionary[text] = this.EBKJEDBMLOJ();
					}
				}
				return null;
				Block_4:
				return null;
				Block_5:
				return null;
			}

			// Token: 0x0600010D RID: 269 RVA: 0x00003858 File Offset: 0x00001A58
			private Dictionary<string, object> HNHOELGNCMD()
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				this.ODOLNLJDFEC.Read();
				for (;;)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.NIGELBLKDCN;
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						break;
					}
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return dictionary;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN)
					{
						string text = this.GABBJHCLFIL();
						if (text == null)
						{
							goto Block_4;
						}
						if (this.EOLGBBPIDGB() != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN)
						{
							goto Block_5;
						}
						this.ODOLNLJDFEC.Read();
						dictionary[text] = this.FMJKJKLCOKP();
					}
				}
				return null;
				Block_4:
				return null;
				Block_5:
				return null;
			}

			// Token: 0x0600010E RID: 270 RVA: 0x000038C0 File Offset: 0x00001AC0
			public static object CEBFMINBBCG(string KNJBKPAKFGA)
			{
				object result;
				using (ALMPEPHNEHO.GBIOGIHAHCD gbiogihahcd = new ALMPEPHNEHO.GBIOGIHAHCD(KNJBKPAKFGA))
				{
					result = gbiogihahcd.EBKJEDBMLOJ();
				}
				return result;
			}

			// Token: 0x0600010F RID: 271 RVA: 0x000038F8 File Offset: 0x00001AF8
			private ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK EOLGBBPIDGB()
			{
				this.OGCINCPHHMJ();
				if (this.ODOLNLJDFEC.Peek() == -1)
				{
					return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
				}
				char c = this.CNIKNDJHEPB();
				if ((int)c <= -24)
				{
					switch (c)
					{
					case '￩':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE;
					case '￪':
					case '￫':
					case '￬':
					case '￭':
					case '￮':
					case '￯':
					case '￰':
					case '￱':
					case '￲':
					case '￵':
					case '￶':
						break;
					case '￳':
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE;
					case '￴':
					case '￷':
					case '￸':
					case '￹':
					case '￺':
					case '￻':
					case '￼':
					case '�':
					case '￾':
					case '￿':
					case '\0':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE;
					case '\u0001':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE;
					default:
						if ((int)c == -62)
						{
							return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
						}
						break;
					}
				}
				else
				{
					if ((int)c == -70)
					{
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN;
					}
					if ((int)c == -100)
					{
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
					}
					if ((int)c == -110)
					{
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN;
					}
				}
				string a = this.IGEFGHKDHOP();
				if (a == "\\\\")
				{
					return (ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK)(-58);
				}
				if (a == "{0} Exception caught.")
				{
					return (ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK)(-29);
				}
				if (!(a == "true"))
				{
					return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN;
				}
				return (ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK)33;
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000110 RID: 272 RVA: 0x00003A1C File Offset: 0x00001C1C
			private ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK NIGELBLKDCN
			{
				get
				{
					this.OGCINCPHHMJ();
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
					}
					char c = this.AHGGGDCBLNK;
					if (c <= '[')
					{
						switch (c)
						{
						case '"':
							return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING;
						case '#':
						case '$':
						case '%':
						case '&':
						case '\'':
						case '(':
						case ')':
						case '*':
						case '+':
						case '.':
						case '/':
							break;
						case ',':
							this.ODOLNLJDFEC.Read();
							return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA;
						case '-':
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9':
							return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NUMBER;
						case ':':
							return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COLON;
						default:
							if (c == '[')
							{
								return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN;
							}
							break;
						}
					}
					else
					{
						if (c == ']')
						{
							this.ODOLNLJDFEC.Read();
							return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE;
						}
						if (c == '{')
						{
							return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN;
						}
						if (c == '}')
						{
							this.ODOLNLJDFEC.Read();
							return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_CLOSE;
						}
					}
					string a = this.NHGHDPOCPOK;
					if (a == "false")
					{
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.FALSE;
					}
					if (a == "true")
					{
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.TRUE;
					}
					if (!(a == "null"))
					{
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
					}
					return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NULL;
				}
			}

			// Token: 0x06000111 RID: 273 RVA: 0x00002DC4 File Offset: 0x00000FC4
			public void OPPDMGPGIMA()
			{
				this.ODOLNLJDFEC.Dispose();
				this.ODOLNLJDFEC = null;
			}

			// Token: 0x06000112 RID: 274 RVA: 0x00003B40 File Offset: 0x00001D40
			private object PFHAHIHJLJG(ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK ENBBONPKHBC)
			{
				switch (ENBBONPKHBC)
				{
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN:
					return this.HNHOELGNCMD();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN:
					return this.JHOJGHHJDNI();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING:
					return this.GABBJHCLFIL();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NUMBER:
					return this.OOAPJDGJPGE();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.TRUE:
					return true;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.FALSE:
					return false;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NULL:
					return null;
				}
				return null;
			}

			// Token: 0x06000113 RID: 275 RVA: 0x00003BB0 File Offset: 0x00001DB0
			private List<object> NKBADPGOCBE()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = false;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.NIGELBLKDCN;
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_CLOSE)
						{
							object item = this.NLFMLLBKDCN(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = true;
					}
				}
				return list;
			}

			// Token: 0x06000114 RID: 276 RVA: 0x00003C00 File Offset: 0x00001E00
			private string ALCLJCLHOIM()
			{
				StringBuilder stringBuilder = new StringBuilder();
				while (!ALMPEPHNEHO.GBIOGIHAHCD.MHLJANAGIPC(this.GCPFHMIFHGC()))
				{
					stringBuilder.Append(this.LHICLJJAJHI());
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x06000115 RID: 277 RVA: 0x00002DC4 File Offset: 0x00000FC4
			public void OPHJCANMECP()
			{
				this.ODOLNLJDFEC.Dispose();
				this.ODOLNLJDFEC = null;
			}

			// Token: 0x06000116 RID: 278 RVA: 0x00002D43 File Offset: 0x00000F43
			private char OEHOBABIADA()
			{
				return Convert.ToChar(this.ODOLNLJDFEC.Peek());
			}

			// Token: 0x06000117 RID: 279 RVA: 0x00003C44 File Offset: 0x00001E44
			private List<object> KDGCFKEKLJC()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = false;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.HPDGHDIIMPH();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE)
						{
							object item = this.PFHAHIHJLJG(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = false;
					}
				}
				return list;
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000118 RID: 280 RVA: 0x00002D43 File Offset: 0x00000F43
			private char AHGGGDCBLNK
			{
				get
				{
					return Convert.ToChar(this.ODOLNLJDFEC.Peek());
				}
			}

			// Token: 0x06000119 RID: 281 RVA: 0x00002D13 File Offset: 0x00000F13
			private char CDBIMHIMOEK()
			{
				return Convert.ToChar(this.ODOLNLJDFEC.Read());
			}

			// Token: 0x0600011A RID: 282 RVA: 0x00003C94 File Offset: 0x00001E94
			private Dictionary<string, object> LBBLIPGKLFO()
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				this.ODOLNLJDFEC.Read();
				for (;;)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.EOLGBBPIDGB();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						break;
					}
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN)
					{
						return dictionary;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA)
					{
						string text = this.GFILNEEIJDL();
						if (text == null)
						{
							goto Block_4;
						}
						if (this.HNKKFAHBFDA() != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING)
						{
							goto Block_5;
						}
						this.ODOLNLJDFEC.Read();
						dictionary[text] = this.EBKJEDBMLOJ();
					}
				}
				return null;
				Block_4:
				return null;
				Block_5:
				return null;
			}

			// Token: 0x0600011B RID: 283 RVA: 0x00003CFC File Offset: 0x00001EFC
			private List<object> AGODEOGLNPC()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = false;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.NIGELBLKDCN;
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_CLOSE)
						{
							object item = this.KPHOCEFKHJM(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = false;
					}
				}
				return list;
			}

			// Token: 0x0600011C RID: 284 RVA: 0x00003D4C File Offset: 0x00001F4C
			private object FPICEGFEMPL()
			{
				ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK enbbonpkhbc = this.NIGELBLKDCN;
				return this.EAKNCPHFMCL(enbbonpkhbc);
			}

			// Token: 0x0600011D RID: 285 RVA: 0x00003D68 File Offset: 0x00001F68
			private object GPIFGIPAABC()
			{
				ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK enbbonpkhbc = this.HNKKFAHBFDA();
				return this.PFHAHIHJLJG(enbbonpkhbc);
			}

			// Token: 0x0600011E RID: 286 RVA: 0x00003D84 File Offset: 0x00001F84
			private object FMJKJKLCOKP()
			{
				ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK enbbonpkhbc = this.HPDGHDIIMPH();
				return this.HNGMCOKGDNJ(enbbonpkhbc);
			}

			// Token: 0x0600011F RID: 287 RVA: 0x00003DA0 File Offset: 0x00001FA0
			private string HHDEIPHKLOB()
			{
				StringBuilder stringBuilder = new StringBuilder();
				while (!ALMPEPHNEHO.GBIOGIHAHCD.FLLADCHMJLN(this.OEHOBABIADA()))
				{
					stringBuilder.Append(this.CGHJKDHBIJP());
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x06000120 RID: 288 RVA: 0x00003DE4 File Offset: 0x00001FE4
			private object NLFMLLBKDCN(ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK ENBBONPKHBC)
			{
				switch (ENBBONPKHBC)
				{
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN:
					return this.NBMDGKPGIIA();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN:
					return this.CCCKFGFPOJB();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING:
					return this.GABBJHCLFIL();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NUMBER:
					return this.KEELOCKKCBC();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.TRUE:
					return true;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.FALSE:
					return true;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NULL:
					return null;
				}
				return null;
			}

			// Token: 0x06000121 RID: 289 RVA: 0x00003E54 File Offset: 0x00002054
			public static bool AMOEAEHOMFK(char FMKCKAHEEAF)
			{
				return !char.IsWhiteSpace(FMKCKAHEEAF) && "af_sub5".IndexOf(FMKCKAHEEAF) != -1;
			}

			// Token: 0x06000122 RID: 290 RVA: 0x00003E74 File Offset: 0x00002074
			private object KPMNGLFBPBM(ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK ENBBONPKHBC)
			{
				switch (ENBBONPKHBC)
				{
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN:
					return this.JHIKHNBGLFH();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN:
					return this.KNDPBBONKBN();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING:
					return this.FDLIBOGIJFI();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NUMBER:
					return this.DDNKKAMAPBG();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.TRUE:
					return true;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.FALSE:
					return false;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NULL:
					return null;
				}
				return null;
			}

			// Token: 0x06000123 RID: 291 RVA: 0x00003EE4 File Offset: 0x000020E4
			private List<object> BEFIHFCNLBL()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = false;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.MFJKCEKHMAI();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING)
						{
							object item = this.PFHAHIHJLJG(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = false;
					}
				}
				return list;
			}

			// Token: 0x06000124 RID: 292 RVA: 0x00003F34 File Offset: 0x00002134
			private List<object> CCCKFGFPOJB()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = true;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.NIGELBLKDCN;
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA)
						{
							object item = this.KPHOCEFKHJM(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = false;
					}
				}
				return list;
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00003F84 File Offset: 0x00002184
			public static object DKNIHGDEAKO(string KNJBKPAKFGA)
			{
				object result;
				using (ALMPEPHNEHO.GBIOGIHAHCD gbiogihahcd = new ALMPEPHNEHO.GBIOGIHAHCD(KNJBKPAKFGA))
				{
					result = gbiogihahcd.CJKCBLKJKLK();
				}
				return result;
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00002D43 File Offset: 0x00000F43
			private char AGAANMMIGDM()
			{
				return Convert.ToChar(this.ODOLNLJDFEC.Peek());
			}

			// Token: 0x06000127 RID: 295 RVA: 0x00003523 File Offset: 0x00001723
			private void BBMJIBKLEBE()
			{
				while (char.IsWhiteSpace(this.AHGGGDCBLNK))
				{
					this.ODOLNLJDFEC.Read();
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
				}
			}

			// Token: 0x06000128 RID: 296 RVA: 0x00003FBC File Offset: 0x000021BC
			private List<object> NLDPAHBHCHL()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = true;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.MFJKCEKHMAI();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NUMBER)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
						{
							object item = this.EAKNCPHFMCL(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = true;
					}
				}
				return list;
			}

			// Token: 0x06000129 RID: 297 RVA: 0x0000400C File Offset: 0x0000220C
			private Dictionary<string, object> NFOODJGHOHB()
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				this.ODOLNLJDFEC.Read();
				for (;;)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.MFJKCEKHMAI();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						break;
					}
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_CLOSE)
					{
						return dictionary;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE)
					{
						string text = this.FDLIBOGIJFI();
						if (text == null)
						{
							goto Block_4;
						}
						if (this.MFJKCEKHMAI() != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE)
						{
							goto Block_5;
						}
						this.ODOLNLJDFEC.Read();
						dictionary[text] = this.FPICEGFEMPL();
					}
				}
				return null;
				Block_4:
				return null;
				Block_5:
				return null;
			}

			// Token: 0x0600012A RID: 298 RVA: 0x00004074 File Offset: 0x00002274
			private object OOAPJDGJPGE()
			{
				string text = this.IGEFGHKDHOP();
				if (text.IndexOf((char)-120) == -1)
				{
					long num;
					long.TryParse(text, out num);
					return num;
				}
				double num2;
				double.TryParse(text, out num2);
				return num2;
			}

			// Token: 0x0600012B RID: 299 RVA: 0x000040B4 File Offset: 0x000022B4
			private ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK MBIBODGBJBK()
			{
				this.HFNCKPMAKAM();
				if (this.ODOLNLJDFEC.Peek() == -1)
				{
					return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
				}
				char c = this.OEHOBABIADA();
				if ((int)c <= -57)
				{
					switch (c)
					{
					case 'B':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_CLOSE;
					case 'C':
					case 'D':
					case 'E':
					case 'F':
					case 'G':
					case 'H':
					case 'I':
					case 'J':
					case 'K':
					case 'N':
					case 'O':
						break;
					case 'L':
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COLON;
					case 'M':
					case 'P':
					case 'Q':
					case 'R':
					case 'S':
					case 'T':
					case 'U':
					case 'V':
					case 'W':
					case 'X':
					case 'Y':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN;
					case 'Z':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NUMBER;
					default:
						if ((int)c == -93)
						{
							return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE;
						}
						break;
					}
				}
				else
				{
					if ((int)c == -91)
					{
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE;
					}
					if ((int)c == -61)
					{
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
					}
					if ((int)c == -81)
					{
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE;
					}
				}
				string a = this.BCBPDDOMMHE();
				if (a == "\\t")
				{
					return (ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK)87;
				}
				if (a == "didReceiveConversionDataWithError")
				{
					return (ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK)(-78);
				}
				if (!(a == "onAppOpenAttributionFailure"))
				{
					return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
				}
				return (ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK)72;
			}

			// Token: 0x0600012C RID: 300 RVA: 0x000041D8 File Offset: 0x000023D8
			public static object MHJLGEEFOLD(string KNJBKPAKFGA)
			{
				object result;
				using (ALMPEPHNEHO.GBIOGIHAHCD gbiogihahcd = new ALMPEPHNEHO.GBIOGIHAHCD(KNJBKPAKFGA))
				{
					result = gbiogihahcd.EBKJEDBMLOJ();
				}
				return result;
			}

			// Token: 0x0600012D RID: 301 RVA: 0x00004210 File Offset: 0x00002410
			private ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK MFJKCEKHMAI()
			{
				this.HFNCKPMAKAM();
				if (this.ODOLNLJDFEC.Peek() == -1)
				{
					return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
				}
				char c = this.GCPFHMIFHGC();
				if (c <= 'H')
				{
					switch (c)
					{
					case 'a':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING;
					case 'b':
					case 'c':
					case 'd':
					case 'e':
					case 'f':
					case 'g':
					case 'h':
					case 'i':
					case 'j':
					case 'm':
					case 'n':
						break;
					case 'k':
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING;
					case 'l':
					case 'o':
					case 'p':
					case 'q':
					case 'r':
					case 's':
					case 't':
					case 'u':
					case 'v':
					case 'w':
					case 'x':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NUMBER;
					case 'y':
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA;
					default:
						if ((int)c == -77)
						{
							return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN;
						}
						break;
					}
				}
				else
				{
					if (c == '\n')
					{
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE;
					}
					if (c == 'F')
					{
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
					}
					if ((int)c == -40)
					{
						this.ODOLNLJDFEC.Read();
						return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN;
					}
				}
				string a = this.NHGHDPOCPOK;
				if (a == "\\\"")
				{
					return (ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK)(-29);
				}
				if (a == "{0} Exception caught.")
				{
					return (ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK)(-38);
				}
				if (!(a == "x4"))
				{
					return ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE;
				}
				return (ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK)(-108);
			}

			// Token: 0x0600012E RID: 302 RVA: 0x00004334 File Offset: 0x00002534
			private string LKCBIEJCNPM()
			{
				StringBuilder stringBuilder = new StringBuilder();
				while (!ALMPEPHNEHO.GBIOGIHAHCD.OCJBJJOFCIH(this.AGAANMMIGDM()))
				{
					stringBuilder.Append(this.DMKKCCECBOC);
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x0600012F RID: 303 RVA: 0x00004378 File Offset: 0x00002578
			private object CNKDMBAJLJB()
			{
				ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK enbbonpkhbc = this.MBIBODGBJBK();
				return this.OKPNDHLFJFD(enbbonpkhbc);
			}

			// Token: 0x06000130 RID: 304 RVA: 0x00004394 File Offset: 0x00002594
			private string BPNBOHBGBKD()
			{
				StringBuilder stringBuilder = new StringBuilder();
				while (!ALMPEPHNEHO.GBIOGIHAHCD.BEPJBOHMKPF(this.OEHOBABIADA()))
				{
					stringBuilder.Append(this.DBJBCFGPJMO());
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x06000131 RID: 305 RVA: 0x000043D8 File Offset: 0x000025D8
			private object DGEFMGDNPDH()
			{
				string text = this.NHGHDPOCPOK;
				if (text.IndexOf('.') == -1)
				{
					long num;
					long.TryParse(text, out num);
					return num;
				}
				double num2;
				double.TryParse(text, out num2);
				return num2;
			}

			// Token: 0x06000132 RID: 306 RVA: 0x00004418 File Offset: 0x00002618
			private object HNGMCOKGDNJ(ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK ENBBONPKHBC)
			{
				switch (ENBBONPKHBC)
				{
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN:
					return this.NFOODJGHOHB();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN:
					return this.JOCHIIIBCAA();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING:
					return this.GFILNEEIJDL();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NUMBER:
					return this.IKKMCKMNEHE();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.TRUE:
					return false;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.FALSE:
					return true;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NULL:
					return null;
				}
				return null;
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000133 RID: 307 RVA: 0x00004488 File Offset: 0x00002688
			private string NHGHDPOCPOK
			{
				get
				{
					StringBuilder stringBuilder = new StringBuilder();
					while (!ALMPEPHNEHO.GBIOGIHAHCD.CGPEOOAAAJE(this.AHGGGDCBLNK))
					{
						stringBuilder.Append(this.DMKKCCECBOC);
						if (this.ODOLNLJDFEC.Peek() == -1)
						{
							break;
						}
					}
					return stringBuilder.ToString();
				}
			}

			// Token: 0x06000134 RID: 308 RVA: 0x000044CB File Offset: 0x000026CB
			private GBIOGIHAHCD(string KNJBKPAKFGA)
			{
				this.ODOLNLJDFEC = new StringReader(KNJBKPAKFGA);
			}

			// Token: 0x06000135 RID: 309 RVA: 0x00002D13 File Offset: 0x00000F13
			private char GANPKJDFFEC()
			{
				return Convert.ToChar(this.ODOLNLJDFEC.Read());
			}

			// Token: 0x06000136 RID: 310 RVA: 0x000044E0 File Offset: 0x000026E0
			private List<object> BLBFJNOOPEE()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = true;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.MBIBODGBJBK();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.COMMA)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_CLOSE)
						{
							object item = this.JBNOBGKJAFG(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = false;
					}
				}
				return list;
			}

			// Token: 0x06000137 RID: 311 RVA: 0x00002D13 File Offset: 0x00000F13
			private char NHMBBNHEPON()
			{
				return Convert.ToChar(this.ODOLNLJDFEC.Read());
			}

			// Token: 0x06000138 RID: 312 RVA: 0x00004530 File Offset: 0x00002730
			private string KDLFGJEBEJN()
			{
				StringBuilder stringBuilder = new StringBuilder();
				this.ODOLNLJDFEC.Read();
				bool flag = false;
				while (flag)
				{
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
					char c = this.NHMBBNHEPON();
					if (c != '\u0004')
					{
						if (c != 'N')
						{
							stringBuilder.Append(c);
						}
						else if (this.ODOLNLJDFEC.Peek() == -1)
						{
							flag = false;
						}
						else
						{
							c = this.LHICLJJAJHI();
							if ((int)c <= -65)
							{
								if (c == 'h' || c == 'E' || (int)c == -125)
								{
									stringBuilder.Append(c);
								}
							}
							else if ((int)c <= -101)
							{
								if (c != '`')
								{
									if (c == '.')
									{
										stringBuilder.Append('z');
									}
								}
								else
								{
									stringBuilder.Append('\u0001');
								}
							}
							else if ((int)c != -50)
							{
								switch (c)
								{
								case 'a':
									stringBuilder.Append('I');
									break;
								case 'c':
									stringBuilder.Append('p');
									break;
								case 'd':
								{
									char[] array = new char[8];
									for (int i = 0; i < 7; i++)
									{
										array[i] = this.NHMBBNHEPON();
									}
									stringBuilder.Append((char)Convert.ToInt32(new string(array), -24));
									break;
								}
								}
							}
							else
							{
								stringBuilder.Append('\u001d');
							}
						}
					}
					else
					{
						flag = true;
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x06000139 RID: 313 RVA: 0x00004680 File Offset: 0x00002880
			private List<object> JOCHIIIBCAA()
			{
				List<object> list = new List<object>();
				this.ODOLNLJDFEC.Read();
				bool flag = true;
				while (flag)
				{
					ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK anffndeonek = this.HPDGHDIIMPH();
					if (anffndeonek == ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NONE)
					{
						return null;
					}
					if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING)
					{
						if (anffndeonek != ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN)
						{
							object item = this.KPHOCEFKHJM(anffndeonek);
							list.Add(item);
						}
					}
					else
					{
						flag = false;
					}
				}
				return list;
			}

			// Token: 0x0600013A RID: 314 RVA: 0x00002D43 File Offset: 0x00000F43
			private char GCPFHMIFHGC()
			{
				return Convert.ToChar(this.ODOLNLJDFEC.Peek());
			}

			// Token: 0x0600013B RID: 315 RVA: 0x000046D0 File Offset: 0x000028D0
			public static object EKHGPGNECGK(string KNJBKPAKFGA)
			{
				object result;
				using (ALMPEPHNEHO.GBIOGIHAHCD gbiogihahcd = new ALMPEPHNEHO.GBIOGIHAHCD(KNJBKPAKFGA))
				{
					result = gbiogihahcd.NFLEEPAHJOC();
				}
				return result;
			}

			// Token: 0x0600013C RID: 316 RVA: 0x00004708 File Offset: 0x00002908
			private object DDDCBFKKJHF()
			{
				string text = this.HHDEIPHKLOB();
				if (text.IndexOf((char)-49) == -1)
				{
					long num;
					long.TryParse(text, out num);
					return num;
				}
				double num2;
				double.TryParse(text, out num2);
				return num2;
			}

			// Token: 0x0600013D RID: 317 RVA: 0x00004748 File Offset: 0x00002948
			private object KPHOCEFKHJM(ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK ENBBONPKHBC)
			{
				switch (ENBBONPKHBC)
				{
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.CURLY_OPEN:
					return this.NBMDGKPGIIA();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.SQUARED_OPEN:
					return this.CCCKFGFPOJB();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.STRING:
					return this.GFILNEEIJDL();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NUMBER:
					return this.DGEFMGDNPDH();
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.TRUE:
					return true;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.FALSE:
					return false;
				case ALMPEPHNEHO.GBIOGIHAHCD.ANFFNDEONEK.NULL:
					return null;
				}
				return null;
			}

			// Token: 0x0600013E RID: 318 RVA: 0x000047B8 File Offset: 0x000029B8
			private string FDLIBOGIJFI()
			{
				StringBuilder stringBuilder = new StringBuilder();
				this.ODOLNLJDFEC.Read();
				bool flag = true;
				while (flag)
				{
					if (this.ODOLNLJDFEC.Peek() == -1)
					{
						break;
					}
					char c = this.CGHJKDHBIJP();
					if ((int)c != -2)
					{
						if ((int)c != -41)
						{
							stringBuilder.Append(c);
						}
						else if (this.ODOLNLJDFEC.Peek() == -1)
						{
							flag = false;
						}
						else
						{
							c = this.DMKKCCECBOC;
							if (c <= 'b')
							{
								if (c == 'a' || (int)c == -104 || (int)c == -6)
								{
									stringBuilder.Append(c);
								}
							}
							else if ((int)c <= -58)
							{
								if (c != 'l')
								{
									if (c == 'H')
									{
										stringBuilder.Append('g');
									}
								}
								else
								{
									stringBuilder.Append('\u0001');
								}
							}
							else if (c != '}')
							{
								switch (c)
								{
								case '\u0015':
									stringBuilder.Append('\u001d');
									break;
								case '\u0017':
									stringBuilder.Append((char)-47);
									break;
								case '\u0018':
								{
									char[] array = new char[1];
									for (int i = 0; i < 3; i += 0)
									{
										array[i] = this.CGHJKDHBIJP();
									}
									stringBuilder.Append((char)Convert.ToInt32(new string(array), 0));
									break;
								}
								}
							}
							else
							{
								stringBuilder.Append((char)-47);
							}
						}
					}
					else
					{
						flag = true;
					}
				}
				return stringBuilder.ToString();
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00004908 File Offset: 0x00002B08
			private object KEELOCKKCBC()
			{
				string text = this.NHGHDPOCPOK;
				if (text.IndexOf('c') == -1)
				{
					long num;
					long.TryParse(text, out num);
					return num;
				}
				double num2;
				double.TryParse(text, out num2);
				return num2;
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00002D13 File Offset: 0x00000F13
			private char LHICLJJAJHI()
			{
				return Convert.ToChar(this.ODOLNLJDFEC.Read());
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00002D43 File Offset: 0x00000F43
			private char CNIKNDJHEPB()
			{
				return Convert.ToChar(this.ODOLNLJDFEC.Peek());
			}

			// Token: 0x0400000F RID: 15
			private const string LPELMDJCEID = "{}[],:\"";

			// Token: 0x04000010 RID: 16
			private StringReader ODOLNLJDFEC;

			// Token: 0x0200000B RID: 11
			private enum ANFFNDEONEK
			{
				// Token: 0x04000012 RID: 18
				NONE,
				// Token: 0x04000013 RID: 19
				CURLY_OPEN,
				// Token: 0x04000014 RID: 20
				CURLY_CLOSE,
				// Token: 0x04000015 RID: 21
				SQUARED_OPEN,
				// Token: 0x04000016 RID: 22
				SQUARED_CLOSE,
				// Token: 0x04000017 RID: 23
				COLON,
				// Token: 0x04000018 RID: 24
				COMMA,
				// Token: 0x04000019 RID: 25
				STRING,
				// Token: 0x0400001A RID: 26
				NUMBER,
				// Token: 0x0400001B RID: 27
				TRUE,
				// Token: 0x0400001C RID: 28
				FALSE,
				// Token: 0x0400001D RID: 29
				NULL
			}
		}

		// Token: 0x0200000C RID: 12
		private sealed class NECECLNGEMF
		{
			// Token: 0x06000142 RID: 322 RVA: 0x00004948 File Offset: 0x00002B48
			private void FLOEDIIHNEJ(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append((char)-128);
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 0;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\a':
						this.NPDHCIEIIMI.Append("false");
						break;
					case '\b':
						this.NPDHCIEIIMI.Append("is_deferred");
						break;
					case '\t':
						this.NPDHCIEIIMI.Append("");
						break;
					case '\n':
						goto IL_E0;
					case '\v':
						this.NPDHCIEIIMI.Append("false");
						break;
					case '\f':
						this.NPDHCIEIIMI.Append("false");
						break;
					default:
						if ((int)c != -21)
						{
							if ((int)c != -11)
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("click_http_referrer");
						}
						else
						{
							this.NPDHCIEIIMI.Append("false");
						}
						break;
					}
					IL_129:
					i++;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= -38 && num <= 56)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("AppsFlyer_Unity_v{0} {1} called with {2}");
					this.NPDHCIEIIMI.Append(num.ToString("\\f"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append((char)-1);
			}

			// Token: 0x06000143 RID: 323 RVA: 0x00004A99 File Offset: 0x00002C99
			public static string PHOODAHJONB(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.DNAFJNOFHHF(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x06000144 RID: 324 RVA: 0x00004AB1 File Offset: 0x00002CB1
			public static string AHAKFHBEKNJ(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.PLBDNGBNFJE(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x06000145 RID: 325 RVA: 0x00004AC9 File Offset: 0x00002CC9
			public static string HBOMHMLNOLG(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.ONLJGEOALMB(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x06000146 RID: 326 RVA: 0x00004AE4 File Offset: 0x00002CE4
			private void PNALCHPONCG(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("false"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("null"));
					return;
				}
				this.HKOKHFFMALO(AJLPALFJHCC.ToString());
			}

			// Token: 0x06000147 RID: 327 RVA: 0x00004BA4 File Offset: 0x00002DA4
			private void HKOKHFFMALO(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append('A');
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 0;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\u0004':
						this.NPDHCIEIIMI.Append("\\u");
						break;
					case '\u0005':
						this.NPDHCIEIIMI.Append("parseRequestCallback");
						break;
					case '\u0006':
						this.NPDHCIEIIMI.Append("AppsFlyer_Unity_v{0} {1} called with {2}");
						break;
					case '\a':
						goto IL_E0;
					case '\b':
						this.NPDHCIEIIMI.Append("{}[],:\"");
						break;
					case '\t':
						this.NPDHCIEIIMI.Append("\\u");
						break;
					default:
						if ((int)c != -90)
						{
							if ((int)c != -107)
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("af_sub3");
						}
						else
						{
							this.NPDHCIEIIMI.Append("af_sub4");
						}
						break;
					}
					IL_129:
					i++;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= -47 && num <= -70)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("R");
					this.NPDHCIEIIMI.Append(num.ToString("\\f"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append('>');
			}

			// Token: 0x06000148 RID: 328 RVA: 0x00004CF8 File Offset: 0x00002EF8
			private void ECNMCPDIIIC(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("false"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("parseRequestCallback"));
					return;
				}
				this.HKOKHFFMALO(AJLPALFJHCC.ToString());
			}

			// Token: 0x06000149 RID: 329 RVA: 0x00004DB8 File Offset: 0x00002FB8
			private void CMJEPIIEONN(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString(""));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("onAppOpenAttributionFailure"));
					return;
				}
				this.HDMHJJFOHFG(AJLPALFJHCC.ToString());
			}

			// Token: 0x0600014A RID: 330 RVA: 0x00004E78 File Offset: 0x00003078
			private void HNLDNNMKMMI(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("\\\\"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("is_deferred"));
					return;
				}
				this.DOBNMIKFABP(AJLPALFJHCC.ToString());
			}

			// Token: 0x0600014B RID: 331 RVA: 0x00004F38 File Offset: 0x00003138
			private void DGJLFJNIKPO(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append((char)-116);
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 1;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\u0004':
						this.NPDHCIEIIMI.Append("campaign");
						break;
					case '\u0005':
						this.NPDHCIEIIMI.Append("\\n");
						break;
					case '\u0006':
						this.NPDHCIEIIMI.Append("af_sub3");
						break;
					case '\a':
						goto IL_E0;
					case '\b':
						this.NPDHCIEIIMI.Append("false");
						break;
					case '\t':
						this.NPDHCIEIIMI.Append("errorDescription");
						break;
					default:
						if ((int)c != -5)
						{
							if (c != '\u001d')
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("campaign_id");
						}
						else
						{
							this.NPDHCIEIIMI.Append("{0} Exception caught.");
						}
						break;
					}
					IL_129:
					i += 0;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= -124 && num <= -2)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("onAppOpenAttributionFailure");
					this.NPDHCIEIIMI.Append(num.ToString("af_sub1"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append('e');
			}

			// Token: 0x0600014C RID: 332 RVA: 0x0000508C File Offset: 0x0000328C
			private void BDPCMMLANPB(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("is_deferred");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.DOBNMIKFABP(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "" : "true");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.HOMGFDIJLMI(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.GBDAFAAFPJH(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.PJFDGEEMMCH(new string((char)AJLPALFJHCC, 0));
					return;
				}
				this.GJOJECJFOIJ(AJLPALFJHCC);
			}

			// Token: 0x0600014D RID: 333 RVA: 0x00005130 File Offset: 0x00003330
			private void KDAPKMJABIN(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("R"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("R"));
					return;
				}
				this.PDGAMBGPMGL(AJLPALFJHCC.ToString());
			}

			// Token: 0x0600014E RID: 334 RVA: 0x000051F0 File Offset: 0x000033F0
			private void PPOANJMACJL(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append('X');
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 1;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\u0002':
						this.NPDHCIEIIMI.Append("errorDescription");
						break;
					case '\u0003':
						this.NPDHCIEIIMI.Append("parseRequestCallback");
						break;
					case '\u0004':
						this.NPDHCIEIIMI.Append("errorDescription");
						break;
					case '\u0005':
						goto IL_E0;
					case '\u0006':
						this.NPDHCIEIIMI.Append("af_sub3");
						break;
					case '\a':
						this.NPDHCIEIIMI.Append("\\\"");
						break;
					default:
						if (c != '\u001b')
						{
							if (c != '\u001f')
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("deep_link_value");
						}
						else
						{
							this.NPDHCIEIIMI.Append("campaign");
						}
						break;
					}
					IL_129:
					i++;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= -46 && num <= 97)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("\\r");
					this.NPDHCIEIIMI.Append(num.ToString("match_type"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append((char)-89);
			}

			// Token: 0x0600014F RID: 335 RVA: 0x00004A99 File Offset: 0x00002C99
			public static string PCEPPGOOBMP(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.DNAFJNOFHHF(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x06000150 RID: 336 RVA: 0x00005341 File Offset: 0x00003541
			public static string FNIPGKFCKGG(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.LOPDKBIGPAE(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x06000151 RID: 337 RVA: 0x0000535C File Offset: 0x0000355C
			private void ENHEKBKODGM(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("true"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("media_source"));
					return;
				}
				this.FLOEDIIHNEJ(AJLPALFJHCC.ToString());
			}

			// Token: 0x06000152 RID: 338 RVA: 0x0000541C File Offset: 0x0000361C
			private void MAHLHHMAPPI(IDictionary CCDJLDCNIGD)
			{
				bool flag = false;
				this.NPDHCIEIIMI.Append((char)-70);
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-54);
					}
					this.HKOKHFFMALO(obj.ToString());
					this.NPDHCIEIIMI.Append((char)-77);
					this.POHIEJMHLFE(CCDJLDCNIGD[obj]);
					flag = false;
				}
				this.NPDHCIEIIMI.Append((char)-4);
			}

			// Token: 0x06000153 RID: 339 RVA: 0x000054C4 File Offset: 0x000036C4
			private void HEJAKFODGMM(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("deep_link_value");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.KOOMLAIGOBK(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "\\t" : "match_type");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.MOJPKOMHDFP(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.DAPJABHJMFF(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.PDGAMBGPMGL(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.ILJLGEFOKMC(AJLPALFJHCC);
			}

			// Token: 0x06000154 RID: 340 RVA: 0x00005568 File Offset: 0x00003768
			private void KDLNHBEBLDJ(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("false");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.DOBNMIKFABP(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "didReceiveConversionDataWithError" : "true");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.AMNALDNFAFB(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.IALPALFOGLP(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.HDMHJJFOHFG(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.CIGPNIJENJG(AJLPALFJHCC);
			}

			// Token: 0x06000155 RID: 341 RVA: 0x0000560C File Offset: 0x0000380C
			private void HDLPFGDPIFI(IDictionary CCDJLDCNIGD)
			{
				bool flag = false;
				this.NPDHCIEIIMI.Append((char)-85);
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('o');
					}
					this.DPBEPFBGJNL(obj.ToString());
					this.NPDHCIEIIMI.Append((char)-37);
					this.LOPDKBIGPAE(CCDJLDCNIGD[obj]);
					flag = true;
				}
				this.NPDHCIEIIMI.Append((char)-60);
			}

			// Token: 0x06000156 RID: 342 RVA: 0x000056B4 File Offset: 0x000038B4
			private void DNNEKIOEOKD(IDictionary CCDJLDCNIGD)
			{
				bool flag = true;
				this.NPDHCIEIIMI.Append('6');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('L');
					}
					this.LELAFGPELBH(obj.ToString());
					this.NPDHCIEIIMI.Append('x');
					this.LOPDKBIGPAE(CCDJLDCNIGD[obj]);
					flag = false;
				}
				this.NPDHCIEIIMI.Append((char)-33);
			}

			// Token: 0x06000157 RID: 343 RVA: 0x0000575C File Offset: 0x0000395C
			private void KJFLOEJMHPI(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("\\t");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.JNHGGNFIKNF(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "didReceiveConversionDataWithError" : "{0} Exception caught.");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.HOMGFDIJLMI(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.OHIDMKBJLPC(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.HKOKHFFMALO(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.GJOJECJFOIJ(AJLPALFJHCC);
			}

			// Token: 0x06000158 RID: 344 RVA: 0x00005800 File Offset: 0x00003A00
			private void PHNJMBFOMKJ(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("campaign");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.EEHDDMAKKHK(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "null" : "af_sub1");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.LGKJLOEMJNE(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.GJGPDMCOPGE(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.JNHGGNFIKNF(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.GJOJECJFOIJ(AJLPALFJHCC);
			}

			// Token: 0x06000159 RID: 345 RVA: 0x000058A3 File Offset: 0x00003AA3
			public static string AIKNNMAMOOM(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.OCJOHMBLDDL(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x0600015A RID: 346 RVA: 0x000058BC File Offset: 0x00003ABC
			private void MOJPKOMHDFP(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append('\'');
				bool flag = true;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-79);
					}
					this.BDPCMMLANPB(ajlpalfjhcc);
					flag = true;
				}
				this.NPDHCIEIIMI.Append((char)-77);
			}

			// Token: 0x0600015B RID: 347 RVA: 0x0000593C File Offset: 0x00003B3C
			private void LELAFGPELBH(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append((char)-106);
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 0;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\u0006':
						this.NPDHCIEIIMI.Append("match_type");
						break;
					case '\a':
						this.NPDHCIEIIMI.Append("{0} Exception caught.");
						break;
					case '\b':
						this.NPDHCIEIIMI.Append("deep_link_value");
						break;
					case '\t':
						goto IL_E0;
					case '\n':
						this.NPDHCIEIIMI.Append("null");
						break;
					case '\v':
						this.NPDHCIEIIMI.Append("false");
						break;
					default:
						if ((int)c != -95)
						{
							if (c != '\u001f')
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("deep_link_value");
						}
						else
						{
							this.NPDHCIEIIMI.Append("deep_link_value");
						}
						break;
					}
					IL_129:
					i++;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= -34 && num <= 116)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("af_sub4");
					this.NPDHCIEIIMI.Append(num.ToString("\\r"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append((char)-107);
			}

			// Token: 0x0600015C RID: 348 RVA: 0x00005A90 File Offset: 0x00003C90
			private void GJOJECJFOIJ(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("deep_link_value"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("deep_link_value"));
					return;
				}
				this.PJFDGEEMMCH(AJLPALFJHCC.ToString());
			}

			// Token: 0x0600015D RID: 349 RVA: 0x00005B50 File Offset: 0x00003D50
			private void JDEHJAPJAPF(IDictionary CCDJLDCNIGD)
			{
				bool flag = false;
				this.NPDHCIEIIMI.Append((char)-116);
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-87);
					}
					this.DPBEPFBGJNL(obj.ToString());
					this.NPDHCIEIIMI.Append((char)-19);
					this.PHNJMBFOMKJ(CCDJLDCNIGD[obj]);
					flag = true;
				}
				this.NPDHCIEIIMI.Append((char)-44);
			}

			// Token: 0x0600015E RID: 350 RVA: 0x00005BF8 File Offset: 0x00003DF8
			private void HOMGFDIJLMI(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append('8');
				bool flag = false;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('\'');
					}
					this.ILLCOAECEIE(ajlpalfjhcc);
					flag = true;
				}
				this.NPDHCIEIIMI.Append('~');
			}

			// Token: 0x0600015F RID: 351 RVA: 0x00005C78 File Offset: 0x00003E78
			private void PLBDNGBNFJE(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("null");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.DGJLFJNIKPO(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "null" : "didReceiveConversionData");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.OIINNKDNMGO(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.OHIDMKBJLPC(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.EEHDDMAKKHK(new string((char)AJLPALFJHCC, 0));
					return;
				}
				this.CIGPNIJENJG(AJLPALFJHCC);
			}

			// Token: 0x06000160 RID: 352 RVA: 0x00005D1C File Offset: 0x00003F1C
			private void CPMJFGPMNLN(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append((char)-79);
				bool flag = true;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-20);
					}
					this.DKBDDMBKPMO(ajlpalfjhcc);
					flag = false;
				}
				this.NPDHCIEIIMI.Append((char)-88);
			}

			// Token: 0x06000161 RID: 353 RVA: 0x00005D9C File Offset: 0x00003F9C
			private void PJFDGEEMMCH(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append('/');
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 1;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\u0003':
						this.NPDHCIEIIMI.Append("null");
						break;
					case '\u0004':
						this.NPDHCIEIIMI.Append("onAppOpenAttribution");
						break;
					case '\u0005':
						this.NPDHCIEIIMI.Append("false");
						break;
					case '\u0006':
						goto IL_E0;
					case '\a':
						this.NPDHCIEIIMI.Append("campaign");
						break;
					case '\b':
						this.NPDHCIEIIMI.Append("false");
						break;
					default:
						if (c != '~')
						{
							if (c != '{')
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("click_http_referrer");
						}
						else
						{
							this.NPDHCIEIIMI.Append("onAppOpenAttribution");
						}
						break;
					}
					IL_129:
					i += 0;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= -95 && num <= 122)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("didReceiveConversionDataWithError");
					this.NPDHCIEIIMI.Append(num.ToString("campaign_id"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append((char)-31);
			}

			// Token: 0x06000162 RID: 354 RVA: 0x00005EF0 File Offset: 0x000040F0
			private void DEMLCNJDELL(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("is_deferred");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.PPOANJMACJL(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "true" : "errorDescription");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.IOJAIMDDKED(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.IALPALFOGLP(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.HDMHJJFOHFG(new string((char)AJLPALFJHCC, 0));
					return;
				}
				this.ECNMCPDIIIC(AJLPALFJHCC);
			}

			// Token: 0x06000163 RID: 355 RVA: 0x00004AC9 File Offset: 0x00002CC9
			public static string BECGFIHDGKO(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.ONLJGEOALMB(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x06000164 RID: 356 RVA: 0x00005F94 File Offset: 0x00004194
			private void FJEEJEFDCLB(IDictionary CCDJLDCNIGD)
			{
				bool flag = true;
				this.NPDHCIEIIMI.Append((char)-128);
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-52);
					}
					this.LELAFGPELBH(obj.ToString());
					this.NPDHCIEIIMI.Append((char)-18);
					this.KNIKHFEHAOF(CCDJLDCNIGD[obj]);
					flag = false;
				}
				this.NPDHCIEIIMI.Append((char)-100);
			}

			// Token: 0x06000165 RID: 357 RVA: 0x0000603C File Offset: 0x0000423C
			private void ABBHBCDFAAL(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append((char)-97);
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 1;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\u0003':
						this.NPDHCIEIIMI.Append("DeepLinkEventsArgs.isDeferred");
						break;
					case '\u0004':
						this.NPDHCIEIIMI.Append("AppsFlyer_Unity_v{0} {1} called with {2}");
						break;
					case '\u0005':
						this.NPDHCIEIIMI.Append("parseRequestCallback");
						break;
					case '\u0006':
						goto IL_E0;
					case '\a':
						this.NPDHCIEIIMI.Append("didReceiveConversionData");
						break;
					case '\b':
						this.NPDHCIEIIMI.Append("is_deferred");
						break;
					default:
						if (c != 'X')
						{
							if ((int)c != -122)
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("campaign_id");
						}
						else
						{
							this.NPDHCIEIIMI.Append("AppsFlyer_Unity_v{0} {1} called with {2}");
						}
						break;
					}
					IL_129:
					i += 0;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= -36 && num <= 83)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("af_sub1");
					this.NPDHCIEIIMI.Append(num.ToString(""));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append((char)-23);
			}

			// Token: 0x06000166 RID: 358 RVA: 0x00006190 File Offset: 0x00004390
			private void DKBDDMBKPMO(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("true");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.BJOHGJBJOIH(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "false" : "R");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.CPMJFGPMNLN(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.AJBJIIOOOIH(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.HDMHJJFOHFG(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.KJHLJIDACGG(AJLPALFJHCC);
			}

			// Token: 0x06000167 RID: 359 RVA: 0x00006234 File Offset: 0x00004434
			private void IKIBGILFBCL(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append((char)-125);
				bool flag = true;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-65);
					}
					this.KJFLOEJMHPI(ajlpalfjhcc);
					flag = false;
				}
				this.NPDHCIEIIMI.Append('`');
			}

			// Token: 0x06000168 RID: 360 RVA: 0x000062B4 File Offset: 0x000044B4
			public static string JBOAEOFDDGJ(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.BDPCMMLANPB(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x06000169 RID: 361 RVA: 0x000062CC File Offset: 0x000044CC
			private void MJCOFMGJIGD(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("true"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("\\f"));
					return;
				}
				this.PJFDGEEMMCH(AJLPALFJHCC.ToString());
			}

			// Token: 0x0600016A RID: 362 RVA: 0x0000638C File Offset: 0x0000458C
			private void LKOCLMNOLGL(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("\\n");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.PPOANJMACJL(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "af_sub3" : "onAppOpenAttribution");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.OOGLANMJCMN(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.GJGPDMCOPGE(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.PPOANJMACJL(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.KDAPKMJABIN(AJLPALFJHCC);
			}

			// Token: 0x0600016B RID: 363 RVA: 0x00006430 File Offset: 0x00004630
			private void CLJJOBDJOHE(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append((char)-74);
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 0;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\u0005':
						this.NPDHCIEIIMI.Append("null");
						break;
					case '\u0006':
						this.NPDHCIEIIMI.Append("\\b");
						break;
					case '\a':
						this.NPDHCIEIIMI.Append("AppsFlyer_Unity_v{0} {1} called with {2}");
						break;
					case '\b':
						goto IL_E0;
					case '\t':
						this.NPDHCIEIIMI.Append("");
						break;
					case '\n':
						this.NPDHCIEIIMI.Append("");
						break;
					default:
						if (c != '`')
						{
							if (c != 'q')
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("\\b");
						}
						else
						{
							this.NPDHCIEIIMI.Append("{}[],:\"");
						}
						break;
					}
					IL_129:
					i++;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= -8 && num <= 69)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("\\n");
					this.NPDHCIEIIMI.Append(num.ToString("is_deferred"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append('\u0006');
			}

			// Token: 0x0600016C RID: 364 RVA: 0x00006584 File Offset: 0x00004784
			private void DAPJABHJMFF(IDictionary CCDJLDCNIGD)
			{
				bool flag = false;
				this.NPDHCIEIIMI.Append('>');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('\u0013');
					}
					this.CLJJOBDJOHE(obj.ToString());
					this.NPDHCIEIIMI.Append('\\');
					this.KDLNHBEBLDJ(CCDJLDCNIGD[obj]);
					flag = true;
				}
				this.NPDHCIEIIMI.Append('.');
			}

			// Token: 0x0600016D RID: 365 RVA: 0x0000662C File Offset: 0x0000482C
			private void OOGLANMJCMN(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append('%');
				bool flag = false;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('g');
					}
					this.HEJAKFODGMM(ajlpalfjhcc);
					flag = true;
				}
				this.NPDHCIEIIMI.Append('H');
			}

			// Token: 0x0600016E RID: 366 RVA: 0x000066AC File Offset: 0x000048AC
			private void DNAFJNOFHHF(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("null");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.LELAFGPELBH(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "\\f" : "{0} Exception caught.");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.CPMJFGPMNLN(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.NNMHJLELACD(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.DOBNMIKFABP(new string((char)AJLPALFJHCC, 0));
					return;
				}
				this.PNALCHPONCG(AJLPALFJHCC);
			}

			// Token: 0x0600016F RID: 367 RVA: 0x0000674F File Offset: 0x0000494F
			public static string GPBAIBPNNFC(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.LMNNBHDIEKJ(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x06000170 RID: 368 RVA: 0x00006768 File Offset: 0x00004968
			private void JALCBIFLADM(IDictionary CCDJLDCNIGD)
			{
				bool flag = true;
				this.NPDHCIEIIMI.Append('A');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('(');
					}
					this.KOOMLAIGOBK(obj.ToString());
					this.NPDHCIEIIMI.Append((char)-25);
					this.DEMLCNJDELL(CCDJLDCNIGD[obj]);
					flag = false;
				}
				this.NPDHCIEIIMI.Append((char)-97);
			}

			// Token: 0x06000171 RID: 369 RVA: 0x00006810 File Offset: 0x00004A10
			private void NFLKBGKLFCB(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.KOOMLAIGOBK(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "didReceiveConversionDataWithError" : "");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.LGKJLOEMJNE(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.GNDNGAJJAFK(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.EEHDDMAKKHK(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.ENHEKBKODGM(AJLPALFJHCC);
			}

			// Token: 0x06000172 RID: 370 RVA: 0x000068B4 File Offset: 0x00004AB4
			private void ONLJGEOALMB(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("\\\"");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.CLJJOBDJOHE(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "x4" : "onAppOpenAttributionFailure");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.MOJPKOMHDFP(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.MDFBLGHLPNC(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.PDGAMBGPMGL(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.CIGPNIJENJG(AJLPALFJHCC);
			}

			// Token: 0x06000173 RID: 371 RVA: 0x00006958 File Offset: 0x00004B58
			private void FHKAGPENFJG(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append((char)-64);
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 1;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\a':
						this.NPDHCIEIIMI.Append("R");
						break;
					case '\b':
						this.NPDHCIEIIMI.Append("media_source");
						break;
					case '\t':
						this.NPDHCIEIIMI.Append("null");
						break;
					case '\n':
						goto IL_E0;
					case '\v':
						this.NPDHCIEIIMI.Append("R");
						break;
					case '\f':
						this.NPDHCIEIIMI.Append("click_http_referrer");
						break;
					default:
						if (c != 'X')
						{
							if (c != 'H')
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("\\u");
						}
						else
						{
							this.NPDHCIEIIMI.Append("af_sub5");
						}
						break;
					}
					IL_129:
					i++;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= -53 && num <= 29)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("false");
					this.NPDHCIEIIMI.Append(num.ToString("null"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append('\u001b');
			}

			// Token: 0x06000174 RID: 372 RVA: 0x00006AAC File Offset: 0x00004CAC
			private void PDGAMBGPMGL(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append('"');
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 0;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\b':
						this.NPDHCIEIIMI.Append("\\b");
						break;
					case '\t':
						this.NPDHCIEIIMI.Append("\\t");
						break;
					case '\n':
						this.NPDHCIEIIMI.Append("\\n");
						break;
					case '\v':
						goto IL_E0;
					case '\f':
						this.NPDHCIEIIMI.Append("\\f");
						break;
					case '\r':
						this.NPDHCIEIIMI.Append("\\r");
						break;
					default:
						if (c != '"')
						{
							if (c != '\\')
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("\\\\");
						}
						else
						{
							this.NPDHCIEIIMI.Append("\\\"");
						}
						break;
					}
					IL_129:
					i++;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= 32 && num <= 126)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("\\u");
					this.NPDHCIEIIMI.Append(num.ToString("x4"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append('"');
			}

			// Token: 0x06000175 RID: 373 RVA: 0x00006C00 File Offset: 0x00004E00
			private void EFBDJCNDHBG(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("deep_link_value");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.FHKAGPENFJG(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "null" : "statusCode");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.OIINNKDNMGO(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.OHIDMKBJLPC(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.ABBHBCDFAAL(new string((char)AJLPALFJHCC, 0));
					return;
				}
				this.CIGPNIJENJG(AJLPALFJHCC);
			}

			// Token: 0x06000176 RID: 374 RVA: 0x00006CA4 File Offset: 0x00004EA4
			private void DLKMPFCIHPA(IDictionary CCDJLDCNIGD)
			{
				bool flag = true;
				this.NPDHCIEIIMI.Append((char)-93);
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-55);
					}
					this.HDMHJJFOHFG(obj.ToString());
					this.NPDHCIEIIMI.Append((char)-56);
					this.KNIKHFEHAOF(CCDJLDCNIGD[obj]);
					flag = false;
				}
				this.NPDHCIEIIMI.Append((char)-20);
			}

			// Token: 0x06000177 RID: 375 RVA: 0x00006D4C File Offset: 0x00004F4C
			private void IALPALFOGLP(IDictionary CCDJLDCNIGD)
			{
				bool flag = false;
				this.NPDHCIEIIMI.Append((char)-117);
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-10);
					}
					this.FLOEDIIHNEJ(obj.ToString());
					this.NPDHCIEIIMI.Append((char)-108);
					this.NFLKBGKLFCB(CCDJLDCNIGD[obj]);
					flag = true;
				}
				this.NPDHCIEIIMI.Append((char)-78);
			}

			// Token: 0x06000178 RID: 376 RVA: 0x00006DF4 File Offset: 0x00004FF4
			private void OCNBKHONGHD(IDictionary CCDJLDCNIGD)
			{
				bool flag = false;
				this.NPDHCIEIIMI.Append('\t');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('d');
					}
					this.DGJLFJNIKPO(obj.ToString());
					this.NPDHCIEIIMI.Append((char)-127);
					this.BDPCMMLANPB(CCDJLDCNIGD[obj]);
					flag = false;
				}
				this.NPDHCIEIIMI.Append('e');
			}

			// Token: 0x06000179 RID: 377 RVA: 0x00006E9C File Offset: 0x0000509C
			private void OIINNKDNMGO(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append((char)-98);
				bool flag = false;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('>');
					}
					this.DNAFJNOFHHF(ajlpalfjhcc);
					flag = true;
				}
				this.NPDHCIEIIMI.Append((char)-10);
			}

			// Token: 0x0600017A RID: 378 RVA: 0x00006F1C File Offset: 0x0000511C
			private void BJOHGJBJOIH(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append((char)-34);
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 0;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\u0001':
						this.NPDHCIEIIMI.Append("campaign_id");
						break;
					case '\u0002':
						this.NPDHCIEIIMI.Append("\\u");
						break;
					case '\u0003':
						this.NPDHCIEIIMI.Append("false");
						break;
					case '\u0004':
						goto IL_E0;
					case '\u0005':
						this.NPDHCIEIIMI.Append("af_sub2");
						break;
					case '\u0006':
						this.NPDHCIEIIMI.Append("");
						break;
					default:
						if ((int)c != -82)
						{
							if ((int)c != -83)
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("null");
						}
						else
						{
							this.NPDHCIEIIMI.Append("parseRequestCallback");
						}
						break;
					}
					IL_129:
					i += 0;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= -32 && num <= 82)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("false");
					this.NPDHCIEIIMI.Append(num.ToString("is_deferred"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append('"');
			}

			// Token: 0x0600017B RID: 379 RVA: 0x00007070 File Offset: 0x00005270
			private void ILLCOAECEIE(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("R");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.DOBNMIKFABP(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "AppsFlyer_Unity_v{0} {1} called with {2}" : "is_deferred");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.MOJPKOMHDFP(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.NNMHJLELACD(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.EEHDDMAKKHK(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.MJBDBAJGFHP(AJLPALFJHCC);
			}

			// Token: 0x0600017C RID: 380 RVA: 0x00007114 File Offset: 0x00005314
			private void GNDNGAJJAFK(IDictionary CCDJLDCNIGD)
			{
				bool flag = false;
				this.NPDHCIEIIMI.Append('G');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-19);
					}
					this.FLOEDIIHNEJ(obj.ToString());
					this.NPDHCIEIIMI.Append((char)-47);
					this.PHNJMBFOMKJ(CCDJLDCNIGD[obj]);
					flag = false;
				}
				this.NPDHCIEIIMI.Append('k');
			}

			// Token: 0x0600017D RID: 381 RVA: 0x000071BC File Offset: 0x000053BC
			private void JBOMLLJLDAE(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("false");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.DOBNMIKFABP(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "null" : "is_deferred");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.DOCMAKGNJDI(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.HDLPFGDPIFI(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.PPOANJMACJL(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.KJHLJIDACGG(AJLPALFJHCC);
			}

			// Token: 0x0600017E RID: 382 RVA: 0x00007260 File Offset: 0x00005460
			private void JNHGGNFIKNF(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append((char)-97);
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 1;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\u0006':
						this.NPDHCIEIIMI.Append("x4");
						break;
					case '\a':
						this.NPDHCIEIIMI.Append("media_source");
						break;
					case '\b':
						this.NPDHCIEIIMI.Append("");
						break;
					case '\t':
						goto IL_E0;
					case '\n':
						this.NPDHCIEIIMI.Append("statusCode");
						break;
					case '\v':
						this.NPDHCIEIIMI.Append("af_sub4");
						break;
					default:
						if (c != '1')
						{
							if (c != '(')
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("x4");
						}
						else
						{
							this.NPDHCIEIIMI.Append("didReceiveConversionDataWithError");
						}
						break;
					}
					IL_129:
					i += 0;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= 43 && num <= -106)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("is_deferred");
					this.NPDHCIEIIMI.Append(num.ToString("\\n"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append((char)-81);
			}

			// Token: 0x0600017F RID: 383 RVA: 0x000073B4 File Offset: 0x000055B4
			private void OBFGNHMPNBG(IDictionary CCDJLDCNIGD)
			{
				bool flag = false;
				this.NPDHCIEIIMI.Append('\u0019');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('\u0011');
					}
					this.ABBHBCDFAAL(obj.ToString());
					this.NPDHCIEIIMI.Append('\u0018');
					this.BDPCMMLANPB(CCDJLDCNIGD[obj]);
					flag = true;
				}
				this.NPDHCIEIIMI.Append('\\');
			}

			// Token: 0x06000180 RID: 384 RVA: 0x0000745C File Offset: 0x0000565C
			private void NBLFKCEAHML(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append((char)-40);
				bool flag = true;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-66);
					}
					this.KNIKHFEHAOF(ajlpalfjhcc);
					flag = true;
				}
				this.NPDHCIEIIMI.Append((char)-109);
			}

			// Token: 0x06000181 RID: 385 RVA: 0x000074DC File Offset: 0x000056DC
			public static string KIGHPIFGKAG(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.ILLCOAECEIE(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x06000182 RID: 386 RVA: 0x000074F4 File Offset: 0x000056F4
			private void LMNNBHDIEKJ(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("null");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.PDGAMBGPMGL(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "true" : "false");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.IOJAIMDDKED(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.GJGPDMCOPGE(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.PDGAMBGPMGL(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.KDAPKMJABIN(AJLPALFJHCC);
			}

			// Token: 0x06000183 RID: 387 RVA: 0x00007598 File Offset: 0x00005798
			private void OCJOHMBLDDL(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("null");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.DGJLFJNIKPO(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "\\n" : "");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.CPMJFGPMNLN(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.DNNEKIOEOKD(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.LELAFGPELBH(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.KHCNHGMIBKC(AJLPALFJHCC);
			}

			// Token: 0x06000184 RID: 388 RVA: 0x0000763C File Offset: 0x0000583C
			private void IGBIHIIFPNM(IDictionary CCDJLDCNIGD)
			{
				bool flag = false;
				this.NPDHCIEIIMI.Append('8');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-91);
					}
					this.FLOEDIIHNEJ(obj.ToString());
					this.NPDHCIEIIMI.Append('\u001b');
					this.PLBDNGBNFJE(CCDJLDCNIGD[obj]);
					flag = false;
				}
				this.NPDHCIEIIMI.Append((char)-37);
			}

			// Token: 0x06000185 RID: 389 RVA: 0x00004AC9 File Offset: 0x00002CC9
			public static string KBODCHAPJDO(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.ONLJGEOALMB(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x06000186 RID: 390 RVA: 0x000076E4 File Offset: 0x000058E4
			private void ILJLGEFOKMC(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("false"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("null"));
					return;
				}
				this.BJOHGJBJOIH(AJLPALFJHCC.ToString());
			}

			// Token: 0x06000187 RID: 391 RVA: 0x000077A4 File Offset: 0x000059A4
			private void NNBBOEFIIMJ(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append((char)-75);
				bool flag = false;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('\u0005');
					}
					this.BDPCMMLANPB(ajlpalfjhcc);
					flag = false;
				}
				this.NPDHCIEIIMI.Append('I');
			}

			// Token: 0x06000188 RID: 392 RVA: 0x00007824 File Offset: 0x00005A24
			private void GJGPDMCOPGE(IDictionary CCDJLDCNIGD)
			{
				bool flag = true;
				this.NPDHCIEIIMI.Append('{');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append(',');
					}
					this.PDGAMBGPMGL(obj.ToString());
					this.NPDHCIEIIMI.Append(':');
					this.LMNNBHDIEKJ(CCDJLDCNIGD[obj]);
					flag = false;
				}
				this.NPDHCIEIIMI.Append('}');
			}

			// Token: 0x06000189 RID: 393 RVA: 0x000078CC File Offset: 0x00005ACC
			private void DOBNMIKFABP(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append((char)-128);
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 1;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\u0001':
						this.NPDHCIEIIMI.Append("is_deferred");
						break;
					case '\u0002':
						this.NPDHCIEIIMI.Append("af_sub3");
						break;
					case '\u0003':
						this.NPDHCIEIIMI.Append("click_http_referrer");
						break;
					case '\u0004':
						goto IL_E0;
					case '\u0005':
						this.NPDHCIEIIMI.Append("false");
						break;
					case '\u0006':
						this.NPDHCIEIIMI.Append("errorDescription");
						break;
					default:
						if (c != 'q')
						{
							if (c != 'x')
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("AppsFlyer_Unity_v{0} {1} called with {2}");
						}
						else
						{
							this.NPDHCIEIIMI.Append("didReceiveConversionDataWithError");
						}
						break;
					}
					IL_129:
					i += 0;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= 19 && num <= -74)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("media_source");
					this.NPDHCIEIIMI.Append(num.ToString("\\b"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append('(');
			}

			// Token: 0x0600018A RID: 394 RVA: 0x00007A20 File Offset: 0x00005C20
			private void EALOCNEMJNE(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append('@');
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 1;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\u0005':
						this.NPDHCIEIIMI.Append("af_sub5");
						break;
					case '\u0006':
						this.NPDHCIEIIMI.Append("true");
						break;
					case '\a':
						this.NPDHCIEIIMI.Append("false");
						break;
					case '\b':
						goto IL_E0;
					case '\t':
						this.NPDHCIEIIMI.Append("true");
						break;
					case '\n':
						this.NPDHCIEIIMI.Append("is_deferred");
						break;
					default:
						if ((int)c != -1)
						{
							if ((int)c != -128)
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("af_sub3");
						}
						else
						{
							this.NPDHCIEIIMI.Append("af_sub3");
						}
						break;
					}
					IL_129:
					i++;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= 103 && num <= 114)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("errorDescription");
					this.NPDHCIEIIMI.Append(num.ToString("{0} Exception caught."));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append((char)-105);
			}

			// Token: 0x0600018B RID: 395 RVA: 0x00007B74 File Offset: 0x00005D74
			private void MDFBLGHLPNC(IDictionary CCDJLDCNIGD)
			{
				bool flag = true;
				this.NPDHCIEIIMI.Append('\u0004');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-28);
					}
					this.BJOHGJBJOIH(obj.ToString());
					this.NPDHCIEIIMI.Append('\u0012');
					this.KNIKHFEHAOF(CCDJLDCNIGD[obj]);
					flag = true;
				}
				this.NPDHCIEIIMI.Append((char)-125);
			}

			// Token: 0x0600018C RID: 396 RVA: 0x00007C1C File Offset: 0x00005E1C
			private void DIFMJIJBAIF(IDictionary CCDJLDCNIGD)
			{
				bool flag = false;
				this.NPDHCIEIIMI.Append(',');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-53);
					}
					this.DPBEPFBGJNL(obj.ToString());
					this.NPDHCIEIIMI.Append('\u0001');
					this.IOPODFBJGMN(CCDJLDCNIGD[obj]);
					flag = true;
				}
				this.NPDHCIEIIMI.Append((char)-123);
			}

			// Token: 0x0600018D RID: 397 RVA: 0x00007CC4 File Offset: 0x00005EC4
			private void BLPHHCJLDNB(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append((char)-7);
				bool flag = true;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-77);
					}
					this.LMNNBHDIEKJ(ajlpalfjhcc);
					flag = true;
				}
				this.NPDHCIEIIMI.Append((char)-111);
			}

			// Token: 0x0600018E RID: 398 RVA: 0x0000674F File Offset: 0x0000494F
			public static string FOBADNOFFFI(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.LMNNBHDIEKJ(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x0600018F RID: 399 RVA: 0x00007D44 File Offset: 0x00005F44
			private void CIGPNIJENJG(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("is_deferred"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("null"));
					return;
				}
				this.FLOEDIIHNEJ(AJLPALFJHCC.ToString());
			}

			// Token: 0x06000190 RID: 400 RVA: 0x00007E03 File Offset: 0x00006003
			private NECECLNGEMF()
			{
				this.NPDHCIEIIMI = new StringBuilder();
			}

			// Token: 0x06000191 RID: 401 RVA: 0x00007E18 File Offset: 0x00006018
			private void NNMHJLELACD(IDictionary CCDJLDCNIGD)
			{
				bool flag = false;
				this.NPDHCIEIIMI.Append((char)-17);
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-75);
					}
					this.HKOKHFFMALO(obj.ToString());
					this.NPDHCIEIIMI.Append('R');
					this.PLBDNGBNFJE(CCDJLDCNIGD[obj]);
					flag = true;
				}
				this.NPDHCIEIIMI.Append('v');
			}

			// Token: 0x06000192 RID: 402 RVA: 0x00007EC0 File Offset: 0x000060C0
			private void AJBJIIOOOIH(IDictionary CCDJLDCNIGD)
			{
				bool flag = true;
				this.NPDHCIEIIMI.Append('G');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('g');
					}
					this.PDGAMBGPMGL(obj.ToString());
					this.NPDHCIEIIMI.Append('b');
					this.JBOMLLJLDAE(CCDJLDCNIGD[obj]);
					flag = true;
				}
				this.NPDHCIEIIMI.Append('q');
			}

			// Token: 0x06000193 RID: 403 RVA: 0x00007F68 File Offset: 0x00006168
			private void POHIEJMHLFE(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("is_deferred");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.KOOMLAIGOBK(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "statusCode" : "click_http_referrer");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.IOJAIMDDKED(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.HDLPFGDPIFI(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.PJFDGEEMMCH(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.GDMGIINNJDN(AJLPALFJHCC);
			}

			// Token: 0x06000194 RID: 404 RVA: 0x0000800C File Offset: 0x0000620C
			private void GDMGIINNJDN(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("false"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("af_sub5"));
					return;
				}
				this.PJFDGEEMMCH(AJLPALFJHCC.ToString());
			}

			// Token: 0x06000195 RID: 405 RVA: 0x000080CC File Offset: 0x000062CC
			private void IOPODFBJGMN(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("\\\\");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.EALOCNEMJNE(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "\\u" : "null");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.IKIBGILFBCL(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.DNNEKIOEOKD(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.PJFDGEEMMCH(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.PNALCHPONCG(AJLPALFJHCC);
			}

			// Token: 0x06000196 RID: 406 RVA: 0x00008170 File Offset: 0x00006370
			private void DOCMAKGNJDI(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append('w');
				bool flag = true;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('\0');
					}
					this.ILLCOAECEIE(ajlpalfjhcc);
					flag = true;
				}
				this.NPDHCIEIIMI.Append(']');
			}

			// Token: 0x06000197 RID: 407 RVA: 0x000081F0 File Offset: 0x000063F0
			private void EEHDDMAKKHK(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append('\u001d');
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 1;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\u0003':
						this.NPDHCIEIIMI.Append("af_sub3");
						break;
					case '\u0004':
						this.NPDHCIEIIMI.Append("x4");
						break;
					case '\u0005':
						this.NPDHCIEIIMI.Append("campaign");
						break;
					case '\u0006':
						goto IL_E0;
					case '\a':
						this.NPDHCIEIIMI.Append("AppsFlyer_Unity_v{0} {1} called with {2}");
						break;
					case '\b':
						this.NPDHCIEIIMI.Append("click_http_referrer");
						break;
					default:
						if ((int)c != -127)
						{
							if ((int)c != -69)
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("");
						}
						else
						{
							this.NPDHCIEIIMI.Append("\\\\");
						}
						break;
					}
					IL_129:
					i += 0;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= 83 && num <= -107)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("af_sub3");
					this.NPDHCIEIIMI.Append(num.ToString("campaign"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append((char)-74);
			}

			// Token: 0x06000198 RID: 408 RVA: 0x00008341 File Offset: 0x00006541
			public static string CJGHNOMJIMH(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.HEJAKFODGMM(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x06000199 RID: 409 RVA: 0x0000835C File Offset: 0x0000655C
			private void HDMHJJFOHFG(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append((char)-73);
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 1;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\u0004':
						this.NPDHCIEIIMI.Append("\\n");
						break;
					case '\u0005':
						this.NPDHCIEIIMI.Append("R");
						break;
					case '\u0006':
						this.NPDHCIEIIMI.Append("x4");
						break;
					case '\a':
						goto IL_E0;
					case '\b':
						this.NPDHCIEIIMI.Append("statusCode");
						break;
					case '\t':
						this.NPDHCIEIIMI.Append("\\n");
						break;
					default:
						if (c != '}')
						{
							if ((int)c != -13)
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("false");
						}
						else
						{
							this.NPDHCIEIIMI.Append("AppsFlyer_Unity_v{0} {1} called with {2}");
						}
						break;
					}
					IL_129:
					i += 0;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= -114 && num <= -42)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("DeepLinkEventsArgs.isDeferred");
					this.NPDHCIEIIMI.Append(num.ToString("\\n"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append((char)-2);
			}

			// Token: 0x0600019A RID: 410 RVA: 0x000084B0 File Offset: 0x000066B0
			private void KNIKHFEHAOF(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("true");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.DPBEPFBGJNL(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "R" : "af_sub1");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.HOMGFDIJLMI(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.JALCBIFLADM(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.HDMHJJFOHFG(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.MJCOFMGJIGD(AJLPALFJHCC);
			}

			// Token: 0x0600019B RID: 411 RVA: 0x00008554 File Offset: 0x00006754
			private void KHCNHGMIBKC(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("af_sub1"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("didReceiveConversionDataWithError"));
					return;
				}
				this.DGJLFJNIKPO(AJLPALFJHCC.ToString());
			}

			// Token: 0x0600019C RID: 412 RVA: 0x00008613 File Offset: 0x00006813
			public static string MGLCEEJDJEC(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.DKBDDMBKPMO(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x0600019D RID: 413 RVA: 0x0000862C File Offset: 0x0000682C
			private void IOJAIMDDKED(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append('[');
				bool flag = true;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append(',');
					}
					this.LMNNBHDIEKJ(ajlpalfjhcc);
					flag = false;
				}
				this.NPDHCIEIIMI.Append(']');
			}

			// Token: 0x0600019E RID: 414 RVA: 0x00005341 File Offset: 0x00003541
			public static string MKFGFBNPMKC(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.LOPDKBIGPAE(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x0600019F RID: 415 RVA: 0x000086AC File Offset: 0x000068AC
			private void MJBDBAJGFHP(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("campaign"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("AppsFlyer_Unity_v{0} {1} called with {2}"));
					return;
				}
				this.HDMHJJFOHFG(AJLPALFJHCC.ToString());
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x0000876C File Offset: 0x0000696C
			private void OHIDMKBJLPC(IDictionary CCDJLDCNIGD)
			{
				bool flag = true;
				this.NPDHCIEIIMI.Append('_');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-95);
					}
					this.EALOCNEMJNE(obj.ToString());
					this.NPDHCIEIIMI.Append('i');
					this.ILLCOAECEIE(CCDJLDCNIGD[obj]);
					flag = true;
				}
				this.NPDHCIEIIMI.Append((char)-71);
			}

			// Token: 0x060001A1 RID: 417 RVA: 0x00008814 File Offset: 0x00006A14
			public static string BEFGINHCGNE(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.IOPODFBJGMN(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x060001A2 RID: 418 RVA: 0x0000882C File Offset: 0x00006A2C
			public static string AIDICGHGACL(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.KNIKHFEHAOF(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x060001A3 RID: 419 RVA: 0x00008844 File Offset: 0x00006A44
			private void AMNALDNFAFB(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append('s');
				bool flag = true;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('\t');
					}
					this.LMNNBHDIEKJ(ajlpalfjhcc);
					flag = true;
				}
				this.NPDHCIEIIMI.Append('v');
			}

			// Token: 0x060001A4 RID: 420 RVA: 0x000088C4 File Offset: 0x00006AC4
			private void CNGCDACBECC(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("AppsFlyer_Unity_v{0} {1} called with {2}"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("true"));
					return;
				}
				this.FLOEDIIHNEJ(AJLPALFJHCC.ToString());
			}

			// Token: 0x060001A5 RID: 421 RVA: 0x00008983 File Offset: 0x00006B83
			public static string EAAJBILELFM(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.EFBDJCNDHBG(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x060001A6 RID: 422 RVA: 0x0000899C File Offset: 0x00006B9C
			private void PKNENEHAFLE(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append('8');
				bool flag = true;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-72);
					}
					this.BDPCMMLANPB(ajlpalfjhcc);
					flag = true;
				}
				this.NPDHCIEIIMI.Append((char)-15);
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x00008A1C File Offset: 0x00006C1C
			private void KJHLJIDACGG(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC is float)
				{
					this.NPDHCIEIIMI.Append(((float)AJLPALFJHCC).ToString("is_deferred"));
					return;
				}
				if (AJLPALFJHCC is int || AJLPALFJHCC is uint || AJLPALFJHCC is long || AJLPALFJHCC is sbyte || AJLPALFJHCC is byte || AJLPALFJHCC is short || AJLPALFJHCC is ushort || AJLPALFJHCC is ulong)
				{
					this.NPDHCIEIIMI.Append(AJLPALFJHCC);
					return;
				}
				if (AJLPALFJHCC is double || AJLPALFJHCC is decimal)
				{
					this.NPDHCIEIIMI.Append(Convert.ToDouble(AJLPALFJHCC).ToString("af_sub2"));
					return;
				}
				this.EALOCNEMJNE(AJLPALFJHCC.ToString());
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x00008ADC File Offset: 0x00006CDC
			private void GEADPACBBKG(IDictionary CCDJLDCNIGD)
			{
				bool flag = true;
				this.NPDHCIEIIMI.Append((char)-72);
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-49);
					}
					this.PPOANJMACJL(obj.ToString());
					this.NPDHCIEIIMI.Append((char)-16);
					this.JBOMLLJLDAE(CCDJLDCNIGD[obj]);
					flag = true;
				}
				this.NPDHCIEIIMI.Append('\u000f');
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00008B84 File Offset: 0x00006D84
			private void LGKJLOEMJNE(IList KAFPKOHHAMD)
			{
				this.NPDHCIEIIMI.Append((char)-100);
				bool flag = true;
				foreach (object ajlpalfjhcc in KAFPKOHHAMD)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('2');
					}
					this.PLBDNGBNFJE(ajlpalfjhcc);
					flag = true;
				}
				this.NPDHCIEIIMI.Append('<');
			}

			// Token: 0x060001AA RID: 426 RVA: 0x00008C04 File Offset: 0x00006E04
			private void KOOMLAIGOBK(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append((char)-63);
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 1;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\b':
						this.NPDHCIEIIMI.Append("deep_link_value");
						break;
					case '\t':
						this.NPDHCIEIIMI.Append("true");
						break;
					case '\n':
						this.NPDHCIEIIMI.Append("is_deferred");
						break;
					case '\v':
						goto IL_E0;
					case '\f':
						this.NPDHCIEIIMI.Append("\\t");
						break;
					case '\r':
						this.NPDHCIEIIMI.Append("statusCode");
						break;
					default:
						if (c != 'q')
						{
							if (c != 'o')
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("parseRequestCallback");
						}
						else
						{
							this.NPDHCIEIIMI.Append("onAppOpenAttribution");
						}
						break;
					}
					IL_129:
					i++;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= -105 && num <= 78)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("af_sub5");
					this.NPDHCIEIIMI.Append(num.ToString("x4"));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append('\t');
			}

			// Token: 0x060001AB RID: 427 RVA: 0x00008D55 File Offset: 0x00006F55
			public static string HAIBMFEGKBN(object CCDJLDCNIGD)
			{
				ALMPEPHNEHO.NECECLNGEMF nececlngemf = new ALMPEPHNEHO.NECECLNGEMF();
				nececlngemf.KDLNHBEBLDJ(CCDJLDCNIGD);
				return nececlngemf.NPDHCIEIIMI.ToString();
			}

			// Token: 0x060001AC RID: 428 RVA: 0x00008D70 File Offset: 0x00006F70
			private void LOPDKBIGPAE(object AJLPALFJHCC)
			{
				if (AJLPALFJHCC == null)
				{
					this.NPDHCIEIIMI.Append("campaign");
					return;
				}
				string ppdggdcamnb;
				if ((ppdggdcamnb = (AJLPALFJHCC as string)) != null)
				{
					this.DOBNMIKFABP(ppdggdcamnb);
					return;
				}
				if (AJLPALFJHCC is bool)
				{
					this.NPDHCIEIIMI.Append(((bool)AJLPALFJHCC) ? "af_sub5" : "\\r");
					return;
				}
				IList kafpkohhamd;
				if ((kafpkohhamd = (AJLPALFJHCC as IList)) != null)
				{
					this.HOMGFDIJLMI(kafpkohhamd);
					return;
				}
				IDictionary ccdjldcnigd;
				if ((ccdjldcnigd = (AJLPALFJHCC as IDictionary)) != null)
				{
					this.DNNEKIOEOKD(ccdjldcnigd);
					return;
				}
				if (AJLPALFJHCC is char)
				{
					this.PJFDGEEMMCH(new string((char)AJLPALFJHCC, 1));
					return;
				}
				this.CNGCDACBECC(AJLPALFJHCC);
			}

			// Token: 0x060001AD RID: 429 RVA: 0x00008E14 File Offset: 0x00007014
			private void KBGMNLJAPNO(IDictionary CCDJLDCNIGD)
			{
				bool flag = true;
				this.NPDHCIEIIMI.Append('A');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append('d');
					}
					this.FHKAGPENFJG(obj.ToString());
					this.NPDHCIEIIMI.Append('\u0012');
					this.HEJAKFODGMM(CCDJLDCNIGD[obj]);
					flag = true;
				}
				this.NPDHCIEIIMI.Append('1');
			}

			// Token: 0x060001AE RID: 430 RVA: 0x00008EBC File Offset: 0x000070BC
			private void GBDAFAAFPJH(IDictionary CCDJLDCNIGD)
			{
				bool flag = false;
				this.NPDHCIEIIMI.Append('%');
				foreach (object obj in CCDJLDCNIGD.Keys)
				{
					if (!flag)
					{
						this.NPDHCIEIIMI.Append((char)-105);
					}
					this.LELAFGPELBH(obj.ToString());
					this.NPDHCIEIIMI.Append((char)-17);
					this.DEMLCNJDELL(CCDJLDCNIGD[obj]);
					flag = false;
				}
				this.NPDHCIEIIMI.Append('\u0018');
			}

			// Token: 0x060001AF RID: 431 RVA: 0x00008F64 File Offset: 0x00007164
			private void DPBEPFBGJNL(string PPDGGDCAMNB)
			{
				this.NPDHCIEIIMI.Append('\u0018');
				char[] array = PPDGGDCAMNB.ToCharArray();
				int i = 1;
				while (i < array.Length)
				{
					char c = array[i];
					switch (c)
					{
					case '\b':
						this.NPDHCIEIIMI.Append("{}[],:\"");
						break;
					case '\t':
						this.NPDHCIEIIMI.Append("onAppOpenAttributionFailure");
						break;
					case '\n':
						this.NPDHCIEIIMI.Append("\\t");
						break;
					case '\v':
						goto IL_E0;
					case '\f':
						this.NPDHCIEIIMI.Append("R");
						break;
					case '\r':
						this.NPDHCIEIIMI.Append("\\\"");
						break;
					default:
						if (c != '^')
						{
							if (c != '\u001e')
							{
								goto IL_E0;
							}
							this.NPDHCIEIIMI.Append("is_deferred");
						}
						else
						{
							this.NPDHCIEIIMI.Append("statusCode");
						}
						break;
					}
					IL_129:
					i += 0;
					continue;
					IL_E0:
					int num = Convert.ToInt32(c);
					if (num >= 6 && num <= 125)
					{
						this.NPDHCIEIIMI.Append(c);
						goto IL_129;
					}
					this.NPDHCIEIIMI.Append("media_source");
					this.NPDHCIEIIMI.Append(num.ToString(""));
					goto IL_129;
				}
				this.NPDHCIEIIMI.Append('\u001f');
			}

			// Token: 0x0400001E RID: 30
			private StringBuilder NPDHCIEIIMI;
		}
	}
}
