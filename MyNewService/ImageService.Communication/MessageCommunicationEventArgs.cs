using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageService.Communication
{
    /// <summary>
    /// class for the communication message eventargs 
    /// </summary>
    public class MessageCommunicationEventArgs : EventArgs
    {
        /// <summary>
        /// the message
        /// </summary>
        public string Message { get; set; }
    }
}
