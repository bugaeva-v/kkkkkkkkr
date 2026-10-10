using System;
using System.ComponentModel;
using System.Diagnostics;

namespace System.Runtime.CompilerServices
{
	/// <summary>
	///         Создает и кэширует правила привязки.
	///       </summary>
	// Token: 0x020002E1 RID: 737
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class CallSiteOps
	{
		/// <summary>
		///         Создает экземпляр динамического вызова, используемый для поиска в кэше.
		///       </summary>
		/// <param name="site">
		///           Экземпляр динамического источника вызова.
		///         </param>
		/// <typeparam name="T">
		///           Тип делегата из <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </typeparam>
		/// <returns>
		///         Новый источник вызова.
		///       </returns>
		// Token: 0x06001662 RID: 5730 RVA: 0x0004BCDD File Offset: 0x00049EDD
		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static CallSite<T> CreateMatchmaker<T>(CallSite<T> site) where T : class
		{
			CallSite<T> callSite = site.CreateMatchMaker();
			callSite._match = true;
			return callSite;
		}

		/// <summary>
		///         Проверка необходимости обновления динамического узла.
		///       </summary>
		/// <param name="site">
		///           Экземпляр динамического источника вызова.
		///         </param>
		/// <returns>
		///         Если правило не обновляется, значение false в противном случае — значение true.
		///       </returns>
		// Token: 0x06001663 RID: 5731 RVA: 0x0004BCEC File Offset: 0x00049EEC
		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool SetNotMatched(CallSite site)
		{
			bool match = site._match;
			site._match = false;
			return match;
		}

		/// <summary>
		///         Проверяет соответствие выполненного правила
		///       </summary>
		/// <param name="site">
		///           Экземпляр динамического источника вызова.
		///         </param>
		/// <returns>
		///         значение true, если правило соответствия, значение false в противном случае.
		///       </returns>
		// Token: 0x06001664 RID: 5732 RVA: 0x0004BCFB File Offset: 0x00049EFB
		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool GetMatch(CallSite site)
		{
			return site._match;
		}

		/// <summary>
		///         Снимает флажок соответствия на вызова, проверяющем.
		///       </summary>
		/// <param name="site">
		///           Экземпляр динамического источника вызова.
		///         </param>
		// Token: 0x06001665 RID: 5733 RVA: 0x0004BD03 File Offset: 0x00049F03
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static void ClearMatch(CallSite site)
		{
			site._match = true;
		}

		/// <summary>
		///         Добавляет правило в кэш, поддерживаемый на динамическом источнике вызова.
		///       </summary>
		/// <param name="site">
		///           Экземпляр динамического источника вызова.
		///         </param>
		/// <param name="rule">
		///           Экземпляр узла правила вызова.
		///         </param>
		/// <typeparam name="T">
		///           Тип делегата из <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </typeparam>
		// Token: 0x06001666 RID: 5734 RVA: 0x0004BD0C File Offset: 0x00049F0C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static void AddRule<T>(CallSite<T> site, T rule) where T : class
		{
			site.AddRule(rule);
		}

		/// <summary>
		///         Обновляет правила в кэше.
		///       </summary>
		/// <param name="this">
		///           Экземпляр динамического источника вызова.
		///         </param>
		/// <param name="matched">
		///           Индекс правила соответствия.
		///         </param>
		/// <typeparam name="T">
		///           Тип делегата из <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </typeparam>
		// Token: 0x06001667 RID: 5735 RVA: 0x0004BD15 File Offset: 0x00049F15
		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void UpdateRules<T>(CallSite<T> @this, int matched) where T : class
		{
			if (matched > 1)
			{
				@this.MoveRule(matched);
			}
		}

		/// <summary>
		///         Получает динамические правила привязки от источника вызова.
		///       </summary>
		/// <param name="site">
		///           Экземпляр динамического источника вызова.
		///         </param>
		/// <typeparam name="T">
		///           Тип делегата из <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </typeparam>
		/// <returns>
		///         Массив динамических правил привязки.
		///       </returns>
		// Token: 0x06001668 RID: 5736 RVA: 0x0004BD22 File Offset: 0x00049F22
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static T[] GetRules<T>(CallSite<T> site) where T : class
		{
			return site.Rules;
		}

		/// <summary>
		///         Извлекает кэш правил привязки.
		///       </summary>
		/// <param name="site">
		///           Экземпляр динамического источника вызова.
		///         </param>
		/// <typeparam name="T">
		///           Тип делегата из <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </typeparam>
		/// <returns>
		///         Кэш.
		///       </returns>
		// Token: 0x06001669 RID: 5737 RVA: 0x0004BD2A File Offset: 0x00049F2A
		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static RuleCache<T> GetRuleCache<T>(CallSite<T> site) where T : class
		{
			return site.Binder.GetRuleCache<T>();
		}

		/// <summary>
		///         Перемещает правило привязки в пределах кэша.
		///       </summary>
		/// <param name="cache">
		///           Кэш правил вызов узла.
		///         </param>
		/// <param name="rule">
		///           Экземпляр узла правила вызова.
		///         </param>
		/// <param name="i">
		///           Индекс правила сайта вызова.
		///         </param>
		/// <typeparam name="T">
		///           Тип делегата из <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </typeparam>
		// Token: 0x0600166A RID: 5738 RVA: 0x0004BD37 File Offset: 0x00049F37
		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void MoveRule<T>(RuleCache<T> cache, T rule, int i) where T : class
		{
			if (i > 1)
			{
				cache.MoveRule(rule, i);
			}
		}

		/// <summary>
		///         Выполняет поиск в кэше динамических правил для правил, применимых к динамической операции.
		///       </summary>
		/// <param name="cache">
		///           Кэш.
		///         </param>
		/// <typeparam name="T">
		///           Тип делегата из <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </typeparam>
		/// <returns>
		///         Коллекция правил.
		///       </returns>
		// Token: 0x0600166B RID: 5739 RVA: 0x0004BD45 File Offset: 0x00049F45
		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static T[] GetCachedRules<T>(RuleCache<T> cache) where T : class
		{
			return cache.GetRules();
		}

		/// <summary>
		///         Обновляет цель сайта вызова новым правилом на основании аргументов.
		///       </summary>
		/// <param name="binder">
		///           Привязки узла вызова.
		///         </param>
		/// <param name="site">
		///           Экземпляр динамического источника вызова.
		///         </param>
		/// <param name="args">
		///           Аргументы для вызова.
		///         </param>
		/// <typeparam name="T">
		///           Тип делегата из <see cref="T:System.Runtime.CompilerServices.CallSite" />.
		///         </typeparam>
		/// <returns>
		///         Новая цель сайта вызова.
		///       </returns>
		// Token: 0x0600166C RID: 5740 RVA: 0x0004BD4D File Offset: 0x00049F4D
		[Obsolete("do not use this method", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static T Bind<T>(CallSiteBinder binder, CallSite<T> site, object[] args) where T : class
		{
			return binder.BindCore<T>(site, args);
		}
	}
}
