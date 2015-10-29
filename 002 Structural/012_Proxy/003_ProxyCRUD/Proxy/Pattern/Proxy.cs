using System;

namespace Proxy
{
    class Proxy : Subject
    {
        Subject subject;
        string role;

        public Proxy(Subject subject, string role)
        {
            this.subject = subject;
            this.role = role;
        }

        public override void Create(string key, string value)
        {
            if (role == "Owner")
                this.subject.Create(key, value);
            else
                throw new UnauthorizedAccessException("Create: Access denied.");
        }

        public override string Read(string key)
        {
            return this.subject.Read(key);
        }

        public override bool Update(string key, string value)
        {
            if (role != "User")
               return this.subject.Update(key, value);
            else
                throw new UnauthorizedAccessException("Update: Access denied.");
        }

        public override bool Delete(string key)
        {
            if (role == "Administrator" || role == "Owner")
                return this.subject.Delete(key);
            else
                throw new UnauthorizedAccessException("Delete: Access denied.");
        }
    }
}
