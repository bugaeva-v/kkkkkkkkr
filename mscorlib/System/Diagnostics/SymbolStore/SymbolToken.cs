using System;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Структура <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> — это объектное представление маркера, представляющего символьные данные.</summary>
	// Token: 0x020009D4 RID: 2516
	public readonly struct SymbolToken
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> для заданного значения.</summary>
		/// <param name="val">Значение, используемое для маркера.</param>
		// Token: 0x06005A3C RID: 23100 RVA: 0x00134281 File Offset: 0x00132481
		public SymbolToken(int val)
		{
			this._token = val;
		}

		/// <summary>Получает значение текущего маркера.</summary>
		/// <returns>Значение текущего маркера.</returns>
		// Token: 0x06005A3D RID: 23101 RVA: 0x0013428A File Offset: 0x0013248A
		public int GetToken()
		{
			return this._token;
		}

		/// <summary>Создает хэш-код для текущего маркера.</summary>
		/// <returns>Хэш-код для текущего маркера.</returns>
		// Token: 0x06005A3E RID: 23102 RVA: 0x0013428A File Offset: 0x0013248A
		public override int GetHashCode()
		{
			return this._token;
		}

		/// <summary>Определяет, является ли объект <paramref name="obj" /> экземпляром класса <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> и равен ли этому экземпляру.</summary>
		/// <param name="obj">Объект для проверки.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="obj" /> является экземпляром класса <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> и равен этому экземпляру, в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005A3F RID: 23103 RVA: 0x00134292 File Offset: 0x00132492
		public override bool Equals(object obj)
		{
			return obj is SymbolToken && this.Equals((SymbolToken)obj);
		}

		/// <summary>Определяет, равен ли объект <paramref name="obj" /> данному экземпляру.</summary>
		/// <param name="obj">Проверяемый элемент <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" />.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно данному экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005A40 RID: 23104 RVA: 0x001342AA File Offset: 0x001324AA
		public bool Equals(SymbolToken obj)
		{
			return obj._token == this._token;
		}

		/// <summary>Возвращает значение, показывающее, равны ли два объекта <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" />.</summary>
		/// <param name="a">Структура <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" />.</param>
		/// <param name="b">Структура <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005A41 RID: 23105 RVA: 0x001342BA File Offset: 0x001324BA
		public static bool operator ==(SymbolToken a, SymbolToken b)
		{
			return a.Equals(b);
		}

		/// <summary>Возвращает значение, показывающее, являются ли два объекта <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> неравными.</summary>
		/// <param name="a">Структура <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" />.</param>
		/// <param name="b">Структура <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="a" /> и <paramref name="b" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005A42 RID: 23106 RVA: 0x001342C4 File Offset: 0x001324C4
		public static bool operator !=(SymbolToken a, SymbolToken b)
		{
			return !(a == b);
		}

		// Token: 0x040037BD RID: 14269
		private readonly int _token;
	}
}
