
namespace MyStackApp
{
    public class MyStack
    {
        public bool IsEmpty()
        {
            return Items.Count == 0;
        }

        public List<int> Items { get; set; } = new();

        public void Push(int v)
        {
            Items.Add(v);
        }

        public object? Size()
        {
            return Items.Count;
        }

        public int Pop()
        {

           var item =  Items.Last();
           Items.Remove(item);
           return item;
        }

        #region Extra
        /*public void DoSomething()
        {
            Console.WriteLine("Test Started");

        }*/
        #endregion
    }
}
