using System;
using System.Diagnostics;

namespace System.Runtime.Versioning
{
	/// <summary>Указывает доступность ресурса для члена класса. Этот класс не наследуется.</summary>
	// Token: 0x02000640 RID: 1600
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, Inherited = false)]
	[Conditional("RESOURCE_ANNOTATION_WORK")]
	public sealed class ResourceExposureAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Versioning.ResourceExposureAttribute" /> с заданным уровнем доступности.</summary>
		/// <param name="exposureLevel">Область видимости ресурса.</param>
		// Token: 0x06003C2F RID: 15407 RVA: 0x000D11BF File Offset: 0x000CF3BF
		public ResourceExposureAttribute(ResourceScope exposureLevel)
		{
			this._resourceExposureLevel = exposureLevel;
		}

		/// <summary>Возвращает область доступности ресурса.</summary>
		/// <returns>Объект <see cref="T:System.Runtime.Versioning.ResourceScope" />.</returns>
		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06003C30 RID: 15408 RVA: 0x000D11CE File Offset: 0x000CF3CE
		public ResourceScope ResourceExposureLevel
		{
			get
			{
				return this._resourceExposureLevel;
			}
		}

		// Token: 0x040026F8 RID: 9976
		private ResourceScope _resourceExposureLevel;
	}
}
