using System;

namespace System.Drawing.Printing
{
	/// <summary>Задает тип печати, разрешенной для выполнения кодом.</summary>
	// Token: 0x020000CB RID: 203
	public enum PrintingPermissionLevel
	{
		/// <summary>Обеспечивает полный доступ ко всем принтерам.</summary>
		// Token: 0x04000715 RID: 1813
		AllPrinting = 3,
		/// <summary>Предоставляет возможность программного вывода на печать на принтере по умолчанию с использованием безопасной печати из диалогового окна с половинным ограничением. <see cref="F:System.Drawing.Printing.PrintingPermissionLevel.DefaultPrinting" /> является подмножеством <see cref="F:System.Drawing.Printing.PrintingPermissionLevel.AllPrinting" />.</summary>
		// Token: 0x04000716 RID: 1814
		DefaultPrinting = 2,
		/// <summary>Предотвращает доступ к принтерам. <see cref="F:System.Drawing.Printing.PrintingPermissionLevel.NoPrinting" /> является подмножеством <see cref="F:System.Drawing.Printing.PrintingPermissionLevel.SafePrinting" />.</summary>
		// Token: 0x04000717 RID: 1815
		NoPrinting = 0,
		/// <summary>Предоставляет возможность печати только из ограниченного диалогового окна. <see cref="F:System.Drawing.Printing.PrintingPermissionLevel.SafePrinting" /> является подмножеством <see cref="F:System.Drawing.Printing.PrintingPermissionLevel.DefaultPrinting" />.</summary>
		// Token: 0x04000718 RID: 1816
		SafePrinting
	}
}
