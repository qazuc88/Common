﻿// Copyright 2017 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace Steeltoe.Common.Http.Discovery
{
    /// <summary>
    /// Extension method for configuring <see cref="DiscoveryHttpMessageHandler"/> in <see cref="HttpClient"/> message handler pipelines
    /// </summary>
    public static class DiscoveryHttpClientBuilderExtensions
    {
        /// <summary>
        /// Adds a <see cref="DiscoveryHttpMessageHandler"/> for performing service discovery
        /// </summary>
        /// <param name="builder">The <see cref="IHttpClientBuilder"/>.</param>
        /// <returns>An <see cref="IHttpClientBuilder"/> that can be used to configure the client.</returns>
        public static IHttpClientBuilder AddServiceDiscovery(this IHttpClientBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.AddHttpMessageHandler<DiscoveryHttpMessageHandler>();
            return builder;
        }
    }
}
