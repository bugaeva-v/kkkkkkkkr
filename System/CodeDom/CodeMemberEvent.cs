using System;

namespace System.CodeDom
{
	/// <summary>Представляет объявление для события типа.</summary>
	// Token: 0x02000316 RID: 790
	[Serializable]
	public class CodeMemberEvent : CodeTypeMember
	{
		/// <summary>Получает или задает тип данных типа делегата, который обрабатывает событие.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип делегата, обрабатывающего событие.</returns>
		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x0005FE5C File Offset: 0x0005E05C
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x0005FE86 File Offset: 0x0005E086
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

		/// <summary>Получает или задает закрыто реализованный тип данных, если он имеется.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeReference" />, указывающий тип данных, приватно реализуемый событием.</returns>
		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x0005FE8F File Offset: 0x0005E08F
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x0005FE97 File Offset: 0x0005E097
		public CodeTypeReference PrivateImplementationType { get; set; }

		/// <summary>Получает или задает тип данных, которые реализует событие члена.</summary>
		/// <returns>
		///   <see cref="T:System.CodeDom.CodeTypeReferenceCollection" />, указывающий тип или типы данных, реализуемых событием члена.</returns>
		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x0005FEA0 File Offset: 0x0005E0A0
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

		// Token: 0x04000D98 RID: 3480
		private CodeTypeReference _type;

		// Token: 0x04000D99 RID: 3481
		private CodeTypeReferenceCollection _implementationTypes;
	}
}
