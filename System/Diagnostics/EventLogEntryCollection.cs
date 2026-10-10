using System;
using System.Collections;
using Unity;

namespace System.Diagnostics
{
	/// <summary>Определяет размер и перечислители для коллекции экземпляров <see cref="T:System.Diagnostics.EventLogEntry" />.</summary>
	// Token: 0x0200025B RID: 603
	public class EventLogEntryCollection : ICollection, IEnumerable
	{
		// Token: 0x060012D6 RID: 4822 RVA: 0x00050956 File Offset: 0x0004EB56
		internal EventLogEntryCollection(EventLogImpl impl)
		{
			this._impl = impl;
		}

		/// <summary>Возвращает число записей в журнале событий (то есть, количество элементов коллекции <see cref="T:System.Diagnostics.EventLogEntry" />).</summary>
		/// <returns>Число записей, имеющихся на данный момент в журнале событий.</returns>
		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x00050965 File Offset: 0x0004EB65
		public int Count
		{
			get
			{
				return this._impl.EntryCount;
			}
		}

		/// <summary>Возвращает запись в журнале событий по индексу, который начинается с 0 (нуля).</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, связанный с записью в журнале событий.</param>
		/// <returns>Запись в журнале событий, находящаяся в расположении, указанном параметром <paramref name="index" />.</returns>
		// Token: 0x17000369 RID: 873
		public virtual EventLogEntry this[int index]
		{
			get
			{
				return this._impl[index];
			}
		}

		/// <summary>Получает значение, определяющее, является ли доступ к коллекции <see cref="T:System.Diagnostics.EventLogEntryCollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="false" />, если доступ к коллекции не синхронизирован (потокобезопасный доступ).</returns>
		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00003062 File Offset: 0x00001262
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Diagnostics.EventLogEntryCollection" />.</summary>
		/// <returns>Объект, который можно использовать для синхронизации доступа к коллекции.</returns>
		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x000075E1 File Offset: 0x000057E1
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Diagnostics.EventLogEntryCollection" /> в массив экземпляров <see cref="T:System.Diagnostics.EventLogEntry" />, начиная с определенного индекса массива.</summary>
		/// <param name="entries">Одномерный массив экземпляров <see cref="T:System.Diagnostics.EventLogEntry" />, который является конечным массивом для элементов, копируемых из коллекции. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Индекс (отсчет с нуля) в массиве, с которого начинается копирование.</param>
		// Token: 0x060012DB RID: 4827 RVA: 0x00050980 File Offset: 0x0004EB80
		public void CopyTo(EventLogEntry[] entries, int index)
		{
			EventLogEntry[] entries2 = this._impl.GetEntries();
			Array.Copy(entries2, 0, entries, index, entries2.Length);
		}

		/// <summary>Поддерживает простой итерационный перебор элементов объекта <see cref="T:System.Diagnostics.EventLogEntryCollection" />.</summary>
		/// <returns>Объект, который может использоваться для итерационного перебора элементов коллекции.</returns>
		// Token: 0x060012DC RID: 4828 RVA: 0x000509A5 File Offset: 0x0004EBA5
		public IEnumerator GetEnumerator()
		{
			return new EventLogEntryCollection.EventLogEntryEnumerator(this._impl);
		}

		/// <summary>Копирует элементы коллекции в <see cref="T:System.Array" /> начиная с определенного индекса в <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, являющийся целевым массивом для элементов, копируемых из коллекции. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x060012DD RID: 4829 RVA: 0x000509B4 File Offset: 0x0004EBB4
		void ICollection.CopyTo(Array array, int index)
		{
			EventLogEntry[] entries = this._impl.GetEntries();
			Array.Copy(entries, 0, array, index, entries.Length);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal EventLogEntryCollection()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000AC4 RID: 2756
		private readonly EventLogImpl _impl;

		// Token: 0x0200025C RID: 604
		private class EventLogEntryEnumerator : IEnumerator
		{
			// Token: 0x060012DF RID: 4831 RVA: 0x000509D9 File Offset: 0x0004EBD9
			internal EventLogEntryEnumerator(EventLogImpl impl)
			{
				this._impl = impl;
			}

			// Token: 0x1700036C RID: 876
			// (get) Token: 0x060012E0 RID: 4832 RVA: 0x000509EF File Offset: 0x0004EBEF
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x1700036D RID: 877
			// (get) Token: 0x060012E1 RID: 4833 RVA: 0x000509F7 File Offset: 0x0004EBF7
			public EventLogEntry Current
			{
				get
				{
					if (this._currentEntry != null)
					{
						return this._currentEntry;
					}
					throw new InvalidOperationException("No current EventLog entry available, cursor is located before the first or after the last element of the enumeration.");
				}
			}

			// Token: 0x060012E2 RID: 4834 RVA: 0x00050A14 File Offset: 0x0004EC14
			public bool MoveNext()
			{
				this._currentIndex++;
				if (this._currentIndex >= this._impl.EntryCount)
				{
					this._currentEntry = null;
					return false;
				}
				this._currentEntry = this._impl[this._currentIndex];
				return true;
			}

			// Token: 0x060012E3 RID: 4835 RVA: 0x00050A63 File Offset: 0x0004EC63
			public void Reset()
			{
				this._currentIndex = -1;
			}

			// Token: 0x04000AC5 RID: 2757
			private readonly EventLogImpl _impl;

			// Token: 0x04000AC6 RID: 2758
			private int _currentIndex = -1;

			// Token: 0x04000AC7 RID: 2759
			private EventLogEntry _currentEntry;
		}
	}
}
