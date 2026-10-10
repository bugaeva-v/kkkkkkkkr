using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Предоставляет данные для известного, но без ссылки, объекта, обнаруженного в кодированном SOAP потоке XML во время десериализации.
	///       </summary>
	// Token: 0x02000313 RID: 787
	public class UnreferencedObjectEventArgs : EventArgs
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.UnreferencedObjectEventArgs" />.
		///       </summary>
		/// <param name="o">
		///           Объект без ссылки.
		///         </param>
		/// <param name="id">
		///           Уникальная строка, используемая для идентификации объекта без ссылки.
		///         </param>
		// Token: 0x060020A9 RID: 8361 RVA: 0x000D16C8 File Offset: 0x000CF8C8
		public UnreferencedObjectEventArgs(object o, string id)
		{
			this.o = o;
			this.id = id;
		}

		/// <summary>
		///         Получает десериализованный, но не использованный объект.
		///       </summary>
		/// <returns>
		///         Десериализованный, но не использованный объект.
		///       </returns>
		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x000D16DE File Offset: 0x000CF8DE
		public object UnreferencedObject
		{
			get
			{
				return this.o;
			}
		}

		/// <summary>
		///         Возвращает идентификатор объекта.
		///       </summary>
		/// <returns>
		///         Идентификатор объекта.
		///       </returns>
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x000D16E6 File Offset: 0x000CF8E6
		public string UnreferencedId
		{
			get
			{
				return this.id;
			}
		}

		// Token: 0x04001B3D RID: 6973
		private object o;

		// Token: 0x04001B3E RID: 6974
		private string id;
	}
}
