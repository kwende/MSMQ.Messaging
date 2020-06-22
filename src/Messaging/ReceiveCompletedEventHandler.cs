

namespace MSMQ.Messaging
{

   

    // <summary>
    //    Represents the signature of the callback that will
    //    be executed when an asynchronous message queue
    //    receive operation is completed.
    // </summary>
    // <param name='sender'>
    //    Contains the MessageQueue object that calls the method.
    // </param>
    // <param name='args'>
    //    The event information associated with the call.
    // </param>
    // </doc>
    //    
    /// <include file='..\..\doc\ReceiveCompletedEventHandler.uex' path='docs/doc[@for="ReceiveCompletedEventHandler"]/*' />
    /// <devdoc>
    /// <para>Represents the method that will handle the <see cref='MessageQueue.ReceiveCompleted'/> event of a <see cref='MessageQueue'/>.</para>
    /// </devdoc>
    public delegate void ReceiveCompletedEventHandler(object sender, ReceiveCompletedEventArgs e);

}
