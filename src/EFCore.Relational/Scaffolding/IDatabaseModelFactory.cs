// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Data.Common;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

#nullable enable

namespace Microsoft.EntityFrameworkCore.Scaffolding
{
    /// <summary>
    ///     A service typically implemented by database providers to reverse engineer a database into
    ///     a <see cref="DatabaseModel" />.
    /// </summary>
    public interface IDatabaseModelFactory
    {
        /// <summary>
        ///     Connects to the database using the given connection string and creates a <see cref="DatabaseModel" />
        ///     for the database.
        /// </summary>
        /// <param name="connectionString"> The connection string for the database to reverse engineer. </param>
        /// <param name="options"> The options specifying which metadata to read. </param>
        /// <returns> The database model. </returns>
        DatabaseModel Create([NotNull] string connectionString, [NotNull] DatabaseModelFactoryOptions options);

        /// <summary>
        ///     Connects to the database using the given connection and creates a <see cref="DatabaseModel" />
        ///     for the database.
        /// </summary>
        /// <param name="connection"> The connection to the database to reverse engineer. </param>
        /// <param name="options"> The options specifying which metadata to read. </param>
        /// <returns> The database model. </returns>
        DatabaseModel Create([NotNull] DbConnection connection, [NotNull] DatabaseModelFactoryOptions options);

        /// <summary>
        ///     Overrides the connection string for scaffolding only.
        /// </summary>
        string? OverriddenConnectionString { get; [param: NotNull] set; }
    }
}
