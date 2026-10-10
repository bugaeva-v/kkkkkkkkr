using System;

namespace System.Reflection
{
	/// <summary>Представляет контекст, который может предоставлять объекты отражения.</summary>
	// Token: 0x020008BD RID: 2237
	public abstract class ReflectionContext
	{
		/// <summary>Возвращает представление сборки в данном контексте отражения в виде объекта из другого контекста отражения.</summary>
		/// <param name="assembly">Внешнее представление сборки, которую следует представить в этом контексте.</param>
		/// <returns>Представление сборки в этом контексте отражения.</returns>
		// Token: 0x06004A09 RID: 18953
		public abstract Assembly MapAssembly(Assembly assembly);

		/// <summary>Возвращает представление типа в этом контексте отражения, представленного объектом из другого контекста отражения.</summary>
		/// <param name="type">Внешнее представление типа, который следует представить в этом контексте.</param>
		/// <returns>Представление типа в этом контексте отражения.</returns>
		// Token: 0x06004A0A RID: 18954
		public abstract TypeInfo MapType(TypeInfo type);

		/// <summary>Получает представление типа указанного объекта в данном контексте отражения.</summary>
		/// <param name="value">Объект для представления.</param>
		/// <returns>Объект, представляющий тип указанного объекта.</returns>
		// Token: 0x06004A0B RID: 18955 RVA: 0x000EF53C File Offset: 0x000ED73C
		public virtual TypeInfo GetTypeForObject(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return this.MapType(value.GetType().GetTypeInfo());
		}
	}
}
