using System;
using System.ComponentModel;

namespace System.IO
{
	/// <summary>Задает для визуальных конструкторов описания возможность отображения при обращении к событию, средству расширения или свойству.</summary>
	// Token: 0x02000517 RID: 1303
	[AttributeUsage(AttributeTargets.All)]
	public class IODescriptionAttribute : DescriptionAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.IODescriptionAttribute" />.</summary>
		/// <param name="description">Описание, которое следует использовать.</param>
		// Token: 0x06002A4A RID: 10826 RVA: 0x0002BAD4 File Offset: 0x00029CD4
		public IODescriptionAttribute(string description) : base(description)
		{
		}

		/// <summary>Получает описание.</summary>
		/// <returns>Описание для события, средства расширения или свойства.</returns>
		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x0006801F File Offset: 0x0006621F
		public override string Description
		{
			get
			{
				return base.DescriptionValue;
			}
		}
	}
}
