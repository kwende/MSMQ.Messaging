

using MSMQ.Messaging.Interop;
using System.Diagnostics;
namespace MSMQ.Messaging
{

 


    /// <include file='..\..\doc\EncryptionRequired.uex' path='docs/doc[@for="EncryptionRequired"]/*' />
    /// <devdoc>
    ///    <para>
    ///       Specifies the privacy level of messages received by the queue.
    ///       
    ///    </para>
    /// </devdoc>
    public enum EncryptionRequired
    {
        /// <include file='..\..\doc\EncryptionRequired.uex' path='docs/doc[@for="EncryptionRequired.None"]/*' />
        /// <devdoc>
        ///    <para>
        ///       Accepts
        ///       only
        ///       non-private (non-encrypted) messages.
        ///       
        ///    </para>
        /// </devdoc>
        None = NativeMethods.QUEUE_PRIVACY_LEVEL_NONE,

        /// <include file='..\..\doc\EncryptionRequired.uex' path='docs/doc[@for="EncryptionRequired.Optional"]/*' />
        /// <devdoc>
        ///    <para>
        ///       Does not force privacy. Accepts private (encrypted) messages and non-private (non-encrypted) messages.
        ///       
        ///    </para>
        /// </devdoc>
        Optional = NativeMethods.QUEUE_PRIVACY_LEVEL_OPTIONAL,

        /// <include file='..\..\doc\EncryptionRequired.uex' path='docs/doc[@for="EncryptionRequired.Body"]/*' />
        /// <devdoc>
        ///    <para>
        ///       Accepts only private (encrypted) messages.
        ///    </para>
        /// </devdoc>
        Body = NativeMethods.QUEUE_PRIVACY_LEVEL_BODY
    }
}
