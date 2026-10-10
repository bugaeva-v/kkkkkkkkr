using System;

namespace System.ComponentModel
{
	/// <summary>Показывает, что родительское свойство получает уведомление при изменении значения свойства, к которому применяется данный атрибут. Этот класс не наследуется.</summary>
	// Token: 0x02000434 RID: 1076
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class NotifyParentPropertyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.ComponentModel.NotifyParentPropertyAttribute" />, используя заданное значение, чтобы определить, уведомляется ли родительское свойство об изменениях значения свойства.</summary>
		/// <param name="notifyParent">Значение <see langword="true" />, если родительское свойство должно быть уведомлено об изменениях; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600235A RID: 9050 RVA: 0x00080C4E File Offset: 0x0007EE4E
		public NotifyParentPropertyAttribute(bool notifyParent)
		{
			this.notifyParent = notifyParent;
		}

		/// <summary>Возвращает или задает значение, показывающее, должно ли родительское свойство уведомляться об изменениях значения свойства.</summary>
		/// <returns>Значение <see langword="true" />, если родительское свойство должно быть уведомлено об изменениях; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x00080C5D File Offset: 0x0007EE5D
		public bool NotifyParent
		{
			get
			{
				return this.notifyParent;
			}
		}

		/// <summary>Возвращает значение, показывающее, совпадает ли заданный объект с текущим.</summary>
		/// <param name="obj">Объект для проверки на равенство.</param>
		/// <returns>Значение <see langword="true" />, если заданный объект совпадает с текущим; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600235C RID: 9052 RVA: 0x00080C65 File Offset: 0x0007EE65
		public override bool Equals(object obj)
		{
			return obj == this || (obj != null && obj is NotifyParentPropertyAttribute && ((NotifyParentPropertyAttribute)obj).NotifyParent == this.notifyParent);
		}

		/// <summary>Получает хэш-код для этого объекта.</summary>
		/// <returns>Хэш-код для объекта, которому принадлежит данный атрибут.</returns>
		// Token: 0x0600235D RID: 9053 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Возвращает значение, показывающее, является ли текущее значение атрибута его значением по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если текущим значением атрибута является значение атрибута по умолчанию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600235E RID: 9054 RVA: 0x00080C8D File Offset: 0x0007EE8D
		public override bool IsDefaultAttribute()
		{
			return this.Equals(NotifyParentPropertyAttribute.Default);
		}

		/// <summary>Показывает, что родительское свойство уведомляется об изменениях значения свойства. Это поле доступно только для чтения.</summary>
		// Token: 0x04001098 RID: 4248
		public static readonly NotifyParentPropertyAttribute Yes = new NotifyParentPropertyAttribute(true);

		/// <summary>Показывает, что родительское свойство не уведомляется об изменениях значения свойства. Это поле доступно только для чтения.</summary>
		// Token: 0x04001099 RID: 4249
		public static readonly NotifyParentPropertyAttribute No = new NotifyParentPropertyAttribute(false);

		/// <summary>Показывает состояние атрибута по умолчанию — свойство не должно уведомлять родительское свойство об изменениях своего значения. Это поле доступно только для чтения.</summary>
		// Token: 0x0400109A RID: 4250
		public static readonly NotifyParentPropertyAttribute Default = NotifyParentPropertyAttribute.No;

		// Token: 0x0400109B RID: 4251
		private bool notifyParent;
	}
}
