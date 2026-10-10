using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет данные для события <see cref="E:System.ComponentModel.INotifyPropertyChanging.PropertyChanging" />.</summary>
	// Token: 0x02000405 RID: 1029
	public class PropertyChangingEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PropertyChangingEventArgs" />.</summary>
		/// <param name="propertyName">Имя свойства, значение которого изменяется.</param>
		// Token: 0x0600214F RID: 8527 RVA: 0x0007219F File Offset: 0x0007039F
		public PropertyChangingEventArgs(string propertyName)
		{
			this._propertyName = propertyName;
		}

		/// <summary>Получает имя свойства, значение которого меняется.</summary>
		/// <returns>Имя свойства, значение которого меняется.</returns>
		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x000721AE File Offset: 0x000703AE
		public virtual string PropertyName
		{
			get
			{
				return this._propertyName;
			}
		}

		// Token: 0x04000FFD RID: 4093
		private readonly string _propertyName;
	}
}
