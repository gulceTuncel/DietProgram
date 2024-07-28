
namespace EFDiyetProgramiProje.UI.ControlClass
{
    public class MultiColoredProgressBar : ProgressBar
    {
        public Color[] Colors { get; set; } = { Color.FromArgb(173, 216, 230), Color.FromArgb(152, 251, 152), Color.FromArgb(255, 182, 193), Color.FromArgb(253, 253, 150) };
        public float[] Ratios { get; set; } = { 0.25f, 0.25f, 0.25f, 0.25f };
        public string[] Labels { get; set; } = { "Yemek1", "Yemek2", "Yemek3", "Diğerleri" };

        public MultiColoredProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;
            Graphics g = e.Graphics;

            // Arka planı çiz
            using (SolidBrush brush = new SolidBrush(SystemColors.Control))
            {
                g.FillRectangle(brush, rect);
            }

            rect.Inflate(-2, -2);

            if (this.Value > 0)
            {
                int totalWidth = rect.Width;
                float accumulatedRatio = 0;

                bool allEmpty = true;
                foreach (var ratio in Ratios)
                {
                    if (ratio > 0)
                    {
                        allEmpty = false;
                        break;
                    }
                }

                if (allEmpty)
                {
                    using (SolidBrush brush = new SolidBrush(Colors[0]))
                    {
                        g.FillRectangle(brush, rect);

                        using (SolidBrush textBrush = new SolidBrush(Color.Black))
                        {
                            StringFormat stringFormat = new StringFormat
                            {
                                Alignment = StringAlignment.Center,
                                LineAlignment = StringAlignment.Center
                            };
                            g.DrawString("Kayıt bulunamadı", this.Font, textBrush, rect, stringFormat);
                        }
                    }
                    return;
                }

                for (int i = 0; i < Colors.Length; i++)
                {
                    int sectionWidth = (int)(totalWidth * Ratios[i]);
                    Rectangle sectionRect = new Rectangle(rect.X + (int)(totalWidth * accumulatedRatio), rect.Y, sectionWidth, rect.Height);
                    accumulatedRatio += Ratios[i];

                    float remainingRatio = (float)this.Value / this.Maximum - accumulatedRatio + Ratios[i];
                    if (remainingRatio > 0 && remainingRatio < Ratios[i])
                    {
                        sectionRect.Width = (int)(totalWidth * remainingRatio);
                    }

                    using (SolidBrush brush = new SolidBrush(Colors[i]))
                    {
                        g.FillRectangle(brush, sectionRect);
                    }

                    // Metni ekleyin
                    if (!string.IsNullOrEmpty(Labels[i]))
                    {
                        using (SolidBrush textBrush = new SolidBrush(Color.Black))
                        {
                            StringFormat stringFormat = new StringFormat
                            {
                                Alignment = StringAlignment.Center,
                                LineAlignment = StringAlignment.Center
                            };
                            g.DrawString(Labels[i], this.Font, textBrush, sectionRect, stringFormat);
                        }
                    }
                }
            }
        }
    }
}
