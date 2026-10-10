using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using NSubstitute.Exceptions;

namespace NSubstitute.Core
{
	// Token: 0x02000066 RID: 102
	public class CallCollection : ICallCollection
	{
		// Token: 0x06000169 RID: 361 RVA: 0x000054A4 File Offset: 0x000036A4
		public void Add(ICall call)
		{
			CallCollection.IReceivedCallEntry receivedCallEntry = call as CallCollection.IReceivedCallEntry;
			CallCollection.IReceivedCallEntry item;
			if (receivedCallEntry != null && receivedCallEntry.TryTakeEntryOwnership())
			{
				item = receivedCallEntry;
			}
			else
			{
				item = new CallCollection.ReceivedCallEntry(call);
			}
			this._callEntries.Enqueue(item);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000054DC File Offset: 0x000036DC
		public void Delete(ICall call)
		{
			CallCollection.IReceivedCallEntry receivedCallEntry = this._callEntries.FirstOrDefault((CallCollection.IReceivedCallEntry e) => !e.IsSkipped && call.Equals(e.Call));
			if (receivedCallEntry == null)
			{
				throw new SubstituteInternalException("CallCollection.Delete - collection doesn't contain the call");
			}
			receivedCallEntry.Skip();
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00005520 File Offset: 0x00003720
		public IEnumerable<ICall> AllCalls()
		{
			return (from e in this._callEntries
			where !e.IsSkipped
			select e.Call).ToArray<ICall>();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00005580 File Offset: 0x00003780
		public void Clear()
		{
			this._callEntries = new ConcurrentQueue<CallCollection.IReceivedCallEntry>();
		}

		// Token: 0x0400007D RID: 125
		private ConcurrentQueue<CallCollection.IReceivedCallEntry> _callEntries = new ConcurrentQueue<CallCollection.IReceivedCallEntry>();

		// Token: 0x02000111 RID: 273
		[NullableContext(2)]
		internal interface IReceivedCallEntry
		{
			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000446 RID: 1094
			ICall Call { get; }

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000447 RID: 1095
			[MemberNotNullWhen(false, "Call")]
			bool IsSkipped { [MemberNotNullWhen(false, "Call")] get; }

			// Token: 0x06000448 RID: 1096
			void Skip();

			// Token: 0x06000449 RID: 1097
			bool TryTakeEntryOwnership();
		}

		// Token: 0x02000112 RID: 274
		[NullableContext(2)]
		[Nullable(0)]
		private class ReceivedCallEntry : CallCollection.IReceivedCallEntry
		{
			// Token: 0x17000064 RID: 100
			// (get) Token: 0x0600044A RID: 1098 RVA: 0x00009C7A File Offset: 0x00007E7A
			// (set) Token: 0x0600044B RID: 1099 RVA: 0x00009C82 File Offset: 0x00007E82
			public ICall Call { get; private set; }

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x00009C8B File Offset: 0x00007E8B
			[MemberNotNullWhen(false, "Call")]
			public bool IsSkipped
			{
				[MemberNotNullWhen(false, "Call")]
				get
				{
					return this.Call == null;
				}
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x00009C96 File Offset: 0x00007E96
			public void Skip()
			{
				this.Call = null;
			}

			// Token: 0x0600044E RID: 1102 RVA: 0x00009C9F File Offset: 0x00007E9F
			public bool TryTakeEntryOwnership()
			{
				throw new SubstituteInternalException("Ownership is never expected to be obtained for this entry.");
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x00009CAB File Offset: 0x00007EAB
			[NullableContext(0)]
			public ReceivedCallEntry(ICall call)
			{
				this.Call = call;
			}
		}
	}
}
