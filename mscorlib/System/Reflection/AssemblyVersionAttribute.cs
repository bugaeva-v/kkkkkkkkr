using System;

namespace System.Reflection
{
	/// <summary>Указывает версию сборки, которой присваиваются атрибуты.</summary>
	// Token: 0x02000891 RID: 2193
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyVersionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="AssemblyVersionAttribute" /> с номером версии сборки, которой присваиваются атрибуты.</summary>
		/// <param name="version">Номер версии сборки с соответствующими атрибутами.</param>
		// Token: 0x06004878 RID: 18552 RVA: 0x000EE1B7 File Offset: 0x000EC3B7
		public AssemblyVersionAttribute(string version)
		{
			this.Version = version;
		}

		/// <summary>Возвращает номер версии сборки с соответствующими атрибутами.</summary>
		/// <returns>Строка, содержащая номер версии сборки.</returns>
		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06004879 RID: 18553 RVA: 0x000EE1C6 File Offset: 0x000EC3C6
		public string Version { get; }
	}
}
