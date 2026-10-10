using System;
using System.Collections;

namespace System.Configuration.Provider
{
	/// <summary>Представляет коллекцию объектов поставщика, которые наследованы из <see cref="T:System.Configuration.Provider.ProviderBase" />.</summary>
	// Token: 0x02000078 RID: 120
	public class ProviderCollection : ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.Provider.ProviderCollection" />.</summary>
		// Token: 0x060003E8 RID: 1000 RVA: 0x0000AEEC File Offset: 0x000090EC
		public ProviderCollection()
		{
			this.lookup = new Hashtable(10, StringComparer.InvariantCultureIgnoreCase);
			this.values = new ArrayList();
		}

		/// <summary>Добавляет поставщика в коллекцию.</summary>
		/// <param name="provider">Поставщик, который должен быть добавлен.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция только для чтения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="provider" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Configuration.Provider.ProviderBase.Name" /> параметра <paramref name="provider" /> есть <see langword="null" />.  
		/// -или- 
		/// Длина <see cref="P:System.Configuration.Provider.ProviderBase.Name" /> параметра <paramref name="provider" /> меньше чем 1.</exception>
		// Token: 0x060003E9 RID: 1001 RVA: 0x0000AF14 File Offset: 0x00009114
		public virtual void Add(ProviderBase provider)
		{
			if (this.readOnly)
			{
				throw new NotSupportedException();
			}
			if (provider == null || provider.Name == null)
			{
				throw new ArgumentNullException();
			}
			int num = this.values.Add(provider);
			try
			{
				this.lookup.Add(provider.Name, num);
			}
			catch
			{
				this.values.RemoveAt(num);
				throw;
			}
		}

		/// <summary>Удаляет все элементы из коллекции.</summary>
		/// <exception cref="T:System.NotSupportedException">Коллекция установлена в режим только для чтения.</exception>
		// Token: 0x060003EA RID: 1002 RVA: 0x0000AF88 File Offset: 0x00009188
		public void Clear()
		{
			if (this.readOnly)
			{
				throw new NotSupportedException();
			}
			this.values.Clear();
			this.lookup.Clear();
		}

		/// <summary>Копирует содержимое коллекции в данный массив, начиная с указанного индекса.</summary>
		/// <param name="array">Массив для копирования элементов коллекции.</param>
		/// <param name="index">Индекс элемента коллекции, с которого начинается копирование.</param>
		// Token: 0x060003EB RID: 1003 RVA: 0x0000AFAE File Offset: 0x000091AE
		public void CopyTo(ProviderBase[] array, int index)
		{
			this.values.CopyTo(array, index);
		}

		/// <summary>Копирует элементы <see cref="T:System.Configuration.Provider.ProviderCollection" /> в массив, начиная с определенного индекса массива.</summary>
		/// <param name="array">Массив для копирования элементов коллекции.</param>
		/// <param name="index">Индекс массива, с которого начинается копирование экземпляров поставщика из коллекции.</param>
		// Token: 0x060003EC RID: 1004 RVA: 0x0000AFAE File Offset: 0x000091AE
		void ICollection.CopyTo(Array array, int index)
		{
			this.values.CopyTo(array, index);
		}

		/// <summary>Возвращает объект, который реализует интерфейс <see cref="T:System.Collections.IEnumerator" />, производящий итерацию по коллекции.</summary>
		/// <returns>Объект, который реализует <see cref="T:System.Collections.IEnumerator" />, производящий итерацию по коллекции.</returns>
		// Token: 0x060003ED RID: 1005 RVA: 0x0000AFBD File Offset: 0x000091BD
		public IEnumerator GetEnumerator()
		{
			return this.values.GetEnumerator();
		}

		/// <summary>Удаляет поставщика из коллекции.</summary>
		/// <param name="name">Имя поставщика, предназначенного для удаления.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция была установлена в режим только для чтения.</exception>
		// Token: 0x060003EE RID: 1006 RVA: 0x0000AFCC File Offset: 0x000091CC
		public void Remove(string name)
		{
			if (this.readOnly)
			{
				throw new NotSupportedException();
			}
			object obj = this.lookup[name];
			if (obj == null || !(obj is int))
			{
				throw new ArgumentException();
			}
			int num = (int)obj;
			if (num >= this.values.Count)
			{
				throw new ArgumentException();
			}
			this.values.RemoveAt(num);
			this.lookup.Remove(name);
			ArrayList arrayList = new ArrayList();
			foreach (object obj2 in this.lookup)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj2;
				if ((int)dictionaryEntry.Value > num)
				{
					arrayList.Add(dictionaryEntry.Key);
				}
			}
			foreach (object obj3 in arrayList)
			{
				string key = (string)obj3;
				this.lookup[key] = (int)this.lookup[key] - 1;
			}
		}

		/// <summary>Устанавливает статус коллекции "только для чтения".</summary>
		// Token: 0x060003EF RID: 1007 RVA: 0x0000B110 File Offset: 0x00009310
		public void SetReadOnly()
		{
			this.readOnly = true;
		}

		/// <summary>Возвращает количество поставщиков в коллекции.</summary>
		/// <returns>Количество поставщиков в коллекции.</returns>
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0000B119 File Offset: 0x00009319
		public int Count
		{
			get
			{
				return this.values.Count;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли доступ к коллекции синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="false" /> во всех случаях.</returns>
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000023BB File Offset: 0x000005BB
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает текущий объект.</summary>
		/// <returns>Текущий объект.</returns>
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00002058 File Offset: 0x00000258
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Возвращает поставщика с заданным именем.</summary>
		/// <param name="name">Ключ, по которому определяется поставщик.</param>
		/// <returns>Поставщик с заданным именем.</returns>
		// Token: 0x17000126 RID: 294
		public ProviderBase this[string name]
		{
			get
			{
				object obj = this.lookup[name];
				if (obj == null)
				{
					return null;
				}
				return this.values[(int)obj] as ProviderBase;
			}
		}

		// Token: 0x04000163 RID: 355
		private Hashtable lookup;

		// Token: 0x04000164 RID: 356
		private bool readOnly;

		// Token: 0x04000165 RID: 357
		private ArrayList values;
	}
}
