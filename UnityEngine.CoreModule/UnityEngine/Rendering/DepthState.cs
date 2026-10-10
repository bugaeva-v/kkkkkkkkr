using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003FC RID: 1020
	public struct DepthState : IEquatable<DepthState>
	{
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x0003A28C File Offset: 0x0003848C
		public static DepthState defaultValue
		{
			get
			{
				return new DepthState(true, CompareFunction.Less);
			}
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x0003A2A5 File Offset: 0x000384A5
		public DepthState(bool writeEnabled = true, CompareFunction compareFunction = CompareFunction.Less)
		{
			this.m_WriteEnabled = Convert.ToByte(writeEnabled);
			this.m_CompareFunction = (sbyte)compareFunction;
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x0003A2BC File Offset: 0x000384BC
		// (set) Token: 0x060022AA RID: 8874 RVA: 0x0003A2D9 File Offset: 0x000384D9
		public bool writeEnabled
		{
			get
			{
				return Convert.ToBoolean(this.m_WriteEnabled);
			}
			set
			{
				this.m_WriteEnabled = Convert.ToByte(value);
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x0003A2E8 File Offset: 0x000384E8
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x0003A300 File Offset: 0x00038500
		public CompareFunction compareFunction
		{
			get
			{
				return (CompareFunction)this.m_CompareFunction;
			}
			set
			{
				this.m_CompareFunction = (sbyte)value;
			}
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x0003A30C File Offset: 0x0003850C
		public bool Equals(DepthState other)
		{
			return this.m_WriteEnabled == other.m_WriteEnabled && this.m_CompareFunction == other.m_CompareFunction;
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x0003A340 File Offset: 0x00038540
		public override bool Equals(object obj)
		{
			bool flag = obj == null;
			return !flag && obj is DepthState && this.Equals((DepthState)obj);
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x0003A378 File Offset: 0x00038578
		public override int GetHashCode()
		{
			return this.m_WriteEnabled.GetHashCode() * 397 ^ this.m_CompareFunction.GetHashCode();
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x0003A3A8 File Offset: 0x000385A8
		public static bool operator ==(DepthState left, DepthState right)
		{
			return left.Equals(right);
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x0003A3C4 File Offset: 0x000385C4
		public static bool operator !=(DepthState left, DepthState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04000CD3 RID: 3283
		private byte m_WriteEnabled;

		// Token: 0x04000CD4 RID: 3284
		private sbyte m_CompareFunction;
	}
}
