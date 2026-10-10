using System;

namespace System.ComponentModel.Composition
{
	/// <summary>Уведомляет часть о том, что ее импорты были удовлетворены.</summary>
	// Token: 0x02000043 RID: 67
	public interface IPartImportsSatisfiedNotification
	{
		/// <summary>Вызывается, если импорты части удовлетворены и использование части безопасно.</summary>
		// Token: 0x060001E2 RID: 482
		void OnImportsSatisfied();
	}
}
