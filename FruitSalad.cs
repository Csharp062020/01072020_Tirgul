namespace _01072020_Tirgul
{
    class FruitSalad
    {
        public Fruit[] _fruits;

        public int GetTotalCalories()
        {
            int sum = 0;
            for (int i = 0; i < _fruits.Length; i++)
            {
                sum += _fruits[i]._calories;
            }
            return sum;
        }

        public bool ContainsMyFavoriteFruit()
        {

            for (int i = 0; i < _fruits.Length; i++)
            {
                if (_fruits[i].IsThisMyFavorite())
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            string fruitsNames = "";
            for (int i = 0; i < _fruits.Length; i++)
            {
                fruitsNames = $"{fruitsNames}, {_fruits[i]._name}";
            }
            return $"{base.ToString()} fruit in salad:{fruitsNames}";
        }
    }
}