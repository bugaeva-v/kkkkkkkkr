using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeNCharSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x0200032D RID: 813
	public sealed class TypeNCharSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeNCharSchemaImporterExtension" />.</summary>
		// Token: 0x06002631 RID: 9777 RVA: 0x000AA3BB File Offset: 0x000A85BB
		public TypeNCharSchemaImporterExtension() : base("nchar", "System.Data.SqlTypes.SqlString", false)
		{
		}
	}
}
