﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Scaffolding
{
    /// <summary>
    ///     Used to scaffold a model from a database schema.
    /// </summary>
    public interface IReverseEngineerScaffolder
    {
        /// <summary>
        ///     Scaffolds a model from a database schema.
        /// </summary>
        /// <param name="connectionString"> A connection string to the database. </param>
        /// <param name="options"> The options specifying which metadata to read from the database. </param>
        /// <param name="rootNamespace"> The namespace of the project. </param>
        /// <param name="modelNamespace"> The namespace for model classes. </param>
        /// <param name="contextNamespace"> The namespace for context class. </param>
        /// <param name="language"> The programming language to scaffold for. </param>
        /// <param name="contextDir"> The DbContext output directory. </param>
        /// <param name="contextName"> The <see cref="DbContext" /> name. </param>
        /// <param name="modelOptions"> The options to use when reverse engineering a model from the database. </param>
        /// <param name="codeOptions"> The options to use when generating code for the model. </param>
        /// <returns> The scaffolded model. </returns>
        ScaffoldedModel ScaffoldModel(
            [NotNull] string connectionString,
            [NotNull] DatabaseModelFactoryOptions options,
            [NotNull] string rootNamespace,
            [NotNull] string modelNamespace,
            [NotNull] string contextNamespace,
            [CanBeNull] string language,
            [CanBeNull] string contextDir,
            [CanBeNull] string contextName,
            [NotNull] ModelReverseEngineerOptions modelOptions,
            [NotNull] ModelCodeGenerationOptions codeOptions);

        /// <summary>
        ///     Saves a scaffolded model to disk.
        /// </summary>
        /// <param name="scaffoldedModel"> The scaffolded model. </param>
        /// <param name="outputDir"> The output directory. </param>
        /// <param name="overwriteFiles"> True to overwrite any existing files. </param>
        /// <returns> The model files. </returns>
        SavedModelFiles Save(
            [NotNull] ScaffoldedModel scaffoldedModel,
            [CanBeNull] string outputDir,
            bool overwriteFiles);
    }
}
