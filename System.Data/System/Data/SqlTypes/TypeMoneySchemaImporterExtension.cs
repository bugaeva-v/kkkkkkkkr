using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeMoneySchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000340 RID: 832
	public sealed class TypeMoneySchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeMoneySchemaImporterExtension" />.</summary>
		// Token: 0x06002644 RID: 9796 RVA: 0x000AA51B File Offset: 0x000A871B
		public TypeMoneySchemaImporterExtension() : base("money", "System.Data.SqlTypes.SqlMoney")
		{
		}
	}
}
