using System;
using System.Text;

namespace Ink.Runtime
{
	// Token: 0x02000024 RID: 36
	internal class Divert : Object
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00009924 File Offset: 0x00007B24
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00009967 File Offset: 0x00007B67
		public Path targetPath
		{
			get
			{
				if (this._targetPath != null && this._targetPath.isRelative)
				{
					Object targetContent = this.targetContent;
					if (targetContent)
					{
						this._targetPath = targetContent.path;
					}
				}
				return this._targetPath;
			}
			set
			{
				this._targetPath = value;
				this._targetContent = null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00009977 File Offset: 0x00007B77
		public Object targetContent
		{
			get
			{
				if (this._targetContent == null)
				{
					this._targetContent = base.ResolvePath(this._targetPath);
				}
				return this._targetContent;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000999F File Offset: 0x00007B9F
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000099B7 File Offset: 0x00007BB7
		public string targetPathString
		{
			get
			{
				if (this.targetPath == null)
				{
					return null;
				}
				return base.CompactPathString(this.targetPath);
			}
			set
			{
				if (value == null)
				{
					this.targetPath = null;
					return;
				}
				this.targetPath = new Path(value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000099D0 File Offset: 0x00007BD0
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000099D8 File Offset: 0x00007BD8
		public string variableDivertName { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000099E1 File Offset: 0x00007BE1
		public bool hasVariableTarget
		{
			get
			{
				return this.variableDivertName != null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000099EC File Offset: 0x00007BEC
		// (set) Token: 0x0600011C RID: 284 RVA: 0x000099F4 File Offset: 0x00007BF4
		public bool pushesToStack { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000099FD File Offset: 0x00007BFD
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00009A05 File Offset: 0x00007C05
		public bool isExternal { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00009A0E File Offset: 0x00007C0E
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00009A16 File Offset: 0x00007C16
		public int externalArgs { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00009A1F File Offset: 0x00007C1F
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00009A27 File Offset: 0x00007C27
		public bool isConditional { get; set; }

		// Token: 0x06000123 RID: 291 RVA: 0x00009A30 File Offset: 0x00007C30
		public Divert()
		{
			this.pushesToStack = false;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00009A3F File Offset: 0x00007C3F
		public Divert(PushPopType stackPushType)
		{
			this.pushesToStack = true;
			this.stackPushType = stackPushType;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00009A58 File Offset: 0x00007C58
		public override bool Equals(object obj)
		{
			Divert divert = obj as Divert;
			if (!divert || this.hasVariableTarget != divert.hasVariableTarget)
			{
				return false;
			}
			if (this.hasVariableTarget)
			{
				return this.variableDivertName == divert.variableDivertName;
			}
			return this.targetPath.Equals(divert.targetPath);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00009AAF File Offset: 0x00007CAF
		public override int GetHashCode()
		{
			if (this.hasVariableTarget)
			{
				return this.variableDivertName.GetHashCode() + 12345;
			}
			return this.targetPath.GetHashCode() + 54321;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00009ADC File Offset: 0x00007CDC
		public override string ToString()
		{
			if (this.hasVariableTarget)
			{
				return "Divert(variable: " + this.variableDivertName + ")";
			}
			if (this.targetPath == null)
			{
				return "Divert(null)";
			}
			StringBuilder stringBuilder = new StringBuilder();
			string value = this.targetPath.ToString();
			int? num = base.DebugLineNumberOfPath(this.targetPath);
			if (num != null)
			{
				string str = "line ";
				int? num2 = num;
				value = str + num2.ToString();
			}
			stringBuilder.Append("Divert");
			if (this.isConditional)
			{
				stringBuilder.Append("?");
			}
			if (this.pushesToStack)
			{
				if (this.stackPushType == PushPopType.Function)
				{
					stringBuilder.Append(" function");
				}
				else
				{
					stringBuilder.Append(" tunnel");
				}
			}
			stringBuilder.Append(" -> ");
			stringBuilder.Append(this.targetPathString);
			stringBuilder.Append(" (");
			stringBuilder.Append(value);
			stringBuilder.Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x04000122 RID: 290
		private Path _targetPath;

		// Token: 0x04000123 RID: 291
		private Object _targetContent;

		// Token: 0x04000126 RID: 294
		public PushPopType stackPushType;
	}
}
