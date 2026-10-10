using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Позволяет компоненту отслеживать событие. Этот класс не наследуется.</summary>
	// Token: 0x0200001C RID: 28
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(false)]
	public sealed class EventTrackingEnabledAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.EventTrackingEnabledAttribute" />, включая отслеживание событий.</summary>
		// Token: 0x06000066 RID: 102 RVA: 0x000022F8 File Offset: 0x000004F8
		public EventTrackingEnabledAttribute()
		{
			this.val = true;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.EventTrackingEnabledAttribute" />, отключая при необходимости отслеживание событий.</summary>
		/// <param name="val">Значение <see langword="true" />, чтобы активировать отслеживание событий; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06000067 RID: 103 RVA: 0x00002307 File Offset: 0x00000507
		public EventTrackingEnabledAttribute(bool val)
		{
			this.val = val;
		}

		/// <summary>Возвращает значение свойства <see cref="P:System.EnterpriseServices.EventTrackingEnabledAttribute.Value" />, указывающее, включено ли отслеживание событий.</summary>
		/// <returns>Значение <see langword="true" />, если отслеживание включено; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002316 File Offset: 0x00000516
		public bool Value
		{
			get
			{
				return this.val;
			}
		}

		// Token: 0x04000053 RID: 83
		private bool val;
	}
}
