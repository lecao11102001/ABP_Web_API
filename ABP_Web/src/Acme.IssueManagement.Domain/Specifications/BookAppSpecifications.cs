using Acme.IssueManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Volo.Abp.Specifications;

namespace Acme.IssueManagement.Specifications
{
    public class BookAppSpecifications : Specification<Book>
    {
        private readonly string _textSearch;
        public BookAppSpecifications()
        {
        }
        public BookAppSpecifications(string textSearch)
        {
            _textSearch = textSearch;
        }
        public override Expression<Func<Book, bool>> ToExpression()
        {
            Expression<Func<Book, bool>> expression = s => true;
            if (!string.IsNullOrEmpty(_textSearch))
            {
                expression = expression.And(s => s.Name.Contains(_textSearch));
            }

            return expression;
        }
    }
}
