// Copyright © 2012-2022 VLINGO LABS. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using System.Collections.Generic;
using Vlingo.Xoom.Turbo.Codegen;
using Vlingo.Xoom.Turbo.Codegen.Template;

namespace Vlingo.Xoom.Turbo.Annotation.Codegen.Initializer;

public class XoomInitializerGenerationStep : TemplateProcessingStep
{
	protected override List<TemplateData> BuildTemplatesData(CodeGenerationContext context) =>
		new List<TemplateData> { new XoomInitializerTemplateData(context) };

	public override bool ShouldProcess(CodeGenerationContext context) => true;
}