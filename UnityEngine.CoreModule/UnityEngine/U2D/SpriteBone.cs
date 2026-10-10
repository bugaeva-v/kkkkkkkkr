using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D
{
	// Token: 0x02000273 RID: 627
	[RequiredByNativeCode]
	[MovedFrom("UnityEngine.Experimental.U2D")]
	[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
	[NativeType(CodegenOptions.Custom, "ScriptingSpriteBone")]
	[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
	[Serializable]
	public struct SpriteBone
	{
		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x0002B930 File Offset: 0x00029B30
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x0002B948 File Offset: 0x00029B48
		public string name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x0002B954 File Offset: 0x00029B54
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x0002B96C File Offset: 0x00029B6C
		public string guid
		{
			get
			{
				return this.m_Guid;
			}
			set
			{
				this.m_Guid = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x0002B978 File Offset: 0x00029B78
		// (set) Token: 0x06001B2C RID: 6956 RVA: 0x0002B990 File Offset: 0x00029B90
		public Vector3 position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				this.m_Position = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x0002B99C File Offset: 0x00029B9C
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x0002B9B4 File Offset: 0x00029BB4
		public Quaternion rotation
		{
			get
			{
				return this.m_Rotation;
			}
			set
			{
				this.m_Rotation = value;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x0002B9C0 File Offset: 0x00029BC0
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x0002B9D8 File Offset: 0x00029BD8
		public float length
		{
			get
			{
				return this.m_Length;
			}
			set
			{
				this.m_Length = value;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x0002B9E4 File Offset: 0x00029BE4
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x0002B9FC File Offset: 0x00029BFC
		public int parentId
		{
			get
			{
				return this.m_ParentId;
			}
			set
			{
				this.m_ParentId = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x0002BA08 File Offset: 0x00029C08
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x0002BA20 File Offset: 0x00029C20
		public Color32 color
		{
			get
			{
				return this.m_Color;
			}
			set
			{
				this.m_Color = value;
			}
		}

		// Token: 0x040008F1 RID: 2289
		[SerializeField]
		[NativeName("name")]
		private string m_Name;

		// Token: 0x040008F2 RID: 2290
		[NativeName("guid")]
		[SerializeField]
		private string m_Guid;

		// Token: 0x040008F3 RID: 2291
		[SerializeField]
		[NativeName("position")]
		private Vector3 m_Position;

		// Token: 0x040008F4 RID: 2292
		[NativeName("rotation")]
		[SerializeField]
		private Quaternion m_Rotation;

		// Token: 0x040008F5 RID: 2293
		[SerializeField]
		[NativeName("length")]
		private float m_Length;

		// Token: 0x040008F6 RID: 2294
		[NativeName("parentId")]
		[SerializeField]
		private int m_ParentId;

		// Token: 0x040008F7 RID: 2295
		[NativeName("color")]
		[SerializeField]
		private Color32 m_Color;
	}
}
