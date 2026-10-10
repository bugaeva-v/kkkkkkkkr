using System;

namespace System.ComponentModel
{
	/// <summary>Задает имя категории, в которой при отображении в элементе управления <see cref="T:System.Windows.Forms.PropertyGrid" /> для группировки свойств или событий установлен режим "По категориям".</summary>
	// Token: 0x0200040A RID: 1034
	[AttributeUsage(AttributeTargets.All)]
	public class CategoryAttribute : Attribute
	{
		/// <summary>Возвращает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "Действие".</summary>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "Действие".</returns>
		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x0007228E File Offset: 0x0007048E
		public static CategoryAttribute Action
		{
			get
			{
				if (CategoryAttribute.action == null)
				{
					CategoryAttribute.action = new CategoryAttribute("Action");
				}
				return CategoryAttribute.action;
			}
		}

		/// <summary>Возвращает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "Внешний вид".</summary>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "Внешний вид".</returns>
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x000722B1 File Offset: 0x000704B1
		public static CategoryAttribute Appearance
		{
			get
			{
				if (CategoryAttribute.appearance == null)
				{
					CategoryAttribute.appearance = new CategoryAttribute("Appearance");
				}
				return CategoryAttribute.appearance;
			}
		}

		/// <summary>Возвращает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "Асинхронная".</summary>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "Асинхронная".</returns>
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x000722D4 File Offset: 0x000704D4
		public static CategoryAttribute Asynchronous
		{
			get
			{
				if (CategoryAttribute.asynchronous == null)
				{
					CategoryAttribute.asynchronous = new CategoryAttribute("Asynchronous");
				}
				return CategoryAttribute.asynchronous;
			}
		}

		/// <summary>Возвращает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "Поведение".</summary>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "Поведение".</returns>
		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x000722F7 File Offset: 0x000704F7
		public static CategoryAttribute Behavior
		{
			get
			{
				if (CategoryAttribute.behavior == null)
				{
					CategoryAttribute.behavior = new CategoryAttribute("Behavior");
				}
				return CategoryAttribute.behavior;
			}
		}

		/// <summary>Возвращает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "Данные".</summary>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "Данные".</returns>
		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x0007231A File Offset: 0x0007051A
		public static CategoryAttribute Data
		{
			get
			{
				if (CategoryAttribute.data == null)
				{
					CategoryAttribute.data = new CategoryAttribute("Data");
				}
				return CategoryAttribute.data;
			}
		}

		/// <summary>Возвращает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "По умолчанию".</summary>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "По умолчанию".</returns>
		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x0007233D File Offset: 0x0007053D
		public static CategoryAttribute Default
		{
			get
			{
				if (CategoryAttribute.defAttr == null)
				{
					CategoryAttribute.defAttr = new CategoryAttribute();
				}
				return CategoryAttribute.defAttr;
			}
		}

		/// <summary>Возвращает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "Конструктор".</summary>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "Конструктор".</returns>
		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x0007235B File Offset: 0x0007055B
		public static CategoryAttribute Design
		{
			get
			{
				if (CategoryAttribute.design == null)
				{
					CategoryAttribute.design = new CategoryAttribute("Design");
				}
				return CategoryAttribute.design;
			}
		}

		/// <summary>Возвращает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "Перетаскивание".</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "Перетаскивание".</returns>
		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x0007237E File Offset: 0x0007057E
		public static CategoryAttribute DragDrop
		{
			get
			{
				if (CategoryAttribute.dragDrop == null)
				{
					CategoryAttribute.dragDrop = new CategoryAttribute("DragDrop");
				}
				return CategoryAttribute.dragDrop;
			}
		}

		/// <summary>Получает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "Фокус".</summary>
		/// <returns>Атрибут <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "Фокус".</returns>
		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x000723A1 File Offset: 0x000705A1
		public static CategoryAttribute Focus
		{
			get
			{
				if (CategoryAttribute.focus == null)
				{
					CategoryAttribute.focus = new CategoryAttribute("Focus");
				}
				return CategoryAttribute.focus;
			}
		}

