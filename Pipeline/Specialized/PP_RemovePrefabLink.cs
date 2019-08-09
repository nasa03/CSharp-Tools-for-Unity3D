﻿// Solution:         Unity Tools
// Project:          Assembly-CSharp
// Filename:         PP_RemovePrefabLink.cs
// 
// Created:          09.08.2019  15:48
// Last modified:    09.08.2019  15:54
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
// 
#region usings

using UnityEditor;
using UnityEngine;

#endregion

namespace Unity_Tools.Pipeline.Specialized
{
    #region Usings

    #endregion

    /// <summary>
    ///     The p p_ remove prefab link.
    /// </summary>
    public class PP_RemovePrefabLink : PipelineItemWorker<GameObject>
    {
        /// <summary>
        ///     The work on item.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        protected override void WorkOnItem(GameObject item)
        {
#if UNITY_EDITOR
            if (item == null)
            {
                return;
            }
            
            if (PrefabUtility.IsPartOfAnyPrefab(item))
            {
                PrefabUtility.UnpackPrefabInstance(
                    PrefabUtility.GetOutermostPrefabInstanceRoot(item),
                    PrefabUnpackMode.Completely,
                    InteractionMode.AutomatedAction);
            }
#endif
        }
    }
}