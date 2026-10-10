using System;
using System.Collections.Generic;

namespace App42Json
{
	// Token: 0x02000068 RID: 104
	internal struct ObjectMetadata
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00015AC6 File Offset: 0x00013CC6
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00015AE1 File Offset: 0x00013CE1
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

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00015AEA File Offset: 0x00013CEA
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00015AF2 File Offset: 0x00013CF2
		public bool IsDictionary
		{
			get
			{
				return this.is_dictionary;
			}
			set
			{
				this.is_dictionary = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00015AFB File Offset: 0x00013CFB
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00015B03 File Offset: 0x00013D03
		public IDictionary<string, PropertyMetadata> Properties
		{
			get
			{
				return this.properties;
			}
			set
			{
				this.properties = value;
			}
		}

		// Token: 0x0400019E RID: 414
		private Type element_type;

		// Token: 0x0400019F RID: 415
		private bool is_dictionary;

		// Token: 0x040001A0 RID: 416
		private IDictionary<string, PropertyMetadata> properties;
	}
}
