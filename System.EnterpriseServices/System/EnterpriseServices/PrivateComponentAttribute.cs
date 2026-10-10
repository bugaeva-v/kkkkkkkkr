using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Определяет компонент в качестве частного компонента, который является видимым и активируемым только компонентами в том же самом приложении. Этот класс не наследуется.</summary>
	// Token: 0x02000037 RID: 55
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(false)]
	public sealed class PrivateComponentAttribute : Attribute
	{
	}
}
