using System;
using System.Collections.Generic;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>
	///         Содержит метаданные (свойства и параметры) для события, определенного в поставщике событий.
	///       </summary>
	// Token: 0x020003B1 RID: 945
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class EventMetadata
	{
		// Token: 0x06001C34 RID: 7220 RVA: 0x0000235B File Offset: 0x0000055B
		internal EventMetadata()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Получает шаблон описания, связанный с событием, использующим язык текущего потока для языка описания.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую шаблон описания, связанный с событием.
		///       </returns>
		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x0005A05A File Offset: 0x0005825A
		public string Description
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает идентификатор события, определенный в поставщике событий.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="long" /> значение, являющееся идентификатором события.
		///       </returns>
		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x0005A9F0 File Offset: 0x00058BF0
		public long Id
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0L;
			}
		}

		/// <summary>
		///         Возвращает ключевые слова, связанные с событием, определенным в поставщике событий.
		///       </summary>
		/// <returns>
		///         Возвращает перечисляемую коллекцию объектов <see cref="T:System.Diagnostics.Eventing.Reader.EventKeyword" />.
		///       </returns>
		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x0005A6D7 File Offset: 0x000588D7
		public IEnumerable<EventKeyword> Keywords
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Возвращает уровень, связанный с событием, определенным в поставщике событий.
		///          Уровень определяет серьезность события.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Diagnostics.Eventing.Reader.EventLevel" /> объекта.
		///       </returns>
		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x0005A05A File Offset: 0x0005825A
		public EventLevel Level
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает ссылку на журнал событий, принимающий событие при публикации поставщиком данного события.
		///       </summary>
		/// <returns>
		///         Возвращает объект <see cref="T:System.Diagnostics.Eventing.Reader.EventLogLink" />.
		///       </returns>
		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x0005A05A File Offset: 0x0005825A
		public EventLogLink LogLink
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает код операции, связанные с этим событием, которое определяется поставщиком событий.
		///          Код операций определяет числовое значение, идентифицирующее действие или пункт действия, который приложение при вызове события.
		///       </summary>
		/// <returns>
		///         Возвращает объект <see cref="T:System.Diagnostics.Eventing.Reader.EventOpcode" />.
		///       </returns>
		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x0005A05A File Offset: 0x0005825A
		public EventOpcode Opcode
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает задачу, связанную с событием.
		///          Задача, идентифицирующая часть приложения или компонента, публикующего событие.
		///       </summary>
		/// <returns>
		///         Возвращает объект <see cref="T:System.Diagnostics.Eventing.Reader.EventTask" />.
		///       </returns>
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x0005A05A File Offset: 0x0005825A
		public EventTask Task
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает строку шаблона для события.
		///          Шаблоны используются для описания данных, используемых поставщиком при публикации события.
		///          Шаблоны опционально указывают XML, предоставляющий структуру события.
		///          XML позволяет значений, предоставляемых издателем событий должны быть вставлены во время отрисовки события.
		///       </summary>
		/// <returns>
		///         Возвращает строку, содержащую шаблон для события.
		///       </returns>
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x0005A05A File Offset: 0x0005825A
		public string Template
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает версию события, который определяет идентификатор события.
		///       </summary>
		/// <returns>
		///         Возвращает значение в байтах.
		///       </returns>
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x0005AA0C File Offset: 0x00058C0C
		public byte Version
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}
	}
}
