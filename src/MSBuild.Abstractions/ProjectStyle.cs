﻿namespace MSBuild.Abstractions
{
    public enum ProjectStyle
    {
        /// <summary>
        /// The project has an import of two defaults. Typically Common.props and CSharp.targets or FSharp.targets, etc. 
        /// </summary>
        Default,

        /// <summary>
        /// Using one of the two defaults, typically CSharp.targets or FSharp.targets.
        /// </summary>
        DefaultSubset,

        /// <summary>
        /// Not using any default targets or props.
        /// </summary>
        Custom,

        /// <summary>
        /// The project is WPF or WinForms, and will use the WinDesktop framework reference
        /// </summary>
        WindowsDesktop,

        /// <summary>
        /// The project is an MSTest project that pulls in a lot of unnecessary imports.
        /// </summary>
        MSTest,

        /// <summary>
        /// Imports CSharp.targets and TODO How to identify the style?
        /// </summary>
        WinUI
    }
}
