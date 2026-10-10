using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeSmallMoneySchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000341 RID: 833
	public sealed class TypeSmallMoneySchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeSmallMoneySchemaImporterExtension" />.</summary>
		// Token: 0x06002645 RID: 9797 RVA: 0x000AA52D File Offset: 0x000A872D
		public TypeSmallMoneySchemaImporterExtension() : base("smallmoney", "System.Data.SqlTypes.SqlMoney")
		{
		}
	}
}
