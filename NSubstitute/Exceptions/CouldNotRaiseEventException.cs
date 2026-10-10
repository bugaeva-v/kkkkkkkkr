using System;

namespace NSubstitute.Exceptions
{
	// Token: 0x02000053 RID: 83
	public class CouldNotRaiseEventException : SubstituteException
	{
		// Token: 0x0600011F RID: 287 RVA: 0x00004B8F File Offset: 0x00002D8F
		public CouldNotRaiseEventException() : base("Make sure you are using Raise.Event() as part of an event subscription on a substitute.\nFor example:\n\tmySub.Clicked += Raise.Event();\n\nIf you substituted for a class rather than an interface, check that the event on your substitute is virtual/abstract.\nEvents on classes cannot be raised if they are not declared virtual or abstract.\n\nNote that the source of the problem may be prior to where this exception was thrown (possibly in a previous test!).\nFor example:\n\tvar notASub = new Button();\n\tnotASub.Clicked += Raise.Event(); // <-- Problem here. This is not a substitute.\n\tvar sub = Substitute.For<IController>();\n\tsub.Load(); // <-- Exception thrown here. NSubstitute thinks the earlier Raise.Event() was meant for this call.")
		{
		}

		// Token: 0x04000063 RID: 99
		protected const string WhatProbablyWentWrong = "Make sure you are using Raise.Event() as part of an event subscription on a substitute.\nFor example:\n\tmySub.Clicked += Raise.Event();\n\nIf you substituted for a class rather than an interface, check that the event on your substitute is virtual/abstract.\nEvents on classes cannot be raised if they are not declared virtual or abstract.\n\nNote that the source of the problem may be prior to where this exception was thrown (possibly in a previous test!).\nFor example:\n\tvar notASub = new Button();\n\tnotASub.Clicked += Raise.Event(); // <-- Problem here. This is not a substitute.\n\tvar sub = Substitute.For<IController>();\n\tsub.Load(); // <-- Exception thrown here. NSubstitute thinks the earlier Raise.Event() was meant for this call.";
	}
}
