using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
	/// <summary>
	///         Предоставляет функциональные возможности для оценки запросов по определенным источникам данных в случае, если тип данных известен.
	///       </summary>
	/// <typeparam name="T">
	///           Тип данных в источнике данных.
	///         </typeparam>
	// Token: 0x02000075 RID: 117
	public interface IQueryable<out T> : IEnumerable<!0>, IEnumerable, IQueryable
	{
	}
}
