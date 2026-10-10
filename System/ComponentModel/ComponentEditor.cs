using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет базовый класс для редактора настраиваемых компонентов.</summary>
	// Token: 0x02000380 RID: 896
	public abstract class ComponentEditor
	{
		/// <summary>Редактирует компонент и возвращает значение, по которому можно определить, был ли изменен данный компонент.</summary>
		/// <param name="component">Редактируемый компонент.</param>
		/// <returns>Значение <see langword="true" />, если компонент был изменен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D74 RID: 7540 RVA: 0x00068F9F File Offset: 0x0006719F
		public bool EditComponent(object component)
		{
			return this.EditComponent(null, component);
		}

		/// <summary>Редактирует компонент и возвращает значение, по которому можно определить, был ли изменен данный компонент на основе заданного контекста.</summary>
		/// <param name="context">Необязательный объект контекста, с помощью которого можно получить дополнительные сведения о редактировании.</param>
		/// <param name="component">Редактируемый компонент.</param>
		/// <returns>Значение <see langword="true" />, если компонент был изменен, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D75 RID: 7541
		public abstract bool EditComponent(ITypeDescriptorContext context, object component);
	}
}
