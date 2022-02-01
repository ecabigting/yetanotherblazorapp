
using System.Globalization;
using System.Text;

namespace YetAnotherBlazorApp.Pages 
{
    public partial class StringManipulator
    {
        public string TextareaToConvert { get; set; }
        public void FirstLetterCaps()
        {
            if(!String.IsNullOrEmpty(TextareaToConvert))
            {
                TextareaToConvert = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TextareaToConvert.ToLower()); 
            }
        }

        public void AllSmallCaps()
        {
            if(!String.IsNullOrEmpty(TextareaToConvert))
            {                
                TextareaToConvert = TextareaToConvert.ToLower();
            }
        }

        public void ToUpperCaps()
        {
            if(!String.IsNullOrEmpty(TextareaToConvert))
            {
                TextareaToConvert = TextareaToConvert.ToUpper();
            }
        }

        public void ReplaceSpaceWithHypen()
        {
            if(!String.IsNullOrEmpty(TextareaToConvert))
            { 
                TextareaToConvert = TextareaToConvert.Replace(' ','-');
            }
        }

        public void ReplaceReplaceHypenWithSpace()
        {
            if(!String.IsNullOrEmpty(TextareaToConvert))
            { 
                TextareaToConvert = TextareaToConvert.Replace('-',' ');
            }
        }

        public void ToAlterNateCase()
        {
            if(!String.IsNullOrEmpty(TextareaToConvert))
            { 
                TextareaToConvert = new string(TextareaToConvert.Select((c, i) => i % 2 == 0 ? char.ToUpper(c) : c).ToArray());
            }
        }

        public void ClearText()
        {
            TextareaToConvert = "";
        }
    }
}