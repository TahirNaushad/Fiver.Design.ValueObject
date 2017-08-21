using System;
using Xunit;

namespace Fiver.Design.ValueObject
{
    public class GenderTests
    {
        [Fact(DisplayName = "Setting_with_male_returns_Male_for_GenderType_prop")]
        public void Setting_with_male_returns_Male_for_GenderType_prop()
        {
            var gender = new Gender1(GenderType.Male);
            Assert.Equal(
                expected: GenderType.Male,
                actual: gender.GenderType);
        }

        [Fact(DisplayName = "Setting_with_male_enum_returns_true_for_IsMale_prop")]
        public void Setting_with_male_enum_returns_true_for_IsMale_prop()
        {
            var gender = new Gender2(GenderType.Male);
            Assert.True(gender.IsMale);
        }

        [Fact(DisplayName = "Setting_with_male_string_returns_true_for_IsMale_prop")]
        public void Setting_with_male_string_returns_true_for_IsMale_prop()
        {
            var gender = new Gender3("M");
            Assert.True(gender.IsMale);
        }
    }
}
