using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002A5 RID: 677
	[Serializable]
	internal class StyleProperty
	{
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x00061698 File Offset: 0x0005F898
		// (set) Token: 0x06001732 RID: 5938 RVA: 0x000616B0 File Offset: 0x0005F8B0
		public string name
		{
			get
			{
				return this.m_Name;
			}
			internal set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x000616BC File Offset: 0x0005F8BC
		// (set) Token: 0x06001734 RID: 5940 RVA: 0x000616D4 File Offset: 0x0005F8D4
		public int line
		{
			get
			{
				return this.m_Line;
			}
			internal set
			{
				this.m_Line = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x000616E0 File Offset: 0x0005F8E0
		// (set) Token: 0x06001736 RID: 5942 RVA: 0x000616F8 File Offset: 0x0005F8F8
		public StyleValueHandle[] values
		{
			get
			{
				return this.m_Values;
			}
			internal set
			{
				this.m_Values = value;
			}
		}

		// Token: 0x040009CE RID: 2510
		[SerializeField]
		private string m_Name;

		// Token: 0x040009CF RID: 2511
		[SerializeField]
		private int m_Line;

		// Token: 0x040009D0 RID: 2512
		[SerializeField]
		private StyleValueHandle[] m_Values;

		// Token: 0x040009D1 RID: 2513
		[NonSerialized]
		internal bool isCustomProperty;

		// Token: 0x040009D2 RID: 2514
		[NonSerialized]
		internal bool requireVariableResolve;
	}
}
