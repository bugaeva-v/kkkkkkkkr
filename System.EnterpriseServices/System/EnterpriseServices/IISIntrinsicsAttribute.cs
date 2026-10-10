using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Включает доступ к встроенным значениям ASP из объекта <see cref="M:System.EnterpriseServices.ContextUtil.GetNamedProperty(System.String)" />. Этот класс не наследуется.</summary>
	// Token: 0x02000020 RID: 32
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(false)]
	public sealed class IISIntrinsicsAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.IISIntrinsicsAttribute" />, предоставляя доступ к встроенным значениям ASP.</summary>
		// Token: 0x0600006F RID: 111 RVA: 0x00002335 File Offset: 0x00000535
		public IISIntrinsicsAttribute()
		{
			this.val = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.IISIntrinsicsAttribute" /> с возможностью отключения доступа к встроенным значениям ASP.</summary>
		/// <param name="val">Значение <see langword="true" />, чтобы включить доступ к встроенным значениям ASP; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06000070 RID: 112 RVA: 0x00002344 File Offset: 0x00000544
		public IISIntrinsicsAttribute(bool val)
		{
			this.val = val;
		}

		/// <summary>Возвращает значение, определяющее, включен ли доступ к встроенным значениям ASP.</summary>
		/// <returns>Значение <see langword="true" />, если доступ включен; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002353 File Offset: 0x00000553
		public bool Value
		{
			get
			{
				return this.val;
			}
		}

		// Token: 0x04000055 RID: 85
		private bool val;
	}
}
