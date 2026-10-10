using System;
using System.Net.Http.Headers;

namespace System.Net.Http
{
	/// <summary>Предоставляет контейнер для содержимого, закодированного с помощью типа MIME multipart/form-data.</summary>
	// Token: 0x02000030 RID: 48
	public class MultipartFormDataContent : MultipartContent
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Http.MultipartFormDataContent" />.</summary>
		// Token: 0x06000186 RID: 390 RVA: 0x00006846 File Offset: 0x00004A46
		public MultipartFormDataContent() : base("form-data")
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Http.MultipartFormDataContent" />.</summary>
		/// <param name="boundary">Строка границ для многокомпонентного содержимого данных форм.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="boundary" />имел значение <see langword="null" /> или содержит только пробелы.  
		///
		/// или - 
		/// Параметр <paramref name="boundary" /> заканчивается символом пробела.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Длина параметра <paramref name="boundary" /> больше 70.</exception>
		// Token: 0x06000187 RID: 391 RVA: 0x00006853 File Offset: 0x00004A53
		public MultipartFormDataContent(string boundary) : base("form-data", boundary)
		{
		}

		/// <summary>Добавление содержимого HTTP в коллекцию объектов <see cref="T:System.Net.Http.HttpContent" />, которые сериализуются в тип MIME "multipart/form-data".</summary>
		/// <param name="content">HTTP-содержимое, добавляемое в коллекцию.</param>
		/// <exception cref="T:System.ArgumentNullException">Запрос <paramref name="content" /> имел значение <see langword="null" />.</exception>
		// Token: 0x06000188 RID: 392 RVA: 0x00006861 File Offset: 0x00004A61
		public override void Add(HttpContent content)
		{
			base.Add(content);
			this.AddContentDisposition(content, null, null);
		}

		/// <summary>Добавление содержимого HTTP в коллекцию объектов <see cref="T:System.Net.Http.HttpContent" />, которые сериализуются в тип MIME "multipart/form-data".</summary>
		/// <param name="content">HTTP-содержимое, добавляемое в коллекцию.</param>
		/// <param name="name">Имя добавляемого содержимого HTTP.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" />имел значение <see langword="null" /> или содержит только пробелы.</exception>
		/// <exception cref="T:System.ArgumentNullException">Запрос <paramref name="content" /> имел значение <see langword="null" />.</exception>
		// Token: 0x06000189 RID: 393 RVA: 0x00006873 File Offset: 0x00004A73
		public void Add(HttpContent content, string name)
		{
			base.Add(content);
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException("name");
			}
			this.AddContentDisposition(content, name, null);
		}

		/// <summary>Добавление содержимого HTTP в коллекцию объектов <see cref="T:System.Net.Http.HttpContent" />, которые сериализуются в тип MIME "multipart/form-data".</summary>
		/// <param name="content">HTTP-содержимое, добавляемое в коллекцию.</param>
		/// <param name="name">Имя добавляемого содержимого HTTP.</param>
		/// <param name="fileName">Имя файла для HTTP-содержимого, которое требуется добавить в коллекцию.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" />имел значение <see langword="null" /> или содержит только пробелы.  
		///
		/// или - 
		/// Параметр <paramref name="fileName" />имел значение <see langword="null" /> или содержит только пробелы.</exception>
		/// <exception cref="T:System.ArgumentNullException">Запрос <paramref name="content" /> имел значение <see langword="null" />.</exception>
		// Token: 0x0600018A RID: 394 RVA: 0x00006898 File Offset: 0x00004A98
		public void Add(HttpContent content, string name, string fileName)
		{
			base.Add(content);
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException("name");
			}
			if (string.IsNullOrWhiteSpace(fileName))
			{
				throw new ArgumentException("fileName");
			}
			this.AddContentDisposition(content, name, fileName);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000068D0 File Offset: 0x00004AD0
		private void AddContentDisposition(HttpContent content, string name, string fileName)
		{
			HttpContentHeaders headers = content.Headers;
			if (headers.ContentDisposition != null)
			{
				return;
			}
			headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
			{
				Name = name,
				FileName = fileName,
				FileNameStar = fileName
			};
		}
	}
}
