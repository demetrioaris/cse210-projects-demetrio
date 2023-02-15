using System.Text;


public class Reference 
{
    private List<Scripture> scriptures;

    public Reference()
    { // Set the scriptures
        scriptures = new List<Scripture>
        {
            new Scripture("1 Nephi", 3, new List<Verse>
            {
                new Verse(7, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            }),
            new Scripture("Jacob", 2, new List<Verse>
            {
                new Verse(18, "But before ye seek for riches, seek ye for the kingdom of God."),
                new Verse(19, "And after ye have obtained a hope in Christ ye shall obtain riches, if ye seek them; and ye will seek them for the intent to do good—to clothe the naked, and to feed the hungry, and to liberate the captive, and administer relief to the sick and the afflicted.")
            }),
            new Scripture("Alma", 34, new List<Verse>
            {
                new Verse(33, "For behold, this life is the time for men to prepare to meet God; yea, behold the day of this life is the day for men to perform their labors."),
                new Verse(34, "And now, as I said unto you before, as ye have had so many witnesses, therefore, I beseech of you that ye do not procrastinate the day of your repentance until the end; for after this day of life, which is given us to prepare for eternity, behold, if we do not improve our time while in this life, then cometh the night of darkness wherein there can be no labor performed."),
                new Verse(35, "Ye cannot say, when ye are brought to that awful crisis, that I will repent, that I will return to my God. Nay, ye cannot say this; for that same spirit which doth possess your bodies at the time that ye go out of this life, that same spirit will have power to possess your body in that eternal world."),
            }),
        };
    }

    public List<Scripture> GetScriptures()
    {
        return scriptures;
    }
    
    public void DisplayScriptures()
    {// return a list with scriptures
     // 1) scripture...
     // 2) scripture...
        for (int i = 0; i < scriptures.Count; i++)
        {
            Scripture scripture = scriptures[i];
            string referenceString = scripture.GetReference();
            Console.WriteLine($"{i+1}) {referenceString}");
        }
    }
}
