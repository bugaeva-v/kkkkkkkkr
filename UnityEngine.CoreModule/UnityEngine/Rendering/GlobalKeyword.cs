using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000420 RID: 1056
	[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	public readonly struct GlobalKeyword
	{
		// Token: 0x060024BC RID: 9404
		[FreeFunction("ShaderScripting::GetGlobalKeywordCount")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint GetGlobalKeywordCount();

		// Token: 0x060024BD RID: 9405
		[FreeFunction("ShaderScripting::GetGlobalKeywordIndex")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint GetGlobalKeywordIndex(string keyword);

		// Token: 0x060024BE RID: 9406
		[FreeFunction("ShaderScripting::CreateGlobalKeyword")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CreateGlobalKeyword(string keyword);

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x0003E44C File Offset: 0x0003C64C
		public string name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x0003E464 File Offset: 0x0003C664
		public static GlobalKeyword Create(string name)
		{
			GlobalKeyword.CreateGlobalKeyword(name);
			return new GlobalKeyword(name);
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x0003E484 File Offset: 0x0003C684
		public GlobalKeyword(string name)
		{
			this.m_Name = name;
			this.m_Index = GlobalKeyword.GetGlobalKeywordIndex(name);
			bool flag = this.m_Index >= GlobalKeyword.GetGlobalKeywordCount();
			if (flag)
			{
				Debug.LogErrorFormat("Global keyword {0} doesn't exist.", new object[]
				{
					name
				});
			}
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x0003E4D0 File Offset: 0x0003C6D0
		public override string ToString()
		{
			return this.m_Name;
		}

		// Token: 0x04000DA5 RID: 3493
		internal readonly string m_Name;

		// Token: 0x04000DA6 RID: 3494
		internal readonly uint m_Index;
	}
}
