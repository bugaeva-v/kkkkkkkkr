using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает идентификатор компонентного класса, импортированного из библиотеки типов.</summary>
	// Token: 0x0200070C RID: 1804
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
	public sealed class CoClassAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.CoClassAttribute" />, используя идентификатор исходного компонентного класса.</summary>
		/// <param name="coClass">
		///   <see cref="T:System.Type" />, содержащий идентификатор исходного компонентного класса.</param>
		// Token: 0x060040B4 RID: 16564 RVA: 0x000E1578 File Offset: 0x000DF778
		public CoClassAttribute(Type coClass)
		{
			this._CoClass = coClass;
		}

		/// <summary>Возвращает идентификатор исходного компонентного класса.</summary>
		/// <returns>
		///   <see cref="T:System.Type" />, содержащий идентификатор исходного совместного класса.</returns>
		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x060040B5 RID: 16565 RVA: 0x000E1587 File Offset: 0x000DF787
		public Type CoClass
		{
			get
			{
				return this._CoClass;
			}
		}

		// Token: 0x04002AE4 RID: 10980
		internal Type _CoClass;
	}
}
