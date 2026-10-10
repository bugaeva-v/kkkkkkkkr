using System;

namespace System.Configuration
{
	/// <summary>Указывает, что поставщик параметров должен отключить любую логику, которая вызывается во время обновления приложения. Этот класс не наследуется.</summary>
	// Token: 0x020001BB RID: 443
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class NoSettingsVersionUpgradeAttribute : Attribute
	{
	}
}
