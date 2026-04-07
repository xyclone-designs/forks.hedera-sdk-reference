// SPDX-License-Identifier: Apache-2.0

namespace Hedera.Hashgraph.Reference.Token
{
    /// <summary>
    /// </summary>
    public enum TokenPauseStatus
    {
        /// <summary>
        ///
        /// Indicates that a Token has no pauseKey
        ///
        /// </summary>
        PAUSE_NOT_APPLICABLE,
        /// <summary>
        ///
        /// Indicates that a Token is Paused
        ///
        /// </summary>
        PAUSED,
        /// <summary>
        ///
        /// Indicates that a Token is Unpaused.
        /// </summary>
        UPAUSED,
    }
}
