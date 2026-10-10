using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Представляет не зависящие от языка сведения для записи журнала событий.</summary>
	// Token: 0x02000258 RID: 600
	public class EventInstance
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventInstance" />, используя заданные идентификаторы ресурсов для локализованного сообщения и текст категории для записи о событии.</summary>
		/// <param name="instanceId">Идентификатор ресурса, соответствующий строке, заданной в файле ресурсов сообщения для источника событий.</param>
		/// <param name="categoryId">Идентификатор ресурса, соответствующий строке, заданной в файле ресурсов категории для источника событий, или нуль, свидетельствующий об отсутствии категории для данного события.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="instanceId" /> является отрицательным числом или превышает значение <see cref="F:System.UInt32.MaxValue" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="categoryId" /> является отрицательным числом или превышает значение <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x06001278 RID: 4728 RVA: 0x0004FC04 File Offset: 0x0004DE04
		public EventInstance(long instanceId, int categoryId) : this(instanceId, categoryId, EventLogEntryType.Information)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventInstance" />, используя заданные идентификаторы ресурсов для локализованного сообщения и текст категории для записи о событии, а также указанный тип журнала событий.</summary>
		/// <param name="instanceId">Идентификатор ресурса, соответствующий строке, заданной в файле ресурсов сообщения для источника событий.</param>
		/// <param name="categoryId">Идентификатор ресурса, соответствующий строке, заданной в файле ресурсов категории для источника событий, или нуль, свидетельствующий об отсутствии категории для данного события.</param>
		/// <param name="entryType">Значение <see cref="T:System.Diagnostics.EventLogEntryType" />, обозначающее тип события.</param>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="entryType" /> не является допустимым значением <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="instanceId" /> является отрицательным числом или превышает значение <see cref="F:System.UInt32.MaxValue" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="categoryId" /> является отрицательным числом или превышает значение <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x06001279 RID: 4729 RVA: 0x0004FC0F File Offset: 0x0004DE0F
		public EventInstance(long instanceId, int categoryId, EventLogEntryType entryType)
		{
			this.InstanceId = instanceId;
			this.CategoryId = categoryId;
			this.EntryType = entryType;
		}

		/// <summary>Получает или задает идентификатор ресурса, определяющий заданную приложением категорию записи о событии.</summary>
		/// <returns>Числовое значение категории либо идентификатор ресурса, соответствующий строке, заданной в файле ресурсов категории для источника событий, или нуль, свидетельствующий об отсутствии категории для данного события. Значение по умолчанию равно нулю. Это означает, что для записи о событии категория отображаться не будет.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задано отрицательное значением или значение, превышающее <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x1700034B RID: 843
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x0004FC2C File Offset: 0x0004DE2C
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x0004FC34 File Offset: 0x0004DE34
		public int CategoryId
		{
			get
			{
				return this._categoryId;
			}
			set
			{
				if (value < 0 || value > 65535)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._categoryId = value;
			}
		}

		/// <summary>Получает или задает тип события для записи в журнале событий.</summary>
		/// <returns>Значение <see cref="T:System.Diagnostics.EventLogEntryType" />, обозначающее тип записи о событии. Значение по умолчанию — <see cref="F:System.Diagnostics.EventLogEntryType.Information" />.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Для свойства не задано допустимое значение <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x0004FC54 File Offset: 0x0004DE54
		// (set) Token: 0x0600127D RID: 4733 RVA: 0x0004FC5C File Offset: 0x0004DE5C
		public EventLogEntryType EntryType
		{
			get
			{
				return this._entryType;
			}
			set
			{
				if (!Enum.IsDefined(typeof(EventLogEntryType), value))
				{
					throw new InvalidEnumArgumentException("value", (int)value, typeof(EventLogEntryType));
				}
				this._entryType = value;
			}
		}

		/// <summary>Получает или задает идентификатор ресурса, определяющий текст сообщения для записи о событии.</summary>
		/// <returns>Идентификатор ресурса, соответствующий строке, заданной в файле ресурсов сообщения для источника событий.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для свойства задано отрицательное значением или значение, превышающее <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x1700034D RID: 845
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x0004FC92 File Offset: 0x0004DE92
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x0004FC9A File Offset: 0x0004DE9A
		public long InstanceId
		{
			get
			{
				return this._instanceId;
			}
			set
			{
				if (value < 0L || value > (long)((ulong)-1))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._instanceId = value;
			}
		}

		// Token: 0x04000AA8 RID: 2728
		private int _categoryId;

		// Token: 0x04000AA9 RID: 2729
		private EventLogEntryType _entryType;

		// Token: 0x04000AAA RID: 2730
		private long _instanceId;
	}
}
