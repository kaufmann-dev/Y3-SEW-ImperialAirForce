namespace royalairforce
{
    public abstract class Command
    {
        public Command() {
        }


        public void Move(Point end)
        {
            throw new System.NotImplementedException();
        }

        public bool IsSpin()
        {
            throw new System.NotImplementedException();
        }
    }
}