using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000421 RID: 1057
	[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[UsedByNativeCode]
	public readonly struct LocalKeyword : IEquatable<LocalKeyword>
	{
		// Token: 0x060024C3 RID: 9411 RVA: 0x0003E4E8 File Offset: 0x0003C6E8
		[FreeFunction("keywords::IsKeywordOverridable")]
		private static bool IsOverridable(LocalKeyword kw)
		{
			return LocalKeyword.IsOverridable_Injected(ref kw);
		}

		// Token: 0x060024C4 RID: 9412
		[FreeFunction("ShaderScripting::GetKeywordCount")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint GetShaderKeywordCount(Shader shader);

		// Token: 0x060024C5 RID: 9413
		[FreeFunction("ShaderScripting::GetKeywordIndex")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint GetShaderKeywordIndex(Shader shader, string keyword);

		// Token: 0x060024C6 RID: 9414
		[FreeFunction("ShaderScripting::GetKeywordCount")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint GetComputeShaderKeywordCount(ComputeShader shader);

		// Token: 0x060024C7 RID: 9415
		[FreeFunction("ShaderScripting::GetKeywordIndex")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword);

		// Token: 0x060024C8 RID: 9416 RVA: 0x0003E4F1 File Offset: 0x0003C6F1
		[FreeFunction("keywords::GetKeywordType")]
		private static ShaderKeywordType GetKeywordType(LocalKeywordSpace spaceInfo, uint keyword)
		{
			return LocalKeyword.GetKeywordType_Injected(ref spaceInfo, keyword);
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x0003E4FB File Offset: 0x0003C6FB
		[FreeFunction("keywords::IsKeywordValid")]
		private static bool IsValid(LocalKeywordSpace spaceInfo, uint keyword)
		{
			return LocalKeyword.IsValid_Injected(ref spaceInfo, keyword);
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x0003E508 File Offset: 0x0003C708
		public string name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060024CB RID: 9419 RVA: 0x0003E520 File Offset: 0x0003C720
		public bool isOverridable
		{
			get
			{
				return LocalKeyword.IsOverridable(this);
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x0003E540 File Offset: 0x0003C740
		public bool isValid
		{
			get
			{
				return LocalKeyword.IsValid(this.m_SpaceInfo, this.m_Index);
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060024CD RID: 9421 RVA: 0x0003E564 File Offset: 0x0003C764
		public ShaderKeywordType type
		{
			get
			{
				return LocalKeyword.GetKeywordType(this.m_SpaceInfo, this.m_Index);
			}
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x0003E588 File Offset: 0x0003C788
		public LocalKeyword(Shader shader, string name)
		{
			bool flag = shader == null;
			if (flag)
			{
				Debug.LogError("Cannot initialize a LocalKeyword with a null Shader.");
			}
			this.m_SpaceInfo = shader.keywordSpace;
			this.m_Name = name;
			this.m_Index = LocalKeyword.GetShaderKeywordIndex(shader, name);
			bool flag2 = this.m_Index >= LocalKeyword.GetShaderKeywordCount(shader);
			if (flag2)
			{
				Debug.LogErrorFormat("Local keyword {0} doesn't exist in the shader.", new object[]
				{
					name
				});
			}
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x0003E5F8 File Offset: 0x0003C7F8
		public LocalKeyword(ComputeShader shader, string name)
		{
			bool flag = shader == null;
			if (flag)
			{
				Debug.LogError("Cannot initialize a LocalKeyword with a null ComputeShader.");
			}
			this.m_SpaceInfo = shader.keywordSpace;
			this.m_Name = name;
			this.m_Index = LocalKeyword.GetComputeShaderKeywordIndex(shader, name);
			bool flag2 = this.m_Index >= LocalKeyword.GetComputeShaderKeywordCount(shader);
			if (flag2)
			{
				Debug.LogErrorFormat("Local keyword {0} doesn't exist in the compute shader.", new object[]
				{
					name
				});
			}
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x0003E668 File Offset: 0x0003C868
		public override string ToString()
		{
			return this.m_Name;
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x0003E680 File Offset: 0x0003C880
		public override bool Equals(object o)
		{
			bool result;
			if (o is LocalKeyword)
			{
				LocalKeyword rhs = (LocalKeyword)o;
				result = this.Equals(rhs);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x0003E6AC File Offset: 0x0003C8AC
		public bool Equals(LocalKeyword rhs)
		{
			return this.m_SpaceInfo == rhs.m_SpaceInfo && this.m_Index == rhs.m_Index;
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x0003E6E4 File Offset: 0x0003C8E4
		public static bool operator ==(LocalKeyword lhs, LocalKeyword rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x0003E700 File Offset: 0x0003C900
		public static bool operator !=(LocalKeyword lhs, LocalKeyword rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x0003E71C File Offset: 0x0003C91C
		public override int GetHashCode()
		{
			return this.m_Index.GetHashCode() ^ this.m_SpaceInfo.GetHashCode();
		}

		// Token: 0x060024D6 RID: 9430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsOverridable_Injected(ref LocalKeyword kw);

		// Token: 0x060024D7 RID: 9431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ShaderKeywordType GetKeywordType_Injected(ref LocalKeywordSpace spaceInfo, uint keyword);

		// Token: 0x060024D8 RID: 9432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsValid_Injected(ref LocalKeywordSpace spaceInfo, uint keyword);

		// Token: 0x04000DA7 RID: 3495
		internal readonly LocalKeywordSpace m_SpaceInfo;

		// Token: 0x04000DA8 RID: 3496
		internal readonly string m_Name;

		// Token: 0x04000DA9 RID: 3497
		internal readonly uint m_Index;
	}
}
