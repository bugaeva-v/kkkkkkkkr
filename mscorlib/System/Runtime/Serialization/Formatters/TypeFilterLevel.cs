using System;

namespace System.Runtime.Serialization.Formatters
{
	/// <summary>Задает уровень автоматической десериализации для удаленного взаимодействия .NET Framework.</summary>
	// Token: 0x0200067A RID: 1658
	public enum TypeFilterLevel
	{
		/// <summary>Низкий уровень десериализации для удаленного взаимодействия .NET Framework. Поддерживаются типы, связанные с основными функциональными возможностями удаленного взаимодействия.</summary>
		// Token: 0x040027AD RID: 10157
		Low = 2,
		/// <summary>Полный уровень десериализации для удаленного взаимодействия .NET Framework. Поддерживаются все типы, которые поддерживаются удаленным взаимодействием во всех ситуациях.</summary>
		// Token: 0x040027AE RID: 10158
		Full
	}
}
