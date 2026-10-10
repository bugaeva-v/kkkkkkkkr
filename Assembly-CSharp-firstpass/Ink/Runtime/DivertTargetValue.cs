using System;

namespace Ink.Runtime
{
	// Token: 0x0200003F RID: 63
	internal class DivertTargetValue : Value<Path>
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00011FE7 File Offset: 0x000101E7
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00011FEF File Offset: 0x000101EF
		public Path targetPath
		{
			get
			{
				return base.value;
			}
			set
			{
				base.value = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00011FF8 File Offset: 0x000101F8
		public override ValueType valueType
		{
			get
			{
				return ValueType.DivertTarget;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00011FFB File Offset: 0x000101FB
		public override bool isTruthy
		{
			get
			{
				throw new Exception("Shouldn't be checking the truthiness of a divert target");
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00012007 File Offset: 0x00010207
		public DivertTargetValue(Path targetPath) : base(targetPath)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00012010 File Offset: 0x00010210
		public DivertTargetValue() : base(null)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00012019 File Offset: 0x00010219
		public override Value Cast(ValueType newType)
		{
			if (newType == this.valueType)
			{
				return this;
			}
			throw new Exception("Unexpected type cast of Value to new ValueType");
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00012030 File Offset: 0x00010230
		public override string ToString()
		{
			string str = "DivertTargetValue(";
			Path targetPath = this.targetPath;
			return str + ((targetPath != null) ? targetPath.ToString() : null) + ")";
		}
	}
}
