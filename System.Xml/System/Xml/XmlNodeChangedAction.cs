using System;

namespace System.Xml
{
	/// <summary>
	///         Задает тип изменения узла.
	///       </summary>
	// Token: 0x020001C7 RID: 455
	public enum XmlNodeChangedAction
	{
		/// <summary>
		///         Узел вставляется в дерево.
		///       </summary>
		// Token: 0x0400109C RID: 4252
		Insert,
		/// <summary>
		///         Узел удаляется из дерева.
		///       </summary>
		// Token: 0x0400109D RID: 4253
		Remove,
		/// <summary>
		///         Изменяется значение узла.
		///       </summary>
		// Token: 0x0400109E RID: 4254
		Change
	}
}
