using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Указывает пул потоков, в которой выполняется работа, предоставленная с помощью объекта <see cref="T:System.EnterpriseServices.Activity" />.</summary>
	// Token: 0x02000050 RID: 80
	[ComVisible(false)]
	[Serializable]
	public enum ThreadPoolOption
	{
		/// <summary>Пул потоков не используется. Если это значение используется для настройки объекта <see cref="T:System.EnterpriseServices.ServiceConfig" />, передаваемого в объект <see cref="T:System.EnterpriseServices.Activity" />, возникает исключение.</summary>
		// Token: 0x04000094 RID: 148
		None,
		/// <summary>Тот же тип апартамента пула потоков, который используется апартаментом потока вызывающего объекта.</summary>
		// Token: 0x04000095 RID: 149
		Inherit,
		/// <summary>Используется однопотоковое подразделение.</summary>
		// Token: 0x04000096 RID: 150
		STA,
		/// <summary>Используется многопотоковое подразделение.</summary>
		// Token: 0x04000097 RID: 151
		MTA
	}
}
