using System;

namespace System.Security
{
	/// <summary>
	///         Представляет тип, к которому применяется сведения о подписи манифеста.
	///       </summary>
	// Token: 0x0200036B RID: 875
	[Flags]
	public enum ManifestKinds
	{
		/// <summary>
		///         Является манифест приложения.
		///       </summary>
		// Token: 0x04000CD7 RID: 3287
		Application = 2,
		/// <summary>
		///         Является манифест для развертывания и приложения.
		///          Значение по умолчанию для проверки сигнатур.
		///       </summary>
		// Token: 0x04000CD8 RID: 3288
		ApplicationAndDeployment = 3,
		/// <summary>
		///         Манифест — только для развертывания.
		///       </summary>
		// Token: 0x04000CD9 RID: 3289
		Deployment = 1,
		/// <summary>
		///         Манифест — без конкретного типа.
		///       </summary>
		// Token: 0x04000CDA RID: 3290
		None = 0
	}
}
