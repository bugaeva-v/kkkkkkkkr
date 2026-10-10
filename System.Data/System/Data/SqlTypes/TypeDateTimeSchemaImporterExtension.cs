using System;

namespace System.Data.SqlTypes
{
	/// <summary>Класс <see cref="T:System.Data.SqlTypes.TypeDateTimeSchemaImporterExtension" /> предназначен для использования не в качестве самостоятельного компонента, а в качестве базового класса, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x0200033E RID: 830
	public sealed class TypeDateTimeSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlTypes.TypeDateTimeSchemaImporterExtension" />.</summary>
		// Token: 0x06002642 RID: 9794 RVA: 0x000AA4F7 File Offset: 0x000A86F7
		public TypeDateTimeSchemaImporterExtension() : base("datetime", "System.Data.SqlTypes.SqlDateTime")
		{
		}
	}
}
