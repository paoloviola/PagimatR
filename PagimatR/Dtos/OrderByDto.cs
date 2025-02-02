using PagimatR.Enums;
using Remote.Linq.Expressions;
using System.Text.Json.Serialization;

namespace PagimatR.Dtos
{
    public class OrderByDto
    {
        public LambdaExpression Property { get; set; }

        public OrderDirection Direction { get; set; }

        [JsonConstructor]
        public OrderByDto(LambdaExpression property, OrderDirection direction)
        {
            Property = property;
            Direction = direction;
        }
    }
}
