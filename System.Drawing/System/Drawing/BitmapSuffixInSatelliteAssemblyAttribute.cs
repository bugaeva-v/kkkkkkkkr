using System;

namespace System.Drawing
{
	/// <summary>Указывает, что при интерпретации объявлений <see cref="T:System.Drawing.ToolboxBitmapAttribute" /> сборка должна искать указанные ресурсы во вспомогательной сборке, но со значением конфигурации <see cref="P:System.Drawing.Configuration.SystemDrawingSection.BitmapSuffix" />, добавленным к объявленному имени файла.</summary>
	// Token: 0x02000017 RID: 23
	[AttributeUsage(AttributeTargets.Assembly)]
	public class BitmapSuffixInSatelliteAssemblyAttribute : Attribute
	{
	}
}
