using System;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Unity;

namespace System.Configuration
{
	/// <summary>Представляет коллекцию связанных разделов в конфигурационном файле.</summary>
	// Token: 0x02000031 RID: 49
	[Serializable]
	public sealed class ConfigurationSectionCollection : NameObjectCollectionBase
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00006CF7 File Offset: 0x00004EF7
		internal ConfigurationSectionCollection(Configuration config, SectionGroupInfo group) : base(StringComparer.Ordinal)
		{
			this.config = config;
			this.group = group;
		}

		/// <summary>Возвращает ключи всем объектам <see cref="T:System.Configuration.ConfigurationSection" />, содержащимся в данном объекте <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.Specialized.NameObjectCollectionBase.KeysCollection" />, содержащий ключи всех разделов в данной коллекции.</returns>
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00006D12 File Offset: 0x00004F12
		public override NameObjectCollectionBase.KeysCollection Keys
		{
			get
			{
				return this.group.Sections.Keys;
			}
		}

		/// <summary>Получает число разделов в данном объекте <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</summary>
		/// <returns>Целое число, представляющее количество разделов в коллекции.</returns>
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00006D24 File Offset: 0x00004F24
		public override int Count
		{
			get
			{
				return this.group.Sections.Count;
			}
		}

		/// <summary>Возвращает указанный объект <see cref="T:System.Configuration.ConfigurationSection" />.</summary>
		/// <param name="name">Имя возвращаемого объекта <see cref="T:System.Configuration.ConfigurationSection" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationSection" /> с указанным именем.</returns>
		// Token: 0x17000082 RID: 130
		public ConfigurationSection this[string name]
		{
			get
			{
				ConfigurationSection configurationSection = base.BaseGet(name) as ConfigurationSection;
				if (configurationSection == null)
				{
					SectionInfo sectionInfo = this.group.Sections[name] as SectionInfo;
					if (sectionInfo == null)
					{
						return null;
					}
					configurationSection = this.config.GetSectionInstance(sectionInfo, true);
					if (configurationSection == null)
					{
						return null;
					}
					object obj = ConfigurationSectionCollection.lockObject;
					lock (obj)
					{
						base.BaseSet(name, configurationSection);
					}
				}
				return configurationSection;
			}
		}

