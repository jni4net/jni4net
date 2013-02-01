/*
wf4j (WinForms for Java) is a library that allows to provide interop betwean WinForms and Java windows
Copyright (C) 2009-2013 Daniel Leping

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA

If you have any questions contact me by e-mail: dileping@gmail.com
*/
package poc;

import system.drawing.*;

import java.awt.*;
import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Rectangle;
import java.awt.font.FontRenderContext;
import java.awt.font.GlyphVector;
import java.awt.geom.AffineTransform;
import java.awt.image.BufferedImage;
import java.awt.image.BufferedImageOp;
import java.awt.image.ImageObserver;
import java.awt.image.RenderedImage;
import java.awt.image.renderable.RenderableImage;
import java.text.AttributedCharacterIterator;
import java.util.Map;

/**
 * Created by Daniel Leping.
 * Date: Feb 20, 2010
 * Time: 8:44:41 PM
 */
public class GraphicsNET { /* extends Graphics2D {
    private system.drawing.Graphics graphics;

    public GraphicsNET(system.drawing.Graphics graphics) {
        this.graphics = graphics;
    }

    @Override
    public void draw(Shape s) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public boolean drawImage(Image img, AffineTransform xform, ImageObserver obs) {
        return false;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void drawImage(BufferedImage img, BufferedImageOp op, int x, int y) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void drawRenderedImage(RenderedImage img, AffineTransform xform) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void drawRenderableImage(RenderableImage img, AffineTransform xform) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void drawString(String str, int x, int y) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void drawString(String str, float x, float y) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void drawString(AttributedCharacterIterator iterator, int x, int y) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public boolean drawImage(Image img, int x, int y, ImageObserver observer) {
        return false;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public boolean drawImage(Image img, int x, int y, int width, int height, ImageObserver observer) {
        return false;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public boolean drawImage(Image img, int x, int y, Color bgcolor, ImageObserver observer) {
        return false;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public boolean drawImage(Image img, int x, int y, int width, int height, Color bgcolor, ImageObserver observer) {
        return false;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public boolean drawImage(Image img, int dx1, int dy1, int dx2, int dy2, int sx1, int sy1, int sx2, int sy2, ImageObserver observer) {
        return false;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public boolean drawImage(Image img, int dx1, int dy1, int dx2, int dy2, int sx1, int sy1, int sx2, int sy2, Color bgcolor, ImageObserver observer) {
        return false;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void dispose() {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void drawString(AttributedCharacterIterator iterator, float x, float y) {
        system.drawing.Font font = new system.drawing.Font(FontFamily.getGenericSansSerif(), 15);
        graphics.DrawString(iterator.toString(), font, Brushes.getCyan(), x, y );
    }

    @Override
    public void drawGlyphVector(GlyphVector g, float x, float y) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void fill(Shape s) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public boolean hit(Rectangle rect, Shape s, boolean onStroke) {
        return false;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public GraphicsConfiguration getDeviceConfiguration() {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void setComposite(Composite comp) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void setPaint(Paint paint) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void setStroke(Stroke s) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void setRenderingHint(RenderingHints.Key hintKey, Object hintValue) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public Object getRenderingHint(RenderingHints.Key hintKey) {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void setRenderingHints(Map<?, ?> hints) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void addRenderingHints(Map<?, ?> hints) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public RenderingHints getRenderingHints() {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public java.awt.Graphics create() {
        return this;
    }

    @Override
    public void translate(int x, int y) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public Color getColor() {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void setColor(Color c) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void setPaintMode() {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void setXORMode(Color c1) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public Font getFont() {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void setFont(Font font) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public FontMetrics getFontMetrics(Font f) {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public Rectangle getClipBounds() {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void clipRect(int x, int y, int width, int height) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void setClip(int x, int y, int width, int height) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public Shape getClip() {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void setClip(Shape clip) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void copyArea(int x, int y, int width, int height, int dx, int dy) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void drawLine(int x1, int y1, int x2, int y2) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void fillRect(int x, int y, int width, int height) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void clearRect(int x, int y, int width, int height) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void drawRoundRect(int x, int y, int width, int height, int arcWidth, int arcHeight) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void fillRoundRect(int x, int y, int width, int height, int arcWidth, int arcHeight) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void drawOval(int x, int y, int width, int height) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void fillOval(int x, int y, int width, int height) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void drawArc(int x, int y, int width, int height, int startAngle, int arcAngle) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void fillArc(int x, int y, int width, int height, int startAngle, int arcAngle) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void drawPolyline(int[] xPoints, int[] yPoints, int nPoints) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void drawPolygon(int[] xPoints, int[] yPoints, int nPoints) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void fillPolygon(int[] xPoints, int[] yPoints, int nPoints) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void translate(double tx, double ty) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void rotate(double theta) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void rotate(double theta, double x, double y) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void scale(double sx, double sy) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void shear(double shx, double shy) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void transform(AffineTransform Tx) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void setTransform(AffineTransform Tx) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public AffineTransform getTransform() {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public Paint getPaint() {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public Composite getComposite() {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void setBackground(Color color) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public Color getBackground() {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public Stroke getStroke() {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public void clip(Shape s) {
        //To change body of implemented methods use File | Settings | File Templates.
    }

    @Override
    public FontRenderContext getFontRenderContext() {
        return null;  //To change body of implemented methods use File | Settings | File Templates.
    } */
} 
