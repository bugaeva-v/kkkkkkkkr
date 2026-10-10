using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000010 RID: 16
	[NullableContext(1)]
	[Nullable(0)]
	internal class TransactionLog : ITransactionLog
	{
		// Token: 0x06000045 RID: 69 RVA: 0x000023E7 File Offset: 0x000005E7
		public TransactionLog(string persistentDataPath)
		{
			if (!string.IsNullOrEmpty(persistentDataPath))
			{
				this.m_PersistentDataPath = Path.Combine(Path.Combine(persistentDataPath, "Unity"), "UnityPurchasing");
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002412 File Offset: 0x00000612
		public void Clear()
		{
			if (!string.IsNullOrEmpty(this.m_PersistentDataPath))
			{
				Directory.Delete(this.m_PersistentDataPath, true);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000242D File Offset: 0x0000062D
		public bool HasRecordOf(string transactionID)
		{
			return !string.IsNullOrEmpty(transactionID) && !string.IsNullOrEmpty(this.m_PersistentDataPath) && Directory.Exists(TransactionLog.GetRecordPath(this.m_PersistentDataPath, transactionID));
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002458 File Offset: 0x00000658
		public void Record(string transactionID)
		{
			if (string.IsNullOrEmpty(transactionID) || string.IsNullOrEmpty(this.m_PersistentDataPath))
			{
				return;
			}
			string recordPath = TransactionLog.GetRecordPath(this.m_PersistentDataPath, transactionID);
			try
			{
				Directory.CreateDirectory(recordPath);
			}
			catch (Exception exception)
			{
				Debug.unityLogger.LogException(exception);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000024B0 File Offset: 0x000006B0
		private static string GetRecordPath(string dataPath, string transactionID)
		{
			return Path.Combine(dataPath, TransactionLog.ComputeHash(transactionID));
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000024C0 File Offset: 0x000006C0
		private static string ComputeHash(string transactionID)
		{
			ulong num = 3074457345618258791UL;
			for (int i = 0; i < transactionID.Length; i++)
			{
				num += (ulong)transactionID[i];
				num *= 3074457345618258799UL;
			}
			StringBuilder stringBuilder = new StringBuilder(16);
			foreach (byte b in BitConverter.GetBytes(num))
			{
				stringBuilder.AppendFormat("{0:X2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000009 RID: 9
		[Nullable(2)]
		private readonly string m_PersistentDataPath;
	}
}
