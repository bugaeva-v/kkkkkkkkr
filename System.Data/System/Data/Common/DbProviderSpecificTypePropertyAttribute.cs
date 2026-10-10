using System;

namespace System.Data.Common
{
	/// <summary>Указывает, какое зависящее от поставщика свойство в строго типизированных классах параметров должно использоваться при настройке типа, зависящего от поставщика.</summary>
	// Token: 0x0200039E RID: 926
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	[Serializable]
	public sealed class DbProviderSpecificTypePropertyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Common.DbProviderSpecificTypePropertyAttribute" />.</summary>
		/// <param name="isProviderSpecificTypeProperty">Указывает, является ли это свойство свойством, зависящим от поставщика.</param>
		// Token: 0x06002D01 RID: 11521 RVA: 0x000BEFC8 File Offset: 0x000BD1C8
		public DbProviderSpecificTypePropertyAttribute(bool isProviderSpecificTypeProperty)
		{
			this.IsProviderSpecificTypeProperty = isProviderSpecificTypeProperty;
		}

		/// <summary>Указывает, имеет ли это атрибутивное свойство тип, зависящий от поставщика.</summary>
		/// <returns>Значение <see langword="true" />, если свойство, к которому применяется этот атрибут, является свойством типа, зависящего от поставщика; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x000BEFD7 File Offset: 0x000BD1D7
		public bool IsProviderSpecificTypeProperty { get; }
	}
}
