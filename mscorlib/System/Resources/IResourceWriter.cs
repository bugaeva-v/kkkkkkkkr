using System;

namespace System.Resources
{
	/// <summary>Предоставляет базовые функциональные возможности для записи ресурсов в выходной файл или поток.</summary>
	// Token: 0x02000863 RID: 2147
	public interface IResourceWriter : IDisposable
	{
		/// <summary>Добавляет именованный ресурс типа <see cref="T:System.String" /> в список ресурсов для записи.</summary>
		/// <param name="name">Имя ресурса.</param>
		/// <param name="value">Значение ресурса.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600475B RID: 18267
		void AddResource(string name, string value);

		/// <summary>Добавляет именованный ресурс типа <see cref="T:System.Object" /> в список ресурсов для записи.</summary>
		/// <param name="name">Имя ресурса.</param>
		/// <param name="value">Значение ресурса.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600475C RID: 18268
		void AddResource(string name, object value);

		/// <summary>Добавляет массив 8-разрядных целых чисел без знака в качестве именованного ресурса в список ресурсов для записи.</summary>
		/// <param name="name">Имя ресурса.</param>
		/// <param name="value">Значение ресурса, представленное массивом 8-разрядных целых чисел без знака.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600475D RID: 18269
		void AddResource(string name, byte[] value);

		/// <summary>Закрывает основной файл или поток ресурсов, убедившись в том, что все данные записаны в файл.</summary>
		// Token: 0x0600475E RID: 18270
		void Close();

		/// <summary>Записывает все ресурсы, добавленные методом <see cref="M:System.Resources.IResourceWriter.AddResource(System.String,System.String)" />, в выходной файл или поток.</summary>
		// Token: 0x0600475F RID: 18271
		void Generate();
	}
}
