using System;

namespace System.ComponentModel
{
	/// <summary>Определяет, как изменяется коллекция.</summary>
	// Token: 0x0200038A RID: 906
	public enum CollectionChangeAction
	{
		/// <summary>Указывает, что в коллекцию был добавлен элемент.</summary>
		// Token: 0x04000EF7 RID: 3831
		Add = 1,
		/// <summary>Указывает, что из коллекции был удален элемент.</summary>
		// Token: 0x04000EF8 RID: 3832
		Remove,
		/// <summary>Указывает, что вся коллекция изменилась. Такие изменения совершаются методами, работающими сразу со всей коллекцией, например, <see cref="M:System.Collections.CollectionBase.Clear" />.</summary>
		// Token: 0x04000EF9 RID: 3833
		Refresh
	}
}
