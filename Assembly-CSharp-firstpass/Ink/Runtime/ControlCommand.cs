using System;

namespace Ink.Runtime
{
	// Token: 0x02000022 RID: 34
	internal class ControlCommand : Object
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000097CA File Offset: 0x000079CA
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000097D2 File Offset: 0x000079D2
		public ControlCommand.CommandType commandType { get; protected set; }

		// Token: 0x060000F7 RID: 247 RVA: 0x000097DB File Offset: 0x000079DB
		public ControlCommand(ControlCommand.CommandType commandType)
		{
			this.commandType = commandType;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000097EA File Offset: 0x000079EA
		public ControlCommand() : this(ControlCommand.CommandType.NotSet)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000097F3 File Offset: 0x000079F3
		internal override Object Copy()
		{
			return new ControlCommand(this.commandType);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00009800 File Offset: 0x00007A00
		public static ControlCommand EvalStart()
		{
			return new ControlCommand(ControlCommand.CommandType.EvalStart);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00009808 File Offset: 0x00007A08
		public static ControlCommand EvalOutput()
		{
			return new ControlCommand(ControlCommand.CommandType.EvalOutput);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00009810 File Offset: 0x00007A10
		public static ControlCommand EvalEnd()
		{
			return new ControlCommand(ControlCommand.CommandType.EvalEnd);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00009818 File Offset: 0x00007A18
		public static ControlCommand Duplicate()
		{
			return new ControlCommand(ControlCommand.CommandType.Duplicate);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00009820 File Offset: 0x00007A20
		public static ControlCommand PopEvaluatedValue()
		{
			return new ControlCommand(ControlCommand.CommandType.PopEvaluatedValue);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00009828 File Offset: 0x00007A28
		public static ControlCommand PopFunction()
		{
			return new ControlCommand(ControlCommand.CommandType.PopFunction);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00009830 File Offset: 0x00007A30
		public static ControlCommand PopTunnel()
		{
			return new ControlCommand(ControlCommand.CommandType.PopTunnel);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00009838 File Offset: 0x00007A38
		public static ControlCommand BeginString()
		{
			return new ControlCommand(ControlCommand.CommandType.BeginString);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00009840 File Offset: 0x00007A40
		public static ControlCommand EndString()
		{
			return new ControlCommand(ControlCommand.CommandType.EndString);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00009848 File Offset: 0x00007A48
		public static ControlCommand NoOp()
		{
			return new ControlCommand(ControlCommand.CommandType.NoOp);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00009851 File Offset: 0x00007A51
		public static ControlCommand ChoiceCount()
		{
			return new ControlCommand(ControlCommand.CommandType.ChoiceCount);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000985A File Offset: 0x00007A5A
		public static ControlCommand TurnsSince()
		{
			return new ControlCommand(ControlCommand.CommandType.TurnsSince);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00009863 File Offset: 0x00007A63
		public static ControlCommand ReadCount()
		{
			return new ControlCommand(ControlCommand.CommandType.ReadCount);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000986C File Offset: 0x00007A6C
		public static ControlCommand Random()
		{
			return new ControlCommand(ControlCommand.CommandType.Random);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00009875 File Offset: 0x00007A75
		public static ControlCommand SeedRandom()
		{
			return new ControlCommand(ControlCommand.CommandType.SeedRandom);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000987E File Offset: 0x00007A7E
		public static ControlCommand VisitIndex()
		{
			return new ControlCommand(ControlCommand.CommandType.VisitIndex);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00009887 File Offset: 0x00007A87
		public static ControlCommand SequenceShuffleIndex()
		{
			return new ControlCommand(ControlCommand.CommandType.SequenceShuffleIndex);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00009890 File Offset: 0x00007A90
		public static ControlCommand StartThread()
		{
			return new ControlCommand(ControlCommand.CommandType.StartThread);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00009899 File Offset: 0x00007A99
		public static ControlCommand Done()
		{
			return new ControlCommand(ControlCommand.CommandType.Done);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000098A2 File Offset: 0x00007AA2
		public static ControlCommand End()
		{
			return new ControlCommand(ControlCommand.CommandType.End);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000098AB File Offset: 0x00007AAB
		public static ControlCommand ListFromInt()
		{
			return new ControlCommand(ControlCommand.CommandType.ListFromInt);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000098B4 File Offset: 0x00007AB4
		public static ControlCommand ListRange()
		{
			return new ControlCommand(ControlCommand.CommandType.ListRange);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000098C0 File Offset: 0x00007AC0
		public override string ToString()
		{
			return this.commandType.ToString();
		}

		// Token: 0x02000066 RID: 102
		public enum CommandType
		{
			// Token: 0x04000210 RID: 528
			NotSet = -1,
			// Token: 0x04000211 RID: 529
			EvalStart,
			// Token: 0x04000212 RID: 530
			EvalOutput,
			// Token: 0x04000213 RID: 531
			EvalEnd,
			// Token: 0x04000214 RID: 532
			Duplicate,
			// Token: 0x04000215 RID: 533
			PopEvaluatedValue,
			// Token: 0x04000216 RID: 534
			PopFunction,
			// Token: 0x04000217 RID: 535
			PopTunnel,
			// Token: 0x04000218 RID: 536
			BeginString,
			// Token: 0x04000219 RID: 537
			EndString,
			// Token: 0x0400021A RID: 538
			NoOp,
			// Token: 0x0400021B RID: 539
			ChoiceCount,
			// Token: 0x0400021C RID: 540
			TurnsSince,
			// Token: 0x0400021D RID: 541
			ReadCount,
			// Token: 0x0400021E RID: 542
			Random,
			// Token: 0x0400021F RID: 543
			SeedRandom,
			// Token: 0x04000220 RID: 544
			VisitIndex,
			// Token: 0x04000221 RID: 545
			SequenceShuffleIndex,
			// Token: 0x04000222 RID: 546
			StartThread,
			// Token: 0x04000223 RID: 547
			Done,
			// Token: 0x04000224 RID: 548
			End,
			// Token: 0x04000225 RID: 549
			ListFromInt,
			// Token: 0x04000226 RID: 550
			ListRange,
			// Token: 0x04000227 RID: 551
			TOTAL_VALUES
		}
	}
}
