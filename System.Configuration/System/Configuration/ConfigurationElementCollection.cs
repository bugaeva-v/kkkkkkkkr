using System;
using System.Collections;
using System.Diagnostics;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Представляет элемент конфигурации, содержащий коллекцию дочерних элементов.</summary>
	// Token: 0x0200001C RID: 28
	[DebuggerDisplay("Count = {Count}")]
	public abstract class ConfigurationElementCollection : ConfigurationElement, ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
		// Token: 0x060000D5 RID: 213 RVA: 0x00004845 File Offset: 0x00002A45
		protected ConfigurationElementCollection()
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
		/// <param name="comparer">Используемый компаратор <see cref="T:System.Collections.IComparer" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="comparer" /> — <see langword="null" />.</exception>
		// Token: 0x060000D6 RID: 214 RVA: 0x00004879 File Offset: 0x00002A79
		protected ConfigurationElementCollection(IComparer comparer)
		{
			this.comparer = comparer;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal override void InitFromProperty(PropertyInformation propertyInfo)
		{
			ConfigurationCollectionAttribute configurationCollectionAttribute = propertyInfo.Property.CollectionAttribute;
			if (configurationCollectionAttribute == null)
			{
				configurationCollectionAttribute = (Attribute.GetCustomAttribute(propertyInfo.Type, typeof(ConfigurationCollectionAttribute)) as ConfigurationCollectionAttribute);
			}
			if (configurationCollectionAttribute != null)
			{
				this.addElementName = configurationCollectionAttribute.AddItemName;
				this.clearElementName = configurationCollectionAttribute.ClearItemsName;
				this.removeElementName = configurationCollectionAttribute.RemoveItemName;
			}
			base.InitFromProperty(propertyInfo);
		}

		/// <summary>Возвращает тип службы <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
		/// <returns>
		///   <see cref="T:System.Configuration.ConfigurationElementCollectionType" /> данной коллекции.</returns>
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00004919 File Offset: 0x00002B19
		public virtual ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.AddRemoveClearMap;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000491C File Offset: 0x00002B1C
		private bool IsBasic
		{
			get
			{
				return this.CollectionType == ConfigurationElementCollectionType.BasicMap || this.CollectionType == ConfigurationElementCollectionType.BasicMapAlternate;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00004931 File Offset: 0x00002B31
		private bool IsAlternate
		{
			get
			{
				return this.CollectionType == ConfigurationElementCollectionType.AddRemoveClearMapAlternate || this.CollectionType == ConfigurationElementCollectionType.BasicMapAlternate;
			}
		}

		/// <summary>Возвращает количество элементов в коллекции.</summary>
		/// <returns>Количество элементов в коллекции.</returns>
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00004947 File Offset: 0x00002B47
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		/// <summary>Получает имя, используемое для данной коллекции элементов в файле конфигурации после переопределения в производном классе.</summary>
		/// <returns>Имя коллекции; в противном случае — пустая строка. Значение по умолчанию - пустая строка.</returns>
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00004954 File Offset: 0x00002B54
		protected virtual string ElementName
		{
			get
			{
				return string.Empty;
			}
		}

		/// <summary>Получает или задает значение, указывающее, была ли коллекция очищена.</summary>
		/// <returns>
		///   <see langword="true" />, если элемент был создан; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Конфигурация доступна только для чтения.</exception>
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000495B File Offset: 0x00002B5B
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00004963 File Offset: 0x00002B63
		public bool EmitClear
		{
			get
			{
				return this.emitClear;
			}
			set
			{
				this.emitClear = value;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли доступ к коллекции синхронизированным.</summary>
		/// <returns>Значение <see langword="true" />, если доступ к коллекции <see cref="T:System.Configuration.ConfigurationElementCollection" /> является синхронизированным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000023BB File Offset: 0x000005BB
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, используемый для синхронизации доступа к <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
		/// <returns>Объект, используемый для синхронизации доступа к коллекции <see cref="T:System.Configuration.ConfigurationElementCollection" />.</returns>
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002058 File Offset: 0x00000258
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Возвращает значение, указывающее, выдаст ли исключение попытка добавить дубликат <see cref="T:System.Configuration.ConfigurationElement" /> к <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
		/// <returns>
		///   <see langword="true" />, если попытка добавить дубликат <see cref="T:System.Configuration.ConfigurationElement" /> к данной коллекции <see cref="T:System.Configuration.ConfigurationElementCollection" /> приводит к вызову исключения; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000496C File Offset: 0x00002B6C
		protected virtual bool ThrowOnDuplicate
		{
			get
			{
				return this.CollectionType == ConfigurationElementCollectionType.AddRemoveClearMap || this.CollectionType == ConfigurationElementCollectionType.AddRemoveClearMapAlternate;
			}
		}

		/// <summary>Возвращает или устанавливает имя <see cref="T:System.Configuration.ConfigurationElement" />, связанное с операцией добавления в <see cref="T:System.Configuration.ConfigurationElementCollection" /> после переопределения в производном классе.</summary>
		/// <returns>Имя элемента.</returns>
		/// <exception cref="T:System.ArgumentException">Избранное значение начинается с зарезервированного префикса config или lock.</exception>
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00004983 File Offset: 0x00002B83
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000498B File Offset: 0x00002B8B
		protected internal string AddElementName
		{
			get
			{
				return this.addElementName;
			}
			set
			{
				this.addElementName = value;
			}
		}

		/// <summary>Возвращает или задает имя <see cref="T:System.Configuration.ConfigurationElement" />, связанное с операцией очистки в <see cref="T:System.Configuration.ConfigurationElementCollection" /> после переопределения в производном классе.</summary>
		/// <returns>Имя элемента.</returns>
		/// <exception cref="T:System.ArgumentException">Избранное значение начинается с зарезервированного префикса config или lock.</exception>
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00004994 File Offset: 0x00002B94
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000499C File Offset: 0x00002B9C
		protected internal string ClearElementName
		{
			get
			{
				return this.clearElementName;
			}
			set
			{
				this.clearElementName = value;
			}
		}

		/// <summary>Получает или задает имя <see cref="T:System.Configuration.ConfigurationElement" />, связанное с операцией удаления в <see cref="T:System.Configuration.ConfigurationElementCollection" /> после переопределения в производном классе.</summary>
		/// <returns>Имя элемента.</returns>
		/// <exception cref="T:System.ArgumentException">Избранное значение начинается с зарезервированного префикса config или lock.</exception>
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000049A5 File Offset: 0x00002BA5
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000049AD File Offset: 0x00002BAD
		protected internal string RemoveElementName
		{
			get
			{
				return this.removeElementName;
			}
			set
			{
				this.removeElementName = value;
			}
		}

		/// <summary>Добавляет новый элемент конфигурации в <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
		/// <param name="element">Добавляемый объект <see cref="T:System.Configuration.ConfigurationElement" />.</param>
		// Token: 0x060000E8 RID: 232 RVA: 0x000049B6 File Offset: 0x00002BB6
		protected virtual void BaseAdd(ConfigurationElement element)
		{
			this.BaseAdd(element, this.ThrowOnDuplicate);
		}

		/// <summary>Добавляет элемент конфигурации в коллекцию элементов конфигурации.</summary>
		/// <param name="element">Добавляемый объект <see cref="T:System.Configuration.ConfigurationElement" />.</param>
		/// <param name="throwIfExists">Значение <see langword="true" />, чтобы выдать исключение, если указанный <see cref="T:System.Configuration.ConfigurationElement" /> уже содержится в <see cref="T:System.Configuration.ConfigurationElementCollection" />; в противном случае — значение <see langword="false" />.</param>
		/// <exception cref="T:System.Exception">Добавляемый <see cref="T:System.Configuration.ConfigurationElement" /> уже существует в <see cref="T:System.Configuration.ConfigurationElementCollection" /> и параметр <paramref name="throwIfExists" /> равен <see langword="true" />.</exception>
		// Token: 0x060000E9 RID: 233 RVA: 0x000049C8 File Offset: 0x00002BC8
		protected void BaseAdd(ConfigurationElement element, bool throwIfExists)
		{
			if (this.IsReadOnly())
			{
				throw new ConfigurationErrorsException("Collection is read only.");
			}
			if (this.IsAlternate)
			{
				this.list.Insert(this.inheritedLimitIndex, element);
				this.inheritedLimitIndex++;
			}
			else
			{
				int num = this.IndexOfKey(this.GetElementKey(element));
				if (num >= 0)
				{
					if (element.Equals(this.list[num]))
					{
						return;
					}
					if (throwIfExists)
					{
						throw new ConfigurationErrorsException("Duplicate element in collection");
					}
					this.list.RemoveAt(num);
				}
				this.list.Add(element);
			}
			this.modified = true;
		}

		/// <summary>Добавляет элемент конфигурации в коллекцию элементов конфигурации.</summary>
		/// <param name="index">Расположение индекса, в которое добавляется указанный <see cref="T:System.Configuration.ConfigurationElement" />.</param>
		/// <param name="element">Добавляемый объект <see cref="T:System.Configuration.ConfigurationElement" />.</param>
		// Token: 0x060000EA RID: 234 RVA: 0x00004A68 File Offset: 0x00002C68
		protected virtual void BaseAdd(int index, ConfigurationElement element)
		{
			if (this.ThrowOnDuplicate && this.BaseIndexOf(element) != -1)
			{
				throw new ConfigurationErrorsException("Duplicate element in collection");
			}
			if (this.IsReadOnly())
			{
				throw new ConfigurationErrorsException("Collection is read only.");
			}
			if (this.IsAlternate && index > this.inheritedLimitIndex)
			{
				throw new ConfigurationErrorsException("Can't insert new elements below the inherited elements.");
			}
			if (!this.IsAlternate && index <= this.inheritedLimitIndex)
			{
				throw new ConfigurationErrorsException("Can't insert new elements above the inherited elements.");
			}
			this.list.Insert(index, element);
			this.modified = true;
		}

		/// <summary>Удаляет все объекты элементов конфигурации из коллекции.</summary>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Конфигурация доступна только для чтения.  
		/// -или- 
		/// Элемент коллекции заблокирован на более высоком уровне конфигурации.</exception>
		// Token: 0x060000EB RID: 235 RVA: 0x00004AF1 File Offset: 0x00002CF1
		protected internal void BaseClear()
		{
			if (this.IsReadOnly())
			{
				throw new ConfigurationErrorsException("Collection is read only.");
			}
			this.list.Clear();
			this.modified = true;
		}

		/// <summary>Возвращает элемент конфигурации с указанным расположением индекса.</summary>
		/// <param name="index">Расположение индекса возвращаемого объекта <see cref="T:System.Configuration.ConfigurationElement" />.</param>
		/// <returns>Параметр <see cref="T:System.Configuration.ConfigurationElement" /> по указанному индексу.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Значение <paramref name="index" /> меньше <see langword="0" />.  
		/// -или- 
		/// Не существует объекта <see cref="T:System.Configuration.ConfigurationElement" /> по указанному <paramref name="index" />.</exception>
		// Token: 0x060000EC RID: 236 RVA: 0x00004B18 File Offset: 0x00002D18
		protected internal ConfigurationElement BaseGet(int index)
		{
			return (ConfigurationElement)this.list[index];
		}

		/// <summary>Возвращает элемент конфигурации с указанным ключом.</summary>
		/// <param name="key">Ключ возвращаемого элемента.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationElement" /> с указанным ключом; в противном случае — <see langword="null" />.</returns>
		// Token: 0x060000ED RID: 237 RVA: 0x00004B2C File Offset: 0x00002D2C
		protected internal ConfigurationElement BaseGet(object key)
		{
			int num = this.IndexOfKey(key);
			if (num != -1)
			{
				return (ConfigurationElement)this.list[num];
			}
			return null;
		}

		/// <summary>Возвращает массив ключей для всех элементов конфигурации, содержащихся в <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
		/// <returns>Массив с ключами для всех объектов <see cref="T:System.Configuration.ConfigurationElement" />, содержащихся в <see cref="T:System.Configuration.ConfigurationElementCollection" />.</returns>
		// Token: 0x060000EE RID: 238 RVA: 0x00004B58 File Offset: 0x00002D58
		protected internal object[] BaseGetAllKeys()
		{
			object[] array = new object[this.list.Count];
			for (int i = 0; i < this.list.Count; i++)
			{
				array[i] = this.BaseGetKey(i);
			}
			return array;
		}

		/// <summary>Получает ключ объекта <see cref="T:System.Configuration.ConfigurationElement" /> по указанному расположению индекса.</summary>
		/// <param name="index">Расположение индекса для объекта <see cref="T:System.Configuration.ConfigurationElement" />.</param>
		/// <returns>Ключ для указанного <see cref="T:System.Configuration.ConfigurationElement" />.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Значение <paramref name="index" /> меньше <see langword="0" />.  
		/// -или- 
		/// Не существует объекта <see cref="T:System.Configuration.ConfigurationElement" /> по указанному <paramref name="index" />.</exception>
		// Token: 0x060000EF RID: 239 RVA: 0x00004B98 File Offset: 0x00002D98
		protected internal object BaseGetKey(int index)
		{
			if (index < 0 || index >= this.list.Count)
			{
				throw new ConfigurationErrorsException(string.Format("Index {0} is out of range", index));
			}
			return this.GetElementKey((ConfigurationElement)this.list[index]).ToString();
		}

		/// <summary>Указывает индекс заданного объекта <see cref="T:System.Configuration.ConfigurationElement" />.</summary>
		/// <param name="element">Объект <see cref="T:System.Configuration.ConfigurationElement" /> по указанному расположению индекса.</param>
		/// <returns>Индекс заданного объекта <see cref="T:System.Configuration.ConfigurationElement" />; в противном случае — значение -1.</returns>
		// Token: 0x060000F0 RID: 240 RVA: 0x00004BE9 File Offset: 0x00002DE9
		protected int BaseIndexOf(ConfigurationElement element)
		{
			return this.list.IndexOf(element);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004BF8 File Offset: 0x00002DF8
		private int IndexOfKey(object key)
		{
			for (int i = 0; i < this.list.Count; i++)
			{
				if (this.CompareKeys(this.GetElementKey((ConfigurationElement)this.list[i]), key))
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Указывает, удален ли <see cref="T:System.Configuration.ConfigurationElement" /> с указанным ключом из <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
		/// <param name="key">Ключ проверяемого элемента.</param>
		/// <returns>Значение <see langword="true" />, если элемент <see cref="T:System.Configuration.ConfigurationElement" /> с указанным ключом был удален; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x060000F2 RID: 242 RVA: 0x00004C40 File Offset: 0x00002E40
		protected internal bool BaseIsRemoved(object key)
		{
			if (this.removed == null)
			{
				return false;
			}
			foreach (object obj in this.removed)
			{
				ConfigurationElement element = (ConfigurationElement)obj;
				if (this.CompareKeys(this.GetElementKey(element), key))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Удаляет объект <see cref="T:System.Configuration.ConfigurationElement" /> из коллекции.</summary>
		/// <param name="key">Ключ удаляемого объекта <see cref="T:System.Configuration.ConfigurationElement" />.</param>
		/// <exception cref="T:System.Exception">В коллекции нет объекта <see cref="T:System.Configuration.ConfigurationElement" /> с указанным ключом. Элемент уже был удален или его не удается удалить, потому что его значение <see cref="P:System.Configuration.ConfigurationProperty.Type" /> не равно <see cref="F:System.Configuration.ConfigurationElementCollectionType.AddRemoveClearMap" />.</exception>
		// Token: 0x060000F3 RID: 243 RVA: 0x00004CB4 File Offset: 0x00002EB4
		protected internal void BaseRemove(object key)
		{
			if (this.IsReadOnly())
			{
				throw new ConfigurationErrorsException("Collection is read only.");
			}
			int num = this.IndexOfKey(key);
			if (num != -1)
			{
				this.BaseRemoveAt(num);
				this.modified = true;
			}
		}

		/// <summary>Удаляет объект <see cref="T:System.Configuration.ConfigurationElement" /> по указанному расположению индекса.</summary>
		/// <param name="index">Расположение индекса удаляемого объекта <see cref="T:System.Configuration.ConfigurationElement" />.</param>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Конфигурация доступна только для чтения.  
		/// -или- 
		///  Значение <paramref name="index" /> меньше <see langword="0" /> или больше числа объектов <see cref="T:System.Configuration.ConfigurationElement" /> в коллекции.  
		/// -или- 
		/// Объект <see cref="T:System.Configuration.ConfigurationElement" /> уже был удален.  
		/// -или- 
		/// Значение объекта <see cref="T:System.Configuration.ConfigurationElement" /> заблокировано на более высоком уровне.  
		/// -или- 
		/// Объект <see cref="T:System.Configuration.ConfigurationElement" /> является унаследованным.  
		/// -или- 
		/// Значение <see cref="P:System.Configuration.ConfigurationProperty.Type" /> объекта <see cref="T:System.Configuration.ConfigurationElement" /> не равно <see cref="F:System.Configuration.ConfigurationElementCollectionType.AddRemoveClearMap" /> или <see cref="F:System.Configuration.ConfigurationElementCollectionType.AddRemoveClearMapAlternate" />.</exception>
		// Token: 0x060000F4 RID: 244 RVA: 0x00004CF0 File Offset: 0x00002EF0
		protected internal void BaseRemoveAt(int index)
		{
			if (this.IsReadOnly())
			{
				throw new ConfigurationErrorsException("Collection is read only.");
			}
			ConfigurationElement configurationElement = (ConfigurationElement)this.list[index];
			if (!this.IsElementRemovable(configurationElement))
			{
				throw new ConfigurationErrorsException("Element can't be removed from element collection.");
			}
			if (this.inherited != null && this.inherited.Contains(configurationElement))
			{
				throw new ConfigurationErrorsException("Inherited items can't be removed.");
			}
			this.list.RemoveAt(index);
			if (this.IsAlternate && this.inheritedLimitIndex > 0)
			{
				this.inheritedLimitIndex--;
			}
			this.modified = true;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004D89 File Offset: 0x00002F89
		private bool CompareKeys(object key1, object key2)
		{
			if (this.comparer != null)
			{
				return this.comparer.Compare(key1, key2) == 0;
			}
			return object.Equals(key1, key2);
		}

		/// <summary>Копирует содержимое объекта <see cref="T:System.Configuration.ConfigurationElementCollection" /> в массив.</summary>
		/// <param name="array">Массив, в который копируется содержимое <see cref="T:System.Configuration.ConfigurationElementCollection" />.</param>
		/// <param name="index">Расположение индекса, с которого начинается копирование.</param>
		// Token: 0x060000F6 RID: 246 RVA: 0x00004DAB File Offset: 0x00002FAB
		public void CopyTo(ConfigurationElement[] array, int index)
		{
			this.list.CopyTo(array, index);
		}

		/// <summary>При переопределении в производном классе создает новый объект <see cref="T:System.Configuration.ConfigurationElement" />.</summary>
		/// <returns>Только что созданный объект <see cref="T:System.Configuration.ConfigurationElement" />.</returns>
		// Token: 0x060000F7 RID: 247
		protected abstract ConfigurationElement CreateNewElement();

		/// <summary>При переопределении в производном классе создает новый элемент <see cref="T:System.Configuration.ConfigurationElement" />.</summary>
		/// <param name="elementName">Имя создаваемого элемента <see cref="T:System.Configuration.ConfigurationElement" />.</param>
		/// <returns>Новый <see cref="T:System.Configuration.ConfigurationElement" /> с указанным именем.</returns>
		// Token: 0x060000F8 RID: 248 RVA: 0x00004DBA File Offset: 0x00002FBA
		protected virtual ConfigurationElement CreateNewElement(string elementName)
		{
			return this.CreateNewElement();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004DC4 File Offset: 0x00002FC4
		private ConfigurationElement CreateNewElementInternal(string elementName)
		{
			ConfigurationElement configurationElement;
			if (elementName == null)
			{
				configurationElement = this.CreateNewElement();
			}
			else
			{
				configurationElement = this.CreateNewElement(elementName);
			}
			configurationElement.Init();
			return configurationElement;
		}

		/// <summary>Сравнивает <see cref="T:System.Configuration.ConfigurationElementCollection" /> с указанным объектом.</summary>
		/// <param name="compareTo">Объект для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если сравниваемый объект равен текущему экземпляру <see cref="T:System.Configuration.ConfigurationElementCollection" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x060000FA RID: 250 RVA: 0x00004DEC File Offset: 0x00002FEC
		public override bool Equals(object compareTo)
		{
			ConfigurationElementCollection configurationElementCollection = compareTo as ConfigurationElementCollection;
			if (configurationElementCollection == null)
			{
				return false;
			}
			if (base.GetType() != configurationElementCollection.GetType())
			{
				return false;
			}
			if (this.Count != configurationElementCollection.Count)
			{
				return false;
			}
			for (int i = 0; i < this.Count; i++)
			{
				if (!this.BaseGet(i).Equals(configurationElementCollection.BaseGet(i)))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>При переопределении в производном классе возвращает ключ указанного элемента конфигурации.</summary>
		/// <param name="element">Объект <see cref="T:System.Configuration.ConfigurationElement" />, для которого возвращается ключ.</param>
		/// <returns>Объект <see cref="T:System.Object" />, используемый в качестве ключа для указанного элемента <see cref="T:System.Configuration.ConfigurationElement" />.</returns>
		// Token: 0x060000FB RID: 251
		protected abstract object GetElementKey(ConfigurationElement element);

		/// <summary>Получает уникальное значение, представляющее экземпляр <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
		/// <returns>Уникальное значение, представляющее текущий экземпляр <see cref="T:System.Configuration.ConfigurationElementCollection" />.</returns>
		// Token: 0x060000FC RID: 252 RVA: 0x00004E54 File Offset: 0x00003054
		public override int GetHashCode()
		{
			int num = 0;
			for (int i = 0; i < this.Count; i++)
			{
				num += this.BaseGet(i).GetHashCode();
			}
			return num;
		}

		/// <summary>Копирует <see cref="T:System.Configuration.ConfigurationElementCollection" /> в массив.</summary>
		/// <param name="arr">Массив, в который копируется данная коллекция <see cref="T:System.Configuration.ConfigurationElementCollection" />.</param>
		/// <param name="index">Расположение индекса, с которого начинается копирование.</param>
		// Token: 0x060000FD RID: 253 RVA: 0x00004DAB File Offset: 0x00002FAB
		void ICollection.CopyTo(Array arr, int index)
		{
			this.list.CopyTo(arr, index);
		}

		/// <summary>Получает метод <see cref="T:System.Collections.IEnumerator" />, используемый для итерации по <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
		/// <returns>Метод <see cref="T:System.Collections.IEnumerator" />, используемый для итерации по <see cref="T:System.Configuration.ConfigurationElementCollection" />.</returns>
		// Token: 0x060000FE RID: 254 RVA: 0x00004E84 File Offset: 0x00003084
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		/// <summary>Указывает, существует ли указанный <see cref="T:System.Configuration.ConfigurationElement" /> в <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
		/// <param name="elementName">Имя проверяемого элемента.</param>
		/// <returns>Значение <see langword="true" />, если элемент присутствует в коллекции; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x060000FF RID: 255 RVA: 0x000023BB File Offset: 0x000005BB
		protected virtual bool IsElementName(string elementName)
		{
			return false;
		}

		/// <summary>Указывает, может ли указанный объект <see cref="T:System.Configuration.ConfigurationElement" /> быть удален из <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
		/// <param name="element">Проверяемый элемент.</param>
		/// <returns>Значение <see langword="true" />, если указанный <see cref="T:System.Configuration.ConfigurationElement" /> можно удалить из этой коллекции <see cref="T:System.Configuration.ConfigurationElementCollection" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x06000100 RID: 256 RVA: 0x00004E91 File Offset: 0x00003091
		protected virtual bool IsElementRemovable(ConfigurationElement element)
		{
			return !this.IsReadOnly();
		}

		/// <summary>Указывает, был ли изменен <see cref="T:System.Configuration.ConfigurationElementCollection" /> с момента последнего сохранения или загрузки после переопределения в производном классе.</summary>
		/// <returns>Значение <see langword="true" />, если элемент был изменен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000101 RID: 257 RVA: 0x00004E9C File Offset: 0x0000309C
		protected internal override bool IsModified()
		{
			if (this.modified)
			{
				return true;
			}
			for (int i = 0; i < this.list.Count; i++)
			{
				if (((ConfigurationElement)this.list[i]).IsModified())
				{
					this.modified = true;
					break;
				}
			}
			return this.modified;
		}

		/// <summary>Указывает, доступен ли объект <see cref="T:System.Configuration.ConfigurationElementCollection" /> только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Configuration.ConfigurationElementCollection" /> доступен только для чтения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000102 RID: 258 RVA: 0x00004EF0 File Offset: 0x000030F0
		[MonoTODO]
		public override bool IsReadOnly()
		{
			return base.IsReadOnly();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004EF8 File Offset: 0x000030F8
		internal override void PrepareSave(ConfigurationElement parentElement, ConfigurationSaveMode mode)
		{
			ConfigurationElementCollection configurationElementCollection = (ConfigurationElementCollection)parentElement;
			base.PrepareSave(parentElement, mode);
			for (int i = 0; i < this.list.Count; i++)
			{
				ConfigurationElement configurationElement = (ConfigurationElement)this.list[i];
				object elementKey = this.GetElementKey(configurationElement);
				ConfigurationElement parent = (configurationElementCollection != null) ? configurationElementCollection.BaseGet(elementKey) : null;
				configurationElement.PrepareSave(parent, mode);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004F5C File Offset: 0x0000315C
		internal override bool HasValues(ConfigurationElement parentElement, ConfigurationSaveMode mode)
		{
			ConfigurationElementCollection configurationElementCollection = (ConfigurationElementCollection)parentElement;
			if (mode == ConfigurationSaveMode.Full)
			{
				return this.list.Count > 0;
			}
			for (int i = 0; i < this.list.Count; i++)
			{
				ConfigurationElement configurationElement = (ConfigurationElement)this.list[i];
				object elementKey = this.GetElementKey(configurationElement);
				ConfigurationElement parent = (configurationElementCollection != null) ? configurationElementCollection.BaseGet(elementKey) : null;
				if (configurationElement.HasValues(parent, mode))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Сбрасывает <see cref="T:System.Configuration.ConfigurationElementCollection" /> в неизмененное состояние после переопределения в производном классе.</summary>
		/// <param name="parentElement">Значение <see cref="T:System.Configuration.ConfigurationElement" />, представляющее родительский элемент коллекции (если таковой имеется); в противном случае — значение <see langword="null" />.</param>
		// Token: 0x06000105 RID: 261 RVA: 0x00004FD0 File Offset: 0x000031D0
		protected internal override void Reset(ConfigurationElement parentElement)
		{
			bool isBasic = this.IsBasic;
			ConfigurationElementCollection configurationElementCollection = (ConfigurationElementCollection)parentElement;
			for (int i = 0; i < configurationElementCollection.Count; i++)
			{
				ConfigurationElement parentElement2 = configurationElementCollection.BaseGet(i);
				ConfigurationElement configurationElement = this.CreateNewElementInternal(null);
				configurationElement.Reset(parentElement2);
				this.BaseAdd(configurationElement);
				if (isBasic)
				{
					if (this.inherited == null)
					{
						this.inherited = new ArrayList();
					}
					this.inherited.Add(configurationElement);
				}
			}
			if (this.IsAlternate)
			{
				this.inheritedLimitIndex = 0;
			}
			else
			{
				this.inheritedLimitIndex = this.Count - 1;
			}
			this.modified = false;
		}

		/// <summary>Переустанавливает значение свойства <see cref="M:System.Configuration.ConfigurationElementCollection.IsModified" /> в <see langword="false" /> при переопределении в производном классе.</summary>
		// Token: 0x06000106 RID: 262 RVA: 0x00005068 File Offset: 0x00003268
		protected internal override void ResetModified()
		{
			this.modified = false;
			for (int i = 0; i < this.list.Count; i++)
			{
				((ConfigurationElement)this.list[i]).ResetModified();
			}
		}

		/// <summary>Устанавливает свойство <see cref="M:System.Configuration.ConfigurationElementCollection.IsReadOnly" /> для объекта <see cref="T:System.Configuration.ConfigurationElementCollection" /> и всех подчиненных элементов.</summary>
		// Token: 0x06000107 RID: 263 RVA: 0x000050A8 File Offset: 0x000032A8
		[MonoTODO]
		protected internal override void SetReadOnly()
		{
			base.SetReadOnly();
		}

		/// <summary>Записывает данные конфигурации в XML-элемент в файле конфигурации после переопределения в производном классе.</summary>
		/// <param name="writer">Выходной поток, записывающий XML в файл конфигурации.</param>
		/// <param name="serializeCollectionKey">Значение <see langword="true" /> для сериализации ключа коллекции, в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если элемент <see cref="T:System.Configuration.ConfigurationElementCollection" /> был успешно записан в файл конфигурации.</returns>
		/// <exception cref="T:System.ArgumentException">Один из элементов коллекции был добавлен или изменен и начинается с зарезервированного префикса config или lock.</exception>
		// Token: 0x06000108 RID: 264 RVA: 0x000050B0 File Offset: 0x000032B0
		protected internal override bool SerializeElement(XmlWriter writer, bool serializeCollectionKey)
		{
			if (serializeCollectionKey)
			{
				return base.SerializeElement(writer, serializeCollectionKey);
			}
			bool flag = false;
			if (this.IsBasic)
			{
				for (int i = 0; i < this.list.Count; i++)
				{
					ConfigurationElement configurationElement = (ConfigurationElement)this.list[i];
					if (this.ElementName != string.Empty)
					{
						flag = (configurationElement.SerializeToXmlElement(writer, this.ElementName) || flag);
					}
					else
					{
						flag = (configurationElement.SerializeElement(writer, false) || flag);
					}
				}
			}
			else
			{
				if (this.emitClear)
				{
					writer.WriteElementString(this.clearElementName, "");
					flag = true;
				}
				if (this.removed != null)
				{
					for (int j = 0; j < this.removed.Count; j++)
					{
						writer.WriteStartElement(this.removeElementName);
						((ConfigurationElement)this.removed[j]).SerializeElement(writer, true);
						writer.WriteEndElement();
					}
					flag = (flag || this.removed.Count > 0);
				}
				for (int k = 0; k < this.list.Count; k++)
				{
					((ConfigurationElement)this.list[k]).SerializeToXmlElement(writer, this.addElementName);
				}
				flag = (flag || this.list.Count > 0);
			}
			return flag;
		}

		/// <summary>Приводит к тому, что система конфигурации выдает исключение.</summary>
		/// <param name="elementName">Имя неопознанного элемента.</param>
		/// <param name="reader">Входной поток, который считывает XML из файла конфигурации.</param>
		/// <returns>Значение <see langword="true" />, если неопознанный элемент был успешно десериализован; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Элемент, указанный в <paramref name="elementName" />, является элементом <see langword="&lt;clear&gt;" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="elementName" /> начинается с зарезервированного префикса config или lock.</exception>
		// Token: 0x06000109 RID: 265 RVA: 0x000051F8 File Offset: 0x000033F8
		protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader)
		{
			if (this.IsBasic)
			{
				ConfigurationElement configurationElement = null;
				if (elementName == this.ElementName)
				{
					configurationElement = this.CreateNewElementInternal(null);
				}
				if (this.IsElementName(elementName))
				{
					configurationElement = this.CreateNewElementInternal(elementName);
				}
				if (configurationElement != null)
				{
					configurationElement.DeserializeElement(reader, false);
					this.BaseAdd(configurationElement);
					this.modified = false;
					return true;
				}
			}
			else if (elementName == this.clearElementName)
			{
				reader.MoveToContent();
				if (reader.MoveToNextAttribute())
				{
					throw new ConfigurationErrorsException("Unrecognized attribute '" + reader.LocalName + "'.");
				}
				reader.MoveToElement();
				reader.Skip();
				this.BaseClear();
				this.emitClear = true;
				this.modified = false;
				return true;
			}
			else
			{
				if (elementName == this.removeElementName)
				{
					ConfigurationElementCollection.ConfigurationRemoveElement configurationRemoveElement = new ConfigurationElementCollection.ConfigurationRemoveElement(this.CreateNewElementInternal(null), this);
					configurationRemoveElement.DeserializeElement(reader, true);
					this.BaseRemove(configurationRemoveElement.KeyValue);
					this.modified = false;
					return true;
				}
				if (elementName == this.addElementName)
				{
					ConfigurationElement configurationElement2 = this.CreateNewElementInternal(null);
					configurationElement2.DeserializeElement(reader, false);
					this.BaseAdd(configurationElement2);
					this.modified = false;
					return true;
				}
			}
			return false;
		}

		/// <summary>Отменяет эффект слияния данных конфигурации на разных уровнях иерархии конфигурации.</summary>
		/// <param name="sourceElement">Объект <see cref="T:System.Configuration.ConfigurationElement" /> текущего уровня, содержащий объединенное представление свойств.</param>
		/// <param name="parentElement">Родительский объект <see cref="T:System.Configuration.ConfigurationElement" /> текущего элемента или <see langword="null" />, если это верхний уровень.</param>
		/// <param name="saveMode">Одно из значений перечисления, определяющее, какие значения свойств следует включить.</param>
		// Token: 0x0600010A RID: 266 RVA: 0x00005318 File Offset: 0x00003518
		protected internal override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode)
		{
			ConfigurationElementCollection configurationElementCollection = (ConfigurationElementCollection)sourceElement;
			ConfigurationElementCollection configurationElementCollection2 = (ConfigurationElementCollection)parentElement;
			for (int i = 0; i < configurationElementCollection.Count; i++)
			{
				ConfigurationElement configurationElement = configurationElementCollection.BaseGet(i);
				object elementKey = configurationElementCollection.GetElementKey(configurationElement);
				ConfigurationElement configurationElement2 = (configurationElementCollection2 != null) ? configurationElementCollection2.BaseGet(elementKey) : null;
				ConfigurationElement configurationElement3 = this.CreateNewElementInternal(null);
				if (configurationElement2 != null && saveMode != ConfigurationSaveMode.Full)
				{
					configurationElement3.Unmerge(configurationElement, configurationElement2, saveMode);
					if (configurationElement3.HasValues(configurationElement2, saveMode))
					{
						this.BaseAdd(configurationElement3);
					}
				}
				else
				{
					configurationElement3.Unmerge(configurationElement, null, ConfigurationSaveMode.Full);
					this.BaseAdd(configurationElement3);
				}
			}
			if (saveMode == ConfigurationSaveMode.Full)
			{
				this.EmitClear = true;
				return;
			}
			if (configurationElementCollection2 != null)
			{
				for (int j = 0; j < configurationElementCollection2.Count; j++)
				{
					ConfigurationElement configurationElement4 = configurationElementCollection2.BaseGet(j);
					object elementKey2 = configurationElementCollection2.GetElementKey(configurationElement4);
					if (configurationElementCollection.IndexOfKey(elementKey2) == -1)
					{
						if (this.removed == null)
						{
							this.removed = new ArrayList();
						}
						this.removed.Add(configurationElement4);
					}
				}
			}
		}

		// Token: 0x04000073 RID: 115
		private ArrayList list = new ArrayList();

		// Token: 0x04000074 RID: 116
		private ArrayList removed;

		// Token: 0x04000075 RID: 117
		private ArrayList inherited;

		// Token: 0x04000076 RID: 118
		private bool emitClear;

		// Token: 0x04000077 RID: 119
		private bool modified;

		// Token: 0x04000078 RID: 120
		private IComparer comparer;

		// Token: 0x04000079 RID: 121
		private int inheritedLimitIndex;

		// Token: 0x0400007A RID: 122
		private string addElementName = "add";

		// Token: 0x0400007B RID: 123
		private string clearElementName = "clear";

		// Token: 0x0400007C RID: 124
		private string removeElementName = "remove";

		// Token: 0x0200001D RID: 29
		private sealed class ConfigurationRemoveElement : ConfigurationElement
		{
			// Token: 0x0600010B RID: 267 RVA: 0x00005410 File Offset: 0x00003610
			internal ConfigurationRemoveElement(ConfigurationElement origElement, ConfigurationElementCollection origCollection)
			{
				this._origElement = origElement;
				this._origCollection = origCollection;
				foreach (object obj in origElement.Properties)
				{
					ConfigurationProperty configurationProperty = (ConfigurationProperty)obj;
					if (configurationProperty.IsKey)
					{
						this.properties.Add(configurationProperty);
					}
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x0600010C RID: 268 RVA: 0x00005498 File Offset: 0x00003698
			internal object KeyValue
			{
				get
				{
					foreach (object obj in this.Properties)
					{
						ConfigurationProperty prop = (ConfigurationProperty)obj;
						this._origElement[prop] = base[prop];
					}
					return this._origCollection.GetElementKey(this._origElement);
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x0600010D RID: 269 RVA: 0x00005510 File Offset: 0x00003710
			protected internal override ConfigurationPropertyCollection Properties
			{
				get
				{
					return this.properties;
				}
			}

			// Token: 0x0400007D RID: 125
			private readonly ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

			// Token: 0x0400007E RID: 126
			private readonly ConfigurationElement _origElement;

			// Token: 0x0400007F RID: 127
			private readonly ConfigurationElementCollection _origCollection;
		}
	}
}
