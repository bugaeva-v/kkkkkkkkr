using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x0200004C RID: 76
	public abstract class AbstractTypeEmitter
	{
		// Token: 0x06000258 RID: 600 RVA: 0x000099D8 File Offset: 0x00007BD8
		protected AbstractTypeEmitter(TypeBuilder typeBuilder)
		{
			this.typebuilder = typeBuilder;
			this.nested = new NestedClassCollection();
			this.methods = new MethodCollection();
			this.constructors = new ConstructorCollection();
			this.properties = new PropertiesCollection();
			this.events = new EventCollection();
			this.name2GenericType = new Dictionary<string, GenericTypeParameterBuilder>();
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00009A44 File Offset: 0x00007C44
		public Type BaseType
		{
			get
			{
				if (this.TypeBuilder.IsInterface)
				{
					throw new InvalidOperationException("This emitter represents an interface; interfaces have no base types.");
				}
				return this.TypeBuilder.BaseType;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00009A69 File Offset: 0x00007C69
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00009A71 File Offset: 0x00007C71
		public TypeConstructorEmitter ClassConstructor { get; private set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00009A7A File Offset: 0x00007C7A
		public ConstructorCollection Constructors
		{
			get
			{
				return this.constructors;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00009A82 File Offset: 0x00007C82
		public GenericTypeParameterBuilder[] GenericTypeParams
		{
			get
			{
				return this.genericTypeParams;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00009A8A File Offset: 0x00007C8A
		public NestedClassCollection Nested
		{
			get
			{
				return this.nested;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00009A92 File Offset: 0x00007C92
		public TypeBuilder TypeBuilder
		{
			get
			{
				return this.typebuilder;
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00009A9C File Offset: 0x00007C9C
		public void AddCustomAttributes(ProxyGenerationOptions proxyGenerationOptions)
		{
			foreach (CustomAttributeInfo customAttributeInfo in proxyGenerationOptions.AdditionalAttributes)
			{
				this.typebuilder.SetCustomAttribute(customAttributeInfo.Builder);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00009AF4 File Offset: 0x00007CF4
		public virtual Type BuildType()
		{
			this.EnsureBuildersAreInAValidState();
			Type result = this.CreateType(this.typebuilder);
			foreach (NestedClassEmitter nestedClassEmitter in this.nested)
			{
				nestedClassEmitter.BuildType();
			}
			return result;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00009B54 File Offset: 0x00007D54
		public void CopyGenericParametersFromMethod(MethodInfo methodToCopyGenericsFrom)
		{
			if (this.genericTypeParams != null)
			{
				throw new ProxyGenerationException("CopyGenericParametersFromMethod: cannot invoke me twice");
			}
			this.SetGenericTypeParameters(GenericUtil.CopyGenericArguments(methodToCopyGenericsFrom, this.typebuilder, this.name2GenericType));
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00009B84 File Offset: 0x00007D84
		public ConstructorEmitter CreateConstructor(params ArgumentReference[] arguments)
		{
			if (this.TypeBuilder.IsInterface)
			{
				throw new InvalidOperationException("Interfaces cannot have constructors.");
			}
			ConstructorEmitter constructorEmitter = new ConstructorEmitter(this, arguments);
			this.constructors.Add(constructorEmitter);
			return constructorEmitter;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00009BBE File Offset: 0x00007DBE
		public void CreateDefaultConstructor()
		{
			if (this.TypeBuilder.IsInterface)
			{
				throw new InvalidOperationException("Interfaces cannot have constructors.");
			}
			this.constructors.Add(new ConstructorEmitter(this, new ArgumentReference[0]));
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00009BF0 File Offset: 0x00007DF0
		public EventEmitter CreateEvent(string name, EventAttributes atts, Type type)
		{
			EventEmitter eventEmitter = new EventEmitter(this, name, atts, type);
			this.events.Add(eventEmitter);
			return eventEmitter;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00009C14 File Offset: 0x00007E14
		public FieldReference CreateField(string name, Type fieldType)
		{
			return this.CreateField(name, fieldType, true);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00009C20 File Offset: 0x00007E20
		public FieldReference CreateField(string name, Type fieldType, bool serializable)
		{
			FieldAttributes fieldAttributes = FieldAttributes.Private;
			if (!serializable)
			{
				fieldAttributes |= FieldAttributes.NotSerialized;
			}
			return this.CreateField(name, fieldType, fieldAttributes);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00009C44 File Offset: 0x00007E44
		public FieldReference CreateField(string name, Type fieldType, FieldAttributes atts)
		{
			FieldReference fieldReference = new FieldReference(this.typebuilder.DefineField(name, fieldType, atts));
			this.fields[name] = fieldReference;
			return fieldReference;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00009C74 File Offset: 0x00007E74
		public MethodEmitter CreateMethod(string name, MethodAttributes attrs, Type returnType, params Type[] argumentTypes)
		{
			MethodEmitter methodEmitter = new MethodEmitter(this, name, attrs, returnType, argumentTypes ?? Type.EmptyTypes);
			this.methods.Add(methodEmitter);
			return methodEmitter;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00009CA3 File Offset: 0x00007EA3
		public MethodEmitter CreateMethod(string name, Type returnType, params Type[] parameterTypes)
		{
			return this.CreateMethod(name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig, returnType, parameterTypes);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00009CB3 File Offset: 0x00007EB3
		public MethodEmitter CreateMethod(string name, MethodInfo methodToUseAsATemplate)
		{
			return this.CreateMethod(name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig, methodToUseAsATemplate);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00009CC4 File Offset: 0x00007EC4
		public MethodEmitter CreateMethod(string name, MethodAttributes attributes, MethodInfo methodToUseAsATemplate)
		{
			MethodEmitter methodEmitter = new MethodEmitter(this, name, attributes, methodToUseAsATemplate);
			this.methods.Add(methodEmitter);
			return methodEmitter;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00009CE8 File Offset: 0x00007EE8
		public PropertyEmitter CreateProperty(string name, PropertyAttributes attributes, Type propertyType, Type[] arguments)
		{
			PropertyEmitter propertyEmitter = new PropertyEmitter(this, name, attributes, propertyType, arguments);
			this.properties.Add(propertyEmitter);
			return propertyEmitter;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00009D0E File Offset: 0x00007F0E
		public FieldReference CreateStaticField(string name, Type fieldType)
		{
			return this.CreateStaticField(name, fieldType, FieldAttributes.Private);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00009D19 File Offset: 0x00007F19
		public FieldReference CreateStaticField(string name, Type fieldType, FieldAttributes atts)
		{
			atts |= FieldAttributes.Static;
			return this.CreateField(name, fieldType, atts);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00009D2C File Offset: 0x00007F2C
		public ConstructorEmitter CreateTypeConstructor()
		{
			TypeConstructorEmitter typeConstructorEmitter = new TypeConstructorEmitter(this);
			this.constructors.Add(typeConstructorEmitter);
			this.ClassConstructor = typeConstructorEmitter;
			return typeConstructorEmitter;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00009D54 File Offset: 0x00007F54
		public void DefineCustomAttribute(CustomAttributeBuilder attribute)
		{
			this.typebuilder.SetCustomAttribute(attribute);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00009D64 File Offset: 0x00007F64
		public void DefineCustomAttribute<TAttribute>(object[] constructorArguments) where TAttribute : Attribute
		{
			CustomAttributeInfo customAttributeInfo = AttributeUtil.CreateInfo(typeof(TAttribute), constructorArguments);
			this.typebuilder.SetCustomAttribute(customAttributeInfo.Builder);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00009D94 File Offset: 0x00007F94
		public void DefineCustomAttribute<TAttribute>() where TAttribute : Attribute, new()
		{
			CustomAttributeInfo customAttributeInfo = AttributeUtil.CreateInfo<TAttribute>();
			this.typebuilder.SetCustomAttribute(customAttributeInfo.Builder);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00009DB8 File Offset: 0x00007FB8
		public void DefineCustomAttributeFor<TAttribute>(FieldReference field) where TAttribute : Attribute, new()
		{
			CustomAttributeInfo customAttributeInfo = AttributeUtil.CreateInfo<TAttribute>();
			FieldBuilder fieldbuilder = field.Fieldbuilder;
			if (fieldbuilder == null)
			{
				throw new ArgumentException("Invalid field reference.This reference does not point to field on type being generated", "field");
			}
			fieldbuilder.SetCustomAttribute(customAttributeInfo.Builder);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00009DF5 File Offset: 0x00007FF5
		public IEnumerable<FieldReference> GetAllFields()
		{
			return this.fields.Values;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00009E04 File Offset: 0x00008004
		public FieldReference GetField(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return null;
			}
			FieldReference result;
			this.fields.TryGetValue(name, out result);
			return result;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00009E2C File Offset: 0x0000802C
		public Type GetGenericArgument(string genericArgumentName)
		{
			GenericTypeParameterBuilder genericTypeParameterBuilder;
			if (this.name2GenericType.TryGetValue(genericArgumentName, out genericTypeParameterBuilder))
			{
				return genericTypeParameterBuilder.AsType();
			}
			return null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00009E54 File Offset: 0x00008054
		public Type[] GetGenericArgumentsFor(Type genericType)
		{
			List<Type> list = new List<Type>();
			foreach (Type type in genericType.GetGenericArguments())
			{
				if (type.GetTypeInfo().IsGenericParameter)
				{
					list.Add(this.name2GenericType[type.Name].AsType());
				}
				else
				{
					list.Add(type);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00009EB8 File Offset: 0x000080B8
		public Type[] GetGenericArgumentsFor(MethodInfo genericMethod)
		{
			List<Type> list = new List<Type>();
			foreach (Type type in genericMethod.GetGenericArguments())
			{
				list.Add(this.name2GenericType[type.Name].AsType());
			}
			return list.ToArray();
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00009F06 File Offset: 0x00008106
		public void SetGenericTypeParameters(GenericTypeParameterBuilder[] genericTypeParameterBuilders)
		{
			this.genericTypeParams = genericTypeParameterBuilders;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00009F10 File Offset: 0x00008110
		protected Type CreateType(TypeBuilder type)
		{
			Type result;
			try
			{
				result = type.CreateTypeInfo().AsType();
			}
			catch (BadImageFormatException ex)
			{
				if (!Debugger.IsAttached)
				{
					throw;
				}
				if (!ex.Message.Contains("HRESULT: 0x8007000B"))
				{
					throw;
				}
				if (!type.IsGenericTypeDefinition)
				{
					throw;
				}
				throw new ProxyGenerationException("This is a DynamicProxy2 error: It looks like you encountered a bug in Visual Studio debugger, which causes this exception when proxying types with generic methods having constraints on their generic arguments.This code will work just fine without the debugger attached. If you wish to use debugger you may have to switch to Visual Studio 2010 where this bug was fixed.")
				{
					Data = 
					{
						{
							"ProxyType",
							type.ToString()
						}
					}
				};
			}
			return result;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00009F84 File Offset: 0x00008184
		protected virtual void EnsureBuildersAreInAValidState()
		{
			if (!this.typebuilder.IsInterface && this.constructors.Count == 0)
			{
				this.CreateDefaultConstructor();
			}
			foreach (PropertyEmitter propertyEmitter in this.properties)
			{
				((IMemberEmitter)propertyEmitter).EnsureValidCodeBlock();
				((IMemberEmitter)propertyEmitter).Generate();
			}
			foreach (EventEmitter eventEmitter in this.events)
			{
				((IMemberEmitter)eventEmitter).EnsureValidCodeBlock();
				((IMemberEmitter)eventEmitter).Generate();
			}
			foreach (ConstructorEmitter constructorEmitter in this.constructors)
			{
				((IMemberEmitter)constructorEmitter).EnsureValidCodeBlock();
				((IMemberEmitter)constructorEmitter).Generate();
			}
			foreach (MethodEmitter methodEmitter in this.methods)
			{
				((IMemberEmitter)methodEmitter).EnsureValidCodeBlock();
				((IMemberEmitter)methodEmitter).Generate();
			}
		}

		// Token: 0x040000A0 RID: 160
		private const MethodAttributes defaultAttributes = MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig;

		// Token: 0x040000A1 RID: 161
		private readonly ConstructorCollection constructors;

		// Token: 0x040000A2 RID: 162
		private readonly EventCollection events;

		// Token: 0x040000A3 RID: 163
		private readonly IDictionary<string, FieldReference> fields = new Dictionary<string, FieldReference>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x040000A4 RID: 164
		private readonly MethodCollection methods;

		// Token: 0x040000A5 RID: 165
		private readonly Dictionary<string, GenericTypeParameterBuilder> name2GenericType;

		// Token: 0x040000A6 RID: 166
		private readonly NestedClassCollection nested;

		// Token: 0x040000A7 RID: 167
		private readonly PropertiesCollection properties;

		// Token: 0x040000A8 RID: 168
		private readonly TypeBuilder typebuilder;

		// Token: 0x040000A9 RID: 169
		private GenericTypeParameterBuilder[] genericTypeParams;
	}
}
