namespace Minesweeper
{
    public interface IView
    {
        int FieldWidth { get; set; }

        int FieldHeight { get; set; }

        int MinesCount { get; set; }

        int NotFoundMinesCount { get; set; }

        void NewGame();

        void PutImageToCell(int x, int y);

        void CreateField();

        void ClearField();

        void ResetTimer();

        int EndGame();
    }
}
