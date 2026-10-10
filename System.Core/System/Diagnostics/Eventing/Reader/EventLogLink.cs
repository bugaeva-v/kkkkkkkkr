using System;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Представляет связь между поставщиком событий и журнал событий, в котором поставщик публикует данные событий.
	///          Невозможно создать экземпляр этого объекта.
	///       </summary>
	// Token: 0x020003A4 RID: 932
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class EventLogLink
	{
		// Token: 0x06001BBA RID: 7098 RVA: 0x0000235B File Offset: 0x0000055B
		internal EventLogLink()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Получает локализованное имя журнала событий.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую локализованное имя журнала событий.
		///       </returns>
		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x0005A05A File Offset: 0x0005825A
		public string DisplayName
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает логическое значение, которое определяет ли журнал событий импортируется, а не определен поставщик событий.
		///          Импортированный журнал событий определяется в другом поставщике.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> Если журнал событий импортируется поставщиком событий и возвращает <see langword="false" /> Если журнал событий не импортируется поставщиком событий.
		///       </returns>
		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x0005A7C0 File Offset: 0x000589C0
		public bool IsImported
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
		}

		/// <summary>
		///         Получает нелокализованное имя журнала событий, связанных с этим объектом.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую нелокализованное имя журнала событий, связанных с этим объектом.
		///       </returns>
		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x0005A05A File Offset: 0x0005825A
		public string LogName
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}
	}
}
