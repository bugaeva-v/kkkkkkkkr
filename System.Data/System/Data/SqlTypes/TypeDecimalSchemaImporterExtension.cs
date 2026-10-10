using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeDecimalSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000335 RID: 821
	public sealed class TypeDecimalSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeDecimalSchemaImporterExtension" />.</summary>
		// Token: 0x06002639 RID: 9785 RVA: 0x000AA453 File Offset: 0x000A8653
		public TypeDecimalSchemaImporterExtension() : base("decimal", "System.Data.SqlTypes.SqlDecimal", false)
		{
		}
	}
}
