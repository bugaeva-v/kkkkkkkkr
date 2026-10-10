using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Buffers
{
	// Token: 0x02000AEF RID: 2799
	public ref struct SequenceReader<[IsUnmanaged] T> where T : struct, ValueType, IEquatable<T>
	{
		// Token: 0x0600638B RID: 25483 RVA: 0x0014CE9C File Offset: 0x0014B09C
		public bool TryReadTo(out ReadOnlySpan<T> span, T delimiter, bool advancePastDelimiter = true)
		{
			ReadOnlySpan<T> unreadSpan = this.UnreadSpan;
			int num = unreadSpan.IndexOf(delimiter);
			if (num != -1)
			{
				span = ((num == 0) ? default(ReadOnlySpan<T>) : unreadSpan.Slice(0, num));
				this.AdvanceCurrentSpan((long)(num + (advancePastDelimiter ? 1 : 0)));
				return true;
			}
			return this.TryReadToSlow(out span, delimiter, advancePastDelimiter);
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x0014CEF4 File Offset: 0x0014B0F4
		private bool TryReadToSlow(out ReadOnlySpan<T> span, T delimiter, bool advancePastDelimiter)
		{
			ReadOnlySequence<T> readOnlySequence;
			if (!this.TryReadToInternal(out readOnlySequence, delimiter, advancePastDelimiter, this.CurrentSpan.Length - this.CurrentSpanIndex))
			{
				span = default(ReadOnlySpan<T>);
				return false;
			}
			span = (readOnlySequence.IsSingleSegment ? readOnlySequence.First.Span : readOnlySequence.ToArray<T>());
			return true;
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x0014CF58 File Offset: 0x0014B158
		public unsafe bool TryReadTo(out ReadOnlySpan<T> span, T delimiter, T delimiterEscape, bool advancePastDelimiter = true)
		{
			ReadOnlySpan<T> unreadSpan = this.UnreadSpan;
			int num = unreadSpan.IndexOf(delimiter);
			if (num > 0)
			{
				T t = *unreadSpan[num - 1];
				if (!t.Equals(delimiterEscape))
				{
					goto IL_36;
				}
			}
			if (num != 0)
			{
				return this.TryReadToSlow(out span, delimiter, delimiterEscape, num, advancePastDelimiter);
			}
			IL_36:
			span = unreadSpan.Slice(0, num);
			this.AdvanceCurrentSpan((long)(num + (advancePastDelimiter ? 1 : 0)));
			return true;
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x0014CFCC File Offset: 0x0014B1CC
		private bool TryReadToSlow(out ReadOnlySpan<T> span, T delimiter, T delimiterEscape, int index, bool advancePastDelimiter)
		{
			ReadOnlySequence<T> readOnlySequence;
			if (!this.TryReadToSlow(out readOnlySequence, delimiter, delimiterEscape, index, advancePastDelimiter))
			{
				span = default(ReadOnlySpan<T>);
				return false;
			}
			span = (readOnlySequence.IsSingleSegment ? readOnlySequence.First.Span : readOnlySequence.ToArray<T>());
			return true;
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x0014D020 File Offset: 0x0014B220
		private unsafe bool TryReadToSlow(out ReadOnlySequence<T> sequence, T delimiter, T delimiterEscape, int index, bool advancePastDelimiter)
		{
			SequenceReader<T> sequenceReader = this;
			ReadOnlySpan<T> span = this.UnreadSpan;
			bool flag = false;
			for (;;)
			{
				if (index < 0)
				{
					if (span.Length <= 0)
					{
						goto IL_1A6;
					}
					T t = *span[span.Length - 1];
					if (!t.Equals(delimiterEscape))
					{
						goto IL_1A6;
					}
					int num = 1;
					int i;
					for (i = span.Length - 2; i >= 0; i--)
					{
						t = *span[i];
						if (!t.Equals(delimiterEscape))
						{
							break;
						}
					}
					num += span.Length - 2 - i;
					if (i < 0 && flag)
					{
						flag = ((num & 1) == 0);
					}
					else
					{
						flag = ((num & 1) != 0);
					}
					IL_1A8:
					this.AdvanceCurrentSpan((long)span.Length);
					span = this.CurrentSpan;
					goto IL_1BD;
					IL_1A6:
					flag = false;
					goto IL_1A8;
				}
				if (index == 0 && flag)
				{
					flag = false;
					this.Advance((long)(index + 1));
					span = this.UnreadSpan;
				}
				else
				{
					if (index <= 0)
					{
						break;
					}
					T t = *span[index - 1];
					if (!t.Equals(delimiterEscape))
					{
						break;
					}
					int num2 = 1;
					int j;
					for (j = index - 2; j >= 0; j--)
					{
						t = *span[j];
						if (!t.Equals(delimiterEscape))
						{
							break;
						}
					}
					if (j < 0 && flag)
					{
						num2++;
					}
					num2 += index - 2 - j;
					if ((num2 & 1) == 0)
					{
						break;
					}
					this.Advance((long)(index + 1));
					flag = false;
					span = this.UnreadSpan;
				}
				IL_1BD:
				index = span.IndexOf(delimiter);
				if (this.End)
				{
					goto Block_13;
				}
			}
			this.AdvanceCurrentSpan((long)index);
			sequence = this.Sequence.Slice(sequenceReader.Position, this.Position);
			if (advancePastDelimiter)
			{
				this.Advance(1L);
			}
			return true;
			Block_13:
			this = sequenceReader;
			sequence = default(ReadOnlySequence<T>);
			return false;
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x0014D20D File Offset: 0x0014B40D
		public bool TryReadTo(out ReadOnlySequence<T> sequence, T delimiter, bool advancePastDelimiter = true)
		{
			return this.TryReadToInternal(out sequence, delimiter, advancePastDelimiter, 0);
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x0014D21C File Offset: 0x0014B41C
		private bool TryReadToInternal(out ReadOnlySequence<T> sequence, T delimiter, bool advancePastDelimiter, int skip = 0)
		{
			SequenceReader<T> sequenceReader = this;
			if (skip > 0)
			{
				this.Advance((long)skip);
			}
			ReadOnlySpan<T> span = this.UnreadSpan;
			while (this._moreData)
			{
				int num = span.IndexOf(delimiter);
				if (num != -1)
				{
					if (num > 0)
					{
						this.AdvanceCurrentSpan((long)num);
					}
					sequence = this.Sequence.Slice(sequenceReader.Position, this.Position);
					if (advancePastDelimiter)
					{
						this.Advance(1L);
					}
					return true;
				}
				this.AdvanceCurrentSpan((long)span.Length);
				span = this.CurrentSpan;
			}
			this = sequenceReader;
			sequence = default(ReadOnlySequence<T>);
			return false;
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x0014D2BC File Offset: 0x0014B4BC
		public unsafe bool TryReadTo(out ReadOnlySequence<T> sequence, T delimiter, T delimiterEscape, bool advancePastDelimiter = true)
		{
			SequenceReader<T> sequenceReader = this;
			ReadOnlySpan<T> span = this.UnreadSpan;
			bool flag = false;
			while (this._moreData)
			{
				int num = span.IndexOf(delimiter);
				if (num != -1)
				{
					if (num != 0 || !flag)
					{
						if (num > 0)
						{
							T t = *span[num - 1];
							if (t.Equals(delimiterEscape))
							{
								int num2 = 0;
								int i = num;
								while (i > 0)
								{
									t = *span[i - 1];
									if (!t.Equals(delimiterEscape))
									{
										break;
									}
									i--;
									num2++;
								}
								if (num2 == num && flag)
								{
									num2++;
								}
								flag = false;
								if ((num2 & 1) != 0)
								{
									this.Advance((long)(num + 1));
									span = this.UnreadSpan;
									continue;
								}
							}
						}
						if (num > 0)
						{
							this.Advance((long)num);
						}
						sequence = this.Sequence.Slice(sequenceReader.Position, this.Position);
						if (advancePastDelimiter)
						{
							this.Advance(1L);
						}
						return true;
					}
					flag = false;
					this.Advance((long)(num + 1));
					span = this.UnreadSpan;
				}
				else
				{
					int num3 = 0;
					int j = span.Length;
					while (j > 0)
					{
						T t = *span[j - 1];
						if (!t.Equals(delimiterEscape))
						{
							break;
						}
						j--;
						num3++;
					}
					if (flag && num3 == span.Length)
					{
						num3++;
					}
					flag = (num3 % 2 != 0);
					this.Advance((long)span.Length);
					span = this.CurrentSpan;
				}
			}
			this = sequenceReader;
			sequence = default(ReadOnlySequence<T>);
			return false;
		}

		// Token: 0x06006393 RID: 25491 RVA: 0x0014D468 File Offset: 0x0014B668
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe bool TryReadToAny(out ReadOnlySpan<T> span, ReadOnlySpan<T> delimiters, bool advancePastDelimiter = true)
		{
			ReadOnlySpan<T> unreadSpan = this.UnreadSpan;
			int num = (delimiters.Length == 2) ? unreadSpan.IndexOfAny(*delimiters[0], *delimiters[1]) : unreadSpan.IndexOfAny(delimiters);
			if (num != -1)
			{
				span = unreadSpan.Slice(0, num);
				this.Advance((long)(num + (advancePastDelimiter ? 1 : 0)));
				return true;
			}
			return this.TryReadToAnySlow(out span, delimiters, advancePastDelimiter);
		}

		// Token: 0x06006394 RID: 25492 RVA: 0x0014D4E0 File Offset: 0x0014B6E0
		private bool TryReadToAnySlow(out ReadOnlySpan<T> span, ReadOnlySpan<T> delimiters, bool advancePastDelimiter)
		{
			ReadOnlySequence<T> readOnlySequence;
			if (!this.TryReadToAnyInternal(out readOnlySequence, delimiters, advancePastDelimiter, this.CurrentSpan.Length - this.CurrentSpanIndex))
			{
				span = default(ReadOnlySpan<T>);
				return false;
			}
			span = (readOnlySequence.IsSingleSegment ? readOnlySequence.First.Span : readOnlySequence.ToArray<T>());
			return true;
		}

		// Token: 0x06006395 RID: 25493 RVA: 0x0014D544 File Offset: 0x0014B744
		public bool TryReadToAny(out ReadOnlySequence<T> sequence, ReadOnlySpan<T> delimiters, bool advancePastDelimiter = true)
		{
			return this.TryReadToAnyInternal(out sequence, delimiters, advancePastDelimiter, 0);
		}

		// Token: 0x06006396 RID: 25494 RVA: 0x0014D550 File Offset: 0x0014B750
		private unsafe bool TryReadToAnyInternal(out ReadOnlySequence<T> sequence, ReadOnlySpan<T> delimiters, bool advancePastDelimiter, int skip = 0)
		{
			SequenceReader<T> sequenceReader = this;
			if (skip > 0)
			{
				this.Advance((long)skip);
			}
			ReadOnlySpan<T> span = this.UnreadSpan;
			while (!this.End)
			{
				int num = (delimiters.Length == 2) ? span.IndexOfAny(*delimiters[0], *delimiters[1]) : span.IndexOfAny(delimiters);
				if (num != -1)
				{
					if (num > 0)
					{
						this.AdvanceCurrentSpan((long)num);
					}
					sequence = this.Sequence.Slice(sequenceReader.Position, this.Position);
					if (advancePastDelimiter)
					{
						this.Advance(1L);
					}
					return true;
				}
				this.Advance((long)span.Length);
				span = this.CurrentSpan;
			}
			this = sequenceReader;
			sequence = default(ReadOnlySequence<T>);
			return false;
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x0014D620 File Offset: 0x0014B820
		public unsafe bool TryReadTo(out ReadOnlySequence<T> sequence, ReadOnlySpan<T> delimiter, bool advancePastDelimiter = true)
		{
			if (delimiter.Length == 0)
			{
				sequence = default(ReadOnlySequence<T>);
				return true;
			}
			SequenceReader<T> sequenceReader = this;
			bool flag = false;
			while (!this.End)
			{
				if (!this.TryReadTo(out sequence, *delimiter[0], false))
				{
					this = sequenceReader;
					return false;
				}
				if (delimiter.Length == 1)
				{
					if (advancePastDelimiter)
					{
						this.Advance(1L);
					}
					return true;
				}
				if (this.IsNext(delimiter, false))
				{
					if (flag)
					{
						sequence = sequenceReader.Sequence.Slice(sequenceReader.Consumed, this.Consumed - sequenceReader.Consumed);
					}
					if (advancePastDelimiter)
					{
						this.Advance((long)delimiter.Length);
					}
					return true;
				}
				this.Advance(1L);
				flag = true;
			}
			this = sequenceReader;
			sequence = default(ReadOnlySequence<T>);
			return false;
		}

		// Token: 0x06006398 RID: 25496 RVA: 0x0014D6F4 File Offset: 0x0014B8F4
		public bool TryAdvanceTo(T delimiter, bool advancePastDelimiter = true)
		{
			int num = this.UnreadSpan.IndexOf(delimiter);
			if (num != -1)
			{
				this.Advance((long)(advancePastDelimiter ? (num + 1) : num));
				return true;
			}
			ReadOnlySequence<T> readOnlySequence;
			return this.TryReadToInternal(out readOnlySequence, delimiter, advancePastDelimiter, 0);
		}

		// Token: 0x06006399 RID: 25497 RVA: 0x0014D730 File Offset: 0x0014B930
		public bool TryAdvanceToAny(ReadOnlySpan<T> delimiters, bool advancePastDelimiter = true)
		{
			int num = this.UnreadSpan.IndexOfAny(delimiters);
			if (num != -1)
			{
				this.AdvanceCurrentSpan((long)(num + (advancePastDelimiter ? 1 : 0)));
				return true;
			}
			ReadOnlySequence<T> readOnlySequence;
			return this.TryReadToAnyInternal(out readOnlySequence, delimiters, advancePastDelimiter, 0);
		}

		// Token: 0x0600639A RID: 25498 RVA: 0x0014D76C File Offset: 0x0014B96C
		public unsafe long AdvancePast(T value)
		{
			long consumed = this.Consumed;
			do
			{
				int i;
				for (i = this.CurrentSpanIndex; i < this.CurrentSpan.Length; i++)
				{
					T t = *this.CurrentSpan[i];
					if (!t.Equals(value))
					{
						break;
					}
				}
				int num = i - this.CurrentSpanIndex;
				if (num == 0)
				{
					break;
				}
				this.AdvanceCurrentSpan((long)num);
			}
			while (this.CurrentSpanIndex == 0 && !this.End);
			return this.Consumed - consumed;
		}

		// Token: 0x0600639B RID: 25499 RVA: 0x0014D7F0 File Offset: 0x0014B9F0
		public unsafe long AdvancePastAny(ReadOnlySpan<T> values)
		{
			long consumed = this.Consumed;
			do
			{
				int num = this.CurrentSpanIndex;
				while (num < this.CurrentSpan.Length && values.IndexOf(*this.CurrentSpan[num]) != -1)
				{
					num++;
				}
				int num2 = num - this.CurrentSpanIndex;
				if (num2 == 0)
				{
					break;
				}
				this.AdvanceCurrentSpan((long)num2);
			}
			while (this.CurrentSpanIndex == 0 && !this.End);
			return this.Consumed - consumed;
		}

		// Token: 0x0600639C RID: 25500 RVA: 0x0014D86C File Offset: 0x0014BA6C
		public unsafe long AdvancePastAny(T value0, T value1, T value2, T value3)
		{
			long consumed = this.Consumed;
			do
			{
				int i;
				for (i = this.CurrentSpanIndex; i < this.CurrentSpan.Length; i++)
				{
					T t = *this.CurrentSpan[i];
					if (!t.Equals(value0) && !t.Equals(value1) && !t.Equals(value2) && !t.Equals(value3))
					{
						break;
					}
				}
				int num = i - this.CurrentSpanIndex;
				if (num == 0)
				{
					break;
				}
				this.AdvanceCurrentSpan((long)num);
			}
			while (this.CurrentSpanIndex == 0 && !this.End);
			return this.Consumed - consumed;
		}

		// Token: 0x0600639D RID: 25501 RVA: 0x0014D928 File Offset: 0x0014BB28
		public unsafe long AdvancePastAny(T value0, T value1, T value2)
		{
			long consumed = this.Consumed;
			do
			{
				int i;
				for (i = this.CurrentSpanIndex; i < this.CurrentSpan.Length; i++)
				{
					T t = *this.CurrentSpan[i];
					if (!t.Equals(value0) && !t.Equals(value1) && !t.Equals(value2))
					{
						break;
					}
				}
				int num = i - this.CurrentSpanIndex;
				if (num == 0)
				{
					break;
				}
				this.AdvanceCurrentSpan((long)num);
			}
			while (this.CurrentSpanIndex == 0 && !this.End);
			return this.Consumed - consumed;
		}

		// Token: 0x0600639E RID: 25502 RVA: 0x0014D9D0 File Offset: 0x0014BBD0
		public unsafe long AdvancePastAny(T value0, T value1)
		{
			long consumed = this.Consumed;
			do
			{
				int i;
				for (i = this.CurrentSpanIndex; i < this.CurrentSpan.Length; i++)
				{
					T t = *this.CurrentSpan[i];
					if (!t.Equals(value0) && !t.Equals(value1))
					{
						break;
					}
				}
				int num = i - this.CurrentSpanIndex;
				if (num == 0)
				{
					break;
				}
				this.AdvanceCurrentSpan((long)num);
			}
			while (this.CurrentSpanIndex == 0 && !this.End);
			return this.Consumed - consumed;
		}

		// Token: 0x0600639F RID: 25503 RVA: 0x0014DA68 File Offset: 0x0014BC68
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe bool IsNext(T next, bool advancePast = false)
		{
			if (this.End)
			{
				return false;
			}
			T t = *this.CurrentSpan[this.CurrentSpanIndex];
			if (t.Equals(next))
			{
				if (advancePast)
				{
					this.AdvanceCurrentSpan(1L);
				}
				return true;
			}
			return false;
		}

		// Token: 0x060063A0 RID: 25504 RVA: 0x0014DAB8 File Offset: 0x0014BCB8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsNext(ReadOnlySpan<T> next, bool advancePast = false)
		{
			ReadOnlySpan<T> unreadSpan = this.UnreadSpan;
			if (unreadSpan.StartsWith(next))
			{
				if (advancePast)
				{
					this.AdvanceCurrentSpan((long)next.Length);
				}
				return true;
			}
			return unreadSpan.Length < next.Length && this.IsNextSlow(next, advancePast);
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x0014DB04 File Offset: 0x0014BD04
		private bool IsNextSlow(ReadOnlySpan<T> next, bool advancePast)
		{
			ReadOnlySpan<T> value = this.UnreadSpan;
			int length = next.Length;
			SequencePosition nextPosition = this._nextPosition;
			IL_8F:
			while (next.StartsWith(value))
			{
				if (next.Length == value.Length)
				{
					if (advancePast)
					{
						this.Advance((long)length);
					}
					return true;
				}
				ReadOnlyMemory<T> readOnlyMemory;
				while (this.Sequence.TryGet(ref nextPosition, out readOnlyMemory, true))
				{
					if (readOnlyMemory.Length > 0)
					{
						next = next.Slice(value.Length);
						value = readOnlyMemory.Span;
						if (value.Length > next.Length)
						{
							value = value.Slice(0, next.Length);
							goto IL_8F;
						}
						goto IL_8F;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x060063A2 RID: 25506 RVA: 0x0014DBAC File Offset: 0x0014BDAC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public SequenceReader(ReadOnlySequence<T> sequence)
		{
			this.CurrentSpanIndex = 0;
			this.Consumed = 0L;
			this.Sequence = sequence;
			this._currentPosition = sequence.Start;
			this._length = -1L;
			ReadOnlySpan<T> currentSpan;
			sequence.GetFirstSpan(out currentSpan, out this._nextPosition);
			this.CurrentSpan = currentSpan;
			this._moreData = (currentSpan.Length > 0);
			if (!this._moreData && !sequence.IsSingleSegment)
			{
				this._moreData = true;
				this.GetNextSpan();
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x060063A3 RID: 25507 RVA: 0x0014DC28 File Offset: 0x0014BE28
		public readonly bool End
		{
			get
			{
				return !this._moreData;
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x060063A4 RID: 25508 RVA: 0x0014DC33 File Offset: 0x0014BE33
		public readonly ReadOnlySequence<T> Sequence { get; }

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x060063A5 RID: 25509 RVA: 0x0014DC3C File Offset: 0x0014BE3C
		public readonly SequencePosition Position
		{
			get
			{
				return this.Sequence.GetPosition((long)this.CurrentSpanIndex, this._currentPosition);
			}
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x060063A6 RID: 25510 RVA: 0x0014DC64 File Offset: 0x0014BE64
		// (set) Token: 0x060063A7 RID: 25511 RVA: 0x0014DC6C File Offset: 0x0014BE6C
		public ReadOnlySpan<T> CurrentSpan { readonly get; private set; }

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x060063A8 RID: 25512 RVA: 0x0014DC75 File Offset: 0x0014BE75
		// (set) Token: 0x060063A9 RID: 25513 RVA: 0x0014DC7D File Offset: 0x0014BE7D
		public int CurrentSpanIndex { readonly get; private set; }

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x060063AA RID: 25514 RVA: 0x0014DC88 File Offset: 0x0014BE88
		public readonly ReadOnlySpan<T> UnreadSpan
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.CurrentSpan.Slice(this.CurrentSpanIndex);
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x060063AB RID: 25515 RVA: 0x0014DCA9 File Offset: 0x0014BEA9
		// (set) Token: 0x060063AC RID: 25516 RVA: 0x0014DCB1 File Offset: 0x0014BEB1
		public long Consumed { readonly get; private set; }

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x060063AD RID: 25517 RVA: 0x0014DCBA File Offset: 0x0014BEBA
		public readonly long Remaining
		{
			get
			{
				return this.Length - this.Consumed;
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x060063AE RID: 25518 RVA: 0x0014DCCC File Offset: 0x0014BECC
		public unsafe readonly long Length
		{
			get
			{
				if (this._length < 0L)
				{
					fixed (long* ptr = &this._length)
					{
						Volatile.Write(Unsafe.AsRef<long>((void*)ptr), this.Sequence.Length);
					}
				}
				return this._length;
			}
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x0014DD10 File Offset: 0x0014BF10
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe readonly bool TryPeek(out T value)
		{
			if (this._moreData)
			{
				value = *this.CurrentSpan[this.CurrentSpanIndex];
				return true;
			}
			value = default(T);
			return false;
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x0014DD50 File Offset: 0x0014BF50
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe bool TryRead(out T value)
		{
			if (this.End)
			{
				value = default(T);
				return false;
			}
			value = *this.CurrentSpan[this.CurrentSpanIndex];
			int currentSpanIndex = this.CurrentSpanIndex;
			this.CurrentSpanIndex = currentSpanIndex + 1;
			long consumed = this.Consumed;
			this.Consumed = consumed + 1L;
			if (this.CurrentSpanIndex >= this.CurrentSpan.Length)
			{
				this.GetNextSpan();
			}
			return true;
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x0014DDCC File Offset: 0x0014BFCC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Rewind(long count)
		{
			if (count > this.Consumed)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count);
			}
			this.Consumed -= count;
			if ((long)this.CurrentSpanIndex >= count)
			{
				this.CurrentSpanIndex -= (int)count;
				this._moreData = true;
				return;
			}
			this.RetreatToPreviousSpan(this.Consumed);
		}

		// Token: 0x060063B2 RID: 25522 RVA: 0x0014DE24 File Offset: 0x0014C024
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RetreatToPreviousSpan(long consumed)
		{
			this.ResetReader();
			this.Advance(consumed);
		}

		// Token: 0x060063B3 RID: 25523 RVA: 0x0014DE34 File Offset: 0x0014C034
		private void ResetReader()
		{
			this.CurrentSpanIndex = 0;
			this.Consumed = 0L;
			this._currentPosition = this.Sequence.Start;
			this._nextPosition = this._currentPosition;
			ReadOnlyMemory<T> readOnlyMemory;
			if (!this.Sequence.TryGet(ref this._nextPosition, out readOnlyMemory, true))
			{
				this._moreData = false;
				this.CurrentSpan = default(ReadOnlySpan<T>);
				return;
			}
			this._moreData = true;
			if (readOnlyMemory.Length == 0)
			{
				this.CurrentSpan = default(ReadOnlySpan<T>);
				this.GetNextSpan();
				return;
			}
			this.CurrentSpan = readOnlyMemory.Span;
		}

		// Token: 0x060063B4 RID: 25524 RVA: 0x0014DED4 File Offset: 0x0014C0D4
		private void GetNextSpan()
		{
			if (!this.Sequence.IsSingleSegment)
			{
				SequencePosition nextPosition = this._nextPosition;
				ReadOnlyMemory<T> readOnlyMemory;
				while (this.Sequence.TryGet(ref this._nextPosition, out readOnlyMemory, true))
				{
					this._currentPosition = nextPosition;
					if (readOnlyMemory.Length > 0)
					{
						this.CurrentSpan = readOnlyMemory.Span;
						this.CurrentSpanIndex = 0;
						return;
					}
					this.CurrentSpan = default(ReadOnlySpan<T>);
					this.CurrentSpanIndex = 0;
					nextPosition = this._nextPosition;
				}
			}
			this._moreData = false;
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x0014DF60 File Offset: 0x0014C160
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Advance(long count)
		{
			if ((count & -2147483648L) == 0L && this.CurrentSpan.Length - this.CurrentSpanIndex > (int)count)
			{
				this.CurrentSpanIndex += (int)count;
				this.Consumed += count;
				return;
			}
			this.AdvanceToNextSpan(count);
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x0014DFB8 File Offset: 0x0014C1B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void AdvanceCurrentSpan(long count)
		{
			this.Consumed += count;
			this.CurrentSpanIndex += (int)count;
			if (this.CurrentSpanIndex >= this.CurrentSpan.Length)
			{
				this.GetNextSpan();
			}
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x0014DFFE File Offset: 0x0014C1FE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void AdvanceWithinSpan(long count)
		{
			this.Consumed += count;
			this.CurrentSpanIndex += (int)count;
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x0014E020 File Offset: 0x0014C220
		private void AdvanceToNextSpan(long count)
		{
			if (count < 0L)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count);
			}
			this.Consumed += count;
			while (this._moreData)
			{
				int num = this.CurrentSpan.Length - this.CurrentSpanIndex;
				if ((long)num > count)
				{
					this.CurrentSpanIndex += (int)count;
					count = 0L;
					break;
				}
				this.CurrentSpanIndex += num;
				count -= (long)num;
				this.GetNextSpan();
				if (count == 0L)
				{
					break;
				}
			}
			if (count != 0L)
			{
				this.Consumed -= count;
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count);
			}
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x0014E0B8 File Offset: 0x0014C2B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool TryCopyTo(Span<T> destination)
		{
			ReadOnlySpan<T> unreadSpan = this.UnreadSpan;
			if (unreadSpan.Length >= destination.Length)
			{
				unreadSpan.Slice(0, destination.Length).CopyTo(destination);
				return true;
			}
			return this.TryCopyMultisegment(destination);
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x0014E100 File Offset: 0x0014C300
		internal readonly bool TryCopyMultisegment(Span<T> destination)
		{
			if (this.Remaining < (long)destination.Length)
			{
				return false;
			}
			ReadOnlySpan<T> unreadSpan = this.UnreadSpan;
			unreadSpan.CopyTo(destination);
			int num = unreadSpan.Length;
			SequencePosition nextPosition = this._nextPosition;
			ReadOnlyMemory<T> readOnlyMemory;
			while (this.Sequence.TryGet(ref nextPosition, out readOnlyMemory, true))
			{
				if (readOnlyMemory.Length > 0)
				{
					ReadOnlySpan<T> span = readOnlyMemory.Span;
					int num2 = Math.Min(span.Length, destination.Length - num);
					span.Slice(0, num2).CopyTo(destination.Slice(num));
					num += num2;
					if (num >= destination.Length)
					{
						break;
					}
				}
			}
			return true;
		}

		// Token: 0x04003A89 RID: 14985
		private SequencePosition _currentPosition;

		// Token: 0x04003A8A RID: 14986
		private SequencePosition _nextPosition;

		// Token: 0x04003A8B RID: 14987
		private bool _moreData;

		// Token: 0x04003A8C RID: 14988
		private readonly long _length;
	}
}
