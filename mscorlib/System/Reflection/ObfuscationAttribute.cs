using System;

namespace System.Reflection
{
	/// <summary>Указывает средствам запутывания, что следует предпринять заданные действия для сборки, типа или члена.</summary>
	// Token: 0x020008B4 RID: 2228
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
	public sealed class ObfuscationAttribute : Attribute
	{
		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, указывающее, должно и средство запутывания удалить данный атрибут по окончании его обработки.</summary>
		/// <returns>Значение <see langword="true" />, если средство запутывания должно удалять атрибут после обработки; в обратном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060049B7 RID: 18871 RVA: 0x000EF1DB File Offset: 0x000ED3DB
		// (set) Token: 0x060049B8 RID: 18872 RVA: 0x000EF1E3 File Offset: 0x000ED3E3
		public bool StripAfterObfuscation { get; set; } = true;

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, указывающее, должно ли средство запутывания исключить тип или член из операции запутывания.</summary>
		/// <returns>Значение <see langword="true" />, если тип или член, к которому применяется этот атрибут, должен быть исключен из операции запутывания; в обратном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060049B9 RID: 18873 RVA: 0x000EF1EC File Offset: 0x000ED3EC
		// (set) Token: 0x060049BA RID: 18874 RVA: 0x000EF1F4 File Offset: 0x000ED3F4
		public bool Exclude { get; set; } = true;

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, которое указывает, должен ли атрибут определенного типа быть применен к членам этого типа.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут должен применяться к членам соответствующего типа; в обратном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060049BB RID: 18875 RVA: 0x000EF1FD File Offset: 0x000ED3FD
		// (set) Token: 0x060049BC RID: 18876 RVA: 0x000EF205 File Offset: 0x000ED405
		public bool ApplyToMembers { get; set; } = true;

		/// <summary>Возвращает или задает строковое значение, которое распознается средством запутывания и определяет параметры обработки.</summary>
		/// <returns>Строковое значение, которое распознается средством запутывания и определяет параметры обработки. По умолчанию установлено значение "all".</returns>
		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060049BD RID: 18877 RVA: 0x000EF20E File Offset: 0x000ED40E
		// (set) Token: 0x060049BE RID: 18878 RVA: 0x000EF216 File Offset: 0x000ED416
		public string Feature { get; set; } = "all";
	}
}
