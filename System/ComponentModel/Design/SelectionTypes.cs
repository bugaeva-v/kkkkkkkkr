using System;

namespace System.ComponentModel.Design
{
	/// <summary>Определяет идентификаторы, показывающие тип выделения.</summary>
	// Token: 0x02000470 RID: 1136
	[Flags]
	public enum SelectionTypes
	{
		/// <summary>Представляет обычное выделение. Служба выбора реагирует на нажатие клавиш CTRL and SHIFT для поддержки добавления или удаления компонентов выделения.</summary>
		// Token: 0x040010DB RID: 4315
		Auto = 1,
		/// <summary>Представляет обычное выделение. Служба выбора реагирует на нажатие клавиш CTRL and SHIFT для поддержки добавления или удаления компонентов выделения.</summary>
		// Token: 0x040010DC RID: 4316
		[Obsolete("This value has been deprecated. Use SelectionTypes.Auto instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		Normal = 1,
		/// <summary>Представляет выделение, возникающее при замещении содержимого выделения. Служба выбора заменяет текущее выделение на новое.</summary>
		// Token: 0x040010DD RID: 4317
		Replace = 2,
		/// <summary>Представляет выделение, возникающее при нажатии пользователем кнопки мыши, когда указатель мыши расположен на компоненте. Если этот компонент уже выделен, выделение не снимается, а компонент становится основным выделенным компонентом.</summary>
		// Token: 0x040010DE RID: 4318
		[Obsolete("This value has been deprecated.  It is no longer supported. http://go.microsoft.com/fwlink/?linkid=14202")]
		MouseDown = 4,
		/// <summary>Представляет выделение, возникающее при отпускании кнопки мыши сразу после того как компонент был выделен. Если вновь выделенный компонент уже выделен, это выделение не снимается, а компонент становится основным выделенным компонентом.</summary>
		// Token: 0x040010DF RID: 4319
		[Obsolete("This value has been deprecated.  It is no longer supported. http://go.microsoft.com/fwlink/?linkid=14202")]
		MouseUp = 8,
		/// <summary>Представляет выделение, возникающее при щелчке компонента пользователем. Если вновь выделенный компонент уже выделен, это выделение не снимается, а компонент становится основным выделенным компонентом.</summary>
		// Token: 0x040010E0 RID: 4320
		[Obsolete("This value has been deprecated. Use SelectionTypes.Primary instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		Click = 16,
		/// <summary>Представляет основное выделение, возникающее при щелчке компонента пользователем. Если компонент в списке выбора ужа выбран, этот компонент становится основным выбранным компонентом.</summary>
		// Token: 0x040010E1 RID: 4321
		Primary = 16,
		/// <summary>Представляет выделение переключения, при котором выполняется переключение между текущим выделением и предоставленным выделением. Если компонент уже выбран и передается в объект <see cref="Overload:System.ComponentModel.Design.ISelectionService.SetSelectedComponents" /> с типом выделения <see cref="F:System.ComponentModel.Design.SelectionTypes.Toggle" />, выбор компонента будет отменен.</summary>
		// Token: 0x040010E2 RID: 4322
		Toggle = 32,
		/// <summary>Представляет выбор для добавления, при котором выбранные компоненты добавляются в текущее выделение с сохранением текущего набора выбранных компонентов.</summary>
		// Token: 0x040010E3 RID: 4323
		Add = 64,
		/// <summary>Представляет выбор для удаления, при котором выбранные компоненты удаляются из текущего выделения с сохранением текущего набора выбранных компонентов.</summary>
		// Token: 0x040010E4 RID: 4324
		Remove = 128,
		/// <summary>Определяет допустимые типы выделений как поле <see cref="F:System.ComponentModel.Design.SelectionTypes.Normal" />, <see cref="F:System.ComponentModel.Design.SelectionTypes.Replace" />, <see cref="F:System.ComponentModel.Design.SelectionTypes.MouseDown" />, <see cref="F:System.ComponentModel.Design.SelectionTypes.MouseUp" /> или <see cref="F:System.ComponentModel.Design.SelectionTypes.Click" />.</summary>
		// Token: 0x040010E5 RID: 4325
		[Obsolete("This value has been deprecated. Use Enum class methods to determine valid values, or use a type converter. http://go.microsoft.com/fwlink/?linkid=14202")]
		Valid = 31
	}
}
