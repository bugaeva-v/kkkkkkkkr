using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;

namespace System.Runtime.CompilerServices
{
	/// <summary>
	///         Класс, предназначенный для привязки среды выполнения динамических операций к узлу динамического вызова.
	///       </summary>
	// Token: 0x020002DE RID: 734
	public abstract class CallSiteBinder
	{
		/// <summary>
		///         Возвращает метку, которая может использоваться для обновления привязки.
		///          Указывает, что привязка выражения больше не действительна.
		///          Обычно это используется «версией» динамический объект был изменен.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Linq.Expressions.LabelTarget" /> Объект, представляющий метку, которая может использоваться для запуска обновления привязки.
		///       </returns>
		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x0004B9AE File Offset: 0x00049BAE
		public static LabelTarget UpdateLabel { get; } = Expression.Label("CallSiteBinder.UpdateLabel");

		/// <summary>
		///         Выполняет привязку динамической операции на набор аргументов среды выполнения.
		///       </summary>
		/// <param name="args">
		///           Массив аргументов динамической операции.
		///         </param>
		/// <param name="parameters">
		///           Массив <see cref="T:System.Linq.Expressions.ParameterExpression" /> экземпляры, которые представляют параметры вызова в процессе привязки.
		///         </param>
		/// <param name="returnLabel">
		///           Элемент LabelTarget возвращают результат динамической привязки.
		///         </param>
		/// <returns>
		///         Выражение, проверяющее аргументы динамической операции и выполняющее эту операцию, если проверки пройдены успешно.
		///          Если тесты будут завершаться при последующих выполнениях динамической операции, привязка будет снова вызван для создания нового <see cref="T:System.Linq.Expressions.Expression" /> для новых типов аргументов.
		///       </returns>
		// Token: 0x06001657 RID: 5719
		public abstract Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel);

