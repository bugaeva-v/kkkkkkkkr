using System;
using System.Collections;

namespace System.Data
{
	/// <summary>Собирает все параметры, относящиеся к объекту Command, и их сопоставления со столбцами <see cref="T:System.Data.DataSet" />. Реализация осуществляют поставщики данных .NET Framework, которые обращаются к источникам данных.</summary>
	// Token: 0x02000100 RID: 256
	public interface IDataParameterCollection : IList, ICollection, IEnumerable
	{
		/// <summary>Возвращает или задает параметр по указанному индексу.</summary>
		/// <param name="parameterName">Имя получаемого параметра.</param>
		/// <returns>Элемент <see cref="T:System.Object" />, расположенный по указанному индексу.</returns>
		// Token: 0x17000296 RID: 662
		object this[string parameterName]
		{
			get;
			set;
		}

		/// <summary>Возвращает значение, которое показывает, имеет ли параметр в коллекции указанное имя.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит параметр. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F22 RID: 3874
		bool Contains(string parameterName);

		/// <summary>Возвращает расположение элемента <see cref="T:System.Data.IDataParameter" /> в коллекции.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		/// <returns>Отсчитываемое от нуля расположение элемента <see cref="T:System.Data.IDataParameter" /> в коллекции.</returns>
		// Token: 0x06000F23 RID: 3875
		int IndexOf(string parameterName);

		/// <summary>Удаляет объект <see cref="T:System.Data.IDataParameter" /> из коллекции.</summary>
		/// <param name="parameterName">Имя параметра.</param>
		// Token: 0x06000F24 RID: 3876
		void RemoveAt(string parameterName);
	}
}
