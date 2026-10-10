using System;

namespace System.IO.Ports
{
	/// <summary>Задает бит четности для объекта <see cref="T:System.IO.Ports.SerialPort" />.</summary>
	// Token: 0x0200052C RID: 1324
	public enum Parity
	{
		/// <summary>Контроль четности не осуществляется.</summary>
		// Token: 0x0400170A RID: 5898
		None,
		/// <summary>Устанавливает бит четности так, чтобы число установленных битов всегда было нечетным.</summary>
		// Token: 0x0400170B RID: 5899
		Odd,
		/// <summary>Устанавливает бит четности так, чтобы число установленных битов всегда было четным.</summary>
		// Token: 0x0400170C RID: 5900
		Even,
		/// <summary>Оставляет бит четности равным 1.</summary>
		// Token: 0x0400170D RID: 5901
		Mark,
		/// <summary>Оставляет бит четности равным 0.</summary>
		// Token: 0x0400170E RID: 5902
		Space
	}
}
