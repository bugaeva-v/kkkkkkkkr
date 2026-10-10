using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет составной элемент управления доступом.</summary>
	// Token: 0x02000518 RID: 1304
	public sealed class CompoundAce : KnownAce
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CompoundAce" />.</summary>
		/// <param name="flags">Содержит флаги, определяющие параметры наследования и распространения наследования, а также условия аудита нового элемента управления доступом.</param>
		/// <param name="accessMask">Маска доступа элемента управления доступом.</param>
		/// <param name="compoundAceType">Значение из перечисления <see cref="T:System.Security.AccessControl.CompoundAceType" />.</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, связанный с новым элементом управления доступом.</param>
		// Token: 0x060033CE RID: 13262 RVA: 0x000BE03B File Offset: 0x000BC23B
		public CompoundAce(AceFlags flags, int accessMask, CompoundAceType compoundAceType, SecurityIdentifier sid) : base(AceType.AccessAllowedCompound, flags)
		{
			this.compound_ace_type = compoundAceType;
			base.AccessMask = accessMask;
			base.SecurityIdentifier = sid;
		}

		/// <summary>Возвращает длину в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.CompoundAce" />. Эту длину необходимо использовать перед маршалингом списка управления доступом в двоичный массив с помощью метода <see cref="M:System.Security.AccessControl.CompoundAce.GetBinaryForm(System.Byte[],System.Int32)" />.</summary>
		/// <returns>Длина в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.CompoundAce" />.</returns>
		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public override int BinaryLength
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает тип этого объекта <see cref="T:System.Security.AccessControl.CompoundAce" />.</summary>
		/// <returns>Тип этого объекта <see cref="T:System.Security.AccessControl.CompoundAce" />.</returns>
		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060033D0 RID: 13264 RVA: 0x000BE05B File Offset: 0x000BC25B
		// (set) Token: 0x060033D1 RID: 13265 RVA: 0x000BE063 File Offset: 0x000BC263
		public CompoundAceType CompoundAceType
		{
			get
			{
				return this.compound_ace_type;
			}
			set
			{
				this.compound_ace_type = value;
			}
		}

		/// <summary>Маршалирует содержимое объекта <see cref="T:System.Security.AccessControl.CompoundAce" /> в указанный массив байтов, начиная с указанной позиции.</summary>
		/// <param name="binaryForm">Массив байтов, в который маршалируется содержимое объекта <see cref="T:System.Security.AccessControl.CompoundAce" />.</param>
		/// <param name="offset">Позиция, с которой начинается маршалинг.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="offset" /> является отрицательным или слишком велико, чтобы разрешить копирование всего <see cref="T:System.Security.AccessControl.CompoundAce" /> в <paramref name="array" />.</exception>
		// Token: 0x060033D2 RID: 13266 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public override void GetBinaryForm(byte[] binaryForm, int offset)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal override string GetSddlForm()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400245D RID: 9309
		private CompoundAceType compound_ace_type;
	}
}
