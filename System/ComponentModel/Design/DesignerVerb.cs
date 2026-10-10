using System;
using System.Text.RegularExpressions;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет команду, которая может быть вызвана из конструктора.</summary>
	// Token: 0x0200044B RID: 1099
	public class DesignerVerb : MenuCommand
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.DesignerVerb" />.</summary>
		/// <param name="text">Текст команды меню, отображаемый для пользователя.</param>
		/// <param name="handler">Обработчик события, выполняющий действия команды.</param>
		// Token: 0x060023C1 RID: 9153 RVA: 0x000812D3 File Offset: 0x0007F4D3
		public DesignerVerb(string text, EventHandler handler) : base(handler, StandardCommands.VerbFirst)
		{
			this.Properties["Text"] = ((text == null) ? null : Regex.Replace(text, "\\(\\&.\\)", ""));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.DesignerVerb" />.</summary>
		/// <param name="text">Текст команды меню, отображаемый для пользователя.</param>
		/// <param name="handler">Обработчик события, выполняющий действия команды.</param>
		/// <param name="startCommandID">Начальный идентификатор команды для данной команды конструктора. По умолчанию архитектура конструктора задает диапазон идентификаторов, допустимых для команд конструктора. Пользователь может переопределить данный идентификатор и задать свой идентификатор команды.</param>
		// Token: 0x060023C2 RID: 9154 RVA: 0x00081307 File Offset: 0x0007F507
		public DesignerVerb(string text, EventHandler handler, CommandID startCommandID) : base(handler, startCommandID)
		{
			this.Properties["Text"] = ((text == null) ? null : Regex.Replace(text, "\\(\\&.\\)", ""));
		}

		/// <summary>Получает или задает описание команды меню для команды.</summary>
		/// <returns>Строка, описывающая команду меню.</returns>
		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x00081338 File Offset: 0x0007F538
		// (set) Token: 0x060023C4 RID: 9156 RVA: 0x00081365 File Offset: 0x0007F565
		public string Description
		{
			get
			{
				object obj = this.Properties["Description"];
				if (obj == null)
				{
					return string.Empty;
				}
				return (string)obj;
			}
			set
			{
				this.Properties["Description"] = value;
			}
		}

		/// <summary>Возвращает текстовое описание команды меню.</summary>
		/// <returns>Текстовое описание команды меню.</returns>
		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x00081378 File Offset: 0x0007F578
		public string Text
		{
			get
			{
				object obj = this.Properties["Text"];
				if (obj == null)
				{
					return string.Empty;
				}
				return (string)obj;
			}
		}

		/// <summary>Переопределяет свойство <see cref="M:System.Object.ToString" />.</summary>
		/// <returns>Текст команды или пустая строка (""), если в текстовом поле отсутствует значение.</returns>
		// Token: 0x060023C6 RID: 9158 RVA: 0x000813A5 File Offset: 0x0007F5A5
		public override string ToString()
		{
			return this.Text + " : " + base.ToString();
		}
	}
}
