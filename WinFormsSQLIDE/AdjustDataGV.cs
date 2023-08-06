using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSQLIDE
{
    internal class AdjustDataGV
    {
        public static void AdjustDataGridViewSize(DataGridView dgv)
        {
            // Wysokość nagłówka
            int headerHeight = dgv.ColumnHeadersHeight;

            // Wysokość komórek
            int cellHeight = dgv.RowTemplate.Height;

            // Liczba komórek
            int cellCount = dgv.RowCount;

            // Obliczanie nowej wysokości
            int newHeight = headerHeight + (cellHeight * cellCount);

            // Ustawianie nowej wysokości
            dgv.Height = newHeight;

            // Ustawienie szerokości DGV na sumę szerokości wszystkich kolumn
            int totalWidth = 0;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                totalWidth += column.Width;
            }
            dgv.Width = totalWidth;
        }
        public static void AdjustCellColors(DataGridView dgv,Color color)
        {
           dgv.BackgroundColor = color;
        }
    }
}
