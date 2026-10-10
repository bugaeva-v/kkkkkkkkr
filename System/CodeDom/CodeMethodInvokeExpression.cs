using System;

namespace System.CodeDom
{
	/// <summary>Представляет выражение, вызывающее метод.</summary>
	// Token: 0x0200031A RID: 794
	[Serializable]
	public class CodeMethodInvokeExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeMethodInvokeExpression" />.</summary>
		// Token: 0x06001940 RID: 6464 RVA: 0x00060336 File Offset: 0x0005E536
		public CodeMethodInvokeExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeMethodInvokeExpression" />, используя указанный метод и параметры.</summary>
		/// <param name="method">
		///   <see cref="T:System.CodeDom.CodeMethodReferenceExpression" />, указывающий метод для вызова.</param>
		/// <param name="parameters">Массив объектов <see cref="T:System.CodeDom.CodeExpression" />, указывающих параметры вызова метода.</param>
		// Token: 0x06001941 RID: 6465 RVA: 0x00060349 File Offset: 0x0005E549
		public CodeMethodInvokeExpression(CodeMethodReferenceExpression method, params CodeExpression[] parameters)
		{
			this._method = method;
			this.Parameters.AddRange(parameters);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeMethodInvokeExpression" />, используя указанный конечный объект, имя метода и параметры.</summary>
		/// <param name="targetObject">
		///   <see cref="T:System.CodeDom.CodeExpression" />, указывающий конечный объект с методом для вызова.</param>
		/// <param name="methodName">Имя вызываемого метода.</param>
		/// <param name="parameters">Массив объектов <see cref="T:System.CodeDom.CodeExpression" />, указывающий параметры вызова метода.</param>
		// Token: 0x06001942 RID: 6466 RVA: 0x0006036F File Offset: 0x0005E56F
		public CodeMethodInvokeExpression(CodeExpression targetObject, string methodName, params CodeExpression[] parameters)
		{
			this._method = new CodeMethodReferenceExpression(targetObject, methodName);
			this.Parameters.AddRange(parameters);
		}

		/// <summary>Получает или задает метод для вызова.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeMethodReferenceExpression" />, указывающий метод для вызова.</returns>
		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x0006039C File Offset: 0x0005E59C
		// (set) Token: 0x06001944 RID: 6468 RVA: 0x000603C1 File Offset: 0x0005E5C1
		public CodeMethodReferenceExpression Method
		{
			get
			{
				CodeMethodReferenceExpression result;
				if ((result = this._method) == null)
				{
					result = (this._method = new CodeMethodReferenceExpression());
				}
				return result;
			}
			set
			{
				this._method = value;
			}
		}

		/// <summary>Получает параметры вызова метода.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeExpressionCollection" />, указывающий параметры вызова метода.</returns>
		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x000603CA File Offset: 0x0005E5CA
		public CodeExpressionCollection Parameters { get; } = new CodeExpressionCollection();

		// Token: 0x04000DB3 RID: 3507
		private CodeMethodReferenceExpression _method;
	}
}
