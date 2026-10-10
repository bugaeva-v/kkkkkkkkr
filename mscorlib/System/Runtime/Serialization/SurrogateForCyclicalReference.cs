using System;
using System.Security;

namespace System.Runtime.Serialization
{
	// Token: 0x0200065D RID: 1629
	internal sealed class SurrogateForCyclicalReference : ISerializationSurrogate
	{
		// Token: 0x06003CD7 RID: 15575 RVA: 0x000D284D File Offset: 0x000D0A4D
		internal SurrogateForCyclicalReference(ISerializationSurrogate innerSurrogate)
		{
			if (innerSurrogate == null)
			{
				throw new ArgumentNullException("innerSurrogate");
			}
			this.innerSurrogate = innerSurrogate;
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x000D286A File Offset: 0x000D0A6A
		[SecurityCritical]
		public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{
			this.innerSurrogate.GetObjectData(obj, info, context);
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x000D287A File Offset: 0x000D0A7A
		[SecurityCritical]
		public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			return this.innerSurrogate.SetObjectData(obj, info, context, selector);
		}

		// Token: 0x04002737 RID: 10039
		private ISerializationSurrogate innerSurrogate;
	}
}
