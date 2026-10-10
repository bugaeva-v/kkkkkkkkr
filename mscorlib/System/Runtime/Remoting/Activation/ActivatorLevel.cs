using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Activation
{
	/// <summary>Определяет подходящую позицию для <see cref="T:System.Activator" /> в цепи активаторов.</summary>
	// Token: 0x020005CC RID: 1484
	[ComVisible(true)]
	[Serializable]
	public enum ActivatorLevel
	{
		/// <summary>Конструирует пустой объект и запускает конструктор.</summary>
		// Token: 0x040025F4 RID: 9716
		Construction = 4,
		/// <summary>Находит или создает подходящий контекст.</summary>
		// Token: 0x040025F5 RID: 9717
		Context = 8,
		/// <summary>Находит или создает объект <see cref="T:System.AppDomain" />.</summary>
		// Token: 0x040025F6 RID: 9718
		AppDomain = 12,
		/// <summary>Запускает процесс.</summary>
		// Token: 0x040025F7 RID: 9719
		Process = 16,
		/// <summary>Находит подходящий компьютер.</summary>
		// Token: 0x040025F8 RID: 9720
		Machine = 20
	}
}
