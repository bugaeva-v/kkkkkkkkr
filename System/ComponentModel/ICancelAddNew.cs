using System;

namespace System.ComponentModel
{
	/// <summary>Добавляет поддержку транзакций при добавлении нового элемента в коллекцию.</summary>
	// Token: 0x020003B1 RID: 945
	public interface ICancelAddNew
	{
		/// <summary>Удаляет незафиксированный новый элемент из коллекции.</summary>
		/// <param name="itemIndex">Индекс элемента, который был ранее добавлен в коллекцию.</param>
		// Token: 0x06001EF6 RID: 7926
		void CancelNew(int itemIndex);

		/// <summary>Фиксирует незафиксированный новый элемент в коллекции.</summary>
		/// <param name="itemIndex">Индекс элемента, который был ранее добавлен в коллекцию.</param>
		// Token: 0x06001EF7 RID: 7927
		void EndNew(int itemIndex);
	}
}
