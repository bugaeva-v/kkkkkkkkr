using System;
using System.Collections.Specialized;

namespace System.CodeDom
{
	/// <summary>Предусматривает контейнер для программного графа CodeDOM.</summary>
	// Token: 0x02000302 RID: 770
	[Serializable]
	public class CodeCompileUnit : CodeObject
	{
		/// <summary>Получает коллекцию пространств имен.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeNamespaceCollection" />, указывающий используемые единицей компиляции пространства имен.</returns>
		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x0005F7DB File Offset: 0x0005D9DB
		public CodeNamespaceCollection Namespaces { get; } = new CodeNamespaceCollection();

		/// <summary>Возвращает сборки, на которые имеются ссылки.</summary>
		/// <returns>
		///   <see cref="T:System.Collections.Specialized.StringCollection" />, содержащий имена файлов сборок, на которые осуществляется ссылка.</returns>
		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x0005F7E4 File Offset: 0x0005D9E4
		public StringCollection ReferencedAssemblies
		{
			get
			{
				StringCollection result;
				if ((result = this._assemblies) == null)
				{
					result = (this._assemblies = new StringCollection());
				}
				return result;
			}
		}

		/// <summary>Получает коллекцию пользовательских атрибутов для создаваемой сборки.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" />, указывающий пользовательские атрибуты для создаваемой сборки.</returns>
		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x0005F80C File Offset: 0x0005DA0C
		public CodeAttributeDeclarationCollection AssemblyCustomAttributes
		{
			get
			{
				CodeAttributeDeclarationCollection result;
				if ((result = this._attributes) == null)
				{
					result = (this._attributes = new CodeAttributeDeclarationCollection());
				}
				return result;
			}
		}

		/// <summary>Получает объект <see cref="T:System.CodeDom.CodeDirectiveCollection" />, содержащий начальные директивы.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeDirectiveCollection" />, содержащий начальные директивы.</returns>
		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x0005F834 File Offset: 0x0005DA34
		public CodeDirectiveCollection StartDirectives
		{
			get
			{
				CodeDirectiveCollection result;
				if ((result = this._startDirectives) == null)
				{
					result = (this._startDirectives = new CodeDirectiveCollection());
				}
				return result;
			}
		}

		/// <summary>Получает объект <see cref="T:System.CodeDom.CodeDirectiveCollection" />, содержащий конечные директивы.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeDirectiveCollection" />, содержащий конечные директивы.</returns>
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x0005F85C File Offset: 0x0005DA5C
		public CodeDirectiveCollection EndDirectives
		{
			get
			{
				CodeDirectiveCollection result;
				if ((result = this._endDirectives) == null)
				{
					result = (this._endDirectives = new CodeDirectiveCollection());
				}
				return result;
			}
		}

		// Token: 0x04000D76 RID: 3446
		private StringCollection _assemblies;

		// Token: 0x04000D77 RID: 3447
		private CodeAttributeDeclarationCollection _attributes;

		// Token: 0x04000D78 RID: 3448
		private CodeDirectiveCollection _startDirectives;

		// Token: 0x04000D79 RID: 3449
		private CodeDirectiveCollection _endDirectives;
	}
}
