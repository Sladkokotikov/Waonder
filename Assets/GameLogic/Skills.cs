using System;

namespace GameLogic
{
    public class Skill
    {
        public string Name { get;}
        public int ID { get; }
        public Card Whole;

        // TODO: сделать ExpressionBuilder.
        public static TSkill Parse<TSkill>(string ourLanguageExpression) where TSkill: Skill, new()
        {
            return new TSkill();
        }
    }

    public class PassiveSkill: Skill
    {
        
    }
    public class ActiveSkill: Skill
    {
        
    }
}