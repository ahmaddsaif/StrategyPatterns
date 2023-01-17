namespace BehaviourPattern
{
    public class ConcreteStrategyA : IStrategy
    {
        public object DoWork(object data)
        {
            var list = data as List<string>;
            list.Sort();
            return list;
        }
    }
}