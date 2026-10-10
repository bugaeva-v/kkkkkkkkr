using System;
using System.Runtime.InteropServices;

namespace System.Security
{
	/// <summary>Позволяет частично доверенному коду вызывать сборку. Без этого объявления использовать сборку могут только полностью доверенные вызывающие объекты. Этот класс не наследуется.</summary>
	// Token: 0x020003D0 RID: 976
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	[ComVisible(true)]
	public sealed class AllowPartiallyTrustedCallersAttribute : Attribute
	{
		/// <summary>Получает или задает видимость по умолчанию с частичным доверием для кода, отмеченного атрибутом <see cref="T:System.Security.AllowPartiallyTrustedCallersAttribute" /> (APTCA).</summary>
		/// <returns>Одно из значений перечисления. Значение по умолчанию — <see cref="F:System.Security.PartialTrustVisibilityLevel.VisibleToAllHosts" />.</returns>
		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06002864 RID: 10340 RVA: 0x00092A51 File Offset: 0x00090C51
		// (set) Token: 0x06002865 RID: 10341 RVA: 0x00092A59 File Offset: 0x00090C59
		public PartialTrustVisibilityLevel PartialTrustVisibilityLevel
		{
			get
			{
				return this._visibilityLevel;
			}
			set
			{
				this._visibilityLevel = value;
			}
		}

		// Token: 0x04001E9A RID: 7834
		private PartialTrustVisibilityLevel _visibilityLevel;
	}
}
