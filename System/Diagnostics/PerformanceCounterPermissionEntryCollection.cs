using System;
using System.Collections;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics
{
	/// <summary>Содержит строго типизированную коллекцию объектов <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntry" />.</summary>
	// Token: 0x0200027A RID: 634
	[Serializable]
	public class PerformanceCounterPermissionEntryCollection : CollectionBase
	{
		// Token: 0x0600142E RID: 5166 RVA: 0x00052F18 File Offset: 0x00051118
		internal PerformanceCounterPermissionEntryCollection(PerformanceCounterPermission owner)
		{
			this.owner = owner;
			ResourcePermissionBaseEntry[] entries = owner.GetEntries();
			if (entries.Length != 0)
			{
				foreach (ResourcePermissionBaseEntry resourcePermissionBaseEntry in entries)
				{
					PerformanceCounterPermissionAccess permissionAccess = (PerformanceCounterPermissionAccess)resourcePermissionBaseEntry.PermissionAccess;
					string machineName = resourcePermissionBaseEntry.PermissionAccessPath[0];
					string categoryName = resourcePermissionBaseEntry.PermissionAccessPath[1];
					PerformanceCounterPermissionEntry value = new PerformanceCounterPermissionEntry(permissionAccess, machineName, categoryName);
					base.InnerList.Add(value);
				}
			}
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00052F84 File Offset: 0x00051184
		internal PerformanceCounterPermissionEntryCollection(ResourcePermissionBaseEntry[] entries)
		{
			foreach (ResourcePermissionBaseEntry resourcePermissionBaseEntry in entries)
			{
				base.List.Add(new PerformanceCounterPermissionEntry((PerformanceCounterPermissionAccess)resourcePermissionBaseEntry.PermissionAccess, resourcePermissionBaseEntry.PermissionAccessPath[0], resourcePermissionBaseEntry.PermissionAccessPath[1]));
			}
		}

		/// <summary>Получает или задает объект по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс в коллекции.</param>
		/// <returns>Объект <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntry" /> по указанному индексу.</returns>
		// Token: 0x170003C6 RID: 966
		public PerformanceCounterPermissionEntry this[int index]
		{
			get
			{
				return (PerformanceCounterPermissionEntry)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntry" /> в эту коллекцию.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntry" />.</param>
		/// <returns>Отсчитываемый с нуля индекс добавляемого объекта <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntry" />.</returns>
		// Token: 0x06001432 RID: 5170 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(PerformanceCounterPermissionEntry value)
		{
			return base.List.Add(value);
		}

		/// <summary>Добавляет набор указанных записей разрешений в данную коллекцию.</summary>
		/// <param name="value">Массив объектов типа <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntry" />, содержащий добавляемые записи разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001433 RID: 5171 RVA: 0x00052FE8 File Offset: 0x000511E8
		public void AddRange(PerformanceCounterPermissionEntry[] value)
		{
			foreach (PerformanceCounterPermissionEntry value2 in value)
			{
				base.List.Add(value2);
			}
		}

		/// <summary>Добавляет набор указанных записей разрешений в данную коллекцию.</summary>
		/// <param name="value">Коллекция <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntryCollection" />, которая содержит добавляемые записи разрешений.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001434 RID: 5172 RVA: 0x00053018 File Offset: 0x00051218
		public void AddRange(PerformanceCounterPermissionEntryCollection value)
		{
			foreach (object obj in value)
			{
				PerformanceCounterPermissionEntry value2 = (PerformanceCounterPermissionEntry)obj;
				base.List.Add(value2);
			}
		}

		/// <summary>Определяет, содержит ли коллекция заданный объект <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntry" />.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntry" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntry" /> принадлежит этой коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001435 RID: 5173 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(PerformanceCounterPermissionEntry value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует записи разрешений из данной коллекции в массив, начиная с конкретного индекса массива.</summary>
		/// <param name="array">Массив объектов типа <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntry" />, который получает записи разрешений коллекции.</param>
		/// <param name="index">Отсчитываемый с нуля индекс, с которого начинается копирование записей разрешений.</param>
		// Token: 0x06001436 RID: 5174 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(PerformanceCounterPermissionEntry[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Определяет индекс указанной записи разрешения в данной коллекции.</summary>
		/// <param name="value">Элемент разрешения, для которого выполняется поиск.</param>
		/// <returns>Отсчитываемый от нуля индекс заданной записи разрешения или -1, если запись разрешения не найдена в коллекции.</returns>
		// Token: 0x06001437 RID: 5175 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(PerformanceCounterPermissionEntry value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет запись разрешения в данную коллекцию по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс в коллекции, по которому нужно вставить запись разрешения.</param>
		/// <param name="value">Запись разрешения для вставки в данную коллекцию.</param>
		// Token: 0x06001438 RID: 5176 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, PerformanceCounterPermissionEntry value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Выполняет дополнительные пользовательские действия после очистки содержимого коллекции.</summary>
		// Token: 0x06001439 RID: 5177 RVA: 0x00053074 File Offset: 0x00051274
		protected override void OnClear()
		{
			this.owner.ClearEntries();
		}

		/// <summary>Выполняет дополнительные пользовательские действия перед вставкой в коллекцию новой записи разрешения.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому должен быть вставлен параметр <paramref name="value" />.</param>
		/// <param name="value">Новое значение записи разрешения в позиции с индексом <paramref name="index" />.</param>
		// Token: 0x0600143A RID: 5178 RVA: 0x00053081 File Offset: 0x00051281
		protected override void OnInsert(int index, object value)
		{
			this.owner.Add(value);
		}

		/// <summary>Выполняет дополнительные пользовательские действия при удалении новой записи разрешения из коллекции.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому может быть найдено значение <paramref name="value" />.</param>
		/// <param name="value">Запись разрешения, которую требуется удалить из позиции с индексом <paramref name="index" />.</param>
		// Token: 0x0600143B RID: 5179 RVA: 0x0005308F File Offset: 0x0005128F
		protected override void OnRemove(int index, object value)
		{
			this.owner.Remove(value);
		}

		/// <summary>Выполняет дополнительные пользовательские действия перед заданием значения в коллекции.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому может быть найдено значение <paramref name="oldValue" />.</param>
		/// <param name="oldValue">Значение, которое требуется заменить на <paramref name="newValue" />.</param>
		/// <param name="newValue">Новое значение записи разрешения в позиции с индексом <paramref name="index" />.</param>
		// Token: 0x0600143C RID: 5180 RVA: 0x0005309D File Offset: 0x0005129D
		protected override void OnSet(int index, object oldValue, object newValue)
		{
			this.owner.Remove(oldValue);
			this.owner.Add(newValue);
		}

		/// <summary>Удаляет указанную запись разрешения из этой коллекции.</summary>
		/// <param name="value">Удаляемая запись разрешения.</param>
		// Token: 0x0600143D RID: 5181 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(PerformanceCounterPermissionEntry value)
		{
			base.List.Remove(value);
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal PerformanceCounterPermissionEntryCollection()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000B32 RID: 2866
		private PerformanceCounterPermission owner;
	}
}
