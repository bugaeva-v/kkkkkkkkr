using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020001BD RID: 445
	[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
	internal class UnityLogWriter : TextWriter
	{
		// Token: 0x06001379 RID: 4985 RVA: 0x0001B428 File Offset: 0x00019628
		[ThreadAndSerializationSafe]
		public static void WriteStringToUnityLog(string s)
		{
			bool flag = s == null;
			if (!flag)
			{
				UnityLogWriter.WriteStringToUnityLogImpl(s);
			}
		}

		// Token: 0x0600137A RID: 4986
		[FreeFunction(IsThreadSafe = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void WriteStringToUnityLogImpl(string s);

		// Token: 0x0600137B RID: 4987 RVA: 0x0001B447 File Offset: 0x00019647
		public static void Init()
		{
			Console.SetOut(new UnityLogWriter());
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x0001B458 File Offset: 0x00019658
		public override Encoding Encoding
		{
			get
			{
				return Encoding.UTF8;
			}
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0001B46F File Offset: 0x0001966F
		public override void Write(char value)
		{
			UnityLogWriter.WriteStringToUnityLog(value.ToString());
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0001B47F File Offset: 0x0001967F
		public override void Write(string s)
		{
			UnityLogWriter.WriteStringToUnityLog(s);
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0001B489 File Offset: 0x00019689
		public override void Write(char[] buffer, int index, int count)
		{
			UnityLogWriter.WriteStringToUnityLogImpl(new string(buffer, index, count));
		}
	}
}
