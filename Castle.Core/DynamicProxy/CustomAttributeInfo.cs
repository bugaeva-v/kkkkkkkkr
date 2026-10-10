using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Castle.DynamicProxy
{
	// Token: 0x02000006 RID: 6
	public class CustomAttributeInfo : IEquatable<CustomAttributeInfo>
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002514 File Offset: 0x00000714
		public CustomAttributeInfo(ConstructorInfo constructor, object[] constructorArgs, PropertyInfo[] namedProperties, object[] propertyValues, FieldInfo[] namedFields, object[] fieldValues)
		{
			this.builder = new CustomAttributeBuilder(constructor, constructorArgs, namedProperties, propertyValues, namedFields, fieldValues);
			this.constructor = constructor;
			this.constructorArgs = ((constructorArgs.Length == 0) ? CustomAttributeInfo.EmptyValues : constructorArgs.ToArray<object>());
			this.properties = this.MakeNameValueDictionary<PropertyInfo>(namedProperties, propertyValues);
			this.fields = this.MakeNameValueDictionary<FieldInfo>(namedFields, fieldValues);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002578 File Offset: 0x00000778
		public CustomAttributeInfo(ConstructorInfo constructor, object[] constructorArgs, PropertyInfo[] namedProperties, object[] propertyValues) : this(constructor, constructorArgs, namedProperties, propertyValues, CustomAttributeInfo.EmptyFields, CustomAttributeInfo.EmptyValues)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000258F File Offset: 0x0000078F
		public CustomAttributeInfo(ConstructorInfo constructor, object[] constructorArgs, FieldInfo[] namedFields, object[] fieldValues) : this(constructor, constructorArgs, CustomAttributeInfo.EmptyProperties, CustomAttributeInfo.EmptyValues, namedFields, fieldValues)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000025A6 File Offset: 0x000007A6
		public CustomAttributeInfo(ConstructorInfo constructor, object[] constructorArgs) : this(constructor, constructorArgs, CustomAttributeInfo.EmptyProperties, CustomAttributeInfo.EmptyValues, CustomAttributeInfo.EmptyFields, CustomAttributeInfo.EmptyValues)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000025C4 File Offset: 0x000007C4
		public static CustomAttributeInfo FromExpression(Expression<Func<Attribute>> expression)
		{
			List<PropertyInfo> list = new List<PropertyInfo>();
			List<object> list2 = new List<object>();
			List<FieldInfo> list3 = new List<FieldInfo>();
			List<object> list4 = new List<object>();
			Expression expression2 = CustomAttributeInfo.UnwrapBody(expression.Body);
			NewExpression newExpression = expression2 as NewExpression;
			if (newExpression == null)
			{
				MemberInitExpression memberInitExpression = expression2 as MemberInitExpression;
				if (memberInitExpression == null)
				{
					throw new ArgumentException("The expression must be either a simple constructor call or an object initializer expression");
				}
				newExpression = memberInitExpression.NewExpression;
				foreach (MemberBinding memberBinding in memberInitExpression.Bindings)
				{
					MemberAssignment memberAssignment = memberBinding as MemberAssignment;
					if (memberAssignment == null)
					{
						throw new ArgumentException("Only assignment bindings are supported");
					}
					object attributeArgumentValue = CustomAttributeInfo.GetAttributeArgumentValue(memberAssignment.Expression, true);
					PropertyInfo propertyInfo = memberAssignment.Member as PropertyInfo;
					if (propertyInfo != null)
					{
						list.Add(propertyInfo);
						list2.Add(attributeArgumentValue);
					}
					else
					{
						FieldInfo fieldInfo = memberAssignment.Member as FieldInfo;
						if (!(fieldInfo != null))
						{
							throw new ArgumentException("Only property and field assignments are supported");
						}
						list3.Add(fieldInfo);
						list4.Add(attributeArgumentValue);
					}
				}
			}
			List<object> list5 = new List<object>();
			foreach (Expression arg in newExpression.Arguments)
			{
				object attributeArgumentValue2 = CustomAttributeInfo.GetAttributeArgumentValue(arg, true);
				list5.Add(attributeArgumentValue2);
			}
			return new CustomAttributeInfo(newExpression.Constructor, list5.ToArray(), list.ToArray(), list2.ToArray(), list3.ToArray(), list4.ToArray());
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002768 File Offset: 0x00000968
		private static Expression UnwrapBody(Expression body)
		{
			UnaryExpression unaryExpression = body as UnaryExpression;
			if (unaryExpression != null && unaryExpression.NodeType == ExpressionType.Convert)
			{
				return unaryExpression.Operand;
			}
			return body;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002794 File Offset: 0x00000994
		private static object GetAttributeArgumentValue(Expression arg, bool allowArray)
		{
			ExpressionType nodeType = arg.NodeType;
			if (nodeType != ExpressionType.Constant)
			{
				if (nodeType != ExpressionType.MemberAccess)
				{
					if (nodeType == ExpressionType.NewArrayInit)
					{
						if (allowArray)
						{
							NewArrayExpression newArrayExpression = (NewArrayExpression)arg;
							Array array = Array.CreateInstance(newArrayExpression.Type.GetElementType(), newArrayExpression.Expressions.Count);
							int num = 0;
							foreach (Expression arg2 in newArrayExpression.Expressions)
							{
								object attributeArgumentValue = CustomAttributeInfo.GetAttributeArgumentValue(arg2, false);
								array.SetValue(attributeArgumentValue, num);
								num++;
							}
							return array;
						}
					}
				}
				else
				{
					MemberExpression memberExpression = (MemberExpression)arg;
					FieldInfo fieldInfo;
					ConstantExpression constantExpression;
					if ((fieldInfo = (memberExpression.Member as FieldInfo)) != null && (constantExpression = (memberExpression.Expression as ConstantExpression)) != null && CustomAttributeInfo.IsCompilerGenerated(constantExpression.Type) && constantExpression.Value != null)
					{
						return fieldInfo.GetValue(constantExpression.Value);
					}
				}
				throw new ArgumentException("Only constant, local variables, method parameters and single-dimensional array expressions are supported");
			}
			return ((ConstantExpression)arg).Value;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000028AC File Offset: 0x00000AAC
		private static bool IsCompilerGenerated(Type type)
		{
			return type.GetTypeInfo().IsDefined(typeof(CompilerGeneratedAttribute));
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000028C3 File Offset: 0x00000AC3
		internal CustomAttributeBuilder Builder
		{
			get
			{
				return this.builder;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000028CC File Offset: 0x00000ACC
		public bool Equals(CustomAttributeInfo other)
		{
			return other != null && (this == other || (this.constructor.Equals(other.constructor) && this.constructorArgs.SequenceEqual(other.constructorArgs, CustomAttributeInfo.ValueComparer) && CustomAttributeInfo.AreMembersEquivalent(this.properties, other.properties) && CustomAttributeInfo.AreMembersEquivalent(this.fields, other.fields)));
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002935 File Offset: 0x00000B35
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || (!(obj.GetType() != base.GetType()) && this.Equals((CustomAttributeInfo)obj)));
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002964 File Offset: 0x00000B64
		public override int GetHashCode()
		{
			return ((this.constructor.GetHashCode() * 397 ^ CustomAttributeInfo.CombineHashCodes(this.constructorArgs)) * 397 ^ CustomAttributeInfo.CombineMemberHashCodes(this.properties)) * 397 ^ CustomAttributeInfo.CombineMemberHashCodes(this.fields);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000029B4 File Offset: 0x00000BB4
		private static bool AreMembersEquivalent(IDictionary<string, object> x, IDictionary<string, object> y)
		{
			if (x.Count != y.Count)
			{
				return false;
			}
			foreach (KeyValuePair<string, object> keyValuePair in x)
			{
				object y2;
				if (!y.TryGetValue(keyValuePair.Key, out y2))
				{
					return false;
				}
				if (!CustomAttributeInfo.ValueComparer.Equals(keyValuePair.Value, y2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002A38 File Offset: 0x00000C38
		private static int CombineHashCodes(IEnumerable<object> values)
		{
			int num = 173;
			foreach (object obj in values)
			{
				num = (num * 397 ^ CustomAttributeInfo.ValueComparer.GetHashCode(obj));
			}
			return num;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002A94 File Offset: 0x00000C94
		private static int CombineMemberHashCodes(IDictionary<string, object> dict)
		{
			int num = 0;
			foreach (KeyValuePair<string, object> keyValuePair in dict)
			{
				int hashCode = keyValuePair.Key.GetHashCode();
				int hashCode2 = CustomAttributeInfo.ValueComparer.GetHashCode(keyValuePair.Value);
				num += (hashCode * 397 ^ hashCode2);
			}
			return num;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002B08 File Offset: 0x00000D08
		private IDictionary<string, object> MakeNameValueDictionary<T>(T[] members, object[] values) where T : MemberInfo
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			for (int i = 0; i < members.Length; i++)
			{
				dictionary.Add(members[i].Name, values[i]);
			}
			return dictionary;
		}

		// Token: 0x0400000D RID: 13
		private static readonly PropertyInfo[] EmptyProperties = new PropertyInfo[0];

		// Token: 0x0400000E RID: 14
		private static readonly FieldInfo[] EmptyFields = new FieldInfo[0];

		// Token: 0x0400000F RID: 15
		private static readonly object[] EmptyValues = new object[0];

		// Token: 0x04000010 RID: 16
		private static readonly IEqualityComparer<object> ValueComparer = new CustomAttributeInfo.AttributeArgumentValueEqualityComparer();

		// Token: 0x04000011 RID: 17
		private readonly CustomAttributeBuilder builder;

		// Token: 0x04000012 RID: 18
		private readonly ConstructorInfo constructor;

		// Token: 0x04000013 RID: 19
		private readonly object[] constructorArgs;

		// Token: 0x04000014 RID: 20
		private readonly IDictionary<string, object> properties;

		// Token: 0x04000015 RID: 21
		private readonly IDictionary<string, object> fields;

		// Token: 0x020001B6 RID: 438
		private class AttributeArgumentValueEqualityComparer : IEqualityComparer<object>
		{
			// Token: 0x06000D82 RID: 3458 RVA: 0x000209B8 File Offset: 0x0001EBB8
			bool IEqualityComparer<object>.Equals(object x, object y)
			{
				if (x == y)
				{
					return true;
				}
				if (x == null || y == null)
				{
					return false;
				}
				if (x.GetType() != y.GetType())
				{
					return false;
				}
				if (x.GetType().IsArray)
				{
					return CustomAttributeInfo.AttributeArgumentValueEqualityComparer.AsObjectEnumerable(x).SequenceEqual(CustomAttributeInfo.AttributeArgumentValueEqualityComparer.AsObjectEnumerable(y));
				}
				return x.Equals(y);
			}

			// Token: 0x06000D83 RID: 3459 RVA: 0x00020A0E File Offset: 0x0001EC0E
			int IEqualityComparer<object>.GetHashCode(object obj)
			{
				if (obj == null)
				{
					return 0;
				}
				if (obj.GetType().IsArray)
				{
					return CustomAttributeInfo.CombineHashCodes(CustomAttributeInfo.AttributeArgumentValueEqualityComparer.AsObjectEnumerable(obj));
				}
				return obj.GetHashCode();
			}

			// Token: 0x06000D84 RID: 3460 RVA: 0x00020A34 File Offset: 0x0001EC34
			private static IEnumerable<object> AsObjectEnumerable(object array)
			{
				if (array.GetType().GetElementType().GetTypeInfo().IsValueType)
				{
					return ((Array)array).Cast<object>();
				}
				return (IEnumerable<object>)array;
			}
		}
	}
}
