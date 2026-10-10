using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Представляет обобщенный формат буфера обмена.</summary>
	// Token: 0x0200018A RID: 394
	public struct FORMATETC
	{
		/// <summary>Задает определенный формат буфера обмена.</summary>
		// Token: 0x04000700 RID: 1792
		[MarshalAs(UnmanagedType.U2)]
		public short cfFormat;

		/// <summary>Задает одну из констант перечисления <see cref="T:System.Runtime.InteropServices.ComTypes.DVASPECT" />, указывающую, сколько сведений должно содержаться в отрисовке.</summary>
		// Token: 0x04000701 RID: 1793
		[MarshalAs(UnmanagedType.U4)]
		public DVASPECT dwAspect;

		/// <summary>Задает часть аспекта, когда данные должны быть разделены по разным страницам.</summary>
		// Token: 0x04000702 RID: 1794
		public int lindex;

		/// <summary>Задает указатель на структуру <see langword="DVTARGETDEVICE" />, содержащую сведения о целевом устройстве, для которого формируются данные.</summary>
		// Token: 0x04000703 RID: 1795
		public IntPtr ptd;

		/// <summary>Задает одну из констант перечисления <see cref="T:System.Runtime.InteropServices.ComTypes.TYMED" />, которая указывает тип среды хранения, используемой для передачи данных объекта.</summary>
		// Token: 0x04000704 RID: 1796
		[MarshalAs(UnmanagedType.U4)]
		public TYMED tymed;
	}
}
