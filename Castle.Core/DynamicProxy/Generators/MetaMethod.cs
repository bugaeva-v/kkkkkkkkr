using System;
using System.Diagnostics;
using System.Reflection;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000041 RID: 65
	[DebuggerDisplay("{Method}")]
	public class MetaMethod : MetaTypeElement, IEquatable<MetaMethod>
	{
		// Token: 0x06000204 RID: 516 RVA: 0x00008810 File Offset: 0x00006A10
		public MetaMethod(MethodInfo method, MethodInfo methodOnTarget, bool standalone, bool proxyable, bool hasTarget) : base(method.DeclaringType)
		{
			this.Method = method;
			this.name = method.Name;
			this.MethodOnTarget = methodOnTarget;
			this.Standalone = standalone;
			this.Proxyable = proxyable;
			this.HasTarget = hasTarget;
			this.Attributes = this.ObtainAttributes();
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00008866 File Offset: 0x00006A66
		// (set) Token: 0x06000206 RID: 518 RVA: 0x0000886E File Offset: 0x00006A6E
		public MethodAttributes Attributes { get; private set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00008877 File Offset: 0x00006A77
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0000887F File Offset: 0x00006A7F
		public bool HasTarget { get; private set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00008888 File Offset: 0x00006A88
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00008890 File Offset: 0x00006A90
		public MethodInfo Method { get; private set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00008899 File Offset: 0x00006A99
		// (set) Token: 0x0600020C RID: 524 RVA: 0x000088A1 File Offset: 0x00006AA1
		public MethodInfo MethodOnTarget { get; private set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600020D RID: 525 RVA: 0x000088AA File Offset: 0x00006AAA
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600020E RID: 526 RVA: 0x000088B2 File Offset: 0x00006AB2
		// (set) Token: 0x0600020F RID: 527 RVA: 0x000088BA File Offset: 0x00006ABA
		public bool Proxyable { get; private set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000088C3 File Offset: 0x00006AC3
		// (set) Token: 0x06000211 RID: 529 RVA: 0x000088CB File Offset: 0x00006ACB
		public bool Standalone { get; private set; }

		// Token: 0x06000212 RID: 530 RVA: 0x000088D4 File Offset: 0x00006AD4
		public bool Equals(MetaMethod other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			if (!StringComparer.OrdinalIgnoreCase.Equals(this.name, other.name))
			{
				return false;
			}
			MethodSignatureComparer instance = MethodSignatureComparer.Instance;
			return instance.EqualSignatureTypes(this.Method.ReturnType, other.Method.ReturnType) && instance.EqualGenericParameters(this.Method, other.Method) && instance.EqualParameters(this.Method, other.Method);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000895C File Offset: 0x00006B5C
		internal override void SwitchToExplicitImplementation()
		{
			this.Attributes = (MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask);
			if (!this.Standalone)
			{
				this.Attributes |= MethodAttributes.SpecialName;
			}
			this.name = MetaTypeElementUtil.CreateNameForExplicitImplementation(this.sourceType, this.Method.Name);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000089AC File Offset: 0x00006BAC
		private MethodAttributes ObtainAttributes()
		{
			MethodInfo method = this.Method;
			MethodAttributes methodAttributes = MethodAttributes.Virtual;
			if (method.IsFinal || this.Method.DeclaringType.GetTypeInfo().IsInterface)
			{
				methodAttributes |= MethodAttributes.VtableLayoutMask;
			}
			if (method.IsPublic)
			{
				methodAttributes |= MethodAttributes.Public;
			}
			if (method.IsHideBySig)
			{
				methodAttributes |= MethodAttributes.HideBySig;
			}
			if (ProxyUtil.IsInternal(method) && ProxyUtil.AreInternalsVisibleToDynamicProxy(method.DeclaringType.GetTypeInfo().Assembly))
			{
				methodAttributes |= MethodAttributes.Assembly;
			}
			if (method.IsFamilyAndAssembly)
			{
				methodAttributes |= MethodAttributes.FamANDAssem;
			}
			else if (method.IsFamilyOrAssembly)
			{
				methodAttributes |= MethodAttributes.FamORAssem;
			}
			else if (method.IsFamily)
			{
				methodAttributes |= MethodAttributes.Family;
			}
			if (!this.Standalone)
			{
				methodAttributes |= MethodAttributes.SpecialName;
			}
			return methodAttributes;
		}

		// Token: 0x0400007F RID: 127
		private const MethodAttributes ExplicitImplementationAttributes = MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask;

		// Token: 0x04000080 RID: 128
		private string name;
	}
}
