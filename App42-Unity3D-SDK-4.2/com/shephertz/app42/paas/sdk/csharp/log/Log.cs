using System;
using System.Collections.Generic;

namespace com.shephertz.app42.paas.sdk.csharp.log
{
	// Token: 0x02000077 RID: 119
	public class Log : App42Response
	{
		// Token: 0x060004E5 RID: 1253 RVA: 0x0001977D File Offset: 0x0001797D
		public IList<Log.Message> GetMessageList()
		{
			return this.messageList;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00019785 File Offset: 0x00017985
		public void SetMessageList(IList<Log.Message> messageList)
		{
			this.messageList = messageList;
		}

		// Token: 0x0400020E RID: 526
		private IList<Log.Message> messageList = new List<Log.Message>();

		// Token: 0x02000078 RID: 120
		public class Message
		{
			// Token: 0x060004E8 RID: 1256 RVA: 0x000197A1 File Offset: 0x000179A1
			public Message(Log log)
			{
				log.messageList.Add(this);
			}

			// Token: 0x060004E9 RID: 1257 RVA: 0x000197B5 File Offset: 0x000179B5
			public string GetMessage()
			{
				return this.message;
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x000197BD File Offset: 0x000179BD
			public void SetMessage(string message)
			{
				this.message = message;
			}

			// Token: 0x060004EB RID: 1259 RVA: 0x000197C6 File Offset: 0x000179C6
			public new string GetType()
			{
				return this.type;
			}

			// Token: 0x060004EC RID: 1260 RVA: 0x000197CE File Offset: 0x000179CE
			public void SetType(string type)
			{
				this.type = type;
			}

			// Token: 0x060004ED RID: 1261 RVA: 0x000197D7 File Offset: 0x000179D7
			public DateTime GetLogTime()
			{
				return this.logTime;
			}

			// Token: 0x060004EE RID: 1262 RVA: 0x000197DF File Offset: 0x000179DF
			public void SetLogTime(DateTime logTime)
			{
				this.logTime = logTime;
			}

			// Token: 0x060004EF RID: 1263 RVA: 0x000197E8 File Offset: 0x000179E8
			public string GetModule()
			{
				return this.module;
			}

			// Token: 0x060004F0 RID: 1264 RVA: 0x000197F0 File Offset: 0x000179F0
			public void SetModule(string appModule)
			{
				this.module = appModule;
			}

			// Token: 0x060004F1 RID: 1265 RVA: 0x000197FC File Offset: 0x000179FC
			public override string ToString()
			{
				return string.Concat(new object[]
				{
					"Message : ",
					this.message,
					" : type : ",
					this.type,
					" : AppModule : ",
					this.module,
					" : logTime : ",
					this.logTime
				});
			}

			// Token: 0x0400020F RID: 527
			public string message;

			// Token: 0x04000210 RID: 528
			public string type;

			// Token: 0x04000211 RID: 529
			public DateTime logTime;

			// Token: 0x04000212 RID: 530
			public string module;
		}
	}
}
