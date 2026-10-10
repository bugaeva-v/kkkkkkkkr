using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000075 RID: 117
	[DebuggerDisplay("&{OwnerReference}")]
	public class IndirectReference : TypeReference
	{
		// Token: 0x06000333 RID: 819 RVA: 0x0000C344 File Offset: 0x0000A544
		public IndirectReference(TypeReference byRefReference) : base(byRefReference, byRefReference.Type.GetElementType())
		{
			if (!byRefReference.Type.GetTypeInfo().IsByRef)
			{
				throw new ArgumentException("Expected an IsByRef reference", "byRefReference");
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000C37A File Offset: 0x0000A57A
		public override void LoadAddressOfReference(ILGenerator gen)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000C37C File Offset: 0x0000A57C
		public override void LoadReference(ILGenerator gen)
		{
			OpCodeUtil.EmitLoadIndirectOpCodeForType(gen, base.Type);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000C38A File Offset: 0x0000A58A
		public override void StoreReference(ILGenerator gen)
		{
			OpCodeUtil.EmitStoreIndirectOpCodeForType(gen, base.Type);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000C398 File Offset: 0x0000A598
		public static TypeReference WrapIfByRef(TypeReference reference)
		{
			if (!reference.Type.GetTypeInfo().IsByRef)
			{
				return reference;
			}
			return new IndirectReference(reference);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000C3B4 File Offset: 0x0000A5B4
		public static TypeReference[] WrapIfByRef(TypeReference[] references)
		{
			TypeReference[] array = new TypeReference[references.Length];
			for (int i = 0; i < references.Length; i++)
			{
				array[i] = IndirectReference.WrapIfByRef(references[i]);
			}
			return array;
		}
	}
}
