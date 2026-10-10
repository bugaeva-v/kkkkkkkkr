using System;
using System.ComponentModel.Composition.Primitives;

namespace System.ComponentModel.Composition
{
	/// <summary>Указывает, что значение свойства, поля или параметра должно предоставляться объектом <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</summary>
	// Token: 0x02000044 RID: 68
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
	public class ImportAttribute : Attribute, IAttributedImport
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ImportAttribute" />, импортирующий экспорт с именем контракта по умолчанию.</summary>
		// Token: 0x060001E3 RID: 483 RVA: 0x00005D86 File Offset: 0x00003F86
		public ImportAttribute() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ImportAttribute" />, импортирующий экспорт с именем контракта, производным от заданного типа.</summary>
		/// <param name="contractType">Тип, от которого наследуется имя контракта экспорта, либо значение <see langword="null" /> для использования имени контракта по умолчанию.</param>
		// Token: 0x060001E4 RID: 484 RVA: 0x00005D8F File Offset: 0x00003F8F
		public ImportAttribute(Type contractType) : this(null, contractType)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ImportAttribute" />, импортирующий экспорт с заданным именем контракта.</summary>
		/// <param name="contractName">Имя контракта импортируемого экспорта либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		// Token: 0x060001E5 RID: 485 RVA: 0x00005D99 File Offset: 0x00003F99
		public ImportAttribute(string contractName) : this(contractName, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ImportAttribute" />, импортирующий экспорт с заданными именем и типом контракта.</summary>
		/// <param name="contractName">Имя контракта импортируемого экспорта либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		/// <param name="contractType">Тип импортируемого экспорта.</param>
		// Token: 0x060001E6 RID: 486 RVA: 0x00005DA3 File Offset: 0x00003FA3
		public ImportAttribute(string contractName, Type contractType)
		{
			this.ContractName = contractName;
			this.ContractType = contractType;
		}

		/// <summary>Получает имя контракта импортируемого экспорта.</summary>
		/// <returns>Имя контракта импортируемого экспорта. Значение по умолчанию — пустая строка ("").</returns>
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00005DB9 File Offset: 0x00003FB9
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00005DC1 File Offset: 0x00003FC1
		public string ContractName { get; private set; }

		/// <summary>Получает тип импортируемого экспорта.</summary>
		/// <returns>Тип импортируемого экспорта.</returns>
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00005DCA File Offset: 0x00003FCA
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00005DD2 File Offset: 0x00003FD2
		public Type ContractType { get; private set; }

		/// <summary>Получает или задает значение, указывающее, будет ли для типа свойства, поля или параметра установлено значение по умолчанию, если в контейнере отсутствует экспорт с данным именем контракта.</summary>
		/// <returns>Значение <see langword="true" />, если типу свойства, поля или параметра присваивается значение по умолчанию в случае отсутствия экспорта с именем <see cref="P:System.ComponentModel.Composition.ImportAttribute.ContractName" /> в контейнере <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00005DDB File Offset: 0x00003FDB
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00005DE3 File Offset: 0x00003FE3
		public bool AllowDefault { get; set; }

		/// <summary>Получает или задает значение, указывающее, будет ли выполняться рекомпозиция свойства или поля при изменении в контейнере экспорта с соответствующим контрактом.</summary>
		/// <returns>Значение <see langword="true" />, если свойство или поле позволяет выполнять рекомпозицию в случае добавления экспортов с соответствующим именем <see cref="P:System.ComponentModel.Composition.ImportAttribute.ContractName" /> в контейнер <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> или удаления их из этого контейнера; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00005DEC File Offset: 0x00003FEC
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00005DF4 File Offset: 0x00003FF4
		public bool AllowRecomposition { get; set; }

		/// <summary>Получает или задает значение, указывающее, что импортеру требуется определенная политика <see cref="T:System.ComponentModel.Composition.CreationPolicy" /> для экспортов, используемых для удовлетворения данного импорта.</summary>
		/// <returns>Одно из следующих значений: 
		///  Значение <see cref="F:System.ComponentModel.Composition.CreationPolicy.Any" />, если импортеру не требуется определенная политика <see cref="T:System.ComponentModel.Composition.CreationPolicy" />. Это значение по умолчанию.  
		///  Значение <see cref="F:System.ComponentModel.Composition.CreationPolicy.Shared" />, если необходимо, чтобы все используемые экспорты совместно использовались всеми частями в контейнере.  
		///  Значение <see cref="F:System.ComponentModel.Composition.CreationPolicy.NonShared" />, если необходимо не предоставлять общий доступ ко всем используемым экспортам в контейнере. В этом случае каждая часть получает свой собственный экземпляр.</returns>
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00005DFD File Offset: 0x00003FFD
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00005E05 File Offset: 0x00004005
		public CreationPolicy RequiredCreationPolicy { get; set; }

		/// <summary>Получает или задает значение, указывающее области, из которых данный импорт может быть удовлетворен.</summary>
		/// <returns>Значение, указывающее области, из которых данный импорт может быть удовлетворен.</returns>
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00005E0E File Offset: 0x0000400E
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00005E16 File Offset: 0x00004016
		public ImportSource Source { get; set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00005E1F File Offset: 0x0000401F
		ImportCardinality IAttributedImport.Cardinality
		{
			get
			{
				if (this.AllowDefault)
				{
					return ImportCardinality.ZeroOrOne;
				}
				return ImportCardinality.ExactlyOne;
			}
		}
	}
}
