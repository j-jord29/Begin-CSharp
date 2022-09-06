using SnapsLibrary;

public class Draw
{
    private int dragging;

    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Drawing");

        Colour pink = new Colour(red: 255, blue: 203, green: 192);

        PenModes penType;

        penType = PenModes.SquarePen;
        /*
        switch (penType)
        {
            case PenModes.RoundPen:
                SnapsEngine.SetDrawingColor(green, 255);
                SnapsEngine.DrawDot(dragging, 20);
                break;

            case PenModes.SquarePen:
                SnapsEngine.SetDrawingColor(green, 255);
                SnapsEngine.DrawDot(dragging, 20);
                break;

            case PenModes.ErasePen:
                SnapsEngine.SetDrawingColor(green, 255);
                SnapsEngine.DrawDot(dragging, 20);
                break;
        }
        */


        while (true)
        {
            SnapsCoordinate dragged = SnapsEngine.GetDraggedCoordinate();
            SnapsEngine.DrawDot(pos: dragged, width: 10);
            if (dragged.XValue < 10 && dragged.YValue < 10)
            {
                SnapsEngine.ClearGraphics();
            }
            else
            {
                SnapsEngine.DrawDot(pos: dragged, width: 20);
            }
        }        
    }

    public struct Colour
    {
        public byte RedValue;
        public byte BlueValue;
        public byte GreenValue;

        public Colour(byte red, byte blue, byte green)
        {
            RedValue = red;
            BlueValue = blue;
            GreenValue = green;
        }
    }

    enum PenModes
    {
        RoundPen,
        SquarePen,
        ErasePen
    }

        
}


