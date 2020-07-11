namespace _01072020_Tirgul
{
    abstract class Fruit
    {
        public string _name;
        public int _calories;

        public abstract bool IsThisMyFavorite();

        public override string ToString()
        {
            return $"{base.ToString()} {_name} {_calories}";
        }

    }
}