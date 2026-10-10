using System;
using System.ComponentModel;
using System.Reflection;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x0200002F RID: 47
	[Obsolete("Intended for internal use only.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	public class CacheKey
	{
		// Token: 0x06000196 RID: 406 RVA: 0x0000669E File Offset: 0x0000489E
		public CacheKey(MemberInfo target, Type type, Type[] interfaces, ProxyGenerationOptions options)
		{
			this.target = target;
			this.type = type;
			this.interfaces = (interfaces ?? Type.EmptyTypes);
			this.options = options;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000066CC File Offset: 0x000048CC
		public CacheKey(Type target, Type[] interfaces, ProxyGenerationOptions options) : this(target.GetTypeInfo(), null, interfaces, options)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000066E0 File Offset: 0x000048E0
		public override int GetHashCode()
		{
			int num = this.target.GetHashCode();
			foreach (Type type in this.interfaces)
			{
				num = 29 * num + type.GetHashCode();
			}
			if (this.options != null)
			{
				num = 29 * num + this.options.GetHashCode();
			}
			if (this.type != null)
			{
				num = 29 * num + this.type.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00006758 File Offset: 0x00004958
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			CacheKey cacheKey = obj as CacheKey;
			if (cacheKey == null)
			{
				return false;
			}
			if (!object.Equals(this.type, cacheKey.type))
			{
				return false;
			}
			if (!object.Equals(this.target, cacheKey.target))
			{
				return false;
			}
			if (this.interfaces.Length != cacheKey.interfaces.Length)
			{
				return false;
			}
			for (int i = 0; i < this.interfaces.Length; i++)
			{
				if (!object.Equals(this.interfaces[i], cacheKey.interfaces[i]))
				{
					return false;
				}
			}
			return object.Equals(this.options, cacheKey.options);
		}

		// Token: 0x0400006C RID: 108
		private readonly MemberInfo target;

		// Token: 0x0400006D RID: 109
		private readonly Type[] interfaces;

		// Token: 0x0400006E RID: 110
		private readonly ProxyGenerationOptions options;

		// Token: 0x0400006F RID: 111
		private readonly Type type;
	}
}
