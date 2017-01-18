﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    public class A
    {
        public void NormalFun() { Console.WriteLine("A NormalFun()"); }
        public virtual void VirtualFun() { Console.WriteLine("A VirtualFun()"); VirtualFun2(); }
        public virtual void VirtualFun2() { Console.WriteLine("A VirtualFun2()"); }
    }

    public class B : A
    {
        public void NormalFun() { Console.WriteLine("B NormalFun()"); }
        public virtual void VirtualFun() { Console.WriteLine("B VirtualFun()"); VirtualFun2(); }
        public override void VirtualFun2() { Console.WriteLine("B VirtualFun2()"); }
    }

    public class C : B
    {
        public override void VirtualFun() { Console.WriteLine("C VirtualFun()"); }
    }

    public class D : C
    {
        public void NormalFun() { Console.WriteLine("D NormalFun()"); }
        public override void VirtualFun() { Console.WriteLine("D VirtualFun()"); }
        public override void VirtualFun2() { Console.WriteLine("D VirtualFun2()"); }
    }

    public abstract class E : D
    {
        public virtual void VirtualFun() { Console.WriteLine("E VirtualFun()"); }
        public abstract void VirtualFun2();
    }

    public class F : E
    {
        public override void VirtualFun() { Console.WriteLine("F VirtualFun()"); }
        public override void VirtualFun2() { Console.WriteLine("F VirtualFun2()"); }
    }

    public abstract class G : F
    {
        public virtual void VirtualFun() { Console.WriteLine("G VirtualFun()"); }
        public abstract void VirtualFun2();
    }

    public class H : G
    {
        public void NormalFun() { Console.WriteLine("H NormalFun()"); }
        public override void VirtualFun() { Console.WriteLine("H VirtualFun()"); }
        public override void VirtualFun2() { Console.WriteLine("H VirtualFun2()"); }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tu jest wynik:");
            //tu wkleić kod
            Console.ReadKey();
 
        }
    }
}
