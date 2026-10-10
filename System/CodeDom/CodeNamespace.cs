using System;

namespace System.CodeDom
{
	/// <summary>Представляет объявление пространства имен.</summary>
	// Token: 0x0200031C RID: 796
	[Serializable]
	public class CodeNamespace : CodeObject
	{
		/// <summary>Событие, которое будет вызвано в первый раз при доступе к коллекции <see cref="P:System.CodeDom.CodeNamespace.Comments" />.</summary>
		// Token: 0x14000020 RID: 32
		// (add) Token: 0x0600194A RID: 6474 RVA: 0x000603F4 File Offset: 0x0005E5F4
		// (remove) Token: 0x0600194B RID: 6475 RVA: 0x0006042C File Offset: 0x0005E62C
		public event EventHandler PopulateComments;

		/// <summary>Событие, которое будет вызвано в первый раз при доступе к коллекции <see cref="P:System.CodeDom.CodeNamespace.Imports" />.</summary>
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x0600194C RID: 6476 RVA: 0x00060464 File Offset: 0x0005E664
		// (remove) Token: 0x0600194D RID: 6477 RVA: 0x0006049C File Offset: 0x0005E69C
		public event EventHandler PopulateImports;

		/// <summary>Событие, которое будет вызвано в первый раз при доступе к коллекции <see cref="P:System.CodeDom.CodeNamespace.Types" />.</summary>
		// Token: 0x14000022 RID: 34
		// (add) Token: 0x0600194E RID: 6478 RVA: 0x000604D4 File Offset: 0x0005E6D4
		// (remove) Token: 0x0600194F RID: 6479 RVA: 0x0006050C File Offset: 0x0005E70C
		public event EventHandler PopulateTypes;

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeNamespace" />.</summary>
		// Token: 0x06001950 RID: 6480 RVA: 0x00060541 File Offset: 0x0005E741
		public CodeNamespace()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeNamespace" /> с использованием указанного имени.</summary>
		/// <param name="name">Имя объявляемого пространства имен.</param>
		// Token: 0x06001951 RID: 6481 RVA: 0x0006056A File Offset: 0x0005E76A
		public CodeNamespace(string name)
		{
			this.Name = name;
		}

		/// <summary>Получает коллекцию типов, содержащихся в пространстве имен.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeDeclarationCollection" /> указывает типы, содержащиеся в пространстве имен.</returns>
		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x0006059A File Offset: 0x0005E79A
		public CodeTypeDeclarationCollection Types
		{
			get
			{
				if ((this._populated & 4) == 0)
				{
					this._populated |= 4;
					EventHandler populateTypes = this.PopulateTypes;
					if (populateTypes != null)
					{
						populateTypes(this, EventArgs.Empty);
					}
				}
				return this._classes;
			}
		}

		/// <summary>Получает коллекцию директив импорта пространства имен, используемую пространством имен.</summary>
		/// <returns>Свойство <see cref="T:System.CodeDom.CodeNamespaceImportCollection" /> указывает директивы импорта пространства имен, используемые пространством имен.</returns>
		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x000605D1 File Offset: 0x0005E7D1
		public CodeNamespaceImportCollection Imports
		{
			get
			{
				if ((this._populated & 1) == 0)
				{
					this._populated |= 1;
					EventHandler populateImports = this.PopulateImports;
					if (populateImports != null)
					{
						populateImports(this, EventArgs.Empty);
					}
				}
				return this._imports;
			}
		}

		/// <summary>Получает или задает имя пространства имен.</summary>
		/// <returns>Имя пространства имен.</returns>
		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x00060608 File Offset: 0x0005E808
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x00060619 File Offset: 0x0005E819
		public string Name
		{
			get
			{
				return this._name ?? string.Empty;
			}
			set
			{
				this._name = value;
			}
		}

		/// <summary>Получает комментарии для пространства имен.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeCommentStatementCollection" /> указывает комментарии для пространства имен.</returns>
		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x00060622 File Offset: 0x0005E822
		public CodeCommentStatementCollection Comments
		{
			get
			{
				if ((this._populated & 2) == 0)
				{
					this._populated |= 2;
					EventHandler populateComments = this.PopulateComments;
					if (populateComments != null)
					{
						populateComments(this, EventArgs.Empty);
					}
				}
				return this._comments;
			}
		}

		// Token: 0x04000DB6 RID: 3510
		private string _name;

		// Token: 0x04000DB7 RID: 3511
		private readonly CodeNamespaceImportCollection _imports = new CodeNamespaceImportCollection();

		// Token: 0x04000DB8 RID: 3512
		private readonly CodeCommentStatementCollection _comments = new CodeCommentStatementCollection();

		// Token: 0x04000DB9 RID: 3513
		private readonly CodeTypeDeclarationCollection _classes = new CodeTypeDeclarationCollection();

		// Token: 0x04000DBA RID: 3514
		private int _populated;

		// Token: 0x04000DBB RID: 3515
		private const int ImportsCollection = 1;

		// Token: 0x04000DBC RID: 3516
		private const int CommentsCollection = 2;

		// Token: 0x04000DBD RID: 3517
		private const int TypesCollection = 4;
	}
}
