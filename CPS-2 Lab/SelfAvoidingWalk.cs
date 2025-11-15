using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

public class SelfAvoidingWalk
{
    private int size;       // Grid size
    private int steps;      // Total steps
    private int cellSize;   // Size of each cell in pixels
    private Random rnd;
    private int xOffset = 250; // X starting offset
    private int yOffset = 450; // Y starting offset

    public SelfAvoidingWalk(int gridSize = 100, int totalSteps = 300, int cellPixelSize = 15)
    {
        size = gridSize;
        steps = totalSteps;
        cellSize = cellPixelSize;
        rnd = new Random();
    }

    // Start the simulation using Graphics from main form
    public async void Start(Graphics gg)
    {
        if (gg == null) return;

        // Clear previous drawing
        gg.Clear(Color.White);

        int[,] plan = new int[size, size];
        int x = 7, y = 7; // starting point
        plan[x, y] = 1;

        List<Point> vs = new List<Point>();
        int index = 0;

        Point prevPoint = new Point(xOffset + x * cellSize, yOffset - y * cellSize);

        for (int i = 0; i < steps; i++)
        {
            double r = rnd.NextDouble();
            int oldX = x, oldY = y;

            // Movement using else-if chain
            if (r < 0.25 && x < size - 1 && plan[x + 1, y] == 0) x++;
            else if (r >= 0.25 && r < 0.5 && x > 0 && plan[x - 1, y] == 0) x--;
            else if (r >= 0.5 && r < 0.75 && y < size - 1 && plan[x, y + 1] == 0) y++;
            else if (r >= 0.75 && y > 0 && plan[x, y - 1] == 0) y--;

            plan[x, y] = 1;
            vs.Add(new Point(x, y));
            index++;

            Point currentPoint = new Point(xOffset + x * cellSize, yOffset - y * cellSize);

            // Draw step with gradient and connecting line
            DrawStep(gg, prevPoint, currentPoint, i);
            prevPoint = currentPoint;

            // Bounds-safe dead-end check
            bool rightBlocked = (x == size - 1) || (plan[x + 1, y] == 1);
            bool leftBlocked = (x == 0) || (plan[x - 1, y] == 1);
            bool upBlocked = (y == size - 1) || (plan[x, y + 1] == 1);
            bool downBlocked = (y == 0) || (plan[x, y - 1] == 1);

            if (rightBlocked && leftBlocked && upBlocked && downBlocked && index > 1)
            {
                index = Math.Max(1, index); // prevent negative index
                x = vs[index - 2].X;
                y = vs[index - 2].Y;
                index--;
            }

            await Task.Delay(100); // smooth animation
        }
    }

    // Draw a single step with color gradient and line connecting previous point
    private void DrawStep(Graphics gg, Point prev, Point current, int stepIndex)
    {
        // Clamp colors between 0-255
        int r = Math.Max(0, Math.Min(255, (stepIndex * 5) % 256));
        int g = Math.Max(0, Math.Min(255, 255 - stepIndex * 3));
        int b = Math.Max(0, Math.Min(255, (stepIndex * 7) % 256));

        using (Pen pen = new Pen(Color.FromArgb(r, g, b), 2))
        using (SolidBrush sb = new SolidBrush(Color.FromArgb(r, g, b)))
        {
            // Draw connecting line
            gg.DrawLine(pen, prev, current);

            // Draw dot safely
            int size = 5 + (stepIndex % 3);
            int drawX = Math.Max(0, current.X - size / 2);
            int drawY = Math.Max(0, current.Y - size / 2);
            gg.FillEllipse(sb, drawX, drawY, size, size);
        }
    }

}
