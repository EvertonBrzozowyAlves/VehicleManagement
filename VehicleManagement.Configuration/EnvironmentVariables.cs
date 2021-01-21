﻿using dotenv.net;
using System;
using System.IO;
using System.Linq;
using VehicleManagement.Configuration.Exceptions;

namespace VehicleManagement.Configuration
{
    public static class EnvironmentVariables
	{       
		/// <summary>
		/// Load environment variables, after finding a .env file within the project root path.
		/// </summary>
		public static void Load()
		{
			try
			{
				var directory = TryGetEnvDirectoryInfo();
				if (directory == null)
				{
					throw new EnvFileNotFoundException();
				}
				DotEnv.Config(filePath: $"{directory.FullName}/.env");
			}
			catch (EnvFileNotFoundException)
			{
				//TODO: add a better handling
				throw new Exception($"Não foi possível localizar o arquivo .env no escopo do projeto.");
			}
			catch (Exception)
			{
				throw;
			}
		}
		private static DirectoryInfo TryGetEnvDirectoryInfo(string currentPath = null)
		{
			var directory = new DirectoryInfo(currentPath ?? Directory.GetCurrentDirectory());
			while (directory != null && !directory.GetFiles("*.env").Any())
			{
				directory = directory.Parent;
			}
			return directory;
		}
	}
}
