using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет данные для события <see cref="E:System.ComponentModel.INotifyPropertyChanged.PropertyChanged" />.</summary>
	// Token: 0x02000403 RID: 1027
	public class PropertyChangedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PropertyChangedEventArgs" />.</summary>
		/// <param name="propertyName">Имя изменяемого свойства.</param>
		// Token: 0x06002149 RID: 8521 RVA: 0x00072188 File Offset: 0x00070388
		public PropertyChangedEventArgs(string propertyName)
		{
			this._propertyName = propertyName;
		}

		/// <summary>Возвращает имя измененного свойства.</summary>
		/// <returns>Имя изменяемого свойства.</returns>
		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x00072197 File Offset: 0x00070397
		public virtual string PropertyName
		{
			get
			{
				return this._propertyName;
			}
		}

		// Token: 0x04000FFC RID: 4092
		private readonly string _propertyName;
	}
}
