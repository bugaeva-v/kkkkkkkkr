using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Задает дополнительную информацию схемы для события.</summary>
	// Token: 0x020009EC RID: 2540
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class EventAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Tracing.EventAttribute" /> с указанным идентификатором события.</summary>
		/// <param name="eventId">Идентификатор события для события.</param>
		// Token: 0x06005A9F RID: 23199 RVA: 0x0013439B File Offset: 0x0013259B
		public EventAttribute(int eventId)
		{
			this.EventId = eventId;
		}

		/// <summary>Возвращает или задает идентификатор события.</summary>
		/// <returns>Идентификатор события. Это значение должно находиться в диапазоне от 0 до 65535.</returns>
		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06005AA0 RID: 23200 RVA: 0x001343AA File Offset: 0x001325AA
		// (set) Token: 0x06005AA1 RID: 23201 RVA: 0x001343B2 File Offset: 0x001325B2
		public int EventId { get; private set; }

		/// <summary>Задает поведение событий запуска и остановки действия. Действие — это область времени между запуском и остановкой приложения.</summary>
		/// <returns>Возвращает <see cref="T:System.Diagnostics.Tracing.EventActivityOptions" />.</returns>
		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06005AA2 RID: 23202 RVA: 0x001343BB File Offset: 0x001325BB
		// (set) Token: 0x06005AA3 RID: 23203 RVA: 0x001343C3 File Offset: 0x001325C3
		public EventActivityOptions ActivityOptions { get; set; }

		/// <summary>Возвращает или задает уровень для события.</summary>
		/// <returns>Одно из значений перечисления, определяющее уровень события.</returns>
		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06005AA4 RID: 23204 RVA: 0x001343CC File Offset: 0x001325CC
		// (set) Token: 0x06005AA5 RID: 23205 RVA: 0x001343D4 File Offset: 0x001325D4
		public EventLevel Level { get; set; }

		/// <summary>Возвращает или задает ключевые слова для события.</summary>
		/// <returns>Побитовое сочетание значений перечисления.</returns>
		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06005AA6 RID: 23206 RVA: 0x001343DD File Offset: 0x001325DD
		// (set) Token: 0x06005AA7 RID: 23207 RVA: 0x001343E5 File Offset: 0x001325E5
		public EventKeywords Keywords { get; set; }

		/// <summary>Возвращает или задает код операции для события.</summary>
		/// <returns>Одно из значений перечисления, определяющее код операции.</returns>
		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06005AA8 RID: 23208 RVA: 0x001343EE File Offset: 0x001325EE
		// (set) Token: 0x06005AA9 RID: 23209 RVA: 0x001343F6 File Offset: 0x001325F6
		public EventOpcode Opcode { get; set; }

		/// <summary>Возвращает или задает дополнительный журнал событий, в который должно быть записано событие.</summary>
		/// <returns>Дополнительный журнал событий, в который должно быть записано событие.</returns>
		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06005AAA RID: 23210 RVA: 0x001343FF File Offset: 0x001325FF
		// (set) Token: 0x06005AAB RID: 23211 RVA: 0x00134407 File Offset: 0x00132607
		public EventChannel Channel { get; set; }

		/// <summary>Возвращает или задает сообщение для события.</summary>
		/// <returns>Сообщение для события.</returns>
		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06005AAC RID: 23212 RVA: 0x00134410 File Offset: 0x00132610
		// (set) Token: 0x06005AAD RID: 23213 RVA: 0x00134418 File Offset: 0x00132618
		public string Message { get; set; }

		/// <summary>Возвращает или задает задачу для события.</summary>
		/// <returns>Задача для события.</returns>
		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06005AAE RID: 23214 RVA: 0x00134421 File Offset: 0x00132621
		// (set) Token: 0x06005AAF RID: 23215 RVA: 0x00134429 File Offset: 0x00132629
		public EventTask Task { get; set; }

		/// <summary>Получает или задает значение <see cref="T:System.Diagnostics.Tracing.EventTags" /> для этого объекта <see cref="T:System.Diagnostics.Tracing.EventAttribute" />. Тег события является определяемым пользователем значением, которое передается при регистрации события в журнале.</summary>
		/// <returns>
		///   <see cref="T:System.Diagnostics.Tracing.EventTags" /> Значение для данного <see cref="T:System.Diagnostics.Tracing.EventAttribute" /> объекта. Тег события является определяемым пользователем значением, которое передается при регистрации события в журнале.</returns>
		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06005AB0 RID: 23216 RVA: 0x00134432 File Offset: 0x00132632
		// (set) Token: 0x06005AB1 RID: 23217 RVA: 0x0013443A File Offset: 0x0013263A
		public EventTags Tags { get; set; }

		/// <summary>Возвращает или задает версию события.</summary>
		/// <returns>Версия события.</returns>
		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06005AB2 RID: 23218 RVA: 0x00134443 File Offset: 0x00132643
		// (set) Token: 0x06005AB3 RID: 23219 RVA: 0x0013444B File Offset: 0x0013264B
		public byte Version { get; set; }
	}
}
