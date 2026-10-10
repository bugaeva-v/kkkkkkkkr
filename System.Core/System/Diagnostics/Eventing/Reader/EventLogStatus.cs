using System;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Содержит код состояния или код ошибки для определенного журнала событий.
	///          Это состояние может использоваться, чтобы определить, доступно ли журнал событий для операции.
	///       </summary>
	// Token: 0x020003AA RID: 938
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class EventLogStatus
	{
		// Token: 0x06001BE0 RID: 7136 RVA: 0x0000235B File Offset: 0x0000055B
		internal EventLogStatus()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает имя журнала событий, для которого производится получение кода состояния.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую имя журнала событий, для которого производится получение кода состояния.
		///       </returns>
		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x0005A05A File Offset: 0x0005825A
		public string LogName
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает код состояния или код ошибки в журнале событий.
		///          Данное состояние или ошибка является результатом операции подписки или чтения журнала событий.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///       </returns>
		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x0005A830 File Offset: 0x00058A30
		public int StatusCode
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}
	}
}
