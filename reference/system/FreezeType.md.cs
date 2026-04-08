// SPDX-License-Identifier: Apache-2.0

namespace Hedera.Hashgraph.Reference.System
{
    /// <summary>
    /// The type of network freeze or upgrade operation to be performed. This type dictates which
    /// fields are required.
    /// </summary>
    public enum FreezeType
    {
        /// <summary>
        /// An (invalid) default value for this enum, to ensure the client explicitly sets
        /// the intended type of freeze transaction.
        /// </summary>
        UNKNOWN_FREEZE_TYPE,

        /// <summary>
        /// Freezes the network at the specified time. The start\_time field must be provided and
        /// must reference a future time. Any values specified for the update\_file and file\_hash
        /// fields will be ignored. This transaction does not perform any network changes or
        /// upgrades and requires manual intervention to restart the network.
        /// </summary>
        FREEZE_ONLY,

        /// <summary>
        /// A non-freezing operation that initiates network wide preparation in advance of a
        /// scheduled freeze upgrade. The update\_file and file\_hash fields must be provided and
        /// valid. The start\_time field may be omitted and any value present will be ignored.
        /// </summary>
        PREPARE_UPGRADE,

        /// <summary>
        /// Freezes the network at the specified time and performs the previously prepared
        /// automatic upgrade across the entire network.
        /// </summary>
        FREEZE_UPGRADE,

        /// <summary>
        /// Aborts a pending network freeze operation.
        /// </summary>
        FREEZE_ABORT,

        /// <summary>
        /// Performs an immediate upgrade on auxilary services and containers providing
        /// telemetry/metrics. Does not impact network operations.
        /// </summary>
        TELEMETRY_UPGRADE,
    }
}
