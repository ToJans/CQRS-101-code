using System;

namespace VisugDemo.Infrastructure
{
    public static class Guard
    {
        public static void Against(bool assertion, string message)
        {
            if (assertion) throw new InvalidOperationException(message);
        }
    }

}