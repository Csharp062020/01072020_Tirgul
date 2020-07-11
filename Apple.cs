namespace _01072020_Tirgul
{
    class Apple :Fruit
    {
        public string _color;
        public bool _pinkLady;

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
            return $"{base.ToString()} , color : {_color}, pinkLady: {_pinkLady} , is my favorite: {_isThisMyFavorite}";
        }
    }
}