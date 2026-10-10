using System;

namespace UnityEngine
{
	// Token: 0x02000258 RID: 600
	[Serializable]
	public struct Pose : IEquatable<Pose>
	{
		// Token: 0x060019F6 RID: 6646 RVA: 0x00029F3C File Offset: 0x0002813C
		public Pose(Vector3 position, Quaternion rotation)
		{
			this.position = position;
			this.rotation = rotation;
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00029F50 File Offset: 0x00028150
		public override string ToString()
		{
			return UnityString.Format("({0}, {1})", new object[]
			{
				this.position.ToString(),
				this.rotation.ToString()
			});
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00029F9C File Offset: 0x0002819C
		public string ToString(string format)
		{
			return UnityString.Format("({0}, {1})", new object[]
			{
				this.position.ToString(format),
				this.rotation.ToString(format)
			});
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00029FDC File Offset: 0x000281DC
		public Pose GetTransformedBy(Pose lhs)
		{
			return new Pose
			{
				position = lhs.position + lhs.rotation * this.position,
				rotation = lhs.rotation * this.rotation
			};
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0002A034 File Offset: 0x00028234
		public Pose GetTransformedBy(Transform lhs)
		{
			return new Pose
			{
				position = lhs.TransformPoint(this.position),
				rotation = lhs.rotation * this.rotation
			};
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x0002A07C File Offset: 0x0002827C
		public Vector3 forward
		{
			get
			{
				return this.rotation * Vector3.forward;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x0002A0A0 File Offset: 0x000282A0
		public Vector3 right
		{
			get
			{
				return this.rotation * Vector3.right;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x0002A0C4 File Offset: 0x000282C4
		public Vector3 up
		{
			get
			{
				return this.rotation * Vector3.up;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x0002A0E8 File Offset: 0x000282E8
		public static Pose identity
		{
			get
			{
				return Pose.k_Identity;
			}
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0002A100 File Offset: 0x00028300
		public override bool Equals(object obj)
		{
			bool flag = !(obj is Pose);
			return !flag && this.Equals((Pose)obj);
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0002A134 File Offset: 0x00028334
		public bool Equals(Pose other)
		{
			return this.position.Equals(other.position) && this.rotation.Equals(other.rotation);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0002A170 File Offset: 0x00028370
		public override int GetHashCode()
		{
			return this.position.GetHashCode() ^ this.rotation.GetHashCode() << 1;
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0002A1A8 File Offset: 0x000283A8
		public static bool operator ==(Pose a, Pose b)
		{
			return a.position == b.position && a.rotation.Equals(b.rotation);
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0002A1E4 File Offset: 0x000283E4
		public static bool operator !=(Pose a, Pose b)
		{
			return !(a == b);
		}

		// Token: 0x04000894 RID: 2196
		public Vector3 position;

		// Token: 0x04000895 RID: 2197
		public Quaternion rotation;

		// Token: 0x04000896 RID: 2198
		private static readonly Pose k_Identity = new Pose(Vector3.zero, Quaternion.identity);
	}
}
