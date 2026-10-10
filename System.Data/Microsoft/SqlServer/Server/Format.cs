using System;

namespace Microsoft.SqlServer.Server
{
	/// <summary>Используется классами <see cref="T:Microsoft.SqlServer.Server.SqlUserDefinedTypeAttribute" /> и <see cref="T:Microsoft.SqlServer.Server.SqlUserDefinedAggregateAttribute" /> для указания формата сериализации пользовательского типа или агрегатной функции.</summary>
	// Token: 0x0200005E RID: 94
	public enum Format
	{
		/// <summary>Формат сериализации неизвестен.</summary>
		// Token: 0x0400055F RID: 1375
		Unknown,
		/// <summary>Формат сериализации <see langword="Native" /> использует простейший алгоритм, позволяющий серверу SQL Server сохранять на диске эффективное представление пользовательского типа. Типами, отмеченными для сериализации <see langword="Native" />, могут быть только типы значений (структуры в Microsoft Visual C# и в Microsoft Visual Basic .NET) в качестве элементов. Члены в виде ссылочных типов (таких, как классы Visual C# или Visual Basic), определенных пользователем или существующих в базовой структуре (например, <see cref="T:System.String" />), не поддерживаются.</summary>
		// Token: 0x04000560 RID: 1376
		Native,
		/// <summary>Формат сериализации <see langword="UserDefined" /> обеспечивает разработчику полный контроль над форматом двоичных данных, осуществляемый с помощью методов <see cref="T:Microsoft.SqlServer.Server.IBinarySerialize" /><see langword=".Write" /> и <see cref="T:Microsoft.SqlServer.Server.IBinarySerialize" /><see langword=".Read" />.</summary>
		// Token: 0x04000561 RID: 1377
		UserDefined
	}
}
