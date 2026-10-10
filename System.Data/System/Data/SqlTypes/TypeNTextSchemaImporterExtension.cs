using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeNTextSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000331 RID: 817
	public sealed class TypeNTextSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeNTextSchemaImporterExtension" />.</summary>
		// Token: 0x06002635 RID: 9781 RVA: 0x000AA407 File Offset: 0x000A8607
		public TypeNTextSchemaImporterExtension() : base("ntext", "System.Data.SqlTypes.SqlString", false)
		{
		}
	}
}
