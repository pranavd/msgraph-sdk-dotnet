// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IManagedEBookCategoriesCollectionReferencesRequest.
    /// </summary>
    public partial interface IManagedEBookCategoriesCollectionReferencesRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified ManagedEBookCategory to the collection via POST.
        /// </summary>
        /// <param name="managedEBookCategory">The ManagedEBookCategory to add.</param>
        System.Threading.Tasks.Task AddAsync(ManagedEBookCategory managedEBookCategory);

        /// <summary>
        /// Adds the specified ManagedEBookCategory to the collection via POST.
        /// </summary>
        /// <param name="managedEBookCategory">The ManagedEBookCategory to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task AddAsync(ManagedEBookCategory managedEBookCategory, CancellationToken cancellationToken);
    }
}