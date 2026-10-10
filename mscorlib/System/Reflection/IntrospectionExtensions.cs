using System;

namespace System.Reflection
{
	/// <summary>Содержит методы для преобразования объектов <see cref="T:System.Type" />.</summary>
	// Token: 0x020008A6 RID: 2214
	public static class IntrospectionExtensions
	{
		/// <summary>Возвращает представление <see cref="T:System.Reflection.TypeInfo" /> указанного типа.</summary>
		/// <param name="type">Тип, преобразование которого выполняется.</param>
		/// <returns>Преобразованный объект.</returns>
		// Token: 0x06004903 RID: 18691 RVA: 0x000EE8CC File Offset: 0x000ECACC
		public static TypeInfo GetTypeInfo(this Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			IReflectableType reflectableType = type as IReflectableType;
			if (reflectableType != null)
			{
				return reflectableType.GetTypeInfo();
			}
			return new TypeDelegator(type);
		}
	}
}
