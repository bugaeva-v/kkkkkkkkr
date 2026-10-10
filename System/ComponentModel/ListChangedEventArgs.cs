using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет данные для события <see cref="E:System.ComponentModel.IBindingList.ListChanged" />.</summary>
	// Token: 0x020003CD RID: 973
	public class ListChangedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ListChangedEventArgs" />, используя заданный тип изменения и индекс изменяемого элемента.</summary>
		/// <param name="listChangedType">Значение <see cref="T:System.ComponentModel.ListChangedType" />, показывающее тип изменения.</param>
		/// <param name="newIndex">Индекс элемента, который был добавлен, изменен или удален.</param>
		// Token: 0x06001F73 RID: 8051 RVA: 0x0006D55A File Offset: 0x0006B75A
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex) : this(listChangedType, newIndex, -1)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ListChangedEventArgs" />, используя заданный тип изменения, индекс изменяемого элемента и дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, описывающий изменяемый элемент.</summary>
		/// <param name="listChangedType">Значение <see cref="T:System.ComponentModel.ListChangedType" />, показывающее тип изменения.</param>
		/// <param name="newIndex">Индекс элемента, который был добавлен или изменен.</param>
		/// <param name="propDesc">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, описывающий элемент.</param>
		// Token: 0x06001F74 RID: 8052 RVA: 0x0006D565 File Offset: 0x0006B765
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) : this(listChangedType, newIndex)
		{
			this.PropertyDescriptor = propDesc;
			this.OldIndex = newIndex;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ListChangedEventArgs" />, используя заданный тип изменения и затрагиваемый дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />.</summary>
		/// <param name="listChangedType">Значение <see cref="T:System.ComponentModel.ListChangedType" />, показывающее тип изменения.</param>
		/// <param name="propDesc">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, который был добавлен, удален или изменен.</param>
		// Token: 0x06001F75 RID: 8053 RVA: 0x0006D57D File Offset: 0x0006B77D
		public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc)
		{
			this.ListChangedType = listChangedType;
			this.PropertyDescriptor = propDesc;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ListChangedEventArgs" />, используя заданный тип изменения, а также старый и новый индексы перемещенного элемента.</summary>
		/// <param name="listChangedType">Значение <see cref="T:System.ComponentModel.ListChangedType" />, показывающее тип изменения.</param>
		/// <param name="newIndex">Новый индекс перемещенного элемента.</param>
		/// <param name="oldIndex">Старый индекс перемещенного элемента.</param>
		// Token: 0x06001F76 RID: 8054 RVA: 0x0006D593 File Offset: 0x0006B793
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex)
		{
			this.ListChangedType = listChangedType;
			this.NewIndex = newIndex;
			this.OldIndex = oldIndex;
		}

		/// <summary>Получение типа изменения.</summary>
		/// <returns>Значение <see cref="T:System.ComponentModel.ListChangedType" />, показывающее тип изменения.</returns>
		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x0006D5B0 File Offset: 0x0006B7B0
		public ListChangedType ListChangedType { get; }

		/// <summary>Возвращает индекс элемента, затрагиваемого изменением.</summary>
		/// <returns>Индекс элемента, затрагиваемого изменением.</returns>
		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x0006D5B8 File Offset: 0x0006B7B8
		public int NewIndex { get; }

		/// <summary>Возвращает старый индекс перемещенного элемента.</summary>
		/// <returns>Старый индекс перемещенного элемента.</returns>
		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x0006D5C0 File Offset: 0x0006B7C0
		public int OldIndex { get; }

		/// <summary>Возвращает дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, который был добавлен, изменен или удален.</summary>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, затрагиваемый изменением.</returns>
		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x0006D5C8 File Offset: 0x0006B7C8
		public PropertyDescriptor PropertyDescriptor { get; }
	}
}
