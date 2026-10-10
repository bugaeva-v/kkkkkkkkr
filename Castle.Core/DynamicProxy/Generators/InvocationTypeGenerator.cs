using System;
using System.Collections.Generic;
using System.Reflection;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x0200003F RID: 63
	public abstract class InvocationTypeGenerator : IGenerator<AbstractTypeEmitter>
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x00007F8E File Offset: 0x0000618E
		protected InvocationTypeGenerator(Type targetType, MetaMethod method, MethodInfo callback, bool canChangeTarget, IInvocationCreationContributor contributor)
		{
			this.targetType = targetType;
			this.method = method;
			this.callback = callback;
			this.canChangeTarget = canChangeTarget;
			this.contributor = contributor;
		}

		// Token: 0x060001E9 RID: 489
		protected abstract ArgumentReference[] GetBaseCtorArguments(Type targetFieldType, ProxyGenerationOptions proxyGenerationOptions, out ConstructorInfo baseConstructor);

		// Token: 0x060001EA RID: 490
		protected abstract Type GetBaseType();

		// Token: 0x060001EB RID: 491
		protected abstract FieldReference GetTargetReference();

		// Token: 0x060001EC RID: 492 RVA: 0x00007FBC File Offset: 0x000061BC
		public AbstractTypeEmitter Generate(ClassEmitter @class, ProxyGenerationOptions options, INamingScope namingScope)
		{
			MethodInfo methodInfo = this.method.Method;
			Type[] interfaces = new Type[0];
			if (this.canChangeTarget)
			{
				interfaces = new Type[]
				{
					typeof(IChangeProxyTarget)
				};
			}
			AbstractTypeEmitter emitter = this.GetEmitter(@class, interfaces, namingScope, methodInfo);
			emitter.CopyGenericParametersFromMethod(methodInfo);
			this.CreateConstructor(emitter, options);
			FieldReference targetReference = this.GetTargetReference();
			if (this.canChangeTarget)
			{
				this.ImplementChangeProxyTargetInterface(@class, emitter, targetReference);
			}
			this.ImplemementInvokeMethodOnTarget(emitter, methodInfo.GetParameters(), targetReference, this.callback);
			emitter.DefineCustomAttribute<SerializableAttribute>();
			return emitter;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00008045 File Offset: 0x00006245
		protected virtual MethodInvocationExpression GetCallbackMethodInvocation(AbstractTypeEmitter invocation, Expression[] args, MethodInfo callbackMethod, Reference targetField, MethodEmitter invokeMethodOnTarget)
		{
			if (this.contributor != null)
			{
				return this.contributor.GetCallbackMethodInvocation(invocation, args, targetField, invokeMethodOnTarget);
			}
			return new MethodInvocationExpression(new AsTypeReference(targetField, callbackMethod.DeclaringType), callbackMethod, args)
			{
				VirtualCall = true
			};
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000807C File Offset: 0x0000627C
		protected virtual void ImplementInvokeMethodOnTarget(AbstractTypeEmitter invocation, ParameterInfo[] parameters, MethodEmitter invokeMethodOnTarget, Reference targetField)
		{
			MethodInfo callbackMethod = this.GetCallbackMethod(invocation);
			if (callbackMethod == null)
			{
				this.EmitCallThrowOnNoTarget(invokeMethodOnTarget);
				return;
			}
			Expression[] array = new Expression[parameters.Length];
			Dictionary<int, LocalReference> dictionary = new Dictionary<int, LocalReference>();
			for (int i = 0; i < parameters.Length; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				Type closedParameterType = invocation.GetClosedParameterType(parameterInfo.ParameterType);
				if (closedParameterType.IsByRef)
				{
					LocalReference localReference = invokeMethodOnTarget.CodeBuilder.DeclareLocal(closedParameterType.GetElementType());
					invokeMethodOnTarget.CodeBuilder.AddStatement(new AssignStatement(localReference, new ConvertExpression(closedParameterType.GetElementType(), new MethodInvocationExpression(SelfReference.Self, InvocationMethods.GetArgumentValue, new Expression[]
					{
						new LiteralIntExpression(i)
					}))));
					ByRefReference reference = new ByRefReference(localReference);
					array[i] = new ReferenceExpression(reference);
					dictionary[i] = localReference;
				}
				else
				{
					array[i] = new ConvertExpression(closedParameterType, new MethodInvocationExpression(SelfReference.Self, InvocationMethods.GetArgumentValue, new Expression[]
					{
						new LiteralIntExpression(i)
					}));
				}
			}
			if (dictionary.Count > 0)
			{
				invokeMethodOnTarget.CodeBuilder.AddStatement(new TryStatement());
			}
			MethodInvocationExpression callbackMethodInvocation = this.GetCallbackMethodInvocation(invocation, array, callbackMethod, targetField, invokeMethodOnTarget);
			LocalReference localReference2 = null;
			if (callbackMethod.ReturnType != typeof(void))
			{
				Type closedParameterType2 = invocation.GetClosedParameterType(callbackMethod.ReturnType);
				localReference2 = invokeMethodOnTarget.CodeBuilder.DeclareLocal(closedParameterType2);
				invokeMethodOnTarget.CodeBuilder.AddStatement(new AssignStatement(localReference2, callbackMethodInvocation));
			}
			else
			{
				invokeMethodOnTarget.CodeBuilder.AddStatement(new ExpressionStatement(callbackMethodInvocation));
			}
			this.AssignBackByRefArguments(invokeMethodOnTarget, dictionary);
			if (callbackMethod.ReturnType != typeof(void))
			{
				MethodInvocationExpression expression = new MethodInvocationExpression(SelfReference.Self, InvocationMethods.SetReturnValue, new Expression[]
				{
					new ConvertExpression(typeof(object), localReference2.Type, localReference2.ToExpression())
				});
				invokeMethodOnTarget.CodeBuilder.AddStatement(new ExpressionStatement(expression));
			}
			invokeMethodOnTarget.CodeBuilder.AddStatement(new ReturnStatement());
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00008284 File Offset: 0x00006484
		private void AssignBackByRefArguments(MethodEmitter invokeMethodOnTarget, Dictionary<int, LocalReference> byRefArguments)
		{
			if (byRefArguments.Count == 0)
			{
				return;
			}
			invokeMethodOnTarget.CodeBuilder.AddStatement(new FinallyStatement());
			foreach (KeyValuePair<int, LocalReference> keyValuePair in byRefArguments)
			{
				int key = keyValuePair.Key;
				LocalReference value = keyValuePair.Value;
				invokeMethodOnTarget.CodeBuilder.AddStatement(new ExpressionStatement(new MethodInvocationExpression(SelfReference.Self, InvocationMethods.SetArgumentValue, new Expression[]
				{
					new LiteralIntExpression(key),
					new ConvertExpression(typeof(object), value.Type, new ReferenceExpression(value))
				})));
			}
			invokeMethodOnTarget.CodeBuilder.AddStatement(new EndExceptionBlockStatement());
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00008354 File Offset: 0x00006554
		private void CreateConstructor(AbstractTypeEmitter invocation, ProxyGenerationOptions options)
		{
			ConstructorInfo constructor;
			ArgumentReference[] baseCtorArguments = this.GetBaseCtorArguments(this.targetType, options, out constructor);
			ConstructorEmitter constructorEmitter = this.CreateConstructor(invocation, baseCtorArguments);
			constructorEmitter.CodeBuilder.InvokeBaseConstructor(constructor, baseCtorArguments);
			constructorEmitter.CodeBuilder.AddStatement(new ReturnStatement());
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00008396 File Offset: 0x00006596
		private ConstructorEmitter CreateConstructor(AbstractTypeEmitter invocation, ArgumentReference[] baseCtorArguments)
		{
			if (this.contributor == null)
			{
				return invocation.CreateConstructor(baseCtorArguments);
			}
			return this.contributor.CreateConstructor(baseCtorArguments, invocation);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000083B8 File Offset: 0x000065B8
		private void EmitCallThrowOnNoTarget(MethodEmitter invokeMethodOnTarget)
		{
			ExpressionStatement stmt = new ExpressionStatement(new MethodInvocationExpression(InvocationMethods.ThrowOnNoTarget, new Expression[0]));
			invokeMethodOnTarget.CodeBuilder.AddStatement(stmt);
			invokeMethodOnTarget.CodeBuilder.AddStatement(new ReturnStatement());
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000083FC File Offset: 0x000065FC
		private MethodInfo GetCallbackMethod(AbstractTypeEmitter invocation)
		{
			if (this.contributor != null)
			{
				return this.contributor.GetCallbackMethod();
			}
			MethodInfo methodInfo = this.callback;
			if (methodInfo == null)
			{
				return null;
			}
			if (!methodInfo.IsGenericMethod)
			{
				return methodInfo;
			}
			return methodInfo.MakeGenericMethod(invocation.GetGenericArgumentsFor(methodInfo));
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00008448 File Offset: 0x00006648
		private AbstractTypeEmitter GetEmitter(ClassEmitter @class, Type[] interfaces, INamingScope namingScope, MethodInfo methodInfo)
		{
			string suggestedName = string.Format("Castle.Proxies.Invocations.{0}_{1}", methodInfo.DeclaringType.Name, methodInfo.Name);
			string uniqueName = namingScope.ParentScope.GetUniqueName(suggestedName);
			return new ClassEmitter(@class.ModuleScope, uniqueName, this.GetBaseType(), interfaces, TypeAttributes.Public | TypeAttributes.Serializable, !@class.InStrongNamedModule);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000084A4 File Offset: 0x000066A4
		private void ImplemementInvokeMethodOnTarget(AbstractTypeEmitter invocation, ParameterInfo[] parameters, FieldReference targetField, MethodInfo callbackMethod)
		{
			MethodEmitter invokeMethodOnTarget = invocation.CreateMethod("InvokeMethodOnTarget", typeof(void), new Type[0]);
			this.ImplementInvokeMethodOnTarget(invocation, parameters, invokeMethodOnTarget, targetField);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000084D8 File Offset: 0x000066D8
		private void ImplementChangeInvocationTarget(AbstractTypeEmitter invocation, FieldReference targetField)
		{
			MethodEmitter methodEmitter = invocation.CreateMethod("ChangeInvocationTarget", typeof(void), new Type[]
			{
				typeof(object)
			});
			methodEmitter.CodeBuilder.AddStatement(new AssignStatement(targetField, new ConvertExpression(this.targetType, methodEmitter.Arguments[0].ToExpression())));
			methodEmitter.CodeBuilder.AddStatement(new ReturnStatement());
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000854C File Offset: 0x0000674C
		private void ImplementChangeProxyTarget(AbstractTypeEmitter invocation, ClassEmitter @class)
		{
			MethodEmitter methodEmitter = invocation.CreateMethod("ChangeProxyTarget", typeof(void), new Type[]
			{
				typeof(object)
			});
			FieldReference fieldReference = new FieldReference(InvocationMethods.ProxyObject);
			LocalReference localReference = methodEmitter.CodeBuilder.DeclareLocal(typeof(IProxyTargetAccessor));
			methodEmitter.CodeBuilder.AddStatement(new AssignStatement(localReference, new ConvertExpression(localReference.Type, fieldReference.ToExpression())));
			MethodInfo methodInfo = typeof(IProxyTargetAccessor).GetMethod("DynProxySetTarget");
			methodEmitter.CodeBuilder.AddStatement(new ExpressionStatement(new MethodInvocationExpression(localReference, methodInfo, new Expression[]
			{
				methodEmitter.Arguments[0].ToExpression()
			})
			{
				VirtualCall = true
			}));
			methodEmitter.CodeBuilder.AddStatement(new ReturnStatement());
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00008621 File Offset: 0x00006821
		private void ImplementChangeProxyTargetInterface(ClassEmitter @class, AbstractTypeEmitter invocation, FieldReference targetField)
		{
			this.ImplementChangeInvocationTarget(invocation, targetField);
			this.ImplementChangeProxyTarget(invocation, @class);
		}

		// Token: 0x04000074 RID: 116
		protected readonly MetaMethod method;

		// Token: 0x04000075 RID: 117
		protected readonly Type targetType;

		// Token: 0x04000076 RID: 118
		private readonly MethodInfo callback;

		// Token: 0x04000077 RID: 119
		private readonly bool canChangeTarget;

		// Token: 0x04000078 RID: 120
		private readonly IInvocationCreationContributor contributor;
	}
}
