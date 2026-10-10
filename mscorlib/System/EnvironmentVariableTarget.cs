using System;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Задает расположение, в котором хранится переменная среды, или из которого она извлекается при выполнении операции Set или Get.</summary>
	// Token: 0x02000237 RID: 567
	[ComVisible(true)]
	public enum EnvironmentVariableTarget
	{
		/// <summary>Переменная среды хранится в блоке переменных среды, связанном с текущим процессом, или извлекается из этого блока.</summary>
		// Token: 0x04001719 RID: 5913
		Process,
		/// <summary>Переменная среды хранится в разделе реестра <see langword="HKEY_CURRENT_USER\Environment" /> операционной системы Windows или извлекается из этого раздела.</summary>
		// Token: 0x0400171A RID: 5914
		User,
		/// <summary>Переменная среды хранится в разделе реестра <see langword="HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Session Manager\Environment" /> операционной системы Windows или извлекается из этого раздела.</summary>
		// Token: 0x0400171B RID: 5915
		Machine
	}
}
