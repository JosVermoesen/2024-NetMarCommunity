namespace NetMar
{
    public static class Globals
    {
        // parameterless constructor required for static class
        static Globals()
        {
            Int = 1234;             // variable Int is an int !
            MimTitle = "Geen bedrijf actief";    // variable String is a string !
        } // default value

        // public get, and private set for strict access control
        public static int Int { get; private set; }

        // GlobalInt can be changed only via this method
        public static void SetInt(int newInt)
        {
            Int = newInt;
        }
                
        public static string MimTitle { get; private set; }
        public static void SetMimTitle(string newString)
        {
            MimTitle = newString;
        }
    }
}
