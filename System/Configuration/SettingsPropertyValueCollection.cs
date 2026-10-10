using System;
using System.Collections;

namespace System.Configuration
{
	/// <summary>Содержит коллекцию значений свойства параметров, которые сопоставляют объекты <see cref="T:System.Configuration.SettingsProperty" /> с объектами <see cref="T:System.Configuration.SettingsPropertyValue" />.</summary>
	// Token: 0x020001D1 RID: 465
	public class SettingsPropertyValueCollection : ICloneable, ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyValueCollection" />.</summary>
		// Token: 0x06000C36 RID: 3126 RVA: 0x00032588 File Offset: 0x00030788
		public SettingsPropertyValueCollection()
		{
			this.items = new Hashtable();
		}

		/// <summary>Добавляет объект <see cref="T:System.Configuration.SettingsPropertyValue" /> в коллекцию.</summary>
		/// <param name="property">Объект <see cref="T:System.Configuration.SettingsPropertyValue" />.</param>
		/// <exception cref="T:System.NotSupportedException">Была сделана попытка добавить элемент в коллекцию, но коллекция отмечена, как доступная только для чтения.</exception>
		// Token: 0x06000C37 RID: 3127 RVA: 0x0003259B File Offset: 0x0003079B
		public void Add(SettingsPropertyValue property)
		{
			if (this.isReadOnly)
			{
				throw new NotSupportedException();
			}
			this.items.Add(property.Name, property);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x000325C0 File Offset: 0x000307C0
		internal void Add(SettingsPropertyValueCollection vals)
		{
			foreach (object obj in vals)
			{
				SettingsPropertyValue property = (SettingsPropertyValue)obj;
				this.Add(property);
			}
		}

		/// <summary>Удаляет все объекты <see cref="T:System.Configuration.SettingsPropertyValue" /> из коллекции.</summary>
		// Token: 0x06000C39 RID: 3129 RVA: 0x00032614 File Offset: 0x00030814
		public void Clear()
		{
			if (this.isReadOnly)
			{
				throw new NotSupportedException();
			}
			this.items.Clear();
		}

		/// <summary>Создает копию существующей коллекции.</summary>
		/// <returns>Класс <see cref="T:System.Configuration.SettingsPropertyValueCollection" />.</returns>
		// Token: 0x06000C3A RID: 3130 RVA: 0x0003262F File Offset: 0x0003082F
		public object Clone()
		{
			return new SettingsPropertyValueCollection
			{
				items = (Hashtable)this.items.Clone()
			};
		}

		/// <summary>Копирует данную коллекцию <see cref="T:System.Configuration.SettingsPropertyValueCollection" /> в массив.</summary>
		/// <param name="array">Массив, в который копируется коллекция.</param>
		/// <param name="index">Индекс, с которого начинается копирование.</param>
		// Token: 0x06000C3B RID: 3131 RVA: 0x0003264C File Offset: 0x0003084C
		public void CopyTo(Array array, int index)
		{
			this.items.Values.CopyTo(array, index);
		}

		/// <summary>Получает объект <see cref="T:System.Collections.IEnumerator" /> в том виде, в котором он применяется в данной коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" /> в том виде, в котором он применяется в коллекции.</returns>
		// Token: 0x06000C3C RID: 3132 RVA: 0x00032660 File Offset: 0x00030860
		public IEnumerator GetEnumerator()
		{
			return this.items.Values.GetEnumerator();
		}

		/// <summary>Удаляет объект <see cref="T:System.Configuration.SettingsPropertyValue" /> из коллекции.</summary>
		/// <param name="name">Имя объекта <see cref="T:System.Configuration.SettingsPropertyValue" />.</param>
		/// <exception cref="T:System.NotSupportedException">Была сделана попытка удалить элемент из коллекции, но коллекция отмечена, как доступная только для чтения.</exception>
		// Token: 0x06000C3D RID: 3133 RVA: 0x00032672 File Offset: 0x00030872
		public void Remove(string name)
		{
			if (this.isReadOnly)
			{
				throw new NotSupportedException();
			}
			this.items.Remove(name);
		}

		/// <summary>Устанавливает статус коллекции "только для чтения".</summary>
		// Token: 0x06000C3E RID: 3134 RVA: 0x0003268E File Offset: 0x0003088E
		public void SetReadOnly()
		{
			this.isReadOnly = true;
		}

		/// <summary>Получает значение, указывающее число объектов <see cref="T:System.Configuration.SettingsPropertyValue" /> в коллекции.</summary>
		/// <returns>Количество объектов <see cref="T:System.Configuration.SettingsPropertyValue" /> в коллекции.</returns>
		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00032697 File Offset: 0x00030897
		public int Count
		{
			get
			{
				return this.items.Count;
			}
		}

		/// <summary>Получает значение, указывающее, является ли доступ к коллекции синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к коллекции <see cref="T:System.Configuration.SettingsPropertyValueCollection" /> является синхронизированным; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x0000829A File Offset: 0x0000649A
		public bool IsSynchronized
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает элемент из коллекции.</summary>
		/// <param name="name">Объект <see cref="T:System.Configuration.SettingsPropertyValue" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.SettingsPropertyValue" /> с указанным <paramref name="name" />.</returns>
		// Token: 0x1700021B RID: 539
		public SettingsPropertyValue this[string name]
		{
			get
			{
				return (SettingsPropertyValue)this.items[name];
			}
		}

		/// <summary>Получает объект, используемый для синхронизации доступа к коллекции.</summary>
		/// <returns>Объект, используемый для синхронизации доступа к коллекции.</returns>
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0000829A File Offset: 0x0000649A
		public object SyncRoot
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x040007B0 RID: 1968
		private Hashtable items;

		// Token: 0x040007B1 RID: 1969
		private bool isReadOnly;
	}
}
