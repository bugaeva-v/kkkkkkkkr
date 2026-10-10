using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Идентифицирует сборку как ссылочную сборку, которая содержит метаданные, но не исполняемый код.</summary>
	// Token: 0x02000800 RID: 2048
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	[Serializable]
	public sealed class ReferenceAssemblyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.ReferenceAssemblyAttribute" />.</summary>
		// Token: 0x06004611 RID: 17937 RVA: 0x00002050 File Offset: 0x00000250
		public ReferenceAssemblyAttribute()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.ReferenceAssemblyAttribute" />, используя заданное описание.</summary>
		/// <param name="description">Описание сборки, на которую сделана ссылка.</param>
		// Token: 0x06004612 RID: 17938 RVA: 0x000E5846 File Offset: 0x000E3A46
		public ReferenceAssemblyAttribute(string description)
		{
			this.Description = description;
		}

		/// <summary>Получает описание сборки, на которую сделана ссылка.</summary>
		/// <returns>Описание сборки, на которую сделана ссылка.</returns>
		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06004613 RID: 17939 RVA: 0x000E5855 File Offset: 0x000E3A55
		public string Description { get; }
	}
}
