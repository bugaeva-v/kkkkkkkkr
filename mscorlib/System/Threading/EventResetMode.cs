using System;

namespace System.Threading
{
	/// <summary>Указывает, сбрасывается ли <see cref="T:System.Threading.EventWaitHandle" /> автоматически или вручную после получения сигнала.</summary>
	// Token: 0x0200028D RID: 653
	public enum EventResetMode
	{
		/// <summary>При получении сигнала <see cref="T:System.Threading.EventWaitHandle" /> сбрасывается автоматически после освобождения одиночного потока. При отсутствии ожидающих потоков <see cref="T:System.Threading.EventWaitHandle" /> остается сигнальным до тех пор, пока поток не блокируется и не сбрасывается после освобождения потока.</summary>
		// Token: 0x04001A38 RID: 6712
		AutoReset,
		/// <summary>При получении сигнала, <see cref="T:System.Threading.EventWaitHandle" /> высвобождает все ожидающие потоки и остается сигнальным до тех пор, пока не сбрасывается вручную.</summary>
		// Token: 0x04001A39 RID: 6713
		ManualReset
	}
}
