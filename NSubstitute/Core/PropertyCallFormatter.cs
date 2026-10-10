using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Exceptions;

namespace NSubstitute.Core
{
	// Token: 0x020000AB RID: 171
	public class PropertyCallFormatter : IMethodInfoFormatter
	{
		// Token: 0x06000294 RID: 660 RVA: 0x00006CFE File Offset: 0x00004EFE
		public bool CanFormat(MethodInfo methodInfo)
		{
			return this.GetPropertyFromGetterOrSetterCall(methodInfo) != null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00006D10 File Offset: 0x00004F10
		public string Format(MethodInfo methodInfo, IEnumerable<string> arguments)
		{
			PropertyInfo propertyFromGetterOrSetterCall = this.GetPropertyFromGetterOrSetterCall(methodInfo);
			if (propertyFromGetterOrSetterCall == null)
			{
				throw new SubstituteInternalException("The 'CanFormat' method should have guarded it.");
			}
			PropertyInfo propertyInfo = propertyFromGetterOrSetterCall;
			int num = propertyInfo.GetIndexParameters().Length;
			return ((num == 0) ? propertyInfo.Name : this.FormatPropertyIndexer(num, arguments)) + this.FormatArgsAfterIndexParamsAsSetterArgs(num, arguments);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00006D5D File Offset: 0x00004F5D
		[return: Nullable(2)]
		private PropertyInfo GetPropertyFromGetterOrSetterCall(MethodInfo methodInfoOfCall)
		{
			return methodInfoOfCall.GetPropertyFromSetterCallOrNull() ?? methodInfoOfCall.GetPropertyFromGetterCallOrNull();
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00006D6F File Offset: 0x00004F6F
		private string FormatPropertyIndexer(int numberOfIndexParameters, IEnumerable<string> arguments)
		{
			return "this[" + arguments.Take(numberOfIndexParameters).Join(", ") + "]";
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00006D91 File Offset: 0x00004F91
		private bool OnlyHasIndexParameterArgs(int numberOfIndexParameters, IEnumerable<string> arguments)
		{
			return numberOfIndexParameters >= arguments.Count<string>();
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00006D9F File Offset: 0x00004F9F
		private string FormatArgsAfterIndexParamsAsSetterArgs(int numberOfIndexParameters, IEnumerable<string> arguments)
		{
			if (this.OnlyHasIndexParameterArgs(numberOfIndexParameters, arguments))
			{
				return string.Empty;
			}
			return " = " + arguments.Skip(numberOfIndexParameters).Join(", ");
		}
	}
}
