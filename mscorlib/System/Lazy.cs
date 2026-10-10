using System;
using System.Diagnostics;
using System.Threading;

namespace System
{
	/// <summary>Обеспечивает поддержку отложенной инициализации.</summary>
	/// <typeparam name="T">Тип объекта с отложенной инициализацией.</typeparam>
	// Token: 0x02000151 RID: 337
	[DebuggerTypeProxy(typeof(LazyDebugView<>))]
	[DebuggerDisplay("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
	[Serializable]
	public class Lazy<T>
	{
		// Token: 0x06000CA5 RID: 3237 RVA: 0x00032A7D File Offset: 0x00030C7D
		private static T CreateViaDefaultConstructor()
		{
			return (T)((object)LazyHelper.CreateViaDefaultConstructor(typeof(T)));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Lazy`1" />. При отложенной инициализации используется конструктор по умолчанию для целевого типа.</summary>
		// Token: 0x06000CA6 RID: 3238 RVA: 0x00032A93 File Offset: 0x00030C93
		public Lazy() : this(null, LazyThreadSafetyMode.ExecutionAndPublication, true)
		{
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00032A9E File Offset: 0x00030C9E
		public Lazy(T value)
		{
			this._value = value;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Lazy`1" />. Когда происходит отложенная инициализация, используется заданная функция инициализации.</summary>
		/// <param name="valueFactory">Делегат, вызываемый для создания значения с отложенной инициализацией при необходимости.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="valueFactory" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000CA8 RID: 3240 RVA: 0x00032AAD File Offset: 0x00030CAD
		public Lazy(Func<T> valueFactory) : this(valueFactory, LazyThreadSafetyMode.ExecutionAndPublication, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Lazy`1" />. При отложенной инициализации используется конструктор по умолчанию целевого типа и указанный режим инициализации.</summary>
		/// <param name="isThreadSafe">Значение <see langword="true" />, чтобы сделать этот экземпляр доступным для одновременного использования несколькими потоками; значение <see langword="false" />, чтобы экземпляр мог использоваться только одним потоком.</param>
		// Token: 0x06000CA9 RID: 3241 RVA: 0x00032AB8 File Offset: 0x00030CB8
		public Lazy(bool isThreadSafe) : this(null, LazyHelper.GetModeFromIsThreadSafe(isThreadSafe), true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Lazy`1" />, использующий конструктор по умолчанию <paramref name="T" /> и заданный потокобезопасный режим.</summary>
		/// <param name="mode">Одно из значений перечисления, задающее потокобезопасный режим.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="mode" /> содержит недопустимое значение.</exception>
		// Token: 0x06000CAA RID: 3242 RVA: 0x00032AC8 File Offset: 0x00030CC8
		public Lazy(LazyThreadSafetyMode mode) : this(null, mode, true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Lazy`1" />. Когда происходит отложенная инициализация, используются заданные функция инициализации и режим инициализации.</summary>
		/// <param name="valueFactory">Делегат, вызываемый для создания значения с отложенной инициализацией при необходимости.</param>
		/// <param name="isThreadSafe">Значение <see langword="true" />, чтобы сделать этот экземпляр доступным для одновременного использования несколькими потоками; значение <see langword="false" />, чтобы этот экземпляр мог использоваться только одним потоком в каждый момент времени.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="valueFactory" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000CAB RID: 3243 RVA: 0x00032AD3 File Offset: 0x00030CD3
		public Lazy(Func<T> valueFactory, bool isThreadSafe) : this(valueFactory, LazyHelper.GetModeFromIsThreadSafe(isThreadSafe), false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Lazy`1" />, который использует заданную функцию инициализации и потокобезопасный режим.</summary>
		/// <param name="valueFactory">Делегат, вызываемый для создания значения с отложенной инициализацией при необходимости.</param>
		/// <param name="mode">Одно из значений перечисления, задающее потокобезопасный режим.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="mode" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="valueFactory" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000CAC RID: 3244 RVA: 0x00032AE3 File Offset: 0x00030CE3
		public Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode) : this(valueFactory, mode, false)
		{
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00032AEE File Offset: 0x00030CEE
		private Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode, bool useDefaultConstructor)
		{
			if (valueFactory == null && !useDefaultConstructor)
			{
				throw new ArgumentNullException("valueFactory");
			}
			this._factory = valueFactory;
			this._state = LazyHelper.Create(mode, useDefaultConstructor);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00032B1D File Offset: 0x00030D1D
		private void ViaConstructor()
		{
			this._value = Lazy<T>.CreateViaDefaultConstructor();
			this._state = null;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00032B34 File Offset: 0x00030D34
		private void ViaFactory(LazyThreadSafetyMode mode)
		{
			try
			{
				Func<T> factory = this._factory;
				if (factory == null)
				{
					throw new InvalidOperationException("ValueFactory attempted to access the Value property of this instance.");
				}
				this._factory = null;
				this._value = factory();
				this._state = null;
			}
			catch (Exception exception)
			{
				this._state = new LazyHelper(mode, exception);
				throw;
			}
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00032B98 File Offset: 0x00030D98
		private void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor)
		{
			lock (executionAndPublication)
			{
				if (this._state == executionAndPublication)
				{
					if (useDefaultConstructor)
					{
						this.ViaConstructor();
					}
					else
					{
						this.ViaFactory(LazyThreadSafetyMode.ExecutionAndPublication);
					}
				}
			}
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00032BEC File Offset: 0x00030DEC
		private void PublicationOnly(LazyHelper publicationOnly, T possibleValue)
		{
			if (Interlocked.CompareExchange<LazyHelper>(ref this._state, LazyHelper.PublicationOnlyWaitForOtherThreadToPublish, publicationOnly) == publicationOnly)
			{
				this._factory = null;
				this._value = possibleValue;
				this._state = null;
			}
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00032C19 File Offset: 0x00030E19
		private void PublicationOnlyViaConstructor(LazyHelper initializer)
		{
			this.PublicationOnly(initializer, Lazy<T>.CreateViaDefaultConstructor());
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00032C28 File Offset: 0x00030E28
		private void PublicationOnlyViaFactory(LazyHelper initializer)
		{
			Func<T> factory = this._factory;
			if (factory == null)
			{
				this.PublicationOnlyWaitForOtherThreadToPublish();
				return;
			}
			this.PublicationOnly(initializer, factory());
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00032C54 File Offset: 0x00030E54
		private void PublicationOnlyWaitForOtherThreadToPublish()
		{
			SpinWait spinWait = default(SpinWait);
			while (this._state != null)
			{
				spinWait.SpinOnce();
			}
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00032C7C File Offset: 0x00030E7C
		private T CreateValue()
		{
			LazyHelper state = this._state;
			if (state != null)
			{
				switch (state.State)
				{
				case LazyState.NoneViaConstructor:
					this.ViaConstructor();
					goto IL_84;
				case LazyState.NoneViaFactory:
					this.ViaFactory(LazyThreadSafetyMode.None);
					goto IL_84;
				case LazyState.PublicationOnlyViaConstructor:
					this.PublicationOnlyViaConstructor(state);
					goto IL_84;
				case LazyState.PublicationOnlyViaFactory:
					this.PublicationOnlyViaFactory(state);
					goto IL_84;
				case LazyState.PublicationOnlyWait:
					this.PublicationOnlyWaitForOtherThreadToPublish();
					goto IL_84;
				case LazyState.ExecutionAndPublicationViaConstructor:
					this.ExecutionAndPublication(state, true);
					goto IL_84;
				case LazyState.ExecutionAndPublicationViaFactory:
					this.ExecutionAndPublication(state, false);
					goto IL_84;
				}
				state.ThrowException();
			}
			IL_84:
			return this.Value;
		}

		/// <summary>Создает и возвращает строковое представление свойства <see cref="P:System.Lazy`1.Value" /> для данного экземпляра.</summary>
		/// <returns>Результат вызова метода <see cref="M:System.Object.ToString" /> для свойства <see cref="P:System.Lazy`1.Value" /> данного экземпляра, если значение создано (то есть если свойство <see cref="P:System.Lazy`1.IsValueCreated" /> возвращает <see langword="true" />). В противном случае строка, указывающая, что значение не создано.</returns>
		/// <exception cref="T:System.NullReferenceException">Значение свойства <see cref="P:System.Lazy`1.Value" /> — <see langword="null" />.</exception>
		// Token: 0x06000CB6 RID: 3254 RVA: 0x00032D14 File Offset: 0x00030F14
		public override string ToString()
		{
			if (!this.IsValueCreated)
			{
				return "Value is not created.";
			}
			T value = this.Value;
			return value.ToString();
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00032D44 File Offset: 0x00030F44
		internal T ValueForDebugDisplay
		{
			get
			{
				if (!this.IsValueCreated)
				{
					return default(T);
				}
				return this._value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00032D69 File Offset: 0x00030F69
		internal LazyThreadSafetyMode? Mode
		{
			get
			{
				return LazyHelper.GetMode(this._state);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00032D78 File Offset: 0x00030F78
		internal bool IsValueFaulted
		{
			get
			{
				return LazyHelper.GetIsValueFaulted(this._state);
			}
		}

		/// <summary>Получает значение, которое показывает, создано ли значение для этого экземпляра <see cref="T:System.Lazy`1" />.</summary>
		/// <returns>Значение <see langword="true" />, если значение создано для этого экземпляра <see cref="T:System.Lazy`1" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00032D87 File Offset: 0x00030F87
		public bool IsValueCreated
		{
			get
			{
				return this._state == null;
			}
		}

		/// <summary>Получает значение с отложенной инициализацией текущего экземпляра <see cref="T:System.Lazy`1" />.</summary>
		/// <returns>Значение с отложенной инициализацией текущего экземпляра <see cref="T:System.Lazy`1" />.</returns>
		/// <exception cref="T:System.MemberAccessException">Экземпляр <see cref="T:System.Lazy`1" /> инициализируется для использования конструктора по умолчанию, имеющего тип с отложенной инициализацией, а разрешения для доступа к этому конструктору отсутствуют.</exception>
		/// <exception cref="T:System.MissingMemberException">Экземпляр <see cref="T:System.Lazy`1" /> инициализируется для использования конструктора по умолчанию, имеющего тип с отложенной инициализацией, а этот тип не имеет общего конструктора без параметров.</exception>
		/// <exception cref="T:System.InvalidOperationException">Функция инициализации пытается получить доступ к <see cref="P:System.Lazy`1.Value" /> в данном экземпляре.</exception>
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x00032D94 File Offset: 0x00030F94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public T Value
		{
			get
			{
				if (this._state != null)
				{
					return this.CreateValue();
				}
				return this._value;
			}
		}

		// Token: 0x0400126D RID: 4717
		private volatile LazyHelper _state;

		// Token: 0x0400126E RID: 4718
		private Func<T> _factory;

		// Token: 0x0400126F RID: 4719
		private T _value;
	}
}
