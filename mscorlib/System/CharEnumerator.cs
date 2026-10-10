using System;
using System.Collections;
using System.Collections.Generic;
using Unity;

namespace System
{
	/// <summary>Поддерживает перебор объекта <see cref="T:System.String" /> и чтение его отдельных символов. Этот класс не наследуется.</summary>
	// Token: 0x02000106 RID: 262
	[Serializable]
	public sealed class CharEnumerator : IEnumerator, IEnumerator<char>, IDisposable, ICloneable
	{
		// Token: 0x0600082E RID: 2094 RVA: 0x000231B7 File Offset: 0x000213B7
		internal CharEnumerator(string str)
		{
			this._str = str;
			this._index = -1;
		}

		/// <summary>Создает копию текущего объекта <see cref="T:System.CharEnumerator" />.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, являющийся копией текущего объекта <see cref="T:System.CharEnumerator" />.</returns>
		// Token: 0x0600082F RID: 2095 RVA: 0x000231CD File Offset: 0x000213CD
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Увеличивает внутренний индекс текущего объекта <see cref="T:System.CharEnumerator" />, чтобы он указывал на следующий символ перечисляемой строки.</summary>
		/// <returns>Значение <see langword="true" /> если индекс успешно увеличен и находится в пределах перечисляемой строки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000830 RID: 2096 RVA: 0x000231D8 File Offset: 0x000213D8
		public bool MoveNext()
		{
			if (this._index < this._str.Length - 1)
			{
				this._index++;
				this._currentElement = this._str[this._index];
				return true;
			}
			this._index = this._str.Length;
			return false;
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.CharEnumerator" />.</summary>
		// Token: 0x06000831 RID: 2097 RVA: 0x00023233 File Offset: 0x00021433
		public void Dispose()
		{
			if (this._str != null)
			{
				this._index = this._str.Length;
			}
			this._str = null;
		}

		/// <summary>Возвращает текущий символ в строке, обходимой данным объектом <see cref="T:System.CharEnumerator" />. Описание этого члена см. в разделе <see cref="P:System.Collections.IEnumerator.Current" />.</summary>
		/// <returns>Упакованный символ Юникод, на которой указывает данный объект <see cref="T:System.CharEnumerator" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечисление не начиналось.  
		///
		/// или - 
		/// Обход завершен.</exception>
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00023255 File Offset: 0x00021455
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		/// <summary>Возвращает текущий символ в строке, обходимой данным объектом <see cref="T:System.CharEnumerator" />.</summary>
		/// <returns>Возвращает символ Юникод, на которой указывает данный объект <see cref="T:System.CharEnumerator" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Индекс является недопустимым; это означает, что он находится перед первым или после последнего символа обходимой строки.</exception>
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00023262 File Offset: 0x00021462
		public char Current
		{
			get
			{
				if (this._index == -1)
				{
					throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
				}
				if (this._index >= this._str.Length)
				{
					throw new InvalidOperationException("Enumeration already finished.");
				}
				return this._currentElement;
			}
		}

		/// <summary>Инициализирует индекс позицией, логически расположенной перед первым символом обходимой строки.</summary>
		// Token: 0x06000834 RID: 2100 RVA: 0x0002329C File Offset: 0x0002149C
		public void Reset()
		{
			this._currentElement = '\0';
			this._index = -1;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000173AD File Offset: 0x000155AD
		internal CharEnumerator()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001081 RID: 4225
		private string _str;

		// Token: 0x04001082 RID: 4226
		private int _index;

		// Token: 0x04001083 RID: 4227
		private char _currentElement;
	}
}
