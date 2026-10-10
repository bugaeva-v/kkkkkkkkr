using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeNumericSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000336 RID: 822
	public sealed class TypeNumericSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeNumericSchemaImporterExtension" />.</summary>
		// Token: 0x0600263A RID: 9786 RVA: 0x000AA466 File Offset: 0x000A8666
		public TypeNumericSchemaImporterExtension() : base("numeric", "System.Data.SqlTypes.SqlDecimal", false)
		{
		}
	}
}
