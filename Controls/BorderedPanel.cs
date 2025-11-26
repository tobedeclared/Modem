using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;  // Для атрибутов

namespace Modem.Controls
{
    public enum BorderSide
    {
        None,
        Top,
        Bottom,
        Left,
        Right
    }

    [ToolboxItem(true)]  // Делаем видимым в Toolbox
    public class BorderedPanel : Panel
    {
        private int _borderWidth = 1;
        private Color _borderColor = Color.Black;
        private BorderSide _borderSide = BorderSide.Right;

        public BorderedPanel()
        {
            // Включаем автоматическую перерисовку при изменении размеров
            this.ResizeRedraw = true;
            this.Padding = new Padding(0, 0, BorderWidth, 0); // Учитываем ширину границы
        }

        [Category("Appearance"), Description("Толщина границы")]
        public int BorderWidth
        {
            get => _borderWidth;
            set
            {
                if (value < 0) value = 0;
                _borderWidth = value;
                this.Invalidate();
            }
        }

        [Category("Appearance"), Description("Цвет границы")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Appearance"), Description("Сторона границы")]
        public BorderSide BorderSide
        {
            get => _borderSide;
            set
            {
                _borderSide = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(_borderColor, _borderWidth))
            {
                Rectangle rect = ClientRectangle;

                switch (_borderSide)
                {
                    case BorderSide.Right:
                        // Сдвигаем линию внутрь
                        rect.Width -= _borderWidth;
                        e.Graphics.DrawLine(pen,
                            rect.Right, rect.Top,
                            rect.Right, rect.Bottom);
                        break;

                    case BorderSide.Left:
                        e.Graphics.DrawLine(pen,
                            rect.Left, rect.Top,
                            rect.Left, rect.Bottom);
                        break;

                    case BorderSide.Top:
                        e.Graphics.DrawLine(pen,
                            rect.Left, rect.Top,
                            rect.Right, rect.Top);
                        break;

                    case BorderSide.Bottom:
                        e.Graphics.DrawLine(pen,
                            rect.Left, rect.Bottom,
                            rect.Right, rect.Bottom);
                        break;
                }
            }
        }
    }
}