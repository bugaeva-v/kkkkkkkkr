using System;

namespace System.Data
{
	/// <summary>Описывает действие, выполняемое с объектом <see cref="T:System.Data.DataRow" />.</summary>
	// Token: 0x020000BF RID: 191
	[Flags]
	public enum DataRowAction
	{
		/// <summary>Строка не была изменена.</summary>
		// Token: 0x040007DB RID: 2011
		Nothing = 0,
		/// <summary>Строка была удалена из таблицы.</summary>
		// Token: 0x040007DC RID: 2012
		Delete = 1,
		/// <summary>Строка была изменена.</summary>
		// Token: 0x040007DD RID: 2013
		Change = 2,
		/// <summary>Выполнен откат последнего изменения строки.</summary>
		// Token: 0x040007DE RID: 2014
		Rollback = 4,
		/// <summary>Изменения, внесенные в строку, были зафиксированы.</summary>
		// Token: 0x040007DF RID: 2015
		Commit = 8,
		/// <summary>Строка была добавлена в таблицу.</summary>
		// Token: 0x040007E0 RID: 2016
		Add = 16,
		/// <summary>Исходная версия строки изменена.</summary>
		// Token: 0x040007E1 RID: 2017
		ChangeOriginal = 32,
		/// <summary>Текущая и исходная версии строки были изменены.</summary>
		// Token: 0x040007E2 RID: 2018
		ChangeCurrentAndOriginal = 64
	}
}
