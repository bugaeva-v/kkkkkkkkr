using System;

namespace System.ComponentModel.Composition
{
	/// <summary>Указывает, что тип предоставляет определенный экспорт и подклассы этого типа также предоставляют данный экспорт.</summary>
	// Token: 0x0200004A RID: 74
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public class InheritedExportAttribute : ExportAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.InheritedExportAttribute" />.</summary>
		// Token: 0x0600020B RID: 523 RVA: 0x00005EFF File Offset: 0x000040FF
		public InheritedExportAttribute() : this(null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.InheritedExportAttribute" /> указанным типом контракта.</summary>
		/// <param name="contractType">Тип контракта.</param>
		// Token: 0x0600020C RID: 524 RVA: 0x00005F09 File Offset: 0x00004109
		public InheritedExportAttribute(Type contractType) : this(null, contractType)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.InheritedExportAttribute" /> указанным именем контракта.</summary>
		/// <param name="contractName">Имя контракта.</param>
		// Token: 0x0600020D RID: 525 RVA: 0x00005F13 File Offset: 0x00004113
		public InheritedExportAttribute(string contractName) : this(contractName, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.InheritedExportAttribute" /> указанным именем и типом контракта.</summary>
		/// <param name="contractName">Имя контракта.</param>
		/// <param name="contractType">Тип контракта.</param>
		// Token: 0x0600020E RID: 526 RVA: 0x00005F1D File Offset: 0x0000411D
		public InheritedExportAttribute(string contractName, Type contractType) : base(contractName, contractType)
		{
		}
	}
}
