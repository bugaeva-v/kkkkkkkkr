using System;
using System.Reflection;

namespace System.CodeDom
{
	/// <summary>Представляет объявление типа для класса, структуры, интерфейса или перечисления.</summary>
	// Token: 0x02000333 RID: 819
	[Serializable]
	public class CodeTypeDeclaration : CodeTypeMember
	{
		/// <summary>Происходит при первом доступе к коллекции <see cref="P:System.CodeDom.CodeTypeDeclaration.BaseTypes" />.</summary>
		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060019EC RID: 6636 RVA: 0x00060F94 File Offset: 0x0005F194
		// (remove) Token: 0x060019ED RID: 6637 RVA: 0x00060FCC File Offset: 0x0005F1CC
		public event EventHandler PopulateBaseTypes;

		/// <summary>Происходит при первом доступе к коллекции <see cref="P:System.CodeDom.CodeTypeDeclaration.Members" />.</summary>
		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060019EE RID: 6638 RVA: 0x00061004 File Offset: 0x0005F204
		// (remove) Token: 0x060019EF RID: 6639 RVA: 0x0006103C File Offset: 0x0005F23C
		public event EventHandler PopulateMembers;

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeDeclaration" />.</summary>
		// Token: 0x060019F0 RID: 6640 RVA: 0x00061071 File Offset: 0x0005F271
		public CodeTypeDeclaration()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.CodeTypeDeclaration" /> с указанным именем.</summary>
		/// <param name="name">Имя нового типа.</param>
		// Token: 0x060019F1 RID: 6641 RVA: 0x00061096 File Offset: 0x0005F296
		public CodeTypeDeclaration(string name)
		{
			base.Name = name;
		}

		/// <summary>Получает или задает атрибуты типа.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.TypeAttributes" />, указывающий атрибуты типа.</returns>
		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x000610C2 File Offset: 0x0005F2C2
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x000610CA File Offset: 0x0005F2CA
		public TypeAttributes TypeAttributes { get; set; } = TypeAttributes.Public;

		/// <summary>Получает базовые типы типа.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeTypeReferenceCollection" />, указывающий базовые типы типа.</returns>
		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x000610D3 File Offset: 0x0005F2D3
		public CodeTypeReferenceCollection BaseTypes
		{
			get
			{
				if ((this._populated & 1) == 0)
				{
					this._populated |= 1;
					EventHandler populateBaseTypes = this.PopulateBaseTypes;
					if (populateBaseTypes != null)
					{
						populateBaseTypes(this, EventArgs.Empty);
					}
				}
				return this._baseTypes;
			}
		}

		/// <summary>Получает или задает значение, показывающее, является ли тип классом или ссылочным типом.</summary>
		/// <returns>Значение <see langword="true" />, если тип является классом или ссылочным типом; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0006110A File Offset: 0x0005F30A
		// (set) Token: 0x060019F6 RID: 6646 RVA: 0x0006112A File Offset: 0x0005F32A
		public bool IsClass
		{
			get
			{
				return (this.TypeAttributes & TypeAttributes.ClassSemanticsMask) == TypeAttributes.NotPublic && !this._isEnum && !this._isStruct;
			}
			set
			{
				if (value)
				{
					this.TypeAttributes &= ~TypeAttributes.ClassSemanticsMask;
					this.TypeAttributes |= TypeAttributes.NotPublic;
					this._isStruct = false;
					this._isEnum = false;
				}
			}
		}

