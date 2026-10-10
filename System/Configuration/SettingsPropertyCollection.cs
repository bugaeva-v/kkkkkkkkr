using System;
using System.Collections;

namespace System.Configuration
{
	/// <summary>Содержит коллекцию объектов <see cref="T:System.Configuration.SettingsProperty" />.</summary>
	// Token: 0x020001CD RID: 461
	public class SettingsPropertyCollection : ICloneable, ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyCollection" />.</summary>
		// Token: 0x06000C0D RID: 3085 RVA: 0x00031FC8 File Offset: 0x000301C8
		public SettingsPropertyCollection()
		{
			this.items = new Hashtable();
		}

		/// <summary>Добавляет объект <see cref="T:System.Configuration.SettingsProperty" /> в коллекцию.</summary>
		/// <param name="property">Объект <see cref="T:System.Configuration.SettingsProperty" />.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06000C0E RID: 3086 RVA: 0x00031FDB File Offset: 0x000301DB
		public void Add(SettingsProperty property)
		{
			if (this.isReadOnly)
			{
				throw new NotSupportedException();
			}
			this.OnAdd(property);
			this.items.Add(property.Name, property);
			this.OnAddComplete(property);
		}

		/// <summary>Удаляет все объекты <see cref="T:System.Configuration.SettingsProperty" /> из коллекции.</summary>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06000C0F RID: 3087 RVA: 0x0003200B File Offset: 0x0003020B
		public void Clear()
		{
			if (this.isReadOnly)
			{
				throw new NotSupportedException();
			}
			this.OnClear();
			this.items.Clear();
			this.OnClearComplete();
		}

		/// <summary>Создает копию существующей коллекции.</summary>
		/// <returns>Класс <see cref="T:System.Configuration.SettingsPropertyCollection" />.</returns>
		// Token: 0x06000C10 RID: 3088 RVA: 0x00032032 File Offset: 0x00030232
		public object Clone()
		{
			return new SettingsPropertyCollection
			{
				items = (Hashtable)this.items.Clone()
			};
		}

		/// <summary>Копирует данный объект <see cref="T:System.Configuration.SettingsPropertyCollection" /> в массив.</summary>
		/// <param name="array">Массив, в который выполняется копирование объекта.</param>
		/// <param name="index">Индекс, с которого начинается копирование.</param>
		// Token: 0x06000C11 RID: 3089 RVA: 0x0003204F File Offset: 0x0003024F
		public void CopyTo(Array array, int index)
		{
			this.items.Values.CopyTo(array, index);
		}

		/// <summary>Получает объект <see cref="T:System.Collections.IEnumerator" /> в том виде, в котором он применяется в данной коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" /> в том виде, в котором он применяется в коллекции.</returns>
		// Token: 0x06000C12 RID: 3090 RVA: 0x00032063 File Offset: 0x00030263
		public IEnumerator GetEnumerator()
		{
			return this.items.Values.GetEnumerator();
		}

		/// <summary>Удаляет объект <see cref="T:System.Configuration.SettingsProperty" /> из коллекции.</summary>
		/// <param name="name">Имя объекта <see cref="T:System.Configuration.SettingsProperty" />.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		// Token: 0x06000C13 RID: 3091 RVA: 0x00032078 File Offset: 0x00030278
		public void Remove(string name)
		{
			if (this.isReadOnly)
			{
				throw new NotSupportedException();
			}
			SettingsProperty property = (SettingsProperty)this.items[name];
			this.OnRemove(property);
			this.items.Remove(name);
			this.OnRemoveComplete(property);
		}

		/// <summary>Устанавливает статус коллекции "только для чтения".</summary>
		// Token: 0x06000C14 RID: 3092 RVA: 0x000320BF File Offset: 0x000302BF
		public void SetReadOnly()
		{
			this.isReadOnly = true;
		}

