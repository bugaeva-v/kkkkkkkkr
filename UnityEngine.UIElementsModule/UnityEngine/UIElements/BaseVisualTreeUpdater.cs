using System;
using System.Diagnostics;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000102 RID: 258
	internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater, IDisposable
	{
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060007F1 RID: 2033 RVA: 0x0001D704 File Offset: 0x0001B904
		// (remove) Token: 0x060007F2 RID: 2034 RVA: 0x0001D73C File Offset: 0x0001B93C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<BaseVisualElementPanel> panelChanged;

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0001D774 File Offset: 0x0001B974
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x0001D78C File Offset: 0x0001B98C
		public BaseVisualElementPanel panel
		{
			get
			{
				return this.m_Panel;
			}
			set
			{
				this.m_Panel = value;
				bool flag = this.panelChanged != null;
				if (flag)
				{
					this.panelChanged(value);
				}
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0001D7BC File Offset: 0x0001B9BC
		public VisualElement visualTree
		{
			get
			{
				return this.panel.visualTree;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060007F6 RID: 2038
		public abstract ProfilerMarker profilerMarker { get; }

		// Token: 0x060007F7 RID: 2039 RVA: 0x0001D7D9 File Offset: 0x0001B9D9
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00002166 File Offset: 0x00000366
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060007F9 RID: 2041
		public abstract void Update();

		// Token: 0x060007FA RID: 2042
		public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);

		// Token: 0x0400034B RID: 843
		private BaseVisualElementPanel m_Panel;
	}
}
