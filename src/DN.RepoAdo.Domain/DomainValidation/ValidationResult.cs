using System.Collections.Generic;
using System.Linq;

namespace DN.RepoAdo.Domain.DomainValidation
{
    public class ValidationResult
    {
        private readonly List<ValidationError> _errors = new List<ValidationError>();

        public bool IsValid { get { return _errors.Count == 0; } }

        public IEnumerable<ValidationError> Errors { get { return _errors; } }

        public void AddError(string message)
        {
            var validationError = new ValidationError(message);
            _errors.Add(validationError);
        }
        public void AddError(ValidationError error)
        {
            _errors.Add(error);
        }
        public void AddError(params ValidationResult[] resultadoValidacao)
        {
            if (resultadoValidacao == null) return;

            foreach (var validationResult in resultadoValidacao.Where(result => result != null))
                _errors.AddRange(validationResult.Errors);
        }
        public void RemoveError(ValidationError error)
        {
            if (_errors.Contains(error))
                _errors.Remove(error);
        }

    }
}