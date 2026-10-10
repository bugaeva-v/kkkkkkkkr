using System;

namespace System.Security.Policy
{
	/// <summary>Задает, как сопоставлять версии, когда приложение определения местоположения доверяет коллекции.</summary>
	// Token: 0x020003F8 RID: 1016
	public enum ApplicationVersionMatch
	{
		/// <summary>Совпадение на всех версиях.</summary>
		// Token: 0x04001F4A RID: 8010
		MatchAllVersions = 1,
		/// <summary>Совпадение на точно указанной версии.</summary>
		// Token: 0x04001F4B RID: 8011
		MatchExactVersion = 0
	}
}
