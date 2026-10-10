using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeFloatSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x0200033C RID: 828
	public sealed class TypeFloatSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeFloatSchemaImporterExtension" />.</summary>
		// Token: 0x06002640 RID: 9792 RVA: 0x000AA4D3 File Offset: 0x000A86D3
		public TypeFloatSchemaImporterExtension() : base("float", "System.Data.SqlTypes.SqlDouble")
		{
		}
	}
}
