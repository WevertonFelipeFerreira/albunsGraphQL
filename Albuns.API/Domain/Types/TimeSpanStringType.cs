using HotChocolate.Language;

namespace Albuns.API.Domain.Types
{
    public sealed class TimeSpanStringType : ScalarType<TimeSpan, StringValueNode>
    {
        private const string CONVERSION_ERROR_MESSAGE = "The specified value has to be a time span value in the format 00:00:00";
        public TimeSpanStringType() : base("TimeSpanString")
        {
        }

        public override IValueNode ParseResult(object? resultValue) => ParseValue(resultValue);

        protected override TimeSpan ParseLiteral(StringValueNode valueSyntax)
        {
            if (string.IsNullOrEmpty(valueSyntax.Value))
                return new TimeSpan(0, 0, 0);

            var splitedString = valueSyntax.Value.Split(":");

            if (splitedString.Length is not 3)
                throw new SerializationException(CONVERSION_ERROR_MESSAGE, this);

            bool hourResult = int.TryParse(splitedString[0], out int hour);
            bool minuteResult = int.TryParse(splitedString[1], out int minute);
            bool secondsResult = int.TryParse(splitedString[2], out int seconds);

            if (!hourResult || !minuteResult || !secondsResult)
                throw new SerializationException(CONVERSION_ERROR_MESSAGE, this);

            return new TimeSpan(hour, minute, seconds);
        }

        protected override StringValueNode ParseValue(TimeSpan runtimeValue)
        {
            return new StringValueNode(runtimeValue.ToString());
        }
    }
}
