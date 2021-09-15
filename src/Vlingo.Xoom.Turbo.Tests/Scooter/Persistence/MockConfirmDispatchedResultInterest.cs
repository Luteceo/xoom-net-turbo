// Copyright © 2012-2021 VLINGO LABS. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using System;
using Vlingo.Xoom.Symbio.Store;
using Vlingo.Xoom.Symbio.Store.Dispatch;

namespace Vlingo.Xoom.Turbo.Tests.Scooter.Persistence
{
	public class MockConfirmDispatchedResultInterest : IConfirmDispatchedResultInterest
	{
		public void ConfirmDispatchedResultedIn(Result result, string dispatchId)
		{
			throw new NotImplementedException();
		}
	}
}