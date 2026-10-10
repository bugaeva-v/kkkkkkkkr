using System;

namespace Ink.Runtime
{
	// Token: 0x02000040 RID: 64
	internal class VariablePointerValue : Value<string>
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00012053 File Offset: 0x00010253
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0001205B File Offset: 0x0001025B
		public string variableName
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00012064 File Offset: 0x00010264
		public override ValueType valueType
		{
			get
			{
				return ValueType.VariablePointer;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00012067 File Offset: 0x00010267
		public override bool isTruthy
		{
			get
			{
				throw new Exception("Shouldn't be checking the truthiness of a variable pointer");
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00012073 File Offset: 0x00010273
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0001207B File Offset: 0x0001027B
		public int contextIndex { get; set; }

		// Token: 0x0600029E RID: 670 RVA: 0x00012084 File Offset: 0x00010284
		public VariablePointerValue(string variableName, int contextIndex = -1) : base(variableName)
		{
			this.contextIndex = contextIndex;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00012094 File Offset: 0x00010294
		public VariablePointerValue() : this(null, -1)
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0001209E File Offset: 0x0001029E
		public override Value Cast(ValueType newType)
		{
			if (newType == this.valueType)
			{
				return this;
			}
			throw new Exception("Unexpected type cast of Value to new ValueType");
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000120B5 File Offset: 0x000102B5
		public override string ToString()
		{
			return "VariablePointerValue(" + this.variableName + ")";
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000120CC File Offset: 0x000102CC
		internal override Object Copy()
		{
			return new VariablePointerValue(this.variableName, this.contextIndex);
		}
	}
}
