using System;
using System.ComponentModel;

namespace System.Timers
{
	/// <summary>Задает описание, которое могут отображать визуальные конструкторы при обращении к событию, средству расширения или свойству.</summary>
	// Token: 0x02000194 RID: 404
	[AttributeUsage(AttributeTargets.All)]
	public class TimersDescriptionAttribute : DescriptionAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Timers.TimersDescriptionAttribute" />.</summary>
		/// <param name="description">Описание, которое следует использовать.</param>
		// Token: 0x06000AA1 RID: 2721 RVA: 0x0002BAD4 File Offset: 0x00029CD4
		public TimersDescriptionAttribute(string description) : base(description)
		{
		}

		/// <summary>Возвращает описание, которое могут отображать визуальные конструкторы при обращении к событию, средству расширения или свойству.</summary>
		/// <returns>Описание для события, средства расширения или свойства.</returns>
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0002DBEC File Offset: 0x0002BDEC
		public override string Description
		{
			get
			{
				if (!this.replaced)
				{
					this.replaced = true;
					base.DescriptionValue = SR.GetString(base.Description);
				}
				return base.Description;
			}
		}

		// Token: 0x04000720 RID: 1824
		private bool replaced;
	}
}
