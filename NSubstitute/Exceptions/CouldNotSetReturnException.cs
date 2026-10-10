using System;

namespace NSubstitute.Exceptions
{
	// Token: 0x02000054 RID: 84
	public abstract class CouldNotSetReturnException : SubstituteException
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00004B9C File Offset: 0x00002D9C
		protected CouldNotSetReturnException(string s) : base(s + "\n\nMake sure you called Returns() after calling your substitute (for example: mySub.SomeMethod().Returns(value)),\nand that you are not configuring other substitutes within Returns() (for example, avoid this: mySub.SomeMethod().Returns(ConfigOtherSub())).\n\nIf you substituted for a class rather than an interface, check that the call to your substitute was on a virtual/abstract member.\nReturn values cannot be configured for non-virtual/non-abstract members.\n\nCorrect use:\n\tmySub.SomeMethod().Returns(returnValue);\n\nPotentially problematic use:\n\tmySub.SomeMethod().Returns(ConfigOtherSub());\nInstead try:\n\tvar returnValue = ConfigOtherSub();\n\tmySub.SomeMethod().Returns(returnValue);\n")
		{
		}

		// Token: 0x04000064 RID: 100
		protected const string WhatProbablyWentWrong = "Make sure you called Returns() after calling your substitute (for example: mySub.SomeMethod().Returns(value)),\nand that you are not configuring other substitutes within Returns() (for example, avoid this: mySub.SomeMethod().Returns(ConfigOtherSub())).\n\nIf you substituted for a class rather than an interface, check that the call to your substitute was on a virtual/abstract member.\nReturn values cannot be configured for non-virtual/non-abstract members.\n\nCorrect use:\n\tmySub.SomeMethod().Returns(returnValue);\n\nPotentially problematic use:\n\tmySub.SomeMethod().Returns(ConfigOtherSub());\nInstead try:\n\tvar returnValue = ConfigOtherSub();\n\tmySub.SomeMethod().Returns(returnValue);\n";
	}
}
