using System;

namespace System.IO
{
	// Token: 0x02000B30 RID: 2864
	public class EnumerationOptions
	{
		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x0600673E RID: 26430 RVA: 0x0015FF8C File Offset: 0x0015E18C
		internal static EnumerationOptions Compatible { get; } = new EnumerationOptions
		{
			MatchType = MatchType.Win32,
			AttributesToSkip = (FileAttributes)0,
			IgnoreInaccessible = false
		};

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x0600673F RID: 26431 RVA: 0x0015FF93 File Offset: 0x0015E193
		private static EnumerationOptions CompatibleRecursive { get; } = new EnumerationOptions
		{
			RecurseSubdirectories = true,
			MatchType = MatchType.Win32,
			AttributesToSkip = (FileAttributes)0,
			IgnoreInaccessible = false
		};

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x06006740 RID: 26432 RVA: 0x0015FF9A File Offset: 0x0015E19A
		internal static EnumerationOptions Default { get; } = new EnumerationOptions();

		// Token: 0x06006741 RID: 26433 RVA: 0x0015FFA1 File Offset: 0x0015E1A1
		public EnumerationOptions()
		{
			this.IgnoreInaccessible = true;
			this.AttributesToSkip = (FileAttributes.Hidden | FileAttributes.System);
		}

		// Token: 0x06006742 RID: 26434 RVA: 0x0015FFB7 File Offset: 0x0015E1B7
		internal static EnumerationOptions FromSearchOption(SearchOption searchOption)
		{
			if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
			{
				throw new ArgumentOutOfRangeException("searchOption", "Enum value was out of legal range.");
			}
			if (searchOption != SearchOption.AllDirectories)
			{
				return EnumerationOptions.Compatible;
			}
			return EnumerationOptions.CompatibleRecursive;
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06006743 RID: 26435 RVA: 0x0015FFDF File Offset: 0x0015E1DF
		// (set) Token: 0x06006744 RID: 26436 RVA: 0x0015FFE7 File Offset: 0x0015E1E7
		public bool RecurseSubdirectories { get; set; }

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x06006745 RID: 26437 RVA: 0x0015FFF0 File Offset: 0x0015E1F0
		// (set) Token: 0x06006746 RID: 26438 RVA: 0x0015FFF8 File Offset: 0x0015E1F8
		public bool IgnoreInaccessible { get; set; }

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x06006747 RID: 26439 RVA: 0x00160001 File Offset: 0x0015E201
		// (set) Token: 0x06006748 RID: 26440 RVA: 0x00160009 File Offset: 0x0015E209
		public int BufferSize { get; set; }

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x06006749 RID: 26441 RVA: 0x00160012 File Offset: 0x0015E212
		// (set) Token: 0x0600674A RID: 26442 RVA: 0x0016001A File Offset: 0x0015E21A
		public FileAttributes AttributesToSkip { get; set; }

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x0600674B RID: 26443 RVA: 0x00160023 File Offset: 0x0015E223
		// (set) Token: 0x0600674C RID: 26444 RVA: 0x0016002B File Offset: 0x0015E22B
		public MatchType MatchType { get; set; }

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x0600674D RID: 26445 RVA: 0x00160034 File Offset: 0x0015E234
		// (set) Token: 0x0600674E RID: 26446 RVA: 0x0016003C File Offset: 0x0015E23C
		public MatchCasing MatchCasing { get; set; }

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x0600674F RID: 26447 RVA: 0x00160045 File Offset: 0x0015E245
		// (set) Token: 0x06006750 RID: 26448 RVA: 0x0016004D File Offset: 0x0015E24D
		public bool ReturnSpecialDirectories { get; set; }
	}
}
