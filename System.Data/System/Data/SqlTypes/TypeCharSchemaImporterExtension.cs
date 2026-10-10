using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeCharSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x0200032C RID: 812
	public sealed class TypeCharSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeCharSchemaImporterExtension" />.</summary>
		// Token: 0x06002630 RID: 9776 RVA: 0x000AA3A8 File Offset: 0x000A85A8
		public TypeCharSchemaImporterExtension() : base("char", "System.Data.SqlTypes.SqlString", false)
		{
		}
	}
}
