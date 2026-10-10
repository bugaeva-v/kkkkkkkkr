using System;

namespace UnityEngine.Assertions
{
	// Token: 0x02000489 RID: 1161
	internal class AssertionMessageUtil
	{
		// Token: 0x0600291B RID: 10523 RVA: 0x00043F8C File Offset: 0x0004218C
		public static string GetMessage(string failureMessage)
		{
			return UnityString.Format("{0} {1}", new object[]
			{
				"Assertion failure.",
				failureMessage
			});
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00043FBC File Offset: 0x000421BC
		public static string GetMessage(string failureMessage, string expected)
		{
			return AssertionMessageUtil.GetMessage(UnityString.Format("{0}{1}{2} {3}", new object[]
			{
				failureMessage,
				Environment.NewLine,
				"Expected:",
				expected
			}));
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00043FFC File Offset: 0x000421FC
		public static string GetEqualityMessage(object actual, object expected, bool expectEqual)
		{
			return AssertionMessageUtil.GetMessage(UnityString.Format("Values are {0}equal.", new object[]
			{
				expectEqual ? "not " : ""
			}), UnityString.Format("{0} {2} {1}", new object[]
			{
				actual,
				expected,
				expectEqual ? "==" : "!="
			}));
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00044060 File Offset: 0x00042260
		public static string NullFailureMessage(object value, bool expectNull)
		{
			return AssertionMessageUtil.GetMessage(UnityString.Format("Value was {0}Null", new object[]
			{
				expectNull ? "not " : ""
			}), UnityString.Format("Value was {0}Null", new object[]
			{
				expectNull ? "" : "not "
			}));
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000440BC File Offset: 0x000422BC
		public static string BooleanFailureMessage(bool expected)
		{
			return AssertionMessageUtil.GetMessage("Value was " + (!expected).ToString(), expected.ToString());
		}

		// Token: 0x04000F9F RID: 3999
		private const string k_Expected = "Expected:";

		// Token: 0x04000FA0 RID: 4000
		private const string k_AssertionFailed = "Assertion failure.";
	}
}
