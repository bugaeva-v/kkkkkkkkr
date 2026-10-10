using System;

namespace System
{
	/// <summary>Представляет клавиши SHIFT, ALT и CTRL на клавиатуре.</summary>
	// Token: 0x020001C1 RID: 449
	[Flags]
	public enum ConsoleModifiers
	{
		/// <summary>Клавиша ALT слева и справа.</summary>
		// Token: 0x0400143D RID: 5181
		Alt = 1,
		/// <summary>Клавиша SHIFT слева и справа.</summary>
		// Token: 0x0400143E RID: 5182
		Shift = 2,
		/// <summary>Клавиша CTRL слева и справа.</summary>
		// Token: 0x0400143F RID: 5183
		Control = 4
	}
}
