using System;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.Emit;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x0200004D RID: 77
	public abstract class ArgumentsUtil
	{
		// Token: 0x0600027D RID: 637 RVA: 0x0000A0B4 File Offset: 0x000082B4
		public static Expression[] ConvertArgumentReferenceToExpression(ArgumentReference[] args)
		{
			Expression[] array = new Expression[args.Length];
			for (int i = 0; i < args.Length; i++)
			{
				array[i] = args[i].ToExpression();
			}
			return array;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000A0E4 File Offset: 0x000082E4
		public static ArgumentReference[] ConvertToArgumentReference(Type[] args)
		{
			ArgumentReference[] array = new ArgumentReference[args.Length];
			for (int i = 0; i < args.Length; i++)
			{
				array[i] = new ArgumentReference(args[i]);
			}
			return array;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000A114 File Offset: 0x00008314
		public static ArgumentReference[] ConvertToArgumentReference(ParameterInfo[] args)
		{
			ArgumentReference[] array = new ArgumentReference[args.Length];
			for (int i = 0; i < args.Length; i++)
			{
				array[i] = new ArgumentReference(args[i].ParameterType);
			}
			return array;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000A14C File Offset: 0x0000834C
		public static ReferenceExpression[] ConvertToArgumentReferenceExpression(ParameterInfo[] args)
		{
			ReferenceExpression[] array = new ReferenceExpression[args.Length];
			for (int i = 0; i < args.Length; i++)
			{
				array[i] = new ReferenceExpression(new ArgumentReference(args[i].ParameterType, i + 1));
			}
			return array;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000A189 File Offset: 0x00008389
		public static void EmitLoadOwnerAndReference(Reference reference, ILGenerator il)
		{
			if (reference == null)
			{
				return;
			}
			ArgumentsUtil.EmitLoadOwnerAndReference(reference.OwnerReference, il);
			reference.LoadReference(il);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000A1A4 File Offset: 0x000083A4
		public static Type[] GetTypes(ParameterInfo[] parameters)
		{
			Type[] array = new Type[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				array[i] = parameters[i].ParameterType;
			}
			return array;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000A1D4 File Offset: 0x000083D4
		public static Type[] InitializeAndConvert(ArgumentReference[] args)
		{
			Type[] array = new Type[args.Length];
			for (int i = 0; i < args.Length; i++)
			{
				args[i].Position = i + 1;
				array[i] = args[i].Type;
			}
			return array;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000A210 File Offset: 0x00008410
		public static void InitializeArgumentsByPosition(ArgumentReference[] args, bool isStatic)
		{
			int num = isStatic ? 0 : 1;
			for (int i = 0; i < args.Length; i++)
			{
				args[i].Position = i + num;
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000A240 File Offset: 0x00008440
		[Obsolete]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool IsAnyByRef(ParameterInfo[] parameters)
		{
			for (int i = 0; i < parameters.Length; i++)
			{
				if (parameters[i].ParameterType.GetTypeInfo().IsByRef)
				{
					return true;
				}
			}
			return false;
		}
	}
}
