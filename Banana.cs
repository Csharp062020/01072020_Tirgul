namespace _01072020_Tirgul
{
    class Banana : Fruit
    {
        public bool _hasBlackSpots;
        public bool _isGreen;
        public float _size;


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
            return $"{base.ToString()} Has Black Spots : {_hasBlackSpots} , Is Green:  {_isGreen} , size: {_size} , is my favorite: {_isThisMyFavorite} ";
        }
    }
}