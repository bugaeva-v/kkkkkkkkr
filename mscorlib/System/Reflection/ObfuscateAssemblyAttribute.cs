using System;

namespace System.Reflection
{
	/// <summary>Указывает средствам запутывания, что следует использовать подходящие правила запутывания для соответствующего типа сборки.</summary>
	// Token: 0x020008B3 RID: 2227
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public sealed class ObfuscateAssemblyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.ObfuscateAssemblyAttribute" />, определяя, должна ли быть подлежащая запутыванию сборка открытой или закрытой.</summary>
		/// <param name="assemblyIsPrivate">Значение <see langword="true" />, если сборка используется в области одного приложения; в обратном случае — значение <see langword="false" />.</param>
		// Token: 0x060049B2 RID: 18866 RVA: 0x000EF184 File Offset: 0x000ED384
		public ObfuscateAssemblyAttribute(bool assemblyIsPrivate)
		{
			this.AssemblyIsPrivate = assemblyIsPrivate;
		}

		/// <summary>Возвращает значение <see cref="T:System.Boolean" />, указывающее, отмечена ли данная сборка как закрытая.</summary>
		/// <returns>Значение <see langword="true" />, если сборка отмечена как закрытая; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060049B3 RID: 18867 RVA: 0x000EF19A File Offset: 0x000ED39A
		public bool AssemblyIsPrivate { get; }

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, указывающее, должно ли средство запутывания удалить данный атрибут по окончании его обработки.</summary>
		/// <returns>Значение <see langword="true" />, если средство запутывания должно удалять атрибут после обработки; в обратном случае — значение <see langword="false" />. Значение по умолчанию для этого свойства — <see langword="true" />.</returns>
		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060049B4 RID: 18868 RVA: 0x000EF1A2 File Offset: 0x000ED3A2
		// (set) Token: 0x060049B5 RID: 18869 RVA: 0x000EF1AA File Offset: 0x000ED3AA
		public bool StripAfterObfuscation { get; set; } = true;
	}
}
