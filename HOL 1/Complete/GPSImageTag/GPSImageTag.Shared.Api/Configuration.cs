using System;
using System.Collections.Generic;
using System.Text;

namespace GPSImageTag
{
    public static class Configuration
    {
        /// <summary>
        /// Azure Storage Connection String. UseDevelopmentStorage=true points to the storage emulator.
        /// </summary>
        // public const string StorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=<Azure Storage account name goes here>;AccountKey=<Azure Storage account key goes here>";
        public const string StorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=petfrenzblob;AccountKey=zFc5dXh6f5CH13K3IIvBphEyCumAwl/8dXOJz+BLS/Sbg2AjhNQMDOBT65LYe8OfnADfFfeKjiK2azpaq3SdZw==;";
        public const string StorageContainerName = "photos";
    }
}