		/// <summary>Возвращает указанный объект <see cref="T:System.Configuration.ConfigurationSection" />.</summary>
		/// <param name="index">Индекс возвращаемого объекта <see cref="T:System.Configuration.ConfigurationSection" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationSection" /> по указанному индексу.</returns>
		// Token: 0x17000083 RID: 131
		public ConfigurationSection this[int index]
		{
			get
			{
				return this[this.GetKey(index)];
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Configuration.ConfigurationSection" /> в объект <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</summary>
		/// <param name="name">Имя добавляемого раздела.</param>
		/// <param name="section">Добавляемый раздел.</param>
		// Token: 0x060001BA RID: 442 RVA: 0x00006DCB File Offset: 0x00004FCB
		public void Add(string name, ConfigurationSection section)
		{
			this.config.CreateSection(this.group, name, section);
		}

		/// <summary>Очищает объект <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</summary>
		// Token: 0x060001BB RID: 443 RVA: 0x00006DE0 File Offset: 0x00004FE0
		public void Clear()
		{
			if (this.group.Sections != null)
			{
				foreach (object obj in this.group.Sections)
				{
					ConfigInfo configInfo = (ConfigInfo)obj;
					this.config.RemoveConfigInfo(configInfo);
				}
			}
		}

		/// <summary>Копирует данный объект <see cref="T:System.Configuration.ConfigurationSectionCollection" /> в массив.</summary>
		/// <param name="array">Массив, в который выполняется копирование объекта <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</param>
		/// <param name="index">Расположение индекса, с которого начинается копирование.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина <paramref name="array" /> меньше, чем <see cref="P:System.Configuration.ConfigurationSectionCollection.Count" /> плюс <paramref name="index" />.</exception>
		// Token: 0x060001BC RID: 444 RVA: 0x00006E50 File Offset: 0x00005050
		public void CopyTo(ConfigurationSection[] array, int index)
		{
			for (int i = 0; i < this.group.Sections.Count; i++)
			{
				array[i + index] = this[i];
			}
		}

		/// <summary>Получает указанный объект <see cref="T:System.Configuration.ConfigurationSection" />, содержащийся в данном объекте <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</summary>
		/// <param name="index">Индекс возвращаемого объекта <see cref="T:System.Configuration.ConfigurationSection" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationSection" /> по указанному индексу.</returns>
		// Token: 0x060001BD RID: 445 RVA: 0x00006E84 File Offset: 0x00005084
		public ConfigurationSection Get(int index)
		{
			return this[index];
		}

		/// <summary>Получает указанный объект <see cref="T:System.Configuration.ConfigurationSection" />, содержащийся в данном объекте <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</summary>
		/// <param name="name">Имя возвращаемого объекта <see cref="T:System.Configuration.ConfigurationSection" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationSection" /> с указанным именем.</returns>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="name" /> равно NULL или пустой строке ("").</exception>
		// Token: 0x060001BE RID: 446 RVA: 0x00006E8D File Offset: 0x0000508D
		public ConfigurationSection Get(string name)
		{
			return this[name];
		}

		/// <summary>Получает перечислитель, который позволяет выполнять перебор элементов объекта <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который позволяет выполнять перебор элементов объекта <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</returns>
		// Token: 0x060001BF RID: 447 RVA: 0x00006E96 File Offset: 0x00005096
		public override IEnumerator GetEnumerator()
		{
			foreach (object obj in this.group.Sections.AllKeys)
			{
				string name = (string)obj;
				yield return this[name];
			}
			IEnumerator enumerator = null;
			yield break;
			yield break;
		}

		/// <summary>Получает ключ указанного объекта <see cref="T:System.Configuration.ConfigurationSection" />, содержащегося в данном объекте <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</summary>
		/// <param name="index">Индекс объекта <see cref="T:System.Configuration.ConfigurationSection" />, ключ которого возвращается.</param>
		/// <returns>Ключ объекта <see cref="T:System.Configuration.ConfigurationSection" /> по указанному индексу.</returns>
		// Token: 0x060001C0 RID: 448 RVA: 0x00006EA5 File Offset: 0x000050A5
		public string GetKey(int index)
		{
			return this.group.Sections.GetKey(index);
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.Configuration.ConfigurationSection" /> из данного объекта <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</summary>
		/// <param name="name">Имя раздела, подлежащего удалению.</param>
		// Token: 0x060001C1 RID: 449 RVA: 0x00006EB8 File Offset: 0x000050B8
		public void Remove(string name)
		{
			SectionInfo sectionInfo = this.group.Sections[name] as SectionInfo;
			if (sectionInfo != null)
			{
				this.config.RemoveConfigInfo(sectionInfo);
			}
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.Configuration.ConfigurationSection" /> из данного объекта <see cref="T:System.Configuration.ConfigurationSectionCollection" />.</summary>
		/// <param name="index">Удаляемый индекс раздела.</param>
		// Token: 0x060001C2 RID: 450 RVA: 0x00006EEC File Offset: 0x000050EC
		public void RemoveAt(int index)
		{
			SectionInfo sectionInfo = this.group.Sections[index] as SectionInfo;
			this.config.RemoveConfigInfo(sectionInfo);
		}

		/// <summary>Используется системой в процессе сериализации.</summary>
		/// <param name="info">Подходящий объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</param>
		/// <param name="context">Подходящий объект <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		// Token: 0x060001C3 RID: 451 RVA: 0x0000371B File Offset: 0x0000191B
		[MonoTODO]
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00003518 File Offset: 0x00001718
		internal ConfigurationSectionCollection()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040000C0 RID: 192
		private SectionGroupInfo group;

		// Token: 0x040000C1 RID: 193
		private Configuration config;

		// Token: 0x040000C2 RID: 194
		private static readonly object lockObject = new object();
	}
}
