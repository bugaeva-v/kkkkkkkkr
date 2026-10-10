using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.message
{
	// Token: 0x02000088 RID: 136
	public class Queue : App42Response
	{
		// Token: 0x06000591 RID: 1425 RVA: 0x0001FA70 File Offset: 0x0001DC70
		public string GetDescription()
		{
			return this.description;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0001FA78 File Offset: 0x0001DC78
		public void SetDescription(string description)
		{
			this.description = description;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0001FA81 File Offset: 0x0001DC81
		public string GetQueueName()
		{
			return this.queueName;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0001FA89 File Offset: 0x0001DC89
		public void GetQueueName(string queueName)
		{
			this.queueName = queueName;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0001FA92 File Offset: 0x0001DC92
		public string GetQueueType()
		{
			return this.queueType;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0001FA9A File Offset: 0x0001DC9A
		public void SetQueueType(string queueType)
		{
			this.queueType = queueType;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0001FAA3 File Offset: 0x0001DCA3
		public IList<Queue.Message> GetMessageList()
		{
			return this.messageList;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0001FAAB File Offset: 0x0001DCAB
		public void SetMessageList(IList<Queue.Message> messageList)
		{
			this.messageList = messageList;
		}

		// Token: 0x04000255 RID: 597
		public string queueName;

		// Token: 0x04000256 RID: 598
		public string queueType;

		// Token: 0x04000257 RID: 599
		public string description;

		// Token: 0x04000258 RID: 600
		public IList<Queue.Message> messageList = new List<Queue.Message>();

		// Token: 0x02000089 RID: 137
		public class Message
		{
			// Token: 0x0600059A RID: 1434 RVA: 0x0001FAC7 File Offset: 0x0001DCC7
			public Message(Queue queue)
			{
				queue.messageList.Add(this);
			}

			// Token: 0x0600059B RID: 1435 RVA: 0x0001FADB File Offset: 0x0001DCDB
			public string GetCorrelationId()
			{
				return this.correlationId;
			}

			// Token: 0x0600059C RID: 1436 RVA: 0x0001FAE3 File Offset: 0x0001DCE3
			public void SetCorrelationId(string correlationId)
			{
				this.correlationId = correlationId;
			}

			// Token: 0x0600059D RID: 1437 RVA: 0x0001FAEC File Offset: 0x0001DCEC
			public string GetPayLoad()
			{
				return this.payLoad;
			}

			// Token: 0x0600059E RID: 1438 RVA: 0x0001FAF4 File Offset: 0x0001DCF4
			public void SetPayLoad(string payLoad)
			{
				this.payLoad = payLoad;
			}

			// Token: 0x0600059F RID: 1439 RVA: 0x0001FAFD File Offset: 0x0001DCFD
			public string GetMessageId()
			{
				return this.messageId;
			}

			// Token: 0x060005A0 RID: 1440 RVA: 0x0001FB05 File Offset: 0x0001DD05
			public void SetMessageId(string messageId)
			{
				this.messageId = messageId;
			}

			// Token: 0x060005A1 RID: 1441 RVA: 0x0001FB10 File Offset: 0x0001DD10
			public override string ToString()
			{
				return string.Concat(new string[]
				{
					" correlationId : ",
					this.correlationId,
					" : payLoad : ",
					this.payLoad,
					" : messageId : ",
					this.messageId
				});
			}

			// Token: 0x04000259 RID: 601
			public string correlationId;

			// Token: 0x0400025A RID: 602
			public string payLoad;

			// Token: 0x0400025B RID: 603
			public string messageId;
		}
	}
}
