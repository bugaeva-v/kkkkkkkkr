using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000276 RID: 630
	public struct EasingFunction : IEquatable<EasingFunction>
	{
		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x00055D00 File Offset: 0x00053F00
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x00055D08 File Offset: 0x00053F08
		public EasingMode mode
		{
			get
			{
				return this.m_Mode;
			}
			set
			{
				this.m_Mode = value;
			}
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00055D11 File Offset: 0x00053F11
		public EasingFunction(EasingMode mode)
		{
			this.m_Mode = mode;
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00055D1C File Offset: 0x00053F1C
		public static implicit operator EasingFunction(EasingMode easingMode)
		{
			return new EasingFunction(easingMode);
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00055D34 File Offset: 0x00053F34
		public static bool operator ==(EasingFunction lhs, EasingFunction rhs)
		{
			return lhs.m_Mode == rhs.m_Mode;
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00055D54 File Offset: 0x00053F54
		public static bool operator !=(EasingFunction lhs, EasingFunction rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00055D70 File Offset: 0x00053F70
		public bool Equals(EasingFunction other)
		{
			return other == this;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00055D90 File Offset: 0x00053F90
		public override bool Equals(object obj)
		{
			bool result;
			if (obj is EasingFunction)
			{
				EasingFunction other = (EasingFunction)obj;
				result = this.Equals(other);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00055DBC File Offset: 0x00053FBC
		public override string ToString()
		{
			return this.m_Mode.ToString();
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00055DE0 File Offset: 0x00053FE0
		public override int GetHashCode()
		{
			return (int)this.m_Mode;
		}

		// Token: 0x04000916 RID: 2326
		private EasingMode m_Mode;
	}
}
