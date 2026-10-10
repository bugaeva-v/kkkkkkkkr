using System;
using System.Reflection;
using Castle.DynamicProxy.Generators.Emitters;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000040 RID: 64
	public class MetaEvent : MetaTypeElement, IEquatable<MetaEvent>
	{
		// Token: 0x060001F9 RID: 505 RVA: 0x00008634 File Offset: 0x00006834
		public MetaEvent(string name, Type declaringType, Type eventDelegateType, MetaMethod adder, MetaMethod remover, EventAttributes attributes) : base(declaringType)
		{
			if (adder == null)
			{
				throw new ArgumentNullException("adder");
			}
			if (remover == null)
			{
				throw new ArgumentNullException("remover");
			}
			this.name = name;
			this.type = eventDelegateType;
			this.adder = adder;
			this.remover = remover;
			this.Attributes = attributes;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000868C File Offset: 0x0000688C
		public MetaMethod Adder
		{
			get
			{
				return this.adder;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00008694 File Offset: 0x00006894
		// (set) Token: 0x060001FC RID: 508 RVA: 0x0000869C File Offset: 0x0000689C
		public EventAttributes Attributes { get; private set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000086A5 File Offset: 0x000068A5
		public EventEmitter Emitter
		{
			get
			{
				if (this.emitter != null)
				{
					return this.emitter;
				}
				throw new InvalidOperationException("Emitter is not initialized. You have to initialize it first using 'BuildEventEmitter' method");
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000086C0 File Offset: 0x000068C0
		public MetaMethod Remover
		{
			get
			{
				return this.remover;
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000086C8 File Offset: 0x000068C8
		public void BuildEventEmitter(ClassEmitter classEmitter)
		{
			if (this.emitter != null)
			{
				throw new InvalidOperationException();
			}
			this.emitter = classEmitter.CreateEvent(this.name, this.Attributes, this.type);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000086F6 File Offset: 0x000068F6
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || (!(obj.GetType() != typeof(MetaEvent)) && this.Equals((MetaEvent)obj)));
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00008728 File Offset: 0x00006928
		public override int GetHashCode()
		{
			return (((this.adder.Method != null) ? this.adder.Method.GetHashCode() : 0) * 397 ^ ((this.remover.Method != null) ? this.remover.Method.GetHashCode() : 0)) * 397 ^ this.Attributes.GetHashCode();
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000087A3 File Offset: 0x000069A3
		public bool Equals(MetaEvent other)
		{
			return other != null && (this == other || (this.type.Equals(other.type) && StringComparer.OrdinalIgnoreCase.Equals(this.name, other.name)));
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000087E0 File Offset: 0x000069E0
		internal override void SwitchToExplicitImplementation()
		{
			this.name = MetaTypeElementUtil.CreateNameForExplicitImplementation(this.sourceType, this.name);
			this.adder.SwitchToExplicitImplementation();
			this.remover.SwitchToExplicitImplementation();
		}

		// Token: 0x04000079 RID: 121
		private readonly MetaMethod adder;

		// Token: 0x0400007A RID: 122
		private readonly MetaMethod remover;

		// Token: 0x0400007B RID: 123
		private readonly Type type;

		// Token: 0x0400007C RID: 124
		private EventEmitter emitter;

		// Token: 0x0400007D RID: 125
		private string name;
	}
}
