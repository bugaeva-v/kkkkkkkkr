using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeUniqueIdentifierSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000342 RID: 834
	public sealed class TypeUniqueIdentifierSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeUniqueIdentifierSchemaImporterExtension" />.</summary>
		// Token: 0x06002646 RID: 9798 RVA: 0x000AA53F File Offset: 0x000A873F
		public TypeUniqueIdentifierSchemaImporterExtension() : base("uniqueidentifier", "System.Data.SqlTypes.SqlGuid")
		{
		}
	}
}
