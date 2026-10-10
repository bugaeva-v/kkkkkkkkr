using System;
using System.Security.Policy;

namespace System.Security
{
	/// <summary>Получает значение <see cref="T:System.Security.Policy.Evidence" /> объекта.</summary>
	// Token: 0x020003C7 RID: 967
	public interface IEvidenceFactory
	{
		/// <summary>Получает значение <see cref="T:System.Security.Policy.Evidence" />, подтверждающее идентификацию текущего объекта.</summary>
		/// <returns>Свидетельство <see cref="T:System.Security.Policy.Evidence" /> идентификации текущего объекта.</returns>
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06002853 RID: 10323
		Evidence Evidence { get; }
	}
}
