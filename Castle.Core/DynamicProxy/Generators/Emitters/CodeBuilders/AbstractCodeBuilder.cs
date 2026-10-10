using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Castle.DynamicProxy.Generators.Emitters.CodeBuilders
{
	// Token: 0x0200008C RID: 140
	public abstract class AbstractCodeBuilder
	{
		// Token: 0x06000381 RID: 897 RVA: 0x0000CC6E File Offset: 0x0000AE6E
		protected AbstractCodeBuilder(ILGenerator generator)
		{
			this.generator = generator;
			this.stmts = new List<Statement>();
			this.ilmarkers = new List<Reference>();
			this.isEmpty = true;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000CC9A File Offset: 0x0000AE9A
		public ILGenerator Generator
		{
			get
			{
				return this.generator;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0000CCA2 File Offset: 0x0000AEA2
		internal bool IsEmpty
		{
			get
			{
				return this.isEmpty;
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000CCAA File Offset: 0x0000AEAA
		public AbstractCodeBuilder AddExpression(Expression expression)
		{
			return this.AddStatement(new ExpressionStatement(expression));
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000CCB8 File Offset: 0x0000AEB8
		public AbstractCodeBuilder AddStatement(Statement stmt)
		{
			this.SetNonEmpty();
			this.stmts.Add(stmt);
			return this;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000CCD0 File Offset: 0x0000AED0
		public LocalReference DeclareLocal(Type type)
		{
			LocalReference localReference = new LocalReference(type);
			this.ilmarkers.Add(localReference);
			return localReference;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000CCF1 File Offset: 0x0000AEF1
		public void SetNonEmpty()
		{
			this.isEmpty = false;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000CCFC File Offset: 0x0000AEFC
		internal void Generate(IMemberEmitter member, ILGenerator il)
		{
			foreach (Reference reference in this.ilmarkers)
			{
				reference.Generate(il);
			}
			foreach (Statement statement in this.stmts)
			{
				statement.Emit(member, il);
			}
		}

		// Token: 0x04000105 RID: 261
		private readonly ILGenerator generator;

		// Token: 0x04000106 RID: 262
		private readonly List<Reference> ilmarkers;

		// Token: 0x04000107 RID: 263
		private readonly List<Statement> stmts;

		// Token: 0x04000108 RID: 264
		private bool isEmpty;
	}
}
