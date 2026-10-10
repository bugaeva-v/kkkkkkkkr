using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeBigIntSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000337 RID: 823
	public sealed class TypeBigIntSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeBigIntSchemaImporterExtension" />.</summary>
		// Token: 0x0600263B RID: 9787 RVA: 0x000AA479 File Offset: 0x000A8679
		public TypeBigIntSchemaImporterExtension() : base("bigint", "System.Data.SqlTypes.SqlInt64")
		{
		}
	}
}
