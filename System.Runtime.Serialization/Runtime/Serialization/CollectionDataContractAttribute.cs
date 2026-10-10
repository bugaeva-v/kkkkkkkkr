using System;

namespace System.Runtime.Serialization
{
	/// <summary>При применении к типу коллекции позволяет пользователю задавать элементы коллекции. Этот атрибут может применяться только к типам, распознаваемым методом <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> как допустимые сериализуемые коллекции.</summary>
	// Token: 0x020000B8 RID: 184
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
	public sealed class CollectionDataContractAttribute : Attribute
	{
		/// <summary>Возвращает или задает пространство имен для контракта данных.</summary>
		/// <returns>Пространство имен контракта данных.</returns>
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0002CC0E File Offset: 0x0002AE0E
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x0002CC16 File Offset: 0x0002AE16
		public string Namespace
		{
			get
			{
				return this.ns;
			}
			set
			{
				this.ns = value;
				this.isNamespaceSetExplicitly = true;
			}
		}

		/// <summary>Получает значение, указывающее, был ли объект <see cref="P:System.Runtime.Serialization.CollectionDataContractAttribute.Namespace" /> задан явно.</summary>
		/// <returns>
		///   <see langword="true" /> Если пространство имен элемента было задано явно; в противном случае <see langword="false" />.</returns>
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0002CC26 File Offset: 0x0002AE26
		public bool IsNamespaceSetExplicitly
		{
			get
			{
				return this.isNamespaceSetExplicitly;
			}
		}

		/// <summary>Возвращает или задает имя контракта данных для типа коллекции.</summary>
		/// <returns>Имя контракта данных для типа коллекции.</returns>
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0002CC2E File Offset: 0x0002AE2E
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x0002CC36 File Offset: 0x0002AE36
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
				this.isNameSetExplicitly = true;
			}
		}

		/// <summary>Получает значение, указывающее, был ли объект <see cref="P:System.Runtime.Serialization.CollectionDataContractAttribute.Name" /> задан явно.</summary>
		/// <returns>
		///   <see langword="true" /> Если имя было задано явно; в противном случае <see langword="false" />.</returns>
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0002CC46 File Offset: 0x0002AE46
		public bool IsNameSetExplicitly
		{
			get
			{
				return this.isNameSetExplicitly;
			}
		}

		/// <summary>Возвращает или задает пользовательское имя для элемента коллекции.</summary>
		/// <returns>Имя, применяемое к элементам коллекции.</returns>
		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0002CC4E File Offset: 0x0002AE4E
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x0002CC56 File Offset: 0x0002AE56
		public string ItemName
		{
			get
			{
				return this.itemName;
			}
			set
			{
				this.itemName = value;
				this.isItemNameSetExplicitly = true;
			}
		}

		/// <summary>Получает значение, указывающее, был ли объект <see cref="P:System.Runtime.Serialization.CollectionDataContractAttribute.ItemName" /> задан явно.</summary>
		/// <returns>
		///   <see langword="true" /> Если имя элемента было задано явно; в противном случае <see langword="false" />.</returns>
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0002CC66 File Offset: 0x0002AE66
		public bool IsItemNameSetExplicitly
		{
			get
			{
				return this.isItemNameSetExplicitly;
			}
		}

		/// <summary>Возвращает или задает пользовательское имя для имени ключа словаря.</summary>
		/// <returns>Имя, используемое вместо имени ключа словаря по умолчанию.</returns>
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0002CC6E File Offset: 0x0002AE6E
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x0002CC76 File Offset: 0x0002AE76
		public string KeyName
		{
			get
			{
				return this.keyName;
			}
			set
			{
				this.keyName = value;
				this.isKeyNameSetExplicitly = true;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, следует ли сохранять данные ссылки на объект.</summary>
		/// <returns>Значение <see langword="true" />, если требуется сохранить данные ссылки на объект; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0002CC86 File Offset: 0x0002AE86
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x0002CC8E File Offset: 0x0002AE8E
		public bool IsReference
		{
			get
			{
				return this.isReference;
			}
			set
			{
				this.isReference = value;
				this.isReferenceSetExplicitly = true;
			}
		}

		/// <summary>Получает значение, указывающее, была ли ссылка задана явно.</summary>
		/// <returns>Значение <see langword="true" />, если эта ссылка была задана явно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0002CC9E File Offset: 0x0002AE9E
		public bool IsReferenceSetExplicitly
		{
			get
			{
				return this.isReferenceSetExplicitly;
			}
		}

		/// <summary>Получает значение, указывающее, был ли объект <see cref="P:System.Runtime.Serialization.CollectionDataContractAttribute.KeyName" /> задан явно.</summary>
		/// <returns>
		///   <see langword="true" /> Если имя ключа было задано явно; в противном случае <see langword="false" />.</returns>
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0002CCA6 File Offset: 0x0002AEA6
		public bool IsKeyNameSetExplicitly
		{
			get
			{
				return this.isKeyNameSetExplicitly;
			}
		}

		/// <summary>Возвращает или задает пользовательское имя для имени значения словаря.</summary>
		/// <returns>Имя, используемое вместо имени значения словаря по умолчанию.</returns>
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x0002CCAE File Offset: 0x0002AEAE
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x0002CCB6 File Offset: 0x0002AEB6
		public string ValueName
		{
			get
			{
				return this.valueName;
			}
			set
			{
				this.valueName = value;
				this.isValueNameSetExplicitly = true;
			}
		}

		/// <summary>Получает значение, указывающее, был ли объект <see cref="P:System.Runtime.Serialization.CollectionDataContractAttribute.ValueName" /> задан явно.</summary>
		/// <returns>
		///   <see langword="true" /> Если имя значения было задано явно; в противном случае <see langword="false" />.</returns>
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0002CCC6 File Offset: 0x0002AEC6
		public bool IsValueNameSetExplicitly
		{
			get
			{
				return this.isValueNameSetExplicitly;
			}
		}

		// Token: 0x04000450 RID: 1104
		private string name;

		// Token: 0x04000451 RID: 1105
		private string ns;

		// Token: 0x04000452 RID: 1106
		private string itemName;

		// Token: 0x04000453 RID: 1107
		private string keyName;

		// Token: 0x04000454 RID: 1108
		private string valueName;

		// Token: 0x04000455 RID: 1109
		private bool isReference;

		// Token: 0x04000456 RID: 1110
		private bool isNameSetExplicitly;

		// Token: 0x04000457 RID: 1111
		private bool isNamespaceSetExplicitly;

		// Token: 0x04000458 RID: 1112
		private bool isReferenceSetExplicitly;

		// Token: 0x04000459 RID: 1113
		private bool isItemNameSetExplicitly;

		// Token: 0x0400045A RID: 1114
		private bool isKeyNameSetExplicitly;

		// Token: 0x0400045B RID: 1115
		private bool isValueNameSetExplicitly;
	}
}
