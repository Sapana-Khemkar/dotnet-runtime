// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
//
// Implementation of _CONTEXT_CaptureContext for the IBM power ppc64le platform.
// This function is processor dependent.  It is used by exception handling,
// and is always apply to the current thread.
//

#include "unixasmmacros.inc"
#include "asmconstants.h"

LEAF_ENTRY CONTEXT_CaptureContext, _TEXT
	bl abort
	nop
LEAF_END CONTEXT_CaptureContext, _TEXT

LEAF_ENTRY RtlCaptureContext, _TEXT
	bl abort
	nop
LEAF_END RtlCaptureContext, _TEXT

LEAF_ENTRY RtlRestoreContext, _TEXT
	bl abort
	nop
LEAF_END RtlRestoreContext, _TEXT
