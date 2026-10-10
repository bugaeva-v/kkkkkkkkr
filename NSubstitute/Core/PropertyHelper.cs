using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Core.Arguments;
using NSubstitute.Exceptions;

namespace NSubstitute.Core
{
	// Token: 0x020000AC RID: 172
	public class PropertyHelper : IPropertyHelper
	{
		// Token: 0x0600029B RID: 667 RVA: 0x00006DD4 File Offset: 0x00004FD4
		public PropertyHelper(ICallFactory callFactory, IArgumentSpecificationCompatibilityTester argSpecCompatTester)
		{
			this._callFactory = callFactory;
			this._argSpecCompatTester = argSpecCompatTester;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00006DEC File Offset: 0x00004FEC
		public bool IsCallToSetAReadWriteProperty(ICall call)
		{
			PropertyInfo propertyFromSetterCall = this.GetPropertyFromSetterCall(call);
			return this.PropertySetterExistsAndHasAGetMethod(propertyFromSetterCall);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00006E08 File Offset: 0x00005008
		[NullableContext(2)]
		private bool PropertySetterExistsAndHasAGetMethod([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] PropertyInfo propertySetter)
		{
			return propertySetter != null && propertySetter.GetGetMethod(true) != null;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00006E22 File Offset: 0x00005022
		[return: Nullable(2)]
		private PropertyInfo GetPropertyFromSetterCall(ICall call)
		{
			return call.GetMethodInfo().GetPropertyFromSetterCallOrNull();
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00006E30 File Offset: 0x00005030
		public ICall CreateCallToPropertyGetterFromSetterCall(ICall callToSetter)
		{
			PropertyInfo propertyFromSetterCall = this.GetPropertyFromSetterCall(callToSetter);
			if (!this.PropertySetterExistsAndHasAGetMethod(propertyFromSetterCall))
			{
				string str = "Could not find a GetMethod for \"";
				MethodInfo methodInfo = callToSetter.GetMethodInfo();
				throw new InvalidOperationException(str + ((methodInfo != null) ? methodInfo.ToString() : null) + "\"");
			}
			MethodInfo getMethod = propertyFromSetterCall.GetGetMethod(true);
			if (getMethod == null)
			{
				throw new SubstituteInternalException("A property with a getter expected.");
			}
			object[] getterArgs = PropertyHelper.SkipLast<object>(callToSetter.GetOriginalArguments());
			IList<IArgumentSpecification> getterCallSpecificationsFromSetterCall = this.GetGetterCallSpecificationsFromSetterCall(callToSetter);
			return this._callFactory.Create(getMethod, getterArgs, callToSetter.Target(), getterCallSpecificationsFromSetterCall);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00006EB4 File Offset: 0x000050B4
		private IList<IArgumentSpecification> GetGetterCallSpecificationsFromSetterCall(ICall callToSetter)
		{
			object argumentValue = callToSetter.GetOriginalArguments().Last<object>();
			Type parameterType = callToSetter.GetParameterInfos().Last<IParameterInfo>().ParameterType;
			IList<IArgumentSpecification> list = callToSetter.GetArgumentSpecifications();
			if (list.Count == 0)
			{
				return list;
			}
			if (this._argSpecCompatTester.IsSpecificationCompatible(list.Last<IArgumentSpecification>(), argumentValue, parameterType))
			{
				list = PropertyHelper.SkipLast<IArgumentSpecification>(list);
			}
			return list;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00006F0C File Offset: 0x0000510C
		private static T[] SkipLast<T>(ICollection<T> collection)
		{
			return collection.Take(collection.Count - 1).ToArray<T>();
		}

		// Token: 0x040000AE RID: 174
		private readonly ICallFactory _callFactory;

		// Token: 0x040000AF RID: 175
		private readonly IArgumentSpecificationCompatibilityTester _argSpecCompatTester;
	}
}
