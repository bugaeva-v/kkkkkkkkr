using System;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Reflection;
using Unity;

namespace System.Runtime.CompilerServices
{
	/// <summary>
	///         Базовый класс узла динамического вызова.
	///          Этот тип используется как тип параметра для целей динамического узла.
	///       </summary>
	// Token: 0x020002DB RID: 731
	public class CallSite
	{
		// Token: 0x0600163B RID: 5691 RVA: 0x0004AE19 File Offset: 0x00049019
		internal CallSite(CallSiteBinder binder)
		{
			this._binder = binder;
		}

		/// <summary>
		///         Класс, предназначенный для привязки динамических операций к динамическому сайту.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" /> Объект, предназначенный для привязки динамических операций.
		///       </returns>
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x0004AE28 File Offset: 0x00049028
		public CallSiteBinder Binder
		{
			get
			{
				return this._binder;
			}
		}

		/// <summary>
		///         Создает источник вызова с делегат заданного типа и привязки.
		///       </summary>
		/// <param name="delegateType">
		///           Тип делегата источника вызова.
		///         </param>
		/// <param name="binder">
		///           Привязки узла вызова.
		///         </param>
		/// <returns>
		///         Новый источник вызова.
		///       </returns>
		// Token: 0x0600163D RID: 5693 RVA: 0x0004AE30 File Offset: 0x00049030
		public static CallSite Create(Type delegateType, CallSiteBinder binder)
		{
			ContractUtils.RequiresNotNull(delegateType, "delegateType");
			ContractUtils.RequiresNotNull(binder, "binder");
			if (!delegateType.IsSubclassOf(typeof(MulticastDelegate)))
			{
				throw Error.TypeMustBeDerivedFromSystemDelegate();
			}
			CacheDict<Type, Func<CallSiteBinder, CallSite>> cacheDict = CallSite.s_siteCtors;
			if (cacheDict == null)
			{
				cacheDict = (CallSite.s_siteCtors = new CacheDict<Type, Func<CallSiteBinder, CallSite>>(100));
			}
			Func<CallSiteBinder, CallSite> func;
			if (!cacheDict.TryGetValue(delegateType, out func))
			{
				MethodInfo method = typeof(CallSite<>).MakeGenericType(new Type[]
				{
					delegateType
				}).GetMethod("Create");
				if (delegateType.IsCollectible)
				{
					return (CallSite)method.Invoke(null, new object[]
					{
						binder
					});
				}
				func = (Func<CallSiteBinder, CallSite>)method.CreateDelegate(typeof(Func<CallSiteBinder, CallSite>));
				cacheDict.Add(delegateType, func);
			}
			return func(binder);
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0000235B File Offset: 0x0000055B
		internal CallSite()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000B40 RID: 2880
		internal const string CallSiteTargetMethodName = "CallSite.Target";

		// Token: 0x04000B41 RID: 2881
		private static volatile CacheDict<Type, Func<CallSiteBinder, CallSite>> s_siteCtors;

		// Token: 0x04000B42 RID: 2882
		internal readonly CallSiteBinder _binder;

		// Token: 0x04000B43 RID: 2883
		internal bool _match;
	}
}
