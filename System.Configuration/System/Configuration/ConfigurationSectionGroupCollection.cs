using System;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Unity;

namespace System.Configuration
{
	/// <summary>Представляет коллекцию объектов <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</summary>
	// Token: 0x02000034 RID: 52
	[Serializable]
	public sealed class ConfigurationSectionGroupCollection : NameObjectCollectionBase
	{
		// Token: 0x060001DC RID: 476 RVA: 0x0000717F File Offset: 0x0000537F
		internal ConfigurationSectionGroupCollection(Configuration config, SectionGroupInfo group) : base(StringComparer.Ordinal)
		{
			this.config = config;
			this.group = group;
		}

		/// <summary>Получает ключи всем объектам <see cref="T:System.Configuration.ConfigurationSectionGroup" />, содержащимся в данном объекте <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" />, содержащий имена всех групп разделов в коллекции.</returns>
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000719A File Offset: 0x0000539A
		public override NameObjectCollectionBase.KeysCollection Keys
		{
			get
			{
				return this.group.Groups.Keys;
			}
		}

		/// <summary>Возвращает число групп разделов в коллекции.</summary>
		/// <returns>Целое, представляющее число групп секций в коллекции.</returns>
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001DE RID: 478 RVA: 0x000071AC File Offset: 0x000053AC
		public override int Count
		{
			get
			{
				return this.group.Groups.Count;
			}
		}

		/// <summary>Возвращает из коллекции объект <see cref="T:System.Configuration.ConfigurationSectionGroup" /> с указанным именем.</summary>
		/// <param name="name">Имя возвращаемого объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationSectionGroup" /> с указанным именем.  
		/// В C# это свойство является индексатором класса <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</returns>
		// Token: 0x17000090 RID: 144
		public ConfigurationSectionGroup this[string name]
		{
			get
			{
				ConfigurationSectionGroup configurationSectionGroup = base.BaseGet(name) as ConfigurationSectionGroup;
				if (configurationSectionGroup == null)
				{
					SectionGroupInfo sectionGroupInfo = this.group.Groups[name] as SectionGroupInfo;
					if (sectionGroupInfo == null)
					{
						return null;
					}
					configurationSectionGroup = this.config.GetSectionGroupInstance(sectionGroupInfo);
					base.BaseSet(name, configurationSectionGroup);
				}
				return configurationSectionGroup;
			}
		}

