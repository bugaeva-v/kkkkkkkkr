using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Определяет, какие члены могут реализовываться классами сущностей данных для поддержки пользовательской синхронной и асинхронной проверки.</summary>
	// Token: 0x02000400 RID: 1024
	public interface INotifyDataErrorInfo
	{
		/// <summary>Возвращает значение, указывающее, имеет ли сущность ошибки проверки.</summary>
		/// <returns>Значение <see langword="true" />, если сущность в данный момент содержит ошибки проверки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002141 RID: 8513
		bool HasErrors { get; }

		/// <summary>Возвращает ошибки проверки для указанного свойства или для всей сущности.</summary>
		/// <param name="propertyName">Имя свойства, для которого извлекаются ошибки проверки, либо значение <see langword="null" /> или <see cref="F:System.String.Empty" /> для извлечения ошибок на уровне сущности.</param>
		/// <returns>Ошибки проверки для свойства или сущности.</returns>
		// Token: 0x06002142 RID: 8514
		IEnumerable GetErrors(string propertyName);

		/// <summary>Происходит при изменении ошибок проверки для свойства или для всей сущности.</summary>
		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06002143 RID: 8515
		// (remove) Token: 0x06002144 RID: 8516
		event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
	}
}
