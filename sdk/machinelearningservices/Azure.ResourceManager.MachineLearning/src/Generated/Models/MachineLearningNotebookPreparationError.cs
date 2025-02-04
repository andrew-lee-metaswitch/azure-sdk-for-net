// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The MachineLearningNotebookPreparationError.
    /// Serialized Name: NotebookPreparationError
    /// </summary>
    public partial class MachineLearningNotebookPreparationError
    {
        /// <summary> Initializes a new instance of MachineLearningNotebookPreparationError. </summary>
        internal MachineLearningNotebookPreparationError()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningNotebookPreparationError. </summary>
        /// <param name="errorMessage"> Serialized Name: NotebookPreparationError.errorMessage. </param>
        /// <param name="statusCode"> Serialized Name: NotebookPreparationError.statusCode. </param>
        internal MachineLearningNotebookPreparationError(string errorMessage, int? statusCode)
        {
            ErrorMessage = errorMessage;
            StatusCode = statusCode;
        }

        /// <summary> Serialized Name: NotebookPreparationError.errorMessage. </summary>
        public string ErrorMessage { get; }
        /// <summary> Serialized Name: NotebookPreparationError.statusCode. </summary>
        public int? StatusCode { get; }
    }
}
