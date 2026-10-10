using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020002B5 RID: 693
	internal class StyleVariableContext
	{
		// Token: 0x06001783 RID: 6019 RVA: 0x0006253C File Offset: 0x0006073C
		public void Add(StyleVariable sv)
		{
			int hashCode = sv.GetHashCode();
			int num = this.m_SortedHash.BinarySearch(hashCode);
			bool flag = num >= 0;
			if (!flag)
			{
				this.m_SortedHash.Insert(~num, hashCode);
				this.m_Variables.Add(sv);
				this.m_VariableHash = ((this.m_Variables.Count == 0) ? sv.GetHashCode() : (this.m_VariableHash * 397 ^ sv.GetHashCode()));
			}
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x000625CC File Offset: 0x000607CC
		public void AddInitialRange(StyleVariableContext other)
		{
			bool flag = other.m_Variables.Count > 0;
			if (flag)
			{
				Debug.Assert(this.m_Variables.Count == 0);
				this.m_VariableHash = other.m_VariableHash;
				this.m_Variables.AddRange(other.m_Variables);
				this.m_SortedHash.AddRange(other.m_SortedHash);
			}
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00062634 File Offset: 0x00060834
		public void Clear()
		{
			bool flag = this.m_Variables.Count > 0;
			if (flag)
			{
				this.m_Variables.Clear();
				this.m_VariableHash = 0;
				this.m_SortedHash.Clear();
			}
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00062675 File Offset: 0x00060875
		public StyleVariableContext()
		{
			this.m_Variables = new List<StyleVariable>();
			this.m_VariableHash = 0;
			this.m_SortedHash = new List<int>();
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0006269C File Offset: 0x0006089C
		public StyleVariableContext(StyleVariableContext other)
		{
			this.m_Variables = new List<StyleVariable>(other.m_Variables);
			this.m_VariableHash = other.m_VariableHash;
			this.m_SortedHash = new List<int>(other.m_SortedHash);
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x000626D4 File Offset: 0x000608D4
		public bool TryFindVariable(string name, out StyleVariable v)
		{
			for (int i = this.m_Variables.Count - 1; i >= 0; i--)
			{
				bool flag = this.m_Variables[i].name == name;
				if (flag)
				{
					v = this.m_Variables[i];
					return true;
				}
			}
			v = default(StyleVariable);
			return false;
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00062744 File Offset: 0x00060944
		public int GetVariableHash()
		{
			return this.m_VariableHash;
		}

		// Token: 0x04000A24 RID: 2596
		public static readonly StyleVariableContext none = new StyleVariableContext();

		// Token: 0x04000A25 RID: 2597
		private int m_VariableHash;

		// Token: 0x04000A26 RID: 2598
		private List<StyleVariable> m_Variables;

		// Token: 0x04000A27 RID: 2599
		private List<int> m_SortedHash;
	}
}
