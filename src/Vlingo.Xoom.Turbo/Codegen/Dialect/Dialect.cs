// Copyright © 2012-2021 VLINGO LABS. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using Vlingo.Xoom.Turbo.Codegen.Parameter;

namespace Vlingo.Xoom.Turbo.Codegen.Dialect
{
	public enum Dialect
	{
		C_SHARP
	}
	public static class DialectExtensions
	{
		public static Dialect FindDefault() => Dialect.C_SHARP;

		public static void ResolvePreParametersProcessing(this Dialect dialect, CodeGenerationParameters parameters)
		{
		}
	}
}