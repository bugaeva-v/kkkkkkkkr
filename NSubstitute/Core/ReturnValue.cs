using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x0200009C RID: 156
	public class ReturnValue : IReturn, ICallIndependentReturn
	{
		// Token: 0x06000237 RID: 567 RVA: 0x00006862 File Offset: 0x00004A62
		[NullableContext(2)]
		public ReturnValue(object value)
		{
			this._value = value;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00006871 File Offset: 0x00004A71
		[NullableContext(2)]
		public object GetReturnValue()
		{
			return this._value;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00006879 File Offset: 0x00004A79
		[return: Nullable(2)]
		public object ReturnFor(CallInfo info)
		{
			return this.GetReturnValue();
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00006881 File Offset: 0x00004A81
		[NullableContext(2)]
		public Type TypeOrNull()
		{
			object value = this._value;
			if (value == null)
			{
				return null;
			}
			return value.GetType();
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00006894 File Offset: 0x00004A94
		public bool CanBeAssignedTo(Type t)
		{
			return this._value.IsCompatibleWith(t);
		}

		// Token: 0x040000A0 RID: 160
		[Nullable(2)]
		private readonly object _value;
	}
}
