﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;

namespace ShaderTools.CodeAnalysis.Editor.Implementation.IntelliSense.SignatureHelp
{
    internal partial class Controller
    {
        internal override void OnCaretPositionChanged(object sender, EventArgs args)
        {
            AssertIsForeground();
            OnCaretPositionChanged();
        }

        private void OnCaretPositionChanged()
        {
            Retrigger();
        }
    }
}
