using System;

namespace System.ComponentModel
{
	/// <summary>Задает видимость свойства для преобразователя этапа разработки.</summary>
	// Token: 0x02000369 RID: 873
	public enum DesignerSerializationVisibility
	{
		/// <summary>Генератор кода не создает код для объекта.</summary>
		// Token: 0x04000EAE RID: 3758
		Hidden,
		/// <summary>Генератор кода создает код для объекта.</summary>
		// Token: 0x04000EAF RID: 3759
		Visible,
		/// <summary>Генератор кода создает код для содержимого объекта, а не для самого объекта.</summary>
		// Token: 0x04000EB0 RID: 3760
		Content
	}
}
