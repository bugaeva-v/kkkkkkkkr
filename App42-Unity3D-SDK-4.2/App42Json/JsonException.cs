using System;

namespace App42Json
{
	// Token: 0x02000065 RID: 101
	public class JsonException : ApplicationException
	{
		// Token: 0x06000422 RID: 1058 RVA: 0x00015A01 File Offset: 0x00013C01
		public JsonException()
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00015A09 File Offset: 0x00013C09
		internal JsonException(ParserToken token) : base(string.Format("Invalid token '{0}' in input string", token))
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00015A21 File Offset: 0x00013C21
		internal JsonException(ParserToken token, Exception inner_exception) : base(string.Format("Invalid token '{0}' in input string", token), inner_exception)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00015A3A File Offset: 0x00013C3A
		internal JsonException(int c) : base(string.Format("Invalid character '{0}' in input string", (char)c))
		{
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00015A53 File Offset: 0x00013C53
		internal JsonException(int c, Exception inner_exception) : base(string.Format("Invalid character '{0}' in input string", (char)c), inner_exception)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00015A6D File Offset: 0x00013C6D
		public JsonException(string message) : base(message)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00015A76 File Offset: 0x00013C76
		public JsonException(string message, Exception inner_exception) : base(message, inner_exception)
		{
		}
	}
}
