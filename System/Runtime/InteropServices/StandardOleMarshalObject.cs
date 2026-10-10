using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Заменяет стандартный независимый от потока модуль упаковки и передачи среды CLR на стандартный модуль упаковки и передачи STA OLE.</summary>
	// Token: 0x02000186 RID: 390
	[MonoLimitation("The runtime does nothing special apart from what it already does with marshal-by-ref objects")]
	[ComVisible(true)]
	public class StandardOleMarshalObject : MarshalByRefObject
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.StandardOleMarshalObject" />.</summary>
		// Token: 0x06000A6F RID: 2671 RVA: 0x0002D758 File Offset: 0x0002B958
		protected StandardOleMarshalObject()
		{
		}
	}
}
