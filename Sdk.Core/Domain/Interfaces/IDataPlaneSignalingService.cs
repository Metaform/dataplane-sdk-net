using Sdk.Core.Domain.Messages;
using Sdk.Core.Domain.Model;

namespace Sdk.Core.Domain.Interfaces;

public interface IDataPlaneSignalingService
{
    /// <summary>
    ///     Starts a data flow by sending a DataflowStartMessage to the data plane signaling service.
    /// </summary>
    /// <param name="message">The start message/></param>
    /// <returns>A status result that contains the response message if successful</returns>
    Task<StatusResult<DataFlowResponseMessage>> StartAsync(DataflowStartMessage message);

    /// <summary>
    ///     Suspends (pauses) a data flow by its ID.
    /// </summary>
    Task<StatusResult<Void>> SuspendAsync(string dataFlowId, string? reason = null);

    /// <summary>
    ///     Terminates (aborts) a data flow by its ID.
    /// </summary>
    /// <param name="dataFlowId">Data flow ID</param>
    /// <param name="reason">Optional reason</param>
    Task<StatusResult<Void>> TerminateAsync(string dataFlowId, string? reason = null);

    /// <summary>
    ///     Returns the transfer state for the process.
    /// </summary>
    /// <param name="processId"></param>
    Task<StatusResult<DataFlowState>> GetTransferStateAsync(string processId);

    /// <summary>
    ///     Validate the start message, i.e. check if the data flow already exists, if source and destination addresses are
    ///     valid, etc.
    /// </summary>
    /// <param name="startMessage"></param>
    /// <returns></returns>
    Task<StatusResult<Void>> ValidateStartMessageAsync(DataflowStartMessage startMessage);

    //todo: add restart flows, resourceProvisioned, resourceDeprovisioned, etc.
}