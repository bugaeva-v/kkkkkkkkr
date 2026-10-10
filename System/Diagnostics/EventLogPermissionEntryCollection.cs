using System;
using System.Collections;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics
{
	/// <summary>Содержит строго типизированную коллекцию объектов <see cref="T:System.Diagnostics.EventLogPermissionEntry" />.</summary>
	// Token: 0x02000264 RID: 612
	[Serializable]
	public class EventLogPermissionEntryCollection : CollectionBase
	{
		// Token: 0x0600131A RID: 4890 RVA: 0x00050FC4 File Offset: 0x0004F1C4
		internal EventLogPermissionEntryCollection(EventLogPermission owner)
		{
			this.owner = owner;
			ResourcePermissionBaseEntry[] entries = owner.GetEntries();
			if (entries.Length != 0)
			{
				foreach (ResourcePermissionBaseEntry resourcePermissionBaseEntry in entries)
				{
					EventLogPermissionEntry value = new EventLogPermissionEntry((EventLogPermissionAccess)resourcePermissionBaseEntry.PermissionAccess, resourcePermissionBaseEntry.PermissionAccessPath[0]);
					base.InnerList.Add(value);
				}
			}
		}

		/// <summary>Получает или задает объект по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс в коллекции.</param>
		/// <returns>Объект <see cref="T:System.Diagnostics.EventLogPermissionEntry" />, находящийся по указанному индексу.</returns>
		// Token: 0x1700037A RID: 890
		public EventLogPermissionEntry this[int index]
		{
			get
			{
				return (EventLogPermissionEntry)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.Diagnostics.EventLogPermissionEntry" /> в эту коллекцию.</summary>
		/// <param name="value">Добавляемый объект <see cref="T:System.Diagnostics.EventLogPermissionEntry" />.</param>
		/// <returns>Отсчитываемый от нуля индекс добавляемого объекта <see cref="T:System.Diagnostics.EventLogPermissionEntry" />.</returns>
		// Token: 0x0600131D RID: 4893 RVA: 0x00051042 File Offset: 0x0004F242
		public int Add(EventLogPermissionEntry value)
		{
			return base.List.Add(value);
		}

		/// <summary>Добавляет набор указанных записей разрешений в данную коллекцию.</summary>
		/// <param name="value">Массив объектов типа <see cref="T:System.Diagnostics.EventLogPermissionEntry" />, содержащий добавляемые записи разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600131E RID: 4894 RVA: 0x00051050 File Offset: 0x0004F250
		public void AddRange(EventLogPermissionEntry[] value)
		{
			foreach (EventLogPermissionEntry value2 in value)
			{
				base.List.Add(value2);
			}
		}

		/// <summary>Добавляет набор указанных записей разрешений в данную коллекцию.</summary>
		/// <param name="value">Коллекция <see cref="T:System.Diagnostics.EventLogPermissionEntryCollection" />, которая содержит добавляемые записи разрешений.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600131F RID: 4895 RVA: 0x00051080 File Offset: 0x0004F280
		public void AddRange(EventLogPermissionEntryCollection value)
		{
			foreach (object obj in value)
			{
				EventLogPermissionEntry value2 = (EventLogPermissionEntry)obj;
				base.List.Add(value2);
			}
		}

		/// <summary>Определяет, содержит ли данная коллекция указанный объект <see cref="T:System.Diagnostics.EventLogPermissionEntry" />.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.Diagnostics.EventLogPermissionEntry" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Diagnostics.EventLogPermissionEntry" /> принадлежит данной коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001320 RID: 4896 RVA: 0x000510DC File Offset: 0x0004F2DC
		public bool Contains(EventLogPermissionEntry value)
		{
			return base.List.Contains(value);
		}

		/// <summary>Копирует записи разрешений из данной коллекции в массив, начиная с конкретного индекса массива.</summary>
		/// <param name="array">Массив объектов типа <see cref="T:System.Diagnostics.EventLogPermissionEntry" />, который получает записи разрешений коллекции.</param>
		/// <param name="index">Отсчитываемый с нуля индекс, с которого начинается копирование записей разрешений.</param>
		// Token: 0x06001321 RID: 4897 RVA: 0x000510EA File Offset: 0x0004F2EA
		public void CopyTo(EventLogPermissionEntry[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>Определяет индекс указанной записи разрешения в данной коллекции.</summary>
		/// <param name="value">Запись разрешения, которую требуется найти.</param>
		/// <returns>Отсчитываемый от нуля индекс заданной записи разрешения или -1, если запись разрешения не найдена в коллекции.</returns>
		// Token: 0x06001322 RID: 4898 RVA: 0x000510F9 File Offset: 0x0004F2F9
		public int IndexOf(EventLogPermissionEntry value)
		{
			return base.List.IndexOf(value);
		}

		/// <summary>Вставляет запись разрешения в данную коллекцию по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс в коллекции, по которому нужно вставить запись разрешения.</param>
		/// <param name="value">Запись разрешения для вставки в данную коллекцию.</param>
		// Token: 0x06001323 RID: 4899 RVA: 0x00051107 File Offset: 0x0004F307
		public void Insert(int index, EventLogPermissionEntry value)
		{
			base.List.Insert(index, value);
		}

		/// <summary>Выполняет дополнительные пользовательские действия после очистки содержимого коллекции.</summary>
		// Token: 0x06001324 RID: 4900 RVA: 0x00051116 File Offset: 0x0004F316
		protected override void OnClear()
		{
			this.owner.ClearEntries();
		}

		/// <summary>Выполняет дополнительные пользовательские действия перед вставкой в коллекцию новой записи разрешения.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому должен быть вставлен параметр <paramref name="value" />.</param>
		/// <param name="value">Новое значение записи разрешения в позиции с индексом <paramref name="index" />.</param>
		// Token: 0x06001325 RID: 4901 RVA: 0x00051123 File Offset: 0x0004F323
		protected override void OnInsert(int index, object value)
		{
			this.owner.Add(value);
		}

		/// <summary>Выполняет дополнительные пользовательские действия при удалении новой записи разрешения из коллекции.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому может быть найдено значение <paramref name="value" />.</param>
		/// <param name="value">Запись разрешения, которую требуется удалить из позиции с индексом <paramref name="index" />.</param>
		// Token: 0x06001326 RID: 4902 RVA: 0x00051131 File Offset: 0x0004F331
		protected override void OnRemove(int index, object value)
		{
			this.owner.Remove(value);
		}

		/// <summary>Выполняет дополнительные пользовательские действия перед заданием значения в коллекции.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому может быть найдено значение <paramref name="oldValue" />.</param>
		/// <param name="oldValue">Значение, которое требуется заменить на <paramref name="newValue" />.</param>
		/// <param name="newValue">Новое значение записи разрешения в позиции с индексом <paramref name="index" />.</param>
		// Token: 0x06001327 RID: 4903 RVA: 0x0005113F File Offset: 0x0004F33F
		protected override void OnSet(int index, object oldValue, object newValue)
		{
			this.owner.Remove(oldValue);
			this.owner.Add(newValue);
		}

		/// <summary>Удаляет указанную запись разрешения из этой коллекции.</summary>
		/// <param name="value">Удаляемая запись разрешения.</param>
		// Token: 0x06001328 RID: 4904 RVA: 0x00051159 File Offset: 0x0004F359
		public void Remove(EventLogPermissionEntry value)
		{
			base.List.Remove(value);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal EventLogPermissionEntryCollection()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000ADB RID: 2779
		private EventLogPermission owner;
	}
}
