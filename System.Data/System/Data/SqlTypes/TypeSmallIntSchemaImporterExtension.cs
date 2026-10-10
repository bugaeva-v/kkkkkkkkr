using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeSmallIntSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000339 RID: 825
	public sealed class TypeSmallIntSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeSmallIntSchemaImporterExtension" />.</summary>
		// Token: 0x0600263D RID: 9789 RVA: 0x000AA49D File Offset: 0x000A869D
		public TypeSmallIntSchemaImporterExtension() : base("smallint", "System.Data.SqlTypes.SqlInt16")
		{
		}
	}
}
