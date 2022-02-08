using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asssignment02PD;
using NUnit.Framework;

namespace RectangleTest
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]  
        public void GetLength_Input01_OutputGetLength()
        {
            //Arrange
            int length = 1;
            int width = 2;
            Rectangle rect = new Rectangle(length, width);

            int expected = 1;
            //Act
            int actual = rect.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }     
        [Test]
        public void GetLength_Input50_OutputGetLength()
        {
            //Arrange
            int length = 50;
            int width = 2;
            Rectangle rect = new Rectangle(length, width);

            int expected = 50;

            //Act
            int actual = rect.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetLength_Input60_OutputGetLength()
        {
            //Arrange
            int length = 60;
            int width = 2;
            Rectangle rect = new Rectangle(length, width);

            int expected = 60;

            //Act
            int actual = rect.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetLength_InputNewLength50_OutputSetLength()
        {
            //Arrange
            int length = 100;
            int width = 2;
            int newLength = 50;
            Rectangle rect = new Rectangle(length, width);

            int expected = 50;

            //Act
            int actual = rect.SetLength(newLength);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SetLength_InputNewLength100_OutputSetLength()
        {
            //Arrange
            int length = 50;
            int width = 2;
            int newLength = 100;
            Rectangle rect = new Rectangle(length, width);

            int expected = 100;

            //Act
            int actual = rect.SetLength(newLength);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SetLength_InputNewLength150_OutputSetLength()
        {
            //Arrange
            int length = 50;
            int width = 2;
            int newLength = 150;
            Rectangle rect = new Rectangle(length, width);

            int expected = 150;

            //Act
            int actual = rect.SetLength(newLength);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetWidth_Input01_OutputGetWidth()
        {
            //Arrange
            int length = 1;
            int width = 1;
            Rectangle rect = new Rectangle(length, width);

            int expected = 1;

            //Act
            int actual = rect.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetWidth_Input70_OutputGetWidth()
        {
            //Arrange
            int length = 50;
            int width = 70;
            Rectangle rect = new Rectangle(length, width);

            int expected = 70;

            //Act
            int actual = rect.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetWidth_Input80_OutputGetWidth()
        {
            //Arrange
            int length = 50;
            int width = 80;
            Rectangle rect = new Rectangle(length, width);

            int expected = 80;

            //Act
            int actual = rect.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetWidth_InputNewWidth50_OutputSetWidth()
        {
            //Arrange
            int length = 20;
            int width = 150;
            int newWidth = 50;
            Rectangle rect = new Rectangle(length, width);

            int expected = 50;

            //Act
            int actual = rect.SetWidth(newWidth);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SetWidth_InputNewWidth100_OutputSetWidth()
        {
            //Arrange
            int length = 20;
            int width = 150;
            int newWidth = 100;
            Rectangle rect = new Rectangle(length, width);

            int expected = 100;

            //Act
            int actual = rect.SetWidth(newWidth);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SetWidth_InputNewWidth150_OutputSetWidth()
        {
            //Arrange
            int length = 20;
            int width = 50;
            int newWidth = 150;
            Rectangle rect = new Rectangle(length, width);

            int expected = 150;

            //Act
            int actual = rect.SetWidth(newWidth);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetPerimeter_Input01and01_OutputGetsPerimeter()
        {
            //Arrange
            int length = 1;
            int width = 1;
            Rectangle rect = new Rectangle(length, width);

            int expected = 4;

            //Act
            int actual = rect.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter_Input50and50_OutputGetsPerimeter()
        {
            //Arrange
            int length = 50;
            int width = 50;
            Rectangle rect = new Rectangle(length, width);

            int expected = 200;

            //Act
            int actual = rect.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter_Input150and150_OutputGetsPerimeter()
        {
            //Arrange
            int length = 150;
            int width = 150;
            Rectangle rect = new Rectangle(length, width);

            int expected = 600;

            //Act
            int actual = rect.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetArea_Input50and50_OutputGetsArea()
        {
            //Arrange
            int length = 50;
            int width = 50;
            Rectangle rect = new Rectangle(length, width);

            int expected = 2500;

            //Act
            int actual = rect.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea_Input100and100_OutputGetsArea()
        {
            //Arrange
            int length = 100;
            int width = 100;
            Rectangle rect = new Rectangle(length, width);

            int expected = 10000;

            //Act
            int actual = rect.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea_Input150and150_OutputGetsArea()
        {
            //Arrange
            int length = 150;
            int width = 150;
            Rectangle rect = new Rectangle(length, width);

            int expected = 22500;

            //Act
            int actual = rect.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
