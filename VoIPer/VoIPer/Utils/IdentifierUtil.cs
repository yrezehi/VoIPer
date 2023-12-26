using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoIPer.Utils
{
    public static class IdentifierUtil
    {
        public static string GenerateShort() =>
            Convert.ToBase64String(Guid.NewGuid().ToByteArray());
    }
}
