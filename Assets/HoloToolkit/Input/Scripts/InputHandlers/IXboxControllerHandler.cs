﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace HoloToolkit.Unity.InputModule
{
    public interface IXboxControllerHandler : IGamePadHandler
    {
        [Obsolete("Use OnXboxInputUpdate")]
        void OnXboxAxisUpdate(XboxControllerEventData eventData);

        void OnXboxInputUpdate(XboxControllerEventData eventData);
    }
}
