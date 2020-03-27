//-----------------------------------------------------------------------
// <copyright file="ErrorViewModel.cs" company="Kofax Inc.">
//     Copyright (c) Kofax Inc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Kofax.QATestTask.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}