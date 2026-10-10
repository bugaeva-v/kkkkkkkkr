using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Содержит массив строк, представляющих запросы XPath для элементов в XML-представление события, который основан на Event Schema.
	///          Запросы в данном объекте используются для извлечения значений из события.
	///       </summary>
	// Token: 0x020003A6 RID: 934
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class EventLogPropertySelector : IDisposable
	{
		/// <summary>
		///         Инициализирует новый <see cref="T:System.Diagnostics.Eventing.Reader.EventLogPropertySelector" /> экземпляра класса.
		///       </summary>
		/// <param name="propertyQueries">
		///           Запросы XPath, используемые для извлечения значений из XML-представление события.
		///         </param>
		// Token: 0x06001BC2 RID: 7106 RVA: 0x0000235B File Offset: 0x0000055B
		[SecurityCritical]
		public EventLogPropertySelector(IEnumerable<string> propertyQueries)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Освобождает все ресурсы, используемые этим объектом.
		///       </summary>
		// Token: 0x06001BC3 RID: 7107 RVA: 0x0000235B File Offset: 0x0000055B
		public void Dispose()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Освобождает неуправляемые ресурсы, используемые этим объектом и при необходимости освобождает также управляемые ресурсы.
		///       </summary>
		/// <param name="disposing">
		///           Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.
		///         </param>
		// Token: 0x06001BC4 RID: 7108 RVA: 0x0000235B File Offset: 0x0000055B
		[SecuritySafeCritical]
		protected virtual void Dispose(bool disposing)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
