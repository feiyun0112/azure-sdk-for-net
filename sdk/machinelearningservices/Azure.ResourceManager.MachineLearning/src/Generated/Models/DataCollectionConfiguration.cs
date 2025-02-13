// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The DataCollectionConfiguration. </summary>
    public partial class DataCollectionConfiguration
    {
        /// <summary> Initializes a new instance of DataCollectionConfiguration. </summary>
        public DataCollectionConfiguration()
        {
        }

        /// <summary> Initializes a new instance of DataCollectionConfiguration. </summary>
        /// <param name="clientId"> The msi client id used to collect logging to blob storage. If it's null,backend will pick a registered endpoint identity to auth. </param>
        /// <param name="dataCollectionMode"> Enable or disable data collection. </param>
        /// <param name="dataId"> The data asset arm resource id. Client side will ensure data asset is pointing to the blob storage, and backend will collect data to the blob storage. </param>
        /// <param name="samplingRate"> The sampling rate for collection. Sampling rate 1.0 means we collect 100% of data by default. </param>
        internal DataCollectionConfiguration(string clientId, DataCollectionMode? dataCollectionMode, string dataId, double? samplingRate)
        {
            ClientId = clientId;
            DataCollectionMode = dataCollectionMode;
            DataId = dataId;
            SamplingRate = samplingRate;
        }

        /// <summary> The msi client id used to collect logging to blob storage. If it's null,backend will pick a registered endpoint identity to auth. </summary>
        public string ClientId { get; set; }
        /// <summary> Enable or disable data collection. </summary>
        public DataCollectionMode? DataCollectionMode { get; set; }
        /// <summary> The data asset arm resource id. Client side will ensure data asset is pointing to the blob storage, and backend will collect data to the blob storage. </summary>
        public string DataId { get; set; }
        /// <summary> The sampling rate for collection. Sampling rate 1.0 means we collect 100% of data by default. </summary>
        public double? SamplingRate { get; set; }
    }
}
