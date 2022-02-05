using DesktopCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopCore.Classes
{
    public class Message
    {
        public int Code { get; set; }
        public string Txt { get; set; }
        public MessageType Type { get; set; }
    }
}
