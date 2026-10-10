using System;

namespace System.CodeDom
{
	/// <summary>Представляет ссылку на метод.</summary>
	// Token: 0x02000340 RID: 832
	[Serializable]
	public class CodeMethodReferenceExpression : CodeExpression
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeMethodReferenceExpression" />.</summary>
		// Token: 0x06001A5F RID: 6751 RVA: 0x0005EE88 File Offset: 0x0005D088
		public CodeMethodReferenceExpression()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeMethodReferenceExpression" />, используя указанные целевой объект и имя метода.</summary>
		/// <param name="targetObject">Объект <see cref="T:System.CodeDom.CodeExpression" />, указывающий объект цели.</param>
		/// <param name="methodName">Имя вызываемого метода.</param>
		// Token: 0x06001A60 RID: 6752 RVA: 0x00061888 File Offset: 0x0005FA88
		public CodeMethodReferenceExpression(CodeExpression targetObject, string methodName)
		{
			this.TargetObject = targetObject;
			this.MethodName = methodName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeMethodReferenceExpression" />, используя указанные целевой объект, имя метода и аргументы универсального типа.</summary>
		/// <param name="targetObject">Объект <see cref="T:System.CodeDom.CodeExpression" />, указывающий объект цели.</param>
		/// <param name="methodName">Имя вызываемого метода.</param>
		/// <param name="typeParameters">Массив значений <see cref="T:System.CodeDom.CodeTypeReference" />, указывающих свойство <see cref="P:System.CodeDom.CodeMethodReferenceExpression.TypeArguments" /> для данного объекта <see cref="T:System.CodeDom.CodeMethodReferenceExpression" />.</param>
		// Token: 0x06001A61 RID: 6753 RVA: 0x0006189E File Offset: 0x0005FA9E
		public CodeMethodReferenceExpression(CodeExpression targetObject, string methodName, params CodeTypeReference[] typeParameters)
		{
			this.TargetObject = targetObject;
			this.MethodName = methodName;
			if (typeParameters != null && typeParameters.Length != 0)
			{
				this.TypeArguments.AddRange(typeParameters);
			}
		}

		/// <summary>Получает или задает выражение, указывающее метод для ссылки.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeExpression" />, представляющий метод для ссылки.</returns>
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x000618C7 File Offset: 0x0005FAC7
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x000618CF File Offset: 0x0005FACF
		public CodeExpression TargetObject { get; set; }

		/// <summary>Получает или задает имя метода для ссылки.</summary>
		/// <returns>Имя метода для ссылки.</returns>
		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x000618D8 File Offset: 0x0005FAD8
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x000618E9 File Offset: 0x0005FAE9
		public string MethodName
		{
			get
			{
				return this._methodName ?? string.Empty;
			}
			set
			{
				this._methodName = value;
			}
		}

		/// <summary>Получает аргументы типа для выражения ссылки текущего универсального метода.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeTypeReferenceCollection" />, содержащий аргументы типа для объекта <see cref="T:System.CodeDom.CodeMethodReferenceExpression" /> в текущем коде.</returns>
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x000618F4 File Offset: 0x0005FAF4
		public CodeTypeReferenceCollection TypeArguments
		{
			get
			{
				CodeTypeReferenceCollection result;
				if ((result = this._typeArguments) == null)
				{
					result = (this._typeArguments = new CodeTypeReferenceCollection());
				}
				return result;
			}
		}

		// Token: 0x04000E16 RID: 3606
		private string _methodName;

		// Token: 0x04000E17 RID: 3607
		private CodeTypeReferenceCollection _typeArguments;
	}
}
