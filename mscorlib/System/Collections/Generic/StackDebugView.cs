using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x02000AB5 RID: 2741
	internal sealed class StackDebugView<T>
	{
		// Token: 0x06006216 RID: 25110 RVA: 0x0014801F File Offset: 0x0014621F
		public StackDebugView(Stack<T> stack)
		{
			if (stack == null)
			{
				throw new ArgumentNullException("stack");
			}
			this._stack = stack;
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06006217 RID: 25111 RVA: 0x0014803C File Offset: 0x0014623C
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] Items
		{
			get
			{
				return this._stack.ToArray();
			}
		}

		// Token: 0x04003A25 RID: 14885
		private readonly Stack<T> _stack;
	}
}
