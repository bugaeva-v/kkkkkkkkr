using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x02000061 RID: 97
	public class Argument
	{
		// Token: 0x06000139 RID: 313 RVA: 0x00004F6E File Offset: 0x0000316E
		[Obsolete("This constructor overload is deprecated and will be removed in the next version.")]
		public Argument(Type declaredType, [Nullable(new byte[]
		{
			0,
			2
		})] Func<object> getValue, [Nullable(new byte[]
		{
			0,
			2
		})] Action<object> setValue)
		{
			this._declaredType = declaredType;
			this._getValue = getValue;
			this._setValue = setValue;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004F8B File Offset: 0x0000318B
		public Argument(ICall call, int argIndex)
		{
			this._call = call;
			this._argIndex = argIndex;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00004FA1 File Offset: 0x000031A1
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00004FC9 File Offset: 0x000031C9
		[Nullable(2)]
		public object Value
		{
			[NullableContext(2)]
			get
			{
				if (this._getValue == null)
				{
					return this._call.GetArguments()[this._argIndex];
				}
				return this._getValue();
			}
			[NullableContext(2)]
			set
			{
				if (this._setValue != null)
				{
					this._setValue(value);
					return;
				}
				this._call.GetArguments()[this._argIndex] = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00004FF3 File Offset: 0x000031F3
		public bool IsByRef
		{
			get
			{
				return this.DeclaredType.IsByRef;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00005000 File Offset: 0x00003200
		public Type DeclaredType
		{
			get
			{
				return this._declaredType ?? this._call.GetParameterInfos()[this._argIndex].ParameterType;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00005023 File Offset: 0x00003223
		public Type ActualType
		{
			get
			{
				if (this.Value != null)
				{
					return this.Value.GetType();
				}
				return this.DeclaredType;
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000503F File Offset: 0x0000323F
		public bool IsDeclaredTypeEqualToOrByRefVersionOf(Type type)
		{
			return Argument.AsNonByRefType(this.DeclaredType) == type;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005052 File Offset: 0x00003252
		public bool IsValueAssignableTo(Type type)
		{
			return type.IsAssignableFrom(Argument.AsNonByRefType(this.ActualType));
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00005065 File Offset: 0x00003265
		public bool CanSetValueWithInstanceOf(Type type)
		{
			return Argument.AsNonByRefType(this.DeclaredType).IsAssignableFrom(type);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00005078 File Offset: 0x00003278
		private static Type AsNonByRefType(Type type)
		{
			if (!type.IsByRef)
			{
				return type;
			}
			return type.GetElementType();
		}

		// Token: 0x04000068 RID: 104
		[Nullable(2)]
		private readonly ICall _call;

		// Token: 0x04000069 RID: 105
		private readonly int _argIndex;

		// Token: 0x0400006A RID: 106
		[Nullable(2)]
		private readonly Type _declaredType;

		// Token: 0x0400006B RID: 107
		[Nullable(2)]
		private readonly Func<object> _getValue;

		// Token: 0x0400006C RID: 108
		[Nullable(2)]
		private readonly Action<object> _setValue;
	}
}
