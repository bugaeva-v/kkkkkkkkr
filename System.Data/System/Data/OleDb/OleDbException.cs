using System;
using System.Data.Common;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Data.OleDb
{
	/// <summary>Исключение, которое генерируется, когда соответствующий поставщик возвращает предупреждение или ошибку для источника данных OLE DB. Этот класс не наследуется.</summary>
	// Token: 0x02000166 RID: 358
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbException : DbException
	{
		// Token: 0x06001363 RID: 4963 RVA: 0x0005ADDE File Offset: 0x00058FDE
		internal OleDbException()
		{
		}

		/// <summary>Получает значение HRESULT ошибки.</summary>
		/// <returns>Значение HRESULT ошибки.</returns>
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override int ErrorCode
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Получает коллекцию из одного или нескольких объектов <see cref="T:System.Data.OleDb.OleDbError" />, которые предоставляют подробные сведения об исключениях, выдаваемых поставщиком данных .NET Framework для OLE DB.</summary>
		/// <returns>Накопленные экземпляры класса <see cref="T:System.Data.OleDb.OleDbError" />.</returns>
		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public OleDbErrorCollection Errors
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Этот элемент переопределяет метод <see cref="M:System.Exception.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" />.</summary>
		/// <param name="si">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Значением параметра <paramref name="si" /> является пустая ссылка (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x06001366 RID: 4966 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo si, StreamingContext context)
		{
			throw ADP.OleDb();
		}
	}
}
