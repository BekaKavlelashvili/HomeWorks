namespace homework10
{
    public class Fileworker2 : Fileworker
    {
        public override string Delete()
        {
            return $"I can delete to {Expansion} file with max storage {MaxSize} ."; ;
        }
        public override string Edit()
        {
                return  $"I can edit to {Expansion} file with max storage {MaxSize} .";
        }
        public override string Read()
        {
           return  $"I can read to {Expansion} file with max storage {MaxSize} .";
        }
        public override string Write()
        {
            return $"I can write to {Expansion} file with max storage {MaxSize} .";
        } 
    }
}
