using System;
using System.Runtime.InteropServices;
using Internal.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Предоставляет методы для шифрования и расшифровки данных. Этот класс не наследуется.</summary>
	// Token: 0x02000011 RID: 17
	public static class ProtectedData
	{
		/// <summary>Зашифровывает данные в заданном массиве байтов и возвращает массив байтов, содержащий зашифрованные данные.</summary>
		/// <param name="userData">Массив байтов, содержащий данные для зашифровки.</param>
		/// <param name="optionalEntropy">Необязательный дополнительный байтовый массив, который используется для увеличения сложности шифрования, или <see langword="null" /> для отсутствия дополнительной сложности.</param>
		/// <param name="scope">Одно из значений перечисления, определяющее область шифрования.</param>
		/// <returns>Массив байтов, представляющий зашифрованные данные.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="userData" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Сбой шифрования.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается операционной системой.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Системе не хватило памяти для зашифрования данных.</exception>
		// Token: 0x06000041 RID: 65 RVA: 0x000029AB File Offset: 0x00000BAB
		public static byte[] Protect(byte[] userData, byte[] optionalEntropy, DataProtectionScope scope)
		{
			if (userData == null)
			{
				throw new ArgumentNullException("userData");
			}
			return ProtectedData.ProtectOrUnprotect(userData, optionalEntropy, scope, true);
		}

		/// <summary>Расшифровывает данные в заданном массиве байтов и возвращает массив байтов, содержащий расшифрованные данные.</summary>
		/// <param name="encryptedData">Массив данных, в котором содержатся данные, зашифрованные с помощью метода <see cref="M:System.Security.Cryptography.ProtectedData.Protect(System.Byte[],System.Byte[],System.Security.Cryptography.DataProtectionScope)" />.</param>
		/// <param name="optionalEntropy">Необязательный дополнительный байтовый массив, который был использован для шифрования данных, или <see langword="null" />, если дополнительные байтовый массив не используются.</param>
		/// <param name="scope">Одно из значений перечисления, задающее область защиты данных, использованную для шифрования данных.</param>
		/// <returns>Массив байтов, представляющий расшифрованные данные.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="encryptedData" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Сбой расшифровки.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается операционной системой.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно памяти.</exception>
		// Token: 0x06000042 RID: 66 RVA: 0x000029C4 File Offset: 0x00000BC4
		public static byte[] Unprotect(byte[] encryptedData, byte[] optionalEntropy, DataProtectionScope scope)
		{
			if (encryptedData == null)
			{
				throw new ArgumentNullException("encryptedData");
			}
			return ProtectedData.ProtectOrUnprotect(encryptedData, optionalEntropy, scope, false);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000029E0 File Offset: 0x00000BE0
		private unsafe static byte[] ProtectOrUnprotect(byte[] inputData, byte[] optionalEntropy, DataProtectionScope scope, bool protect)
		{
			byte[] array;
			byte* value;
			if ((array = ((inputData.Length == 0) ? ProtectedData.s_nonEmpty : inputData)) == null || array.Length == 0)
			{
				value = null;
			}
			else
			{
				value = &array[0];
			}
			byte* value2;
			if (optionalEntropy == null || optionalEntropy.Length == 0)
			{
				value2 = null;
			}
			else
			{
				value2 = &optionalEntropy[0];
			}
			Interop.Crypt32.DATA_BLOB data_BLOB = new Interop.Crypt32.DATA_BLOB((IntPtr)((void*)value), (uint)inputData.Length);
			Interop.Crypt32.DATA_BLOB data_BLOB2 = default(Interop.Crypt32.DATA_BLOB);
			if (optionalEntropy != null)
			{
				data_BLOB2 = new Interop.Crypt32.DATA_BLOB((IntPtr)((void*)value2), (uint)optionalEntropy.Length);
			}
			Interop.Crypt32.CryptProtectDataFlags cryptProtectDataFlags = Interop.Crypt32.CryptProtectDataFlags.CRYPTPROTECT_UI_FORBIDDEN;
			if (scope == DataProtectionScope.LocalMachine)
			{
				cryptProtectDataFlags |= Interop.Crypt32.CryptProtectDataFlags.CRYPTPROTECT_LOCAL_MACHINE;
			}
			Interop.Crypt32.DATA_BLOB data_BLOB3 = default(Interop.Crypt32.DATA_BLOB);
			byte[] result;
			try
			{
				if (!(protect ? Interop.Crypt32.CryptProtectData(ref data_BLOB, null, ref data_BLOB2, IntPtr.Zero, IntPtr.Zero, cryptProtectDataFlags, out data_BLOB3) : Interop.Crypt32.CryptUnprotectData(ref data_BLOB, IntPtr.Zero, ref data_BLOB2, IntPtr.Zero, IntPtr.Zero, cryptProtectDataFlags, out data_BLOB3)))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					if (protect && ProtectedData.ErrorMayBeCausedByUnloadedProfile(lastWin32Error))
					{
						throw new CryptographicException("The data protection operation was unsuccessful. This may have been caused by not having the user profile loaded for the current thread's user context, which may be the case when the thread is impersonating.");
					}
					throw lastWin32Error.ToCryptographicException();
				}
				else
				{
					if (data_BLOB3.pbData == IntPtr.Zero)
					{
						throw new OutOfMemoryException();
					}
					int cbData = (int)data_BLOB3.cbData;
					byte[] array2 = new byte[cbData];
					Marshal.Copy(data_BLOB3.pbData, array2, 0, cbData);
					result = array2;
				}
			}
			finally
			{
				if (data_BLOB3.pbData != IntPtr.Zero)
				{
					int cbData2 = (int)data_BLOB3.cbData;
					byte* ptr = (byte*)((void*)data_BLOB3.pbData);
					for (int i = 0; i < cbData2; i++)
					{
						ptr[i] = 0;
					}
					Marshal.FreeHGlobal(data_BLOB3.pbData);
				}
			}
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002B6C File Offset: 0x00000D6C
		private static bool ErrorMayBeCausedByUnloadedProfile(int errorCode)
		{
			return errorCode == -2147024894 || errorCode == 2;
		}

		// Token: 0x04000088 RID: 136
		private static readonly byte[] s_nonEmpty = new byte[1];
	}
}
