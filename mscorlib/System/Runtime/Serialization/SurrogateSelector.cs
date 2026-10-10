using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Serialization
{
	/// <summary>Содействует форматерам при выборе знака-заместителя сериализации для делегирования в обработку сериализации или десериализации.</summary>
	// Token: 0x02000675 RID: 1653
	[ComVisible(true)]
	public class SurrogateSelector : ISurrogateSelector
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.SurrogateSelector" />.</summary>
		// Token: 0x06003DBB RID: 15803 RVA: 0x000D56CD File Offset: 0x000D38CD
		public SurrogateSelector()
		{
			this.m_surrogates = new SurrogateHashtable(32);
		}

		/// <summary>Добавляет суррогат в список проверенных суррогатов.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" />, для которого требуется суррогат.</param>
		/// <param name="context">Связанные с контекстом данные.</param>
		/// <param name="surrogate">Суррогат для вызова этого типа.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="type" /> или параметра <paramref name="surrogate" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Для этого типа и контекста суррогат уже существует.</exception>
		// Token: 0x06003DBC RID: 15804 RVA: 0x000D56E4 File Offset: 0x000D38E4
		public virtual void AddSurrogate(Type type, StreamingContext context, ISerializationSurrogate surrogate)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (surrogate == null)
			{
				throw new ArgumentNullException("surrogate");
			}
			SurrogateKey key = new SurrogateKey(type, context);
			this.m_surrogates.Add(key, surrogate);
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x000D5728 File Offset: 0x000D3928
		[SecurityCritical]
		private static bool HasCycle(ISurrogateSelector selector)
		{
			ISurrogateSelector surrogateSelector = selector;
			ISurrogateSelector surrogateSelector2 = selector;
			while (surrogateSelector != null)
			{
				surrogateSelector = surrogateSelector.GetNextSelector();
				if (surrogateSelector == null)
				{
					return true;
				}
				if (surrogateSelector == surrogateSelector2)
				{
					return false;
				}
				surrogateSelector = surrogateSelector.GetNextSelector();
				surrogateSelector2 = surrogateSelector2.GetNextSelector();
				if (surrogateSelector == surrogateSelector2)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Добавляет заданный <see cref="T:System.Runtime.Serialization.ISurrogateSelector" />, который может обрабатывать конкретный тип объекта для списка суррогатов.</summary>
		/// <param name="selector">Добавляемый суррогатный селектор.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="selector" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Данный селектор уже находится в списке селекторов.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003DBE RID: 15806 RVA: 0x000D5768 File Offset: 0x000D3968
		[SecurityCritical]
		public virtual void ChainSelector(ISurrogateSelector selector)
		{
			if (selector == null)
			{
				throw new ArgumentNullException("selector");
			}
			if (selector == this)
			{
				throw new SerializationException(Environment.GetResourceString("Selector is already on the list of checked selectors."));
			}
			if (!SurrogateSelector.HasCycle(selector))
			{
				throw new ArgumentException(Environment.GetResourceString("Selector contained a cycle."), "selector");
			}
			ISurrogateSelector surrogateSelector = selector.GetNextSelector();
			ISurrogateSelector surrogateSelector2 = selector;
			while (surrogateSelector != null && surrogateSelector != this)
			{
				surrogateSelector2 = surrogateSelector;
				surrogateSelector = surrogateSelector.GetNextSelector();
			}
			if (surrogateSelector == this)
			{
				throw new ArgumentException(Environment.GetResourceString("Adding selector will introduce a cycle."), "selector");
			}
			surrogateSelector = selector;
			ISurrogateSelector surrogateSelector3 = selector;
			while (surrogateSelector != null)
			{
				if (surrogateSelector == surrogateSelector2)
				{
					surrogateSelector = this.GetNextSelector();
				}
				else
				{
					surrogateSelector = surrogateSelector.GetNextSelector();
				}
				if (surrogateSelector == null)
				{
					break;
				}
				if (surrogateSelector == surrogateSelector3)
				{
					throw new ArgumentException(Environment.GetResourceString("Adding selector will introduce a cycle."), "selector");
				}
				if (surrogateSelector == surrogateSelector2)
				{
					surrogateSelector = this.GetNextSelector();
				}
				else
				{
					surrogateSelector = surrogateSelector.GetNextSelector();
				}
				if (surrogateSelector3 == surrogateSelector2)
				{
					surrogateSelector3 = this.GetNextSelector();
				}
				else
				{
					surrogateSelector3 = surrogateSelector3.GetNextSelector();
				}
				if (surrogateSelector == surrogateSelector3)
				{
					throw new ArgumentException(Environment.GetResourceString("Adding selector will introduce a cycle."), "selector");
				}
			}
			ISurrogateSelector nextSelector = this.m_nextSelector;
			this.m_nextSelector = selector;
			if (nextSelector != null)
			{
				surrogateSelector2.ChainSelector(nextSelector);
			}
		}

		/// <summary>Возвращает следующий селектор в цепочку селекторов.</summary>
		/// <returns>Следующий <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> в цепочке селекторов.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003DBF RID: 15807 RVA: 0x000D587A File Offset: 0x000D3A7A
		[SecurityCritical]
		public virtual ISurrogateSelector GetNextSelector()
		{
			return this.m_nextSelector;
		}

		/// <summary>Возвращает суррогат для определенного типа.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" />, для которого запрашивается суррогат.</param>
		/// <param name="context">Контекст потоковой передачи.</param>
		/// <param name="selector">Используемый суррогат.</param>
		/// <returns>Суррогат для определенного типа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06003DC0 RID: 15808 RVA: 0x000D5884 File Offset: 0x000D3A84
		[SecurityCritical]
		public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			selector = this;
			SurrogateKey key = new SurrogateKey(type, context);
			ISerializationSurrogate serializationSurrogate = (ISerializationSurrogate)this.m_surrogates[key];
			if (serializationSurrogate != null)
			{
				return serializationSurrogate;
			}
			if (this.m_nextSelector != null)
			{
				return this.m_nextSelector.GetSurrogate(type, context, out selector);
			}
			return null;
		}

		/// <summary>Удаляет суррогат, связанный с заданным типом.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" />, для которого удаляется суррогат.</param>
		/// <param name="context">
		///   <see cref="T:System.Runtime.Serialization.StreamingContext" /> для текущего суррогата.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003DC1 RID: 15809 RVA: 0x000D58E0 File Offset: 0x000D3AE0
		public virtual void RemoveSurrogate(Type type, StreamingContext context)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			SurrogateKey key = new SurrogateKey(type, context);
			this.m_surrogates.Remove(key);
		}

		// Token: 0x040027A1 RID: 10145
		internal SurrogateHashtable m_surrogates;

		// Token: 0x040027A2 RID: 10146
		internal ISurrogateSelector m_nextSelector;
	}
}
