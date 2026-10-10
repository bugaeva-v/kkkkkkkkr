using System;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Содержит код операций события, определенный в поставщике событий.
	///          Код операций определяет числовое значение, идентифицирующее действие или пункт действия, который приложение при вызове события.
	///       </summary>
	// Token: 0x020003B2 RID: 946
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class EventOpcode
	{
		// Token: 0x06001C3E RID: 7230 RVA: 0x0000235B File Offset: 0x0000055B
		internal EventOpcode()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает локализованное имя для кода операций событий.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую локализованное имя кода операций события.
		///       </returns>
		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x0005A05A File Offset: 0x0005825A
		public string DisplayName
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает нелокализованное имя кода операций события.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую нелокализованное имя кода операций события.
		///       </returns>
		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x0005A05A File Offset: 0x0005825A
		public string Name
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает числовое значение, связанное с кодом операций события.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///       </returns>
		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x0005AA28 File Offset: 0x00058C28
		public int Value
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}
	}
}
