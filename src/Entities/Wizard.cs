

namespace jogoRPG.src.Entities
{
    public class Wizard : Hero
    
    {
        public Wizard(string Name, int Level, string heroType)
        {
           this.Name = Name;
           this.Level = Level;
           this.heroType = heroType;
        }
        
            
        
        public override string Attack(){
            return this.Name + "Lancou magia";

        }

        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Name + "Lançou Magia super efetiva com bonus de " + Bonus;

            }else{
                 return this.Name + "Lançou Magia com força fraca com bonus de " + Bonus;


            }
        }
    }
}