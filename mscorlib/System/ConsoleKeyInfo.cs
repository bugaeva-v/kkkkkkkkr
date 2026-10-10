using System;

namespace System
{
	/// <summary>Описывает нажатую клавишу консоли, включая символ, представленный этой клавишей, и состояние управляющих клавиш CTRL, SHIFT и ALT.</summary>
	// Token: 0x020001C0 RID: 448
	[Serializable]
	public readonly struct ConsoleKeyInfo
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.ConsoleKeyInfo" /> с использованием заданного символа, клавиши консоли и управляющих клавиш.</summary>
		/// <param name="keyChar">Символ Юникода, соответствующий параметру <paramref name="key" />.</param>
		/// <param name="key">Клавиша консоли, соответствующая параметру <paramref name="keyChar" />.</param>
		/// <param name="shift">
		///   <see langword="true" />, чтобы указать, что нажата клавиша SHIFT; в противном случае — <see langword="false" />.</param>
		/// <param name="alt">
		///   <see langword="true" />, чтобы указать, что нажата клавиша ALT; в противном случае — <see langword="false" />.</param>
		/// <param name="control">
		///   <see langword="true" />, чтобы указать, что нажата клавиша CTRL; в противном случае — <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Числовое значение параметра <paramref name="key" /> меньше 0 или больше 255.</exception>
		// Token: 0x06001339 RID: 4921 RVA: 0x0004D888 File Offset: 0x0004BA88
		public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control)
		{
			if (key < (ConsoleKey)0 || key > (ConsoleKey)255)
			{
				throw new ArgumentOutOfRangeException("key", "Console key values must be between 0 and 255 inclusive.");
			}
			this._keyChar = keyChar;
			this._key = key;
			this._mods = (ConsoleModifiers)0;
			if (shift)
			{
				this._mods |= ConsoleModifiers.Shift;
			}
			if (alt)
			{
				this._mods |= ConsoleModifiers.Alt;
			}
			if (control)
			{
				this._mods |= ConsoleModifiers.Control;
			}
		}

		/// <summary>Возвращает символ Юникода, представленный текущим объектом <see cref="T:System.ConsoleKeyInfo" />.</summary>
		/// <returns>Объект, соответствующий клавише консоли, представленной текущим объектом <see cref="T:System.ConsoleKeyInfo" />.</returns>
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x0004D8FB File Offset: 0x0004BAFB
		public char KeyChar
		{
			get
			{
				return this._keyChar;
			}
		}

		/// <summary>Возвращает клавишу консоли, представленную текущим объектом <see cref="T:System.ConsoleKeyInfo" />.</summary>
		/// <returns>Значение, идентифицирующее нажатую клавишу консоли.</returns>
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x0004D903 File Offset: 0x0004BB03
		public ConsoleKey Key
		{
			get
			{
				return this._key;
			}
		}

		/// <summary>Возвращает побитовое сочетание значений из перечисления <see cref="T:System.ConsoleModifiers" />, указывающее, были ли одновременно с клавишей консоли нажаты управляющие клавиши SHIFT, ALT или CTRL.</summary>
		/// <returns>Побитовое сочетание значений перечисления. Значение по умолчанию отсутствует.</returns>
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x0004D90B File Offset: 0x0004BB0B
		public ConsoleModifiers Modifiers
		{
			get
			{
				return this._mods;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, равен ли указанный объект текущему объекту <see cref="T:System.ConsoleKeyInfo" />.</summary>
		/// <param name="value">Объект, который требуется сравнить с текущим объектом <see cref="T:System.ConsoleKeyInfo" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="value" /> является объектом <see cref="T:System.ConsoleKeyInfo" /> и равен текущему объекту <see cref="T:System.ConsoleKeyInfo" />. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600133D RID: 4925 RVA: 0x0004D913 File Offset: 0x0004BB13
		public override bool Equals(object value)
		{
			return value is ConsoleKeyInfo && this.Equals((ConsoleKeyInfo)value);
		}

		/// <summary>Возвращает значение, позволяющее определить, равен ли указанный объект <see cref="T:System.ConsoleKeyInfo" /> текущему объекту <see cref="T:System.ConsoleKeyInfo" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом <see cref="T:System.ConsoleKeyInfo" />.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="obj" /> равен текущему объекту <see cref="T:System.ConsoleKeyInfo" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x0600133E RID: 4926 RVA: 0x0004D92B File Offset: 0x0004BB2B
		public bool Equals(ConsoleKeyInfo obj)
		{
			return obj._keyChar == this._keyChar && obj._key == this._key && obj._mods == this._mods;
		}

		/// <summary>Указывает, равны ли значения заданных объектов <see cref="T:System.ConsoleKeyInfo" />.</summary>
		/// <param name="a">Первый из сравниваемых объектов.</param>
		/// <param name="b">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600133F RID: 4927 RVA: 0x0004D959 File Offset: 0x0004BB59
		public static bool operator ==(ConsoleKeyInfo a, ConsoleKeyInfo b)
		{
			return a.Equals(b);
		}

		/// <summary>Указывает, верно ли, что значения указанных объектов <see cref="T:System.ConsoleKeyInfo" /> не равны.</summary>
		/// <param name="a">Первый из сравниваемых объектов.</param>
		/// <param name="b">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="a" /> и <paramref name="b" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001340 RID: 4928 RVA: 0x0004D963 File Offset: 0x0004BB63
		public static bool operator !=(ConsoleKeyInfo a, ConsoleKeyInfo b)
		{
			return !(a == b);
		}

		/// <summary>Возвращает хэш-код для текущего объекта <see cref="T:System.ConsoleKeyInfo" />.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001341 RID: 4929 RVA: 0x0004D96F File Offset: 0x0004BB6F
		public override int GetHashCode()
		{
			return (int)((ConsoleKey)this._keyChar | (int)this._key << 16 | (ConsoleKey)((int)this._mods << 24));
		}

		// Token: 0x04001439 RID: 5177
		private readonly char _keyChar;

		// Token: 0x0400143A RID: 5178
		private readonly ConsoleKey _key;

		// Token: 0x0400143B RID: 5179
		private readonly ConsoleModifiers _mods;
	}
}
