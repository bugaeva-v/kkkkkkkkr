using System;

namespace System.ComponentModel.Composition
{
	/// <summary>Фабрика, которая создает новые экземпляры части, предоставляющей указанный экспорт с вложенными метаданными.</summary>
	/// <typeparam name="T">Тип создаваемой части.</typeparam>
	/// <typeparam name="TMetadata">Тип метаданных создаваемой части.</typeparam>
	// Token: 0x02000038 RID: 56
	public class ExportFactory<T, TMetadata> : ExportFactory<T>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ExportFactory`2" />.</summary>
		/// <param name="exportLifetimeContextCreator">Функция, возвращающая экспортированное значение, и действие <see cref="T:System.Action" />, выполняющее освобождение.</param>
		/// <param name="metadata">Метаданные для присоединения к создаваемой части.</param>
		// Token: 0x060001B6 RID: 438 RVA: 0x0000590A File Offset: 0x00003B0A
		public ExportFactory(Func<Tuple<T, Action>> exportLifetimeContextCreator, TMetadata metadata) : base(exportLifetimeContextCreator)
		{
			this._metadata = metadata;
		}

		/// <summary>Получает метаданные для присоединения к создаваемым частям.</summary>
		/// <returns>Объект метаданных, который будет присоединен к создаваемым частям.</returns>
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000591A File Offset: 0x00003B1A
		public TMetadata Metadata
		{
			get
			{
				return this._metadata;
			}
		}

		// Token: 0x040000B5 RID: 181
		private readonly TMetadata _metadata;
	}
}
