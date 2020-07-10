using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 工厂方法模式
/// 通过面向对象编程的思想，把产品的的创建延迟到具体工厂中，从而解决了简单工厂模式中的问题，符合了对扩展开放，对修改封闭的原则
/// </summary>
namespace DesignMode.FaFactoryMethod
{
    /// <summary>
    /// 工厂父类
    /// </summary>
    public abstract class FactoryMethod
    {
        public abstract Product CreateProduct();
    }
    /// <summary>
    /// 具体A工厂
    /// </summary>
    public class FactoryA : FactoryMethod
    {
        public override Product CreateProduct()
        {
            Console.WriteLine("这是A工厂");
            return new ProductA();
        }
    }
    /// <summary>
    /// 具体B工厂
    /// </summary>
    public class FactoryB : FactoryMethod
    {
        public override Product CreateProduct()
        {
            Console.WriteLine("这是B工厂");
            return new ProductB();
        }
    }
    /// <summary>
    /// 产品基类
    /// </summary>
    public abstract class Product
    {
        /// <summary>
        /// 创建产品
        /// </summary>
        public abstract void CreateProduct();
    }
    /// <summary>
    /// 具体产品A
    /// </summary>
    public class ProductA : Product
    {
        public override void CreateProduct()
        {
            Console.WriteLine("产品A");
        }
    }
    public class ProductB : Product
    {
        public override void CreateProduct()
        {
            Console.WriteLine("产品B");
        }
    }
    public class Customer
    {
        static void Main(string[] args)
        {
            //FactoryA factoryA = new FactoryA();
            //FactoryB factoryB = new FactoryB();

            //Product a = factoryA.CreateProduct();
            //a.CreateProduct();

            //Product b = factoryB.CreateProduct();
            //b.CreateProduct();

        }
    }

}
