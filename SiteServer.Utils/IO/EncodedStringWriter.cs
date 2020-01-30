using System.IO;
using System.Text;

namespace SiteServer.Utils.IO
{
    public class EncodedStringWriter : StringWriter
    {
        private Encoding encoding;

        public EncodedStringWriter(StringBuilder builder, Encoding encoding)
            : base(builder)
        {
            this.encoding = encoding;
        }

        public override Encoding Encoding => encoding;
    }
}
