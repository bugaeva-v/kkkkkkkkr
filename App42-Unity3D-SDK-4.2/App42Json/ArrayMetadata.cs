using System;

namespace App42Json
{
	// Token: 0x02000067 RID: 103
	internal struct ArrayMetadata
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00015A80 File Offset: 0x00013C80
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00015A9B File Offset: 0x00013C9B
		public Type ElementType
		{
			get
			{
				if (this.element_type == null)
				{
					return typeof(JsonData);
				}
				return this.element_type;
			}
			set
			{
				this.element_type = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00015AA4 File Offset: 0x00013CA4
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00015AAC File Offset: 0x00013CAC
		public bool IsArray
		{
			get
			{
				return this.is_array;
			}
			set
			{
				this.is_array = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00015AB5 File Offset: 0x00013CB5
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x00015ABD File Offset: 0x00013CBD
		public bool IsList
		{
			get
			{
				return this.is_list;
			}
			set
			{
				this.is_list = value;
			}
		}

		// Token: 0x0400019B RID: 411
		private Type element_type;

		// Token: 0x0400019C RID: 412
		private bool is_array;

		// Token: 0x0400019D RID: 413
		private bool is_list;
	}
}