		/// <summary>Возвращает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "Формат".</summary>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "Формат".</returns>
		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x000723C4 File Offset: 0x000705C4
		public static CategoryAttribute Format
		{
			get
			{
				if (CategoryAttribute.format == null)
				{
					CategoryAttribute.format = new CategoryAttribute("Format");
				}
				return CategoryAttribute.format;
			}
		}

		/// <summary>Получает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "Клавиша".</summary>
		/// <returns>Атрибут <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "Клавиша".</returns>
		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x000723E7 File Offset: 0x000705E7
		public static CategoryAttribute Key
		{
			get
			{
				if (CategoryAttribute.key == null)
				{
					CategoryAttribute.key = new CategoryAttribute("Key");
				}
				return CategoryAttribute.key;
			}
		}

		/// <summary>Возвращает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "Структура".</summary>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "Структура".</returns>
		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x0007240A File Offset: 0x0007060A
		public static CategoryAttribute Layout
		{
			get
			{
				if (CategoryAttribute.layout == null)
				{
					CategoryAttribute.layout = new CategoryAttribute("Layout");
				}
				return CategoryAttribute.layout;
			}
		}

		/// <summary>Возвращает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "Мышь".</summary>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "Мышь".</returns>
		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x0007242D File Offset: 0x0007062D
		public static CategoryAttribute Mouse
		{
			get
			{
				if (CategoryAttribute.mouse == null)
				{
					CategoryAttribute.mouse = new CategoryAttribute("Mouse");
				}
				return CategoryAttribute.mouse;
			}
		}

