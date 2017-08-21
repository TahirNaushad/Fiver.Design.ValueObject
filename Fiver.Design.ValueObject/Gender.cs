using System;
using System.Collections.Generic;
using System.Text;

namespace Fiver.Design.ValueObject
{
    public enum GenderType { Male, Female }
    
    public sealed class Gender1
    {
        private readonly GenderType genderType;

        internal Gender1(GenderType genderType)
        {
            this.genderType = genderType;
        }

        public GenderType GenderType => this.genderType;
    }

    public sealed class Gender2
    {
        private readonly GenderType genderType;

        internal Gender2(GenderType genderType)
        {
            this.genderType = genderType;
        }

        public bool IsMale => this.genderType == GenderType.Male;
        public bool IsFemale => this.genderType == GenderType.Female;
    }

    public sealed class Gender3
    {
        private readonly string genderType;

        internal Gender3(string genderType)
        {
            this.genderType = genderType;
        }

        public bool IsMale =>
            this.genderType.ToUpper() == "MALE" || this.genderType.ToUpper() == "M";

        public bool IsFemale =>
            this.genderType.ToUpper() == "Female" || this.genderType.ToUpper() == "F";
    }
}