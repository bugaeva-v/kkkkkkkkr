using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Представляет атрибут элемента панели инструментов.</summary>
	// Token: 0x020003A2 RID: 930
	[AttributeUsage(AttributeTargets.All)]
	public class ToolboxItemAttribute : Attribute
	{
		/// <summary>Возвращает значение, показывающее, является ли текущее значение атрибута его значением по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если текущим значением атрибута является значение по умолчанию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001E64 RID: 7780 RVA: 0x0006BF71 File Offset: 0x0006A171
		public override bool IsDefaultAttribute()
		{
			return this.Equals(ToolboxItemAttribute.Default);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> и указывает, следует ли использовать заданные по умолчанию значения для инициализации.</summary>
		/// <param name="defaultType">Значение <see langword="true" />, чтобы создать атрибут панели инструментов для типа по умолчанию, значение <see langword="false" />, чтобы не связывать с этим атрибутом поддержку элементов панели инструментов, установленных по умолчанию.</param>
		// Token: 0x06001E65 RID: 7781 RVA: 0x0006BF7E File Offset: 0x0006A17E
		public ToolboxItemAttribute(bool defaultType)
		{
			if (defaultType)
			{
				this._toolboxItemTypeName = "System.Drawing.Design.ToolboxItem, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ToolboxItemAttribute" />, используя заданное имя типа.</summary>
		/// <param name="toolboxItemTypeName">Имена типа элемента панели управления и сборки, содержащей данный тип.</param>
		// Token: 0x06001E66 RID: 7782 RVA: 0x0006BF94 File Offset: 0x0006A194
		public ToolboxItemAttribute(string toolboxItemTypeName)
		{
			toolboxItemTypeName.ToUpper(CultureInfo.InvariantCulture);
			this._toolboxItemTypeName = toolboxItemTypeName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ToolboxItemAttribute" />, используя заданный тип элемента панели инструментов.</summary>
		/// <param name="toolboxItemType">Тип элемента панели инструментов.</param>
		// Token: 0x06001E67 RID: 7783 RVA: 0x0006BFAF File Offset: 0x0006A1AF
		public ToolboxItemAttribute(Type toolboxItemType)
		{
			this._toolboxItemType = toolboxItemType;
			this._toolboxItemTypeName = toolboxItemType.AssemblyQualifiedName;
		}

		/// <summary>Получает или задает тип элемента панели инструментов.</summary>
		/// <returns>Тип элемента панели инструментов.</returns>
		/// <exception cref="T:System.ArgumentException">Тип найти не удалось.</exception>
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0006BFCC File Offset: 0x0006A1CC
		public Type ToolboxItemType
		{
			get
			{
				if (this._toolboxItemType == null && this._toolboxItemTypeName != null)
				{
					try
					{
						this._toolboxItemType = Type.GetType(this._toolboxItemTypeName, true);
					}
					catch (Exception innerException)
					{
						throw new ArgumentException(SR.Format("Failed to create ToolboxItem of type: {0}", this._toolboxItemTypeName), innerException);
					}
				}
				return this._toolboxItemType;
			}
		}

		/// <summary>Получает или задает имя типа текущего элемента <see cref="T:System.Drawing.Design.ToolboxItem" /> .</summary>
		/// <returns>Полное имя типа текущего элемента панели инструментов.</returns>
		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x0006C034 File Offset: 0x0006A234
		public string ToolboxItemTypeName
		{
			get
			{
				if (this._toolboxItemTypeName == null)
				{
					return string.Empty;
				}
				return this._toolboxItemTypeName;
			}
		}

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для сравнения с этим экземпляром или пустая ссылка (<see langword="Nothing" /> в Visual Basic).</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> равно типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001E6A RID: 7786 RVA: 0x0006C04C File Offset: 0x0006A24C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			ToolboxItemAttribute toolboxItemAttribute = obj as ToolboxItemAttribute;
			return toolboxItemAttribute != null && toolboxItemAttribute.ToolboxItemTypeName == this.ToolboxItemTypeName;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001E6B RID: 7787 RVA: 0x0006C07C File Offset: 0x0006A27C
		public override int GetHashCode()
		{
			if (this._toolboxItemTypeName != null)
			{
				return this._toolboxItemTypeName.GetHashCode();
			}
			return base.GetHashCode();
		}

		// Token: 0x04000F2E RID: 3886
		private Type _toolboxItemType;

		// Token: 0x04000F2F RID: 3887
		private string _toolboxItemTypeName;

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> и устанавливает для типа значение по умолчанию <see cref="T:System.Drawing.Design.ToolboxItem" />. Это поле доступно только для чтения.</summary>
		// Token: 0x04000F30 RID: 3888
		public static readonly ToolboxItemAttribute Default = new ToolboxItemAttribute("System.Drawing.Design.ToolboxItem, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> и устанавливает тип в <see langword="null" />. Это поле доступно только для чтения.</summary>
		// Token: 0x04000F31 RID: 3889
		public static readonly ToolboxItemAttribute None = new ToolboxItemAttribute(false);
	}
}
