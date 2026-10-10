using System;

namespace System.Configuration
{
	/// <summary>Указывает уровень в иерархии спецификации, на котором создаются значения свойств конфигурации.</summary>
	// Token: 0x0200005B RID: 91
	public enum PropertyValueOrigin
	{
		/// <summary>Значение свойства конфигурации создается в свойстве <see cref="P:System.Configuration.ConfigurationProperty.DefaultValue" />.</summary>
		// Token: 0x0400011B RID: 283
		Default,
		/// <summary>Значение свойства конфигурации наследуется от родительского уровня в конфигурации.</summary>
		// Token: 0x0400011C RID: 284
		Inherited,
		/// <summary>Значение свойства конфигурации определяется на текущем уровне иерархии.</summary>
		// Token: 0x0400011D RID: 285
		SetHere
	}
}
