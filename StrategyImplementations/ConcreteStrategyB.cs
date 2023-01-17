namespace BehaviourPattern
{
    public class ConcreteStrategyB : IStrategy
    {
        public object DoWork(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();
            return list;
        }
    }
}