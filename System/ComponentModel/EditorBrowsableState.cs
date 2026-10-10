using System;

namespace System.ComponentModel
{
	/// <summary>Указывает отображаемое состояние свойства или метода в редакторе.</summary>
	// Token: 0x02000360 RID: 864
	public enum EditorBrowsableState
	{
		/// <summary>Это свойство или метод всегда отображается в редакторе.</summary>
		// Token: 0x04000E8E RID: 3726
		Always,
		/// <summary>Это свойство или метод никогда не отображается в редакторе.</summary>
		// Token: 0x04000E8F RID: 3727
		Never,
		/// <summary>Свойство или метод является элементом, который должен быть видимым только для опытных пользователей. Редактор может показать или скрыть такие свойства.</summary>
		// Token: 0x04000E90 RID: 3728
		Advanced
	}
}
