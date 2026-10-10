using System;
using System.Collections;

namespace System.Diagnostics
{
	/// <summary>Возвращает строго типизированную коллекцию объектов <see cref="T:System.Diagnostics.ProcessThread" />.</summary>
	// Token: 0x02000246 RID: 582
	public class ProcessThreadCollection : ReadOnlyCollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.ProcessThreadCollection" /> без связанных экземпляров <see cref="T:System.Diagnostics.ProcessThread" />.</summary>
		// Token: 0x06001205 RID: 4613 RVA: 0x0004DD52 File Offset: 0x0004BF52
		protected ProcessThreadCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.ProcessThreadCollection" />, используя указанный массив экземпляров <see cref="T:System.Diagnostics.ProcessThread" />.</summary>
		/// <param name="processThreads">Массив экземпляров <see cref="T:System.Diagnostics.ProcessThread" />, с помощью которого требуется инициализировать этот экземпляр <see cref="T:System.Diagnostics.ProcessThreadCollection" />.</param>
		// Token: 0x06001206 RID: 4614 RVA: 0x0004DD5A File Offset: 0x0004BF5A
		public ProcessThreadCollection(ProcessThread[] processThreads)
		{
			base.InnerList.AddRange(processThreads);
		}

		/// <summary>Возвращает индекс для перебора набора потоков процесса.</summary>
		/// <param name="index">Значение отсчитываемого от нуля индекса потока в коллекции.</param>
		/// <returns>Объект <see cref="T:System.Diagnostics.ProcessThread" />, который индексирует потоки в коллекции.</returns>
		// Token: 0x1700033A RID: 826
		public ProcessThread this[int index]
		{
			get
			{
				return (ProcessThread)base.InnerList[index];
			}
		}

		/// <summary>Добавляет поток процесса в коллекцию.</summary>
		/// <param name="thread">Поток для добавления в коллекцию.</param>
		/// <returns>Отсчитываемый от нуля индекс потока в коллекции.</returns>
		// Token: 0x06001208 RID: 4616 RVA: 0x0004E204 File Offset: 0x0004C404
		public int Add(ProcessThread thread)
		{
			return base.InnerList.Add(thread);
		}

		/// <summary>Вставляет поток процесса в указанном месте в коллекции.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, указывающий место, в котором должен быть вставлен поток.</param>
		/// <param name="thread">Поток, вставляемый в коллекцию.</param>
		// Token: 0x06001209 RID: 4617 RVA: 0x0004E212 File Offset: 0x0004C412
		public void Insert(int index, ProcessThread thread)
		{
			base.InnerList.Insert(index, thread);
		}

		/// <summary>Предоставляет положение указанного потока в коллекции.</summary>
		/// <param name="thread">Поток <see cref="T:System.Diagnostics.ProcessThread" />, индекс которого извлекается.</param>
		/// <returns>Отсчитываемый от нуля индекс, который определяет место потока в <see cref="T:System.Diagnostics.ProcessThreadCollection" />.</returns>
		// Token: 0x0600120A RID: 4618 RVA: 0x0004DD81 File Offset: 0x0004BF81
		public int IndexOf(ProcessThread thread)
		{
			return base.InnerList.IndexOf(thread);
		}

		/// <summary>Определяет, присутствует ли в коллекции указанный поток процесса.</summary>
		/// <param name="thread">Экземпляр <see cref="T:System.Diagnostics.ProcessThread" />, указывающий поток, который необходимо найти в этой коллекции.</param>
		/// <returns>Значение <see langword="true" />, если поток присутствует в коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600120B RID: 4619 RVA: 0x0004DD8F File Offset: 0x0004BF8F
		public bool Contains(ProcessThread thread)
		{
			return base.InnerList.Contains(thread);
		}

		/// <summary>Удаляет поток процесса из коллекции.</summary>
		/// <param name="thread">Поток, который требуется удалить из коллекции.</param>
		// Token: 0x0600120C RID: 4620 RVA: 0x0004E221 File Offset: 0x0004C421
		public void Remove(ProcessThread thread)
		{
			base.InnerList.Remove(thread);
		}

		/// <summary>Копирует массив экземпляров <see cref="T:System.Diagnostics.ProcessThread" /> в коллекцию по указанному индексу.</summary>
		/// <param name="array">Массив экземпляров <see cref="T:System.Diagnostics.ProcessThread" />, добавляемый в коллекцию.</param>
		/// <param name="index">Расположение, в которое добавляются новые экземпляры.</param>
		// Token: 0x0600120D RID: 4621 RVA: 0x0004DD9D File Offset: 0x0004BF9D
		public void CopyTo(ProcessThread[] array, int index)
		{
			base.InnerList.CopyTo(array, index);
		}
	}
}
