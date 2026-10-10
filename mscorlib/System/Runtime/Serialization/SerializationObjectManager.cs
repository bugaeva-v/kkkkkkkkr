using System;
using System.Collections.Generic;

namespace System.Runtime.Serialization
{
	/// <summary>Управляет процессами сериализации во время исполнения. Этот класс не наследуется.</summary>
	// Token: 0x02000659 RID: 1625
	public sealed class SerializationObjectManager
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.SerializationObjectManager" />.</summary>
		/// <param name="context">Экземпляр класса <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащего сведения о текущей операции сериализации.</param>
		// Token: 0x06003CB4 RID: 15540 RVA: 0x000D1D20 File Offset: 0x000CFF20
		public SerializationObjectManager(StreamingContext context)
		{
			this._context = context;
			this._objectSeenTable = new Dictionary<object, object>();
		}

		/// <summary>Регистрирует объект, по которому будут созданы события.</summary>
		/// <param name="obj">Регистрируемый объект.</param>
		// Token: 0x06003CB5 RID: 15541 RVA: 0x000D1D3C File Offset: 0x000CFF3C
		public void RegisterObject(object obj)
		{
			SerializationEvents serializationEventsForType = SerializationEventsCache.GetSerializationEventsForType(obj.GetType());
			if (serializationEventsForType.HasOnSerializingEvents && this._objectSeenTable.TryAdd(obj, true))
			{
				serializationEventsForType.InvokeOnSerializing(obj, this._context);
				this.AddOnSerialized(obj);
			}
		}

		/// <summary>Вызывает событие обратного вызова OnSerializing, если тип объекта содержит его, и регистрирует объект для вызова события OnSerialized, если тип объекта содержит его.</summary>
		// Token: 0x06003CB6 RID: 15542 RVA: 0x000D1D85 File Offset: 0x000CFF85
		public void RaiseOnSerializedEvent()
		{
			SerializationEventHandler onSerializedHandler = this._onSerializedHandler;
			if (onSerializedHandler == null)
			{
				return;
			}
			onSerializedHandler(this._context);
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x000D1DA0 File Offset: 0x000CFFA0
		private void AddOnSerialized(object obj)
		{
			SerializationEvents serializationEventsForType = SerializationEventsCache.GetSerializationEventsForType(obj.GetType());
			this._onSerializedHandler = serializationEventsForType.AddOnSerialized(obj, this._onSerializedHandler);
		}

		// Token: 0x0400272B RID: 10027
		private readonly Dictionary<object, object> _objectSeenTable;

		// Token: 0x0400272C RID: 10028
		private readonly StreamingContext _context;

		// Token: 0x0400272D RID: 10029
		private SerializationEventHandler _onSerializedHandler;
	}
}
