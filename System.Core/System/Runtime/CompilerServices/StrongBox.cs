using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>
	///         Содержит ссылку на значение.
	///       </summary>
	/// <typeparam name="T">
	///           Тип значения, на которое ссылается <see cref="T:System.Runtime.CompilerServices.StrongBox`1" />.
	///         </typeparam>
	// Token: 0x020002EB RID: 747
	public class StrongBox<T> : IStrongBox
	{
		/// <summary>
		///         Инициализирует новый StrongBox которой могут получать значение при ссылочном вызове.
		///       </summary>
		// Token: 0x060016AF RID: 5807 RVA: 0x00002162 File Offset: 0x00000362
		public StrongBox()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Runtime.CompilerServices.StrongBox`1" /> используя указанное значение.
		///       </summary>
		/// <param name="value">
		///           Значение, которое <see cref="T:System.Runtime.CompilerServices.StrongBox`1" /> будет ссылаться.
		///         </param>
		// Token: 0x060016B0 RID: 5808 RVA: 0x0004C7DB File Offset: 0x0004A9DB
		public StrongBox(T value)
		{
			this.Value = value;
		}

		/// <summary>
		///         Возвращает или задает значение, которое <see cref="T:System.Runtime.CompilerServices.StrongBox`1" /> ссылки.
		///       </summary>
		/// <returns>
		///         Значение, <see cref="T:System.Runtime.CompilerServices.StrongBox`1" /> ссылки.
		///       </returns>
		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x0004C7EA File Offset: 0x0004A9EA
		// (set) Token: 0x060016B2 RID: 5810 RVA: 0x0004C7F7 File Offset: 0x0004A9F7
		object IStrongBox.Value
		{
			get
			{
				return this.Value;
			}
			set
			{
				this.Value = (T)((object)value);
			}
		}

		/// <summary>
		///         Представляет значение, <see cref="T:System.Runtime.CompilerServices.StrongBox`1" /> ссылки.
		///       </summary>
		// Token: 0x04000B63 RID: 2915
		public T Value;
	}
}
