using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x02000422 RID: 1058
	[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
	public readonly struct LocalKeywordSpace : IEquatable<LocalKeywordSpace>
	{
		// Token: 0x060024D9 RID: 9433 RVA: 0x0003E74E File Offset: 0x0003C94E
		[FreeFunction("keywords::GetKeywords", HasExplicitThis = true)]
		private LocalKeyword[] GetKeywords()
		{
			return LocalKeywordSpace.GetKeywords_Injected(ref this);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x0003E756 File Offset: 0x0003C956
		[FreeFunction("keywords::GetKeywordNames", HasExplicitThis = true)]
		private string[] GetKeywordNames()
		{
			return LocalKeywordSpace.GetKeywordNames_Injected(ref this);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x0003E75E File Offset: 0x0003C95E
		[FreeFunction("keywords::GetKeywordCount", HasExplicitThis = true)]
		private uint GetKeywordCount()
		{
			return LocalKeywordSpace.GetKeywordCount_Injected(ref this);
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x0003E768 File Offset: 0x0003C968
		[FreeFunction("keywords::GetKeyword", HasExplicitThis = true)]
		private LocalKeyword GetKeyword(string name)
		{
			LocalKeyword result;
			LocalKeywordSpace.GetKeyword_Injected(ref this, name, out result);
			return result;
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060024DD RID: 9437 RVA: 0x0003E780 File Offset: 0x0003C980
		public LocalKeyword[] keywords
		{
			get
			{
				return this.GetKeywords();
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x0003E798 File Offset: 0x0003C998
		public string[] keywordNames
		{
			get
			{
				return this.GetKeywordNames();
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x0003E7B0 File Offset: 0x0003C9B0
		public uint keywordCount
		{
			get
			{
				return this.GetKeywordCount();
			}
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x0003E7C8 File Offset: 0x0003C9C8
		public LocalKeyword FindKeyword(string name)
		{
			return this.GetKeyword(name);
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x0003E7E4 File Offset: 0x0003C9E4
		public override bool Equals(object o)
		{
			bool result;
			if (o is LocalKeywordSpace)
			{
				LocalKeywordSpace rhs = (LocalKeywordSpace)o;
				result = this.Equals(rhs);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x0003E810 File Offset: 0x0003CA10
		public bool Equals(LocalKeywordSpace rhs)
		{
			return this.m_KeywordSpace == rhs.m_KeywordSpace;
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x0003E834 File Offset: 0x0003CA34
		public static bool operator ==(LocalKeywordSpace lhs, LocalKeywordSpace rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x0003E850 File Offset: 0x0003CA50
		public static bool operator !=(LocalKeywordSpace lhs, LocalKeywordSpace rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x0003E86C File Offset: 0x0003CA6C
		public override int GetHashCode()
		{
			return this.m_KeywordSpace.GetHashCode();
		}

		// Token: 0x060024E6 RID: 9446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern LocalKeyword[] GetKeywords_Injected(ref LocalKeywordSpace _unity_self);

		// Token: 0x060024E7 RID: 9447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string[] GetKeywordNames_Injected(ref LocalKeywordSpace _unity_self);

		// Token: 0x060024E8 RID: 9448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint GetKeywordCount_Injected(ref LocalKeywordSpace _unity_self);

		// Token: 0x060024E9 RID: 9449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetKeyword_Injected(ref LocalKeywordSpace _unity_self, string name, out LocalKeyword ret);

		// Token: 0x04000DAA RID: 3498
		private readonly IntPtr m_KeywordSpace;
	}
}
