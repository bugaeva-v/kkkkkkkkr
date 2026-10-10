using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy
{
	// Token: 0x02000014 RID: 20
	public class MixinData
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00002E9C File Offset: 0x0000109C
		public MixinData(IEnumerable<object> mixinInstances)
		{
			if (mixinInstances != null)
			{
				List<Type> list = new List<Type>();
				Dictionary<Type, object> dictionary = new Dictionary<Type, object>();
				this.delegateMixinCount = 0;
				foreach (object obj in mixinInstances)
				{
					Type[] array;
					object value;
					Type type;
					if (obj is Delegate)
					{
						this.delegateMixinCount++;
						array = new Type[]
						{
							obj.GetType()
						};
						value = obj;
					}
					else if ((type = (obj as Type)) != null && type.IsDelegateType())
					{
						this.delegateMixinCount++;
						array = new Type[]
						{
							type
						};
						value = null;
					}
					else
					{
						array = obj.GetType().GetInterfaces();
						value = obj;
					}
					foreach (Type type2 in array)
					{
						list.Add(type2);
						object obj2;
						if (dictionary.TryGetValue(type2, out obj2))
						{
							string message;
							if (obj2 != null)
							{
								message = string.Format("The list of mixins contains two mixins implementing the same interface '{0}': {1} and {2}. An interface cannot be added by more than one mixin.", type2.FullName, obj2.GetType().Name, obj.GetType().Name);
							}
							else
							{
								message = string.Format("The list of mixins already contains a mixin for delegate type '{0}'.", type2.FullName);
							}
							throw new ArgumentException(message, "mixinInstances");
						}
						dictionary[type2] = value;
					}
				}
				if (this.delegateMixinCount > 1)
				{
					HashSet<MethodInfo> hashSet = new HashSet<MethodInfo>();
					foreach (Type type3 in dictionary.Keys)
					{
						if (type3.IsDelegateType())
						{
							MethodInfo method = type3.GetMethod("Invoke");
							if (hashSet.Contains(method, MethodSignatureComparer.Instance))
							{
								throw new ArgumentException("The list of mixins contains at least two delegate mixins for the same delegate signature.", "mixinInstances");
							}
							hashSet.Add(method);
						}
					}
				}
				list.Sort((Type x, Type y) => string.CompareOrdinal(x.FullName, y.FullName));
				for (int j = 0; j < list.Count; j++)
				{
					Type key = list[j];
					object item = dictionary[key];
					this.mixinPositions[key] = j;
					this.mixinsImpl.Add(item);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00003128 File Offset: 0x00001328
		public IEnumerable<Type> MixinInterfaces
		{
			get
			{
				return this.mixinPositions.Keys;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00003135 File Offset: 0x00001335
		public IEnumerable<object> Mixins
		{
			get
			{
				return this.mixinsImpl;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000313D File Offset: 0x0000133D
		public bool ContainsMixin(Type mixinInterfaceType)
		{
			return this.mixinPositions.ContainsKey(mixinInterfaceType);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000314C File Offset: 0x0000134C
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			MixinData mixinData = obj as MixinData;
			if (mixinData == null)
			{
				return false;
			}
			if (this.mixinsImpl.Count != mixinData.mixinsImpl.Count)
			{
				return false;
			}
			if (this.delegateMixinCount != mixinData.delegateMixinCount)
			{
				return false;
			}
			for (int i = 0; i < this.mixinsImpl.Count; i++)
			{
				object obj2 = this.mixinsImpl[i];
				Type left = (obj2 != null) ? obj2.GetType() : null;
				object obj3 = mixinData.mixinsImpl[i];
				if (left != ((obj3 != null) ? obj3.GetType() : null))
				{
					return false;
				}
			}
			if (this.delegateMixinCount > 0)
			{
				IEnumerable<Type> first = (from m in this.mixinPositions
				select m.Key).Where(new Func<Type, bool>(TypeUtil.IsDelegateType));
				IEnumerable<Type> second = (from m in mixinData.mixinPositions
				select m.Key).Where(new Func<Type, bool>(TypeUtil.IsDelegateType));
				return first.SequenceEqual(second);
			}
			return true;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000326C File Offset: 0x0000146C
		public override int GetHashCode()
		{
			int num = 0;
			foreach (object obj in this.mixinsImpl)
			{
				num = ((29 * num + ((obj != null) ? new int?(obj.GetType().GetHashCode()) : null)) ?? 307);
			}
			return num;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000331C File Offset: 0x0000151C
		public object GetMixinInstance(Type mixinInterfaceType)
		{
			return this.mixinsImpl[this.mixinPositions[mixinInterfaceType]];
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003335 File Offset: 0x00001535
		public int GetMixinPosition(Type mixinInterfaceType)
		{
			return this.mixinPositions[mixinInterfaceType];
		}

		// Token: 0x0400001A RID: 26
		private readonly Dictionary<Type, int> mixinPositions = new Dictionary<Type, int>();

		// Token: 0x0400001B RID: 27
		private readonly List<object> mixinsImpl = new List<object>();

		// Token: 0x0400001C RID: 28
		private int delegateMixinCount;
	}
}
