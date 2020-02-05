// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gagr = Google.Api.Gax.ResourceNames;
using gcdv = Google.Cloud.Dataproc.V1;
using sys = System;

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Resource name for the <c>AutoscalingPolicy</c> resource.</summary>
    public sealed partial class AutoscalingPolicyName : gax::IResourceName, sys::IEquatable<AutoscalingPolicyName>
    {
        /// <summary>The possible contents of <see cref="AutoscalingPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>.
            /// </summary>
            ProjectRegionAutoscalingPolicy = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>.
            /// </summary>
            ProjectLocationAutoscalingPolicy = 2
        }

        private static gax::PathTemplate s_projectRegionAutoscalingPolicy = new gax::PathTemplate("projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}");

        private static gax::PathTemplate s_projectLocationAutoscalingPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}");

        /// <summary>Creates a <see cref="AutoscalingPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AutoscalingPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AutoscalingPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AutoscalingPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AutoscalingPolicyName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoscalingPolicyId">The <c>AutoscalingPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AutoscalingPolicyName"/> constructed from the provided ids.</returns>
        public static AutoscalingPolicyName FromProjectRegionAutoscalingPolicy(string projectId, string regionId, string autoscalingPolicyId) =>
            new AutoscalingPolicyName(ResourceNameType.ProjectRegionAutoscalingPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), autoscalingPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(autoscalingPolicyId, nameof(autoscalingPolicyId)));

        /// <summary>
        /// Creates a <see cref="AutoscalingPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoscalingPolicyId">The <c>AutoscalingPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AutoscalingPolicyName"/> constructed from the provided ids.</returns>
        public static AutoscalingPolicyName FromProjectLocationAutoscalingPolicy(string projectId, string locationId, string autoscalingPolicyId) =>
            new AutoscalingPolicyName(ResourceNameType.ProjectLocationAutoscalingPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), autoscalingPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(autoscalingPolicyId, nameof(autoscalingPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutoscalingPolicyName"/> with pattern
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoscalingPolicyId">The <c>AutoscalingPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AutoscalingPolicyName"/> with pattern
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string autoscalingPolicyId) =>
            FormatProjectRegionAutoscalingPolicy(projectId, regionId, autoscalingPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutoscalingPolicyName"/> with pattern
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoscalingPolicyId">The <c>AutoscalingPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AutoscalingPolicyName"/> with pattern
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </returns>
        public static string FormatProjectRegionAutoscalingPolicy(string projectId, string regionId, string autoscalingPolicyId) =>
            s_projectRegionAutoscalingPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(autoscalingPolicyId, nameof(autoscalingPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutoscalingPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoscalingPolicyId">The <c>AutoscalingPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AutoscalingPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationAutoscalingPolicy(string projectId, string locationId, string autoscalingPolicyId) =>
            s_projectLocationAutoscalingPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(autoscalingPolicyId, nameof(autoscalingPolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AutoscalingPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="autoscalingPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AutoscalingPolicyName"/> if successful.</returns>
        public static AutoscalingPolicyName Parse(string autoscalingPolicyName) => Parse(autoscalingPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AutoscalingPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="autoscalingPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AutoscalingPolicyName"/> if successful.</returns>
        public static AutoscalingPolicyName Parse(string autoscalingPolicyName, bool allowUnparsed) =>
            TryParse(autoscalingPolicyName, allowUnparsed, out AutoscalingPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AutoscalingPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="autoscalingPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AutoscalingPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string autoscalingPolicyName, out AutoscalingPolicyName result) =>
            TryParse(autoscalingPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AutoscalingPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="autoscalingPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AutoscalingPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string autoscalingPolicyName, bool allowUnparsed, out AutoscalingPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(autoscalingPolicyName, nameof(autoscalingPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegionAutoscalingPolicy.TryParseName(autoscalingPolicyName, out resourceName))
            {
                result = FromProjectRegionAutoscalingPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationAutoscalingPolicy.TryParseName(autoscalingPolicyName, out resourceName))
            {
                result = FromProjectLocationAutoscalingPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(autoscalingPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AutoscalingPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string autoscalingPolicyId = null, string locationId = null, string projectId = null, string regionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AutoscalingPolicyId = autoscalingPolicyId;
            LocationId = locationId;
            ProjectId = projectId;
            RegionId = regionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AutoscalingPolicyName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoscalingPolicyId">The <c>AutoscalingPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public AutoscalingPolicyName(string projectId, string regionId, string autoscalingPolicyId) : this(ResourceNameType.ProjectRegionAutoscalingPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), autoscalingPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(autoscalingPolicyId, nameof(autoscalingPolicyId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>AutoscalingPolicy</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string AutoscalingPolicyId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string RegionId { get; }

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionAutoscalingPolicy: return s_projectRegionAutoscalingPolicy.Expand(ProjectId, RegionId, AutoscalingPolicyId);
                case ResourceNameType.ProjectLocationAutoscalingPolicy: return s_projectLocationAutoscalingPolicy.Expand(ProjectId, LocationId, AutoscalingPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AutoscalingPolicyName);

        /// <inheritdoc/>
        public bool Equals(AutoscalingPolicyName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AutoscalingPolicyName a, AutoscalingPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AutoscalingPolicyName a, AutoscalingPolicyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>RegionOrLocation</c> resource.</summary>
    public sealed partial class RegionOrLocationName : gax::IResourceName, sys::IEquatable<RegionOrLocationName>
    {
        /// <summary>The possible contents of <see cref="RegionOrLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/regions/{region}</c>.</summary>
            ProjectRegion = 1,

            /// <summary>A resource name with pattern <c>projects/{project}/locations/{location}</c>.</summary>
            ProjectLocation = 2
        }

        private static gax::PathTemplate s_projectRegion = new gax::PathTemplate("projects/{project}/regions/{region}");

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}");

        /// <summary>Creates a <see cref="RegionOrLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RegionOrLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RegionOrLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RegionOrLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RegionOrLocationName"/> with the pattern <c>projects/{project}/regions/{region}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RegionOrLocationName"/> constructed from the provided ids.</returns>
        public static RegionOrLocationName FromProjectRegion(string projectId, string regionId) =>
            new RegionOrLocationName(ResourceNameType.ProjectRegion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)));

        /// <summary>
        /// Creates a <see cref="RegionOrLocationName"/> with the pattern <c>projects/{project}/locations/{location}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RegionOrLocationName"/> constructed from the provided ids.</returns>
        public static RegionOrLocationName FromProjectLocation(string projectId, string locationId) =>
            new RegionOrLocationName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegionOrLocationName"/> with pattern
        /// <c>projects/{project}/regions/{region}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegionOrLocationName"/> with pattern
        /// <c>projects/{project}/regions/{region}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId) => FormatProjectRegion(projectId, regionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegionOrLocationName"/> with pattern
        /// <c>projects/{project}/regions/{region}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegionOrLocationName"/> with pattern
        /// <c>projects/{project}/regions/{region}</c>.
        /// </returns>
        public static string FormatProjectRegion(string projectId, string regionId) =>
            s_projectRegion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegionOrLocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegionOrLocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RegionOrLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="regionOrLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RegionOrLocationName"/> if successful.</returns>
        public static RegionOrLocationName Parse(string regionOrLocationName) => Parse(regionOrLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RegionOrLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="regionOrLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RegionOrLocationName"/> if successful.</returns>
        public static RegionOrLocationName Parse(string regionOrLocationName, bool allowUnparsed) =>
            TryParse(regionOrLocationName, allowUnparsed, out RegionOrLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegionOrLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="regionOrLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegionOrLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string regionOrLocationName, out RegionOrLocationName result) =>
            TryParse(regionOrLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegionOrLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="regionOrLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegionOrLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string regionOrLocationName, bool allowUnparsed, out RegionOrLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(regionOrLocationName, nameof(regionOrLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegion.TryParseName(regionOrLocationName, out resourceName))
            {
                result = FromProjectRegion(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocation.TryParseName(regionOrLocationName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(regionOrLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RegionOrLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string regionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RegionId = regionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RegionOrLocationName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        public RegionOrLocationName(string projectId, string regionId) : this(ResourceNameType.ProjectRegion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string RegionId { get; }

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegion: return s_projectRegion.Expand(ProjectId, RegionId);
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RegionOrLocationName);

        /// <inheritdoc/>
        public bool Equals(RegionOrLocationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RegionOrLocationName a, RegionOrLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RegionOrLocationName a, RegionOrLocationName b) => !(a == b);
    }

    public partial class AutoscalingPolicy
    {
        /// <summary>
        /// <see cref="gcdv::AutoscalingPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AutoscalingPolicyName AutoscalingPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AutoscalingPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAutoscalingPolicyRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="RegionOrLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RegionOrLocationName ParentAsRegionOrLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RegionOrLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (RegionOrLocationName.TryParse(Parent, out RegionOrLocationName regionOrLocation))
                {
                    return regionOrLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAutoscalingPolicyRequest
    {
        /// <summary>
        /// <see cref="gcdv::AutoscalingPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AutoscalingPolicyName AutoscalingPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AutoscalingPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAutoscalingPolicyRequest
    {
        /// <summary>
        /// <see cref="gcdv::AutoscalingPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AutoscalingPolicyName AutoscalingPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AutoscalingPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAutoscalingPoliciesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="RegionOrLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RegionOrLocationName ParentAsRegionOrLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RegionOrLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (RegionOrLocationName.TryParse(Parent, out RegionOrLocationName regionOrLocation))
                {
                    return regionOrLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }
}