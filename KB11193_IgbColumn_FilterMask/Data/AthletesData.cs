namespace KB11193_IgbColumn_FilterMask.Data
{

    public class AthletesData : List<AthletesDataItem>
    {
        public AthletesData()
        {
            AddRange(new AthletesDataItem[] {
        new ()
        {
            Id = 84,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/12.jpg",
            Position = @"current",
            Name = @"Abel Brun",
            AthleteNumber = 39315,
            RegistDate = new DateTime(2023, 3, 1, 2, 24, 37)

        },
        new ()
        {
            Id = 65,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/60.jpg",
            Position = @"down",
            Name = @"Keira Walker",
            AthleteNumber = 34116,
            RegistDate = new DateTime(2023, 3, 1, 2, 24, 59)

        },
        new ()
        {
            Id = 197,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/93.jpg",
            Position = @"current",
            Name = @"Brent Lord",
            AthleteNumber = 20943,
            RegistDate = new DateTime(2023, 3, 1, 2, 26, 02)

        }}); ;
        }
    }
}