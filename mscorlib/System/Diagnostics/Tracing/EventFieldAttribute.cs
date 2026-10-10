using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Атрибут <see cref="T:System.Diagnostics.Tracing.EventFieldAttribute" /> помещается в полях типов, определяемых пользователем, которые передаются в качестве полезных данных <see cref="T:System.Diagnostics.Tracing.EventSource" />.</summary>
	// Token: 0x020009F1 RID: 2545
	[AttributeUsage(AttributeTargets.Property)]
	public class EventFieldAttribute : Attribute
	{
		/// <summary>Получает или задает значение, определяющее способ форматирования значения определяемого пользователем типа.</summary>
		/// <returns>Значение, определяющее способ форматирования значения определяемого пользователем типа.</returns>
		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06005ABF RID: 23231 RVA: 0x000479F8 File Offset: 0x00045BF8
		// (set) Token: 0x06005AC0 RID: 23232 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public EventFieldFormat Format
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает определяемое пользователем значение <see cref="T:System.Diagnostics.Tracing.EventFieldTags" />, которое требуется для полей, содержащих данные неподдерживаемых типов.</summary>
		/// <returns>Возвращает <see cref="T:System.Diagnostics.Tracing.EventFieldTags" />.</returns>
		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06005AC1 RID: 23233 RVA: 0x000479F8 File Offset: 0x00045BF8
		// (set) Token: 0x06005AC2 RID: 23234 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public EventFieldTags Tags
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
