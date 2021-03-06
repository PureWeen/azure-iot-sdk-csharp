﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Azure.Devices.Common;
using Microsoft.Azure.Devices.Common.Exceptions;
using System;

namespace Microsoft.Azure.Devices.Provisioning.Service
{
    public sealed class EnrollmentNotFoundException : IotHubException
    {
        public EnrollmentNotFoundException(string registrationId)
            : this(registrationId, null, null)
        {
        }

        public EnrollmentNotFoundException(string registrationId, string drsName)
            : this(registrationId, drsName, null)
        {
        }

        public EnrollmentNotFoundException(string registrationId, string drsName, string trackingId)
            : base(!string.IsNullOrEmpty(drsName) ?
                  ApiResources.EnrollmentNotFoundAtServiceName.FormatInvariant(registrationId, drsName) :
                  ApiResources.EnrollmentNotFound.FormatInvariant(registrationId), trackingId)
        {
        }

        public EnrollmentNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
