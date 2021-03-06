using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Lambda;

namespace LambdaTest
{
    class A0 { }
    class A1 { }
    class A2 { }
    class A3 { }
    class A4 { }
    class A5 { }
    class A6 { }
    class A7 { }
    class A8 { }
    class A9 { }
    class A10 { }
    class A11 { }
    class A12 { }
    class A13 { }
    class A14 { }
    class A15 { }
    class A16 { }
    class A17 { }
    class A18 { }
    class A19 { }
    class A20 { }
    class A21 { }
    class A22 { }
    class B0 : A0 { }
    class B1 : A1 { }
    class B2 : A2 { }
    class B3 : A3 { }
    class B4 : A4 { }
    class B5 : A5 { }
    class B6 : A6 { }
    class B7 : A7 { }
    class B8 : A8 { }
    class B9 : A9 { }
    class B10 : A10 { }
    class B11 : A11 { }
    class B12 : A12 { }
    class B13 : A13 { }
    class B14 : A14 { }
    class B15 : A15 { }
    class B16 : A16 { }
    class B17 : A17 { }
    class B18 : A18 { }
    class B19 : A19 { }
    class B20 : A20 { }
    class B21 : A21 { }
    class B22 : A22 { }
    [TestFixture]
    public class TupleVarianceTest
    {
        [Test]
        public void Rec1IsCovariant()
        {
            Rec<A0> t = _.t(new B0());
        }

        [Test]
        public void Rec2IsCovariant()
        {
            Rec<A0, A1> t = _.t(new B0(), new B1());
        }

        [Test]
        public void Rec3IsCovariant()
        {
            Rec<A0, A1, A2> t = _.t(new B0(), new B1(), new B2());
        }

        [Test]
        public void Rec4IsCovariant()
        {
            Rec<A0, A1, A2, A3> t = _.t(new B0(), new B1(), new B2(), new B3());
        }

