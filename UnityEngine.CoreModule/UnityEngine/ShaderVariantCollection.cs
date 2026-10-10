using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200023C RID: 572
	public sealed class ShaderVariantCollection : Object
	{
		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001882 RID: 6274
		public extern int shaderCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001883 RID: 6275
		public extern int variantCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001884 RID: 6276
		public extern bool isWarmedUp { [NativeName("IsWarmedUp")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001885 RID: 6277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddVariant(Shader shader, PassType passType, [Unmarshalled] string[] keywords);

		// Token: 0x06001886 RID: 6278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool RemoveVariant(Shader shader, PassType passType, [Unmarshalled] string[] keywords);

		// Token: 0x06001887 RID: 6279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool ContainsVariant(Shader shader, PassType passType, [Unmarshalled] string[] keywords);

		// Token: 0x06001888 RID: 6280
		[NativeName("ClearVariants")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Clear();

		// Token: 0x06001889 RID: 6281
		[NativeName("WarmupShaders")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void WarmUp();

		// Token: 0x0600188A RID: 6282
		[NativeName("CreateFromScript")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] ShaderVariantCollection svc);

		// Token: 0x0600188B RID: 6283 RVA: 0x00027A7F File Offset: 0x00025C7F
		public ShaderVariantCollection()
		{
			ShaderVariantCollection.Internal_Create(this);
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00027A90 File Offset: 0x00025C90
		public bool Add(ShaderVariantCollection.ShaderVariant variant)
		{
			return this.AddVariant(variant.shader, variant.passType, variant.keywords);
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00027ABC File Offset: 0x00025CBC
		public bool Remove(ShaderVariantCollection.ShaderVariant variant)
		{
			return this.RemoveVariant(variant.shader, variant.passType, variant.keywords);
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00027AE8 File Offset: 0x00025CE8
		public bool Contains(ShaderVariantCollection.ShaderVariant variant)
		{
			return this.ContainsVariant(variant.shader, variant.passType, variant.keywords);
		}

		// Token: 0x0200023D RID: 573
		public struct ShaderVariant
		{
			// Token: 0x0600188F RID: 6287
			[NativeConditional("UNITY_EDITOR")]
			[FreeFunction]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern string CheckShaderVariant(Shader shader, PassType passType, string[] keywords);

			// Token: 0x06001890 RID: 6288 RVA: 0x00027B12 File Offset: 0x00025D12
			public ShaderVariant(Shader shader, PassType passType, params string[] keywords)
			{
				this.shader = shader;
				this.passType = passType;
				this.keywords = keywords;
			}

			// Token: 0x04000840 RID: 2112
			public Shader shader;

			// Token: 0x04000841 RID: 2113
			public PassType passType;

			// Token: 0x04000842 RID: 2114
			public string[] keywords;
		}
	}
}
