using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x020000A7 RID: 167
	public class JSONArray : JSONNode
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00028FE4 File Offset: 0x000271E4
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00028FEC File Offset: 0x000271EC
		public override bool Inline
		{
			get
			{
				return this.inline;
			}
			set
			{
				this.inline = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00028FF5 File Offset: 0x000271F5
		public override JSONNodeType Tag
		{
			get
			{
				return JSONNodeType.Array;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00028FF8 File Offset: 0x000271F8
		public override bool IsArray
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00028FFB File Offset: 0x000271FB
		public override JSONNode.Enumerator GetEnumerator()
		{
			return new JSONNode.Enumerator(this.m_List.GetEnumerator());
		}

		// Token: 0x17000068 RID: 104
		public override JSONNode this[int aIndex]
		{
			get
			{
				if (aIndex < 0 || aIndex >= this.m_List.Count)
				{
					return new JSONLazyCreator(this);
				}
				return this.m_List[aIndex];
			}
			set
			{
				if (value == null)
				{
					value = JSONNull.CreateOrGet();
				}
				if (aIndex < 0 || aIndex >= this.m_List.Count)
				{
					this.m_List.Add(value);
					return;
				}
				this.m_List[aIndex] = value;
			}
		}

		// Token: 0x17000069 RID: 105
		public override JSONNode this[string aKey]
		{
			get
			{
				return new JSONLazyCreator(this);
			}
			set
			{
				if (value == null)
				{
					value = JSONNull.CreateOrGet();
				}
				this.m_List.Add(value);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00029098 File Offset: 0x00027298
		public override int Count
		{
			get
			{
				return this.m_List.Count;
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x000290A5 File Offset: 0x000272A5
		public override void Add(string aKey, JSONNode aItem)
		{
			if (aItem == null)
			{
				aItem = JSONNull.CreateOrGet();
			}
			this.m_List.Add(aItem);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x000290C4 File Offset: 0x000272C4
		public override JSONNode Remove(int aIndex)
		{
			if (aIndex < 0 || aIndex >= this.m_List.Count)
			{
				return null;
			}
			JSONNode result = this.m_List[aIndex];
			this.m_List.RemoveAt(aIndex);
			return result;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x000290FF File Offset: 0x000272FF
		public override JSONNode Remove(JSONNode aNode)
		{
			this.m_List.Remove(aNode);
			return aNode;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x000292A0 File Offset: 0x000274A0
		public override IEnumerable<JSONNode> Children
		{
			get
			{
				foreach (JSONNode N in this.m_List)
				{
					yield return N;
				}
				yield break;
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x000292C0 File Offset: 0x000274C0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			aSB.Append('[');
			int count = this.m_List.Count;
			if (this.inline)
			{
				aMode = JSONTextMode.Compact;
			}
			for (int i = 0; i < count; i++)
			{
				if (i > 0)
				{
					aSB.Append(',');
				}
				if (aMode == JSONTextMode.Indent)
				{
					aSB.AppendLine();
				}
				if (aMode == JSONTextMode.Indent)
				{
					aSB.Append(' ', aIndent + aIndentInc);
				}
				this.m_List[i].WriteToStringBuilder(aSB, aIndent + aIndentInc, aIndentInc, aMode);
			}
			if (aMode == JSONTextMode.Indent)
			{
				aSB.AppendLine().Append(' ', aIndent);
			}
			aSB.Append(']');
		}

		// Token: 0x04000299 RID: 665
		private List<JSONNode> m_List = new List<JSONNode>();

		// Token: 0x0400029A RID: 666
		private bool inline;
	}
}
