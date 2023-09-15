﻿using Hebron.Roslyn;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StbSharp.StbImage.Generator
{
	class Program
	{
		private static string Write<T>(Dictionary<string, T> input) where T : SyntaxNode
		{
			var keys = (from string k in input.Keys select k).ToArray();
			var result = string.Empty;
			foreach (var key in keys)
			{
				using (var sw = new StringWriter())
				{
					input[key].NormalizeWhitespace().WriteTo(sw);

					result += sw.ToString();
					result += Environment.NewLine;
				}

			}

			return result;
		}

		private class Writer
		{
			private readonly StringBuilder sb = new StringBuilder();

			public Writer()
			{
				sb.AppendLine(string.Format("// Generated by Hebron at {0}", DateTime.Now));
				sb.AppendLine();

				sb.AppendLine("using System;");
				sb.AppendLine("using System.Runtime.InteropServices;");

				sb.AppendLine();

				sb.Append("namespace UfbxSharp\n{\n\t");
				sb.AppendLine("unsafe partial class Ufbx\n\t{");
			}

			public void Write<T>(Dictionary<string, T> input) where T : SyntaxNode
			{
				var keys = (from string k in input.Keys select k).ToArray();
				foreach (var key in keys)
				{
					using (var sw = new StringWriter())
					{
						input[key].NormalizeWhitespace().WriteTo(sw);
						sb.AppendLine(sw.ToString());
					}
				}
			}

			public void WriteEmptyLine()
			{
				sb.AppendLine();
			}

			public string Finish()
			{
				sb.Append("}\n}");
				return sb.ToString();
			}
		}

		static void Process()
		{
			var parameters = new RoslynConversionParameters
			{
				InputPath = @"ufbx.c",
				Defines = new[]
				{
					"UFBX_NO_ASSERT",
					"UFBX_REAL_IS_FLOAT"
				},
				SkipStructs = new string[]
				{
				},
				SkipGlobalVariables = new string[]
				{
					"ufbxi_mat_transform_fns",
					"ufbxi_real_sum_fns"
				},
				SkipFunctions = new[]
				{
					"stbiw__writefv",
					"stbiw__writef",
					"stbiw__outfile",
				},
				Classes = new string[]
				{
				},
			};

			var result = RoslynCodeConverter.Convert(parameters);

			// Write output
			var writer = new Writer();
			writer.Write(result.NamedEnums);
			File.WriteAllText(@"..\..\..\..\..\..\src\Ufbx.Enums.Generated.cs", writer.Finish());

			writer = new Writer();
			writer.Write(result.UnnamedEnumValues);
			writer.WriteEmptyLine();
			writer.Write(result.GlobalVariables);
			File.WriteAllText(@"..\..\..\..\..\..\src\Ufbx.GlobalVariables.Generated.cs", writer.Finish());

			writer = new Writer();
			writer.Write(result.Structs);
			File.WriteAllText(@"..\..\..\..\..\..\src\Ufbx.Structs.Generated.cs", writer.Finish());

			writer = new Writer();
			writer.Write(result.Delegates);
			writer.WriteEmptyLine();
			writer.Write(result.Functions);

			var data = writer.Finish();
			data.Replace("u i64", string.Empty);
			data.Replace("u i32", string.Empty);
			File.WriteAllText(@"..\..\..\..\..\..\src\Ufbx.Functions.Generated.cs", data);
		}

		static void Main(string[] args)
		{
			try
			{
				Process();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
			}

			Console.WriteLine("Finished. Press any key to quit.");
			Console.ReadKey();
		}
	}
}