using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeVarCharSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x0200032E RID: 814
	public sealed class TypeVarCharSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeVarCharSchemaImporterExtension" />.</summary>
		// Token: 0x06002632 RID: 9778 RVA: 0x000AA3CE File Offset: 0x000A85CE
		public TypeVarCharSchemaImporterExtension() : base("varchar", "System.Data.SqlTypes.SqlString", false)
		{
		}
	}
}
