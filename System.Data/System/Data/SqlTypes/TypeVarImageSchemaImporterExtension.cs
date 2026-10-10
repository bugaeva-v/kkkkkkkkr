using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeVarImageSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000334 RID: 820
	public sealed class TypeVarImageSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeVarImageSchemaImporterExtension" />.</summary>
		// Token: 0x06002638 RID: 9784 RVA: 0x000AA440 File Offset: 0x000A8640
		public TypeVarImageSchemaImporterExtension() : base("image", "System.Data.SqlTypes.SqlBinary", false)
		{
		}
	}
}
