using System;

namespace System.Configuration
{
	/// <summary>Определяет, что группа параметров или свойство приложения содержит отличимые данные для каждого пользователя приложения. Этот класс не наследуется.</summary>
	// Token: 0x020001DD RID: 477
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class UserScopedSettingAttribute : SettingAttribute
	{
	}
}
