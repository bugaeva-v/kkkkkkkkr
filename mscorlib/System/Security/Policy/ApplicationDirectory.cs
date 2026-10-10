using System;
using System.IO;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Предоставляет каталог приложения в качестве свидетельства для оценки политики. Этот класс не наследуется.</summary>
	// Token: 0x020003FF RID: 1023
	[ComVisible(true)]
	[Serializable]
	public sealed class ApplicationDirectory : EvidenceBase, IBuiltInEvidence
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.ApplicationDirectory" />.</summary>
		/// <param name="name">Путь каталога приложения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060029D0 RID: 10704 RVA: 0x00097EC9 File Offset: 0x000960C9
		public ApplicationDirectory(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length < 1)
			{
				throw new FormatException(Locale.GetText("Empty"));
			}
			this.directory = name;
		}

		/// <summary>Получает путь для каталога приложения.</summary>
		/// <returns>Путь каталога приложения.</returns>
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x00097EFF File Offset: 0x000960FF
		public string Directory
		{
			get
			{
				return this.directory;
			}
		}

		/// <summary>Создает новую копию объекта <see cref="T:System.Security.Policy.ApplicationDirectory" />.</summary>
		/// <returns>Новая, идентичная копия объекта <see cref="T:System.Security.Policy.ApplicationDirectory" />.</returns>
		// Token: 0x060029D2 RID: 10706 RVA: 0x00097F07 File Offset: 0x00096107
		public object Copy()
		{
			return new ApplicationDirectory(this.Directory);
		}

		/// <summary>Определяет, являются ли эквивалентными экземпляры одного и того же типа объекта свидетельства.</summary>
		/// <param name="o">Объект одного и того же типа в качестве текущего объекта свидетельства.</param>
		/// <returns>Значение <see langword="true" />, если два экземпляра эквивалентны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060029D3 RID: 10707 RVA: 0x00097F14 File Offset: 0x00096114
		public override bool Equals(object o)
		{
			ApplicationDirectory applicationDirectory = o as ApplicationDirectory;
			if (applicationDirectory != null)
			{
				this.ThrowOnInvalid(applicationDirectory.directory);
				return this.directory == applicationDirectory.directory;
			}
			return false;
		}

		/// <summary>Получает хэш-код текущего каталога приложения.</summary>
		/// <returns>Хэш-код текущего каталога приложения.</returns>
		// Token: 0x060029D4 RID: 10708 RVA: 0x00097F4A File Offset: 0x0009614A
		public override int GetHashCode()
		{
			return this.Directory.GetHashCode();
		}

		/// <summary>Получает строковое представление состояния объекта свидетельства <see cref="T:System.Security.Policy.ApplicationDirectory" />.</summary>
		/// <returns>Представление состояния объекта свидетельства <see cref="T:System.Security.Policy.ApplicationDirectory" />.</returns>
		// Token: 0x060029D5 RID: 10709 RVA: 0x00097F58 File Offset: 0x00096158
		public override string ToString()
		{
			this.ThrowOnInvalid(this.Directory);
			SecurityElement securityElement = new SecurityElement("System.Security.Policy.ApplicationDirectory");
			securityElement.AddAttribute("version", "1");
			securityElement.AddChild(new SecurityElement("Directory", this.directory));
			return securityElement.ToString();
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00097FA6 File Offset: 0x000961A6
		int IBuiltInEvidence.GetRequiredSize(bool verbose)
		{
			return (verbose ? 3 : 1) + this.directory.Length;
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("IBuiltInEvidence")]
		int IBuiltInEvidence.InitFromBuffer(char[] buffer, int position)
		{
			return 0;
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("IBuiltInEvidence")]
		int IBuiltInEvidence.OutputToBuffer(char[] buffer, int position, bool verbose)
		{
			return 0;
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x00097FBB File Offset: 0x000961BB
		private void ThrowOnInvalid(string appdir)
		{
			if (appdir.IndexOfAny(Path.InvalidPathChars) != -1)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid character(s) in directory {0}"), appdir), "other");
			}
		}

		// Token: 0x04001F53 RID: 8019
		private string directory;
	}
}
