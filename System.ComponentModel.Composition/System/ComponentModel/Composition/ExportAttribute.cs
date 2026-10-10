using System;

namespace System.ComponentModel.Composition
{
	/// <summary>Указывает, что типом, свойством, полем или методом предоставляется определенный экспорт.</summary>
	// Token: 0x02000035 RID: 53
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	public class ExportAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ExportAttribute" />, экспортирующего тип или член, помеченный данным атрибутом, в рамках имени контракта по умолчанию.</summary>
		// Token: 0x060001AA RID: 426 RVA: 0x0000585F File Offset: 0x00003A5F
		public ExportAttribute() : this(null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ExportAttribute" />, экспортирующего тип или член, помеченный данным атрибутом, в рамках имени контракта, производного от заданного типа.</summary>
		/// <param name="contractType">Тип, от которого наследуется имя контракта, используемое для экспорта типа или члена, помеченного данным атрибутом, или значение <see langword="null" /> для использования имени контракта по умолчанию.</param>
		// Token: 0x060001AB RID: 427 RVA: 0x00005869 File Offset: 0x00003A69
		public ExportAttribute(Type contractType) : this(null, contractType)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ExportAttribute" />, экспортирующего тип или член, помеченный данным атрибутом, в рамках заданного имени контракта.</summary>
		/// <param name="contractName">Имя контракта, используемое для экспорта типа или члена, помеченного данным атрибутом, либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		// Token: 0x060001AC RID: 428 RVA: 0x00005873 File Offset: 0x00003A73
		public ExportAttribute(string contractName) : this(contractName, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ExportAttribute" />, экспортирующего указанный тип в рамках заданного имени контракта.</summary>
		/// <param name="contractName">Имя контракта, используемое для экспорта типа или члена, помеченного данным атрибутом, либо значение <see langword="null" /> или пустая строка ("") для использования имени контракта по умолчанию.</param>
		/// <param name="contractType">Экспортируемый тип.</param>
		// Token: 0x060001AD RID: 429 RVA: 0x0000587D File Offset: 0x00003A7D
		public ExportAttribute(string contractName, Type contractType)
		{
			this.ContractName = contractName;
			this.ContractType = contractType;
		}

		/// <summary>Получает имя контракта, используемое для экспорта типа или члена, помеченного данным атрибутом.</summary>
		/// <returns>Имя контракта, используемое для экспорта типа или члена, помеченного данным атрибутом. Значением по умолчанию является пустая строка ("").</returns>
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00005893 File Offset: 0x00003A93
		// (set) Token: 0x060001AF RID: 431 RVA: 0x0000589B File Offset: 0x00003A9B
		public string ContractName { get; private set; }

		/// <summary>Получает тип контракта, экспортируемый членом, к которому прикреплен данный атрибут.</summary>
		/// <returns>Тип предоставляемого экспорта. Значение по умолчанию — <see langword="null" />, означающее, что тип будет получен путем определения типа члена, к которому прикреплен данный экспорт.</returns>
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x000058A4 File Offset: 0x00003AA4
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x000058AC File Offset: 0x00003AAC
		public Type ContractType { get; private set; }
	}
}
