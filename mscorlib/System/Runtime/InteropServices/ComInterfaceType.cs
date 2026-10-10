using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Определяет способ предоставления интерфейса модели COM.</summary>
	// Token: 0x020006E6 RID: 1766
	[ComVisible(true)]
	[Serializable]
	public enum ComInterfaceType
	{
		/// <summary>Указывает, что интерфейс предоставляется модели COM в качестве сдвоенного интерфейса, который обеспечивает раннее и позднее связывание. По умолчанию устанавливается значение <see cref="F:System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual" />.</summary>
		// Token: 0x04002A2F RID: 10799
		InterfaceIsDual,
		/// <summary>Указывает, что интерфейс предоставляется модели COM в качестве интерфейса, производного от IUnknown, который обеспечивает только раннее связывание.</summary>
		// Token: 0x04002A30 RID: 10800
		InterfaceIsIUnknown,
		/// <summary>Указывает, что интерфейс предоставляется модели COM в качестве dispinterface, который обеспечивает только позднее связывание.</summary>
		// Token: 0x04002A31 RID: 10801
		InterfaceIsIDispatch,
		/// <summary>Указывает, что интерфейс предоставляется модели COM в качестве интерфейса Среда выполнения Windows.</summary>
		// Token: 0x04002A32 RID: 10802
		[ComVisible(false)]
		InterfaceIsIInspectable
	}
}
