using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Представляет часть работы, связанную с транзакцией. Эта структура применяется в объекте <see cref="T:System.EnterpriseServices.XACTTRANSINFO" />.</summary>
	// Token: 0x02000013 RID: 19
	[ComVisible(false)]
	public struct BOID
	{
		/// <summary>Представляет массив, который содержит данные.</summary>
		// Token: 0x04000046 RID: 70
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public byte[] rgb;
	}
}
