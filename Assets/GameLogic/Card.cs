using System;

namespace GameLogic
{
    public class Card
    {
        private PassiveSkill _passive;
        private ActiveSkill _active;

        private int _durability;
        private bool _folded;
        private bool _flipped;
        private bool _broken;

        public int Durability
        {
            get => _durability;
            private set
            {
                _durability = value;
                if (_durability <= 0)
                    _broken = true;
            }
        }

        //private CardPlace _place;

        public Card(int durability)
        {
            _durability = durability;
        }

        public Card Fold()
        {
            if (_folded)
                return this;
            var card = Copy(this);
            card.Durability -= 1;
            card._folded = true;
            return card;
        }

        public Card Tear()
        {
            var card = Copy(this);
            card._broken = true;
            return card;
        }

        private static Card Copy(Card source)
            => new Card(source._durability)
            {
                _active = source._active,
                _passive = source._passive,
                _flipped = source._flipped,
                _folded = source._folded,
                _broken = source._broken,
                //_place = source._place
            };

        public static Card Stitch(PassiveSkill passive, ActiveSkill active, int durability)
            => new Card(durability)
            {
                _passive = passive, 
                _active = active
            };
    }
}