using System;
using System.Collections.Generic;
using Unity;

namespace System.Runtime.Serialization
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Exception.SerializeObjectState" />.</summary>
	// Token: 0x02000669 RID: 1641
	public sealed class SafeSerializationEventArgs : EventArgs
	{
		// Token: 0x06003D54 RID: 15700 RVA: 0x000D4716 File Offset: 0x000D2916
		internal SafeSerializationEventArgs(StreamingContext streamingContext)
		{
			this.m_serializedStates = new List<object>();
			base..ctor();
			this.m_streamingContext = streamingContext;
		}

		/// <summary>Сохраняет состояние исключения.</summary>
		/// <param name="serializedState">Объект состояния, сериализуемый с данным экземпляром.</param>
		// Token: 0x06003D55 RID: 15701 RVA: 0x000D4730 File Offset: 0x000D2930
		public void AddSerializedState(ISafeSerializationData serializedState)
		{
			if (serializedState == null)
			{
				throw new ArgumentNullException("serializedState");
			}
			if (!serializedState.GetType().IsSerializable)
			{
				throw new ArgumentException(Environment.GetResourceString("Type '{0}' in Assembly '{1}' is not marked as serializable.", new object[]
				{
					serializedState.GetType(),
					serializedState.GetType().Assembly.FullName
				}));
			}
			this.m_serializedStates.Add(serializedState);
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06003D56 RID: 15702 RVA: 0x000D4796 File Offset: 0x000D2996
		internal IList<object> SerializedStates
		{
			get
			{
				return this.m_serializedStates;
			}
		}

		/// <summary>Получает или задает Объект, описывающий источник и назначение сериализованного потока.</summary>
		/// <returns>Объект, описывающий источник и назначение сериализованного потока.</returns>
		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06003D57 RID: 15703 RVA: 0x000D479E File Offset: 0x000D299E
		public StreamingContext StreamingContext
		{
			get
			{
				return this.m_streamingContext;
			}
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x000173AD File Offset: 0x000155AD
		internal SafeSerializationEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04002779 RID: 10105
		private StreamingContext m_streamingContext;

		// Token: 0x0400277A RID: 10106
		private List<object> m_serializedStates;
	}
}
