using System;

namespace ElevaEducacao.PortalEscola.Application.Util
{
    public class Guardian
    {
        public static void AgainstNull(object param, string name = null)
        {
            if (param == null)
            {
                throw new ArgumentNullException(nameof(param));
            }
        }
    }
}
