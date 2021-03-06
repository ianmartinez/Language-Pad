﻿using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LangPadUI.Theming
{
    /// <summary>
    /// Render a tool strip based on a theme.
    /// </summary>
    public class ThemeToolStripRenderer : ToolStripSystemRenderer
    {
        private readonly Theme theme;

        public ThemeToolStripRenderer(Theme theme) : base()
        {
            this.theme = theme;
        }

        protected override void InitializeItem(ToolStripItem item)
        {
            base.InitializeItem(item);
            item.ForeColor = theme.ToolStripTextColor;
        }

        protected override void Initialize(ToolStrip toolStrip)
        {
            base.Initialize(toolStrip);
            toolStrip.ForeColor = theme.ToolStripTextColor;
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            //base.OnRenderSeparator(e);
            if (e.ToolStrip.Orientation == Orientation.Vertical)
            {
                Rectangle separatorRect = new Rectangle(2, 3, e.Item.Width - 4, 1);
                Rectangle shadowRect = new Rectangle(3, 4, e.Item.Width - 5, 1);
                e.Graphics.FillRectangle(new SolidBrush(theme.ToolStripSeparatorColor), separatorRect);
                e.Graphics.FillRectangle(new SolidBrush(theme.ToolStripSeparatorShadowColor), shadowRect);
            }
            else
            {
                Rectangle separatorRect = new Rectangle(3, 5, 1, e.Item.Height - 10);
                Rectangle shadowRect = new Rectangle(4, 6, 1, e.Item.Height - 10);
                e.Graphics.FillRectangle(new SolidBrush(theme.ToolStripSeparatorColor), separatorRect);
                e.Graphics.FillRectangle(new SolidBrush(theme.ToolStripSeparatorShadowColor), shadowRect);
            }
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBorder(e)
            Pen shadow = new Pen(theme.ToolStripBorderColor);
            Rectangle rect = new Rectangle(e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width - 1, e.AffectedBounds.Height-1);
            e.Graphics.DrawRectangle(shadow, rect);
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBackground(e);
            var gradientMode = theme.HasVerticalToolbarGradient ? LinearGradientMode.Vertical : LinearGradientMode.Horizontal;
            if (e.ToolStrip.Orientation == Orientation.Vertical) // Flip if other orientation
                gradientMode = theme.HasVerticalToolbarGradient ? LinearGradientMode.Horizontal : LinearGradientMode.Vertical;

            LinearGradientBrush background = new LinearGradientBrush(e.AffectedBounds, theme.ToolStripBackColor1, theme.ToolStripBackColor2, gradientMode);
            SolidBrush shadow = new SolidBrush(theme.ToolStripInsetColor);
            Rectangle shadowRect = new Rectangle(0, e.ToolStrip.Height - 2, e.ToolStrip.Width, 1);
            Rectangle rect = new Rectangle(e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width + 1, e.AffectedBounds.Height + 1);
            e.Graphics.FillRectangle(background, rect);
            e.Graphics.FillRectangle(shadow, shadowRect);
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            //base.OnRenderButtonBackground(e);
            Rectangle rectBorder = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2);
            Rectangle rect = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2);

            if (e.Item.Selected || ((ToolStripButton)e.Item).Checked)
            {
                LinearGradientBrush background = new LinearGradientBrush(rect, theme.ToolStripButtonSelectedColor1, theme.ToolStripButtonSelectedColor2, LinearGradientMode.Vertical);
                Pen border = new Pen(theme.ToolStripButtonSelectedBorderColor);
                e.Graphics.FillRectangle(background, rect);
                e.Graphics.DrawRectangle(border, rectBorder);
            }
            if (e.Item.Pressed)
            {
                LinearGradientBrush background = new LinearGradientBrush(rect, theme.ToolStripButtonPressedColor1, theme.ToolStripButtonPressedColor2, LinearGradientMode.Vertical);
                Pen border = new Pen(theme.ToolStripButtonPressedBorderColor);
                e.Graphics.FillRectangle(background, rect);
                e.Graphics.DrawRectangle(border, rectBorder);
            }
        }
    }
}
