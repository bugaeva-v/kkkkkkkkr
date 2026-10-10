using System;

namespace System.Resources
{
	/// <summary>Определяет, в какой сборке объект <see cref="T:System.Resources.ResourceManager" /> выполняет поиск ресурсов языковых и региональных параметров по умолчанию приложения: в основной или вспомогательной.</summary>
	// Token: 0x02000862 RID: 2146
	public enum UltimateResourceFallbackLocation
	{
		/// <summary>Резервные ресурсы размещаются в главной сборке.</summary>
		// Token: 0x04002DC9 RID: 11721
		MainAssembly,
		/// <summary>Резервные ресурсы размещаются во вспомогательной сборке.</summary>
		// Token: 0x04002DCA RID: 11722
		Satellite
	}
}