        [Test]
        public void Rec5IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4());
        }

        [Test]
        public void Rec6IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5());
        }

        [Test]
        public void Rec7IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6());
        }

        [Test]
        public void Rec8IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7());
        }

        [Test]
        public void Rec9IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8());
        }

        [Test]
        public void Rec10IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9());
        }

        [Test]
        public void Rec11IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10());
        }

        [Test]
        public void Rec12IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11());
        }

        [Test]
        public void Rec13IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12());
        }

        [Test]
        public void Rec14IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13());
        }

        [Test]
        public void Rec15IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14());
        }

        [Test]
        public void Rec16IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15());
        }

        [Test]
        public void Rec17IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16());
        }

        [Test]
        public void Rec18IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16(), new B17());
        }

        [Test]
        public void Rec19IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17, A18> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16(), new B17(), new B18());
        }

        [Test]
        public void Rec20IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17, A18, A19> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16(), new B17(), new B18(), new B19());
        }

        [Test]
        public void Rec21IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17, A18, A19, A20> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16(), new B17(), new B18(), new B19(), new B20());
        }

        [Test]
        public void Rec22IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17, A18, A19, A20, A21> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16(), new B17(), new B18(), new B19(), new B20(), new B21());
        }

        [Test]
        public void Rec23IsCovariant()
        {
            Rec<A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17, A18, A19, A20, A21, A22> t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16(), new B17(), new B18(), new B19(), new B20(), new B21(), new B22());
        }

    }
    [TestFixture]
    public class TupleAssignmentTest
    {
        [Test]
        public void AssignmentMustWorkForRec1()
        {
            var t = _.t(new B0());
            A0 a0 = t._1;
        }

        [Test]
        public void AssignmentMustWorkForRec2()
        {
            var t = _.t(new B0(), new B1());
            A0 a0 = t._1;
            A1 a1 = t._2;
        }

        [Test]
        public void AssignmentMustWorkForRec3()
        {
            var t = _.t(new B0(), new B1(), new B2());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
        }

        [Test]
        public void AssignmentMustWorkForRec4()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
        }

        [Test]
        public void AssignmentMustWorkForRec5()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
        }

        [Test]
        public void AssignmentMustWorkForRec6()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
        }

        [Test]
        public void AssignmentMustWorkForRec7()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
        }

        [Test]
        public void AssignmentMustWorkForRec8()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
        }

        [Test]
        public void AssignmentMustWorkForRec9()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
        }

        [Test]
        public void AssignmentMustWorkForRec10()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
        }

        [Test]
        public void AssignmentMustWorkForRec11()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
            A10 a10 = t._11;
        }

        [Test]
        public void AssignmentMustWorkForRec12()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
            A10 a10 = t._11;
            A11 a11 = t._12;
        }

        [Test]
        public void AssignmentMustWorkForRec13()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
            A10 a10 = t._11;
            A11 a11 = t._12;
            A12 a12 = t._13;
        }

        [Test]
        public void AssignmentMustWorkForRec14()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
            A10 a10 = t._11;
            A11 a11 = t._12;
            A12 a12 = t._13;
            A13 a13 = t._14;
        }

        [Test]
        public void AssignmentMustWorkForRec15()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
            A10 a10 = t._11;
            A11 a11 = t._12;
            A12 a12 = t._13;
            A13 a13 = t._14;
            A14 a14 = t._15;
        }

        [Test]
        public void AssignmentMustWorkForRec16()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
            A10 a10 = t._11;
            A11 a11 = t._12;
            A12 a12 = t._13;
            A13 a13 = t._14;
            A14 a14 = t._15;
            A15 a15 = t._16;
        }

        [Test]
        public void AssignmentMustWorkForRec17()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
            A10 a10 = t._11;
            A11 a11 = t._12;
            A12 a12 = t._13;
            A13 a13 = t._14;
            A14 a14 = t._15;
            A15 a15 = t._16;
            A16 a16 = t._17;
        }

        [Test]
        public void AssignmentMustWorkForRec18()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16(), new B17());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
            A10 a10 = t._11;
            A11 a11 = t._12;
            A12 a12 = t._13;
            A13 a13 = t._14;
            A14 a14 = t._15;
            A15 a15 = t._16;
            A16 a16 = t._17;
            A17 a17 = t._18;
        }

        [Test]
        public void AssignmentMustWorkForRec19()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16(), new B17(), new B18());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
            A10 a10 = t._11;
            A11 a11 = t._12;
            A12 a12 = t._13;
            A13 a13 = t._14;
            A14 a14 = t._15;
            A15 a15 = t._16;
            A16 a16 = t._17;
            A17 a17 = t._18;
            A18 a18 = t._19;
        }

        [Test]
        public void AssignmentMustWorkForRec20()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16(), new B17(), new B18(), new B19());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
            A10 a10 = t._11;
            A11 a11 = t._12;
            A12 a12 = t._13;
            A13 a13 = t._14;
            A14 a14 = t._15;
            A15 a15 = t._16;
            A16 a16 = t._17;
            A17 a17 = t._18;
            A18 a18 = t._19;
            A19 a19 = t._20;
        }

        [Test]
        public void AssignmentMustWorkForRec21()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16(), new B17(), new B18(), new B19(), new B20());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
            A10 a10 = t._11;
            A11 a11 = t._12;
            A12 a12 = t._13;
            A13 a13 = t._14;
            A14 a14 = t._15;
            A15 a15 = t._16;
            A16 a16 = t._17;
            A17 a17 = t._18;
            A18 a18 = t._19;
            A19 a19 = t._20;
            A20 a20 = t._21;
        }

        [Test]
        public void AssignmentMustWorkForRec22()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16(), new B17(), new B18(), new B19(), new B20(), new B21());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
            A10 a10 = t._11;
            A11 a11 = t._12;
            A12 a12 = t._13;
            A13 a13 = t._14;
            A14 a14 = t._15;
            A15 a15 = t._16;
            A16 a16 = t._17;
            A17 a17 = t._18;
            A18 a18 = t._19;
            A19 a19 = t._20;
            A20 a20 = t._21;
            A21 a21 = t._22;
        }

        [Test]
        public void AssignmentMustWorkForRec23()
        {
            var t = _.t(new B0(), new B1(), new B2(), new B3(), new B4(), new B5(), new B6(), new B7(), new B8(), new B9(), new B10(), new B11(), new B12(), new B13(), new B14(), new B15(), new B16(), new B17(), new B18(), new B19(), new B20(), new B21(), new B22());
            A0 a0 = t._1;
            A1 a1 = t._2;
            A2 a2 = t._3;
            A3 a3 = t._4;
            A4 a4 = t._5;
            A5 a5 = t._6;
            A6 a6 = t._7;
            A7 a7 = t._8;
            A8 a8 = t._9;
            A9 a9 = t._10;
            A10 a10 = t._11;
            A11 a11 = t._12;
            A12 a12 = t._13;
            A13 a13 = t._14;
            A14 a14 = t._15;
            A15 a15 = t._16;
            A16 a16 = t._17;
            A17 a17 = t._18;
            A18 a18 = t._19;
            A19 a19 = t._20;
            A20 a20 = t._21;
            A21 a21 = t._22;
            A22 a22 = t._23;
        }

    }

}
