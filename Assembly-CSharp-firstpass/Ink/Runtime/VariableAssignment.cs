using System;

namespace Ink.Runtime
{
	// Token: 0x02000042 RID: 66
	internal class VariableAssignment : Object
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002AA RID: 682 RVA: 0x000122AA File Offset: 0x000104AA
		// (set) Token: 0x060002AB RID: 683 RVA: 0x000122B2 File Offset: 0x000104B2
		public string variableName { get; protected set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002AC RID: 684 RVA: 0x000122BB File Offset: 0x000104BB
		// (set) Token: 0x060002AD RID: 685 RVA: 0x000122C3 File Offset: 0x000104C3
		public bool isNewDeclaration { get; protected set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002AE RID: 686 RVA: 0x000122CC File Offset: 0x000104CC
		// (set) Token: 0x060002AF RID: 687 RVA: 0x000122D4 File Offset: 0x000104D4
		public bool isGlobal { get; set; }

		// Token: 0x060002B0 RID: 688 RVA: 0x000122DD File Offset: 0x000104DD
		public VariableAssignment(string variableName, bool isNewDeclaration)
		{
			this.variableName = variableName;
			this.isNewDeclaration = isNewDeclaration;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000122F3 File Offset: 0x000104F3
		public VariableAssignment() : this(null, false)
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000122FD File Offset: 0x000104FD
		public override string ToString()
		{
			return "VarAssign to " + this.variableName;
		}
	}
}
