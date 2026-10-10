using System;

namespace System.ComponentModel
{
	/// <summary>Создает экземпляр конкретного типа свойства и раскрывающегося поля в таблице свойств <see cref="T:System.Windows.Forms.PropertyGrid" />.</summary>
	// Token: 0x020003BF RID: 959
	public abstract class InstanceCreationEditor
	{
		/// <summary>Возвращает заданный текст.</summary>
		/// <returns>Заданный текст.</returns>
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x0006CD0C File Offset: 0x0006AF0C
		public virtual string Text
		{
			get
			{
				return "(New...)";
			}
		}

		/// <summary>Если экземпляр службы переопределен в производном классе, возвращает экземпляр заданного типа.</summary>
		/// <param name="context">Сведения о контексте.</param>
		/// <param name="instanceType">Заданный тип.</param>
		/// <returns>Экземпляр заданного типа или <see langword="null" />.</returns>
		// Token: 0x06001F2A RID: 7978
		public abstract object CreateInstance(ITypeDescriptorContext context, Type instanceType);
	}
}
