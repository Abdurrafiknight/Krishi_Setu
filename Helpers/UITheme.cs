using System.Drawing;
using System.Windows.Forms;

namespace KrishiSetuPro.Helpers
{
    /// <summary>
    /// Central place for the app's modern color palette and reusable styling helpers,
    /// so every form looks consistent instead of using default WinForms styling.
    /// </summary>
    public static class UITheme
    {
        // Palette
        public static readonly Color Primary = Color.FromArgb(21, 128, 89);      // deep green
        public static readonly Color PrimaryDark = Color.FromArgb(14, 92, 64);   // hover/darker green
        public static readonly Color Accent = Color.FromArgb(255, 159, 28);      // amber accent
        public static readonly Color Sidebar = Color.FromArgb(24, 35, 30);       // near-black green sidebar
        public static readonly Color SidebarHover = Color.FromArgb(37, 53, 46);
        public static readonly Color PageBackground = Color.FromArgb(244, 246, 245);
        public static readonly Color CardBackground = Color.White;
        public static readonly Color BorderLight = Color.FromArgb(226, 230, 228);
        public static readonly Color TextDark = Color.FromArgb(33, 41, 38);
        public static readonly Color TextMuted = Color.FromArgb(120, 130, 126);
        public static readonly Color Danger = Color.FromArgb(214, 69, 65);
        public static readonly Color Success = Color.FromArgb(34, 139, 84);

        // Fonts
        public static Font FontTitle => new Font("Segoe UI", 20F, FontStyle.Bold);
        public static Font FontHeading => new Font("Segoe UI", 13F, FontStyle.Bold);
        public static Font FontSubheading => new Font("Segoe UI", 10.5F, FontStyle.Bold);
        public static Font FontBody => new Font("Segoe UI", 9.5F, FontStyle.Regular);
        public static Font FontSmall => new Font("Segoe UI", 8.5F, FontStyle.Regular);
        public static Font FontNav => new Font("Segoe UI", 10.5F, FontStyle.Regular);
        public static Font FontStat => new Font("Segoe UI", 18F, FontStyle.Bold);

        /// <summary>Applies flat, borderless, primary-colored styling to a button.</summary>
        public static void StylePrimaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = PrimaryDark;
            btn.BackColor = Primary;
            btn.ForeColor = Color.White;
            btn.Font = FontSubheading;
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
        }

        /// <summary>Applies flat, outlined "secondary" styling to a button.</summary>
        public static void StyleSecondaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = BorderLight;
            btn.FlatAppearance.MouseOverBackColor = PageBackground;
            btn.BackColor = Color.White;
            btn.ForeColor = TextDark;
            btn.Font = FontBody;
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
        }

        /// <summary>Applies flat, danger-colored (red text) styling to a button.</summary>
        public static void StyleDangerButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Danger;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 235, 234);
            btn.BackColor = Color.White;
            btn.ForeColor = Danger;
            btn.Font = FontBody;
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
        }

        /// <summary>Applies a clean, modern look to a DataGridView (no default gray gridlines/header).</summary>
        public static void StyleGrid(DataGridView grid)
        {
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Color.White;
            grid.GridColor = BorderLight;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.RowHeadersVisible = false;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 38;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Sidebar;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = FontSubheading;
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 240, 233);
            grid.DefaultCellStyle.SelectionForeColor = TextDark;
            grid.DefaultCellStyle.Font = FontBody;
            grid.DefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 249);
            grid.RowTemplate.Height = 32;
            grid.AllowUserToResizeRows = false;
        }
    }
}
