using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core.DependencyInjection
{
	// Token: 0x020000C7 RID: 199
	public class NSubContainer : IConfigurableNSubContainer, INSubContainer, INSubResolver
	{
		// Token: 0x06000344 RID: 836 RVA: 0x0000849D File Offset: 0x0000669D
		public NSubContainer()
		{
			this._syncRoot = new object();
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000084BB File Offset: 0x000066BB
		private NSubContainer(NSubContainer parentContainer)
		{
			this._parentContainer = parentContainer;
			this._syncRoot = parentContainer._syncRoot;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000084E1 File Offset: 0x000066E1
		public T Resolve<[Nullable(1)] T>()
		{
			return this.CreateScope().Resolve<T>();
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000084F0 File Offset: 0x000066F0
		public IConfigurableNSubContainer Register<[Nullable(1)] TKey, TImpl>(NSubLifetime lifetime) where TImpl : TKey
		{
			NSubContainer.<>c__DisplayClass6_0<TKey, TImpl> CS$<>8__locals1 = new NSubContainer.<>c__DisplayClass6_0<TKey, TImpl>();
			ConstructorInfo[] constructors = typeof(TImpl).GetConstructors();
			if (constructors.Length != 1)
			{
				throw new ArgumentException("Type '" + typeof(TImpl).FullName + "' should contain only single public constructor. Please register type using factory method to avoid ambiguity.");
			}
			CS$<>8__locals1.ctor = constructors[0];
			this.SetRegistration(typeof(TKey), new NSubContainer.Registration(new Func<NSubContainer.Scope, object>(CS$<>8__locals1.<Register>g__Factory|0), lifetime));
			return this;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000856C File Offset: 0x0000676C
		public IConfigurableNSubContainer Register<[Nullable(1)] TKey>(Func<INSubResolver, TKey> factory, NSubLifetime lifetime)
		{
			NSubContainer.<>c__DisplayClass7_0<TKey> CS$<>8__locals1 = new NSubContainer.<>c__DisplayClass7_0<TKey>();
			CS$<>8__locals1.factory = factory;
			this.SetRegistration(typeof(TKey), new NSubContainer.Registration(new Func<NSubContainer.Scope, object>(CS$<>8__locals1.<Register>g__Factory|0), lifetime));
			return this;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000085AC File Offset: 0x000067AC
		public IConfigurableNSubContainer Decorate<[Nullable(1)] TKey>(Func<TKey, INSubResolver, TKey> factory)
		{
			NSubContainer.<>c__DisplayClass8_0<TKey> CS$<>8__locals1 = new NSubContainer.<>c__DisplayClass8_0<TKey>();
			CS$<>8__locals1.factory = factory;
			CS$<>8__locals1.existingRegistration = this.TryFindRegistration(typeof(TKey));
			if (CS$<>8__locals1.existingRegistration == null)
			{
				throw new ArgumentException("Cannot decorate type " + typeof(TKey).FullName + " as implementation is not registered.");
			}
			this.SetRegistration(typeof(TKey), new NSubContainer.Registration(new Func<NSubContainer.Scope, object>(CS$<>8__locals1.<Decorate>g__Factory|0), CS$<>8__locals1.existingRegistration.Lifetime));
			return this;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00008635 File Offset: 0x00006835
		public IConfigurableNSubContainer Customize()
		{
			return new NSubContainer(this);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000863D File Offset: 0x0000683D
		public INSubResolver CreateScope()
		{
			return new NSubContainer.Scope(this);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00008648 File Offset: 0x00006848
		private void SetRegistration(Type type, NSubContainer.Registration registration)
		{
			object syncRoot = this._syncRoot;
			lock (syncRoot)
			{
				this._registrations[type] = registration;
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00008690 File Offset: 0x00006890
		[return: Nullable(2)]
		private NSubContainer.Registration TryFindRegistration(Type type)
		{
			object syncRoot = this._syncRoot;
			NSubContainer.Registration result2;
			lock (syncRoot)
			{
				for (NSubContainer nsubContainer = this; nsubContainer != null; nsubContainer = nsubContainer._parentContainer)
				{
					NSubContainer.Registration result;
					if (nsubContainer._registrations.TryGetValue(type, out result))
					{
						return result;
					}
				}
				result2 = null;
			}
			return result2;
		}

		// Token: 0x040000EE RID: 238
		[Nullable(2)]
		private readonly NSubContainer _parentContainer;

		// Token: 0x040000EF RID: 239
		private readonly object _syncRoot;

		// Token: 0x040000F0 RID: 240
		private readonly Dictionary<Type, NSubContainer.Registration> _registrations = new Dictionary<Type, NSubContainer.Registration>();

		// Token: 0x02000143 RID: 323
		private class Registration
		{
			// Token: 0x1700006E RID: 110
			// (get) Token: 0x060004EB RID: 1259 RVA: 0x0000A6AB File Offset: 0x000088AB
			public NSubLifetime Lifetime { get; }

			// Token: 0x060004EC RID: 1260 RVA: 0x0000A6B3 File Offset: 0x000088B3
			public Registration(Func<NSubContainer.Scope, object> factory, NSubLifetime lifetime)
			{
				this._factory = factory;
				this.Lifetime = lifetime;
			}

			// Token: 0x060004ED RID: 1261 RVA: 0x0000A6CC File Offset: 0x000088CC
			public object Resolve(NSubContainer.Scope scope)
			{
				switch (this.Lifetime)
				{
				case NSubLifetime.Singleton:
				{
					object result;
					if ((result = this._singletonValue) == null)
					{
						result = (this._singletonValue = this._factory(scope));
					}
					return result;
				}
				case NSubLifetime.PerScope:
				{
					object obj;
					if (scope.TryGetCached(this, out obj))
					{
						return obj;
					}
					obj = this._factory(scope);
					scope.Set(this, obj);
					return obj;
				}
				case NSubLifetime.Transient:
					return this._factory(scope);
				default:
					throw new InvalidOperationException("Unknown lifetime");
				}
			}

			// Token: 0x040001A0 RID: 416
			private readonly Func<NSubContainer.Scope, object> _factory;

			// Token: 0x040001A1 RID: 417
			[Nullable(2)]
			private object _singletonValue;
		}

		// Token: 0x02000144 RID: 324
		private class Scope : INSubResolver
		{
			// Token: 0x060004EE RID: 1262 RVA: 0x0000A74F File Offset: 0x0000894F
			public Scope(NSubContainer mostNestedContainer)
			{
				this._mostNestedContainer = mostNestedContainer;
			}

			// Token: 0x060004EF RID: 1263 RVA: 0x0000A769 File Offset: 0x00008969
			public T Resolve<[Nullable(1)] T>()
			{
				return (T)((object)this.Resolve(typeof(T)));
			}

			// Token: 0x060004F0 RID: 1264 RVA: 0x0000A780 File Offset: 0x00008980
			public bool TryGetCached(NSubContainer.Registration registration, [System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out object result)
			{
				return this._cache.TryGetValue(registration, out result);
			}

			// Token: 0x060004F1 RID: 1265 RVA: 0x0000A78F File Offset: 0x0000898F
			public void Set(NSubContainer.Registration registration, object value)
			{
				this._cache[registration] = value;
			}

			// Token: 0x060004F2 RID: 1266 RVA: 0x0000A7A0 File Offset: 0x000089A0
			public object Resolve(Type type)
			{
				object syncRoot = this._mostNestedContainer._syncRoot;
				object result;
				lock (syncRoot)
				{
					NSubContainer.Registration registration = this._mostNestedContainer.TryFindRegistration(type);
					if (registration == null)
					{
						throw new InvalidOperationException("Type is not registered: " + type.FullName);
					}
					result = registration.Resolve(this);
				}
				return result;
			}

			// Token: 0x060004F3 RID: 1267 RVA: 0x0000A80C File Offset: 0x00008A0C
			public object Resolve(NSubContainer.Registration registration)
			{
				object syncRoot = this._mostNestedContainer._syncRoot;
				object result;
				lock (syncRoot)
				{
					result = registration.Resolve(this);
				}
				return result;
			}

			// Token: 0x040001A3 RID: 419
			private readonly Dictionary<NSubContainer.Registration, object> _cache = new Dictionary<NSubContainer.Registration, object>();

			// Token: 0x040001A4 RID: 420
			private readonly NSubContainer _mostNestedContainer;
		}
	}
}
