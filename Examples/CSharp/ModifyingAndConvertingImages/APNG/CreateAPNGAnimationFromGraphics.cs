//-----------------------------------------------------------------------------------------------------------
// <copyright file="CreateAPNGAnimationFromGraphics.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="20.06.2020 18:20:32">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Brushes;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Apng;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.APNG
{
    class CreateAPNGAnimationFromGraphics
    {
        public static void Run()
        {
            Console.WriteLine("Running example CreateAPNGAnimationFromGraphics");

            const int AnimationDuration = 1000; // 1 s

            string dataDir = RunExamples.GetDataDir_APNG();
            string fileName = "not_animated.png";
            string inputFilePath = Path.Combine(dataDir, fileName);
            string outputFilePath = Path.Combine(dataDir, "vector_animation.png");


            // Preparing the animation scene
            const int SceneWidth = 400;
            const int SceneHeigth = 400;
            const uint ActDuration = 1000; // Act duration, in milliseconds
            const uint TotalDuration = 4000; // Total duration, in milliseconds
            const uint FrameDuration = 50; // Frame duration, in milliseconds
            Scene scene = new Scene();

            Ellipse ellipse = new Ellipse
            {
                FillColor = Color.FromArgb(128, 128, 128),
                CenterPoint = new PointF(SceneWidth / 2f, SceneHeigth / 2f),
                RadiusX = 80,
                RadiusY = 80
            };
            scene.AddObject(ellipse);

            Line line = new Line
            {
                Color = Color.Blue,
                LineWidth = 10,
                StartPoint = new PointF(30, 30),
                EndPoint = new PointF(SceneWidth - 30, 30)
            };
            scene.AddObject(line);

            IAnimation lineAnimation1 = new LinearAnimation(
                                            delegate(float progress)
                                            {
                                                line.StartPoint = new PointF(
                                                    30 + (progress * (SceneWidth - 60)),
                                                    30 + (progress * (SceneHeigth - 60)));
                                                line.Color = Color.FromArgb(
                                                    (int)(progress * 255),
                                                    0,
                                                    255 - (int)(progress * 255));
                                            }) { Duration = ActDuration };
            IAnimation lineAnimation2 = new LinearAnimation(
                                            delegate(float progress)
                                            {
                                                line.EndPoint = new PointF(
                                                    SceneWidth - 30 - (progress * (SceneWidth - 60)),
                                                    30 + (progress * (SceneHeigth - 60)));
                                                line.Color = Color.FromArgb(
                                                    255,
                                                    (int)(progress * 255),
                                                    0);
                                            }) { Duration = ActDuration };
            IAnimation lineAnimation3 = new LinearAnimation(
                                            delegate(float progress)
                                            {
                                                line.StartPoint = new PointF(
                                                    SceneWidth - 30 - (progress * (SceneWidth - 60)),
                                                    SceneHeigth - 30 - (progress * (SceneHeigth - 60)));
                                                line.Color = Color.FromArgb(
                                                    255 - (int)(progress * 255),
                                                    255,
                                                    0);
                                            }) { Duration = ActDuration };
            IAnimation lineAnimation4 = new LinearAnimation(
                                            delegate(float progress)
                                            {
                                                line.EndPoint = new PointF(
                                                    30 + (progress * (SceneWidth - 60)),
                                                    SceneHeigth - 30 - (progress * (SceneHeigth - 60)));
                                                line.Color = Color.FromArgb(
                                                    0,
                                                    255 - (int)(progress * 255),
                                                    (int)(progress * 255));
                                            }) { Duration = ActDuration };
            IAnimation fullLineAnimation = new SequentialAnimation() { lineAnimation1, lineAnimation2, lineAnimation3, lineAnimation4 };
            IAnimation ellipseAnimation1 = new LinearAnimation(
                                               delegate(float progress)
                                               {
                                                   ellipse.RadiusX += progress * 10;
                                                   ellipse.RadiusY += progress * 10;
                                                   int compValue = (int)(128 + (progress * 112));
                                                   ellipse.FillColor = Color.FromArgb(
                                                       compValue,
                                                       compValue,
                                                       compValue);
                                               }) { Duration = ActDuration };
            IAnimation ellipseAnimation2 = new Delay() { Duration = ActDuration };
            IAnimation ellipseAnimation3 = new LinearAnimation(
                                               delegate(float progress)
                                               {
                                                   ellipse.RadiusX -= progress * 10;
                                                   int compValue = (int)(240 - (progress * 224));
                                                   ellipse.FillColor = Color.FromArgb(
                                                       compValue,
                                                       compValue,
                                                       compValue);
                                               }) { Duration = ActDuration };
            IAnimation ellipseAnimation4 = new LinearAnimation(
                                               delegate(float progress)
                                               {
                                                   ellipse.RadiusY -= progress * 10;
                                                   int compValue = (int)(16 + (progress * 112));
                                                   ellipse.FillColor = Color.FromArgb(
                                                       compValue,
                                                       compValue,
                                                       compValue);
                                               }) { Duration = ActDuration };
            IAnimation fullEllipseAnimation = new SequentialAnimation() { ellipseAnimation1, ellipseAnimation2, ellipseAnimation3, ellipseAnimation4 };
            scene.Animation = new ParallelAnimation() { fullLineAnimation, fullEllipseAnimation };

            // Playing the scene on the newly created APNG image
            ApngOptions createOptions = new ApngOptions
            {
                Source = new FileCreateSource(outputFilePath, false),
                ColorType = PngColorType.TruecolorWithAlpha,
            };

            using (ApngImage image = (ApngImage)Image.Create(createOptions, SceneWidth, SceneHeigth))
            {
                image.DefaultFrameTime = FrameDuration;
                scene.Play(image, TotalDuration);
                image.Save();
            }

            File.Delete(outputFilePath);

            Console.WriteLine("Finished example CreateAPNGAnimationFromGraphics");
        }
    }

    // The graphics scene
    public class Scene
    {
        private readonly List<IGraphicsObject> graphicsObjects = new List<IGraphicsObject>();

        public IAnimation Animation { get; set; }

        public void AddObject(IGraphicsObject graphicsObject)
        {
            this.graphicsObjects.Add(graphicsObject);
        }

        public void Play(ApngImage animationImage, uint totalDuration)
        {
            uint frameDuration = animationImage.DefaultFrameTime;
            uint numFrames = totalDuration / frameDuration;
            uint totalElapsed = 0;
            for (uint frameIndex = 0; frameIndex < numFrames; frameIndex++)
            {
                if (this.Animation != null)
                {
                    this.Animation.Update(totalElapsed);
                }

                ApngFrame frame = animationImage.PageCount == 0 || frameIndex > 0
                                      ? animationImage.AddFrame()
                                      : (ApngFrame)animationImage.Pages[0];
                Graphics graphics = new Graphics(frame);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                foreach (IGraphicsObject graphicsObject in this.graphicsObjects)
                {
                    graphicsObject.Render(graphics);
                }

                totalElapsed += frameDuration;
            }
        }
    }

    // The graphics object
    public interface IGraphicsObject
    {
        void Render(Graphics graphics);
    }

    // The line
    public class Line : IGraphicsObject
    {
        public PointF StartPoint { get; set; }

        public PointF EndPoint { get; set; }

        public float LineWidth { get; set; }

        public Color Color { get; set; }

        public void Render(Graphics graphics)
        {
            graphics.DrawLine(new Pen(this.Color, this.LineWidth), this.StartPoint, this.EndPoint);
        }
    }

    // The ellipse
    public class Ellipse : IGraphicsObject
    {
        public Color FillColor { get; set; }

        public PointF CenterPoint { get; set; }

        public float RadiusX { get; set; }

        public float RadiusY { get; set; }

        public void Render(Graphics graphics)
        {
            graphics.FillEllipse(
                new SolidBrush(this.FillColor),
                this.CenterPoint.X - this.RadiusX,
                this.CenterPoint.Y - this.RadiusY,
                this.RadiusX * 2,
                this.RadiusY * 2);
        }
    }

    // The animation
    public interface IAnimation
    {
        // The animation duration, in milliseconds.
        uint Duration { get; set; }

        void Update(uint elapsed);
    }

    // The linear animation
    public class LinearAnimation : IAnimation
    {
        private readonly AnimationProgressHandler progressHandler;

        public delegate void AnimationProgressHandler(float progress);

        public LinearAnimation(AnimationProgressHandler progressHandler)
        {
            if (progressHandler == null)
            {
                throw new System.ArgumentNullException("progressHandler");
            }

            this.progressHandler = progressHandler;
        }

        public uint Duration { get; set; }

        public void Update(uint elapsed)
        {
            if (elapsed <= this.Duration)
            {
                this.progressHandler.Invoke((float)elapsed / this.Duration);
            }
        }
    }

    // A simple delay between other animations
    public class Delay : IAnimation
    {
        public uint Duration { get; set; }

        public void Update(uint elapsed)
        {
            // No operation
        }
    }

    // The parallel animation processor
    public class ParallelAnimation : List<IAnimation>, IAnimation
    {
        public uint Duration
        {
            get
            {
                uint maxDuration = 0;
                foreach (IAnimation animation in this)
                {
                    if (maxDuration < animation.Duration)
                    {
                        maxDuration = animation.Duration;
                    }
                }

                return maxDuration;
            }

            set
            {
                throw new System.NotSupportedException();
            }
        }

        public void Update(uint elapsed)
        {
            foreach (IAnimation animation in this)
            {
                animation.Update(elapsed);
            }
        }
    }

    // The sequential animation processor
    public class SequentialAnimation : List<IAnimation>, IAnimation
    {
        public uint Duration
        {
            get
            {
                uint summDuration = 0;
                foreach (IAnimation animation in this)
                {
                    summDuration += animation.Duration;
                }

                return summDuration;
            }

            set
            {
                throw new System.NotSupportedException();
            }
        }

        public void Update(uint elapsed)
        {
            uint totalDuration = 0;
            foreach (IAnimation animation in this)
            {
                if (totalDuration > elapsed)
                {
                    break;
                }

                animation.Update(elapsed - totalDuration);
                totalDuration += animation.Duration;
            }
        }
    }
}