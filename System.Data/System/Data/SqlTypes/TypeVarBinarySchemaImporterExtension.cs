using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeVarBinarySchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000332 RID: 818
	public sealed class TypeVarBinarySchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeVarBinarySchemaImporterExtension" />.</summary>
		// Token: 0x06002636 RID: 9782 RVA: 0x000AA41A File Offset: 0x000A861A
		public TypeVarBinarySchemaImporterExtension() : base("varbinary", "System.Data.SqlTypes.SqlBinary", false)
		{
		}
	}
}
