// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.Options;

namespace Microsoft.CodeAnalysis.Editor.Options
{
    internal partial class ExtensionManagerOptions
    {
        public const string FeatureName = "ExtensionManager";

        [ExportOption]
        public static readonly Option<bool> DisableCrashingExtensions = new Option<bool>(FeatureName, "DisableCrashingExtensions", defaultValue: true);
    }
}
