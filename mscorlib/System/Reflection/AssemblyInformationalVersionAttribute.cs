using System;

namespace System.Reflection
{
	/// <summary>Определяет дополнительные сведения о версии для манифеста сборки.</summary>
	// Token: 0x02000888 RID: 2184
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyInformationalVersionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyInformationalVersionAttribute" />.</summary>
		/// <param name="informationalVersion">Сведения о версии сборки.</param>
		// Token: 0x06004866 RID: 18534 RVA: 0x000EE0E1 File Offset: 0x000EC2E1
		public AssemblyInformationalVersionAttribute(string informationalVersion)
		{
			this.InformationalVersion = informationalVersion;
		}

		/// <summary>Возвращает сведения о версии.</summary>
		/// <returns>Строка, содержащая сведения о версии.</returns>
		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06004867 RID: 18535 RVA: 0x000EE0F0 File Offset: 0x000EC2F0
		public string InformationalVersion { get; }
	}
}
