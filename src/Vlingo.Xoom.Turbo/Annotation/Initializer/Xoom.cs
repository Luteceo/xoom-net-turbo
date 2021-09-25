// Copyright © 2012-2021 VLINGO LABS. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using System;

namespace Vlingo.Xoom.Turbo.Annotation.Initializer
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public class Xoom : Attribute
	{
		private string _name;

		public string Name
		{
			get => _name;
			set => _name = value;
		}
	}
}