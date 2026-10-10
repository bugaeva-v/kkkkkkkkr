using System;

namespace System.Runtime.Versioning
{
	/// <summary>Определяет гарантированную совместимость компонента, типа или члена типа с одной или несколькими версиями.</summary>
	// Token: 0x0200063D RID: 1597
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	public sealed class ComponentGuaranteesAttribute : Attribute
	{
		/// <summary>Получает значение, указывающее гарантированный уровень совместимости библиотеки, типа или члена типа с несколькими версиями.</summary>
		/// <returns>Одно из значений перечисления, задающее гарантированный уровень совместимости с несколькими версиями.</returns>
		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06003C29 RID: 15401 RVA: 0x000D1167 File Offset: 0x000CF367
		public ComponentGuaranteesOptions Guarantees { get; }

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Versioning.ComponentGuaranteesAttribute" /> со значением, указывающим библиотеку, тип или гарантированный уровень совместимости члена с несколькими версиями.</summary>
		/// <param name="guarantees">Одно из значений перечисления, задающее гарантированный уровень совместимости с несколькими версиями.</param>
		// Token: 0x06003C2A RID: 15402 RVA: 0x000D116F File Offset: 0x000CF36F
		public ComponentGuaranteesAttribute(ComponentGuaranteesOptions guarantees)
		{
			this.Guarantees = guarantees;
		}
	}
}
