using System;

namespace NSubstitute.Exceptions
{
	// Token: 0x0200004D RID: 77
	public class ArgumentSetWithIncompatibleValueException : SubstituteException
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00004AEE File Offset: 0x00002CEE
		public ArgumentSetWithIncompatibleValueException(int argumentIndex, Type argumentType, Type typeOfValueWeTriedToAssign) : base(string.Format("Could not set value of type {2} to argument {0} ({1}) because the types are incompatible.", argumentIndex, argumentType.Name, typeOfValueWeTriedToAssign.Name))
		{
		}

		// Token: 0x0400005F RID: 95
		private const string WhatProbablyWentWrong = "Could not set value of type {2} to argument {0} ({1}) because the types are incompatible.";
	}
}
