using System;

namespace System.ComponentModel.Composition
{
	/// <summary>Задает свойство <see cref="P:System.ComponentModel.Composition.PartCreationPolicyAttribute.CreationPolicy" /> для части.</summary>
	// Token: 0x02000050 RID: 80
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class PartCreationPolicyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.PartCreationPolicyAttribute" /> с использованием указанной политики создания.</summary>
		/// <param name="creationPolicy">Используемая политика создания.</param>
		// Token: 0x06000220 RID: 544 RVA: 0x000069AB File Offset: 0x00004BAB
		public PartCreationPolicyAttribute(CreationPolicy creationPolicy)
		{
			this.CreationPolicy = creationPolicy;
		}

		/// <summary>Получает или задает значение, указывающее политику создания помеченной атрибутами части.</summary>
		/// <returns>Одно из значений <see cref="P:System.ComponentModel.Composition.PartCreationPolicyAttribute.CreationPolicy" />, указывающее политику создания помеченной атрибутами части. Значение по умолчанию — <see cref="F:System.ComponentModel.Composition.CreationPolicy.Any" />.</returns>
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000221 RID: 545 RVA: 0x000069BA File Offset: 0x00004BBA
		// (set) Token: 0x06000222 RID: 546 RVA: 0x000069C2 File Offset: 0x00004BC2
		public CreationPolicy CreationPolicy { get; private set; }

		// Token: 0x040000E3 RID: 227
		internal static PartCreationPolicyAttribute Default = new PartCreationPolicyAttribute(CreationPolicy.Any);

		// Token: 0x040000E4 RID: 228
		internal static PartCreationPolicyAttribute Shared = new PartCreationPolicyAttribute(CreationPolicy.Shared);
	}
}
