﻿// Solution:         Unity Tools
// Project:          UnityTools
// Filename:         PP_RemoveComponents.cs
// 
// Created:          16.08.2019  16:33
// Last modified:    03.12.2019  08:37
// 
// --------------------------------------------------------------------------------------
// 
// MIT License
// 
// Copyright (c) 2019 chillersanim
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

using UnityEngine;
using Unity_Tools.Core;

namespace Unity_Tools.Pipeline.Specialized
{
    /// <summary>
    ///     The p p_ remove components.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public sealed class PP_RemoveComponents<T> : PipelineItemWorker<GameObject>
        where T : Component
    {
        /// <summary>
        ///     The work on item.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        protected override void WorkOnItem(GameObject item)
        {
            if (item == null)
            {
                return;
            }

            item.RemoveComponents<T>();
        }
    }
}