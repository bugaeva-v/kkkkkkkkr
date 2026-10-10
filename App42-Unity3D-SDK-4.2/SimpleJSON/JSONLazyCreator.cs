using System;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x020000AD RID: 173
	internal class JSONLazyCreator : JSONNode
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00029C25 File Offset: 0x00027E25
		public override JSONNodeType Tag
		{
			get
			{
				return JSONNodeType.None;
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00029C28 File Offset: 0x00027E28
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00029C3E File Offset: 0x00027E3E
		public JSONLazyCreator(JSONNode aNode)
		{
			this.m_Node = aNode;
			this.m_Key = null;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00029C54 File Offset: 0x00027E54
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
			this.m_Node = aNode;
			this.m_Key = aKey;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00029C6A File Offset: 0x00027E6A
		private void Set(JSONNode aVal)
		{
			if (this.m_Key == null)
			{
				this.m_Node.Add(aVal);
			}
			else
			{
				this.m_Node.Add(this.m_Key, aVal);
			}
			this.m_Node = null;
		}

		// Token: 0x17000083 RID: 131
		public override JSONNode this[int aIndex]
		{
			get
			{
				return new JSONLazyCreator(this);
			}
			set
			{
				JSONArray jsonarray = new JSONArray();
				jsonarray.Add(value);
				this.Set(jsonarray);
			}
		}

		// Token: 0x17000084 RID: 132
		public override JSONNode this[string aKey]
		{
			get
			{
				return new JSONLazyCreator(this, aKey);
			}
			set
			{
				JSONObject jsonobject = new JSONObject();
				jsonobject.Add(aKey, value);
				this.Set(jsonobject);
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00029CF4 File Offset: 0x00027EF4
		public override void Add(JSONNode aItem)
		{
			JSONArray jsonarray = new JSONArray();
			jsonarray.Add(aItem);
			this.Set(jsonarray);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00029D18 File Offset: 0x00027F18
		public override void Add(string aKey, JSONNode aItem)
		{
			JSONObject jsonobject = new JSONObject();
			jsonobject.Add(aKey, aItem);
			this.Set(jsonobject);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00029D3A File Offset: 0x00027F3A
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return b == null || object.ReferenceEquals(a, b);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00029D48 File Offset: 0x00027F48
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return !(a == b);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00029D54 File Offset: 0x00027F54
		public override bool Equals(object obj)
		{
			return obj == null || object.ReferenceEquals(this, obj);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00029D62 File Offset: 0x00027F62
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00029D68 File Offset: 0x00027F68
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00029D8C File Offset: 0x00027F8C
		public override int AsInt
		{
			get
			{
				JSONNumber aVal = new JSONNumber(0.0);
				this.Set(aVal);
				return 0;
			}
			set
			{
				JSONNumber aVal = new JSONNumber((double)value);
				this.Set(aVal);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00029DA8 File Offset: 0x00027FA8
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00029DD0 File Offset: 0x00027FD0
		public override float AsFloat
		{
			get
			{
				JSONNumber aVal = new JSONNumber(0.0);
				this.Set(aVal);
				return 0f;
			}
			set
			{
				JSONNumber aVal = new JSONNumber((double)value);
				this.Set(aVal);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00029DEC File Offset: 0x00027FEC
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00029E18 File Offset: 0x00028018
		public override double AsDouble
		{
			get
			{
				JSONNumber aVal = new JSONNumber(0.0);
				this.Set(aVal);
				return 0.0;
			}
			set
			{
				JSONNumber aVal = new JSONNumber(value);
				this.Set(aVal);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00029E34 File Offset: 0x00028034
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00029E50 File Offset: 0x00028050
		public override bool AsBool
		{
			get
			{
				JSONBool aVal = new JSONBool(false);
				this.Set(aVal);
				return false;
			}
			set
			{
				JSONBool aVal = new JSONBool(value);
				this.Set(aVal);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00029E6C File Offset: 0x0002806C
		public override JSONArray AsArray
		{
			get
			{
				JSONArray jsonarray = new JSONArray();
				this.Set(jsonarray);
				return jsonarray;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00029E88 File Offset: 0x00028088
		public override JSONObject AsObject
		{
			get
			{
				JSONObject jsonobject = new JSONObject();
				this.Set(jsonobject);
				return jsonobject;
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00029EA3 File Offset: 0x000280A3
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			aSB.Append("null");
		}

		// Token: 0x040002A2 RID: 674
		private JSONNode m_Node;

		// Token: 0x040002A3 RID: 675
		private string m_Key;
	}
}
