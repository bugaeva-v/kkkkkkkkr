using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, что список может использоваться в качестве источника данных. Визуальный конструктор должен использовать этот атрибут, чтобы определить, отображается ли конкретный список в сборщике привязки данных. Этот класс не наследуется.</summary>
	// Token: 0x020003CC RID: 972
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ListBindableAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ListBindableAttribute" />, используя значение, показывающее, поддерживает ли этот список возможности привязки.</summary>
		/// <param name="listBindable">Значение <see langword="true" />, если список поддерживает возможности привязки; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001F6C RID: 8044 RVA: 0x0006D4BE File Offset: 0x0006B6BE
		public ListBindableAttribute(bool listBindable)
		{
			this.ListBindable = listBindable;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ListBindableAttribute" />, используя объект <see cref="T:System.ComponentModel.BindableSupport" />, показывающий, поддерживает ли список возможности привязки.</summary>
		/// <param name="flags">Объект <see cref="T:System.ComponentModel.BindableSupport" />, показывающий, поддерживает ли список возможности привязки.</param>
		// Token: 0x06001F6D RID: 8045 RVA: 0x0006D4CD File Offset: 0x0006B6CD
		public ListBindableAttribute(BindableSupport flags)
		{
			this.ListBindable = (flags > BindableSupport.No);
			this._isDefault = (flags == BindableSupport.Default);
		}

		/// <summary>Возвращает значение, показывающее, поддерживает ли список возможности привязки.</summary>
		/// <returns>Значение <see langword="true" />, если список поддерживает возможности привязки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x0006D4E9 File Offset: 0x0006B6E9
		public bool ListBindable { get; }

		/// <summary>Возвращает значение, показывающее, равен ли переданный объект этому атрибуту <see cref="T:System.ComponentModel.ListBindableAttribute" />.</summary>
		/// <param name="obj">Объект для проверки на равенство.</param>
		/// <returns>Значение <see langword="true" />, если переданный объект равен этому объекту <see cref="T:System.ComponentModel.ListBindableAttribute" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001F6F RID: 8047 RVA: 0x0006D4F4 File Offset: 0x0006B6F4
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			ListBindableAttribute listBindableAttribute = obj as ListBindableAttribute;
			return listBindableAttribute != null && listBindableAttribute.ListBindable == this.ListBindable;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.ListBindableAttribute" />.</returns>
		// Token: 0x06001F70 RID: 8048 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Возвращает значение, показывающее, установлено ли для свойства <see cref="P:System.ComponentModel.ListBindableAttribute.ListBindable" /> значение по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.ComponentModel.ListBindableAttribute.ListBindable" /> установлено равным значению по умолчанию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001F71 RID: 8049 RVA: 0x0006D521 File Offset: 0x0006B721
		public override bool IsDefaultAttribute()
		{
			return this.Equals(ListBindableAttribute.Default) || this._isDefault;
		}

		/// <summary>Определяет, что список не поддерживает возможности привязки. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000F59 RID: 3929
		public static readonly ListBindableAttribute Yes = new ListBindableAttribute(true);

		/// <summary>Определяет, что список не поддерживает возможности привязки. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000F5A RID: 3930
		public static readonly ListBindableAttribute No = new ListBindableAttribute(false);

		/// <summary>Представляет значение по умолчанию для объекта <see cref="T:System.ComponentModel.ListBindableAttribute" />.</summary>
		// Token: 0x04000F5B RID: 3931
		public static readonly ListBindableAttribute Default = ListBindableAttribute.Yes;

		// Token: 0x04000F5C RID: 3932
		private bool _isDefault;
	}
}
