// This file is part of Core WF which is licensed under the MIT license.
// See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace System.Activities.Runtime.DurableInstancing
{
    //[Serializable]
    public class InstancePersistenceCommandException : InstancePersistenceException
    {
        private const string InstanceIdName = "instancePersistenceInstanceId";

        public InstancePersistenceCommandException()
        {
        }

        public InstancePersistenceCommandException(string message)
            : base(message)
        {
        }

        public InstancePersistenceCommandException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public InstancePersistenceCommandException(XName commandName)
            : base(commandName)
        {
        }

        public InstancePersistenceCommandException(XName commandName, Guid instanceId)
            : base(commandName)
        {
            InstanceId = instanceId;
        }

        public InstancePersistenceCommandException(XName commandName, Exception innerException)
            : base(commandName, innerException)
        {
        }

        public InstancePersistenceCommandException(XName commandName, string message, Exception innerException)
            : base(commandName, message, innerException)
        {
        }

        public InstancePersistenceCommandException(XName commandName, Guid instanceId, Exception innerException)
            : base(commandName, innerException)
        {
            InstanceId = instanceId;
        }

        public InstancePersistenceCommandException(XName commandName, Guid instanceId, string message, Exception innerException)
            : base(commandName, message, innerException)
        {
            InstanceId = instanceId;
        }

        //[SecurityCritical]
        //protected InstancePersistenceCommandException(SerializationInfo info, StreamingContext context)
        //    : base(info, context)
        //{
        //    InstanceId = (Guid)info.GetValue(InstanceIdName, typeof(Guid));
        //}

        public Guid InstanceId { get; private set; }

        //[Fx.Tag.SecurityNote(Critical = "Overrides critical inherited method")]
        //[SecurityCritical]
        ////[SuppressMessage(FxCop.Category.Security, FxCop.Rule.SecureGetObjectDataOverrides,
        //    //Justification = "Method is SecurityCritical")]
        //public override void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    base.GetObjectData(info, context);
        //    info.AddValue(InstanceIdName, InstanceId, typeof(Guid));
        //}
    }
}
