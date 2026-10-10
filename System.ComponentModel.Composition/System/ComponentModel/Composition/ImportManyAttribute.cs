using System;
using System.ComponentModel.Composition.Primitives;

namespace System.ComponentModel.Composition
{
	/// <summary>Указывает, что свойство, поле или параметр должны заполняться всеми соответствующими экспортами с помощью объекта <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />.</summary>
	// Token: 0x02000047 RID: 71
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
	public class ImportManyAttribute : Attribute, IAttributedImport
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ImportManyAttribute" />, импортирующий набор экспортов с именем контракта по умолчанию.</summary>
		// Token: 0x060001FB RID: 507 RVA: 0x00005E74 File Offset: 0x00004074
		public ImportManyAttribute() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ImportManyAttribute" />, импортирующий набор экспортов с именем контракта, производным от заданного типа.</summary>
		/// <param name="contractType">Тип, от которого наследуется имя контракта импортируемых экспортов, либо значение <see langword="null" /> для использования имени контракта по умолчанию.</param>
		// Token: 0x060001FC RID: 508 RVA: 0x00005E7D File Offset: 0x0000407D
		public ImportManyAttribute(Type contractType) : this(null, contractType)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ImportManyAttribute" />, импортирующий набор экспортов с заданным именем контракта.</summary>
		/// <param name="contractName">Имя контракта импортируемых экспортов либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		// Token: 0x060001FD RID: 509 RVA: 0x00005E87 File Offset: 0x00004087
		public ImportManyAttribute(string contractName) : this(contractName, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ImportManyAttribute" />, импортирующий набор экспортов с заданными именем и типом контракта.</summary>
		/// <param name="contractName">Имя контракта импортируемых экспортов либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		/// <param name="contractType">Тип импортируемого экспорта.</param>
		// Token: 0x060001FE RID: 510 RVA: 0x00005E91 File Offset: 0x00004091
		public ImportManyAttribute(string contractName, Type contractType)
		{
			this.ContractName = contractName;
			this.ContractType = contractType;
		}

		/// <summary>Получает имя контракта импортируемых экспортов.</summary>
		/// <returns>Имя контракта импортируемых экспортов. Значением по умолчанию является пустая строка ("").</returns>
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00005EA7 File Offset: 0x000040A7
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00005EAF File Offset: 0x000040AF
		public string ContractName { get; private set; }

		/// <summary>Получает тип контракта импортируемого экспорта.</summary>
		/// <returns>Тип экспорта, ожидаемый данным импортом. Значение по умолчанию — <see langword="null" />, означающее, что тип будет получен путем определения типа члена, к которому прикреплен данный импорт. Если для типа установлено значение <see cref="T:System.Object" />, импорт будет соответствовать любому экспортируемому типу.</returns>
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00005EB8 File Offset: 0x000040B8
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00005EC0 File Offset: 0x000040C0
		public Type ContractType { get; private set; }

		/// <summary>Получает или задает значение, указывающее, будет ли заново компоноваться декорированное свойство или поле при изменении экспортов, предоставляющих соответствующий контракт.</summary>
		/// <returns>Значение <see langword="true" />, если свойство или поле позволяет выполнять рекомпозицию в случае добавления экспортов, предоставляющих то же имя <see cref="P:System.ComponentModel.Composition.ImportManyAttribute.ContractName" />, в контейнер <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> или удаления их из этого контейнера; в противном случае — значение <see langword="false" />.  
		/// Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00005EC9 File Offset: 0x000040C9
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00005ED1 File Offset: 0x000040D1
		public bool AllowRecomposition { get; set; }

		/// <summary>Получает или задает значение, указывающее, что импортеру требуется определенная политика <see cref="T:System.ComponentModel.Composition.CreationPolicy" /> для экспортов, используемых для удовлетворения данного импорта.</summary>
		/// <returns>Одно из следующих значений: 
		///  Значение <see cref="F:System.ComponentModel.Composition.CreationPolicy.Any" />, если импортеру не требуется определенная политика <see cref="T:System.ComponentModel.Composition.CreationPolicy" />. Это значение по умолчанию.  
		///  Значение <see cref="F:System.ComponentModel.Composition.CreationPolicy.Shared" />, если необходимо, чтобы все используемые экспорты совместно использовались всеми частями в контейнере.  
		///  Значение <see cref="F:System.ComponentModel.Composition.CreationPolicy.NonShared" />, если необходимо не предоставлять общий доступ ко всем используемым экспортам в контейнере. В этом случае каждая часть получает свой собственный экземпляр.</returns>
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00005EDA File Offset: 0x000040DA
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00005EE2 File Offset: 0x000040E2
		public CreationPolicy RequiredCreationPolicy { get; set; }

		/// <summary>Получает или задает значение, указывающее области, из которых данный импорт может быть удовлетворен.</summary>
		/// <returns>Значение, указывающее области, из которых данный импорт может быть удовлетворен.</returns>
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00005EEB File Offset: 0x000040EB
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00005EF3 File Offset: 0x000040F3
		public ImportSource Source { get; set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00005EFC File Offset: 0x000040FC
		ImportCardinality IAttributedImport.Cardinality
		{
			get
			{
				return ImportCardinality.ZeroOrMore;
			}
		}
	}
}
