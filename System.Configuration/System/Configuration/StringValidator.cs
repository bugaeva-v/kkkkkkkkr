using System;

namespace System.Configuration
{
	/// <summary>Выполняет проверку строки.</summary>
	// Token: 0x0200006A RID: 106
	public class StringValidator : ConfigurationValidatorBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.StringValidator" />, используя предоставленный параметр.</summary>
		/// <param name="minLength">Целое число, определяющее минимальную длину значения строки.</param>
		// Token: 0x060003AC RID: 940 RVA: 0x0000A7EB File Offset: 0x000089EB
		public StringValidator(int minLength)
		{
			this.minLength = minLength;
			this.maxLength = int.MaxValue;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.StringValidator" /> на основе предоставленных параметров.</summary>
		/// <param name="minLength">Целое число, определяющее минимальную длину значения строки.</param>
		/// <param name="maxLength">Целое число, определяющее максимальную длину значения строки.</param>
		// Token: 0x060003AD RID: 941 RVA: 0x0000A805 File Offset: 0x00008A05
		public StringValidator(int minLength, int maxLength)
		{
			this.minLength = minLength;
			this.maxLength = maxLength;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.StringValidator" /> на основе предоставленных параметров.</summary>
		/// <param name="minLength">Целое число, определяющее минимальную длину значения строки.</param>
		/// <param name="maxLength">Целое число, определяющее максимальную длину значения строки.</param>
		/// <param name="invalidCharacters">Строка, отображающая недопустимые символы.</param>
		// Token: 0x060003AE RID: 942 RVA: 0x0000A81B File Offset: 0x00008A1B
		public StringValidator(int minLength, int maxLength, string invalidCharacters)
		{
			this.minLength = minLength;
			this.maxLength = maxLength;
			if (invalidCharacters != null)
			{
				this.invalidCharacters = invalidCharacters.ToCharArray();
			}
		}

		/// <summary>Определяет, можно ли проверить объект по типу.</summary>
		/// <param name="type">Тип объекта.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="type" /> соответствует строке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060003AF RID: 943 RVA: 0x00008F30 File Offset: 0x00007130
		public override bool CanValidate(Type type)
		{
			return type == typeof(string);
		}

		/// <summary>Определяет, является ли значение объекта допустимым.</summary>
		/// <param name="value">Значение объекта.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> меньше чем <paramref name="minValue" /> или больше чем <paramref name="maxValue" />, как определено в конструкторе.  
		/// -или- 
		///  Параметр <paramref name="value" /> содержит недопустимые символы.</exception>
		// Token: 0x060003B0 RID: 944 RVA: 0x0000A840 File Offset: 0x00008A40
		public override void Validate(object value)
		{
			if (value == null && this.minLength <= 0)
			{
				return;
			}
			string text = (string)value;
			if (text == null || text.Length < this.minLength)
			{
				throw new ArgumentException("The string must be at least " + this.minLength.ToString() + " characters long.");
			}
			if (text.Length > this.maxLength)
			{
				throw new ArgumentException("The string must be no more than " + this.maxLength.ToString() + " characters long.");
			}
			if (this.invalidCharacters != null && text.IndexOfAny(this.invalidCharacters) != -1)
			{
				throw new ArgumentException(string.Format("The string cannot contain any of the following characters: '{0}'.", this.invalidCharacters));
			}
		}

		// Token: 0x0400014C RID: 332
		private char[] invalidCharacters;

		// Token: 0x0400014D RID: 333
		private int maxLength;

		// Token: 0x0400014E RID: 334
		private int minLength;
	}
}
