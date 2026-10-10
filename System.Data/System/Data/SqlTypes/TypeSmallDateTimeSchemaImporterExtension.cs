using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс TypeSmallDateTimeSchemaImporterExtension предназначен для использования не в качестве самостоятельного компонента, а в качестве класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x0200033F RID: 831
	public sealed class TypeSmallDateTimeSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса TypeSmallDateTimeSchemaImporterExtension.</summary>
		// Token: 0x06002643 RID: 9795 RVA: 0x000AA509 File Offset: 0x000A8709
		public TypeSmallDateTimeSchemaImporterExtension() : base("smalldatetime", "System.Data.SqlTypes.SqlDateTime")
		{
		}
	}
}
