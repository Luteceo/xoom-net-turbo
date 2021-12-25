// Copyright © 2012-2021 VLINGO LABS. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

namespace Vlingo.Xoom.Turbo.Tests.Scooter.Persistence
{
	public class Entity2
	{
		public string Id { get; }
		public string Value { get; }

		public Entity2(string id, string value)
		{
			Id = id;
			Value = value;
		}
		
		public override bool Equals(object? obj)
		{
			if (obj == null || obj.GetType() != GetType())
			{
				return false;
			}
			return Id == ((Entity2)obj).Id;
		}
	}
}