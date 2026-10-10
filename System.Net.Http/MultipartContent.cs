using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Net.Http
{
	/// <summary>Предоставляет коллекцию объектов <see cref="T:System.Net.Http.HttpContent" />, которые сериализуются используя спецификацию типа содержимого multipart/*.</summary>
	// Token: 0x0200002E RID: 46
	public class MultipartContent : HttpContent, IEnumerable<HttpContent>, IEnumerable
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Http.MultipartContent" />.</summary>
		// Token: 0x0600017A RID: 378 RVA: 0x00006012 File Offset: 0x00004212
		public MultipartContent() : this("mixed")
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Http.MultipartContent" />.</summary>
		/// <param name="subtype">Подтип многокомпонентного контента.</param>
		/// <exception cref="T:System.ArgumentException">Объект <paramref name="subtype" /> был <see langword="null" /> или содержит только пробелы.</exception>
		// Token: 0x0600017B RID: 379 RVA: 0x00006020 File Offset: 0x00004220
		public MultipartContent(string subtype) : this(subtype, Guid.NewGuid().ToString("D", CultureInfo.InvariantCulture))
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Http.MultipartContent" />.</summary>
		/// <param name="subtype">Подтип многокомпонентного контента.</param>
		/// <param name="boundary">Строка границ для многокомпонентного контента.</param>
		/// <exception cref="T:System.ArgumentException">Объект <paramref name="subtype" /> являлся <see langword="null" /> или пустой строкой.  
		/// Объект  <paramref name="boundary" /> являлся <see langword="null" /> или содержит только пробелы.  
		///
		/// или - 
		/// <paramref name="boundary" /> заканчивается пробелом.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина <paramref name="boundary" /> больше 70 символов.</exception>
		// Token: 0x0600017C RID: 380 RVA: 0x0000604C File Offset: 0x0000424C
		public MultipartContent(string subtype, string boundary)
		{
			if (string.IsNullOrWhiteSpace(subtype))
			{
				throw new ArgumentException("boundary");
			}
			if (string.IsNullOrWhiteSpace(boundary))
			{
				throw new ArgumentException("boundary");
			}
			if (boundary.Length > 70)
			{
				throw new ArgumentOutOfRangeException("boundary");
			}
			if (boundary.Last<char>() == ' ' || !MultipartContent.IsValidRFC2049(boundary))
			{
				throw new ArgumentException("boundary");
			}
			this.boundary = boundary;
			this.nested_content = new List<HttpContent>(2);
			base.Headers.ContentType = new MediaTypeHeaderValue("multipart/" + subtype)
			{
				Parameters = 
				{
					new NameValueHeaderValue("boundary", "\"" + boundary + "\"")
				}
			};
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000610C File Offset: 0x0000430C
		private static bool IsValidRFC2049(string s)
		{
			foreach (char c in s)
			{
				if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && (c < '0' || c > '9'))
				{
					if (c <= ':')
					{
						switch (c)
						{
						case '\'':
						case '(':
						case ')':
						case '+':
						case ',':
						case '-':
						case '.':
						case '/':
							goto IL_71;
						case '*':
							break;
						default:
							if (c == ':')
							{
								goto IL_71;
							}
							break;
						}
					}
					else if (c == '=' || c == '?')
					{
						goto IL_71;
					}
					return false;
				}
				IL_71:;
			}
			return true;
		}

		/// <summary>Добавить многокомпонентное содержимое HTTP в коллекцию объектов <see cref="T:System.Net.Http.HttpContent" />, которые сериализуются используя спецификацию типа содержимого multipart/*.</summary>
		/// <param name="content">HTTP-содержимое, добавляемое в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Запрос <paramref name="content" /> имел значение <see langword="null" />.</exception>
		// Token: 0x0600017E RID: 382 RVA: 0x00006198 File Offset: 0x00004398
		public virtual void Add(HttpContent content)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			if (this.nested_content == null)
			{
				this.nested_content = new List<HttpContent>();
			}
			this.nested_content.Add(content);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Http.MultipartContent" />, и опционально удаляет управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> для освобождения управляемых и неуправляемых ресурсов; значение <see langword="false" /> для освобождения только неуправляемых ресурсов.</param>
		// Token: 0x0600017F RID: 383 RVA: 0x000061C8 File Offset: 0x000043C8
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				foreach (HttpContent httpContent in this.nested_content)
				{
					httpContent.Dispose();
				}
				this.nested_content = null;
			}
			base.Dispose(disposing);
		}

		/// <summary>Сериализация многокомпонентного HTTP-содержимого в поток в качестве асинхронной операции.</summary>
		/// <param name="stream">Целевой поток.</param>
		/// <param name="context">Сведения о транспорте (например, маркер привязки каналов). Этот параметр может иметь значение <see langword="null" />.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x06000180 RID: 384 RVA: 0x0000622C File Offset: 0x0000442C
		protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
		{
			MultipartContent.<SerializeToStreamAsync>d__8 <SerializeToStreamAsync>d__;
			<SerializeToStreamAsync>d__.<>4__this = this;
			<SerializeToStreamAsync>d__.stream = stream;
			<SerializeToStreamAsync>d__.context = context;
			<SerializeToStreamAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SerializeToStreamAsync>d__.<>1__state = -1;
			<SerializeToStreamAsync>d__.<>t__builder.Start<MultipartContent.<SerializeToStreamAsync>d__8>(ref <SerializeToStreamAsync>d__);
			return <SerializeToStreamAsync>d__.<>t__builder.Task;
		}

		/// <summary>Определяет, имеет ли составное содержимое HTTP допустимую длину в байтах.</summary>
		/// <param name="length">Длина содержимого HTTP в байтах.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="length" /> — допустимая длина. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000181 RID: 385 RVA: 0x00006280 File Offset: 0x00004480
		protected internal override bool TryComputeLength(out long length)
		{
			length = (long)(12 + 2 * this.boundary.Length);
			for (int i = 0; i < this.nested_content.Count; i++)
			{
				HttpContent httpContent = this.nested_content[i];
				foreach (KeyValuePair<string, IEnumerable<string>> keyValuePair in httpContent.Headers)
				{
					length += (long)keyValuePair.Key.Length;
					length += 4L;
					foreach (string text in keyValuePair.Value)
					{
						length += (long)text.Length;
					}
				}
				long num;
				if (!httpContent.TryComputeLength(out num))
				{
					return false;
				}
				length += 2L;
				length += num;
				if (i != this.nested_content.Count - 1)
				{
					length += 6L;
					length += (long)this.boundary.Length;
				}
			}
			return true;
		}

		/// <summary>Возвращает перечислитель, который выполняет итерацию по коллекции объектов <see cref="T:System.Net.Http.HttpContent" />, сериализируемых с использованием спецификации типа содержимого multipart/*.</summary>
		/// <returns>Объект, который можно использовать для перечисления элементов коллекции.</returns>
		// Token: 0x06000182 RID: 386 RVA: 0x000063A8 File Offset: 0x000045A8
		public IEnumerator<HttpContent> GetEnumerator()
		{
			return this.nested_content.GetEnumerator();
		}

		/// <summary>Явная реализация метода <see cref="M:System.Net.Http.MultipartContent.GetEnumerator" />.</summary>
		/// <returns>Объект, который можно использовать для перечисления элементов коллекции.</returns>
		// Token: 0x06000183 RID: 387 RVA: 0x000063A8 File Offset: 0x000045A8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.nested_content.GetEnumerator();
		}

		// Token: 0x040000C9 RID: 201
		private List<HttpContent> nested_content;

		// Token: 0x040000CA RID: 202
		private readonly string boundary;
	}
}
