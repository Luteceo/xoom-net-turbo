// Copyright © 2012-2021 VLINGO LABS. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using System.Collections.Generic;
using Vlingo.Xoom.Turbo.Codegen.Content;
using Vlingo.Xoom.Turbo.Codegen.Template;

namespace Vlingo.Xoom.Turbo.Annotation.Codegen.Storage
{
	public class AdapterTemplateData : TemplateData
	{
		private TemplateParameters _parameters;

		public static TemplateData From(string persistencePackage, StorageType storageType, IReadOnlyList<ContentBase> contents)
		{
			throw new System.NotImplementedException();
		}

		public override TemplateParameters Parameters() => _parameters;

		public override TemplateStandard Standard() => AnnotationBasedTemplateStandard.Adapter;
	}
}