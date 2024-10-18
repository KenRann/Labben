namespace Labben
{
    public class GeneratedInfo
    {

        List<GenPersonCompany> genPCompany = new List<GenPersonCompany>();
        List<GenPersonPInfo> genPInfo = new List<GenPersonPInfo>();
        List<GenPersonResidence> genPResidence = new List<GenPersonResidence>();

        GenPersonCompany generatedPersonCompany;
        GenPersonPInfo generatedPersonInfo;
        GenPersonResidence generatedPersonResidence;
 

        List<GeneratedInfo> list = new List<GeneratedInfo>();

        public GeneratedInfo(GenPersonPInfo genPersonalInfo, GenPersonCompany genCompany, GenPersonResidence genResidence )
        {
            
        }
        public GeneratedInfo()
        {
            
        }

        public List<GeneratedInfo> CombinedLists()
        {

            list.Add(
                new GeneratedInfo ( 
                    new GenPersonPInfo (2005 - 05 - 05 - 8901, "Emma Lindström", "emma.lindstrom@Gmail.com" ),
                    new GenPersonCompany ("Blomsterdesign AB", "Skapa ditt drömrum med naturens skönhet."),
                    new GenPersonResidence ("Månskenstorget 3", "Stockholm", 18429)
                    )
                );

            return list;
        }

        //public List<GeneratedInfo> CombinedListOfUsers()
        //{
            
        //    return list;
        //}

    }
}