		/// <summary>
		///         Обеспечивает поддержку привязки низкого уровня среды выполнения.
		///          Классы могут переопределить это и обеспечивая прямой делегат для реализации правила.
		///          Это позволяет сохранять правила на диск, обеспечивать специализированные правила во время выполнения или предоставление альтернативную политику кэширования.
		///       </summary>
		/// <param name="site">
		///           Для которого выполняется привязка источника вызова.
		///         </param>
		/// <param name="args">
		///           Аргументы для привязки.
		///         </param>
		/// <typeparam name="T">
		///           Тип целевого элемента источника вызова.
		///         </typeparam>
		/// <returns>
		///         Новый делегат, заменяющий целевой.
		///       </returns>
		// Token: 0x06001658 RID: 5720 RVA: 0x0004B9B8 File Offset: 0x00049BB8
		public virtual T BindDelegate<T>(CallSite<T> site, object[] args) where T : class
		{
			return default(T);
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0004B9D0 File Offset: 0x00049BD0
		internal T BindCore<T>(CallSite<T> site, object[] args) where T : class
		{
			T t = this.BindDelegate<T>(site, args);
			if (t != null)
			{
				return t;
			}
			CallSiteBinder.LambdaSignature<T> instance = CallSiteBinder.LambdaSignature<T>.Instance;
			Expression expression = this.Bind(args, instance.Parameters, instance.ReturnLabel);
			if (expression == null)
			{
				throw Error.NoOrInvalidRuleProduced();
			}
			T t2 = CallSiteBinder.Stitch<T>(expression, instance).Compile();
			this.CacheTarget<T>(t2);
			return t2;
		}

		/// <summary>
		///         Добавляет целевой элемент в кэш известных целевых элементов.
		///          Кэшированные целевые объекты будут проверяться перед вызовом метода BindDelegate для получения нового правила.
		///       </summary>
		/// <param name="target">
		///           Целевой делегат, который добавляется в кэш.
		///         </param>
		/// <typeparam name="T">
		///           Тип добавляемого целевого элемента.
		///         </typeparam>
		// Token: 0x0600165A RID: 5722 RVA: 0x0004BA26 File Offset: 0x00049C26
		protected void CacheTarget<T>(T target) where T : class
		{
			this.GetRuleCache<T>().AddRule(target);
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0004BA34 File Offset: 0x00049C34
		private static Expression<T> Stitch<T>(Expression binding, CallSiteBinder.LambdaSignature<T> signature) where T : class
		{
			Type typeFromHandle = typeof(CallSite<T>);
			ReadOnlyCollectionBuilder<Expression> readOnlyCollectionBuilder = new ReadOnlyCollectionBuilder<Expression>(3);
			readOnlyCollectionBuilder.Add(binding);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(CallSite), "$site");
			TrueReadOnlyCollection<ParameterExpression> trueReadOnlyCollection = signature.Parameters.AddFirst(parameterExpression);
			Expression item = Expression.Label(CallSiteBinder.UpdateLabel);
			readOnlyCollectionBuilder.Add(item);
			readOnlyCollectionBuilder.Add(Expression.Label(signature.ReturnLabel, Expression.Condition(Expression.Call(CachedReflectionInfo.CallSiteOps_SetNotMatched, parameterExpression), Expression.Default(signature.ReturnLabel.Type), Expression.Invoke(Expression.Property(Expression.Convert(parameterExpression, typeFromHandle), typeof(CallSite<T>).GetProperty("Update")), trueReadOnlyCollection))));
			return Expression.Lambda<T>(Expression.Block(readOnlyCollectionBuilder), "CallSite.Target", true, trueReadOnlyCollection);
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0004BAF8 File Offset: 0x00049CF8
		internal RuleCache<T> GetRuleCache<T>() where T : class
		{
			if (this.Cache == null)
			{
				Interlocked.CompareExchange<Dictionary<Type, object>>(ref this.Cache, new Dictionary<Type, object>(), null);
			}
			Dictionary<Type, object> cache = this.Cache;
			Dictionary<Type, object> obj = cache;
			object obj2;
			lock (obj)
			{
				if (!cache.TryGetValue(typeof(T), out obj2))
				{
					obj2 = (cache[typeof(T)] = new RuleCache<T>());
				}
			}
			return obj2 as RuleCache<T>;
		}

		// Token: 0x04000B4E RID: 2894
		internal Dictionary<Type, object> Cache;

		// Token: 0x020002DF RID: 735
		private sealed class LambdaSignature<T> where T : class
		{
			// Token: 0x170003D6 RID: 982
			// (get) Token: 0x0600165E RID: 5726 RVA: 0x0004BB91 File Offset: 0x00049D91
			internal static CallSiteBinder.LambdaSignature<T> Instance
			{
				get
				{
					if (CallSiteBinder.LambdaSignature<T>.s_instance == null)
					{
						CallSiteBinder.LambdaSignature<T>.s_instance = new CallSiteBinder.LambdaSignature<T>();
					}
					return CallSiteBinder.LambdaSignature<T>.s_instance;
				}
			}

			// Token: 0x0600165F RID: 5727 RVA: 0x0004BBAC File Offset: 0x00049DAC
			private LambdaSignature()
			{
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsSubclassOf(typeof(MulticastDelegate)))
				{
					throw Error.TypeParameterIsNotDelegate(typeFromHandle);
				}
				MethodInfo invokeMethod = typeFromHandle.GetInvokeMethod();
				ParameterInfo[] parametersCached = invokeMethod.GetParametersCached();
				if (parametersCached[0].ParameterType != typeof(CallSite))
				{
					throw Error.FirstArgumentMustBeCallSite();
				}
				ParameterExpression[] array = new ParameterExpression[parametersCached.Length - 1];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Expression.Parameter(parametersCached[i + 1].ParameterType, "$arg" + i.ToString());
				}
				this.Parameters = new TrueReadOnlyCollection<ParameterExpression>(array);
				this.ReturnLabel = Expression.Label(invokeMethod.GetReturnType());
			}

			// Token: 0x04000B50 RID: 2896
			private static CallSiteBinder.LambdaSignature<T> s_instance;

			// Token: 0x04000B51 RID: 2897
			internal readonly ReadOnlyCollection<ParameterExpression> Parameters;

			// Token: 0x04000B52 RID: 2898
			internal readonly LabelTarget ReturnLabel;
		}
	}
}
