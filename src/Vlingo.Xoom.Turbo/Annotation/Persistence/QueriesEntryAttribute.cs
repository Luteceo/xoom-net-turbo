﻿// Copyright © 2012-2022 VLINGO LABS. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using System;

namespace Vlingo.Xoom.Turbo.Annotation.Persistence
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class QueriesEntryAttribute : Attribute
	{
		public Type? Actor { get; set; }

		public Type? Protocol { get; set; }
	}
}