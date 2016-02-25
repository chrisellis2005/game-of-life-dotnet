using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace GameOfLife
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void FewerThanTwoDies()
        {

            var initalLevel = new List<List<int>> {
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 1, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 1, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0}
            };
            var expectedLevel = new List<List<int>> {
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0}
            };

            var _level = Level.LoadLevel(initalLevel);
            _level.Next();

            Assert.That(_level.LevelMap, Is.EqualTo(expectedLevel));
        }

        [Test()]
        public void TwoOrThreeNeighboursLivesOn()
        {

            var initalLevel = new List<List<int>> {
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 1, 0, 0, 0},
                new List<int>{0, 0, 0, 1, 1, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 1, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0}
            };
            var expectedLevel = new List<List<int>> {
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 1, 1, 0, 0, 0},
                new List<int>{0, 0, 0, 1, 1, 1, 0, 0},
                new List<int>{0, 0, 0, 1, 1, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0}
            };

            var _level = Level.LoadLevel(initalLevel);
            _level.Next();

            Assert.That(_level.LevelMap, Is.EqualTo(expectedLevel));
        }

        [Test()]
        public void MoreThanThreeDies()
        {

            var initalLevel = new List<List<int>> {
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 1, 0, 0, 0},
                new List<int>{0, 0, 0, 1, 1, 1, 0, 0},
                new List<int>{0, 0, 0, 0, 1, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0}
            };
            var expectedLevel = new List<List<int>> {
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 1, 1, 1, 0, 0},
                new List<int>{0, 0, 0, 1, 0, 1, 0, 0},
                new List<int>{0, 0, 0, 1, 1, 1, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0}
            };

            var _level = Level.LoadLevel(initalLevel);
            _level.Next();

            Assert.That(_level.LevelMap, Is.EqualTo(expectedLevel));
        }
   
        [Test()]
        public void DeadCellWithThreeNeighboursIsBorn()
        {

            var initalLevel = new List<List<int>> {
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 1, 0, 0, 0},
                new List<int>{0, 0, 0, 1, 1, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0}
            };
            var expectedLevel = new List<List<int>> {
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 1, 1, 0, 0, 0},
                new List<int>{0, 0, 0, 1, 1, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0}
            };

            var _level = Level.LoadLevel(initalLevel);
            _level.Next();

            Assert.That(_level.LevelMap, Is.EqualTo(expectedLevel));
        }
    }
}

