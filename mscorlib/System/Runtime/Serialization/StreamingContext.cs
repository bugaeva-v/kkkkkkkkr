using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Описывает источник и назначение заданного потока сериализации и обеспечивает дополнительный контекст, определяемый вызывающим объектом.</summary>
	// Token: 0x02000673 RID: 1651
	[ComVisible(true)]
	[Serializable]
	public readonly struct StreamingContext
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.StreamingContext" /> с заданным состоянием контекста.</summary>
		/// <param name="state">Битовая комбинация значений <see cref="T:System.Runtime.Serialization.StreamingContextStates" />, которые задают контекст источника или назначения для этого <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		// Token: 0x06003DB5 RID: 15797 RVA: 0x000D566E File Offset: 0x000D386E
		public StreamingContext(StreamingContextStates state)
		{
			this = new StreamingContext(state, null);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.StreamingContext" /> с заданным состоянием контекста и некоторыми дополнительными сведениями.</summary>
		/// <param name="state">Битовая комбинация значений <see cref="T:System.Runtime.Serialization.StreamingContextStates" />, которые задают контекст источника или назначения для этого <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		/// <param name="additional">Любые дополнительные сведения, которые необходимо связать с <see cref="T:System.Runtime.Serialization.StreamingContext" />. Эти сведения будут доступны любому объекту, реализующему <see cref="T:System.Runtime.Serialization.ISerializable" /> или любой суррогат сериализации. Обычно пользователи не нуждаются в установке этого параметра.</param>
		// Token: 0x06003DB6 RID: 15798 RVA: 0x000D5678 File Offset: 0x000D3878
		public StreamingContext(StreamingContextStates state, object additional)
		{
			this.m_state = state;
			this.m_additionalContext = additional;
		}

		/// <summary>Возвращает контекст, заданный как часть дополнительного контекста.</summary>
		/// <returns>Контекст, заданный как часть дополнительного контекста.</returns>
		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x000D5688 File Offset: 0x000D3888
		public object Context
		{
			get
			{
				return this.m_additionalContext;
			}
		}

		/// <summary>Определяет, содержат ли два экземпляра <see cref="T:System.Runtime.Serialization.StreamingContext" /> одинаковые значения.</summary>
		/// <param name="obj">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если заданный объект является экземпляром <see cref="T:System.Runtime.Serialization.StreamingContext" /> и равен значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003DB8 RID: 15800 RVA: 0x000D5690 File Offset: 0x000D3890
		public override bool Equals(object obj)
		{
			return obj is StreamingContext && (((StreamingContext)obj).m_additionalContext == this.m_additionalContext && ((StreamingContext)obj).m_state == this.m_state);
		}

		/// <summary>Возвращает хэш-код этого объекта.</summary>
		/// <returns>Значение <see cref="T:System.Runtime.Serialization.StreamingContextStates" />, которое содержит источник или назначение для <see cref="T:System.Runtime.Serialization.StreamingContext" />.</returns>
		// Token: 0x06003DB9 RID: 15801 RVA: 0x000D56C5 File Offset: 0x000D38C5
		public override int GetHashCode()
		{
			return (int)this.m_state;
		}

		/// <summary>Возвращает источник или назначение переданных данных.</summary>
		/// <returns>При сериализации назначение переданных данных. При десериализации источник данных.</returns>
		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06003DBA RID: 15802 RVA: 0x000D56C5 File Offset: 0x000D38C5
		public StreamingContextStates State
		{
			get
			{
				return this.m_state;
			}
		}

		// Token: 0x04002795 RID: 10133
		internal readonly object m_additionalContext;

		// Token: 0x04002796 RID: 10134
		internal readonly StreamingContextStates m_state;
	}
}
