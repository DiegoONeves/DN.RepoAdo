using System;

namespace DN.RepoAdo.Domain.DomainValidation
{
    public class ValidationError
    {
        public ValidationError(string message)
        {
            Key = GetKey();
            Message = message;
        }
        public ValidationError(string message, MessageCategory messageCategory)
        {
            Key = GetKey();
            Message = message;
            MessageCategory = messageCategory;
        }
        public ValidationError(string key, string message)
        {
            Key = key;
            Message = message;
        }
        public ValidationError(string key, string message, MessageCategory messageCategory)
        {
            Key = key;
            Message = message;
            MessageCategory = messageCategory;

        }
        public string Key { get; private set; }
        public string Message { get; private set; }
        public MessageCategory MessageCategory { get; private set; } = MessageCategory.BusinessRule;

        private string GetKey()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8);
        }
    }
}
