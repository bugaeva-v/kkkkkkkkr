using System;

namespace System.Data
{
	/// <summary>Указывает, как считывать XML-данные и реляционную схему в объект <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x02000143 RID: 323
	public enum XmlReadMode
	{
		/// <summary>По умолчанию.</summary>
		// Token: 0x04000B51 RID: 2897
		Auto,
		/// <summary>Считывает любую встроенную схему и загружает данные. Если объект <see cref="T:System.Data.DataSet" /> уже содержит схему, новая таблица может быть в нее добавлена, но если какая-либо таблица во внутренней схеме уже существует в объекте <see cref="T:System.Data.DataSet" />, выдается исключение.</summary>
		// Token: 0x04000B52 RID: 2898
		ReadSchema,
		/// <summary>Пропускает любую встроенную схему и считывает данные в существующую схему <see cref="T:System.Data.DataSet" />. Если какие-либо данные не соответствуют существующей схеме, они удаляются (включая данные из разных пространств имен, определенных для объекта <see cref="T:System.Data.DataSet" />). Если данные являются DiffGram, значение <see langword="IgnoreSchema" /> имеет такую же функциональность, что и <see langword="DiffGram" />.</summary>
		// Token: 0x04000B53 RID: 2899
		IgnoreSchema,
		/// <summary>Игнорирует все встроенные схемы, выводит схему из данных и загружает их. Если объект <see cref="T:System.Data.DataSet" /> уже содержит схему, текущая схема расширяется за счет добавления новых таблиц или столбцов в существующие таблицы. Если добавляемая таблица уже существует, но с другим пространством имен, или если добавляемые столбцы конфликтуют с существующими, выдается исключение.</summary>
		// Token: 0x04000B54 RID: 2900
		InferSchema,
		/// <summary>Считывает DiffGram, применяя изменения из DiffGram к объекту <see cref="T:System.Data.DataSet" />. Семантика идентична семантике операции <see cref="M:System.Data.DataSet.Merge(System.Data.DataSet)" />. Как и в случае операции <see cref="M:System.Data.DataSet.Merge(System.Data.DataSet)" />, значения <see cref="P:System.Data.DataRow.RowState" /> сохраняются. Входные данные метода <see cref="M:System.Data.DataSet.ReadXml(System.Xml.XmlReader)" /> с DiffGrams могут быть получены только с использованием выходных данных метода <see cref="M:System.Data.DataSet.WriteXml(System.IO.Stream)" /> в виде DiffGram.</summary>
		// Token: 0x04000B55 RID: 2901
		DiffGram,
		/// <summary>Считывает XML-фрагменты, которые созданы при выполнении запросов FOR XML к экземпляру SQL Server. Когда для режима <see cref="T:System.Data.XmlReadMode" /> задано значение <see langword="Fragment" />, пространство имен по умолчанию читается как встроенная схема.</summary>
		// Token: 0x04000B56 RID: 2902
		Fragment,
		/// <summary>Игнорирует все встроенные схемы, выводит строго типизированную схему из данных и загружает их. Если тип не может быть выведен из данных, он интерпретируется как строковые данные. Если объект <see cref="T:System.Data.DataSet" /> уже содержит схему, текущая схема расширяется за счет добавления либо новых таблиц, либо столбцов в существующие таблицы. Если добавляемая таблица уже существует, но с другим пространством имен, или если добавляемые столбцы конфликтуют с существующими, выдается исключение.</summary>
		// Token: 0x04000B57 RID: 2903
		InferTypedSchema
	}
}
