using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Internal;

namespace System.ComponentModel.Composition.Hosting
{
	/// <summary>Представляет отдельную операцию композиции для транзакционной композиции.</summary>
	// Token: 0x020000A3 RID: 163
	public class AtomicComposition : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.AtomicComposition" />.</summary>
		// Token: 0x06000456 RID: 1110 RVA: 0x0000C459 File Offset: 0x0000A659
		public AtomicComposition() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.AtomicComposition" /> заданным родительским объектом <see cref="T:System.ComponentModel.Composition.Hosting.AtomicComposition" />.</summary>
		/// <param name="outerAtomicComposition">Родительский объект данной операции композиции.</param>
		// Token: 0x06000457 RID: 1111 RVA: 0x0000C462 File Offset: 0x0000A662
		public AtomicComposition(AtomicComposition outerAtomicComposition)
		{
			if (outerAtomicComposition != null)
			{
				this._outerAtomicComposition = outerAtomicComposition;
				this._outerAtomicComposition.ContainsInnerAtomicComposition = true;
			}
		}

		/// <summary>Сохраняет пару "ключ-значение" в транзакции для отслеживания неопределенного состояния.</summary>
		/// <param name="key">Сохраняемый ключ.</param>
		/// <param name="value">Сохраняемое значение.</param>
		// Token: 0x06000458 RID: 1112 RVA: 0x0000C480 File Offset: 0x0000A680
		public void SetValue(object key, object value)
		{
			this.ThrowIfDisposed();
			this.ThrowIfCompleted();
			this.ThrowIfContainsInnerAtomicComposition();
			Requires.NotNull<object>(key, "key");
			this.SetValueInternal(key, value);
		}

		/// <summary>Получает значение, сохраненное методом <see cref="M:System.ComponentModel.Composition.Hosting.AtomicComposition.SetValue(System.Object,System.Object)" />.</summary>
		/// <param name="key">Ключ, из которого выполняется извлечение.</param>
		/// <param name="value">Извлекаемое значение.</param>
		/// <typeparam name="T">Тип извлекаемого значения.</typeparam>
		/// <returns>Значение <see langword="true" />, если значение было успешно извлечено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000459 RID: 1113 RVA: 0x0000C4A7 File Offset: 0x0000A6A7
		public bool TryGetValue<T>(object key, out T value)
		{
			return this.TryGetValue<T>(key, false, out value);
		}

		/// <summary>Получает значение, сохраненное методом <see cref="M:System.ComponentModel.Composition.Hosting.AtomicComposition.SetValue(System.Object,System.Object)" />, с возможностью не выполнять поиск в родительских транзакциях.</summary>
		/// <param name="key">Ключ, из которого выполняется извлечение.</param>
		/// <param name="localAtomicCompositionOnly">Значение <see langword="true" /> для исключения родительских транзакций; в противном случае — значение <see langword="false" />.</param>
		/// <param name="value">Извлекаемое значение.</param>
		/// <typeparam name="T">Тип извлекаемого значения.</typeparam>
		/// <returns>Значение <see langword="true" />, если значение было успешно извлечено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600045A RID: 1114 RVA: 0x0000C4B2 File Offset: 0x0000A6B2
		public bool TryGetValue<T>(object key, bool localAtomicCompositionOnly, out T value)
		{
			this.ThrowIfDisposed();
			this.ThrowIfCompleted();
			Requires.NotNull<object>(key, "key");
			return this.TryGetValueInternal<T>(key, localAtomicCompositionOnly, out value);
		}

		/// <summary>Добавляет действие, которое должно выполняться после успешного завершения общей операции композиции.</summary>
		/// <param name="completeAction">Выполняемое действие.</param>
		// Token: 0x0600045B RID: 1115 RVA: 0x0000C4D4 File Offset: 0x0000A6D4
		public void AddCompleteAction(Action completeAction)
		{
			this.ThrowIfDisposed();
			this.ThrowIfCompleted();
			this.ThrowIfContainsInnerAtomicComposition();
			Requires.NotNull<Action>(completeAction, "completeAction");
			if (this._completeActionList == null)
			{
				this._completeActionList = new List<Action>();
			}
			this._completeActionList.Add(completeAction);
		}

		/// <summary>Добавляет действие, которое должно выполняться в случае неудачного завершения общей операции композиции.</summary>
		/// <param name="revertAction">Выполняемое действие.</param>
		// Token: 0x0600045C RID: 1116 RVA: 0x0000C512 File Offset: 0x0000A712
		public void AddRevertAction(Action revertAction)
		{
			this.ThrowIfDisposed();
			this.ThrowIfCompleted();
			this.ThrowIfContainsInnerAtomicComposition();
			Requires.NotNull<Action>(revertAction, "revertAction");
			if (this._revertActionList == null)
			{
				this._revertActionList = new List<Action>();
			}
			this._revertActionList.Add(revertAction);
		}

