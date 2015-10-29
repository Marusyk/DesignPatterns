
namespace MusicNotes
{
    public class Position
    {
        /// <summary>
        /// Определяет позийию по оси х
        /// </summary>
        private int x;

        /// <summary>
        /// Определяет позицию по оси у
        /// </summary>
        private int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Определяет позицию по оси х
        /// </summary>
        public int X
        {
            get { return x; }
        }

        /// <summary>
        /// Определяет позицию по оси у
        /// </summary>
        public int Y
        {
            get { return y; }
        }

        /// <summary>
        /// Метод вычисления позиции ноты при удалении нот
        /// </summary>
        /// <param name="lastPosition">Позиция последней ноты</param>
        /// <returns>Position</returns>
        public static Position CalculateNotePositionOnDeletion(Position lastPosition)
        {
            if (lastPosition.X == 43)
            {
                return new Position(917, lastPosition.Y - 50);
            }

            return new Position(lastPosition.X - 23, lastPosition.Y);
        }

        /// <summary>
        /// Метод вычисления позиции стана при удалении нот 
        /// </summary>
        /// <param name="lastPosition">Позиция последней ноты</param>
        /// <returns>Position</returns>
        public static Position CalculateStaffPositionOnDeletion(Position lastPosition)
        {
            return new Position(lastPosition.X, lastPosition.Y-50);
        }

        /// <summary>
        ///  Метод вычисления позиции ноты при добавлении ноты
        /// </summary>
        /// <param name="lastPosition">Позиция последней ноты</param>
        /// <returns>Position</returns>
        public static Position CalculateNotePosition(Position lastPosition)
        {
            if (lastPosition.X >= 900)
            {
                return new Position(43, lastPosition.Y + 50);
            }

            return new Position(lastPosition.X + 23, lastPosition.Y);
        }

        /// <summary>
        ///  Метод вычисления позиции стана при добавлении ноты
        /// </summary>
        /// <param name="lastPosition">Позиция последней ноты</param>
        /// <returns>Position</returns>
        public static Position CalculateStaffPosition(Position lastPosition)
        {
            if (lastPosition.X >= 900)
            {
                return new Position(20, lastPosition.Y + 50);
            }

            return new Position(lastPosition.X + 23, lastPosition.Y);
        }
        
        /// <summary>
        /// Метод вычисления позиции паузы при добавлении ноты
        /// </summary>
        /// <param name="lastPosition">Позиция последней ноты</param>
        /// <returns>Position</returns>
        public static Position CalculatePausePosition(Position lastPosition)
        {
            if (lastPosition.X >= 900)
            {
                return new Position(20, lastPosition.Y + 30);
            }

            return new Position(lastPosition.X + 15, lastPosition.Y);
        }
    }
}