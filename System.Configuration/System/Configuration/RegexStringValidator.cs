using System;
using System.Text.RegularExpressions;

namespace System.Configuration
{
	/// <summary>Обеспечивает проверку строки в соответствии с правилами, предусмотренными регулярным выражением.</summary>
	// Token: 0x02000063 RID: 99
	public class RegexStringValidator : ConfigurationValidatorBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.RegexStringValidator" />.</summary>
		/// <param name="regex">Строка, определяющая регулярное выражение.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="regex" /> имеет значение null или равен пустой строке ("").</exception>
		// Token: 0x06000338 RID: 824 RVA: 0x00008F21 File Offset: 0x00007121
		public RegexStringValidator(string regex)
		{
			this.regex = regex;
		}

		/// <summary>Определяет, можно ли проверить тип объекта.</summary>
		/// <param name="type">Тип объекта.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="type" /> соответствует строке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000339 RID: 825 RVA: 0x00008F30 File Offset: 0x00007130
		public override bool CanValidate(Type type)
		{
			return type == typeof(string);
		}

		/// <summary>Определяет, является ли значение объекта допустимым.</summary>
		/// <param name="value">Значение объекта.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не соответствует параметрам класса <see cref="T:System.Text.RegularExpressions.Regex" />.</exception>
		// Token: 0x0600033A RID: 826 RVA: 0x00008F42 File Offset: 0x00007142
		public override void Validate(object value)
		{
			if (!Regex.IsMatch((string)value, this.regex))
			{
				throw new ArgumentException("The string must match the regexp `{0}'", this.regex);
			}
		}

		// Token: 0x0400012C RID: 300
		private string regex;
	}
}
