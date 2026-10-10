using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeBitSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x0200033B RID: 827
	public sealed class TypeBitSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeBitSchemaImporterExtension" />.</summary>
		// Token: 0x0600263F RID: 9791 RVA: 0x000AA4C1 File Offset: 0x000A86C1
		public TypeBitSchemaImporterExtension() : base("bit", "System.Data.SqlTypes.SqlBoolean")
		{
		}
	}
}
