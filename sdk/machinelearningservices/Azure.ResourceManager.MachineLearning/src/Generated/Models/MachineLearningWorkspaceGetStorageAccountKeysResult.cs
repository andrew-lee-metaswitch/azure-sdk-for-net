// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The MachineLearningWorkspaceGetStorageAccountKeysResult.
    /// Serialized Name: ListStorageAccountKeysResult
    /// </summary>
    public partial class MachineLearningWorkspaceGetStorageAccountKeysResult
    {
        /// <summary> Initializes a new instance of MachineLearningWorkspaceGetStorageAccountKeysResult. </summary>
        internal MachineLearningWorkspaceGetStorageAccountKeysResult()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningWorkspaceGetStorageAccountKeysResult. </summary>
        /// <param name="userStorageKey"> Serialized Name: ListStorageAccountKeysResult.userStorageKey. </param>
        internal MachineLearningWorkspaceGetStorageAccountKeysResult(string userStorageKey)
        {
            UserStorageKey = userStorageKey;
        }

        /// <summary> Serialized Name: ListStorageAccountKeysResult.userStorageKey. </summary>
        public string UserStorageKey { get; }
    }
}
