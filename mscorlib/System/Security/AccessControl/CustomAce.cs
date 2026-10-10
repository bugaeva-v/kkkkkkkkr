using System;

namespace System.Security.AccessControl
{
	/// <summary>Представляет элемент управления доступом, тип которого не является членом перечисления <see cref="T:System.Security.AccessControl.AceType" />.</summary>
	// Token: 0x0200051F RID: 1311
	public sealed class CustomAce : GenericAce
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CustomAce" />.</summary>
		/// <param name="type">Тип нового элемента управления доступом. Значение должно быть больше, чем <see cref="F:System.Security.AccessControl.AceType.MaxDefinedAceType" />.</param>
		/// <param name="flags">Флаги, определяющие параметры наследования и распространения наследования, а также условия аудита нового элемента управления доступом.</param>
		/// <param name="opaque">Массив байтовых значений, содержащий данные нового элемента управления доступом. Это значение может быть равно <see langword="null" />. Длина этого массива не должна превышать значения поля <see cref="F:System.Security.AccessControl.CustomAce.MaxOpaqueLength" /> и должно быть кратным четырем.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="type" /> не превышает <see cref="F:System.Security.AccessControl.AceType.MaxDefinedAceType" /> или длина массива <paramref name="opaque" /> превышает значение поля <see cref="F:System.Security.AccessControl.CustomAce.MaxOpaqueLength" /> или не кратна четырем.</exception>
		// Token: 0x060033EC RID: 13292 RVA: 0x000BE0F6 File Offset: 0x000BC2F6
		public CustomAce(AceType type, AceFlags flags, byte[] opaque) : base(type, flags)
		{
			this.SetOpaque(opaque);
		}

		/// <summary>Возвращает длину в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.CustomAce" />. Эту длину необходимо использовать перед маршалингом списка управления доступом в двоичный массив с помощью метода <see cref="M:System.Security.AccessControl.CustomAce.GetBinaryForm(System.Byte[],System.Int32)" />.</summary>
		/// <returns>Длина в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.CustomAce" />.</returns>
		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060033ED RID: 13293 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public override int BinaryLength
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает длину непрозрачных данных, связанных с этим объектом <see cref="T:System.Security.AccessControl.CustomAce" />.</summary>
		/// <returns>Длина непрозрачных данных обратного вызова в байтах.</returns>
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060033EE RID: 13294 RVA: 0x000BE107 File Offset: 0x000BC307
		public int OpaqueLength
		{
			get
			{
				return this.opaque.Length;
			}
		}

		/// <summary>Маршалирует содержимое объекта <see cref="T:System.Security.AccessControl.CustomAce" /> в указанный массив байтов, начиная с указанной позиции.</summary>
		/// <param name="binaryForm">Массив байтов, в который маршалируется содержимое объекта <see cref="T:System.Security.AccessControl.CustomAce" />.</param>
		/// <param name="offset">Позиция, с которой начинается маршалинг.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="offset" /> является отрицательным или слишком велико, чтобы разрешить копирование всего <see cref="T:System.Security.AccessControl.CustomAce" /> в <paramref name="array" />.</exception>
		// Token: 0x060033EF RID: 13295 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public override void GetBinaryForm(byte[] binaryForm, int offset)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает длину непрозрачных данных, связанных с этим объектом <see cref="T:System.Security.AccessControl.CustomAce" />.</summary>
		/// <returns>Массив байтов, представляющий непрозрачные данные, связанные с данным объектом <see cref="T:System.Security.AccessControl.CustomAce" />.</returns>
		// Token: 0x060033F0 RID: 13296 RVA: 0x000BE111 File Offset: 0x000BC311
		public byte[] GetOpaque()
		{
			return (byte[])this.opaque.Clone();
		}

		/// <summary>Задает непрозрачные данные обратного вызова, связанные с этим объектом <see cref="T:System.Security.AccessControl.CustomAce" />.</summary>
		/// <param name="opaque">Массив байтов, представляющий непрозрачные данные обратного вызова для данного объекта <see cref="T:System.Security.AccessControl.CustomAce" />.</param>
		// Token: 0x060033F1 RID: 13297 RVA: 0x000BE123 File Offset: 0x000BC323
		public void SetOpaque(byte[] opaque)
		{
			if (opaque == null)
			{
				this.opaque = null;
				return;
			}
			this.opaque = (byte[])opaque.Clone();
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x000472C8 File Offset: 0x000454C8
		internal override string GetSddlForm()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04002483 RID: 9347
		private byte[] opaque;

		/// <summary>Возвращает максимально допустимую длину большого двоичного объекта непрозрачных данных для данного объекта <see cref="T:System.Security.AccessControl.CustomAce" />.</summary>
		// Token: 0x04002484 RID: 9348
		[MonoTODO]
		public static readonly int MaxOpaqueLength;
	}
}
