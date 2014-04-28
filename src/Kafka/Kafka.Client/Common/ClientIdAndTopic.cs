﻿namespace Kafka.Client.Common
{
    public class ClientIdAndTopic
    {
        public string ClientId { get; private set; }

        public string Topic { get; private set; }

        public ClientIdAndTopic(string clientId, string topic)
        {
            this.ClientId = clientId;
            this.Topic = topic;
        }

        protected bool Equals(ClientIdAndTopic other)
        {
            return string.Equals(this.ClientId, other.ClientId) && string.Equals(this.Topic, other.Topic);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((ClientIdAndTopic)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((this.ClientId != null ? this.ClientId.GetHashCode() : 0) * 397) ^ (this.Topic != null ? this.Topic.GetHashCode() : 0);
            }
        }

        public override string ToString()
        {
            return string.Format("({0}-{1})", this.ClientId, this.Topic);
        }
    }
}