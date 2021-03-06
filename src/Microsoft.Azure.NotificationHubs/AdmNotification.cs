﻿//----------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT License. See License.txt in the project root for 
// license information.
//----------------------------------------------------------------

namespace Microsoft.Azure.NotificationHubs
{
    using System;

    /// <summary>
    /// Represents the Amazon Device Messaging (ADM) notification.
    /// </summary>
    public sealed class AdmNotification : Notification, INativeNotification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Microsoft.Azure.NotificationHubs.AdmNotification"/> class.
        /// </summary>
        /// <param name="jsonPayload">The JSON payload.</param>
        public AdmNotification(string jsonPayload)
            : base(null, null)
        {
            if (string.IsNullOrWhiteSpace(jsonPayload))
            {
                throw new ArgumentNullException("jsonPayload");
            }

            this.Body = jsonPayload;
        }

        /// <summary>
        /// Gets the type of the platform.
        /// </summary>
        /// <value>
        /// The type of the platform.
        /// </value>
        protected override string PlatformType
        {
            get { return AdmCredential.AppPlatformName; }
        }

        /// <summary>
        /// Validate and populates the headers.
        /// </summary>
        protected override void OnValidateAndPopulateHeaders()
        {
        }
    }
}