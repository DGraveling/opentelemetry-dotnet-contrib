// <copyright file="AWSLambdaSemanticConventions.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

namespace OpenTelemetry.Instrumentation.AWSLambda.Implementation;

/// <summary>
/// Semantic conventions for AWS Lambda.
/// </summary>
internal static class AWSLambdaSemanticConventions
{
    public const string AttributeCloudAccountID = "cloud.account.id";
    public const string AttributeCloudProvider = "cloud.provider";
    public const string AttributeCloudRegion = "cloud.region";
    public const string AttributeFaasExecution = "faas.execution";
    public const string AttributeFaasID = "faas.id";
    public const string AttributeFaasName = "faas.name";
    public const string AttributeFaasVersion = "faas.version";
    public const string AttributeFaasTrigger = "faas.trigger";
}
