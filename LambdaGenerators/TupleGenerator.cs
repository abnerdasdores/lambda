﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaGenerators
{

    interface A<out T> { }
    class B<T> : A<T> { }
    class X
    {
        public void a()
        {
            A<Object> a = new B<Object>();
        }
    }

    class TupleGenerator
    {
        static void Main(string[] args)
        {
            var i = 23;
            var classes =
            Using("using LambdaInternal;\r\nusing Lambda;\r\n", () =>
                new List<string> {
                    Namespace("Lambda", () =>
                        new List<string> {
                            TupleCreator(i)
                        }.Concat(
                        Enumerable.Range(1, i).Select(x => Interface(x))
                        )
                    ),
                    Namespace("LambdaInternal", () =>
                        Enumerable.Range(1, i).Select(x =>
                            Class(x, () =>
                                string.Join("\r\n", 
                                    Fields(x)
                                ) + Constructor(x) +
                                GetterImpls(x)
                            )
                       ))
                }
            );

            var testes =
            Using("using FluentAssertions;\r\nusing NUnit.Framework;\r\nusing Lambda;\r\n", () =>
                new List<string>
                {
                    Namespace("LambdaTest", () =>
                        new List<string> 
                        {
                            MotherFixtures(i),
                            ChildrenFixtures(i),
                            TupleVarianceTests(i),
                            TupleAssignmentTests(i)
                        }    
                    )
                }
            );

            File.WriteAllText("../../../Lambda/Tuples.cs", classes);
            File.WriteAllText("../../../LambdaTest/TupleTests.cs", testes);

        }

        private static string GetterImpls(int k)
        {
            return string.Join("\r\n", Enumerable.Range(1, k).Select(i => "public T" + (i - 1) + " _" + i + "{ get { return __" + i + "; } }"));
        }

        private static string TupleAssignmentTests(int k)
        {
            return "[TestFixture] public class TupleAssignmentTest\r\n{\r\n" +
                    string.Join("\r\n", Enumerable.Range(1, k).Select(TupleAssignmentTestMethod)) +
                    "\r\n}\r\n";
        }

        private static string TupleAssignmentTestMethod(int k)
        {
            return "[Test] public void AssignmentMustWorkForRec" + k + "() {\r\n" +
                "var t = _.t(" + string.Join(", ", Enumerable.Range(0, k).Select(i => "new B" + i + "()")) + ");\r\n" +
                string.Join("\r\n", Enumerable.Range(0, k).Select(i => "A" + i + " a" + i + " = t._" + (i + 1) + ";")) +
                "\r\n}\r\n";
        }

        private static string MotherFixtures(int k)
        {
            return string.Join("\r\n", Enumerable.Range(0, k).Select(i => "class A" + i + " {}"));
        }

        private static string ChildrenFixtures(int k)
        {
            return string.Join("\r\n", Enumerable.Range(0, k).Select(i => "class B" + i + " : A" + i + " {}"));
        }

        private static string TupleVarianceTests(int k)
        {
            return "[TestFixture] public class TupleVarianceTest\r\n{\r\n" +
                        string.Join("\r\n", Enumerable.Range(1, k).Select(TupleVarianceTestMethod)) +
                   "\r\n}";
        }

        private static string TupleVarianceTestMethod(int k)
        {
            return "[Test] public void Rec" + k + "IsCovariant() {\r\n" +
                    "Rec<" + string.Join(", ", Enumerable.Range(0, k).Select(e => "A" + e)) + "> t = _.t(" +
                    string.Join(", ", Enumerable.Range(0, k).Select(e => "new B" + e + "()")) + ");" +
                "\r\n}\r\n"
                ;
        }

        private static string TupleCreator(int k)
        {
            return "public static class _ \r\n{\r\n" +
                string.Join("\r\n", Enumerable.Range(1, k).Select(TupleCreatorMethod)) +
                "\r\n}";
        }

        private static string TupleCreatorMethod(int k)
        {
            return
                "public static Rec" + TypeSignature(k) + " t" + TypeSignature(k) + "(" + Parameters(k) + ") {\r\n" +
                "return new RecInternal" + TypeSignature(k) + "(" + string.Join(", ", Enumerable.Range(1, k).Select(e => "_" + e)) + ");" +
                "\r\n}";
        }

        public static string Interface(int i)
        {
            return "public interface Rec" + TypeSignature(i, "out") + " {\r\n" +
                string.Join("\r\n", Getters(i)) + "\r\n" +            
            "}\r\n";
        }

        private static IEnumerable<string> Getters(int k)
        {
            return Enumerable.Range(1, k).Select(i => "T" + (i -1) + " _" + i + " { get; }");
        }

        public static string Constructor(int i)
        {
            return "\r\npublic RecInternal(" + Parameters(i) + ") {\r\n" +
                FieldAttribution(i) + "\r\n}";
        }

        public static string FieldAttribution(int i)
        {
            return string.Join("\r\n", Enumerable.Range(1, i).Select(k =>
                    "this.__" + k + " = _" + k + ";"
                ));
        }

        public static string Parameters(int k)
        {
            return string.Join(", ", Enumerable.Range(0, k).Select(i =>
                "T" + i + " _" + (i + 1)
                ));
        }

        public static IEnumerable<string> Fields(int k)
        {
            return Enumerable.Range(1, k).Select(i =>
                "public readonly T" + (i - 1) + " __" + i + ";"
            );
        }

        public static string Class(int i, Func<string> f)
        {
            return "public struct RecInternal" + TypeSignature(i) + " : Rec" + TypeSignature(i) + "\r\n{\r\n" + f() + "\r\n}\r\n";
        }

        public static string TypeSignature(int i, string prefix = "")
        {
            return "<" + prefix + " " + String.Join(", " + prefix + " ", Types(i).ToArray()) + ">";
        }

        public static IEnumerable<string> Types(int i)
        {
            return Enumerable.Range(0, i).Select(t => "T" + t);
        }

        public static string Namespace(string nameSpace, Func<IEnumerable<string>> f)
        {
            return "namespace " + nameSpace + "\r\n{\r\n" + String.Join("\r\n", f()) + "\r\n}\r\n";
        }

        public static string Using(string others, Func<IEnumerable<string>> f)
        {
            return "using System;\r\n" +
                   "using System.Collections.Generic;\r\n" +
                    "using System.Linq;\r\n" +
                    "using System.Text;\r\n" +
                    "using System.Threading.Tasks;\r\n" +
                    others +
                    "\r\n" +
                    string.Join("\r\n", f());
        }
    }

}
