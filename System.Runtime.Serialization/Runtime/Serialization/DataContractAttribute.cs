using System;

namespace System.Runtime.Serialization
{
	/// <summary>Указывает, что тип определяет или реализует контракт данных и может быть сериализован сериализатором, таким как <see cref="T:System.Runtime.Serialization.DataContractSerializer" />. Чтобы сделать тип сериализуемым, авторы типа должны определить для него контракт данных.</summary>
	// Token: 0x020000C4 RID: 196
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
	public sealed class DataContractAttribute : Attribute
	{
		/// <summary>Возвращает или задает значение, указывающее, следует ли сохранять данные ссылки на объект.</summary>
		/// <returns>Значение <see langword="true" />, если требуется сохранить данные ссылки на объект с помощью стандартного XML; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x000302BE File Offset: 0x0002E4BE
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x000302C6 File Offset: 0x0002E4C6
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

		/// <summary>Получает значение, указывающее, был ли объект <see cref="P:System.Runtime.Serialization.DataContractAttribute.IsReference" /> задан явно.</summary>
		/// <returns>Значение <see langword="true" />, если эта ссылка была задана явно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x000302D6 File Offset: 0x0002E4D6
		public bool IsReferenceSetExplicitly
		{
			get
			{
				return this.isReferenceSetExplicitly;
			}
		}

		/// <summary>Возвращает или задает пространство имен для контракта данных типа.</summary>
		/// <returns>Пространство имен контракта.</returns>
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x000302DE File Offset: 0x0002E4DE
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x000302E6 File Offset: 0x0002E4E6
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

		/// <summary>Получает значение, указывающее, был ли объект <see cref="P:System.Runtime.Serialization.DataContractAttribute.Namespace" /> задан явно.</summary>
		/// <returns>
		///   <see langword="true" /> Если пространство имен было явно задано; в противном случае <see langword="false" />.</returns>
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x000302F6 File Offset: 0x0002E4F6
		public bool IsNamespaceSetExplicitly
		{
			get
			{
				return this.isNamespaceSetExplicitly;
			}
		}

		/// <summary>Возвращает или задает имя для контракта данных типа.</summary>
		/// <returns>Локальное имя контракта данных. Значение по умолчанию — это имя класса, к которому применяется атрибут.</returns>
		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x000302FE File Offset: 0x0002E4FE
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00030306 File Offset: 0x0002E506
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

		/// <summary>Получает значение, указывающее, был ли объект <see cref="P:System.Runtime.Serialization.DataContractAttribute.Name" /> задан явно.</summary>
		/// <returns>
		///   <see langword="true" /> Если имя было задано явно; в противном случае <see langword="false" />.</returns>
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00030316 File Offset: 0x0002E516
		public bool IsNameSetExplicitly
		{
			get
			{
				return this.isNameSetExplicitly;
			}
		}

		// Token: 0x0400048F RID: 1167
		private string name;

		// Token: 0x04000490 RID: 1168
		private string ns;

		// Token: 0x04000491 RID: 1169
		private bool isNameSetExplicitly;

		// Token: 0x04000492 RID: 1170
		private bool isNamespaceSetExplicitly;

		// Token: 0x04000493 RID: 1171
		private bool isReference;

		// Token: 0x04000494 RID: 1172
		private bool isReferenceSetExplicitly;
	}
}
