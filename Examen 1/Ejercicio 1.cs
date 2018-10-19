using System;

public class Ejercicio_1
{
    class Exámen_1__ejercicio_1 : Foo
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name == value)
                {

                }
            }
        }
    }
    public abstract class Foo
    {
        public string Name { get; set; }
    }
}
