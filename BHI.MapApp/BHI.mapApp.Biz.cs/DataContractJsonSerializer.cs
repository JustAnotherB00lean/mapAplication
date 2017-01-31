using System;

namespace BHI.mapApp.Biz.cs
{
    internal class DataContractJsonSerializer
    {
        private Type type;

        public DataContractJsonSerializer(Type type)
        {
            this.type = type;
        }
    }
}