		/// <summary>Возвращает из коллекции объект <see cref="T:System.Configuration.ConfigurationSectionGroup" /> с указанным индексом.</summary>
		/// <param name="index">Индекс возвращаемого объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationSectionGroup" />, расположенный по указанному индексу.  
		/// В C# это свойство является индексатором класса <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</returns>
		// Token: 0x17000091 RID: 145
		public ConfigurationSectionGroup this[int index]
		{
			get
			{
				return this[this.GetKey(index)];
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Configuration.ConfigurationSectionGroup" /> к данному объекту <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" />.</summary>
		/// <param name="name">Имя добавляемого объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</param>
		/// <param name="sectionGroup">Объект <see cref="T:System.Configuration.ConfigurationSectionGroup" />, который требуется добавить.</param>
		// Token: 0x060001E1 RID: 481 RVA: 0x0000721E File Offset: 0x0000541E
		public void Add(string name, ConfigurationSectionGroup sectionGroup)
		{
			this.config.CreateSectionGroup(this.group, name, sectionGroup);
		}

		/// <summary>Очищает коллекцию.</summary>
		// Token: 0x060001E2 RID: 482 RVA: 0x00007234 File Offset: 0x00005434
		public void Clear()
		{
			if (this.group.Groups != null)
			{
				foreach (object obj in this.group.Groups)
				{
					ConfigInfo configInfo = (ConfigInfo)obj;
					this.config.RemoveConfigInfo(configInfo);
				}
			}
		}

		/// <summary>Копирует данный объект <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" /> в массив.</summary>
		/// <param name="array">Массив, в который выполняется копирование объекта.</param>
		/// <param name="index">Расположение индекса, с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина <paramref name="array" /> меньше, чем значение <see cref="P:System.Configuration.ConfigurationSectionGroupCollection.Count" /> плюс <paramref name="index" />.</exception>
		// Token: 0x060001E3 RID: 483 RVA: 0x000072A4 File Offset: 0x000054A4
		public void CopyTo(ConfigurationSectionGroup[] array, int index)
		{
			for (int i = 0; i < this.group.Groups.Count; i++)
			{
				array[i + index] = this[i];
			}
		}

		/// <summary>Возвращает указанный объект <see cref="T:System.Configuration.ConfigurationSectionGroup" />, содержащийся в коллекции.</summary>
		/// <param name="index">Индекс возвращаемого объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationSectionGroup" />, расположенный по указанному индексу.</returns>
		// Token: 0x060001E4 RID: 484 RVA: 0x000072D8 File Offset: 0x000054D8
		public ConfigurationSectionGroup Get(int index)
		{
			return this[index];
		}

		/// <summary>Возвращает указанный объект <see cref="T:System.Configuration.ConfigurationSectionGroup" /> из коллекции.</summary>
		/// <param name="name">Имя возвращаемого объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationSectionGroup" /> с указанным именем.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение null или равен пустой строке ("").</exception>
		// Token: 0x060001E5 RID: 485 RVA: 0x000072E1 File Offset: 0x000054E1
		public ConfigurationSectionGroup Get(string name)
		{
			return this[name];
		}

		/// <summary>Возвращает перечислитель, который может выполнять итерацию по объекту <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации по объекту <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" />.</returns>
		// Token: 0x060001E6 RID: 486 RVA: 0x000072EA File Offset: 0x000054EA
		public override IEnumerator GetEnumerator()
		{
			return this.group.Groups.AllKeys.GetEnumerator();
		}

		/// <summary>Получает ключ указанного объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" />, содержащегося в данном объекте <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" />.</summary>
		/// <param name="index">Индекс группы раздела, ключ которой возвращается.</param>
		/// <returns>Ключ объекта <see cref="T:System.Configuration.ConfigurationSectionGroup" /> по указанному индексу.</returns>
		// Token: 0x060001E7 RID: 487 RVA: 0x00007301 File Offset: 0x00005501
		public string GetKey(int index)
		{
			return this.group.Groups.GetKey(index);
		}

		/// <summary>Удаляет объект <see cref="T:System.Configuration.ConfigurationSectionGroup" />, имя которого определено из данного объекта <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" />.</summary>
		/// <param name="name">Имя группы раздела, подлежащей удалению.</param>
		// Token: 0x060001E8 RID: 488 RVA: 0x00007314 File Offset: 0x00005514
		public void Remove(string name)
		{
			SectionGroupInfo sectionGroupInfo = this.group.Groups[name] as SectionGroupInfo;
			if (sectionGroupInfo != null)
			{
				this.config.RemoveConfigInfo(sectionGroupInfo);
			}
		}

		/// <summary>Удаляет объект <see cref="T:System.Configuration.ConfigurationSectionGroup" />, индекс которого определен из данного объекта <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" />.</summary>
		/// <param name="index">Индекс группы раздела, подлежащей удалению.</param>
		// Token: 0x060001E9 RID: 489 RVA: 0x00007348 File Offset: 0x00005548
		public void RemoveAt(int index)
		{
			SectionGroupInfo sectionGroupInfo = this.group.Groups[index] as SectionGroupInfo;
			this.config.RemoveConfigInfo(sectionGroupInfo);
		}

		/// <summary>Используется системой в процессе сериализации.</summary>
		/// <param name="info">Подходящий объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</param>
		/// <param name="context">Подходящий объект <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		// Token: 0x060001EA RID: 490 RVA: 0x0000371B File Offset: 0x0000191B
		[MonoTODO]
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00003518 File Offset: 0x00001718
		internal ConfigurationSectionGroupCollection()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040000CF RID: 207
		private SectionGroupInfo group;

		// Token: 0x040000D0 RID: 208
		private Configuration config;
	}
}
