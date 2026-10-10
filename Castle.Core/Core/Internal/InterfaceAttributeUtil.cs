using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Castle.Core.Internal
{
	// Token: 0x020000E1 RID: 225
	internal sealed class InterfaceAttributeUtil
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		private Type CurrentType
		{
			get
			{
				return this.types[this.index].Value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00011CFC File Offset: 0x0000FEFC
		private int CurrentAge
		{
			get
			{
				return this.types[this.index].Age;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00011D10 File Offset: 0x0000FF10
		private bool IsMostDerivedType
		{
			get
			{
				return this.index == 0;
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00011D1C File Offset: 0x0000FF1C
		public static object[] GetAttributes(Type type, bool inherit)
		{
			if (!type.GetTypeInfo().IsInterface)
			{
				throw new ArgumentOutOfRangeException("type");
			}
			object[] array = type.GetTypeInfo().GetCustomAttributes(false).ToArray<object>();
			Type[] interfaces = type.GetInterfaces();
			if (interfaces.Length == 0 || !inherit)
			{
				return array;
			}
			return new InterfaceAttributeUtil(type, interfaces).GetAttributes(array);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00011D70 File Offset: 0x0000FF70
		private InterfaceAttributeUtil(Type derivedType, Type[] baseTypes)
		{
			this.types = this.CollectTypes(derivedType, baseTypes);
			this.singletons = new Dictionary<Type, InterfaceAttributeUtil.Aged<object>>();
			this.results = new List<object>();
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00011D9C File Offset: 0x0000FF9C
		private InterfaceAttributeUtil.Aged<Type>[] CollectTypes(Type derivedType, Type[] baseTypes)
		{
			Dictionary<Type, int> dictionary = new Dictionary<Type, int>();
			dictionary[derivedType] = 0;
			foreach (Type type in baseTypes)
			{
				if (InterfaceAttributeUtil.ShouldConsiderType(type))
				{
					dictionary[type] = 1;
				}
			}
			foreach (Type type2 in baseTypes)
			{
				if (dictionary.ContainsKey(type2))
				{
					foreach (Type key in type2.GetInterfaces())
					{
						int num;
						if (dictionary.TryGetValue(key, out num))
						{
							num = (dictionary[key] = num + 1);
						}
					}
				}
			}
			return (from a in dictionary
			select new InterfaceAttributeUtil.Aged<Type>(a.Key, a.Value) into t
			orderby t.Age
			select t).ToArray<InterfaceAttributeUtil.Aged<Type>>();
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00011E88 File Offset: 0x00010088
		private object[] GetAttributes(object[] attributes)
		{
			this.index = this.types.Length - 1;
			while (this.index > 0)
			{
				this.ProcessType(this.CurrentType.GetTypeInfo().GetCustomAttributes(false).ToArray<object>());
				this.index--;
			}
			this.ProcessType(attributes);
			this.CollectSingletons();
			return this.results.ToArray();
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00011EF4 File Offset: 0x000100F4
		private void ProcessType(object[] attributes)
		{
			foreach (object obj in attributes)
			{
				Type type = obj.GetType();
				AttributeUsageAttribute attributeUsage = type.GetAttributeUsage();
				if (this.IsMostDerivedType || attributeUsage.Inherited)
				{
					if (attributeUsage.AllowMultiple)
					{
						this.results.Add(obj);
					}
					else
					{
						this.AddSingleton(obj, type);
					}
				}
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00011F54 File Offset: 0x00010154
		private void AddSingleton(object attribute, Type attributeType)
		{
			InterfaceAttributeUtil.Aged<object> aged;
			if (this.singletons.TryGetValue(attributeType, out aged) && aged.Age == this.CurrentAge)
			{
				if (aged.Value == InterfaceAttributeUtil.ConflictMarker)
				{
					return;
				}
				attribute = InterfaceAttributeUtil.ConflictMarker;
			}
			this.singletons[attributeType] = this.MakeAged<object>(attribute);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00011FA8 File Offset: 0x000101A8
		private void CollectSingletons()
		{
			foreach (KeyValuePair<Type, InterfaceAttributeUtil.Aged<object>> keyValuePair in this.singletons)
			{
				object value = keyValuePair.Value.Value;
				if (value == InterfaceAttributeUtil.ConflictMarker)
				{
					this.HandleAttributeConflict(keyValuePair.Key);
				}
				else
				{
					this.results.Add(value);
				}
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00012024 File Offset: 0x00010224
		private void HandleAttributeConflict(Type attributeType)
		{
			throw new InvalidOperationException(string.Format("Cannot determine inherited attributes for interface type {0}.  Conflicting attributes of type {1} exist in the inheritance graph.", this.CurrentType.FullName, attributeType.FullName));
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00012048 File Offset: 0x00010248
		private static bool ShouldConsiderType(Type type)
		{
			string @namespace = type.Namespace;
			return @namespace != "Castle.Components.DictionaryAdapter" && @namespace != "System.ComponentModel";
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00012076 File Offset: 0x00010276
		private InterfaceAttributeUtil.Aged<T> MakeAged<T>(T value)
		{
			return new InterfaceAttributeUtil.Aged<T>(value, this.CurrentAge);
		}

		// Token: 0x0400016E RID: 366
		private readonly InterfaceAttributeUtil.Aged<Type>[] types;

		// Token: 0x0400016F RID: 367
		private readonly Dictionary<Type, InterfaceAttributeUtil.Aged<object>> singletons;

		// Token: 0x04000170 RID: 368
		private readonly List<object> results;

		// Token: 0x04000171 RID: 369
		private int index;

		// Token: 0x04000172 RID: 370
		private static readonly object ConflictMarker = new object();

		// Token: 0x020001F1 RID: 497
		[DebuggerDisplay("{Value}, Age: {Age}")]
		private sealed class Aged<T>
		{
			// Token: 0x06000E67 RID: 3687 RVA: 0x0002251B File Offset: 0x0002071B
			public Aged(T value, int age)
			{
				this.Value = value;
				this.Age = age;
			}

			// Token: 0x040003A8 RID: 936
			public readonly T Value;

			// Token: 0x040003A9 RID: 937
			public readonly int Age;
		}
	}
}
