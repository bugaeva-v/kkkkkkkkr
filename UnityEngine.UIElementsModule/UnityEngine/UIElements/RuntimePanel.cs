using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200024F RID: 591
	internal class RuntimePanel : BaseRuntimePanel, IRuntimePanel
	{
		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x00046908 File Offset: 0x00044B08
		public PanelSettings panelSettings
		{
			get
			{
				return this.m_PanelSettings;
			}
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00046910 File Offset: 0x00044B10
		public static RuntimePanel Create(ScriptableObject ownerObject)
		{
			return new RuntimePanel(ownerObject);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00046928 File Offset: 0x00044B28
		private RuntimePanel(ScriptableObject ownerObject) : base(ownerObject, RuntimePanel.s_EventDispatcher)
		{
			this.focusController = new FocusController(new NavigateFocusRing(this.visualTree));
			this.m_PanelSettings = (ownerObject as PanelSettings);
			base.name = ((this.m_PanelSettings != null) ? this.m_PanelSettings.name : "RuntimePanel");
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00046990 File Offset: 0x00044B90
		public override void Update()
		{
			bool flag = this.m_PanelSettings != null;
			if (flag)
			{
				this.m_PanelSettings.ApplyPanelSettings();
			}
			base.Update();
		}

		// Token: 0x0400080A RID: 2058
		internal static readonly EventDispatcher s_EventDispatcher = RuntimeEventDispatcher.Create();

		// Token: 0x0400080B RID: 2059
		private readonly PanelSettings m_PanelSettings;
	}
}
