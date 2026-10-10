using System;

namespace System
{
	/// <summary>Задает сочетание управляющих клавиш и клавиш консоли, с помощью которого можно прервать работу текущего процесса.</summary>
	// Token: 0x020001C2 RID: 450
	public enum ConsoleSpecialKey
	{
		/// <summary>Управляющая клавиша <see cref="F:System.ConsoleModifiers.Control" /> плюс клавиша консоли <see cref="F:System.ConsoleKey.C" />.</summary>
		// Token: 0x04001441 RID: 5185
		ControlC,
		/// <summary>Управляющая клавиша <see cref="F:System.ConsoleModifiers.Control" /> плюс клавиша консоли BREAK.</summary>
		// Token: 0x04001442 RID: 5186
		ControlBreak
	}
}
