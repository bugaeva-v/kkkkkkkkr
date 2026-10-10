using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Ink.Runtime
{
	// Token: 0x02000031 RID: 49
	public class Profiler
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000D5F2 File Offset: 0x0000B7F2
		public ProfileNode rootNode
		{
			get
			{
				return this._rootNode;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		internal Profiler()
		{
			this._rootNode = new ProfileNode();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000D654 File Offset: 0x0000B854
		public string Report()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("{0} CONTINUES / LINES:\n", this._numContinues);
			stringBuilder.AppendFormat("TOTAL TIME: {0}\n", Profiler.FormatMillisecs(this._continueTotal));
			stringBuilder.AppendFormat("SNAPSHOTTING: {0}\n", Profiler.FormatMillisecs(this._snapTotal));
			stringBuilder.AppendFormat("RESTORING: {0}\n", Profiler.FormatMillisecs(this._restoreTotal));
			stringBuilder.AppendFormat("OTHER: {0}\n", Profiler.FormatMillisecs(this._continueTotal - (this._stepTotal + this._snapTotal + this._restoreTotal)));
			stringBuilder.Append(this._rootNode.ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000D705 File Offset: 0x0000B905
		internal void PreContinue()
		{
			this._continueWatch.Reset();
			this._continueWatch.Start();
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000D71D File Offset: 0x0000B91D
		internal void PostContinue()
		{
			this._continueWatch.Stop();
			this._continueTotal += this.Millisecs(this._continueWatch);
			this._numContinues++;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000D751 File Offset: 0x0000B951
		internal void PreStep()
		{
			this._currStepStack = null;
			this._stepWatch.Reset();
			this._stepWatch.Start();
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000D770 File Offset: 0x0000B970
		internal void Step(CallStack callstack)
		{
			this._stepWatch.Stop();
			string[] array = new string[callstack.elements.Count];
			for (int i = 0; i < array.Length; i++)
			{
				Path path = callstack.elements[i].currentObject.path;
				string text = "";
				for (int j = 0; j < path.componentCount; j++)
				{
					Path.Component component = path.GetComponent(j);
					if (!component.isIndex)
					{
						text = component.name;
						break;
					}
				}
				array[i] = text;
			}
			this._currStepStack = array;
			Object @object = callstack.currentElement.currentObject ?? callstack.currentElement.currentContainer;
			this._currStepDetails = new Profiler.StepDetails
			{
				type = @object.GetType().Name,
				detail = @object.ToString()
			};
			this._stepWatch.Start();
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000D85C File Offset: 0x0000BA5C
		internal void PostStep()
		{
			this._stepWatch.Stop();
			double num = this.Millisecs(this._stepWatch);
			this._stepTotal += num;
			this._rootNode.AddSample(this._currStepStack, num);
			this._currStepDetails.time = num;
			this._stepDetails.Add(this._currStepDetails);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		public string StepLengthReport()
		{
			StringBuilder stringBuilder = new StringBuilder();
			string[] value = (from s in this._stepDetails
			group s by s.type into typeToDetails
			select new KeyValuePair<string, double>(typeToDetails.Key, typeToDetails.Average((Profiler.StepDetails d) => d.time)) into stepTypeToAverage
			orderby stepTypeToAverage.Value descending
			select stepTypeToAverage.Key + ": " + stepTypeToAverage.Value.ToString() + "ms").ToArray<string>();
			stringBuilder.AppendLine("AVERAGE STEP TIMES: " + string.Join(", ", value));
			string[] value2 = (from d in this._stepDetails
			orderby d.time descending
			select d.detail + ":" + d.time.ToString() + "ms").Take(100).ToArray<string>();
			stringBuilder.AppendLine("MAX STEP TIMES: " + string.Join("\n", value2));
			return stringBuilder.ToString();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000DA06 File Offset: 0x0000BC06
		internal void PreSnapshot()
		{
			this._snapWatch.Reset();
			this._snapWatch.Start();
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000DA1E File Offset: 0x0000BC1E
		internal void PostSnapshot()
		{
			this._snapWatch.Stop();
			this._snapTotal += this.Millisecs(this._snapWatch);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000DA44 File Offset: 0x0000BC44
		internal void PreRestore()
		{
			this._restoreWatch.Reset();
			this._restoreWatch.Start();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000DA5C File Offset: 0x0000BC5C
		internal void PostRestore()
		{
			this._restoreWatch.Stop();
			this._restoreTotal += this.Millisecs(this._restoreWatch);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000DA82 File Offset: 0x0000BC82
		private double Millisecs(Stopwatch watch)
		{
			return (double)watch.ElapsedTicks * Profiler._millisecsPerTick;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000DA94 File Offset: 0x0000BC94
		internal static string FormatMillisecs(double num)
		{
			if (num > 5000.0)
			{
				return string.Format("{0:N1} secs", num / 1000.0);
			}
			if (num > 1000.0)
			{
				return string.Format("{0:N2} secs", num / 1000.0);
			}
			if (num > 100.0)
			{
				return string.Format("{0:N0} ms", num);
			}
			if (num > 1.0)
			{
				return string.Format("{0:N1} ms", num);
			}
			if (num > 0.01)
			{
				return string.Format("{0:N3} ms", num);
			}
			return string.Format("{0:N} ms", num);
		}

		// Token: 0x04000160 RID: 352
		private Stopwatch _continueWatch = new Stopwatch();

		// Token: 0x04000161 RID: 353
		private Stopwatch _stepWatch = new Stopwatch();

		// Token: 0x04000162 RID: 354
		private Stopwatch _snapWatch = new Stopwatch();

		// Token: 0x04000163 RID: 355
		private Stopwatch _restoreWatch = new Stopwatch();

		// Token: 0x04000164 RID: 356
		private double _continueTotal;

		// Token: 0x04000165 RID: 357
		private double _snapTotal;

		// Token: 0x04000166 RID: 358
		private double _stepTotal;

		// Token: 0x04000167 RID: 359
		private double _restoreTotal;

		// Token: 0x04000168 RID: 360
		private string[] _currStepStack;

		// Token: 0x04000169 RID: 361
		private Profiler.StepDetails _currStepDetails;

		// Token: 0x0400016A RID: 362
		private ProfileNode _rootNode;

		// Token: 0x0400016B RID: 363
		private int _numContinues;

		// Token: 0x0400016C RID: 364
		private List<Profiler.StepDetails> _stepDetails = new List<Profiler.StepDetails>();

		// Token: 0x0400016D RID: 365
		private static double _millisecsPerTick = 1000.0 / (double)Stopwatch.Frequency;

		// Token: 0x0200006E RID: 110
		private struct StepDetails
		{
			// Token: 0x0400026C RID: 620
			public string type;

			// Token: 0x0400026D RID: 621
			public string detail;

			// Token: 0x0400026E RID: 622
			public double time;
		}
	}
}
