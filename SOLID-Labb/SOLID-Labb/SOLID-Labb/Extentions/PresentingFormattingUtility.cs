using SOLID_Labb.interfaces;

namespace SOLID_Labb.Extentions
{
    public static class PresentingFormattingUtility
    {
        public static void WriteSeparator(this IPresenting display)
        {
            display.DisplayOnLine("############### \n");
        }
    }
}