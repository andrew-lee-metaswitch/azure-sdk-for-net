// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Results of last detection. </summary>
    public partial class MultivariateLastDetectionResult
    {
        /// <summary> Initializes a new instance of MultivariateLastDetectionResult. </summary>
        internal MultivariateLastDetectionResult()
        {
            VariableStates = new ChangeTrackingList<VariableState>();
            Results = new ChangeTrackingList<AnomalyState>();
        }

        /// <summary> Initializes a new instance of MultivariateLastDetectionResult. </summary>
        /// <param name="variableStates"></param>
        /// <param name="results"></param>
        internal MultivariateLastDetectionResult(IReadOnlyList<VariableState> variableStates, IReadOnlyList<AnomalyState> results)
        {
            VariableStates = variableStates.ToList();
            Results = results.ToList();
        }

        /// <summary> Gets the variable states. </summary>
        public IReadOnlyList<VariableState> VariableStates { get; }
        /// <summary> Gets the results. </summary>
        public IReadOnlyList<AnomalyState> Results { get; }
    }
}
