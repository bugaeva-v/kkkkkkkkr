using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001B0 RID: 432
	internal struct StartDragArgs
	{
		// Token: 0x06000E2B RID: 3627 RVA: 0x0003ADAF File Offset: 0x00038FAF
		public StartDragArgs(string title, DragVisualMode visualMode)
		{
			this.title = title;
			this.visualMode = visualMode;
			this.genericData = null;
			this.unityObjectReferences = null;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0003ADD0 File Offset: 0x00038FD0
		internal StartDragArgs(string title, object target)
		{
			this.title = title;
			this.visualMode = 2;
			this.genericData = null;
			this.unityObjectReferences = null;
			this.SetGenericData("__unity-drag-and-drop__source-view", target);
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x0003ADFE File Offset: 0x00038FFE
		public readonly string title { get; }

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x0003AE06 File Offset: 0x00039006
		public readonly DragVisualMode visualMode { get; }

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x0003AE0E File Offset: 0x0003900E
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x0003AE16 File Offset: 0x00039016
		internal Hashtable genericData { readonly get; private set; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x0003AE1F File Offset: 0x0003901F
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x0003AE27 File Offset: 0x00039027
		internal IEnumerable<Object> unityObjectReferences { readonly get; private set; }

		// Token: 0x06000E33 RID: 3635 RVA: 0x0003AE30 File Offset: 0x00039030
		public void SetGenericData(string key, object data)
		{
			if (this.genericData == null)
			{
				this.genericData = new Hashtable();
			}
			this.genericData[key] = data;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0003AE62 File Offset: 0x00039062
		public void SetUnityObjectReferences(IEnumerable<Object> references)
		{
			this.unityObjectReferences = references;
		}
	}
}