		/// <summary>Осуществляет дополнительные выборочные действия при добавлении к содержимому экземпляра <see cref="T:System.Configuration.SettingsPropertyCollection" />.</summary>
		/// <param name="property">Объект <see cref="T:System.Configuration.SettingsProperty" />.</param>
		// Token: 0x06000C15 RID: 3093 RVA: 0x00003917 File Offset: 0x00001B17
		protected virtual void OnAdd(SettingsProperty property)
		{
		}

		/// <summary>Осуществляет дополнительные выборочные действия после добавления к содержимому экземпляра <see cref="T:System.Configuration.SettingsPropertyCollection" />.</summary>
		/// <param name="property">Объект <see cref="T:System.Configuration.SettingsProperty" />.</param>
		// Token: 0x06000C16 RID: 3094 RVA: 0x00003917 File Offset: 0x00001B17
		protected virtual void OnAddComplete(SettingsProperty property)
		{
		}

		/// <summary>Осуществляет дополнительные выборочные действия при чистке содержимого экземпляра <see cref="T:System.Configuration.SettingsPropertyCollection" />.</summary>
		// Token: 0x06000C17 RID: 3095 RVA: 0x00003917 File Offset: 0x00001B17
		protected virtual void OnClear()
		{
		}

		/// <summary>Осуществляет дополнительные выборочные действия после чистки содержимого экземпляра <see cref="T:System.Configuration.SettingsPropertyCollection" />.</summary>
		// Token: 0x06000C18 RID: 3096 RVA: 0x00003917 File Offset: 0x00001B17
		protected virtual void OnClearComplete()
		{
		}

		/// <summary>Осуществляет дополнительные выборочные действия при удалении содержимого экземпляра <see cref="T:System.Configuration.SettingsPropertyCollection" />.</summary>
		/// <param name="property">Объект <see cref="T:System.Configuration.SettingsProperty" />.</param>
		// Token: 0x06000C19 RID: 3097 RVA: 0x00003917 File Offset: 0x00001B17
		protected virtual void OnRemove(SettingsProperty property)
		{
		}

		/// <summary>Осуществляет дополнительные выборочные действия после удаления содержимого экземпляра <see cref="T:System.Configuration.SettingsPropertyCollection" />.</summary>
		/// <param name="property">Объект <see cref="T:System.Configuration.SettingsProperty" />.</param>
		// Token: 0x06000C1A RID: 3098 RVA: 0x00003917 File Offset: 0x00001B17
		protected virtual void OnRemoveComplete(SettingsProperty property)
		{
		}

		/// <summary>Получает значение, указывающее число объектов <see cref="T:System.Configuration.SettingsProperty" /> в коллекции.</summary>
		/// <returns>Количество объектов <see cref="T:System.Configuration.SettingsProperty" /> в коллекции.</returns>
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x000320C8 File Offset: 0x000302C8
		public int Count
		{
			get
			{
				return this.items.Count;
			}
		}

		/// <summary>Получает значение, указывающее, является ли доступ к коллекции синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="true" />, если доступ к коллекции <see cref="T:System.Configuration.SettingsPropertyCollection" /> является синхронизированным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x00003062 File Offset: 0x00001262
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает элемент коллекции с указанным именем.</summary>
		/// <param name="name">Имя объекта <see cref="T:System.Configuration.SettingsProperty" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.SettingsProperty" /> с указанным <paramref name="name" />.</returns>
		// Token: 0x17000210 RID: 528
		public SettingsProperty this[string name]
		{
			get
			{
				return (SettingsProperty)this.items[name];
			}
		}

		/// <summary>Получает объект, используемый для синхронизации доступа к коллекции.</summary>
		/// <returns>Объект, используемый для синхронизации доступа к коллекции.</returns>
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x000075E1 File Offset: 0x000057E1
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x040007A6 RID: 1958
		private Hashtable items;

		// Token: 0x040007A7 RID: 1959
		private bool isReadOnly;
	}
}
