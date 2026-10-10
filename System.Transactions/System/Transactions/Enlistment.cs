using System;

namespace System.Transactions
{
	/// <summary>Облегчает взаимодействие между включенным в список участником транзакции и диспетчером транзакций на завершающем этапе транзакции.</summary>
	// Token: 0x02000010 RID: 16
	public class Enlistment
	{
		// Token: 0x06000029 RID: 41 RVA: 0x000021D0 File Offset: 0x000003D0
		internal Enlistment()
		{
			this.done = false;
		}

		/// <summary>Указывает, что участник транзакции завершил свою работу.</summary>
		// Token: 0x0600002A RID: 42 RVA: 0x000021DF File Offset: 0x000003DF
		public void Done()
		{
			this.done = true;
			this.InternalOnDone();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000021EE File Offset: 0x000003EE
		internal virtual void InternalOnDone()
		{
		}

		// Token: 0x04000033 RID: 51
		internal bool done;
	}
}
