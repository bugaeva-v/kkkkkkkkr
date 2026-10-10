using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001E5 RID: 485
	[UsedByNativeCode]
	public struct PropertyName : IEquatable<PropertyName>
	{
		// Token: 0x060015F4 RID: 5620 RVA: 0x00023436 File Offset: 0x00021636
		public PropertyName(string name)
		{
			this = new PropertyName(PropertyNameUtils.PropertyNameFromString(name));
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00023446 File Offset: 0x00021646
		public PropertyName(PropertyName other)
		{
			this.id = other.id;
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00023455 File Offset: 0x00021655
		public PropertyName(int id)
		{
			this.id = id;
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00023460 File Offset: 0x00021660
		public static bool IsNullOrEmpty(PropertyName prop)
		{
			return prop.id == 0;
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x0002347C File Offset: 0x0002167C
		public static bool operator ==(PropertyName lhs, PropertyName rhs)
		{
			return lhs.id == rhs.id;
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x0002349C File Offset: 0x0002169C
		public static bool operator !=(PropertyName lhs, PropertyName rhs)
		{
			return lhs.id != rhs.id;
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x000234C0 File Offset: 0x000216C0
		public override int GetHashCode()
		{
			return this.id;
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x000234D8 File Offset: 0x000216D8
		public override bool Equals(object other)
		{
			return other is PropertyName && this.Equals((PropertyName)other);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00023504 File Offset: 0x00021704
		public bool Equals(PropertyName other)
		{
			return this == other;
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00023524 File Offset: 0x00021724
		public static implicit operator PropertyName(string name)
		{
			return new PropertyName(name);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x0002353C File Offset: 0x0002173C
		public static implicit operator PropertyName(int id)
		{
			return new PropertyName(id);
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00023554 File Offset: 0x00021754
		public override string ToString()
		{
			return string.Format("Unknown:{0}", this.id);
		}

		// Token: 0x040007C4 RID: 1988
		internal int id;
	}
}
