using System;

public class Ejercicio_2
{
    public enum Color
    {
        red,
        green,
        blue
    }

    public interface IShape
    {
        Color Color { get; set; }
        void Draw(Action<String> action);
    }

    public class Figura : IShape
    {
        public Color Color { get; set; }
        public virtual void Draw(Action<String> action) { }
    }

    public class Arrow : Figura
    {

        public Arrow(Color color)
        {
            Color = color;
        }
        public override void Draw(Action<String> refe)
        {
            refe.Invoke(String.Format("El tipo de forma es {0} y el color es {1}", GetType().Name, this.Color));
        }
    }
    public class Rectangle : Figura
    {
        public Rectable(Color color)
        {
            Color = color;
        }
        public override void Draw(Action<String> refe)
        {
            refe.Invoke(String.Format("El tipo de forma es {0} y el color es {1}", GetType().Name, this.Color));
        }
    }

    public class Circle : Figura
    {
        public Circle(Color color)
        {
            Color = color;
        }
        public override void Draw(Action<String> refe)
        {
            refe.Invoke(String.Format("El tipo de forma es {0} y el color es {1}", GetType().Name, this.Color));
        }
    }

    
}
