using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeTinyIntSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x0200033A RID: 826
	public sealed class TypeTinyIntSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeTinyIntSchemaImporterExtension" />.</summary>
		// Token: 0x0600263E RID: 9790 RVA: 0x000AA4AF File Offset: 0x000A86AF
		public TypeTinyIntSchemaImporterExtension() : base("tinyint", "System.Data.SqlTypes.SqlByte")
		{
		}
	}
}
