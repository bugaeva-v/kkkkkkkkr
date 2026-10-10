using System;

namespace System.CodeDom.Compiler
{
	/// <summary>Задает идентификаторы, определяющие наличие поддержки генератором кода определенных типов элементов кода.</summary>
	// Token: 0x02000350 RID: 848
	[Flags]
	public enum GeneratorSupport
	{
		/// <summary>Показывает, поддерживает ли генератор массивы массивов.</summary>
		// Token: 0x04000E51 RID: 3665
		ArraysOfArrays = 1,
		/// <summary>Показывает, поддерживает ли генератор определение метода точки входа программы. Используется при построении исполняемых файлов.</summary>
		// Token: 0x04000E52 RID: 3666
		EntryPointMethod = 2,
		/// <summary>Показывает, поддерживает ли генератор операторы goto языка.</summary>
		// Token: 0x04000E53 RID: 3667
		GotoStatements = 4,
		/// <summary>Показывает, поддерживает ли генератор ссылки на многомерные массивы. В настоящий момент CodeDom не может использоваться для создания экземпляров многомерных массивов.</summary>
		// Token: 0x04000E54 RID: 3668
		MultidimensionalArrays = 8,
		/// <summary>Показывает, поддерживает ли генератор статические конструкторы.</summary>
		// Token: 0x04000E55 RID: 3669
		StaticConstructors = 16,
		/// <summary>Показывает, поддерживает ли генератор операторы языка <see langword="try...catch" />.</summary>
		// Token: 0x04000E56 RID: 3670
		TryCatchStatements = 32,
		/// <summary>Показывает, поддерживает ли генератор объявления атрибутов возвращаемого типа.</summary>
		// Token: 0x04000E57 RID: 3671
		ReturnTypeAttributes = 64,
		/// <summary>Показывает, поддерживает ли генератор объявления типа значения.</summary>
		// Token: 0x04000E58 RID: 3672
		DeclareValueTypes = 128,
		/// <summary>Показывает, поддерживает ли генератор объявления перечисления.</summary>
		// Token: 0x04000E59 RID: 3673
		DeclareEnums = 256,
		/// <summary>Показывает, поддерживает ли генератор объявления делегата.</summary>
		// Token: 0x04000E5A RID: 3674
		DeclareDelegates = 512,
		/// <summary>Показывает, поддерживает ли генератор объявления интерфейса.</summary>
		// Token: 0x04000E5B RID: 3675
		DeclareInterfaces = 1024,
		/// <summary>Показывает, поддерживает ли генератор объявления события.</summary>
		// Token: 0x04000E5C RID: 3676
		DeclareEvents = 2048,
		/// <summary>Показывает, поддерживает ли генератор атрибуты сборки.</summary>
		// Token: 0x04000E5D RID: 3677
		AssemblyAttributes = 4096,
		/// <summary>Показывает, поддерживает ли генератор атрибуты параметра.</summary>
		// Token: 0x04000E5E RID: 3678
		ParameterAttributes = 8192,
		/// <summary>Показывает, поддерживает ли генератор параметры, передаваемые по ссылке, и выходные параметры.</summary>
		// Token: 0x04000E5F RID: 3679
		ReferenceParameters = 16384,
		/// <summary>Показывает, поддерживает ли генератор аргументы цепного конструктора.</summary>
		// Token: 0x04000E60 RID: 3680
		ChainedConstructorArguments = 32768,
		/// <summary>Показывает, поддерживает ли генератор объявление вложенных типов.</summary>
		// Token: 0x04000E61 RID: 3681
		NestedTypes = 65536,
		/// <summary>Показывает, поддерживает ли генератор объявление членов, реализующих несколько интерфейсов.</summary>
		// Token: 0x04000E62 RID: 3682
		MultipleInterfaceMembers = 131072,
		/// <summary>Показывает, поддерживает ли генератор открытые статические члены.</summary>
		// Token: 0x04000E63 RID: 3683
		PublicStaticMembers = 262144,
		/// <summary>Показывает, поддерживает ли генератор составные выражения.</summary>
		// Token: 0x04000E64 RID: 3684
		ComplexExpressions = 524288,
		/// <summary>Показывает, поддерживает ли генератор компиляцию с ресурсами Win32.</summary>
		// Token: 0x04000E65 RID: 3685
		Win32Resources = 1048576,
		/// <summary>Показывает, поддерживает ли генератор компиляцию с ресурсами платформы .NET Framework. Это могут быть ресурсы по умолчанию, откомпилированные прямо в сборку, или ресурсы, указанные во вспомогательной сборке.</summary>
		// Token: 0x04000E66 RID: 3686
		Resources = 2097152,
		/// <summary>Показывает, поддерживает ли генератор объявления частичных типов.</summary>
		// Token: 0x04000E67 RID: 3687
		PartialTypes = 4194304,
		/// <summary>Показывает, поддерживает ли генератор объявления ссылок универсальных типов.</summary>
		// Token: 0x04000E68 RID: 3688
		GenericTypeReference = 8388608,
		/// <summary>Показывает, поддерживает ли генератор объявления универсальных типов.</summary>
		// Token: 0x04000E69 RID: 3689
		GenericTypeDeclaration = 16777216,
		/// <summary>Показывает, поддерживает ли генератор объявление свойств индексатора.</summary>
		// Token: 0x04000E6A RID: 3690
		DeclareIndexerProperties = 33554432
	}
}