		/// <summary>Помечает данную операцию композиции как завершенную.</summary>
		// Token: 0x0600045D RID: 1117 RVA: 0x0000C550 File Offset: 0x0000A750
		public void Complete()
		{
			this.ThrowIfDisposed();
			this.ThrowIfCompleted();
			if (this._outerAtomicComposition == null)
			{
				this.FinalComplete();
			}
			else
			{
				this.CopyComplete();
			}
			this._isCompleted = true;
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром объекта <see cref="T:System.ComponentModel.Composition.Hosting.AtomicComposition" /> и помечает данную операцию композиции как неудачно завершенную.</summary>
		// Token: 0x0600045E RID: 1118 RVA: 0x0000C57B File Offset: 0x0000A77B
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.ComponentModel.Composition.Hosting.AtomicComposition" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x0600045F RID: 1119 RVA: 0x0000C58C File Offset: 0x0000A78C
		protected virtual void Dispose(bool disposing)
		{
			this.ThrowIfDisposed();
			this._isDisposed = true;
			if (this._outerAtomicComposition != null)
			{
				this._outerAtomicComposition.ContainsInnerAtomicComposition = false;
			}
			if (!this._isCompleted && this._revertActionList != null)
			{
				for (int i = this._revertActionList.Count - 1; i >= 0; i--)
				{
					this._revertActionList[i]();
				}
				this._revertActionList = null;
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		private void FinalComplete()
		{
			if (this._completeActionList != null)
			{
				foreach (Action action in this._completeActionList)
				{
					action();
				}
				this._completeActionList = null;
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000C65C File Offset: 0x0000A85C
		private void CopyComplete()
		{
			Assumes.NotNull<AtomicComposition>(this._outerAtomicComposition);
			this._outerAtomicComposition.ContainsInnerAtomicComposition = false;
			if (this._completeActionList != null)
			{
				foreach (Action completeAction in this._completeActionList)
				{
					this._outerAtomicComposition.AddCompleteAction(completeAction);
				}
			}
			if (this._revertActionList != null)
			{
				foreach (Action revertAction in this._revertActionList)
				{
					this._outerAtomicComposition.AddRevertAction(revertAction);
				}
			}
			for (int i = 0; i < this._valueCount; i++)
			{
				this._outerAtomicComposition.SetValueInternal(this._values[i].Key, this._values[i].Value);
			}
		}

		// Token: 0x17000141 RID: 321
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x0000C760 File Offset: 0x0000A960
		private bool ContainsInnerAtomicComposition
		{
			set
			{
				if (value && this._containsInnerAtomicComposition)
				{
					throw new InvalidOperationException(Strings.AtomicComposition_AlreadyNested);
				}
				this._containsInnerAtomicComposition = value;
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000C780 File Offset: 0x0000A980
		private bool TryGetValueInternal<T>(object key, bool localAtomicCompositionOnly, out T value)
		{
			for (int i = 0; i < this._valueCount; i++)
			{
				if (this._values[i].Key == key)
				{
					value = (T)((object)this._values[i].Value);
					return true;
				}
			}
			if (!localAtomicCompositionOnly && this._outerAtomicComposition != null)
			{
				return this._outerAtomicComposition.TryGetValueInternal<T>(key, localAtomicCompositionOnly, out value);
			}
			value = default(T);
			return false;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		private void SetValueInternal(object key, object value)
		{
			for (int i = 0; i < this._valueCount; i++)
			{
				if (this._values[i].Key == key)
				{
					this._values[i] = new KeyValuePair<object, object>(key, value);
					return;
				}
			}
			if (this._values == null || this._valueCount == this._values.Length)
			{
				KeyValuePair<object, object>[] array = new KeyValuePair<object, object>[(this._valueCount == 0) ? 5 : (this._valueCount * 2)];
				if (this._values != null)
				{
					Array.Copy(this._values, array, this._valueCount);
				}
				this._values = array;
			}
			this._values[this._valueCount] = new KeyValuePair<object, object>(key, value);
			this._valueCount++;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0000C8B2 File Offset: 0x0000AAB2
		[DebuggerStepThrough]
		private void ThrowIfContainsInnerAtomicComposition()
		{
			if (this._containsInnerAtomicComposition)
			{
				throw new InvalidOperationException(Strings.AtomicComposition_PartOfAnotherAtomicComposition);
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000C8C7 File Offset: 0x0000AAC7
		[DebuggerStepThrough]
		private void ThrowIfCompleted()
		{
			if (this._isCompleted)
			{
				throw new InvalidOperationException(Strings.AtomicComposition_AlreadyCompleted);
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000C8DC File Offset: 0x0000AADC
		[DebuggerStepThrough]
		private void ThrowIfDisposed()
		{
			if (this._isDisposed)
			{
				throw ExceptionBuilder.CreateObjectDisposed(this);
			}
		}

		// Token: 0x040001B2 RID: 434
		private readonly AtomicComposition _outerAtomicComposition;

		// Token: 0x040001B3 RID: 435
		private KeyValuePair<object, object>[] _values;

		// Token: 0x040001B4 RID: 436
		private int _valueCount;

		// Token: 0x040001B5 RID: 437
		private List<Action> _completeActionList;

		// Token: 0x040001B6 RID: 438
		private List<Action> _revertActionList;

		// Token: 0x040001B7 RID: 439
		private bool _isDisposed;

		// Token: 0x040001B8 RID: 440
		private bool _isCompleted;

		// Token: 0x040001B9 RID: 441
		private bool _containsInnerAtomicComposition;
	}
}
