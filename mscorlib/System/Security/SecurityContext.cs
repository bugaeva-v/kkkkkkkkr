using System;
using System.Security.Permissions;
using System.Threading;

namespace System.Security
{
	/// <summary>Инкапсулирует и распространяет все связанные с безопасностью данные контекстов выполнения для различных потоков. Этот класс не наследуется.</summary>
	// Token: 0x020003DC RID: 988
	public sealed class SecurityContext : IDisposable
	{
		// Token: 0x06002881 RID: 10369 RVA: 0x0000259F File Offset: 0x0000079F
		private SecurityContext()
		{
		}

		/// <summary>Создает копию текущего контекста безопасности.</summary>
		/// <returns>Контекст безопасности текущего потока.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий контекст безопасности ранее не использовался, был маршалирован в доменах приложения или не был получен с помощью метода <see cref="M:System.Security.SecurityContext.Capture" />.</exception>
		// Token: 0x06002882 RID: 10370 RVA: 0x0000270D File Offset: 0x0000090D
		public SecurityContext CreateCopy()
		{
			return this;
		}

		/// <summary>Перехватывает контекст безопасности текущего потока.</summary>
		/// <returns>Контекст безопасности текущего потока.</returns>
		// Token: 0x06002883 RID: 10371 RVA: 0x00093068 File Offset: 0x00091268
		public static SecurityContext Capture()
		{
			return new SecurityContext();
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Security.SecurityContext" />.</summary>
		// Token: 0x06002884 RID: 10372 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void Dispose()
		{
		}

		/// <summary>Определяет, было ли подавлено действие контекста безопасности.</summary>
		/// <returns>Значение <see langword="true" />, если действие было подавлено, в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002885 RID: 10373 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public static bool IsFlowSuppressed()
		{
			return false;
		}

		/// <summary>Определяет, было ли подавлено действие удостоверения Windows текущего контекста безопасности.</summary>
		/// <returns>Значение <see langword="true" />, если действие было подавлено, в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002886 RID: 10374 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public static bool IsWindowsIdentityFlowSuppressed()
		{
			return false;
		}

		/// <summary>Восстанавливает поток контекста безопасности по асинхронным потокам.</summary>
		/// <exception cref="T:System.InvalidOperationException">Контекст безопасности равен <see langword="null" /> или пустой строке.</exception>
		// Token: 0x06002887 RID: 10375 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public static void RestoreFlow()
		{
		}

		/// <summary>Выполняет указанный метод в указанном контексте безопасности в текущем потоке.</summary>
		/// <param name="securityContext">Задаваемый контекст безопасности.</param>
		/// <param name="callback">Делегат, представляющий метод, выполняемый в указанном контексте безопасности.</param>
		/// <param name="state">Данный объект передается в метод обратного вызова.</param>
		/// <exception cref="T:System.InvalidOperationException">Свойство <paramref name="securityContext" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="securityContext" /> не был получен во время операции отслеживания.  
		///
		/// или - 
		/// Объект <paramref name="securityContext" /> уже использовался в качестве аргумента в вызове метода <see cref="M:System.Security.SecurityContext.Run(System.Security.SecurityContext,System.Threading.ContextCallback,System.Object)" />.</exception>
		// Token: 0x06002888 RID: 10376 RVA: 0x0009306F File Offset: 0x0009126F
		[SecurityPermission(SecurityAction.Assert, ControlPrincipal = true)]
		[SecurityPermission(SecurityAction.LinkDemand, Infrastructure = true)]
		public static void Run(SecurityContext securityContext, ContextCallback callback, object state)
		{
			callback(state);
		}

		/// <summary>Подавляет действие контекста безопасности между асинхронными потоками.</summary>
		/// <returns>Структура <see cref="T:System.Threading.AsyncFlowControl" /> для восстановления перемещения.</returns>
		// Token: 0x06002889 RID: 10377 RVA: 0x000472C8 File Offset: 0x000454C8
		[SecurityPermission(SecurityAction.LinkDemand, Infrastructure = true)]
		public static AsyncFlowControl SuppressFlow()
		{
			throw new NotSupportedException();
		}

		/// <summary>Подавляет действие удостоверения Windows текущего контекста безопасности на асинхронных потоках.</summary>
		/// <returns>Структура для восстановления потока.</returns>
		// Token: 0x0600288A RID: 10378 RVA: 0x000472C8 File Offset: 0x000454C8
		public static AsyncFlowControl SuppressFlowWindowsIdentity()
		{
			throw new NotSupportedException();
		}
	}
}
