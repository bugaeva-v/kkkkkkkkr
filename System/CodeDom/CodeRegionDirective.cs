using System;

namespace System.CodeDom
{
	/// <summary>Задает имя и режим для области кода.</summary>
	// Token: 0x02000326 RID: 806
	[Serializable]
	public class CodeRegionDirective : CodeDirective
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeRegionDirective" /> со значениями по умолчанию.</summary>
		// Token: 0x060019AE RID: 6574 RVA: 0x0005F624 File Offset: 0x0005D824
		public CodeRegionDirective()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeRegionDirective" />, указывая его режим и имя.</summary>
		/// <param name="regionMode">Одно из значений <see cref="T:System.CodeDom.CodeRegionMode" />.</param>
		/// <param name="regionText">Имя для области.</param>
		// Token: 0x060019AF RID: 6575 RVA: 0x00060BF9 File Offset: 0x0005EDF9
		public CodeRegionDirective(CodeRegionMode regionMode, string regionText)
		{
			this.RegionText = regionText;
			this.RegionMode = regionMode;
		}

		/// <summary>Получает или задает имя области.</summary>
		/// <returns>Имя области.</returns>
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x00060C0F File Offset: 0x0005EE0F
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x00060C20 File Offset: 0x0005EE20
		public string RegionText
		{
			get
			{
				return this._regionText ?? string.Empty;
			}
			set
			{
				this._regionText = value;
			}
		}

		/// <summary>Получает или задает режим для директивы области.</summary>
		/// <returns>Одно из значений <see cref="T:System.CodeDom.CodeRegionMode" />. Значение по умолчанию — <see cref="F:System.CodeDom.CodeRegionMode.None" />.</returns>
		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x00060C29 File Offset: 0x0005EE29
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x00060C31 File Offset: 0x0005EE31
		public CodeRegionMode RegionMode { get; set; }

		// Token: 0x04000DCE RID: 3534
		private string _regionText;
	}
}
