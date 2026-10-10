using System;

namespace Ink.Runtime
{
	// Token: 0x0200001F RID: 31
	public class Choice : Object
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00008CC7 File Offset: 0x00006EC7
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00008CCF File Offset: 0x00006ECF
		public string text { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00008CD8 File Offset: 0x00006ED8
		public string pathStringOnChoice
		{
			get
			{
				return this.choicePoint.pathStringOnChoice;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00008CE5 File Offset: 0x00006EE5
		public string sourcePath
		{
			get
			{
				return this.choicePoint.path.componentsString;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00008CF7 File Offset: 0x00006EF7
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00008CFF File Offset: 0x00006EFF
		public int index { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00008D08 File Offset: 0x00006F08
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00008D10 File Offset: 0x00006F10
		internal ChoicePoint choicePoint { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00008D19 File Offset: 0x00006F19
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00008D21 File Offset: 0x00006F21
		internal CallStack.Thread threadAtGeneration { get; set; }

		// Token: 0x060000C1 RID: 193 RVA: 0x00008D2A File Offset: 0x00006F2A
		internal Choice()
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00008D32 File Offset: 0x00006F32
		internal Choice(ChoicePoint choice)
		{
			this.choicePoint = choice;
		}

		// Token: 0x0400010E RID: 270
		internal int originalThreadIndex;

		// Token: 0x0400010F RID: 271
		internal string originalChoicePath;
	}
}
