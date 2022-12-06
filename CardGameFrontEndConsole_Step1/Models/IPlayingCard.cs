using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameFrontEndConsole.Models
{
    
    public enum PlayingCardColor
    {
        Clubs = 0, Diamonds, Hearts, Spades         
    }

    
    public enum PlayingCardValue
    {
        Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        Knight, Queen, King, Ace                
    }

    interface IPlayingCard
    {
        
        public PlayingCardColor Color { get; init; }

        
        public PlayingCardValue Value { get; init; }

        
        public string ToString();
    }
}
