using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001A1 RID: 417
	[UsedByNativeCode]
	[Serializable]
	public struct BoneWeight1 : IEquatable<BoneWeight1>
	{
		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x00015F68 File Offset: 0x00014168
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00015F80 File Offset: 0x00014180
		public float weight
		{
			get
			{
				return this.m_Weight;
			}
			set
			{
				this.m_Weight = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x00015F8C File Offset: 0x0001418C
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x00015FA4 File Offset: 0x000141A4
		public int boneIndex
		{
			get
			{
				return this.m_BoneIndex;
			}
			set
			{
				this.m_BoneIndex = value;
			}
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00015FB0 File Offset: 0x000141B0
		public override bool Equals(object other)
		{
			return other is BoneWeight1 && this.Equals((BoneWeight1)other);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00015FDC File Offset: 0x000141DC
		public bool Equals(BoneWeight1 other)
		{
			return this.boneIndex.Equals(other.boneIndex) && this.weight.Equals(other.weight);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00016020 File Offset: 0x00014220
		public override int GetHashCode()
		{
			return this.boneIndex.GetHashCode() ^ this.weight.GetHashCode();
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00016050 File Offset: 0x00014250
		public static bool operator ==(BoneWeight1 lhs, BoneWeight1 rhs)
		{
			return lhs.boneIndex == rhs.boneIndex && lhs.weight == rhs.weight;
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00016088 File Offset: 0x00014288
		public static bool operator !=(BoneWeight1 lhs, BoneWeight1 rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x040005B7 RID: 1463
		[SerializeField]
		private float m_Weight;

		// Token: 0x040005B8 RID: 1464
		[SerializeField]
		private int m_BoneIndex;
	}
}
