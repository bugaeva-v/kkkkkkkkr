using System;
using System.Data.Common;

namespace Microsoft.SqlServer.Server
{
	/// <summary>Используется, чтобы пометить определение типа в сборке как пользовательский тип в SQL Server. Свойства этого атрибута отражают физические характеристики, используемые при регистрации типа в SQL Server. Этот класс не наследуется.</summary>
	// Token: 0x0200005F RID: 95
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public sealed class SqlUserDefinedTypeAttribute : Attribute
	{
		/// <summary>Обязательный атрибут пользовательского типа (UDT), используемый для подтверждения того, что данный тип является UDT, и задающий формат хранения UDT.</summary>
		/// <param name="format">Одно из значений <see cref="T:Microsoft.SqlServer.Server.Format" />, представляющее формат сериализации типа.</param>
		// Token: 0x06000491 RID: 1169 RVA: 0x00010B3B File Offset: 0x0000ED3B
		public SqlUserDefinedTypeAttribute(Format format)
		{
			if (format == Format.Unknown)
			{
				throw ADP.NotSupportedUserDefinedTypeSerializationFormat(format, "format");
			}
			if (format - Format.Native > 1)
			{
				throw ADP.InvalidUserDefinedTypeSerializationFormat(format);
			}
			this.m_format = format;
		}

		/// <summary>Максимальный размер экземпляра в байтах.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, представляющее максимальный размер экземпляра.</returns>
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00010B68 File Offset: 0x0000ED68
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x00010B70 File Offset: 0x0000ED70
		public int MaxByteSize
		{
			get
			{
				return this.m_MaxByteSize;
			}
			set
			{
				if (value < -1)
				{
					throw ADP.ArgumentOutOfRange("MaxByteSize");
				}
				this.m_MaxByteSize = value;
			}
		}

		/// <summary>Показывает, все ли экземпляры данного пользовательского типа имеют одинаковую длину.</summary>
		/// <returns>
		///   <see langword="true" />, если все экземпляры типа имеют одинаковую длину, в противном случае — <see langword="false" />.</returns>
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00010B88 File Offset: 0x0000ED88
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00010B90 File Offset: 0x0000ED90
		public bool IsFixedLength
		{
			get
			{
				return this.m_IsFixedLength;
			}
			set
			{
				this.m_IsFixedLength = value;
			}
		}

		/// <summary>Показывает, упорядочен ли пользовательский тип по байтам.</summary>
		/// <returns>
		///   <see langword="true" />, если пользовательский тип побайтно упорядочен, в противном случае — <see langword="false" />.</returns>
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00010B99 File Offset: 0x0000ED99
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00010BA1 File Offset: 0x0000EDA1
		public bool IsByteOrdered
		{
			get
			{
				return this.m_IsByteOrdered;
			}
			set
			{
				this.m_IsByteOrdered = value;
			}
		}

		/// <summary>Формат сериализации в виде значения <see cref="T:Microsoft.SqlServer.Server.Format" />.</summary>
		/// <returns>Значение <see cref="T:Microsoft.SqlServer.Server.Format" />, представляющее формат сериализации.</returns>
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00010BAA File Offset: 0x0000EDAA
		public Format Format
		{
			get
			{
				return this.m_format;
			}
		}

		/// <summary>Имя метода, используемого для проверки экземпляров пользовательского типа.</summary>
		/// <returns>Значение типа <see cref="T:System.String" />, представляющее имя метода проверки экземпляров пользовательского типа.</returns>
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00010BB2 File Offset: 0x0000EDB2
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00010BBA File Offset: 0x0000EDBA
		public string ValidationMethodName
		{
			get
			{
				return this.m_ValidationMethodName;
			}
			set
			{
				this.m_ValidationMethodName = value;
			}
		}

		/// <summary>Имя пользовательского типа SQL Server.</summary>
		/// <returns>Значение типа <see cref="T:System.String" />, представляющее имя пользовательского типа SQL Server.</returns>
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00010BC3 File Offset: 0x0000EDC3
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00010BCB File Offset: 0x0000EDCB
		public string Name
		{
			get
			{
				return this.m_fName;
			}
			set
			{
				this.m_fName = value;
			}
		}

		// Token: 0x04000562 RID: 1378
		private int m_MaxByteSize;

		// Token: 0x04000563 RID: 1379
		private bool m_IsFixedLength;

		// Token: 0x04000564 RID: 1380
		private bool m_IsByteOrdered;

		// Token: 0x04000565 RID: 1381
		private Format m_format;

		// Token: 0x04000566 RID: 1382
		private string m_fName;

		// Token: 0x04000567 RID: 1383
		internal const int YukonMaxByteSizeValue = 8000;

		// Token: 0x04000568 RID: 1384
		private string m_ValidationMethodName;
	}
}
