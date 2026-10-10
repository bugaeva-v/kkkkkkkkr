using System;
using System.Collections.Generic;
using UnityEngine;

namespace DG.DemiLib
{
	// Token: 0x02000008 RID: 8
	public interface IEditorGUINode
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000012 RID: 18
		// (set) Token: 0x06000013 RID: 19
		string id { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000014 RID: 20
		// (set) Token: 0x06000015 RID: 21
		Vector2 guiPosition { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000016 RID: 22
		// (set) Token: 0x06000017 RID: 23
		List<string> connectedNodesIds { get; set; }
	}
}
