using System;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Содержит уровень события, определенный в поставщике событий.
	///          Данный уровень указывает серьезность события.
	///       </summary>
	// Token: 0x02000399 RID: 921
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class EventLevel
	{
		// Token: 0x06001B76 RID: 7030 RVA: 0x0000235B File Offset: 0x0000055B
		internal EventLevel()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает локализованное имя для уровня событий.
		///          Имя описывает уровень серьезности событий, этот уровень используется для.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую локализованное имя для уровня событий.
		///       </returns>
		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x0005A05A File Offset: 0x0005825A
		public string DisplayName
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает нелокализованное имя уровня событий.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую нелокализованное имя уровня событий.
		///       </returns>
		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x0005A05A File Offset: 0x0005825A
		public string Name
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает числовое значение уровня событий.
		///       </summary>
		/// <returns>
		///         Возвращает целочисленное значение.
		///       </returns>
		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x0005A550 File Offset: 0x00058750
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
