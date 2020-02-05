using System.Threading.Tasks;

namespace MvcCharacter.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Hp { get; set; }
        public int Damage { get; set; }
    }
}
