using System;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Содержит значение свойства события, указанное поставщиком событий при публикации события.
	///       </summary>
	// Token: 0x020003AC RID: 940
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class EventProperty
	{
		// Token: 0x06001C01 RID: 7169 RVA: 0x0000235B File Offset: 0x0000055B
		internal EventProperty()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает значение свойства события, указанное поставщиком событий при публикации события.
		///       </summary>
		/// <returns>
		///         Возвращает объект.
		///       </returns>
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x0005A05A File Offset: 0x0005825A
		public object Value
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}
	}
}
