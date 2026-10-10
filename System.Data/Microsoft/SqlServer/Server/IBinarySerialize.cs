using System;
using System.IO;

namespace Microsoft.SqlServer.Server
{
	/// <summary>Предоставляет настраиваемую реализацию для сериализации и десериализации пользовательских типов (UDT) и пользовательских агрегатных функций.</summary>
	// Token: 0x02000055 RID: 85
	public interface IBinarySerialize
	{
		/// <summary>Генерирует пользовательский тип (UDT) или пользовательскую агрегатную функцию из соответствующей двоичной формы.</summary>
		/// <param name="r">Поток <see cref="T:System.IO.BinaryReader" />, из которого выполняется десериализация объекта.</param>
		// Token: 0x06000456 RID: 1110
		void Read(BinaryReader r);

		/// <summary>Преобразует пользовательский тип или пользовательскую агрегатную функцию в двоичный формат для возможности сохранения.</summary>
		/// <param name="w">Поток <see cref="T:System.IO.BinaryWriter" />, в который выполняется сериализация пользовательского типа или пользовательской агрегатной функции.</param>
		// Token: 0x06000457 RID: 1111
		void Write(BinaryWriter w);
	}
}
