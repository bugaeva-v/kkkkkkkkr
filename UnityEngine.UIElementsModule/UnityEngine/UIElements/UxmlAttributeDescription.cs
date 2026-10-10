using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.UIElements
{
	// Token: 0x020002D0 RID: 720
	public abstract class UxmlAttributeDescription
	{
		// Token: 0x0600183F RID: 6207 RVA: 0x000644ED File Offset: 0x000626ED
		protected UxmlAttributeDescription()
		{
			this.use = UxmlAttributeDescription.Use.Optional;
			this.restriction = null;
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x00064507 File Offset: 0x00062707
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x0006450F File Offset: 0x0006270F
		public string name { get; set; }

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x00064518 File Offset: 0x00062718
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x00064530 File Offset: 0x00062730
		public IEnumerable<string> obsoleteNames
		{
			get
			{
				return this.m_ObsoleteNames;
			}
			set
			{
				this.m_ObsoleteNames = value.ToArray<string>();
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x0006453F File Offset: 0x0006273F
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x00064547 File Offset: 0x00062747
		public string type { get; protected set; }

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x00064550 File Offset: 0x00062750
		// (set) Token: 0x06001847 RID: 6215 RVA: 0x00064558 File Offset: 0x00062758
		public string typeNamespace { get; protected set; }

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001848 RID: 6216
		public abstract string defaultValueAsString { get; }

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x00064561 File Offset: 0x00062761
		// (set) Token: 0x0600184A RID: 6218 RVA: 0x00064569 File Offset: 0x00062769
		public UxmlAttributeDescription.Use use { get; set; }

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x00064572 File Offset: 0x00062772
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x0006457A File Offset: 0x0006277A
		public UxmlTypeRestriction restriction { get; set; }

		// Token: 0x0600184D RID: 6221 RVA: 0x00064584 File Offset: 0x00062784
		internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value)
		{
			bool flag = this.name == null && (this.m_ObsoleteNames == null || this.m_ObsoleteNames.Length == 0);
			bool result;
			if (flag)
			{
				Debug.LogError("Attribute description has no name.");
				value = null;
				result = false;
			}
			else
			{
				string text;
				bag.TryGetAttributeValue("name", out text);
				bool flag2 = !string.IsNullOrEmpty(text) && cc.attributeOverrides != null;
				if (flag2)
				{
					for (int i = 0; i < cc.attributeOverrides.Count; i++)
					{
						bool flag3 = cc.attributeOverrides[i].m_ElementName != text;
						if (!flag3)
						{
							bool flag4 = cc.attributeOverrides[i].m_AttributeName != this.name;
							if (flag4)
							{
								bool flag5 = this.m_ObsoleteNames != null;
								if (!flag5)
								{
									goto IL_147;
								}
								bool flag6 = false;
								for (int j = 0; j < this.m_ObsoleteNames.Length; j++)
								{
									bool flag7 = cc.attributeOverrides[i].m_AttributeName == this.m_ObsoleteNames[j];
									if (flag7)
									{
										flag6 = true;
										break;
									}
								}
								bool flag8 = !flag6;
								if (flag8)
								{
									goto IL_147;
								}
							}
							value = cc.attributeOverrides[i].m_Value;
							return true;
						}
						IL_147:;
					}
				}
				bool flag9 = this.name == null;
				if (flag9)
				{
					for (int k = 0; k < this.m_ObsoleteNames.Length; k++)
					{
						bool flag10 = bag.TryGetAttributeValue(this.m_ObsoleteNames[k], out value);
						if (flag10)
						{
							bool flag11 = cc.visualTreeAsset != null;
							if (flag11)
							{
							}
							return true;
						}
					}
					value = null;
					result = false;
				}
				else
				{
					bool flag12 = !bag.TryGetAttributeValue(this.name, out value);
					if (flag12)
					{
						bool flag13 = this.m_ObsoleteNames != null;
						if (flag13)
						{
							for (int l = 0; l < this.m_ObsoleteNames.Length; l++)
							{
								bool flag14 = bag.TryGetAttributeValue(this.m_ObsoleteNames[l], out value);
								if (flag14)
								{
									bool flag15 = cc.visualTreeAsset != null;
									if (flag15)
									{
									}
									return true;
								}
							}
						}
						value = null;
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x000647E8 File Offset: 0x000629E8
		protected bool TryGetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue, ref T value)
		{
			string arg;
			bool flag = this.TryGetValueFromBagAsString(bag, cc, out arg);
			bool result;
			if (flag)
			{
				bool flag2 = converterFunc != null;
				if (flag2)
				{
					value = converterFunc(arg, defaultValue);
				}
				else
				{
					value = defaultValue;
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00064838 File Offset: 0x00062A38
		protected T GetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue)
		{
			bool flag = converterFunc == null;
			if (flag)
			{
				throw new ArgumentNullException("converterFunc");
			}
			string arg;
			bool flag2 = this.TryGetValueFromBagAsString(bag, cc, out arg);
			T result;
			if (flag2)
			{
				result = converterFunc(arg, defaultValue);
			}
			else
			{
				result = defaultValue;
			}
			return result;
		}

		// Token: 0x04000A70 RID: 2672
		protected const string xmlSchemaNamespace = "http://www.w3.org/2001/XMLSchema";

		// Token: 0x04000A72 RID: 2674
		private string[] m_ObsoleteNames;

		// Token: 0x020002D1 RID: 721
		public enum Use
		{
			// Token: 0x04000A78 RID: 2680
			None,
			// Token: 0x04000A79 RID: 2681
			Optional,
			// Token: 0x04000A7A RID: 2682
			Prohibited,
			// Token: 0x04000A7B RID: 2683
			Required
		}
	}
}
