using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeIntSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000338 RID: 824
	public sealed class TypeIntSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeIntSchemaImporterExtension" />.</summary>
		// Token: 0x0600263C RID: 9788 RVA: 0x000AA48B File Offset: 0x000A868B
		public TypeIntSchemaImporterExtension() : base("int", "System.Data.SqlTypes.SqlInt32")
		{
		}
	}
}
