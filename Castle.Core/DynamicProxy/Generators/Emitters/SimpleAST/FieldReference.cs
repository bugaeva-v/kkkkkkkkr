using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000071 RID: 113
	[DebuggerDisplay("{fieldbuilder.Name} ({fieldbuilder.FieldType})")]
	public class FieldReference : Reference
	{
		// Token: 0x06000326 RID: 806 RVA: 0x0000C177 File Offset: 0x0000A377
		public FieldReference(FieldInfo field)
		{
			this.field = field;
			if ((field.Attributes & FieldAttributes.Static) != FieldAttributes.PrivateScope)
			{
				this.isStatic = true;
				this.owner = null;
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000C19F File Offset: 0x0000A39F
		public FieldReference(FieldBuilder fieldbuilder)
		{
			this.fieldbuilder = fieldbuilder;
			this.field = fieldbuilder;
			if ((fieldbuilder.Attributes & FieldAttributes.Static) != FieldAttributes.PrivateScope)
			{
				this.isStatic = true;
				this.owner = null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0000C1CE File Offset: 0x0000A3CE
		public FieldBuilder Fieldbuilder
		{
			get
			{
				return this.fieldbuilder;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000C1D6 File Offset: 0x0000A3D6
		public FieldInfo Reference
		{
			get
			{
				return this.field;
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000C1DE File Offset: 0x0000A3DE
		public override void LoadAddressOfReference(ILGenerator gen)
		{
			if (this.isStatic)
			{
				gen.Emit(OpCodes.Ldsflda, this.Reference);
				return;
			}
			gen.Emit(OpCodes.Ldflda, this.Reference);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000C20B File Offset: 0x0000A40B
		public override void LoadReference(ILGenerator gen)
		{
			if (this.isStatic)
			{
				gen.Emit(OpCodes.Ldsfld, this.Reference);
				return;
			}
			gen.Emit(OpCodes.Ldfld, this.Reference);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000C238 File Offset: 0x0000A438
		public override void StoreReference(ILGenerator gen)
		{
			if (this.isStatic)
			{
				gen.Emit(OpCodes.Stsfld, this.Reference);
				return;
			}
			gen.Emit(OpCodes.Stfld, this.Reference);
		}

		// Token: 0x040000DD RID: 221
		private readonly FieldInfo field;

		// Token: 0x040000DE RID: 222
		private readonly FieldBuilder fieldbuilder;

		// Token: 0x040000DF RID: 223
		private readonly bool isStatic;
	}
}
