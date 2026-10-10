using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000101 RID: 257
	[Serializable]
	public class StoreSpecificIds : IEnumerable, ISerializationCallbackReceiver
	{
		// Token: 0x060004C0 RID: 1216 RVA: 0x0000A4A1 File Offset: 0x000086A1
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.m_productIdDictionary.GetEnumerator();
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000A4B3 File Offset: 0x000086B3
		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return this.m_productIdDictionary.GetEnumerator();
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000A4C8 File Offset: 0x000086C8
		public void Add(string id, params string[] stores)
		{
			foreach (string key in stores)
			{
				this.m_productIdDictionary[key] = id;
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000A4F8 File Offset: 0x000086F8
		public void Add(string id, params object[] stores)
		{
			foreach (object obj in stores)
			{
				this.m_productIdDictionary[obj.ToString()] = id;
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000A52B File Offset: 0x0000872B
		internal string SpecificIDForStore(string store, string defaultValue)
		{
			if (!this.m_productIdDictionary.ContainsKey(store))
			{
				return defaultValue;
			}
			return this.m_productIdDictionary[store];
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0000A54C File Offset: 0x0000874C
		public void OnBeforeSerialize()
		{
			this.m_storeNames.Clear();
			this.m_productIds.Clear();
			foreach (KeyValuePair<string, string> keyValuePair in this.m_productIdDictionary)
			{
				this.m_storeNames.Add(keyValuePair.Key);
				this.m_productIds.Add(keyValuePair.Value);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000A5D4 File Offset: 0x000087D4
		public void OnAfterDeserialize()
		{
			this.m_productIdDictionary = new Dictionary<string, string>();
			for (int num = 0; num != this.m_productIdDictionary.Count; num++)
			{
				this.m_productIdDictionary.Add(this.m_storeNames[num], this.m_productIds[num]);
			}
		}

		// Token: 0x04000225 RID: 549
		private Dictionary<string, string> m_productIdDictionary = new Dictionary<string, string>();

		// Token: 0x04000226 RID: 550
		[FormerlySerializedAs("m_keys")]
		[SerializeField]
		private List<string> m_storeNames = new List<string>();

		// Token: 0x04000227 RID: 551
		[FormerlySerializedAs("m_values")]
		[SerializeField]
		private List<string> m_productIds = new List<string>();
	}
}
