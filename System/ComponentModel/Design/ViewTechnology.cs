using System;

namespace System.ComponentModel.Design
{
	/// <summary>Определяет идентификаторы для набора технологий, поддерживаемых хостами конструкторов.</summary>
	// Token: 0x02000479 RID: 1145
	public enum ViewTechnology
	{
		/// <summary>Представляет режим, при котором объект просмотра передается непосредственно в среду разработки.</summary>
		// Token: 0x04001485 RID: 5253
		[Obsolete("This value has been deprecated. Use ViewTechnology.Default instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		Passthrough,
		/// <summary>Представляет режим отображения базового конструктора с помощью объекта элемента управления Windows Forms.</summary>
		// Token: 0x04001486 RID: 5254
		[Obsolete("This value has been deprecated. Use ViewTechnology.Default instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		WindowsForms,
		/// <summary>Задает поддержку используемой по умолчанию технологии представления.</summary>
		// Token: 0x04001487 RID: 5255
		Default
	}
}
