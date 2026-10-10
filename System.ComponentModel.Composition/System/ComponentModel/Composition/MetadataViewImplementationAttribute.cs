using System;

namespace System.ComponentModel.Composition
{
	/// <summary>Определяет тип, используемый для реализации представления метаданных.</summary>
	// Token: 0x0200004E RID: 78
	[AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class MetadataViewImplementationAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.MetadataViewImplementationAttribute" />.</summary>
		/// <param name="implementationType">Тип представления метаданных.</param>
		// Token: 0x0600021B RID: 539 RVA: 0x000066CC File Offset: 0x000048CC
		public MetadataViewImplementationAttribute(Type implementationType)
		{
			this.ImplementationType = implementationType;
		}

		/// <summary>Получает тип представления метаданных.</summary>
		/// <returns>Тип представления метаданных.</returns>
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000066DB File Offset: 0x000048DB
		// (set) Token: 0x0600021D RID: 541 RVA: 0x000066E3 File Offset: 0x000048E3
		public Type ImplementationType { get; private set; }
	}
}
