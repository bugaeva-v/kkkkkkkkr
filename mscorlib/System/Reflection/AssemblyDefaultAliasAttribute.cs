using System;

namespace System.Reflection
{
	/// <summary>Определяет понятный псевдоним по умолчанию для манифеста сборки.</summary>
	// Token: 0x02000883 RID: 2179
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDefaultAliasAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyDefaultAliasAttribute" />.</summary>
		/// <param name="defaultAlias">Сведения о псевдониме по умолчанию для данной сборки.</param>
		// Token: 0x06004859 RID: 18521 RVA: 0x000EE060 File Offset: 0x000EC260
		public AssemblyDefaultAliasAttribute(string defaultAlias)
		{
			this.DefaultAlias = defaultAlias;
		}

		/// <summary>Возвращает сведения о псевдониме по умолчанию.</summary>
		/// <returns>Строка, содержащая сведения о псевдониме по умолчанию.</returns>
		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x0600485A RID: 18522 RVA: 0x000EE06F File Offset: 0x000EC26F
		public string DefaultAlias { get; }
	}
}
