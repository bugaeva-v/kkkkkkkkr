using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Предоставляет инструкции по отображению для отладчика.</summary>
	// Token: 0x020009BA RID: 2490
	[ComVisible(true)]
	public enum DebuggerBrowsableState
	{
		/// <summary>Никогда не отображает элемент.</summary>
		// Token: 0x0400377C RID: 14204
		Never,
		/// <summary>Отобразите свернутый элемент.</summary>
		// Token: 0x0400377D RID: 14205
		Collapsed = 2,
		/// <summary>Не отображайте корневые элементы; отображайте дочерние элементы, если элемент является коллекцией или массивом элементов.</summary>
		// Token: 0x0400377E RID: 14206
		RootHidden
	}
}
