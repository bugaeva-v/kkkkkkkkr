using System;
using System.Collections;
using System.Reflection;
using System.Security;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000201 RID: 513
	[RequiredByNativeCode]
	internal class SetupCoroutine
	{
		// Token: 0x060016B0 RID: 5808 RVA: 0x0002445C File Offset: 0x0002265C
		[RequiredByNativeCode]
		[SecuritySafeCritical]
		public unsafe static void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress)
		{
			bool flag = returnValueAddress == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("Return value address cannot be 0.", "returnValueAddress");
			}
			*(byte*)((void*)returnValueAddress) = (enumerator.MoveNext() ? 1 : 0);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00024498 File Offset: 0x00022698
		[RequiredByNativeCode]
		public static object InvokeMember(object behaviour, string name, object variable)
		{
			object[] args = null;
			bool flag = variable != null;
			if (flag)
			{
				args = new object[]
				{
					variable
				};
			}
			return behaviour.GetType().InvokeMember(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, behaviour, args, null, null, null);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x000244D8 File Offset: 0x000226D8
		public static object InvokeStatic(Type klass, string name, object variable)
		{
			object[] args = null;
			bool flag = variable != null;
			if (flag)
			{
				args = new object[]
				{
					variable
				};
			}
			return klass.InvokeMember(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, null, args, null, null, null);
		}
	}
}
