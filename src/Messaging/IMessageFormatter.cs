

using System;
using System.ComponentModel;
using MSMQ.Messaging.Design;

namespace MSMQ.Messaging
{
   

    /// <include file='..\..\doc\IMessageFormatter.uex' path='docs/doc[@for="IMessageFormatter"]/*' />
    /// <devdoc>
    ///    The functions defined in this interface are used to 
    ///    serailize and deserialize objects into and from 
    ///    MessageQueue messages.
    /// </devdoc>
    [TypeConverter(typeof(MessageFormatterConverter))]
    public interface IMessageFormatter : ICloneable
    {

        /// <include file='..\..\doc\IMessageFormatter.uex' path='docs/doc[@for="IMessageFormatter.CanRead"]/*' />
        /// <devdoc>
        ///    When this method is called, the formatter will attempt to determine 
        ///    if the contents of the message are something the formatter can deal with.
        /// </devdoc>
        bool CanRead(Message message);

        /// <include file='..\..\doc\IMessageFormatter.uex' path='docs/doc[@for="IMessageFormatter.Read"]/*' />
        /// <devdoc>
        ///    This method is used to read the contents from the given message 
        ///     and create an object.
        /// </devdoc>
        object Read(Message message);

        /// <include file='..\..\doc\IMessageFormatter.uex' path='docs/doc[@for="IMessageFormatter.Write"]/*' />
        /// <devdoc>
        ///    This method is used to write the given object into the given message.  
        ///     If the formatter cannot understand the given object, an exception is thrown.
        /// </devdoc>
        void Write(Message message, object obj);
    }
}
