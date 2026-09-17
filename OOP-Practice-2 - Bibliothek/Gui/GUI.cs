using OOP_Practice_2___Bibliothek.Library;

namespace OOP_Practice_2___Bibliothek.Gui
{
    class GUI
    {
        public LendResult ReadInt(string prompt)
        {
            if (!int.TryParse(prompt, out var result)) return LendResult.Invalid;
            return LendResult.Ok;

        }
    }
}
