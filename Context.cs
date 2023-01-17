namespace BehaviourPattern
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void DoWork()
        {
            Console.WriteLine("\nDoing the work based on the strategy type: " + this._strategy.GetType().ToString());
            var result = this._strategy.DoWork(new List<string>{"a", "b", "c", "d", "e"});

            foreach(var res in result as List<string>)
            {
                Console.Write(res + " ");
            }
        }
    }
}