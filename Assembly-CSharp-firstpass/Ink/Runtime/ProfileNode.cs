using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ink.Runtime
{
	// Token: 0x02000032 RID: 50
	public class ProfileNode
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000DB6D File Offset: 0x0000BD6D
		public bool hasChildren
		{
			get
			{
				return this._nodes != null && this._nodes.Count > 0;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000DB87 File Offset: 0x0000BD87
		internal ProfileNode()
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000DB8F File Offset: 0x0000BD8F
		internal ProfileNode(string key)
		{
			this.key = key;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000DB9E File Offset: 0x0000BD9E
		internal void AddSample(string[] stack, double duration)
		{
			this.AddSample(stack, -1, duration);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000DBAC File Offset: 0x0000BDAC
		private void AddSample(string[] stack, int stackIdx, double duration)
		{
			this._totalSampleCount++;
			this._totalMillisecs += duration;
			if (stackIdx == stack.Length - 1)
			{
				this._selfSampleCount++;
				this._selfMillisecs += duration;
			}
			if (stackIdx + 1 < stack.Length)
			{
				this.AddSampleToNode(stack, stackIdx + 1, duration);
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000DC0C File Offset: 0x0000BE0C
		private void AddSampleToNode(string[] stack, int stackIdx, double duration)
		{
			string text = stack[stackIdx];
			if (this._nodes == null)
			{
				this._nodes = new Dictionary<string, ProfileNode>();
			}
			ProfileNode profileNode;
			if (!this._nodes.TryGetValue(text, out profileNode))
			{
				profileNode = new ProfileNode(text);
				this._nodes[text] = profileNode;
			}
			profileNode.AddSample(stack, stackIdx, duration);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000DC5D File Offset: 0x0000BE5D
		public IEnumerable<KeyValuePair<string, ProfileNode>> descendingOrderedNodes
		{
			get
			{
				if (this._nodes == null)
				{
					return null;
				}
				return from keyNode in this._nodes
				orderby keyNode.Value._totalMillisecs descending
				select keyNode;
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000DC94 File Offset: 0x0000BE94
		private void PrintHierarchy(StringBuilder sb, int indent)
		{
			this.Pad(sb, indent);
			sb.Append(this.key);
			sb.Append(": ");
			sb.AppendLine(this.ownReport);
			if (this._nodes == null)
			{
				return;
			}
			foreach (KeyValuePair<string, ProfileNode> keyValuePair in this.descendingOrderedNodes)
			{
				keyValuePair.Value.PrintHierarchy(sb, indent + 1);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000DD24 File Offset: 0x0000BF24
		public string ownReport
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("total ");
				stringBuilder.Append(Profiler.FormatMillisecs(this._totalMillisecs));
				stringBuilder.Append(", self ");
				stringBuilder.Append(Profiler.FormatMillisecs(this._selfMillisecs));
				stringBuilder.Append(" (");
				stringBuilder.Append(this._selfSampleCount);
				stringBuilder.Append(" self samples, ");
				stringBuilder.Append(this._totalSampleCount);
				stringBuilder.Append(" total)");
				return stringBuilder.ToString();
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		private void Pad(StringBuilder sb, int spaces)
		{
			for (int i = 0; i < spaces; i++)
			{
				sb.Append("   ");
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000DDE0 File Offset: 0x0000BFE0
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			this.PrintHierarchy(stringBuilder, 0);
			return stringBuilder.ToString();
		}

		// Token: 0x0400016E RID: 366
		public readonly string key;

		// Token: 0x0400016F RID: 367
		public bool openInUI;

		// Token: 0x04000170 RID: 368
		private Dictionary<string, ProfileNode> _nodes;

		// Token: 0x04000171 RID: 369
		private double _selfMillisecs;

		// Token: 0x04000172 RID: 370
		private double _totalMillisecs;

		// Token: 0x04000173 RID: 371
		private int _selfSampleCount;

		// Token: 0x04000174 RID: 372
		private int _totalSampleCount;
	}
}
