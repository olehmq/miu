using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class CharacterBuilder
    {
        private Сharacter _character;

        public CharacterBuilder()
        {
            _character = new Сharacter();
        }

        public void SetColor(string color)
        {
            _character.Color = color;
        }

        public void SetSize(string size)
        {
            _character.Size = size;
        }

        public void SetType(string type)
        {
            _character.Type = type;
        }

        public Сharacter GetCharacter()
        {
            return _character;
        }
    }
}
