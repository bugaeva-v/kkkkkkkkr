using System;

namespace System.ComponentModel
{
	/// <summary>Задает значения, указывающие, может ли свойство быть связано с элементом данных или другим свойством.</summary>
	// Token: 0x02000383 RID: 899
	public enum BindableSupport
	{
		/// <summary>Это свойство не может быть связано во время разработки.</summary>
		// Token: 0x04000EE3 RID: 3811
		No,
		/// <summary>Это свойство может быть связано во время разработки.</summary>
		// Token: 0x04000EE4 RID: 3812
		Yes,
		/// <summary>Свойство установлено равным значению по умолчанию.</summary>
		// Token: 0x04000EE5 RID: 3813
		Default
	}
}