		/// <summary>Получает или задает значение, указывающее, являются ли тип типом значения (структурой).</summary>
		/// <returns>Значение <see langword="true" />, если тип является типом значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x0006115A File Offset: 0x0005F35A
		// (set) Token: 0x060019F8 RID: 6648 RVA: 0x00061162 File Offset: 0x0005F362
		public bool IsStruct
		{
			get
			{
				return this._isStruct;
			}
			set
			{
				if (value)
				{
					this.TypeAttributes &= ~TypeAttributes.ClassSemanticsMask;
					this._isEnum = false;
				}
				this._isStruct = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, является ли тип перечислением.</summary>
		/// <returns>Значение <see langword="true" />, если тип является перечислением; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x00061184 File Offset: 0x0005F384
		// (set) Token: 0x060019FA RID: 6650 RVA: 0x0006118C File Offset: 0x0005F38C
		public bool IsEnum
		{
			get
			{
				return this._isEnum;
			}
			set
			{
				if (value)
				{
					this.TypeAttributes &= ~TypeAttributes.ClassSemanticsMask;
					this._isStruct = false;
				}
				this._isEnum = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, является ли тип интерфейсом.</summary>
		/// <returns>Значение <see langword="true" />, если тип является интерфейсом; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x000611AE File Offset: 0x0005F3AE
		// (set) Token: 0x060019FC RID: 6652 RVA: 0x000611C0 File Offset: 0x0005F3C0
		public bool IsInterface
		{
			get
			{
				return (this.TypeAttributes & TypeAttributes.ClassSemanticsMask) == TypeAttributes.ClassSemanticsMask;
			}
			set
			{
				if (value)
				{
					this.TypeAttributes &= ~TypeAttributes.ClassSemanticsMask;
					this.TypeAttributes |= TypeAttributes.ClassSemanticsMask;
					this._isStruct = false;
					this._isEnum = false;
					return;
				}
				this.TypeAttributes &= ~TypeAttributes.ClassSemanticsMask;
			}
		}

		/// <summary>Получает или задает значение, указывающее, является ли объявление типа полным или разделяемым.</summary>
		/// <returns>Значение <see langword="true" />, если объявление класса или структуры является частичным представлением реализации; значение <see langword="false" />, если объявление является полной реализацией класса или структуры. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x0006120C File Offset: 0x0005F40C
		// (set) Token: 0x060019FE RID: 6654 RVA: 0x00061214 File Offset: 0x0005F414
		public bool IsPartial { get; set; }

		/// <summary>Получает коллекцию элементов класса для представленного типа.</summary>
		/// <returns>Объект <see cref="T:System.CodeDom.CodeTypeMemberCollection" />, указывающий элементы класса.</returns>
		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x0006121D File Offset: 0x0005F41D
		public CodeTypeMemberCollection Members
		{
			get
			{
				if ((this._populated & 2) == 0)
				{
					this._populated |= 2;
					EventHandler populateMembers = this.PopulateMembers;
					if (populateMembers != null)
					{
						populateMembers(this, EventArgs.Empty);
					}
				}
				return this._members;
			}
		}

		/// <summary>Получает параметры типа для объявления типа.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeParameterCollection" />, содержащий параметры типа для объявления типа.</returns>
		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00061254 File Offset: 0x0005F454
		public CodeTypeParameterCollection TypeParameters
		{
			get
			{
				CodeTypeParameterCollection result;
				if ((result = this._typeParameters) == null)
				{
					result = (this._typeParameters = new CodeTypeParameterCollection());
				}
				return result;
			}
		}

		// Token: 0x04000DE2 RID: 3554
		private readonly CodeTypeReferenceCollection _baseTypes = new CodeTypeReferenceCollection();

		// Token: 0x04000DE3 RID: 3555
		private readonly CodeTypeMemberCollection _members = new CodeTypeMemberCollection();

		// Token: 0x04000DE4 RID: 3556
		private bool _isEnum;

		// Token: 0x04000DE5 RID: 3557
		private bool _isStruct;

		// Token: 0x04000DE6 RID: 3558
		private int _populated;

		// Token: 0x04000DE7 RID: 3559
		private const int BaseTypesCollection = 1;

		// Token: 0x04000DE8 RID: 3560
		private const int MembersCollection = 2;

		// Token: 0x04000DE9 RID: 3561
		private CodeTypeParameterCollection _typeParameters;
	}
}
