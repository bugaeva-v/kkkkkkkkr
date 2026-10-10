using System;

namespace NSubstitute.Exceptions
{
	// Token: 0x0200004B RID: 75
	public class ArgumentIsNotOutOrRefException : SubstituteException
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00004AC7 File Offset: 0x00002CC7
		public ArgumentIsNotOutOrRefException(int argumentIndex, Type argumentType) : base(string.Format("Could not set argument {0} ({1}) as it is not an out or ref argument.", argumentIndex, argumentType.Name))
		{
		}

		// Token: 0x0400005E RID: 94
		private const string WhatProbablyWentWrong = "Could not set argument {0} ({1}) as it is not an out or ref argument.";
	}
}
