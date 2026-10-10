using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200029D RID: 669
	public sealed class GrammarRecognizer : PhraseRecognizer
	{
		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x0002DD85 File Offset: 0x0002BF85
		// (set) Token: 0x06001C92 RID: 7314 RVA: 0x0002DD8D File Offset: 0x0002BF8D
		public string GrammarFilePath { get; private set; }

		// Token: 0x06001C93 RID: 7315 RVA: 0x0002DD96 File Offset: 0x0002BF96
		public GrammarRecognizer(string grammarFilePath) : this(grammarFilePath, ConfidenceLevel.Medium)
		{
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0002DDA4 File Offset: 0x0002BFA4
		public GrammarRecognizer(string grammarFilePath, ConfidenceLevel minimumConfidence)
		{
			bool flag = grammarFilePath == null;
			if (flag)
			{
				throw new ArgumentNullException("grammarFilePath");
			}
			bool flag2 = grammarFilePath.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Grammar file path cannot be empty.");
			}
			this.GrammarFilePath = grammarFilePath;
			this.m_Recognizer = PhraseRecognizer.CreateFromGrammarFile(this, grammarFilePath, minimumConfidence);
		}
	}
}
