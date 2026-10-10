using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет данные для события <see cref="E:System.ComponentModel.INotifyDataErrorInfo.ErrorsChanged" />.</summary>
	// Token: 0x020003FF RID: 1023
	public class DataErrorsChangedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.DataErrorsChangedEventArgs" />.</summary>
		/// <param name="propertyName">Имя свойства, которое содержит ошибку.  <see langword="null" /> или <see cref="F:System.String.Empty" />, если ошибка произошла на уровне объекта.</param>
		// Token: 0x0600213F RID: 8511 RVA: 0x00072171 File Offset: 0x00070371
		public DataErrorsChangedEventArgs(string propertyName)
		{
			this._propertyName = propertyName;
		}

		/// <summary>Возвращает имя свойства, которое содержит ошибку.</summary>
		/// <returns>Имя свойства, которое содержит ошибку. <see langword="null" /> или <see cref="F:System.String.Empty" />, если ошибка произошла на уровне объекта.</returns>
		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x00072180 File Offset: 0x00070380
		public virtual string PropertyName
		{
			get
			{
				return this._propertyName;
			}
		}

		// Token: 0x04000FFB RID: 4091
		private readonly string _propertyName;
	}
}
