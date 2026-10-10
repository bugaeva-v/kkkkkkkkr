using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Задает режим удаления для свойств в новой группе общих свойств.</summary>
	// Token: 0x02000039 RID: 57
	[ComVisible(false)]
	[Serializable]
	public enum PropertyReleaseMode
	{
		/// <summary>Группа свойств не уничтожается до тех пор, пока не завершается процесс, в котором она была создана.</summary>
		// Token: 0x0400007B RID: 123
		Process = 1,
		/// <summary>Когда все клиенты удаляют свои ссылки на группу свойств, она автоматически уничтожается. Это режим COM, используемый по умолчанию.</summary>
		// Token: 0x0400007C RID: 124
		Standard = 0
	}
}
