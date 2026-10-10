using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeTextSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000330 RID: 816
	public sealed class TypeTextSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeTextSchemaImporterExtension" />.</summary>
		// Token: 0x06002634 RID: 9780 RVA: 0x000AA3F4 File Offset: 0x000A85F4
		public TypeTextSchemaImporterExtension() : base("text", "System.Data.SqlTypes.SqlString", false)
		{
		}
	}
}
