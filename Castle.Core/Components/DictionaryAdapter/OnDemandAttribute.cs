using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000104 RID: 260
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = false)]
	public class OnDemandAttribute : DictionaryBehaviorAttribute, IDictionaryPropertyGetter, IDictionaryBehavior
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x000131BF File Offset: 0x000113BF
		public OnDemandAttribute()
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000131C7 File Offset: 0x000113C7
		public OnDemandAttribute(Type type)
		{
			if (type.GetConstructor(Type.EmptyTypes) == null)
			{
				throw new ArgumentException("On-demand values must have a parameterless constructor");
			}
			this.Type = type;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000131F4 File Offset: 0x000113F4
		public OnDemandAttribute(object value)
		{
			this.Value = value;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x00013203 File Offset: 0x00011403
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x0001320B File Offset: 0x0001140B
		public Type Type { get; private set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00013214 File Offset: 0x00011414
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x0001321C File Offset: 0x0001141C
		public object Value { get; private set; }

		// Token: 0x060006DE RID: 1758 RVA: 0x00013228 File Offset: 0x00011428
		public object GetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, object storedValue, PropertyDescriptor property, bool ifExists)
		{
			if (storedValue == null && !ifExists)
			{
				IValueInitializer valueInitializer = null;
				if (this.Value != null)
				{
					storedValue = this.Value;
				}
				else
				{
					Type type = this.Type ?? OnDemandAttribute.GetInferredType(dictionaryAdapter, property, out valueInitializer);
					if (OnDemandAttribute.IsAcceptedType(type))
					{
						if (type.GetTypeInfo().IsInterface)
						{
							if (!property.IsDynamicProperty && storedValue == null)
							{
								storedValue = dictionaryAdapter.Create(property.PropertyType);
							}
						}
						else if (type.GetTypeInfo().IsArray)
						{
							storedValue = Array.CreateInstance(type.GetElementType(), 0);
						}
						else if (storedValue == null)
						{
							object[] parameters = null;
							ConstructorInfo constructorInfo = null;
							if (property.IsDynamicProperty)
							{
								constructorInfo = (from ctor in type.GetConstructors()
								let parms = ctor.GetParameters()
								where parms.Length == 1 && parms[0].ParameterType.IsAssignableFrom(dictionaryAdapter.Meta.Type)
								select ctor).FirstOrDefault<ConstructorInfo>();
								if (constructorInfo != null)
								{
									object[] array = new IDictionaryAdapter[]
									{
										dictionaryAdapter
									};
									parameters = array;
								}
							}
							if (constructorInfo == null)
							{
								constructorInfo = type.GetConstructor(Type.EmptyTypes);
							}
							if (constructorInfo != null)
							{
								storedValue = constructorInfo.Invoke(parameters);
							}
						}
					}
				}
				if (storedValue != null)
				{
					using (dictionaryAdapter.SuppressNotificationsBlock())
					{
						if (storedValue is ISupportInitialize)
						{
							((ISupportInitialize)storedValue).BeginInit();
							((ISupportInitialize)storedValue).EndInit();
						}
						if (valueInitializer != null)
						{
							valueInitializer.Initialize(dictionaryAdapter, storedValue);
						}
						property.SetPropertyValue(dictionaryAdapter, property.PropertyName, ref storedValue, dictionaryAdapter.This.Descriptor);
					}
				}
			}
			return storedValue;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00013430 File Offset: 0x00011630
		private static bool IsAcceptedType(Type type)
		{
			return type != null && type != typeof(string) && !type.GetTypeInfo().IsPrimitive && !type.GetTypeInfo().IsEnum;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0001346C File Offset: 0x0001166C
		private static Type GetInferredType(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property, out IValueInitializer initializer)
		{
			initializer = null;
			Type propertyType = property.PropertyType;
			if (!typeof(IEnumerable).IsAssignableFrom(propertyType))
			{
				return propertyType;
			}
			Type type = null;
			if (propertyType.GetTypeInfo().IsGenericType)
			{
				Type genericTypeDefinition = propertyType.GetGenericTypeDefinition();
				Type genericArg = propertyType.GetGenericArguments()[0];
				bool flag = genericTypeDefinition == typeof(BindingList<>);
				if (flag || genericTypeDefinition == typeof(List<>))
				{
					if (dictionaryAdapter.CanEdit)
					{
						type = (flag ? typeof(EditableBindingList<>) : typeof(EditableList<>));
					}
					if (flag && genericArg.GetTypeInfo().IsInterface)
					{
						Func<object> func = () => dictionaryAdapter.Create(genericArg);
						Type type2 = typeof(BindingListInitializer<>).MakeGenericType(new Type[]
						{
							genericArg
						});
						object[] array = new object[5];
						array[1] = func;
						initializer = (IValueInitializer)Activator.CreateInstance(type2, array);
					}
				}
				else if (genericTypeDefinition == typeof(IList<>) || genericTypeDefinition == typeof(ICollection<>))
				{
					type = (dictionaryAdapter.CanEdit ? typeof(EditableList<>) : typeof(List<>));
				}
				if (type != null)
				{
					return type.MakeGenericType(new Type[]
					{
						genericArg
					});
				}
			}
			else if (propertyType == typeof(IList) || propertyType == typeof(ICollection))
			{
				if (!dictionaryAdapter.CanEdit)
				{
					return typeof(List<object>);
				}
				return typeof(EditableList);
			}
			return propertyType;
		}
	}
}
