﻿using System;

namespace ZpqrtBnk.ModelsBuilder
{
    /// <summary>
    /// Indicates the models namespace.
    /// </summary>
    /// <remarks>Will override anything else that might come from settings.</remarks>
    [Obsolete("Use the ModelsBuilderConfigureAttribute instead.")]
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    public sealed class ModelsNamespaceAttribute : Attribute
    {
        public ModelsNamespaceAttribute(string modelsNamespace)
        {}
    }
}

