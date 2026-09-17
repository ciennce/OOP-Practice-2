using OOP_Practice_2___Bibliothek.Library;

namespace OOP_Practice_2___Bibliothek.Gui
{
    class GUI
    {
        public LendResult ReadInt(string prompt)
        {
            bool hasWhiteSpace = prompt.Any(char.IsWhiteSpace);
            bool isValid = !hasWhiteSpace && uint.TryParse(prompt, out _);

            if (!isValid) return LendResult.Invalid;
            return LendResult.Ok;
        }
    }
}
