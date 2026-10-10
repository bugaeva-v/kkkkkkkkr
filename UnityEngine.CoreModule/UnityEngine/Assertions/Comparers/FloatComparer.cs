using System;
using System.Collections.Generic;

namespace UnityEngine.Assertions.Comparers
{
	// Token: 0x0200048B RID: 1163
	public class FloatComparer : IEqualityComparer<float>
	{
		// Token: 0x06002935 RID: 10549 RVA: 0x000441D2 File Offset: 0x000423D2
		public FloatComparer() : this(1E-05f, false)
		{
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x000441E2 File Offset: 0x000423E2
		public FloatComparer(bool relative) : this(1E-05f, relative)
		{
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x000441F2 File Offset: 0x000423F2
		public FloatComparer(float error) : this(error, false)
		{
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x000441FE File Offset: 0x000423FE
		public FloatComparer(float error, bool relative)
		{
			this.m_Error = error;
			this.m_Relative = relative;
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x00044218 File Offset: 0x00042418
		public bool Equals(float a, float b)
		{
			return this.m_Relative ? FloatComparer.AreEqualRelative(a, b, this.m_Error) : FloatComparer.AreEqual(a, b, this.m_Error);
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x00044250 File Offset: 0x00042450
		public int GetHashCode(float obj)
		{
			return base.GetHashCode();
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x00044268 File Offset: 0x00042468
		public static bool AreEqual(float expected, float actual, float error)
		{
			return Math.Abs(actual - expected) <= error;
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00044288 File Offset: 0x00042488
		public static bool AreEqualRelative(float expected, float actual, float error)
		{
			bool flag = expected == actual;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				float num = Math.Abs(expected);
				float num2 = Math.Abs(actual);
				float num3 = Math.Abs((actual - expected) / ((num > num2) ? num : num2));
				result = (num3 <= error);
			}
			return result;
		}

		// Token: 0x04000FA1 RID: 4001
		private readonly float m_Error;

		// Token: 0x04000FA2 RID: 4002
		private readonly bool m_Relative;

		// Token: 0x04000FA3 RID: 4003
		public static readonly FloatComparer s_ComparerWithDefaultTolerance = new FloatComparer(1E-05f);

		// Token: 0x04000FA4 RID: 4004
		public const float kEpsilon = 1E-05f;
	}
}
