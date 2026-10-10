using System;
using System.Collections.Generic;
using System.Text;

namespace System.Security.AccessControl
{
	/// <summary>Представляет список управления доступом.</summary>
	// Token: 0x02000545 RID: 1349
	public sealed class RawAcl : GenericAcl
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.RawAcl" /> с заданным номером редакции.</summary>
		/// <param name="revision">Номер редакции нового списка управления доступом.</param>
		/// <param name="capacity">Количество элементов управления доступом, которые могут содержаться в данном объекте <see cref="T:System.Security.AccessControl.RawAcl" />. Это число будет использоваться только для справки.</param>
		// Token: 0x06003565 RID: 13669 RVA: 0x000C1095 File Offset: 0x000BF295
		public RawAcl(byte revision, int capacity)
		{
			this.revision = revision;
			this.list = new List<GenericAce>(capacity);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.RawAcl" /> из указанной двоичной формы.</summary>
		/// <param name="binaryForm">Массив байтовых значений, представляющий список управления доступом.</param>
		/// <param name="offset">Позиция в массиве <paramref name="binaryForm" />, с которой начинается распаковка данных.</param>
		// Token: 0x06003566 RID: 13670 RVA: 0x000C10B0 File Offset: 0x000BF2B0
		public RawAcl(byte[] binaryForm, int offset)
		{
			if (binaryForm == null)
			{
				throw new ArgumentNullException("binaryForm");
			}
			if (offset < 0 || offset > binaryForm.Length - 8)
			{
				throw new ArgumentOutOfRangeException("offset", offset, "Offset out of range");
			}
			this.revision = binaryForm[offset];
			if (this.revision != GenericAcl.AclRevision && this.revision != GenericAcl.AclRevisionDS)
			{
				throw new ArgumentException("Invalid ACL - unknown revision", "binaryForm");
			}
			int num = (int)this.ReadUShort(binaryForm, offset + 2);
			if (offset > binaryForm.Length - num)
			{
				throw new ArgumentException("Invalid ACL - truncated", "binaryForm");
			}
			int num2 = offset + 8;
			int num3 = (int)this.ReadUShort(binaryForm, offset + 4);
			this.list = new List<GenericAce>(num3);
			for (int i = 0; i < num3; i++)
			{
				GenericAce genericAce = GenericAce.CreateFromBinaryForm(binaryForm, num2);
				this.list.Add(genericAce);
				num2 += genericAce.BinaryLength;
			}
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x000C1190 File Offset: 0x000BF390
		internal RawAcl(byte revision, List<GenericAce> aces)
		{
			this.revision = revision;
			this.list = aces;
		}

		/// <summary>Возвращает длину в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.RawAcl" />. Эту длину необходимо использовать перед маршалингом списка управления доступом в двоичный массив с помощью метода <see cref="M:System.Security.AccessControl.RawAcl.GetBinaryForm(System.Byte[],System.Int32)" />.</summary>
		/// <returns>Длина в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.RawAcl" />.</returns>
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06003568 RID: 13672 RVA: 0x000C11A8 File Offset: 0x000BF3A8
		public override int BinaryLength
		{
			get
			{
				int num = 8;
				foreach (GenericAce genericAce in this.list)
				{
					num += genericAce.BinaryLength;
				}
				return num;
			}
		}

		/// <summary>Возвращает количество элементов управления доступом в текущем объекте <see cref="T:System.Security.AccessControl.RawAcl" />.</summary>
		/// <returns>Количество элементов управления доступом в текущем объекте <see cref="T:System.Security.AccessControl.RawAcl" />.</returns>
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06003569 RID: 13673 RVA: 0x000C1200 File Offset: 0x000BF400
		public override int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		/// <summary>Получает или задает элемент управления доступом по указанному индексу.</summary>
		/// <param name="index">Индекс (с нуля) получаемого или задаваемого элемента управления доступом.</param>
		/// <returns>Элемент управления доступом по указанному индексу.</returns>
		// Token: 0x17000763 RID: 1891
		public override GenericAce this[int index]
		{
			get
			{
				return this.list[index];
			}
			set
			{
				this.list[index] = value;
			}
		}

		/// <summary>Возвращает уровень редакции объекта <see cref="T:System.Security.AccessControl.RawAcl" />.</summary>
		/// <returns>Байтовое значение, определяющее уровень редакции объекта <see cref="T:System.Security.AccessControl.RawAcl" />.</returns>
		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x000C122A File Offset: 0x000BF42A
		public override byte Revision
		{
			get
			{
				return this.revision;
			}
		}

		/// <summary>Маршалирует содержимое объекта <see cref="T:System.Security.AccessControl.RawAcl" /> в указанный массив байтов, начиная с указанной позиции.</summary>
		/// <param name="binaryForm">Массив байтов, в который маршалируется содержимое объекта <see cref="T:System.Security.AccessControl.RawAcl" />.</param>
		/// <param name="offset">Позиция, с которой начинается маршалинг.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="offset" /> является отрицательным или слишком велико, чтобы разрешить копирование всего <see cref="T:System.Security.AccessControl.RawAcl" /> в <paramref name="array" />.</exception>
		// Token: 0x0600356D RID: 13677 RVA: 0x000C1234 File Offset: 0x000BF434
		public override void GetBinaryForm(byte[] binaryForm, int offset)
		{
			if (binaryForm == null)
			{
				throw new ArgumentNullException("binaryForm");
			}
			if (offset < 0 || offset > binaryForm.Length - this.BinaryLength)
			{
				throw new ArgumentException("Offset out of range", "offset");
			}
			binaryForm[offset] = this.Revision;
			binaryForm[offset + 1] = 0;
			this.WriteUShort((ushort)this.BinaryLength, binaryForm, offset + 2);
			this.WriteUShort((ushort)this.list.Count, binaryForm, offset + 4);
			this.WriteUShort(0, binaryForm, offset + 6);
			int num = offset + 8;
			foreach (GenericAce genericAce in this.list)
			{
				genericAce.GetBinaryForm(binaryForm, num);
				num += genericAce.BinaryLength;
			}
		}

		/// <summary>Вставляет указанный элемент управления доступом по указанному индексу.</summary>
		/// <param name="index">Позиция, куда добавляются новые элементы управления доступом. Укажите значение свойства <see cref="P:System.Security.AccessControl.RawAcl.Count" />, чтобы поместить элемент управления доступом в конец объекта <see cref="T:System.Security.AccessControl.RawAcl" />.</param>
		/// <param name="ace">Вставляемый элемент управления доступом.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="offset" /> является отрицательным или слишком велико, чтобы разрешить копирование всего <see cref="T:System.Security.AccessControl.GenericAcl" /> в <paramref name="array" />.</exception>
		// Token: 0x0600356E RID: 13678 RVA: 0x000C1308 File Offset: 0x000BF508
		public void InsertAce(int index, GenericAce ace)
		{
			if (ace == null)
			{
				throw new ArgumentNullException("ace");
			}
			this.list.Insert(index, ace);
		}

		/// <summary>Удаляет элемент управления доступом по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс удаляемого элемента управления доступом.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> превышает значение свойства <see cref="P:System.Security.AccessControl.RawAcl.Count" /> минус один или отрицательно.</exception>
		// Token: 0x0600356F RID: 13679 RVA: 0x000C132B File Offset: 0x000BF52B
		public void RemoveAce(int index)
		{
			this.list.RemoveAt(index);
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x000C133C File Offset: 0x000BF53C
		internal override string GetSddlForm(ControlFlags sdFlags, bool isDacl)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (isDacl)
			{
				if ((sdFlags & ControlFlags.DiscretionaryAclProtected) != ControlFlags.None)
				{
					stringBuilder.Append("P");
				}
				if ((sdFlags & ControlFlags.DiscretionaryAclAutoInheritRequired) != ControlFlags.None)
				{
					stringBuilder.Append("AR");
				}
				if ((sdFlags & ControlFlags.DiscretionaryAclAutoInherited) != ControlFlags.None)
				{
					stringBuilder.Append("AI");
				}
			}
			else
			{
				if ((sdFlags & ControlFlags.SystemAclProtected) != ControlFlags.None)
				{
					stringBuilder.Append("P");
				}
				if ((sdFlags & ControlFlags.SystemAclAutoInheritRequired) != ControlFlags.None)
				{
					stringBuilder.Append("AR");
				}
				if ((sdFlags & ControlFlags.SystemAclAutoInherited) != ControlFlags.None)
				{
					stringBuilder.Append("AI");
				}
			}
			foreach (GenericAce genericAce in this.list)
			{
				stringBuilder.Append(genericAce.GetSddlForm());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x000C1424 File Offset: 0x000BF624
		internal static RawAcl ParseSddlForm(string sddlForm, bool isDacl, ref ControlFlags sdFlags, ref int pos)
		{
			RawAcl.ParseFlags(sddlForm, isDacl, ref sdFlags, ref pos);
			byte b = GenericAcl.AclRevision;
			List<GenericAce> list = new List<GenericAce>();
			while (pos < sddlForm.Length && sddlForm[pos] == '(')
			{
				GenericAce genericAce = GenericAce.CreateFromSddlForm(sddlForm, ref pos);
				if (genericAce as ObjectAce != null)
				{
					b = GenericAcl.AclRevisionDS;
				}
				list.Add(genericAce);
			}
			return new RawAcl(b, list);
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x000C1488 File Offset: 0x000BF688
		private static void ParseFlags(string sddlForm, bool isDacl, ref ControlFlags sdFlags, ref int pos)
		{
			char c = char.ToUpperInvariant(sddlForm[pos]);
			while (c == 'P' || c == 'A')
			{
				if (c == 'P')
				{
					if (isDacl)
					{
						sdFlags |= ControlFlags.DiscretionaryAclProtected;
					}
					else
					{
						sdFlags |= ControlFlags.SystemAclProtected;
					}
					pos++;
				}
				else
				{
					if (sddlForm.Length <= pos + 1)
					{
						throw new ArgumentException("Invalid SDDL string.", "sddlForm");
					}
					c = char.ToUpperInvariant(sddlForm[pos + 1]);
					if (c == 'R')
					{
						if (isDacl)
						{
							sdFlags |= ControlFlags.DiscretionaryAclAutoInheritRequired;
						}
						else
						{
							sdFlags |= ControlFlags.SystemAclAutoInheritRequired;
						}
						pos += 2;
					}
					else
					{
						if (c != 'I')
						{
							throw new ArgumentException("Invalid SDDL string.", "sddlForm");
						}
						if (isDacl)
						{
							sdFlags |= ControlFlags.DiscretionaryAclAutoInherited;
						}
						else
						{
							sdFlags |= ControlFlags.SystemAclAutoInherited;
						}
						pos += 2;
					}
				}
				c = char.ToUpperInvariant(sddlForm[pos]);
			}
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x000BF85E File Offset: 0x000BDA5E
		private void WriteUShort(ushort val, byte[] buffer, int offset)
		{
			buffer[offset] = (byte)val;
			buffer[offset + 1] = (byte)(val >> 8);
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x000C1577 File Offset: 0x000BF777
		private ushort ReadUShort(byte[] buffer, int offset)
		{
			return (ushort)((int)buffer[offset] | (int)buffer[offset + 1] << 8);
		}

		// Token: 0x040024D5 RID: 9429
		private byte revision;

		// Token: 0x040024D6 RID: 9430
		private List<GenericAce> list;
	}
}
