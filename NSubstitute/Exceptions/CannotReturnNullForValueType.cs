using System;

namespace NSubstitute.Exceptions
{
	// Token: 0x02000051 RID: 81
	public class CannotReturnNullForValueType : SubstituteException
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00004B56 File Offset: 0x00002D56
		public CannotReturnNullForValueType(Type valueType) : base(string.Format("Cannot return null for {0} because it is a value type. If you want to return the default value for this type use \"default({0})\".", valueType.Name))
		{
		}

		// Token: 0x04000060 RID: 96
		private const string Description = "Cannot return null for {0} because it is a value type. If you want to return the default value for this type use \"default({0})\".";
	}
}
