using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x02000076 RID: 118
	public class DefaultForType : IDefaultForType
	{
		// Token: 0x060001BB RID: 443 RVA: 0x00006230 File Offset: 0x00004430
		[return: Nullable(2)]
		public object GetDefaultFor(Type type)
		{
			if (this.IsVoid(type))
			{
				return null;
			}
			if (type.GetTypeInfo().IsValueType)
			{
				return this.DefaultInstanceOfValueType(type);
			}
			return null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00006253 File Offset: 0x00004453
		private bool IsVoid(Type returnType)
		{
			return returnType == typeof(void);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00006268 File Offset: 0x00004468
		private object DefaultInstanceOfValueType(Type returnType)
		{
			if (returnType == typeof(bool))
			{
				return DefaultForType.BoxedBoolean;
			}
			if (returnType == typeof(int))
			{
				return DefaultForType.BoxedInt;
			}
			if (returnType == typeof(long))
			{
				return DefaultForType.BoxedLong;
			}
			if (returnType == typeof(double))
			{
				return DefaultForType.BoxedDouble;
			}
			return Activator.CreateInstance(returnType);
		}

		// Token: 0x04000094 RID: 148
		private static readonly object BoxedBoolean = false;

		// Token: 0x04000095 RID: 149
		private static readonly object BoxedInt = 0;

		// Token: 0x04000096 RID: 150
		private static readonly object BoxedLong = 0L;

		// Token: 0x04000097 RID: 151
		private static readonly object BoxedDouble = 0.0;
	}
}
