using System;
using System.Collections.Generic;
using Castle.Core;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200014E RID: 334
	public sealed class VirtualSite<TNode, TMember> : IVirtualSite<TNode>, IEquatable<VirtualSite<TNode, TMember>>
	{
		// Token: 0x0600096F RID: 2415 RVA: 0x00017A66 File Offset: 0x00015C66
		public VirtualSite(IVirtualTarget<TNode, TMember> target, TMember member)
		{
			this.target = target;
			this.member = member;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x00017A7C File Offset: 0x00015C7C
		public IVirtualTarget<TNode, TMember> Target
		{
			get
			{
				return this.target;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x00017A84 File Offset: 0x00015C84
		public TMember Member
		{
			get
			{
				return this.member;
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00017A8C File Offset: 0x00015C8C
		public void OnRealizing(TNode node)
		{
			this.target.OnRealizing(node, this.member);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00017AA0 File Offset: 0x00015CA0
		public override bool Equals(object obj)
		{
			return this.Equals(obj as VirtualSite<TNode, TMember>);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00017AAE File Offset: 0x00015CAE
		public bool Equals(VirtualSite<TNode, TMember> other)
		{
			return other != null && VirtualSite<TNode, TMember>.TargetComparer.Equals(this.target, other.target) && VirtualSite<TNode, TMember>.MemberComparer.Equals(this.member, other.member);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00017AE3 File Offset: 0x00015CE3
		public override int GetHashCode()
		{
			return 1928399421 + 37 * VirtualSite<TNode, TMember>.TargetComparer.GetHashCode(this.target) + 37 * VirtualSite<TNode, TMember>.MemberComparer.GetHashCode(this.member);
		}

		// Token: 0x04000209 RID: 521
		private readonly IVirtualTarget<TNode, TMember> target;

		// Token: 0x0400020A RID: 522
		private readonly TMember member;

		// Token: 0x0400020B RID: 523
		private static readonly IEqualityComparer<IVirtualTarget<TNode, TMember>> TargetComparer = ReferenceEqualityComparer<IVirtualTarget<TNode, TMember>>.Instance;

		// Token: 0x0400020C RID: 524
		private static readonly IEqualityComparer<TMember> MemberComparer = EqualityComparer<TMember>.Default;
	}
}
