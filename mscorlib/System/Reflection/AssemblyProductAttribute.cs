using System;

namespace System.Reflection
{
	/// <summary>Определяет настраиваемый атрибут имени продукта для манифеста сборки.</summary>
	// Token: 0x0200088D RID: 2189
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyProductAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyProductAttribute" />.</summary>
		/// <param name="product">Сведения об имени продукта.</param>
		// Token: 0x0600486F RID: 18543 RVA: 0x000EE14C File Offset: 0x000EC34C
		public AssemblyProductAttribute(string product)
		{
			this.Product = product;
		}

		/// <summary>Возвращает сведения об имени продукта.</summary>
		/// <returns>Строка, содержащая имя продукта.</returns>
		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x000EE15B File Offset: 0x000EC35B
		public string Product { get; }
	}
}
