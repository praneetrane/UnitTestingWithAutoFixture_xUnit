using System.ComponentModel.DataAnnotations;

namespace LearnAutoFixture
{
    public class PlayerCharacter
    {
        [StringLength(4)]
        public string RealName { get; set; }
        [StringLength(8)]
        public string GameCharacterName { get; set; }

        public int CurrentHealth { get; set; }
    }


}
