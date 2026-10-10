using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security;
using Unity;

namespace System.Runtime.DesignerServices
{
	/// <summary>Предоставляет настраиваемую привязку сборки для конструкторов, которые используются для создания приложений Windows 8.x Store.</summary>
	// Token: 0x02000BCE RID: 3022
	public sealed class WindowsRuntimeDesignerContext
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.DesignerServices.WindowsRuntimeDesignerContext" /> с указанием набора путей для поиска сторонних типов Среда выполнения Windows и управляемых сборок, а также с указанием имени контекста.</summary>
		/// <param name="paths">Пути для поиска.</param>
		/// <param name="name">Имя контекста.</param>
		/// <exception cref="T:System.NotSupportedException">Текущий домен приложения не является доменом приложения по умолчанию.  
		///
		/// или - 
		/// Процесс не работает в контейнере приложения.  
		///
		/// или - 
		/// На компьютере отсутствует лицензия разработчика.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="paths" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06006B5E RID: 27486 RVA: 0x000173AD File Offset: 0x000155AD
		[SecurityCritical]
		public WindowsRuntimeDesignerContext(IEnumerable<string> paths, string name)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает имя контекста привязки конструктора.</summary>
		/// <returns>Имя контекста.</returns>
		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06006B5F RID: 27487 RVA: 0x00052955 File Offset: 0x00050B55
		public string Name
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Загружает указанную сборку из текущего контекста.</summary>
		/// <param name="assemblyName">Полное имя сборки для загрузки. Описание полные отображаемые имена сборок см. в описании свойства <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <returns>Сборка, если она найдена в текущем контексте; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x06006B60 RID: 27488 RVA: 0x00052955 File Offset: 0x00050B55
		[SecurityCritical]
		public Assembly GetAssembly(string assemblyName)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Загружает указанный тип из текущего контекста.</summary>
		/// <param name="typeName">Полное имя сборки типа для отправки. Описание имен с указанием сборки см. в описании свойства <see cref="P:System.Type.AssemblyQualifiedName" />.</param>
		/// <returns>Тип, если он найден в текущем контексте; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x06006B61 RID: 27489 RVA: 0x00052955 File Offset: 0x00050B55
		[SecurityCritical]
		public Type GetType(string typeName)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Создает контекст и задает его как общий контекст.</summary>
		/// <param name="paths">Перечисляемая коллекция путей, используемых для разрешения запросов привязки, которые не могут быть удовлетворены контекстом итерации.</param>
		/// <exception cref="T:System.NotSupportedException">Общий контекст уже установлен в этом домене приложения.  
		///
		/// или - 
		/// Текущий домен приложения не является доменом приложения по умолчанию.  
		///
		/// или - 
		/// Процесс не работает в контейнере приложения.  
		///
		/// или - 
		/// На компьютере отсутствует лицензия разработчика.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="paths" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06006B62 RID: 27490 RVA: 0x000173AD File Offset: 0x000155AD
		[SecurityCritical]
		public static void InitializeSharedContext(IEnumerable<string> paths)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Задает контекст для обработки итераций запросов привязки сборок при перекомпиляции сборок в процессе разработки.</summary>
		/// <param name="context">Контекст, обрабатывающий итерации запросов привязки сборки.</param>
		/// <exception cref="T:System.NotSupportedException">Текущий домен приложения не является доменом приложения по умолчанию.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="context" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06006B63 RID: 27491 RVA: 0x000173AD File Offset: 0x000155AD
		[SecurityCritical]
		public static void SetIterationContext(WindowsRuntimeDesignerContext context)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
