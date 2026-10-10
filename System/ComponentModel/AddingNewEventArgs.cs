using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Windows.Forms.BindingSource.AddingNew" />.</summary>
	// Token: 0x02000378 RID: 888
	public class AddingNewEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AddingNewEventArgs" /> без параметров.</summary>
		// Token: 0x06001D3F RID: 7487 RVA: 0x0000C759 File Offset: 0x0000A959
		public AddingNewEventArgs()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AddingNewEventArgs" />, используя заданный объект в качестве нового элемента.</summary>
		/// <param name="newObject">Объект <see cref="T:System.Object" />, используемый в качестве значения нового элемента.</param>
		// Token: 0x06001D40 RID: 7488 RVA: 0x0006876E File Offset: 0x0006696E
		public AddingNewEventArgs(object newObject)
		{
			this.NewObject = newObject;
		}

		/// <summary>Получает или задает объект, добавляемый в связанный список.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, добавляемый в качестве нового элемента в связанную коллекцию.</returns>
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x0006877D File Offset: 0x0006697D
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x00068785 File Offset: 0x00066985
		public object NewObject { get; set; }
	}
}
