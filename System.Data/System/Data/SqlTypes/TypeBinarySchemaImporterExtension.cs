using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeBinarySchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000333 RID: 819
	public sealed class TypeBinarySchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeBinarySchemaImporterExtension" />.</summary>
		// Token: 0x06002637 RID: 9783 RVA: 0x000AA42D File Offset: 0x000A862D
		public TypeBinarySchemaImporterExtension() : base("binary", "System.Data.SqlTypes.SqlBinary", false)
		{
		}
	}
}
