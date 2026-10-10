using System;

namespace System.CodeDom
{
	/// <summary>Представляет объявление для свойства типа.</summary>
	// Token: 0x02000319 RID: 793
	[Serializable]
	public class CodeMemberProperty : CodeTypeMember
	{
		/// <summary>Получает или задает тип данных интерфейса (при наличии), который реализует данное свойство, если оно является закрытым.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeReference" /> указывает тип данных интерфейса (при наличии), который свойство, если оно является частным, реализует.</returns>
		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x00060227 File Offset: 0x0005E427
		// (set) Token: 0x06001934 RID: 6452 RVA: 0x0006022F File Offset: 0x0005E42F
		public CodeTypeReference PrivateImplementationType { get; set; }

		/// <summary>Получает типы данных любого интерфейса, реализованного свойством.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeReferenceCollection" />, указывающий типы данных, реализуемых свойством.</returns>
		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x00060238 File Offset: 0x0005E438
		public CodeTypeReferenceCollection ImplementationTypes
		{
			get
			{
				CodeTypeReferenceCollection result;
				if ((result = this._implementationTypes) == null)
				{
					result = (this._implementationTypes = new CodeTypeReferenceCollection());
				}
				return result;
			}
		}

		/// <summary>Получает или задает тип данных свойства.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип данных свойства.</returns>
		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x00060260 File Offset: 0x0005E460
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0006028A File Offset: 0x0005E48A
		public CodeTypeReference Type
		{
			get
			{
				CodeTypeReference result;
				if ((result = this._type) == null)
				{
					result = (this._type = new CodeTypeReference(""));
				}
				return result;
			}
			set
			{
				this._type = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, имеет ли свойство метод доступа <see langword="get" />.</summary>
		/// <returns>Значение <see langword="true" />, если свойство <see langword="Count" /> коллекции <see cref="P:System.CodeDom.CodeMemberProperty.GetStatements" /> отлично от нуля или если значение данного свойства было задано как <see langword="true" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x00060293 File Offset: 0x0005E493
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x000602AD File Offset: 0x0005E4AD
		public bool HasGet
		{
			get
			{
				return this._hasGet || this.GetStatements.Count > 0;
			}
			set
			{
				this._hasGet = value;
				if (!value)
				{
					this.GetStatements.Clear();
				}
			}
		}

		/// <summary>Получает или задает значение, указывающее, имеет ли свойство метод доступа <see langword="set" />.</summary>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.Collections.CollectionBase.Count" /> коллекции <see cref="P:System.CodeDom.CodeMemberProperty.SetStatements" /> отлично от нуля; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x000602C4 File Offset: 0x0005E4C4
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x000602DE File Offset: 0x0005E4DE
		public bool HasSet
		{
			get
			{
				return this._hasSet || this.SetStatements.Count > 0;
			}
			set
			{
				this._hasSet = value;
				if (!value)
				{
					this.SetStatements.Clear();
				}
			}
		}

		/// <summary>Получает коллекцию операторов <see langword="get" /> для свойства.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeStatementCollection" />, содержащий операторы <see langword="get" /> для свойства элемента.</returns>
		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x000602F5 File Offset: 0x0005E4F5
		public CodeStatementCollection GetStatements { get; } = new CodeStatementCollection();

		/// <summary>Получает коллекцию операторов <see langword="set" /> для свойства.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeStatementCollection" />, содержащий операторы <see langword="set" /> для свойства элемента.</returns>
		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x000602FD File Offset: 0x0005E4FD
		public CodeStatementCollection SetStatements { get; } = new CodeStatementCollection();

		/// <summary>Получает коллекцию выражений объявлений для свойства.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeParameterDeclarationExpressionCollection" />, указывающий выражение объявлений для свойства.</returns>
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x00060305 File Offset: 0x0005E505
		public CodeParameterDeclarationExpressionCollection Parameters { get; } = new CodeParameterDeclarationExpressionCollection();

		// Token: 0x04000DAB RID: 3499
		private CodeTypeReference _type;

		// Token: 0x04000DAC RID: 3500
		private bool _hasGet;

		// Token: 0x04000DAD RID: 3501
		private bool _hasSet;

		// Token: 0x04000DAE RID: 3502
		private CodeTypeReferenceCollection _implementationTypes;
	}
}
