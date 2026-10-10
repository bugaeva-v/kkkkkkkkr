using System;

namespace System.ComponentModel
{
	/// <summary>Определяет, можно ли привязать этот шаблон односторонним или двусторонним образом.</summary>
	// Token: 0x02000384 RID: 900
	public enum BindingDirection
	{
		/// <summary>Шаблон может только принимать значения свойств. Используется с общим шаблоном <see cref="T:System.Web.UI.ITemplate" />.</summary>
		// Token: 0x04000EE7 RID: 3815
		OneWay,
		/// <summary>Шаблон может принимать и предоставлять значения свойств. Используется с шаблоном <see cref="T:System.Web.UI.IBindableTemplate" />.</summary>
		// Token: 0x04000EE8 RID: 3816
		TwoWay
	}
}
