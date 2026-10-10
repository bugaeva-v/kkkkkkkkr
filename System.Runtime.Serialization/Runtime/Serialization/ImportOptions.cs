using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace System.Runtime.Serialization
{
	/// <summary>Представляет параметры, которые могут устанавливаться для <see cref="T:System.Runtime.Serialization.XsdDataContractImporter" />.</summary>
	// Token: 0x020000E9 RID: 233
	public class ImportOptions
	{
		/// <summary>Возвращает или задает значение, указывающее, будут ли помечены классы контракта данных атрибутом <see cref="T:System.SerializableAttribute" /> в дополнение к атрибуту <see cref="T:System.Runtime.Serialization.DataContractAttribute" />.</summary>
		/// <returns>Значение <see langword="true" />, если следует создать классы с применением атрибута <see cref="T:System.SerializableAttribute" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00035384 File Offset: 0x00033584
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x0003538C File Offset: 0x0003358C
		public bool GenerateSerializable
		{
			get
			{
				return this.generateSerializable;
			}
			set
			{
				this.generateSerializable = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, помечается ли созданный код как внутренний или как открытый.</summary>
		/// <returns>Значение <see langword="true" />, если код помечается как <see langword="internal" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x00035395 File Offset: 0x00033595
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x0003539D File Offset: 0x0003359D
		public bool GenerateInternal
		{
			get
			{
				return this.generateInternal;
			}
			set
			{
				this.generateInternal = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, должны ли типы создаваемого кода реализовать интерфейс <see cref="T:System.ComponentModel.INotifyPropertyChanged" />.</summary>
		/// <returns>Значение <see langword="true" />, если в создаваемом коде должен быть реализован интерфейс <see cref="T:System.ComponentModel.INotifyPropertyChanged" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x000353A6 File Offset: 0x000335A6
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x000353AE File Offset: 0x000335AE
		public bool EnableDataBinding
		{
			get
			{
				return this.enableDataBinding;
			}
			set
			{
				this.enableDataBinding = value;
			}
		}

		/// <summary>Возвращает или задает экземпляр класса <see cref="T:System.CodeDom.Compiler.CodeDomProvider" />, предоставляющий средства проверки, выявляющие, поддерживаются ли определенные параметры для целевого языка.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.Compiler.CodeDomProvider" />, предоставляющий средства проверки, выявляющие, поддерживаются ли определенные параметры для целевого языка.</returns>
		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x000353B7 File Offset: 0x000335B7
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x000353BF File Offset: 0x000335BF
		public CodeDomProvider CodeProvider
		{
			get
			{
				return this.codeProvider;
			}
			set
			{
				this.codeProvider = value;
			}
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.Generic.IList`1" />, содержащий типы, ссылки на которые присутствуют в созданном коде.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.Generic.IList`1" />, содержащий типы, на которые заданы ссылки.</returns>
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x000353C8 File Offset: 0x000335C8
		public ICollection<Type> ReferencedTypes
		{
			get
			{
				if (this.referencedTypes == null)
				{
					this.referencedTypes = new List<Type>();
				}
				return this.referencedTypes;
			}
		}

		/// <summary>Возвращает коллекцию типов, представляющую коллекции контрактов данных, на которые следует ссылаться при создании кода для коллекций, например списков или словарей элементов.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.Generic.ICollection`1" />, содержащий типы коллекций, на которые заданы ссылки.</returns>
		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x000353E3 File Offset: 0x000335E3
		public ICollection<Type> ReferencedCollectionTypes
		{
			get
			{
				if (this.referencedCollectionTypes == null)
				{
					this.referencedCollectionTypes = new List<Type>();
				}
				return this.referencedCollectionTypes;
			}
		}

		/// <summary>Возвращает словарь, содержащий сопоставление пространств имен контракта данных пространствам имен среды CLR, которое должно использоваться для создания кода при выполнении операции импорта.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.Generic.IDictionary`2" />, содержащий сопоставления пространств имен.</returns>
		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x000353FE File Offset: 0x000335FE
		public IDictionary<string, string> Namespaces
		{
			get
			{
				if (this.namespaces == null)
				{
					this.namespaces = new Dictionary<string, string>();
				}
				return this.namespaces;
			}
		}

		/// <summary>Возвращает или задает значение, определяющее, будут ли импортированы все типы схемы XML, включая типы, не соответствующие схеме контракта данных.</summary>
		/// <returns>Значение <see langword="true" />, если следует импортировать все типы схемы; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x00035419 File Offset: 0x00033619
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x00035421 File Offset: 0x00033621
		public bool ImportXmlType
		{
			get
			{
				return this.importXmlType;
			}
			set
			{
				this.importXmlType = value;
			}
		}

		/// <summary>Возвращает или задает суррогат контракта данных, который может использоваться для изменения кода, созданного при выполнении операции импорта.</summary>
		/// <returns>Реализация интерфейса <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" />, обрабатывающая импорт схемы.</returns>
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x0003542A File Offset: 0x0003362A
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x00035432 File Offset: 0x00033632
		public IDataContractSurrogate DataContractSurrogate
		{
			get
			{
				return this.dataContractSurrogate;
			}
			set
			{
				this.dataContractSurrogate = value;
			}
		}

		// Token: 0x04000615 RID: 1557
		private bool generateSerializable;

		// Token: 0x04000616 RID: 1558
		private bool generateInternal;

		// Token: 0x04000617 RID: 1559
		private bool enableDataBinding;

		// Token: 0x04000618 RID: 1560
		private CodeDomProvider codeProvider;

		// Token: 0x04000619 RID: 1561
		private ICollection<Type> referencedTypes;

		// Token: 0x0400061A RID: 1562
		private ICollection<Type> referencedCollectionTypes;

		// Token: 0x0400061B RID: 1563
		private IDictionary<string, string> namespaces;

		// Token: 0x0400061C RID: 1564
		private bool importXmlType;

		// Token: 0x0400061D RID: 1565
		private IDataContractSurrogate dataContractSurrogate;
	}
}
