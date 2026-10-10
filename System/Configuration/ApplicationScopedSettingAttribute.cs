using System;

namespace System.Configuration
{
	/// <summary>Определяет, что свойство параметров приложения имеет общее значение для всех пользователей приложения. Этот класс не наследуется.</summary>
	// Token: 0x02000198 RID: 408
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class ApplicationScopedSettingAttribute : SettingAttribute
	{
	}
}
