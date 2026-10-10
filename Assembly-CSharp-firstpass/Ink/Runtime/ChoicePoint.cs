using System;

namespace Ink.Runtime
{
	// Token: 0x02000020 RID: 32
	internal class ChoicePoint : Object
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00008D44 File Offset: 0x00006F44
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00008D87 File Offset: 0x00006F87
		internal Path pathOnChoice
		{
			get
			{
				if (this._pathOnChoice != null && this._pathOnChoice.isRelative)
				{
					Container choiceTarget = this.choiceTarget;
					if (choiceTarget)
					{
						this._pathOnChoice = choiceTarget.path;
					}
				}
				return this._pathOnChoice;
			}
			set
			{
				this._pathOnChoice = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00008D90 File Offset: 0x00006F90
		internal Container choiceTarget
		{
			get
			{
				return base.ResolvePath(this._pathOnChoice) as Container;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00008DA3 File Offset: 0x00006FA3
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00008DB1 File Offset: 0x00006FB1
		internal string pathStringOnChoice
		{
			get
			{
				return base.CompactPathString(this.pathOnChoice);
			}
			set
			{
				this.pathOnChoice = new Path(value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00008DBF File Offset: 0x00006FBF
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00008DC7 File Offset: 0x00006FC7
		internal bool hasCondition { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00008DD0 File Offset: 0x00006FD0
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00008DD8 File Offset: 0x00006FD8
		internal bool hasStartContent { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00008DE1 File Offset: 0x00006FE1
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00008DE9 File Offset: 0x00006FE9
		internal bool hasChoiceOnlyContent { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00008DF2 File Offset: 0x00006FF2
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00008DFA File Offset: 0x00006FFA
		internal bool onceOnly { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00008E03 File Offset: 0x00007003
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00008E0B File Offset: 0x0000700B
		internal bool isInvisibleDefault { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00008E14 File Offset: 0x00007014
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00008E61 File Offset: 0x00007061
		internal int flags
		{
			get
			{
				int num = 0;
				if (this.hasCondition)
				{
					num |= 1;
				}
				if (this.hasStartContent)
				{
					num |= 2;
				}
				if (this.hasChoiceOnlyContent)
				{
					num |= 4;
				}
				if (this.isInvisibleDefault)
				{
					num |= 8;
				}
				if (this.onceOnly)
				{
					num |= 16;
				}
				return num;
			}
			set
			{
				this.hasCondition = ((value & 1) > 0);
				this.hasStartContent = ((value & 2) > 0);
				this.hasChoiceOnlyContent = ((value & 4) > 0);
				this.isInvisibleDefault = ((value & 8) > 0);
				this.onceOnly = ((value & 16) > 0);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00008EA0 File Offset: 0x000070A0
		internal ChoicePoint(bool onceOnly)
		{
			this.onceOnly = onceOnly;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00008EAF File Offset: 0x000070AF
		public ChoicePoint() : this(true)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00008EB8 File Offset: 0x000070B8
		public override string ToString()
		{
			int? num = base.DebugLineNumberOfPath(this.pathOnChoice);
			string str = this.pathOnChoice.ToString();
			if (num != null)
			{
				string str2 = " line ";
				int? num2 = num;
				str = str2 + num2.ToString();
			}
			return "Choice: -> " + str;
		}

		// Token: 0x04000110 RID: 272
		private Path _pathOnChoice;
	}
}
