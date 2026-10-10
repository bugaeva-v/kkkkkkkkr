using System;
using System.Configuration;
using System.IO;

namespace System.Xml.Serialization.Configuration
{
	/// <summary>
	///         Проверяет правила, регулирующие использование tempFilesLocation конфигурационный параметр.
	///       </summary>
	// Token: 0x0200031F RID: 799
	public class RootedPathValidator : ConfigurationValidatorBase
	{
		/// <summary>
		///         Определяет, можно ли проверить тип объекта.
		///       </summary>
		/// <param name="type">
		///           Тип объекта.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <paramref name="type" /> параметр соответствует допустимым <see langword="XMLSerializer" /> объекта; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x060020EC RID: 8428 RVA: 0x000D2055 File Offset: 0x000D0255
		public override bool CanValidate(Type type)
		{
			return type == typeof(string);
		}

		/// <summary>
		///         Определяет, допустимо ли значение объекта.
		///       </summary>
		/// <param name="value">
		///           Значение объекта.
		///         </param>
		// Token: 0x060020ED RID: 8429 RVA: 0x000D2068 File Offset: 0x000D0268
		public override void Validate(object value)
		{
			string text = value as string;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			text = text.Trim();
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			if (!Path.IsPathRooted(text))
			{
				throw new ConfigurationErrorsException();
			}
			char c = text[0];
			if (c == Path.DirectorySeparatorChar || c == Path.AltDirectorySeparatorChar)
			{
				throw new ConfigurationErrorsException();
			}
		}
	}
}
