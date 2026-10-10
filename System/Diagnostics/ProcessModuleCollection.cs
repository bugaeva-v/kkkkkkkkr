using System;
using System.Collections;

namespace System.Diagnostics
{
	/// <summary>Возвращает строго типизированную коллекцию объектов <see cref="T:System.Diagnostics.ProcessModule" />.</summary>
	// Token: 0x02000244 RID: 580
	public class ProcessModuleCollection : ReadOnlyCollectionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.ProcessModuleCollection" /> без связанных экземпляров <see cref="T:System.Diagnostics.ProcessModule" />.</summary>
		// Token: 0x060011CD RID: 4557 RVA: 0x0004DD52 File Offset: 0x0004BF52
		protected ProcessModuleCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.ProcessModuleCollection" />, используя указанный массив экземпляров <see cref="T:System.Diagnostics.ProcessModule" />.</summary>
		/// <param name="processModules">Массив экземпляров <see cref="T:System.Diagnostics.ProcessModule" />, с помощью которого требуется инициализировать этот экземпляр <see cref="T:System.Diagnostics.ProcessModuleCollection" />.</param>
		// Token: 0x060011CE RID: 4558 RVA: 0x0004DD5A File Offset: 0x0004BF5A
		public ProcessModuleCollection(ProcessModule[] processModules)
		{
			base.InnerList.AddRange(processModules);
		}

		/// <summary>Возвращает индекс для перебора набора модулей процесса.</summary>
		/// <param name="index">Значение отсчитываемого от нуля индекса модуля в коллекции.</param>
		/// <returns>Объект <see cref="T:System.Diagnostics.ProcessModule" />, который индексирует модули в коллекции.</returns>
		// Token: 0x17000320 RID: 800
		public ProcessModule this[int index]
		{
			get
			{
				return (ProcessModule)base.InnerList[index];
			}
		}

		/// <summary>Предоставляет положение указанного модуля в коллекции.</summary>
		/// <param name="module">Поток <see cref="T:System.Diagnostics.ProcessModule" />, индекс которого извлекается.</param>
		/// <returns>Отсчитываемый от нуля индекс, который определяет место модуля в <see cref="T:System.Diagnostics.ProcessModuleCollection" />.</returns>
		// Token: 0x060011D0 RID: 4560 RVA: 0x0004DD81 File Offset: 0x0004BF81
		public int IndexOf(ProcessModule module)
		{
			return base.InnerList.IndexOf(module);
		}

		/// <summary>Определяет, существует ли в коллекции указанный модуль процесса.</summary>
		/// <param name="module">Экземпляр <see cref="T:System.Diagnostics.ProcessModule" />, указывающий модуль, который необходимо найти в этой коллекции.</param>
		/// <returns>Значение <see langword="true" />, если модуль существует в коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060011D1 RID: 4561 RVA: 0x0004DD8F File Offset: 0x0004BF8F
		public bool Contains(ProcessModule module)
		{
			return base.InnerList.Contains(module);
		}

		/// <summary>Копирует массив экземпляров <see cref="T:System.Diagnostics.ProcessModule" /> в коллекцию по указанному индексу.</summary>
		/// <param name="array">Массив экземпляров <see cref="T:System.Diagnostics.ProcessModule" />, добавляемый в коллекцию.</param>
		/// <param name="index">Расположение, в которое добавляются новые экземпляры.</param>
		// Token: 0x060011D2 RID: 4562 RVA: 0x0004DD9D File Offset: 0x0004BF9D
		public void CopyTo(ProcessModule[] array, int index)
		{
			base.InnerList.CopyTo(array, index);
		}
	}
}
