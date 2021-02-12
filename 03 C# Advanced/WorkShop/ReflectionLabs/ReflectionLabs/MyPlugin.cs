namespace ReflectionLabs
{
    public class MyPlugin : IPlugin
    {
        private int _value = 10;

        public void Do()
        {

        }
        public string Name
        {
            get { return "MyPlugin"; }
        }
        public string Description
        {
            get { return "My Sample Plugin"; }
        }
    }
}
