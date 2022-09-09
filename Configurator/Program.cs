﻿/*
Copyright (C) 2019-2020 TARAKHOMYN YURIY IVANOVYCH
All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

/*
Автор:    Тарахомин Юрій Іванович
Адреса:   Україна, м. Львів
Сайт:     accounting.org.ua
*/

using System;
using System.Windows.Forms;
using AccountingSoftware;

namespace Configurator
{
	public static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.SetCompatibleTextRenderingDefault(false);

			FormConfiguration formConfiguration = new FormConfiguration();

			if (args.Length >= 1)
			{
				//Ключ конфігурації яку потрібно відкрити автоматично (Guid)
				formConfiguration.AutoOpenConfigurationKey = args[0];

				//Ключ команди яку потрібно виконати
				if (args.Length >= 2)
					formConfiguration.CommandExecuteKey = args[1];

				//Параметр для команди
				if (args.Length >= 3)
					formConfiguration.CommandExecuteParam = args[2];
			}

			Application.Run(formConfiguration);
		}

		public static Kernel Kernel { get; set; }
	}
}
