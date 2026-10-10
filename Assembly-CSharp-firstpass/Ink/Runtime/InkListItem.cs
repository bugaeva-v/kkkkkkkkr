using System;

namespace Ink.Runtime
{
	// Token: 0x02000029 RID: 41
	public struct InkListItem
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00009C7D File Offset: 0x00007E7D
		public InkListItem(string originName, string itemName)
		{
			this.originName = originName;
			this.itemName = itemName;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00009C90 File Offset: 0x00007E90
		public InkListItem(string fullName)
		{
			string[] array = fullName.Split('.', StringSplitOptions.None);
			this.originName = array[0];
			this.itemName = array[1];
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00009CB9 File Offset: 0x00007EB9
		internal static InkListItem Null
		{
			get
			{
				return new InkListItem(null, null);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00009CC2 File Offset: 0x00007EC2
		internal bool isNull
		{
			get
			{
				return this.originName == null && this.itemName == null;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00009CD7 File Offset: 0x00007ED7
		public string fullName
		{
			get
			{
				return (this.originName ?? "?") + "." + this.itemName;
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00009CF8 File Offset: 0x00007EF8
		public override string ToString()
		{
			return this.fullName;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00009D00 File Offset: 0x00007F00
		public override bool Equals(object obj)
		{
			if (obj is InkListItem)
			{
				InkListItem inkListItem = (InkListItem)obj;
				return inkListItem.itemName == this.itemName && inkListItem.originName == this.originName;
			}
			return false;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00009D44 File Offset: 0x00007F44
		public override int GetHashCode()
		{
			int num = 0;
			int hashCode = this.itemName.GetHashCode();
			if (this.originName != null)
			{
				num = this.originName.GetHashCode();
			}
			return num + hashCode;
		}

		// Token: 0x0400012F RID: 303
		public readonly string originName;

		// Token: 0x04000130 RID: 304
		public readonly string itemName;
	}
}
