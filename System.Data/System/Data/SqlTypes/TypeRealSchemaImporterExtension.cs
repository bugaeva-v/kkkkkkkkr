using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeRealSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x0200033D RID: 829
	public sealed class TypeRealSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeRealSchemaImporterExtension" />.</summary>
		// Token: 0x06002641 RID: 9793 RVA: 0x000AA4E5 File Offset: 0x000A86E5
		public TypeRealSchemaImporterExtension() : base("real", "System.Data.SqlTypes.SqlSingle")
		{
		}
	}
}
