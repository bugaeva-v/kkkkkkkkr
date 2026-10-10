using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет значение, которое может быть либо продуктом, либо комментарием в заголовке User-Agent.</summary>
	// Token: 0x02000061 RID: 97
	public class ProductInfoHeaderValue : ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</summary>
		/// <param name="product">Объект <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />, который используется для инициализации нового экземпляра.</param>
		// Token: 0x06000367 RID: 871 RVA: 0x0000BD1F File Offset: 0x00009F1F
		public ProductInfoHeaderValue(ProductHeaderValue product)
		{
			if (product == null)
			{
				throw new ArgumentNullException();
			}
			this.Product = product;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</summary>
		/// <param name="comment">Значение комментария.</param>
		// Token: 0x06000368 RID: 872 RVA: 0x0000BD37 File Offset: 0x00009F37
		public ProductInfoHeaderValue(string comment)
		{
			Parser.Token.CheckComment(comment);
			this.Comment = comment;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</summary>
		/// <param name="productName">Значение имени продукта.</param>
		/// <param name="productVersion">Значение версии продукта.</param>
		// Token: 0x06000369 RID: 873 RVA: 0x0000BD4C File Offset: 0x00009F4C
		public ProductInfoHeaderValue(string productName, string productVersion)
		{
			this.Product = new ProductHeaderValue(productName, productVersion);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000022B8 File Offset: 0x000004B8
		private ProductInfoHeaderValue()
		{
		}

		/// <summary>Возвращает комментарий из объекта <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</summary>
		/// <returns>Значение комментария (<see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />).</returns>
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0000BD61 File Offset: 0x00009F61
		// (set) Token: 0x0600036C RID: 876 RVA: 0x0000BD69 File Offset: 0x00009F69
		public string Comment { get; private set; }

		/// <summary>Возвращает продукт из объекта <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</summary>
		/// <returns>Значение продукта из объекта <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</returns>
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000BD72 File Offset: 0x00009F72
		// (set) Token: 0x0600036E RID: 878 RVA: 0x0000BD7A File Offset: 0x00009F7A
		public ProductHeaderValue Product { get; private set; }

		/// <summary>Создает новый объект <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />, являющийся копией текущего экземпляра.</summary>
		/// <returns>Копия текущего экземпляра.</returns>
		// Token: 0x0600036F RID: 879 RVA: 0x00006AEE File Offset: 0x00004CEE
		object ICloneable.Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Определяет, равен ли заданный объект <see cref="T:System.Object" /> текущему объекту <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</summary>
		/// <param name="obj">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06000370 RID: 880 RVA: 0x0000BD84 File Offset: 0x00009F84
		public override bool Equals(object obj)
		{
			ProductInfoHeaderValue productInfoHeaderValue = obj as ProductInfoHeaderValue;
			if (productInfoHeaderValue == null)
			{
				return false;
			}
			if (this.Product == null)
			{
				return productInfoHeaderValue.Comment == this.Comment;
			}
			return this.Product.Equals(productInfoHeaderValue.Product);
		}

		/// <summary>Служит хэш-функцией для объекта <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</summary>
		/// <returns>Хэш-код для текущего объекта.</returns>
		// Token: 0x06000371 RID: 881 RVA: 0x0000BDC8 File Offset: 0x00009FC8
		public override int GetHashCode()
		{
			if (this.Product == null)
			{
				return this.Comment.GetHashCode();
			}
			return this.Product.GetHashCode();
		}

		/// <summary>Преобразует строку в экземпляр <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</summary>
		/// <param name="input">Строка, представляющая сведения о значениях заголовка продукта.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="input" /> — это пустая ссылка (<see langword="null" />).</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="input" /> не представляет допустимые сведения о значениях заголовка продукта.</exception>
		// Token: 0x06000372 RID: 882 RVA: 0x0000BDEC File Offset: 0x00009FEC
		public static ProductInfoHeaderValue Parse(string input)
		{
			ProductInfoHeaderValue result;
			if (ProductInfoHeaderValue.TryParse(input, out result))
			{
				return result;
			}
			throw new FormatException(input);
		}

		/// <summary>Определяет, является ли строка допустимыми сведениями <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</summary>
		/// <param name="input">Проверяемая строка.</param>
		/// <param name="parsedValue">Версия <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" /> строки.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="input" /> представляет допустимые сведения <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x06000373 RID: 883 RVA: 0x0000BE0C File Offset: 0x0000A00C
		public static bool TryParse(string input, out ProductInfoHeaderValue parsedValue)
		{
			parsedValue = null;
			Lexer lexer = new Lexer(input);
			if (!ProductInfoHeaderValue.TryParseElement(lexer, out parsedValue) || parsedValue == null)
			{
				return false;
			}
			if (lexer.Scan(false) != Token.Type.End)
			{
				parsedValue = null;
				return false;
			}
			return true;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000BE48 File Offset: 0x0000A048
		internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result)
		{
			List<ProductInfoHeaderValue> list = new List<ProductInfoHeaderValue>();
			Lexer lexer = new Lexer(input);
			result = null;
			ProductInfoHeaderValue productInfoHeaderValue;
			while (ProductInfoHeaderValue.TryParseElement(lexer, out productInfoHeaderValue))
			{
				if (productInfoHeaderValue != null)
				{
					list.Add(productInfoHeaderValue);
					int num = lexer.PeekChar();
					if (num != -1)
					{
						if (num == 9 || num == 32)
						{
							lexer.EatChar();
							continue;
						}
					}
					else if (minimalCount <= list.Count)
					{
						result = list;
						return true;
					}
					return false;
				}
				if (list != null && minimalCount <= list.Count)
				{
					result = list;
					return true;
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000BEBC File Offset: 0x0000A0BC
		private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue)
		{
			parsedValue = null;
			string text;
			Token token;
			if (lexer.ScanCommentOptional(out text, out token))
			{
				if (text == null)
				{
					return false;
				}
				parsedValue = new ProductInfoHeaderValue();
				parsedValue.Comment = text;
				return true;
			}
			else
			{
				if (token == Token.Type.End)
				{
					return true;
				}
				if (token != Token.Type.Token)
				{
					return false;
				}
				ProductHeaderValue productHeaderValue = new ProductHeaderValue();
				productHeaderValue.Name = lexer.GetStringValue(token);
				int position = lexer.Position;
				token = lexer.Scan(false);
				if (token == Token.Type.SeparatorSlash)
				{
					token = lexer.Scan(false);
					if (token != Token.Type.Token)
					{
						return false;
					}
					productHeaderValue.Version = lexer.GetStringValue(token);
				}
				else
				{
					lexer.Position = position;
				}
				parsedValue = new ProductInfoHeaderValue(productHeaderValue);
				return true;
			}
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x06000376 RID: 886 RVA: 0x0000BF61 File Offset: 0x0000A161
		public override string ToString()
		{
			if (this.Product == null)
			{
				return this.Comment;
			}
			return this.Product.ToString();
		}
	}
}
