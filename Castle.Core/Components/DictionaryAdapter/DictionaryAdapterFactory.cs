using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Xml;
using Castle.Components.DictionaryAdapter.Xml;
using Castle.Core.Internal;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000115 RID: 277
	public class DictionaryAdapterFactory : IDictionaryAdapterFactory
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x00014CEE File Offset: 0x00012EEE
		public T GetAdapter<T>(IDictionary dictionary)
		{
			return (T)((object)this.GetAdapter(typeof(T), dictionary));
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00014D06 File Offset: 0x00012F06
		public object GetAdapter(Type type, IDictionary dictionary)
		{
			return this.InternalGetAdapter(type, dictionary, null);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00014D11 File Offset: 0x00012F11
		public object GetAdapter(Type type, IDictionary dictionary, PropertyDescriptor descriptor)
		{
			return this.InternalGetAdapter(type, dictionary, descriptor);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00014D1C File Offset: 0x00012F1C
		public T GetAdapter<T, R>(IDictionary<string, R> dictionary)
		{
			return (T)((object)this.GetAdapter<R>(typeof(T), dictionary));
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00014D34 File Offset: 0x00012F34
		public object GetAdapter<R>(Type type, IDictionary<string, R> dictionary)
		{
			GenericDictionaryAdapter<R> dictionary2 = new GenericDictionaryAdapter<R>(dictionary);
			return this.InternalGetAdapter(type, dictionary2, null);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00014D51 File Offset: 0x00012F51
		public T GetAdapter<T>(NameValueCollection nameValues)
		{
			return this.GetAdapter<T>(new NameValueCollectionAdapter(nameValues));
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00014D5F File Offset: 0x00012F5F
		public object GetAdapter(Type type, NameValueCollection nameValues)
		{
			return this.GetAdapter(type, new NameValueCollectionAdapter(nameValues));
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00014D6E File Offset: 0x00012F6E
		public T GetAdapter<T>(XmlNode xmlNode)
		{
			return (T)((object)this.GetAdapter(typeof(T), xmlNode));
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00014D88 File Offset: 0x00012F88
		public object GetAdapter(Type type, XmlNode xmlNode)
		{
			XmlAdapter behavior = new XmlAdapter(xmlNode);
			return this.GetAdapter(type, new Hashtable(), new PropertyDescriptor().AddBehavior(XmlMetadataBehavior.Default).AddBehavior(behavior));
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00014DBD File Offset: 0x00012FBD
		public DictionaryAdapterMeta GetAdapterMeta(Type type)
		{
			return this.GetAdapterMeta(type, null);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00014DC7 File Offset: 0x00012FC7
		public DictionaryAdapterMeta GetAdapterMeta(Type type, PropertyDescriptor descriptor)
		{
			return this.InternalGetAdapterMeta(type, descriptor, null);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00014DD2 File Offset: 0x00012FD2
		public DictionaryAdapterMeta GetAdapterMeta(Type type, DictionaryAdapterMeta other)
		{
			return this.InternalGetAdapterMeta(type, null, other);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00014DE0 File Offset: 0x00012FE0
		private DictionaryAdapterMeta InternalGetAdapterMeta(Type type, PropertyDescriptor descriptor, DictionaryAdapterMeta other)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (!type.GetTypeInfo().IsInterface)
			{
				throw new ArgumentException("Only interfaces can be adapted to a dictionary", "type");
			}
			return this.interfaceToMeta.GetOrAdd(type, delegate(Type t)
			{
				if (descriptor == null && other != null)
				{
					descriptor = other.CreateDescriptor();
				}
				TypeBuilder typeBuilder = DictionaryAdapterFactory.CreateTypeBuilder(type);
				return this.CreateAdapterMeta(type, typeBuilder, descriptor);
			});
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00014E67 File Offset: 0x00013067
		private object InternalGetAdapter(Type type, IDictionary dictionary, PropertyDescriptor descriptor)
		{
			return this.InternalGetAdapterMeta(type, descriptor, null).CreateInstance(dictionary, descriptor);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00014E7C File Offset: 0x0001307C
		private static TypeBuilder CreateTypeBuilder(Type type)
		{
			ModuleBuilder moduleBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("CastleDictionaryAdapterAssembly"), AssemblyBuilderAccess.Run).DefineDynamicModule("CastleDictionaryAdapterModule");
			return DictionaryAdapterFactory.CreateAdapterType(type, moduleBuilder);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00014EAC File Offset: 0x000130AC
		private static TypeBuilder CreateAdapterType(Type type, ModuleBuilder moduleBuilder)
		{
			TypeBuilder typeBuilder = moduleBuilder.DefineType("CastleDictionaryAdapterType", TypeAttributes.Public | TypeAttributes.BeforeFieldInit);
			typeBuilder.AddInterfaceImplementation(type);
			typeBuilder.SetParent(typeof(DictionaryAdapterBase));
			Type[] types = new Type[]
			{
				typeof(Type)
			};
			ConstructorInfo constructor = typeof(DictionaryAdapterAttribute).GetConstructor(types);
			object[] constructorArgs = new Type[]
			{
				type
			};
			CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(constructor, constructorArgs);
			typeBuilder.SetCustomAttribute(customAttribute);
			Type[] types2 = new Type[]
			{
				typeof(string)
			};
			ConstructorInfo constructor2 = typeof(DebuggerDisplayAttribute).GetConstructor(types2);
			constructorArgs = new string[]
			{
				"Type: {Meta.Type.FullName,nq}"
			};
			CustomAttributeBuilder customAttribute2 = new CustomAttributeBuilder(constructor2, constructorArgs);
			typeBuilder.SetCustomAttribute(customAttribute2);
			return typeBuilder;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00014F68 File Offset: 0x00013168
		private DictionaryAdapterMeta CreateAdapterMeta(Type type, TypeBuilder typeBuilder, PropertyDescriptor descriptor)
		{
			FieldAttributes attributes = FieldAttributes.FamANDAssem | FieldAttributes.Family | FieldAttributes.Static;
			FieldBuilder field = typeBuilder.DefineField("__meta", typeof(DictionaryAdapterMeta), attributes);
			ConstructorInfo constructor = DictionaryAdapterFactory.CreateAdapterConstructor(typeBuilder);
			DictionaryAdapterFactory.CreateAdapterFactoryMethod(typeBuilder, constructor);
			PropertyDescriptor propertyDescriptor = new PropertyDescriptor();
			object[] array;
			Dictionary<string, PropertyDescriptor> propertyDescriptors = DictionaryAdapterFactory.GetPropertyDescriptors(type, propertyDescriptor, out array);
			if (descriptor != null)
			{
				propertyDescriptor.AddBehaviors(descriptor.MetaInitializers);
				array = array.Union(descriptor.Annotations).ToArray<object>();
			}
			DictionaryAdapterFactory.CreateMetaProperty(typeBuilder, DictionaryAdapterFactory.AdapterGetMeta, field);
			foreach (KeyValuePair<string, PropertyDescriptor> keyValuePair in propertyDescriptors)
			{
				DictionaryAdapterFactory.CreateAdapterProperty(typeBuilder, keyValuePair.Value);
			}
			Type type2 = typeBuilder.CreateTypeInfo().AsType();
			Func<DictionaryAdapterInstance, IDictionaryAdapter> creator = (Func<DictionaryAdapterInstance, IDictionaryAdapter>)type2.GetTypeInfo().GetDeclaredMethod("__Create").CreateDelegate(typeof(Func<DictionaryAdapterInstance, IDictionaryAdapter>));
			DictionaryAdapterMeta dictionaryAdapterMeta = new DictionaryAdapterMeta(type, type2, array, propertyDescriptor.MetaInitializers.ToArray<IDictionaryMetaInitializer>(), propertyDescriptor.Initializers.ToArray<IDictionaryInitializer>(), propertyDescriptors, this, creator);
			type2.GetField("__meta", BindingFlags.Static | BindingFlags.Public).SetValue(type2, dictionaryAdapterMeta);
			return dictionaryAdapterMeta;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x000150A0 File Offset: 0x000132A0
		private static ConstructorInfo CreateAdapterConstructor(TypeBuilder typeBuilder)
		{
			ConstructorBuilder constructorBuilder = typeBuilder.DefineConstructor(MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.HideBySig, CallingConventions.Standard, DictionaryAdapterFactory.ConstructorParameterTypes);
			ILGenerator ilgenerator = constructorBuilder.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Ldarg_1);
			ilgenerator.Emit(OpCodes.Call, DictionaryAdapterFactory.BaseCtor);
			ilgenerator.Emit(OpCodes.Ret);
			return constructorBuilder;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000150F4 File Offset: 0x000132F4
		private static void CreateAdapterFactoryMethod(TypeBuilder typeBuilder, ConstructorInfo constructor)
		{
			ILGenerator ilgenerator = typeBuilder.DefineMethod("__Create", MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static | MethodAttributes.HideBySig, typeof(IDictionaryAdapter), DictionaryAdapterFactory.ConstructorParameterTypes).GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Newobj, constructor);
			ilgenerator.Emit(OpCodes.Ret);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00015148 File Offset: 0x00013348
		private static void CreateMetaProperty(TypeBuilder typeBuilder, PropertyInfo prop, FieldInfo field)
		{
			MethodBuilder methodBuilder = typeBuilder.DefineMethod("get_" + prop.Name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.SpecialName, prop.PropertyType, null);
			ILGenerator ilgenerator = methodBuilder.GetILGenerator();
			if (field.IsStatic)
			{
				ilgenerator.Emit(OpCodes.Ldsfld, field);
			}
			else
			{
				ilgenerator.Emit(OpCodes.Ldarg_0);
				ilgenerator.Emit(OpCodes.Ldfld, field);
			}
			ilgenerator.Emit(OpCodes.Ret);
			typeBuilder.DefineMethodOverride(methodBuilder, prop.GetGetMethod());
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000151C4 File Offset: 0x000133C4
		private static void CreateAdapterProperty(TypeBuilder typeBuilder, PropertyDescriptor descriptor)
		{
			PropertyInfo property = descriptor.Property;
			PropertyBuilder propertyBuilder = typeBuilder.DefineProperty(property.Name, property.Attributes, property.PropertyType, null);
			if (property.CanRead)
			{
				DictionaryAdapterFactory.CreatePropertyGetMethod(typeBuilder, propertyBuilder, descriptor, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.SpecialName);
			}
			if (property.CanWrite)
			{
				DictionaryAdapterFactory.CreatePropertySetMethod(typeBuilder, propertyBuilder, descriptor, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.SpecialName);
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0001521C File Offset: 0x0001341C
		private static void PreparePropertyMethod(PropertyDescriptor descriptor, ILGenerator propILGenerator)
		{
			propILGenerator.DeclareLocal(typeof(string));
			propILGenerator.DeclareLocal(typeof(object));
			propILGenerator.Emit(OpCodes.Ldstr, descriptor.PropertyName);
			propILGenerator.Emit(OpCodes.Stloc_0);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0001525C File Offset: 0x0001345C
		private static void CreatePropertyGetMethod(TypeBuilder typeBuilder, PropertyBuilder propertyBuilder, PropertyDescriptor descriptor, MethodAttributes propAttribs)
		{
			MethodBuilder methodBuilder = typeBuilder.DefineMethod("get_" + descriptor.PropertyName, propAttribs, descriptor.PropertyType, null);
			ILGenerator ilgenerator = methodBuilder.GetILGenerator();
			Label label = ilgenerator.DefineLabel();
			Label label2 = ilgenerator.DefineLabel();
			Label label3 = ilgenerator.DefineLabel();
			DictionaryAdapterFactory.PreparePropertyMethod(descriptor, ilgenerator);
			LocalBuilder local = ilgenerator.DeclareLocal(descriptor.PropertyType);
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Ldloc_0);
			ilgenerator.Emit(OpCodes.Ldc_I4_0);
			ilgenerator.Emit(OpCodes.Callvirt, DictionaryAdapterFactory.AdapterGetProperty);
			ilgenerator.Emit(OpCodes.Stloc_1);
			ilgenerator.Emit(OpCodes.Ldloc_1);
			ilgenerator.Emit(OpCodes.Brfalse_S, label);
			ilgenerator.Emit(OpCodes.Ldloc_1);
			ilgenerator.Emit(OpCodes.Unbox_Any, descriptor.PropertyType);
			ilgenerator.Emit(OpCodes.Br_S, label2);
			ilgenerator.MarkLabel(label);
			ilgenerator.Emit(OpCodes.Ldloca_S, local);
			ilgenerator.Emit(OpCodes.Initobj, descriptor.PropertyType);
			ilgenerator.Emit(OpCodes.Br_S, label3);
			ilgenerator.MarkLabel(label2);
			ilgenerator.Emit(OpCodes.Stloc_S, local);
			ilgenerator.MarkLabel(label3);
			ilgenerator.Emit(OpCodes.Ldloc_S, local);
			ilgenerator.Emit(OpCodes.Ret);
			propertyBuilder.SetGetMethod(methodBuilder);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000153A4 File Offset: 0x000135A4
		private static void CreatePropertySetMethod(TypeBuilder typeBuilder, PropertyBuilder propertyBuilder, PropertyDescriptor descriptor, MethodAttributes propAttribs)
		{
			MethodBuilder methodBuilder = typeBuilder.DefineMethod("set_" + descriptor.PropertyName, propAttribs, null, new Type[]
			{
				descriptor.PropertyType
			});
			ILGenerator ilgenerator = methodBuilder.GetILGenerator();
			DictionaryAdapterFactory.PreparePropertyMethod(descriptor, ilgenerator);
			ilgenerator.Emit(OpCodes.Ldarg_1);
			if (descriptor.PropertyType.GetTypeInfo().IsValueType)
			{
				ilgenerator.Emit(OpCodes.Box, descriptor.PropertyType);
			}
			ilgenerator.Emit(OpCodes.Stloc_1);
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Ldloc_0);
			ilgenerator.Emit(OpCodes.Ldloca_S, 1);
			ilgenerator.Emit(OpCodes.Callvirt, DictionaryAdapterFactory.AdapterSetProperty);
			ilgenerator.Emit(OpCodes.Pop);
			ilgenerator.Emit(OpCodes.Ret);
			propertyBuilder.SetSetMethod(methodBuilder);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00015470 File Offset: 0x00013670
		private static Dictionary<string, PropertyDescriptor> GetPropertyDescriptors(Type type, PropertyDescriptor initializers, out object[] typeBehaviors)
		{
			DictionaryAdapterFactory.<>c__DisplayClass30_0 CS$<>8__locals1 = new DictionaryAdapterFactory.<>c__DisplayClass30_0();
			CS$<>8__locals1.initializers = initializers;
			CS$<>8__locals1.propertyMap = new Dictionary<string, PropertyDescriptor>();
			DictionaryAdapterFactory.<>c__DisplayClass30_0 CS$<>8__locals2 = CS$<>8__locals1;
			object[] interfaceBehaviors;
			typeBehaviors = (interfaceBehaviors = DictionaryAdapterFactory.ExpandBehaviors(InterfaceAttributeUtil.GetAttributes(type, true)).ToArray<object>());
			CS$<>8__locals2.interfaceBehaviors = interfaceBehaviors;
			CS$<>8__locals1.defaultFetch = (from b in typeBehaviors.OfType<FetchAttribute>()
			select new bool?(b.Fetch)).FirstOrDefault<bool?>().GetValueOrDefault();
			CS$<>8__locals1.initializers.AddBehaviors(typeBehaviors.OfType<IDictionaryMetaInitializer>()).AddBehaviors(typeBehaviors.OfType<IDictionaryInitializer>());
			DictionaryAdapterFactory.CollectProperties(type, delegate(PropertyInfo property, Type reflectedType)
			{
				object[] array = DictionaryAdapterFactory.ExpandBehaviors(property.GetCustomAttributes(false)).ToArray<object>();
				PropertyDescriptor propertyDescriptor = new PropertyDescriptor(property, array).AddBehaviors(array.OfType<IDictionaryBehavior>()).AddBehaviors(from b in CS$<>8__locals1.interfaceBehaviors.OfType<IDictionaryBehavior>()
				where !(b is IDictionaryKeyBuilder)
				select b);
				IEnumerable<IDictionaryKeyBuilder> behaviors = DictionaryAdapterFactory.ExpandBehaviors(InterfaceAttributeUtil.GetAttributes(reflectedType, true)).OfType<IDictionaryKeyBuilder>();
				propertyDescriptor = propertyDescriptor.AddBehaviors(behaviors);
				DictionaryAdapterFactory.AddDefaultGetter(propertyDescriptor);
				bool? flag = (from b in array.OfType<FetchAttribute>()
				select new bool?(b.Fetch)).FirstOrDefault<bool?>();
				propertyDescriptor.IfExists = array.OfType<IfExistsAttribute>().Any<IfExistsAttribute>();
				propertyDescriptor.Fetch = flag.GetValueOrDefault(CS$<>8__locals1.defaultFetch);
				foreach (IPropertyDescriptorInitializer propertyDescriptorInitializer in propertyDescriptor.Behaviors.OfType<IPropertyDescriptorInitializer>())
				{
					propertyDescriptorInitializer.Initialize(propertyDescriptor, array);
				}
				CS$<>8__locals1.initializers.AddBehaviors(array.OfType<IDictionaryMetaInitializer>());
				PropertyDescriptor propertyDescriptor2;
				if (CS$<>8__locals1.propertyMap.TryGetValue(property.Name, out propertyDescriptor2) && propertyDescriptor2.Property.PropertyType == property.PropertyType)
				{
					if (property.CanRead && property.CanWrite)
					{
						CS$<>8__locals1.propertyMap[property.Name] = propertyDescriptor;
					}
					return;
				}
				CS$<>8__locals1.propertyMap.Add(property.Name, propertyDescriptor);
			});
			return CS$<>8__locals1.propertyMap;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00015526 File Offset: 0x00013726
		private static IEnumerable<object> ExpandBehaviors(IEnumerable<object> behaviors)
		{
			foreach (object obj in behaviors)
			{
				if (obj is IDictionaryBehaviorBuilder)
				{
					foreach (object obj2 in ((IDictionaryBehaviorBuilder)obj).BuildBehaviors())
					{
						yield return obj2;
					}
					object[] array = null;
				}
				else
				{
					yield return obj;
				}
			}
			IEnumerator<object> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00015538 File Offset: 0x00013738
		private static void CollectProperties(Type currentType, Action<PropertyInfo, Type> onProperty)
		{
			List<Type> list = new List<Type>();
			list.Add(currentType);
			list.AddRange(currentType.GetInterfaces());
			foreach (Type type in from t in list
			where !DictionaryAdapterFactory.InfrastructureTypes.Contains(t)
			select t)
			{
				foreach (PropertyInfo arg in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
				{
					onProperty(arg, type);
				}
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x000155DC File Offset: 0x000137DC
		private static void AddDefaultGetter(PropertyDescriptor descriptor)
		{
			if (descriptor.TypeConverter != null)
			{
				descriptor.AddBehavior(new DefaultPropertyGetter(descriptor.TypeConverter));
			}
		}

		// Token: 0x040001BC RID: 444
		private readonly SynchronizedDictionary<Type, DictionaryAdapterMeta> interfaceToMeta = new SynchronizedDictionary<Type, DictionaryAdapterMeta>();

		// Token: 0x040001BD RID: 445
		private static readonly PropertyInfo AdapterGetMeta = typeof(IDictionaryAdapter).GetProperty("Meta");

		// Token: 0x040001BE RID: 446
		private static readonly ConstructorInfo BaseCtor = typeof(DictionaryAdapterBase).GetConstructors()[0];

		// Token: 0x040001BF RID: 447
		private static readonly Type[] ConstructorParameterTypes = new Type[]
		{
			typeof(DictionaryAdapterInstance)
		};

		// Token: 0x040001C0 RID: 448
		private static readonly MethodInfo AdapterGetProperty = typeof(IDictionaryAdapter).GetMethod("GetProperty");

		// Token: 0x040001C1 RID: 449
		private static readonly MethodInfo AdapterSetProperty = typeof(IDictionaryAdapter).GetMethod("SetProperty");

		// Token: 0x040001C2 RID: 450
		private static readonly HashSet<Type> InfrastructureTypes = new HashSet<Type>
		{
			typeof(IEditableObject),
			typeof(IDictionaryEdit),
			typeof(IChangeTracking),
			typeof(IRevertibleChangeTracking),
			typeof(IDictionaryNotify),
			typeof(IDataErrorInfo),
			typeof(IDictionaryValidate),
			typeof(IDictionaryAdapter)
		};
	}
}
