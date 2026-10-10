using System;

namespace System.Configuration
{
	/// <summary>Декларативно указывает платформе .NET Framework на необходимость создания коллекции элементов конфигурации. Этот класс не наследуется.</summary>
	// Token: 0x02000017 RID: 23
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class ConfigurationCollectionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConfigurationCollectionAttribute" />.</summary>
		/// <param name="itemType">Создаваемый тип свойства коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="itemType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000089 RID: 137 RVA: 0x0000352F File Offset: 0x0000172F
		public ConfigurationCollectionAttribute(Type itemType)
		{
			this.itemType = itemType;
		}

		/// <summary>Возвращает или задает имя элемента конфигурации <see langword="&lt;add&gt;" />.</summary>
		/// <returns>Имя, которое заменяет стандартное имя add в разделе конфигурации.</returns>
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000355F File Offset: 0x0000175F
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00003567 File Offset: 0x00001767
		public string AddItemName
		{
			get
			{
				return this.addItemName;
			}
			set
			{
				this.addItemName = value;
			}
		}

		/// <summary>Возвращает или задает имя элемента конфигурации <see langword="&lt;clear&gt;" />.</summary>
		/// <returns>Имя, которое заменяет стандартное имя clear в разделе конфигурации.</returns>
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00003570 File Offset: 0x00001770
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00003578 File Offset: 0x00001778
		public string ClearItemsName
		{
			get
			{
				return this.clearItemsName;
			}
			set
			{
				this.clearItemsName = value;
			}
		}

		/// <summary>Возвращает или задает имя элемента конфигурации <see langword="&lt;remove&gt;" />.</summary>
		/// <returns>Имя, которое заменяет стандартное имя remove в разделе конфигурации.</returns>
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00003581 File Offset: 0x00001781
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00003589 File Offset: 0x00001789
		public string RemoveItemName
		{
			get
			{
				return this.removeItemName;
			}
			set
			{
				this.removeItemName = value;
			}
		}

		/// <summary>Возвращает или задает тип атрибута <see cref="T:System.Configuration.ConfigurationCollectionAttribute" />.</summary>
		/// <returns>Тип <see cref="T:System.Configuration.ConfigurationCollectionAttribute" />.</returns>
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003592 File Offset: 0x00001792
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000359A File Offset: 0x0000179A
		public ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return this.collectionType;
			}
			set
			{
				this.collectionType = value;
			}
		}

		/// <summary>Возвращает тип элемента коллекции.</summary>
		/// <returns>Тип элемента коллекции.</returns>
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000035A3 File Offset: 0x000017A3
		[MonoInternalNote("Do something with this in ConfigurationElementCollection")]
		public Type ItemType
		{
			get
			{
				return this.itemType;
			}
		}

		// Token: 0x04000058 RID: 88
		private string addItemName = "add";

		// Token: 0x04000059 RID: 89
		private string clearItemsName = "clear";

		// Token: 0x0400005A RID: 90
		private string removeItemName = "remove";

		// Token: 0x0400005B RID: 91
		private ConfigurationElementCollectionType collectionType;

		// Token: 0x0400005C RID: 92
		private Type itemType;
	}
}
