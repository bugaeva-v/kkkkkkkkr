using System;
using System.Threading;

namespace System
{
	/// <summary>Предоставляет отложенную непрямую ссылку на объект и связанные с ним метаданные для использования платформой Managed Extensibility Framework.</summary>
	/// <typeparam name="T">Тип объекта, на который указывает ссылка.</typeparam>
	/// <typeparam name="TMetadata">Тип метаданных.</typeparam>
	// Token: 0x0200001D RID: 29
	[Serializable]
	public class Lazy<T, TMetadata> : Lazy<T>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Lazy`2" /> с заданными метаданными, который использует заданную функцию для получения объекта, на который существует ссылка.</summary>
		/// <param name="valueFactory">Функция, возвращающая объект, на который существует ссылка.</param>
		/// <param name="metadata">Метаданные, связанные с объектом, на который существует ссылка.</param>
		// Token: 0x06000106 RID: 262 RVA: 0x00003EC6 File Offset: 0x000020C6
		public Lazy(Func<T> valueFactory, TMetadata metadata) : base(valueFactory)
		{
			this._metadata = metadata;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Lazy`2" /> с заданными метаданными.</summary>
		/// <param name="metadata">Метаданные, связанные с объектом, на который существует ссылка.</param>
		// Token: 0x06000107 RID: 263 RVA: 0x00003ED6 File Offset: 0x000020D6
		public Lazy(TMetadata metadata)
		{
			this._metadata = metadata;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Lazy`2" /> с заданными метаданными и потокобезопасным значением.</summary>
		/// <param name="metadata">Метаданные, связанные с объектом, на который существует ссылка.</param>
		/// <param name="isThreadSafe">Указывает, будет ли создаваемый объект <see cref="T:System.Lazy`2" /> потокобезопасным.</param>
		// Token: 0x06000108 RID: 264 RVA: 0x00003EE5 File Offset: 0x000020E5
		public Lazy(TMetadata metadata, bool isThreadSafe) : base(isThreadSafe)
		{
			this._metadata = metadata;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Lazy`2" /> с заданными метаданными и потокобезопасным значением, который использует заданную функцию для получения объекта, на который существует ссылка.</summary>
		/// <param name="valueFactory">Функция, возвращающая объект, на который существует ссылка.</param>
		/// <param name="metadata">Метаданные, связанные с объектом, на который существует ссылка.</param>
		/// <param name="isThreadSafe">Указывает, будет ли создаваемый объект <see cref="T:System.Lazy`2" /> потокобезопасным.</param>
		// Token: 0x06000109 RID: 265 RVA: 0x00003EF5 File Offset: 0x000020F5
		public Lazy(Func<T> valueFactory, TMetadata metadata, bool isThreadSafe) : base(valueFactory, isThreadSafe)
		{
			this._metadata = metadata;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Lazy`2" /> с заданными метаданными и режимом синхронизации потоков.</summary>
		/// <param name="metadata">Метаданные, связанные с объектом, на который существует ссылка.</param>
		/// <param name="mode">Режим синхронизации потоков.</param>
		// Token: 0x0600010A RID: 266 RVA: 0x00003F06 File Offset: 0x00002106
		public Lazy(TMetadata metadata, LazyThreadSafetyMode mode) : base(mode)
		{
			this._metadata = metadata;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Lazy`2" /> с заданными метаданными и режимом синхронизации потоков, который использует заданную функцию для получения объекта, на который существует ссылка.</summary>
		/// <param name="valueFactory">Функция, возвращающая объект, на который существует ссылка.</param>
		/// <param name="metadata">Метаданные, связанные с объектом, на который существует ссылка.</param>
		/// <param name="mode">Режим синхронизации потоков</param>
		// Token: 0x0600010B RID: 267 RVA: 0x00003F16 File Offset: 0x00002116
		public Lazy(Func<T> valueFactory, TMetadata metadata, LazyThreadSafetyMode mode) : base(valueFactory, mode)
		{
			this._metadata = metadata;
		}

		/// <summary>Получает метаданные, связанные с объектом, на который существует ссылка.</summary>
		/// <returns>Метаданные, связанные с объектом, на который существует ссылка.</returns>
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00003F27 File Offset: 0x00002127
		public TMetadata Metadata
		{
			get
			{
				return this._metadata;
			}
		}

		// Token: 0x04000067 RID: 103
		private TMetadata _metadata;
	}
}
