using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000B4 RID: 180
	[Serializable]
	public class LocalizedProductDescription
	{
		// Token: 0x0600032C RID: 812 RVA: 0x00007D16 File Offset: 0x00005F16
		public LocalizedProductDescription Clone()
		{
			return new LocalizedProductDescription
			{
				googleLocale = this.googleLocale,
				Title = this.Title,
				Description = this.Description
			};
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00007D41 File Offset: 0x00005F41
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00007D4E File Offset: 0x00005F4E
		public string Title
		{
			get
			{
				return LocalizedProductDescription.DecodeNonLatinCharacters(this.title);
			}
			set
			{
				this.title = LocalizedProductDescription.EncodeNonLatinCharacters(value);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00007D5C File Offset: 0x00005F5C
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00007D69 File Offset: 0x00005F69
		public string Description
		{
			get
			{
				return LocalizedProductDescription.DecodeNonLatinCharacters(this.description);
			}
			set
			{
				this.description = LocalizedProductDescription.EncodeNonLatinCharacters(value);
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00007D78 File Offset: 0x00005F78
		private static string EncodeNonLatinCharacters(string s)
		{
			if (s == null)
			{
				return s;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in s)
			{
				if (c > '\u007f')
				{
					string str = "\\u";
					int num = (int)c;
					string value = str + num.ToString("x4");
					stringBuilder.Append(value);
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00007DE4 File Offset: 0x00005FE4
		private static string DecodeNonLatinCharacters(string s)
		{
			if (s == null)
			{
				return s;
			}
			return Regex.Replace(s, "\\\\u(?<Value>[a-zA-Z0-9]{4})", (Match m) => ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString());
		}

		// Token: 0x0400014F RID: 335
		public TranslationLocale googleLocale = TranslationLocale.en_US;

		// Token: 0x04000150 RID: 336
		[SerializeField]
		private string title;

		// Token: 0x04000151 RID: 337
		[SerializeField]
		private string description;
	}
}
