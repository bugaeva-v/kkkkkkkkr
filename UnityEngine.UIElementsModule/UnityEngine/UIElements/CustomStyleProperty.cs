using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000273 RID: 627
	public struct CustomStyleProperty<T> : IEquatable<CustomStyleProperty<T>>
	{
		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00055BF3 File Offset: 0x00053DF3
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x00055BFB File Offset: 0x00053DFB
		public string name { readonly get; private set; }

		// Token: 0x0600139B RID: 5019 RVA: 0x00055C04 File Offset: 0x00053E04
		public CustomStyleProperty(string propertyName)
		{
			bool flag = !string.IsNullOrEmpty(propertyName) && !propertyName.StartsWith("--");
			if (flag)
			{
				throw new ArgumentException("Custom style property \"" + propertyName + "\" must start with \"--\" prefix.");
			}
			this.name = propertyName;
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00055C50 File Offset: 0x00053E50
		public override bool Equals(object obj)
		{
			bool flag = !(obj is CustomStyleProperty<T>);
			return !flag && this.Equals((CustomStyleProperty<T>)obj);
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00055C84 File Offset: 0x00053E84
		public bool Equals(CustomStyleProperty<T> other)
		{
			return this.name == other.name;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00055CA8 File Offset: 0x00053EA8
		public override int GetHashCode()
		{
			return this.name.GetHashCode();
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00055CC8 File Offset: 0x00053EC8
		public static bool operator ==(CustomStyleProperty<T> a, CustomStyleProperty<T> b)
		{
			return a.Equals(b);
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00055CE4 File Offset: 0x00053EE4
		public static bool operator !=(CustomStyleProperty<T> a, CustomStyleProperty<T> b)
		{
			return !(a == b);
		}
	}
}
