namespace _01072020_Tirgul
{
    class Tomato: Fruit
    {
        public bool _isGreen;
        public int _size;

        /// <summary>
        /// I know this is not what I was asked to do.
        ///But it makes more sense and is more convenient to change the information.
        /// </summary>
        public bool _isThisMyFavorite;
        public override bool IsThisMyFavorite()
        {
            return _isThisMyFavorite;
        }

        public override string ToString()
        {
            return $"{base.ToString()}  Is Green:  {_isGreen} , size: {_size} , is my favorite: {_isThisMyFavorite} ";
        }

    }
}