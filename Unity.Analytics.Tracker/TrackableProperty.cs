using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.Analytics
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	internal class TrackableProperty
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002893 File Offset: 0x00000A93
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000289B File Offset: 0x00000A9B
		public List<TrackableProperty.FieldWithTarget> fields
		{
			get
			{
				return this.m_Fields;
			}
			set
			{
				this.m_Fields = value;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000028A4 File Offset: 0x00000AA4
		public override int GetHashCode()
		{
			int num = 17;
			foreach (TrackableProperty.FieldWithTarget fieldWithTarget in this.m_Fields)
			{
				num = num * 23 + fieldWithTarget.paramName.GetHashCode();
			}
			return num;
		}

		// Token: 0x04000026 RID: 38
		public const int kMaxParams = 10;

		// Token: 0x04000027 RID: 39
		[SerializeField]
		private List<TrackableProperty.FieldWithTarget> m_Fields;

		// Token: 0x02000019 RID: 25
		[Serializable]
		internal class FieldWithTarget
		{
			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600005B RID: 91 RVA: 0x00003080 File Offset: 0x00001280
			// (set) Token: 0x0600005C RID: 92 RVA: 0x00003088 File Offset: 0x00001288
			public string paramName
			{
				get
				{
					return this.m_ParamName;
				}
				set
				{
					this.m_ParamName = value;
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x0600005D RID: 93 RVA: 0x00003091 File Offset: 0x00001291
			// (set) Token: 0x0600005E RID: 94 RVA: 0x00003099 File Offset: 0x00001299
			public Object target
			{
				get
				{
					return this.m_Target;
				}
				set
				{
					this.m_Target = value;
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600005F RID: 95 RVA: 0x000030A2 File Offset: 0x000012A2
			// (set) Token: 0x06000060 RID: 96 RVA: 0x000030AA File Offset: 0x000012AA
			public string fieldPath
			{
				get
				{
					return this.m_FieldPath;
				}
				set
				{
					this.m_FieldPath = value;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000061 RID: 97 RVA: 0x000030B3 File Offset: 0x000012B3
			// (set) Token: 0x06000062 RID: 98 RVA: 0x000030BB File Offset: 0x000012BB
			public string typeString
			{
				get
				{
					return this.m_TypeString;
				}
				set
				{
					this.m_TypeString = value;
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000063 RID: 99 RVA: 0x000030C4 File Offset: 0x000012C4
			// (set) Token: 0x06000064 RID: 100 RVA: 0x000030CC File Offset: 0x000012CC
			public bool doStatic
			{
				get
				{
					return this.m_DoStatic;
				}
				set
				{
					this.m_DoStatic = value;
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000065 RID: 101 RVA: 0x000030D5 File Offset: 0x000012D5
			// (set) Token: 0x06000066 RID: 102 RVA: 0x000030DD File Offset: 0x000012DD
			public string staticString
			{
				get
				{
					return this.m_StaticString;
				}
				set
				{
					this.m_StaticString = value;
				}
			}

			// Token: 0x06000067 RID: 103 RVA: 0x000030E8 File Offset: 0x000012E8
			public object GetValue()
			{
				if (this.m_DoStatic)
				{
					return this.m_StaticString;
				}
				object obj = this.m_Target;
				foreach (string name in this.m_FieldPath.Split(new char[]
				{
					'.'
				}))
				{
					Type type = obj.GetType();
					PropertyInfo property = type.GetProperty(name);
					FieldInfo field = type.GetField(name);
					if (property != null)
					{
						obj = property.GetValue(obj, null);
					}
					else
					{
						if (!(field != null))
						{
							return null;
						}
						obj = field.GetValue(obj);
					}
				}
				return obj;
			}

			// Token: 0x04000069 RID: 105
			[SerializeField]
			private string m_ParamName;

			// Token: 0x0400006A RID: 106
			[SerializeField]
			private Object m_Target;

			// Token: 0x0400006B RID: 107
			[SerializeField]
			private string m_FieldPath;

			// Token: 0x0400006C RID: 108
			[SerializeField]
			private string m_TypeString;

			// Token: 0x0400006D RID: 109
			[SerializeField]
			private bool m_DoStatic;

			// Token: 0x0400006E RID: 110
			[SerializeField]
			private string m_StaticString;
		}
	}
}