		/// <summary>Возвращает атрибут <see cref="T:System.ComponentModel.CategoryAttribute" />, представляющий категорию "Стиль окна".</summary>
		/// <returns>Экземпляр класса <see cref="T:System.ComponentModel.CategoryAttribute" /> для категории "Стиль окна".</returns>
		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x00072450 File Offset: 0x00070650
		public static CategoryAttribute WindowStyle
		{
			get
			{
				if (CategoryAttribute.windowStyle == null)
				{
					CategoryAttribute.windowStyle = new CategoryAttribute("WindowStyle");
				}
				return CategoryAttribute.windowStyle;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.CategoryAttribute" /> с использованием имени категории "По умолчанию".</summary>
		// Token: 0x06002171 RID: 8561 RVA: 0x00072473 File Offset: 0x00070673
		public CategoryAttribute() : this("Default")
		{
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.ComponentModel.CategoryAttribute" />, используя заданное имя категории.</summary>
		/// <param name="category">Имя категории.</param>
		// Token: 0x06002172 RID: 8562 RVA: 0x00072480 File Offset: 0x00070680
		public CategoryAttribute(string category)
		{
			this.categoryValue = category;
			this.localized = false;
		}

		/// <summary>Возвращает имя категории для свойства или события, к которым применяется этот атрибут.</summary>
		/// <returns>Имя категории для свойства или события, к которым применяется этот атрибут.</returns>
		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x00072498 File Offset: 0x00070698
		public string Category
		{
			get
			{
				if (!this.localized)
				{
					this.localized = true;
					string localizedString = this.GetLocalizedString(this.categoryValue);
					if (localizedString != null)
					{
						this.categoryValue = localizedString;
					}
				}
				return this.categoryValue;
			}
		}

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.CategoryAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002174 RID: 8564 RVA: 0x000724D1 File Offset: 0x000706D1
		public override bool Equals(object obj)
		{
			return obj == this || (obj is CategoryAttribute && this.Category.Equals(((CategoryAttribute)obj).Category));
		}

		/// <summary>Возвращает хэш-код для данного атрибута.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06002175 RID: 8565 RVA: 0x000724F9 File Offset: 0x000706F9
		public override int GetHashCode()
		{
			return this.Category.GetHashCode();
		}

		/// <summary>Выполняет поиск локализованной версии имени заданной категории.</summary>
		/// <param name="value">Идентификатор искомой категории.</param>
		/// <returns>Локализованное имя категории или значение <see langword="null" />, если локализованное имя не существует.</returns>
		// Token: 0x06002176 RID: 8566 RVA: 0x00072508 File Offset: 0x00070708
		protected virtual string GetLocalizedString(string value)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(value);
			if (num <= 1062369733U)
			{
				if (num <= 630759034U)
				{
					if (num <= 433860734U)
					{
						if (num != 175614239U)
						{
							if (num == 433860734U)
							{
								if (value == "Default")
								{
									return "Misc";
								}
							}
						}
						else if (value == "Action")
						{
							return "Action";
						}
					}
					else if (num != 521774151U)
					{
						if (num == 630759034U)
						{
							if (value == "DragDrop")
							{
								return "Drag Drop";
							}
						}
					}
					else if (value == "Behavior")
					{
						return "Behavior";
					}
				}
				else if (num <= 723360612U)
				{
					if (num != 676498961U)
					{
						if (num == 723360612U)
						{
							if (value == "Mouse")
							{
								return "Mouse";
							}
						}
					}
					else if (value == "Scale")
					{
						return "Scale";
					}
				}
				else if (num != 822184863U)
				{
					if (num != 1041509726U)
					{
						if (num == 1062369733U)
						{
							if (value == "Data")
							{
								return "Data";
							}
						}
					}
					else if (value == "Text")
					{
						return "Text";
					}
				}
				else if (value == "Appearance")
				{
					return "Appearance";
				}
			}
			else if (num <= 2809814704U)
			{
				if (num <= 1779622119U)
				{
					if (num != 1762750224U)
					{
						if (num == 1779622119U)
						{
							if (value == "Config")
							{
								return "Configurations";
							}
						}
					}
					else if (value == "DDE")
					{
						return "DDE";
					}
				}
				else if (num != 2055433310U)
				{
					if (num != 2368288673U)
					{
						if (num == 2809814704U)
						{
							if (value == "Font")
							{
								return "Font";
							}
						}
					}
					else if (value == "List")
					{
						return "List";
					}
				}
				else if (value == "WindowStyle")
				{
					return "Window Style";
				}
			}
			else if (num <= 3441084684U)
			{
				if (num != 3159863731U)
				{
					if (num == 3441084684U)
					{
						if (value == "Key")
						{
							return "Key";
						}
					}
				}
				else if (value == "Focus")
				{
					return "Focus";
				}
			}
			else if (num != 3799987242U)
			{
				if (num != 3901555439U)
				{
					if (num == 4152902175U)
					{
						if (value == "Layout")
						{
							return "Layout";
						}
					}
				}
				else if (value == "Design")
				{
					return "Design";
				}
			}
			else if (value == "Position")
			{
				return "Position";
			}
			return value;
		}

		/// <summary>Определяет, является ли этот атрибут используемым по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут является значением по умолчанию для данного класса атрибутов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002177 RID: 8567 RVA: 0x00072846 File Offset: 0x00070A46
		public override bool IsDefaultAttribute()
		{
			return this.Category.Equals(CategoryAttribute.Default.Category);
		}

		// Token: 0x04001004 RID: 4100
		private static volatile CategoryAttribute appearance;

		// Token: 0x04001005 RID: 4101
		private static volatile CategoryAttribute asynchronous;

		// Token: 0x04001006 RID: 4102
		private static volatile CategoryAttribute behavior;

		// Token: 0x04001007 RID: 4103
		private static volatile CategoryAttribute data;

		// Token: 0x04001008 RID: 4104
		private static volatile CategoryAttribute design;

		// Token: 0x04001009 RID: 4105
		private static volatile CategoryAttribute action;

		// Token: 0x0400100A RID: 4106
		private static volatile CategoryAttribute format;

		// Token: 0x0400100B RID: 4107
		private static volatile CategoryAttribute layout;

		// Token: 0x0400100C RID: 4108
		private static volatile CategoryAttribute mouse;

		// Token: 0x0400100D RID: 4109
		private static volatile CategoryAttribute key;

		// Token: 0x0400100E RID: 4110
		private static volatile CategoryAttribute focus;

		// Token: 0x0400100F RID: 4111
		private static volatile CategoryAttribute windowStyle;

		// Token: 0x04001010 RID: 4112
		private static volatile CategoryAttribute dragDrop;

		// Token: 0x04001011 RID: 4113
		private static volatile CategoryAttribute defAttr;

		// Token: 0x04001012 RID: 4114
		private bool localized;

		// Token: 0x04001013 RID: 4115
		private string categoryValue;
	}
}
