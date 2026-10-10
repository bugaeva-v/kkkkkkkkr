using System;

namespace System.Reflection
{
	/// <summary>Указывает конфигурацию сборки, например окончательную или отладочную, для сборки.</summary>
	// Token: 0x0200087F RID: 2175
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyConfigurationAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyConfigurationAttribute" />.</summary>
		/// <param name="configuration">Конфигурация сборки.</param>
		// Token: 0x06004853 RID: 18515 RVA: 0x000EE01B File Offset: 0x000EC21B
		public AssemblyConfigurationAttribute(string configuration)
		{
			this.Configuration = configuration;
		}

		/// <summary>Возвращает сведения о конфигурации сборки.</summary>
		/// <returns>Строка, содержащая сведения о конфигурации сборки.</returns>
		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06004854 RID: 18516 RVA: 0x000EE02A File Offset: 0x000EC22A
		public string Configuration { get; }
	}
}
