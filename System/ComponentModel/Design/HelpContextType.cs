using System;

namespace System.ComponentModel.Design
{
	/// <summary>Определяет идентификаторы, несущие данные о контексте, из которого был вызван запрос на предоставление справочных сведений.</summary>
	// Token: 0x02000453 RID: 1107
	public enum HelpContextType
	{
		/// <summary>Общий контекст.</summary>
		// Token: 0x040010C7 RID: 4295
		Ambient,
		/// <summary>Окно.</summary>
		// Token: 0x040010C8 RID: 4296
		Window,
		/// <summary>Выделение.</summary>
		// Token: 0x040010C9 RID: 4297
		Selection,
		/// <summary>Выделение окна средств.</summary>
		// Token: 0x040010CA RID: 4298
		ToolWindowSelection
	}
}
