using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет значение токена продукта в заголовке агента пользователя.</summary>
	// Token: 0x02000060 RID: 96
	public class ProductHeaderValue : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.ProductHeaderValue" />.</summary>
		/// <param name="name">Название продукта.</param>
		// Token: 0x06000358 RID: 856 RVA: 0x0000BB1D File Offset: 0x00009D1D
		public ProductHeaderValue(string name)
		{
			Parser.Token.Check(name);
			this.Name = name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.ProductHeaderValue" />.</summary>
		/// <param name="name">Значение имени продукта.</param>
		/// <param name="version">Значение версии продукта.</param>
		// Token: 0x06000359 RID: 857 RVA: 0x0000BB32 File Offset: 0x00009D32
		public ProductHeaderValue(string name, string version) : this(name)
		{
			if (!string.IsNullOrEmpty(version))
			{
				Parser.Token.Check(version);
			}
			this.Version = version;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000022B8 File Offset: 0x000004B8
		internal ProductHeaderValue()
		{
		}

		/// <summary>Возвращает имя маркера продукта.</summary>
		/// <returns>Имя маркера продукта.</returns>
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0000BB50 File Offset: 0x00009D50
		// (set) Token: 0x0600035C RID: 860 RVA: 0x0000BB58 File Offset: 0x00009D58
		public string Name { get; internal set; }

		/// <summary>Возвращает версию маркера продукта.</summary>
		/// <returns>Версия маркера продукта.</returns>
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000BB61 File Offset: 0x00009D61
		// (set) Token: 0x0600035E RID: 862 RVA: 0x0000BB69 File Offset: 0x00009D69
		public string Version { get; internal set; }

		/// <summary>Создает новый объект <see cref="T:System.Net.Http.Headers.ProductHeaderValue" />, являющийся копией текущего экземпляра.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x0600035F RID: 863 RVA: 0x00006AEE File Offset: 0x00004CEE
		object ICloneable.Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Object" /> текущему объекту <see cref="T:System.Net.Http.Headers.ProductHeaderValue" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06000360 RID: 864 RVA: 0x0000BB74 File Offset: 0x00009D74
		public override bool Equals(object obj)
		{
			ProductHeaderValue productHeaderValue = obj as ProductHeaderValue;
			return productHeaderValue != null && string.Equals(productHeaderValue.Name, this.Name, StringComparison.OrdinalIgnoreCase) && string.Equals(productHeaderValue.Version, this.Version, StringComparison.OrdinalIgnoreCase);
		}

		/// <summary>Служит хэш-функцией для объекта <see cref="T:System.Net.Http.Headers.ProductHeaderValue" />.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x06000361 RID: 865 RVA: 0x0000BBB8 File Offset: 0x00009DB8
		public override int GetHashCode()
		{
			int num = this.Name.ToLowerInvariant().GetHashCode();
			if (this.Version != null)
			{
				num ^= this.Version.ToLowerInvariant().GetHashCode();
			}
			return num;
		}

		/// <summary>Преобразует строку в экземпляр <see cref="T:System.Net.Http.Headers.ProductHeaderValue" />.</summary>
		/// <param name="input">Строка, представляющая сведения о значениях заголовка продукта.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.Http.Headers.ProductHeaderValue" />.</returns>
		// Token: 0x06000362 RID: 866 RVA: 0x0000BBF4 File Offset: 0x00009DF4
		public static ProductHeaderValue Parse(string input)
		{
			ProductHeaderValue result;
			if (ProductHeaderValue.TryParse(input, out result))
			{
				return result;
			}
			throw new FormatException(input);
		}

		/// <summary>Определяет, является ли строка допустимыми сведениями <see cref="T:System.Net.Http.Headers.ProductHeaderValue" />.</summary>
		/// <param name="input">Проверяемая строка.</param>
		/// <param name="parsedValue">Версия <see cref="T:System.Net.Http.Headers.ProductHeaderValue" /> строки.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="input" /> представляет допустимые сведения <see cref="T:System.Net.Http.Headers.ProductHeaderValue" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06000363 RID: 867 RVA: 0x0000BC14 File Offset: 0x00009E14
		public static bool TryParse(string input, out ProductHeaderValue parsedValue)
		{
			Token token;
			if (ProductHeaderValue.TryParseElement(new Lexer(input), out parsedValue, out token) && token == Token.Type.End)
			{
				return true;
			}
			parsedValue = null;
			return false;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000BC40 File Offset: 0x00009E40
		internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result)
		{
			return CollectionParser.TryParse<ProductHeaderValue>(input, minimalCount, new ElementTryParser<ProductHeaderValue>(ProductHeaderValue.TryParseElement), out result);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000BC58 File Offset: 0x00009E58
		private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out Token t)
		{
			parsedValue = null;
			t = lexer.Scan(false);
			if (t != Token.Type.Token)
			{
				return false;
			}
			parsedValue = new ProductHeaderValue();
			parsedValue.Name = lexer.GetStringValue(t);
			t = lexer.Scan(false);
			if (t == Token.Type.SeparatorSlash)
			{
				t = lexer.Scan(false);
				if (t != Token.Type.Token)
				{
					return false;
				}
				parsedValue.Version = lexer.GetStringValue(t);
				t = lexer.Scan(false);
			}
			return true;
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.ProductHeaderValue" />.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x06000366 RID: 870 RVA: 0x0000BCF8 File Offset: 0x00009EF8
		public override string ToString()
		{
			if (this.Version != null)
			{
				return this.Name + "/" + this.Version;
			}
			return this.Name;
		}
	}
}
