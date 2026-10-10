using System;

namespace System.ComponentModel.Composition
{
	/// <summary>Содержит экспортированное значение, созданное объектом <see cref="T:System.ComponentModel.Composition.ExportFactory`1" />, и ссылку на метод для освобождения этого объекта.</summary>
	/// <typeparam name="T">Тип экспортированного значения.</typeparam>
	// Token: 0x02000039 RID: 57
	public sealed class ExportLifetimeContext<T> : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ExportLifetimeContext`1" />.</summary>
		/// <param name="value">Экспортированное значение.</param>
		/// <param name="disposeAction">Ссылка на метод для освобождения объекта.</param>
		// Token: 0x060001B8 RID: 440 RVA: 0x00005922 File Offset: 0x00003B22
		public ExportLifetimeContext(T value, Action disposeAction)
		{
			this._value = value;
			this._disposeAction = disposeAction;
		}

		/// <summary>Получает экспортированное значение объекта <see cref="T:System.ComponentModel.Composition.ExportFactory`1" />.</summary>
		/// <returns>Экспортированное значение.</returns>
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00005938 File Offset: 0x00003B38
		public T Value
		{
			get
			{
				return this._value;
			}
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.ComponentModel.Composition.ExportLifetimeContext`1" />, включая связанный с ним экспорт.</summary>
		// Token: 0x060001BA RID: 442 RVA: 0x00005940 File Offset: 0x00003B40
		public void Dispose()
		{
			if (this._disposeAction != null)
			{
				this._disposeAction();
			}
		}

		// Token: 0x040000B6 RID: 182
		private readonly T _value;

		// Token: 0x040000B7 RID: 183
		private readonly Action _disposeAction;
	}
}
