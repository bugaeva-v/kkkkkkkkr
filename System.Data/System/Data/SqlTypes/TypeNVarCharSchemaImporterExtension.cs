using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeNVarCharSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x0200032F RID: 815
	public sealed class TypeNVarCharSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeNVarCharSchemaImporterExtension" />.</summary>
		// Token: 0x06002633 RID: 9779 RVA: 0x000AA3E1 File Offset: 0x000A85E1
		public TypeNVarCharSchemaImporterExtension() : base("nvarchar", "System.Data.SqlTypes.SqlString", false)
		{
		}
	}
}
