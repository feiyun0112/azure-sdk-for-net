// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> List of restorable backups for a Cassandra cluster. </summary>
    internal partial class ListBackups
    {
        /// <summary> Initializes a new instance of ListBackups. </summary>
        internal ListBackups()
        {
            Value = new ChangeTrackingList<CassandraClusterBackupResourceData>();
        }

        /// <summary> Initializes a new instance of ListBackups. </summary>
        /// <param name="value"> Container for array of backups. </param>
        internal ListBackups(IReadOnlyList<CassandraClusterBackupResourceData> value)
        {
            Value = value;
        }

        /// <summary> Container for array of backups. </summary>
        public IReadOnlyList<CassandraClusterBackupResourceData> Value { get; }
    }
}
