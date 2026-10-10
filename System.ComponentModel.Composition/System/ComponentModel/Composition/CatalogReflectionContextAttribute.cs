using System;
using System.Reflection;
using Microsoft.Internal;

namespace System.ComponentModel.Composition
{
	/// <summary>При применении к объекту <see cref="T:System.Reflection.Assembly" /> позволяет объекту <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" /> обнаруживать пользовательские объекты <see cref="T:System.Reflection.ReflectionContext" />.</summary>
	// Token: 0x02000022 RID: 34
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = true)]
	public class CatalogReflectionContextAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.AssemblyCatalog" /> с указанным типом <see cref="T:System.Reflection.ReflectionContext" />.</summary>
		/// <param name="reflectionContextType">Тип контекста отражения.</param>
		// Token: 0x0600012A RID: 298 RVA: 0x00004300 File Offset: 0x00002500
		public CatalogReflectionContextAttribute(Type reflectionContextType)
		{
			Requires.NotNull<Type>(reflectionContextType, "reflectionContextType");
			this._reflectionContextType = reflectionContextType;
		}

		/// <summary>Создает экземпляр пользовательского объекта <see cref="T:System.Reflection.ReflectionContext" />.</summary>
		/// <returns>Экземпляр пользовательского контекста отражения.</returns>
		// Token: 0x0600012B RID: 299 RVA: 0x0000431C File Offset: 0x0000251C
		public ReflectionContext CreateReflectionContext()
		{
			Assumes.NotNull<Type>(this._reflectionContextType);
			ReflectionContext result = null;
			try
			{
				result = (ReflectionContext)Activator.CreateInstance(this._reflectionContextType);
			}
			catch (InvalidCastException innerException)
			{
				throw new InvalidOperationException(Strings.ReflectionContext_Type_Required, innerException);
			}
			catch (MissingMethodException inner)
			{
				throw new MissingMethodException(Strings.ReflectionContext_Requires_DefaultConstructor, inner);
			}
			return result;
		}

		// Token: 0x0400006B RID: 107
		private Type _reflectionContextType;
	}
}
