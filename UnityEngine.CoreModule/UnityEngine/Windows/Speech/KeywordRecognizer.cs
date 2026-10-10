using System;
using System.Collections.Generic;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200029C RID: 668
	public sealed class KeywordRecognizer : PhraseRecognizer
	{
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x0002DCD6 File Offset: 0x0002BED6
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0002DCDE File Offset: 0x0002BEDE
		public IEnumerable<string> Keywords { get; private set; }

		// Token: 0x06001C8F RID: 7311 RVA: 0x0002DCE7 File Offset: 0x0002BEE7
		public KeywordRecognizer(string[] keywords) : this(keywords, ConfidenceLevel.Medium)
		{
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0002DCF4 File Offset: 0x0002BEF4
		public KeywordRecognizer(string[] keywords, ConfidenceLevel minimumConfidence)
		{
			bool flag = keywords == null;
			if (flag)
			{
				throw new ArgumentNullException("keywords");
			}
			bool flag2 = keywords.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("At least one keyword must be specified.", "keywords");
			}
			int num = keywords.Length;
			for (int i = 0; i < num; i++)
			{
				bool flag3 = keywords[i] == null;
				if (flag3)
				{
					throw new ArgumentNullException(string.Format("Keyword at index {0} is null.", i));
				}
			}
			this.Keywords = keywords;
			this.m_Recognizer = PhraseRecognizer.CreateFromKeywords(this, keywords, minimumConfidence);
		}
	}
}
