using System;

namespace System.Drawing
{
	/// <summary>Указывает, что при интерпретации объявлений <see cref="T:System.Drawing.ToolboxBitmapAttribute" />, сборка должна искать указанные ресурсы во той же сборке, но со значением конфигурации <see cref="P:System.Drawing.Configuration.SystemDrawingSection.BitmapSuffix" /> добавленным к объявленному имени файла.</summary>
	// Token: 0x02000016 RID: 22
	[AttributeUsage(AttributeTargets.Assembly)]
	public class BitmapSuffixInSameAssemblyAttribute : Attribute
	{
	}
}
