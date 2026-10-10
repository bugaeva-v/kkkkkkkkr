using System;
using System.Collections;
using System.IO;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Предоставляет базовый класс для хранения данных сериализации компонента <see cref="T:System.ComponentModel.Design.Serialization.ComponentSerializationService" />.</summary>
	// Token: 0x02000493 RID: 1171
	public abstract class SerializationStore : IDisposable
	{
		/// <summary>Возвращает коллекцию ошибок, которые возникли в процессе сериализации или десериализации.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, содержащий ошибки, которые возникли в процессе сериализации или десериализации.</returns>
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600255E RID: 9566
		public abstract ICollection Errors { get; }

		/// <summary>Закрывает хранилище сериализации.</summary>
		// Token: 0x0600255F RID: 9567
		public abstract void Close();

		/// <summary>Сохраняет хранилище в заданный поток.</summary>
		/// <param name="stream">Поток, для которого необходимо сериализовать хранилище.</param>
		// Token: 0x06002560 RID: 9568
		public abstract void Save(Stream stream);

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />.</summary>
		// Token: 0x06002561 RID: 9569 RVA: 0x00083377 File Offset: 0x00081577
		void IDisposable.Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.ComponentModel.Design.Serialization.SerializationStore" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002562 RID: 9570 RVA: 0x00083380 File Offset: 0x00081580
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Close();
			}
		}
	}
}
