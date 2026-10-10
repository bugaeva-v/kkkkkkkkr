using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Включает поддержку построения объектов COM+. Этот класс не наследуется.</summary>
	// Token: 0x02000018 RID: 24
	[ComVisible(false)]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ConstructionEnabledAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ConstructionEnabledAttribute" /> и инициализирует значения по умолчанию для объектов <see cref="P:System.EnterpriseServices.ConstructionEnabledAttribute.Enabled" /> и <see cref="P:System.EnterpriseServices.ConstructionEnabledAttribute.Default" />.</summary>
		// Token: 0x06000041 RID: 65 RVA: 0x00002234 File Offset: 0x00000434
		public ConstructionEnabledAttribute()
		{
			this.def = string.Empty;
			this.enabled = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ConstructionEnabledAttribute" />, устанавливая указанное значение для объекта <see cref="P:System.EnterpriseServices.ConstructionEnabledAttribute.Enabled" />.</summary>
		/// <param name="val">Значение <see langword="true" />, чтобы включить поддержку построения объектов COM+; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06000042 RID: 66 RVA: 0x0000224E File Offset: 0x0000044E
		public ConstructionEnabledAttribute(bool val)
		{
			this.def = string.Empty;
			this.enabled = val;
		}

		/// <summary>Получает или задает значение по умолчанию для строки конструктора.</summary>
		/// <returns>Значение, которое должно использоваться по умолчанию для строки конструктора. Значение по умолчанию — пустая строка ("").</returns>
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002268 File Offset: 0x00000468
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002270 File Offset: 0x00000470
		public string Default
		{
			get
			{
				return this.def;
			}
			set
			{
				this.def = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, включена ли поддержка построения объектов COM+.</summary>
		/// <returns>Значение <see langword="true" />, если поддержка построения объектов COM+ включена; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002279 File Offset: 0x00000479
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002281 File Offset: 0x00000481
		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				this.enabled = value;
			}
		}

		// Token: 0x0400004C RID: 76
		private string def;

		// Token: 0x0400004D RID: 77
		private bool enabled;
	}
}
