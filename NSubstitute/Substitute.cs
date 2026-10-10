using System;
using NSubstitute.Core;

namespace NSubstitute
{
	// Token: 0x02000017 RID: 23
	public static class Substitute
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002786 File Offset: 0x00000986
		public static T For<T>(params object[] constructorArguments) where T : class
		{
			return (T)((object)Substitute.For(new Type[]
			{
				typeof(T)
			}, constructorArguments));
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000027A6 File Offset: 0x000009A6
		public static T1 For<T1, T2>(params object[] constructorArguments) where T1 : class where T2 : class
		{
			return (T1)((object)Substitute.For(new Type[]
			{
				typeof(T1),
				typeof(T2)
			}, constructorArguments));
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000027D3 File Offset: 0x000009D3
		public static T1 For<T1, T2, T3>(params object[] constructorArguments) where T1 : class where T2 : class where T3 : class
		{
			return (T1)((object)Substitute.For(new Type[]
			{
				typeof(T1),
				typeof(T2),
				typeof(T3)
			}, constructorArguments));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000280D File Offset: 0x00000A0D
		public static object For(Type[] typesToProxy, object[] constructorArguments)
		{
			return SubstitutionContext.Current.SubstituteFactory.Create(typesToProxy, constructorArguments);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002820 File Offset: 0x00000A20
		public static T ForPartsOf<T>(params object[] constructorArguments) where T : class
		{
			return (T)((object)SubstitutionContext.Current.SubstituteFactory.CreatePartial(new Type[]
			{
				typeof(T)
			}, constructorArguments));
		}
	}
}
